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
	/// This class is the base class for any <see cref="GiangVienThanhToanQuaNganHangProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GiangVienThanhToanQuaNganHangProviderBaseCore : EntityProviderBase<PMS.Entities.GiangVienThanhToanQuaNganHang, PMS.Entities.GiangVienThanhToanQuaNganHangKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.GiangVienThanhToanQuaNganHangKey key)
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
		public override PMS.Entities.GiangVienThanhToanQuaNganHang Get(TransactionManager transactionManager, PMS.Entities.GiangVienThanhToanQuaNganHangKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK__GiangVie__3214EC07579890A4 index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienThanhToanQuaNganHang"/> class.</returns>
		public PMS.Entities.GiangVienThanhToanQuaNganHang GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__GiangVie__3214EC07579890A4 index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienThanhToanQuaNganHang"/> class.</returns>
		public PMS.Entities.GiangVienThanhToanQuaNganHang GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__GiangVie__3214EC07579890A4 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienThanhToanQuaNganHang"/> class.</returns>
		public PMS.Entities.GiangVienThanhToanQuaNganHang GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__GiangVie__3214EC07579890A4 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienThanhToanQuaNganHang"/> class.</returns>
		public PMS.Entities.GiangVienThanhToanQuaNganHang GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__GiangVie__3214EC07579890A4 index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienThanhToanQuaNganHang"/> class.</returns>
		public PMS.Entities.GiangVienThanhToanQuaNganHang GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__GiangVie__3214EC07579890A4 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienThanhToanQuaNganHang"/> class.</returns>
		public abstract PMS.Entities.GiangVienThanhToanQuaNganHang GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_GiangVienThanhToanQuaNganHang_GetByNamHocHocKyDonViBacDaoTaoLanChot 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienThanhToanQuaNganHang_GetByNamHocHocKyDonViBacDaoTaoLanChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyDonViBacDaoTaoLanChot(System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.Int32 lanChot)
		{
			return GetByNamHocHocKyDonViBacDaoTaoLanChot(null, 0, int.MaxValue , namHoc, hocKy, maDonVi, maBacDaoTao, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienThanhToanQuaNganHang_GetByNamHocHocKyDonViBacDaoTaoLanChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyDonViBacDaoTaoLanChot(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.Int32 lanChot)
		{
			return GetByNamHocHocKyDonViBacDaoTaoLanChot(null, start, pageLength , namHoc, hocKy, maDonVi, maBacDaoTao, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVienThanhToanQuaNganHang_GetByNamHocHocKyDonViBacDaoTaoLanChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyDonViBacDaoTaoLanChot(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.Int32 lanChot)
		{
			return GetByNamHocHocKyDonViBacDaoTaoLanChot(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi, maBacDaoTao, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienThanhToanQuaNganHang_GetByNamHocHocKyDonViBacDaoTaoLanChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKyDonViBacDaoTaoLanChot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi, System.String maBacDaoTao, System.Int32 lanChot);
		
		#endregion
		
		#region cust_GiangVienThanhToanQuaNganHang_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienThanhToanQuaNganHang_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_GiangVienThanhToanQuaNganHang_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_GiangVienThanhToanQuaNganHang_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_GiangVienThanhToanQuaNganHang_GetByNamHocHocKy' stored procedure. 
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
		
		#region cust_GiangVienThanhToanQuaNganHang_LuuThayDoi 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienThanhToanQuaNganHang_LuuThayDoi' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuThayDoi(System.String xmlData, ref System.Int32 reVal)
		{
			 LuuThayDoi(null, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienThanhToanQuaNganHang_LuuThayDoi' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuThayDoi(int start, int pageLength, System.String xmlData, ref System.Int32 reVal)
		{
			 LuuThayDoi(null, start, pageLength , xmlData, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVienThanhToanQuaNganHang_LuuThayDoi' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuThayDoi(TransactionManager transactionManager, System.String xmlData, ref System.Int32 reVal)
		{
			 LuuThayDoi(transactionManager, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienThanhToanQuaNganHang_LuuThayDoi' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LuuThayDoi(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GiangVienThanhToanQuaNganHang&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GiangVienThanhToanQuaNganHang&gt;"/></returns>
		public static TList<GiangVienThanhToanQuaNganHang> Fill(IDataReader reader, TList<GiangVienThanhToanQuaNganHang> rows, int start, int pageLength)
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
				
				PMS.Entities.GiangVienThanhToanQuaNganHang c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GiangVienThanhToanQuaNganHang")
					.Append("|").Append((System.Int32)reader[((int)GiangVienThanhToanQuaNganHangColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<GiangVienThanhToanQuaNganHang>(
					key.ToString(), // EntityTrackingKey
					"GiangVienThanhToanQuaNganHang",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.GiangVienThanhToanQuaNganHang();
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
					c.Id = (System.Int32)reader[(GiangVienThanhToanQuaNganHangColumn.Id.ToString())];
					c.MaGiangVien = (reader[GiangVienThanhToanQuaNganHangColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienThanhToanQuaNganHangColumn.MaGiangVien.ToString())];
					c.ChiuPhiChuyen = (reader[GiangVienThanhToanQuaNganHangColumn.ChiuPhiChuyen.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienThanhToanQuaNganHangColumn.ChiuPhiChuyen.ToString())];
					c.NamHoc = (reader[GiangVienThanhToanQuaNganHangColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienThanhToanQuaNganHangColumn.NamHoc.ToString())];
					c.HocKy = (reader[GiangVienThanhToanQuaNganHangColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienThanhToanQuaNganHangColumn.HocKy.ToString())];
					c.GhiChu = (reader[GiangVienThanhToanQuaNganHangColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienThanhToanQuaNganHangColumn.GhiChu.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienThanhToanQuaNganHang"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienThanhToanQuaNganHang"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.GiangVienThanhToanQuaNganHang entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(GiangVienThanhToanQuaNganHangColumn.Id.ToString())];
			entity.MaGiangVien = (reader[GiangVienThanhToanQuaNganHangColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienThanhToanQuaNganHangColumn.MaGiangVien.ToString())];
			entity.ChiuPhiChuyen = (reader[GiangVienThanhToanQuaNganHangColumn.ChiuPhiChuyen.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienThanhToanQuaNganHangColumn.ChiuPhiChuyen.ToString())];
			entity.NamHoc = (reader[GiangVienThanhToanQuaNganHangColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienThanhToanQuaNganHangColumn.NamHoc.ToString())];
			entity.HocKy = (reader[GiangVienThanhToanQuaNganHangColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienThanhToanQuaNganHangColumn.HocKy.ToString())];
			entity.GhiChu = (reader[GiangVienThanhToanQuaNganHangColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienThanhToanQuaNganHangColumn.GhiChu.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienThanhToanQuaNganHang"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienThanhToanQuaNganHang"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.GiangVienThanhToanQuaNganHang entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.Int32?)dataRow["MaGiangVien"];
			entity.ChiuPhiChuyen = Convert.IsDBNull(dataRow["ChiuPhiChuyen"]) ? null : (System.Decimal?)dataRow["ChiuPhiChuyen"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
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
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienThanhToanQuaNganHang"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienThanhToanQuaNganHang Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.GiangVienThanhToanQuaNganHang entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.GiangVienThanhToanQuaNganHang object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.GiangVienThanhToanQuaNganHang instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienThanhToanQuaNganHang Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.GiangVienThanhToanQuaNganHang entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region GiangVienThanhToanQuaNganHangChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.GiangVienThanhToanQuaNganHang</c>
	///</summary>
	public enum GiangVienThanhToanQuaNganHangChildEntityTypes
	{
	}
	
	#endregion GiangVienThanhToanQuaNganHangChildEntityTypes
	
	#region GiangVienThanhToanQuaNganHangFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GiangVienThanhToanQuaNganHangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienThanhToanQuaNganHang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienThanhToanQuaNganHangFilterBuilder : SqlFilterBuilder<GiangVienThanhToanQuaNganHangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienThanhToanQuaNganHangFilterBuilder class.
		/// </summary>
		public GiangVienThanhToanQuaNganHangFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienThanhToanQuaNganHangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienThanhToanQuaNganHangFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienThanhToanQuaNganHangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienThanhToanQuaNganHangFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienThanhToanQuaNganHangFilterBuilder
	
	#region GiangVienThanhToanQuaNganHangParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GiangVienThanhToanQuaNganHangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienThanhToanQuaNganHang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienThanhToanQuaNganHangParameterBuilder : ParameterizedSqlFilterBuilder<GiangVienThanhToanQuaNganHangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienThanhToanQuaNganHangParameterBuilder class.
		/// </summary>
		public GiangVienThanhToanQuaNganHangParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienThanhToanQuaNganHangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienThanhToanQuaNganHangParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienThanhToanQuaNganHangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienThanhToanQuaNganHangParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienThanhToanQuaNganHangParameterBuilder
	
	#region GiangVienThanhToanQuaNganHangSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GiangVienThanhToanQuaNganHangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienThanhToanQuaNganHang"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GiangVienThanhToanQuaNganHangSortBuilder : SqlSortBuilder<GiangVienThanhToanQuaNganHangColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienThanhToanQuaNganHangSqlSortBuilder class.
		/// </summary>
		public GiangVienThanhToanQuaNganHangSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GiangVienThanhToanQuaNganHangSortBuilder
	
} // end namespace
