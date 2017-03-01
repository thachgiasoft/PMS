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
	/// This class is the base class for any <see cref="PscExBarCodesProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PscExBarCodesProviderBaseCore : EntityProviderBase<PMS.Entities.PscExBarCodes, PMS.Entities.PscExBarCodesKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.PscExBarCodesKey key)
		{
			return Delete(transactionManager, key.MaLopHocPhan, key.KyThi, key.LanThi, key.BarCode);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maLopHocPhan">. Primary Key.</param>
		/// <param name="_kyThi">. Primary Key.</param>
		/// <param name="_lanThi">. Primary Key.</param>
		/// <param name="_barCode">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _maLopHocPhan, System.String _kyThi, System.Int32 _lanThi, System.String _barCode)
		{
			return Delete(null, _maLopHocPhan, _kyThi, _lanThi, _barCode);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLopHocPhan">. Primary Key.</param>
		/// <param name="_kyThi">. Primary Key.</param>
		/// <param name="_lanThi">. Primary Key.</param>
		/// <param name="_barCode">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _maLopHocPhan, System.String _kyThi, System.Int32 _lanThi, System.String _barCode);		
		
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
		public override PMS.Entities.PscExBarCodes Get(TransactionManager transactionManager, PMS.Entities.PscExBarCodesKey key, int start, int pageLength)
		{
			return GetByMaLopHocPhanKyThiLanThiBarCode(transactionManager, key.MaLopHocPhan, key.KyThi, key.LanThi, key.BarCode, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_psc_EX_BarCodes index.
		/// </summary>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_kyThi"></param>
		/// <param name="_lanThi"></param>
		/// <param name="_barCode"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PscExBarCodes"/> class.</returns>
		public PMS.Entities.PscExBarCodes GetByMaLopHocPhanKyThiLanThiBarCode(System.String _maLopHocPhan, System.String _kyThi, System.Int32 _lanThi, System.String _barCode)
		{
			int count = -1;
			return GetByMaLopHocPhanKyThiLanThiBarCode(null,_maLopHocPhan, _kyThi, _lanThi, _barCode, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_psc_EX_BarCodes index.
		/// </summary>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_kyThi"></param>
		/// <param name="_lanThi"></param>
		/// <param name="_barCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PscExBarCodes"/> class.</returns>
		public PMS.Entities.PscExBarCodes GetByMaLopHocPhanKyThiLanThiBarCode(System.String _maLopHocPhan, System.String _kyThi, System.Int32 _lanThi, System.String _barCode, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLopHocPhanKyThiLanThiBarCode(null, _maLopHocPhan, _kyThi, _lanThi, _barCode, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_psc_EX_BarCodes index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_kyThi"></param>
		/// <param name="_lanThi"></param>
		/// <param name="_barCode"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PscExBarCodes"/> class.</returns>
		public PMS.Entities.PscExBarCodes GetByMaLopHocPhanKyThiLanThiBarCode(TransactionManager transactionManager, System.String _maLopHocPhan, System.String _kyThi, System.Int32 _lanThi, System.String _barCode)
		{
			int count = -1;
			return GetByMaLopHocPhanKyThiLanThiBarCode(transactionManager, _maLopHocPhan, _kyThi, _lanThi, _barCode, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_psc_EX_BarCodes index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_kyThi"></param>
		/// <param name="_lanThi"></param>
		/// <param name="_barCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PscExBarCodes"/> class.</returns>
		public PMS.Entities.PscExBarCodes GetByMaLopHocPhanKyThiLanThiBarCode(TransactionManager transactionManager, System.String _maLopHocPhan, System.String _kyThi, System.Int32 _lanThi, System.String _barCode, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLopHocPhanKyThiLanThiBarCode(transactionManager, _maLopHocPhan, _kyThi, _lanThi, _barCode, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_psc_EX_BarCodes index.
		/// </summary>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_kyThi"></param>
		/// <param name="_lanThi"></param>
		/// <param name="_barCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PscExBarCodes"/> class.</returns>
		public PMS.Entities.PscExBarCodes GetByMaLopHocPhanKyThiLanThiBarCode(System.String _maLopHocPhan, System.String _kyThi, System.Int32 _lanThi, System.String _barCode, int start, int pageLength, out int count)
		{
			return GetByMaLopHocPhanKyThiLanThiBarCode(null, _maLopHocPhan, _kyThi, _lanThi, _barCode, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_psc_EX_BarCodes index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_kyThi"></param>
		/// <param name="_lanThi"></param>
		/// <param name="_barCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PscExBarCodes"/> class.</returns>
		public abstract PMS.Entities.PscExBarCodes GetByMaLopHocPhanKyThiLanThiBarCode(TransactionManager transactionManager, System.String _maLopHocPhan, System.String _kyThi, System.Int32 _lanThi, System.String _barCode, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PscExBarCodes&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PscExBarCodes&gt;"/></returns>
		public static TList<PscExBarCodes> Fill(IDataReader reader, TList<PscExBarCodes> rows, int start, int pageLength)
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
				
				PMS.Entities.PscExBarCodes c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PscExBarCodes")
					.Append("|").Append((System.String)reader[((int)PscExBarCodesColumn.MaLopHocPhan - 1)])
					.Append("|").Append((System.String)reader[((int)PscExBarCodesColumn.KyThi - 1)])
					.Append("|").Append((System.Int32)reader[((int)PscExBarCodesColumn.LanThi - 1)])
					.Append("|").Append((System.String)reader[((int)PscExBarCodesColumn.BarCode - 1)]).ToString();
					c = EntityManager.LocateOrCreate<PscExBarCodes>(
					key.ToString(), // EntityTrackingKey
					"PscExBarCodes",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.PscExBarCodes();
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
					c.MaLopHocPhan = (System.String)reader[(PscExBarCodesColumn.MaLopHocPhan.ToString())];
					c.OriginalMaLopHocPhan = c.MaLopHocPhan;
					c.KyThi = (System.String)reader[(PscExBarCodesColumn.KyThi.ToString())];
					c.OriginalKyThi = c.KyThi;
					c.LanThi = (System.Int32)reader[(PscExBarCodesColumn.LanThi.ToString())];
					c.OriginalLanThi = c.LanThi;
					c.BarCode = (System.String)reader[(PscExBarCodesColumn.BarCode.ToString())];
					c.OriginalBarCode = c.BarCode;
					c.MaNhanDang = (reader[PscExBarCodesColumn.MaNhanDang.ToString()] == DBNull.Value) ? null : (System.String)reader[(PscExBarCodesColumn.MaNhanDang.ToString())];
					c.GiaoBai = (reader[PscExBarCodesColumn.GiaoBai.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(PscExBarCodesColumn.GiaoBai.ToString())];
					c.NhanBai = (reader[PscExBarCodesColumn.NhanBai.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(PscExBarCodesColumn.NhanBai.ToString())];
					c.GhiChu = (reader[PscExBarCodesColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(PscExBarCodesColumn.GhiChu.ToString())];
					c.UpdateDate = (reader[PscExBarCodesColumn.UpdateDate.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(PscExBarCodesColumn.UpdateDate.ToString())];
					c.UpdateStaff = (reader[PscExBarCodesColumn.UpdateStaff.ToString()] == DBNull.Value) ? null : (System.String)reader[(PscExBarCodesColumn.UpdateStaff.ToString())];
					c.NgayNhan = (reader[PscExBarCodesColumn.NgayNhan.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(PscExBarCodesColumn.NgayNhan.ToString())];
					c.NguoiNhan = (reader[PscExBarCodesColumn.NguoiNhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(PscExBarCodesColumn.NguoiNhan.ToString())];
					c.NgayGiao = (reader[PscExBarCodesColumn.NgayGiao.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(PscExBarCodesColumn.NgayGiao.ToString())];
					c.NguoiGiao = (reader[PscExBarCodesColumn.NguoiGiao.ToString()] == DBNull.Value) ? null : (System.String)reader[(PscExBarCodesColumn.NguoiGiao.ToString())];
					c.DaGuiMailNhacGiaoBai = (reader[PscExBarCodesColumn.DaGuiMailNhacGiaoBai.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(PscExBarCodesColumn.DaGuiMailNhacGiaoBai.ToString())];
					c.DaGuiMailNhacThuHoiBai = (reader[PscExBarCodesColumn.DaGuiMailNhacThuHoiBai.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(PscExBarCodesColumn.DaGuiMailNhacThuHoiBai.ToString())];
					c.DaGuiMailNhacNhanBai = (reader[PscExBarCodesColumn.DaGuiMailNhacNhanBai.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(PscExBarCodesColumn.DaGuiMailNhacNhanBai.ToString())];
					c.SoBai = (reader[PscExBarCodesColumn.SoBai.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(PscExBarCodesColumn.SoBai.ToString())];
					c.SoTo = (reader[PscExBarCodesColumn.SoTo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(PscExBarCodesColumn.SoTo.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.PscExBarCodes"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.PscExBarCodes"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.PscExBarCodes entity)
		{
			if (!reader.Read()) return;
			
			entity.MaLopHocPhan = (System.String)reader[(PscExBarCodesColumn.MaLopHocPhan.ToString())];
			entity.OriginalMaLopHocPhan = (System.String)reader["MaLopHocPhan"];
			entity.KyThi = (System.String)reader[(PscExBarCodesColumn.KyThi.ToString())];
			entity.OriginalKyThi = (System.String)reader["KyThi"];
			entity.LanThi = (System.Int32)reader[(PscExBarCodesColumn.LanThi.ToString())];
			entity.OriginalLanThi = (System.Int32)reader["LanThi"];
			entity.BarCode = (System.String)reader[(PscExBarCodesColumn.BarCode.ToString())];
			entity.OriginalBarCode = (System.String)reader["BarCode"];
			entity.MaNhanDang = (reader[PscExBarCodesColumn.MaNhanDang.ToString()] == DBNull.Value) ? null : (System.String)reader[(PscExBarCodesColumn.MaNhanDang.ToString())];
			entity.GiaoBai = (reader[PscExBarCodesColumn.GiaoBai.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(PscExBarCodesColumn.GiaoBai.ToString())];
			entity.NhanBai = (reader[PscExBarCodesColumn.NhanBai.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(PscExBarCodesColumn.NhanBai.ToString())];
			entity.GhiChu = (reader[PscExBarCodesColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(PscExBarCodesColumn.GhiChu.ToString())];
			entity.UpdateDate = (reader[PscExBarCodesColumn.UpdateDate.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(PscExBarCodesColumn.UpdateDate.ToString())];
			entity.UpdateStaff = (reader[PscExBarCodesColumn.UpdateStaff.ToString()] == DBNull.Value) ? null : (System.String)reader[(PscExBarCodesColumn.UpdateStaff.ToString())];
			entity.NgayNhan = (reader[PscExBarCodesColumn.NgayNhan.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(PscExBarCodesColumn.NgayNhan.ToString())];
			entity.NguoiNhan = (reader[PscExBarCodesColumn.NguoiNhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(PscExBarCodesColumn.NguoiNhan.ToString())];
			entity.NgayGiao = (reader[PscExBarCodesColumn.NgayGiao.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(PscExBarCodesColumn.NgayGiao.ToString())];
			entity.NguoiGiao = (reader[PscExBarCodesColumn.NguoiGiao.ToString()] == DBNull.Value) ? null : (System.String)reader[(PscExBarCodesColumn.NguoiGiao.ToString())];
			entity.DaGuiMailNhacGiaoBai = (reader[PscExBarCodesColumn.DaGuiMailNhacGiaoBai.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(PscExBarCodesColumn.DaGuiMailNhacGiaoBai.ToString())];
			entity.DaGuiMailNhacThuHoiBai = (reader[PscExBarCodesColumn.DaGuiMailNhacThuHoiBai.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(PscExBarCodesColumn.DaGuiMailNhacThuHoiBai.ToString())];
			entity.DaGuiMailNhacNhanBai = (reader[PscExBarCodesColumn.DaGuiMailNhacNhanBai.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(PscExBarCodesColumn.DaGuiMailNhacNhanBai.ToString())];
			entity.SoBai = (reader[PscExBarCodesColumn.SoBai.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(PscExBarCodesColumn.SoBai.ToString())];
			entity.SoTo = (reader[PscExBarCodesColumn.SoTo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(PscExBarCodesColumn.SoTo.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.PscExBarCodes"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.PscExBarCodes"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.PscExBarCodes entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaLopHocPhan = (System.String)dataRow["MaLopHocPhan"];
			entity.OriginalMaLopHocPhan = (System.String)dataRow["MaLopHocPhan"];
			entity.KyThi = (System.String)dataRow["KyThi"];
			entity.OriginalKyThi = (System.String)dataRow["KyThi"];
			entity.LanThi = (System.Int32)dataRow["LanThi"];
			entity.OriginalLanThi = (System.Int32)dataRow["LanThi"];
			entity.BarCode = (System.String)dataRow["BarCode"];
			entity.OriginalBarCode = (System.String)dataRow["BarCode"];
			entity.MaNhanDang = Convert.IsDBNull(dataRow["MaNhanDang"]) ? null : (System.String)dataRow["MaNhanDang"];
			entity.GiaoBai = Convert.IsDBNull(dataRow["GiaoBai"]) ? null : (System.Boolean?)dataRow["GiaoBai"];
			entity.NhanBai = Convert.IsDBNull(dataRow["NhanBai"]) ? null : (System.Boolean?)dataRow["NhanBai"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.UpdateDate = Convert.IsDBNull(dataRow["UpdateDate"]) ? null : (System.DateTime?)dataRow["UpdateDate"];
			entity.UpdateStaff = Convert.IsDBNull(dataRow["UpdateStaff"]) ? null : (System.String)dataRow["UpdateStaff"];
			entity.NgayNhan = Convert.IsDBNull(dataRow["NgayNhan"]) ? null : (System.DateTime?)dataRow["NgayNhan"];
			entity.NguoiNhan = Convert.IsDBNull(dataRow["NguoiNhan"]) ? null : (System.String)dataRow["NguoiNhan"];
			entity.NgayGiao = Convert.IsDBNull(dataRow["NgayGiao"]) ? null : (System.DateTime?)dataRow["NgayGiao"];
			entity.NguoiGiao = Convert.IsDBNull(dataRow["NguoiGiao"]) ? null : (System.String)dataRow["NguoiGiao"];
			entity.DaGuiMailNhacGiaoBai = Convert.IsDBNull(dataRow["DaGuiMailNhacGiaoBai"]) ? null : (System.Boolean?)dataRow["DaGuiMailNhacGiaoBai"];
			entity.DaGuiMailNhacThuHoiBai = Convert.IsDBNull(dataRow["DaGuiMailNhacThuHoiBai"]) ? null : (System.Boolean?)dataRow["DaGuiMailNhacThuHoiBai"];
			entity.DaGuiMailNhacNhanBai = Convert.IsDBNull(dataRow["DaGuiMailNhacNhanBai"]) ? null : (System.Boolean?)dataRow["DaGuiMailNhacNhanBai"];
			entity.SoBai = Convert.IsDBNull(dataRow["SoBai"]) ? null : (System.Int32?)dataRow["SoBai"];
			entity.SoTo = Convert.IsDBNull(dataRow["SoTo"]) ? null : (System.Int32?)dataRow["SoTo"];
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
		/// <param name="entity">The <see cref="PMS.Entities.PscExBarCodes"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.PscExBarCodes Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.PscExBarCodes entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.PscExBarCodes object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.PscExBarCodes instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.PscExBarCodes Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.PscExBarCodes entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region PscExBarCodesChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.PscExBarCodes</c>
	///</summary>
	public enum PscExBarCodesChildEntityTypes
	{
	}
	
	#endregion PscExBarCodesChildEntityTypes
	
	#region PscExBarCodesFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PscExBarCodesColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PscExBarCodes"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PscExBarCodesFilterBuilder : SqlFilterBuilder<PscExBarCodesColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PscExBarCodesFilterBuilder class.
		/// </summary>
		public PscExBarCodesFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PscExBarCodesFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PscExBarCodesFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PscExBarCodesFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PscExBarCodesFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PscExBarCodesFilterBuilder
	
	#region PscExBarCodesParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PscExBarCodesColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PscExBarCodes"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PscExBarCodesParameterBuilder : ParameterizedSqlFilterBuilder<PscExBarCodesColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PscExBarCodesParameterBuilder class.
		/// </summary>
		public PscExBarCodesParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PscExBarCodesParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PscExBarCodesParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PscExBarCodesParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PscExBarCodesParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PscExBarCodesParameterBuilder
	
	#region PscExBarCodesSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PscExBarCodesColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PscExBarCodes"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PscExBarCodesSortBuilder : SqlSortBuilder<PscExBarCodesColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PscExBarCodesSqlSortBuilder class.
		/// </summary>
		public PscExBarCodesSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PscExBarCodesSortBuilder
	
} // end namespace
