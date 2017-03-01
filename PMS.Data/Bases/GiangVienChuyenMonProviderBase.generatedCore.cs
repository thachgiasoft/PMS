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
	/// This class is the base class for any <see cref="GiangVienChuyenMonProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GiangVienChuyenMonProviderBaseCore : EntityProviderBase<PMS.Entities.GiangVienChuyenMon, PMS.Entities.GiangVienChuyenMonKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.GiangVienChuyenMonKey key)
		{
			return Delete(transactionManager, key.MaPhanCong);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maPhanCong">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maPhanCong)
		{
			return Delete(null, _maPhanCong);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maPhanCong">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maPhanCong);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_ChuyenMon_GiangVien key.
		///		FK_GiangVien_ChuyenMon_GiangVien Description: 
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienChuyenMon objects.</returns>
		public TList<GiangVienChuyenMon> GetByMaGiangVien(System.Int32? _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(_maGiangVien, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_ChuyenMon_GiangVien key.
		///		FK_GiangVien_ChuyenMon_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienChuyenMon objects.</returns>
		/// <remarks></remarks>
		public TList<GiangVienChuyenMon> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_ChuyenMon_GiangVien key.
		///		FK_GiangVien_ChuyenMon_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienChuyenMon objects.</returns>
		public TList<GiangVienChuyenMon> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_ChuyenMon_GiangVien key.
		///		fkGiangVienChuyenMonGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienChuyenMon objects.</returns>
		public TList<GiangVienChuyenMon> GetByMaGiangVien(System.Int32? _maGiangVien, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_ChuyenMon_GiangVien key.
		///		fkGiangVienChuyenMonGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienChuyenMon objects.</returns>
		public TList<GiangVienChuyenMon> GetByMaGiangVien(System.Int32? _maGiangVien, int start, int pageLength,out int count)
		{
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_ChuyenMon_GiangVien key.
		///		FK_GiangVien_ChuyenMon_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienChuyenMon objects.</returns>
		public abstract TList<GiangVienChuyenMon> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.GiangVienChuyenMon Get(TransactionManager transactionManager, PMS.Entities.GiangVienChuyenMonKey key, int start, int pageLength)
		{
			return GetByMaPhanCong(transactionManager, key.MaPhanCong, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GiangVien_ChuyenMon index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maMonHoc"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienChuyenMon"/> class.</returns>
		public PMS.Entities.GiangVienChuyenMon GetByMaGiangVienMaMonHoc(System.Int32? _maGiangVien, System.String _maMonHoc)
		{
			int count = -1;
			return GetByMaGiangVienMaMonHoc(null,_maGiangVien, _maMonHoc, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GiangVien_ChuyenMon index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maMonHoc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienChuyenMon"/> class.</returns>
		public PMS.Entities.GiangVienChuyenMon GetByMaGiangVienMaMonHoc(System.Int32? _maGiangVien, System.String _maMonHoc, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVienMaMonHoc(null, _maGiangVien, _maMonHoc, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GiangVien_ChuyenMon index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maMonHoc"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienChuyenMon"/> class.</returns>
		public PMS.Entities.GiangVienChuyenMon GetByMaGiangVienMaMonHoc(TransactionManager transactionManager, System.Int32? _maGiangVien, System.String _maMonHoc)
		{
			int count = -1;
			return GetByMaGiangVienMaMonHoc(transactionManager, _maGiangVien, _maMonHoc, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GiangVien_ChuyenMon index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maMonHoc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienChuyenMon"/> class.</returns>
		public PMS.Entities.GiangVienChuyenMon GetByMaGiangVienMaMonHoc(TransactionManager transactionManager, System.Int32? _maGiangVien, System.String _maMonHoc, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVienMaMonHoc(transactionManager, _maGiangVien, _maMonHoc, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GiangVien_ChuyenMon index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maMonHoc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienChuyenMon"/> class.</returns>
		public PMS.Entities.GiangVienChuyenMon GetByMaGiangVienMaMonHoc(System.Int32? _maGiangVien, System.String _maMonHoc, int start, int pageLength, out int count)
		{
			return GetByMaGiangVienMaMonHoc(null, _maGiangVien, _maMonHoc, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GiangVien_ChuyenMon index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maMonHoc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienChuyenMon"/> class.</returns>
		public abstract PMS.Entities.GiangVienChuyenMon GetByMaGiangVienMaMonHoc(TransactionManager transactionManager, System.Int32? _maGiangVien, System.String _maMonHoc, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GiangVien_ChuyenMon index.
		/// </summary>
		/// <param name="_maPhanCong"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienChuyenMon"/> class.</returns>
		public PMS.Entities.GiangVienChuyenMon GetByMaPhanCong(System.Int32 _maPhanCong)
		{
			int count = -1;
			return GetByMaPhanCong(null,_maPhanCong, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien_ChuyenMon index.
		/// </summary>
		/// <param name="_maPhanCong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienChuyenMon"/> class.</returns>
		public PMS.Entities.GiangVienChuyenMon GetByMaPhanCong(System.Int32 _maPhanCong, int start, int pageLength)
		{
			int count = -1;
			return GetByMaPhanCong(null, _maPhanCong, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien_ChuyenMon index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maPhanCong"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienChuyenMon"/> class.</returns>
		public PMS.Entities.GiangVienChuyenMon GetByMaPhanCong(TransactionManager transactionManager, System.Int32 _maPhanCong)
		{
			int count = -1;
			return GetByMaPhanCong(transactionManager, _maPhanCong, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien_ChuyenMon index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maPhanCong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienChuyenMon"/> class.</returns>
		public PMS.Entities.GiangVienChuyenMon GetByMaPhanCong(TransactionManager transactionManager, System.Int32 _maPhanCong, int start, int pageLength)
		{
			int count = -1;
			return GetByMaPhanCong(transactionManager, _maPhanCong, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien_ChuyenMon index.
		/// </summary>
		/// <param name="_maPhanCong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienChuyenMon"/> class.</returns>
		public PMS.Entities.GiangVienChuyenMon GetByMaPhanCong(System.Int32 _maPhanCong, int start, int pageLength, out int count)
		{
			return GetByMaPhanCong(null, _maPhanCong, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien_ChuyenMon index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maPhanCong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienChuyenMon"/> class.</returns>
		public abstract PMS.Entities.GiangVienChuyenMon GetByMaPhanCong(TransactionManager transactionManager, System.Int32 _maPhanCong, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_GiangVien_ChuyenMon_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ChuyenMon_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, System.String maGiangVien)
		{
			 Luu(null, 0, int.MaxValue , xmlData, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ChuyenMon_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, System.String maGiangVien)
		{
			 Luu(null, start, pageLength , xmlData, maGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ChuyenMon_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, System.String maGiangVien)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ChuyenMon_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String maGiangVien);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GiangVienChuyenMon&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GiangVienChuyenMon&gt;"/></returns>
		public static TList<GiangVienChuyenMon> Fill(IDataReader reader, TList<GiangVienChuyenMon> rows, int start, int pageLength)
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
				
				PMS.Entities.GiangVienChuyenMon c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GiangVienChuyenMon")
					.Append("|").Append((System.Int32)reader[((int)GiangVienChuyenMonColumn.MaPhanCong - 1)]).ToString();
					c = EntityManager.LocateOrCreate<GiangVienChuyenMon>(
					key.ToString(), // EntityTrackingKey
					"GiangVienChuyenMon",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.GiangVienChuyenMon();
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
					c.MaPhanCong = (System.Int32)reader[(GiangVienChuyenMonColumn.MaPhanCong.ToString())];
					c.MaGiangVien = (reader[GiangVienChuyenMonColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienChuyenMonColumn.MaGiangVien.ToString())];
					c.MaMonHoc = (reader[GiangVienChuyenMonColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChuyenMonColumn.MaMonHoc.ToString())];
					c.NgayPhanCong = (reader[GiangVienChuyenMonColumn.NgayPhanCong.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienChuyenMonColumn.NgayPhanCong.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienChuyenMon"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienChuyenMon"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.GiangVienChuyenMon entity)
		{
			if (!reader.Read()) return;
			
			entity.MaPhanCong = (System.Int32)reader[(GiangVienChuyenMonColumn.MaPhanCong.ToString())];
			entity.MaGiangVien = (reader[GiangVienChuyenMonColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienChuyenMonColumn.MaGiangVien.ToString())];
			entity.MaMonHoc = (reader[GiangVienChuyenMonColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienChuyenMonColumn.MaMonHoc.ToString())];
			entity.NgayPhanCong = (reader[GiangVienChuyenMonColumn.NgayPhanCong.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienChuyenMonColumn.NgayPhanCong.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienChuyenMon"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienChuyenMon"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.GiangVienChuyenMon entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaPhanCong = (System.Int32)dataRow["MaPhanCong"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.Int32?)dataRow["MaGiangVien"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.NgayPhanCong = Convert.IsDBNull(dataRow["NgayPhanCong"]) ? null : (System.DateTime?)dataRow["NgayPhanCong"];
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
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienChuyenMon"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienChuyenMon Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.GiangVienChuyenMon entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaGiangVienSource	
			if (CanDeepLoad(entity, "GiangVien|MaGiangVienSource", deepLoadType, innerList) 
				&& entity.MaGiangVienSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaGiangVien ?? (int)0);
				GiangVien tmpEntity = EntityManager.LocateEntity<GiangVien>(EntityLocator.ConstructKeyFromPkItems(typeof(GiangVien), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaGiangVienSource = tmpEntity;
				else
					entity.MaGiangVienSource = DataRepository.GiangVienProvider.GetByMaGiangVien(transactionManager, (entity.MaGiangVien ?? (int)0));		
				
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
		/// Deep Save the entire object graph of the PMS.Entities.GiangVienChuyenMon object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.GiangVienChuyenMon instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienChuyenMon Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.GiangVienChuyenMon entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region GiangVienChuyenMonChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.GiangVienChuyenMon</c>
	///</summary>
	public enum GiangVienChuyenMonChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GiangVien</c> at MaGiangVienSource
		///</summary>
		[ChildEntityType(typeof(GiangVien))]
		GiangVien,
	}
	
	#endregion GiangVienChuyenMonChildEntityTypes
	
	#region GiangVienChuyenMonFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GiangVienChuyenMonColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienChuyenMon"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienChuyenMonFilterBuilder : SqlFilterBuilder<GiangVienChuyenMonColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienChuyenMonFilterBuilder class.
		/// </summary>
		public GiangVienChuyenMonFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienChuyenMonFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienChuyenMonFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienChuyenMonFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienChuyenMonFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienChuyenMonFilterBuilder
	
	#region GiangVienChuyenMonParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GiangVienChuyenMonColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienChuyenMon"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienChuyenMonParameterBuilder : ParameterizedSqlFilterBuilder<GiangVienChuyenMonColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienChuyenMonParameterBuilder class.
		/// </summary>
		public GiangVienChuyenMonParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienChuyenMonParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienChuyenMonParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienChuyenMonParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienChuyenMonParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienChuyenMonParameterBuilder
	
	#region GiangVienChuyenMonSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GiangVienChuyenMonColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienChuyenMon"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GiangVienChuyenMonSortBuilder : SqlSortBuilder<GiangVienChuyenMonColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienChuyenMonSqlSortBuilder class.
		/// </summary>
		public GiangVienChuyenMonSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GiangVienChuyenMonSortBuilder
	
} // end namespace
