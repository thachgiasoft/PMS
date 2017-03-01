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
	/// This class is the base class for any <see cref="ThanhToanThinhGiangProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ThanhToanThinhGiangProviderBaseCore : EntityProviderBase<PMS.Entities.ThanhToanThinhGiang, PMS.Entities.ThanhToanThinhGiangKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.ThanhToanThinhGiangKey key)
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
		public override PMS.Entities.ThanhToanThinhGiang Get(TransactionManager transactionManager, PMS.Entities.ThanhToanThinhGiangKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ThanhToanThinhGiang index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhToanThinhGiang"/> class.</returns>
		public PMS.Entities.ThanhToanThinhGiang GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThanhToanThinhGiang index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhToanThinhGiang"/> class.</returns>
		public PMS.Entities.ThanhToanThinhGiang GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThanhToanThinhGiang index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhToanThinhGiang"/> class.</returns>
		public PMS.Entities.ThanhToanThinhGiang GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThanhToanThinhGiang index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhToanThinhGiang"/> class.</returns>
		public PMS.Entities.ThanhToanThinhGiang GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThanhToanThinhGiang index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhToanThinhGiang"/> class.</returns>
		public PMS.Entities.ThanhToanThinhGiang GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThanhToanThinhGiang index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhToanThinhGiang"/> class.</returns>
		public abstract PMS.Entities.ThanhToanThinhGiang GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_ThanhToanThinhGiang_GetByNamHocHocKyDonViTuNgayDenNgay 
		
		/// <summary>
		///	This method wrap the 'cust_ThanhToanThinhGiang_GetByNamHocHocKyDonViTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="taiKhoanKhoa"> A <c>System.Boolean</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyDonViTuNgayDenNgay(System.String namHoc, System.String hocKy, System.String khoaDonVi, System.DateTime tuNgay, System.DateTime denNgay, System.Boolean taiKhoanKhoa)
		{
			return GetByNamHocHocKyDonViTuNgayDenNgay(null, 0, int.MaxValue , namHoc, hocKy, khoaDonVi, tuNgay, denNgay, taiKhoanKhoa);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhToanThinhGiang_GetByNamHocHocKyDonViTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="taiKhoanKhoa"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyDonViTuNgayDenNgay(int start, int pageLength, System.String namHoc, System.String hocKy, System.String khoaDonVi, System.DateTime tuNgay, System.DateTime denNgay, System.Boolean taiKhoanKhoa)
		{
			return GetByNamHocHocKyDonViTuNgayDenNgay(null, start, pageLength , namHoc, hocKy, khoaDonVi, tuNgay, denNgay, taiKhoanKhoa);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThanhToanThinhGiang_GetByNamHocHocKyDonViTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="taiKhoanKhoa"> A <c>System.Boolean</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyDonViTuNgayDenNgay(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String khoaDonVi, System.DateTime tuNgay, System.DateTime denNgay, System.Boolean taiKhoanKhoa)
		{
			return GetByNamHocHocKyDonViTuNgayDenNgay(transactionManager, 0, int.MaxValue , namHoc, hocKy, khoaDonVi, tuNgay, denNgay, taiKhoanKhoa);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhToanThinhGiang_GetByNamHocHocKyDonViTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="taiKhoanKhoa"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKyDonViTuNgayDenNgay(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String khoaDonVi, System.DateTime tuNgay, System.DateTime denNgay, System.Boolean taiKhoanKhoa);
		
		#endregion
		
		#region cust_ThanhToanThinhGiang_LuuHbu 
		
		/// <summary>
		///	This method wrap the 'cust_ThanhToanThinhGiang_LuuHbu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuHbu(System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 LuuHbu(null, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhToanThinhGiang_LuuHbu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuHbu(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 LuuHbu(null, start, pageLength , xmlData, namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThanhToanThinhGiang_LuuHbu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuHbu(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 LuuHbu(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhToanThinhGiang_LuuHbu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LuuHbu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_ThanhToanThinhGiang_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_ThanhToanThinhGiang_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhToanThinhGiang_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Luu(null, start, pageLength , xmlData, namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThanhToanThinhGiang_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhToanThinhGiang_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_ThanhToanThinhGiang_KiemTraThanhToan 
		
		/// <summary>
		///	This method wrap the 'cust_ThanhToanThinhGiang_KiemTraThanhToan' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraThanhToan(System.String maGiangVien, System.String maLopHocPhan, ref System.Int32 reVal)
		{
			 KiemTraThanhToan(null, 0, int.MaxValue , maGiangVien, maLopHocPhan, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhToanThinhGiang_KiemTraThanhToan' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraThanhToan(int start, int pageLength, System.String maGiangVien, System.String maLopHocPhan, ref System.Int32 reVal)
		{
			 KiemTraThanhToan(null, start, pageLength , maGiangVien, maLopHocPhan, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThanhToanThinhGiang_KiemTraThanhToan' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraThanhToan(TransactionManager transactionManager, System.String maGiangVien, System.String maLopHocPhan, ref System.Int32 reVal)
		{
			 KiemTraThanhToan(transactionManager, 0, int.MaxValue , maGiangVien, maLopHocPhan, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhToanThinhGiang_KiemTraThanhToan' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void KiemTraThanhToan(TransactionManager transactionManager, int start, int pageLength , System.String maGiangVien, System.String maLopHocPhan, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ThanhToanThinhGiang&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ThanhToanThinhGiang&gt;"/></returns>
		public static TList<ThanhToanThinhGiang> Fill(IDataReader reader, TList<ThanhToanThinhGiang> rows, int start, int pageLength)
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
				
				PMS.Entities.ThanhToanThinhGiang c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ThanhToanThinhGiang")
					.Append("|").Append((System.Int32)reader[((int)ThanhToanThinhGiangColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<ThanhToanThinhGiang>(
					key.ToString(), // EntityTrackingKey
					"ThanhToanThinhGiang",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.ThanhToanThinhGiang();
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
					c.Id = (System.Int32)reader[(ThanhToanThinhGiangColumn.Id.ToString())];
					c.NamHoc = (reader[ThanhToanThinhGiangColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhToanThinhGiangColumn.NamHoc.ToString())];
					c.HocKy = (reader[ThanhToanThinhGiangColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhToanThinhGiangColumn.HocKy.ToString())];
					c.MaGiangVien = (reader[ThanhToanThinhGiangColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThanhToanThinhGiangColumn.MaGiangVien.ToString())];
					c.MaLopHocPhan = (reader[ThanhToanThinhGiangColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhToanThinhGiangColumn.MaLopHocPhan.ToString())];
					c.ChucDanh = (reader[ThanhToanThinhGiangColumn.ChucDanh.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhToanThinhGiangColumn.ChucDanh.ToString())];
					c.MaLop = (reader[ThanhToanThinhGiangColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhToanThinhGiangColumn.MaLop.ToString())];
					c.SiSo = (reader[ThanhToanThinhGiangColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThanhToanThinhGiangColumn.SiSo.ToString())];
					c.Stt = (reader[ThanhToanThinhGiangColumn.Stt.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThanhToanThinhGiangColumn.Stt.ToString())];
					c.NoiDung = (reader[ThanhToanThinhGiangColumn.NoiDung.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhToanThinhGiangColumn.NoiDung.ToString())];
					c.SoTiet = (reader[ThanhToanThinhGiangColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanThinhGiangColumn.SoTiet.ToString())];
					c.HeSo = (reader[ThanhToanThinhGiangColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanThinhGiangColumn.HeSo.ToString())];
					c.HeSoChucDanh = (reader[ThanhToanThinhGiangColumn.HeSoChucDanh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanThinhGiangColumn.HeSoChucDanh.ToString())];
					c.CongHeSo = (reader[ThanhToanThinhGiangColumn.CongHeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanThinhGiangColumn.CongHeSo.ToString())];
					c.DonGia = (reader[ThanhToanThinhGiangColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanThinhGiangColumn.DonGia.ToString())];
					c.ThanhTien = (reader[ThanhToanThinhGiangColumn.ThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanThinhGiangColumn.ThanhTien.ToString())];
					c.Thue = (reader[ThanhToanThinhGiangColumn.Thue.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanThinhGiangColumn.Thue.ToString())];
					c.ConNhan = (reader[ThanhToanThinhGiangColumn.ConNhan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanThinhGiangColumn.ConNhan.ToString())];
					c.GhiChu = (reader[ThanhToanThinhGiangColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhToanThinhGiangColumn.GhiChu.ToString())];
					c.NgayXacNhan = (reader[ThanhToanThinhGiangColumn.NgayXacNhan.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ThanhToanThinhGiangColumn.NgayXacNhan.ToString())];
					c.HeSoNgoaiGio = (reader[ThanhToanThinhGiangColumn.HeSoNgoaiGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanThinhGiangColumn.HeSoNgoaiGio.ToString())];
					c.HeSoLopDong = (reader[ThanhToanThinhGiangColumn.HeSoLopDong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanThinhGiangColumn.HeSoLopDong.ToString())];
					c.HeSoKhoiNganh = (reader[ThanhToanThinhGiangColumn.HeSoKhoiNganh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanThinhGiangColumn.HeSoKhoiNganh.ToString())];
					c.HeSoBacDaoTao = (reader[ThanhToanThinhGiangColumn.HeSoBacDaoTao.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanThinhGiangColumn.HeSoBacDaoTao.ToString())];
					c.HeSoNgonNgu = (reader[ThanhToanThinhGiangColumn.HeSoNgonNgu.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanThinhGiangColumn.HeSoNgonNgu.ToString())];
					c.TietQuyDoi = (reader[ThanhToanThinhGiangColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanThinhGiangColumn.TietQuyDoi.ToString())];
					c.SoTietTkb = (reader[ThanhToanThinhGiangColumn.SoTietTkb.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanThinhGiangColumn.SoTietTkb.ToString())];
					c.NgayNhap = (reader[ThanhToanThinhGiangColumn.NgayNhap.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ThanhToanThinhGiangColumn.NgayNhap.ToString())];
					c.XacNhan = (reader[ThanhToanThinhGiangColumn.XacNhan.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ThanhToanThinhGiangColumn.XacNhan.ToString())];
					c.MaHocHam = (reader[ThanhToanThinhGiangColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThanhToanThinhGiangColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[ThanhToanThinhGiangColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThanhToanThinhGiangColumn.MaHocVi.ToString())];
					c.SiSoNhomThucHanh = (reader[ThanhToanThinhGiangColumn.SiSoNhomThucHanh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanThinhGiangColumn.SiSoNhomThucHanh.ToString())];
					c.HeSoQuyDoiThucHanhSangLyThuyet = (reader[ThanhToanThinhGiangColumn.HeSoQuyDoiThucHanhSangLyThuyet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanThinhGiangColumn.HeSoQuyDoiThucHanhSangLyThuyet.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThanhToanThinhGiang"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThanhToanThinhGiang"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.ThanhToanThinhGiang entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(ThanhToanThinhGiangColumn.Id.ToString())];
			entity.NamHoc = (reader[ThanhToanThinhGiangColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhToanThinhGiangColumn.NamHoc.ToString())];
			entity.HocKy = (reader[ThanhToanThinhGiangColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhToanThinhGiangColumn.HocKy.ToString())];
			entity.MaGiangVien = (reader[ThanhToanThinhGiangColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThanhToanThinhGiangColumn.MaGiangVien.ToString())];
			entity.MaLopHocPhan = (reader[ThanhToanThinhGiangColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhToanThinhGiangColumn.MaLopHocPhan.ToString())];
			entity.ChucDanh = (reader[ThanhToanThinhGiangColumn.ChucDanh.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhToanThinhGiangColumn.ChucDanh.ToString())];
			entity.MaLop = (reader[ThanhToanThinhGiangColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhToanThinhGiangColumn.MaLop.ToString())];
			entity.SiSo = (reader[ThanhToanThinhGiangColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThanhToanThinhGiangColumn.SiSo.ToString())];
			entity.Stt = (reader[ThanhToanThinhGiangColumn.Stt.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThanhToanThinhGiangColumn.Stt.ToString())];
			entity.NoiDung = (reader[ThanhToanThinhGiangColumn.NoiDung.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhToanThinhGiangColumn.NoiDung.ToString())];
			entity.SoTiet = (reader[ThanhToanThinhGiangColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanThinhGiangColumn.SoTiet.ToString())];
			entity.HeSo = (reader[ThanhToanThinhGiangColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanThinhGiangColumn.HeSo.ToString())];
			entity.HeSoChucDanh = (reader[ThanhToanThinhGiangColumn.HeSoChucDanh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanThinhGiangColumn.HeSoChucDanh.ToString())];
			entity.CongHeSo = (reader[ThanhToanThinhGiangColumn.CongHeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanThinhGiangColumn.CongHeSo.ToString())];
			entity.DonGia = (reader[ThanhToanThinhGiangColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanThinhGiangColumn.DonGia.ToString())];
			entity.ThanhTien = (reader[ThanhToanThinhGiangColumn.ThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanThinhGiangColumn.ThanhTien.ToString())];
			entity.Thue = (reader[ThanhToanThinhGiangColumn.Thue.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanThinhGiangColumn.Thue.ToString())];
			entity.ConNhan = (reader[ThanhToanThinhGiangColumn.ConNhan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanThinhGiangColumn.ConNhan.ToString())];
			entity.GhiChu = (reader[ThanhToanThinhGiangColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhToanThinhGiangColumn.GhiChu.ToString())];
			entity.NgayXacNhan = (reader[ThanhToanThinhGiangColumn.NgayXacNhan.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ThanhToanThinhGiangColumn.NgayXacNhan.ToString())];
			entity.HeSoNgoaiGio = (reader[ThanhToanThinhGiangColumn.HeSoNgoaiGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanThinhGiangColumn.HeSoNgoaiGio.ToString())];
			entity.HeSoLopDong = (reader[ThanhToanThinhGiangColumn.HeSoLopDong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanThinhGiangColumn.HeSoLopDong.ToString())];
			entity.HeSoKhoiNganh = (reader[ThanhToanThinhGiangColumn.HeSoKhoiNganh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanThinhGiangColumn.HeSoKhoiNganh.ToString())];
			entity.HeSoBacDaoTao = (reader[ThanhToanThinhGiangColumn.HeSoBacDaoTao.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanThinhGiangColumn.HeSoBacDaoTao.ToString())];
			entity.HeSoNgonNgu = (reader[ThanhToanThinhGiangColumn.HeSoNgonNgu.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanThinhGiangColumn.HeSoNgonNgu.ToString())];
			entity.TietQuyDoi = (reader[ThanhToanThinhGiangColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanThinhGiangColumn.TietQuyDoi.ToString())];
			entity.SoTietTkb = (reader[ThanhToanThinhGiangColumn.SoTietTkb.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanThinhGiangColumn.SoTietTkb.ToString())];
			entity.NgayNhap = (reader[ThanhToanThinhGiangColumn.NgayNhap.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ThanhToanThinhGiangColumn.NgayNhap.ToString())];
			entity.XacNhan = (reader[ThanhToanThinhGiangColumn.XacNhan.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ThanhToanThinhGiangColumn.XacNhan.ToString())];
			entity.MaHocHam = (reader[ThanhToanThinhGiangColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThanhToanThinhGiangColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[ThanhToanThinhGiangColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThanhToanThinhGiangColumn.MaHocVi.ToString())];
			entity.SiSoNhomThucHanh = (reader[ThanhToanThinhGiangColumn.SiSoNhomThucHanh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanThinhGiangColumn.SiSoNhomThucHanh.ToString())];
			entity.HeSoQuyDoiThucHanhSangLyThuyet = (reader[ThanhToanThinhGiangColumn.HeSoQuyDoiThucHanhSangLyThuyet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhToanThinhGiangColumn.HeSoQuyDoiThucHanhSangLyThuyet.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThanhToanThinhGiang"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThanhToanThinhGiang"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.ThanhToanThinhGiang entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.Int32?)dataRow["MaGiangVien"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.ChucDanh = Convert.IsDBNull(dataRow["ChucDanh"]) ? null : (System.String)dataRow["ChucDanh"];
			entity.MaLop = Convert.IsDBNull(dataRow["MaLop"]) ? null : (System.String)dataRow["MaLop"];
			entity.SiSo = Convert.IsDBNull(dataRow["SiSo"]) ? null : (System.Int32?)dataRow["SiSo"];
			entity.Stt = Convert.IsDBNull(dataRow["Stt"]) ? null : (System.Int32?)dataRow["Stt"];
			entity.NoiDung = Convert.IsDBNull(dataRow["NoiDung"]) ? null : (System.String)dataRow["NoiDung"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Decimal?)dataRow["SoTiet"];
			entity.HeSo = Convert.IsDBNull(dataRow["HeSo"]) ? null : (System.Decimal?)dataRow["HeSo"];
			entity.HeSoChucDanh = Convert.IsDBNull(dataRow["HeSoChucDanh"]) ? null : (System.Decimal?)dataRow["HeSoChucDanh"];
			entity.CongHeSo = Convert.IsDBNull(dataRow["CongHeSo"]) ? null : (System.Decimal?)dataRow["CongHeSo"];
			entity.DonGia = Convert.IsDBNull(dataRow["DonGia"]) ? null : (System.Decimal?)dataRow["DonGia"];
			entity.ThanhTien = Convert.IsDBNull(dataRow["ThanhTien"]) ? null : (System.Decimal?)dataRow["ThanhTien"];
			entity.Thue = Convert.IsDBNull(dataRow["Thue"]) ? null : (System.Decimal?)dataRow["Thue"];
			entity.ConNhan = Convert.IsDBNull(dataRow["ConNhan"]) ? null : (System.Decimal?)dataRow["ConNhan"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.NgayXacNhan = Convert.IsDBNull(dataRow["NgayXacNhan"]) ? null : (System.DateTime?)dataRow["NgayXacNhan"];
			entity.HeSoNgoaiGio = Convert.IsDBNull(dataRow["HeSoNgoaiGio"]) ? null : (System.Decimal?)dataRow["HeSoNgoaiGio"];
			entity.HeSoLopDong = Convert.IsDBNull(dataRow["HeSoLopDong"]) ? null : (System.Decimal?)dataRow["HeSoLopDong"];
			entity.HeSoKhoiNganh = Convert.IsDBNull(dataRow["HeSoKhoiNganh"]) ? null : (System.Decimal?)dataRow["HeSoKhoiNganh"];
			entity.HeSoBacDaoTao = Convert.IsDBNull(dataRow["HeSoBacDaoTao"]) ? null : (System.Decimal?)dataRow["HeSoBacDaoTao"];
			entity.HeSoNgonNgu = Convert.IsDBNull(dataRow["HeSoNgonNgu"]) ? null : (System.Decimal?)dataRow["HeSoNgonNgu"];
			entity.TietQuyDoi = Convert.IsDBNull(dataRow["TietQuyDoi"]) ? null : (System.Decimal?)dataRow["TietQuyDoi"];
			entity.SoTietTkb = Convert.IsDBNull(dataRow["SoTietTkb"]) ? null : (System.Decimal?)dataRow["SoTietTkb"];
			entity.NgayNhap = Convert.IsDBNull(dataRow["NgayNhap"]) ? null : (System.DateTime?)dataRow["NgayNhap"];
			entity.XacNhan = Convert.IsDBNull(dataRow["XacNhan"]) ? null : (System.Boolean?)dataRow["XacNhan"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
			entity.SiSoNhomThucHanh = Convert.IsDBNull(dataRow["SiSoNhomThucHanh"]) ? null : (System.Decimal?)dataRow["SiSoNhomThucHanh"];
			entity.HeSoQuyDoiThucHanhSangLyThuyet = Convert.IsDBNull(dataRow["HeSoQuyDoiThucHanhSangLyThuyet"]) ? null : (System.Decimal?)dataRow["HeSoQuyDoiThucHanhSangLyThuyet"];
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
		/// <param name="entity">The <see cref="PMS.Entities.ThanhToanThinhGiang"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.ThanhToanThinhGiang Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.ThanhToanThinhGiang entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.ThanhToanThinhGiang object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.ThanhToanThinhGiang instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.ThanhToanThinhGiang Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.ThanhToanThinhGiang entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region ThanhToanThinhGiangChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.ThanhToanThinhGiang</c>
	///</summary>
	public enum ThanhToanThinhGiangChildEntityTypes
	{
	}
	
	#endregion ThanhToanThinhGiangChildEntityTypes
	
	#region ThanhToanThinhGiangFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ThanhToanThinhGiangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThanhToanThinhGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThanhToanThinhGiangFilterBuilder : SqlFilterBuilder<ThanhToanThinhGiangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThanhToanThinhGiangFilterBuilder class.
		/// </summary>
		public ThanhToanThinhGiangFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThanhToanThinhGiangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThanhToanThinhGiangFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThanhToanThinhGiangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThanhToanThinhGiangFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThanhToanThinhGiangFilterBuilder
	
	#region ThanhToanThinhGiangParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ThanhToanThinhGiangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThanhToanThinhGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThanhToanThinhGiangParameterBuilder : ParameterizedSqlFilterBuilder<ThanhToanThinhGiangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThanhToanThinhGiangParameterBuilder class.
		/// </summary>
		public ThanhToanThinhGiangParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThanhToanThinhGiangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThanhToanThinhGiangParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThanhToanThinhGiangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThanhToanThinhGiangParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThanhToanThinhGiangParameterBuilder
	
	#region ThanhToanThinhGiangSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ThanhToanThinhGiangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThanhToanThinhGiang"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ThanhToanThinhGiangSortBuilder : SqlSortBuilder<ThanhToanThinhGiangColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThanhToanThinhGiangSqlSortBuilder class.
		/// </summary>
		public ThanhToanThinhGiangSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ThanhToanThinhGiangSortBuilder
	
} // end namespace
