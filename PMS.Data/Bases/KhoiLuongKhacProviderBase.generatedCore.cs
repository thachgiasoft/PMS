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
	/// This class is the base class for any <see cref="KhoiLuongKhacProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KhoiLuongKhacProviderBaseCore : EntityProviderBase<PMS.Entities.KhoiLuongKhac, PMS.Entities.KhoiLuongKhacKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KhoiLuongKhacKey key)
		{
			return Delete(transactionManager, key.MaKhoiLuong);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maKhoiLuong">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maKhoiLuong)
		{
			return Delete(null, _maKhoiLuong);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuong">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maKhoiLuong);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongKhac_GiangVien key.
		///		FK_KhoiLuongKhac_GiangVien Description: 
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongKhac objects.</returns>
		public TList<KhoiLuongKhac> GetByMaGiangVien(System.Int32? _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(_maGiangVien, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongKhac_GiangVien key.
		///		FK_KhoiLuongKhac_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongKhac objects.</returns>
		/// <remarks></remarks>
		public TList<KhoiLuongKhac> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongKhac_GiangVien key.
		///		FK_KhoiLuongKhac_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongKhac objects.</returns>
		public TList<KhoiLuongKhac> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongKhac_GiangVien key.
		///		fkKhoiLuongKhacGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongKhac objects.</returns>
		public TList<KhoiLuongKhac> GetByMaGiangVien(System.Int32? _maGiangVien, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongKhac_GiangVien key.
		///		fkKhoiLuongKhacGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongKhac objects.</returns>
		public TList<KhoiLuongKhac> GetByMaGiangVien(System.Int32? _maGiangVien, int start, int pageLength,out int count)
		{
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongKhac_GiangVien key.
		///		FK_KhoiLuongKhac_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongKhac objects.</returns>
		public abstract TList<KhoiLuongKhac> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.KhoiLuongKhac Get(TransactionManager transactionManager, PMS.Entities.KhoiLuongKhacKey key, int start, int pageLength)
		{
			return GetByMaKhoiLuong(transactionManager, key.MaKhoiLuong, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KhoiLuongKhac index.
		/// </summary>
		/// <param name="_maKhoiLuong"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongKhac"/> class.</returns>
		public PMS.Entities.KhoiLuongKhac GetByMaKhoiLuong(System.Int32 _maKhoiLuong)
		{
			int count = -1;
			return GetByMaKhoiLuong(null,_maKhoiLuong, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongKhac index.
		/// </summary>
		/// <param name="_maKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongKhac"/> class.</returns>
		public PMS.Entities.KhoiLuongKhac GetByMaKhoiLuong(System.Int32 _maKhoiLuong, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKhoiLuong(null, _maKhoiLuong, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongKhac index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuong"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongKhac"/> class.</returns>
		public PMS.Entities.KhoiLuongKhac GetByMaKhoiLuong(TransactionManager transactionManager, System.Int32 _maKhoiLuong)
		{
			int count = -1;
			return GetByMaKhoiLuong(transactionManager, _maKhoiLuong, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongKhac index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongKhac"/> class.</returns>
		public PMS.Entities.KhoiLuongKhac GetByMaKhoiLuong(TransactionManager transactionManager, System.Int32 _maKhoiLuong, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKhoiLuong(transactionManager, _maKhoiLuong, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongKhac index.
		/// </summary>
		/// <param name="_maKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongKhac"/> class.</returns>
		public PMS.Entities.KhoiLuongKhac GetByMaKhoiLuong(System.Int32 _maKhoiLuong, int start, int pageLength, out int count)
		{
			return GetByMaKhoiLuong(null, _maKhoiLuong, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongKhac index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongKhac"/> class.</returns>
		public abstract PMS.Entities.KhoiLuongKhac GetByMaKhoiLuong(TransactionManager transactionManager, System.Int32 _maKhoiLuong, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_KhoiLuongKhac_GetByNamHocHocKyPhanLoaiMaGiangVien 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongKhac_GetByNamHocHocKyPhanLoaiMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="phanLoai"> A <c>System.Int32</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongKhac&gt;"/> instance.</returns>
		public TList<KhoiLuongKhac> GetByNamHocHocKyPhanLoaiMaGiangVien(System.String namHoc, System.String hocKy, System.Int32 phanLoai, System.Int32 maGiangVien)
		{
			return GetByNamHocHocKyPhanLoaiMaGiangVien(null, 0, int.MaxValue , namHoc, hocKy, phanLoai, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongKhac_GetByNamHocHocKyPhanLoaiMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="phanLoai"> A <c>System.Int32</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongKhac&gt;"/> instance.</returns>
		public TList<KhoiLuongKhac> GetByNamHocHocKyPhanLoaiMaGiangVien(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 phanLoai, System.Int32 maGiangVien)
		{
			return GetByNamHocHocKyPhanLoaiMaGiangVien(null, start, pageLength , namHoc, hocKy, phanLoai, maGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongKhac_GetByNamHocHocKyPhanLoaiMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="phanLoai"> A <c>System.Int32</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongKhac&gt;"/> instance.</returns>
		public TList<KhoiLuongKhac> GetByNamHocHocKyPhanLoaiMaGiangVien(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 phanLoai, System.Int32 maGiangVien)
		{
			return GetByNamHocHocKyPhanLoaiMaGiangVien(transactionManager, 0, int.MaxValue , namHoc, hocKy, phanLoai, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongKhac_GetByNamHocHocKyPhanLoaiMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="phanLoai"> A <c>System.Int32</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongKhac&gt;"/> instance.</returns>
		public abstract TList<KhoiLuongKhac> GetByNamHocHocKyPhanLoaiMaGiangVien(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 phanLoai, System.Int32 maGiangVien);
		
		#endregion
		
		#region cust_KhoiLuongKhac_GetByNamHocHocKyPhanLoai 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongKhac_GetByNamHocHocKyPhanLoai' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="phanLoai"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongKhac&gt;"/> instance.</returns>
		public TList<KhoiLuongKhac> GetByNamHocHocKyPhanLoai(System.String namHoc, System.String hocKy, System.Int32 phanLoai)
		{
			return GetByNamHocHocKyPhanLoai(null, 0, int.MaxValue , namHoc, hocKy, phanLoai);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongKhac_GetByNamHocHocKyPhanLoai' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="phanLoai"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongKhac&gt;"/> instance.</returns>
		public TList<KhoiLuongKhac> GetByNamHocHocKyPhanLoai(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 phanLoai)
		{
			return GetByNamHocHocKyPhanLoai(null, start, pageLength , namHoc, hocKy, phanLoai);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongKhac_GetByNamHocHocKyPhanLoai' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="phanLoai"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongKhac&gt;"/> instance.</returns>
		public TList<KhoiLuongKhac> GetByNamHocHocKyPhanLoai(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 phanLoai)
		{
			return GetByNamHocHocKyPhanLoai(transactionManager, 0, int.MaxValue , namHoc, hocKy, phanLoai);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongKhac_GetByNamHocHocKyPhanLoai' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="phanLoai"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongKhac&gt;"/> instance.</returns>
		public abstract TList<KhoiLuongKhac> GetByNamHocHocKyPhanLoai(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 phanLoai);
		
		#endregion
		
		#region cust_KhoiLuongKhac_LayDuLieuDoAn 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongKhac_LayDuLieuDoAn' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LayDuLieuDoAn(System.String namHoc, System.String hocKy)
		{
			 LayDuLieuDoAn(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongKhac_LayDuLieuDoAn' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LayDuLieuDoAn(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			 LayDuLieuDoAn(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongKhac_LayDuLieuDoAn' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LayDuLieuDoAn(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			 LayDuLieuDoAn(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongKhac_LayDuLieuDoAn' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LayDuLieuDoAn(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KhoiLuongKhac&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KhoiLuongKhac&gt;"/></returns>
		public static TList<KhoiLuongKhac> Fill(IDataReader reader, TList<KhoiLuongKhac> rows, int start, int pageLength)
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
				
				PMS.Entities.KhoiLuongKhac c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KhoiLuongKhac")
					.Append("|").Append((System.Int32)reader[((int)KhoiLuongKhacColumn.MaKhoiLuong - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KhoiLuongKhac>(
					key.ToString(), // EntityTrackingKey
					"KhoiLuongKhac",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KhoiLuongKhac();
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
					c.MaKhoiLuong = (System.Int32)reader[(KhoiLuongKhacColumn.MaKhoiLuong.ToString())];
					c.MaGiangVien = (reader[KhoiLuongKhacColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongKhacColumn.MaGiangVien.ToString())];
					c.LoaiHocPhan = (reader[KhoiLuongKhacColumn.LoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongKhacColumn.LoaiHocPhan.ToString())];
					c.MaLopHocPhan = (reader[KhoiLuongKhacColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongKhacColumn.MaLopHocPhan.ToString())];
					c.MaLop = (reader[KhoiLuongKhacColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongKhacColumn.MaLop.ToString())];
					c.MaMonHoc = (reader[KhoiLuongKhacColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongKhacColumn.MaMonHoc.ToString())];
					c.MaNhom = (reader[KhoiLuongKhacColumn.MaNhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongKhacColumn.MaNhom.ToString())];
					c.SoTiet = (reader[KhoiLuongKhacColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongKhacColumn.SoTiet.ToString())];
					c.SoTuan = (reader[KhoiLuongKhacColumn.SoTuan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongKhacColumn.SoTuan.ToString())];
					c.DonGia = (reader[KhoiLuongKhacColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongKhacColumn.DonGia.ToString())];
					c.NamHoc = (reader[KhoiLuongKhacColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongKhacColumn.NamHoc.ToString())];
					c.HocKy = (reader[KhoiLuongKhacColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongKhacColumn.HocKy.ToString())];
					c.SoLuong = (reader[KhoiLuongKhacColumn.SoLuong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongKhacColumn.SoLuong.ToString())];
					c.TietQuyDoi = (reader[KhoiLuongKhacColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongKhacColumn.TietQuyDoi.ToString())];
					c.DienGiai = (reader[KhoiLuongKhacColumn.DienGiai.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongKhacColumn.DienGiai.ToString())];
					c.PhanLoai = (reader[KhoiLuongKhacColumn.PhanLoai.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongKhacColumn.PhanLoai.ToString())];
					c.NgayTao = (reader[KhoiLuongKhacColumn.NgayTao.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KhoiLuongKhacColumn.NgayTao.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KhoiLuongKhac"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongKhac"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KhoiLuongKhac entity)
		{
			if (!reader.Read()) return;
			
			entity.MaKhoiLuong = (System.Int32)reader[(KhoiLuongKhacColumn.MaKhoiLuong.ToString())];
			entity.MaGiangVien = (reader[KhoiLuongKhacColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongKhacColumn.MaGiangVien.ToString())];
			entity.LoaiHocPhan = (reader[KhoiLuongKhacColumn.LoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongKhacColumn.LoaiHocPhan.ToString())];
			entity.MaLopHocPhan = (reader[KhoiLuongKhacColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongKhacColumn.MaLopHocPhan.ToString())];
			entity.MaLop = (reader[KhoiLuongKhacColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongKhacColumn.MaLop.ToString())];
			entity.MaMonHoc = (reader[KhoiLuongKhacColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongKhacColumn.MaMonHoc.ToString())];
			entity.MaNhom = (reader[KhoiLuongKhacColumn.MaNhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongKhacColumn.MaNhom.ToString())];
			entity.SoTiet = (reader[KhoiLuongKhacColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongKhacColumn.SoTiet.ToString())];
			entity.SoTuan = (reader[KhoiLuongKhacColumn.SoTuan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongKhacColumn.SoTuan.ToString())];
			entity.DonGia = (reader[KhoiLuongKhacColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongKhacColumn.DonGia.ToString())];
			entity.NamHoc = (reader[KhoiLuongKhacColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongKhacColumn.NamHoc.ToString())];
			entity.HocKy = (reader[KhoiLuongKhacColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongKhacColumn.HocKy.ToString())];
			entity.SoLuong = (reader[KhoiLuongKhacColumn.SoLuong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongKhacColumn.SoLuong.ToString())];
			entity.TietQuyDoi = (reader[KhoiLuongKhacColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongKhacColumn.TietQuyDoi.ToString())];
			entity.DienGiai = (reader[KhoiLuongKhacColumn.DienGiai.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongKhacColumn.DienGiai.ToString())];
			entity.PhanLoai = (reader[KhoiLuongKhacColumn.PhanLoai.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongKhacColumn.PhanLoai.ToString())];
			entity.NgayTao = (reader[KhoiLuongKhacColumn.NgayTao.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KhoiLuongKhacColumn.NgayTao.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KhoiLuongKhac"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongKhac"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KhoiLuongKhac entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaKhoiLuong = (System.Int32)dataRow["MaKhoiLuong"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.Int32?)dataRow["MaGiangVien"];
			entity.LoaiHocPhan = Convert.IsDBNull(dataRow["LoaiHocPhan"]) ? null : (System.String)dataRow["LoaiHocPhan"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.MaLop = Convert.IsDBNull(dataRow["MaLop"]) ? null : (System.String)dataRow["MaLop"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.MaNhom = Convert.IsDBNull(dataRow["MaNhom"]) ? null : (System.String)dataRow["MaNhom"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Decimal?)dataRow["SoTiet"];
			entity.SoTuan = Convert.IsDBNull(dataRow["SoTuan"]) ? null : (System.Int32?)dataRow["SoTuan"];
			entity.DonGia = Convert.IsDBNull(dataRow["DonGia"]) ? null : (System.Decimal?)dataRow["DonGia"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.SoLuong = Convert.IsDBNull(dataRow["SoLuong"]) ? null : (System.Int32?)dataRow["SoLuong"];
			entity.TietQuyDoi = Convert.IsDBNull(dataRow["TietQuyDoi"]) ? null : (System.Decimal?)dataRow["TietQuyDoi"];
			entity.DienGiai = Convert.IsDBNull(dataRow["DienGiai"]) ? null : (System.String)dataRow["DienGiai"];
			entity.PhanLoai = Convert.IsDBNull(dataRow["PhanLoai"]) ? null : (System.Int32?)dataRow["PhanLoai"];
			entity.NgayTao = Convert.IsDBNull(dataRow["NgayTao"]) ? null : (System.DateTime?)dataRow["NgayTao"];
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
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongKhac"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KhoiLuongKhac Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KhoiLuongKhac entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaGiangVienSource	
			if (CanDeepLoad(entity, "GiangVien|MaGiangVienSource", deepLoadType, innerList) 
				&& entity.MaGiangVienSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaGiangVien ?? (int)0);
				GiangVien tmpEntity = EntityManager.LocateEntity<GiangVien>(EntityLocator.ConstructKeyFromPkItems(typeof(GiangVien), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaGiangVienSource = tmpEntity;
				else
					entity.MaGiangVienSource = DataRepository.GiangVienProvider.GetByMaGiangVien(transactionManager, (entity.MaGiangVien ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaGiangVienSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaGiangVienSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GiangVienProvider.DeepLoad(transactionManager, entity.MaGiangVienSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaGiangVienSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMaKhoiLuong methods when available
			
			#region ChiTietKhoiLuongCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ChiTietKhoiLuong>|ChiTietKhoiLuongCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ChiTietKhoiLuongCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ChiTietKhoiLuongCollection = DataRepository.ChiTietKhoiLuongProvider.GetByMaKhoiLuong(transactionManager, entity.MaKhoiLuong);

				if (deep && entity.ChiTietKhoiLuongCollection.Count > 0)
				{
					deepHandles.Add("ChiTietKhoiLuongCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ChiTietKhoiLuong>) DataRepository.ChiTietKhoiLuongProvider.DeepLoad,
						new object[] { transactionManager, entity.ChiTietKhoiLuongCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
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
		/// Deep Save the entire object graph of the PMS.Entities.KhoiLuongKhac object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KhoiLuongKhac instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KhoiLuongKhac Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KhoiLuongKhac entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaGiangVienSource
			if (CanDeepSave(entity, "GiangVien|MaGiangVienSource", deepSaveType, innerList) 
				&& entity.MaGiangVienSource != null)
			{
				DataRepository.GiangVienProvider.Save(transactionManager, entity.MaGiangVienSource);
				entity.MaGiangVien = entity.MaGiangVienSource.MaGiangVien;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<ChiTietKhoiLuong>
				if (CanDeepSave(entity.ChiTietKhoiLuongCollection, "List<ChiTietKhoiLuong>|ChiTietKhoiLuongCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ChiTietKhoiLuong child in entity.ChiTietKhoiLuongCollection)
					{
						if(child.MaKhoiLuongSource != null)
						{
							child.MaKhoiLuong = child.MaKhoiLuongSource.MaKhoiLuong;
						}
						else
						{
							child.MaKhoiLuong = entity.MaKhoiLuong;
						}

					}

					if (entity.ChiTietKhoiLuongCollection.Count > 0 || entity.ChiTietKhoiLuongCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ChiTietKhoiLuongProvider.Save(transactionManager, entity.ChiTietKhoiLuongCollection);
						
						deepHandles.Add("ChiTietKhoiLuongCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ChiTietKhoiLuong >) DataRepository.ChiTietKhoiLuongProvider.DeepSave,
							new object[] { transactionManager, entity.ChiTietKhoiLuongCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
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
	
	#region KhoiLuongKhacChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KhoiLuongKhac</c>
	///</summary>
	public enum KhoiLuongKhacChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GiangVien</c> at MaGiangVienSource
		///</summary>
		[ChildEntityType(typeof(GiangVien))]
		GiangVien,
		///<summary>
		/// Collection of <c>KhoiLuongKhac</c> as OneToMany for ChiTietKhoiLuongCollection
		///</summary>
		[ChildEntityType(typeof(TList<ChiTietKhoiLuong>))]
		ChiTietKhoiLuongCollection,
	}
	
	#endregion KhoiLuongKhacChildEntityTypes
	
	#region KhoiLuongKhacFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KhoiLuongKhacColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongKhacFilterBuilder : SqlFilterBuilder<KhoiLuongKhacColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongKhacFilterBuilder class.
		/// </summary>
		public KhoiLuongKhacFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongKhacFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KhoiLuongKhacFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongKhacFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KhoiLuongKhacFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KhoiLuongKhacFilterBuilder
	
	#region KhoiLuongKhacParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KhoiLuongKhacColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongKhacParameterBuilder : ParameterizedSqlFilterBuilder<KhoiLuongKhacColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongKhacParameterBuilder class.
		/// </summary>
		public KhoiLuongKhacParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongKhacParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KhoiLuongKhacParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongKhacParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KhoiLuongKhacParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KhoiLuongKhacParameterBuilder
	
	#region KhoiLuongKhacSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KhoiLuongKhacColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongKhac"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KhoiLuongKhacSortBuilder : SqlSortBuilder<KhoiLuongKhacColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongKhacSqlSortBuilder class.
		/// </summary>
		public KhoiLuongKhacSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KhoiLuongKhacSortBuilder
	
} // end namespace
