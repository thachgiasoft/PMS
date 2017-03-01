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
	/// This class is the base class for any <see cref="KcqDonGiaProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KcqDonGiaProviderBaseCore : EntityProviderBase<PMS.Entities.KcqDonGia, PMS.Entities.KcqDonGiaKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KcqDonGiaKey key)
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
		public override PMS.Entities.KcqDonGia Get(TransactionManager transactionManager, PMS.Entities.KcqDonGiaKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KcqDonGia index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqDonGia"/> class.</returns>
		public PMS.Entities.KcqDonGia GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqDonGia index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqDonGia"/> class.</returns>
		public PMS.Entities.KcqDonGia GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqDonGia index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqDonGia"/> class.</returns>
		public PMS.Entities.KcqDonGia GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqDonGia index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqDonGia"/> class.</returns>
		public PMS.Entities.KcqDonGia GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqDonGia index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqDonGia"/> class.</returns>
		public PMS.Entities.KcqDonGia GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqDonGia index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqDonGia"/> class.</returns>
		public abstract PMS.Entities.KcqDonGia GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_KcqDonGia_GetByMaQuanLyNamHocHocKyLopClc 
		
		/// <summary>
		///	This method wrap the 'cust_KcqDonGia_GetByMaQuanLyNamHocHocKyLopClc' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lopClc"> A <c>System.Boolean</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Double</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaQuanLyNamHocHocKyLopClc(System.String maQuanLy, System.String namHoc, System.String hocKy, System.Boolean lopClc, ref System.Double ketQua)
		{
			 GetByMaQuanLyNamHocHocKyLopClc(null, 0, int.MaxValue , maQuanLy, namHoc, hocKy, lopClc, ref ketQua);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqDonGia_GetByMaQuanLyNamHocHocKyLopClc' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lopClc"> A <c>System.Boolean</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaQuanLyNamHocHocKyLopClc(int start, int pageLength, System.String maQuanLy, System.String namHoc, System.String hocKy, System.Boolean lopClc, ref System.Double ketQua)
		{
			 GetByMaQuanLyNamHocHocKyLopClc(null, start, pageLength , maQuanLy, namHoc, hocKy, lopClc, ref ketQua);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KcqDonGia_GetByMaQuanLyNamHocHocKyLopClc' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lopClc"> A <c>System.Boolean</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Double</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaQuanLyNamHocHocKyLopClc(TransactionManager transactionManager, System.String maQuanLy, System.String namHoc, System.String hocKy, System.Boolean lopClc, ref System.Double ketQua)
		{
			 GetByMaQuanLyNamHocHocKyLopClc(transactionManager, 0, int.MaxValue , maQuanLy, namHoc, hocKy, lopClc, ref ketQua);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqDonGia_GetByMaQuanLyNamHocHocKyLopClc' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lopClc"> A <c>System.Boolean</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetByMaQuanLyNamHocHocKyLopClc(TransactionManager transactionManager, int start, int pageLength , System.String maQuanLy, System.String namHoc, System.String hocKy, System.Boolean lopClc, ref System.Double ketQua);
		
		#endregion
		
		#region cust_KcqDonGia_GetByHinhThucDaoTao 
		
		/// <summary>
		///	This method wrap the 'cust_KcqDonGia_GetByHinhThucDaoTao' stored procedure. 
		/// </summary>
		/// <param name="maHinhThucDaoTao"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqDonGia&gt;"/> instance.</returns>
		public TList<KcqDonGia> GetByHinhThucDaoTao(System.Int32 maHinhThucDaoTao)
		{
			return GetByHinhThucDaoTao(null, 0, int.MaxValue , maHinhThucDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqDonGia_GetByHinhThucDaoTao' stored procedure. 
		/// </summary>
		/// <param name="maHinhThucDaoTao"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqDonGia&gt;"/> instance.</returns>
		public TList<KcqDonGia> GetByHinhThucDaoTao(int start, int pageLength, System.Int32 maHinhThucDaoTao)
		{
			return GetByHinhThucDaoTao(null, start, pageLength , maHinhThucDaoTao);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KcqDonGia_GetByHinhThucDaoTao' stored procedure. 
		/// </summary>
		/// <param name="maHinhThucDaoTao"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqDonGia&gt;"/> instance.</returns>
		public TList<KcqDonGia> GetByHinhThucDaoTao(TransactionManager transactionManager, System.Int32 maHinhThucDaoTao)
		{
			return GetByHinhThucDaoTao(transactionManager, 0, int.MaxValue , maHinhThucDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqDonGia_GetByHinhThucDaoTao' stored procedure. 
		/// </summary>
		/// <param name="maHinhThucDaoTao"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqDonGia&gt;"/> instance.</returns>
		public abstract TList<KcqDonGia> GetByHinhThucDaoTao(TransactionManager transactionManager, int start, int pageLength , System.Int32 maHinhThucDaoTao);
		
		#endregion
		
		#region cust_KcqDonGia_GetByMaLoaiGiangVienMaHocHamMaHocViLopClc 
		
		/// <summary>
		///	This method wrap the 'cust_KcqDonGia_GetByMaLoaiGiangVienMaHocHamMaHocViLopClc' stored procedure. 
		/// </summary>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <param name="lopClc"> A <c>System.Boolean</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaLoaiGiangVienMaHocHamMaHocViLopClc(System.Int32 maLoaiGiangVien, System.Int32 maHocHam, System.Int32 maHocVi, System.Boolean lopClc, ref System.Int32 ketQua)
		{
			 GetByMaLoaiGiangVienMaHocHamMaHocViLopClc(null, 0, int.MaxValue , maLoaiGiangVien, maHocHam, maHocVi, lopClc, ref ketQua);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqDonGia_GetByMaLoaiGiangVienMaHocHamMaHocViLopClc' stored procedure. 
		/// </summary>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <param name="lopClc"> A <c>System.Boolean</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaLoaiGiangVienMaHocHamMaHocViLopClc(int start, int pageLength, System.Int32 maLoaiGiangVien, System.Int32 maHocHam, System.Int32 maHocVi, System.Boolean lopClc, ref System.Int32 ketQua)
		{
			 GetByMaLoaiGiangVienMaHocHamMaHocViLopClc(null, start, pageLength , maLoaiGiangVien, maHocHam, maHocVi, lopClc, ref ketQua);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KcqDonGia_GetByMaLoaiGiangVienMaHocHamMaHocViLopClc' stored procedure. 
		/// </summary>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <param name="lopClc"> A <c>System.Boolean</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaLoaiGiangVienMaHocHamMaHocViLopClc(TransactionManager transactionManager, System.Int32 maLoaiGiangVien, System.Int32 maHocHam, System.Int32 maHocVi, System.Boolean lopClc, ref System.Int32 ketQua)
		{
			 GetByMaLoaiGiangVienMaHocHamMaHocViLopClc(transactionManager, 0, int.MaxValue , maLoaiGiangVien, maHocHam, maHocVi, lopClc, ref ketQua);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqDonGia_GetByMaLoaiGiangVienMaHocHamMaHocViLopClc' stored procedure. 
		/// </summary>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <param name="lopClc"> A <c>System.Boolean</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetByMaLoaiGiangVienMaHocHamMaHocViLopClc(TransactionManager transactionManager, int start, int pageLength , System.Int32 maLoaiGiangVien, System.Int32 maHocHam, System.Int32 maHocVi, System.Boolean lopClc, ref System.Int32 ketQua);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KcqDonGia&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KcqDonGia&gt;"/></returns>
		public static TList<KcqDonGia> Fill(IDataReader reader, TList<KcqDonGia> rows, int start, int pageLength)
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
				
				PMS.Entities.KcqDonGia c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KcqDonGia")
					.Append("|").Append((System.Int32)reader[((int)KcqDonGiaColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KcqDonGia>(
					key.ToString(), // EntityTrackingKey
					"KcqDonGia",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KcqDonGia();
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
					c.Id = (System.Int32)reader[(KcqDonGiaColumn.Id.ToString())];
					c.MaQuanLy = (reader[KcqDonGiaColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqDonGiaColumn.MaQuanLy.ToString())];
					c.MaLoaiGiangVien = (reader[KcqDonGiaColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqDonGiaColumn.MaLoaiGiangVien.ToString())];
					c.MaHocHam = (reader[KcqDonGiaColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqDonGiaColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[KcqDonGiaColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqDonGiaColumn.MaHocVi.ToString())];
					c.DonGia = (reader[KcqDonGiaColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqDonGiaColumn.DonGia.ToString())];
					c.NgayCapNhat = (reader[KcqDonGiaColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KcqDonGiaColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[KcqDonGiaColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqDonGiaColumn.NguoiCapNhat.ToString())];
					c.DonGiaClc = (reader[KcqDonGiaColumn.DonGiaClc.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqDonGiaColumn.DonGiaClc.ToString())];
					c.HeSoQuyDoiChatLuong = (reader[KcqDonGiaColumn.HeSoQuyDoiChatLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqDonGiaColumn.HeSoQuyDoiChatLuong.ToString())];
					c.DonGiaTrongChuan = (reader[KcqDonGiaColumn.DonGiaTrongChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqDonGiaColumn.DonGiaTrongChuan.ToString())];
					c.DonGiaNgoaiChuan = (reader[KcqDonGiaColumn.DonGiaNgoaiChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqDonGiaColumn.DonGiaNgoaiChuan.ToString())];
					c.MaHinhThucDaoTao = (reader[KcqDonGiaColumn.MaHinhThucDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqDonGiaColumn.MaHinhThucDaoTao.ToString())];
					c.BacDaoTao = (reader[KcqDonGiaColumn.BacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqDonGiaColumn.BacDaoTao.ToString())];
					c.NgonNguGiangDay = (reader[KcqDonGiaColumn.NgonNguGiangDay.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqDonGiaColumn.NgonNguGiangDay.ToString())];
					c.NamHoc = (reader[KcqDonGiaColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqDonGiaColumn.NamHoc.ToString())];
					c.HocKy = (reader[KcqDonGiaColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqDonGiaColumn.HocKy.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqDonGia"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqDonGia"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KcqDonGia entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(KcqDonGiaColumn.Id.ToString())];
			entity.MaQuanLy = (reader[KcqDonGiaColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqDonGiaColumn.MaQuanLy.ToString())];
			entity.MaLoaiGiangVien = (reader[KcqDonGiaColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqDonGiaColumn.MaLoaiGiangVien.ToString())];
			entity.MaHocHam = (reader[KcqDonGiaColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqDonGiaColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[KcqDonGiaColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqDonGiaColumn.MaHocVi.ToString())];
			entity.DonGia = (reader[KcqDonGiaColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqDonGiaColumn.DonGia.ToString())];
			entity.NgayCapNhat = (reader[KcqDonGiaColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KcqDonGiaColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[KcqDonGiaColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqDonGiaColumn.NguoiCapNhat.ToString())];
			entity.DonGiaClc = (reader[KcqDonGiaColumn.DonGiaClc.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqDonGiaColumn.DonGiaClc.ToString())];
			entity.HeSoQuyDoiChatLuong = (reader[KcqDonGiaColumn.HeSoQuyDoiChatLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqDonGiaColumn.HeSoQuyDoiChatLuong.ToString())];
			entity.DonGiaTrongChuan = (reader[KcqDonGiaColumn.DonGiaTrongChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqDonGiaColumn.DonGiaTrongChuan.ToString())];
			entity.DonGiaNgoaiChuan = (reader[KcqDonGiaColumn.DonGiaNgoaiChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqDonGiaColumn.DonGiaNgoaiChuan.ToString())];
			entity.MaHinhThucDaoTao = (reader[KcqDonGiaColumn.MaHinhThucDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqDonGiaColumn.MaHinhThucDaoTao.ToString())];
			entity.BacDaoTao = (reader[KcqDonGiaColumn.BacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqDonGiaColumn.BacDaoTao.ToString())];
			entity.NgonNguGiangDay = (reader[KcqDonGiaColumn.NgonNguGiangDay.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqDonGiaColumn.NgonNguGiangDay.ToString())];
			entity.NamHoc = (reader[KcqDonGiaColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqDonGiaColumn.NamHoc.ToString())];
			entity.HocKy = (reader[KcqDonGiaColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqDonGiaColumn.HocKy.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqDonGia"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqDonGia"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KcqDonGia entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaQuanLy = Convert.IsDBNull(dataRow["MaQuanLy"]) ? null : (System.String)dataRow["MaQuanLy"];
			entity.MaLoaiGiangVien = Convert.IsDBNull(dataRow["MaLoaiGiangVien"]) ? null : (System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
			entity.DonGia = Convert.IsDBNull(dataRow["DonGia"]) ? null : (System.Decimal?)dataRow["DonGia"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.DonGiaClc = Convert.IsDBNull(dataRow["DonGiaClc"]) ? null : (System.Decimal?)dataRow["DonGiaClc"];
			entity.HeSoQuyDoiChatLuong = Convert.IsDBNull(dataRow["HeSoQuyDoiChatLuong"]) ? null : (System.Decimal?)dataRow["HeSoQuyDoiChatLuong"];
			entity.DonGiaTrongChuan = Convert.IsDBNull(dataRow["DonGiaTrongChuan"]) ? null : (System.Decimal?)dataRow["DonGiaTrongChuan"];
			entity.DonGiaNgoaiChuan = Convert.IsDBNull(dataRow["DonGiaNgoaiChuan"]) ? null : (System.Decimal?)dataRow["DonGiaNgoaiChuan"];
			entity.MaHinhThucDaoTao = Convert.IsDBNull(dataRow["MaHinhThucDaoTao"]) ? null : (System.String)dataRow["MaHinhThucDaoTao"];
			entity.BacDaoTao = Convert.IsDBNull(dataRow["BacDaoTao"]) ? null : (System.String)dataRow["BacDaoTao"];
			entity.NgonNguGiangDay = Convert.IsDBNull(dataRow["NgonNguGiangDay"]) ? null : (System.String)dataRow["NgonNguGiangDay"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
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
		/// <param name="entity">The <see cref="PMS.Entities.KcqDonGia"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KcqDonGia Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KcqDonGia entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.KcqDonGia object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KcqDonGia instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KcqDonGia Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KcqDonGia entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region KcqDonGiaChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KcqDonGia</c>
	///</summary>
	public enum KcqDonGiaChildEntityTypes
	{
	}
	
	#endregion KcqDonGiaChildEntityTypes
	
	#region KcqDonGiaFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KcqDonGiaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqDonGia"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqDonGiaFilterBuilder : SqlFilterBuilder<KcqDonGiaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqDonGiaFilterBuilder class.
		/// </summary>
		public KcqDonGiaFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqDonGiaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqDonGiaFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqDonGiaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqDonGiaFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqDonGiaFilterBuilder
	
	#region KcqDonGiaParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KcqDonGiaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqDonGia"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqDonGiaParameterBuilder : ParameterizedSqlFilterBuilder<KcqDonGiaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqDonGiaParameterBuilder class.
		/// </summary>
		public KcqDonGiaParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqDonGiaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqDonGiaParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqDonGiaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqDonGiaParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqDonGiaParameterBuilder
	
	#region KcqDonGiaSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KcqDonGiaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqDonGia"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KcqDonGiaSortBuilder : SqlSortBuilder<KcqDonGiaColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqDonGiaSqlSortBuilder class.
		/// </summary>
		public KcqDonGiaSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KcqDonGiaSortBuilder
	
} // end namespace
