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
	/// This class is the base class for any <see cref="GiangVienThayDoiHocHamProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GiangVienThayDoiHocHamProviderBaseCore : EntityProviderBase<PMS.Entities.GiangVienThayDoiHocHam, PMS.Entities.GiangVienThayDoiHocHamKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.GiangVienThayDoiHocHamKey key)
		{
			return Delete(transactionManager, key.MaQuanLy);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maQuanLy">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maQuanLy)
		{
			return Delete(null, _maQuanLy);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maQuanLy);		
		
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
		public override PMS.Entities.GiangVienThayDoiHocHam Get(TransactionManager transactionManager, PMS.Entities.GiangVienThayDoiHocHamKey key, int start, int pageLength)
		{
			return GetByMaQuanLy(transactionManager, key.MaQuanLy, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ThayDoiHocHam index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienThayDoiHocHam"/> class.</returns>
		public PMS.Entities.GiangVienThayDoiHocHam GetByMaQuanLy(System.Int32 _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(null,_maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThayDoiHocHam index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienThayDoiHocHam"/> class.</returns>
		public PMS.Entities.GiangVienThayDoiHocHam GetByMaQuanLy(System.Int32 _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThayDoiHocHam index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienThayDoiHocHam"/> class.</returns>
		public PMS.Entities.GiangVienThayDoiHocHam GetByMaQuanLy(TransactionManager transactionManager, System.Int32 _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThayDoiHocHam index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienThayDoiHocHam"/> class.</returns>
		public PMS.Entities.GiangVienThayDoiHocHam GetByMaQuanLy(TransactionManager transactionManager, System.Int32 _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThayDoiHocHam index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienThayDoiHocHam"/> class.</returns>
		public PMS.Entities.GiangVienThayDoiHocHam GetByMaQuanLy(System.Int32 _maQuanLy, int start, int pageLength, out int count)
		{
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThayDoiHocHam index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienThayDoiHocHam"/> class.</returns>
		public abstract PMS.Entities.GiangVienThayDoiHocHam GetByMaQuanLy(TransactionManager transactionManager, System.Int32 _maQuanLy, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_GiangVienThayDoiHocHam_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienThayDoiHocHam_Luu' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocHamCu"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocHamMoi"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayHieuLuc"> A <c>System.DateTime</c> instance.</param>
		/// <param name="ngayCapNhat"> A <c>System.DateTime</c> instance.</param>
		/// <param name="user"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.Int32 maGiangVien, System.Int32 maHocHamCu, System.Int32 maHocHamMoi, System.DateTime ngayHieuLuc, System.DateTime ngayCapNhat, System.String user, ref System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , maGiangVien, maHocHamCu, maHocHamMoi, ngayHieuLuc, ngayCapNhat, user, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienThayDoiHocHam_Luu' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocHamCu"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocHamMoi"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayHieuLuc"> A <c>System.DateTime</c> instance.</param>
		/// <param name="ngayCapNhat"> A <c>System.DateTime</c> instance.</param>
		/// <param name="user"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.Int32 maGiangVien, System.Int32 maHocHamCu, System.Int32 maHocHamMoi, System.DateTime ngayHieuLuc, System.DateTime ngayCapNhat, System.String user, ref System.Int32 reVal)
		{
			 Luu(null, start, pageLength , maGiangVien, maHocHamCu, maHocHamMoi, ngayHieuLuc, ngayCapNhat, user, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVienThayDoiHocHam_Luu' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocHamCu"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocHamMoi"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayHieuLuc"> A <c>System.DateTime</c> instance.</param>
		/// <param name="ngayCapNhat"> A <c>System.DateTime</c> instance.</param>
		/// <param name="user"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.Int32 maGiangVien, System.Int32 maHocHamCu, System.Int32 maHocHamMoi, System.DateTime ngayHieuLuc, System.DateTime ngayCapNhat, System.String user, ref System.Int32 reVal)
		{
			 Luu(transactionManager, 0, int.MaxValue , maGiangVien, maHocHamCu, maHocHamMoi, ngayHieuLuc, ngayCapNhat, user, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienThayDoiHocHam_Luu' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocHamCu"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocHamMoi"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayHieuLuc"> A <c>System.DateTime</c> instance.</param>
		/// <param name="ngayCapNhat"> A <c>System.DateTime</c> instance.</param>
		/// <param name="user"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.Int32 maGiangVien, System.Int32 maHocHamCu, System.Int32 maHocHamMoi, System.DateTime ngayHieuLuc, System.DateTime ngayCapNhat, System.String user, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GiangVienThayDoiHocHam&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GiangVienThayDoiHocHam&gt;"/></returns>
		public static TList<GiangVienThayDoiHocHam> Fill(IDataReader reader, TList<GiangVienThayDoiHocHam> rows, int start, int pageLength)
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
				
				PMS.Entities.GiangVienThayDoiHocHam c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GiangVienThayDoiHocHam")
					.Append("|").Append((System.Int32)reader[((int)GiangVienThayDoiHocHamColumn.MaQuanLy - 1)]).ToString();
					c = EntityManager.LocateOrCreate<GiangVienThayDoiHocHam>(
					key.ToString(), // EntityTrackingKey
					"GiangVienThayDoiHocHam",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.GiangVienThayDoiHocHam();
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
					c.MaQuanLy = (System.Int32)reader[(GiangVienThayDoiHocHamColumn.MaQuanLy.ToString())];
					c.MaGiangVien = (reader[GiangVienThayDoiHocHamColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienThayDoiHocHamColumn.MaGiangVien.ToString())];
					c.MaHocHamCu = (reader[GiangVienThayDoiHocHamColumn.MaHocHamCu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienThayDoiHocHamColumn.MaHocHamCu.ToString())];
					c.MaHocHam = (reader[GiangVienThayDoiHocHamColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienThayDoiHocHamColumn.MaHocHam.ToString())];
					c.NgayHieuLuc = (reader[GiangVienThayDoiHocHamColumn.NgayHieuLuc.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienThayDoiHocHamColumn.NgayHieuLuc.ToString())];
					c.NgayCapNhat = (reader[GiangVienThayDoiHocHamColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienThayDoiHocHamColumn.NgayCapNhat.ToString())];
					c.User = (reader[GiangVienThayDoiHocHamColumn.User.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienThayDoiHocHamColumn.User.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienThayDoiHocHam"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienThayDoiHocHam"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.GiangVienThayDoiHocHam entity)
		{
			if (!reader.Read()) return;
			
			entity.MaQuanLy = (System.Int32)reader[(GiangVienThayDoiHocHamColumn.MaQuanLy.ToString())];
			entity.MaGiangVien = (reader[GiangVienThayDoiHocHamColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienThayDoiHocHamColumn.MaGiangVien.ToString())];
			entity.MaHocHamCu = (reader[GiangVienThayDoiHocHamColumn.MaHocHamCu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienThayDoiHocHamColumn.MaHocHamCu.ToString())];
			entity.MaHocHam = (reader[GiangVienThayDoiHocHamColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienThayDoiHocHamColumn.MaHocHam.ToString())];
			entity.NgayHieuLuc = (reader[GiangVienThayDoiHocHamColumn.NgayHieuLuc.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienThayDoiHocHamColumn.NgayHieuLuc.ToString())];
			entity.NgayCapNhat = (reader[GiangVienThayDoiHocHamColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienThayDoiHocHamColumn.NgayCapNhat.ToString())];
			entity.User = (reader[GiangVienThayDoiHocHamColumn.User.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienThayDoiHocHamColumn.User.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienThayDoiHocHam"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienThayDoiHocHam"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.GiangVienThayDoiHocHam entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaQuanLy = (System.Int32)dataRow["MaQuanLy"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.Int32?)dataRow["MaGiangVien"];
			entity.MaHocHamCu = Convert.IsDBNull(dataRow["MaHocHamCu"]) ? null : (System.Int32?)dataRow["MaHocHamCu"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.NgayHieuLuc = Convert.IsDBNull(dataRow["NgayHieuLuc"]) ? null : (System.DateTime?)dataRow["NgayHieuLuc"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
			entity.User = Convert.IsDBNull(dataRow["User"]) ? null : (System.String)dataRow["User"];
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
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienThayDoiHocHam"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienThayDoiHocHam Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.GiangVienThayDoiHocHam entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.GiangVienThayDoiHocHam object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.GiangVienThayDoiHocHam instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienThayDoiHocHam Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.GiangVienThayDoiHocHam entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region GiangVienThayDoiHocHamChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.GiangVienThayDoiHocHam</c>
	///</summary>
	public enum GiangVienThayDoiHocHamChildEntityTypes
	{
	}
	
	#endregion GiangVienThayDoiHocHamChildEntityTypes
	
	#region GiangVienThayDoiHocHamFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GiangVienThayDoiHocHamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienThayDoiHocHam"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienThayDoiHocHamFilterBuilder : SqlFilterBuilder<GiangVienThayDoiHocHamColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienThayDoiHocHamFilterBuilder class.
		/// </summary>
		public GiangVienThayDoiHocHamFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienThayDoiHocHamFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienThayDoiHocHamFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienThayDoiHocHamFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienThayDoiHocHamFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienThayDoiHocHamFilterBuilder
	
	#region GiangVienThayDoiHocHamParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GiangVienThayDoiHocHamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienThayDoiHocHam"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienThayDoiHocHamParameterBuilder : ParameterizedSqlFilterBuilder<GiangVienThayDoiHocHamColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienThayDoiHocHamParameterBuilder class.
		/// </summary>
		public GiangVienThayDoiHocHamParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienThayDoiHocHamParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienThayDoiHocHamParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienThayDoiHocHamParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienThayDoiHocHamParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienThayDoiHocHamParameterBuilder
	
	#region GiangVienThayDoiHocHamSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GiangVienThayDoiHocHamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienThayDoiHocHam"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GiangVienThayDoiHocHamSortBuilder : SqlSortBuilder<GiangVienThayDoiHocHamColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienThayDoiHocHamSqlSortBuilder class.
		/// </summary>
		public GiangVienThayDoiHocHamSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GiangVienThayDoiHocHamSortBuilder
	
} // end namespace
