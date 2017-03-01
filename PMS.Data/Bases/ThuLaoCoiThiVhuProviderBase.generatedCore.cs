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
	/// This class is the base class for any <see cref="ThuLaoCoiThiVhuProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ThuLaoCoiThiVhuProviderBaseCore : EntityProviderBase<PMS.Entities.ThuLaoCoiThiVhu, PMS.Entities.ThuLaoCoiThiVhuKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.ThuLaoCoiThiVhuKey key)
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
		public override PMS.Entities.ThuLaoCoiThiVhu Get(TransactionManager transactionManager, PMS.Entities.ThuLaoCoiThiVhuKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ThuLaoCoiThiVhu index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoCoiThiVhu"/> class.</returns>
		public PMS.Entities.ThuLaoCoiThiVhu GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoCoiThiVhu index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoCoiThiVhu"/> class.</returns>
		public PMS.Entities.ThuLaoCoiThiVhu GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoCoiThiVhu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoCoiThiVhu"/> class.</returns>
		public PMS.Entities.ThuLaoCoiThiVhu GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoCoiThiVhu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoCoiThiVhu"/> class.</returns>
		public PMS.Entities.ThuLaoCoiThiVhu GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoCoiThiVhu index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoCoiThiVhu"/> class.</returns>
		public PMS.Entities.ThuLaoCoiThiVhu GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoCoiThiVhu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoCoiThiVhu"/> class.</returns>
		public abstract PMS.Entities.ThuLaoCoiThiVhu GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_ThuLaoCoiThiVhu_HuyChot 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThiVhu_HuyChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChot(System.String namHoc, System.String hocKy)
		{
			 HuyChot(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThiVhu_HuyChot' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoCoiThiVhu_HuyChot' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoCoiThiVhu_HuyChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void HuyChot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_ThuLaoCoiThiVhu_DongBo 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThiVhu_DongBo' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoCoiThiVhu_DongBo' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoCoiThiVhu_DongBo' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoCoiThiVhu_DongBo' stored procedure. 
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
		
		#region cust_ThuLaoCoiThiVhu_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThiVhu_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoCoiThiVhu_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoCoiThiVhu_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoCoiThiVhu_GetByNamHocHocKy' stored procedure. 
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
		
		#region cust_ThuLaoCoiThiVhu_Chot 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThiVhu_Chot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Chot(System.String namHoc, System.String hocKy)
		{
			 Chot(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThiVhu_Chot' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoCoiThiVhu_Chot' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoCoiThiVhu_Chot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Chot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_ThuLaoCoiThiVhu_KiemTraChot 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThiVhu_KiemTraChot' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoCoiThiVhu_KiemTraChot' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoCoiThiVhu_KiemTraChot' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoCoiThiVhu_KiemTraChot' stored procedure. 
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
		/// Fill a TList&lt;ThuLaoCoiThiVhu&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ThuLaoCoiThiVhu&gt;"/></returns>
		public static TList<ThuLaoCoiThiVhu> Fill(IDataReader reader, TList<ThuLaoCoiThiVhu> rows, int start, int pageLength)
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
				
				PMS.Entities.ThuLaoCoiThiVhu c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ThuLaoCoiThiVhu")
					.Append("|").Append((System.Int32)reader[((int)ThuLaoCoiThiVhuColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<ThuLaoCoiThiVhu>(
					key.ToString(), // EntityTrackingKey
					"ThuLaoCoiThiVhu",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.ThuLaoCoiThiVhu();
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
					c.Id = (System.Int32)reader[(ThuLaoCoiThiVhuColumn.Id.ToString())];
					c.NamHoc = (reader[ThuLaoCoiThiVhuColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiVhuColumn.NamHoc.ToString())];
					c.HocKy = (reader[ThuLaoCoiThiVhuColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiVhuColumn.HocKy.ToString())];
					c.MaGiangVienQuanLy = (reader[ThuLaoCoiThiVhuColumn.MaGiangVienQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiVhuColumn.MaGiangVienQuanLy.ToString())];
					c.LanThi = (reader[ThuLaoCoiThiVhuColumn.LanThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiVhuColumn.LanThi.ToString())];
					c.KyThi = (reader[ThuLaoCoiThiVhuColumn.KyThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiVhuColumn.KyThi.ToString())];
					c.SoBuoiCoiThi75 = (reader[ThuLaoCoiThiVhuColumn.SoBuoiCoiThi75.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiVhuColumn.SoBuoiCoiThi75.ToString())];
					c.ThuLaoCoiThi75 = (reader[ThuLaoCoiThiVhuColumn.ThuLaoCoiThi75.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiVhuColumn.ThuLaoCoiThi75.ToString())];
					c.SoBuoiCoiThi90 = (reader[ThuLaoCoiThiVhuColumn.SoBuoiCoiThi90.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiVhuColumn.SoBuoiCoiThi90.ToString())];
					c.ThuLaoCoiThi90 = (reader[ThuLaoCoiThiVhuColumn.ThuLaoCoiThi90.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiVhuColumn.ThuLaoCoiThi90.ToString())];
					c.SoBuoiCoiThi120 = (reader[ThuLaoCoiThiVhuColumn.SoBuoiCoiThi120.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiVhuColumn.SoBuoiCoiThi120.ToString())];
					c.ThuLaoCoiThi120 = (reader[ThuLaoCoiThiVhuColumn.ThuLaoCoiThi120.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiVhuColumn.ThuLaoCoiThi120.ToString())];
					c.TongCong = (reader[ThuLaoCoiThiVhuColumn.TongCong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiVhuColumn.TongCong.ToString())];
					c.HeSoQuyDoi = (reader[ThuLaoCoiThiVhuColumn.HeSoQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiVhuColumn.HeSoQuyDoi.ToString())];
					c.SoTietQuyDoi = (reader[ThuLaoCoiThiVhuColumn.SoTietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiVhuColumn.SoTietQuyDoi.ToString())];
					c.NgayCapNhat = (reader[ThuLaoCoiThiVhuColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiVhuColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[ThuLaoCoiThiVhuColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiVhuColumn.NguoiCapNhat.ToString())];
					c.Chot = (reader[ThuLaoCoiThiVhuColumn.Chot.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ThuLaoCoiThiVhuColumn.Chot.ToString())];
					c.MaLoaiGiangVien = (reader[ThuLaoCoiThiVhuColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiVhuColumn.MaLoaiGiangVien.ToString())];
					c.MaHocHam = (reader[ThuLaoCoiThiVhuColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiVhuColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[ThuLaoCoiThiVhuColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiVhuColumn.MaHocVi.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThuLaoCoiThiVhu"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoCoiThiVhu"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.ThuLaoCoiThiVhu entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(ThuLaoCoiThiVhuColumn.Id.ToString())];
			entity.NamHoc = (reader[ThuLaoCoiThiVhuColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiVhuColumn.NamHoc.ToString())];
			entity.HocKy = (reader[ThuLaoCoiThiVhuColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiVhuColumn.HocKy.ToString())];
			entity.MaGiangVienQuanLy = (reader[ThuLaoCoiThiVhuColumn.MaGiangVienQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiVhuColumn.MaGiangVienQuanLy.ToString())];
			entity.LanThi = (reader[ThuLaoCoiThiVhuColumn.LanThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiVhuColumn.LanThi.ToString())];
			entity.KyThi = (reader[ThuLaoCoiThiVhuColumn.KyThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiVhuColumn.KyThi.ToString())];
			entity.SoBuoiCoiThi75 = (reader[ThuLaoCoiThiVhuColumn.SoBuoiCoiThi75.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiVhuColumn.SoBuoiCoiThi75.ToString())];
			entity.ThuLaoCoiThi75 = (reader[ThuLaoCoiThiVhuColumn.ThuLaoCoiThi75.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiVhuColumn.ThuLaoCoiThi75.ToString())];
			entity.SoBuoiCoiThi90 = (reader[ThuLaoCoiThiVhuColumn.SoBuoiCoiThi90.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiVhuColumn.SoBuoiCoiThi90.ToString())];
			entity.ThuLaoCoiThi90 = (reader[ThuLaoCoiThiVhuColumn.ThuLaoCoiThi90.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiVhuColumn.ThuLaoCoiThi90.ToString())];
			entity.SoBuoiCoiThi120 = (reader[ThuLaoCoiThiVhuColumn.SoBuoiCoiThi120.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiVhuColumn.SoBuoiCoiThi120.ToString())];
			entity.ThuLaoCoiThi120 = (reader[ThuLaoCoiThiVhuColumn.ThuLaoCoiThi120.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiVhuColumn.ThuLaoCoiThi120.ToString())];
			entity.TongCong = (reader[ThuLaoCoiThiVhuColumn.TongCong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiVhuColumn.TongCong.ToString())];
			entity.HeSoQuyDoi = (reader[ThuLaoCoiThiVhuColumn.HeSoQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiVhuColumn.HeSoQuyDoi.ToString())];
			entity.SoTietQuyDoi = (reader[ThuLaoCoiThiVhuColumn.SoTietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiVhuColumn.SoTietQuyDoi.ToString())];
			entity.NgayCapNhat = (reader[ThuLaoCoiThiVhuColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiVhuColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[ThuLaoCoiThiVhuColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiVhuColumn.NguoiCapNhat.ToString())];
			entity.Chot = (reader[ThuLaoCoiThiVhuColumn.Chot.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ThuLaoCoiThiVhuColumn.Chot.ToString())];
			entity.MaLoaiGiangVien = (reader[ThuLaoCoiThiVhuColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiVhuColumn.MaLoaiGiangVien.ToString())];
			entity.MaHocHam = (reader[ThuLaoCoiThiVhuColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiVhuColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[ThuLaoCoiThiVhuColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiVhuColumn.MaHocVi.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThuLaoCoiThiVhu"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoCoiThiVhu"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.ThuLaoCoiThiVhu entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaGiangVienQuanLy = Convert.IsDBNull(dataRow["MaGiangVienQuanLy"]) ? null : (System.String)dataRow["MaGiangVienQuanLy"];
			entity.LanThi = Convert.IsDBNull(dataRow["LanThi"]) ? null : (System.String)dataRow["LanThi"];
			entity.KyThi = Convert.IsDBNull(dataRow["KyThi"]) ? null : (System.String)dataRow["KyThi"];
			entity.SoBuoiCoiThi75 = Convert.IsDBNull(dataRow["SoBuoiCoiThi75"]) ? null : (System.Int32?)dataRow["SoBuoiCoiThi75"];
			entity.ThuLaoCoiThi75 = Convert.IsDBNull(dataRow["ThuLaoCoiThi75"]) ? null : (System.Decimal?)dataRow["ThuLaoCoiThi75"];
			entity.SoBuoiCoiThi90 = Convert.IsDBNull(dataRow["SoBuoiCoiThi90"]) ? null : (System.Int32?)dataRow["SoBuoiCoiThi90"];
			entity.ThuLaoCoiThi90 = Convert.IsDBNull(dataRow["ThuLaoCoiThi90"]) ? null : (System.Decimal?)dataRow["ThuLaoCoiThi90"];
			entity.SoBuoiCoiThi120 = Convert.IsDBNull(dataRow["SoBuoiCoiThi120"]) ? null : (System.Int32?)dataRow["SoBuoiCoiThi120"];
			entity.ThuLaoCoiThi120 = Convert.IsDBNull(dataRow["ThuLaoCoiThi120"]) ? null : (System.Decimal?)dataRow["ThuLaoCoiThi120"];
			entity.TongCong = Convert.IsDBNull(dataRow["TongCong"]) ? null : (System.Decimal?)dataRow["TongCong"];
			entity.HeSoQuyDoi = Convert.IsDBNull(dataRow["HeSoQuyDoi"]) ? null : (System.Decimal?)dataRow["HeSoQuyDoi"];
			entity.SoTietQuyDoi = Convert.IsDBNull(dataRow["SoTietQuyDoi"]) ? null : (System.Decimal?)dataRow["SoTietQuyDoi"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.Chot = Convert.IsDBNull(dataRow["Chot"]) ? null : (System.Boolean?)dataRow["Chot"];
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
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoCoiThiVhu"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.ThuLaoCoiThiVhu Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.ThuLaoCoiThiVhu entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.ThuLaoCoiThiVhu object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.ThuLaoCoiThiVhu instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.ThuLaoCoiThiVhu Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.ThuLaoCoiThiVhu entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region ThuLaoCoiThiVhuChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.ThuLaoCoiThiVhu</c>
	///</summary>
	public enum ThuLaoCoiThiVhuChildEntityTypes
	{
	}
	
	#endregion ThuLaoCoiThiVhuChildEntityTypes
	
	#region ThuLaoCoiThiVhuFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ThuLaoCoiThiVhuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoCoiThiVhu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoCoiThiVhuFilterBuilder : SqlFilterBuilder<ThuLaoCoiThiVhuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiVhuFilterBuilder class.
		/// </summary>
		public ThuLaoCoiThiVhuFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiVhuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThuLaoCoiThiVhuFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiVhuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThuLaoCoiThiVhuFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThuLaoCoiThiVhuFilterBuilder
	
	#region ThuLaoCoiThiVhuParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ThuLaoCoiThiVhuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoCoiThiVhu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoCoiThiVhuParameterBuilder : ParameterizedSqlFilterBuilder<ThuLaoCoiThiVhuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiVhuParameterBuilder class.
		/// </summary>
		public ThuLaoCoiThiVhuParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiVhuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThuLaoCoiThiVhuParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiVhuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThuLaoCoiThiVhuParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThuLaoCoiThiVhuParameterBuilder
	
	#region ThuLaoCoiThiVhuSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ThuLaoCoiThiVhuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoCoiThiVhu"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ThuLaoCoiThiVhuSortBuilder : SqlSortBuilder<ThuLaoCoiThiVhuColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiVhuSqlSortBuilder class.
		/// </summary>
		public ThuLaoCoiThiVhuSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ThuLaoCoiThiVhuSortBuilder
	
} // end namespace
