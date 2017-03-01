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
	/// This class is the base class for any <see cref="NghienCuuKhoaHocProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class NghienCuuKhoaHocProviderBaseCore : EntityProviderBase<PMS.Entities.NghienCuuKhoaHoc, PMS.Entities.NghienCuuKhoaHocKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.NghienCuuKhoaHocKey key)
		{
			return Delete(transactionManager, key.MaNghienCuuKhoaHoc);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maNghienCuuKhoaHoc">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maNghienCuuKhoaHoc)
		{
			return Delete(null, _maNghienCuuKhoaHoc);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNghienCuuKhoaHoc">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maNghienCuuKhoaHoc);		
		
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
		public override PMS.Entities.NghienCuuKhoaHoc Get(TransactionManager transactionManager, PMS.Entities.NghienCuuKhoaHocKey key, int start, int pageLength)
		{
			return GetByMaNghienCuuKhoaHoc(transactionManager, key.MaNghienCuuKhoaHoc, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_NghienCuuKhoaHoc index.
		/// </summary>
		/// <param name="_maNghienCuuKhoaHoc"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NghienCuuKhoaHoc"/> class.</returns>
		public PMS.Entities.NghienCuuKhoaHoc GetByMaNghienCuuKhoaHoc(System.Int32 _maNghienCuuKhoaHoc)
		{
			int count = -1;
			return GetByMaNghienCuuKhoaHoc(null,_maNghienCuuKhoaHoc, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NghienCuuKhoaHoc index.
		/// </summary>
		/// <param name="_maNghienCuuKhoaHoc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NghienCuuKhoaHoc"/> class.</returns>
		public PMS.Entities.NghienCuuKhoaHoc GetByMaNghienCuuKhoaHoc(System.Int32 _maNghienCuuKhoaHoc, int start, int pageLength)
		{
			int count = -1;
			return GetByMaNghienCuuKhoaHoc(null, _maNghienCuuKhoaHoc, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NghienCuuKhoaHoc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNghienCuuKhoaHoc"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NghienCuuKhoaHoc"/> class.</returns>
		public PMS.Entities.NghienCuuKhoaHoc GetByMaNghienCuuKhoaHoc(TransactionManager transactionManager, System.Int32 _maNghienCuuKhoaHoc)
		{
			int count = -1;
			return GetByMaNghienCuuKhoaHoc(transactionManager, _maNghienCuuKhoaHoc, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NghienCuuKhoaHoc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNghienCuuKhoaHoc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NghienCuuKhoaHoc"/> class.</returns>
		public PMS.Entities.NghienCuuKhoaHoc GetByMaNghienCuuKhoaHoc(TransactionManager transactionManager, System.Int32 _maNghienCuuKhoaHoc, int start, int pageLength)
		{
			int count = -1;
			return GetByMaNghienCuuKhoaHoc(transactionManager, _maNghienCuuKhoaHoc, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NghienCuuKhoaHoc index.
		/// </summary>
		/// <param name="_maNghienCuuKhoaHoc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NghienCuuKhoaHoc"/> class.</returns>
		public PMS.Entities.NghienCuuKhoaHoc GetByMaNghienCuuKhoaHoc(System.Int32 _maNghienCuuKhoaHoc, int start, int pageLength, out int count)
		{
			return GetByMaNghienCuuKhoaHoc(null, _maNghienCuuKhoaHoc, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NghienCuuKhoaHoc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNghienCuuKhoaHoc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NghienCuuKhoaHoc"/> class.</returns>
		public abstract PMS.Entities.NghienCuuKhoaHoc GetByMaNghienCuuKhoaHoc(TransactionManager transactionManager, System.Int32 _maNghienCuuKhoaHoc, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_NghienCuuKhoaHoc_Import 
		
		/// <summary>
		///	This method wrap the 'cust_NghienCuuKhoaHoc_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reval"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Import(System.String xmlData, ref System.Int32 reval)
		{
			 Import(null, 0, int.MaxValue , xmlData, ref reval);
		}
		
		/// <summary>
		///	This method wrap the 'cust_NghienCuuKhoaHoc_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reval"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Import(int start, int pageLength, System.String xmlData, ref System.Int32 reval)
		{
			 Import(null, start, pageLength , xmlData, ref reval);
		}
				
		/// <summary>
		///	This method wrap the 'cust_NghienCuuKhoaHoc_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reval"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Import(TransactionManager transactionManager, System.String xmlData, ref System.Int32 reval)
		{
			 Import(transactionManager, 0, int.MaxValue , xmlData, ref reval);
		}
		
		/// <summary>
		///	This method wrap the 'cust_NghienCuuKhoaHoc_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reval"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Import(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, ref System.Int32 reval);
		
		#endregion
		
		#region cust_NghienCuuKhoaHoc_GetByMaQuanLyNamHoc 
		
		/// <summary>
		///	This method wrap the 'cust_NghienCuuKhoaHoc_GetByMaQuanLyNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;NghienCuuKhoaHoc&gt;"/> instance.</returns>
		public TList<NghienCuuKhoaHoc> GetByMaQuanLyNamHoc(System.String maQuanLy, System.String namHoc)
		{
			return GetByMaQuanLyNamHoc(null, 0, int.MaxValue , maQuanLy, namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_NghienCuuKhoaHoc_GetByMaQuanLyNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;NghienCuuKhoaHoc&gt;"/> instance.</returns>
		public TList<NghienCuuKhoaHoc> GetByMaQuanLyNamHoc(int start, int pageLength, System.String maQuanLy, System.String namHoc)
		{
			return GetByMaQuanLyNamHoc(null, start, pageLength , maQuanLy, namHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_NghienCuuKhoaHoc_GetByMaQuanLyNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;NghienCuuKhoaHoc&gt;"/> instance.</returns>
		public TList<NghienCuuKhoaHoc> GetByMaQuanLyNamHoc(TransactionManager transactionManager, System.String maQuanLy, System.String namHoc)
		{
			return GetByMaQuanLyNamHoc(transactionManager, 0, int.MaxValue , maQuanLy, namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_NghienCuuKhoaHoc_GetByMaQuanLyNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;NghienCuuKhoaHoc&gt;"/> instance.</returns>
		public abstract TList<NghienCuuKhoaHoc> GetByMaQuanLyNamHoc(TransactionManager transactionManager, int start, int pageLength , System.String maQuanLy, System.String namHoc);
		
		#endregion
		
		#region cust_NghienCuuKhoaHoc_GetByMaGiangVienNamHoc 
		
		/// <summary>
		///	This method wrap the 'cust_NghienCuuKhoaHoc_GetByMaGiangVienNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;NghienCuuKhoaHoc&gt;"/> instance.</returns>
		public TList<NghienCuuKhoaHoc> GetByMaGiangVienNamHoc(System.Int32 maGiangVien, System.String namHoc)
		{
			return GetByMaGiangVienNamHoc(null, 0, int.MaxValue , maGiangVien, namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_NghienCuuKhoaHoc_GetByMaGiangVienNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;NghienCuuKhoaHoc&gt;"/> instance.</returns>
		public TList<NghienCuuKhoaHoc> GetByMaGiangVienNamHoc(int start, int pageLength, System.Int32 maGiangVien, System.String namHoc)
		{
			return GetByMaGiangVienNamHoc(null, start, pageLength , maGiangVien, namHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_NghienCuuKhoaHoc_GetByMaGiangVienNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;NghienCuuKhoaHoc&gt;"/> instance.</returns>
		public TList<NghienCuuKhoaHoc> GetByMaGiangVienNamHoc(TransactionManager transactionManager, System.Int32 maGiangVien, System.String namHoc)
		{
			return GetByMaGiangVienNamHoc(transactionManager, 0, int.MaxValue , maGiangVien, namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_NghienCuuKhoaHoc_GetByMaGiangVienNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;NghienCuuKhoaHoc&gt;"/> instance.</returns>
		public abstract TList<NghienCuuKhoaHoc> GetByMaGiangVienNamHoc(TransactionManager transactionManager, int start, int pageLength , System.Int32 maGiangVien, System.String namHoc);
		
		#endregion
		
		#region cust_NghienCuuKhoaHoc_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_NghienCuuKhoaHoc_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reval"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, System.String maDonVi, System.String namHoc, System.String hocKy, ref System.Int32 reval)
		{
			 Luu(null, 0, int.MaxValue , xmlData, maDonVi, namHoc, hocKy, ref reval);
		}
		
		/// <summary>
		///	This method wrap the 'cust_NghienCuuKhoaHoc_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reval"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, System.String maDonVi, System.String namHoc, System.String hocKy, ref System.Int32 reval)
		{
			 Luu(null, start, pageLength , xmlData, maDonVi, namHoc, hocKy, ref reval);
		}
				
		/// <summary>
		///	This method wrap the 'cust_NghienCuuKhoaHoc_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reval"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, System.String maDonVi, System.String namHoc, System.String hocKy, ref System.Int32 reval)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, maDonVi, namHoc, hocKy, ref reval);
		}
		
		/// <summary>
		///	This method wrap the 'cust_NghienCuuKhoaHoc_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reval"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String maDonVi, System.String namHoc, System.String hocKy, ref System.Int32 reval);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;NghienCuuKhoaHoc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;NghienCuuKhoaHoc&gt;"/></returns>
		public static TList<NghienCuuKhoaHoc> Fill(IDataReader reader, TList<NghienCuuKhoaHoc> rows, int start, int pageLength)
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
				
				PMS.Entities.NghienCuuKhoaHoc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("NghienCuuKhoaHoc")
					.Append("|").Append((System.Int32)reader[((int)NghienCuuKhoaHocColumn.MaNghienCuuKhoaHoc - 1)]).ToString();
					c = EntityManager.LocateOrCreate<NghienCuuKhoaHoc>(
					key.ToString(), // EntityTrackingKey
					"NghienCuuKhoaHoc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.NghienCuuKhoaHoc();
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
					c.MaNghienCuuKhoaHoc = (System.Int32)reader[(NghienCuuKhoaHocColumn.MaNghienCuuKhoaHoc.ToString())];
					c.MaGiangVien = (reader[NghienCuuKhoaHocColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(NghienCuuKhoaHocColumn.MaGiangVien.ToString())];
					c.NamHoc = (reader[NghienCuuKhoaHocColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(NghienCuuKhoaHocColumn.NamHoc.ToString())];
					c.SoTietDinhMuc = (reader[NghienCuuKhoaHocColumn.SoTietDinhMuc.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(NghienCuuKhoaHocColumn.SoTietDinhMuc.ToString())];
					c.SoTietThucHien = (reader[NghienCuuKhoaHocColumn.SoTietThucHien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(NghienCuuKhoaHocColumn.SoTietThucHien.ToString())];
					c.HocKy = (reader[NghienCuuKhoaHocColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(NghienCuuKhoaHocColumn.HocKy.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.NghienCuuKhoaHoc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.NghienCuuKhoaHoc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.NghienCuuKhoaHoc entity)
		{
			if (!reader.Read()) return;
			
			entity.MaNghienCuuKhoaHoc = (System.Int32)reader[(NghienCuuKhoaHocColumn.MaNghienCuuKhoaHoc.ToString())];
			entity.MaGiangVien = (reader[NghienCuuKhoaHocColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(NghienCuuKhoaHocColumn.MaGiangVien.ToString())];
			entity.NamHoc = (reader[NghienCuuKhoaHocColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(NghienCuuKhoaHocColumn.NamHoc.ToString())];
			entity.SoTietDinhMuc = (reader[NghienCuuKhoaHocColumn.SoTietDinhMuc.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(NghienCuuKhoaHocColumn.SoTietDinhMuc.ToString())];
			entity.SoTietThucHien = (reader[NghienCuuKhoaHocColumn.SoTietThucHien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(NghienCuuKhoaHocColumn.SoTietThucHien.ToString())];
			entity.HocKy = (reader[NghienCuuKhoaHocColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(NghienCuuKhoaHocColumn.HocKy.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.NghienCuuKhoaHoc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.NghienCuuKhoaHoc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.NghienCuuKhoaHoc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaNghienCuuKhoaHoc = (System.Int32)dataRow["MaNghienCuuKhoaHoc"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.Int32?)dataRow["MaGiangVien"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.SoTietDinhMuc = Convert.IsDBNull(dataRow["SoTietDinhMuc"]) ? null : (System.Decimal?)dataRow["SoTietDinhMuc"];
			entity.SoTietThucHien = Convert.IsDBNull(dataRow["SoTietThucHien"]) ? null : (System.Decimal?)dataRow["SoTietThucHien"];
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
		/// <param name="entity">The <see cref="PMS.Entities.NghienCuuKhoaHoc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.NghienCuuKhoaHoc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.NghienCuuKhoaHoc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.NghienCuuKhoaHoc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.NghienCuuKhoaHoc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.NghienCuuKhoaHoc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.NghienCuuKhoaHoc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region NghienCuuKhoaHocChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.NghienCuuKhoaHoc</c>
	///</summary>
	public enum NghienCuuKhoaHocChildEntityTypes
	{
	}
	
	#endregion NghienCuuKhoaHocChildEntityTypes
	
	#region NghienCuuKhoaHocFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;NghienCuuKhoaHocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NghienCuuKhoaHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NghienCuuKhoaHocFilterBuilder : SqlFilterBuilder<NghienCuuKhoaHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NghienCuuKhoaHocFilterBuilder class.
		/// </summary>
		public NghienCuuKhoaHocFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the NghienCuuKhoaHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public NghienCuuKhoaHocFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the NghienCuuKhoaHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public NghienCuuKhoaHocFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion NghienCuuKhoaHocFilterBuilder
	
	#region NghienCuuKhoaHocParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;NghienCuuKhoaHocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NghienCuuKhoaHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NghienCuuKhoaHocParameterBuilder : ParameterizedSqlFilterBuilder<NghienCuuKhoaHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NghienCuuKhoaHocParameterBuilder class.
		/// </summary>
		public NghienCuuKhoaHocParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the NghienCuuKhoaHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public NghienCuuKhoaHocParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the NghienCuuKhoaHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public NghienCuuKhoaHocParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion NghienCuuKhoaHocParameterBuilder
	
	#region NghienCuuKhoaHocSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;NghienCuuKhoaHocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NghienCuuKhoaHoc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class NghienCuuKhoaHocSortBuilder : SqlSortBuilder<NghienCuuKhoaHocColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NghienCuuKhoaHocSqlSortBuilder class.
		/// </summary>
		public NghienCuuKhoaHocSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion NghienCuuKhoaHocSortBuilder
	
} // end namespace
