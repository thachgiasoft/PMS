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
	/// This class is the base class for any <see cref="KetQuaThanhToanThuLaoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KetQuaThanhToanThuLaoProviderBaseCore : EntityProviderBase<PMS.Entities.KetQuaThanhToanThuLao, PMS.Entities.KetQuaThanhToanThuLaoKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KetQuaThanhToanThuLaoKey key)
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
		public override PMS.Entities.KetQuaThanhToanThuLao Get(TransactionManager transactionManager, PMS.Entities.KetQuaThanhToanThuLaoKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KetQuaThanhToanThuLao index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaThanhToanThuLao"/> class.</returns>
		public PMS.Entities.KetQuaThanhToanThuLao GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KetQuaThanhToanThuLao index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaThanhToanThuLao"/> class.</returns>
		public PMS.Entities.KetQuaThanhToanThuLao GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KetQuaThanhToanThuLao index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaThanhToanThuLao"/> class.</returns>
		public PMS.Entities.KetQuaThanhToanThuLao GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KetQuaThanhToanThuLao index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaThanhToanThuLao"/> class.</returns>
		public PMS.Entities.KetQuaThanhToanThuLao GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KetQuaThanhToanThuLao index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaThanhToanThuLao"/> class.</returns>
		public PMS.Entities.KetQuaThanhToanThuLao GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KetQuaThanhToanThuLao index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaThanhToanThuLao"/> class.</returns>
		public abstract PMS.Entities.KetQuaThanhToanThuLao GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_KetQuaThanhToanThuLao_BangKeGioGiangTheoNam 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangKeGioGiangTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangKeGioGiangTheoNam(System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return BangKeGioGiangTheoNam(null, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangKeGioGiangTheoNam' stored procedure. 
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
		public IDataReader BangKeGioGiangTheoNam(int start, int pageLength, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return BangKeGioGiangTheoNam(null, start, pageLength , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangKeGioGiangTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangKeGioGiangTheoNam(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return BangKeGioGiangTheoNam(transactionManager, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangKeGioGiangTheoNam' stored procedure. 
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
		public abstract IDataReader BangKeGioGiangTheoNam(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_HuyChotThuLao 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_HuyChotThuLao' stored procedure. 
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
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_HuyChotThuLao' stored procedure. 
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
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_HuyChotThuLao' stored procedure. 
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
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_HuyChotThuLao' stored procedure. 
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
		
		#region cust_KetQuaThanhToanThuLao_GetThuLaoTheoNam_web 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetThuLaoTheoNam_web' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maQuanLyGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThuLaoTheoNam_web(System.String namHoc, System.String maQuanLyGiangVien)
		{
			return GetThuLaoTheoNam_web(null, 0, int.MaxValue , namHoc, maQuanLyGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetThuLaoTheoNam_web' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maQuanLyGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThuLaoTheoNam_web(int start, int pageLength, System.String namHoc, System.String maQuanLyGiangVien)
		{
			return GetThuLaoTheoNam_web(null, start, pageLength , namHoc, maQuanLyGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetThuLaoTheoNam_web' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maQuanLyGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThuLaoTheoNam_web(TransactionManager transactionManager, System.String namHoc, System.String maQuanLyGiangVien)
		{
			return GetThuLaoTheoNam_web(transactionManager, 0, int.MaxValue , namHoc, maQuanLyGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetThuLaoTheoNam_web' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maQuanLyGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetThuLaoTheoNam_web(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String maQuanLyGiangVien);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_TongHopKetQuaThanhToan 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_TongHopKetQuaThanhToan' stored procedure. 
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
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_TongHopKetQuaThanhToan' stored procedure. 
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
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_TongHopKetQuaThanhToan' stored procedure. 
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
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_TongHopKetQuaThanhToan' stored procedure. 
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
		
		#region cust_KetQuaThanhToanThuLao_LuuChiTra 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_LuuChiTra' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuChiTra(System.String xmlData, ref System.Int32 reVal)
		{
			 LuuChiTra(null, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_LuuChiTra' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuChiTra(int start, int pageLength, System.String xmlData, ref System.Int32 reVal)
		{
			 LuuChiTra(null, start, pageLength , xmlData, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_LuuChiTra' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuChiTra(TransactionManager transactionManager, System.String xmlData, ref System.Int32 reVal)
		{
			 LuuChiTra(transactionManager, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_LuuChiTra' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LuuChiTra(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_BangTongHopGioGiangCacKhoaTheoNam 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangTongHopGioGiangCacKhoaTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangTongHopGioGiangCacKhoaTheoNam(System.String namHoc, System.String donVi, System.String loaiGiangVien, System.String loaiHinhDaoTao)
		{
			return BangTongHopGioGiangCacKhoaTheoNam(null, 0, int.MaxValue , namHoc, donVi, loaiGiangVien, loaiHinhDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangTongHopGioGiangCacKhoaTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangTongHopGioGiangCacKhoaTheoNam(int start, int pageLength, System.String namHoc, System.String donVi, System.String loaiGiangVien, System.String loaiHinhDaoTao)
		{
			return BangTongHopGioGiangCacKhoaTheoNam(null, start, pageLength , namHoc, donVi, loaiGiangVien, loaiHinhDaoTao);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangTongHopGioGiangCacKhoaTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangTongHopGioGiangCacKhoaTheoNam(TransactionManager transactionManager, System.String namHoc, System.String donVi, System.String loaiGiangVien, System.String loaiHinhDaoTao)
		{
			return BangTongHopGioGiangCacKhoaTheoNam(transactionManager, 0, int.MaxValue , namHoc, donVi, loaiGiangVien, loaiHinhDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangTongHopGioGiangCacKhoaTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader BangTongHopGioGiangCacKhoaTheoNam(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String donVi, System.String loaiGiangVien, System.String loaiHinhDaoTao);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ChotThanhToanKhoaDonVi 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ChotThanhToanKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ChotThanhToanKhoaDonVi(System.String namHoc, System.String hocKy, System.String khoaDonVi, System.Int32 lanChot, ref System.Int32 reVal)
		{
			 ChotThanhToanKhoaDonVi(null, 0, int.MaxValue , namHoc, hocKy, khoaDonVi, lanChot, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ChotThanhToanKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ChotThanhToanKhoaDonVi(int start, int pageLength, System.String namHoc, System.String hocKy, System.String khoaDonVi, System.Int32 lanChot, ref System.Int32 reVal)
		{
			 ChotThanhToanKhoaDonVi(null, start, pageLength , namHoc, hocKy, khoaDonVi, lanChot, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ChotThanhToanKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ChotThanhToanKhoaDonVi(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String khoaDonVi, System.Int32 lanChot, ref System.Int32 reVal)
		{
			 ChotThanhToanKhoaDonVi(transactionManager, 0, int.MaxValue , namHoc, hocKy, khoaDonVi, lanChot, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ChotThanhToanKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void ChotThanhToanKhoaDonVi(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String khoaDonVi, System.Int32 lanChot, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_GetThuLaoTheoNam_Reportweb 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetThuLaoTheoNam_Reportweb' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maQuanLyGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetThuLaoTheoNam_Reportweb(System.String namHoc, System.String maQuanLyGiangVien)
		{
			 GetThuLaoTheoNam_Reportweb(null, 0, int.MaxValue , namHoc, maQuanLyGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetThuLaoTheoNam_Reportweb' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maQuanLyGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetThuLaoTheoNam_Reportweb(int start, int pageLength, System.String namHoc, System.String maQuanLyGiangVien)
		{
			 GetThuLaoTheoNam_Reportweb(null, start, pageLength , namHoc, maQuanLyGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetThuLaoTheoNam_Reportweb' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maQuanLyGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetThuLaoTheoNam_Reportweb(TransactionManager transactionManager, System.String namHoc, System.String maQuanLyGiangVien)
		{
			 GetThuLaoTheoNam_Reportweb(transactionManager, 0, int.MaxValue , namHoc, maQuanLyGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetThuLaoTheoNam_Reportweb' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maQuanLyGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetThuLaoTheoNam_Reportweb(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String maQuanLyGiangVien);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_GetSoLanChot 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoLanChot' stored procedure. 
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
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoLanChot' stored procedure. 
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
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoLanChot' stored procedure. 
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
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoLanChot' stored procedure. 
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
		
		#region cust_KetQuaThanhToanThuLao_LuuThueTncn 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_LuuThueTncn' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="loaiThue"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuThueTncn(System.String xmlData, System.String namHoc, System.String hocKy, System.Int32 lanChot, System.String loaiThue, ref System.Int32 reVal)
		{
			 LuuThueTncn(null, 0, int.MaxValue , xmlData, namHoc, hocKy, lanChot, loaiThue, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_LuuThueTncn' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="loaiThue"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuThueTncn(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, System.Int32 lanChot, System.String loaiThue, ref System.Int32 reVal)
		{
			 LuuThueTncn(null, start, pageLength , xmlData, namHoc, hocKy, lanChot, loaiThue, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_LuuThueTncn' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="loaiThue"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuThueTncn(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, System.Int32 lanChot, System.String loaiThue, ref System.Int32 reVal)
		{
			 LuuThueTncn(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, lanChot, loaiThue, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_LuuThueTncn' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="loaiThue"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LuuThueTncn(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, System.Int32 lanChot, System.String loaiThue, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_GetByMaGiangVienNamHocHocKyLanChot 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetByMaGiangVienNamHocHocKyLanChot' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaGiangVienNamHocHocKyLanChot(System.Int32 maGiangVien, System.String namHoc, System.String hocKy, System.Int32 lanChot)
		{
			return GetByMaGiangVienNamHocHocKyLanChot(null, 0, int.MaxValue , maGiangVien, namHoc, hocKy, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetByMaGiangVienNamHocHocKyLanChot' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaGiangVienNamHocHocKyLanChot(int start, int pageLength, System.Int32 maGiangVien, System.String namHoc, System.String hocKy, System.Int32 lanChot)
		{
			return GetByMaGiangVienNamHocHocKyLanChot(null, start, pageLength , maGiangVien, namHoc, hocKy, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetByMaGiangVienNamHocHocKyLanChot' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaGiangVienNamHocHocKyLanChot(TransactionManager transactionManager, System.Int32 maGiangVien, System.String namHoc, System.String hocKy, System.Int32 lanChot)
		{
			return GetByMaGiangVienNamHocHocKyLanChot(transactionManager, 0, int.MaxValue , maGiangVien, namHoc, hocKy, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetByMaGiangVienNamHocHocKyLanChot' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByMaGiangVienNamHocHocKyLanChot(TransactionManager transactionManager, int start, int pageLength , System.Int32 maGiangVien, System.String namHoc, System.String hocKy, System.Int32 lanChot);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_GetDataVuotGioBoSung_Bk 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetDataVuotGioBoSung_Bk' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDataVuotGioBoSung_Bk(System.String namHoc, System.Int32 lanChotHk01, System.Int32 lanChotHk02, System.String khoaDonVi)
		{
			return GetDataVuotGioBoSung_Bk(null, 0, int.MaxValue , namHoc, lanChotHk01, lanChotHk02, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetDataVuotGioBoSung_Bk' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDataVuotGioBoSung_Bk(int start, int pageLength, System.String namHoc, System.Int32 lanChotHk01, System.Int32 lanChotHk02, System.String khoaDonVi)
		{
			return GetDataVuotGioBoSung_Bk(null, start, pageLength , namHoc, lanChotHk01, lanChotHk02, khoaDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetDataVuotGioBoSung_Bk' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDataVuotGioBoSung_Bk(TransactionManager transactionManager, System.String namHoc, System.Int32 lanChotHk01, System.Int32 lanChotHk02, System.String khoaDonVi)
		{
			return GetDataVuotGioBoSung_Bk(transactionManager, 0, int.MaxValue , namHoc, lanChotHk01, lanChotHk02, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetDataVuotGioBoSung_Bk' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetDataVuotGioBoSung_Bk(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.Int32 lanChotHk01, System.Int32 lanChotHk02, System.String khoaDonVi);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ChotThanhToan2 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ChotThanhToan2' stored procedure. 
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
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ChotThanhToan2' stored procedure. 
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
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ChotThanhToan2' stored procedure. 
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
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ChotThanhToan2' stored procedure. 
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
		
		#region cust_KetQuaThanhToanThuLao_BangKeThanhToanTheoDot 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangKeThanhToanTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangKeThanhToanTheoDot(System.String namHoc, System.String hocKy, System.String donVi, System.String dotThanhToan, System.String loaiGiangVien)
		{
			return BangKeThanhToanTheoDot(null, 0, int.MaxValue , namHoc, hocKy, donVi, dotThanhToan, loaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangKeThanhToanTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangKeThanhToanTheoDot(int start, int pageLength, System.String namHoc, System.String hocKy, System.String donVi, System.String dotThanhToan, System.String loaiGiangVien)
		{
			return BangKeThanhToanTheoDot(null, start, pageLength , namHoc, hocKy, donVi, dotThanhToan, loaiGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangKeThanhToanTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangKeThanhToanTheoDot(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String donVi, System.String dotThanhToan, System.String loaiGiangVien)
		{
			return BangKeThanhToanTheoDot(transactionManager, 0, int.MaxValue , namHoc, hocKy, donVi, dotThanhToan, loaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangKeThanhToanTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader BangKeThanhToanTheoDot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String donVi, System.String dotThanhToan, System.String loaiGiangVien);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeTienGiangLyThuyetGiangVienThinhGiangCtim 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangLyThuyetGiangVienThinhGiangCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangLyThuyetGiangVienThinhGiangCtim(System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangLyThuyetGiangVienThinhGiangCtim(null, 0, int.MaxValue , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangLyThuyetGiangVienThinhGiangCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangLyThuyetGiangVienThinhGiangCtim(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangLyThuyetGiangVienThinhGiangCtim(null, start, pageLength , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangLyThuyetGiangVienThinhGiangCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangLyThuyetGiangVienThinhGiangCtim(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangLyThuyetGiangVienThinhGiangCtim(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangLyThuyetGiangVienThinhGiangCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeTienGiangLyThuyetGiangVienThinhGiangCtim(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_GetBangNamVuotGioBoSung 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetBangNamVuotGioBoSung' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetBangNamVuotGioBoSung(System.String namHoc, System.Int32 lanChotHk01, System.Int32 lanChotHk02, System.String khoaDonVi)
		{
			return GetBangNamVuotGioBoSung(null, 0, int.MaxValue , namHoc, lanChotHk01, lanChotHk02, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetBangNamVuotGioBoSung' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetBangNamVuotGioBoSung(int start, int pageLength, System.String namHoc, System.Int32 lanChotHk01, System.Int32 lanChotHk02, System.String khoaDonVi)
		{
			return GetBangNamVuotGioBoSung(null, start, pageLength , namHoc, lanChotHk01, lanChotHk02, khoaDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetBangNamVuotGioBoSung' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetBangNamVuotGioBoSung(TransactionManager transactionManager, System.String namHoc, System.Int32 lanChotHk01, System.Int32 lanChotHk02, System.String khoaDonVi)
		{
			return GetBangNamVuotGioBoSung(transactionManager, 0, int.MaxValue , namHoc, lanChotHk01, lanChotHk02, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetBangNamVuotGioBoSung' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetBangNamVuotGioBoSung(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.Int32 lanChotHk01, System.Int32 lanChotHk02, System.String khoaDonVi);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_GiangVienXemTrenWeb_Uel 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GiangVienXemTrenWeb_Uel' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GiangVienXemTrenWeb_Uel(System.String namHoc, System.String hocKy, System.String maGiangVien)
		{
			 GiangVienXemTrenWeb_Uel(null, 0, int.MaxValue , namHoc, hocKy, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GiangVienXemTrenWeb_Uel' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GiangVienXemTrenWeb_Uel(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maGiangVien)
		{
			 GiangVienXemTrenWeb_Uel(null, start, pageLength , namHoc, hocKy, maGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GiangVienXemTrenWeb_Uel' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GiangVienXemTrenWeb_Uel(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maGiangVien)
		{
			 GiangVienXemTrenWeb_Uel(transactionManager, 0, int.MaxValue , namHoc, hocKy, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GiangVienXemTrenWeb_Uel' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GiangVienXemTrenWeb_Uel(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maGiangVien);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_LuuGiangVienDaChiTra 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_LuuGiangVienDaChiTra' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuGiangVienDaChiTra(System.String xmlData, ref System.Int32 reVal)
		{
			 LuuGiangVienDaChiTra(null, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_LuuGiangVienDaChiTra' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuGiangVienDaChiTra(int start, int pageLength, System.String xmlData, ref System.Int32 reVal)
		{
			 LuuGiangVienDaChiTra(null, start, pageLength , xmlData, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_LuuGiangVienDaChiTra' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuGiangVienDaChiTra(TransactionManager transactionManager, System.String xmlData, ref System.Int32 reVal)
		{
			 LuuGiangVienDaChiTra(transactionManager, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_LuuGiangVienDaChiTra' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LuuGiangVienDaChiTra(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_GetNhiemVuNghienCuuKhoaHoc 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetNhiemVuNghienCuuKhoaHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetNhiemVuNghienCuuKhoaHoc(System.String namHoc, System.String hocKy, System.Int32 maGiangVien)
		{
			return GetNhiemVuNghienCuuKhoaHoc(null, 0, int.MaxValue , namHoc, hocKy, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetNhiemVuNghienCuuKhoaHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetNhiemVuNghienCuuKhoaHoc(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 maGiangVien)
		{
			return GetNhiemVuNghienCuuKhoaHoc(null, start, pageLength , namHoc, hocKy, maGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetNhiemVuNghienCuuKhoaHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetNhiemVuNghienCuuKhoaHoc(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 maGiangVien)
		{
			return GetNhiemVuNghienCuuKhoaHoc(transactionManager, 0, int.MaxValue , namHoc, hocKy, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetNhiemVuNghienCuuKhoaHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetNhiemVuNghienCuuKhoaHoc(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 maGiangVien);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_GetDataVuotGioBoSung 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetDataVuotGioBoSung' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDataVuotGioBoSung(System.String namHoc, System.Int32 lanChotHk01, System.Int32 lanChotHk02, System.String khoaDonVi)
		{
			return GetDataVuotGioBoSung(null, 0, int.MaxValue , namHoc, lanChotHk01, lanChotHk02, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetDataVuotGioBoSung' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDataVuotGioBoSung(int start, int pageLength, System.String namHoc, System.Int32 lanChotHk01, System.Int32 lanChotHk02, System.String khoaDonVi)
		{
			return GetDataVuotGioBoSung(null, start, pageLength , namHoc, lanChotHk01, lanChotHk02, khoaDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetDataVuotGioBoSung' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDataVuotGioBoSung(TransactionManager transactionManager, System.String namHoc, System.Int32 lanChotHk01, System.Int32 lanChotHk02, System.String khoaDonVi)
		{
			return GetDataVuotGioBoSung(transactionManager, 0, int.MaxValue , namHoc, lanChotHk01, lanChotHk02, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetDataVuotGioBoSung' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetDataVuotGioBoSung(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.Int32 lanChotHk01, System.Int32 lanChotHk02, System.String khoaDonVi);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_BangThanhToanGioGiangCoHuuCaNam 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangThanhToanGioGiangCoHuuCaNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangThanhToanGioGiangCoHuuCaNam(System.String namHoc, System.String donVi, System.String loaiGiangVien)
		{
			return BangThanhToanGioGiangCoHuuCaNam(null, 0, int.MaxValue , namHoc, donVi, loaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangThanhToanGioGiangCoHuuCaNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangThanhToanGioGiangCoHuuCaNam(int start, int pageLength, System.String namHoc, System.String donVi, System.String loaiGiangVien)
		{
			return BangThanhToanGioGiangCoHuuCaNam(null, start, pageLength , namHoc, donVi, loaiGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangThanhToanGioGiangCoHuuCaNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangThanhToanGioGiangCoHuuCaNam(TransactionManager transactionManager, System.String namHoc, System.String donVi, System.String loaiGiangVien)
		{
			return BangThanhToanGioGiangCoHuuCaNam(transactionManager, 0, int.MaxValue , namHoc, donVi, loaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangThanhToanGioGiangCoHuuCaNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader BangThanhToanGioGiangCoHuuCaNam(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String donVi, System.String loaiGiangVien);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_GetThongTinGiangVienTheoNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetThongTinGiangVienTheoNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThongTinGiangVienTheoNamHocHocKy(System.String namHoc, System.String hocKy, System.Int32 maGiangVien)
		{
			return GetThongTinGiangVienTheoNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetThongTinGiangVienTheoNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThongTinGiangVienTheoNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 maGiangVien)
		{
			return GetThongTinGiangVienTheoNamHocHocKy(null, start, pageLength , namHoc, hocKy, maGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetThongTinGiangVienTheoNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThongTinGiangVienTheoNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 maGiangVien)
		{
			return GetThongTinGiangVienTheoNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetThongTinGiangVienTheoNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetThongTinGiangVienTheoNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 maGiangVien);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThanhToanTienGiangClc 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThanhToanTienGiangClc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThanhToanTienGiangClc(System.String namHoc, System.String hocKy, System.String khoaBoMon, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return ThanhToanTienGiangClc(null, 0, int.MaxValue , namHoc, hocKy, khoaBoMon, loaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThanhToanTienGiangClc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThanhToanTienGiangClc(int start, int pageLength, System.String namHoc, System.String hocKy, System.String khoaBoMon, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return ThanhToanTienGiangClc(null, start, pageLength , namHoc, hocKy, khoaBoMon, loaiGiangVien, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThanhToanTienGiangClc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThanhToanTienGiangClc(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String khoaBoMon, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return ThanhToanTienGiangClc(transactionManager, 0, int.MaxValue , namHoc, hocKy, khoaBoMon, loaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThanhToanTienGiangClc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThanhToanTienGiangClc(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String khoaBoMon, System.String loaiGiangVien, System.Int32 lanChot);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_DanhSachGiangVienDuocSuDungTroGiang 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_DanhSachGiangVienDuocSuDungTroGiang' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader DanhSachGiangVienDuocSuDungTroGiang(System.String namHoc, System.String hocKy)
		{
			return DanhSachGiangVienDuocSuDungTroGiang(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_DanhSachGiangVienDuocSuDungTroGiang' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader DanhSachGiangVienDuocSuDungTroGiang(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return DanhSachGiangVienDuocSuDungTroGiang(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_DanhSachGiangVienDuocSuDungTroGiang' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader DanhSachGiangVienDuocSuDungTroGiang(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return DanhSachGiangVienDuocSuDungTroGiang(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_DanhSachGiangVienDuocSuDungTroGiang' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader DanhSachGiangVienDuocSuDungTroGiang(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThanhToanThuLaoGiangDayTheoKhoa 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThanhToanThuLaoGiangDayTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThanhToanThuLaoGiangDayTheoKhoa(System.String maDonVi, System.String maLoaiGiangVien, System.String namHoc, System.String hocKy, System.Int32 lanChot)
		{
			return ThanhToanThuLaoGiangDayTheoKhoa(null, 0, int.MaxValue , maDonVi, maLoaiGiangVien, namHoc, hocKy, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThanhToanThuLaoGiangDayTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThanhToanThuLaoGiangDayTheoKhoa(int start, int pageLength, System.String maDonVi, System.String maLoaiGiangVien, System.String namHoc, System.String hocKy, System.Int32 lanChot)
		{
			return ThanhToanThuLaoGiangDayTheoKhoa(null, start, pageLength , maDonVi, maLoaiGiangVien, namHoc, hocKy, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThanhToanThuLaoGiangDayTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThanhToanThuLaoGiangDayTheoKhoa(TransactionManager transactionManager, System.String maDonVi, System.String maLoaiGiangVien, System.String namHoc, System.String hocKy, System.Int32 lanChot)
		{
			return ThanhToanThuLaoGiangDayTheoKhoa(transactionManager, 0, int.MaxValue , maDonVi, maLoaiGiangVien, namHoc, hocKy, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThanhToanThuLaoGiangDayTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThanhToanThuLaoGiangDayTheoKhoa(TransactionManager transactionManager, int start, int pageLength , System.String maDonVi, System.String maLoaiGiangVien, System.String namHoc, System.String hocKy, System.Int32 lanChot);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_GetSoTietRaDe 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoTietRaDe' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaToChuc"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanThi"> A <c>System.Int32</c> instance.</param>
		/// <param name="heDaoTao"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetSoTietRaDe(System.String maQuanLy, System.String maKhoaToChuc, System.String namHoc, System.String hocKy, System.Int32 lanThi, System.String heDaoTao)
		{
			return GetSoTietRaDe(null, 0, int.MaxValue , maQuanLy, maKhoaToChuc, namHoc, hocKy, lanThi, heDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoTietRaDe' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaToChuc"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanThi"> A <c>System.Int32</c> instance.</param>
		/// <param name="heDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetSoTietRaDe(int start, int pageLength, System.String maQuanLy, System.String maKhoaToChuc, System.String namHoc, System.String hocKy, System.Int32 lanThi, System.String heDaoTao)
		{
			return GetSoTietRaDe(null, start, pageLength , maQuanLy, maKhoaToChuc, namHoc, hocKy, lanThi, heDaoTao);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoTietRaDe' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaToChuc"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanThi"> A <c>System.Int32</c> instance.</param>
		/// <param name="heDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetSoTietRaDe(TransactionManager transactionManager, System.String maQuanLy, System.String maKhoaToChuc, System.String namHoc, System.String hocKy, System.Int32 lanThi, System.String heDaoTao)
		{
			return GetSoTietRaDe(transactionManager, 0, int.MaxValue , maQuanLy, maKhoaToChuc, namHoc, hocKy, lanThi, heDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoTietRaDe' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaToChuc"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanThi"> A <c>System.Int32</c> instance.</param>
		/// <param name="heDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetSoTietRaDe(TransactionManager transactionManager, int start, int pageLength , System.String maQuanLy, System.String maKhoaToChuc, System.String namHoc, System.String hocKy, System.Int32 lanThi, System.String heDaoTao);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_GetNoiDungGiamTruGioChuan 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetNoiDungGiamTruGioChuan' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetNoiDungGiamTruGioChuan(System.String xmlData, System.String namHoc, System.String hocKy, System.Int32 lanChot)
		{
			return GetNoiDungGiamTruGioChuan(null, 0, int.MaxValue , xmlData, namHoc, hocKy, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetNoiDungGiamTruGioChuan' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetNoiDungGiamTruGioChuan(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, System.Int32 lanChot)
		{
			return GetNoiDungGiamTruGioChuan(null, start, pageLength , xmlData, namHoc, hocKy, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetNoiDungGiamTruGioChuan' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetNoiDungGiamTruGioChuan(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, System.Int32 lanChot)
		{
			return GetNoiDungGiamTruGioChuan(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetNoiDungGiamTruGioChuan' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetNoiDungGiamTruGioChuan(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, System.Int32 lanChot);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeTongHopTheoNamHocHocKyDonViLoaiGiangVienLanChot 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTongHopTheoNamHocHocKyDonViLoaiGiangVienLanChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongHopTheoNamHocHocKyDonViLoaiGiangVienLanChot(System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return ThongKeTongHopTheoNamHocHocKyDonViLoaiGiangVienLanChot(null, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTongHopTheoNamHocHocKyDonViLoaiGiangVienLanChot' stored procedure. 
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
		public IDataReader ThongKeTongHopTheoNamHocHocKyDonViLoaiGiangVienLanChot(int start, int pageLength, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return ThongKeTongHopTheoNamHocHocKyDonViLoaiGiangVienLanChot(null, start, pageLength , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTongHopTheoNamHocHocKyDonViLoaiGiangVienLanChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongHopTheoNamHocHocKyDonViLoaiGiangVienLanChot(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return ThongKeTongHopTheoNamHocHocKyDonViLoaiGiangVienLanChot(transactionManager, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTongHopTheoNamHocHocKyDonViLoaiGiangVienLanChot' stored procedure. 
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
		public abstract IDataReader ThongKeTongHopTheoNamHocHocKyDonViLoaiGiangVienLanChot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeChiTiet_Cdgtvt 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeChiTiet_Cdgtvt' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeChiTiet_Cdgtvt(System.String namHoc, System.String hocKy, System.String maDonVi, System.String loaiGiangVien)
		{
			return ThongKeChiTiet_Cdgtvt(null, 0, int.MaxValue , namHoc, hocKy, maDonVi, loaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeChiTiet_Cdgtvt' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeChiTiet_Cdgtvt(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi, System.String loaiGiangVien)
		{
			return ThongKeChiTiet_Cdgtvt(null, start, pageLength , namHoc, hocKy, maDonVi, loaiGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeChiTiet_Cdgtvt' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeChiTiet_Cdgtvt(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi, System.String loaiGiangVien)
		{
			return ThongKeChiTiet_Cdgtvt(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi, loaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeChiTiet_Cdgtvt' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeChiTiet_Cdgtvt(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi, System.String loaiGiangVien);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_GetNgayChiTra 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetNgayChiTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetNgayChiTra(System.String namHoc, System.String hocKy, System.Int32 lanChot)
		{
			return GetNgayChiTra(null, 0, int.MaxValue , namHoc, hocKy, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetNgayChiTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetNgayChiTra(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 lanChot)
		{
			return GetNgayChiTra(null, start, pageLength , namHoc, hocKy, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetNgayChiTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetNgayChiTra(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 lanChot)
		{
			return GetNgayChiTra(transactionManager, 0, int.MaxValue , namHoc, hocKy, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetNgayChiTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetNgayChiTra(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 lanChot);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_LuuTietNoTon 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_LuuTietNoTon' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuTietNoTon(System.String xmlData, System.String namHoc, ref System.Int32 reVal)
		{
			 LuuTietNoTon(null, 0, int.MaxValue , xmlData, namHoc, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_LuuTietNoTon' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuTietNoTon(int start, int pageLength, System.String xmlData, System.String namHoc, ref System.Int32 reVal)
		{
			 LuuTietNoTon(null, start, pageLength , xmlData, namHoc, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_LuuTietNoTon' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuTietNoTon(TransactionManager transactionManager, System.String xmlData, System.String namHoc, ref System.Int32 reVal)
		{
			 LuuTietNoTon(transactionManager, 0, int.MaxValue , xmlData, namHoc, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_LuuTietNoTon' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LuuTietNoTon(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeGioGiangTheoDot 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeGioGiangTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeGioGiangTheoDot(System.String namHoc, System.String hocKy, System.String donVi, System.String dotThanhToan, System.String loaiGiangVien, System.String loaiHinhDaoTao)
		{
			return ThongKeGioGiangTheoDot(null, 0, int.MaxValue , namHoc, hocKy, donVi, dotThanhToan, loaiGiangVien, loaiHinhDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeGioGiangTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeGioGiangTheoDot(int start, int pageLength, System.String namHoc, System.String hocKy, System.String donVi, System.String dotThanhToan, System.String loaiGiangVien, System.String loaiHinhDaoTao)
		{
			return ThongKeGioGiangTheoDot(null, start, pageLength , namHoc, hocKy, donVi, dotThanhToan, loaiGiangVien, loaiHinhDaoTao);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeGioGiangTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeGioGiangTheoDot(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String donVi, System.String dotThanhToan, System.String loaiGiangVien, System.String loaiHinhDaoTao)
		{
			return ThongKeGioGiangTheoDot(transactionManager, 0, int.MaxValue , namHoc, hocKy, donVi, dotThanhToan, loaiGiangVien, loaiHinhDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeGioGiangTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeGioGiangTheoDot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String donVi, System.String dotThanhToan, System.String loaiGiangVien, System.String loaiHinhDaoTao);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeTienLuongDayThemGio_Cdgtvt 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienLuongDayThemGio_Cdgtvt' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienLuongDayThemGio_Cdgtvt(System.String namHoc, System.String maDonVi)
		{
			return ThongKeTienLuongDayThemGio_Cdgtvt(null, 0, int.MaxValue , namHoc, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienLuongDayThemGio_Cdgtvt' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienLuongDayThemGio_Cdgtvt(int start, int pageLength, System.String namHoc, System.String maDonVi)
		{
			return ThongKeTienLuongDayThemGio_Cdgtvt(null, start, pageLength , namHoc, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienLuongDayThemGio_Cdgtvt' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienLuongDayThemGio_Cdgtvt(TransactionManager transactionManager, System.String namHoc, System.String maDonVi)
		{
			return ThongKeTienLuongDayThemGio_Cdgtvt(transactionManager, 0, int.MaxValue , namHoc, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienLuongDayThemGio_Cdgtvt' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeTienLuongDayThemGio_Cdgtvt(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String maDonVi);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_NoGioChuanTheoHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_NoGioChuanTheoHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader NoGioChuanTheoHocKy(System.String namHoc, System.String hocKy, System.String donVi)
		{
			return NoGioChuanTheoHocKy(null, 0, int.MaxValue , namHoc, hocKy, donVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_NoGioChuanTheoHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader NoGioChuanTheoHocKy(int start, int pageLength, System.String namHoc, System.String hocKy, System.String donVi)
		{
			return NoGioChuanTheoHocKy(null, start, pageLength , namHoc, hocKy, donVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_NoGioChuanTheoHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader NoGioChuanTheoHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String donVi)
		{
			return NoGioChuanTheoHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy, donVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_NoGioChuanTheoHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader NoGioChuanTheoHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String donVi);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_KiemTraDaChiTra 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_KiemTraDaChiTra' stored procedure. 
		/// </summary>
		/// <param name="id"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraDaChiTra(System.Int32 id, ref System.String reVal)
		{
			 KiemTraDaChiTra(null, 0, int.MaxValue , id, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_KiemTraDaChiTra' stored procedure. 
		/// </summary>
		/// <param name="id"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraDaChiTra(int start, int pageLength, System.Int32 id, ref System.String reVal)
		{
			 KiemTraDaChiTra(null, start, pageLength , id, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_KiemTraDaChiTra' stored procedure. 
		/// </summary>
		/// <param name="id"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraDaChiTra(TransactionManager transactionManager, System.Int32 id, ref System.String reVal)
		{
			 KiemTraDaChiTra(transactionManager, 0, int.MaxValue , id, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_KiemTraDaChiTra' stored procedure. 
		/// </summary>
		/// <param name="id"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void KiemTraDaChiTra(TransactionManager transactionManager, int start, int pageLength , System.Int32 id, ref System.String reVal);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_SoSanhHaiLanChot 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_SoSanhHaiLanChot' stored procedure. 
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
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_SoSanhHaiLanChot' stored procedure. 
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
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_SoSanhHaiLanChot' stored procedure. 
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
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_SoSanhHaiLanChot' stored procedure. 
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
		
		#region cust_KetQuaThanhToanThuLao_ThongKeTienGiangLyThuyetCBKGHDDHCtim 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangLyThuyetCBKGHDDHCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangLyThuyetCBKGHDDHCtim(System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangLyThuyetCBKGHDDHCtim(null, 0, int.MaxValue , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangLyThuyetCBKGHDDHCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangLyThuyetCBKGHDDHCtim(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangLyThuyetCBKGHDDHCtim(null, start, pageLength , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangLyThuyetCBKGHDDHCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangLyThuyetCBKGHDDHCtim(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangLyThuyetCBKGHDDHCtim(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangLyThuyetCBKGHDDHCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeTienGiangLyThuyetCBKGHDDHCtim(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_TongHopKetQuaThanhToanTapSu 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_TongHopKetQuaThanhToanTapSu' stored procedure. 
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
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_TongHopKetQuaThanhToanTapSu' stored procedure. 
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
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_TongHopKetQuaThanhToanTapSu' stored procedure. 
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
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_TongHopKetQuaThanhToanTapSu' stored procedure. 
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
		
		#region cust_KetQuaThanhToanThuLao_ThongKeTienGiangThucHanhGiangVienThinhGiangCtim 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangThucHanhGiangVienThinhGiangCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangThucHanhGiangVienThinhGiangCtim(System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangThucHanhGiangVienThinhGiangCtim(null, 0, int.MaxValue , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangThucHanhGiangVienThinhGiangCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangThucHanhGiangVienThinhGiangCtim(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangThucHanhGiangVienThinhGiangCtim(null, start, pageLength , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangThucHanhGiangVienThinhGiangCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangThucHanhGiangVienThinhGiangCtim(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangThucHanhGiangVienThinhGiangCtim(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangThucHanhGiangVienThinhGiangCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeTienGiangThucHanhGiangVienThinhGiangCtim(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_XacNhanChiTra 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_XacNhanChiTra' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void XacNhanChiTra(System.String xmlData, ref System.Int32 reVal)
		{
			 XacNhanChiTra(null, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_XacNhanChiTra' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void XacNhanChiTra(int start, int pageLength, System.String xmlData, ref System.Int32 reVal)
		{
			 XacNhanChiTra(null, start, pageLength , xmlData, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_XacNhanChiTra' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void XacNhanChiTra(TransactionManager transactionManager, System.String xmlData, ref System.Int32 reVal)
		{
			 XacNhanChiTra(transactionManager, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_XacNhanChiTra' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void XacNhanChiTra(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeTongHopGioCoiThiChamBaiRaDeTheoHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTongHopGioCoiThiChamBaiRaDeTheoHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="heDaoTao"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongHopGioCoiThiChamBaiRaDeTheoHocKy(System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.String heDaoTao)
		{
			return ThongKeTongHopGioCoiThiChamBaiRaDeTheoHocKy(null, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien, heDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTongHopGioCoiThiChamBaiRaDeTheoHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="heDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongHopGioCoiThiChamBaiRaDeTheoHocKy(int start, int pageLength, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.String heDaoTao)
		{
			return ThongKeTongHopGioCoiThiChamBaiRaDeTheoHocKy(null, start, pageLength , namHoc, hocKy, donVi, loaiGiangVien, heDaoTao);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTongHopGioCoiThiChamBaiRaDeTheoHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="heDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongHopGioCoiThiChamBaiRaDeTheoHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.String heDaoTao)
		{
			return ThongKeTongHopGioCoiThiChamBaiRaDeTheoHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien, heDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTongHopGioCoiThiChamBaiRaDeTheoHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="heDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeTongHopGioCoiThiChamBaiRaDeTheoHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.String heDaoTao);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_GetSoTietChuyeNoTon 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoTietChuyeNoTon' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetSoTietChuyeNoTon(System.String namHoc)
		{
			return GetSoTietChuyeNoTon(null, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoTietChuyeNoTon' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetSoTietChuyeNoTon(int start, int pageLength, System.String namHoc)
		{
			return GetSoTietChuyeNoTon(null, start, pageLength , namHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoTietChuyeNoTon' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetSoTietChuyeNoTon(TransactionManager transactionManager, System.String namHoc)
		{
			return GetSoTietChuyeNoTon(transactionManager, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoTietChuyeNoTon' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetSoTietChuyeNoTon(TransactionManager transactionManager, int start, int pageLength , System.String namHoc);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeTienGiangThucHanhCBKGHDDHCtim 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangThucHanhCBKGHDDHCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangThucHanhCBKGHDDHCtim(System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangThucHanhCBKGHDDHCtim(null, 0, int.MaxValue , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangThucHanhCBKGHDDHCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangThucHanhCBKGHDDHCtim(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangThucHanhCBKGHDDHCtim(null, start, pageLength , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangThucHanhCBKGHDDHCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangThucHanhCBKGHDDHCtim(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangThucHanhCBKGHDDHCtim(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangThucHanhCBKGHDDHCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeTienGiangThucHanhCBKGHDDHCtim(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThanhToanThuLaoThinhGiang 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThanhToanThuLaoThinhGiang' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThanhToanThuLaoThinhGiang(System.String namHoc, System.String hocKy, System.Int32 lanChot, System.String khoaDonVi)
		{
			return ThanhToanThuLaoThinhGiang(null, 0, int.MaxValue , namHoc, hocKy, lanChot, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThanhToanThuLaoThinhGiang' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThanhToanThuLaoThinhGiang(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 lanChot, System.String khoaDonVi)
		{
			return ThanhToanThuLaoThinhGiang(null, start, pageLength , namHoc, hocKy, lanChot, khoaDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThanhToanThuLaoThinhGiang' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThanhToanThuLaoThinhGiang(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 lanChot, System.String khoaDonVi)
		{
			return ThanhToanThuLaoThinhGiang(transactionManager, 0, int.MaxValue , namHoc, hocKy, lanChot, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThanhToanThuLaoThinhGiang' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThanhToanThuLaoThinhGiang(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 lanChot, System.String khoaDonVi);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeTienGiangTttnCBKGHDDHCtim 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangTttnCBKGHDDHCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangTttnCBKGHDDHCtim(System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangTttnCBKGHDDHCtim(null, 0, int.MaxValue , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangTttnCBKGHDDHCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangTttnCBKGHDDHCtim(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangTttnCBKGHDDHCtim(null, start, pageLength , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangTttnCBKGHDDHCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangTttnCBKGHDDHCtim(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangTttnCBKGHDDHCtim(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangTttnCBKGHDDHCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeTienGiangTttnCBKGHDDHCtim(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThuLaoTrenWebIuh 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThuLaoTrenWebIuh' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="professorId"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThuLaoTrenWebIuh(System.String namHoc, System.String professorId)
		{
			return ThuLaoTrenWebIuh(null, 0, int.MaxValue , namHoc, professorId);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThuLaoTrenWebIuh' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="professorId"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThuLaoTrenWebIuh(int start, int pageLength, System.String namHoc, System.String professorId)
		{
			return ThuLaoTrenWebIuh(null, start, pageLength , namHoc, professorId);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThuLaoTrenWebIuh' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="professorId"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThuLaoTrenWebIuh(TransactionManager transactionManager, System.String namHoc, System.String professorId)
		{
			return ThuLaoTrenWebIuh(transactionManager, 0, int.MaxValue , namHoc, professorId);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThuLaoTrenWebIuh' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="professorId"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThuLaoTrenWebIuh(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String professorId);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_DuToanKinhPhiGiangDayVhu 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_DuToanKinhPhiGiangDayVhu' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader DuToanKinhPhiGiangDayVhu(System.String maDonVi, System.String maLoaiGiangVien, System.String namHoc, System.String hocKy, System.Int32 lanChot)
		{
			return DuToanKinhPhiGiangDayVhu(null, 0, int.MaxValue , maDonVi, maLoaiGiangVien, namHoc, hocKy, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_DuToanKinhPhiGiangDayVhu' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader DuToanKinhPhiGiangDayVhu(int start, int pageLength, System.String maDonVi, System.String maLoaiGiangVien, System.String namHoc, System.String hocKy, System.Int32 lanChot)
		{
			return DuToanKinhPhiGiangDayVhu(null, start, pageLength , maDonVi, maLoaiGiangVien, namHoc, hocKy, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_DuToanKinhPhiGiangDayVhu' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader DuToanKinhPhiGiangDayVhu(TransactionManager transactionManager, System.String maDonVi, System.String maLoaiGiangVien, System.String namHoc, System.String hocKy, System.Int32 lanChot)
		{
			return DuToanKinhPhiGiangDayVhu(transactionManager, 0, int.MaxValue , maDonVi, maLoaiGiangVien, namHoc, hocKy, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_DuToanKinhPhiGiangDayVhu' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader DuToanKinhPhiGiangDayVhu(TransactionManager transactionManager, int start, int pageLength , System.String maDonVi, System.String maLoaiGiangVien, System.String namHoc, System.String hocKy, System.Int32 lanChot);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_GetLuoiVuotGioBoSung 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetLuoiVuotGioBoSung' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetLuoiVuotGioBoSung(System.String namHoc, System.Int32 lanChotHk01, System.Int32 lanChotHk02, System.String khoaDonVi)
		{
			return GetLuoiVuotGioBoSung(null, 0, int.MaxValue , namHoc, lanChotHk01, lanChotHk02, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetLuoiVuotGioBoSung' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetLuoiVuotGioBoSung(int start, int pageLength, System.String namHoc, System.Int32 lanChotHk01, System.Int32 lanChotHk02, System.String khoaDonVi)
		{
			return GetLuoiVuotGioBoSung(null, start, pageLength , namHoc, lanChotHk01, lanChotHk02, khoaDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetLuoiVuotGioBoSung' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetLuoiVuotGioBoSung(TransactionManager transactionManager, System.String namHoc, System.Int32 lanChotHk01, System.Int32 lanChotHk02, System.String khoaDonVi)
		{
			return GetLuoiVuotGioBoSung(transactionManager, 0, int.MaxValue , namHoc, lanChotHk01, lanChotHk02, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetLuoiVuotGioBoSung' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetLuoiVuotGioBoSung(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.Int32 lanChotHk01, System.Int32 lanChotHk02, System.String khoaDonVi);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_KiemTraTinhTrangKeToanChiTra 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_KiemTraTinhTrangKeToanChiTra' stored procedure. 
		/// </summary>
		/// <param name="id"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraTinhTrangKeToanChiTra(System.Int32 id, ref System.Int32 reVal)
		{
			 KiemTraTinhTrangKeToanChiTra(null, 0, int.MaxValue , id, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_KiemTraTinhTrangKeToanChiTra' stored procedure. 
		/// </summary>
		/// <param name="id"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraTinhTrangKeToanChiTra(int start, int pageLength, System.Int32 id, ref System.Int32 reVal)
		{
			 KiemTraTinhTrangKeToanChiTra(null, start, pageLength , id, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_KiemTraTinhTrangKeToanChiTra' stored procedure. 
		/// </summary>
		/// <param name="id"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraTinhTrangKeToanChiTra(TransactionManager transactionManager, System.Int32 id, ref System.Int32 reVal)
		{
			 KiemTraTinhTrangKeToanChiTra(transactionManager, 0, int.MaxValue , id, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_KiemTraTinhTrangKeToanChiTra' stored procedure. 
		/// </summary>
		/// <param name="id"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void KiemTraTinhTrangKeToanChiTra(TransactionManager transactionManager, int start, int pageLength , System.Int32 id, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeTienGiangThucHanhHopDongDaiHanCtim 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangThucHanhHopDongDaiHanCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangThucHanhHopDongDaiHanCtim(System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangThucHanhHopDongDaiHanCtim(null, 0, int.MaxValue , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangThucHanhHopDongDaiHanCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangThucHanhHopDongDaiHanCtim(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangThucHanhHopDongDaiHanCtim(null, start, pageLength , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangThucHanhHopDongDaiHanCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangThucHanhHopDongDaiHanCtim(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangThucHanhHopDongDaiHanCtim(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangThucHanhHopDongDaiHanCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeTienGiangThucHanhHopDongDaiHanCtim(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeTheoNamHocHocKyBacDaoTaoDonViLoaiGiangVienLanChot 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTheoNamHocHocKyBacDaoTaoDonViLoaiGiangVienLanChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTheoNamHocHocKyBacDaoTaoDonViLoaiGiangVienLanChot(System.String namHoc, System.String hocKy, System.String bacDaoTao, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return ThongKeTheoNamHocHocKyBacDaoTaoDonViLoaiGiangVienLanChot(null, 0, int.MaxValue , namHoc, hocKy, bacDaoTao, donVi, loaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTheoNamHocHocKyBacDaoTaoDonViLoaiGiangVienLanChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTheoNamHocHocKyBacDaoTaoDonViLoaiGiangVienLanChot(int start, int pageLength, System.String namHoc, System.String hocKy, System.String bacDaoTao, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return ThongKeTheoNamHocHocKyBacDaoTaoDonViLoaiGiangVienLanChot(null, start, pageLength , namHoc, hocKy, bacDaoTao, donVi, loaiGiangVien, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTheoNamHocHocKyBacDaoTaoDonViLoaiGiangVienLanChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTheoNamHocHocKyBacDaoTaoDonViLoaiGiangVienLanChot(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String bacDaoTao, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return ThongKeTheoNamHocHocKyBacDaoTaoDonViLoaiGiangVienLanChot(transactionManager, 0, int.MaxValue , namHoc, hocKy, bacDaoTao, donVi, loaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTheoNamHocHocKyBacDaoTaoDonViLoaiGiangVienLanChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeTheoNamHocHocKyBacDaoTaoDonViLoaiGiangVienLanChot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String bacDaoTao, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeTongHop_Cdgtvt 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTongHop_Cdgtvt' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongHop_Cdgtvt(System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return ThongKeTongHop_Cdgtvt(null, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTongHop_Cdgtvt' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongHop_Cdgtvt(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return ThongKeTongHop_Cdgtvt(null, start, pageLength , namHoc, hocKy, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTongHop_Cdgtvt' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongHop_Cdgtvt(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return ThongKeTongHop_Cdgtvt(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTongHop_Cdgtvt' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeTongHop_Cdgtvt(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_BangKeThanhToanCaNam 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangKeThanhToanCaNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangKeThanhToanCaNam(System.String namHoc, System.String donVi, System.String loaiGiangVien)
		{
			return BangKeThanhToanCaNam(null, 0, int.MaxValue , namHoc, donVi, loaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangKeThanhToanCaNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangKeThanhToanCaNam(int start, int pageLength, System.String namHoc, System.String donVi, System.String loaiGiangVien)
		{
			return BangKeThanhToanCaNam(null, start, pageLength , namHoc, donVi, loaiGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangKeThanhToanCaNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangKeThanhToanCaNam(TransactionManager transactionManager, System.String namHoc, System.String donVi, System.String loaiGiangVien)
		{
			return BangKeThanhToanCaNam(transactionManager, 0, int.MaxValue , namHoc, donVi, loaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangKeThanhToanCaNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader BangKeThanhToanCaNam(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String donVi, System.String loaiGiangVien);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeTongHopTheoKhoa_Cdgtvt 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTongHopTheoKhoa_Cdgtvt' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongHopTheoKhoa_Cdgtvt(System.String namHoc, System.String maDonVi, System.Int32 maLoaiGiangVien)
		{
			return ThongKeTongHopTheoKhoa_Cdgtvt(null, 0, int.MaxValue , namHoc, maDonVi, maLoaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTongHopTheoKhoa_Cdgtvt' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongHopTheoKhoa_Cdgtvt(int start, int pageLength, System.String namHoc, System.String maDonVi, System.Int32 maLoaiGiangVien)
		{
			return ThongKeTongHopTheoKhoa_Cdgtvt(null, start, pageLength , namHoc, maDonVi, maLoaiGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTongHopTheoKhoa_Cdgtvt' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongHopTheoKhoa_Cdgtvt(TransactionManager transactionManager, System.String namHoc, System.String maDonVi, System.Int32 maLoaiGiangVien)
		{
			return ThongKeTongHopTheoKhoa_Cdgtvt(transactionManager, 0, int.MaxValue , namHoc, maDonVi, maLoaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTongHopTheoKhoa_Cdgtvt' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeTongHopTheoKhoa_Cdgtvt(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String maDonVi, System.Int32 maLoaiGiangVien);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_BangKeThanhToanTienRaDeCtim 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangKeThanhToanTienRaDeCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangKeThanhToanTienRaDeCtim(System.String namHoc, System.String hocKy, System.String khoaHoc, System.String bacDaoTao, System.String khoaBoMon, System.Int32 maLoaiGiangVien)
		{
			return BangKeThanhToanTienRaDeCtim(null, 0, int.MaxValue , namHoc, hocKy, khoaHoc, bacDaoTao, khoaBoMon, maLoaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangKeThanhToanTienRaDeCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangKeThanhToanTienRaDeCtim(int start, int pageLength, System.String namHoc, System.String hocKy, System.String khoaHoc, System.String bacDaoTao, System.String khoaBoMon, System.Int32 maLoaiGiangVien)
		{
			return BangKeThanhToanTienRaDeCtim(null, start, pageLength , namHoc, hocKy, khoaHoc, bacDaoTao, khoaBoMon, maLoaiGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangKeThanhToanTienRaDeCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangKeThanhToanTienRaDeCtim(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String khoaHoc, System.String bacDaoTao, System.String khoaBoMon, System.Int32 maLoaiGiangVien)
		{
			return BangKeThanhToanTienRaDeCtim(transactionManager, 0, int.MaxValue , namHoc, hocKy, khoaHoc, bacDaoTao, khoaBoMon, maLoaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangKeThanhToanTienRaDeCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader BangKeThanhToanTienRaDeCtim(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String khoaHoc, System.String bacDaoTao, System.String khoaBoMon, System.Int32 maLoaiGiangVien);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_GetCongTacKhac 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetCongTacKhac' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetCongTacKhac(System.String namHoc, System.String hocKy, System.Int32 maGiangVien)
		{
			return GetCongTacKhac(null, 0, int.MaxValue , namHoc, hocKy, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetCongTacKhac' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetCongTacKhac(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 maGiangVien)
		{
			return GetCongTacKhac(null, start, pageLength , namHoc, hocKy, maGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetCongTacKhac' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetCongTacKhac(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 maGiangVien)
		{
			return GetCongTacKhac(transactionManager, 0, int.MaxValue , namHoc, hocKy, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetCongTacKhac' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetCongTacKhac(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 maGiangVien);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeChiTienThuLaoGiangDay 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeChiTienThuLaoGiangDay' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeChiTienThuLaoGiangDay(System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien)
		{
			return ThongKeChiTienThuLaoGiangDay(null, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeChiTienThuLaoGiangDay' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeChiTienThuLaoGiangDay(int start, int pageLength, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien)
		{
			return ThongKeChiTienThuLaoGiangDay(null, start, pageLength , namHoc, hocKy, donVi, loaiGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeChiTienThuLaoGiangDay' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeChiTienThuLaoGiangDay(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien)
		{
			return ThongKeChiTienThuLaoGiangDay(transactionManager, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeChiTienThuLaoGiangDay' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeChiTienThuLaoGiangDay(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_GetSoTietNhapDiem 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoTietNhapDiem' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaToChuc"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanThi"> A <c>System.Int32</c> instance.</param>
		/// <param name="heDaoTao"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetSoTietNhapDiem(System.String maQuanLy, System.String maKhoaToChuc, System.String namHoc, System.String hocKy, System.Int32 lanThi, System.String heDaoTao)
		{
			return GetSoTietNhapDiem(null, 0, int.MaxValue , maQuanLy, maKhoaToChuc, namHoc, hocKy, lanThi, heDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoTietNhapDiem' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaToChuc"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanThi"> A <c>System.Int32</c> instance.</param>
		/// <param name="heDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetSoTietNhapDiem(int start, int pageLength, System.String maQuanLy, System.String maKhoaToChuc, System.String namHoc, System.String hocKy, System.Int32 lanThi, System.String heDaoTao)
		{
			return GetSoTietNhapDiem(null, start, pageLength , maQuanLy, maKhoaToChuc, namHoc, hocKy, lanThi, heDaoTao);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoTietNhapDiem' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaToChuc"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanThi"> A <c>System.Int32</c> instance.</param>
		/// <param name="heDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetSoTietNhapDiem(TransactionManager transactionManager, System.String maQuanLy, System.String maKhoaToChuc, System.String namHoc, System.String hocKy, System.Int32 lanThi, System.String heDaoTao)
		{
			return GetSoTietNhapDiem(transactionManager, 0, int.MaxValue , maQuanLy, maKhoaToChuc, namHoc, hocKy, lanThi, heDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoTietNhapDiem' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaToChuc"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanThi"> A <c>System.Int32</c> instance.</param>
		/// <param name="heDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetSoTietNhapDiem(TransactionManager transactionManager, int start, int pageLength , System.String maQuanLy, System.String maKhoaToChuc, System.String namHoc, System.String hocKy, System.Int32 lanThi, System.String heDaoTao);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ChotThanhToan 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ChotThanhToan' stored procedure. 
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
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ChotThanhToan' stored procedure. 
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
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ChotThanhToan' stored procedure. 
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
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ChotThanhToan' stored procedure. 
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
		
		#region cust_KetQuaThanhToanThuLao_GetThuLaoTamUng_ReportWeb 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetThuLaoTamUng_ReportWeb' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maQuanLyGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThuLaoTamUng_ReportWeb(System.String namHoc, System.String hocKy, System.String maQuanLyGiangVien)
		{
			return GetThuLaoTamUng_ReportWeb(null, 0, int.MaxValue , namHoc, hocKy, maQuanLyGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetThuLaoTamUng_ReportWeb' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maQuanLyGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThuLaoTamUng_ReportWeb(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maQuanLyGiangVien)
		{
			return GetThuLaoTamUng_ReportWeb(null, start, pageLength , namHoc, hocKy, maQuanLyGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetThuLaoTamUng_ReportWeb' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maQuanLyGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThuLaoTamUng_ReportWeb(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maQuanLyGiangVien)
		{
			return GetThuLaoTamUng_ReportWeb(transactionManager, 0, int.MaxValue , namHoc, hocKy, maQuanLyGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetThuLaoTamUng_ReportWeb' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maQuanLyGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetThuLaoTamUng_ReportWeb(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maQuanLyGiangVien);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeThanhToanTienGiang_Bk 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeThanhToanTienGiang_Bk' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeThanhToanTienGiang_Bk(System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return ThongKeThanhToanTienGiang_Bk(null, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeThanhToanTienGiang_Bk' stored procedure. 
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
		public IDataReader ThongKeThanhToanTienGiang_Bk(int start, int pageLength, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return ThongKeThanhToanTienGiang_Bk(null, start, pageLength , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeThanhToanTienGiang_Bk' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeThanhToanTienGiang_Bk(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return ThongKeThanhToanTienGiang_Bk(transactionManager, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeThanhToanTienGiang_Bk' stored procedure. 
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
		public abstract IDataReader ThongKeThanhToanTienGiang_Bk(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThanhToanThuLaoVuotGioGiangVienCoHuuTheoNamHoc 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThanhToanThuLaoVuotGioGiangVienCoHuuTheoNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="giangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThanhToanThuLaoVuotGioGiangVienCoHuuTheoNamHoc(System.String namHoc, System.String giangVien)
		{
			return ThanhToanThuLaoVuotGioGiangVienCoHuuTheoNamHoc(null, 0, int.MaxValue , namHoc, giangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThanhToanThuLaoVuotGioGiangVienCoHuuTheoNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="giangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThanhToanThuLaoVuotGioGiangVienCoHuuTheoNamHoc(int start, int pageLength, System.String namHoc, System.String giangVien)
		{
			return ThanhToanThuLaoVuotGioGiangVienCoHuuTheoNamHoc(null, start, pageLength , namHoc, giangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThanhToanThuLaoVuotGioGiangVienCoHuuTheoNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="giangVien"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThanhToanThuLaoVuotGioGiangVienCoHuuTheoNamHoc(TransactionManager transactionManager, System.String namHoc, System.String giangVien)
		{
			return ThanhToanThuLaoVuotGioGiangVienCoHuuTheoNamHoc(transactionManager, 0, int.MaxValue , namHoc, giangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThanhToanThuLaoVuotGioGiangVienCoHuuTheoNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="giangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThanhToanThuLaoVuotGioGiangVienCoHuuTheoNamHoc(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String giangVien);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThanhToanTamUngDot1 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThanhToanTamUngDot1' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThanhToanTamUngDot1(System.String namHoc)
		{
			return ThanhToanTamUngDot1(null, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThanhToanTamUngDot1' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThanhToanTamUngDot1(int start, int pageLength, System.String namHoc)
		{
			return ThanhToanTamUngDot1(null, start, pageLength , namHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThanhToanTamUngDot1' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThanhToanTamUngDot1(TransactionManager transactionManager, System.String namHoc)
		{
			return ThanhToanTamUngDot1(transactionManager, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThanhToanTamUngDot1' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThanhToanTamUngDot1(TransactionManager transactionManager, int start, int pageLength , System.String namHoc);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ChiTietGioGiangIuh 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ChiTietGioGiangIuh' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ChiTietGioGiangIuh(System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return ChiTietGioGiangIuh(null, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ChiTietGioGiangIuh' stored procedure. 
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
		public IDataReader ChiTietGioGiangIuh(int start, int pageLength, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return ChiTietGioGiangIuh(null, start, pageLength , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ChiTietGioGiangIuh' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ChiTietGioGiangIuh(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return ChiTietGioGiangIuh(transactionManager, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ChiTietGioGiangIuh' stored procedure. 
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
		public abstract IDataReader ChiTietGioGiangIuh(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeTienGiangGDTCHopDongDaiHanCtim 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangGDTCHopDongDaiHanCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangGDTCHopDongDaiHanCtim(System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangGDTCHopDongDaiHanCtim(null, 0, int.MaxValue , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangGDTCHopDongDaiHanCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangGDTCHopDongDaiHanCtim(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangGDTCHopDongDaiHanCtim(null, start, pageLength , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangGDTCHopDongDaiHanCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangGDTCHopDongDaiHanCtim(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangGDTCHopDongDaiHanCtim(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangGDTCHopDongDaiHanCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeTienGiangGDTCHopDongDaiHanCtim(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_GetLuoiVuotGioBoSung_Bk 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetLuoiVuotGioBoSung_Bk' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetLuoiVuotGioBoSung_Bk(System.String namHoc, System.Int32 lanChotHk01, System.Int32 lanChotHk02, System.String khoaDonVi)
		{
			return GetLuoiVuotGioBoSung_Bk(null, 0, int.MaxValue , namHoc, lanChotHk01, lanChotHk02, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetLuoiVuotGioBoSung_Bk' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetLuoiVuotGioBoSung_Bk(int start, int pageLength, System.String namHoc, System.Int32 lanChotHk01, System.Int32 lanChotHk02, System.String khoaDonVi)
		{
			return GetLuoiVuotGioBoSung_Bk(null, start, pageLength , namHoc, lanChotHk01, lanChotHk02, khoaDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetLuoiVuotGioBoSung_Bk' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetLuoiVuotGioBoSung_Bk(TransactionManager transactionManager, System.String namHoc, System.Int32 lanChotHk01, System.Int32 lanChotHk02, System.String khoaDonVi)
		{
			return GetLuoiVuotGioBoSung_Bk(transactionManager, 0, int.MaxValue , namHoc, lanChotHk01, lanChotHk02, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetLuoiVuotGioBoSung_Bk' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetLuoiVuotGioBoSung_Bk(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.Int32 lanChotHk01, System.Int32 lanChotHk02, System.String khoaDonVi);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_InBangKeGioGiangTheoNam 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_InBangKeGioGiangTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader InBangKeGioGiangTheoNam(System.String namHoc, System.String hocKy, System.Int32 lanChot, System.String khoaDonVi)
		{
			return InBangKeGioGiangTheoNam(null, 0, int.MaxValue , namHoc, hocKy, lanChot, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_InBangKeGioGiangTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader InBangKeGioGiangTheoNam(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 lanChot, System.String khoaDonVi)
		{
			return InBangKeGioGiangTheoNam(null, start, pageLength , namHoc, hocKy, lanChot, khoaDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_InBangKeGioGiangTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader InBangKeGioGiangTheoNam(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 lanChot, System.String khoaDonVi)
		{
			return InBangKeGioGiangTheoNam(transactionManager, 0, int.MaxValue , namHoc, hocKy, lanChot, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_InBangKeGioGiangTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader InBangKeGioGiangTheoNam(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 lanChot, System.String khoaDonVi);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_GetSoTietDoDiem 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoTietDoDiem' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaToChuc"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanThi"> A <c>System.Int32</c> instance.</param>
		/// <param name="heDaoTao"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetSoTietDoDiem(System.String maQuanLy, System.String maKhoaToChuc, System.String namHoc, System.String hocKy, System.Int32 lanThi, System.String heDaoTao)
		{
			return GetSoTietDoDiem(null, 0, int.MaxValue , maQuanLy, maKhoaToChuc, namHoc, hocKy, lanThi, heDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoTietDoDiem' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaToChuc"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanThi"> A <c>System.Int32</c> instance.</param>
		/// <param name="heDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetSoTietDoDiem(int start, int pageLength, System.String maQuanLy, System.String maKhoaToChuc, System.String namHoc, System.String hocKy, System.Int32 lanThi, System.String heDaoTao)
		{
			return GetSoTietDoDiem(null, start, pageLength , maQuanLy, maKhoaToChuc, namHoc, hocKy, lanThi, heDaoTao);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoTietDoDiem' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaToChuc"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanThi"> A <c>System.Int32</c> instance.</param>
		/// <param name="heDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetSoTietDoDiem(TransactionManager transactionManager, System.String maQuanLy, System.String maKhoaToChuc, System.String namHoc, System.String hocKy, System.Int32 lanThi, System.String heDaoTao)
		{
			return GetSoTietDoDiem(transactionManager, 0, int.MaxValue , maQuanLy, maKhoaToChuc, namHoc, hocKy, lanThi, heDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoTietDoDiem' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaToChuc"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanThi"> A <c>System.Int32</c> instance.</param>
		/// <param name="heDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetSoTietDoDiem(TransactionManager transactionManager, int start, int pageLength , System.String maQuanLy, System.String maKhoaToChuc, System.String namHoc, System.String hocKy, System.Int32 lanThi, System.String heDaoTao);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeLopHocPhanKhongRaiLich 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeLopHocPhanKhongRaiLich' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeLopHocPhanKhongRaiLich(System.String namHoc, System.String hocKy)
		{
			return ThongKeLopHocPhanKhongRaiLich(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeLopHocPhanKhongRaiLich' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeLopHocPhanKhongRaiLich(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return ThongKeLopHocPhanKhongRaiLich(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeLopHocPhanKhongRaiLich' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeLopHocPhanKhongRaiLich(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return ThongKeLopHocPhanKhongRaiLich(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeLopHocPhanKhongRaiLich' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeLopHocPhanKhongRaiLich(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_GetSoTietToChucThi 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoTietToChucThi' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaToChuc"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanThi"> A <c>System.Int32</c> instance.</param>
		/// <param name="heDaoTao"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetSoTietToChucThi(System.String maQuanLy, System.String maKhoaToChuc, System.String namHoc, System.String hocKy, System.Int32 lanThi, System.String heDaoTao)
		{
			return GetSoTietToChucThi(null, 0, int.MaxValue , maQuanLy, maKhoaToChuc, namHoc, hocKy, lanThi, heDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoTietToChucThi' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaToChuc"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanThi"> A <c>System.Int32</c> instance.</param>
		/// <param name="heDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetSoTietToChucThi(int start, int pageLength, System.String maQuanLy, System.String maKhoaToChuc, System.String namHoc, System.String hocKy, System.Int32 lanThi, System.String heDaoTao)
		{
			return GetSoTietToChucThi(null, start, pageLength , maQuanLy, maKhoaToChuc, namHoc, hocKy, lanThi, heDaoTao);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoTietToChucThi' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaToChuc"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanThi"> A <c>System.Int32</c> instance.</param>
		/// <param name="heDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetSoTietToChucThi(TransactionManager transactionManager, System.String maQuanLy, System.String maKhoaToChuc, System.String namHoc, System.String hocKy, System.Int32 lanThi, System.String heDaoTao)
		{
			return GetSoTietToChucThi(transactionManager, 0, int.MaxValue , maQuanLy, maKhoaToChuc, namHoc, hocKy, lanThi, heDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoTietToChucThi' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaToChuc"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanThi"> A <c>System.Int32</c> instance.</param>
		/// <param name="heDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetSoTietToChucThi(TransactionManager transactionManager, int start, int pageLength , System.String maQuanLy, System.String maKhoaToChuc, System.String namHoc, System.String hocKy, System.Int32 lanThi, System.String heDaoTao);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeChiTietGioGiangTheoDot 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeChiTietGioGiangTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="loaiThongKe"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeChiTietGioGiangTheoDot(System.String namHoc, System.String hocKy, System.String donVi, System.String dotThanhToan, System.String loaiGiangVien, System.String loaiHinhDaoTao, System.Int32 loaiThongKe)
		{
			return ThongKeChiTietGioGiangTheoDot(null, 0, int.MaxValue , namHoc, hocKy, donVi, dotThanhToan, loaiGiangVien, loaiHinhDaoTao, loaiThongKe);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeChiTietGioGiangTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="loaiThongKe"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeChiTietGioGiangTheoDot(int start, int pageLength, System.String namHoc, System.String hocKy, System.String donVi, System.String dotThanhToan, System.String loaiGiangVien, System.String loaiHinhDaoTao, System.Int32 loaiThongKe)
		{
			return ThongKeChiTietGioGiangTheoDot(null, start, pageLength , namHoc, hocKy, donVi, dotThanhToan, loaiGiangVien, loaiHinhDaoTao, loaiThongKe);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeChiTietGioGiangTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="loaiThongKe"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeChiTietGioGiangTheoDot(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String donVi, System.String dotThanhToan, System.String loaiGiangVien, System.String loaiHinhDaoTao, System.Int32 loaiThongKe)
		{
			return ThongKeChiTietGioGiangTheoDot(transactionManager, 0, int.MaxValue , namHoc, hocKy, donVi, dotThanhToan, loaiGiangVien, loaiHinhDaoTao, loaiThongKe);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeChiTietGioGiangTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="loaiThongKe"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeChiTietGioGiangTheoDot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String donVi, System.String dotThanhToan, System.String loaiGiangVien, System.String loaiHinhDaoTao, System.Int32 loaiThongKe);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThuLaoTrenWeb_Dlu 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThuLaoTrenWeb_Dlu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
		/// <param name="professorId"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThuLaoTrenWeb_Dlu(System.String namHoc, System.String hocKy, System.Int32 dotThanhToan, System.String professorId)
		{
			return ThuLaoTrenWeb_Dlu(null, 0, int.MaxValue , namHoc, hocKy, dotThanhToan, professorId);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThuLaoTrenWeb_Dlu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
		/// <param name="professorId"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThuLaoTrenWeb_Dlu(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 dotThanhToan, System.String professorId)
		{
			return ThuLaoTrenWeb_Dlu(null, start, pageLength , namHoc, hocKy, dotThanhToan, professorId);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThuLaoTrenWeb_Dlu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
		/// <param name="professorId"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThuLaoTrenWeb_Dlu(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 dotThanhToan, System.String professorId)
		{
			return ThuLaoTrenWeb_Dlu(transactionManager, 0, int.MaxValue , namHoc, hocKy, dotThanhToan, professorId);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThuLaoTrenWeb_Dlu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
		/// <param name="professorId"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThuLaoTrenWeb_Dlu(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 dotThanhToan, System.String professorId);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_HuyChotThuLaoTheoDot 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_HuyChotThuLaoTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChotThuLaoTheoDot(System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio, System.Int32 lanChot, ref System.Int32 reVal)
		{
			 HuyChotThuLaoTheoDot(null, 0, int.MaxValue , namHoc, hocKy, maCauHinhChotGio, lanChot, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_HuyChotThuLaoTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChotThuLaoTheoDot(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio, System.Int32 lanChot, ref System.Int32 reVal)
		{
			 HuyChotThuLaoTheoDot(null, start, pageLength , namHoc, hocKy, maCauHinhChotGio, lanChot, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_HuyChotThuLaoTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChotThuLaoTheoDot(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio, System.Int32 lanChot, ref System.Int32 reVal)
		{
			 HuyChotThuLaoTheoDot(transactionManager, 0, int.MaxValue , namHoc, hocKy, maCauHinhChotGio, lanChot, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_HuyChotThuLaoTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void HuyChotThuLaoTheoDot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio, System.Int32 lanChot, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThanhToanThuLaoDot2 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThanhToanThuLaoDot2' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThanhToanThuLaoDot2(System.String namHoc)
		{
			return ThanhToanThuLaoDot2(null, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThanhToanThuLaoDot2' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThanhToanThuLaoDot2(int start, int pageLength, System.String namHoc)
		{
			return ThanhToanThuLaoDot2(null, start, pageLength , namHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThanhToanThuLaoDot2' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThanhToanThuLaoDot2(TransactionManager transactionManager, System.String namHoc)
		{
			return ThanhToanThuLaoDot2(transactionManager, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThanhToanThuLaoDot2' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThanhToanThuLaoDot2(TransactionManager transactionManager, int start, int pageLength , System.String namHoc);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_HuyChotThuLaoKhoaDonVi 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_HuyChotThuLaoKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChotThuLaoKhoaDonVi(System.String namHoc, System.String hocKy, System.String khoaDonVi, System.Int32 lanChot, ref System.Int32 reVal)
		{
			 HuyChotThuLaoKhoaDonVi(null, 0, int.MaxValue , namHoc, hocKy, khoaDonVi, lanChot, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_HuyChotThuLaoKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChotThuLaoKhoaDonVi(int start, int pageLength, System.String namHoc, System.String hocKy, System.String khoaDonVi, System.Int32 lanChot, ref System.Int32 reVal)
		{
			 HuyChotThuLaoKhoaDonVi(null, start, pageLength , namHoc, hocKy, khoaDonVi, lanChot, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_HuyChotThuLaoKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChotThuLaoKhoaDonVi(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String khoaDonVi, System.Int32 lanChot, ref System.Int32 reVal)
		{
			 HuyChotThuLaoKhoaDonVi(transactionManager, 0, int.MaxValue , namHoc, hocKy, khoaDonVi, lanChot, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_HuyChotThuLaoKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void HuyChotThuLaoKhoaDonVi(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String khoaDonVi, System.Int32 lanChot, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThanhToanGioVuotDinhMucVhu 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThanhToanGioVuotDinhMucVhu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThanhToanGioVuotDinhMucVhu(System.String namHoc, System.Int32 lanChotHk01, System.Int32 lanChotHk02)
		{
			return ThanhToanGioVuotDinhMucVhu(null, 0, int.MaxValue , namHoc, lanChotHk01, lanChotHk02);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThanhToanGioVuotDinhMucVhu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThanhToanGioVuotDinhMucVhu(int start, int pageLength, System.String namHoc, System.Int32 lanChotHk01, System.Int32 lanChotHk02)
		{
			return ThanhToanGioVuotDinhMucVhu(null, start, pageLength , namHoc, lanChotHk01, lanChotHk02);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThanhToanGioVuotDinhMucVhu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThanhToanGioVuotDinhMucVhu(TransactionManager transactionManager, System.String namHoc, System.Int32 lanChotHk01, System.Int32 lanChotHk02)
		{
			return ThanhToanGioVuotDinhMucVhu(transactionManager, 0, int.MaxValue , namHoc, lanChotHk01, lanChotHk02);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThanhToanGioVuotDinhMucVhu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThanhToanGioVuotDinhMucVhu(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.Int32 lanChotHk01, System.Int32 lanChotHk02);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_Import 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Import(System.String xmlData, ref System.Int32 reVal)
		{
			 Import(null, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_Import' stored procedure. 
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
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_Import' stored procedure. 
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
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Import(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThanhToanPhuCapGdtc 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThanhToanPhuCapGdtc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThanhToanPhuCapGdtc(System.String namHoc, System.String hocKy, System.Int32 lanChot)
		{
			return ThanhToanPhuCapGdtc(null, 0, int.MaxValue , namHoc, hocKy, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThanhToanPhuCapGdtc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThanhToanPhuCapGdtc(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 lanChot)
		{
			return ThanhToanPhuCapGdtc(null, start, pageLength , namHoc, hocKy, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThanhToanPhuCapGdtc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThanhToanPhuCapGdtc(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 lanChot)
		{
			return ThanhToanPhuCapGdtc(transactionManager, 0, int.MaxValue , namHoc, hocKy, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThanhToanPhuCapGdtc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThanhToanPhuCapGdtc(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 lanChot);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_BangTongHopGioGiangToanTruongTheoNam 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangTongHopGioGiangToanTruongTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangTongHopGioGiangToanTruongTheoNam(System.String namHoc, System.String loaiGiangVien, System.String loaiHinhDaoTao)
		{
			return BangTongHopGioGiangToanTruongTheoNam(null, 0, int.MaxValue , namHoc, loaiGiangVien, loaiHinhDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangTongHopGioGiangToanTruongTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangTongHopGioGiangToanTruongTheoNam(int start, int pageLength, System.String namHoc, System.String loaiGiangVien, System.String loaiHinhDaoTao)
		{
			return BangTongHopGioGiangToanTruongTheoNam(null, start, pageLength , namHoc, loaiGiangVien, loaiHinhDaoTao);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangTongHopGioGiangToanTruongTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangTongHopGioGiangToanTruongTheoNam(TransactionManager transactionManager, System.String namHoc, System.String loaiGiangVien, System.String loaiHinhDaoTao)
		{
			return BangTongHopGioGiangToanTruongTheoNam(transactionManager, 0, int.MaxValue , namHoc, loaiGiangVien, loaiHinhDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangTongHopGioGiangToanTruongTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader BangTongHopGioGiangToanTruongTheoNam(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String loaiGiangVien, System.String loaiHinhDaoTao);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeTienGiangGDTCCBKGHDDHCtim 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangGDTCCBKGHDDHCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangGDTCCBKGHDDHCtim(System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangGDTCCBKGHDDHCtim(null, 0, int.MaxValue , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangGDTCCBKGHDDHCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangGDTCCBKGHDDHCtim(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangGDTCCBKGHDDHCtim(null, start, pageLength , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangGDTCCBKGHDDHCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangGDTCCBKGHDDHCtim(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangGDTCCBKGHDDHCtim(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangGDTCCBKGHDDHCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeTienGiangGDTCCBKGHDDHCtim(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_GetByMaGiangVienNamHoc 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetByMaGiangVienNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="loaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk03"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaGiangVienNamHoc(System.String maQuanLy, System.String namHoc, System.String loaiKhoiLuong, System.String lanChotHk01, System.String lanChotHk02, System.String lanChotHk03)
		{
			return GetByMaGiangVienNamHoc(null, 0, int.MaxValue , maQuanLy, namHoc, loaiKhoiLuong, lanChotHk01, lanChotHk02, lanChotHk03);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetByMaGiangVienNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="loaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk03"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaGiangVienNamHoc(int start, int pageLength, System.String maQuanLy, System.String namHoc, System.String loaiKhoiLuong, System.String lanChotHk01, System.String lanChotHk02, System.String lanChotHk03)
		{
			return GetByMaGiangVienNamHoc(null, start, pageLength , maQuanLy, namHoc, loaiKhoiLuong, lanChotHk01, lanChotHk02, lanChotHk03);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetByMaGiangVienNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="loaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk03"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaGiangVienNamHoc(TransactionManager transactionManager, System.String maQuanLy, System.String namHoc, System.String loaiKhoiLuong, System.String lanChotHk01, System.String lanChotHk02, System.String lanChotHk03)
		{
			return GetByMaGiangVienNamHoc(transactionManager, 0, int.MaxValue , maQuanLy, namHoc, loaiKhoiLuong, lanChotHk01, lanChotHk02, lanChotHk03);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetByMaGiangVienNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="loaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk03"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByMaGiangVienNamHoc(TransactionManager transactionManager, int start, int pageLength , System.String maQuanLy, System.String namHoc, System.String loaiKhoiLuong, System.String lanChotHk01, System.String lanChotHk02, System.String lanChotHk03);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_GetSoTietCoiThi 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoTietCoiThi' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaToChuc"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanThi"> A <c>System.Int32</c> instance.</param>
		/// <param name="heDaoTao"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetSoTietCoiThi(System.String maQuanLy, System.String maKhoaToChuc, System.String namHoc, System.String hocKy, System.Int32 lanThi, System.String heDaoTao)
		{
			return GetSoTietCoiThi(null, 0, int.MaxValue , maQuanLy, maKhoaToChuc, namHoc, hocKy, lanThi, heDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoTietCoiThi' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaToChuc"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanThi"> A <c>System.Int32</c> instance.</param>
		/// <param name="heDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetSoTietCoiThi(int start, int pageLength, System.String maQuanLy, System.String maKhoaToChuc, System.String namHoc, System.String hocKy, System.Int32 lanThi, System.String heDaoTao)
		{
			return GetSoTietCoiThi(null, start, pageLength , maQuanLy, maKhoaToChuc, namHoc, hocKy, lanThi, heDaoTao);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoTietCoiThi' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaToChuc"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanThi"> A <c>System.Int32</c> instance.</param>
		/// <param name="heDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetSoTietCoiThi(TransactionManager transactionManager, System.String maQuanLy, System.String maKhoaToChuc, System.String namHoc, System.String hocKy, System.Int32 lanThi, System.String heDaoTao)
		{
			return GetSoTietCoiThi(transactionManager, 0, int.MaxValue , maQuanLy, maKhoaToChuc, namHoc, hocKy, lanThi, heDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoTietCoiThi' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaToChuc"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanThi"> A <c>System.Int32</c> instance.</param>
		/// <param name="heDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetSoTietCoiThi(TransactionManager transactionManager, int start, int pageLength , System.String maQuanLy, System.String maKhoaToChuc, System.String namHoc, System.String hocKy, System.Int32 lanThi, System.String heDaoTao);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeTienGiangLyThuyetHopDongDaiHanCtim 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangLyThuyetHopDongDaiHanCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangLyThuyetHopDongDaiHanCtim(System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangLyThuyetHopDongDaiHanCtim(null, 0, int.MaxValue , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangLyThuyetHopDongDaiHanCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangLyThuyetHopDongDaiHanCtim(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangLyThuyetHopDongDaiHanCtim(null, start, pageLength , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangLyThuyetHopDongDaiHanCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangLyThuyetHopDongDaiHanCtim(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangLyThuyetHopDongDaiHanCtim(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangLyThuyetHopDongDaiHanCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeTienGiangLyThuyetHopDongDaiHanCtim(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_KeToanXacNhanThanhToan 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_KeToanXacNhanThanhToan' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
		/// <param name="ngayChiTra"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KeToanXacNhanThanhToan(System.String xmlData, System.String dotChiTra, System.String ngayChiTra, ref System.Int32 reVal)
		{
			 KeToanXacNhanThanhToan(null, 0, int.MaxValue , xmlData, dotChiTra, ngayChiTra, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_KeToanXacNhanThanhToan' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
		/// <param name="ngayChiTra"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KeToanXacNhanThanhToan(int start, int pageLength, System.String xmlData, System.String dotChiTra, System.String ngayChiTra, ref System.Int32 reVal)
		{
			 KeToanXacNhanThanhToan(null, start, pageLength , xmlData, dotChiTra, ngayChiTra, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_KeToanXacNhanThanhToan' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
		/// <param name="ngayChiTra"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KeToanXacNhanThanhToan(TransactionManager transactionManager, System.String xmlData, System.String dotChiTra, System.String ngayChiTra, ref System.Int32 reVal)
		{
			 KeToanXacNhanThanhToan(transactionManager, 0, int.MaxValue , xmlData, dotChiTra, ngayChiTra, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_KeToanXacNhanThanhToan' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
		/// <param name="ngayChiTra"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void KeToanXacNhanThanhToan(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String dotChiTra, System.String ngayChiTra, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_GetThuLaoTamUng_Web 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetThuLaoTamUng_Web' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maQuanLyGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThuLaoTamUng_Web(System.String namHoc, System.String hocKy, System.String maQuanLyGiangVien)
		{
			return GetThuLaoTamUng_Web(null, 0, int.MaxValue , namHoc, hocKy, maQuanLyGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetThuLaoTamUng_Web' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maQuanLyGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThuLaoTamUng_Web(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maQuanLyGiangVien)
		{
			return GetThuLaoTamUng_Web(null, start, pageLength , namHoc, hocKy, maQuanLyGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetThuLaoTamUng_Web' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maQuanLyGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThuLaoTamUng_Web(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maQuanLyGiangVien)
		{
			return GetThuLaoTamUng_Web(transactionManager, 0, int.MaxValue , namHoc, hocKy, maQuanLyGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetThuLaoTamUng_Web' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maQuanLyGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetThuLaoTamUng_Web(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maQuanLyGiangVien);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeTongHop_Act 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTongHop_Act' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongHop_Act(System.String namHoc, System.String hocKy, System.Int32 maGiangVien)
		{
			return ThongKeTongHop_Act(null, 0, int.MaxValue , namHoc, hocKy, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTongHop_Act' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongHop_Act(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 maGiangVien)
		{
			return ThongKeTongHop_Act(null, start, pageLength , namHoc, hocKy, maGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTongHop_Act' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongHop_Act(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 maGiangVien)
		{
			return ThongKeTongHop_Act(transactionManager, 0, int.MaxValue , namHoc, hocKy, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTongHop_Act' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeTongHop_Act(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 maGiangVien);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_KetQuaGiangDayTheoNam 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_KetQuaGiangDayTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk03"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader KetQuaGiangDayTheoNam(System.String namHoc, System.Int32 lanChotHk01, System.Int32 lanChotHk02, System.Int32 lanChotHk03, System.String khoaDonVi, System.String loaiGiangVien)
		{
			return KetQuaGiangDayTheoNam(null, 0, int.MaxValue , namHoc, lanChotHk01, lanChotHk02, lanChotHk03, khoaDonVi, loaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_KetQuaGiangDayTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk03"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader KetQuaGiangDayTheoNam(int start, int pageLength, System.String namHoc, System.Int32 lanChotHk01, System.Int32 lanChotHk02, System.Int32 lanChotHk03, System.String khoaDonVi, System.String loaiGiangVien)
		{
			return KetQuaGiangDayTheoNam(null, start, pageLength , namHoc, lanChotHk01, lanChotHk02, lanChotHk03, khoaDonVi, loaiGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_KetQuaGiangDayTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk03"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader KetQuaGiangDayTheoNam(TransactionManager transactionManager, System.String namHoc, System.Int32 lanChotHk01, System.Int32 lanChotHk02, System.Int32 lanChotHk03, System.String khoaDonVi, System.String loaiGiangVien)
		{
			return KetQuaGiangDayTheoNam(transactionManager, 0, int.MaxValue , namHoc, lanChotHk01, lanChotHk02, lanChotHk03, khoaDonVi, loaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_KetQuaGiangDayTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk03"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader KetQuaGiangDayTheoNam(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.Int32 lanChotHk01, System.Int32 lanChotHk02, System.Int32 lanChotHk03, System.String khoaDonVi, System.String loaiGiangVien);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeTienGiangGDTCGiangVienThinhGiangCtim 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangGDTCGiangVienThinhGiangCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangGDTCGiangVienThinhGiangCtim(System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangGDTCGiangVienThinhGiangCtim(null, 0, int.MaxValue , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangGDTCGiangVienThinhGiangCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangGDTCGiangVienThinhGiangCtim(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangGDTCGiangVienThinhGiangCtim(null, start, pageLength , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangGDTCGiangVienThinhGiangCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangGDTCGiangVienThinhGiangCtim(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangGDTCGiangVienThinhGiangCtim(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangGDTCGiangVienThinhGiangCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeTienGiangGDTCGiangVienThinhGiangCtim(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeSoLuongGiangVienTheoHe 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeSoLuongGiangVienTheoHe' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeSoLuongGiangVienTheoHe(System.DateTime ngay)
		{
			return ThongKeSoLuongGiangVienTheoHe(null, 0, int.MaxValue , ngay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeSoLuongGiangVienTheoHe' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeSoLuongGiangVienTheoHe(int start, int pageLength, System.DateTime ngay)
		{
			return ThongKeSoLuongGiangVienTheoHe(null, start, pageLength , ngay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeSoLuongGiangVienTheoHe' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeSoLuongGiangVienTheoHe(TransactionManager transactionManager, System.DateTime ngay)
		{
			return ThongKeSoLuongGiangVienTheoHe(transactionManager, 0, int.MaxValue , ngay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeSoLuongGiangVienTheoHe' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeSoLuongGiangVienTheoHe(TransactionManager transactionManager, int start, int pageLength , System.DateTime ngay);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_GetSoTietChamBai 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoTietChamBai' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaToChuc"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanThi"> A <c>System.Int32</c> instance.</param>
		/// <param name="heDaoTao"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetSoTietChamBai(System.String maQuanLy, System.String maKhoaToChuc, System.String namHoc, System.String hocKy, System.Int32 lanThi, System.String heDaoTao)
		{
			return GetSoTietChamBai(null, 0, int.MaxValue , maQuanLy, maKhoaToChuc, namHoc, hocKy, lanThi, heDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoTietChamBai' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaToChuc"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanThi"> A <c>System.Int32</c> instance.</param>
		/// <param name="heDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetSoTietChamBai(int start, int pageLength, System.String maQuanLy, System.String maKhoaToChuc, System.String namHoc, System.String hocKy, System.Int32 lanThi, System.String heDaoTao)
		{
			return GetSoTietChamBai(null, start, pageLength , maQuanLy, maKhoaToChuc, namHoc, hocKy, lanThi, heDaoTao);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoTietChamBai' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaToChuc"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanThi"> A <c>System.Int32</c> instance.</param>
		/// <param name="heDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetSoTietChamBai(TransactionManager transactionManager, System.String maQuanLy, System.String maKhoaToChuc, System.String namHoc, System.String hocKy, System.Int32 lanThi, System.String heDaoTao)
		{
			return GetSoTietChamBai(transactionManager, 0, int.MaxValue , maQuanLy, maKhoaToChuc, namHoc, hocKy, lanThi, heDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoTietChamBai' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaToChuc"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanThi"> A <c>System.Int32</c> instance.</param>
		/// <param name="heDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetSoTietChamBai(TransactionManager transactionManager, int start, int pageLength , System.String maQuanLy, System.String maKhoaToChuc, System.String namHoc, System.String hocKy, System.Int32 lanThi, System.String heDaoTao);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_GetThuLaoThinhGiangNamHocHocKyDonViBacDaoTao 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetThuLaoThinhGiangNamHocHocKyDonViBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThuLaoThinhGiangNamHocHocKyDonViBacDaoTao(System.String namHoc, System.String hocKy, System.String bacDaoTao, System.String donVi)
		{
			return GetThuLaoThinhGiangNamHocHocKyDonViBacDaoTao(null, 0, int.MaxValue , namHoc, hocKy, bacDaoTao, donVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetThuLaoThinhGiangNamHocHocKyDonViBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThuLaoThinhGiangNamHocHocKyDonViBacDaoTao(int start, int pageLength, System.String namHoc, System.String hocKy, System.String bacDaoTao, System.String donVi)
		{
			return GetThuLaoThinhGiangNamHocHocKyDonViBacDaoTao(null, start, pageLength , namHoc, hocKy, bacDaoTao, donVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetThuLaoThinhGiangNamHocHocKyDonViBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThuLaoThinhGiangNamHocHocKyDonViBacDaoTao(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String bacDaoTao, System.String donVi)
		{
			return GetThuLaoThinhGiangNamHocHocKyDonViBacDaoTao(transactionManager, 0, int.MaxValue , namHoc, hocKy, bacDaoTao, donVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetThuLaoThinhGiangNamHocHocKyDonViBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetThuLaoThinhGiangNamHocHocKyDonViBacDaoTao(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String bacDaoTao, System.String donVi);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_GetKhoiLuongChiTietHbu 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetKhoiLuongChiTietHbu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="listMaGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetKhoiLuongChiTietHbu(System.String namHoc, System.String hocKy, System.String listMaGiangVien)
		{
			return GetKhoiLuongChiTietHbu(null, 0, int.MaxValue , namHoc, hocKy, listMaGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetKhoiLuongChiTietHbu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="listMaGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetKhoiLuongChiTietHbu(int start, int pageLength, System.String namHoc, System.String hocKy, System.String listMaGiangVien)
		{
			return GetKhoiLuongChiTietHbu(null, start, pageLength , namHoc, hocKy, listMaGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetKhoiLuongChiTietHbu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="listMaGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetKhoiLuongChiTietHbu(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String listMaGiangVien)
		{
			return GetKhoiLuongChiTietHbu(transactionManager, 0, int.MaxValue , namHoc, hocKy, listMaGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetKhoiLuongChiTietHbu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="listMaGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetKhoiLuongChiTietHbu(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String listMaGiangVien);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_BangTongHopGioGiangTheoKhoa 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangTongHopGioGiangTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangTongHopGioGiangTheoKhoa(System.String namHoc, System.String hocKy, System.String donVi, System.Int32 lanChot)
		{
			return BangTongHopGioGiangTheoKhoa(null, 0, int.MaxValue , namHoc, hocKy, donVi, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangTongHopGioGiangTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangTongHopGioGiangTheoKhoa(int start, int pageLength, System.String namHoc, System.String hocKy, System.String donVi, System.Int32 lanChot)
		{
			return BangTongHopGioGiangTheoKhoa(null, start, pageLength , namHoc, hocKy, donVi, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangTongHopGioGiangTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangTongHopGioGiangTheoKhoa(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String donVi, System.Int32 lanChot)
		{
			return BangTongHopGioGiangTheoKhoa(transactionManager, 0, int.MaxValue , namHoc, hocKy, donVi, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangTongHopGioGiangTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader BangTongHopGioGiangTheoKhoa(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String donVi, System.Int32 lanChot);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_GetNhiemVuGiangDay 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetNhiemVuGiangDay' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetNhiemVuGiangDay(System.String namHoc, System.String hocKy, System.Int32 maGiangVien)
		{
			return GetNhiemVuGiangDay(null, 0, int.MaxValue , namHoc, hocKy, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetNhiemVuGiangDay' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetNhiemVuGiangDay(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 maGiangVien)
		{
			return GetNhiemVuGiangDay(null, start, pageLength , namHoc, hocKy, maGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetNhiemVuGiangDay' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetNhiemVuGiangDay(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 maGiangVien)
		{
			return GetNhiemVuGiangDay(transactionManager, 0, int.MaxValue , namHoc, hocKy, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetNhiemVuGiangDay' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetNhiemVuGiangDay(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 maGiangVien);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeTongHopThanhToanThuLaoCtim 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTongHopThanhToanThuLaoCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongHopThanhToanThuLaoCtim(System.String namHoc, System.String hocKy, System.String maDonVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return ThongKeTongHopThanhToanThuLaoCtim(null, 0, int.MaxValue , namHoc, hocKy, maDonVi, loaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTongHopThanhToanThuLaoCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongHopThanhToanThuLaoCtim(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return ThongKeTongHopThanhToanThuLaoCtim(null, start, pageLength , namHoc, hocKy, maDonVi, loaiGiangVien, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTongHopThanhToanThuLaoCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongHopThanhToanThuLaoCtim(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return ThongKeTongHopThanhToanThuLaoCtim(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi, loaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTongHopThanhToanThuLaoCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeTongHopThanhToanThuLaoCtim(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi, System.String loaiGiangVien, System.Int32 lanChot);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeKhoiLuongGiangDayTheoBoMon 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeKhoiLuongGiangDayTheoBoMon' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="boMon"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeKhoiLuongGiangDayTheoBoMon(System.String namHoc, System.String hocKy, System.String boMon, System.Int32 lanChot)
		{
			return ThongKeKhoiLuongGiangDayTheoBoMon(null, 0, int.MaxValue , namHoc, hocKy, boMon, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeKhoiLuongGiangDayTheoBoMon' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="boMon"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeKhoiLuongGiangDayTheoBoMon(int start, int pageLength, System.String namHoc, System.String hocKy, System.String boMon, System.Int32 lanChot)
		{
			return ThongKeKhoiLuongGiangDayTheoBoMon(null, start, pageLength , namHoc, hocKy, boMon, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeKhoiLuongGiangDayTheoBoMon' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="boMon"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeKhoiLuongGiangDayTheoBoMon(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String boMon, System.Int32 lanChot)
		{
			return ThongKeKhoiLuongGiangDayTheoBoMon(transactionManager, 0, int.MaxValue , namHoc, hocKy, boMon, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeKhoiLuongGiangDayTheoBoMon' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="boMon"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeKhoiLuongGiangDayTheoBoMon(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String boMon, System.Int32 lanChot);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeTienGiangCtim 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangCtim(System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.String maLoaiGiangVien, System.String loaiHocPhan, System.Int32 lanChot)
		{
			return ThongKeTienGiangCtim(null, 0, int.MaxValue , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, maLoaiGiangVien, loaiHocPhan, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangCtim(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.String maLoaiGiangVien, System.String loaiHocPhan, System.Int32 lanChot)
		{
			return ThongKeTienGiangCtim(null, start, pageLength , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, maLoaiGiangVien, loaiHocPhan, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangCtim(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.String maLoaiGiangVien, System.String loaiHocPhan, System.Int32 lanChot)
		{
			return ThongKeTienGiangCtim(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, maLoaiGiangVien, loaiHocPhan, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeTienGiangCtim(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.String maLoaiGiangVien, System.String loaiHocPhan, System.Int32 lanChot);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeTheoNamHocHocKyDonViLoaiGiangVienLanChot 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTheoNamHocHocKyDonViLoaiGiangVienLanChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTheoNamHocHocKyDonViLoaiGiangVienLanChot(System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return ThongKeTheoNamHocHocKyDonViLoaiGiangVienLanChot(null, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTheoNamHocHocKyDonViLoaiGiangVienLanChot' stored procedure. 
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
		public IDataReader ThongKeTheoNamHocHocKyDonViLoaiGiangVienLanChot(int start, int pageLength, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return ThongKeTheoNamHocHocKyDonViLoaiGiangVienLanChot(null, start, pageLength , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTheoNamHocHocKyDonViLoaiGiangVienLanChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTheoNamHocHocKyDonViLoaiGiangVienLanChot(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return ThongKeTheoNamHocHocKyDonViLoaiGiangVienLanChot(transactionManager, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTheoNamHocHocKyDonViLoaiGiangVienLanChot' stored procedure. 
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
		public abstract IDataReader ThongKeTheoNamHocHocKyDonViLoaiGiangVienLanChot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_GetSoLanChotTheoKhoa 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoLanChotTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetSoLanChotTheoKhoa(System.String namHoc, System.String hocKy, System.String khoaDonVi, ref System.Int32 ketQua)
		{
			 GetSoLanChotTheoKhoa(null, 0, int.MaxValue , namHoc, hocKy, khoaDonVi, ref ketQua);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoLanChotTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetSoLanChotTheoKhoa(int start, int pageLength, System.String namHoc, System.String hocKy, System.String khoaDonVi, ref System.Int32 ketQua)
		{
			 GetSoLanChotTheoKhoa(null, start, pageLength , namHoc, hocKy, khoaDonVi, ref ketQua);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoLanChotTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetSoLanChotTheoKhoa(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String khoaDonVi, ref System.Int32 ketQua)
		{
			 GetSoLanChotTheoKhoa(transactionManager, 0, int.MaxValue , namHoc, hocKy, khoaDonVi, ref ketQua);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoLanChotTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetSoLanChotTheoKhoa(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String khoaDonVi, ref System.Int32 ketQua);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_BangKeKetQuaGiangDayTheoNam 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangKeKetQuaGiangDayTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="listHocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangKeKetQuaGiangDayTheoNam(System.String namHoc, System.String listHocKy, System.String khoaDonVi, System.String loaiGiangVien)
		{
			return BangKeKetQuaGiangDayTheoNam(null, 0, int.MaxValue , namHoc, listHocKy, khoaDonVi, loaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangKeKetQuaGiangDayTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="listHocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangKeKetQuaGiangDayTheoNam(int start, int pageLength, System.String namHoc, System.String listHocKy, System.String khoaDonVi, System.String loaiGiangVien)
		{
			return BangKeKetQuaGiangDayTheoNam(null, start, pageLength , namHoc, listHocKy, khoaDonVi, loaiGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangKeKetQuaGiangDayTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="listHocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangKeKetQuaGiangDayTheoNam(TransactionManager transactionManager, System.String namHoc, System.String listHocKy, System.String khoaDonVi, System.String loaiGiangVien)
		{
			return BangKeKetQuaGiangDayTheoNam(transactionManager, 0, int.MaxValue , namHoc, listHocKy, khoaDonVi, loaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangKeKetQuaGiangDayTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="listHocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader BangKeKetQuaGiangDayTheoNam(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String listHocKy, System.String khoaDonVi, System.String loaiGiangVien);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeThanhToanTienGiang 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeThanhToanTienGiang' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeThanhToanTienGiang(System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot, System.String dotChiTra)
		{
			return ThongKeThanhToanTienGiang(null, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien, lanChot, dotChiTra);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeThanhToanTienGiang' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeThanhToanTienGiang(int start, int pageLength, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot, System.String dotChiTra)
		{
			return ThongKeThanhToanTienGiang(null, start, pageLength , namHoc, hocKy, donVi, loaiGiangVien, lanChot, dotChiTra);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeThanhToanTienGiang' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeThanhToanTienGiang(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot, System.String dotChiTra)
		{
			return ThongKeThanhToanTienGiang(transactionManager, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien, lanChot, dotChiTra);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeThanhToanTienGiang' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeThanhToanTienGiang(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot, System.String dotChiTra);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_GetSoLanChotTheoDot 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoLanChotTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetSoLanChotTheoDot(System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio, System.String bacDaoTao, System.String loaiHinhDaoTao, ref System.Int32 ketQua)
		{
			 GetSoLanChotTheoDot(null, 0, int.MaxValue , namHoc, hocKy, maCauHinhChotGio, bacDaoTao, loaiHinhDaoTao, ref ketQua);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoLanChotTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetSoLanChotTheoDot(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio, System.String bacDaoTao, System.String loaiHinhDaoTao, ref System.Int32 ketQua)
		{
			 GetSoLanChotTheoDot(null, start, pageLength , namHoc, hocKy, maCauHinhChotGio, bacDaoTao, loaiHinhDaoTao, ref ketQua);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoLanChotTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetSoLanChotTheoDot(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio, System.String bacDaoTao, System.String loaiHinhDaoTao, ref System.Int32 ketQua)
		{
			 GetSoLanChotTheoDot(transactionManager, 0, int.MaxValue , namHoc, hocKy, maCauHinhChotGio, bacDaoTao, loaiHinhDaoTao, ref ketQua);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetSoLanChotTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetSoLanChotTheoDot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio, System.String bacDaoTao, System.String loaiHinhDaoTao, ref System.Int32 ketQua);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_BangKeThanhToanDot4 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangKeThanhToanDot4' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangKeThanhToanDot4(System.String namHoc, System.String donVi, System.String loaiGiangVien)
		{
			return BangKeThanhToanDot4(null, 0, int.MaxValue , namHoc, donVi, loaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangKeThanhToanDot4' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangKeThanhToanDot4(int start, int pageLength, System.String namHoc, System.String donVi, System.String loaiGiangVien)
		{
			return BangKeThanhToanDot4(null, start, pageLength , namHoc, donVi, loaiGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangKeThanhToanDot4' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangKeThanhToanDot4(TransactionManager transactionManager, System.String namHoc, System.String donVi, System.String loaiGiangVien)
		{
			return BangKeThanhToanDot4(transactionManager, 0, int.MaxValue , namHoc, donVi, loaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangKeThanhToanDot4' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader BangKeThanhToanDot4(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String donVi, System.String loaiGiangVien);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_BangKeThanhToanTheoNamLaw 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangKeThanhToanTheoNamLaw' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangKeThanhToanTheoNamLaw(System.String namHoc, System.String lanChotHk01, System.String lanChotHk02, System.String bacDaoTao, System.String loaiHinhDaoTao, System.String khoaDonVi, System.String loaiGiangVien)
		{
			return BangKeThanhToanTheoNamLaw(null, 0, int.MaxValue , namHoc, lanChotHk01, lanChotHk02, bacDaoTao, loaiHinhDaoTao, khoaDonVi, loaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangKeThanhToanTheoNamLaw' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangKeThanhToanTheoNamLaw(int start, int pageLength, System.String namHoc, System.String lanChotHk01, System.String lanChotHk02, System.String bacDaoTao, System.String loaiHinhDaoTao, System.String khoaDonVi, System.String loaiGiangVien)
		{
			return BangKeThanhToanTheoNamLaw(null, start, pageLength , namHoc, lanChotHk01, lanChotHk02, bacDaoTao, loaiHinhDaoTao, khoaDonVi, loaiGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangKeThanhToanTheoNamLaw' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangKeThanhToanTheoNamLaw(TransactionManager transactionManager, System.String namHoc, System.String lanChotHk01, System.String lanChotHk02, System.String bacDaoTao, System.String loaiHinhDaoTao, System.String khoaDonVi, System.String loaiGiangVien)
		{
			return BangKeThanhToanTheoNamLaw(transactionManager, 0, int.MaxValue , namHoc, lanChotHk01, lanChotHk02, bacDaoTao, loaiHinhDaoTao, khoaDonVi, loaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangKeThanhToanTheoNamLaw' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader BangKeThanhToanTheoNamLaw(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String lanChotHk01, System.String lanChotHk02, System.String bacDaoTao, System.String loaiHinhDaoTao, System.String khoaDonVi, System.String loaiGiangVien);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeGioNghiaVuCaNam 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeGioNghiaVuCaNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeGioNghiaVuCaNam(System.String namHoc, System.String donVi)
		{
			return ThongKeGioNghiaVuCaNam(null, 0, int.MaxValue , namHoc, donVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeGioNghiaVuCaNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeGioNghiaVuCaNam(int start, int pageLength, System.String namHoc, System.String donVi)
		{
			return ThongKeGioNghiaVuCaNam(null, start, pageLength , namHoc, donVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeGioNghiaVuCaNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeGioNghiaVuCaNam(TransactionManager transactionManager, System.String namHoc, System.String donVi)
		{
			return ThongKeGioNghiaVuCaNam(transactionManager, 0, int.MaxValue , namHoc, donVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeGioNghiaVuCaNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeGioNghiaVuCaNam(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String donVi);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_DanhSachChiTienCanBoCoHuuVuotGio 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_DanhSachChiTienCanBoCoHuuVuotGio' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader DanhSachChiTienCanBoCoHuuVuotGio(System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return DanhSachChiTienCanBoCoHuuVuotGio(null, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_DanhSachChiTienCanBoCoHuuVuotGio' stored procedure. 
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
		public IDataReader DanhSachChiTienCanBoCoHuuVuotGio(int start, int pageLength, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return DanhSachChiTienCanBoCoHuuVuotGio(null, start, pageLength , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_DanhSachChiTienCanBoCoHuuVuotGio' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader DanhSachChiTienCanBoCoHuuVuotGio(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return DanhSachChiTienCanBoCoHuuVuotGio(transactionManager, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_DanhSachChiTienCanBoCoHuuVuotGio' stored procedure. 
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
		public abstract IDataReader DanhSachChiTienCanBoCoHuuVuotGio(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeTienGiangTttnGiangVienThinhGiangCtim 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangTttnGiangVienThinhGiangCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangTttnGiangVienThinhGiangCtim(System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangTttnGiangVienThinhGiangCtim(null, 0, int.MaxValue , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangTttnGiangVienThinhGiangCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangTttnGiangVienThinhGiangCtim(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangTttnGiangVienThinhGiangCtim(null, start, pageLength , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangTttnGiangVienThinhGiangCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangTttnGiangVienThinhGiangCtim(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangTttnGiangVienThinhGiangCtim(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangTttnGiangVienThinhGiangCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeTienGiangTttnGiangVienThinhGiangCtim(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_TongHopGioGiangIuh 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_TongHopGioGiangIuh' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader TongHopGioGiangIuh(System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien)
		{
			return TongHopGioGiangIuh(null, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_TongHopGioGiangIuh' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader TongHopGioGiangIuh(int start, int pageLength, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien)
		{
			return TongHopGioGiangIuh(null, start, pageLength , namHoc, hocKy, donVi, loaiGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_TongHopGioGiangIuh' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader TongHopGioGiangIuh(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien)
		{
			return TongHopGioGiangIuh(transactionManager, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_TongHopGioGiangIuh' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader TongHopGioGiangIuh(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ChotThanhToanTheoDot 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ChotThanhToanTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ChotThanhToanTheoDot(System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio, System.String bacDaoTao, System.String loaiHinhDaoTao, System.Int32 lanChot, ref System.Int32 reVal)
		{
			 ChotThanhToanTheoDot(null, 0, int.MaxValue , namHoc, hocKy, maCauHinhChotGio, bacDaoTao, loaiHinhDaoTao, lanChot, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ChotThanhToanTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ChotThanhToanTheoDot(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio, System.String bacDaoTao, System.String loaiHinhDaoTao, System.Int32 lanChot, ref System.Int32 reVal)
		{
			 ChotThanhToanTheoDot(null, start, pageLength , namHoc, hocKy, maCauHinhChotGio, bacDaoTao, loaiHinhDaoTao, lanChot, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ChotThanhToanTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ChotThanhToanTheoDot(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio, System.String bacDaoTao, System.String loaiHinhDaoTao, System.Int32 lanChot, ref System.Int32 reVal)
		{
			 ChotThanhToanTheoDot(transactionManager, 0, int.MaxValue , namHoc, hocKy, maCauHinhChotGio, bacDaoTao, loaiHinhDaoTao, lanChot, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ChotThanhToanTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void ChotThanhToanTheoDot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio, System.String bacDaoTao, System.String loaiHinhDaoTao, System.Int32 lanChot, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_DsThanhToanThuLaoBoSung 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_DsThanhToanThuLaoBoSung' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader DsThanhToanThuLaoBoSung(System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return DsThanhToanThuLaoBoSung(null, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_DsThanhToanThuLaoBoSung' stored procedure. 
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
		public IDataReader DsThanhToanThuLaoBoSung(int start, int pageLength, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return DsThanhToanThuLaoBoSung(null, start, pageLength , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_DsThanhToanThuLaoBoSung' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader DsThanhToanThuLaoBoSung(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return DsThanhToanThuLaoBoSung(transactionManager, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_DsThanhToanThuLaoBoSung' stored procedure. 
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
		public abstract IDataReader DsThanhToanThuLaoBoSung(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeGioGiangTheoLop_Act 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeGioGiangTheoLop_Act' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeGioGiangTheoLop_Act(System.String namHoc, System.String hocKy)
		{
			return ThongKeGioGiangTheoLop_Act(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeGioGiangTheoLop_Act' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeGioGiangTheoLop_Act(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return ThongKeGioGiangTheoLop_Act(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeGioGiangTheoLop_Act' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeGioGiangTheoLop_Act(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return ThongKeGioGiangTheoLop_Act(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeGioGiangTheoLop_Act' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeGioGiangTheoLop_Act(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeTienGiangTttnGiangVienHopDongDaiHanCtim 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangTttnGiangVienHopDongDaiHanCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangTttnGiangVienHopDongDaiHanCtim(System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangTttnGiangVienHopDongDaiHanCtim(null, 0, int.MaxValue , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangTttnGiangVienHopDongDaiHanCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangTttnGiangVienHopDongDaiHanCtim(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangTttnGiangVienHopDongDaiHanCtim(null, start, pageLength , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangTttnGiangVienHopDongDaiHanCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTienGiangTttnGiangVienHopDongDaiHanCtim(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot)
		{
			return ThongKeTienGiangTttnGiangVienHopDongDaiHanCtim(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi, maBacDaoTao, maKhoaHoc, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTienGiangTttnGiangVienHopDongDaiHanCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeTienGiangTttnGiangVienHopDongDaiHanCtim(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 lanChot);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_LuuNgayChiTra 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_LuuNgayChiTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayChiTra"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuNgayChiTra(System.String namHoc, System.String hocKy, System.Int32 lanChot, System.String ngayChiTra, ref System.Int32 reVal)
		{
			 LuuNgayChiTra(null, 0, int.MaxValue , namHoc, hocKy, lanChot, ngayChiTra, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_LuuNgayChiTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayChiTra"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuNgayChiTra(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 lanChot, System.String ngayChiTra, ref System.Int32 reVal)
		{
			 LuuNgayChiTra(null, start, pageLength , namHoc, hocKy, lanChot, ngayChiTra, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_LuuNgayChiTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayChiTra"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuNgayChiTra(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 lanChot, System.String ngayChiTra, ref System.Int32 reVal)
		{
			 LuuNgayChiTra(transactionManager, 0, int.MaxValue , namHoc, hocKy, lanChot, ngayChiTra, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_LuuNgayChiTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayChiTra"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LuuNgayChiTra(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 lanChot, System.String ngayChiTra, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeChiTietGioGiangBuh 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeChiTietGioGiangBuh' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeChiTietGioGiangBuh(System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return ThongKeChiTietGioGiangBuh(null, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeChiTietGioGiangBuh' stored procedure. 
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
		public IDataReader ThongKeChiTietGioGiangBuh(int start, int pageLength, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return ThongKeChiTietGioGiangBuh(null, start, pageLength , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeChiTietGioGiangBuh' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeChiTietGioGiangBuh(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return ThongKeChiTietGioGiangBuh(transactionManager, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeChiTietGioGiangBuh' stored procedure. 
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
		public abstract IDataReader ThongKeChiTietGioGiangBuh(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeTongHopGioGiangTheoDot 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTongHopGioGiangTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongHopGioGiangTheoDot(System.String namHoc, System.String hocKy, System.String dotThanhToan, System.String loaiGiangVien, System.String loaiHinhDaoTao)
		{
			return ThongKeTongHopGioGiangTheoDot(null, 0, int.MaxValue , namHoc, hocKy, dotThanhToan, loaiGiangVien, loaiHinhDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTongHopGioGiangTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongHopGioGiangTheoDot(int start, int pageLength, System.String namHoc, System.String hocKy, System.String dotThanhToan, System.String loaiGiangVien, System.String loaiHinhDaoTao)
		{
			return ThongKeTongHopGioGiangTheoDot(null, start, pageLength , namHoc, hocKy, dotThanhToan, loaiGiangVien, loaiHinhDaoTao);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTongHopGioGiangTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongHopGioGiangTheoDot(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String dotThanhToan, System.String loaiGiangVien, System.String loaiHinhDaoTao)
		{
			return ThongKeTongHopGioGiangTheoDot(transactionManager, 0, int.MaxValue , namHoc, hocKy, dotThanhToan, loaiGiangVien, loaiHinhDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTongHopGioGiangTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeTongHopGioGiangTheoDot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String dotThanhToan, System.String loaiGiangVien, System.String loaiHinhDaoTao);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeGioCoiThiChamBaiRaDeTheoHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeGioCoiThiChamBaiRaDeTheoHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="heDaoTao"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeGioCoiThiChamBaiRaDeTheoHocKy(System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.String heDaoTao)
		{
			return ThongKeGioCoiThiChamBaiRaDeTheoHocKy(null, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien, heDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeGioCoiThiChamBaiRaDeTheoHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="heDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeGioCoiThiChamBaiRaDeTheoHocKy(int start, int pageLength, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.String heDaoTao)
		{
			return ThongKeGioCoiThiChamBaiRaDeTheoHocKy(null, start, pageLength , namHoc, hocKy, donVi, loaiGiangVien, heDaoTao);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeGioCoiThiChamBaiRaDeTheoHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="heDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeGioCoiThiChamBaiRaDeTheoHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.String heDaoTao)
		{
			return ThongKeGioCoiThiChamBaiRaDeTheoHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien, heDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeGioCoiThiChamBaiRaDeTheoHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="heDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeGioCoiThiChamBaiRaDeTheoHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.String heDaoTao);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_TongHopThanhToanThuLaoVuotGioGiangVienCoHuu 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_TongHopThanhToanThuLaoVuotGioGiangVienCoHuu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader TongHopThanhToanThuLaoVuotGioGiangVienCoHuu(System.String namHoc, System.String bacDaoTao, System.String khoaDonVi)
		{
			return TongHopThanhToanThuLaoVuotGioGiangVienCoHuu(null, 0, int.MaxValue , namHoc, bacDaoTao, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_TongHopThanhToanThuLaoVuotGioGiangVienCoHuu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader TongHopThanhToanThuLaoVuotGioGiangVienCoHuu(int start, int pageLength, System.String namHoc, System.String bacDaoTao, System.String khoaDonVi)
		{
			return TongHopThanhToanThuLaoVuotGioGiangVienCoHuu(null, start, pageLength , namHoc, bacDaoTao, khoaDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_TongHopThanhToanThuLaoVuotGioGiangVienCoHuu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader TongHopThanhToanThuLaoVuotGioGiangVienCoHuu(TransactionManager transactionManager, System.String namHoc, System.String bacDaoTao, System.String khoaDonVi)
		{
			return TongHopThanhToanThuLaoVuotGioGiangVienCoHuu(transactionManager, 0, int.MaxValue , namHoc, bacDaoTao, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_TongHopThanhToanThuLaoVuotGioGiangVienCoHuu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader TongHopThanhToanThuLaoVuotGioGiangVienCoHuu(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String bacDaoTao, System.String khoaDonVi);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_BangKeVuotGioGiangBuh 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangKeVuotGioGiangBuh' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangKeVuotGioGiangBuh(System.String xmlData, System.String namHoc, System.String hocKy, System.Int32 lanChot)
		{
			return BangKeVuotGioGiangBuh(null, 0, int.MaxValue , xmlData, namHoc, hocKy, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangKeVuotGioGiangBuh' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangKeVuotGioGiangBuh(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, System.Int32 lanChot)
		{
			return BangKeVuotGioGiangBuh(null, start, pageLength , xmlData, namHoc, hocKy, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangKeVuotGioGiangBuh' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangKeVuotGioGiangBuh(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, System.Int32 lanChot)
		{
			return BangKeVuotGioGiangBuh(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_BangKeVuotGioGiangBuh' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader BangKeVuotGioGiangBuh(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, System.Int32 lanChot);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeGiangVienThieuTiet 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeGiangVienThieuTiet' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeGiangVienThieuTiet(System.String namHoc, System.String donVi, System.String loaiGiangVien, System.Int32 lanChotHk01, System.Int32 lanChotHk02)
		{
			return ThongKeGiangVienThieuTiet(null, 0, int.MaxValue , namHoc, donVi, loaiGiangVien, lanChotHk01, lanChotHk02);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeGiangVienThieuTiet' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeGiangVienThieuTiet(int start, int pageLength, System.String namHoc, System.String donVi, System.String loaiGiangVien, System.Int32 lanChotHk01, System.Int32 lanChotHk02)
		{
			return ThongKeGiangVienThieuTiet(null, start, pageLength , namHoc, donVi, loaiGiangVien, lanChotHk01, lanChotHk02);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeGiangVienThieuTiet' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeGiangVienThieuTiet(TransactionManager transactionManager, System.String namHoc, System.String donVi, System.String loaiGiangVien, System.Int32 lanChotHk01, System.Int32 lanChotHk02)
		{
			return ThongKeGiangVienThieuTiet(transactionManager, 0, int.MaxValue , namHoc, donVi, loaiGiangVien, lanChotHk01, lanChotHk02);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeGiangVienThieuTiet' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeGiangVienThieuTiet(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String donVi, System.String loaiGiangVien, System.Int32 lanChotHk01, System.Int32 lanChotHk02);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeTongHopVhu 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTongHopVhu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongHopVhu(System.String namHoc, System.String khoaDonVi)
		{
			return ThongKeTongHopVhu(null, 0, int.MaxValue , namHoc, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTongHopVhu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongHopVhu(int start, int pageLength, System.String namHoc, System.String khoaDonVi)
		{
			return ThongKeTongHopVhu(null, start, pageLength , namHoc, khoaDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTongHopVhu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongHopVhu(TransactionManager transactionManager, System.String namHoc, System.String khoaDonVi)
		{
			return ThongKeTongHopVhu(transactionManager, 0, int.MaxValue , namHoc, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeTongHopVhu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeTongHopVhu(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String khoaDonVi);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_ThongKeChung_DLU 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeChung_DLU' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="loaiThongKe"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ThongKeChung_DLU(System.String namHoc, System.String hocKy, System.String donVi, System.String dotThanhToan, System.String loaiGiangVien, System.String loaiHinhDaoTao, System.Int32 loaiThongKe)
		{
			 ThongKeChung_DLU(null, 0, int.MaxValue , namHoc, hocKy, donVi, dotThanhToan, loaiGiangVien, loaiHinhDaoTao, loaiThongKe);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeChung_DLU' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="loaiThongKe"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ThongKeChung_DLU(int start, int pageLength, System.String namHoc, System.String hocKy, System.String donVi, System.String dotThanhToan, System.String loaiGiangVien, System.String loaiHinhDaoTao, System.Int32 loaiThongKe)
		{
			 ThongKeChung_DLU(null, start, pageLength , namHoc, hocKy, donVi, dotThanhToan, loaiGiangVien, loaiHinhDaoTao, loaiThongKe);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeChung_DLU' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="loaiThongKe"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ThongKeChung_DLU(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String donVi, System.String dotThanhToan, System.String loaiGiangVien, System.String loaiHinhDaoTao, System.Int32 loaiThongKe)
		{
			 ThongKeChung_DLU(transactionManager, 0, int.MaxValue , namHoc, hocKy, donVi, dotThanhToan, loaiGiangVien, loaiHinhDaoTao, loaiThongKe);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_ThongKeChung_DLU' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="loaiThongKe"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void ThongKeChung_DLU(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String donVi, System.String dotThanhToan, System.String loaiGiangVien, System.String loaiHinhDaoTao, System.Int32 loaiThongKe);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_GetByNamHocHocKyLanChotKhoaDonVi 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetByNamHocHocKyLanChotKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyLanChotKhoaDonVi(System.String namHoc, System.String hocKy, System.Int32 lanChot, System.String khoaDonVi)
		{
			return GetByNamHocHocKyLanChotKhoaDonVi(null, 0, int.MaxValue , namHoc, hocKy, lanChot, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetByNamHocHocKyLanChotKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyLanChotKhoaDonVi(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 lanChot, System.String khoaDonVi)
		{
			return GetByNamHocHocKyLanChotKhoaDonVi(null, start, pageLength , namHoc, hocKy, lanChot, khoaDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetByNamHocHocKyLanChotKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyLanChotKhoaDonVi(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 lanChot, System.String khoaDonVi)
		{
			return GetByNamHocHocKyLanChotKhoaDonVi(transactionManager, 0, int.MaxValue , namHoc, hocKy, lanChot, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetByNamHocHocKyLanChotKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKyLanChotKhoaDonVi(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 lanChot, System.String khoaDonVi);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_GetGiangVienTamUng 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetGiangVienTamUng' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetGiangVienTamUng(System.String namHoc, System.String maDonVi)
		{
			return GetGiangVienTamUng(null, 0, int.MaxValue , namHoc, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetGiangVienTamUng' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetGiangVienTamUng(int start, int pageLength, System.String namHoc, System.String maDonVi)
		{
			return GetGiangVienTamUng(null, start, pageLength , namHoc, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetGiangVienTamUng' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetGiangVienTamUng(TransactionManager transactionManager, System.String namHoc, System.String maDonVi)
		{
			return GetGiangVienTamUng(transactionManager, 0, int.MaxValue , namHoc, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_GetGiangVienTamUng' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetGiangVienTamUng(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String maDonVi);
		
		#endregion
		
		#region cust_KetQuaThanhToanThuLao_TongHopKetQuaThanhToan_HBU 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_TongHopKetQuaThanhToan_HBU' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader TongHopKetQuaThanhToan_HBU(System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return TongHopKetQuaThanhToan_HBU(null, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_TongHopKetQuaThanhToan_HBU' stored procedure. 
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
		public IDataReader TongHopKetQuaThanhToan_HBU(int start, int pageLength, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return TongHopKetQuaThanhToan_HBU(null, start, pageLength , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_TongHopKetQuaThanhToan_HBU' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader TongHopKetQuaThanhToan_HBU(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return TongHopKetQuaThanhToan_HBU(transactionManager, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaThanhToanThuLao_TongHopKetQuaThanhToan_HBU' stored procedure. 
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
		public abstract IDataReader TongHopKetQuaThanhToan_HBU(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KetQuaThanhToanThuLao&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KetQuaThanhToanThuLao&gt;"/></returns>
		public static TList<KetQuaThanhToanThuLao> Fill(IDataReader reader, TList<KetQuaThanhToanThuLao> rows, int start, int pageLength)
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
				
				PMS.Entities.KetQuaThanhToanThuLao c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KetQuaThanhToanThuLao")
					.Append("|").Append((System.Int32)reader[((int)KetQuaThanhToanThuLaoColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KetQuaThanhToanThuLao>(
					key.ToString(), // EntityTrackingKey
					"KetQuaThanhToanThuLao",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KetQuaThanhToanThuLao();
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
					c.Id = (System.Int32)reader[(KetQuaThanhToanThuLaoColumn.Id.ToString())];
					c.MaGiangVien = (reader[KetQuaThanhToanThuLaoColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KetQuaThanhToanThuLaoColumn.MaGiangVien.ToString())];
					c.NamHoc = (reader[KetQuaThanhToanThuLaoColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.NamHoc.ToString())];
					c.HocKy = (reader[KetQuaThanhToanThuLaoColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.HocKy.ToString())];
					c.MaHocHam = (reader[KetQuaThanhToanThuLaoColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KetQuaThanhToanThuLaoColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[KetQuaThanhToanThuLaoColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KetQuaThanhToanThuLaoColumn.MaHocVi.ToString())];
					c.MaLoaiGiangVien = (reader[KetQuaThanhToanThuLaoColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KetQuaThanhToanThuLaoColumn.MaLoaiGiangVien.ToString())];
					c.MaDonVi = (reader[KetQuaThanhToanThuLaoColumn.MaDonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.MaDonVi.ToString())];
					c.Loai = (reader[KetQuaThanhToanThuLaoColumn.Loai.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.Loai.ToString())];
					c.PhanLoai = (reader[KetQuaThanhToanThuLaoColumn.PhanLoai.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.PhanLoai.ToString())];
					c.MaMonHoc = (reader[KetQuaThanhToanThuLaoColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.MaMonHoc.ToString())];
					c.TenMonHoc = (reader[KetQuaThanhToanThuLaoColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.TenMonHoc.ToString())];
					c.LoaiHocPhan = (reader[KetQuaThanhToanThuLaoColumn.LoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.LoaiHocPhan.ToString())];
					c.Nhom = (reader[KetQuaThanhToanThuLaoColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.Nhom.ToString())];
					c.MaLop = (reader[KetQuaThanhToanThuLaoColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.MaLop.ToString())];
					c.LopClc = (reader[KetQuaThanhToanThuLaoColumn.LopClc.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KetQuaThanhToanThuLaoColumn.LopClc.ToString())];
					c.SiSo = (reader[KetQuaThanhToanThuLaoColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KetQuaThanhToanThuLaoColumn.SiSo.ToString())];
					c.TietThucDay = (reader[KetQuaThanhToanThuLaoColumn.TietThucDay.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.TietThucDay.ToString())];
					c.TietChuNhat = (reader[KetQuaThanhToanThuLaoColumn.TietChuNhat.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.TietChuNhat.ToString())];
					c.HeSoHocKy = (reader[KetQuaThanhToanThuLaoColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.HeSoHocKy.ToString())];
					c.HeSoLopDong = (reader[KetQuaThanhToanThuLaoColumn.HeSoLopDong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.HeSoLopDong.ToString())];
					c.TietQuyDoi = (reader[KetQuaThanhToanThuLaoColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.TietQuyDoi.ToString())];
					c.DonGia = (reader[KetQuaThanhToanThuLaoColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.DonGia.ToString())];
					c.ThanhTien = (reader[KetQuaThanhToanThuLaoColumn.ThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.ThanhTien.ToString())];
					c.LanChot = (reader[KetQuaThanhToanThuLaoColumn.LanChot.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KetQuaThanhToanThuLaoColumn.LanChot.ToString())];
					c.NgayCapNhat = (reader[KetQuaThanhToanThuLaoColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KetQuaThanhToanThuLaoColumn.NgayCapNhat.ToString())];
					c.MaHinhThucDaoTao = (reader[KetQuaThanhToanThuLaoColumn.MaHinhThucDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.MaHinhThucDaoTao.ToString())];
					c.DonGiaTrongChuan = (reader[KetQuaThanhToanThuLaoColumn.DonGiaTrongChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.DonGiaTrongChuan.ToString())];
					c.DonGiaNgoaiChuan = (reader[KetQuaThanhToanThuLaoColumn.DonGiaNgoaiChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.DonGiaNgoaiChuan.ToString())];
					c.TenCoSo = (reader[KetQuaThanhToanThuLaoColumn.TenCoSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.TenCoSo.ToString())];
					c.HeSoQuyDoiThucHanhSangLyThuyet = (reader[KetQuaThanhToanThuLaoColumn.HeSoQuyDoiThucHanhSangLyThuyet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.HeSoQuyDoiThucHanhSangLyThuyet.ToString())];
					c.HeSoCoSo = (reader[KetQuaThanhToanThuLaoColumn.HeSoCoSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.HeSoCoSo.ToString())];
					c.SoGioThucGiangTrenLop = (reader[KetQuaThanhToanThuLaoColumn.SoGioThucGiangTrenLop.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.SoGioThucGiangTrenLop.ToString())];
					c.SoGioChuanTinhThem = (reader[KetQuaThanhToanThuLaoColumn.SoGioChuanTinhThem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.SoGioChuanTinhThem.ToString())];
					c.HeSoChucDanhChuyenMon = (reader[KetQuaThanhToanThuLaoColumn.HeSoChucDanhChuyenMon.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.HeSoChucDanhChuyenMon.ToString())];
					c.HeSoClcCntn = (reader[KetQuaThanhToanThuLaoColumn.HeSoClcCntn.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.HeSoClcCntn.ToString())];
					c.HeSoThinhGiangMonChuyenNganh = (reader[KetQuaThanhToanThuLaoColumn.HeSoThinhGiangMonChuyenNganh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.HeSoThinhGiangMonChuyenNganh.ToString())];
					c.MaNhomMonHoc = (reader[KetQuaThanhToanThuLaoColumn.MaNhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.MaNhomMonHoc.ToString())];
					c.LoaiLop = (reader[KetQuaThanhToanThuLaoColumn.LoaiLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.LoaiLop.ToString())];
					c.MaBacDaoTao = (reader[KetQuaThanhToanThuLaoColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.MaBacDaoTao.ToString())];
					c.MalopHocPhan = (reader[KetQuaThanhToanThuLaoColumn.MalopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.MalopHocPhan.ToString())];
					c.MaKhoaHoc = (reader[KetQuaThanhToanThuLaoColumn.MaKhoaHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.MaKhoaHoc.ToString())];
					c.HeSoTroCap = (reader[KetQuaThanhToanThuLaoColumn.HeSoTroCap.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.HeSoTroCap.ToString())];
					c.HeSoNgoaiGio = (reader[KetQuaThanhToanThuLaoColumn.HeSoNgoaiGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.HeSoNgoaiGio.ToString())];
					c.HeSoLuong = (reader[KetQuaThanhToanThuLaoColumn.HeSoLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.HeSoLuong.ToString())];
					c.HeSoMonMoi = (reader[KetQuaThanhToanThuLaoColumn.HeSoMonMoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.HeSoMonMoi.ToString())];
					c.HeSoNienCheTinChi = (reader[KetQuaThanhToanThuLaoColumn.HeSoNienCheTinChi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.HeSoNienCheTinChi.ToString())];
					c.HeSoNgonNgu = (reader[KetQuaThanhToanThuLaoColumn.HeSoNgonNgu.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.HeSoNgonNgu.ToString())];
					c.HeSoBacDaoTao = (reader[KetQuaThanhToanThuLaoColumn.HeSoBacDaoTao.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.HeSoBacDaoTao.ToString())];
					c.NgayChiTra = (reader[KetQuaThanhToanThuLaoColumn.NgayChiTra.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.NgayChiTra.ToString())];
					c.XacNhanChiTra = (reader[KetQuaThanhToanThuLaoColumn.XacNhanChiTra.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KetQuaThanhToanThuLaoColumn.XacNhanChiTra.ToString())];
					c.GhiChu = (reader[KetQuaThanhToanThuLaoColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.GhiChu.ToString())];
					c.NguoiCapNhat = (reader[KetQuaThanhToanThuLaoColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.NguoiCapNhat.ToString())];
					c.HeSoCongViec = (reader[KetQuaThanhToanThuLaoColumn.HeSoCongViec.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.HeSoCongViec.ToString())];
					c.NgonNguGiangDay = (reader[KetQuaThanhToanThuLaoColumn.NgonNguGiangDay.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.NgonNguGiangDay.ToString())];
					c.MaCoSo = (reader[KetQuaThanhToanThuLaoColumn.MaCoSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.MaCoSo.ToString())];
					c.MucThanhToan = (reader[KetQuaThanhToanThuLaoColumn.MucThanhToan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.MucThanhToan.ToString())];
					c.DotChiTra = (reader[KetQuaThanhToanThuLaoColumn.DotChiTra.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.DotChiTra.ToString())];
					c.HeSoKhoiNganh = (reader[KetQuaThanhToanThuLaoColumn.HeSoKhoiNganh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.HeSoKhoiNganh.ToString())];
					c.MaCauHinhChotGio = (reader[KetQuaThanhToanThuLaoColumn.MaCauHinhChotGio.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KetQuaThanhToanThuLaoColumn.MaCauHinhChotGio.ToString())];
					c.MaKhoaCuaMonHoc = (reader[KetQuaThanhToanThuLaoColumn.MaKhoaCuaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.MaKhoaCuaMonHoc.ToString())];
					c.HeSoThamNien = (reader[KetQuaThanhToanThuLaoColumn.HeSoThamNien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.HeSoThamNien.ToString())];
					c.MaLoaiHinhDaoTao = (reader[KetQuaThanhToanThuLaoColumn.MaLoaiHinhDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.MaLoaiHinhDaoTao.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KetQuaThanhToanThuLao"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KetQuaThanhToanThuLao"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KetQuaThanhToanThuLao entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(KetQuaThanhToanThuLaoColumn.Id.ToString())];
			entity.MaGiangVien = (reader[KetQuaThanhToanThuLaoColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KetQuaThanhToanThuLaoColumn.MaGiangVien.ToString())];
			entity.NamHoc = (reader[KetQuaThanhToanThuLaoColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.NamHoc.ToString())];
			entity.HocKy = (reader[KetQuaThanhToanThuLaoColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.HocKy.ToString())];
			entity.MaHocHam = (reader[KetQuaThanhToanThuLaoColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KetQuaThanhToanThuLaoColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[KetQuaThanhToanThuLaoColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KetQuaThanhToanThuLaoColumn.MaHocVi.ToString())];
			entity.MaLoaiGiangVien = (reader[KetQuaThanhToanThuLaoColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KetQuaThanhToanThuLaoColumn.MaLoaiGiangVien.ToString())];
			entity.MaDonVi = (reader[KetQuaThanhToanThuLaoColumn.MaDonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.MaDonVi.ToString())];
			entity.Loai = (reader[KetQuaThanhToanThuLaoColumn.Loai.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.Loai.ToString())];
			entity.PhanLoai = (reader[KetQuaThanhToanThuLaoColumn.PhanLoai.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.PhanLoai.ToString())];
			entity.MaMonHoc = (reader[KetQuaThanhToanThuLaoColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.MaMonHoc.ToString())];
			entity.TenMonHoc = (reader[KetQuaThanhToanThuLaoColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.TenMonHoc.ToString())];
			entity.LoaiHocPhan = (reader[KetQuaThanhToanThuLaoColumn.LoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.LoaiHocPhan.ToString())];
			entity.Nhom = (reader[KetQuaThanhToanThuLaoColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.Nhom.ToString())];
			entity.MaLop = (reader[KetQuaThanhToanThuLaoColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.MaLop.ToString())];
			entity.LopClc = (reader[KetQuaThanhToanThuLaoColumn.LopClc.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KetQuaThanhToanThuLaoColumn.LopClc.ToString())];
			entity.SiSo = (reader[KetQuaThanhToanThuLaoColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KetQuaThanhToanThuLaoColumn.SiSo.ToString())];
			entity.TietThucDay = (reader[KetQuaThanhToanThuLaoColumn.TietThucDay.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.TietThucDay.ToString())];
			entity.TietChuNhat = (reader[KetQuaThanhToanThuLaoColumn.TietChuNhat.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.TietChuNhat.ToString())];
			entity.HeSoHocKy = (reader[KetQuaThanhToanThuLaoColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.HeSoHocKy.ToString())];
			entity.HeSoLopDong = (reader[KetQuaThanhToanThuLaoColumn.HeSoLopDong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.HeSoLopDong.ToString())];
			entity.TietQuyDoi = (reader[KetQuaThanhToanThuLaoColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.TietQuyDoi.ToString())];
			entity.DonGia = (reader[KetQuaThanhToanThuLaoColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.DonGia.ToString())];
			entity.ThanhTien = (reader[KetQuaThanhToanThuLaoColumn.ThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.ThanhTien.ToString())];
			entity.LanChot = (reader[KetQuaThanhToanThuLaoColumn.LanChot.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KetQuaThanhToanThuLaoColumn.LanChot.ToString())];
			entity.NgayCapNhat = (reader[KetQuaThanhToanThuLaoColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KetQuaThanhToanThuLaoColumn.NgayCapNhat.ToString())];
			entity.MaHinhThucDaoTao = (reader[KetQuaThanhToanThuLaoColumn.MaHinhThucDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.MaHinhThucDaoTao.ToString())];
			entity.DonGiaTrongChuan = (reader[KetQuaThanhToanThuLaoColumn.DonGiaTrongChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.DonGiaTrongChuan.ToString())];
			entity.DonGiaNgoaiChuan = (reader[KetQuaThanhToanThuLaoColumn.DonGiaNgoaiChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.DonGiaNgoaiChuan.ToString())];
			entity.TenCoSo = (reader[KetQuaThanhToanThuLaoColumn.TenCoSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.TenCoSo.ToString())];
			entity.HeSoQuyDoiThucHanhSangLyThuyet = (reader[KetQuaThanhToanThuLaoColumn.HeSoQuyDoiThucHanhSangLyThuyet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.HeSoQuyDoiThucHanhSangLyThuyet.ToString())];
			entity.HeSoCoSo = (reader[KetQuaThanhToanThuLaoColumn.HeSoCoSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.HeSoCoSo.ToString())];
			entity.SoGioThucGiangTrenLop = (reader[KetQuaThanhToanThuLaoColumn.SoGioThucGiangTrenLop.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.SoGioThucGiangTrenLop.ToString())];
			entity.SoGioChuanTinhThem = (reader[KetQuaThanhToanThuLaoColumn.SoGioChuanTinhThem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.SoGioChuanTinhThem.ToString())];
			entity.HeSoChucDanhChuyenMon = (reader[KetQuaThanhToanThuLaoColumn.HeSoChucDanhChuyenMon.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.HeSoChucDanhChuyenMon.ToString())];
			entity.HeSoClcCntn = (reader[KetQuaThanhToanThuLaoColumn.HeSoClcCntn.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.HeSoClcCntn.ToString())];
			entity.HeSoThinhGiangMonChuyenNganh = (reader[KetQuaThanhToanThuLaoColumn.HeSoThinhGiangMonChuyenNganh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.HeSoThinhGiangMonChuyenNganh.ToString())];
			entity.MaNhomMonHoc = (reader[KetQuaThanhToanThuLaoColumn.MaNhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.MaNhomMonHoc.ToString())];
			entity.LoaiLop = (reader[KetQuaThanhToanThuLaoColumn.LoaiLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.LoaiLop.ToString())];
			entity.MaBacDaoTao = (reader[KetQuaThanhToanThuLaoColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.MaBacDaoTao.ToString())];
			entity.MalopHocPhan = (reader[KetQuaThanhToanThuLaoColumn.MalopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.MalopHocPhan.ToString())];
			entity.MaKhoaHoc = (reader[KetQuaThanhToanThuLaoColumn.MaKhoaHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.MaKhoaHoc.ToString())];
			entity.HeSoTroCap = (reader[KetQuaThanhToanThuLaoColumn.HeSoTroCap.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.HeSoTroCap.ToString())];
			entity.HeSoNgoaiGio = (reader[KetQuaThanhToanThuLaoColumn.HeSoNgoaiGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.HeSoNgoaiGio.ToString())];
			entity.HeSoLuong = (reader[KetQuaThanhToanThuLaoColumn.HeSoLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.HeSoLuong.ToString())];
			entity.HeSoMonMoi = (reader[KetQuaThanhToanThuLaoColumn.HeSoMonMoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.HeSoMonMoi.ToString())];
			entity.HeSoNienCheTinChi = (reader[KetQuaThanhToanThuLaoColumn.HeSoNienCheTinChi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.HeSoNienCheTinChi.ToString())];
			entity.HeSoNgonNgu = (reader[KetQuaThanhToanThuLaoColumn.HeSoNgonNgu.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.HeSoNgonNgu.ToString())];
			entity.HeSoBacDaoTao = (reader[KetQuaThanhToanThuLaoColumn.HeSoBacDaoTao.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.HeSoBacDaoTao.ToString())];
			entity.NgayChiTra = (reader[KetQuaThanhToanThuLaoColumn.NgayChiTra.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.NgayChiTra.ToString())];
			entity.XacNhanChiTra = (reader[KetQuaThanhToanThuLaoColumn.XacNhanChiTra.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KetQuaThanhToanThuLaoColumn.XacNhanChiTra.ToString())];
			entity.GhiChu = (reader[KetQuaThanhToanThuLaoColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.GhiChu.ToString())];
			entity.NguoiCapNhat = (reader[KetQuaThanhToanThuLaoColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.NguoiCapNhat.ToString())];
			entity.HeSoCongViec = (reader[KetQuaThanhToanThuLaoColumn.HeSoCongViec.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.HeSoCongViec.ToString())];
			entity.NgonNguGiangDay = (reader[KetQuaThanhToanThuLaoColumn.NgonNguGiangDay.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.NgonNguGiangDay.ToString())];
			entity.MaCoSo = (reader[KetQuaThanhToanThuLaoColumn.MaCoSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.MaCoSo.ToString())];
			entity.MucThanhToan = (reader[KetQuaThanhToanThuLaoColumn.MucThanhToan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.MucThanhToan.ToString())];
			entity.DotChiTra = (reader[KetQuaThanhToanThuLaoColumn.DotChiTra.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.DotChiTra.ToString())];
			entity.HeSoKhoiNganh = (reader[KetQuaThanhToanThuLaoColumn.HeSoKhoiNganh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.HeSoKhoiNganh.ToString())];
			entity.MaCauHinhChotGio = (reader[KetQuaThanhToanThuLaoColumn.MaCauHinhChotGio.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KetQuaThanhToanThuLaoColumn.MaCauHinhChotGio.ToString())];
			entity.MaKhoaCuaMonHoc = (reader[KetQuaThanhToanThuLaoColumn.MaKhoaCuaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.MaKhoaCuaMonHoc.ToString())];
			entity.HeSoThamNien = (reader[KetQuaThanhToanThuLaoColumn.HeSoThamNien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaThanhToanThuLaoColumn.HeSoThamNien.ToString())];
			entity.MaLoaiHinhDaoTao = (reader[KetQuaThanhToanThuLaoColumn.MaLoaiHinhDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaThanhToanThuLaoColumn.MaLoaiHinhDaoTao.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KetQuaThanhToanThuLao"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KetQuaThanhToanThuLao"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KetQuaThanhToanThuLao entity)
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
			entity.NgayChiTra = Convert.IsDBNull(dataRow["NgayChiTra"]) ? null : (System.String)dataRow["NgayChiTra"];
			entity.XacNhanChiTra = Convert.IsDBNull(dataRow["XacNhanChiTra"]) ? null : (System.Boolean?)dataRow["XacNhanChiTra"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.HeSoCongViec = Convert.IsDBNull(dataRow["HeSoCongViec"]) ? null : (System.Decimal?)dataRow["HeSoCongViec"];
			entity.NgonNguGiangDay = Convert.IsDBNull(dataRow["NgonNguGiangDay"]) ? null : (System.String)dataRow["NgonNguGiangDay"];
			entity.MaCoSo = Convert.IsDBNull(dataRow["MaCoSo"]) ? null : (System.String)dataRow["MaCoSo"];
			entity.MucThanhToan = Convert.IsDBNull(dataRow["MucThanhToan"]) ? null : (System.Decimal?)dataRow["MucThanhToan"];
			entity.DotChiTra = Convert.IsDBNull(dataRow["DotChiTra"]) ? null : (System.String)dataRow["DotChiTra"];
			entity.HeSoKhoiNganh = Convert.IsDBNull(dataRow["HeSoKhoiNganh"]) ? null : (System.Decimal?)dataRow["HeSoKhoiNganh"];
			entity.MaCauHinhChotGio = Convert.IsDBNull(dataRow["MaCauHinhChotGio"]) ? null : (System.Int32?)dataRow["MaCauHinhChotGio"];
			entity.MaKhoaCuaMonHoc = Convert.IsDBNull(dataRow["MaKhoaCuaMonHoc"]) ? null : (System.String)dataRow["MaKhoaCuaMonHoc"];
			entity.HeSoThamNien = Convert.IsDBNull(dataRow["HeSoThamNien"]) ? null : (System.Decimal?)dataRow["HeSoThamNien"];
			entity.MaLoaiHinhDaoTao = Convert.IsDBNull(dataRow["MaLoaiHinhDaoTao"]) ? null : (System.String)dataRow["MaLoaiHinhDaoTao"];
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
		/// <param name="entity">The <see cref="PMS.Entities.KetQuaThanhToanThuLao"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KetQuaThanhToanThuLao Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KetQuaThanhToanThuLao entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.KetQuaThanhToanThuLao object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KetQuaThanhToanThuLao instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KetQuaThanhToanThuLao Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KetQuaThanhToanThuLao entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region KetQuaThanhToanThuLaoChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KetQuaThanhToanThuLao</c>
	///</summary>
	public enum KetQuaThanhToanThuLaoChildEntityTypes
	{
	}
	
	#endregion KetQuaThanhToanThuLaoChildEntityTypes
	
	#region KetQuaThanhToanThuLaoFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KetQuaThanhToanThuLaoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KetQuaThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KetQuaThanhToanThuLaoFilterBuilder : SqlFilterBuilder<KetQuaThanhToanThuLaoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KetQuaThanhToanThuLaoFilterBuilder class.
		/// </summary>
		public KetQuaThanhToanThuLaoFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KetQuaThanhToanThuLaoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KetQuaThanhToanThuLaoFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KetQuaThanhToanThuLaoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KetQuaThanhToanThuLaoFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KetQuaThanhToanThuLaoFilterBuilder
	
	#region KetQuaThanhToanThuLaoParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KetQuaThanhToanThuLaoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KetQuaThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KetQuaThanhToanThuLaoParameterBuilder : ParameterizedSqlFilterBuilder<KetQuaThanhToanThuLaoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KetQuaThanhToanThuLaoParameterBuilder class.
		/// </summary>
		public KetQuaThanhToanThuLaoParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KetQuaThanhToanThuLaoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KetQuaThanhToanThuLaoParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KetQuaThanhToanThuLaoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KetQuaThanhToanThuLaoParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KetQuaThanhToanThuLaoParameterBuilder
	
	#region KetQuaThanhToanThuLaoSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KetQuaThanhToanThuLaoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KetQuaThanhToanThuLao"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KetQuaThanhToanThuLaoSortBuilder : SqlSortBuilder<KetQuaThanhToanThuLaoColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KetQuaThanhToanThuLaoSqlSortBuilder class.
		/// </summary>
		public KetQuaThanhToanThuLaoSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KetQuaThanhToanThuLaoSortBuilder
	
} // end namespace
