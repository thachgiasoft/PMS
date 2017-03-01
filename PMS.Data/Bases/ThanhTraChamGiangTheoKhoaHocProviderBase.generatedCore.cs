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
	/// This class is the base class for any <see cref="ThanhTraChamGiangTheoKhoaHocProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ThanhTraChamGiangTheoKhoaHocProviderBaseCore : EntityProviderBase<PMS.Entities.ThanhTraChamGiangTheoKhoaHoc, PMS.Entities.ThanhTraChamGiangTheoKhoaHocKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.ThanhTraChamGiangTheoKhoaHocKey key)
		{
			return Delete(transactionManager, key.NamHoc, key.HocKy, key.MaKhoaHoc);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_namHoc">. Primary Key.</param>
		/// <param name="_hocKy">. Primary Key.</param>
		/// <param name="_maKhoaHoc">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _namHoc, System.String _hocKy, System.String _maKhoaHoc)
		{
			return Delete(null, _namHoc, _hocKy, _maKhoaHoc);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_namHoc">. Primary Key.</param>
		/// <param name="_hocKy">. Primary Key.</param>
		/// <param name="_maKhoaHoc">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _namHoc, System.String _hocKy, System.String _maKhoaHoc);		
		
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
		public override PMS.Entities.ThanhTraChamGiangTheoKhoaHoc Get(TransactionManager transactionManager, PMS.Entities.ThanhTraChamGiangTheoKhoaHocKey key, int start, int pageLength)
		{
			return GetByNamHocHocKyMaKhoaHoc(transactionManager, key.NamHoc, key.HocKy, key.MaKhoaHoc, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ThanhTraChamGiangTheoKhoaHoc index.
		/// </summary>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <param name="_maKhoaHoc"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhTraChamGiangTheoKhoaHoc"/> class.</returns>
		public PMS.Entities.ThanhTraChamGiangTheoKhoaHoc GetByNamHocHocKyMaKhoaHoc(System.String _namHoc, System.String _hocKy, System.String _maKhoaHoc)
		{
			int count = -1;
			return GetByNamHocHocKyMaKhoaHoc(null,_namHoc, _hocKy, _maKhoaHoc, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThanhTraChamGiangTheoKhoaHoc index.
		/// </summary>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <param name="_maKhoaHoc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhTraChamGiangTheoKhoaHoc"/> class.</returns>
		public PMS.Entities.ThanhTraChamGiangTheoKhoaHoc GetByNamHocHocKyMaKhoaHoc(System.String _namHoc, System.String _hocKy, System.String _maKhoaHoc, int start, int pageLength)
		{
			int count = -1;
			return GetByNamHocHocKyMaKhoaHoc(null, _namHoc, _hocKy, _maKhoaHoc, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThanhTraChamGiangTheoKhoaHoc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <param name="_maKhoaHoc"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhTraChamGiangTheoKhoaHoc"/> class.</returns>
		public PMS.Entities.ThanhTraChamGiangTheoKhoaHoc GetByNamHocHocKyMaKhoaHoc(TransactionManager transactionManager, System.String _namHoc, System.String _hocKy, System.String _maKhoaHoc)
		{
			int count = -1;
			return GetByNamHocHocKyMaKhoaHoc(transactionManager, _namHoc, _hocKy, _maKhoaHoc, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThanhTraChamGiangTheoKhoaHoc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <param name="_maKhoaHoc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhTraChamGiangTheoKhoaHoc"/> class.</returns>
		public PMS.Entities.ThanhTraChamGiangTheoKhoaHoc GetByNamHocHocKyMaKhoaHoc(TransactionManager transactionManager, System.String _namHoc, System.String _hocKy, System.String _maKhoaHoc, int start, int pageLength)
		{
			int count = -1;
			return GetByNamHocHocKyMaKhoaHoc(transactionManager, _namHoc, _hocKy, _maKhoaHoc, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThanhTraChamGiangTheoKhoaHoc index.
		/// </summary>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <param name="_maKhoaHoc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhTraChamGiangTheoKhoaHoc"/> class.</returns>
		public PMS.Entities.ThanhTraChamGiangTheoKhoaHoc GetByNamHocHocKyMaKhoaHoc(System.String _namHoc, System.String _hocKy, System.String _maKhoaHoc, int start, int pageLength, out int count)
		{
			return GetByNamHocHocKyMaKhoaHoc(null, _namHoc, _hocKy, _maKhoaHoc, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThanhTraChamGiangTheoKhoaHoc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <param name="_maKhoaHoc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhTraChamGiangTheoKhoaHoc"/> class.</returns>
		public abstract PMS.Entities.ThanhTraChamGiangTheoKhoaHoc GetByNamHocHocKyMaKhoaHoc(TransactionManager transactionManager, System.String _namHoc, System.String _hocKy, System.String _maKhoaHoc, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_ThanhTraChamGiangTheoKhoaHoc_SaoChep 
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraChamGiangTheoKhoaHoc_SaoChep' stored procedure. 
		/// </summary>
		/// <param name="namHocNguon"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyNguon"> A <c>System.String</c> instance.</param>
		/// <param name="namHocDich"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyDich"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void SaoChep(System.String namHocNguon, System.String hocKyNguon, System.String namHocDich, System.String hocKyDich)
		{
			 SaoChep(null, 0, int.MaxValue , namHocNguon, hocKyNguon, namHocDich, hocKyDich);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraChamGiangTheoKhoaHoc_SaoChep' stored procedure. 
		/// </summary>
		/// <param name="namHocNguon"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyNguon"> A <c>System.String</c> instance.</param>
		/// <param name="namHocDich"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyDich"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void SaoChep(int start, int pageLength, System.String namHocNguon, System.String hocKyNguon, System.String namHocDich, System.String hocKyDich)
		{
			 SaoChep(null, start, pageLength , namHocNguon, hocKyNguon, namHocDich, hocKyDich);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThanhTraChamGiangTheoKhoaHoc_SaoChep' stored procedure. 
		/// </summary>
		/// <param name="namHocNguon"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyNguon"> A <c>System.String</c> instance.</param>
		/// <param name="namHocDich"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyDich"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void SaoChep(TransactionManager transactionManager, System.String namHocNguon, System.String hocKyNguon, System.String namHocDich, System.String hocKyDich)
		{
			 SaoChep(transactionManager, 0, int.MaxValue , namHocNguon, hocKyNguon, namHocDich, hocKyDich);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraChamGiangTheoKhoaHoc_SaoChep' stored procedure. 
		/// </summary>
		/// <param name="namHocNguon"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyNguon"> A <c>System.String</c> instance.</param>
		/// <param name="namHocDich"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyDich"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void SaoChep(TransactionManager transactionManager, int start, int pageLength , System.String namHocNguon, System.String hocKyNguon, System.String namHocDich, System.String hocKyDich);
		
		#endregion
		
		#region cust_ThanhTraChamGiangTheoKhoaHoc_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraChamGiangTheoKhoaHoc_Luu' stored procedure. 
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
		///	This method wrap the 'cust_ThanhTraChamGiangTheoKhoaHoc_Luu' stored procedure. 
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
		///	This method wrap the 'cust_ThanhTraChamGiangTheoKhoaHoc_Luu' stored procedure. 
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
		///	This method wrap the 'cust_ThanhTraChamGiangTheoKhoaHoc_Luu' stored procedure. 
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
		/// Fill a TList&lt;ThanhTraChamGiangTheoKhoaHoc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ThanhTraChamGiangTheoKhoaHoc&gt;"/></returns>
		public static TList<ThanhTraChamGiangTheoKhoaHoc> Fill(IDataReader reader, TList<ThanhTraChamGiangTheoKhoaHoc> rows, int start, int pageLength)
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
				
				PMS.Entities.ThanhTraChamGiangTheoKhoaHoc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ThanhTraChamGiangTheoKhoaHoc")
					.Append("|").Append((System.String)reader[((int)ThanhTraChamGiangTheoKhoaHocColumn.NamHoc - 1)])
					.Append("|").Append((System.String)reader[((int)ThanhTraChamGiangTheoKhoaHocColumn.HocKy - 1)])
					.Append("|").Append((System.String)reader[((int)ThanhTraChamGiangTheoKhoaHocColumn.MaKhoaHoc - 1)]).ToString();
					c = EntityManager.LocateOrCreate<ThanhTraChamGiangTheoKhoaHoc>(
					key.ToString(), // EntityTrackingKey
					"ThanhTraChamGiangTheoKhoaHoc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.ThanhTraChamGiangTheoKhoaHoc();
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
					c.NamHoc = (System.String)reader[(ThanhTraChamGiangTheoKhoaHocColumn.NamHoc.ToString())];
					c.OriginalNamHoc = c.NamHoc;
					c.HocKy = (System.String)reader[(ThanhTraChamGiangTheoKhoaHocColumn.HocKy.ToString())];
					c.OriginalHocKy = c.HocKy;
					c.MaKhoaHoc = (System.String)reader[(ThanhTraChamGiangTheoKhoaHocColumn.MaKhoaHoc.ToString())];
					c.OriginalMaKhoaHoc = c.MaKhoaHoc;
					c.Chon = (reader[ThanhTraChamGiangTheoKhoaHocColumn.Chon.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ThanhTraChamGiangTheoKhoaHocColumn.Chon.ToString())];
					c.NgayCapNhat = (reader[ThanhTraChamGiangTheoKhoaHocColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraChamGiangTheoKhoaHocColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[ThanhTraChamGiangTheoKhoaHocColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraChamGiangTheoKhoaHocColumn.NguoiCapNhat.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThanhTraChamGiangTheoKhoaHoc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThanhTraChamGiangTheoKhoaHoc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.ThanhTraChamGiangTheoKhoaHoc entity)
		{
			if (!reader.Read()) return;
			
			entity.NamHoc = (System.String)reader[(ThanhTraChamGiangTheoKhoaHocColumn.NamHoc.ToString())];
			entity.OriginalNamHoc = (System.String)reader["NamHoc"];
			entity.HocKy = (System.String)reader[(ThanhTraChamGiangTheoKhoaHocColumn.HocKy.ToString())];
			entity.OriginalHocKy = (System.String)reader["HocKy"];
			entity.MaKhoaHoc = (System.String)reader[(ThanhTraChamGiangTheoKhoaHocColumn.MaKhoaHoc.ToString())];
			entity.OriginalMaKhoaHoc = (System.String)reader["MaKhoaHoc"];
			entity.Chon = (reader[ThanhTraChamGiangTheoKhoaHocColumn.Chon.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ThanhTraChamGiangTheoKhoaHocColumn.Chon.ToString())];
			entity.NgayCapNhat = (reader[ThanhTraChamGiangTheoKhoaHocColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraChamGiangTheoKhoaHocColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[ThanhTraChamGiangTheoKhoaHocColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraChamGiangTheoKhoaHocColumn.NguoiCapNhat.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThanhTraChamGiangTheoKhoaHoc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThanhTraChamGiangTheoKhoaHoc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.ThanhTraChamGiangTheoKhoaHoc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.NamHoc = (System.String)dataRow["NamHoc"];
			entity.OriginalNamHoc = (System.String)dataRow["NamHoc"];
			entity.HocKy = (System.String)dataRow["HocKy"];
			entity.OriginalHocKy = (System.String)dataRow["HocKy"];
			entity.MaKhoaHoc = (System.String)dataRow["MaKhoaHoc"];
			entity.OriginalMaKhoaHoc = (System.String)dataRow["MaKhoaHoc"];
			entity.Chon = Convert.IsDBNull(dataRow["Chon"]) ? null : (System.Boolean?)dataRow["Chon"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
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
		/// <param name="entity">The <see cref="PMS.Entities.ThanhTraChamGiangTheoKhoaHoc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.ThanhTraChamGiangTheoKhoaHoc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.ThanhTraChamGiangTheoKhoaHoc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.ThanhTraChamGiangTheoKhoaHoc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.ThanhTraChamGiangTheoKhoaHoc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.ThanhTraChamGiangTheoKhoaHoc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.ThanhTraChamGiangTheoKhoaHoc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region ThanhTraChamGiangTheoKhoaHocChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.ThanhTraChamGiangTheoKhoaHoc</c>
	///</summary>
	public enum ThanhTraChamGiangTheoKhoaHocChildEntityTypes
	{
	}
	
	#endregion ThanhTraChamGiangTheoKhoaHocChildEntityTypes
	
	#region ThanhTraChamGiangTheoKhoaHocFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ThanhTraChamGiangTheoKhoaHocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThanhTraChamGiangTheoKhoaHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThanhTraChamGiangTheoKhoaHocFilterBuilder : SqlFilterBuilder<ThanhTraChamGiangTheoKhoaHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThanhTraChamGiangTheoKhoaHocFilterBuilder class.
		/// </summary>
		public ThanhTraChamGiangTheoKhoaHocFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThanhTraChamGiangTheoKhoaHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThanhTraChamGiangTheoKhoaHocFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThanhTraChamGiangTheoKhoaHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThanhTraChamGiangTheoKhoaHocFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThanhTraChamGiangTheoKhoaHocFilterBuilder
	
	#region ThanhTraChamGiangTheoKhoaHocParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ThanhTraChamGiangTheoKhoaHocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThanhTraChamGiangTheoKhoaHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThanhTraChamGiangTheoKhoaHocParameterBuilder : ParameterizedSqlFilterBuilder<ThanhTraChamGiangTheoKhoaHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThanhTraChamGiangTheoKhoaHocParameterBuilder class.
		/// </summary>
		public ThanhTraChamGiangTheoKhoaHocParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThanhTraChamGiangTheoKhoaHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThanhTraChamGiangTheoKhoaHocParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThanhTraChamGiangTheoKhoaHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThanhTraChamGiangTheoKhoaHocParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThanhTraChamGiangTheoKhoaHocParameterBuilder
	
	#region ThanhTraChamGiangTheoKhoaHocSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ThanhTraChamGiangTheoKhoaHocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThanhTraChamGiangTheoKhoaHoc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ThanhTraChamGiangTheoKhoaHocSortBuilder : SqlSortBuilder<ThanhTraChamGiangTheoKhoaHocColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThanhTraChamGiangTheoKhoaHocSqlSortBuilder class.
		/// </summary>
		public ThanhTraChamGiangTheoKhoaHocSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ThanhTraChamGiangTheoKhoaHocSortBuilder
	
} // end namespace
