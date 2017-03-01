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
	/// This class is the base class for any <see cref="GiangVienHoSoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GiangVienHoSoProviderBaseCore : EntityProviderBase<PMS.Entities.GiangVienHoSo, PMS.Entities.GiangVienHoSoKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.GiangVienHoSoKey key)
		{
			return Delete(transactionManager, key.MaHoSo, key.MaGiangVien);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maHoSo">. Primary Key.</param>
		/// <param name="_maGiangVien">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maHoSo, System.Int32 _maGiangVien)
		{
			return Delete(null, _maHoSo, _maGiangVien);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHoSo">. Primary Key.</param>
		/// <param name="_maGiangVien">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maHoSo, System.Int32 _maGiangVien);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HoSo_GiangVien key.
		///		FK_GiangVien_HoSo_GiangVien Description: 
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoSo objects.</returns>
		public TList<GiangVienHoSo> GetByMaGiangVien(System.Int32 _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(_maGiangVien, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HoSo_GiangVien key.
		///		FK_GiangVien_HoSo_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoSo objects.</returns>
		/// <remarks></remarks>
		public TList<GiangVienHoSo> GetByMaGiangVien(TransactionManager transactionManager, System.Int32 _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HoSo_GiangVien key.
		///		FK_GiangVien_HoSo_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoSo objects.</returns>
		public TList<GiangVienHoSo> GetByMaGiangVien(TransactionManager transactionManager, System.Int32 _maGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HoSo_GiangVien key.
		///		fkGiangVienHoSoGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoSo objects.</returns>
		public TList<GiangVienHoSo> GetByMaGiangVien(System.Int32 _maGiangVien, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HoSo_GiangVien key.
		///		fkGiangVienHoSoGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoSo objects.</returns>
		public TList<GiangVienHoSo> GetByMaGiangVien(System.Int32 _maGiangVien, int start, int pageLength,out int count)
		{
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HoSo_GiangVien key.
		///		FK_GiangVien_HoSo_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoSo objects.</returns>
		public abstract TList<GiangVienHoSo> GetByMaGiangVien(TransactionManager transactionManager, System.Int32 _maGiangVien, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HoSo_HoSo key.
		///		FK_GiangVien_HoSo_HoSo Description: 
		/// </summary>
		/// <param name="_maHoSo"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoSo objects.</returns>
		public TList<GiangVienHoSo> GetByMaHoSo(System.Int32 _maHoSo)
		{
			int count = -1;
			return GetByMaHoSo(_maHoSo, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HoSo_HoSo key.
		///		FK_GiangVien_HoSo_HoSo Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHoSo"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoSo objects.</returns>
		/// <remarks></remarks>
		public TList<GiangVienHoSo> GetByMaHoSo(TransactionManager transactionManager, System.Int32 _maHoSo)
		{
			int count = -1;
			return GetByMaHoSo(transactionManager, _maHoSo, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HoSo_HoSo key.
		///		FK_GiangVien_HoSo_HoSo Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHoSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoSo objects.</returns>
		public TList<GiangVienHoSo> GetByMaHoSo(TransactionManager transactionManager, System.Int32 _maHoSo, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHoSo(transactionManager, _maHoSo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HoSo_HoSo key.
		///		fkGiangVienHoSoHoSo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maHoSo"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoSo objects.</returns>
		public TList<GiangVienHoSo> GetByMaHoSo(System.Int32 _maHoSo, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaHoSo(null, _maHoSo, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HoSo_HoSo key.
		///		fkGiangVienHoSoHoSo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maHoSo"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoSo objects.</returns>
		public TList<GiangVienHoSo> GetByMaHoSo(System.Int32 _maHoSo, int start, int pageLength,out int count)
		{
			return GetByMaHoSo(null, _maHoSo, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HoSo_HoSo key.
		///		FK_GiangVien_HoSo_HoSo Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHoSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoSo objects.</returns>
		public abstract TList<GiangVienHoSo> GetByMaHoSo(TransactionManager transactionManager, System.Int32 _maHoSo, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.GiangVienHoSo Get(TransactionManager transactionManager, PMS.Entities.GiangVienHoSoKey key, int start, int pageLength)
		{
			return GetByMaHoSoMaGiangVien(transactionManager, key.MaHoSo, key.MaGiangVien, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GiangVien_HoSo index.
		/// </summary>
		/// <param name="_maHoSo"></param>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienHoSo"/> class.</returns>
		public PMS.Entities.GiangVienHoSo GetByMaHoSoMaGiangVien(System.Int32 _maHoSo, System.Int32 _maGiangVien)
		{
			int count = -1;
			return GetByMaHoSoMaGiangVien(null,_maHoSo, _maGiangVien, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien_HoSo index.
		/// </summary>
		/// <param name="_maHoSo"></param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienHoSo"/> class.</returns>
		public PMS.Entities.GiangVienHoSo GetByMaHoSoMaGiangVien(System.Int32 _maHoSo, System.Int32 _maGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHoSoMaGiangVien(null, _maHoSo, _maGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien_HoSo index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHoSo"></param>
		/// <param name="_maGiangVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienHoSo"/> class.</returns>
		public PMS.Entities.GiangVienHoSo GetByMaHoSoMaGiangVien(TransactionManager transactionManager, System.Int32 _maHoSo, System.Int32 _maGiangVien)
		{
			int count = -1;
			return GetByMaHoSoMaGiangVien(transactionManager, _maHoSo, _maGiangVien, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien_HoSo index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHoSo"></param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienHoSo"/> class.</returns>
		public PMS.Entities.GiangVienHoSo GetByMaHoSoMaGiangVien(TransactionManager transactionManager, System.Int32 _maHoSo, System.Int32 _maGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHoSoMaGiangVien(transactionManager, _maHoSo, _maGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien_HoSo index.
		/// </summary>
		/// <param name="_maHoSo"></param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienHoSo"/> class.</returns>
		public PMS.Entities.GiangVienHoSo GetByMaHoSoMaGiangVien(System.Int32 _maHoSo, System.Int32 _maGiangVien, int start, int pageLength, out int count)
		{
			return GetByMaHoSoMaGiangVien(null, _maHoSo, _maGiangVien, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien_HoSo index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHoSo"></param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienHoSo"/> class.</returns>
		public abstract PMS.Entities.GiangVienHoSo GetByMaHoSoMaGiangVien(TransactionManager transactionManager, System.Int32 _maHoSo, System.Int32 _maGiangVien, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GiangVienHoSo&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GiangVienHoSo&gt;"/></returns>
		public static TList<GiangVienHoSo> Fill(IDataReader reader, TList<GiangVienHoSo> rows, int start, int pageLength)
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
				
				PMS.Entities.GiangVienHoSo c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GiangVienHoSo")
					.Append("|").Append((System.Int32)reader[((int)GiangVienHoSoColumn.MaHoSo - 1)])
					.Append("|").Append((System.Int32)reader[((int)GiangVienHoSoColumn.MaGiangVien - 1)]).ToString();
					c = EntityManager.LocateOrCreate<GiangVienHoSo>(
					key.ToString(), // EntityTrackingKey
					"GiangVienHoSo",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.GiangVienHoSo();
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
					c.MaHoSo = (System.Int32)reader[(GiangVienHoSoColumn.MaHoSo.ToString())];
					c.OriginalMaHoSo = c.MaHoSo;
					c.MaGiangVien = (System.Int32)reader[(GiangVienHoSoColumn.MaGiangVien.ToString())];
					c.OriginalMaGiangVien = c.MaGiangVien;
					c.SoHoSo = (reader[GiangVienHoSoColumn.SoHoSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienHoSoColumn.SoHoSo.ToString())];
					c.NgayCap = (reader[GiangVienHoSoColumn.NgayCap.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienHoSoColumn.NgayCap.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienHoSo"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienHoSo"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.GiangVienHoSo entity)
		{
			if (!reader.Read()) return;
			
			entity.MaHoSo = (System.Int32)reader[(GiangVienHoSoColumn.MaHoSo.ToString())];
			entity.OriginalMaHoSo = (System.Int32)reader["MaHoSo"];
			entity.MaGiangVien = (System.Int32)reader[(GiangVienHoSoColumn.MaGiangVien.ToString())];
			entity.OriginalMaGiangVien = (System.Int32)reader["MaGiangVien"];
			entity.SoHoSo = (reader[GiangVienHoSoColumn.SoHoSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienHoSoColumn.SoHoSo.ToString())];
			entity.NgayCap = (reader[GiangVienHoSoColumn.NgayCap.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienHoSoColumn.NgayCap.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienHoSo"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienHoSo"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.GiangVienHoSo entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaHoSo = (System.Int32)dataRow["MaHoSo"];
			entity.OriginalMaHoSo = (System.Int32)dataRow["MaHoSo"];
			entity.MaGiangVien = (System.Int32)dataRow["MaGiangVien"];
			entity.OriginalMaGiangVien = (System.Int32)dataRow["MaGiangVien"];
			entity.SoHoSo = Convert.IsDBNull(dataRow["SoHoSo"]) ? null : (System.String)dataRow["SoHoSo"];
			entity.NgayCap = Convert.IsDBNull(dataRow["NgayCap"]) ? null : (System.String)dataRow["NgayCap"];
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
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienHoSo"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienHoSo Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.GiangVienHoSo entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaGiangVienSource	
			if (CanDeepLoad(entity, "GiangVien|MaGiangVienSource", deepLoadType, innerList) 
				&& entity.MaGiangVienSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.MaGiangVien;
				GiangVien tmpEntity = EntityManager.LocateEntity<GiangVien>(EntityLocator.ConstructKeyFromPkItems(typeof(GiangVien), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaGiangVienSource = tmpEntity;
				else
					entity.MaGiangVienSource = DataRepository.GiangVienProvider.GetByMaGiangVien(transactionManager, entity.MaGiangVien);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaGiangVienSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaGiangVienSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GiangVienProvider.DeepLoad(transactionManager, entity.MaGiangVienSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaGiangVienSource

			#region MaHoSoSource	
			if (CanDeepLoad(entity, "HoSo|MaHoSoSource", deepLoadType, innerList) 
				&& entity.MaHoSoSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.MaHoSo;
				HoSo tmpEntity = EntityManager.LocateEntity<HoSo>(EntityLocator.ConstructKeyFromPkItems(typeof(HoSo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaHoSoSource = tmpEntity;
				else
					entity.MaHoSoSource = DataRepository.HoSoProvider.GetByMaHoSo(transactionManager, entity.MaHoSo);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaHoSoSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaHoSoSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.HoSoProvider.DeepLoad(transactionManager, entity.MaHoSoSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaHoSoSource
			
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
		/// Deep Save the entire object graph of the PMS.Entities.GiangVienHoSo object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.GiangVienHoSo instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienHoSo Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.GiangVienHoSo entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaGiangVienSource
			if (CanDeepSave(entity, "GiangVien|MaGiangVienSource", deepSaveType, innerList) 
				&& entity.MaGiangVienSource != null)
			{
				DataRepository.GiangVienProvider.Save(transactionManager, entity.MaGiangVienSource);
				entity.MaGiangVien = entity.MaGiangVienSource.MaGiangVien;
			}
			#endregion 
			
			#region MaHoSoSource
			if (CanDeepSave(entity, "HoSo|MaHoSoSource", deepSaveType, innerList) 
				&& entity.MaHoSoSource != null)
			{
				DataRepository.HoSoProvider.Save(transactionManager, entity.MaHoSoSource);
				entity.MaHoSo = entity.MaHoSoSource.MaHoSo;
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
	
	#region GiangVienHoSoChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.GiangVienHoSo</c>
	///</summary>
	public enum GiangVienHoSoChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GiangVien</c> at MaGiangVienSource
		///</summary>
		[ChildEntityType(typeof(GiangVien))]
		GiangVien,
		
		///<summary>
		/// Composite Property for <c>HoSo</c> at MaHoSoSource
		///</summary>
		[ChildEntityType(typeof(HoSo))]
		HoSo,
	}
	
	#endregion GiangVienHoSoChildEntityTypes
	
	#region GiangVienHoSoFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GiangVienHoSoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienHoSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienHoSoFilterBuilder : SqlFilterBuilder<GiangVienHoSoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienHoSoFilterBuilder class.
		/// </summary>
		public GiangVienHoSoFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienHoSoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienHoSoFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienHoSoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienHoSoFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienHoSoFilterBuilder
	
	#region GiangVienHoSoParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GiangVienHoSoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienHoSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienHoSoParameterBuilder : ParameterizedSqlFilterBuilder<GiangVienHoSoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienHoSoParameterBuilder class.
		/// </summary>
		public GiangVienHoSoParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienHoSoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienHoSoParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienHoSoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienHoSoParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienHoSoParameterBuilder
	
	#region GiangVienHoSoSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GiangVienHoSoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienHoSo"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GiangVienHoSoSortBuilder : SqlSortBuilder<GiangVienHoSoColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienHoSoSqlSortBuilder class.
		/// </summary>
		public GiangVienHoSoSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GiangVienHoSoSortBuilder
	
} // end namespace
