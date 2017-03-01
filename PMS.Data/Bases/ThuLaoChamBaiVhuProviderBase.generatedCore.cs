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
	/// This class is the base class for any <see cref="ThuLaoChamBaiVhuProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ThuLaoChamBaiVhuProviderBaseCore : EntityProviderBase<PMS.Entities.ThuLaoChamBaiVhu, PMS.Entities.ThuLaoChamBaiVhuKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.ThuLaoChamBaiVhuKey key)
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
		public override PMS.Entities.ThuLaoChamBaiVhu Get(TransactionManager transactionManager, PMS.Entities.ThuLaoChamBaiVhuKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ThuLaoChamBaiVhu index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoChamBaiVhu"/> class.</returns>
		public PMS.Entities.ThuLaoChamBaiVhu GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoChamBaiVhu index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoChamBaiVhu"/> class.</returns>
		public PMS.Entities.ThuLaoChamBaiVhu GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoChamBaiVhu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoChamBaiVhu"/> class.</returns>
		public PMS.Entities.ThuLaoChamBaiVhu GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoChamBaiVhu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoChamBaiVhu"/> class.</returns>
		public PMS.Entities.ThuLaoChamBaiVhu GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoChamBaiVhu index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoChamBaiVhu"/> class.</returns>
		public PMS.Entities.ThuLaoChamBaiVhu GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoChamBaiVhu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoChamBaiVhu"/> class.</returns>
		public abstract PMS.Entities.ThuLaoChamBaiVhu GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_ThuLaoChamBaiVhu_HuyChot 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBaiVhu_HuyChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChot(System.String namHoc, System.String hocKy)
		{
			 HuyChot(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBaiVhu_HuyChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChot(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			 HuyChot(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBaiVhu_HuyChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChot(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			 HuyChot(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBaiVhu_HuyChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void HuyChot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_ThuLaoChamBaiVhu_DongBo 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBaiVhu_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBo(System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 DongBo(null, 0, int.MaxValue , namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBaiVhu_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBo(int start, int pageLength, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 DongBo(null, start, pageLength , namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBaiVhu_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBo(TransactionManager transactionManager, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 DongBo(transactionManager, 0, int.MaxValue , namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBaiVhu_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DongBo(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_ThuLaoChamBaiVhu_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBaiVhu_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBaiVhu_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBaiVhu_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBaiVhu_GetByNamHocHocKy' stored procedure. 
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
		
		#region cust_ThuLaoChamBaiVhu_Chot 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBaiVhu_Chot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Chot(System.String namHoc, System.String hocKy)
		{
			 Chot(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBaiVhu_Chot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Chot(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			 Chot(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBaiVhu_Chot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Chot(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			 Chot(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBaiVhu_Chot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Chot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_ThuLaoChamBaiVhu_KiemTraChot 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBaiVhu_KiemTraChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraChot(System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 KiemTraChot(null, 0, int.MaxValue , namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBaiVhu_KiemTraChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraChot(int start, int pageLength, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 KiemTraChot(null, start, pageLength , namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBaiVhu_KiemTraChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraChot(TransactionManager transactionManager, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 KiemTraChot(transactionManager, 0, int.MaxValue , namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBaiVhu_KiemTraChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void KiemTraChot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ThuLaoChamBaiVhu&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ThuLaoChamBaiVhu&gt;"/></returns>
		public static TList<ThuLaoChamBaiVhu> Fill(IDataReader reader, TList<ThuLaoChamBaiVhu> rows, int start, int pageLength)
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
				
				PMS.Entities.ThuLaoChamBaiVhu c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ThuLaoChamBaiVhu")
					.Append("|").Append((System.Int32)reader[((int)ThuLaoChamBaiVhuColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<ThuLaoChamBaiVhu>(
					key.ToString(), // EntityTrackingKey
					"ThuLaoChamBaiVhu",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.ThuLaoChamBaiVhu();
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
					c.Id = (System.Int32)reader[(ThuLaoChamBaiVhuColumn.Id.ToString())];
					c.NamHoc = (reader[ThuLaoChamBaiVhuColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiVhuColumn.NamHoc.ToString())];
					c.HocKy = (reader[ThuLaoChamBaiVhuColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiVhuColumn.HocKy.ToString())];
					c.KyThi = (reader[ThuLaoChamBaiVhuColumn.KyThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiVhuColumn.KyThi.ToString())];
					c.LanThi = (reader[ThuLaoChamBaiVhuColumn.LanThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiVhuColumn.LanThi.ToString())];
					c.MaGiangVien = (reader[ThuLaoChamBaiVhuColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoChamBaiVhuColumn.MaGiangVien.ToString())];
					c.KhoaNganh = (reader[ThuLaoChamBaiVhuColumn.KhoaNganh.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiVhuColumn.KhoaNganh.ToString())];
					c.Nganh = (reader[ThuLaoChamBaiVhuColumn.Nganh.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiVhuColumn.Nganh.ToString())];
					c.MaHocPhan = (reader[ThuLaoChamBaiVhuColumn.MaHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiVhuColumn.MaHocPhan.ToString())];
					c.TenHocPhan = (reader[ThuLaoChamBaiVhuColumn.TenHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiVhuColumn.TenHocPhan.ToString())];
					c.MaLopHocPhan = (reader[ThuLaoChamBaiVhuColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiVhuColumn.MaLopHocPhan.ToString())];
					c.SoTinChi = (reader[ThuLaoChamBaiVhuColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoChamBaiVhuColumn.SoTinChi.ToString())];
					c.BacDaoTao = (reader[ThuLaoChamBaiVhuColumn.BacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiVhuColumn.BacDaoTao.ToString())];
					c.LopSinhVien = (reader[ThuLaoChamBaiVhuColumn.LopSinhVien.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiVhuColumn.LopSinhVien.ToString())];
					c.SiSo = (reader[ThuLaoChamBaiVhuColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoChamBaiVhuColumn.SiSo.ToString())];
					c.ThoiGianThi = (reader[ThuLaoChamBaiVhuColumn.ThoiGianThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiVhuColumn.ThoiGianThi.ToString())];
					c.DinhMucChamGiuaKy = (reader[ThuLaoChamBaiVhuColumn.DinhMucChamGiuaKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiVhuColumn.DinhMucChamGiuaKy.ToString())];
					c.ThuLaoChamGiuaKy = (reader[ThuLaoChamBaiVhuColumn.ThuLaoChamGiuaKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiVhuColumn.ThuLaoChamGiuaKy.ToString())];
					c.DinhMucChamCuoiKy = (reader[ThuLaoChamBaiVhuColumn.DinhMucChamCuoiKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiVhuColumn.DinhMucChamCuoiKy.ToString())];
					c.ThuLaoChamCuoiKy = (reader[ThuLaoChamBaiVhuColumn.ThuLaoChamCuoiKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiVhuColumn.ThuLaoChamCuoiKy.ToString())];
					c.ThanhTienLan1 = (reader[ThuLaoChamBaiVhuColumn.ThanhTienLan1.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiVhuColumn.ThanhTienLan1.ToString())];
					c.ThanhTienLan2 = (reader[ThuLaoChamBaiVhuColumn.ThanhTienLan2.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiVhuColumn.ThanhTienLan2.ToString())];
					c.TongCong = (reader[ThuLaoChamBaiVhuColumn.TongCong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiVhuColumn.TongCong.ToString())];
					c.HinhThucThi = (reader[ThuLaoChamBaiVhuColumn.HinhThucThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiVhuColumn.HinhThucThi.ToString())];
					c.HeSoQuyDoi = (reader[ThuLaoChamBaiVhuColumn.HeSoQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiVhuColumn.HeSoQuyDoi.ToString())];
					c.SoTietQuyDoi = (reader[ThuLaoChamBaiVhuColumn.SoTietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiVhuColumn.SoTietQuyDoi.ToString())];
					c.Chot = (reader[ThuLaoChamBaiVhuColumn.Chot.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ThuLaoChamBaiVhuColumn.Chot.ToString())];
					c.NgayCapNhat = (reader[ThuLaoChamBaiVhuColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiVhuColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[ThuLaoChamBaiVhuColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiVhuColumn.NguoiCapNhat.ToString())];
					c.MaHocHam = (reader[ThuLaoChamBaiVhuColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoChamBaiVhuColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[ThuLaoChamBaiVhuColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoChamBaiVhuColumn.MaHocVi.ToString())];
					c.MaLoaiGiangVien = (reader[ThuLaoChamBaiVhuColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoChamBaiVhuColumn.MaLoaiGiangVien.ToString())];
					c.SoBaiLan2 = (reader[ThuLaoChamBaiVhuColumn.SoBaiLan2.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoChamBaiVhuColumn.SoBaiLan2.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThuLaoChamBaiVhu"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoChamBaiVhu"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.ThuLaoChamBaiVhu entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(ThuLaoChamBaiVhuColumn.Id.ToString())];
			entity.NamHoc = (reader[ThuLaoChamBaiVhuColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiVhuColumn.NamHoc.ToString())];
			entity.HocKy = (reader[ThuLaoChamBaiVhuColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiVhuColumn.HocKy.ToString())];
			entity.KyThi = (reader[ThuLaoChamBaiVhuColumn.KyThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiVhuColumn.KyThi.ToString())];
			entity.LanThi = (reader[ThuLaoChamBaiVhuColumn.LanThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiVhuColumn.LanThi.ToString())];
			entity.MaGiangVien = (reader[ThuLaoChamBaiVhuColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoChamBaiVhuColumn.MaGiangVien.ToString())];
			entity.KhoaNganh = (reader[ThuLaoChamBaiVhuColumn.KhoaNganh.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiVhuColumn.KhoaNganh.ToString())];
			entity.Nganh = (reader[ThuLaoChamBaiVhuColumn.Nganh.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiVhuColumn.Nganh.ToString())];
			entity.MaHocPhan = (reader[ThuLaoChamBaiVhuColumn.MaHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiVhuColumn.MaHocPhan.ToString())];
			entity.TenHocPhan = (reader[ThuLaoChamBaiVhuColumn.TenHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiVhuColumn.TenHocPhan.ToString())];
			entity.MaLopHocPhan = (reader[ThuLaoChamBaiVhuColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiVhuColumn.MaLopHocPhan.ToString())];
			entity.SoTinChi = (reader[ThuLaoChamBaiVhuColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoChamBaiVhuColumn.SoTinChi.ToString())];
			entity.BacDaoTao = (reader[ThuLaoChamBaiVhuColumn.BacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiVhuColumn.BacDaoTao.ToString())];
			entity.LopSinhVien = (reader[ThuLaoChamBaiVhuColumn.LopSinhVien.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiVhuColumn.LopSinhVien.ToString())];
			entity.SiSo = (reader[ThuLaoChamBaiVhuColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoChamBaiVhuColumn.SiSo.ToString())];
			entity.ThoiGianThi = (reader[ThuLaoChamBaiVhuColumn.ThoiGianThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiVhuColumn.ThoiGianThi.ToString())];
			entity.DinhMucChamGiuaKy = (reader[ThuLaoChamBaiVhuColumn.DinhMucChamGiuaKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiVhuColumn.DinhMucChamGiuaKy.ToString())];
			entity.ThuLaoChamGiuaKy = (reader[ThuLaoChamBaiVhuColumn.ThuLaoChamGiuaKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiVhuColumn.ThuLaoChamGiuaKy.ToString())];
			entity.DinhMucChamCuoiKy = (reader[ThuLaoChamBaiVhuColumn.DinhMucChamCuoiKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiVhuColumn.DinhMucChamCuoiKy.ToString())];
			entity.ThuLaoChamCuoiKy = (reader[ThuLaoChamBaiVhuColumn.ThuLaoChamCuoiKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiVhuColumn.ThuLaoChamCuoiKy.ToString())];
			entity.ThanhTienLan1 = (reader[ThuLaoChamBaiVhuColumn.ThanhTienLan1.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiVhuColumn.ThanhTienLan1.ToString())];
			entity.ThanhTienLan2 = (reader[ThuLaoChamBaiVhuColumn.ThanhTienLan2.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiVhuColumn.ThanhTienLan2.ToString())];
			entity.TongCong = (reader[ThuLaoChamBaiVhuColumn.TongCong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiVhuColumn.TongCong.ToString())];
			entity.HinhThucThi = (reader[ThuLaoChamBaiVhuColumn.HinhThucThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiVhuColumn.HinhThucThi.ToString())];
			entity.HeSoQuyDoi = (reader[ThuLaoChamBaiVhuColumn.HeSoQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiVhuColumn.HeSoQuyDoi.ToString())];
			entity.SoTietQuyDoi = (reader[ThuLaoChamBaiVhuColumn.SoTietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiVhuColumn.SoTietQuyDoi.ToString())];
			entity.Chot = (reader[ThuLaoChamBaiVhuColumn.Chot.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ThuLaoChamBaiVhuColumn.Chot.ToString())];
			entity.NgayCapNhat = (reader[ThuLaoChamBaiVhuColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiVhuColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[ThuLaoChamBaiVhuColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiVhuColumn.NguoiCapNhat.ToString())];
			entity.MaHocHam = (reader[ThuLaoChamBaiVhuColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoChamBaiVhuColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[ThuLaoChamBaiVhuColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoChamBaiVhuColumn.MaHocVi.ToString())];
			entity.MaLoaiGiangVien = (reader[ThuLaoChamBaiVhuColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoChamBaiVhuColumn.MaLoaiGiangVien.ToString())];
			entity.SoBaiLan2 = (reader[ThuLaoChamBaiVhuColumn.SoBaiLan2.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoChamBaiVhuColumn.SoBaiLan2.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThuLaoChamBaiVhu"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoChamBaiVhu"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.ThuLaoChamBaiVhu entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.KyThi = Convert.IsDBNull(dataRow["KyThi"]) ? null : (System.String)dataRow["KyThi"];
			entity.LanThi = Convert.IsDBNull(dataRow["LanThi"]) ? null : (System.String)dataRow["LanThi"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.Int32?)dataRow["MaGiangVien"];
			entity.KhoaNganh = Convert.IsDBNull(dataRow["KhoaNganh"]) ? null : (System.String)dataRow["KhoaNganh"];
			entity.Nganh = Convert.IsDBNull(dataRow["Nganh"]) ? null : (System.String)dataRow["Nganh"];
			entity.MaHocPhan = Convert.IsDBNull(dataRow["MaHocPhan"]) ? null : (System.String)dataRow["MaHocPhan"];
			entity.TenHocPhan = Convert.IsDBNull(dataRow["TenHocPhan"]) ? null : (System.String)dataRow["TenHocPhan"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.SoTinChi = Convert.IsDBNull(dataRow["SoTinChi"]) ? null : (System.Int32?)dataRow["SoTinChi"];
			entity.BacDaoTao = Convert.IsDBNull(dataRow["BacDaoTao"]) ? null : (System.String)dataRow["BacDaoTao"];
			entity.LopSinhVien = Convert.IsDBNull(dataRow["LopSinhVien"]) ? null : (System.String)dataRow["LopSinhVien"];
			entity.SiSo = Convert.IsDBNull(dataRow["SiSo"]) ? null : (System.Int32?)dataRow["SiSo"];
			entity.ThoiGianThi = Convert.IsDBNull(dataRow["ThoiGianThi"]) ? null : (System.String)dataRow["ThoiGianThi"];
			entity.DinhMucChamGiuaKy = Convert.IsDBNull(dataRow["DinhMucChamGiuaKy"]) ? null : (System.Decimal?)dataRow["DinhMucChamGiuaKy"];
			entity.ThuLaoChamGiuaKy = Convert.IsDBNull(dataRow["ThuLaoChamGiuaKy"]) ? null : (System.Decimal?)dataRow["ThuLaoChamGiuaKy"];
			entity.DinhMucChamCuoiKy = Convert.IsDBNull(dataRow["DinhMucChamCuoiKy"]) ? null : (System.Decimal?)dataRow["DinhMucChamCuoiKy"];
			entity.ThuLaoChamCuoiKy = Convert.IsDBNull(dataRow["ThuLaoChamCuoiKy"]) ? null : (System.Decimal?)dataRow["ThuLaoChamCuoiKy"];
			entity.ThanhTienLan1 = Convert.IsDBNull(dataRow["ThanhTienLan1"]) ? null : (System.Decimal?)dataRow["ThanhTienLan1"];
			entity.ThanhTienLan2 = Convert.IsDBNull(dataRow["ThanhTienLan2"]) ? null : (System.Decimal?)dataRow["ThanhTienLan2"];
			entity.TongCong = Convert.IsDBNull(dataRow["TongCong"]) ? null : (System.Decimal?)dataRow["TongCong"];
			entity.HinhThucThi = Convert.IsDBNull(dataRow["HinhThucThi"]) ? null : (System.String)dataRow["HinhThucThi"];
			entity.HeSoQuyDoi = Convert.IsDBNull(dataRow["HeSoQuyDoi"]) ? null : (System.Decimal?)dataRow["HeSoQuyDoi"];
			entity.SoTietQuyDoi = Convert.IsDBNull(dataRow["SoTietQuyDoi"]) ? null : (System.Decimal?)dataRow["SoTietQuyDoi"];
			entity.Chot = Convert.IsDBNull(dataRow["Chot"]) ? null : (System.Boolean?)dataRow["Chot"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
			entity.MaLoaiGiangVien = Convert.IsDBNull(dataRow["MaLoaiGiangVien"]) ? null : (System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.SoBaiLan2 = Convert.IsDBNull(dataRow["SoBaiLan2"]) ? null : (System.Int32?)dataRow["SoBaiLan2"];
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
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoChamBaiVhu"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.ThuLaoChamBaiVhu Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.ThuLaoChamBaiVhu entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.ThuLaoChamBaiVhu object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.ThuLaoChamBaiVhu instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.ThuLaoChamBaiVhu Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.ThuLaoChamBaiVhu entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region ThuLaoChamBaiVhuChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.ThuLaoChamBaiVhu</c>
	///</summary>
	public enum ThuLaoChamBaiVhuChildEntityTypes
	{
	}
	
	#endregion ThuLaoChamBaiVhuChildEntityTypes
	
	#region ThuLaoChamBaiVhuFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ThuLaoChamBaiVhuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoChamBaiVhu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoChamBaiVhuFilterBuilder : SqlFilterBuilder<ThuLaoChamBaiVhuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoChamBaiVhuFilterBuilder class.
		/// </summary>
		public ThuLaoChamBaiVhuFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoChamBaiVhuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThuLaoChamBaiVhuFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoChamBaiVhuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThuLaoChamBaiVhuFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThuLaoChamBaiVhuFilterBuilder
	
	#region ThuLaoChamBaiVhuParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ThuLaoChamBaiVhuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoChamBaiVhu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoChamBaiVhuParameterBuilder : ParameterizedSqlFilterBuilder<ThuLaoChamBaiVhuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoChamBaiVhuParameterBuilder class.
		/// </summary>
		public ThuLaoChamBaiVhuParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoChamBaiVhuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThuLaoChamBaiVhuParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoChamBaiVhuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThuLaoChamBaiVhuParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThuLaoChamBaiVhuParameterBuilder
	
	#region ThuLaoChamBaiVhuSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ThuLaoChamBaiVhuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoChamBaiVhu"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ThuLaoChamBaiVhuSortBuilder : SqlSortBuilder<ThuLaoChamBaiVhuColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoChamBaiVhuSqlSortBuilder class.
		/// </summary>
		public ThuLaoChamBaiVhuSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ThuLaoChamBaiVhuSortBuilder
	
} // end namespace
