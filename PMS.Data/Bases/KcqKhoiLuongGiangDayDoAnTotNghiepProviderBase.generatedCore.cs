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
	/// This class is the base class for any <see cref="KcqKhoiLuongGiangDayDoAnTotNghiepProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KcqKhoiLuongGiangDayDoAnTotNghiepProviderBaseCore : EntityProviderBase<PMS.Entities.KcqKhoiLuongGiangDayDoAnTotNghiep, PMS.Entities.KcqKhoiLuongGiangDayDoAnTotNghiepKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KcqKhoiLuongGiangDayDoAnTotNghiepKey key)
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
		public override PMS.Entities.KcqKhoiLuongGiangDayDoAnTotNghiep Get(TransactionManager transactionManager, PMS.Entities.KcqKhoiLuongGiangDayDoAnTotNghiepKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KcqKhoiLuongGiangDayDoAnTotNghiep index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongGiangDayDoAnTotNghiep"/> class.</returns>
		public PMS.Entities.KcqKhoiLuongGiangDayDoAnTotNghiep GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqKhoiLuongGiangDayDoAnTotNghiep index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongGiangDayDoAnTotNghiep"/> class.</returns>
		public PMS.Entities.KcqKhoiLuongGiangDayDoAnTotNghiep GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqKhoiLuongGiangDayDoAnTotNghiep index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongGiangDayDoAnTotNghiep"/> class.</returns>
		public PMS.Entities.KcqKhoiLuongGiangDayDoAnTotNghiep GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqKhoiLuongGiangDayDoAnTotNghiep index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongGiangDayDoAnTotNghiep"/> class.</returns>
		public PMS.Entities.KcqKhoiLuongGiangDayDoAnTotNghiep GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqKhoiLuongGiangDayDoAnTotNghiep index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongGiangDayDoAnTotNghiep"/> class.</returns>
		public PMS.Entities.KcqKhoiLuongGiangDayDoAnTotNghiep GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqKhoiLuongGiangDayDoAnTotNghiep index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongGiangDayDoAnTotNghiep"/> class.</returns>
		public abstract PMS.Entities.KcqKhoiLuongGiangDayDoAnTotNghiep GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_KcqKhoiLuongGiangDayDoAnTotNghiep_DongBo 
		
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongGiangDayDoAnTotNghiep_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader DongBo(System.String namHoc, System.String hocKy)
		{
			return DongBo(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongGiangDayDoAnTotNghiep_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader DongBo(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return DongBo(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongGiangDayDoAnTotNghiep_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader DongBo(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return DongBo(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongGiangDayDoAnTotNghiep_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader DongBo(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KcqKhoiLuongGiangDayDoAnTotNghiep&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KcqKhoiLuongGiangDayDoAnTotNghiep&gt;"/></returns>
		public static TList<KcqKhoiLuongGiangDayDoAnTotNghiep> Fill(IDataReader reader, TList<KcqKhoiLuongGiangDayDoAnTotNghiep> rows, int start, int pageLength)
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
				
				PMS.Entities.KcqKhoiLuongGiangDayDoAnTotNghiep c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KcqKhoiLuongGiangDayDoAnTotNghiep")
					.Append("|").Append((System.Int32)reader[((int)KcqKhoiLuongGiangDayDoAnTotNghiepColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KcqKhoiLuongGiangDayDoAnTotNghiep>(
					key.ToString(), // EntityTrackingKey
					"KcqKhoiLuongGiangDayDoAnTotNghiep",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KcqKhoiLuongGiangDayDoAnTotNghiep();
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
					c.Id = (System.Int32)reader[(KcqKhoiLuongGiangDayDoAnTotNghiepColumn.Id.ToString())];
					c.MaMonHoc = (reader[KcqKhoiLuongGiangDayDoAnTotNghiepColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnTotNghiepColumn.MaMonHoc.ToString())];
					c.TenMonHoc = (reader[KcqKhoiLuongGiangDayDoAnTotNghiepColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnTotNghiepColumn.TenMonHoc.ToString())];
					c.MaHocPhan = (reader[KcqKhoiLuongGiangDayDoAnTotNghiepColumn.MaHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnTotNghiepColumn.MaHocPhan.ToString())];
					c.NamHoc = (reader[KcqKhoiLuongGiangDayDoAnTotNghiepColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnTotNghiepColumn.NamHoc.ToString())];
					c.HocKy = (reader[KcqKhoiLuongGiangDayDoAnTotNghiepColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnTotNghiepColumn.HocKy.ToString())];
					c.MaLopHocPhan = (reader[KcqKhoiLuongGiangDayDoAnTotNghiepColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnTotNghiepColumn.MaLopHocPhan.ToString())];
					c.Nhom = (reader[KcqKhoiLuongGiangDayDoAnTotNghiepColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnTotNghiepColumn.Nhom.ToString())];
					c.MaLop = (reader[KcqKhoiLuongGiangDayDoAnTotNghiepColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnTotNghiepColumn.MaLop.ToString())];
					c.SoTinChi = (reader[KcqKhoiLuongGiangDayDoAnTotNghiepColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongGiangDayDoAnTotNghiepColumn.SoTinChi.ToString())];
					c.LopClc = (reader[KcqKhoiLuongGiangDayDoAnTotNghiepColumn.LopClc.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KcqKhoiLuongGiangDayDoAnTotNghiepColumn.LopClc.ToString())];
					c.SiSo = (reader[KcqKhoiLuongGiangDayDoAnTotNghiepColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongGiangDayDoAnTotNghiepColumn.SiSo.ToString())];
					c.NgayCapNhat = (reader[KcqKhoiLuongGiangDayDoAnTotNghiepColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KcqKhoiLuongGiangDayDoAnTotNghiepColumn.NgayCapNhat.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqKhoiLuongGiangDayDoAnTotNghiep"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqKhoiLuongGiangDayDoAnTotNghiep"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KcqKhoiLuongGiangDayDoAnTotNghiep entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(KcqKhoiLuongGiangDayDoAnTotNghiepColumn.Id.ToString())];
			entity.MaMonHoc = (reader[KcqKhoiLuongGiangDayDoAnTotNghiepColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnTotNghiepColumn.MaMonHoc.ToString())];
			entity.TenMonHoc = (reader[KcqKhoiLuongGiangDayDoAnTotNghiepColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnTotNghiepColumn.TenMonHoc.ToString())];
			entity.MaHocPhan = (reader[KcqKhoiLuongGiangDayDoAnTotNghiepColumn.MaHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnTotNghiepColumn.MaHocPhan.ToString())];
			entity.NamHoc = (reader[KcqKhoiLuongGiangDayDoAnTotNghiepColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnTotNghiepColumn.NamHoc.ToString())];
			entity.HocKy = (reader[KcqKhoiLuongGiangDayDoAnTotNghiepColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnTotNghiepColumn.HocKy.ToString())];
			entity.MaLopHocPhan = (reader[KcqKhoiLuongGiangDayDoAnTotNghiepColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnTotNghiepColumn.MaLopHocPhan.ToString())];
			entity.Nhom = (reader[KcqKhoiLuongGiangDayDoAnTotNghiepColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnTotNghiepColumn.Nhom.ToString())];
			entity.MaLop = (reader[KcqKhoiLuongGiangDayDoAnTotNghiepColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnTotNghiepColumn.MaLop.ToString())];
			entity.SoTinChi = (reader[KcqKhoiLuongGiangDayDoAnTotNghiepColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongGiangDayDoAnTotNghiepColumn.SoTinChi.ToString())];
			entity.LopClc = (reader[KcqKhoiLuongGiangDayDoAnTotNghiepColumn.LopClc.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KcqKhoiLuongGiangDayDoAnTotNghiepColumn.LopClc.ToString())];
			entity.SiSo = (reader[KcqKhoiLuongGiangDayDoAnTotNghiepColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongGiangDayDoAnTotNghiepColumn.SiSo.ToString())];
			entity.NgayCapNhat = (reader[KcqKhoiLuongGiangDayDoAnTotNghiepColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KcqKhoiLuongGiangDayDoAnTotNghiepColumn.NgayCapNhat.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqKhoiLuongGiangDayDoAnTotNghiep"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqKhoiLuongGiangDayDoAnTotNghiep"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KcqKhoiLuongGiangDayDoAnTotNghiep entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = Convert.IsDBNull(dataRow["TenMonHoc"]) ? null : (System.String)dataRow["TenMonHoc"];
			entity.MaHocPhan = Convert.IsDBNull(dataRow["MaHocPhan"]) ? null : (System.String)dataRow["MaHocPhan"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.Nhom = Convert.IsDBNull(dataRow["Nhom"]) ? null : (System.String)dataRow["Nhom"];
			entity.MaLop = Convert.IsDBNull(dataRow["MaLop"]) ? null : (System.String)dataRow["MaLop"];
			entity.SoTinChi = Convert.IsDBNull(dataRow["SoTinChi"]) ? null : (System.Int32?)dataRow["SoTinChi"];
			entity.LopClc = Convert.IsDBNull(dataRow["LopClc"]) ? null : (System.Boolean?)dataRow["LopClc"];
			entity.SiSo = Convert.IsDBNull(dataRow["SiSo"]) ? null : (System.Int32?)dataRow["SiSo"];
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
		/// <param name="entity">The <see cref="PMS.Entities.KcqKhoiLuongGiangDayDoAnTotNghiep"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KcqKhoiLuongGiangDayDoAnTotNghiep Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KcqKhoiLuongGiangDayDoAnTotNghiep entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.KcqKhoiLuongGiangDayDoAnTotNghiep object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KcqKhoiLuongGiangDayDoAnTotNghiep instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KcqKhoiLuongGiangDayDoAnTotNghiep Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KcqKhoiLuongGiangDayDoAnTotNghiep entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region KcqKhoiLuongGiangDayDoAnTotNghiepChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KcqKhoiLuongGiangDayDoAnTotNghiep</c>
	///</summary>
	public enum KcqKhoiLuongGiangDayDoAnTotNghiepChildEntityTypes
	{
	}
	
	#endregion KcqKhoiLuongGiangDayDoAnTotNghiepChildEntityTypes
	
	#region KcqKhoiLuongGiangDayDoAnTotNghiepFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KcqKhoiLuongGiangDayDoAnTotNghiepColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongGiangDayDoAnTotNghiep"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKhoiLuongGiangDayDoAnTotNghiepFilterBuilder : SqlFilterBuilder<KcqKhoiLuongGiangDayDoAnTotNghiepColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayDoAnTotNghiepFilterBuilder class.
		/// </summary>
		public KcqKhoiLuongGiangDayDoAnTotNghiepFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayDoAnTotNghiepFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqKhoiLuongGiangDayDoAnTotNghiepFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayDoAnTotNghiepFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqKhoiLuongGiangDayDoAnTotNghiepFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqKhoiLuongGiangDayDoAnTotNghiepFilterBuilder
	
	#region KcqKhoiLuongGiangDayDoAnTotNghiepParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KcqKhoiLuongGiangDayDoAnTotNghiepColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongGiangDayDoAnTotNghiep"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKhoiLuongGiangDayDoAnTotNghiepParameterBuilder : ParameterizedSqlFilterBuilder<KcqKhoiLuongGiangDayDoAnTotNghiepColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayDoAnTotNghiepParameterBuilder class.
		/// </summary>
		public KcqKhoiLuongGiangDayDoAnTotNghiepParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayDoAnTotNghiepParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqKhoiLuongGiangDayDoAnTotNghiepParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayDoAnTotNghiepParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqKhoiLuongGiangDayDoAnTotNghiepParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqKhoiLuongGiangDayDoAnTotNghiepParameterBuilder
	
	#region KcqKhoiLuongGiangDayDoAnTotNghiepSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KcqKhoiLuongGiangDayDoAnTotNghiepColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongGiangDayDoAnTotNghiep"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KcqKhoiLuongGiangDayDoAnTotNghiepSortBuilder : SqlSortBuilder<KcqKhoiLuongGiangDayDoAnTotNghiepColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayDoAnTotNghiepSqlSortBuilder class.
		/// </summary>
		public KcqKhoiLuongGiangDayDoAnTotNghiepSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KcqKhoiLuongGiangDayDoAnTotNghiepSortBuilder
	
} // end namespace
