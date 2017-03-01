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
	/// This class is the base class for any <see cref="KcqPhanLoaiHocPhanProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KcqPhanLoaiHocPhanProviderBaseCore : EntityProviderBase<PMS.Entities.KcqPhanLoaiHocPhan, PMS.Entities.KcqPhanLoaiHocPhanKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KcqPhanLoaiHocPhanKey key)
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
		public override PMS.Entities.KcqPhanLoaiHocPhan Get(TransactionManager transactionManager, PMS.Entities.KcqPhanLoaiHocPhanKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KcqPhanLoaiHocPhan index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqPhanLoaiHocPhan"/> class.</returns>
		public PMS.Entities.KcqPhanLoaiHocPhan GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqPhanLoaiHocPhan index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqPhanLoaiHocPhan"/> class.</returns>
		public PMS.Entities.KcqPhanLoaiHocPhan GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqPhanLoaiHocPhan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqPhanLoaiHocPhan"/> class.</returns>
		public PMS.Entities.KcqPhanLoaiHocPhan GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqPhanLoaiHocPhan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqPhanLoaiHocPhan"/> class.</returns>
		public PMS.Entities.KcqPhanLoaiHocPhan GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqPhanLoaiHocPhan index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqPhanLoaiHocPhan"/> class.</returns>
		public PMS.Entities.KcqPhanLoaiHocPhan GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqPhanLoaiHocPhan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqPhanLoaiHocPhan"/> class.</returns>
		public abstract PMS.Entities.KcqPhanLoaiHocPhan GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_KcqPhanLoaiHocPhan_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_KcqPhanLoaiHocPhan_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqPhanLoaiHocPhan_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Luu(null, start, pageLength , xmlData, namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KcqPhanLoaiHocPhan_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqPhanLoaiHocPhan_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KcqPhanLoaiHocPhan&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KcqPhanLoaiHocPhan&gt;"/></returns>
		public static TList<KcqPhanLoaiHocPhan> Fill(IDataReader reader, TList<KcqPhanLoaiHocPhan> rows, int start, int pageLength)
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
				
				PMS.Entities.KcqPhanLoaiHocPhan c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KcqPhanLoaiHocPhan")
					.Append("|").Append((System.Int32)reader[((int)KcqPhanLoaiHocPhanColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KcqPhanLoaiHocPhan>(
					key.ToString(), // EntityTrackingKey
					"KcqPhanLoaiHocPhan",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KcqPhanLoaiHocPhan();
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
					c.Id = (System.Int32)reader[(KcqPhanLoaiHocPhanColumn.Id.ToString())];
					c.NamHoc = (reader[KcqPhanLoaiHocPhanColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqPhanLoaiHocPhanColumn.NamHoc.ToString())];
					c.HocKy = (reader[KcqPhanLoaiHocPhanColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqPhanLoaiHocPhanColumn.HocKy.ToString())];
					c.MaGiangVienQuanLy = (reader[KcqPhanLoaiHocPhanColumn.MaGiangVienQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqPhanLoaiHocPhanColumn.MaGiangVienQuanLy.ToString())];
					c.MaMonHoc = (reader[KcqPhanLoaiHocPhanColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqPhanLoaiHocPhanColumn.MaMonHoc.ToString())];
					c.MaLopHocPhan = (reader[KcqPhanLoaiHocPhanColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqPhanLoaiHocPhanColumn.MaLopHocPhan.ToString())];
					c.MaLop = (reader[KcqPhanLoaiHocPhanColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqPhanLoaiHocPhanColumn.MaLop.ToString())];
					c.Nhom = (reader[KcqPhanLoaiHocPhanColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqPhanLoaiHocPhanColumn.Nhom.ToString())];
					c.MaLoaiHocPhanGanMoi = (reader[KcqPhanLoaiHocPhanColumn.MaLoaiHocPhanGanMoi.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqPhanLoaiHocPhanColumn.MaLoaiHocPhanGanMoi.ToString())];
					c.MaLoaiHocPhanCu = (reader[KcqPhanLoaiHocPhanColumn.MaLoaiHocPhanCu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqPhanLoaiHocPhanColumn.MaLoaiHocPhanCu.ToString())];
					c.MaDot = (reader[KcqPhanLoaiHocPhanColumn.MaDot.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqPhanLoaiHocPhanColumn.MaDot.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqPhanLoaiHocPhan"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqPhanLoaiHocPhan"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KcqPhanLoaiHocPhan entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(KcqPhanLoaiHocPhanColumn.Id.ToString())];
			entity.NamHoc = (reader[KcqPhanLoaiHocPhanColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqPhanLoaiHocPhanColumn.NamHoc.ToString())];
			entity.HocKy = (reader[KcqPhanLoaiHocPhanColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqPhanLoaiHocPhanColumn.HocKy.ToString())];
			entity.MaGiangVienQuanLy = (reader[KcqPhanLoaiHocPhanColumn.MaGiangVienQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqPhanLoaiHocPhanColumn.MaGiangVienQuanLy.ToString())];
			entity.MaMonHoc = (reader[KcqPhanLoaiHocPhanColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqPhanLoaiHocPhanColumn.MaMonHoc.ToString())];
			entity.MaLopHocPhan = (reader[KcqPhanLoaiHocPhanColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqPhanLoaiHocPhanColumn.MaLopHocPhan.ToString())];
			entity.MaLop = (reader[KcqPhanLoaiHocPhanColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqPhanLoaiHocPhanColumn.MaLop.ToString())];
			entity.Nhom = (reader[KcqPhanLoaiHocPhanColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqPhanLoaiHocPhanColumn.Nhom.ToString())];
			entity.MaLoaiHocPhanGanMoi = (reader[KcqPhanLoaiHocPhanColumn.MaLoaiHocPhanGanMoi.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqPhanLoaiHocPhanColumn.MaLoaiHocPhanGanMoi.ToString())];
			entity.MaLoaiHocPhanCu = (reader[KcqPhanLoaiHocPhanColumn.MaLoaiHocPhanCu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqPhanLoaiHocPhanColumn.MaLoaiHocPhanCu.ToString())];
			entity.MaDot = (reader[KcqPhanLoaiHocPhanColumn.MaDot.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqPhanLoaiHocPhanColumn.MaDot.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqPhanLoaiHocPhan"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqPhanLoaiHocPhan"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KcqPhanLoaiHocPhan entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaGiangVienQuanLy = Convert.IsDBNull(dataRow["MaGiangVienQuanLy"]) ? null : (System.String)dataRow["MaGiangVienQuanLy"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.MaLop = Convert.IsDBNull(dataRow["MaLop"]) ? null : (System.String)dataRow["MaLop"];
			entity.Nhom = Convert.IsDBNull(dataRow["Nhom"]) ? null : (System.String)dataRow["Nhom"];
			entity.MaLoaiHocPhanGanMoi = Convert.IsDBNull(dataRow["MaLoaiHocPhanGanMoi"]) ? null : (System.String)dataRow["MaLoaiHocPhanGanMoi"];
			entity.MaLoaiHocPhanCu = Convert.IsDBNull(dataRow["MaLoaiHocPhanCu"]) ? null : (System.String)dataRow["MaLoaiHocPhanCu"];
			entity.MaDot = Convert.IsDBNull(dataRow["MaDot"]) ? null : (System.String)dataRow["MaDot"];
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
		/// <param name="entity">The <see cref="PMS.Entities.KcqPhanLoaiHocPhan"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KcqPhanLoaiHocPhan Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KcqPhanLoaiHocPhan entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.KcqPhanLoaiHocPhan object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KcqPhanLoaiHocPhan instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KcqPhanLoaiHocPhan Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KcqPhanLoaiHocPhan entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region KcqPhanLoaiHocPhanChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KcqPhanLoaiHocPhan</c>
	///</summary>
	public enum KcqPhanLoaiHocPhanChildEntityTypes
	{
	}
	
	#endregion KcqPhanLoaiHocPhanChildEntityTypes
	
	#region KcqPhanLoaiHocPhanFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KcqPhanLoaiHocPhanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqPhanLoaiHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqPhanLoaiHocPhanFilterBuilder : SqlFilterBuilder<KcqPhanLoaiHocPhanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqPhanLoaiHocPhanFilterBuilder class.
		/// </summary>
		public KcqPhanLoaiHocPhanFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqPhanLoaiHocPhanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqPhanLoaiHocPhanFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqPhanLoaiHocPhanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqPhanLoaiHocPhanFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqPhanLoaiHocPhanFilterBuilder
	
	#region KcqPhanLoaiHocPhanParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KcqPhanLoaiHocPhanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqPhanLoaiHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqPhanLoaiHocPhanParameterBuilder : ParameterizedSqlFilterBuilder<KcqPhanLoaiHocPhanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqPhanLoaiHocPhanParameterBuilder class.
		/// </summary>
		public KcqPhanLoaiHocPhanParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqPhanLoaiHocPhanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqPhanLoaiHocPhanParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqPhanLoaiHocPhanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqPhanLoaiHocPhanParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqPhanLoaiHocPhanParameterBuilder
	
	#region KcqPhanLoaiHocPhanSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KcqPhanLoaiHocPhanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqPhanLoaiHocPhan"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KcqPhanLoaiHocPhanSortBuilder : SqlSortBuilder<KcqPhanLoaiHocPhanColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqPhanLoaiHocPhanSqlSortBuilder class.
		/// </summary>
		public KcqPhanLoaiHocPhanSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KcqPhanLoaiHocPhanSortBuilder
	
} // end namespace
