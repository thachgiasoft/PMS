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
	/// This class is the base class for any <see cref="GiangVienChucVuProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GiangVienChucVuProviderBaseCore : EntityProviderBase<PMS.Entities.GiangVienChucVu, PMS.Entities.GiangVienChucVuKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.GiangVienChucVuKey key)
		{
			return Delete(transactionManager, key.MaQuanLy, key.MaGiangVien, key.MaChucVu);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maQuanLy">. Primary Key.</param>
		/// <param name="_maGiangVien">. Primary Key.</param>
		/// <param name="_maChucVu">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maQuanLy, System.Int32 _maGiangVien, System.Int32 _maChucVu)
		{
			return Delete(null, _maQuanLy, _maGiangVien, _maChucVu);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy">. Primary Key.</param>
		/// <param name="_maGiangVien">. Primary Key.</param>
		/// <param name="_maChucVu">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maQuanLy, System.Int32 _maGiangVien, System.Int32 _maChucVu);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_ChucVu_ChucVu key.
		///		FK_GiangVien_ChucVu_ChucVu Description: 
		/// </summary>
		/// <param name="_maChucVu"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienChucVu objects.</returns>
		public TList<GiangVienChucVu> GetByMaChucVu(System.Int32 _maChucVu)
		{
			int count = -1;
			return GetByMaChucVu(_maChucVu, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_ChucVu_ChucVu key.
		///		FK_GiangVien_ChucVu_ChucVu Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maChucVu"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienChucVu objects.</returns>
		/// <remarks></remarks>
		public TList<GiangVienChucVu> GetByMaChucVu(TransactionManager transactionManager, System.Int32 _maChucVu)
		{
			int count = -1;
			return GetByMaChucVu(transactionManager, _maChucVu, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_ChucVu_ChucVu key.
		///		FK_GiangVien_ChucVu_ChucVu Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maChucVu"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienChucVu objects.</returns>
		public TList<GiangVienChucVu> GetByMaChucVu(TransactionManager transactionManager, System.Int32 _maChucVu, int start, int pageLength)
		{
			int count = -1;
			return GetByMaChucVu(transactionManager, _maChucVu, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_ChucVu_ChucVu key.
		///		fkGiangVienChucVuChucVu Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maChucVu"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienChucVu objects.</returns>
		public TList<GiangVienChucVu> GetByMaChucVu(System.Int32 _maChucVu, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaChucVu(null, _maChucVu, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_ChucVu_ChucVu key.
		///		fkGiangVienChucVuChucVu Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maChucVu"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienChucVu objects.</returns>
		public TList<GiangVienChucVu> GetByMaChucVu(System.Int32 _maChucVu, int start, int pageLength,out int count)
		{
			return GetByMaChucVu(null, _maChucVu, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_ChucVu_ChucVu key.
		///		FK_GiangVien_ChucVu_ChucVu Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maChucVu"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienChucVu objects.</returns>
		public abstract TList<GiangVienChucVu> GetByMaChucVu(TransactionManager transactionManager, System.Int32 _maChucVu, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_ChucVu_GiangVien key.
		///		FK_GiangVien_ChucVu_GiangVien Description: 
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienChucVu objects.</returns>
		public TList<GiangVienChucVu> GetByMaGiangVien(System.Int32 _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(_maGiangVien, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_ChucVu_GiangVien key.
		///		FK_GiangVien_ChucVu_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienChucVu objects.</returns>
		/// <remarks></remarks>
		public TList<GiangVienChucVu> GetByMaGiangVien(TransactionManager transactionManager, System.Int32 _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_ChucVu_GiangVien key.
		///		FK_GiangVien_ChucVu_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienChucVu objects.</returns>
		public TList<GiangVienChucVu> GetByMaGiangVien(TransactionManager transactionManager, System.Int32 _maGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_ChucVu_GiangVien key.
		///		fkGiangVienChucVuGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienChucVu objects.</returns>
		public TList<GiangVienChucVu> GetByMaGiangVien(System.Int32 _maGiangVien, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_ChucVu_GiangVien key.
		///		fkGiangVienChucVuGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienChucVu objects.</returns>
		public TList<GiangVienChucVu> GetByMaGiangVien(System.Int32 _maGiangVien, int start, int pageLength,out int count)
		{
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_ChucVu_GiangVien key.
		///		FK_GiangVien_ChucVu_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienChucVu objects.</returns>
		public abstract TList<GiangVienChucVu> GetByMaGiangVien(TransactionManager transactionManager, System.Int32 _maGiangVien, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.GiangVienChucVu Get(TransactionManager transactionManager, PMS.Entities.GiangVienChucVuKey key, int start, int pageLength)
		{
			return GetByMaQuanLyMaGiangVienMaChucVu(transactionManager, key.MaQuanLy, key.MaGiangVien, key.MaChucVu, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GiangVien_ChucVu index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maChucVu"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienChucVu"/> class.</returns>
		public PMS.Entities.GiangVienChucVu GetByMaQuanLyMaGiangVienMaChucVu(System.Int32 _maQuanLy, System.Int32 _maGiangVien, System.Int32 _maChucVu)
		{
			int count = -1;
			return GetByMaQuanLyMaGiangVienMaChucVu(null,_maQuanLy, _maGiangVien, _maChucVu, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien_ChucVu index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maChucVu"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienChucVu"/> class.</returns>
		public PMS.Entities.GiangVienChucVu GetByMaQuanLyMaGiangVienMaChucVu(System.Int32 _maQuanLy, System.Int32 _maGiangVien, System.Int32 _maChucVu, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLyMaGiangVienMaChucVu(null, _maQuanLy, _maGiangVien, _maChucVu, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien_ChucVu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maChucVu"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienChucVu"/> class.</returns>
		public PMS.Entities.GiangVienChucVu GetByMaQuanLyMaGiangVienMaChucVu(TransactionManager transactionManager, System.Int32 _maQuanLy, System.Int32 _maGiangVien, System.Int32 _maChucVu)
		{
			int count = -1;
			return GetByMaQuanLyMaGiangVienMaChucVu(transactionManager, _maQuanLy, _maGiangVien, _maChucVu, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien_ChucVu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maChucVu"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienChucVu"/> class.</returns>
		public PMS.Entities.GiangVienChucVu GetByMaQuanLyMaGiangVienMaChucVu(TransactionManager transactionManager, System.Int32 _maQuanLy, System.Int32 _maGiangVien, System.Int32 _maChucVu, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLyMaGiangVienMaChucVu(transactionManager, _maQuanLy, _maGiangVien, _maChucVu, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien_ChucVu index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maChucVu"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienChucVu"/> class.</returns>
		public PMS.Entities.GiangVienChucVu GetByMaQuanLyMaGiangVienMaChucVu(System.Int32 _maQuanLy, System.Int32 _maGiangVien, System.Int32 _maChucVu, int start, int pageLength, out int count)
		{
			return GetByMaQuanLyMaGiangVienMaChucVu(null, _maQuanLy, _maGiangVien, _maChucVu, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien_ChucVu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maChucVu"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienChucVu"/> class.</returns>
		public abstract PMS.Entities.GiangVienChucVu GetByMaQuanLyMaGiangVienMaChucVu(TransactionManager transactionManager, System.Int32 _maQuanLy, System.Int32 _maGiangVien, System.Int32 _maChucVu, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_GiangVien_ChucVu_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ChucVu_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, System.Int32 maGiangVien, ref System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , xmlData, maGiangVien, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ChucVu_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, System.Int32 maGiangVien, ref System.Int32 reVal)
		{
			 Luu(null, start, pageLength , xmlData, maGiangVien, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ChucVu_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, System.Int32 maGiangVien, ref System.Int32 reVal)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, maGiangVien, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ChucVu_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.Int32 maGiangVien, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GiangVienChucVu&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GiangVienChucVu&gt;"/></returns>
		public static TList<GiangVienChucVu> Fill(IDataReader reader, TList<GiangVienChucVu> rows, int start, int pageLength)
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
				
				PMS.Entities.GiangVienChucVu c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GiangVienChucVu")
					.Append("|").Append((System.Int32)reader[((int)GiangVienChucVuColumn.MaQuanLy - 1)])
					.Append("|").Append((System.Int32)reader[((int)GiangVienChucVuColumn.MaGiangVien - 1)])
					.Append("|").Append((System.Int32)reader[((int)GiangVienChucVuColumn.MaChucVu - 1)]).ToString();
					c = EntityManager.LocateOrCreate<GiangVienChucVu>(
					key.ToString(), // EntityTrackingKey
					"GiangVienChucVu",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.GiangVienChucVu();
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
					c.MaQuanLy = (System.Int32)reader[(GiangVienChucVuColumn.MaQuanLy.ToString())];
					c.MaGiangVien = (System.Int32)reader[(GiangVienChucVuColumn.MaGiangVien.ToString())];
					c.OriginalMaGiangVien = c.MaGiangVien;
					c.MaChucVu = (System.Int32)reader[(GiangVienChucVuColumn.MaChucVu.ToString())];
					c.OriginalMaChucVu = c.MaChucVu;
					c.NgayHieuLuc = (reader[GiangVienChucVuColumn.NgayHieuLuc.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienChucVuColumn.NgayHieuLuc.ToString())];
					c.NgayHetHieuLuc = (reader[GiangVienChucVuColumn.NgayHetHieuLuc.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienChucVuColumn.NgayHetHieuLuc.ToString())];
					c.NgayCapNhat = (reader[GiangVienChucVuColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienChucVuColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[GiangVienChucVuColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChucVuColumn.NguoiCapNhat.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienChucVu"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienChucVu"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.GiangVienChucVu entity)
		{
			if (!reader.Read()) return;
			
			entity.MaQuanLy = (System.Int32)reader[(GiangVienChucVuColumn.MaQuanLy.ToString())];
			entity.MaGiangVien = (System.Int32)reader[(GiangVienChucVuColumn.MaGiangVien.ToString())];
			entity.OriginalMaGiangVien = (System.Int32)reader["MaGiangVien"];
			entity.MaChucVu = (System.Int32)reader[(GiangVienChucVuColumn.MaChucVu.ToString())];
			entity.OriginalMaChucVu = (System.Int32)reader["MaChucVu"];
			entity.NgayHieuLuc = (reader[GiangVienChucVuColumn.NgayHieuLuc.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienChucVuColumn.NgayHieuLuc.ToString())];
			entity.NgayHetHieuLuc = (reader[GiangVienChucVuColumn.NgayHetHieuLuc.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienChucVuColumn.NgayHetHieuLuc.ToString())];
			entity.NgayCapNhat = (reader[GiangVienChucVuColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienChucVuColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[GiangVienChucVuColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChucVuColumn.NguoiCapNhat.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienChucVu"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienChucVu"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.GiangVienChucVu entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaQuanLy = (System.Int32)dataRow["MaQuanLy"];
			entity.MaGiangVien = (System.Int32)dataRow["MaGiangVien"];
			entity.OriginalMaGiangVien = (System.Int32)dataRow["MaGiangVien"];
			entity.MaChucVu = (System.Int32)dataRow["MaChucVu"];
			entity.OriginalMaChucVu = (System.Int32)dataRow["MaChucVu"];
			entity.NgayHieuLuc = Convert.IsDBNull(dataRow["NgayHieuLuc"]) ? null : (System.DateTime?)dataRow["NgayHieuLuc"];
			entity.NgayHetHieuLuc = Convert.IsDBNull(dataRow["NgayHetHieuLuc"]) ? null : (System.DateTime?)dataRow["NgayHetHieuLuc"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
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
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienChucVu"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienChucVu Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.GiangVienChucVu entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaChucVuSource	
			if (CanDeepLoad(entity, "ChucVu|MaChucVuSource", deepLoadType, innerList) 
				&& entity.MaChucVuSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.MaChucVu;
				ChucVu tmpEntity = EntityManager.LocateEntity<ChucVu>(EntityLocator.ConstructKeyFromPkItems(typeof(ChucVu), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaChucVuSource = tmpEntity;
				else
					entity.MaChucVuSource = DataRepository.ChucVuProvider.GetByMaChucVu(transactionManager, entity.MaChucVu);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaChucVuSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaChucVuSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ChucVuProvider.DeepLoad(transactionManager, entity.MaChucVuSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaChucVuSource

			#region MaGiangVienSource	
			if (CanDeepLoad(entity, "GiangVien|MaGiangVienSource", deepLoadType, innerList) 
				&& entity.MaGiangVienSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.MaGiangVien;
				GiangVien tmpEntity = EntityManager.LocateEntity<GiangVien>(EntityLocator.ConstructKeyFromPkItems(typeof(GiangVien), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaGiangVienSource = tmpEntity;
				else
					entity.MaGiangVienSource = DataRepository.GiangVienProvider.GetByMaGiangVien(transactionManager, entity.MaGiangVien);		
				
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
		/// Deep Save the entire object graph of the PMS.Entities.GiangVienChucVu object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.GiangVienChucVu instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienChucVu Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.GiangVienChucVu entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaChucVuSource
			if (CanDeepSave(entity, "ChucVu|MaChucVuSource", deepSaveType, innerList) 
				&& entity.MaChucVuSource != null)
			{
				DataRepository.ChucVuProvider.Save(transactionManager, entity.MaChucVuSource);
				entity.MaChucVu = entity.MaChucVuSource.MaChucVu;
			}
			#endregion 
			
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
	
	#region GiangVienChucVuChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.GiangVienChucVu</c>
	///</summary>
	public enum GiangVienChucVuChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>ChucVu</c> at MaChucVuSource
		///</summary>
		[ChildEntityType(typeof(ChucVu))]
		ChucVu,
		
		///<summary>
		/// Composite Property for <c>GiangVien</c> at MaGiangVienSource
		///</summary>
		[ChildEntityType(typeof(GiangVien))]
		GiangVien,
	}
	
	#endregion GiangVienChucVuChildEntityTypes
	
	#region GiangVienChucVuFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GiangVienChucVuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienChucVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienChucVuFilterBuilder : SqlFilterBuilder<GiangVienChucVuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienChucVuFilterBuilder class.
		/// </summary>
		public GiangVienChucVuFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienChucVuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienChucVuFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienChucVuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienChucVuFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienChucVuFilterBuilder
	
	#region GiangVienChucVuParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GiangVienChucVuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienChucVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienChucVuParameterBuilder : ParameterizedSqlFilterBuilder<GiangVienChucVuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienChucVuParameterBuilder class.
		/// </summary>
		public GiangVienChucVuParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienChucVuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienChucVuParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienChucVuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienChucVuParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienChucVuParameterBuilder
	
	#region GiangVienChucVuSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GiangVienChucVuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienChucVu"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GiangVienChucVuSortBuilder : SqlSortBuilder<GiangVienChucVuColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienChucVuSqlSortBuilder class.
		/// </summary>
		public GiangVienChucVuSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GiangVienChucVuSortBuilder
	
} // end namespace
