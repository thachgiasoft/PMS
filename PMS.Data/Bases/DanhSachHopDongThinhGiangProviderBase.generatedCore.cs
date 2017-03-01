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
	/// This class is the base class for any <see cref="DanhSachHopDongThinhGiangProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class DanhSachHopDongThinhGiangProviderBaseCore : EntityProviderBase<PMS.Entities.DanhSachHopDongThinhGiang, PMS.Entities.DanhSachHopDongThinhGiangKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.DanhSachHopDongThinhGiangKey key)
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
		public override PMS.Entities.DanhSachHopDongThinhGiang Get(TransactionManager transactionManager, PMS.Entities.DanhSachHopDongThinhGiangKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_DanhSachHopDongThinhGiang index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhSachHopDongThinhGiang"/> class.</returns>
		public PMS.Entities.DanhSachHopDongThinhGiang GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DanhSachHopDongThinhGiang index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhSachHopDongThinhGiang"/> class.</returns>
		public PMS.Entities.DanhSachHopDongThinhGiang GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DanhSachHopDongThinhGiang index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhSachHopDongThinhGiang"/> class.</returns>
		public PMS.Entities.DanhSachHopDongThinhGiang GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DanhSachHopDongThinhGiang index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhSachHopDongThinhGiang"/> class.</returns>
		public PMS.Entities.DanhSachHopDongThinhGiang GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DanhSachHopDongThinhGiang index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhSachHopDongThinhGiang"/> class.</returns>
		public PMS.Entities.DanhSachHopDongThinhGiang GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DanhSachHopDongThinhGiang index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhSachHopDongThinhGiang"/> class.</returns>
		public abstract PMS.Entities.DanhSachHopDongThinhGiang GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_DanhSachHopDongThinhGiang_GetThongTinLopHocPhan 
		
		/// <summary>
		///	This method wrap the 'cust_DanhSachHopDongThinhGiang_GetThongTinLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThongTinLopHocPhan(System.String maLopHocPhan)
		{
			return GetThongTinLopHocPhan(null, 0, int.MaxValue , maLopHocPhan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DanhSachHopDongThinhGiang_GetThongTinLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThongTinLopHocPhan(int start, int pageLength, System.String maLopHocPhan)
		{
			return GetThongTinLopHocPhan(null, start, pageLength , maLopHocPhan);
		}
				
		/// <summary>
		///	This method wrap the 'cust_DanhSachHopDongThinhGiang_GetThongTinLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThongTinLopHocPhan(TransactionManager transactionManager, System.String maLopHocPhan)
		{
			return GetThongTinLopHocPhan(transactionManager, 0, int.MaxValue , maLopHocPhan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DanhSachHopDongThinhGiang_GetThongTinLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetThongTinLopHocPhan(TransactionManager transactionManager, int start, int pageLength , System.String maLopHocPhan);
		
		#endregion
		
		#region cust_DanhSachHopDongThinhGiang_LuuThanhLyXacNhanHopDong 
		
		/// <summary>
		///	This method wrap the 'cust_DanhSachHopDongThinhGiang_LuuThanhLyXacNhanHopDong' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuThanhLyXacNhanHopDong(System.String xmlData, ref System.Int32 reVal)
		{
			 LuuThanhLyXacNhanHopDong(null, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DanhSachHopDongThinhGiang_LuuThanhLyXacNhanHopDong' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuThanhLyXacNhanHopDong(int start, int pageLength, System.String xmlData, ref System.Int32 reVal)
		{
			 LuuThanhLyXacNhanHopDong(null, start, pageLength , xmlData, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_DanhSachHopDongThinhGiang_LuuThanhLyXacNhanHopDong' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuThanhLyXacNhanHopDong(TransactionManager transactionManager, System.String xmlData, ref System.Int32 reVal)
		{
			 LuuThanhLyXacNhanHopDong(transactionManager, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DanhSachHopDongThinhGiang_LuuThanhLyXacNhanHopDong' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LuuThanhLyXacNhanHopDong(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_DanhSachHopDongThinhGiang_KiemTraSoHopDong 
		
		/// <summary>
		///	This method wrap the 'cust_DanhSachHopDongThinhGiang_KiemTraSoHopDong' stored procedure. 
		/// </summary>
		/// <param name="soHopDong"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraSoHopDong(System.String soHopDong, ref System.String reVal)
		{
			 KiemTraSoHopDong(null, 0, int.MaxValue , soHopDong, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DanhSachHopDongThinhGiang_KiemTraSoHopDong' stored procedure. 
		/// </summary>
		/// <param name="soHopDong"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraSoHopDong(int start, int pageLength, System.String soHopDong, ref System.String reVal)
		{
			 KiemTraSoHopDong(null, start, pageLength , soHopDong, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_DanhSachHopDongThinhGiang_KiemTraSoHopDong' stored procedure. 
		/// </summary>
		/// <param name="soHopDong"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraSoHopDong(TransactionManager transactionManager, System.String soHopDong, ref System.String reVal)
		{
			 KiemTraSoHopDong(transactionManager, 0, int.MaxValue , soHopDong, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DanhSachHopDongThinhGiang_KiemTraSoHopDong' stored procedure. 
		/// </summary>
		/// <param name="soHopDong"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void KiemTraSoHopDong(TransactionManager transactionManager, int start, int pageLength , System.String soHopDong, ref System.String reVal);
		
		#endregion
		
		#region cust_DanhSachHopDongThinhGiang_LayDanhSachThanhLyXacNhanHopDong 
		
		/// <summary>
		///	This method wrap the 'cust_DanhSachHopDongThinhGiang_LayDanhSachThanhLyXacNhanHopDong' stored procedure. 
		/// </summary>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="soHopDong"> A <c>System.String</c> instance.</param>
		/// <param name="boLocTheoNgay"> A <c>System.Boolean</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader LayDanhSachThanhLyXacNhanHopDong(System.String khoaDonVi, System.DateTime tuNgay, System.DateTime denNgay, System.String soHopDong, System.Boolean boLocTheoNgay)
		{
			return LayDanhSachThanhLyXacNhanHopDong(null, 0, int.MaxValue , khoaDonVi, tuNgay, denNgay, soHopDong, boLocTheoNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DanhSachHopDongThinhGiang_LayDanhSachThanhLyXacNhanHopDong' stored procedure. 
		/// </summary>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="soHopDong"> A <c>System.String</c> instance.</param>
		/// <param name="boLocTheoNgay"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader LayDanhSachThanhLyXacNhanHopDong(int start, int pageLength, System.String khoaDonVi, System.DateTime tuNgay, System.DateTime denNgay, System.String soHopDong, System.Boolean boLocTheoNgay)
		{
			return LayDanhSachThanhLyXacNhanHopDong(null, start, pageLength , khoaDonVi, tuNgay, denNgay, soHopDong, boLocTheoNgay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_DanhSachHopDongThinhGiang_LayDanhSachThanhLyXacNhanHopDong' stored procedure. 
		/// </summary>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="soHopDong"> A <c>System.String</c> instance.</param>
		/// <param name="boLocTheoNgay"> A <c>System.Boolean</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader LayDanhSachThanhLyXacNhanHopDong(TransactionManager transactionManager, System.String khoaDonVi, System.DateTime tuNgay, System.DateTime denNgay, System.String soHopDong, System.Boolean boLocTheoNgay)
		{
			return LayDanhSachThanhLyXacNhanHopDong(transactionManager, 0, int.MaxValue , khoaDonVi, tuNgay, denNgay, soHopDong, boLocTheoNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DanhSachHopDongThinhGiang_LayDanhSachThanhLyXacNhanHopDong' stored procedure. 
		/// </summary>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="soHopDong"> A <c>System.String</c> instance.</param>
		/// <param name="boLocTheoNgay"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader LayDanhSachThanhLyXacNhanHopDong(TransactionManager transactionManager, int start, int pageLength , System.String khoaDonVi, System.DateTime tuNgay, System.DateTime denNgay, System.String soHopDong, System.Boolean boLocTheoNgay);
		
		#endregion
		
		#region cust_DanhSachHopDongThinhGiang_GetSoHopDong 
		
		/// <summary>
		///	This method wrap the 'cust_DanhSachHopDongThinhGiang_GetSoHopDong' stored procedure. 
		/// </summary>
			/// <param name="soHopDong"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetSoHopDong(ref System.String soHopDong)
		{
			 GetSoHopDong(null, 0, int.MaxValue , ref soHopDong);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DanhSachHopDongThinhGiang_GetSoHopDong' stored procedure. 
		/// </summary>
			/// <param name="soHopDong"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetSoHopDong(int start, int pageLength, ref System.String soHopDong)
		{
			 GetSoHopDong(null, start, pageLength , ref soHopDong);
		}
				
		/// <summary>
		///	This method wrap the 'cust_DanhSachHopDongThinhGiang_GetSoHopDong' stored procedure. 
		/// </summary>
			/// <param name="soHopDong"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetSoHopDong(TransactionManager transactionManager, ref System.String soHopDong)
		{
			 GetSoHopDong(transactionManager, 0, int.MaxValue , ref soHopDong);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DanhSachHopDongThinhGiang_GetSoHopDong' stored procedure. 
		/// </summary>
			/// <param name="soHopDong"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetSoHopDong(TransactionManager transactionManager, int start, int pageLength , ref System.String soHopDong);
		
		#endregion
		
		#region cust_DanhSachHopDongThinhGiang_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_DanhSachHopDongThinhGiang_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, ref System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DanhSachHopDongThinhGiang_Luu' stored procedure. 
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
		///	This method wrap the 'cust_DanhSachHopDongThinhGiang_Luu' stored procedure. 
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
		///	This method wrap the 'cust_DanhSachHopDongThinhGiang_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_DanhSachHopDongThinhGiang_GetSoLuongChuaDuyet 
		
		/// <summary>
		///	This method wrap the 'cust_DanhSachHopDongThinhGiang_GetSoLuongChuaDuyet' stored procedure. 
		/// </summary>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetSoLuongChuaDuyet(ref System.Int32 reVal)
		{
			 GetSoLuongChuaDuyet(null, 0, int.MaxValue , ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DanhSachHopDongThinhGiang_GetSoLuongChuaDuyet' stored procedure. 
		/// </summary>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetSoLuongChuaDuyet(int start, int pageLength, ref System.Int32 reVal)
		{
			 GetSoLuongChuaDuyet(null, start, pageLength , ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_DanhSachHopDongThinhGiang_GetSoLuongChuaDuyet' stored procedure. 
		/// </summary>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetSoLuongChuaDuyet(TransactionManager transactionManager, ref System.Int32 reVal)
		{
			 GetSoLuongChuaDuyet(transactionManager, 0, int.MaxValue , ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DanhSachHopDongThinhGiang_GetSoLuongChuaDuyet' stored procedure. 
		/// </summary>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetSoLuongChuaDuyet(TransactionManager transactionManager, int start, int pageLength , ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;DanhSachHopDongThinhGiang&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;DanhSachHopDongThinhGiang&gt;"/></returns>
		public static TList<DanhSachHopDongThinhGiang> Fill(IDataReader reader, TList<DanhSachHopDongThinhGiang> rows, int start, int pageLength)
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
				
				PMS.Entities.DanhSachHopDongThinhGiang c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("DanhSachHopDongThinhGiang")
					.Append("|").Append((System.Int32)reader[((int)DanhSachHopDongThinhGiangColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<DanhSachHopDongThinhGiang>(
					key.ToString(), // EntityTrackingKey
					"DanhSachHopDongThinhGiang",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.DanhSachHopDongThinhGiang();
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
					c.Id = (System.Int32)reader[(DanhSachHopDongThinhGiangColumn.Id.ToString())];
					c.NamHoc = (reader[DanhSachHopDongThinhGiangColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.NamHoc.ToString())];
					c.HocKy = (reader[DanhSachHopDongThinhGiangColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.HocKy.ToString())];
					c.MaGiangVien = (reader[DanhSachHopDongThinhGiangColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DanhSachHopDongThinhGiangColumn.MaGiangVien.ToString())];
					c.HoTen = (reader[DanhSachHopDongThinhGiangColumn.HoTen.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.HoTen.ToString())];
					c.NgaySinh = (reader[DanhSachHopDongThinhGiangColumn.NgaySinh.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.NgaySinh.ToString())];
					c.SoCmnd = (reader[DanhSachHopDongThinhGiangColumn.SoCmnd.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.SoCmnd.ToString())];
					c.MaHocHam = (reader[DanhSachHopDongThinhGiangColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DanhSachHopDongThinhGiangColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[DanhSachHopDongThinhGiangColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DanhSachHopDongThinhGiangColumn.MaHocVi.ToString())];
					c.ChuyenNganh = (reader[DanhSachHopDongThinhGiangColumn.ChuyenNganh.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.ChuyenNganh.ToString())];
					c.MaSoThue = (reader[DanhSachHopDongThinhGiangColumn.MaSoThue.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.MaSoThue.ToString())];
					c.CoQuanCongTac = (reader[DanhSachHopDongThinhGiangColumn.CoQuanCongTac.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.CoQuanCongTac.ToString())];
					c.MaMonHoc = (reader[DanhSachHopDongThinhGiangColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.MaMonHoc.ToString())];
					c.MaLopHocPhan = (reader[DanhSachHopDongThinhGiangColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.MaLopHocPhan.ToString())];
					c.MaLop = (reader[DanhSachHopDongThinhGiangColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.MaLop.ToString())];
					c.SoHopDong = (reader[DanhSachHopDongThinhGiangColumn.SoHopDong.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.SoHopDong.ToString())];
					c.MaDonVi = (reader[DanhSachHopDongThinhGiangColumn.MaDonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.MaDonVi.ToString())];
					c.NgayBatDau = (reader[DanhSachHopDongThinhGiangColumn.NgayBatDau.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(DanhSachHopDongThinhGiangColumn.NgayBatDau.ToString())];
					c.NgayKetThuc = (reader[DanhSachHopDongThinhGiangColumn.NgayKetThuc.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(DanhSachHopDongThinhGiangColumn.NgayKetThuc.ToString())];
					c.SoTietLyThuyet = (reader[DanhSachHopDongThinhGiangColumn.SoTietLyThuyet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DanhSachHopDongThinhGiangColumn.SoTietLyThuyet.ToString())];
					c.SoTietThucHanh = (reader[DanhSachHopDongThinhGiangColumn.SoTietThucHanh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DanhSachHopDongThinhGiangColumn.SoTietThucHanh.ToString())];
					c.HeSoQuyDoiThucHanh = (reader[DanhSachHopDongThinhGiangColumn.HeSoQuyDoiThucHanh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DanhSachHopDongThinhGiangColumn.HeSoQuyDoiThucHanh.ToString())];
					c.SoNhomThucHanh = (reader[DanhSachHopDongThinhGiangColumn.SoNhomThucHanh.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DanhSachHopDongThinhGiangColumn.SoNhomThucHanh.ToString())];
					c.TongSoTiet = (reader[DanhSachHopDongThinhGiangColumn.TongSoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DanhSachHopDongThinhGiangColumn.TongSoTiet.ToString())];
					c.SoTietLyThuyetTrenTuan = (reader[DanhSachHopDongThinhGiangColumn.SoTietLyThuyetTrenTuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DanhSachHopDongThinhGiangColumn.SoTietLyThuyetTrenTuan.ToString())];
					c.SoTietThucHanhTrenTuan = (reader[DanhSachHopDongThinhGiangColumn.SoTietThucHanhTrenTuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DanhSachHopDongThinhGiangColumn.SoTietThucHanhTrenTuan.ToString())];
					c.TongSoTietTrenTuan = (reader[DanhSachHopDongThinhGiangColumn.TongSoTietTrenTuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DanhSachHopDongThinhGiangColumn.TongSoTietTrenTuan.ToString())];
					c.HeSoLopDong = (reader[DanhSachHopDongThinhGiangColumn.HeSoLopDong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DanhSachHopDongThinhGiangColumn.HeSoLopDong.ToString())];
					c.SiSo = (reader[DanhSachHopDongThinhGiangColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DanhSachHopDongThinhGiangColumn.SiSo.ToString())];
					c.TrangThaiHoSo = (reader[DanhSachHopDongThinhGiangColumn.TrangThaiHoSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.TrangThaiHoSo.ToString())];
					c.DonGia = (reader[DanhSachHopDongThinhGiangColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DanhSachHopDongThinhGiangColumn.DonGia.ToString())];
					c.DonViTienTe = (reader[DanhSachHopDongThinhGiangColumn.DonViTienTe.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.DonViTienTe.ToString())];
					c.TongGiaTriHopDong = (reader[DanhSachHopDongThinhGiangColumn.TongGiaTriHopDong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DanhSachHopDongThinhGiangColumn.TongGiaTriHopDong.ToString())];
					c.GiaTriHopDongConLai = (reader[DanhSachHopDongThinhGiangColumn.GiaTriHopDongConLai.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DanhSachHopDongThinhGiangColumn.GiaTriHopDongConLai.ToString())];
					c.Thue = (reader[DanhSachHopDongThinhGiangColumn.Thue.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DanhSachHopDongThinhGiangColumn.Thue.ToString())];
					c.GhiChu = (reader[DanhSachHopDongThinhGiangColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.GhiChu.ToString())];
					c.DaXacNhan = (reader[DanhSachHopDongThinhGiangColumn.DaXacNhan.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(DanhSachHopDongThinhGiangColumn.DaXacNhan.ToString())];
					c.IsLock = (reader[DanhSachHopDongThinhGiangColumn.IsLock.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(DanhSachHopDongThinhGiangColumn.IsLock.ToString())];
					c.NgayCapNhat = (reader[DanhSachHopDongThinhGiangColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[DanhSachHopDongThinhGiangColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.NguoiCapNhat.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DanhSachHopDongThinhGiang"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DanhSachHopDongThinhGiang"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.DanhSachHopDongThinhGiang entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(DanhSachHopDongThinhGiangColumn.Id.ToString())];
			entity.NamHoc = (reader[DanhSachHopDongThinhGiangColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.NamHoc.ToString())];
			entity.HocKy = (reader[DanhSachHopDongThinhGiangColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.HocKy.ToString())];
			entity.MaGiangVien = (reader[DanhSachHopDongThinhGiangColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DanhSachHopDongThinhGiangColumn.MaGiangVien.ToString())];
			entity.HoTen = (reader[DanhSachHopDongThinhGiangColumn.HoTen.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.HoTen.ToString())];
			entity.NgaySinh = (reader[DanhSachHopDongThinhGiangColumn.NgaySinh.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.NgaySinh.ToString())];
			entity.SoCmnd = (reader[DanhSachHopDongThinhGiangColumn.SoCmnd.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.SoCmnd.ToString())];
			entity.MaHocHam = (reader[DanhSachHopDongThinhGiangColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DanhSachHopDongThinhGiangColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[DanhSachHopDongThinhGiangColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DanhSachHopDongThinhGiangColumn.MaHocVi.ToString())];
			entity.ChuyenNganh = (reader[DanhSachHopDongThinhGiangColumn.ChuyenNganh.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.ChuyenNganh.ToString())];
			entity.MaSoThue = (reader[DanhSachHopDongThinhGiangColumn.MaSoThue.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.MaSoThue.ToString())];
			entity.CoQuanCongTac = (reader[DanhSachHopDongThinhGiangColumn.CoQuanCongTac.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.CoQuanCongTac.ToString())];
			entity.MaMonHoc = (reader[DanhSachHopDongThinhGiangColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.MaMonHoc.ToString())];
			entity.MaLopHocPhan = (reader[DanhSachHopDongThinhGiangColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.MaLopHocPhan.ToString())];
			entity.MaLop = (reader[DanhSachHopDongThinhGiangColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.MaLop.ToString())];
			entity.SoHopDong = (reader[DanhSachHopDongThinhGiangColumn.SoHopDong.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.SoHopDong.ToString())];
			entity.MaDonVi = (reader[DanhSachHopDongThinhGiangColumn.MaDonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.MaDonVi.ToString())];
			entity.NgayBatDau = (reader[DanhSachHopDongThinhGiangColumn.NgayBatDau.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(DanhSachHopDongThinhGiangColumn.NgayBatDau.ToString())];
			entity.NgayKetThuc = (reader[DanhSachHopDongThinhGiangColumn.NgayKetThuc.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(DanhSachHopDongThinhGiangColumn.NgayKetThuc.ToString())];
			entity.SoTietLyThuyet = (reader[DanhSachHopDongThinhGiangColumn.SoTietLyThuyet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DanhSachHopDongThinhGiangColumn.SoTietLyThuyet.ToString())];
			entity.SoTietThucHanh = (reader[DanhSachHopDongThinhGiangColumn.SoTietThucHanh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DanhSachHopDongThinhGiangColumn.SoTietThucHanh.ToString())];
			entity.HeSoQuyDoiThucHanh = (reader[DanhSachHopDongThinhGiangColumn.HeSoQuyDoiThucHanh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DanhSachHopDongThinhGiangColumn.HeSoQuyDoiThucHanh.ToString())];
			entity.SoNhomThucHanh = (reader[DanhSachHopDongThinhGiangColumn.SoNhomThucHanh.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DanhSachHopDongThinhGiangColumn.SoNhomThucHanh.ToString())];
			entity.TongSoTiet = (reader[DanhSachHopDongThinhGiangColumn.TongSoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DanhSachHopDongThinhGiangColumn.TongSoTiet.ToString())];
			entity.SoTietLyThuyetTrenTuan = (reader[DanhSachHopDongThinhGiangColumn.SoTietLyThuyetTrenTuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DanhSachHopDongThinhGiangColumn.SoTietLyThuyetTrenTuan.ToString())];
			entity.SoTietThucHanhTrenTuan = (reader[DanhSachHopDongThinhGiangColumn.SoTietThucHanhTrenTuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DanhSachHopDongThinhGiangColumn.SoTietThucHanhTrenTuan.ToString())];
			entity.TongSoTietTrenTuan = (reader[DanhSachHopDongThinhGiangColumn.TongSoTietTrenTuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DanhSachHopDongThinhGiangColumn.TongSoTietTrenTuan.ToString())];
			entity.HeSoLopDong = (reader[DanhSachHopDongThinhGiangColumn.HeSoLopDong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DanhSachHopDongThinhGiangColumn.HeSoLopDong.ToString())];
			entity.SiSo = (reader[DanhSachHopDongThinhGiangColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DanhSachHopDongThinhGiangColumn.SiSo.ToString())];
			entity.TrangThaiHoSo = (reader[DanhSachHopDongThinhGiangColumn.TrangThaiHoSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.TrangThaiHoSo.ToString())];
			entity.DonGia = (reader[DanhSachHopDongThinhGiangColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DanhSachHopDongThinhGiangColumn.DonGia.ToString())];
			entity.DonViTienTe = (reader[DanhSachHopDongThinhGiangColumn.DonViTienTe.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.DonViTienTe.ToString())];
			entity.TongGiaTriHopDong = (reader[DanhSachHopDongThinhGiangColumn.TongGiaTriHopDong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DanhSachHopDongThinhGiangColumn.TongGiaTriHopDong.ToString())];
			entity.GiaTriHopDongConLai = (reader[DanhSachHopDongThinhGiangColumn.GiaTriHopDongConLai.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DanhSachHopDongThinhGiangColumn.GiaTriHopDongConLai.ToString())];
			entity.Thue = (reader[DanhSachHopDongThinhGiangColumn.Thue.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DanhSachHopDongThinhGiangColumn.Thue.ToString())];
			entity.GhiChu = (reader[DanhSachHopDongThinhGiangColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.GhiChu.ToString())];
			entity.DaXacNhan = (reader[DanhSachHopDongThinhGiangColumn.DaXacNhan.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(DanhSachHopDongThinhGiangColumn.DaXacNhan.ToString())];
			entity.IsLock = (reader[DanhSachHopDongThinhGiangColumn.IsLock.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(DanhSachHopDongThinhGiangColumn.IsLock.ToString())];
			entity.NgayCapNhat = (reader[DanhSachHopDongThinhGiangColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[DanhSachHopDongThinhGiangColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhSachHopDongThinhGiangColumn.NguoiCapNhat.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DanhSachHopDongThinhGiang"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DanhSachHopDongThinhGiang"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.DanhSachHopDongThinhGiang entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.Int32?)dataRow["MaGiangVien"];
			entity.HoTen = Convert.IsDBNull(dataRow["HoTen"]) ? null : (System.String)dataRow["HoTen"];
			entity.NgaySinh = Convert.IsDBNull(dataRow["NgaySinh"]) ? null : (System.String)dataRow["NgaySinh"];
			entity.SoCmnd = Convert.IsDBNull(dataRow["SoCmnd"]) ? null : (System.String)dataRow["SoCmnd"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
			entity.ChuyenNganh = Convert.IsDBNull(dataRow["ChuyenNganh"]) ? null : (System.String)dataRow["ChuyenNganh"];
			entity.MaSoThue = Convert.IsDBNull(dataRow["MaSoThue"]) ? null : (System.String)dataRow["MaSoThue"];
			entity.CoQuanCongTac = Convert.IsDBNull(dataRow["CoQuanCongTac"]) ? null : (System.String)dataRow["CoQuanCongTac"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.MaLop = Convert.IsDBNull(dataRow["MaLop"]) ? null : (System.String)dataRow["MaLop"];
			entity.SoHopDong = Convert.IsDBNull(dataRow["SoHopDong"]) ? null : (System.String)dataRow["SoHopDong"];
			entity.MaDonVi = Convert.IsDBNull(dataRow["MaDonVi"]) ? null : (System.String)dataRow["MaDonVi"];
			entity.NgayBatDau = Convert.IsDBNull(dataRow["NgayBatDau"]) ? null : (System.DateTime?)dataRow["NgayBatDau"];
			entity.NgayKetThuc = Convert.IsDBNull(dataRow["NgayKetThuc"]) ? null : (System.DateTime?)dataRow["NgayKetThuc"];
			entity.SoTietLyThuyet = Convert.IsDBNull(dataRow["SoTietLyThuyet"]) ? null : (System.Decimal?)dataRow["SoTietLyThuyet"];
			entity.SoTietThucHanh = Convert.IsDBNull(dataRow["SoTietThucHanh"]) ? null : (System.Decimal?)dataRow["SoTietThucHanh"];
			entity.HeSoQuyDoiThucHanh = Convert.IsDBNull(dataRow["HeSoQuyDoiThucHanh"]) ? null : (System.Decimal?)dataRow["HeSoQuyDoiThucHanh"];
			entity.SoNhomThucHanh = Convert.IsDBNull(dataRow["SoNhomThucHanh"]) ? null : (System.Int32?)dataRow["SoNhomThucHanh"];
			entity.TongSoTiet = Convert.IsDBNull(dataRow["TongSoTiet"]) ? null : (System.Decimal?)dataRow["TongSoTiet"];
			entity.SoTietLyThuyetTrenTuan = Convert.IsDBNull(dataRow["SoTietLyThuyetTrenTuan"]) ? null : (System.Decimal?)dataRow["SoTietLyThuyetTrenTuan"];
			entity.SoTietThucHanhTrenTuan = Convert.IsDBNull(dataRow["SoTietThucHanhTrenTuan"]) ? null : (System.Decimal?)dataRow["SoTietThucHanhTrenTuan"];
			entity.TongSoTietTrenTuan = Convert.IsDBNull(dataRow["TongSoTietTrenTuan"]) ? null : (System.Decimal?)dataRow["TongSoTietTrenTuan"];
			entity.HeSoLopDong = Convert.IsDBNull(dataRow["HeSoLopDong"]) ? null : (System.Decimal?)dataRow["HeSoLopDong"];
			entity.SiSo = Convert.IsDBNull(dataRow["SiSo"]) ? null : (System.Int32?)dataRow["SiSo"];
			entity.TrangThaiHoSo = Convert.IsDBNull(dataRow["TrangThaiHoSo"]) ? null : (System.String)dataRow["TrangThaiHoSo"];
			entity.DonGia = Convert.IsDBNull(dataRow["DonGia"]) ? null : (System.Decimal?)dataRow["DonGia"];
			entity.DonViTienTe = Convert.IsDBNull(dataRow["DonViTienTe"]) ? null : (System.String)dataRow["DonViTienTe"];
			entity.TongGiaTriHopDong = Convert.IsDBNull(dataRow["TongGiaTriHopDong"]) ? null : (System.Decimal?)dataRow["TongGiaTriHopDong"];
			entity.GiaTriHopDongConLai = Convert.IsDBNull(dataRow["GiaTriHopDongConLai"]) ? null : (System.Decimal?)dataRow["GiaTriHopDongConLai"];
			entity.Thue = Convert.IsDBNull(dataRow["Thue"]) ? null : (System.Decimal?)dataRow["Thue"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.DaXacNhan = Convert.IsDBNull(dataRow["DaXacNhan"]) ? null : (System.Boolean?)dataRow["DaXacNhan"];
			entity.IsLock = Convert.IsDBNull(dataRow["IsLock"]) ? null : (System.Boolean?)dataRow["IsLock"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
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
		/// <param name="entity">The <see cref="PMS.Entities.DanhSachHopDongThinhGiang"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.DanhSachHopDongThinhGiang Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.DanhSachHopDongThinhGiang entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.DanhSachHopDongThinhGiang object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.DanhSachHopDongThinhGiang instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.DanhSachHopDongThinhGiang Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.DanhSachHopDongThinhGiang entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region DanhSachHopDongThinhGiangChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.DanhSachHopDongThinhGiang</c>
	///</summary>
	public enum DanhSachHopDongThinhGiangChildEntityTypes
	{
	}
	
	#endregion DanhSachHopDongThinhGiangChildEntityTypes
	
	#region DanhSachHopDongThinhGiangFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;DanhSachHopDongThinhGiangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DanhSachHopDongThinhGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DanhSachHopDongThinhGiangFilterBuilder : SqlFilterBuilder<DanhSachHopDongThinhGiangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DanhSachHopDongThinhGiangFilterBuilder class.
		/// </summary>
		public DanhSachHopDongThinhGiangFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DanhSachHopDongThinhGiangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DanhSachHopDongThinhGiangFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DanhSachHopDongThinhGiangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DanhSachHopDongThinhGiangFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DanhSachHopDongThinhGiangFilterBuilder
	
	#region DanhSachHopDongThinhGiangParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;DanhSachHopDongThinhGiangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DanhSachHopDongThinhGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DanhSachHopDongThinhGiangParameterBuilder : ParameterizedSqlFilterBuilder<DanhSachHopDongThinhGiangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DanhSachHopDongThinhGiangParameterBuilder class.
		/// </summary>
		public DanhSachHopDongThinhGiangParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DanhSachHopDongThinhGiangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DanhSachHopDongThinhGiangParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DanhSachHopDongThinhGiangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DanhSachHopDongThinhGiangParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DanhSachHopDongThinhGiangParameterBuilder
	
	#region DanhSachHopDongThinhGiangSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;DanhSachHopDongThinhGiangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DanhSachHopDongThinhGiang"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class DanhSachHopDongThinhGiangSortBuilder : SqlSortBuilder<DanhSachHopDongThinhGiangColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DanhSachHopDongThinhGiangSqlSortBuilder class.
		/// </summary>
		public DanhSachHopDongThinhGiangSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion DanhSachHopDongThinhGiangSortBuilder
	
} // end namespace
