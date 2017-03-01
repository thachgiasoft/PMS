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
	/// This class is the base class for any <see cref="LopHocPhanGhepThoiKhoaBieuProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class LopHocPhanGhepThoiKhoaBieuProviderBaseCore : EntityProviderBase<PMS.Entities.LopHocPhanGhepThoiKhoaBieu, PMS.Entities.LopHocPhanGhepThoiKhoaBieuKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.LopHocPhanGhepThoiKhoaBieuKey key)
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
		public override PMS.Entities.LopHocPhanGhepThoiKhoaBieu Get(TransactionManager transactionManager, PMS.Entities.LopHocPhanGhepThoiKhoaBieuKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_LopHocPhanGhepThoiKhoaBieu index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanGhepThoiKhoaBieu"/> class.</returns>
		public PMS.Entities.LopHocPhanGhepThoiKhoaBieu GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LopHocPhanGhepThoiKhoaBieu index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanGhepThoiKhoaBieu"/> class.</returns>
		public PMS.Entities.LopHocPhanGhepThoiKhoaBieu GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LopHocPhanGhepThoiKhoaBieu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanGhepThoiKhoaBieu"/> class.</returns>
		public PMS.Entities.LopHocPhanGhepThoiKhoaBieu GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LopHocPhanGhepThoiKhoaBieu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanGhepThoiKhoaBieu"/> class.</returns>
		public PMS.Entities.LopHocPhanGhepThoiKhoaBieu GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LopHocPhanGhepThoiKhoaBieu index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanGhepThoiKhoaBieu"/> class.</returns>
		public PMS.Entities.LopHocPhanGhepThoiKhoaBieu GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LopHocPhanGhepThoiKhoaBieu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanGhepThoiKhoaBieu"/> class.</returns>
		public abstract PMS.Entities.LopHocPhanGhepThoiKhoaBieu GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_LopHocPhanGhepThoiKhoaBieu_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanGhepThoiKhoaBieu_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_LopHocPhanGhepThoiKhoaBieu_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_LopHocPhanGhepThoiKhoaBieu_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_LopHocPhanGhepThoiKhoaBieu_GetByNamHocHocKy' stored procedure. 
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
		
		#region cust_LopHocPhanGhepThoiKhoaBieu_KiemTra 
		
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanGhepThoiKhoaBieu_KiemTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTra(System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 KiemTra(null, 0, int.MaxValue , namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanGhepThoiKhoaBieu_KiemTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTra(int start, int pageLength, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 KiemTra(null, start, pageLength , namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanGhepThoiKhoaBieu_KiemTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTra(TransactionManager transactionManager, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 KiemTra(transactionManager, 0, int.MaxValue , namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanGhepThoiKhoaBieu_KiemTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void KiemTra(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_LopHocPhanGhepThoiKhoaBieu_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanGhepThoiKhoaBieu_Luu' stored procedure. 
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
		///	This method wrap the 'cust_LopHocPhanGhepThoiKhoaBieu_Luu' stored procedure. 
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
		///	This method wrap the 'cust_LopHocPhanGhepThoiKhoaBieu_Luu' stored procedure. 
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
		///	This method wrap the 'cust_LopHocPhanGhepThoiKhoaBieu_Luu' stored procedure. 
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
		
		#region cust_LopHocPhanGhepThoiKhoaBieu_LayDuLieu 
		
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanGhepThoiKhoaBieu_LayDuLieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LayDuLieu(System.String namHoc, System.String hocKy)
		{
			 LayDuLieu(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanGhepThoiKhoaBieu_LayDuLieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LayDuLieu(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			 LayDuLieu(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanGhepThoiKhoaBieu_LayDuLieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LayDuLieu(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			 LayDuLieu(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanGhepThoiKhoaBieu_LayDuLieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LayDuLieu(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;LopHocPhanGhepThoiKhoaBieu&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;LopHocPhanGhepThoiKhoaBieu&gt;"/></returns>
		public static TList<LopHocPhanGhepThoiKhoaBieu> Fill(IDataReader reader, TList<LopHocPhanGhepThoiKhoaBieu> rows, int start, int pageLength)
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
				
				PMS.Entities.LopHocPhanGhepThoiKhoaBieu c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("LopHocPhanGhepThoiKhoaBieu")
					.Append("|").Append((System.Int32)reader[((int)LopHocPhanGhepThoiKhoaBieuColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<LopHocPhanGhepThoiKhoaBieu>(
					key.ToString(), // EntityTrackingKey
					"LopHocPhanGhepThoiKhoaBieu",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.LopHocPhanGhepThoiKhoaBieu();
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
					c.Id = (System.Int32)reader[(LopHocPhanGhepThoiKhoaBieuColumn.Id.ToString())];
					c.SoThuTu = (reader[LopHocPhanGhepThoiKhoaBieuColumn.SoThuTu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(LopHocPhanGhepThoiKhoaBieuColumn.SoThuTu.ToString())];
					c.MaLopHocPhan = (reader[LopHocPhanGhepThoiKhoaBieuColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(LopHocPhanGhepThoiKhoaBieuColumn.MaLopHocPhan.ToString())];
					c.MaCanBoGiangDay = (reader[LopHocPhanGhepThoiKhoaBieuColumn.MaCanBoGiangDay.ToString()] == DBNull.Value) ? null : (System.String)reader[(LopHocPhanGhepThoiKhoaBieuColumn.MaCanBoGiangDay.ToString())];
					c.MaMonHoc = (reader[LopHocPhanGhepThoiKhoaBieuColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(LopHocPhanGhepThoiKhoaBieuColumn.MaMonHoc.ToString())];
					c.TenMonHoc = (reader[LopHocPhanGhepThoiKhoaBieuColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(LopHocPhanGhepThoiKhoaBieuColumn.TenMonHoc.ToString())];
					c.MaBacDaoTao = (reader[LopHocPhanGhepThoiKhoaBieuColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(LopHocPhanGhepThoiKhoaBieuColumn.MaBacDaoTao.ToString())];
					c.SiSoTruocGhep = (reader[LopHocPhanGhepThoiKhoaBieuColumn.SiSoTruocGhep.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(LopHocPhanGhepThoiKhoaBieuColumn.SiSoTruocGhep.ToString())];
					c.SiSoSauGhep = (reader[LopHocPhanGhepThoiKhoaBieuColumn.SiSoSauGhep.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(LopHocPhanGhepThoiKhoaBieuColumn.SiSoSauGhep.ToString())];
					c.MaLopTruocGhep = (reader[LopHocPhanGhepThoiKhoaBieuColumn.MaLopTruocGhep.ToString()] == DBNull.Value) ? null : (System.String)reader[(LopHocPhanGhepThoiKhoaBieuColumn.MaLopTruocGhep.ToString())];
					c.MaLopSauGhep = (reader[LopHocPhanGhepThoiKhoaBieuColumn.MaLopSauGhep.ToString()] == DBNull.Value) ? null : (System.String)reader[(LopHocPhanGhepThoiKhoaBieuColumn.MaLopSauGhep.ToString())];
					c.LopChinh = (reader[LopHocPhanGhepThoiKhoaBieuColumn.LopChinh.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(LopHocPhanGhepThoiKhoaBieuColumn.LopChinh.ToString())];
					c.NamHoc = (reader[LopHocPhanGhepThoiKhoaBieuColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(LopHocPhanGhepThoiKhoaBieuColumn.NamHoc.ToString())];
					c.HocKy = (reader[LopHocPhanGhepThoiKhoaBieuColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(LopHocPhanGhepThoiKhoaBieuColumn.HocKy.ToString())];
					c.NgayCapNhat = (reader[LopHocPhanGhepThoiKhoaBieuColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(LopHocPhanGhepThoiKhoaBieuColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[LopHocPhanGhepThoiKhoaBieuColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(LopHocPhanGhepThoiKhoaBieuColumn.NguoiCapNhat.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.LopHocPhanGhepThoiKhoaBieu"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.LopHocPhanGhepThoiKhoaBieu"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.LopHocPhanGhepThoiKhoaBieu entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(LopHocPhanGhepThoiKhoaBieuColumn.Id.ToString())];
			entity.SoThuTu = (reader[LopHocPhanGhepThoiKhoaBieuColumn.SoThuTu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(LopHocPhanGhepThoiKhoaBieuColumn.SoThuTu.ToString())];
			entity.MaLopHocPhan = (reader[LopHocPhanGhepThoiKhoaBieuColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(LopHocPhanGhepThoiKhoaBieuColumn.MaLopHocPhan.ToString())];
			entity.MaCanBoGiangDay = (reader[LopHocPhanGhepThoiKhoaBieuColumn.MaCanBoGiangDay.ToString()] == DBNull.Value) ? null : (System.String)reader[(LopHocPhanGhepThoiKhoaBieuColumn.MaCanBoGiangDay.ToString())];
			entity.MaMonHoc = (reader[LopHocPhanGhepThoiKhoaBieuColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(LopHocPhanGhepThoiKhoaBieuColumn.MaMonHoc.ToString())];
			entity.TenMonHoc = (reader[LopHocPhanGhepThoiKhoaBieuColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(LopHocPhanGhepThoiKhoaBieuColumn.TenMonHoc.ToString())];
			entity.MaBacDaoTao = (reader[LopHocPhanGhepThoiKhoaBieuColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(LopHocPhanGhepThoiKhoaBieuColumn.MaBacDaoTao.ToString())];
			entity.SiSoTruocGhep = (reader[LopHocPhanGhepThoiKhoaBieuColumn.SiSoTruocGhep.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(LopHocPhanGhepThoiKhoaBieuColumn.SiSoTruocGhep.ToString())];
			entity.SiSoSauGhep = (reader[LopHocPhanGhepThoiKhoaBieuColumn.SiSoSauGhep.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(LopHocPhanGhepThoiKhoaBieuColumn.SiSoSauGhep.ToString())];
			entity.MaLopTruocGhep = (reader[LopHocPhanGhepThoiKhoaBieuColumn.MaLopTruocGhep.ToString()] == DBNull.Value) ? null : (System.String)reader[(LopHocPhanGhepThoiKhoaBieuColumn.MaLopTruocGhep.ToString())];
			entity.MaLopSauGhep = (reader[LopHocPhanGhepThoiKhoaBieuColumn.MaLopSauGhep.ToString()] == DBNull.Value) ? null : (System.String)reader[(LopHocPhanGhepThoiKhoaBieuColumn.MaLopSauGhep.ToString())];
			entity.LopChinh = (reader[LopHocPhanGhepThoiKhoaBieuColumn.LopChinh.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(LopHocPhanGhepThoiKhoaBieuColumn.LopChinh.ToString())];
			entity.NamHoc = (reader[LopHocPhanGhepThoiKhoaBieuColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(LopHocPhanGhepThoiKhoaBieuColumn.NamHoc.ToString())];
			entity.HocKy = (reader[LopHocPhanGhepThoiKhoaBieuColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(LopHocPhanGhepThoiKhoaBieuColumn.HocKy.ToString())];
			entity.NgayCapNhat = (reader[LopHocPhanGhepThoiKhoaBieuColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(LopHocPhanGhepThoiKhoaBieuColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[LopHocPhanGhepThoiKhoaBieuColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(LopHocPhanGhepThoiKhoaBieuColumn.NguoiCapNhat.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.LopHocPhanGhepThoiKhoaBieu"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.LopHocPhanGhepThoiKhoaBieu"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.LopHocPhanGhepThoiKhoaBieu entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.SoThuTu = Convert.IsDBNull(dataRow["SoThuTu"]) ? null : (System.Int32?)dataRow["SoThuTu"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.MaCanBoGiangDay = Convert.IsDBNull(dataRow["MaCanBoGiangDay"]) ? null : (System.String)dataRow["MaCanBoGiangDay"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = Convert.IsDBNull(dataRow["TenMonHoc"]) ? null : (System.String)dataRow["TenMonHoc"];
			entity.MaBacDaoTao = Convert.IsDBNull(dataRow["MaBacDaoTao"]) ? null : (System.String)dataRow["MaBacDaoTao"];
			entity.SiSoTruocGhep = Convert.IsDBNull(dataRow["SiSoTruocGhep"]) ? null : (System.Int32?)dataRow["SiSoTruocGhep"];
			entity.SiSoSauGhep = Convert.IsDBNull(dataRow["SiSoSauGhep"]) ? null : (System.Int32?)dataRow["SiSoSauGhep"];
			entity.MaLopTruocGhep = Convert.IsDBNull(dataRow["MaLopTruocGhep"]) ? null : (System.String)dataRow["MaLopTruocGhep"];
			entity.MaLopSauGhep = Convert.IsDBNull(dataRow["MaLopSauGhep"]) ? null : (System.String)dataRow["MaLopSauGhep"];
			entity.LopChinh = Convert.IsDBNull(dataRow["LopChinh"]) ? null : (System.Boolean?)dataRow["LopChinh"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
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
		/// <param name="entity">The <see cref="PMS.Entities.LopHocPhanGhepThoiKhoaBieu"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.LopHocPhanGhepThoiKhoaBieu Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.LopHocPhanGhepThoiKhoaBieu entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.LopHocPhanGhepThoiKhoaBieu object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.LopHocPhanGhepThoiKhoaBieu instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.LopHocPhanGhepThoiKhoaBieu Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.LopHocPhanGhepThoiKhoaBieu entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region LopHocPhanGhepThoiKhoaBieuChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.LopHocPhanGhepThoiKhoaBieu</c>
	///</summary>
	public enum LopHocPhanGhepThoiKhoaBieuChildEntityTypes
	{
	}
	
	#endregion LopHocPhanGhepThoiKhoaBieuChildEntityTypes
	
	#region LopHocPhanGhepThoiKhoaBieuFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;LopHocPhanGhepThoiKhoaBieuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanGhepThoiKhoaBieu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LopHocPhanGhepThoiKhoaBieuFilterBuilder : SqlFilterBuilder<LopHocPhanGhepThoiKhoaBieuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LopHocPhanGhepThoiKhoaBieuFilterBuilder class.
		/// </summary>
		public LopHocPhanGhepThoiKhoaBieuFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the LopHocPhanGhepThoiKhoaBieuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LopHocPhanGhepThoiKhoaBieuFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LopHocPhanGhepThoiKhoaBieuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LopHocPhanGhepThoiKhoaBieuFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LopHocPhanGhepThoiKhoaBieuFilterBuilder
	
	#region LopHocPhanGhepThoiKhoaBieuParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;LopHocPhanGhepThoiKhoaBieuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanGhepThoiKhoaBieu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LopHocPhanGhepThoiKhoaBieuParameterBuilder : ParameterizedSqlFilterBuilder<LopHocPhanGhepThoiKhoaBieuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LopHocPhanGhepThoiKhoaBieuParameterBuilder class.
		/// </summary>
		public LopHocPhanGhepThoiKhoaBieuParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the LopHocPhanGhepThoiKhoaBieuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LopHocPhanGhepThoiKhoaBieuParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LopHocPhanGhepThoiKhoaBieuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LopHocPhanGhepThoiKhoaBieuParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LopHocPhanGhepThoiKhoaBieuParameterBuilder
	
	#region LopHocPhanGhepThoiKhoaBieuSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;LopHocPhanGhepThoiKhoaBieuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanGhepThoiKhoaBieu"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class LopHocPhanGhepThoiKhoaBieuSortBuilder : SqlSortBuilder<LopHocPhanGhepThoiKhoaBieuColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LopHocPhanGhepThoiKhoaBieuSqlSortBuilder class.
		/// </summary>
		public LopHocPhanGhepThoiKhoaBieuSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion LopHocPhanGhepThoiKhoaBieuSortBuilder
	
} // end namespace
