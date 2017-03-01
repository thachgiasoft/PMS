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
	/// This class is the base class for any <see cref="ChotGioDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ChotGioDayProviderBaseCore : EntityProviderBase<PMS.Entities.ChotGioDay, PMS.Entities.ChotGioDayKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.ChotGioDayKey key)
		{
			return Delete(transactionManager, key.MaChotGio);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maChotGio">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maChotGio)
		{
			return Delete(null, _maChotGio);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maChotGio">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maChotGio);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ChotGioDay_CauHinhChotGio key.
		///		FK_ChotGioDay_CauHinhChotGio Description: 
		/// </summary>
		/// <param name="_maCauHinhChotGio"></param>
		/// <returns>Returns a typed collection of PMS.Entities.ChotGioDay objects.</returns>
		public TList<ChotGioDay> GetByMaCauHinhChotGio(System.Int32? _maCauHinhChotGio)
		{
			int count = -1;
			return GetByMaCauHinhChotGio(_maCauHinhChotGio, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ChotGioDay_CauHinhChotGio key.
		///		FK_ChotGioDay_CauHinhChotGio Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCauHinhChotGio"></param>
		/// <returns>Returns a typed collection of PMS.Entities.ChotGioDay objects.</returns>
		/// <remarks></remarks>
		public TList<ChotGioDay> GetByMaCauHinhChotGio(TransactionManager transactionManager, System.Int32? _maCauHinhChotGio)
		{
			int count = -1;
			return GetByMaCauHinhChotGio(transactionManager, _maCauHinhChotGio, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ChotGioDay_CauHinhChotGio key.
		///		FK_ChotGioDay_CauHinhChotGio Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCauHinhChotGio"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.ChotGioDay objects.</returns>
		public TList<ChotGioDay> GetByMaCauHinhChotGio(TransactionManager transactionManager, System.Int32? _maCauHinhChotGio, int start, int pageLength)
		{
			int count = -1;
			return GetByMaCauHinhChotGio(transactionManager, _maCauHinhChotGio, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ChotGioDay_CauHinhChotGio key.
		///		fkChotGioDayCauHinhChotGio Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maCauHinhChotGio"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.ChotGioDay objects.</returns>
		public TList<ChotGioDay> GetByMaCauHinhChotGio(System.Int32? _maCauHinhChotGio, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaCauHinhChotGio(null, _maCauHinhChotGio, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ChotGioDay_CauHinhChotGio key.
		///		fkChotGioDayCauHinhChotGio Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maCauHinhChotGio"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.ChotGioDay objects.</returns>
		public TList<ChotGioDay> GetByMaCauHinhChotGio(System.Int32? _maCauHinhChotGio, int start, int pageLength,out int count)
		{
			return GetByMaCauHinhChotGio(null, _maCauHinhChotGio, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ChotGioDay_CauHinhChotGio key.
		///		FK_ChotGioDay_CauHinhChotGio Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCauHinhChotGio"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.ChotGioDay objects.</returns>
		public abstract TList<ChotGioDay> GetByMaCauHinhChotGio(TransactionManager transactionManager, System.Int32? _maCauHinhChotGio, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.ChotGioDay Get(TransactionManager transactionManager, PMS.Entities.ChotGioDayKey key, int start, int pageLength)
		{
			return GetByMaChotGio(transactionManager, key.MaChotGio, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ChotGioDay index.
		/// </summary>
		/// <param name="_maChotGio"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChotGioDay"/> class.</returns>
		public PMS.Entities.ChotGioDay GetByMaChotGio(System.Int32 _maChotGio)
		{
			int count = -1;
			return GetByMaChotGio(null,_maChotGio, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ChotGioDay index.
		/// </summary>
		/// <param name="_maChotGio"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChotGioDay"/> class.</returns>
		public PMS.Entities.ChotGioDay GetByMaChotGio(System.Int32 _maChotGio, int start, int pageLength)
		{
			int count = -1;
			return GetByMaChotGio(null, _maChotGio, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ChotGioDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maChotGio"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChotGioDay"/> class.</returns>
		public PMS.Entities.ChotGioDay GetByMaChotGio(TransactionManager transactionManager, System.Int32 _maChotGio)
		{
			int count = -1;
			return GetByMaChotGio(transactionManager, _maChotGio, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ChotGioDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maChotGio"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChotGioDay"/> class.</returns>
		public PMS.Entities.ChotGioDay GetByMaChotGio(TransactionManager transactionManager, System.Int32 _maChotGio, int start, int pageLength)
		{
			int count = -1;
			return GetByMaChotGio(transactionManager, _maChotGio, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ChotGioDay index.
		/// </summary>
		/// <param name="_maChotGio"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChotGioDay"/> class.</returns>
		public PMS.Entities.ChotGioDay GetByMaChotGio(System.Int32 _maChotGio, int start, int pageLength, out int count)
		{
			return GetByMaChotGio(null, _maChotGio, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ChotGioDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maChotGio"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChotGioDay"/> class.</returns>
		public abstract PMS.Entities.ChotGioDay GetByMaChotGio(TransactionManager transactionManager, System.Int32 _maChotGio, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_ChotGioDay_GetByMaGiangVienBacHeDaoTaoTuNgayDenNgay 
		
		/// <summary>
		///	This method wrap the 'cust_ChotGioDay_GetByMaGiangVienBacHeDaoTaoTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChotGioDay&gt;"/> instance.</returns>
		public TList<ChotGioDay> GetByMaGiangVienBacHeDaoTaoTuNgayDenNgay(System.String maGiangVien, System.String maBacDaoTao, System.String maHeDaoTao, System.Int32 maCauHinhChotGio)
		{
			return GetByMaGiangVienBacHeDaoTaoTuNgayDenNgay(null, 0, int.MaxValue , maGiangVien, maBacDaoTao, maHeDaoTao, maCauHinhChotGio);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChotGioDay_GetByMaGiangVienBacHeDaoTaoTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChotGioDay&gt;"/> instance.</returns>
		public TList<ChotGioDay> GetByMaGiangVienBacHeDaoTaoTuNgayDenNgay(int start, int pageLength, System.String maGiangVien, System.String maBacDaoTao, System.String maHeDaoTao, System.Int32 maCauHinhChotGio)
		{
			return GetByMaGiangVienBacHeDaoTaoTuNgayDenNgay(null, start, pageLength , maGiangVien, maBacDaoTao, maHeDaoTao, maCauHinhChotGio);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ChotGioDay_GetByMaGiangVienBacHeDaoTaoTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChotGioDay&gt;"/> instance.</returns>
		public TList<ChotGioDay> GetByMaGiangVienBacHeDaoTaoTuNgayDenNgay(TransactionManager transactionManager, System.String maGiangVien, System.String maBacDaoTao, System.String maHeDaoTao, System.Int32 maCauHinhChotGio)
		{
			return GetByMaGiangVienBacHeDaoTaoTuNgayDenNgay(transactionManager, 0, int.MaxValue , maGiangVien, maBacDaoTao, maHeDaoTao, maCauHinhChotGio);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChotGioDay_GetByMaGiangVienBacHeDaoTaoTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChotGioDay&gt;"/> instance.</returns>
		public abstract TList<ChotGioDay> GetByMaGiangVienBacHeDaoTaoTuNgayDenNgay(TransactionManager transactionManager, int start, int pageLength , System.String maGiangVien, System.String maBacDaoTao, System.String maHeDaoTao, System.Int32 maCauHinhChotGio);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ChotGioDay&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ChotGioDay&gt;"/></returns>
		public static TList<ChotGioDay> Fill(IDataReader reader, TList<ChotGioDay> rows, int start, int pageLength)
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
				
				PMS.Entities.ChotGioDay c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ChotGioDay")
					.Append("|").Append((System.Int32)reader[((int)ChotGioDayColumn.MaChotGio - 1)]).ToString();
					c = EntityManager.LocateOrCreate<ChotGioDay>(
					key.ToString(), // EntityTrackingKey
					"ChotGioDay",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.ChotGioDay();
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
					c.MaChotGio = (System.Int32)reader[((int)ChotGioDayColumn.MaChotGio - 1)];
					c.MaGiangVien = (reader.IsDBNull(((int)ChotGioDayColumn.MaGiangVien - 1)))?null:(System.String)reader[((int)ChotGioDayColumn.MaGiangVien - 1)];
					c.MaBacDaoTao = (reader.IsDBNull(((int)ChotGioDayColumn.MaBacDaoTao - 1)))?null:(System.String)reader[((int)ChotGioDayColumn.MaBacDaoTao - 1)];
					c.MaHeDaoTao = (reader.IsDBNull(((int)ChotGioDayColumn.MaHeDaoTao - 1)))?null:(System.String)reader[((int)ChotGioDayColumn.MaHeDaoTao - 1)];
					c.TietThucDay = (reader.IsDBNull(((int)ChotGioDayColumn.TietThucDay - 1)))?null:(System.Decimal?)reader[((int)ChotGioDayColumn.TietThucDay - 1)];
					c.TietQuyDoi = (reader.IsDBNull(((int)ChotGioDayColumn.TietQuyDoi - 1)))?null:(System.Decimal?)reader[((int)ChotGioDayColumn.TietQuyDoi - 1)];
					c.MaCauHinhChotGio = (reader.IsDBNull(((int)ChotGioDayColumn.MaCauHinhChotGio - 1)))?null:(System.Int32?)reader[((int)ChotGioDayColumn.MaCauHinhChotGio - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ChotGioDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ChotGioDay"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.ChotGioDay entity)
		{
			if (!reader.Read()) return;
			
			entity.MaChotGio = (System.Int32)reader[((int)ChotGioDayColumn.MaChotGio - 1)];
			entity.MaGiangVien = (reader.IsDBNull(((int)ChotGioDayColumn.MaGiangVien - 1)))?null:(System.String)reader[((int)ChotGioDayColumn.MaGiangVien - 1)];
			entity.MaBacDaoTao = (reader.IsDBNull(((int)ChotGioDayColumn.MaBacDaoTao - 1)))?null:(System.String)reader[((int)ChotGioDayColumn.MaBacDaoTao - 1)];
			entity.MaHeDaoTao = (reader.IsDBNull(((int)ChotGioDayColumn.MaHeDaoTao - 1)))?null:(System.String)reader[((int)ChotGioDayColumn.MaHeDaoTao - 1)];
			entity.TietThucDay = (reader.IsDBNull(((int)ChotGioDayColumn.TietThucDay - 1)))?null:(System.Decimal?)reader[((int)ChotGioDayColumn.TietThucDay - 1)];
			entity.TietQuyDoi = (reader.IsDBNull(((int)ChotGioDayColumn.TietQuyDoi - 1)))?null:(System.Decimal?)reader[((int)ChotGioDayColumn.TietQuyDoi - 1)];
			entity.MaCauHinhChotGio = (reader.IsDBNull(((int)ChotGioDayColumn.MaCauHinhChotGio - 1)))?null:(System.Int32?)reader[((int)ChotGioDayColumn.MaCauHinhChotGio - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ChotGioDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ChotGioDay"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.ChotGioDay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaChotGio = (System.Int32)dataRow["MaChotGio"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.String)dataRow["MaGiangVien"];
			entity.MaBacDaoTao = Convert.IsDBNull(dataRow["MaBacDaoTao"]) ? null : (System.String)dataRow["MaBacDaoTao"];
			entity.MaHeDaoTao = Convert.IsDBNull(dataRow["MaHeDaoTao"]) ? null : (System.String)dataRow["MaHeDaoTao"];
			entity.TietThucDay = Convert.IsDBNull(dataRow["TietThucDay"]) ? null : (System.Decimal?)dataRow["TietThucDay"];
			entity.TietQuyDoi = Convert.IsDBNull(dataRow["TietQuyDoi"]) ? null : (System.Decimal?)dataRow["TietQuyDoi"];
			entity.MaCauHinhChotGio = Convert.IsDBNull(dataRow["MaCauHinhChotGio"]) ? null : (System.Int32?)dataRow["MaCauHinhChotGio"];
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
		/// <param name="entity">The <see cref="PMS.Entities.ChotGioDay"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.ChotGioDay Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.ChotGioDay entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaCauHinhChotGioSource	
			if (CanDeepLoad(entity, "CauHinhChotGio|MaCauHinhChotGioSource", deepLoadType, innerList) 
				&& entity.MaCauHinhChotGioSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaCauHinhChotGio ?? (int)0);
				CauHinhChotGio tmpEntity = EntityManager.LocateEntity<CauHinhChotGio>(EntityLocator.ConstructKeyFromPkItems(typeof(CauHinhChotGio), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaCauHinhChotGioSource = tmpEntity;
				else
					entity.MaCauHinhChotGioSource = DataRepository.CauHinhChotGioProvider.GetByMaCauHinhChotGio(transactionManager, (entity.MaCauHinhChotGio ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaCauHinhChotGioSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaCauHinhChotGioSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.CauHinhChotGioProvider.DeepLoad(transactionManager, entity.MaCauHinhChotGioSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaCauHinhChotGioSource
			
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
		/// Deep Save the entire object graph of the PMS.Entities.ChotGioDay object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.ChotGioDay instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.ChotGioDay Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.ChotGioDay entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaCauHinhChotGioSource
			if (CanDeepSave(entity, "CauHinhChotGio|MaCauHinhChotGioSource", deepSaveType, innerList) 
				&& entity.MaCauHinhChotGioSource != null)
			{
				DataRepository.CauHinhChotGioProvider.Save(transactionManager, entity.MaCauHinhChotGioSource);
				entity.MaCauHinhChotGio = entity.MaCauHinhChotGioSource.MaCauHinhChotGio;
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
	
	#region ChotGioDayChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.ChotGioDay</c>
	///</summary>
	public enum ChotGioDayChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>CauHinhChotGio</c> at MaCauHinhChotGioSource
		///</summary>
		[ChildEntityType(typeof(CauHinhChotGio))]
		CauHinhChotGio,
		}
	
	#endregion ChotGioDayChildEntityTypes
	
	#region ChotGioDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ChotGioDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChotGioDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChotGioDayFilterBuilder : SqlFilterBuilder<ChotGioDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChotGioDayFilterBuilder class.
		/// </summary>
		public ChotGioDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ChotGioDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ChotGioDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ChotGioDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ChotGioDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ChotGioDayFilterBuilder
	
	#region ChotGioDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ChotGioDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChotGioDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChotGioDayParameterBuilder : ParameterizedSqlFilterBuilder<ChotGioDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChotGioDayParameterBuilder class.
		/// </summary>
		public ChotGioDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ChotGioDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ChotGioDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ChotGioDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ChotGioDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ChotGioDayParameterBuilder
	
	#region ChotGioDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ChotGioDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChotGioDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ChotGioDaySortBuilder : SqlSortBuilder<ChotGioDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChotGioDaySqlSortBuilder class.
		/// </summary>
		public ChotGioDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ChotGioDaySortBuilder
	
} // end namespace
