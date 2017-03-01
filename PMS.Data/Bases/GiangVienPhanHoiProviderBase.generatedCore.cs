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
	/// This class is the base class for any <see cref="GiangVienPhanHoiProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GiangVienPhanHoiProviderBaseCore : EntityProviderBase<PMS.Entities.GiangVienPhanHoi, PMS.Entities.GiangVienPhanHoiKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.GiangVienPhanHoiKey key)
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
		public override PMS.Entities.GiangVienPhanHoi Get(TransactionManager transactionManager, PMS.Entities.GiangVienPhanHoiKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GiangVienPhanHoi index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienPhanHoi"/> class.</returns>
		public PMS.Entities.GiangVienPhanHoi GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVienPhanHoi index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienPhanHoi"/> class.</returns>
		public PMS.Entities.GiangVienPhanHoi GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVienPhanHoi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienPhanHoi"/> class.</returns>
		public PMS.Entities.GiangVienPhanHoi GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVienPhanHoi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienPhanHoi"/> class.</returns>
		public PMS.Entities.GiangVienPhanHoi GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVienPhanHoi index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienPhanHoi"/> class.</returns>
		public PMS.Entities.GiangVienPhanHoi GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVienPhanHoi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienPhanHoi"/> class.</returns>
		public abstract PMS.Entities.GiangVienPhanHoi GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_GiangVienPhanHoi_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienPhanHoi_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienPhanHoi&gt;"/> instance.</returns>
		public TList<GiangVienPhanHoi> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienPhanHoi_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienPhanHoi&gt;"/> instance.</returns>
		public TList<GiangVienPhanHoi> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVienPhanHoi_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienPhanHoi&gt;"/> instance.</returns>
		public TList<GiangVienPhanHoi> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienPhanHoi_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienPhanHoi&gt;"/> instance.</returns>
		public abstract TList<GiangVienPhanHoi> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_GiangVienPhanHoi_GetTraLoi 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienPhanHoi_GetTraLoi' stored procedure. 
		/// </summary>
		/// <param name="maGiangVienQuanLy"> A <c>System.String</c> instance.</param>
			/// <param name="traLoi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetTraLoi(System.String maGiangVienQuanLy, ref System.String traLoi)
		{
			 GetTraLoi(null, 0, int.MaxValue , maGiangVienQuanLy, ref traLoi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienPhanHoi_GetTraLoi' stored procedure. 
		/// </summary>
		/// <param name="maGiangVienQuanLy"> A <c>System.String</c> instance.</param>
			/// <param name="traLoi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetTraLoi(int start, int pageLength, System.String maGiangVienQuanLy, ref System.String traLoi)
		{
			 GetTraLoi(null, start, pageLength , maGiangVienQuanLy, ref traLoi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVienPhanHoi_GetTraLoi' stored procedure. 
		/// </summary>
		/// <param name="maGiangVienQuanLy"> A <c>System.String</c> instance.</param>
			/// <param name="traLoi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetTraLoi(TransactionManager transactionManager, System.String maGiangVienQuanLy, ref System.String traLoi)
		{
			 GetTraLoi(transactionManager, 0, int.MaxValue , maGiangVienQuanLy, ref traLoi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienPhanHoi_GetTraLoi' stored procedure. 
		/// </summary>
		/// <param name="maGiangVienQuanLy"> A <c>System.String</c> instance.</param>
			/// <param name="traLoi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetTraLoi(TransactionManager transactionManager, int start, int pageLength , System.String maGiangVienQuanLy, ref System.String traLoi);
		
		#endregion
		
		#region cust_GiangVienPhanHoi_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienPhanHoi_Luu' stored procedure. 
		/// </summary>
		/// <param name="maGiangVienQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="hoTen"> A <c>System.String</c> instance.</param>
		/// <param name="noiDungPhanHoi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String maGiangVienQuanLy, System.String hoTen, System.String noiDungPhanHoi)
		{
			 Luu(null, 0, int.MaxValue , maGiangVienQuanLy, hoTen, noiDungPhanHoi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienPhanHoi_Luu' stored procedure. 
		/// </summary>
		/// <param name="maGiangVienQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="hoTen"> A <c>System.String</c> instance.</param>
		/// <param name="noiDungPhanHoi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String maGiangVienQuanLy, System.String hoTen, System.String noiDungPhanHoi)
		{
			 Luu(null, start, pageLength , maGiangVienQuanLy, hoTen, noiDungPhanHoi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVienPhanHoi_Luu' stored procedure. 
		/// </summary>
		/// <param name="maGiangVienQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="hoTen"> A <c>System.String</c> instance.</param>
		/// <param name="noiDungPhanHoi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String maGiangVienQuanLy, System.String hoTen, System.String noiDungPhanHoi)
		{
			 Luu(transactionManager, 0, int.MaxValue , maGiangVienQuanLy, hoTen, noiDungPhanHoi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienPhanHoi_Luu' stored procedure. 
		/// </summary>
		/// <param name="maGiangVienQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="hoTen"> A <c>System.String</c> instance.</param>
		/// <param name="noiDungPhanHoi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String maGiangVienQuanLy, System.String hoTen, System.String noiDungPhanHoi);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GiangVienPhanHoi&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GiangVienPhanHoi&gt;"/></returns>
		public static TList<GiangVienPhanHoi> Fill(IDataReader reader, TList<GiangVienPhanHoi> rows, int start, int pageLength)
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
				
				PMS.Entities.GiangVienPhanHoi c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GiangVienPhanHoi")
					.Append("|").Append((System.Int32)reader[((int)GiangVienPhanHoiColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<GiangVienPhanHoi>(
					key.ToString(), // EntityTrackingKey
					"GiangVienPhanHoi",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.GiangVienPhanHoi();
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
					c.Id = (System.Int32)reader[(GiangVienPhanHoiColumn.Id.ToString())];
					c.NamHoc = (reader[GiangVienPhanHoiColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienPhanHoiColumn.NamHoc.ToString())];
					c.HocKy = (reader[GiangVienPhanHoiColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienPhanHoiColumn.HocKy.ToString())];
					c.MaGiangVienQuanLy = (reader[GiangVienPhanHoiColumn.MaGiangVienQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienPhanHoiColumn.MaGiangVienQuanLy.ToString())];
					c.HoTen = (reader[GiangVienPhanHoiColumn.HoTen.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienPhanHoiColumn.HoTen.ToString())];
					c.NoiDungPhanHoi = (reader[GiangVienPhanHoiColumn.NoiDungPhanHoi.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienPhanHoiColumn.NoiDungPhanHoi.ToString())];
					c.TraLoiPhanHoi = (reader[GiangVienPhanHoiColumn.TraLoiPhanHoi.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienPhanHoiColumn.TraLoiPhanHoi.ToString())];
					c.NgayPhanHoi = (reader[GiangVienPhanHoiColumn.NgayPhanHoi.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienPhanHoiColumn.NgayPhanHoi.ToString())];
					c.NgayTraLoi = (reader[GiangVienPhanHoiColumn.NgayTraLoi.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienPhanHoiColumn.NgayTraLoi.ToString())];
					c.NguoiTraLoi = (reader[GiangVienPhanHoiColumn.NguoiTraLoi.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienPhanHoiColumn.NguoiTraLoi.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienPhanHoi"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienPhanHoi"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.GiangVienPhanHoi entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(GiangVienPhanHoiColumn.Id.ToString())];
			entity.NamHoc = (reader[GiangVienPhanHoiColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienPhanHoiColumn.NamHoc.ToString())];
			entity.HocKy = (reader[GiangVienPhanHoiColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienPhanHoiColumn.HocKy.ToString())];
			entity.MaGiangVienQuanLy = (reader[GiangVienPhanHoiColumn.MaGiangVienQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienPhanHoiColumn.MaGiangVienQuanLy.ToString())];
			entity.HoTen = (reader[GiangVienPhanHoiColumn.HoTen.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienPhanHoiColumn.HoTen.ToString())];
			entity.NoiDungPhanHoi = (reader[GiangVienPhanHoiColumn.NoiDungPhanHoi.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienPhanHoiColumn.NoiDungPhanHoi.ToString())];
			entity.TraLoiPhanHoi = (reader[GiangVienPhanHoiColumn.TraLoiPhanHoi.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienPhanHoiColumn.TraLoiPhanHoi.ToString())];
			entity.NgayPhanHoi = (reader[GiangVienPhanHoiColumn.NgayPhanHoi.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienPhanHoiColumn.NgayPhanHoi.ToString())];
			entity.NgayTraLoi = (reader[GiangVienPhanHoiColumn.NgayTraLoi.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienPhanHoiColumn.NgayTraLoi.ToString())];
			entity.NguoiTraLoi = (reader[GiangVienPhanHoiColumn.NguoiTraLoi.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienPhanHoiColumn.NguoiTraLoi.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienPhanHoi"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienPhanHoi"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.GiangVienPhanHoi entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaGiangVienQuanLy = Convert.IsDBNull(dataRow["MaGiangVienQuanLy"]) ? null : (System.String)dataRow["MaGiangVienQuanLy"];
			entity.HoTen = Convert.IsDBNull(dataRow["HoTen"]) ? null : (System.String)dataRow["HoTen"];
			entity.NoiDungPhanHoi = Convert.IsDBNull(dataRow["NoiDungPhanHoi"]) ? null : (System.String)dataRow["NoiDungPhanHoi"];
			entity.TraLoiPhanHoi = Convert.IsDBNull(dataRow["TraLoiPhanHoi"]) ? null : (System.String)dataRow["TraLoiPhanHoi"];
			entity.NgayPhanHoi = Convert.IsDBNull(dataRow["NgayPhanHoi"]) ? null : (System.DateTime?)dataRow["NgayPhanHoi"];
			entity.NgayTraLoi = Convert.IsDBNull(dataRow["NgayTraLoi"]) ? null : (System.DateTime?)dataRow["NgayTraLoi"];
			entity.NguoiTraLoi = Convert.IsDBNull(dataRow["NguoiTraLoi"]) ? null : (System.String)dataRow["NguoiTraLoi"];
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
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienPhanHoi"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienPhanHoi Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.GiangVienPhanHoi entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.GiangVienPhanHoi object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.GiangVienPhanHoi instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienPhanHoi Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.GiangVienPhanHoi entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region GiangVienPhanHoiChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.GiangVienPhanHoi</c>
	///</summary>
	public enum GiangVienPhanHoiChildEntityTypes
	{
	}
	
	#endregion GiangVienPhanHoiChildEntityTypes
	
	#region GiangVienPhanHoiFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GiangVienPhanHoiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienPhanHoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienPhanHoiFilterBuilder : SqlFilterBuilder<GiangVienPhanHoiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienPhanHoiFilterBuilder class.
		/// </summary>
		public GiangVienPhanHoiFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienPhanHoiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienPhanHoiFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienPhanHoiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienPhanHoiFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienPhanHoiFilterBuilder
	
	#region GiangVienPhanHoiParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GiangVienPhanHoiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienPhanHoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienPhanHoiParameterBuilder : ParameterizedSqlFilterBuilder<GiangVienPhanHoiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienPhanHoiParameterBuilder class.
		/// </summary>
		public GiangVienPhanHoiParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienPhanHoiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienPhanHoiParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienPhanHoiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienPhanHoiParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienPhanHoiParameterBuilder
	
	#region GiangVienPhanHoiSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GiangVienPhanHoiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienPhanHoi"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GiangVienPhanHoiSortBuilder : SqlSortBuilder<GiangVienPhanHoiColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienPhanHoiSqlSortBuilder class.
		/// </summary>
		public GiangVienPhanHoiSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GiangVienPhanHoiSortBuilder
	
} // end namespace
