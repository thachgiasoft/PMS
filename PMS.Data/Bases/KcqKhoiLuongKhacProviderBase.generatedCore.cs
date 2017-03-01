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
	/// This class is the base class for any <see cref="KcqKhoiLuongKhacProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KcqKhoiLuongKhacProviderBaseCore : EntityProviderBase<PMS.Entities.KcqKhoiLuongKhac, PMS.Entities.KcqKhoiLuongKhacKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KcqKhoiLuongKhacKey key)
		{
			return Delete(transactionManager, key.MaKhoiLuong);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maKhoiLuong">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maKhoiLuong)
		{
			return Delete(null, _maKhoiLuong);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuong">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maKhoiLuong);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KcqKhoiLuongKhac_GiangVien key.
		///		FK_KcqKhoiLuongKhac_GiangVien Description: 
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.KcqKhoiLuongKhac objects.</returns>
		public TList<KcqKhoiLuongKhac> GetByMaGiangVien(System.Int32? _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(_maGiangVien, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KcqKhoiLuongKhac_GiangVien key.
		///		FK_KcqKhoiLuongKhac_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.KcqKhoiLuongKhac objects.</returns>
		/// <remarks></remarks>
		public TList<KcqKhoiLuongKhac> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_KcqKhoiLuongKhac_GiangVien key.
		///		FK_KcqKhoiLuongKhac_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KcqKhoiLuongKhac objects.</returns>
		public TList<KcqKhoiLuongKhac> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KcqKhoiLuongKhac_GiangVien key.
		///		fkKcqKhoiLuongKhacGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KcqKhoiLuongKhac objects.</returns>
		public TList<KcqKhoiLuongKhac> GetByMaGiangVien(System.Int32? _maGiangVien, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KcqKhoiLuongKhac_GiangVien key.
		///		fkKcqKhoiLuongKhacGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KcqKhoiLuongKhac objects.</returns>
		public TList<KcqKhoiLuongKhac> GetByMaGiangVien(System.Int32? _maGiangVien, int start, int pageLength,out int count)
		{
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KcqKhoiLuongKhac_GiangVien key.
		///		FK_KcqKhoiLuongKhac_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.KcqKhoiLuongKhac objects.</returns>
		public abstract TList<KcqKhoiLuongKhac> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.KcqKhoiLuongKhac Get(TransactionManager transactionManager, PMS.Entities.KcqKhoiLuongKhacKey key, int start, int pageLength)
		{
			return GetByMaKhoiLuong(transactionManager, key.MaKhoiLuong, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KcqKhoiLuongKhac index.
		/// </summary>
		/// <param name="_maKhoiLuong"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongKhac"/> class.</returns>
		public PMS.Entities.KcqKhoiLuongKhac GetByMaKhoiLuong(System.Int32 _maKhoiLuong)
		{
			int count = -1;
			return GetByMaKhoiLuong(null,_maKhoiLuong, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqKhoiLuongKhac index.
		/// </summary>
		/// <param name="_maKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongKhac"/> class.</returns>
		public PMS.Entities.KcqKhoiLuongKhac GetByMaKhoiLuong(System.Int32 _maKhoiLuong, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKhoiLuong(null, _maKhoiLuong, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqKhoiLuongKhac index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuong"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongKhac"/> class.</returns>
		public PMS.Entities.KcqKhoiLuongKhac GetByMaKhoiLuong(TransactionManager transactionManager, System.Int32 _maKhoiLuong)
		{
			int count = -1;
			return GetByMaKhoiLuong(transactionManager, _maKhoiLuong, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqKhoiLuongKhac index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongKhac"/> class.</returns>
		public PMS.Entities.KcqKhoiLuongKhac GetByMaKhoiLuong(TransactionManager transactionManager, System.Int32 _maKhoiLuong, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKhoiLuong(transactionManager, _maKhoiLuong, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqKhoiLuongKhac index.
		/// </summary>
		/// <param name="_maKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongKhac"/> class.</returns>
		public PMS.Entities.KcqKhoiLuongKhac GetByMaKhoiLuong(System.Int32 _maKhoiLuong, int start, int pageLength, out int count)
		{
			return GetByMaKhoiLuong(null, _maKhoiLuong, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqKhoiLuongKhac index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongKhac"/> class.</returns>
		public abstract PMS.Entities.KcqKhoiLuongKhac GetByMaKhoiLuong(TransactionManager transactionManager, System.Int32 _maKhoiLuong, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KcqKhoiLuongKhac&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KcqKhoiLuongKhac&gt;"/></returns>
		public static TList<KcqKhoiLuongKhac> Fill(IDataReader reader, TList<KcqKhoiLuongKhac> rows, int start, int pageLength)
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
				
				PMS.Entities.KcqKhoiLuongKhac c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KcqKhoiLuongKhac")
					.Append("|").Append((System.Int32)reader[((int)KcqKhoiLuongKhacColumn.MaKhoiLuong - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KcqKhoiLuongKhac>(
					key.ToString(), // EntityTrackingKey
					"KcqKhoiLuongKhac",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KcqKhoiLuongKhac();
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
					c.MaKhoiLuong = (System.Int32)reader[(KcqKhoiLuongKhacColumn.MaKhoiLuong.ToString())];
					c.MaGiangVien = (reader[KcqKhoiLuongKhacColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongKhacColumn.MaGiangVien.ToString())];
					c.LoaiHocPhan = (reader[KcqKhoiLuongKhacColumn.LoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongKhacColumn.LoaiHocPhan.ToString())];
					c.MaLopHocPhan = (reader[KcqKhoiLuongKhacColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongKhacColumn.MaLopHocPhan.ToString())];
					c.MaLop = (reader[KcqKhoiLuongKhacColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongKhacColumn.MaLop.ToString())];
					c.MaMonHoc = (reader[KcqKhoiLuongKhacColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongKhacColumn.MaMonHoc.ToString())];
					c.MaNhom = (reader[KcqKhoiLuongKhacColumn.MaNhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongKhacColumn.MaNhom.ToString())];
					c.SoTiet = (reader[KcqKhoiLuongKhacColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongKhacColumn.SoTiet.ToString())];
					c.SoTuan = (reader[KcqKhoiLuongKhacColumn.SoTuan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongKhacColumn.SoTuan.ToString())];
					c.DonGia = (reader[KcqKhoiLuongKhacColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongKhacColumn.DonGia.ToString())];
					c.NamHoc = (reader[KcqKhoiLuongKhacColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongKhacColumn.NamHoc.ToString())];
					c.HocKy = (reader[KcqKhoiLuongKhacColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongKhacColumn.HocKy.ToString())];
					c.SoLuong = (reader[KcqKhoiLuongKhacColumn.SoLuong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongKhacColumn.SoLuong.ToString())];
					c.TietQuyDoi = (reader[KcqKhoiLuongKhacColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongKhacColumn.TietQuyDoi.ToString())];
					c.DienGiai = (reader[KcqKhoiLuongKhacColumn.DienGiai.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongKhacColumn.DienGiai.ToString())];
					c.PhanLoai = (reader[KcqKhoiLuongKhacColumn.PhanLoai.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongKhacColumn.PhanLoai.ToString())];
					c.NgayTao = (reader[KcqKhoiLuongKhacColumn.NgayTao.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KcqKhoiLuongKhacColumn.NgayTao.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqKhoiLuongKhac"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqKhoiLuongKhac"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KcqKhoiLuongKhac entity)
		{
			if (!reader.Read()) return;
			
			entity.MaKhoiLuong = (System.Int32)reader[(KcqKhoiLuongKhacColumn.MaKhoiLuong.ToString())];
			entity.MaGiangVien = (reader[KcqKhoiLuongKhacColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongKhacColumn.MaGiangVien.ToString())];
			entity.LoaiHocPhan = (reader[KcqKhoiLuongKhacColumn.LoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongKhacColumn.LoaiHocPhan.ToString())];
			entity.MaLopHocPhan = (reader[KcqKhoiLuongKhacColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongKhacColumn.MaLopHocPhan.ToString())];
			entity.MaLop = (reader[KcqKhoiLuongKhacColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongKhacColumn.MaLop.ToString())];
			entity.MaMonHoc = (reader[KcqKhoiLuongKhacColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongKhacColumn.MaMonHoc.ToString())];
			entity.MaNhom = (reader[KcqKhoiLuongKhacColumn.MaNhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongKhacColumn.MaNhom.ToString())];
			entity.SoTiet = (reader[KcqKhoiLuongKhacColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongKhacColumn.SoTiet.ToString())];
			entity.SoTuan = (reader[KcqKhoiLuongKhacColumn.SoTuan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongKhacColumn.SoTuan.ToString())];
			entity.DonGia = (reader[KcqKhoiLuongKhacColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongKhacColumn.DonGia.ToString())];
			entity.NamHoc = (reader[KcqKhoiLuongKhacColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongKhacColumn.NamHoc.ToString())];
			entity.HocKy = (reader[KcqKhoiLuongKhacColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongKhacColumn.HocKy.ToString())];
			entity.SoLuong = (reader[KcqKhoiLuongKhacColumn.SoLuong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongKhacColumn.SoLuong.ToString())];
			entity.TietQuyDoi = (reader[KcqKhoiLuongKhacColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongKhacColumn.TietQuyDoi.ToString())];
			entity.DienGiai = (reader[KcqKhoiLuongKhacColumn.DienGiai.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongKhacColumn.DienGiai.ToString())];
			entity.PhanLoai = (reader[KcqKhoiLuongKhacColumn.PhanLoai.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongKhacColumn.PhanLoai.ToString())];
			entity.NgayTao = (reader[KcqKhoiLuongKhacColumn.NgayTao.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KcqKhoiLuongKhacColumn.NgayTao.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqKhoiLuongKhac"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqKhoiLuongKhac"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KcqKhoiLuongKhac entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaKhoiLuong = (System.Int32)dataRow["MaKhoiLuong"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.Int32?)dataRow["MaGiangVien"];
			entity.LoaiHocPhan = Convert.IsDBNull(dataRow["LoaiHocPhan"]) ? null : (System.String)dataRow["LoaiHocPhan"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.MaLop = Convert.IsDBNull(dataRow["MaLop"]) ? null : (System.String)dataRow["MaLop"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.MaNhom = Convert.IsDBNull(dataRow["MaNhom"]) ? null : (System.String)dataRow["MaNhom"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Decimal?)dataRow["SoTiet"];
			entity.SoTuan = Convert.IsDBNull(dataRow["SoTuan"]) ? null : (System.Int32?)dataRow["SoTuan"];
			entity.DonGia = Convert.IsDBNull(dataRow["DonGia"]) ? null : (System.Decimal?)dataRow["DonGia"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.SoLuong = Convert.IsDBNull(dataRow["SoLuong"]) ? null : (System.Int32?)dataRow["SoLuong"];
			entity.TietQuyDoi = Convert.IsDBNull(dataRow["TietQuyDoi"]) ? null : (System.Decimal?)dataRow["TietQuyDoi"];
			entity.DienGiai = Convert.IsDBNull(dataRow["DienGiai"]) ? null : (System.String)dataRow["DienGiai"];
			entity.PhanLoai = Convert.IsDBNull(dataRow["PhanLoai"]) ? null : (System.Int32?)dataRow["PhanLoai"];
			entity.NgayTao = Convert.IsDBNull(dataRow["NgayTao"]) ? null : (System.DateTime?)dataRow["NgayTao"];
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
		/// <param name="entity">The <see cref="PMS.Entities.KcqKhoiLuongKhac"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KcqKhoiLuongKhac Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KcqKhoiLuongKhac entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaGiangVienSource	
			if (CanDeepLoad(entity, "GiangVien|MaGiangVienSource", deepLoadType, innerList) 
				&& entity.MaGiangVienSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaGiangVien ?? (int)0);
				GiangVien tmpEntity = EntityManager.LocateEntity<GiangVien>(EntityLocator.ConstructKeyFromPkItems(typeof(GiangVien), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaGiangVienSource = tmpEntity;
				else
					entity.MaGiangVienSource = DataRepository.GiangVienProvider.GetByMaGiangVien(transactionManager, (entity.MaGiangVien ?? (int)0));		
				
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
		/// Deep Save the entire object graph of the PMS.Entities.KcqKhoiLuongKhac object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KcqKhoiLuongKhac instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KcqKhoiLuongKhac Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KcqKhoiLuongKhac entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
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
	
	#region KcqKhoiLuongKhacChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KcqKhoiLuongKhac</c>
	///</summary>
	public enum KcqKhoiLuongKhacChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GiangVien</c> at MaGiangVienSource
		///</summary>
		[ChildEntityType(typeof(GiangVien))]
		GiangVien,
	}
	
	#endregion KcqKhoiLuongKhacChildEntityTypes
	
	#region KcqKhoiLuongKhacFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KcqKhoiLuongKhacColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKhoiLuongKhacFilterBuilder : SqlFilterBuilder<KcqKhoiLuongKhacColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongKhacFilterBuilder class.
		/// </summary>
		public KcqKhoiLuongKhacFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongKhacFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqKhoiLuongKhacFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongKhacFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqKhoiLuongKhacFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqKhoiLuongKhacFilterBuilder
	
	#region KcqKhoiLuongKhacParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KcqKhoiLuongKhacColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKhoiLuongKhacParameterBuilder : ParameterizedSqlFilterBuilder<KcqKhoiLuongKhacColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongKhacParameterBuilder class.
		/// </summary>
		public KcqKhoiLuongKhacParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongKhacParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqKhoiLuongKhacParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongKhacParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqKhoiLuongKhacParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqKhoiLuongKhacParameterBuilder
	
	#region KcqKhoiLuongKhacSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KcqKhoiLuongKhacColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongKhac"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KcqKhoiLuongKhacSortBuilder : SqlSortBuilder<KcqKhoiLuongKhacColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongKhacSqlSortBuilder class.
		/// </summary>
		public KcqKhoiLuongKhacSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KcqKhoiLuongKhacSortBuilder
	
} // end namespace
