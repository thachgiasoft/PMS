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
	/// This class is the base class for any <see cref="SiSoLopHocPhanProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SiSoLopHocPhanProviderBaseCore : EntityProviderBase<PMS.Entities.SiSoLopHocPhan, PMS.Entities.SiSoLopHocPhanKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.SiSoLopHocPhanKey key)
		{
			return Delete(transactionManager, key.ScheduleStudyUnitId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_scheduleStudyUnitId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _scheduleStudyUnitId)
		{
			return Delete(null, _scheduleStudyUnitId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scheduleStudyUnitId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _scheduleStudyUnitId);		
		
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
		public override PMS.Entities.SiSoLopHocPhan Get(TransactionManager transactionManager, PMS.Entities.SiSoLopHocPhanKey key, int start, int pageLength)
		{
			return GetByScheduleStudyUnitId(transactionManager, key.ScheduleStudyUnitId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SiSoLopHocPhan index.
		/// </summary>
		/// <param name="_scheduleStudyUnitId"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SiSoLopHocPhan"/> class.</returns>
		public PMS.Entities.SiSoLopHocPhan GetByScheduleStudyUnitId(System.String _scheduleStudyUnitId)
		{
			int count = -1;
			return GetByScheduleStudyUnitId(null,_scheduleStudyUnitId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SiSoLopHocPhan index.
		/// </summary>
		/// <param name="_scheduleStudyUnitId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SiSoLopHocPhan"/> class.</returns>
		public PMS.Entities.SiSoLopHocPhan GetByScheduleStudyUnitId(System.String _scheduleStudyUnitId, int start, int pageLength)
		{
			int count = -1;
			return GetByScheduleStudyUnitId(null, _scheduleStudyUnitId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SiSoLopHocPhan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scheduleStudyUnitId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SiSoLopHocPhan"/> class.</returns>
		public PMS.Entities.SiSoLopHocPhan GetByScheduleStudyUnitId(TransactionManager transactionManager, System.String _scheduleStudyUnitId)
		{
			int count = -1;
			return GetByScheduleStudyUnitId(transactionManager, _scheduleStudyUnitId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SiSoLopHocPhan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scheduleStudyUnitId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SiSoLopHocPhan"/> class.</returns>
		public PMS.Entities.SiSoLopHocPhan GetByScheduleStudyUnitId(TransactionManager transactionManager, System.String _scheduleStudyUnitId, int start, int pageLength)
		{
			int count = -1;
			return GetByScheduleStudyUnitId(transactionManager, _scheduleStudyUnitId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SiSoLopHocPhan index.
		/// </summary>
		/// <param name="_scheduleStudyUnitId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SiSoLopHocPhan"/> class.</returns>
		public PMS.Entities.SiSoLopHocPhan GetByScheduleStudyUnitId(System.String _scheduleStudyUnitId, int start, int pageLength, out int count)
		{
			return GetByScheduleStudyUnitId(null, _scheduleStudyUnitId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SiSoLopHocPhan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scheduleStudyUnitId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SiSoLopHocPhan"/> class.</returns>
		public abstract PMS.Entities.SiSoLopHocPhan GetByScheduleStudyUnitId(TransactionManager transactionManager, System.String _scheduleStudyUnitId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_SiSoLopHocPhan_GhepSiSoDangKy 
		
		/// <summary>
		///	This method wrap the 'cust_SiSoLopHocPhan_GhepSiSoDangKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reval"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GhepSiSoDangKy(System.String namHoc, System.String hocKy, ref System.Int32 reval)
		{
			 GhepSiSoDangKy(null, 0, int.MaxValue , namHoc, hocKy, ref reval);
		}
		
		/// <summary>
		///	This method wrap the 'cust_SiSoLopHocPhan_GhepSiSoDangKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reval"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GhepSiSoDangKy(int start, int pageLength, System.String namHoc, System.String hocKy, ref System.Int32 reval)
		{
			 GhepSiSoDangKy(null, start, pageLength , namHoc, hocKy, ref reval);
		}
				
		/// <summary>
		///	This method wrap the 'cust_SiSoLopHocPhan_GhepSiSoDangKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reval"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GhepSiSoDangKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy, ref System.Int32 reval)
		{
			 GhepSiSoDangKy(transactionManager, 0, int.MaxValue , namHoc, hocKy, ref reval);
		}
		
		/// <summary>
		///	This method wrap the 'cust_SiSoLopHocPhan_GhepSiSoDangKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reval"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GhepSiSoDangKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, ref System.Int32 reval);
		
		#endregion
		
		#region cust_SiSoLopHocPhan_LaySiSoLopGhep 
		
		/// <summary>
		///	This method wrap the 'cust_SiSoLopHocPhan_LaySiSoLopGhep' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader LaySiSoLopGhep(System.String namHoc, System.String hocKy)
		{
			return LaySiSoLopGhep(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_SiSoLopHocPhan_LaySiSoLopGhep' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader LaySiSoLopGhep(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return LaySiSoLopGhep(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_SiSoLopHocPhan_LaySiSoLopGhep' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader LaySiSoLopGhep(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return LaySiSoLopGhep(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_SiSoLopHocPhan_LaySiSoLopGhep' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader LaySiSoLopGhep(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_SiSoLopHocPhan_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_SiSoLopHocPhan_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, ref System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_SiSoLopHocPhan_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, ref System.Int32 reVal)
		{
			 Luu(null, start, pageLength , xmlData, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_SiSoLopHocPhan_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, ref System.Int32 reVal)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_SiSoLopHocPhan_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_SiSoLopHocPhan_LayChiTietlopGhep 
		
		/// <summary>
		///	This method wrap the 'cust_SiSoLopHocPhan_LayChiTietlopGhep' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader LayChiTietlopGhep(System.String maLopHocPhan)
		{
			return LayChiTietlopGhep(null, 0, int.MaxValue , maLopHocPhan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_SiSoLopHocPhan_LayChiTietlopGhep' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader LayChiTietlopGhep(int start, int pageLength, System.String maLopHocPhan)
		{
			return LayChiTietlopGhep(null, start, pageLength , maLopHocPhan);
		}
				
		/// <summary>
		///	This method wrap the 'cust_SiSoLopHocPhan_LayChiTietlopGhep' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader LayChiTietlopGhep(TransactionManager transactionManager, System.String maLopHocPhan)
		{
			return LayChiTietlopGhep(transactionManager, 0, int.MaxValue , maLopHocPhan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_SiSoLopHocPhan_LayChiTietlopGhep' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader LayChiTietlopGhep(TransactionManager transactionManager, int start, int pageLength , System.String maLopHocPhan);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SiSoLopHocPhan&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SiSoLopHocPhan&gt;"/></returns>
		public static TList<SiSoLopHocPhan> Fill(IDataReader reader, TList<SiSoLopHocPhan> rows, int start, int pageLength)
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
				
				PMS.Entities.SiSoLopHocPhan c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SiSoLopHocPhan")
					.Append("|").Append((System.String)reader[((int)SiSoLopHocPhanColumn.ScheduleStudyUnitId - 1)]).ToString();
					c = EntityManager.LocateOrCreate<SiSoLopHocPhan>(
					key.ToString(), // EntityTrackingKey
					"SiSoLopHocPhan",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.SiSoLopHocPhan();
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
					c.ScheduleStudyUnitId = (System.String)reader[(SiSoLopHocPhanColumn.ScheduleStudyUnitId.ToString())];
					c.OriginalScheduleStudyUnitId = c.ScheduleStudyUnitId;
					c.SiSoLop = (reader[SiSoLopHocPhanColumn.SiSoLop.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SiSoLopHocPhanColumn.SiSoLop.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.SiSoLopHocPhan"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.SiSoLopHocPhan"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.SiSoLopHocPhan entity)
		{
			if (!reader.Read()) return;
			
			entity.ScheduleStudyUnitId = (System.String)reader[(SiSoLopHocPhanColumn.ScheduleStudyUnitId.ToString())];
			entity.OriginalScheduleStudyUnitId = (System.String)reader["ScheduleStudyUnitID"];
			entity.SiSoLop = (reader[SiSoLopHocPhanColumn.SiSoLop.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SiSoLopHocPhanColumn.SiSoLop.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.SiSoLopHocPhan"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.SiSoLopHocPhan"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.SiSoLopHocPhan entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ScheduleStudyUnitId = (System.String)dataRow["ScheduleStudyUnitID"];
			entity.OriginalScheduleStudyUnitId = (System.String)dataRow["ScheduleStudyUnitID"];
			entity.SiSoLop = Convert.IsDBNull(dataRow["SiSoLop"]) ? null : (System.Int32?)dataRow["SiSoLop"];
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
		/// <param name="entity">The <see cref="PMS.Entities.SiSoLopHocPhan"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.SiSoLopHocPhan Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.SiSoLopHocPhan entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.SiSoLopHocPhan object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.SiSoLopHocPhan instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.SiSoLopHocPhan Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.SiSoLopHocPhan entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region SiSoLopHocPhanChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.SiSoLopHocPhan</c>
	///</summary>
	public enum SiSoLopHocPhanChildEntityTypes
	{
	}
	
	#endregion SiSoLopHocPhanChildEntityTypes
	
	#region SiSoLopHocPhanFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SiSoLopHocPhanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SiSoLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SiSoLopHocPhanFilterBuilder : SqlFilterBuilder<SiSoLopHocPhanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SiSoLopHocPhanFilterBuilder class.
		/// </summary>
		public SiSoLopHocPhanFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SiSoLopHocPhanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SiSoLopHocPhanFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SiSoLopHocPhanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SiSoLopHocPhanFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SiSoLopHocPhanFilterBuilder
	
	#region SiSoLopHocPhanParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SiSoLopHocPhanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SiSoLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SiSoLopHocPhanParameterBuilder : ParameterizedSqlFilterBuilder<SiSoLopHocPhanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SiSoLopHocPhanParameterBuilder class.
		/// </summary>
		public SiSoLopHocPhanParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SiSoLopHocPhanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SiSoLopHocPhanParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SiSoLopHocPhanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SiSoLopHocPhanParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SiSoLopHocPhanParameterBuilder
	
	#region SiSoLopHocPhanSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SiSoLopHocPhanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SiSoLopHocPhan"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SiSoLopHocPhanSortBuilder : SqlSortBuilder<SiSoLopHocPhanColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SiSoLopHocPhanSqlSortBuilder class.
		/// </summary>
		public SiSoLopHocPhanSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SiSoLopHocPhanSortBuilder
	
} // end namespace
