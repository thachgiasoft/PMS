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
	/// This class is the base class for any <see cref="KhoiLuongQuyDoiCaoDangProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KhoiLuongQuyDoiCaoDangProviderBaseCore : EntityProviderBase<PMS.Entities.KhoiLuongQuyDoiCaoDang, PMS.Entities.KhoiLuongQuyDoiCaoDangKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KhoiLuongQuyDoiCaoDangKey key)
		{
			return Delete(transactionManager, key.MaKhoiLuongQuyDoiCaoDang);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maKhoiLuongQuyDoiCaoDang">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maKhoiLuongQuyDoiCaoDang)
		{
			return Delete(null, _maKhoiLuongQuyDoiCaoDang);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuongQuyDoiCaoDang">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maKhoiLuongQuyDoiCaoDang);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongQuyDoiCaoDang_KhoiLuongGiangDayCaoDang key.
		///		FK_KhoiLuongQuyDoiCaoDang_KhoiLuongGiangDayCaoDang Description: 
		/// </summary>
		/// <param name="_maKhoiLuongCaoDang"></param>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongQuyDoiCaoDang objects.</returns>
		public TList<KhoiLuongQuyDoiCaoDang> GetByMaKhoiLuongCaoDang(System.Int32? _maKhoiLuongCaoDang)
		{
			int count = -1;
			return GetByMaKhoiLuongCaoDang(_maKhoiLuongCaoDang, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongQuyDoiCaoDang_KhoiLuongGiangDayCaoDang key.
		///		FK_KhoiLuongQuyDoiCaoDang_KhoiLuongGiangDayCaoDang Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuongCaoDang"></param>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongQuyDoiCaoDang objects.</returns>
		/// <remarks></remarks>
		public TList<KhoiLuongQuyDoiCaoDang> GetByMaKhoiLuongCaoDang(TransactionManager transactionManager, System.Int32? _maKhoiLuongCaoDang)
		{
			int count = -1;
			return GetByMaKhoiLuongCaoDang(transactionManager, _maKhoiLuongCaoDang, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongQuyDoiCaoDang_KhoiLuongGiangDayCaoDang key.
		///		FK_KhoiLuongQuyDoiCaoDang_KhoiLuongGiangDayCaoDang Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuongCaoDang"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongQuyDoiCaoDang objects.</returns>
		public TList<KhoiLuongQuyDoiCaoDang> GetByMaKhoiLuongCaoDang(TransactionManager transactionManager, System.Int32? _maKhoiLuongCaoDang, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKhoiLuongCaoDang(transactionManager, _maKhoiLuongCaoDang, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongQuyDoiCaoDang_KhoiLuongGiangDayCaoDang key.
		///		fkKhoiLuongQuyDoiCaoDangKhoiLuongGiangDayCaoDang Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maKhoiLuongCaoDang"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongQuyDoiCaoDang objects.</returns>
		public TList<KhoiLuongQuyDoiCaoDang> GetByMaKhoiLuongCaoDang(System.Int32? _maKhoiLuongCaoDang, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaKhoiLuongCaoDang(null, _maKhoiLuongCaoDang, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongQuyDoiCaoDang_KhoiLuongGiangDayCaoDang key.
		///		fkKhoiLuongQuyDoiCaoDangKhoiLuongGiangDayCaoDang Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maKhoiLuongCaoDang"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongQuyDoiCaoDang objects.</returns>
		public TList<KhoiLuongQuyDoiCaoDang> GetByMaKhoiLuongCaoDang(System.Int32? _maKhoiLuongCaoDang, int start, int pageLength,out int count)
		{
			return GetByMaKhoiLuongCaoDang(null, _maKhoiLuongCaoDang, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongQuyDoiCaoDang_KhoiLuongGiangDayCaoDang key.
		///		FK_KhoiLuongQuyDoiCaoDang_KhoiLuongGiangDayCaoDang Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuongCaoDang"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongQuyDoiCaoDang objects.</returns>
		public abstract TList<KhoiLuongQuyDoiCaoDang> GetByMaKhoiLuongCaoDang(TransactionManager transactionManager, System.Int32? _maKhoiLuongCaoDang, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.KhoiLuongQuyDoiCaoDang Get(TransactionManager transactionManager, PMS.Entities.KhoiLuongQuyDoiCaoDangKey key, int start, int pageLength)
		{
			return GetByMaKhoiLuongQuyDoiCaoDang(transactionManager, key.MaKhoiLuongQuyDoiCaoDang, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KhoiLuongQuyDoiCaoDang index.
		/// </summary>
		/// <param name="_maKhoiLuongQuyDoiCaoDang"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongQuyDoiCaoDang"/> class.</returns>
		public PMS.Entities.KhoiLuongQuyDoiCaoDang GetByMaKhoiLuongQuyDoiCaoDang(System.Int32 _maKhoiLuongQuyDoiCaoDang)
		{
			int count = -1;
			return GetByMaKhoiLuongQuyDoiCaoDang(null,_maKhoiLuongQuyDoiCaoDang, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongQuyDoiCaoDang index.
		/// </summary>
		/// <param name="_maKhoiLuongQuyDoiCaoDang"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongQuyDoiCaoDang"/> class.</returns>
		public PMS.Entities.KhoiLuongQuyDoiCaoDang GetByMaKhoiLuongQuyDoiCaoDang(System.Int32 _maKhoiLuongQuyDoiCaoDang, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKhoiLuongQuyDoiCaoDang(null, _maKhoiLuongQuyDoiCaoDang, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongQuyDoiCaoDang index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuongQuyDoiCaoDang"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongQuyDoiCaoDang"/> class.</returns>
		public PMS.Entities.KhoiLuongQuyDoiCaoDang GetByMaKhoiLuongQuyDoiCaoDang(TransactionManager transactionManager, System.Int32 _maKhoiLuongQuyDoiCaoDang)
		{
			int count = -1;
			return GetByMaKhoiLuongQuyDoiCaoDang(transactionManager, _maKhoiLuongQuyDoiCaoDang, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongQuyDoiCaoDang index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuongQuyDoiCaoDang"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongQuyDoiCaoDang"/> class.</returns>
		public PMS.Entities.KhoiLuongQuyDoiCaoDang GetByMaKhoiLuongQuyDoiCaoDang(TransactionManager transactionManager, System.Int32 _maKhoiLuongQuyDoiCaoDang, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKhoiLuongQuyDoiCaoDang(transactionManager, _maKhoiLuongQuyDoiCaoDang, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongQuyDoiCaoDang index.
		/// </summary>
		/// <param name="_maKhoiLuongQuyDoiCaoDang"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongQuyDoiCaoDang"/> class.</returns>
		public PMS.Entities.KhoiLuongQuyDoiCaoDang GetByMaKhoiLuongQuyDoiCaoDang(System.Int32 _maKhoiLuongQuyDoiCaoDang, int start, int pageLength, out int count)
		{
			return GetByMaKhoiLuongQuyDoiCaoDang(null, _maKhoiLuongQuyDoiCaoDang, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongQuyDoiCaoDang index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuongQuyDoiCaoDang"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongQuyDoiCaoDang"/> class.</returns>
		public abstract PMS.Entities.KhoiLuongQuyDoiCaoDang GetByMaKhoiLuongQuyDoiCaoDang(TransactionManager transactionManager, System.Int32 _maKhoiLuongQuyDoiCaoDang, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_KhoiLuongQuyDoiCaoDang_DeleteByMaKhoiLuongCaoDang 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoiCaoDang_DeleteByMaKhoiLuongCaoDang' stored procedure. 
		/// </summary>
		/// <param name="maKhoiLuongCaoDang"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteByMaKhoiLuongCaoDang(System.Int32 maKhoiLuongCaoDang)
		{
			 DeleteByMaKhoiLuongCaoDang(null, 0, int.MaxValue , maKhoiLuongCaoDang);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoiCaoDang_DeleteByMaKhoiLuongCaoDang' stored procedure. 
		/// </summary>
		/// <param name="maKhoiLuongCaoDang"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteByMaKhoiLuongCaoDang(int start, int pageLength, System.Int32 maKhoiLuongCaoDang)
		{
			 DeleteByMaKhoiLuongCaoDang(null, start, pageLength , maKhoiLuongCaoDang);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoiCaoDang_DeleteByMaKhoiLuongCaoDang' stored procedure. 
		/// </summary>
		/// <param name="maKhoiLuongCaoDang"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteByMaKhoiLuongCaoDang(TransactionManager transactionManager, System.Int32 maKhoiLuongCaoDang)
		{
			 DeleteByMaKhoiLuongCaoDang(transactionManager, 0, int.MaxValue , maKhoiLuongCaoDang);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoiCaoDang_DeleteByMaKhoiLuongCaoDang' stored procedure. 
		/// </summary>
		/// <param name="maKhoiLuongCaoDang"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DeleteByMaKhoiLuongCaoDang(TransactionManager transactionManager, int start, int pageLength , System.Int32 maKhoiLuongCaoDang);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KhoiLuongQuyDoiCaoDang&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KhoiLuongQuyDoiCaoDang&gt;"/></returns>
		public static TList<KhoiLuongQuyDoiCaoDang> Fill(IDataReader reader, TList<KhoiLuongQuyDoiCaoDang> rows, int start, int pageLength)
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
				
				PMS.Entities.KhoiLuongQuyDoiCaoDang c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KhoiLuongQuyDoiCaoDang")
					.Append("|").Append((System.Int32)reader[((int)KhoiLuongQuyDoiCaoDangColumn.MaKhoiLuongQuyDoiCaoDang - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KhoiLuongQuyDoiCaoDang>(
					key.ToString(), // EntityTrackingKey
					"KhoiLuongQuyDoiCaoDang",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KhoiLuongQuyDoiCaoDang();
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
					c.MaKhoiLuongQuyDoiCaoDang = (System.Int32)reader[(KhoiLuongQuyDoiCaoDangColumn.MaKhoiLuongQuyDoiCaoDang.ToString())];
					c.TietQuyDoiLt = (reader[KhoiLuongQuyDoiCaoDangColumn.TietQuyDoiLt.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiCaoDangColumn.TietQuyDoiLt.ToString())];
					c.TietQuyDoiTh = (reader[KhoiLuongQuyDoiCaoDangColumn.TietQuyDoiTh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiCaoDangColumn.TietQuyDoiTh.ToString())];
					c.TongTietQuyDoi = (reader[KhoiLuongQuyDoiCaoDangColumn.TongTietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiCaoDangColumn.TongTietQuyDoi.ToString())];
					c.MaKhoiLuongCaoDang = (reader[KhoiLuongQuyDoiCaoDangColumn.MaKhoiLuongCaoDang.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongQuyDoiCaoDangColumn.MaKhoiLuongCaoDang.ToString())];
					c.MaLoaiGiangVien = (reader[KhoiLuongQuyDoiCaoDangColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongQuyDoiCaoDangColumn.MaLoaiGiangVien.ToString())];
					c.MaHocHam = (reader[KhoiLuongQuyDoiCaoDangColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongQuyDoiCaoDangColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[KhoiLuongQuyDoiCaoDangColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongQuyDoiCaoDangColumn.MaHocVi.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KhoiLuongQuyDoiCaoDang"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongQuyDoiCaoDang"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KhoiLuongQuyDoiCaoDang entity)
		{
			if (!reader.Read()) return;
			
			entity.MaKhoiLuongQuyDoiCaoDang = (System.Int32)reader[(KhoiLuongQuyDoiCaoDangColumn.MaKhoiLuongQuyDoiCaoDang.ToString())];
			entity.TietQuyDoiLt = (reader[KhoiLuongQuyDoiCaoDangColumn.TietQuyDoiLt.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiCaoDangColumn.TietQuyDoiLt.ToString())];
			entity.TietQuyDoiTh = (reader[KhoiLuongQuyDoiCaoDangColumn.TietQuyDoiTh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiCaoDangColumn.TietQuyDoiTh.ToString())];
			entity.TongTietQuyDoi = (reader[KhoiLuongQuyDoiCaoDangColumn.TongTietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiCaoDangColumn.TongTietQuyDoi.ToString())];
			entity.MaKhoiLuongCaoDang = (reader[KhoiLuongQuyDoiCaoDangColumn.MaKhoiLuongCaoDang.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongQuyDoiCaoDangColumn.MaKhoiLuongCaoDang.ToString())];
			entity.MaLoaiGiangVien = (reader[KhoiLuongQuyDoiCaoDangColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongQuyDoiCaoDangColumn.MaLoaiGiangVien.ToString())];
			entity.MaHocHam = (reader[KhoiLuongQuyDoiCaoDangColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongQuyDoiCaoDangColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[KhoiLuongQuyDoiCaoDangColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongQuyDoiCaoDangColumn.MaHocVi.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KhoiLuongQuyDoiCaoDang"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongQuyDoiCaoDang"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KhoiLuongQuyDoiCaoDang entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaKhoiLuongQuyDoiCaoDang = (System.Int32)dataRow["MaKhoiLuongQuyDoiCaoDang"];
			entity.TietQuyDoiLt = Convert.IsDBNull(dataRow["TietQuyDoiLT"]) ? null : (System.Decimal?)dataRow["TietQuyDoiLT"];
			entity.TietQuyDoiTh = Convert.IsDBNull(dataRow["TietQuyDoiTH"]) ? null : (System.Decimal?)dataRow["TietQuyDoiTH"];
			entity.TongTietQuyDoi = Convert.IsDBNull(dataRow["TongTietQuyDoi"]) ? null : (System.Decimal?)dataRow["TongTietQuyDoi"];
			entity.MaKhoiLuongCaoDang = Convert.IsDBNull(dataRow["MaKhoiLuongCaoDang"]) ? null : (System.Int32?)dataRow["MaKhoiLuongCaoDang"];
			entity.MaLoaiGiangVien = Convert.IsDBNull(dataRow["MaLoaiGiangVien"]) ? null : (System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
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
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongQuyDoiCaoDang"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KhoiLuongQuyDoiCaoDang Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KhoiLuongQuyDoiCaoDang entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaKhoiLuongCaoDangSource	
			if (CanDeepLoad(entity, "KhoiLuongGiangDayCaoDang|MaKhoiLuongCaoDangSource", deepLoadType, innerList) 
				&& entity.MaKhoiLuongCaoDangSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaKhoiLuongCaoDang ?? (int)0);
				KhoiLuongGiangDayCaoDang tmpEntity = EntityManager.LocateEntity<KhoiLuongGiangDayCaoDang>(EntityLocator.ConstructKeyFromPkItems(typeof(KhoiLuongGiangDayCaoDang), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaKhoiLuongCaoDangSource = tmpEntity;
				else
					entity.MaKhoiLuongCaoDangSource = DataRepository.KhoiLuongGiangDayCaoDangProvider.GetByMaKhoiLuongCaoDang(transactionManager, (entity.MaKhoiLuongCaoDang ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaKhoiLuongCaoDangSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaKhoiLuongCaoDangSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.KhoiLuongGiangDayCaoDangProvider.DeepLoad(transactionManager, entity.MaKhoiLuongCaoDangSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaKhoiLuongCaoDangSource
			
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
		/// Deep Save the entire object graph of the PMS.Entities.KhoiLuongQuyDoiCaoDang object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KhoiLuongQuyDoiCaoDang instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KhoiLuongQuyDoiCaoDang Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KhoiLuongQuyDoiCaoDang entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaKhoiLuongCaoDangSource
			if (CanDeepSave(entity, "KhoiLuongGiangDayCaoDang|MaKhoiLuongCaoDangSource", deepSaveType, innerList) 
				&& entity.MaKhoiLuongCaoDangSource != null)
			{
				DataRepository.KhoiLuongGiangDayCaoDangProvider.Save(transactionManager, entity.MaKhoiLuongCaoDangSource);
				entity.MaKhoiLuongCaoDang = entity.MaKhoiLuongCaoDangSource.MaKhoiLuongCaoDang;
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
	
	#region KhoiLuongQuyDoiCaoDangChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KhoiLuongQuyDoiCaoDang</c>
	///</summary>
	public enum KhoiLuongQuyDoiCaoDangChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>KhoiLuongGiangDayCaoDang</c> at MaKhoiLuongCaoDangSource
		///</summary>
		[ChildEntityType(typeof(KhoiLuongGiangDayCaoDang))]
		KhoiLuongGiangDayCaoDang,
	}
	
	#endregion KhoiLuongQuyDoiCaoDangChildEntityTypes
	
	#region KhoiLuongQuyDoiCaoDangFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KhoiLuongQuyDoiCaoDangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongQuyDoiCaoDang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongQuyDoiCaoDangFilterBuilder : SqlFilterBuilder<KhoiLuongQuyDoiCaoDangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongQuyDoiCaoDangFilterBuilder class.
		/// </summary>
		public KhoiLuongQuyDoiCaoDangFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongQuyDoiCaoDangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KhoiLuongQuyDoiCaoDangFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongQuyDoiCaoDangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KhoiLuongQuyDoiCaoDangFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KhoiLuongQuyDoiCaoDangFilterBuilder
	
	#region KhoiLuongQuyDoiCaoDangParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KhoiLuongQuyDoiCaoDangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongQuyDoiCaoDang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongQuyDoiCaoDangParameterBuilder : ParameterizedSqlFilterBuilder<KhoiLuongQuyDoiCaoDangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongQuyDoiCaoDangParameterBuilder class.
		/// </summary>
		public KhoiLuongQuyDoiCaoDangParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongQuyDoiCaoDangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KhoiLuongQuyDoiCaoDangParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongQuyDoiCaoDangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KhoiLuongQuyDoiCaoDangParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KhoiLuongQuyDoiCaoDangParameterBuilder
	
	#region KhoiLuongQuyDoiCaoDangSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KhoiLuongQuyDoiCaoDangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongQuyDoiCaoDang"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KhoiLuongQuyDoiCaoDangSortBuilder : SqlSortBuilder<KhoiLuongQuyDoiCaoDangColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongQuyDoiCaoDangSqlSortBuilder class.
		/// </summary>
		public KhoiLuongQuyDoiCaoDangSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KhoiLuongQuyDoiCaoDangSortBuilder
	
} // end namespace
