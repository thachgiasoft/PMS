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
	/// This class is the base class for any <see cref="KetQuaCacKhoanChiKhacProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KetQuaCacKhoanChiKhacProviderBaseCore : EntityProviderBase<PMS.Entities.KetQuaCacKhoanChiKhac, PMS.Entities.KetQuaCacKhoanChiKhacKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KetQuaCacKhoanChiKhacKey key)
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
		public override PMS.Entities.KetQuaCacKhoanChiKhac Get(TransactionManager transactionManager, PMS.Entities.KetQuaCacKhoanChiKhacKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KetQuaCacKhoanChiKhac index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaCacKhoanChiKhac"/> class.</returns>
		public PMS.Entities.KetQuaCacKhoanChiKhac GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KetQuaCacKhoanChiKhac index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaCacKhoanChiKhac"/> class.</returns>
		public PMS.Entities.KetQuaCacKhoanChiKhac GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KetQuaCacKhoanChiKhac index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaCacKhoanChiKhac"/> class.</returns>
		public PMS.Entities.KetQuaCacKhoanChiKhac GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KetQuaCacKhoanChiKhac index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaCacKhoanChiKhac"/> class.</returns>
		public PMS.Entities.KetQuaCacKhoanChiKhac GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KetQuaCacKhoanChiKhac index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaCacKhoanChiKhac"/> class.</returns>
		public PMS.Entities.KetQuaCacKhoanChiKhac GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KetQuaCacKhoanChiKhac index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaCacKhoanChiKhac"/> class.</returns>
		public abstract PMS.Entities.KetQuaCacKhoanChiKhac GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_KetQuaCacKhoanChiKhac_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaCacKhoanChiKhac_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, System.DateTime tuNgay, System.DateTime denNgay, ref System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , xmlData, tuNgay, denNgay, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaCacKhoanChiKhac_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, System.DateTime tuNgay, System.DateTime denNgay, ref System.Int32 reVal)
		{
			 Luu(null, start, pageLength , xmlData, tuNgay, denNgay, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaCacKhoanChiKhac_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, System.DateTime tuNgay, System.DateTime denNgay, ref System.Int32 reVal)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, tuNgay, denNgay, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaCacKhoanChiKhac_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.DateTime tuNgay, System.DateTime denNgay, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KetQuaCacKhoanChiKhac&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KetQuaCacKhoanChiKhac&gt;"/></returns>
		public static TList<KetQuaCacKhoanChiKhac> Fill(IDataReader reader, TList<KetQuaCacKhoanChiKhac> rows, int start, int pageLength)
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
				
				PMS.Entities.KetQuaCacKhoanChiKhac c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KetQuaCacKhoanChiKhac")
					.Append("|").Append((System.Int32)reader[((int)KetQuaCacKhoanChiKhacColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KetQuaCacKhoanChiKhac>(
					key.ToString(), // EntityTrackingKey
					"KetQuaCacKhoanChiKhac",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KetQuaCacKhoanChiKhac();
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
					c.Id = (System.Int32)reader[(KetQuaCacKhoanChiKhacColumn.Id.ToString())];
					c.MaGiangVienQuanLy = (reader[KetQuaCacKhoanChiKhacColumn.MaGiangVienQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaCacKhoanChiKhacColumn.MaGiangVienQuanLy.ToString())];
					c.Lop = (reader[KetQuaCacKhoanChiKhacColumn.Lop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaCacKhoanChiKhacColumn.Lop.ToString())];
					c.MaSo = (reader[KetQuaCacKhoanChiKhacColumn.MaSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaCacKhoanChiKhacColumn.MaSo.ToString())];
					c.Ngay = (reader[KetQuaCacKhoanChiKhacColumn.Ngay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KetQuaCacKhoanChiKhacColumn.Ngay.ToString())];
					c.NoiDung = (reader[KetQuaCacKhoanChiKhacColumn.NoiDung.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaCacKhoanChiKhacColumn.NoiDung.ToString())];
					c.HeSo = (reader[KetQuaCacKhoanChiKhacColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaCacKhoanChiKhacColumn.HeSo.ToString())];
					c.SoTiet = (reader[KetQuaCacKhoanChiKhacColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaCacKhoanChiKhacColumn.SoTiet.ToString())];
					c.TienMotTiet = (reader[KetQuaCacKhoanChiKhacColumn.TienMotTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaCacKhoanChiKhacColumn.TienMotTiet.ToString())];
					c.ThanhTien = (reader[KetQuaCacKhoanChiKhacColumn.ThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaCacKhoanChiKhacColumn.ThanhTien.ToString())];
					c.PhiCongTac = (reader[KetQuaCacKhoanChiKhacColumn.PhiCongTac.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaCacKhoanChiKhacColumn.PhiCongTac.ToString())];
					c.TienGiangNgoaiGio = (reader[KetQuaCacKhoanChiKhacColumn.TienGiangNgoaiGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaCacKhoanChiKhacColumn.TienGiangNgoaiGio.ToString())];
					c.TongThanhTien = (reader[KetQuaCacKhoanChiKhacColumn.TongThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaCacKhoanChiKhacColumn.TongThanhTien.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KetQuaCacKhoanChiKhac"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KetQuaCacKhoanChiKhac"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KetQuaCacKhoanChiKhac entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(KetQuaCacKhoanChiKhacColumn.Id.ToString())];
			entity.MaGiangVienQuanLy = (reader[KetQuaCacKhoanChiKhacColumn.MaGiangVienQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaCacKhoanChiKhacColumn.MaGiangVienQuanLy.ToString())];
			entity.Lop = (reader[KetQuaCacKhoanChiKhacColumn.Lop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaCacKhoanChiKhacColumn.Lop.ToString())];
			entity.MaSo = (reader[KetQuaCacKhoanChiKhacColumn.MaSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaCacKhoanChiKhacColumn.MaSo.ToString())];
			entity.Ngay = (reader[KetQuaCacKhoanChiKhacColumn.Ngay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KetQuaCacKhoanChiKhacColumn.Ngay.ToString())];
			entity.NoiDung = (reader[KetQuaCacKhoanChiKhacColumn.NoiDung.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaCacKhoanChiKhacColumn.NoiDung.ToString())];
			entity.HeSo = (reader[KetQuaCacKhoanChiKhacColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaCacKhoanChiKhacColumn.HeSo.ToString())];
			entity.SoTiet = (reader[KetQuaCacKhoanChiKhacColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaCacKhoanChiKhacColumn.SoTiet.ToString())];
			entity.TienMotTiet = (reader[KetQuaCacKhoanChiKhacColumn.TienMotTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaCacKhoanChiKhacColumn.TienMotTiet.ToString())];
			entity.ThanhTien = (reader[KetQuaCacKhoanChiKhacColumn.ThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaCacKhoanChiKhacColumn.ThanhTien.ToString())];
			entity.PhiCongTac = (reader[KetQuaCacKhoanChiKhacColumn.PhiCongTac.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaCacKhoanChiKhacColumn.PhiCongTac.ToString())];
			entity.TienGiangNgoaiGio = (reader[KetQuaCacKhoanChiKhacColumn.TienGiangNgoaiGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaCacKhoanChiKhacColumn.TienGiangNgoaiGio.ToString())];
			entity.TongThanhTien = (reader[KetQuaCacKhoanChiKhacColumn.TongThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaCacKhoanChiKhacColumn.TongThanhTien.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KetQuaCacKhoanChiKhac"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KetQuaCacKhoanChiKhac"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KetQuaCacKhoanChiKhac entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaGiangVienQuanLy = Convert.IsDBNull(dataRow["MaGiangVienQuanLy"]) ? null : (System.String)dataRow["MaGiangVienQuanLy"];
			entity.Lop = Convert.IsDBNull(dataRow["Lop"]) ? null : (System.String)dataRow["Lop"];
			entity.MaSo = Convert.IsDBNull(dataRow["MaSo"]) ? null : (System.String)dataRow["MaSo"];
			entity.Ngay = Convert.IsDBNull(dataRow["Ngay"]) ? null : (System.DateTime?)dataRow["Ngay"];
			entity.NoiDung = Convert.IsDBNull(dataRow["NoiDung"]) ? null : (System.String)dataRow["NoiDung"];
			entity.HeSo = Convert.IsDBNull(dataRow["HeSo"]) ? null : (System.Decimal?)dataRow["HeSo"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Decimal?)dataRow["SoTiet"];
			entity.TienMotTiet = Convert.IsDBNull(dataRow["TienMotTiet"]) ? null : (System.Decimal?)dataRow["TienMotTiet"];
			entity.ThanhTien = Convert.IsDBNull(dataRow["ThanhTien"]) ? null : (System.Decimal?)dataRow["ThanhTien"];
			entity.PhiCongTac = Convert.IsDBNull(dataRow["PhiCongTac"]) ? null : (System.Decimal?)dataRow["PhiCongTac"];
			entity.TienGiangNgoaiGio = Convert.IsDBNull(dataRow["TienGiangNgoaiGio"]) ? null : (System.Decimal?)dataRow["TienGiangNgoaiGio"];
			entity.TongThanhTien = Convert.IsDBNull(dataRow["TongThanhTien"]) ? null : (System.Decimal?)dataRow["TongThanhTien"];
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
		/// <param name="entity">The <see cref="PMS.Entities.KetQuaCacKhoanChiKhac"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KetQuaCacKhoanChiKhac Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KetQuaCacKhoanChiKhac entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.KetQuaCacKhoanChiKhac object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KetQuaCacKhoanChiKhac instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KetQuaCacKhoanChiKhac Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KetQuaCacKhoanChiKhac entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region KetQuaCacKhoanChiKhacChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KetQuaCacKhoanChiKhac</c>
	///</summary>
	public enum KetQuaCacKhoanChiKhacChildEntityTypes
	{
	}
	
	#endregion KetQuaCacKhoanChiKhacChildEntityTypes
	
	#region KetQuaCacKhoanChiKhacFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KetQuaCacKhoanChiKhacColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KetQuaCacKhoanChiKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KetQuaCacKhoanChiKhacFilterBuilder : SqlFilterBuilder<KetQuaCacKhoanChiKhacColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KetQuaCacKhoanChiKhacFilterBuilder class.
		/// </summary>
		public KetQuaCacKhoanChiKhacFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KetQuaCacKhoanChiKhacFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KetQuaCacKhoanChiKhacFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KetQuaCacKhoanChiKhacFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KetQuaCacKhoanChiKhacFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KetQuaCacKhoanChiKhacFilterBuilder
	
	#region KetQuaCacKhoanChiKhacParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KetQuaCacKhoanChiKhacColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KetQuaCacKhoanChiKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KetQuaCacKhoanChiKhacParameterBuilder : ParameterizedSqlFilterBuilder<KetQuaCacKhoanChiKhacColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KetQuaCacKhoanChiKhacParameterBuilder class.
		/// </summary>
		public KetQuaCacKhoanChiKhacParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KetQuaCacKhoanChiKhacParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KetQuaCacKhoanChiKhacParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KetQuaCacKhoanChiKhacParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KetQuaCacKhoanChiKhacParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KetQuaCacKhoanChiKhacParameterBuilder
	
	#region KetQuaCacKhoanChiKhacSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KetQuaCacKhoanChiKhacColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KetQuaCacKhoanChiKhac"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KetQuaCacKhoanChiKhacSortBuilder : SqlSortBuilder<KetQuaCacKhoanChiKhacColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KetQuaCacKhoanChiKhacSqlSortBuilder class.
		/// </summary>
		public KetQuaCacKhoanChiKhacSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KetQuaCacKhoanChiKhacSortBuilder
	
} // end namespace
