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
	/// This class is the base class for any <see cref="ThongTinGiangDayGiangVienProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ThongTinGiangDayGiangVienProviderBaseCore : EntityProviderBase<PMS.Entities.ThongTinGiangDayGiangVien, PMS.Entities.ThongTinGiangDayGiangVienKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.ThongTinGiangDayGiangVienKey key)
		{
			return Delete(transactionManager, key.MaGiangVien, key.MaLopHocPhan);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maGiangVien">. Primary Key.</param>
		/// <param name="_maLopHocPhan">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _maGiangVien, System.String _maLopHocPhan)
		{
			return Delete(null, _maGiangVien, _maLopHocPhan);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien">. Primary Key.</param>
		/// <param name="_maLopHocPhan">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _maGiangVien, System.String _maLopHocPhan);		
		
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
		public override PMS.Entities.ThongTinGiangDayGiangVien Get(TransactionManager transactionManager, PMS.Entities.ThongTinGiangDayGiangVienKey key, int start, int pageLength)
		{
			return GetByMaGiangVienMaLopHocPhan(transactionManager, key.MaGiangVien, key.MaLopHocPhan, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ThongTinGiangDayGiangVien index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maLopHocPhan"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThongTinGiangDayGiangVien"/> class.</returns>
		public PMS.Entities.ThongTinGiangDayGiangVien GetByMaGiangVienMaLopHocPhan(System.String _maGiangVien, System.String _maLopHocPhan)
		{
			int count = -1;
			return GetByMaGiangVienMaLopHocPhan(null,_maGiangVien, _maLopHocPhan, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThongTinGiangDayGiangVien index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThongTinGiangDayGiangVien"/> class.</returns>
		public PMS.Entities.ThongTinGiangDayGiangVien GetByMaGiangVienMaLopHocPhan(System.String _maGiangVien, System.String _maLopHocPhan, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVienMaLopHocPhan(null, _maGiangVien, _maLopHocPhan, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThongTinGiangDayGiangVien index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maLopHocPhan"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThongTinGiangDayGiangVien"/> class.</returns>
		public PMS.Entities.ThongTinGiangDayGiangVien GetByMaGiangVienMaLopHocPhan(TransactionManager transactionManager, System.String _maGiangVien, System.String _maLopHocPhan)
		{
			int count = -1;
			return GetByMaGiangVienMaLopHocPhan(transactionManager, _maGiangVien, _maLopHocPhan, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThongTinGiangDayGiangVien index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThongTinGiangDayGiangVien"/> class.</returns>
		public PMS.Entities.ThongTinGiangDayGiangVien GetByMaGiangVienMaLopHocPhan(TransactionManager transactionManager, System.String _maGiangVien, System.String _maLopHocPhan, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVienMaLopHocPhan(transactionManager, _maGiangVien, _maLopHocPhan, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThongTinGiangDayGiangVien index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThongTinGiangDayGiangVien"/> class.</returns>
		public PMS.Entities.ThongTinGiangDayGiangVien GetByMaGiangVienMaLopHocPhan(System.String _maGiangVien, System.String _maLopHocPhan, int start, int pageLength, out int count)
		{
			return GetByMaGiangVienMaLopHocPhan(null, _maGiangVien, _maLopHocPhan, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThongTinGiangDayGiangVien index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThongTinGiangDayGiangVien"/> class.</returns>
		public abstract PMS.Entities.ThongTinGiangDayGiangVien GetByMaGiangVienMaLopHocPhan(TransactionManager transactionManager, System.String _maGiangVien, System.String _maLopHocPhan, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_ThongTinGiangDayGiangVien_GetByNamHocHocKyMaGiangVienMaLopHocPhan 
		
		/// <summary>
		///	This method wrap the 'cust_ThongTinGiangDayGiangVien_GetByNamHocHocKyMaGiangVienMaLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThongTinGiangDayGiangVien&gt;"/> instance.</returns>
		public TList<ThongTinGiangDayGiangVien> GetByNamHocHocKyMaGiangVienMaLopHocPhan(System.String namHoc, System.String hocKy, System.String maGiangVien, System.String maLopHocPhan)
		{
			return GetByNamHocHocKyMaGiangVienMaLopHocPhan(null, 0, int.MaxValue , namHoc, hocKy, maGiangVien, maLopHocPhan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThongTinGiangDayGiangVien_GetByNamHocHocKyMaGiangVienMaLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThongTinGiangDayGiangVien&gt;"/> instance.</returns>
		public TList<ThongTinGiangDayGiangVien> GetByNamHocHocKyMaGiangVienMaLopHocPhan(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maGiangVien, System.String maLopHocPhan)
		{
			return GetByNamHocHocKyMaGiangVienMaLopHocPhan(null, start, pageLength , namHoc, hocKy, maGiangVien, maLopHocPhan);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThongTinGiangDayGiangVien_GetByNamHocHocKyMaGiangVienMaLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThongTinGiangDayGiangVien&gt;"/> instance.</returns>
		public TList<ThongTinGiangDayGiangVien> GetByNamHocHocKyMaGiangVienMaLopHocPhan(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maGiangVien, System.String maLopHocPhan)
		{
			return GetByNamHocHocKyMaGiangVienMaLopHocPhan(transactionManager, 0, int.MaxValue , namHoc, hocKy, maGiangVien, maLopHocPhan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThongTinGiangDayGiangVien_GetByNamHocHocKyMaGiangVienMaLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThongTinGiangDayGiangVien&gt;"/> instance.</returns>
		public abstract TList<ThongTinGiangDayGiangVien> GetByNamHocHocKyMaGiangVienMaLopHocPhan(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maGiangVien, System.String maLopHocPhan);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ThongTinGiangDayGiangVien&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ThongTinGiangDayGiangVien&gt;"/></returns>
		public static TList<ThongTinGiangDayGiangVien> Fill(IDataReader reader, TList<ThongTinGiangDayGiangVien> rows, int start, int pageLength)
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
				
				PMS.Entities.ThongTinGiangDayGiangVien c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ThongTinGiangDayGiangVien")
					.Append("|").Append((System.String)reader[((int)ThongTinGiangDayGiangVienColumn.MaGiangVien - 1)])
					.Append("|").Append((System.String)reader[((int)ThongTinGiangDayGiangVienColumn.MaLopHocPhan - 1)]).ToString();
					c = EntityManager.LocateOrCreate<ThongTinGiangDayGiangVien>(
					key.ToString(), // EntityTrackingKey
					"ThongTinGiangDayGiangVien",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.ThongTinGiangDayGiangVien();
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
					c.MaGiangVien = (System.String)reader[(ThongTinGiangDayGiangVienColumn.MaGiangVien.ToString())];
					c.OriginalMaGiangVien = c.MaGiangVien;
					c.MaLopHocPhan = (System.String)reader[(ThongTinGiangDayGiangVienColumn.MaLopHocPhan.ToString())];
					c.OriginalMaLopHocPhan = c.MaLopHocPhan;
					c.SoLanDiLai = (reader[ThongTinGiangDayGiangVienColumn.SoLanDiLai.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThongTinGiangDayGiangVienColumn.SoLanDiLai.ToString())];
					c.SoNgayLuuTru = (reader[ThongTinGiangDayGiangVienColumn.SoNgayLuuTru.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThongTinGiangDayGiangVienColumn.SoNgayLuuTru.ToString())];
					c.NamHoc = (System.String)reader[(ThongTinGiangDayGiangVienColumn.NamHoc.ToString())];
					c.HocKy = (System.String)reader[(ThongTinGiangDayGiangVienColumn.HocKy.ToString())];
					c.ChiPhiLuuTru = (reader[ThongTinGiangDayGiangVienColumn.ChiPhiLuuTru.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThongTinGiangDayGiangVienColumn.ChiPhiLuuTru.ToString())];
					c.ChiPhiDiLai = (reader[ThongTinGiangDayGiangVienColumn.ChiPhiDiLai.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThongTinGiangDayGiangVienColumn.ChiPhiDiLai.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThongTinGiangDayGiangVien"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThongTinGiangDayGiangVien"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.ThongTinGiangDayGiangVien entity)
		{
			if (!reader.Read()) return;
			
			entity.MaGiangVien = (System.String)reader[(ThongTinGiangDayGiangVienColumn.MaGiangVien.ToString())];
			entity.OriginalMaGiangVien = (System.String)reader["MaGiangVien"];
			entity.MaLopHocPhan = (System.String)reader[(ThongTinGiangDayGiangVienColumn.MaLopHocPhan.ToString())];
			entity.OriginalMaLopHocPhan = (System.String)reader["MaLopHocPhan"];
			entity.SoLanDiLai = (reader[ThongTinGiangDayGiangVienColumn.SoLanDiLai.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThongTinGiangDayGiangVienColumn.SoLanDiLai.ToString())];
			entity.SoNgayLuuTru = (reader[ThongTinGiangDayGiangVienColumn.SoNgayLuuTru.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThongTinGiangDayGiangVienColumn.SoNgayLuuTru.ToString())];
			entity.NamHoc = (System.String)reader[(ThongTinGiangDayGiangVienColumn.NamHoc.ToString())];
			entity.HocKy = (System.String)reader[(ThongTinGiangDayGiangVienColumn.HocKy.ToString())];
			entity.ChiPhiLuuTru = (reader[ThongTinGiangDayGiangVienColumn.ChiPhiLuuTru.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThongTinGiangDayGiangVienColumn.ChiPhiLuuTru.ToString())];
			entity.ChiPhiDiLai = (reader[ThongTinGiangDayGiangVienColumn.ChiPhiDiLai.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThongTinGiangDayGiangVienColumn.ChiPhiDiLai.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThongTinGiangDayGiangVien"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThongTinGiangDayGiangVien"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.ThongTinGiangDayGiangVien entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (System.String)dataRow["MaGiangVien"];
			entity.OriginalMaGiangVien = (System.String)dataRow["MaGiangVien"];
			entity.MaLopHocPhan = (System.String)dataRow["MaLopHocPhan"];
			entity.OriginalMaLopHocPhan = (System.String)dataRow["MaLopHocPhan"];
			entity.SoLanDiLai = Convert.IsDBNull(dataRow["SoLanDiLai"]) ? null : (System.Int32?)dataRow["SoLanDiLai"];
			entity.SoNgayLuuTru = Convert.IsDBNull(dataRow["SoNgayLuuTru"]) ? null : (System.Int32?)dataRow["SoNgayLuuTru"];
			entity.NamHoc = (System.String)dataRow["NamHoc"];
			entity.HocKy = (System.String)dataRow["HocKy"];
			entity.ChiPhiLuuTru = Convert.IsDBNull(dataRow["ChiPhiLuuTru"]) ? null : (System.Decimal?)dataRow["ChiPhiLuuTru"];
			entity.ChiPhiDiLai = Convert.IsDBNull(dataRow["ChiPhiDiLai"]) ? null : (System.Decimal?)dataRow["ChiPhiDiLai"];
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
		/// <param name="entity">The <see cref="PMS.Entities.ThongTinGiangDayGiangVien"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.ThongTinGiangDayGiangVien Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.ThongTinGiangDayGiangVien entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.ThongTinGiangDayGiangVien object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.ThongTinGiangDayGiangVien instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.ThongTinGiangDayGiangVien Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.ThongTinGiangDayGiangVien entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region ThongTinGiangDayGiangVienChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.ThongTinGiangDayGiangVien</c>
	///</summary>
	public enum ThongTinGiangDayGiangVienChildEntityTypes
	{
	}
	
	#endregion ThongTinGiangDayGiangVienChildEntityTypes
	
	#region ThongTinGiangDayGiangVienFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ThongTinGiangDayGiangVienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThongTinGiangDayGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThongTinGiangDayGiangVienFilterBuilder : SqlFilterBuilder<ThongTinGiangDayGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThongTinGiangDayGiangVienFilterBuilder class.
		/// </summary>
		public ThongTinGiangDayGiangVienFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThongTinGiangDayGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThongTinGiangDayGiangVienFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThongTinGiangDayGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThongTinGiangDayGiangVienFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThongTinGiangDayGiangVienFilterBuilder
	
	#region ThongTinGiangDayGiangVienParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ThongTinGiangDayGiangVienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThongTinGiangDayGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThongTinGiangDayGiangVienParameterBuilder : ParameterizedSqlFilterBuilder<ThongTinGiangDayGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThongTinGiangDayGiangVienParameterBuilder class.
		/// </summary>
		public ThongTinGiangDayGiangVienParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThongTinGiangDayGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThongTinGiangDayGiangVienParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThongTinGiangDayGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThongTinGiangDayGiangVienParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThongTinGiangDayGiangVienParameterBuilder
	
	#region ThongTinGiangDayGiangVienSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ThongTinGiangDayGiangVienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThongTinGiangDayGiangVien"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ThongTinGiangDayGiangVienSortBuilder : SqlSortBuilder<ThongTinGiangDayGiangVienColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThongTinGiangDayGiangVienSqlSortBuilder class.
		/// </summary>
		public ThongTinGiangDayGiangVienSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ThongTinGiangDayGiangVienSortBuilder
	
} // end namespace
