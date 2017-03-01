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
	/// This class is the base class for any <see cref="BangPhuTroiNamHocProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class BangPhuTroiNamHocProviderBaseCore : EntityProviderBase<PMS.Entities.BangPhuTroiNamHoc, PMS.Entities.BangPhuTroiNamHocKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.BangPhuTroiNamHocKey key)
		{
			return Delete(transactionManager, key.MaGiangVien, key.NamHoc);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maGiangVien">. Primary Key.</param>
		/// <param name="_namHoc">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maGiangVien, System.String _namHoc)
		{
			return Delete(null, _maGiangVien, _namHoc);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien">. Primary Key.</param>
		/// <param name="_namHoc">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maGiangVien, System.String _namHoc);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_BangPhuTroiNamHoc_GiangVien key.
		///		FK_BangPhuTroiNamHoc_GiangVien Description: 
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.BangPhuTroiNamHoc objects.</returns>
		public TList<BangPhuTroiNamHoc> GetByMaGiangVien(System.Int32 _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(_maGiangVien, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_BangPhuTroiNamHoc_GiangVien key.
		///		FK_BangPhuTroiNamHoc_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.BangPhuTroiNamHoc objects.</returns>
		/// <remarks></remarks>
		public TList<BangPhuTroiNamHoc> GetByMaGiangVien(TransactionManager transactionManager, System.Int32 _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_BangPhuTroiNamHoc_GiangVien key.
		///		FK_BangPhuTroiNamHoc_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.BangPhuTroiNamHoc objects.</returns>
		public TList<BangPhuTroiNamHoc> GetByMaGiangVien(TransactionManager transactionManager, System.Int32 _maGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_BangPhuTroiNamHoc_GiangVien key.
		///		fkBangPhuTroiNamHocGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.BangPhuTroiNamHoc objects.</returns>
		public TList<BangPhuTroiNamHoc> GetByMaGiangVien(System.Int32 _maGiangVien, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_BangPhuTroiNamHoc_GiangVien key.
		///		fkBangPhuTroiNamHocGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.BangPhuTroiNamHoc objects.</returns>
		public TList<BangPhuTroiNamHoc> GetByMaGiangVien(System.Int32 _maGiangVien, int start, int pageLength,out int count)
		{
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_BangPhuTroiNamHoc_GiangVien key.
		///		FK_BangPhuTroiNamHoc_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.BangPhuTroiNamHoc objects.</returns>
		public abstract TList<BangPhuTroiNamHoc> GetByMaGiangVien(TransactionManager transactionManager, System.Int32 _maGiangVien, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.BangPhuTroiNamHoc Get(TransactionManager transactionManager, PMS.Entities.BangPhuTroiNamHocKey key, int start, int pageLength)
		{
			return GetByMaGiangVienNamHoc(transactionManager, key.MaGiangVien, key.NamHoc, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_BangPhuTroiNamHoc index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="_namHoc"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.BangPhuTroiNamHoc"/> class.</returns>
		public PMS.Entities.BangPhuTroiNamHoc GetByMaGiangVienNamHoc(System.Int32 _maGiangVien, System.String _namHoc)
		{
			int count = -1;
			return GetByMaGiangVienNamHoc(null,_maGiangVien, _namHoc, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_BangPhuTroiNamHoc index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="_namHoc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.BangPhuTroiNamHoc"/> class.</returns>
		public PMS.Entities.BangPhuTroiNamHoc GetByMaGiangVienNamHoc(System.Int32 _maGiangVien, System.String _namHoc, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVienNamHoc(null, _maGiangVien, _namHoc, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_BangPhuTroiNamHoc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_namHoc"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.BangPhuTroiNamHoc"/> class.</returns>
		public PMS.Entities.BangPhuTroiNamHoc GetByMaGiangVienNamHoc(TransactionManager transactionManager, System.Int32 _maGiangVien, System.String _namHoc)
		{
			int count = -1;
			return GetByMaGiangVienNamHoc(transactionManager, _maGiangVien, _namHoc, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_BangPhuTroiNamHoc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_namHoc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.BangPhuTroiNamHoc"/> class.</returns>
		public PMS.Entities.BangPhuTroiNamHoc GetByMaGiangVienNamHoc(TransactionManager transactionManager, System.Int32 _maGiangVien, System.String _namHoc, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVienNamHoc(transactionManager, _maGiangVien, _namHoc, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_BangPhuTroiNamHoc index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="_namHoc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.BangPhuTroiNamHoc"/> class.</returns>
		public PMS.Entities.BangPhuTroiNamHoc GetByMaGiangVienNamHoc(System.Int32 _maGiangVien, System.String _namHoc, int start, int pageLength, out int count)
		{
			return GetByMaGiangVienNamHoc(null, _maGiangVien, _namHoc, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_BangPhuTroiNamHoc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_namHoc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.BangPhuTroiNamHoc"/> class.</returns>
		public abstract PMS.Entities.BangPhuTroiNamHoc GetByMaGiangVienNamHoc(TransactionManager transactionManager, System.Int32 _maGiangVien, System.String _namHoc, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_BangPhuTroiNamHoc_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_BangPhuTroiNamHoc_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="khoa"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, System.String namHoc, System.String khoa, ref System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , xmlData, namHoc, khoa, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_BangPhuTroiNamHoc_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="khoa"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, System.String namHoc, System.String khoa, ref System.Int32 reVal)
		{
			 Luu(null, start, pageLength , xmlData, namHoc, khoa, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_BangPhuTroiNamHoc_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="khoa"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String khoa, ref System.Int32 reVal)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, namHoc, khoa, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_BangPhuTroiNamHoc_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="khoa"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String khoa, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;BangPhuTroiNamHoc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;BangPhuTroiNamHoc&gt;"/></returns>
		public static TList<BangPhuTroiNamHoc> Fill(IDataReader reader, TList<BangPhuTroiNamHoc> rows, int start, int pageLength)
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
				
				PMS.Entities.BangPhuTroiNamHoc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("BangPhuTroiNamHoc")
					.Append("|").Append((System.Int32)reader[((int)BangPhuTroiNamHocColumn.MaGiangVien - 1)])
					.Append("|").Append((System.String)reader[((int)BangPhuTroiNamHocColumn.NamHoc - 1)]).ToString();
					c = EntityManager.LocateOrCreate<BangPhuTroiNamHoc>(
					key.ToString(), // EntityTrackingKey
					"BangPhuTroiNamHoc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.BangPhuTroiNamHoc();
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
					c.MaGiangVien = (System.Int32)reader[(BangPhuTroiNamHocColumn.MaGiangVien.ToString())];
					c.OriginalMaGiangVien = c.MaGiangVien;
					c.NamHoc = (System.String)reader[(BangPhuTroiNamHocColumn.NamHoc.ToString())];
					c.OriginalNamHoc = c.NamHoc;
					c.SoTietNckhTrungCap = (reader[BangPhuTroiNamHocColumn.SoTietNckhTrungCap.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(BangPhuTroiNamHocColumn.SoTietNckhTrungCap.ToString())];
					c.SoTietNckhCaoDang = (reader[BangPhuTroiNamHocColumn.SoTietNckhCaoDang.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(BangPhuTroiNamHocColumn.SoTietNckhCaoDang.ToString())];
					c.GioThiHk1 = (reader[BangPhuTroiNamHocColumn.GioThiHk1.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(BangPhuTroiNamHocColumn.GioThiHk1.ToString())];
					c.GioThiHk2 = (reader[BangPhuTroiNamHocColumn.GioThiHk2.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(BangPhuTroiNamHocColumn.GioThiHk2.ToString())];
					c.TietQuyDoiHuongDanGvTinhNguyen = (reader[BangPhuTroiNamHocColumn.TietQuyDoiHuongDanGvTinhNguyen.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(BangPhuTroiNamHocColumn.TietQuyDoiHuongDanGvTinhNguyen.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.BangPhuTroiNamHoc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.BangPhuTroiNamHoc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.BangPhuTroiNamHoc entity)
		{
			if (!reader.Read()) return;
			
			entity.MaGiangVien = (System.Int32)reader[(BangPhuTroiNamHocColumn.MaGiangVien.ToString())];
			entity.OriginalMaGiangVien = (System.Int32)reader["MaGiangVien"];
			entity.NamHoc = (System.String)reader[(BangPhuTroiNamHocColumn.NamHoc.ToString())];
			entity.OriginalNamHoc = (System.String)reader["NamHoc"];
			entity.SoTietNckhTrungCap = (reader[BangPhuTroiNamHocColumn.SoTietNckhTrungCap.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(BangPhuTroiNamHocColumn.SoTietNckhTrungCap.ToString())];
			entity.SoTietNckhCaoDang = (reader[BangPhuTroiNamHocColumn.SoTietNckhCaoDang.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(BangPhuTroiNamHocColumn.SoTietNckhCaoDang.ToString())];
			entity.GioThiHk1 = (reader[BangPhuTroiNamHocColumn.GioThiHk1.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(BangPhuTroiNamHocColumn.GioThiHk1.ToString())];
			entity.GioThiHk2 = (reader[BangPhuTroiNamHocColumn.GioThiHk2.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(BangPhuTroiNamHocColumn.GioThiHk2.ToString())];
			entity.TietQuyDoiHuongDanGvTinhNguyen = (reader[BangPhuTroiNamHocColumn.TietQuyDoiHuongDanGvTinhNguyen.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(BangPhuTroiNamHocColumn.TietQuyDoiHuongDanGvTinhNguyen.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.BangPhuTroiNamHoc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.BangPhuTroiNamHoc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.BangPhuTroiNamHoc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (System.Int32)dataRow["MaGiangVien"];
			entity.OriginalMaGiangVien = (System.Int32)dataRow["MaGiangVien"];
			entity.NamHoc = (System.String)dataRow["NamHoc"];
			entity.OriginalNamHoc = (System.String)dataRow["NamHoc"];
			entity.SoTietNckhTrungCap = Convert.IsDBNull(dataRow["SoTietNCKH_TrungCap"]) ? null : (System.Decimal?)dataRow["SoTietNCKH_TrungCap"];
			entity.SoTietNckhCaoDang = Convert.IsDBNull(dataRow["SoTietNCKH_CaoDang"]) ? null : (System.Decimal?)dataRow["SoTietNCKH_CaoDang"];
			entity.GioThiHk1 = Convert.IsDBNull(dataRow["GioThiHK1"]) ? null : (System.Decimal?)dataRow["GioThiHK1"];
			entity.GioThiHk2 = Convert.IsDBNull(dataRow["GioThiHK2"]) ? null : (System.Decimal?)dataRow["GioThiHK2"];
			entity.TietQuyDoiHuongDanGvTinhNguyen = Convert.IsDBNull(dataRow["TietQuyDoiHuongDanGvTinhNguyen"]) ? null : (System.Decimal?)dataRow["TietQuyDoiHuongDanGvTinhNguyen"];
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
		/// <param name="entity">The <see cref="PMS.Entities.BangPhuTroiNamHoc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.BangPhuTroiNamHoc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.BangPhuTroiNamHoc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.BangPhuTroiNamHoc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.BangPhuTroiNamHoc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.BangPhuTroiNamHoc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.BangPhuTroiNamHoc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region BangPhuTroiNamHocChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.BangPhuTroiNamHoc</c>
	///</summary>
	public enum BangPhuTroiNamHocChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GiangVien</c> at MaGiangVienSource
		///</summary>
		[ChildEntityType(typeof(GiangVien))]
		GiangVien,
	}
	
	#endregion BangPhuTroiNamHocChildEntityTypes
	
	#region BangPhuTroiNamHocFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;BangPhuTroiNamHocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="BangPhuTroiNamHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class BangPhuTroiNamHocFilterBuilder : SqlFilterBuilder<BangPhuTroiNamHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the BangPhuTroiNamHocFilterBuilder class.
		/// </summary>
		public BangPhuTroiNamHocFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the BangPhuTroiNamHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public BangPhuTroiNamHocFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the BangPhuTroiNamHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public BangPhuTroiNamHocFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion BangPhuTroiNamHocFilterBuilder
	
	#region BangPhuTroiNamHocParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;BangPhuTroiNamHocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="BangPhuTroiNamHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class BangPhuTroiNamHocParameterBuilder : ParameterizedSqlFilterBuilder<BangPhuTroiNamHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the BangPhuTroiNamHocParameterBuilder class.
		/// </summary>
		public BangPhuTroiNamHocParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the BangPhuTroiNamHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public BangPhuTroiNamHocParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the BangPhuTroiNamHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public BangPhuTroiNamHocParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion BangPhuTroiNamHocParameterBuilder
	
	#region BangPhuTroiNamHocSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;BangPhuTroiNamHocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="BangPhuTroiNamHoc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class BangPhuTroiNamHocSortBuilder : SqlSortBuilder<BangPhuTroiNamHocColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the BangPhuTroiNamHocSqlSortBuilder class.
		/// </summary>
		public BangPhuTroiNamHocSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion BangPhuTroiNamHocSortBuilder
	
} // end namespace
