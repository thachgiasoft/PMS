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
	/// This class is the base class for any <see cref="DuTruGioGiangKhiCoLopHocPhanProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class DuTruGioGiangKhiCoLopHocPhanProviderBaseCore : EntityProviderBase<PMS.Entities.DuTruGioGiangKhiCoLopHocPhan, PMS.Entities.DuTruGioGiangKhiCoLopHocPhanKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.DuTruGioGiangKhiCoLopHocPhanKey key)
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
		public override PMS.Entities.DuTruGioGiangKhiCoLopHocPhan Get(TransactionManager transactionManager, PMS.Entities.DuTruGioGiangKhiCoLopHocPhanKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_DuTruGioGiangKhiCoLHP index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DuTruGioGiangKhiCoLopHocPhan"/> class.</returns>
		public PMS.Entities.DuTruGioGiangKhiCoLopHocPhan GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DuTruGioGiangKhiCoLHP index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DuTruGioGiangKhiCoLopHocPhan"/> class.</returns>
		public PMS.Entities.DuTruGioGiangKhiCoLopHocPhan GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DuTruGioGiangKhiCoLHP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DuTruGioGiangKhiCoLopHocPhan"/> class.</returns>
		public PMS.Entities.DuTruGioGiangKhiCoLopHocPhan GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DuTruGioGiangKhiCoLHP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DuTruGioGiangKhiCoLopHocPhan"/> class.</returns>
		public PMS.Entities.DuTruGioGiangKhiCoLopHocPhan GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DuTruGioGiangKhiCoLHP index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DuTruGioGiangKhiCoLopHocPhan"/> class.</returns>
		public PMS.Entities.DuTruGioGiangKhiCoLopHocPhan GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DuTruGioGiangKhiCoLHP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DuTruGioGiangKhiCoLopHocPhan"/> class.</returns>
		public abstract PMS.Entities.DuTruGioGiangKhiCoLopHocPhan GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_DuTruGioGiangKhiCoLopHocPhan_TinhQuyDoiKhiChuaCoLhp 
		
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangKhiCoLopHocPhan_TinhQuyDoiKhiChuaCoLhp' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void TinhQuyDoiKhiChuaCoLhp(System.String namHoc, System.String hocKy)
		{
			 TinhQuyDoiKhiChuaCoLhp(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangKhiCoLopHocPhan_TinhQuyDoiKhiChuaCoLhp' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void TinhQuyDoiKhiChuaCoLhp(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			 TinhQuyDoiKhiChuaCoLhp(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangKhiCoLopHocPhan_TinhQuyDoiKhiChuaCoLhp' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void TinhQuyDoiKhiChuaCoLhp(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			 TinhQuyDoiKhiChuaCoLhp(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangKhiCoLopHocPhan_TinhQuyDoiKhiChuaCoLhp' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void TinhQuyDoiKhiChuaCoLhp(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_DuTruGioGiangKhiCoLopHocPhan_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangKhiCoLopHocPhan_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_DuTruGioGiangKhiCoLopHocPhan_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_DuTruGioGiangKhiCoLopHocPhan_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_DuTruGioGiangKhiCoLopHocPhan_GetByNamHocHocKy' stored procedure. 
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
		
		#region cust_DuTruGioGiangKhiCoLopHocPhan_ThongKeCaNam 
		
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangKhiCoLopHocPhan_ThongKeCaNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeCaNam(System.String namHoc)
		{
			return ThongKeCaNam(null, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangKhiCoLopHocPhan_ThongKeCaNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeCaNam(int start, int pageLength, System.String namHoc)
		{
			return ThongKeCaNam(null, start, pageLength , namHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangKhiCoLopHocPhan_ThongKeCaNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeCaNam(TransactionManager transactionManager, System.String namHoc)
		{
			return ThongKeCaNam(transactionManager, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangKhiCoLopHocPhan_ThongKeCaNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeCaNam(TransactionManager transactionManager, int start, int pageLength , System.String namHoc);
		
		#endregion
		
		#region cust_DuTruGioGiangKhiCoLopHocPhan_ThongKeTheoKhoa 
		
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangKhiCoLopHocPhan_ThongKeTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTheoKhoa(System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return ThongKeTheoKhoa(null, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangKhiCoLopHocPhan_ThongKeTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTheoKhoa(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return ThongKeTheoKhoa(null, start, pageLength , namHoc, hocKy, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangKhiCoLopHocPhan_ThongKeTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTheoKhoa(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return ThongKeTheoKhoa(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangKhiCoLopHocPhan_ThongKeTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeTheoKhoa(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi);
		
		#endregion
		
		#region cust_DuTruGioGiangKhiCoLopHocPhan_LuuKhoa 
		
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangKhiCoLopHocPhan_LuuKhoa' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuKhoa(System.String xmlData, ref System.Int32 reVal)
		{
			 LuuKhoa(null, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangKhiCoLopHocPhan_LuuKhoa' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuKhoa(int start, int pageLength, System.String xmlData, ref System.Int32 reVal)
		{
			 LuuKhoa(null, start, pageLength , xmlData, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangKhiCoLopHocPhan_LuuKhoa' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuKhoa(TransactionManager transactionManager, System.String xmlData, ref System.Int32 reVal)
		{
			 LuuKhoa(transactionManager, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangKhiCoLopHocPhan_LuuKhoa' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LuuKhoa(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;DuTruGioGiangKhiCoLopHocPhan&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;DuTruGioGiangKhiCoLopHocPhan&gt;"/></returns>
		public static TList<DuTruGioGiangKhiCoLopHocPhan> Fill(IDataReader reader, TList<DuTruGioGiangKhiCoLopHocPhan> rows, int start, int pageLength)
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
				
				PMS.Entities.DuTruGioGiangKhiCoLopHocPhan c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("DuTruGioGiangKhiCoLopHocPhan")
					.Append("|").Append((System.Int32)reader[((int)DuTruGioGiangKhiCoLopHocPhanColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<DuTruGioGiangKhiCoLopHocPhan>(
					key.ToString(), // EntityTrackingKey
					"DuTruGioGiangKhiCoLopHocPhan",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.DuTruGioGiangKhiCoLopHocPhan();
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
					c.Id = (System.Int32)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.Id.ToString())];
					c.MaLopHocPhan = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.MaLopHocPhan.ToString())];
					c.TenLopHocPhan = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.TenLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.TenLopHocPhan.ToString())];
					c.NamHoc = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.NamHoc.ToString())];
					c.HocKy = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.HocKy.ToString())];
					c.MaMonHoc = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.MaMonHoc.ToString())];
					c.TenMonHoc = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.TenMonHoc.ToString())];
					c.SoTiet = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.SoTiet.ToString())];
					c.SiSo = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.SiSo.ToString())];
					c.MaLoaiHocPhan = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.MaLoaiHocPhan.ToString())];
					c.TenLoaiHocPhan = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.TenLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.TenLoaiHocPhan.ToString())];
					c.MaBacDaoTao = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.MaBacDaoTao.ToString())];
					c.MaNhomMonHoc = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.MaNhomMonHoc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.MaNhomMonHoc.ToString())];
					c.HeSoBacDaoTao = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.HeSoBacDaoTao.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.HeSoBacDaoTao.ToString())];
					c.HeSoLopDong = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.HeSoLopDong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.HeSoLopDong.ToString())];
					c.HeSoMonThucTap = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.HeSoMonThucTap.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.HeSoMonThucTap.ToString())];
					c.HeSoCoVanHocTap = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.HeSoCoVanHocTap.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.HeSoCoVanHocTap.ToString())];
					c.SoTietQuyDoi = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.SoTietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.SoTietQuyDoi.ToString())];
					c.MaDonVi = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.MaDonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.MaDonVi.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DuTruGioGiangKhiCoLopHocPhan"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DuTruGioGiangKhiCoLopHocPhan"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.DuTruGioGiangKhiCoLopHocPhan entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.Id.ToString())];
			entity.MaLopHocPhan = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.MaLopHocPhan.ToString())];
			entity.TenLopHocPhan = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.TenLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.TenLopHocPhan.ToString())];
			entity.NamHoc = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.NamHoc.ToString())];
			entity.HocKy = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.HocKy.ToString())];
			entity.MaMonHoc = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.MaMonHoc.ToString())];
			entity.TenMonHoc = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.TenMonHoc.ToString())];
			entity.SoTiet = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.SoTiet.ToString())];
			entity.SiSo = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.SiSo.ToString())];
			entity.MaLoaiHocPhan = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.MaLoaiHocPhan.ToString())];
			entity.TenLoaiHocPhan = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.TenLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.TenLoaiHocPhan.ToString())];
			entity.MaBacDaoTao = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.MaBacDaoTao.ToString())];
			entity.MaNhomMonHoc = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.MaNhomMonHoc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.MaNhomMonHoc.ToString())];
			entity.HeSoBacDaoTao = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.HeSoBacDaoTao.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.HeSoBacDaoTao.ToString())];
			entity.HeSoLopDong = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.HeSoLopDong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.HeSoLopDong.ToString())];
			entity.HeSoMonThucTap = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.HeSoMonThucTap.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.HeSoMonThucTap.ToString())];
			entity.HeSoCoVanHocTap = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.HeSoCoVanHocTap.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.HeSoCoVanHocTap.ToString())];
			entity.SoTietQuyDoi = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.SoTietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.SoTietQuyDoi.ToString())];
			entity.MaDonVi = (reader[DuTruGioGiangKhiCoLopHocPhanColumn.MaDonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangKhiCoLopHocPhanColumn.MaDonVi.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DuTruGioGiangKhiCoLopHocPhan"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DuTruGioGiangKhiCoLopHocPhan"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.DuTruGioGiangKhiCoLopHocPhan entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.TenLopHocPhan = Convert.IsDBNull(dataRow["TenLopHocPhan"]) ? null : (System.String)dataRow["TenLopHocPhan"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = Convert.IsDBNull(dataRow["TenMonHoc"]) ? null : (System.String)dataRow["TenMonHoc"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Decimal?)dataRow["SoTiet"];
			entity.SiSo = Convert.IsDBNull(dataRow["SiSo"]) ? null : (System.Int32?)dataRow["SiSo"];
			entity.MaLoaiHocPhan = Convert.IsDBNull(dataRow["MaLoaiHocPhan"]) ? null : (System.Int32?)dataRow["MaLoaiHocPhan"];
			entity.TenLoaiHocPhan = Convert.IsDBNull(dataRow["TenLoaiHocPhan"]) ? null : (System.String)dataRow["TenLoaiHocPhan"];
			entity.MaBacDaoTao = Convert.IsDBNull(dataRow["MaBacDaoTao"]) ? null : (System.String)dataRow["MaBacDaoTao"];
			entity.MaNhomMonHoc = Convert.IsDBNull(dataRow["MaNhomMonHoc"]) ? null : (System.Int32?)dataRow["MaNhomMonHoc"];
			entity.HeSoBacDaoTao = Convert.IsDBNull(dataRow["HeSoBacDaoTao"]) ? null : (System.Decimal?)dataRow["HeSoBacDaoTao"];
			entity.HeSoLopDong = Convert.IsDBNull(dataRow["HeSoLopDong"]) ? null : (System.Decimal?)dataRow["HeSoLopDong"];
			entity.HeSoMonThucTap = Convert.IsDBNull(dataRow["HeSoMonThucTap"]) ? null : (System.Decimal?)dataRow["HeSoMonThucTap"];
			entity.HeSoCoVanHocTap = Convert.IsDBNull(dataRow["HeSoCoVanHocTap"]) ? null : (System.Decimal?)dataRow["HeSoCoVanHocTap"];
			entity.SoTietQuyDoi = Convert.IsDBNull(dataRow["SoTietQuyDoi"]) ? null : (System.Decimal?)dataRow["SoTietQuyDoi"];
			entity.MaDonVi = Convert.IsDBNull(dataRow["MaDonVi"]) ? null : (System.String)dataRow["MaDonVi"];
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
		/// <param name="entity">The <see cref="PMS.Entities.DuTruGioGiangKhiCoLopHocPhan"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.DuTruGioGiangKhiCoLopHocPhan Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.DuTruGioGiangKhiCoLopHocPhan entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.DuTruGioGiangKhiCoLopHocPhan object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.DuTruGioGiangKhiCoLopHocPhan instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.DuTruGioGiangKhiCoLopHocPhan Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.DuTruGioGiangKhiCoLopHocPhan entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region DuTruGioGiangKhiCoLopHocPhanChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.DuTruGioGiangKhiCoLopHocPhan</c>
	///</summary>
	public enum DuTruGioGiangKhiCoLopHocPhanChildEntityTypes
	{
	}
	
	#endregion DuTruGioGiangKhiCoLopHocPhanChildEntityTypes
	
	#region DuTruGioGiangKhiCoLopHocPhanFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;DuTruGioGiangKhiCoLopHocPhanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DuTruGioGiangKhiCoLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DuTruGioGiangKhiCoLopHocPhanFilterBuilder : SqlFilterBuilder<DuTruGioGiangKhiCoLopHocPhanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DuTruGioGiangKhiCoLopHocPhanFilterBuilder class.
		/// </summary>
		public DuTruGioGiangKhiCoLopHocPhanFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DuTruGioGiangKhiCoLopHocPhanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DuTruGioGiangKhiCoLopHocPhanFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DuTruGioGiangKhiCoLopHocPhanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DuTruGioGiangKhiCoLopHocPhanFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DuTruGioGiangKhiCoLopHocPhanFilterBuilder
	
	#region DuTruGioGiangKhiCoLopHocPhanParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;DuTruGioGiangKhiCoLopHocPhanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DuTruGioGiangKhiCoLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DuTruGioGiangKhiCoLopHocPhanParameterBuilder : ParameterizedSqlFilterBuilder<DuTruGioGiangKhiCoLopHocPhanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DuTruGioGiangKhiCoLopHocPhanParameterBuilder class.
		/// </summary>
		public DuTruGioGiangKhiCoLopHocPhanParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DuTruGioGiangKhiCoLopHocPhanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DuTruGioGiangKhiCoLopHocPhanParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DuTruGioGiangKhiCoLopHocPhanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DuTruGioGiangKhiCoLopHocPhanParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DuTruGioGiangKhiCoLopHocPhanParameterBuilder
	
	#region DuTruGioGiangKhiCoLopHocPhanSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;DuTruGioGiangKhiCoLopHocPhanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DuTruGioGiangKhiCoLopHocPhan"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class DuTruGioGiangKhiCoLopHocPhanSortBuilder : SqlSortBuilder<DuTruGioGiangKhiCoLopHocPhanColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DuTruGioGiangKhiCoLopHocPhanSqlSortBuilder class.
		/// </summary>
		public DuTruGioGiangKhiCoLopHocPhanSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion DuTruGioGiangKhiCoLopHocPhanSortBuilder
	
} // end namespace
