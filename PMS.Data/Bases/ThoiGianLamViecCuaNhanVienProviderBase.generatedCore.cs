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
	/// This class is the base class for any <see cref="ThoiGianLamViecCuaNhanVienProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ThoiGianLamViecCuaNhanVienProviderBaseCore : EntityProviderBase<PMS.Entities.ThoiGianLamViecCuaNhanVien, PMS.Entities.ThoiGianLamViecCuaNhanVienKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.ThoiGianLamViecCuaNhanVienKey key)
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
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ThoiGianLamViecCuaNhanVien_GiangVien key.
		///		FK_ThoiGianLamViecCuaNhanVien_GiangVien Description: 
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.ThoiGianLamViecCuaNhanVien objects.</returns>
		public TList<ThoiGianLamViecCuaNhanVien> GetByMaGiangVien(System.Int32? _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(_maGiangVien, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ThoiGianLamViecCuaNhanVien_GiangVien key.
		///		FK_ThoiGianLamViecCuaNhanVien_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.ThoiGianLamViecCuaNhanVien objects.</returns>
		/// <remarks></remarks>
		public TList<ThoiGianLamViecCuaNhanVien> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ThoiGianLamViecCuaNhanVien_GiangVien key.
		///		FK_ThoiGianLamViecCuaNhanVien_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.ThoiGianLamViecCuaNhanVien objects.</returns>
		public TList<ThoiGianLamViecCuaNhanVien> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ThoiGianLamViecCuaNhanVien_GiangVien key.
		///		fkThoiGianLamViecCuaNhanVienGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.ThoiGianLamViecCuaNhanVien objects.</returns>
		public TList<ThoiGianLamViecCuaNhanVien> GetByMaGiangVien(System.Int32? _maGiangVien, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ThoiGianLamViecCuaNhanVien_GiangVien key.
		///		fkThoiGianLamViecCuaNhanVienGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.ThoiGianLamViecCuaNhanVien objects.</returns>
		public TList<ThoiGianLamViecCuaNhanVien> GetByMaGiangVien(System.Int32? _maGiangVien, int start, int pageLength,out int count)
		{
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ThoiGianLamViecCuaNhanVien_GiangVien key.
		///		FK_ThoiGianLamViecCuaNhanVien_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.ThoiGianLamViecCuaNhanVien objects.</returns>
		public abstract TList<ThoiGianLamViecCuaNhanVien> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.ThoiGianLamViecCuaNhanVien Get(TransactionManager transactionManager, PMS.Entities.ThoiGianLamViecCuaNhanVienKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ThoiGianLamViecCuaNhanVien index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThoiGianLamViecCuaNhanVien"/> class.</returns>
		public PMS.Entities.ThoiGianLamViecCuaNhanVien GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThoiGianLamViecCuaNhanVien index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThoiGianLamViecCuaNhanVien"/> class.</returns>
		public PMS.Entities.ThoiGianLamViecCuaNhanVien GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThoiGianLamViecCuaNhanVien index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThoiGianLamViecCuaNhanVien"/> class.</returns>
		public PMS.Entities.ThoiGianLamViecCuaNhanVien GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThoiGianLamViecCuaNhanVien index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThoiGianLamViecCuaNhanVien"/> class.</returns>
		public PMS.Entities.ThoiGianLamViecCuaNhanVien GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThoiGianLamViecCuaNhanVien index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThoiGianLamViecCuaNhanVien"/> class.</returns>
		public PMS.Entities.ThoiGianLamViecCuaNhanVien GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThoiGianLamViecCuaNhanVien index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThoiGianLamViecCuaNhanVien"/> class.</returns>
		public abstract PMS.Entities.ThoiGianLamViecCuaNhanVien GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_ThoiGianLamViecCuaNhanVien_LuuTheoNamHoc 
		
		/// <summary>
		///	This method wrap the 'cust_ThoiGianLamViecCuaNhanVien_LuuTheoNamHoc' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuTheoNamHoc(System.String xmlData, System.String namHoc, ref System.Int32 reVal)
		{
			 LuuTheoNamHoc(null, 0, int.MaxValue , xmlData, namHoc, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThoiGianLamViecCuaNhanVien_LuuTheoNamHoc' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuTheoNamHoc(int start, int pageLength, System.String xmlData, System.String namHoc, ref System.Int32 reVal)
		{
			 LuuTheoNamHoc(null, start, pageLength , xmlData, namHoc, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThoiGianLamViecCuaNhanVien_LuuTheoNamHoc' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuTheoNamHoc(TransactionManager transactionManager, System.String xmlData, System.String namHoc, ref System.Int32 reVal)
		{
			 LuuTheoNamHoc(transactionManager, 0, int.MaxValue , xmlData, namHoc, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThoiGianLamViecCuaNhanVien_LuuTheoNamHoc' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LuuTheoNamHoc(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_ThoiGianLamViecCuaNhanVien_GetQuanLy 
		
		/// <summary>
		///	This method wrap the 'cust_ThoiGianLamViecCuaNhanVien_GetQuanLy' stored procedure. 
		/// </summary>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetQuanLy()
		{
			return GetQuanLy(null, 0, int.MaxValue );
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThoiGianLamViecCuaNhanVien_GetQuanLy' stored procedure. 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetQuanLy(int start, int pageLength)
		{
			return GetQuanLy(null, start, pageLength );
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThoiGianLamViecCuaNhanVien_GetQuanLy' stored procedure. 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetQuanLy(TransactionManager transactionManager)
		{
			return GetQuanLy(transactionManager, 0, int.MaxValue );
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThoiGianLamViecCuaNhanVien_GetQuanLy' stored procedure. 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetQuanLy(TransactionManager transactionManager, int start, int pageLength );
		
		#endregion
		
		#region cust_ThoiGianLamViecCuaNhanVien_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_ThoiGianLamViecCuaNhanVien_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, ref System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThoiGianLamViecCuaNhanVien_Luu' stored procedure. 
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
		///	This method wrap the 'cust_ThoiGianLamViecCuaNhanVien_Luu' stored procedure. 
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
		///	This method wrap the 'cust_ThoiGianLamViecCuaNhanVien_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ThoiGianLamViecCuaNhanVien&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ThoiGianLamViecCuaNhanVien&gt;"/></returns>
		public static TList<ThoiGianLamViecCuaNhanVien> Fill(IDataReader reader, TList<ThoiGianLamViecCuaNhanVien> rows, int start, int pageLength)
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
				
				PMS.Entities.ThoiGianLamViecCuaNhanVien c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ThoiGianLamViecCuaNhanVien")
					.Append("|").Append((System.Int32)reader[((int)ThoiGianLamViecCuaNhanVienColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<ThoiGianLamViecCuaNhanVien>(
					key.ToString(), // EntityTrackingKey
					"ThoiGianLamViecCuaNhanVien",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.ThoiGianLamViecCuaNhanVien();
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
					c.Id = (System.Int32)reader[(ThoiGianLamViecCuaNhanVienColumn.Id.ToString())];
					c.MaGiangVien = (reader[ThoiGianLamViecCuaNhanVienColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThoiGianLamViecCuaNhanVienColumn.MaGiangVien.ToString())];
					c.NoiDung = (reader[ThoiGianLamViecCuaNhanVienColumn.NoiDung.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThoiGianLamViecCuaNhanVienColumn.NoiDung.ToString())];
					c.TuNgay = (reader[ThoiGianLamViecCuaNhanVienColumn.TuNgay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ThoiGianLamViecCuaNhanVienColumn.TuNgay.ToString())];
					c.DenNgay = (reader[ThoiGianLamViecCuaNhanVienColumn.DenNgay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ThoiGianLamViecCuaNhanVienColumn.DenNgay.ToString())];
					c.NgayCapNhat = (reader[ThoiGianLamViecCuaNhanVienColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThoiGianLamViecCuaNhanVienColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[ThoiGianLamViecCuaNhanVienColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThoiGianLamViecCuaNhanVienColumn.NguoiCapNhat.ToString())];
					c.NamHoc = (reader[ThoiGianLamViecCuaNhanVienColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThoiGianLamViecCuaNhanVienColumn.NamHoc.ToString())];
					c.HocKy = (reader[ThoiGianLamViecCuaNhanVienColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThoiGianLamViecCuaNhanVienColumn.HocKy.ToString())];
					c.MaGiamTruDinhMuc = (reader[ThoiGianLamViecCuaNhanVienColumn.MaGiamTruDinhMuc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThoiGianLamViecCuaNhanVienColumn.MaGiamTruDinhMuc.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThoiGianLamViecCuaNhanVien"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThoiGianLamViecCuaNhanVien"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.ThoiGianLamViecCuaNhanVien entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(ThoiGianLamViecCuaNhanVienColumn.Id.ToString())];
			entity.MaGiangVien = (reader[ThoiGianLamViecCuaNhanVienColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThoiGianLamViecCuaNhanVienColumn.MaGiangVien.ToString())];
			entity.NoiDung = (reader[ThoiGianLamViecCuaNhanVienColumn.NoiDung.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThoiGianLamViecCuaNhanVienColumn.NoiDung.ToString())];
			entity.TuNgay = (reader[ThoiGianLamViecCuaNhanVienColumn.TuNgay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ThoiGianLamViecCuaNhanVienColumn.TuNgay.ToString())];
			entity.DenNgay = (reader[ThoiGianLamViecCuaNhanVienColumn.DenNgay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ThoiGianLamViecCuaNhanVienColumn.DenNgay.ToString())];
			entity.NgayCapNhat = (reader[ThoiGianLamViecCuaNhanVienColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThoiGianLamViecCuaNhanVienColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[ThoiGianLamViecCuaNhanVienColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThoiGianLamViecCuaNhanVienColumn.NguoiCapNhat.ToString())];
			entity.NamHoc = (reader[ThoiGianLamViecCuaNhanVienColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThoiGianLamViecCuaNhanVienColumn.NamHoc.ToString())];
			entity.HocKy = (reader[ThoiGianLamViecCuaNhanVienColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThoiGianLamViecCuaNhanVienColumn.HocKy.ToString())];
			entity.MaGiamTruDinhMuc = (reader[ThoiGianLamViecCuaNhanVienColumn.MaGiamTruDinhMuc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThoiGianLamViecCuaNhanVienColumn.MaGiamTruDinhMuc.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThoiGianLamViecCuaNhanVien"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThoiGianLamViecCuaNhanVien"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.ThoiGianLamViecCuaNhanVien entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.Int32?)dataRow["MaGiangVien"];
			entity.NoiDung = Convert.IsDBNull(dataRow["NoiDung"]) ? null : (System.String)dataRow["NoiDung"];
			entity.TuNgay = Convert.IsDBNull(dataRow["TuNgay"]) ? null : (System.DateTime?)dataRow["TuNgay"];
			entity.DenNgay = Convert.IsDBNull(dataRow["DenNgay"]) ? null : (System.DateTime?)dataRow["DenNgay"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaGiamTruDinhMuc = Convert.IsDBNull(dataRow["MaGiamTruDinhMuc"]) ? null : (System.Int32?)dataRow["MaGiamTruDinhMuc"];
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
		/// <param name="entity">The <see cref="PMS.Entities.ThoiGianLamViecCuaNhanVien"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.ThoiGianLamViecCuaNhanVien Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.ThoiGianLamViecCuaNhanVien entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.ThoiGianLamViecCuaNhanVien object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.ThoiGianLamViecCuaNhanVien instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.ThoiGianLamViecCuaNhanVien Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.ThoiGianLamViecCuaNhanVien entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region ThoiGianLamViecCuaNhanVienChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.ThoiGianLamViecCuaNhanVien</c>
	///</summary>
	public enum ThoiGianLamViecCuaNhanVienChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GiangVien</c> at MaGiangVienSource
		///</summary>
		[ChildEntityType(typeof(GiangVien))]
		GiangVien,
	}
	
	#endregion ThoiGianLamViecCuaNhanVienChildEntityTypes
	
	#region ThoiGianLamViecCuaNhanVienFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ThoiGianLamViecCuaNhanVienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThoiGianLamViecCuaNhanVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThoiGianLamViecCuaNhanVienFilterBuilder : SqlFilterBuilder<ThoiGianLamViecCuaNhanVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThoiGianLamViecCuaNhanVienFilterBuilder class.
		/// </summary>
		public ThoiGianLamViecCuaNhanVienFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThoiGianLamViecCuaNhanVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThoiGianLamViecCuaNhanVienFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThoiGianLamViecCuaNhanVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThoiGianLamViecCuaNhanVienFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThoiGianLamViecCuaNhanVienFilterBuilder
	
	#region ThoiGianLamViecCuaNhanVienParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ThoiGianLamViecCuaNhanVienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThoiGianLamViecCuaNhanVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThoiGianLamViecCuaNhanVienParameterBuilder : ParameterizedSqlFilterBuilder<ThoiGianLamViecCuaNhanVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThoiGianLamViecCuaNhanVienParameterBuilder class.
		/// </summary>
		public ThoiGianLamViecCuaNhanVienParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThoiGianLamViecCuaNhanVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThoiGianLamViecCuaNhanVienParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThoiGianLamViecCuaNhanVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThoiGianLamViecCuaNhanVienParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThoiGianLamViecCuaNhanVienParameterBuilder
	
	#region ThoiGianLamViecCuaNhanVienSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ThoiGianLamViecCuaNhanVienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThoiGianLamViecCuaNhanVien"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ThoiGianLamViecCuaNhanVienSortBuilder : SqlSortBuilder<ThoiGianLamViecCuaNhanVienColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThoiGianLamViecCuaNhanVienSqlSortBuilder class.
		/// </summary>
		public ThoiGianLamViecCuaNhanVienSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ThoiGianLamViecCuaNhanVienSortBuilder
	
} // end namespace
