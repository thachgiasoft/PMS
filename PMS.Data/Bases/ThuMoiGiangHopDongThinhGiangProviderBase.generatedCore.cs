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
	/// This class is the base class for any <see cref="ThuMoiGiangHopDongThinhGiangProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ThuMoiGiangHopDongThinhGiangProviderBaseCore : EntityProviderBase<PMS.Entities.ThuMoiGiangHopDongThinhGiang, PMS.Entities.ThuMoiGiangHopDongThinhGiangKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.ThuMoiGiangHopDongThinhGiangKey key)
		{
			return Delete(transactionManager, key.MaGiangVien, key.MaLopHocPhan, key.MaLopSinhVien);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maGiangVien">. Primary Key.</param>
		/// <param name="_maLopHocPhan">. Primary Key.</param>
		/// <param name="_maLopSinhVien">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _maGiangVien, System.String _maLopHocPhan, System.String _maLopSinhVien)
		{
			return Delete(null, _maGiangVien, _maLopHocPhan, _maLopSinhVien);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien">. Primary Key.</param>
		/// <param name="_maLopHocPhan">. Primary Key.</param>
		/// <param name="_maLopSinhVien">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _maGiangVien, System.String _maLopHocPhan, System.String _maLopSinhVien);		
		
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
		public override PMS.Entities.ThuMoiGiangHopDongThinhGiang Get(TransactionManager transactionManager, PMS.Entities.ThuMoiGiangHopDongThinhGiangKey key, int start, int pageLength)
		{
			return GetByMaGiangVienMaLopHocPhanMaLopSinhVien(transactionManager, key.MaGiangVien, key.MaLopHocPhan, key.MaLopSinhVien, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ThuMoiGiang_HopDongThinhGiang index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maLopSinhVien"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuMoiGiangHopDongThinhGiang"/> class.</returns>
		public PMS.Entities.ThuMoiGiangHopDongThinhGiang GetByMaGiangVienMaLopHocPhanMaLopSinhVien(System.String _maGiangVien, System.String _maLopHocPhan, System.String _maLopSinhVien)
		{
			int count = -1;
			return GetByMaGiangVienMaLopHocPhanMaLopSinhVien(null,_maGiangVien, _maLopHocPhan, _maLopSinhVien, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuMoiGiang_HopDongThinhGiang index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maLopSinhVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuMoiGiangHopDongThinhGiang"/> class.</returns>
		public PMS.Entities.ThuMoiGiangHopDongThinhGiang GetByMaGiangVienMaLopHocPhanMaLopSinhVien(System.String _maGiangVien, System.String _maLopHocPhan, System.String _maLopSinhVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVienMaLopHocPhanMaLopSinhVien(null, _maGiangVien, _maLopHocPhan, _maLopSinhVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuMoiGiang_HopDongThinhGiang index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maLopSinhVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuMoiGiangHopDongThinhGiang"/> class.</returns>
		public PMS.Entities.ThuMoiGiangHopDongThinhGiang GetByMaGiangVienMaLopHocPhanMaLopSinhVien(TransactionManager transactionManager, System.String _maGiangVien, System.String _maLopHocPhan, System.String _maLopSinhVien)
		{
			int count = -1;
			return GetByMaGiangVienMaLopHocPhanMaLopSinhVien(transactionManager, _maGiangVien, _maLopHocPhan, _maLopSinhVien, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuMoiGiang_HopDongThinhGiang index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maLopSinhVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuMoiGiangHopDongThinhGiang"/> class.</returns>
		public PMS.Entities.ThuMoiGiangHopDongThinhGiang GetByMaGiangVienMaLopHocPhanMaLopSinhVien(TransactionManager transactionManager, System.String _maGiangVien, System.String _maLopHocPhan, System.String _maLopSinhVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVienMaLopHocPhanMaLopSinhVien(transactionManager, _maGiangVien, _maLopHocPhan, _maLopSinhVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuMoiGiang_HopDongThinhGiang index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maLopSinhVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuMoiGiangHopDongThinhGiang"/> class.</returns>
		public PMS.Entities.ThuMoiGiangHopDongThinhGiang GetByMaGiangVienMaLopHocPhanMaLopSinhVien(System.String _maGiangVien, System.String _maLopHocPhan, System.String _maLopSinhVien, int start, int pageLength, out int count)
		{
			return GetByMaGiangVienMaLopHocPhanMaLopSinhVien(null, _maGiangVien, _maLopHocPhan, _maLopSinhVien, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuMoiGiang_HopDongThinhGiang index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maLopSinhVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuMoiGiangHopDongThinhGiang"/> class.</returns>
		public abstract PMS.Entities.ThuMoiGiangHopDongThinhGiang GetByMaGiangVienMaLopHocPhanMaLopSinhVien(TransactionManager transactionManager, System.String _maGiangVien, System.String _maLopHocPhan, System.String _maLopSinhVien, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ThuMoiGiangHopDongThinhGiang&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ThuMoiGiangHopDongThinhGiang&gt;"/></returns>
		public static TList<ThuMoiGiangHopDongThinhGiang> Fill(IDataReader reader, TList<ThuMoiGiangHopDongThinhGiang> rows, int start, int pageLength)
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
				
				PMS.Entities.ThuMoiGiangHopDongThinhGiang c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ThuMoiGiangHopDongThinhGiang")
					.Append("|").Append((System.String)reader[((int)ThuMoiGiangHopDongThinhGiangColumn.MaGiangVien - 1)])
					.Append("|").Append((System.String)reader[((int)ThuMoiGiangHopDongThinhGiangColumn.MaLopHocPhan - 1)])
					.Append("|").Append((System.String)reader[((int)ThuMoiGiangHopDongThinhGiangColumn.MaLopSinhVien - 1)]).ToString();
					c = EntityManager.LocateOrCreate<ThuMoiGiangHopDongThinhGiang>(
					key.ToString(), // EntityTrackingKey
					"ThuMoiGiangHopDongThinhGiang",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.ThuMoiGiangHopDongThinhGiang();
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
					c.MaGiangVien = (System.String)reader[(ThuMoiGiangHopDongThinhGiangColumn.MaGiangVien.ToString())];
					c.OriginalMaGiangVien = c.MaGiangVien;
					c.MaLopHocPhan = (System.String)reader[(ThuMoiGiangHopDongThinhGiangColumn.MaLopHocPhan.ToString())];
					c.OriginalMaLopHocPhan = c.MaLopHocPhan;
					c.MaBacDaoTao = (System.String)reader[(ThuMoiGiangHopDongThinhGiangColumn.MaBacDaoTao.ToString())];
					c.MaLoaiHinh = (System.String)reader[(ThuMoiGiangHopDongThinhGiangColumn.MaLoaiHinh.ToString())];
					c.MaMonHoc = (System.String)reader[(ThuMoiGiangHopDongThinhGiangColumn.MaMonHoc.ToString())];
					c.SoTiet = (reader[ThuMoiGiangHopDongThinhGiangColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuMoiGiangHopDongThinhGiangColumn.SoTiet.ToString())];
					c.SiSoLop = (reader[ThuMoiGiangHopDongThinhGiangColumn.SiSoLop.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuMoiGiangHopDongThinhGiangColumn.SiSoLop.ToString())];
					c.HeSoLd = (reader[ThuMoiGiangHopDongThinhGiangColumn.HeSoLd.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuMoiGiangHopDongThinhGiangColumn.HeSoLd.ToString())];
					c.HeSoTinChi = (reader[ThuMoiGiangHopDongThinhGiangColumn.HeSoTinChi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuMoiGiangHopDongThinhGiangColumn.HeSoTinChi.ToString())];
					c.TietQuyDoi = (reader[ThuMoiGiangHopDongThinhGiangColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuMoiGiangHopDongThinhGiangColumn.TietQuyDoi.ToString())];
					c.NgayBatDauDay = (reader[ThuMoiGiangHopDongThinhGiangColumn.NgayBatDauDay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ThuMoiGiangHopDongThinhGiangColumn.NgayBatDauDay.ToString())];
					c.NgayKetThucDay = (reader[ThuMoiGiangHopDongThinhGiangColumn.NgayKetThucDay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ThuMoiGiangHopDongThinhGiangColumn.NgayKetThucDay.ToString())];
					c.MaLopSinhVien = (System.String)reader[(ThuMoiGiangHopDongThinhGiangColumn.MaLopSinhVien.ToString())];
					c.OriginalMaLopSinhVien = c.MaLopSinhVien;
					c.HoanTat = (reader[ThuMoiGiangHopDongThinhGiangColumn.HoanTat.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ThuMoiGiangHopDongThinhGiangColumn.HoanTat.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThuMoiGiangHopDongThinhGiang"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThuMoiGiangHopDongThinhGiang"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.ThuMoiGiangHopDongThinhGiang entity)
		{
			if (!reader.Read()) return;
			
			entity.MaGiangVien = (System.String)reader[(ThuMoiGiangHopDongThinhGiangColumn.MaGiangVien.ToString())];
			entity.OriginalMaGiangVien = (System.String)reader["MaGiangVien"];
			entity.MaLopHocPhan = (System.String)reader[(ThuMoiGiangHopDongThinhGiangColumn.MaLopHocPhan.ToString())];
			entity.OriginalMaLopHocPhan = (System.String)reader["MaLopHocPhan"];
			entity.MaBacDaoTao = (System.String)reader[(ThuMoiGiangHopDongThinhGiangColumn.MaBacDaoTao.ToString())];
			entity.MaLoaiHinh = (System.String)reader[(ThuMoiGiangHopDongThinhGiangColumn.MaLoaiHinh.ToString())];
			entity.MaMonHoc = (System.String)reader[(ThuMoiGiangHopDongThinhGiangColumn.MaMonHoc.ToString())];
			entity.SoTiet = (reader[ThuMoiGiangHopDongThinhGiangColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuMoiGiangHopDongThinhGiangColumn.SoTiet.ToString())];
			entity.SiSoLop = (reader[ThuMoiGiangHopDongThinhGiangColumn.SiSoLop.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuMoiGiangHopDongThinhGiangColumn.SiSoLop.ToString())];
			entity.HeSoLd = (reader[ThuMoiGiangHopDongThinhGiangColumn.HeSoLd.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuMoiGiangHopDongThinhGiangColumn.HeSoLd.ToString())];
			entity.HeSoTinChi = (reader[ThuMoiGiangHopDongThinhGiangColumn.HeSoTinChi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuMoiGiangHopDongThinhGiangColumn.HeSoTinChi.ToString())];
			entity.TietQuyDoi = (reader[ThuMoiGiangHopDongThinhGiangColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuMoiGiangHopDongThinhGiangColumn.TietQuyDoi.ToString())];
			entity.NgayBatDauDay = (reader[ThuMoiGiangHopDongThinhGiangColumn.NgayBatDauDay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ThuMoiGiangHopDongThinhGiangColumn.NgayBatDauDay.ToString())];
			entity.NgayKetThucDay = (reader[ThuMoiGiangHopDongThinhGiangColumn.NgayKetThucDay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ThuMoiGiangHopDongThinhGiangColumn.NgayKetThucDay.ToString())];
			entity.MaLopSinhVien = (System.String)reader[(ThuMoiGiangHopDongThinhGiangColumn.MaLopSinhVien.ToString())];
			entity.OriginalMaLopSinhVien = (System.String)reader["MaLopSinhVien"];
			entity.HoanTat = (reader[ThuMoiGiangHopDongThinhGiangColumn.HoanTat.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ThuMoiGiangHopDongThinhGiangColumn.HoanTat.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThuMoiGiangHopDongThinhGiang"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThuMoiGiangHopDongThinhGiang"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.ThuMoiGiangHopDongThinhGiang entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (System.String)dataRow["MaGiangVien"];
			entity.OriginalMaGiangVien = (System.String)dataRow["MaGiangVien"];
			entity.MaLopHocPhan = (System.String)dataRow["MaLopHocPhan"];
			entity.OriginalMaLopHocPhan = (System.String)dataRow["MaLopHocPhan"];
			entity.MaBacDaoTao = (System.String)dataRow["MaBacDaoTao"];
			entity.MaLoaiHinh = (System.String)dataRow["MaLoaiHinh"];
			entity.MaMonHoc = (System.String)dataRow["MaMonHoc"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Int32?)dataRow["SoTiet"];
			entity.SiSoLop = Convert.IsDBNull(dataRow["SiSoLop"]) ? null : (System.Int32?)dataRow["SiSoLop"];
			entity.HeSoLd = Convert.IsDBNull(dataRow["HeSoLD"]) ? null : (System.Decimal?)dataRow["HeSoLD"];
			entity.HeSoTinChi = Convert.IsDBNull(dataRow["HeSoTinChi"]) ? null : (System.Decimal?)dataRow["HeSoTinChi"];
			entity.TietQuyDoi = Convert.IsDBNull(dataRow["TietQuyDoi"]) ? null : (System.Decimal?)dataRow["TietQuyDoi"];
			entity.NgayBatDauDay = Convert.IsDBNull(dataRow["NgayBatDauDay"]) ? null : (System.DateTime?)dataRow["NgayBatDauDay"];
			entity.NgayKetThucDay = Convert.IsDBNull(dataRow["NgayKetThucDay"]) ? null : (System.DateTime?)dataRow["NgayKetThucDay"];
			entity.MaLopSinhVien = (System.String)dataRow["MaLopSinhVien"];
			entity.OriginalMaLopSinhVien = (System.String)dataRow["MaLopSinhVien"];
			entity.HoanTat = Convert.IsDBNull(dataRow["HoanTat"]) ? null : (System.Boolean?)dataRow["HoanTat"];
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
		/// <param name="entity">The <see cref="PMS.Entities.ThuMoiGiangHopDongThinhGiang"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.ThuMoiGiangHopDongThinhGiang Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.ThuMoiGiangHopDongThinhGiang entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.ThuMoiGiangHopDongThinhGiang object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.ThuMoiGiangHopDongThinhGiang instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.ThuMoiGiangHopDongThinhGiang Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.ThuMoiGiangHopDongThinhGiang entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region ThuMoiGiangHopDongThinhGiangChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.ThuMoiGiangHopDongThinhGiang</c>
	///</summary>
	public enum ThuMoiGiangHopDongThinhGiangChildEntityTypes
	{
	}
	
	#endregion ThuMoiGiangHopDongThinhGiangChildEntityTypes
	
	#region ThuMoiGiangHopDongThinhGiangFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ThuMoiGiangHopDongThinhGiangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuMoiGiangHopDongThinhGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuMoiGiangHopDongThinhGiangFilterBuilder : SqlFilterBuilder<ThuMoiGiangHopDongThinhGiangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuMoiGiangHopDongThinhGiangFilterBuilder class.
		/// </summary>
		public ThuMoiGiangHopDongThinhGiangFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThuMoiGiangHopDongThinhGiangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThuMoiGiangHopDongThinhGiangFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThuMoiGiangHopDongThinhGiangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThuMoiGiangHopDongThinhGiangFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThuMoiGiangHopDongThinhGiangFilterBuilder
	
	#region ThuMoiGiangHopDongThinhGiangParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ThuMoiGiangHopDongThinhGiangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuMoiGiangHopDongThinhGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuMoiGiangHopDongThinhGiangParameterBuilder : ParameterizedSqlFilterBuilder<ThuMoiGiangHopDongThinhGiangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuMoiGiangHopDongThinhGiangParameterBuilder class.
		/// </summary>
		public ThuMoiGiangHopDongThinhGiangParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThuMoiGiangHopDongThinhGiangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThuMoiGiangHopDongThinhGiangParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThuMoiGiangHopDongThinhGiangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThuMoiGiangHopDongThinhGiangParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThuMoiGiangHopDongThinhGiangParameterBuilder
	
	#region ThuMoiGiangHopDongThinhGiangSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ThuMoiGiangHopDongThinhGiangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuMoiGiangHopDongThinhGiang"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ThuMoiGiangHopDongThinhGiangSortBuilder : SqlSortBuilder<ThuMoiGiangHopDongThinhGiangColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuMoiGiangHopDongThinhGiangSqlSortBuilder class.
		/// </summary>
		public ThuMoiGiangHopDongThinhGiangSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ThuMoiGiangHopDongThinhGiangSortBuilder
	
} // end namespace
