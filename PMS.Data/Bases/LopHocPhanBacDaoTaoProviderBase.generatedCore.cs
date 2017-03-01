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
	/// This class is the base class for any <see cref="LopHocPhanBacDaoTaoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class LopHocPhanBacDaoTaoProviderBaseCore : EntityProviderBase<PMS.Entities.LopHocPhanBacDaoTao, PMS.Entities.LopHocPhanBacDaoTaoKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.LopHocPhanBacDaoTaoKey key)
		{
			return Delete(transactionManager, key.MaLopHocPhan, key.MaHeSoBacDaoTao);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maLopHocPhan">. Primary Key.</param>
		/// <param name="_maHeSoBacDaoTao">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _maLopHocPhan, System.Int32 _maHeSoBacDaoTao)
		{
			return Delete(null, _maLopHocPhan, _maHeSoBacDaoTao);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLopHocPhan">. Primary Key.</param>
		/// <param name="_maHeSoBacDaoTao">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _maLopHocPhan, System.Int32 _maHeSoBacDaoTao);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_LopHocPhan_BacDaoTao_HeSoBacDaoTao key.
		///		FK_LopHocPhan_BacDaoTao_HeSoBacDaoTao Description: 
		/// </summary>
		/// <param name="_maHeSoBacDaoTao"></param>
		/// <returns>Returns a typed collection of PMS.Entities.LopHocPhanBacDaoTao objects.</returns>
		public TList<LopHocPhanBacDaoTao> GetByMaHeSoBacDaoTao(System.Int32 _maHeSoBacDaoTao)
		{
			int count = -1;
			return GetByMaHeSoBacDaoTao(_maHeSoBacDaoTao, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_LopHocPhan_BacDaoTao_HeSoBacDaoTao key.
		///		FK_LopHocPhan_BacDaoTao_HeSoBacDaoTao Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSoBacDaoTao"></param>
		/// <returns>Returns a typed collection of PMS.Entities.LopHocPhanBacDaoTao objects.</returns>
		/// <remarks></remarks>
		public TList<LopHocPhanBacDaoTao> GetByMaHeSoBacDaoTao(TransactionManager transactionManager, System.Int32 _maHeSoBacDaoTao)
		{
			int count = -1;
			return GetByMaHeSoBacDaoTao(transactionManager, _maHeSoBacDaoTao, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_LopHocPhan_BacDaoTao_HeSoBacDaoTao key.
		///		FK_LopHocPhan_BacDaoTao_HeSoBacDaoTao Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSoBacDaoTao"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.LopHocPhanBacDaoTao objects.</returns>
		public TList<LopHocPhanBacDaoTao> GetByMaHeSoBacDaoTao(TransactionManager transactionManager, System.Int32 _maHeSoBacDaoTao, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHeSoBacDaoTao(transactionManager, _maHeSoBacDaoTao, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_LopHocPhan_BacDaoTao_HeSoBacDaoTao key.
		///		fkLopHocPhanBacDaoTaoHeSoBacDaoTao Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maHeSoBacDaoTao"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.LopHocPhanBacDaoTao objects.</returns>
		public TList<LopHocPhanBacDaoTao> GetByMaHeSoBacDaoTao(System.Int32 _maHeSoBacDaoTao, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaHeSoBacDaoTao(null, _maHeSoBacDaoTao, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_LopHocPhan_BacDaoTao_HeSoBacDaoTao key.
		///		fkLopHocPhanBacDaoTaoHeSoBacDaoTao Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maHeSoBacDaoTao"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.LopHocPhanBacDaoTao objects.</returns>
		public TList<LopHocPhanBacDaoTao> GetByMaHeSoBacDaoTao(System.Int32 _maHeSoBacDaoTao, int start, int pageLength,out int count)
		{
			return GetByMaHeSoBacDaoTao(null, _maHeSoBacDaoTao, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_LopHocPhan_BacDaoTao_HeSoBacDaoTao key.
		///		FK_LopHocPhan_BacDaoTao_HeSoBacDaoTao Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSoBacDaoTao"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.LopHocPhanBacDaoTao objects.</returns>
		public abstract TList<LopHocPhanBacDaoTao> GetByMaHeSoBacDaoTao(TransactionManager transactionManager, System.Int32 _maHeSoBacDaoTao, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.LopHocPhanBacDaoTao Get(TransactionManager transactionManager, PMS.Entities.LopHocPhanBacDaoTaoKey key, int start, int pageLength)
		{
			return GetByMaLopHocPhanMaHeSoBacDaoTao(transactionManager, key.MaLopHocPhan, key.MaHeSoBacDaoTao, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_LopHocPhan_BacDaoTao index.
		/// </summary>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maHeSoBacDaoTao"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanBacDaoTao"/> class.</returns>
		public PMS.Entities.LopHocPhanBacDaoTao GetByMaLopHocPhanMaHeSoBacDaoTao(System.String _maLopHocPhan, System.Int32 _maHeSoBacDaoTao)
		{
			int count = -1;
			return GetByMaLopHocPhanMaHeSoBacDaoTao(null,_maLopHocPhan, _maHeSoBacDaoTao, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LopHocPhan_BacDaoTao index.
		/// </summary>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maHeSoBacDaoTao"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanBacDaoTao"/> class.</returns>
		public PMS.Entities.LopHocPhanBacDaoTao GetByMaLopHocPhanMaHeSoBacDaoTao(System.String _maLopHocPhan, System.Int32 _maHeSoBacDaoTao, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLopHocPhanMaHeSoBacDaoTao(null, _maLopHocPhan, _maHeSoBacDaoTao, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LopHocPhan_BacDaoTao index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maHeSoBacDaoTao"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanBacDaoTao"/> class.</returns>
		public PMS.Entities.LopHocPhanBacDaoTao GetByMaLopHocPhanMaHeSoBacDaoTao(TransactionManager transactionManager, System.String _maLopHocPhan, System.Int32 _maHeSoBacDaoTao)
		{
			int count = -1;
			return GetByMaLopHocPhanMaHeSoBacDaoTao(transactionManager, _maLopHocPhan, _maHeSoBacDaoTao, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LopHocPhan_BacDaoTao index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maHeSoBacDaoTao"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanBacDaoTao"/> class.</returns>
		public PMS.Entities.LopHocPhanBacDaoTao GetByMaLopHocPhanMaHeSoBacDaoTao(TransactionManager transactionManager, System.String _maLopHocPhan, System.Int32 _maHeSoBacDaoTao, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLopHocPhanMaHeSoBacDaoTao(transactionManager, _maLopHocPhan, _maHeSoBacDaoTao, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LopHocPhan_BacDaoTao index.
		/// </summary>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maHeSoBacDaoTao"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanBacDaoTao"/> class.</returns>
		public PMS.Entities.LopHocPhanBacDaoTao GetByMaLopHocPhanMaHeSoBacDaoTao(System.String _maLopHocPhan, System.Int32 _maHeSoBacDaoTao, int start, int pageLength, out int count)
		{
			return GetByMaLopHocPhanMaHeSoBacDaoTao(null, _maLopHocPhan, _maHeSoBacDaoTao, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LopHocPhan_BacDaoTao index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maHeSoBacDaoTao"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanBacDaoTao"/> class.</returns>
		public abstract PMS.Entities.LopHocPhanBacDaoTao GetByMaLopHocPhanMaHeSoBacDaoTao(TransactionManager transactionManager, System.String _maLopHocPhan, System.Int32 _maHeSoBacDaoTao, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_LopHocPhan_BacDaoTao_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_LopHocPhan_BacDaoTao_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;LopHocPhanBacDaoTao&gt;"/> instance.</returns>
		public TList<LopHocPhanBacDaoTao> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_LopHocPhan_BacDaoTao_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;LopHocPhanBacDaoTao&gt;"/> instance.</returns>
		public TList<LopHocPhanBacDaoTao> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_LopHocPhan_BacDaoTao_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;LopHocPhanBacDaoTao&gt;"/> instance.</returns>
		public TList<LopHocPhanBacDaoTao> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_LopHocPhan_BacDaoTao_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;LopHocPhanBacDaoTao&gt;"/> instance.</returns>
		public abstract TList<LopHocPhanBacDaoTao> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;LopHocPhanBacDaoTao&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;LopHocPhanBacDaoTao&gt;"/></returns>
		public static TList<LopHocPhanBacDaoTao> Fill(IDataReader reader, TList<LopHocPhanBacDaoTao> rows, int start, int pageLength)
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
				
				PMS.Entities.LopHocPhanBacDaoTao c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("LopHocPhanBacDaoTao")
					.Append("|").Append((System.String)reader[((int)LopHocPhanBacDaoTaoColumn.MaLopHocPhan - 1)])
					.Append("|").Append((System.Int32)reader[((int)LopHocPhanBacDaoTaoColumn.MaHeSoBacDaoTao - 1)]).ToString();
					c = EntityManager.LocateOrCreate<LopHocPhanBacDaoTao>(
					key.ToString(), // EntityTrackingKey
					"LopHocPhanBacDaoTao",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.LopHocPhanBacDaoTao();
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
					c.MaLopHocPhan = (System.String)reader[(LopHocPhanBacDaoTaoColumn.MaLopHocPhan.ToString())];
					c.OriginalMaLopHocPhan = c.MaLopHocPhan;
					c.MaHeSoBacDaoTao = (System.Int32)reader[(LopHocPhanBacDaoTaoColumn.MaHeSoBacDaoTao.ToString())];
					c.OriginalMaHeSoBacDaoTao = c.MaHeSoBacDaoTao;
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.LopHocPhanBacDaoTao"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.LopHocPhanBacDaoTao"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.LopHocPhanBacDaoTao entity)
		{
			if (!reader.Read()) return;
			
			entity.MaLopHocPhan = (System.String)reader[(LopHocPhanBacDaoTaoColumn.MaLopHocPhan.ToString())];
			entity.OriginalMaLopHocPhan = (System.String)reader["MaLopHocPhan"];
			entity.MaHeSoBacDaoTao = (System.Int32)reader[(LopHocPhanBacDaoTaoColumn.MaHeSoBacDaoTao.ToString())];
			entity.OriginalMaHeSoBacDaoTao = (System.Int32)reader["MaHeSoBacDaoTao"];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.LopHocPhanBacDaoTao"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.LopHocPhanBacDaoTao"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.LopHocPhanBacDaoTao entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaLopHocPhan = (System.String)dataRow["MaLopHocPhan"];
			entity.OriginalMaLopHocPhan = (System.String)dataRow["MaLopHocPhan"];
			entity.MaHeSoBacDaoTao = (System.Int32)dataRow["MaHeSoBacDaoTao"];
			entity.OriginalMaHeSoBacDaoTao = (System.Int32)dataRow["MaHeSoBacDaoTao"];
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
		/// <param name="entity">The <see cref="PMS.Entities.LopHocPhanBacDaoTao"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.LopHocPhanBacDaoTao Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.LopHocPhanBacDaoTao entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaHeSoBacDaoTaoSource	
			if (CanDeepLoad(entity, "HeSoBacDaoTao|MaHeSoBacDaoTaoSource", deepLoadType, innerList) 
				&& entity.MaHeSoBacDaoTaoSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.MaHeSoBacDaoTao;
				HeSoBacDaoTao tmpEntity = EntityManager.LocateEntity<HeSoBacDaoTao>(EntityLocator.ConstructKeyFromPkItems(typeof(HeSoBacDaoTao), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaHeSoBacDaoTaoSource = tmpEntity;
				else
					entity.MaHeSoBacDaoTaoSource = DataRepository.HeSoBacDaoTaoProvider.GetByMaHeSo(transactionManager, entity.MaHeSoBacDaoTao);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaHeSoBacDaoTaoSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaHeSoBacDaoTaoSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.HeSoBacDaoTaoProvider.DeepLoad(transactionManager, entity.MaHeSoBacDaoTaoSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaHeSoBacDaoTaoSource
			
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
		/// Deep Save the entire object graph of the PMS.Entities.LopHocPhanBacDaoTao object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.LopHocPhanBacDaoTao instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.LopHocPhanBacDaoTao Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.LopHocPhanBacDaoTao entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaHeSoBacDaoTaoSource
			if (CanDeepSave(entity, "HeSoBacDaoTao|MaHeSoBacDaoTaoSource", deepSaveType, innerList) 
				&& entity.MaHeSoBacDaoTaoSource != null)
			{
				DataRepository.HeSoBacDaoTaoProvider.Save(transactionManager, entity.MaHeSoBacDaoTaoSource);
				entity.MaHeSoBacDaoTao = entity.MaHeSoBacDaoTaoSource.MaHeSo;
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
	
	#region LopHocPhanBacDaoTaoChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.LopHocPhanBacDaoTao</c>
	///</summary>
	public enum LopHocPhanBacDaoTaoChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>HeSoBacDaoTao</c> at MaHeSoBacDaoTaoSource
		///</summary>
		[ChildEntityType(typeof(HeSoBacDaoTao))]
		HeSoBacDaoTao,
	}
	
	#endregion LopHocPhanBacDaoTaoChildEntityTypes
	
	#region LopHocPhanBacDaoTaoFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;LopHocPhanBacDaoTaoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanBacDaoTao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LopHocPhanBacDaoTaoFilterBuilder : SqlFilterBuilder<LopHocPhanBacDaoTaoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LopHocPhanBacDaoTaoFilterBuilder class.
		/// </summary>
		public LopHocPhanBacDaoTaoFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the LopHocPhanBacDaoTaoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LopHocPhanBacDaoTaoFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LopHocPhanBacDaoTaoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LopHocPhanBacDaoTaoFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LopHocPhanBacDaoTaoFilterBuilder
	
	#region LopHocPhanBacDaoTaoParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;LopHocPhanBacDaoTaoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanBacDaoTao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LopHocPhanBacDaoTaoParameterBuilder : ParameterizedSqlFilterBuilder<LopHocPhanBacDaoTaoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LopHocPhanBacDaoTaoParameterBuilder class.
		/// </summary>
		public LopHocPhanBacDaoTaoParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the LopHocPhanBacDaoTaoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LopHocPhanBacDaoTaoParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LopHocPhanBacDaoTaoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LopHocPhanBacDaoTaoParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LopHocPhanBacDaoTaoParameterBuilder
	
	#region LopHocPhanBacDaoTaoSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;LopHocPhanBacDaoTaoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanBacDaoTao"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class LopHocPhanBacDaoTaoSortBuilder : SqlSortBuilder<LopHocPhanBacDaoTaoColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LopHocPhanBacDaoTaoSqlSortBuilder class.
		/// </summary>
		public LopHocPhanBacDaoTaoSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion LopHocPhanBacDaoTaoSortBuilder
	
} // end namespace
