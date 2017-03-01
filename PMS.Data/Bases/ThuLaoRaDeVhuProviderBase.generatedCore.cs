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
	/// This class is the base class for any <see cref="ThuLaoRaDeVhuProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ThuLaoRaDeVhuProviderBaseCore : EntityProviderBase<PMS.Entities.ThuLaoRaDeVhu, PMS.Entities.ThuLaoRaDeVhuKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.ThuLaoRaDeVhuKey key)
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
		public override PMS.Entities.ThuLaoRaDeVhu Get(TransactionManager transactionManager, PMS.Entities.ThuLaoRaDeVhuKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ThuLaoRaDeVhu index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoRaDeVhu"/> class.</returns>
		public PMS.Entities.ThuLaoRaDeVhu GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoRaDeVhu index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoRaDeVhu"/> class.</returns>
		public PMS.Entities.ThuLaoRaDeVhu GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoRaDeVhu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoRaDeVhu"/> class.</returns>
		public PMS.Entities.ThuLaoRaDeVhu GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoRaDeVhu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoRaDeVhu"/> class.</returns>
		public PMS.Entities.ThuLaoRaDeVhu GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoRaDeVhu index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoRaDeVhu"/> class.</returns>
		public PMS.Entities.ThuLaoRaDeVhu GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoRaDeVhu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoRaDeVhu"/> class.</returns>
		public abstract PMS.Entities.ThuLaoRaDeVhu GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_ThuLaoRaDeVhu_HuyChot 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoRaDeVhu_HuyChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChot(System.String namHoc, System.String hocKy)
		{
			 HuyChot(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoRaDeVhu_HuyChot' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoRaDeVhu_HuyChot' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoRaDeVhu_HuyChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void HuyChot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_ThuLaoRaDeVhu_DongBo 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoRaDeVhu_DongBo' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoRaDeVhu_DongBo' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoRaDeVhu_DongBo' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoRaDeVhu_DongBo' stored procedure. 
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
		
		#region cust_ThuLaoRaDeVhu_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoRaDeVhu_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoRaDeVhu_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoRaDeVhu_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoRaDeVhu_GetByNamHocHocKy' stored procedure. 
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
		
		#region cust_ThuLaoRaDeVhu_Chot 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoRaDeVhu_Chot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Chot(System.String namHoc, System.String hocKy)
		{
			 Chot(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoRaDeVhu_Chot' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoRaDeVhu_Chot' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoRaDeVhu_Chot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Chot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_ThuLaoRaDeVhu_KiemTraChot 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoRaDeVhu_KiemTraChot' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoRaDeVhu_KiemTraChot' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoRaDeVhu_KiemTraChot' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoRaDeVhu_KiemTraChot' stored procedure. 
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
		/// Fill a TList&lt;ThuLaoRaDeVhu&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ThuLaoRaDeVhu&gt;"/></returns>
		public static TList<ThuLaoRaDeVhu> Fill(IDataReader reader, TList<ThuLaoRaDeVhu> rows, int start, int pageLength)
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
				
				PMS.Entities.ThuLaoRaDeVhu c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ThuLaoRaDeVhu")
					.Append("|").Append((System.Int32)reader[((int)ThuLaoRaDeVhuColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<ThuLaoRaDeVhu>(
					key.ToString(), // EntityTrackingKey
					"ThuLaoRaDeVhu",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.ThuLaoRaDeVhu();
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
					c.Id = (System.Int32)reader[(ThuLaoRaDeVhuColumn.Id.ToString())];
					c.NamHoc = (reader[ThuLaoRaDeVhuColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeVhuColumn.NamHoc.ToString())];
					c.HocKy = (reader[ThuLaoRaDeVhuColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeVhuColumn.HocKy.ToString())];
					c.MaGiangVien = (reader[ThuLaoRaDeVhuColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoRaDeVhuColumn.MaGiangVien.ToString())];
					c.MaDotThi = (reader[ThuLaoRaDeVhuColumn.MaDotThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeVhuColumn.MaDotThi.ToString())];
					c.TenDotThi = (reader[ThuLaoRaDeVhuColumn.TenDotThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeVhuColumn.TenDotThi.ToString())];
					c.ThoiGianLamBai = (reader[ThuLaoRaDeVhuColumn.ThoiGianLamBai.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeVhuColumn.ThoiGianLamBai.ToString())];
					c.MaLopHocPhan = (reader[ThuLaoRaDeVhuColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeVhuColumn.MaLopHocPhan.ToString())];
					c.MaHinhThucThi = (reader[ThuLaoRaDeVhuColumn.MaHinhThucThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeVhuColumn.MaHinhThucThi.ToString())];
					c.SoLuongDe = (reader[ThuLaoRaDeVhuColumn.SoLuongDe.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoRaDeVhuColumn.SoLuongDe.ToString())];
					c.HeSoExamination = (reader[ThuLaoRaDeVhuColumn.HeSoExamination.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoRaDeVhuColumn.HeSoExamination.ToString())];
					c.MaDangDeThi = (reader[ThuLaoRaDeVhuColumn.MaDangDeThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeVhuColumn.MaDangDeThi.ToString())];
					c.TenDangDeThi = (reader[ThuLaoRaDeVhuColumn.TenDangDeThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeVhuColumn.TenDangDeThi.ToString())];
					c.KyThi = (reader[ThuLaoRaDeVhuColumn.KyThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeVhuColumn.KyThi.ToString())];
					c.HeSoQuyDoi = (reader[ThuLaoRaDeVhuColumn.HeSoQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoRaDeVhuColumn.HeSoQuyDoi.ToString())];
					c.SoTietQuyDoi = (reader[ThuLaoRaDeVhuColumn.SoTietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoRaDeVhuColumn.SoTietQuyDoi.ToString())];
					c.TongTien = (reader[ThuLaoRaDeVhuColumn.TongTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoRaDeVhuColumn.TongTien.ToString())];
					c.Chot = (reader[ThuLaoRaDeVhuColumn.Chot.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ThuLaoRaDeVhuColumn.Chot.ToString())];
					c.NgayCapNhat = (reader[ThuLaoRaDeVhuColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeVhuColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[ThuLaoRaDeVhuColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeVhuColumn.NguoiCapNhat.ToString())];
					c.MaHocHam = (reader[ThuLaoRaDeVhuColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoRaDeVhuColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[ThuLaoRaDeVhuColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoRaDeVhuColumn.MaHocVi.ToString())];
					c.MaLoaiGiangVien = (reader[ThuLaoRaDeVhuColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoRaDeVhuColumn.MaLoaiGiangVien.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThuLaoRaDeVhu"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoRaDeVhu"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.ThuLaoRaDeVhu entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(ThuLaoRaDeVhuColumn.Id.ToString())];
			entity.NamHoc = (reader[ThuLaoRaDeVhuColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeVhuColumn.NamHoc.ToString())];
			entity.HocKy = (reader[ThuLaoRaDeVhuColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeVhuColumn.HocKy.ToString())];
			entity.MaGiangVien = (reader[ThuLaoRaDeVhuColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoRaDeVhuColumn.MaGiangVien.ToString())];
			entity.MaDotThi = (reader[ThuLaoRaDeVhuColumn.MaDotThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeVhuColumn.MaDotThi.ToString())];
			entity.TenDotThi = (reader[ThuLaoRaDeVhuColumn.TenDotThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeVhuColumn.TenDotThi.ToString())];
			entity.ThoiGianLamBai = (reader[ThuLaoRaDeVhuColumn.ThoiGianLamBai.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeVhuColumn.ThoiGianLamBai.ToString())];
			entity.MaLopHocPhan = (reader[ThuLaoRaDeVhuColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeVhuColumn.MaLopHocPhan.ToString())];
			entity.MaHinhThucThi = (reader[ThuLaoRaDeVhuColumn.MaHinhThucThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeVhuColumn.MaHinhThucThi.ToString())];
			entity.SoLuongDe = (reader[ThuLaoRaDeVhuColumn.SoLuongDe.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoRaDeVhuColumn.SoLuongDe.ToString())];
			entity.HeSoExamination = (reader[ThuLaoRaDeVhuColumn.HeSoExamination.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoRaDeVhuColumn.HeSoExamination.ToString())];
			entity.MaDangDeThi = (reader[ThuLaoRaDeVhuColumn.MaDangDeThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeVhuColumn.MaDangDeThi.ToString())];
			entity.TenDangDeThi = (reader[ThuLaoRaDeVhuColumn.TenDangDeThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeVhuColumn.TenDangDeThi.ToString())];
			entity.KyThi = (reader[ThuLaoRaDeVhuColumn.KyThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeVhuColumn.KyThi.ToString())];
			entity.HeSoQuyDoi = (reader[ThuLaoRaDeVhuColumn.HeSoQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoRaDeVhuColumn.HeSoQuyDoi.ToString())];
			entity.SoTietQuyDoi = (reader[ThuLaoRaDeVhuColumn.SoTietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoRaDeVhuColumn.SoTietQuyDoi.ToString())];
			entity.TongTien = (reader[ThuLaoRaDeVhuColumn.TongTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoRaDeVhuColumn.TongTien.ToString())];
			entity.Chot = (reader[ThuLaoRaDeVhuColumn.Chot.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ThuLaoRaDeVhuColumn.Chot.ToString())];
			entity.NgayCapNhat = (reader[ThuLaoRaDeVhuColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeVhuColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[ThuLaoRaDeVhuColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeVhuColumn.NguoiCapNhat.ToString())];
			entity.MaHocHam = (reader[ThuLaoRaDeVhuColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoRaDeVhuColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[ThuLaoRaDeVhuColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoRaDeVhuColumn.MaHocVi.ToString())];
			entity.MaLoaiGiangVien = (reader[ThuLaoRaDeVhuColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoRaDeVhuColumn.MaLoaiGiangVien.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThuLaoRaDeVhu"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoRaDeVhu"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.ThuLaoRaDeVhu entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.Int32?)dataRow["MaGiangVien"];
			entity.MaDotThi = Convert.IsDBNull(dataRow["MaDotThi"]) ? null : (System.String)dataRow["MaDotThi"];
			entity.TenDotThi = Convert.IsDBNull(dataRow["TenDotThi"]) ? null : (System.String)dataRow["TenDotThi"];
			entity.ThoiGianLamBai = Convert.IsDBNull(dataRow["ThoiGianLamBai"]) ? null : (System.String)dataRow["ThoiGianLamBai"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.MaHinhThucThi = Convert.IsDBNull(dataRow["MaHinhThucThi"]) ? null : (System.String)dataRow["MaHinhThucThi"];
			entity.SoLuongDe = Convert.IsDBNull(dataRow["SoLuongDe"]) ? null : (System.Int32?)dataRow["SoLuongDe"];
			entity.HeSoExamination = Convert.IsDBNull(dataRow["HeSoExamination"]) ? null : (System.Decimal?)dataRow["HeSoExamination"];
			entity.MaDangDeThi = Convert.IsDBNull(dataRow["MaDangDeThi"]) ? null : (System.String)dataRow["MaDangDeThi"];
			entity.TenDangDeThi = Convert.IsDBNull(dataRow["TenDangDeThi"]) ? null : (System.String)dataRow["TenDangDeThi"];
			entity.KyThi = Convert.IsDBNull(dataRow["KyThi"]) ? null : (System.String)dataRow["KyThi"];
			entity.HeSoQuyDoi = Convert.IsDBNull(dataRow["HeSoQuyDoi"]) ? null : (System.Decimal?)dataRow["HeSoQuyDoi"];
			entity.SoTietQuyDoi = Convert.IsDBNull(dataRow["SoTietQuyDoi"]) ? null : (System.Decimal?)dataRow["SoTietQuyDoi"];
			entity.TongTien = Convert.IsDBNull(dataRow["TongTien"]) ? null : (System.Decimal?)dataRow["TongTien"];
			entity.Chot = Convert.IsDBNull(dataRow["Chot"]) ? null : (System.Boolean?)dataRow["Chot"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
			entity.MaLoaiGiangVien = Convert.IsDBNull(dataRow["MaLoaiGiangVien"]) ? null : (System.Int32?)dataRow["MaLoaiGiangVien"];
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
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoRaDeVhu"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.ThuLaoRaDeVhu Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.ThuLaoRaDeVhu entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.ThuLaoRaDeVhu object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.ThuLaoRaDeVhu instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.ThuLaoRaDeVhu Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.ThuLaoRaDeVhu entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region ThuLaoRaDeVhuChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.ThuLaoRaDeVhu</c>
	///</summary>
	public enum ThuLaoRaDeVhuChildEntityTypes
	{
	}
	
	#endregion ThuLaoRaDeVhuChildEntityTypes
	
	#region ThuLaoRaDeVhuFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ThuLaoRaDeVhuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoRaDeVhu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoRaDeVhuFilterBuilder : SqlFilterBuilder<ThuLaoRaDeVhuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoRaDeVhuFilterBuilder class.
		/// </summary>
		public ThuLaoRaDeVhuFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoRaDeVhuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThuLaoRaDeVhuFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoRaDeVhuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThuLaoRaDeVhuFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThuLaoRaDeVhuFilterBuilder
	
	#region ThuLaoRaDeVhuParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ThuLaoRaDeVhuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoRaDeVhu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoRaDeVhuParameterBuilder : ParameterizedSqlFilterBuilder<ThuLaoRaDeVhuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoRaDeVhuParameterBuilder class.
		/// </summary>
		public ThuLaoRaDeVhuParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoRaDeVhuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThuLaoRaDeVhuParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoRaDeVhuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThuLaoRaDeVhuParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThuLaoRaDeVhuParameterBuilder
	
	#region ThuLaoRaDeVhuSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ThuLaoRaDeVhuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoRaDeVhu"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ThuLaoRaDeVhuSortBuilder : SqlSortBuilder<ThuLaoRaDeVhuColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoRaDeVhuSqlSortBuilder class.
		/// </summary>
		public ThuLaoRaDeVhuSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ThuLaoRaDeVhuSortBuilder
	
} // end namespace
