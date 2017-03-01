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
	/// This class is the base class for any <see cref="GiangVienChoDuyetHoSoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GiangVienChoDuyetHoSoProviderBaseCore : EntityProviderBase<PMS.Entities.GiangVienChoDuyetHoSo, PMS.Entities.GiangVienChoDuyetHoSoKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.GiangVienChoDuyetHoSoKey key)
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
		public override PMS.Entities.GiangVienChoDuyetHoSo Get(TransactionManager transactionManager, PMS.Entities.GiangVienChoDuyetHoSoKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GiangVienChoDuyetHoSo index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienChoDuyetHoSo"/> class.</returns>
		public PMS.Entities.GiangVienChoDuyetHoSo GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVienChoDuyetHoSo index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienChoDuyetHoSo"/> class.</returns>
		public PMS.Entities.GiangVienChoDuyetHoSo GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVienChoDuyetHoSo index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienChoDuyetHoSo"/> class.</returns>
		public PMS.Entities.GiangVienChoDuyetHoSo GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVienChoDuyetHoSo index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienChoDuyetHoSo"/> class.</returns>
		public PMS.Entities.GiangVienChoDuyetHoSo GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVienChoDuyetHoSo index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienChoDuyetHoSo"/> class.</returns>
		public PMS.Entities.GiangVienChoDuyetHoSo GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVienChoDuyetHoSo index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienChoDuyetHoSo"/> class.</returns>
		public abstract PMS.Entities.GiangVienChoDuyetHoSo GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_GiangVienChoDuyetHoSo_GetSoLuongHoSoChuaDuyet 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienChoDuyetHoSo_GetSoLuongHoSoChuaDuyet' stored procedure. 
		/// </summary>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetSoLuongHoSoChuaDuyet(ref System.Int32 reVal)
		{
			 GetSoLuongHoSoChuaDuyet(null, 0, int.MaxValue , ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienChoDuyetHoSo_GetSoLuongHoSoChuaDuyet' stored procedure. 
		/// </summary>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetSoLuongHoSoChuaDuyet(int start, int pageLength, ref System.Int32 reVal)
		{
			 GetSoLuongHoSoChuaDuyet(null, start, pageLength , ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVienChoDuyetHoSo_GetSoLuongHoSoChuaDuyet' stored procedure. 
		/// </summary>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetSoLuongHoSoChuaDuyet(TransactionManager transactionManager, ref System.Int32 reVal)
		{
			 GetSoLuongHoSoChuaDuyet(transactionManager, 0, int.MaxValue , ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienChoDuyetHoSo_GetSoLuongHoSoChuaDuyet' stored procedure. 
		/// </summary>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetSoLuongHoSoChuaDuyet(TransactionManager transactionManager, int start, int pageLength , ref System.Int32 reVal);
		
		#endregion
		
		#region cust_GiangVienChoDuyetHoSo_DuyetHoSo 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienChoDuyetHoSo_DuyetHoSo' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DuyetHoSo(System.String xmlData, ref System.Int32 reVal)
		{
			 DuyetHoSo(null, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienChoDuyetHoSo_DuyetHoSo' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DuyetHoSo(int start, int pageLength, System.String xmlData, ref System.Int32 reVal)
		{
			 DuyetHoSo(null, start, pageLength , xmlData, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVienChoDuyetHoSo_DuyetHoSo' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DuyetHoSo(TransactionManager transactionManager, System.String xmlData, ref System.Int32 reVal)
		{
			 DuyetHoSo(transactionManager, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienChoDuyetHoSo_DuyetHoSo' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DuyetHoSo(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_GiangVienChoDuyetHoSo_GetMaDonViMaHocHamMaHocViMaTinhTrang 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienChoDuyetHoSo_GetMaDonViMaHocHamMaHocViMaTinhTrang' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <param name="maTinhTrang"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienChoDuyetHoSo&gt;"/> instance.</returns>
		public TList<GiangVienChoDuyetHoSo> GetMaDonViMaHocHamMaHocViMaTinhTrang(System.String maDonVi, System.Int32 maHocHam, System.Int32 maHocVi, System.String maTinhTrang)
		{
			return GetMaDonViMaHocHamMaHocViMaTinhTrang(null, 0, int.MaxValue , maDonVi, maHocHam, maHocVi, maTinhTrang);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienChoDuyetHoSo_GetMaDonViMaHocHamMaHocViMaTinhTrang' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <param name="maTinhTrang"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienChoDuyetHoSo&gt;"/> instance.</returns>
		public TList<GiangVienChoDuyetHoSo> GetMaDonViMaHocHamMaHocViMaTinhTrang(int start, int pageLength, System.String maDonVi, System.Int32 maHocHam, System.Int32 maHocVi, System.String maTinhTrang)
		{
			return GetMaDonViMaHocHamMaHocViMaTinhTrang(null, start, pageLength , maDonVi, maHocHam, maHocVi, maTinhTrang);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVienChoDuyetHoSo_GetMaDonViMaHocHamMaHocViMaTinhTrang' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <param name="maTinhTrang"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienChoDuyetHoSo&gt;"/> instance.</returns>
		public TList<GiangVienChoDuyetHoSo> GetMaDonViMaHocHamMaHocViMaTinhTrang(TransactionManager transactionManager, System.String maDonVi, System.Int32 maHocHam, System.Int32 maHocVi, System.String maTinhTrang)
		{
			return GetMaDonViMaHocHamMaHocViMaTinhTrang(transactionManager, 0, int.MaxValue , maDonVi, maHocHam, maHocVi, maTinhTrang);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienChoDuyetHoSo_GetMaDonViMaHocHamMaHocViMaTinhTrang' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <param name="maTinhTrang"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienChoDuyetHoSo&gt;"/> instance.</returns>
		public abstract TList<GiangVienChoDuyetHoSo> GetMaDonViMaHocHamMaHocViMaTinhTrang(TransactionManager transactionManager, int start, int pageLength , System.String maDonVi, System.Int32 maHocHam, System.Int32 maHocVi, System.String maTinhTrang);
		
		#endregion
		
		#region cust_GiangVienChoDuyetHoSo_GetDanhSach 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienChoDuyetHoSo_GetDanhSach' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDanhSach(System.String maDonVi)
		{
			return GetDanhSach(null, 0, int.MaxValue , maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienChoDuyetHoSo_GetDanhSach' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDanhSach(int start, int pageLength, System.String maDonVi)
		{
			return GetDanhSach(null, start, pageLength , maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVienChoDuyetHoSo_GetDanhSach' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDanhSach(TransactionManager transactionManager, System.String maDonVi)
		{
			return GetDanhSach(transactionManager, 0, int.MaxValue , maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienChoDuyetHoSo_GetDanhSach' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetDanhSach(TransactionManager transactionManager, int start, int pageLength , System.String maDonVi);
		
		#endregion
		
		#region cust_GiangVienChoDuyetHoSo_GetByMaDonVi 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienChoDuyetHoSo_GetByMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienChoDuyetHoSo&gt;"/> instance.</returns>
		public TList<GiangVienChoDuyetHoSo> GetByMaDonVi(System.String maDonVi)
		{
			return GetByMaDonVi(null, 0, int.MaxValue , maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienChoDuyetHoSo_GetByMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienChoDuyetHoSo&gt;"/> instance.</returns>
		public TList<GiangVienChoDuyetHoSo> GetByMaDonVi(int start, int pageLength, System.String maDonVi)
		{
			return GetByMaDonVi(null, start, pageLength , maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVienChoDuyetHoSo_GetByMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienChoDuyetHoSo&gt;"/> instance.</returns>
		public TList<GiangVienChoDuyetHoSo> GetByMaDonVi(TransactionManager transactionManager, System.String maDonVi)
		{
			return GetByMaDonVi(transactionManager, 0, int.MaxValue , maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienChoDuyetHoSo_GetByMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienChoDuyetHoSo&gt;"/> instance.</returns>
		public abstract TList<GiangVienChoDuyetHoSo> GetByMaDonVi(TransactionManager transactionManager, int start, int pageLength , System.String maDonVi);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GiangVienChoDuyetHoSo&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GiangVienChoDuyetHoSo&gt;"/></returns>
		public static TList<GiangVienChoDuyetHoSo> Fill(IDataReader reader, TList<GiangVienChoDuyetHoSo> rows, int start, int pageLength)
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
				
				PMS.Entities.GiangVienChoDuyetHoSo c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GiangVienChoDuyetHoSo")
					.Append("|").Append((System.Int32)reader[((int)GiangVienChoDuyetHoSoColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<GiangVienChoDuyetHoSo>(
					key.ToString(), // EntityTrackingKey
					"GiangVienChoDuyetHoSo",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.GiangVienChoDuyetHoSo();
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
					c.Id = (System.Int32)reader[(GiangVienChoDuyetHoSoColumn.Id.ToString())];
					c.MaDanToc = (reader[GiangVienChoDuyetHoSoColumn.MaDanToc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.MaDanToc.ToString())];
					c.MaTonGiao = (reader[GiangVienChoDuyetHoSoColumn.MaTonGiao.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.MaTonGiao.ToString())];
					c.MaDonVi = (reader[GiangVienChoDuyetHoSoColumn.MaDonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.MaDonVi.ToString())];
					c.MaHocHam = (reader[GiangVienChoDuyetHoSoColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienChoDuyetHoSoColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[GiangVienChoDuyetHoSoColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienChoDuyetHoSoColumn.MaHocVi.ToString())];
					c.MaLoaiGiangVien = (reader[GiangVienChoDuyetHoSoColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienChoDuyetHoSoColumn.MaLoaiGiangVien.ToString())];
					c.MaNguoiLap = (reader[GiangVienChoDuyetHoSoColumn.MaNguoiLap.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienChoDuyetHoSoColumn.MaNguoiLap.ToString())];
					c.MatKhau = (reader[GiangVienChoDuyetHoSoColumn.MatKhau.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.MatKhau.ToString())];
					c.MaTinhTrang = (reader[GiangVienChoDuyetHoSoColumn.MaTinhTrang.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienChoDuyetHoSoColumn.MaTinhTrang.ToString())];
					c.MaQuanLy = (reader[GiangVienChoDuyetHoSoColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.MaQuanLy.ToString())];
					c.Ho = (reader[GiangVienChoDuyetHoSoColumn.Ho.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.Ho.ToString())];
					c.TenDem = (reader[GiangVienChoDuyetHoSoColumn.TenDem.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.TenDem.ToString())];
					c.Ten = (reader[GiangVienChoDuyetHoSoColumn.Ten.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.Ten.ToString())];
					c.NgaySinh = (reader[GiangVienChoDuyetHoSoColumn.NgaySinh.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.NgaySinh.ToString())];
					c.GioiTinh = (reader[GiangVienChoDuyetHoSoColumn.GioiTinh.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(GiangVienChoDuyetHoSoColumn.GioiTinh.ToString())];
					c.NoiSinh = (reader[GiangVienChoDuyetHoSoColumn.NoiSinh.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.NoiSinh.ToString())];
					c.Cmnd = (reader[GiangVienChoDuyetHoSoColumn.Cmnd.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.Cmnd.ToString())];
					c.NgayCap = (reader[GiangVienChoDuyetHoSoColumn.NgayCap.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.NgayCap.ToString())];
					c.NoiCap = (reader[GiangVienChoDuyetHoSoColumn.NoiCap.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.NoiCap.ToString())];
					c.DoanDang = (reader[GiangVienChoDuyetHoSoColumn.DoanDang.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(GiangVienChoDuyetHoSoColumn.DoanDang.ToString())];
					c.NgayVaoDoanDang = (reader[GiangVienChoDuyetHoSoColumn.NgayVaoDoanDang.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.NgayVaoDoanDang.ToString())];
					c.NgayKyHopDong = (reader[GiangVienChoDuyetHoSoColumn.NgayKyHopDong.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienChoDuyetHoSoColumn.NgayKyHopDong.ToString())];
					c.NgayKetThucHopDong = (reader[GiangVienChoDuyetHoSoColumn.NgayKetThucHopDong.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienChoDuyetHoSoColumn.NgayKetThucHopDong.ToString())];
					c.HinhAnh = (reader[GiangVienChoDuyetHoSoColumn.HinhAnh.ToString()] == DBNull.Value) ? null : (System.Byte[])reader[(GiangVienChoDuyetHoSoColumn.HinhAnh.ToString())];
					c.DiaChi = (reader[GiangVienChoDuyetHoSoColumn.DiaChi.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.DiaChi.ToString())];
					c.ThuongTru = (reader[GiangVienChoDuyetHoSoColumn.ThuongTru.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.ThuongTru.ToString())];
					c.NoiLamViec = (reader[GiangVienChoDuyetHoSoColumn.NoiLamViec.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.NoiLamViec.ToString())];
					c.Email = (reader[GiangVienChoDuyetHoSoColumn.Email.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.Email.ToString())];
					c.DienThoai = (reader[GiangVienChoDuyetHoSoColumn.DienThoai.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.DienThoai.ToString())];
					c.SoDiDong = (reader[GiangVienChoDuyetHoSoColumn.SoDiDong.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.SoDiDong.ToString())];
					c.SoTaiKhoan = (reader[GiangVienChoDuyetHoSoColumn.SoTaiKhoan.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.SoTaiKhoan.ToString())];
					c.TenNganHang = (reader[GiangVienChoDuyetHoSoColumn.TenNganHang.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.TenNganHang.ToString())];
					c.MaSoThue = (reader[GiangVienChoDuyetHoSoColumn.MaSoThue.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.MaSoThue.ToString())];
					c.ChiNhanh = (reader[GiangVienChoDuyetHoSoColumn.ChiNhanh.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.ChiNhanh.ToString())];
					c.SoSoBaoHiem = (reader[GiangVienChoDuyetHoSoColumn.SoSoBaoHiem.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.SoSoBaoHiem.ToString())];
					c.ThoiGianBatDau = (reader[GiangVienChoDuyetHoSoColumn.ThoiGianBatDau.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.ThoiGianBatDau.ToString())];
					c.BacLuong = (reader[GiangVienChoDuyetHoSoColumn.BacLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienChoDuyetHoSoColumn.BacLuong.ToString())];
					c.NgayHuongLuong = (reader[GiangVienChoDuyetHoSoColumn.NgayHuongLuong.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.NgayHuongLuong.ToString())];
					c.NamLamViec = (reader[GiangVienChoDuyetHoSoColumn.NamLamViec.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.NamLamViec.ToString())];
					c.ChuyenNganh = (reader[GiangVienChoDuyetHoSoColumn.ChuyenNganh.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.ChuyenNganh.ToString())];
					c.MaHeSoThuLao = (reader[GiangVienChoDuyetHoSoColumn.MaHeSoThuLao.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.MaHeSoThuLao.ToString())];
					c.Ngach = (reader[GiangVienChoDuyetHoSoColumn.Ngach.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.Ngach.ToString())];
					c.SoHieuCongChuc = (reader[GiangVienChoDuyetHoSoColumn.SoHieuCongChuc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.SoHieuCongChuc.ToString())];
					c.Hrmid = (reader[GiangVienChoDuyetHoSoColumn.Hrmid.ToString()] == DBNull.Value) ? null : (System.Guid?)reader[(GiangVienChoDuyetHoSoColumn.Hrmid.ToString())];
					c.NoiCapBang = (reader[GiangVienChoDuyetHoSoColumn.NoiCapBang.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.NoiCapBang.ToString())];
					c.KhoaTaiKhoan = (reader[GiangVienChoDuyetHoSoColumn.KhoaTaiKhoan.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(GiangVienChoDuyetHoSoColumn.KhoaTaiKhoan.ToString())];
					c.MaLoaiNhanVien = (reader[GiangVienChoDuyetHoSoColumn.MaLoaiNhanVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienChoDuyetHoSoColumn.MaLoaiNhanVien.ToString())];
					c.MaNgachCongChuc = (reader[GiangVienChoDuyetHoSoColumn.MaNgachCongChuc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienChoDuyetHoSoColumn.MaNgachCongChuc.ToString())];
					c.MaTrinhDoChinhTri = (reader[GiangVienChoDuyetHoSoColumn.MaTrinhDoChinhTri.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienChoDuyetHoSoColumn.MaTrinhDoChinhTri.ToString())];
					c.MaTrinhDoSuPham = (reader[GiangVienChoDuyetHoSoColumn.MaTrinhDoSuPham.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienChoDuyetHoSoColumn.MaTrinhDoSuPham.ToString())];
					c.MaTrinhDoNgoaiNgu = (reader[GiangVienChoDuyetHoSoColumn.MaTrinhDoNgoaiNgu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienChoDuyetHoSoColumn.MaTrinhDoNgoaiNgu.ToString())];
					c.MaTrinhDoTinHoc = (reader[GiangVienChoDuyetHoSoColumn.MaTrinhDoTinHoc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienChoDuyetHoSoColumn.MaTrinhDoTinHoc.ToString())];
					c.MaTrinhDoQuanLyNhaNuoc = (reader[GiangVienChoDuyetHoSoColumn.MaTrinhDoQuanLyNhaNuoc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienChoDuyetHoSoColumn.MaTrinhDoQuanLyNhaNuoc.ToString())];
					c.NguoiCapNhat = (reader[GiangVienChoDuyetHoSoColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.NguoiCapNhat.ToString())];
					c.NgayCapNhat = (reader[GiangVienChoDuyetHoSoColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.NgayCapNhat.ToString())];
					c.KhoiKienThucGiangDay = (reader[GiangVienChoDuyetHoSoColumn.KhoiKienThucGiangDay.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.KhoiKienThucGiangDay.ToString())];
					c.NganhDaoTao = (reader[GiangVienChoDuyetHoSoColumn.NganhDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.NganhDaoTao.ToString())];
					c.DonViGiangDay = (reader[GiangVienChoDuyetHoSoColumn.DonViGiangDay.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.DonViGiangDay.ToString())];
					c.DaDuyet = (reader[GiangVienChoDuyetHoSoColumn.DaDuyet.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(GiangVienChoDuyetHoSoColumn.DaDuyet.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienChoDuyetHoSo"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienChoDuyetHoSo"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.GiangVienChoDuyetHoSo entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(GiangVienChoDuyetHoSoColumn.Id.ToString())];
			entity.MaDanToc = (reader[GiangVienChoDuyetHoSoColumn.MaDanToc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.MaDanToc.ToString())];
			entity.MaTonGiao = (reader[GiangVienChoDuyetHoSoColumn.MaTonGiao.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.MaTonGiao.ToString())];
			entity.MaDonVi = (reader[GiangVienChoDuyetHoSoColumn.MaDonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.MaDonVi.ToString())];
			entity.MaHocHam = (reader[GiangVienChoDuyetHoSoColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienChoDuyetHoSoColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[GiangVienChoDuyetHoSoColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienChoDuyetHoSoColumn.MaHocVi.ToString())];
			entity.MaLoaiGiangVien = (reader[GiangVienChoDuyetHoSoColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienChoDuyetHoSoColumn.MaLoaiGiangVien.ToString())];
			entity.MaNguoiLap = (reader[GiangVienChoDuyetHoSoColumn.MaNguoiLap.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienChoDuyetHoSoColumn.MaNguoiLap.ToString())];
			entity.MatKhau = (reader[GiangVienChoDuyetHoSoColumn.MatKhau.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.MatKhau.ToString())];
			entity.MaTinhTrang = (reader[GiangVienChoDuyetHoSoColumn.MaTinhTrang.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienChoDuyetHoSoColumn.MaTinhTrang.ToString())];
			entity.MaQuanLy = (reader[GiangVienChoDuyetHoSoColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.MaQuanLy.ToString())];
			entity.Ho = (reader[GiangVienChoDuyetHoSoColumn.Ho.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.Ho.ToString())];
			entity.TenDem = (reader[GiangVienChoDuyetHoSoColumn.TenDem.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.TenDem.ToString())];
			entity.Ten = (reader[GiangVienChoDuyetHoSoColumn.Ten.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.Ten.ToString())];
			entity.NgaySinh = (reader[GiangVienChoDuyetHoSoColumn.NgaySinh.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.NgaySinh.ToString())];
			entity.GioiTinh = (reader[GiangVienChoDuyetHoSoColumn.GioiTinh.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(GiangVienChoDuyetHoSoColumn.GioiTinh.ToString())];
			entity.NoiSinh = (reader[GiangVienChoDuyetHoSoColumn.NoiSinh.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.NoiSinh.ToString())];
			entity.Cmnd = (reader[GiangVienChoDuyetHoSoColumn.Cmnd.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.Cmnd.ToString())];
			entity.NgayCap = (reader[GiangVienChoDuyetHoSoColumn.NgayCap.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.NgayCap.ToString())];
			entity.NoiCap = (reader[GiangVienChoDuyetHoSoColumn.NoiCap.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.NoiCap.ToString())];
			entity.DoanDang = (reader[GiangVienChoDuyetHoSoColumn.DoanDang.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(GiangVienChoDuyetHoSoColumn.DoanDang.ToString())];
			entity.NgayVaoDoanDang = (reader[GiangVienChoDuyetHoSoColumn.NgayVaoDoanDang.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.NgayVaoDoanDang.ToString())];
			entity.NgayKyHopDong = (reader[GiangVienChoDuyetHoSoColumn.NgayKyHopDong.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienChoDuyetHoSoColumn.NgayKyHopDong.ToString())];
			entity.NgayKetThucHopDong = (reader[GiangVienChoDuyetHoSoColumn.NgayKetThucHopDong.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienChoDuyetHoSoColumn.NgayKetThucHopDong.ToString())];
			entity.HinhAnh = (reader[GiangVienChoDuyetHoSoColumn.HinhAnh.ToString()] == DBNull.Value) ? null : (System.Byte[])reader[(GiangVienChoDuyetHoSoColumn.HinhAnh.ToString())];
			entity.DiaChi = (reader[GiangVienChoDuyetHoSoColumn.DiaChi.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.DiaChi.ToString())];
			entity.ThuongTru = (reader[GiangVienChoDuyetHoSoColumn.ThuongTru.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.ThuongTru.ToString())];
			entity.NoiLamViec = (reader[GiangVienChoDuyetHoSoColumn.NoiLamViec.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.NoiLamViec.ToString())];
			entity.Email = (reader[GiangVienChoDuyetHoSoColumn.Email.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.Email.ToString())];
			entity.DienThoai = (reader[GiangVienChoDuyetHoSoColumn.DienThoai.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.DienThoai.ToString())];
			entity.SoDiDong = (reader[GiangVienChoDuyetHoSoColumn.SoDiDong.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.SoDiDong.ToString())];
			entity.SoTaiKhoan = (reader[GiangVienChoDuyetHoSoColumn.SoTaiKhoan.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.SoTaiKhoan.ToString())];
			entity.TenNganHang = (reader[GiangVienChoDuyetHoSoColumn.TenNganHang.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.TenNganHang.ToString())];
			entity.MaSoThue = (reader[GiangVienChoDuyetHoSoColumn.MaSoThue.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.MaSoThue.ToString())];
			entity.ChiNhanh = (reader[GiangVienChoDuyetHoSoColumn.ChiNhanh.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.ChiNhanh.ToString())];
			entity.SoSoBaoHiem = (reader[GiangVienChoDuyetHoSoColumn.SoSoBaoHiem.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.SoSoBaoHiem.ToString())];
			entity.ThoiGianBatDau = (reader[GiangVienChoDuyetHoSoColumn.ThoiGianBatDau.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.ThoiGianBatDau.ToString())];
			entity.BacLuong = (reader[GiangVienChoDuyetHoSoColumn.BacLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienChoDuyetHoSoColumn.BacLuong.ToString())];
			entity.NgayHuongLuong = (reader[GiangVienChoDuyetHoSoColumn.NgayHuongLuong.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.NgayHuongLuong.ToString())];
			entity.NamLamViec = (reader[GiangVienChoDuyetHoSoColumn.NamLamViec.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.NamLamViec.ToString())];
			entity.ChuyenNganh = (reader[GiangVienChoDuyetHoSoColumn.ChuyenNganh.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.ChuyenNganh.ToString())];
			entity.MaHeSoThuLao = (reader[GiangVienChoDuyetHoSoColumn.MaHeSoThuLao.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.MaHeSoThuLao.ToString())];
			entity.Ngach = (reader[GiangVienChoDuyetHoSoColumn.Ngach.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.Ngach.ToString())];
			entity.SoHieuCongChuc = (reader[GiangVienChoDuyetHoSoColumn.SoHieuCongChuc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.SoHieuCongChuc.ToString())];
			entity.Hrmid = (reader[GiangVienChoDuyetHoSoColumn.Hrmid.ToString()] == DBNull.Value) ? null : (System.Guid?)reader[(GiangVienChoDuyetHoSoColumn.Hrmid.ToString())];
			entity.NoiCapBang = (reader[GiangVienChoDuyetHoSoColumn.NoiCapBang.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.NoiCapBang.ToString())];
			entity.KhoaTaiKhoan = (reader[GiangVienChoDuyetHoSoColumn.KhoaTaiKhoan.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(GiangVienChoDuyetHoSoColumn.KhoaTaiKhoan.ToString())];
			entity.MaLoaiNhanVien = (reader[GiangVienChoDuyetHoSoColumn.MaLoaiNhanVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienChoDuyetHoSoColumn.MaLoaiNhanVien.ToString())];
			entity.MaNgachCongChuc = (reader[GiangVienChoDuyetHoSoColumn.MaNgachCongChuc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienChoDuyetHoSoColumn.MaNgachCongChuc.ToString())];
			entity.MaTrinhDoChinhTri = (reader[GiangVienChoDuyetHoSoColumn.MaTrinhDoChinhTri.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienChoDuyetHoSoColumn.MaTrinhDoChinhTri.ToString())];
			entity.MaTrinhDoSuPham = (reader[GiangVienChoDuyetHoSoColumn.MaTrinhDoSuPham.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienChoDuyetHoSoColumn.MaTrinhDoSuPham.ToString())];
			entity.MaTrinhDoNgoaiNgu = (reader[GiangVienChoDuyetHoSoColumn.MaTrinhDoNgoaiNgu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienChoDuyetHoSoColumn.MaTrinhDoNgoaiNgu.ToString())];
			entity.MaTrinhDoTinHoc = (reader[GiangVienChoDuyetHoSoColumn.MaTrinhDoTinHoc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienChoDuyetHoSoColumn.MaTrinhDoTinHoc.ToString())];
			entity.MaTrinhDoQuanLyNhaNuoc = (reader[GiangVienChoDuyetHoSoColumn.MaTrinhDoQuanLyNhaNuoc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienChoDuyetHoSoColumn.MaTrinhDoQuanLyNhaNuoc.ToString())];
			entity.NguoiCapNhat = (reader[GiangVienChoDuyetHoSoColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.NguoiCapNhat.ToString())];
			entity.NgayCapNhat = (reader[GiangVienChoDuyetHoSoColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.NgayCapNhat.ToString())];
			entity.KhoiKienThucGiangDay = (reader[GiangVienChoDuyetHoSoColumn.KhoiKienThucGiangDay.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.KhoiKienThucGiangDay.ToString())];
			entity.NganhDaoTao = (reader[GiangVienChoDuyetHoSoColumn.NganhDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.NganhDaoTao.ToString())];
			entity.DonViGiangDay = (reader[GiangVienChoDuyetHoSoColumn.DonViGiangDay.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChoDuyetHoSoColumn.DonViGiangDay.ToString())];
			entity.DaDuyet = (reader[GiangVienChoDuyetHoSoColumn.DaDuyet.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(GiangVienChoDuyetHoSoColumn.DaDuyet.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienChoDuyetHoSo"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienChoDuyetHoSo"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.GiangVienChoDuyetHoSo entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaDanToc = Convert.IsDBNull(dataRow["MaDanToc"]) ? null : (System.String)dataRow["MaDanToc"];
			entity.MaTonGiao = Convert.IsDBNull(dataRow["MaTonGiao"]) ? null : (System.String)dataRow["MaTonGiao"];
			entity.MaDonVi = Convert.IsDBNull(dataRow["MaDonVi"]) ? null : (System.String)dataRow["MaDonVi"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
			entity.MaLoaiGiangVien = Convert.IsDBNull(dataRow["MaLoaiGiangVien"]) ? null : (System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.MaNguoiLap = Convert.IsDBNull(dataRow["MaNguoiLap"]) ? null : (System.Int32?)dataRow["MaNguoiLap"];
			entity.MatKhau = Convert.IsDBNull(dataRow["MatKhau"]) ? null : (System.String)dataRow["MatKhau"];
			entity.MaTinhTrang = Convert.IsDBNull(dataRow["MaTinhTrang"]) ? null : (System.Int32?)dataRow["MaTinhTrang"];
			entity.MaQuanLy = Convert.IsDBNull(dataRow["MaQuanLy"]) ? null : (System.String)dataRow["MaQuanLy"];
			entity.Ho = Convert.IsDBNull(dataRow["Ho"]) ? null : (System.String)dataRow["Ho"];
			entity.TenDem = Convert.IsDBNull(dataRow["TenDem"]) ? null : (System.String)dataRow["TenDem"];
			entity.Ten = Convert.IsDBNull(dataRow["Ten"]) ? null : (System.String)dataRow["Ten"];
			entity.NgaySinh = Convert.IsDBNull(dataRow["NgaySinh"]) ? null : (System.String)dataRow["NgaySinh"];
			entity.GioiTinh = Convert.IsDBNull(dataRow["GioiTinh"]) ? null : (System.Boolean?)dataRow["GioiTinh"];
			entity.NoiSinh = Convert.IsDBNull(dataRow["NoiSinh"]) ? null : (System.String)dataRow["NoiSinh"];
			entity.Cmnd = Convert.IsDBNull(dataRow["Cmnd"]) ? null : (System.String)dataRow["Cmnd"];
			entity.NgayCap = Convert.IsDBNull(dataRow["NgayCap"]) ? null : (System.String)dataRow["NgayCap"];
			entity.NoiCap = Convert.IsDBNull(dataRow["NoiCap"]) ? null : (System.String)dataRow["NoiCap"];
			entity.DoanDang = Convert.IsDBNull(dataRow["DoanDang"]) ? null : (System.Boolean?)dataRow["DoanDang"];
			entity.NgayVaoDoanDang = Convert.IsDBNull(dataRow["NgayVaoDoanDang"]) ? null : (System.String)dataRow["NgayVaoDoanDang"];
			entity.NgayKyHopDong = Convert.IsDBNull(dataRow["NgayKyHopDong"]) ? null : (System.DateTime?)dataRow["NgayKyHopDong"];
			entity.NgayKetThucHopDong = Convert.IsDBNull(dataRow["NgayKetThucHopDong"]) ? null : (System.DateTime?)dataRow["NgayKetThucHopDong"];
			entity.HinhAnh = Convert.IsDBNull(dataRow["HinhAnh"]) ? null : (System.Byte[])dataRow["HinhAnh"];
			entity.DiaChi = Convert.IsDBNull(dataRow["DiaChi"]) ? null : (System.String)dataRow["DiaChi"];
			entity.ThuongTru = Convert.IsDBNull(dataRow["ThuongTru"]) ? null : (System.String)dataRow["ThuongTru"];
			entity.NoiLamViec = Convert.IsDBNull(dataRow["NoiLamViec"]) ? null : (System.String)dataRow["NoiLamViec"];
			entity.Email = Convert.IsDBNull(dataRow["Email"]) ? null : (System.String)dataRow["Email"];
			entity.DienThoai = Convert.IsDBNull(dataRow["DienThoai"]) ? null : (System.String)dataRow["DienThoai"];
			entity.SoDiDong = Convert.IsDBNull(dataRow["SoDiDong"]) ? null : (System.String)dataRow["SoDiDong"];
			entity.SoTaiKhoan = Convert.IsDBNull(dataRow["SoTaiKhoan"]) ? null : (System.String)dataRow["SoTaiKhoan"];
			entity.TenNganHang = Convert.IsDBNull(dataRow["TenNganHang"]) ? null : (System.String)dataRow["TenNganHang"];
			entity.MaSoThue = Convert.IsDBNull(dataRow["MaSoThue"]) ? null : (System.String)dataRow["MaSoThue"];
			entity.ChiNhanh = Convert.IsDBNull(dataRow["ChiNhanh"]) ? null : (System.String)dataRow["ChiNhanh"];
			entity.SoSoBaoHiem = Convert.IsDBNull(dataRow["SoSoBaoHiem"]) ? null : (System.String)dataRow["SoSoBaoHiem"];
			entity.ThoiGianBatDau = Convert.IsDBNull(dataRow["ThoiGianBatDau"]) ? null : (System.String)dataRow["ThoiGianBatDau"];
			entity.BacLuong = Convert.IsDBNull(dataRow["BacLuong"]) ? null : (System.Decimal?)dataRow["BacLuong"];
			entity.NgayHuongLuong = Convert.IsDBNull(dataRow["NgayHuongLuong"]) ? null : (System.String)dataRow["NgayHuongLuong"];
			entity.NamLamViec = Convert.IsDBNull(dataRow["NamLamViec"]) ? null : (System.String)dataRow["NamLamViec"];
			entity.ChuyenNganh = Convert.IsDBNull(dataRow["ChuyenNganh"]) ? null : (System.String)dataRow["ChuyenNganh"];
			entity.MaHeSoThuLao = Convert.IsDBNull(dataRow["MaHeSoThuLao"]) ? null : (System.String)dataRow["MaHeSoThuLao"];
			entity.Ngach = Convert.IsDBNull(dataRow["Ngach"]) ? null : (System.String)dataRow["Ngach"];
			entity.SoHieuCongChuc = Convert.IsDBNull(dataRow["SoHieuCongChuc"]) ? null : (System.String)dataRow["SoHieuCongChuc"];
			entity.Hrmid = Convert.IsDBNull(dataRow["HRMID"]) ? null : (System.Guid?)dataRow["HRMID"];
			entity.NoiCapBang = Convert.IsDBNull(dataRow["NoiCapBang"]) ? null : (System.String)dataRow["NoiCapBang"];
			entity.KhoaTaiKhoan = Convert.IsDBNull(dataRow["KhoaTaiKhoan"]) ? null : (System.Boolean?)dataRow["KhoaTaiKhoan"];
			entity.MaLoaiNhanVien = Convert.IsDBNull(dataRow["MaLoaiNhanVien"]) ? null : (System.Int32?)dataRow["MaLoaiNhanVien"];
			entity.MaNgachCongChuc = Convert.IsDBNull(dataRow["MaNgachCongChuc"]) ? null : (System.Int32?)dataRow["MaNgachCongChuc"];
			entity.MaTrinhDoChinhTri = Convert.IsDBNull(dataRow["MaTrinhDoChinhTri"]) ? null : (System.Int32?)dataRow["MaTrinhDoChinhTri"];
			entity.MaTrinhDoSuPham = Convert.IsDBNull(dataRow["MaTrinhDoSuPham"]) ? null : (System.Int32?)dataRow["MaTrinhDoSuPham"];
			entity.MaTrinhDoNgoaiNgu = Convert.IsDBNull(dataRow["MaTrinhDoNgoaiNgu"]) ? null : (System.Int32?)dataRow["MaTrinhDoNgoaiNgu"];
			entity.MaTrinhDoTinHoc = Convert.IsDBNull(dataRow["MaTrinhDoTinHoc"]) ? null : (System.Int32?)dataRow["MaTrinhDoTinHoc"];
			entity.MaTrinhDoQuanLyNhaNuoc = Convert.IsDBNull(dataRow["MaTrinhDoQuanLyNhaNuoc"]) ? null : (System.Int32?)dataRow["MaTrinhDoQuanLyNhaNuoc"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
			entity.KhoiKienThucGiangDay = Convert.IsDBNull(dataRow["KhoiKienThucGiangDay"]) ? null : (System.String)dataRow["KhoiKienThucGiangDay"];
			entity.NganhDaoTao = Convert.IsDBNull(dataRow["NganhDaoTao"]) ? null : (System.String)dataRow["NganhDaoTao"];
			entity.DonViGiangDay = Convert.IsDBNull(dataRow["DonViGiangDay"]) ? null : (System.String)dataRow["DonViGiangDay"];
			entity.DaDuyet = Convert.IsDBNull(dataRow["DaDuyet"]) ? null : (System.Boolean?)dataRow["DaDuyet"];
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
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienChoDuyetHoSo"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienChoDuyetHoSo Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.GiangVienChoDuyetHoSo entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.GiangVienChoDuyetHoSo object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.GiangVienChoDuyetHoSo instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienChoDuyetHoSo Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.GiangVienChoDuyetHoSo entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region GiangVienChoDuyetHoSoChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.GiangVienChoDuyetHoSo</c>
	///</summary>
	public enum GiangVienChoDuyetHoSoChildEntityTypes
	{
	}
	
	#endregion GiangVienChoDuyetHoSoChildEntityTypes
	
	#region GiangVienChoDuyetHoSoFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GiangVienChoDuyetHoSoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienChoDuyetHoSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienChoDuyetHoSoFilterBuilder : SqlFilterBuilder<GiangVienChoDuyetHoSoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienChoDuyetHoSoFilterBuilder class.
		/// </summary>
		public GiangVienChoDuyetHoSoFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienChoDuyetHoSoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienChoDuyetHoSoFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienChoDuyetHoSoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienChoDuyetHoSoFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienChoDuyetHoSoFilterBuilder
	
	#region GiangVienChoDuyetHoSoParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GiangVienChoDuyetHoSoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienChoDuyetHoSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienChoDuyetHoSoParameterBuilder : ParameterizedSqlFilterBuilder<GiangVienChoDuyetHoSoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienChoDuyetHoSoParameterBuilder class.
		/// </summary>
		public GiangVienChoDuyetHoSoParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienChoDuyetHoSoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienChoDuyetHoSoParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienChoDuyetHoSoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienChoDuyetHoSoParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienChoDuyetHoSoParameterBuilder
	
	#region GiangVienChoDuyetHoSoSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GiangVienChoDuyetHoSoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienChoDuyetHoSo"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GiangVienChoDuyetHoSoSortBuilder : SqlSortBuilder<GiangVienChoDuyetHoSoColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienChoDuyetHoSoSqlSortBuilder class.
		/// </summary>
		public GiangVienChoDuyetHoSoSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GiangVienChoDuyetHoSoSortBuilder
	
} // end namespace
