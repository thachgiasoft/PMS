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
	/// This class is the base class for any <see cref="KcqUteKhoiLuongKhacProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KcqUteKhoiLuongKhacProviderBaseCore : EntityProviderBase<PMS.Entities.KcqUteKhoiLuongKhac, PMS.Entities.KcqUteKhoiLuongKhacKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KcqUteKhoiLuongKhacKey key)
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
		public override PMS.Entities.KcqUteKhoiLuongKhac Get(TransactionManager transactionManager, PMS.Entities.KcqUteKhoiLuongKhacKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KcqUte_KhoiLuongKhac index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqUteKhoiLuongKhac"/> class.</returns>
		public PMS.Entities.KcqUteKhoiLuongKhac GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqUte_KhoiLuongKhac index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqUteKhoiLuongKhac"/> class.</returns>
		public PMS.Entities.KcqUteKhoiLuongKhac GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqUte_KhoiLuongKhac index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqUteKhoiLuongKhac"/> class.</returns>
		public PMS.Entities.KcqUteKhoiLuongKhac GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqUte_KhoiLuongKhac index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqUteKhoiLuongKhac"/> class.</returns>
		public PMS.Entities.KcqUteKhoiLuongKhac GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqUte_KhoiLuongKhac index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqUteKhoiLuongKhac"/> class.</returns>
		public PMS.Entities.KcqUteKhoiLuongKhac GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqUte_KhoiLuongKhac index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqUteKhoiLuongKhac"/> class.</returns>
		public abstract PMS.Entities.KcqUteKhoiLuongKhac GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_KcqUte_KhoiLuongKhac_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_KcqUte_KhoiLuongKhac_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqUte_KhoiLuongKhac_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KcqUte_KhoiLuongKhac_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqUte_KhoiLuongKhac_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_KcqUte_KhoiLuongKhac_GetByNamHocHocKyDonViLoaiGiangVien 
		
		/// <summary>
		///	This method wrap the 'cust_KcqUte_KhoiLuongKhac_GetByNamHocHocKyDonViLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyDonViLoaiGiangVien(System.String namHoc, System.String hocKy, System.String maDonVi, System.Int32 maLoaiGiangVien)
		{
			return GetByNamHocHocKyDonViLoaiGiangVien(null, 0, int.MaxValue , namHoc, hocKy, maDonVi, maLoaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqUte_KhoiLuongKhac_GetByNamHocHocKyDonViLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyDonViLoaiGiangVien(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi, System.Int32 maLoaiGiangVien)
		{
			return GetByNamHocHocKyDonViLoaiGiangVien(null, start, pageLength , namHoc, hocKy, maDonVi, maLoaiGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KcqUte_KhoiLuongKhac_GetByNamHocHocKyDonViLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyDonViLoaiGiangVien(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi, System.Int32 maLoaiGiangVien)
		{
			return GetByNamHocHocKyDonViLoaiGiangVien(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi, maLoaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqUte_KhoiLuongKhac_GetByNamHocHocKyDonViLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKyDonViLoaiGiangVien(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi, System.Int32 maLoaiGiangVien);
		
		#endregion
		
		#region cust_KcqUte_KhoiLuongKhac_GetByNamHocHocKyDot 
		
		/// <summary>
		///	This method wrap the 'cust_KcqUte_KhoiLuongKhac_GetByNamHocHocKyDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dot"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqUteKhoiLuongKhac&gt;"/> instance.</returns>
		public TList<KcqUteKhoiLuongKhac> GetByNamHocHocKyDot(System.String namHoc, System.String hocKy, System.String dot)
		{
			return GetByNamHocHocKyDot(null, 0, int.MaxValue , namHoc, hocKy, dot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqUte_KhoiLuongKhac_GetByNamHocHocKyDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dot"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqUteKhoiLuongKhac&gt;"/> instance.</returns>
		public TList<KcqUteKhoiLuongKhac> GetByNamHocHocKyDot(int start, int pageLength, System.String namHoc, System.String hocKy, System.String dot)
		{
			return GetByNamHocHocKyDot(null, start, pageLength , namHoc, hocKy, dot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KcqUte_KhoiLuongKhac_GetByNamHocHocKyDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dot"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqUteKhoiLuongKhac&gt;"/> instance.</returns>
		public TList<KcqUteKhoiLuongKhac> GetByNamHocHocKyDot(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String dot)
		{
			return GetByNamHocHocKyDot(transactionManager, 0, int.MaxValue , namHoc, hocKy, dot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqUte_KhoiLuongKhac_GetByNamHocHocKyDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dot"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqUteKhoiLuongKhac&gt;"/> instance.</returns>
		public abstract TList<KcqUteKhoiLuongKhac> GetByNamHocHocKyDot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String dot);
		
		#endregion
		
		#region cust_KcqUte_KhoiLuongKhac_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_KcqUte_KhoiLuongKhac_Luu' stored procedure. 
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
		///	This method wrap the 'cust_KcqUte_KhoiLuongKhac_Luu' stored procedure. 
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
		///	This method wrap the 'cust_KcqUte_KhoiLuongKhac_Luu' stored procedure. 
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
		///	This method wrap the 'cust_KcqUte_KhoiLuongKhac_Luu' stored procedure. 
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
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KcqUteKhoiLuongKhac&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KcqUteKhoiLuongKhac&gt;"/></returns>
		public static TList<KcqUteKhoiLuongKhac> Fill(IDataReader reader, TList<KcqUteKhoiLuongKhac> rows, int start, int pageLength)
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
				
				PMS.Entities.KcqUteKhoiLuongKhac c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KcqUteKhoiLuongKhac")
					.Append("|").Append((System.Int32)reader[((int)KcqUteKhoiLuongKhacColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KcqUteKhoiLuongKhac>(
					key.ToString(), // EntityTrackingKey
					"KcqUteKhoiLuongKhac",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KcqUteKhoiLuongKhac();
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
					c.Id = (System.Int32)reader[(KcqUteKhoiLuongKhacColumn.Id.ToString())];
					c.MaQuanLy = (reader[KcqUteKhoiLuongKhacColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongKhacColumn.MaQuanLy.ToString())];
					c.MaHocHam = (reader[KcqUteKhoiLuongKhacColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteKhoiLuongKhacColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[KcqUteKhoiLuongKhacColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteKhoiLuongKhacColumn.MaHocVi.ToString())];
					c.MaLoaiGiangVien = (reader[KcqUteKhoiLuongKhacColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteKhoiLuongKhacColumn.MaLoaiGiangVien.ToString())];
					c.MaDonVi = (reader[KcqUteKhoiLuongKhacColumn.MaDonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongKhacColumn.MaDonVi.ToString())];
					c.MaMonHoc = (reader[KcqUteKhoiLuongKhacColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongKhacColumn.MaMonHoc.ToString())];
					c.MaLoaiHocPhan = (reader[KcqUteKhoiLuongKhacColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongKhacColumn.MaLoaiHocPhan.ToString())];
					c.MaLopHocPhan = (reader[KcqUteKhoiLuongKhacColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongKhacColumn.MaLopHocPhan.ToString())];
					c.MaLop = (reader[KcqUteKhoiLuongKhacColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongKhacColumn.MaLop.ToString())];
					c.MaNhom = (reader[KcqUteKhoiLuongKhacColumn.MaNhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongKhacColumn.MaNhom.ToString())];
					c.SoTiet = (reader[KcqUteKhoiLuongKhacColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteKhoiLuongKhacColumn.SoTiet.ToString())];
					c.SoTuan = (reader[KcqUteKhoiLuongKhacColumn.SoTuan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteKhoiLuongKhacColumn.SoTuan.ToString())];
					c.SiSo = (reader[KcqUteKhoiLuongKhacColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteKhoiLuongKhacColumn.SiSo.ToString())];
					c.SoTietQuyDoi = (reader[KcqUteKhoiLuongKhacColumn.SoTietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqUteKhoiLuongKhacColumn.SoTietQuyDoi.ToString())];
					c.DonGia = (reader[KcqUteKhoiLuongKhacColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqUteKhoiLuongKhacColumn.DonGia.ToString())];
					c.ThanhTien = (reader[KcqUteKhoiLuongKhacColumn.ThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqUteKhoiLuongKhacColumn.ThanhTien.ToString())];
					c.NamHoc = (reader[KcqUteKhoiLuongKhacColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongKhacColumn.NamHoc.ToString())];
					c.HocKy = (reader[KcqUteKhoiLuongKhacColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongKhacColumn.HocKy.ToString())];
					c.PhanLoai = (reader[KcqUteKhoiLuongKhacColumn.PhanLoai.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongKhacColumn.PhanLoai.ToString())];
					c.GhiChu = (reader[KcqUteKhoiLuongKhacColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongKhacColumn.GhiChu.ToString())];
					c.NgayCapNhat = (reader[KcqUteKhoiLuongKhacColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KcqUteKhoiLuongKhacColumn.NgayCapNhat.ToString())];
					c.HeSoHocKy = (reader[KcqUteKhoiLuongKhacColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqUteKhoiLuongKhacColumn.HeSoHocKy.ToString())];
					c.MaDot = (reader[KcqUteKhoiLuongKhacColumn.MaDot.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongKhacColumn.MaDot.ToString())];
					c.MaDiaDiem = (reader[KcqUteKhoiLuongKhacColumn.MaDiaDiem.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongKhacColumn.MaDiaDiem.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqUteKhoiLuongKhac"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqUteKhoiLuongKhac"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KcqUteKhoiLuongKhac entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(KcqUteKhoiLuongKhacColumn.Id.ToString())];
			entity.MaQuanLy = (reader[KcqUteKhoiLuongKhacColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongKhacColumn.MaQuanLy.ToString())];
			entity.MaHocHam = (reader[KcqUteKhoiLuongKhacColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteKhoiLuongKhacColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[KcqUteKhoiLuongKhacColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteKhoiLuongKhacColumn.MaHocVi.ToString())];
			entity.MaLoaiGiangVien = (reader[KcqUteKhoiLuongKhacColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteKhoiLuongKhacColumn.MaLoaiGiangVien.ToString())];
			entity.MaDonVi = (reader[KcqUteKhoiLuongKhacColumn.MaDonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongKhacColumn.MaDonVi.ToString())];
			entity.MaMonHoc = (reader[KcqUteKhoiLuongKhacColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongKhacColumn.MaMonHoc.ToString())];
			entity.MaLoaiHocPhan = (reader[KcqUteKhoiLuongKhacColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongKhacColumn.MaLoaiHocPhan.ToString())];
			entity.MaLopHocPhan = (reader[KcqUteKhoiLuongKhacColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongKhacColumn.MaLopHocPhan.ToString())];
			entity.MaLop = (reader[KcqUteKhoiLuongKhacColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongKhacColumn.MaLop.ToString())];
			entity.MaNhom = (reader[KcqUteKhoiLuongKhacColumn.MaNhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongKhacColumn.MaNhom.ToString())];
			entity.SoTiet = (reader[KcqUteKhoiLuongKhacColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteKhoiLuongKhacColumn.SoTiet.ToString())];
			entity.SoTuan = (reader[KcqUteKhoiLuongKhacColumn.SoTuan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteKhoiLuongKhacColumn.SoTuan.ToString())];
			entity.SiSo = (reader[KcqUteKhoiLuongKhacColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteKhoiLuongKhacColumn.SiSo.ToString())];
			entity.SoTietQuyDoi = (reader[KcqUteKhoiLuongKhacColumn.SoTietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqUteKhoiLuongKhacColumn.SoTietQuyDoi.ToString())];
			entity.DonGia = (reader[KcqUteKhoiLuongKhacColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqUteKhoiLuongKhacColumn.DonGia.ToString())];
			entity.ThanhTien = (reader[KcqUteKhoiLuongKhacColumn.ThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqUteKhoiLuongKhacColumn.ThanhTien.ToString())];
			entity.NamHoc = (reader[KcqUteKhoiLuongKhacColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongKhacColumn.NamHoc.ToString())];
			entity.HocKy = (reader[KcqUteKhoiLuongKhacColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongKhacColumn.HocKy.ToString())];
			entity.PhanLoai = (reader[KcqUteKhoiLuongKhacColumn.PhanLoai.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongKhacColumn.PhanLoai.ToString())];
			entity.GhiChu = (reader[KcqUteKhoiLuongKhacColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongKhacColumn.GhiChu.ToString())];
			entity.NgayCapNhat = (reader[KcqUteKhoiLuongKhacColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KcqUteKhoiLuongKhacColumn.NgayCapNhat.ToString())];
			entity.HeSoHocKy = (reader[KcqUteKhoiLuongKhacColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqUteKhoiLuongKhacColumn.HeSoHocKy.ToString())];
			entity.MaDot = (reader[KcqUteKhoiLuongKhacColumn.MaDot.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongKhacColumn.MaDot.ToString())];
			entity.MaDiaDiem = (reader[KcqUteKhoiLuongKhacColumn.MaDiaDiem.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongKhacColumn.MaDiaDiem.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqUteKhoiLuongKhac"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqUteKhoiLuongKhac"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KcqUteKhoiLuongKhac entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaQuanLy = Convert.IsDBNull(dataRow["MaQuanLy"]) ? null : (System.String)dataRow["MaQuanLy"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
			entity.MaLoaiGiangVien = Convert.IsDBNull(dataRow["MaLoaiGiangVien"]) ? null : (System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.MaDonVi = Convert.IsDBNull(dataRow["MaDonVi"]) ? null : (System.String)dataRow["MaDonVi"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.MaLoaiHocPhan = Convert.IsDBNull(dataRow["MaLoaiHocPhan"]) ? null : (System.String)dataRow["MaLoaiHocPhan"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.MaLop = Convert.IsDBNull(dataRow["MaLop"]) ? null : (System.String)dataRow["MaLop"];
			entity.MaNhom = Convert.IsDBNull(dataRow["MaNhom"]) ? null : (System.String)dataRow["MaNhom"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Int32?)dataRow["SoTiet"];
			entity.SoTuan = Convert.IsDBNull(dataRow["SoTuan"]) ? null : (System.Int32?)dataRow["SoTuan"];
			entity.SiSo = Convert.IsDBNull(dataRow["SiSo"]) ? null : (System.Int32?)dataRow["SiSo"];
			entity.SoTietQuyDoi = Convert.IsDBNull(dataRow["SoTietQuyDoi"]) ? null : (System.Decimal?)dataRow["SoTietQuyDoi"];
			entity.DonGia = Convert.IsDBNull(dataRow["DonGia"]) ? null : (System.Decimal?)dataRow["DonGia"];
			entity.ThanhTien = Convert.IsDBNull(dataRow["ThanhTien"]) ? null : (System.Decimal?)dataRow["ThanhTien"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.PhanLoai = Convert.IsDBNull(dataRow["PhanLoai"]) ? null : (System.String)dataRow["PhanLoai"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
			entity.HeSoHocKy = Convert.IsDBNull(dataRow["HeSoHocKy"]) ? null : (System.Decimal?)dataRow["HeSoHocKy"];
			entity.MaDot = Convert.IsDBNull(dataRow["MaDot"]) ? null : (System.String)dataRow["MaDot"];
			entity.MaDiaDiem = Convert.IsDBNull(dataRow["MaDiaDiem"]) ? null : (System.String)dataRow["MaDiaDiem"];
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
		/// <param name="entity">The <see cref="PMS.Entities.KcqUteKhoiLuongKhac"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KcqUteKhoiLuongKhac Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KcqUteKhoiLuongKhac entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.KcqUteKhoiLuongKhac object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KcqUteKhoiLuongKhac instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KcqUteKhoiLuongKhac Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KcqUteKhoiLuongKhac entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region KcqUteKhoiLuongKhacChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KcqUteKhoiLuongKhac</c>
	///</summary>
	public enum KcqUteKhoiLuongKhacChildEntityTypes
	{
	}
	
	#endregion KcqUteKhoiLuongKhacChildEntityTypes
	
	#region KcqUteKhoiLuongKhacFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KcqUteKhoiLuongKhacColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqUteKhoiLuongKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqUteKhoiLuongKhacFilterBuilder : SqlFilterBuilder<KcqUteKhoiLuongKhacColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqUteKhoiLuongKhacFilterBuilder class.
		/// </summary>
		public KcqUteKhoiLuongKhacFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqUteKhoiLuongKhacFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqUteKhoiLuongKhacFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqUteKhoiLuongKhacFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqUteKhoiLuongKhacFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqUteKhoiLuongKhacFilterBuilder
	
	#region KcqUteKhoiLuongKhacParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KcqUteKhoiLuongKhacColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqUteKhoiLuongKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqUteKhoiLuongKhacParameterBuilder : ParameterizedSqlFilterBuilder<KcqUteKhoiLuongKhacColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqUteKhoiLuongKhacParameterBuilder class.
		/// </summary>
		public KcqUteKhoiLuongKhacParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqUteKhoiLuongKhacParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqUteKhoiLuongKhacParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqUteKhoiLuongKhacParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqUteKhoiLuongKhacParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqUteKhoiLuongKhacParameterBuilder
	
	#region KcqUteKhoiLuongKhacSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KcqUteKhoiLuongKhacColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqUteKhoiLuongKhac"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KcqUteKhoiLuongKhacSortBuilder : SqlSortBuilder<KcqUteKhoiLuongKhacColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqUteKhoiLuongKhacSqlSortBuilder class.
		/// </summary>
		public KcqUteKhoiLuongKhacSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KcqUteKhoiLuongKhacSortBuilder
	
} // end namespace
