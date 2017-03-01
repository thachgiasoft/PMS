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
	/// This class is the base class for any <see cref="SdhMonPhanCongNhieuGiangVienProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SdhMonPhanCongNhieuGiangVienProviderBaseCore : EntityProviderBase<PMS.Entities.SdhMonPhanCongNhieuGiangVien, PMS.Entities.SdhMonPhanCongNhieuGiangVienKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.SdhMonPhanCongNhieuGiangVienKey key)
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
		public override PMS.Entities.SdhMonPhanCongNhieuGiangVien Get(TransactionManager transactionManager, PMS.Entities.SdhMonPhanCongNhieuGiangVienKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SdhMonPhanCongNhieuGiangVien index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhMonPhanCongNhieuGiangVien"/> class.</returns>
		public PMS.Entities.SdhMonPhanCongNhieuGiangVien GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SdhMonPhanCongNhieuGiangVien index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhMonPhanCongNhieuGiangVien"/> class.</returns>
		public PMS.Entities.SdhMonPhanCongNhieuGiangVien GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SdhMonPhanCongNhieuGiangVien index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhMonPhanCongNhieuGiangVien"/> class.</returns>
		public PMS.Entities.SdhMonPhanCongNhieuGiangVien GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SdhMonPhanCongNhieuGiangVien index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhMonPhanCongNhieuGiangVien"/> class.</returns>
		public PMS.Entities.SdhMonPhanCongNhieuGiangVien GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SdhMonPhanCongNhieuGiangVien index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhMonPhanCongNhieuGiangVien"/> class.</returns>
		public PMS.Entities.SdhMonPhanCongNhieuGiangVien GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SdhMonPhanCongNhieuGiangVien index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhMonPhanCongNhieuGiangVien"/> class.</returns>
		public abstract PMS.Entities.SdhMonPhanCongNhieuGiangVien GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SdhMonPhanCongNhieuGiangVien&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SdhMonPhanCongNhieuGiangVien&gt;"/></returns>
		public static TList<SdhMonPhanCongNhieuGiangVien> Fill(IDataReader reader, TList<SdhMonPhanCongNhieuGiangVien> rows, int start, int pageLength)
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
				
				PMS.Entities.SdhMonPhanCongNhieuGiangVien c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SdhMonPhanCongNhieuGiangVien")
					.Append("|").Append((System.Int32)reader[((int)SdhMonPhanCongNhieuGiangVienColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<SdhMonPhanCongNhieuGiangVien>(
					key.ToString(), // EntityTrackingKey
					"SdhMonPhanCongNhieuGiangVien",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.SdhMonPhanCongNhieuGiangVien();
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
					c.Id = (System.Int32)reader[(SdhMonPhanCongNhieuGiangVienColumn.Id.ToString())];
					c.MaMonHoc = (reader[SdhMonPhanCongNhieuGiangVienColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhMonPhanCongNhieuGiangVienColumn.MaMonHoc.ToString())];
					c.TenMonHoc = (reader[SdhMonPhanCongNhieuGiangVienColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhMonPhanCongNhieuGiangVienColumn.TenMonHoc.ToString())];
					c.NhomMonHoc = (reader[SdhMonPhanCongNhieuGiangVienColumn.NhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhMonPhanCongNhieuGiangVienColumn.NhomMonHoc.ToString())];
					c.MaHocPhan = (reader[SdhMonPhanCongNhieuGiangVienColumn.MaHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhMonPhanCongNhieuGiangVienColumn.MaHocPhan.ToString())];
					c.NamHoc = (reader[SdhMonPhanCongNhieuGiangVienColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhMonPhanCongNhieuGiangVienColumn.NamHoc.ToString())];
					c.HocKy = (reader[SdhMonPhanCongNhieuGiangVienColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhMonPhanCongNhieuGiangVienColumn.HocKy.ToString())];
					c.MaLopHocPhan = (reader[SdhMonPhanCongNhieuGiangVienColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhMonPhanCongNhieuGiangVienColumn.MaLopHocPhan.ToString())];
					c.MaLop = (reader[SdhMonPhanCongNhieuGiangVienColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhMonPhanCongNhieuGiangVienColumn.MaLop.ToString())];
					c.MaGiangVienQuanLy = (reader[SdhMonPhanCongNhieuGiangVienColumn.MaGiangVienQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhMonPhanCongNhieuGiangVienColumn.MaGiangVienQuanLy.ToString())];
					c.SoTinChi = (reader[SdhMonPhanCongNhieuGiangVienColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhMonPhanCongNhieuGiangVienColumn.SoTinChi.ToString())];
					c.SiSo = (reader[SdhMonPhanCongNhieuGiangVienColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhMonPhanCongNhieuGiangVienColumn.SiSo.ToString())];
					c.LopClc = (reader[SdhMonPhanCongNhieuGiangVienColumn.LopClc.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(SdhMonPhanCongNhieuGiangVienColumn.LopClc.ToString())];
					c.SoTietDayChuNhat = (reader[SdhMonPhanCongNhieuGiangVienColumn.SoTietDayChuNhat.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhMonPhanCongNhieuGiangVienColumn.SoTietDayChuNhat.ToString())];
					c.SoTiet = (reader[SdhMonPhanCongNhieuGiangVienColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhMonPhanCongNhieuGiangVienColumn.SoTiet.ToString())];
					c.MaLoaiHocPhan = (reader[SdhMonPhanCongNhieuGiangVienColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhMonPhanCongNhieuGiangVienColumn.MaLoaiHocPhan.ToString())];
					c.MaLoaiGiangVien = (reader[SdhMonPhanCongNhieuGiangVienColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhMonPhanCongNhieuGiangVienColumn.MaLoaiGiangVien.ToString())];
					c.MaHocHam = (reader[SdhMonPhanCongNhieuGiangVienColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhMonPhanCongNhieuGiangVienColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[SdhMonPhanCongNhieuGiangVienColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhMonPhanCongNhieuGiangVienColumn.MaHocVi.ToString())];
					c.Nhom = (reader[SdhMonPhanCongNhieuGiangVienColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhMonPhanCongNhieuGiangVienColumn.Nhom.ToString())];
					c.NgayCapNhat = (reader[SdhMonPhanCongNhieuGiangVienColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(SdhMonPhanCongNhieuGiangVienColumn.NgayCapNhat.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.SdhMonPhanCongNhieuGiangVien"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.SdhMonPhanCongNhieuGiangVien"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.SdhMonPhanCongNhieuGiangVien entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(SdhMonPhanCongNhieuGiangVienColumn.Id.ToString())];
			entity.MaMonHoc = (reader[SdhMonPhanCongNhieuGiangVienColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhMonPhanCongNhieuGiangVienColumn.MaMonHoc.ToString())];
			entity.TenMonHoc = (reader[SdhMonPhanCongNhieuGiangVienColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhMonPhanCongNhieuGiangVienColumn.TenMonHoc.ToString())];
			entity.NhomMonHoc = (reader[SdhMonPhanCongNhieuGiangVienColumn.NhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhMonPhanCongNhieuGiangVienColumn.NhomMonHoc.ToString())];
			entity.MaHocPhan = (reader[SdhMonPhanCongNhieuGiangVienColumn.MaHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhMonPhanCongNhieuGiangVienColumn.MaHocPhan.ToString())];
			entity.NamHoc = (reader[SdhMonPhanCongNhieuGiangVienColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhMonPhanCongNhieuGiangVienColumn.NamHoc.ToString())];
			entity.HocKy = (reader[SdhMonPhanCongNhieuGiangVienColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhMonPhanCongNhieuGiangVienColumn.HocKy.ToString())];
			entity.MaLopHocPhan = (reader[SdhMonPhanCongNhieuGiangVienColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhMonPhanCongNhieuGiangVienColumn.MaLopHocPhan.ToString())];
			entity.MaLop = (reader[SdhMonPhanCongNhieuGiangVienColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhMonPhanCongNhieuGiangVienColumn.MaLop.ToString())];
			entity.MaGiangVienQuanLy = (reader[SdhMonPhanCongNhieuGiangVienColumn.MaGiangVienQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhMonPhanCongNhieuGiangVienColumn.MaGiangVienQuanLy.ToString())];
			entity.SoTinChi = (reader[SdhMonPhanCongNhieuGiangVienColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhMonPhanCongNhieuGiangVienColumn.SoTinChi.ToString())];
			entity.SiSo = (reader[SdhMonPhanCongNhieuGiangVienColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhMonPhanCongNhieuGiangVienColumn.SiSo.ToString())];
			entity.LopClc = (reader[SdhMonPhanCongNhieuGiangVienColumn.LopClc.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(SdhMonPhanCongNhieuGiangVienColumn.LopClc.ToString())];
			entity.SoTietDayChuNhat = (reader[SdhMonPhanCongNhieuGiangVienColumn.SoTietDayChuNhat.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhMonPhanCongNhieuGiangVienColumn.SoTietDayChuNhat.ToString())];
			entity.SoTiet = (reader[SdhMonPhanCongNhieuGiangVienColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhMonPhanCongNhieuGiangVienColumn.SoTiet.ToString())];
			entity.MaLoaiHocPhan = (reader[SdhMonPhanCongNhieuGiangVienColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhMonPhanCongNhieuGiangVienColumn.MaLoaiHocPhan.ToString())];
			entity.MaLoaiGiangVien = (reader[SdhMonPhanCongNhieuGiangVienColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhMonPhanCongNhieuGiangVienColumn.MaLoaiGiangVien.ToString())];
			entity.MaHocHam = (reader[SdhMonPhanCongNhieuGiangVienColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhMonPhanCongNhieuGiangVienColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[SdhMonPhanCongNhieuGiangVienColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhMonPhanCongNhieuGiangVienColumn.MaHocVi.ToString())];
			entity.Nhom = (reader[SdhMonPhanCongNhieuGiangVienColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhMonPhanCongNhieuGiangVienColumn.Nhom.ToString())];
			entity.NgayCapNhat = (reader[SdhMonPhanCongNhieuGiangVienColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(SdhMonPhanCongNhieuGiangVienColumn.NgayCapNhat.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.SdhMonPhanCongNhieuGiangVien"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.SdhMonPhanCongNhieuGiangVien"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.SdhMonPhanCongNhieuGiangVien entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = Convert.IsDBNull(dataRow["TenMonHoc"]) ? null : (System.String)dataRow["TenMonHoc"];
			entity.NhomMonHoc = Convert.IsDBNull(dataRow["NhomMonHoc"]) ? null : (System.String)dataRow["NhomMonHoc"];
			entity.MaHocPhan = Convert.IsDBNull(dataRow["MaHocPhan"]) ? null : (System.String)dataRow["MaHocPhan"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.MaLop = Convert.IsDBNull(dataRow["MaLop"]) ? null : (System.String)dataRow["MaLop"];
			entity.MaGiangVienQuanLy = Convert.IsDBNull(dataRow["MaGiangVienQuanLy"]) ? null : (System.String)dataRow["MaGiangVienQuanLy"];
			entity.SoTinChi = Convert.IsDBNull(dataRow["SoTinChi"]) ? null : (System.Int32?)dataRow["SoTinChi"];
			entity.SiSo = Convert.IsDBNull(dataRow["SiSo"]) ? null : (System.Int32?)dataRow["SiSo"];
			entity.LopClc = Convert.IsDBNull(dataRow["LopClc"]) ? null : (System.Boolean?)dataRow["LopClc"];
			entity.SoTietDayChuNhat = Convert.IsDBNull(dataRow["SoTietDayChuNhat"]) ? null : (System.Int32?)dataRow["SoTietDayChuNhat"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Int32?)dataRow["SoTiet"];
			entity.MaLoaiHocPhan = Convert.IsDBNull(dataRow["MaLoaiHocPhan"]) ? null : (System.Int32?)dataRow["MaLoaiHocPhan"];
			entity.MaLoaiGiangVien = Convert.IsDBNull(dataRow["MaLoaiGiangVien"]) ? null : (System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
			entity.Nhom = Convert.IsDBNull(dataRow["Nhom"]) ? null : (System.String)dataRow["Nhom"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
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
		/// <param name="entity">The <see cref="PMS.Entities.SdhMonPhanCongNhieuGiangVien"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.SdhMonPhanCongNhieuGiangVien Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.SdhMonPhanCongNhieuGiangVien entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.SdhMonPhanCongNhieuGiangVien object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.SdhMonPhanCongNhieuGiangVien instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.SdhMonPhanCongNhieuGiangVien Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.SdhMonPhanCongNhieuGiangVien entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region SdhMonPhanCongNhieuGiangVienChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.SdhMonPhanCongNhieuGiangVien</c>
	///</summary>
	public enum SdhMonPhanCongNhieuGiangVienChildEntityTypes
	{
	}
	
	#endregion SdhMonPhanCongNhieuGiangVienChildEntityTypes
	
	#region SdhMonPhanCongNhieuGiangVienFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SdhMonPhanCongNhieuGiangVienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhMonPhanCongNhieuGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhMonPhanCongNhieuGiangVienFilterBuilder : SqlFilterBuilder<SdhMonPhanCongNhieuGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhMonPhanCongNhieuGiangVienFilterBuilder class.
		/// </summary>
		public SdhMonPhanCongNhieuGiangVienFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SdhMonPhanCongNhieuGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SdhMonPhanCongNhieuGiangVienFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SdhMonPhanCongNhieuGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SdhMonPhanCongNhieuGiangVienFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SdhMonPhanCongNhieuGiangVienFilterBuilder
	
	#region SdhMonPhanCongNhieuGiangVienParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SdhMonPhanCongNhieuGiangVienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhMonPhanCongNhieuGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhMonPhanCongNhieuGiangVienParameterBuilder : ParameterizedSqlFilterBuilder<SdhMonPhanCongNhieuGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhMonPhanCongNhieuGiangVienParameterBuilder class.
		/// </summary>
		public SdhMonPhanCongNhieuGiangVienParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SdhMonPhanCongNhieuGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SdhMonPhanCongNhieuGiangVienParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SdhMonPhanCongNhieuGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SdhMonPhanCongNhieuGiangVienParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SdhMonPhanCongNhieuGiangVienParameterBuilder
	
	#region SdhMonPhanCongNhieuGiangVienSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SdhMonPhanCongNhieuGiangVienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhMonPhanCongNhieuGiangVien"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SdhMonPhanCongNhieuGiangVienSortBuilder : SqlSortBuilder<SdhMonPhanCongNhieuGiangVienColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhMonPhanCongNhieuGiangVienSqlSortBuilder class.
		/// </summary>
		public SdhMonPhanCongNhieuGiangVienSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SdhMonPhanCongNhieuGiangVienSortBuilder
	
} // end namespace
