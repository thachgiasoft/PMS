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
	/// This class is the base class for any <see cref="PhanCongDoAnTotNghiepProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PhanCongDoAnTotNghiepProviderBaseCore : EntityProviderBase<PMS.Entities.PhanCongDoAnTotNghiep, PMS.Entities.PhanCongDoAnTotNghiepKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.PhanCongDoAnTotNghiepKey key)
		{
			return Delete(transactionManager, key.MaLopHocPhan, key.MaSinhVien);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maLopHocPhan">. Primary Key.</param>
		/// <param name="_maSinhVien">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _maLopHocPhan, System.String _maSinhVien)
		{
			return Delete(null, _maLopHocPhan, _maSinhVien);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLopHocPhan">. Primary Key.</param>
		/// <param name="_maSinhVien">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _maLopHocPhan, System.String _maSinhVien);		
		
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
		public override PMS.Entities.PhanCongDoAnTotNghiep Get(TransactionManager transactionManager, PMS.Entities.PhanCongDoAnTotNghiepKey key, int start, int pageLength)
		{
			return GetByMaLopHocPhanMaSinhVien(transactionManager, key.MaLopHocPhan, key.MaSinhVien, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PhanCongDoAnTotNghiep index.
		/// </summary>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maSinhVien"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PhanCongDoAnTotNghiep"/> class.</returns>
		public PMS.Entities.PhanCongDoAnTotNghiep GetByMaLopHocPhanMaSinhVien(System.String _maLopHocPhan, System.String _maSinhVien)
		{
			int count = -1;
			return GetByMaLopHocPhanMaSinhVien(null,_maLopHocPhan, _maSinhVien, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PhanCongDoAnTotNghiep index.
		/// </summary>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maSinhVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PhanCongDoAnTotNghiep"/> class.</returns>
		public PMS.Entities.PhanCongDoAnTotNghiep GetByMaLopHocPhanMaSinhVien(System.String _maLopHocPhan, System.String _maSinhVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLopHocPhanMaSinhVien(null, _maLopHocPhan, _maSinhVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PhanCongDoAnTotNghiep index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maSinhVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PhanCongDoAnTotNghiep"/> class.</returns>
		public PMS.Entities.PhanCongDoAnTotNghiep GetByMaLopHocPhanMaSinhVien(TransactionManager transactionManager, System.String _maLopHocPhan, System.String _maSinhVien)
		{
			int count = -1;
			return GetByMaLopHocPhanMaSinhVien(transactionManager, _maLopHocPhan, _maSinhVien, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PhanCongDoAnTotNghiep index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maSinhVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PhanCongDoAnTotNghiep"/> class.</returns>
		public PMS.Entities.PhanCongDoAnTotNghiep GetByMaLopHocPhanMaSinhVien(TransactionManager transactionManager, System.String _maLopHocPhan, System.String _maSinhVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLopHocPhanMaSinhVien(transactionManager, _maLopHocPhan, _maSinhVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PhanCongDoAnTotNghiep index.
		/// </summary>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maSinhVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PhanCongDoAnTotNghiep"/> class.</returns>
		public PMS.Entities.PhanCongDoAnTotNghiep GetByMaLopHocPhanMaSinhVien(System.String _maLopHocPhan, System.String _maSinhVien, int start, int pageLength, out int count)
		{
			return GetByMaLopHocPhanMaSinhVien(null, _maLopHocPhan, _maSinhVien, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PhanCongDoAnTotNghiep index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maSinhVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PhanCongDoAnTotNghiep"/> class.</returns>
		public abstract PMS.Entities.PhanCongDoAnTotNghiep GetByMaLopHocPhanMaSinhVien(TransactionManager transactionManager, System.String _maLopHocPhan, System.String _maSinhVien, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_PhanCongDoAnTotNghiep_GetByMaLopHocPhan 
		
		/// <summary>
		///	This method wrap the 'cust_PhanCongDoAnTotNghiep_GetByMaLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;PhanCongDoAnTotNghiep&gt;"/> instance.</returns>
		public TList<PhanCongDoAnTotNghiep> GetByMaLopHocPhan(System.String maLopHocPhan)
		{
			return GetByMaLopHocPhan(null, 0, int.MaxValue , maLopHocPhan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_PhanCongDoAnTotNghiep_GetByMaLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;PhanCongDoAnTotNghiep&gt;"/> instance.</returns>
		public TList<PhanCongDoAnTotNghiep> GetByMaLopHocPhan(int start, int pageLength, System.String maLopHocPhan)
		{
			return GetByMaLopHocPhan(null, start, pageLength , maLopHocPhan);
		}
				
		/// <summary>
		///	This method wrap the 'cust_PhanCongDoAnTotNghiep_GetByMaLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;PhanCongDoAnTotNghiep&gt;"/> instance.</returns>
		public TList<PhanCongDoAnTotNghiep> GetByMaLopHocPhan(TransactionManager transactionManager, System.String maLopHocPhan)
		{
			return GetByMaLopHocPhan(transactionManager, 0, int.MaxValue , maLopHocPhan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_PhanCongDoAnTotNghiep_GetByMaLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;PhanCongDoAnTotNghiep&gt;"/> instance.</returns>
		public abstract TList<PhanCongDoAnTotNghiep> GetByMaLopHocPhan(TransactionManager transactionManager, int start, int pageLength , System.String maLopHocPhan);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PhanCongDoAnTotNghiep&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PhanCongDoAnTotNghiep&gt;"/></returns>
		public static TList<PhanCongDoAnTotNghiep> Fill(IDataReader reader, TList<PhanCongDoAnTotNghiep> rows, int start, int pageLength)
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
				
				PMS.Entities.PhanCongDoAnTotNghiep c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PhanCongDoAnTotNghiep")
					.Append("|").Append((System.String)reader[((int)PhanCongDoAnTotNghiepColumn.MaLopHocPhan - 1)])
					.Append("|").Append((System.String)reader[((int)PhanCongDoAnTotNghiepColumn.MaSinhVien - 1)]).ToString();
					c = EntityManager.LocateOrCreate<PhanCongDoAnTotNghiep>(
					key.ToString(), // EntityTrackingKey
					"PhanCongDoAnTotNghiep",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.PhanCongDoAnTotNghiep();
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
					c.MaLopHocPhan = (System.String)reader[(PhanCongDoAnTotNghiepColumn.MaLopHocPhan.ToString())];
					c.OriginalMaLopHocPhan = c.MaLopHocPhan;
					c.MaSinhVien = (System.String)reader[(PhanCongDoAnTotNghiepColumn.MaSinhVien.ToString())];
					c.OriginalMaSinhVien = c.MaSinhVien;
					c.HoTen = (reader[PhanCongDoAnTotNghiepColumn.HoTen.ToString()] == DBNull.Value) ? null : (System.String)reader[(PhanCongDoAnTotNghiepColumn.HoTen.ToString())];
					c.GiangVienHuongDan = (reader[PhanCongDoAnTotNghiepColumn.GiangVienHuongDan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(PhanCongDoAnTotNghiepColumn.GiangVienHuongDan.ToString())];
					c.GiangVienPhanBien1 = (reader[PhanCongDoAnTotNghiepColumn.GiangVienPhanBien1.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(PhanCongDoAnTotNghiepColumn.GiangVienPhanBien1.ToString())];
					c.GiangVienPhanBien2 = (reader[PhanCongDoAnTotNghiepColumn.GiangVienPhanBien2.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(PhanCongDoAnTotNghiepColumn.GiangVienPhanBien2.ToString())];
					c.GhiChu = (reader[PhanCongDoAnTotNghiepColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(PhanCongDoAnTotNghiepColumn.GhiChu.ToString())];
					c.NgayCapNhat = (reader[PhanCongDoAnTotNghiepColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(PhanCongDoAnTotNghiepColumn.NgayCapNhat.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.PhanCongDoAnTotNghiep"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.PhanCongDoAnTotNghiep"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.PhanCongDoAnTotNghiep entity)
		{
			if (!reader.Read()) return;
			
			entity.MaLopHocPhan = (System.String)reader[(PhanCongDoAnTotNghiepColumn.MaLopHocPhan.ToString())];
			entity.OriginalMaLopHocPhan = (System.String)reader["MaLopHocPhan"];
			entity.MaSinhVien = (System.String)reader[(PhanCongDoAnTotNghiepColumn.MaSinhVien.ToString())];
			entity.OriginalMaSinhVien = (System.String)reader["MaSinhVien"];
			entity.HoTen = (reader[PhanCongDoAnTotNghiepColumn.HoTen.ToString()] == DBNull.Value) ? null : (System.String)reader[(PhanCongDoAnTotNghiepColumn.HoTen.ToString())];
			entity.GiangVienHuongDan = (reader[PhanCongDoAnTotNghiepColumn.GiangVienHuongDan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(PhanCongDoAnTotNghiepColumn.GiangVienHuongDan.ToString())];
			entity.GiangVienPhanBien1 = (reader[PhanCongDoAnTotNghiepColumn.GiangVienPhanBien1.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(PhanCongDoAnTotNghiepColumn.GiangVienPhanBien1.ToString())];
			entity.GiangVienPhanBien2 = (reader[PhanCongDoAnTotNghiepColumn.GiangVienPhanBien2.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(PhanCongDoAnTotNghiepColumn.GiangVienPhanBien2.ToString())];
			entity.GhiChu = (reader[PhanCongDoAnTotNghiepColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(PhanCongDoAnTotNghiepColumn.GhiChu.ToString())];
			entity.NgayCapNhat = (reader[PhanCongDoAnTotNghiepColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(PhanCongDoAnTotNghiepColumn.NgayCapNhat.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.PhanCongDoAnTotNghiep"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.PhanCongDoAnTotNghiep"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.PhanCongDoAnTotNghiep entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaLopHocPhan = (System.String)dataRow["MaLopHocPhan"];
			entity.OriginalMaLopHocPhan = (System.String)dataRow["MaLopHocPhan"];
			entity.MaSinhVien = (System.String)dataRow["MaSinhVien"];
			entity.OriginalMaSinhVien = (System.String)dataRow["MaSinhVien"];
			entity.HoTen = Convert.IsDBNull(dataRow["HoTen"]) ? null : (System.String)dataRow["HoTen"];
			entity.GiangVienHuongDan = Convert.IsDBNull(dataRow["GiangVienHuongDan"]) ? null : (System.Int32?)dataRow["GiangVienHuongDan"];
			entity.GiangVienPhanBien1 = Convert.IsDBNull(dataRow["GiangVienPhanBien1"]) ? null : (System.Int32?)dataRow["GiangVienPhanBien1"];
			entity.GiangVienPhanBien2 = Convert.IsDBNull(dataRow["GiangVienPhanBien2"]) ? null : (System.Int32?)dataRow["GiangVienPhanBien2"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
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
		/// <param name="entity">The <see cref="PMS.Entities.PhanCongDoAnTotNghiep"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.PhanCongDoAnTotNghiep Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.PhanCongDoAnTotNghiep entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.PhanCongDoAnTotNghiep object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.PhanCongDoAnTotNghiep instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.PhanCongDoAnTotNghiep Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.PhanCongDoAnTotNghiep entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region PhanCongDoAnTotNghiepChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.PhanCongDoAnTotNghiep</c>
	///</summary>
	public enum PhanCongDoAnTotNghiepChildEntityTypes
	{
	}
	
	#endregion PhanCongDoAnTotNghiepChildEntityTypes
	
	#region PhanCongDoAnTotNghiepFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PhanCongDoAnTotNghiepColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PhanCongDoAnTotNghiep"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PhanCongDoAnTotNghiepFilterBuilder : SqlFilterBuilder<PhanCongDoAnTotNghiepColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PhanCongDoAnTotNghiepFilterBuilder class.
		/// </summary>
		public PhanCongDoAnTotNghiepFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PhanCongDoAnTotNghiepFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PhanCongDoAnTotNghiepFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PhanCongDoAnTotNghiepFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PhanCongDoAnTotNghiepFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PhanCongDoAnTotNghiepFilterBuilder
	
	#region PhanCongDoAnTotNghiepParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PhanCongDoAnTotNghiepColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PhanCongDoAnTotNghiep"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PhanCongDoAnTotNghiepParameterBuilder : ParameterizedSqlFilterBuilder<PhanCongDoAnTotNghiepColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PhanCongDoAnTotNghiepParameterBuilder class.
		/// </summary>
		public PhanCongDoAnTotNghiepParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PhanCongDoAnTotNghiepParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PhanCongDoAnTotNghiepParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PhanCongDoAnTotNghiepParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PhanCongDoAnTotNghiepParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PhanCongDoAnTotNghiepParameterBuilder
	
	#region PhanCongDoAnTotNghiepSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PhanCongDoAnTotNghiepColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PhanCongDoAnTotNghiep"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PhanCongDoAnTotNghiepSortBuilder : SqlSortBuilder<PhanCongDoAnTotNghiepColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PhanCongDoAnTotNghiepSqlSortBuilder class.
		/// </summary>
		public PhanCongDoAnTotNghiepSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PhanCongDoAnTotNghiepSortBuilder
	
} // end namespace
