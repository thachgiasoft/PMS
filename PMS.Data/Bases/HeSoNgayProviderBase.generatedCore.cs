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
	/// This class is the base class for any <see cref="HeSoNgayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class HeSoNgayProviderBaseCore : EntityProviderBase<PMS.Entities.HeSoNgay, PMS.Entities.HeSoNgayKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.HeSoNgayKey key)
		{
			return Delete(transactionManager, key.MaHeSo);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maHeSo">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maHeSo)
		{
			return Delete(null, _maHeSo);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSo">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maHeSo);		
		
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
		public override PMS.Entities.HeSoNgay Get(TransactionManager transactionManager, PMS.Entities.HeSoNgayKey key, int start, int pageLength)
		{
			return GetByMaHeSo(transactionManager, key.MaHeSo, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_HeSoNgayNghi index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="_maBuoi"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoNgay"/> class.</returns>
		public PMS.Entities.HeSoNgay GetByMaQuanLyMaBuoi(System.String _maQuanLy, System.String _maBuoi)
		{
			int count = -1;
			return GetByMaQuanLyMaBuoi(null,_maQuanLy, _maBuoi, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_HeSoNgayNghi index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="_maBuoi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoNgay"/> class.</returns>
		public PMS.Entities.HeSoNgay GetByMaQuanLyMaBuoi(System.String _maQuanLy, System.String _maBuoi, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLyMaBuoi(null, _maQuanLy, _maBuoi, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_HeSoNgayNghi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="_maBuoi"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoNgay"/> class.</returns>
		public PMS.Entities.HeSoNgay GetByMaQuanLyMaBuoi(TransactionManager transactionManager, System.String _maQuanLy, System.String _maBuoi)
		{
			int count = -1;
			return GetByMaQuanLyMaBuoi(transactionManager, _maQuanLy, _maBuoi, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_HeSoNgayNghi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="_maBuoi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoNgay"/> class.</returns>
		public PMS.Entities.HeSoNgay GetByMaQuanLyMaBuoi(TransactionManager transactionManager, System.String _maQuanLy, System.String _maBuoi, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLyMaBuoi(transactionManager, _maQuanLy, _maBuoi, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_HeSoNgayNghi index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="_maBuoi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoNgay"/> class.</returns>
		public PMS.Entities.HeSoNgay GetByMaQuanLyMaBuoi(System.String _maQuanLy, System.String _maBuoi, int start, int pageLength, out int count)
		{
			return GetByMaQuanLyMaBuoi(null, _maQuanLy, _maBuoi, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_HeSoNgayNghi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="_maBuoi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoNgay"/> class.</returns>
		public abstract PMS.Entities.HeSoNgay GetByMaQuanLyMaBuoi(TransactionManager transactionManager, System.String _maQuanLy, System.String _maBuoi, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_HeSoNgayNghi index.
		/// </summary>
		/// <param name="_maHeSo"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoNgay"/> class.</returns>
		public PMS.Entities.HeSoNgay GetByMaHeSo(System.Int32 _maHeSo)
		{
			int count = -1;
			return GetByMaHeSo(null,_maHeSo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoNgayNghi index.
		/// </summary>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoNgay"/> class.</returns>
		public PMS.Entities.HeSoNgay GetByMaHeSo(System.Int32 _maHeSo, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHeSo(null, _maHeSo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoNgayNghi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSo"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoNgay"/> class.</returns>
		public PMS.Entities.HeSoNgay GetByMaHeSo(TransactionManager transactionManager, System.Int32 _maHeSo)
		{
			int count = -1;
			return GetByMaHeSo(transactionManager, _maHeSo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoNgayNghi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoNgay"/> class.</returns>
		public PMS.Entities.HeSoNgay GetByMaHeSo(TransactionManager transactionManager, System.Int32 _maHeSo, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHeSo(transactionManager, _maHeSo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoNgayNghi index.
		/// </summary>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoNgay"/> class.</returns>
		public PMS.Entities.HeSoNgay GetByMaHeSo(System.Int32 _maHeSo, int start, int pageLength, out int count)
		{
			return GetByMaHeSo(null, _maHeSo, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoNgayNghi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoNgay"/> class.</returns>
		public abstract PMS.Entities.HeSoNgay GetByMaHeSo(TransactionManager transactionManager, System.Int32 _maHeSo, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_HeSoNgay_GetByThuTietBatDau 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNgay_GetByThuTietBatDau' stored procedure. 
		/// </summary>
		/// <param name="thu"> A <c>System.String</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByThuTietBatDau(System.String thu, System.Int32 tietBatDau, ref System.Double reVal)
		{
			 GetByThuTietBatDau(null, 0, int.MaxValue , thu, tietBatDau, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNgay_GetByThuTietBatDau' stored procedure. 
		/// </summary>
		/// <param name="thu"> A <c>System.String</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByThuTietBatDau(int start, int pageLength, System.String thu, System.Int32 tietBatDau, ref System.Double reVal)
		{
			 GetByThuTietBatDau(null, start, pageLength , thu, tietBatDau, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoNgay_GetByThuTietBatDau' stored procedure. 
		/// </summary>
		/// <param name="thu"> A <c>System.String</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByThuTietBatDau(TransactionManager transactionManager, System.String thu, System.Int32 tietBatDau, ref System.Double reVal)
		{
			 GetByThuTietBatDau(transactionManager, 0, int.MaxValue , thu, tietBatDau, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNgay_GetByThuTietBatDau' stored procedure. 
		/// </summary>
		/// <param name="thu"> A <c>System.String</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetByThuTietBatDau(TransactionManager transactionManager, int start, int pageLength , System.String thu, System.Int32 tietBatDau, ref System.Double reVal);
		
		#endregion
		
		#region cust_HeSoNgay_GetByMaQuanLy 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNgay_GetByMaQuanLy' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoNgay&gt;"/> instance.</returns>
		public TList<HeSoNgay> GetByMaQuanLy(System.String maQuanLy)
		{
			return GetByMaQuanLy(null, 0, int.MaxValue , maQuanLy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNgay_GetByMaQuanLy' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoNgay&gt;"/> instance.</returns>
		public TList<HeSoNgay> GetByMaQuanLy(int start, int pageLength, System.String maQuanLy)
		{
			return GetByMaQuanLy(null, start, pageLength , maQuanLy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoNgay_GetByMaQuanLy' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoNgay&gt;"/> instance.</returns>
		public TList<HeSoNgay> GetByMaQuanLy(TransactionManager transactionManager, System.String maQuanLy)
		{
			return GetByMaQuanLy(transactionManager, 0, int.MaxValue , maQuanLy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNgay_GetByMaQuanLy' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoNgay&gt;"/> instance.</returns>
		public abstract TList<HeSoNgay> GetByMaQuanLy(TransactionManager transactionManager, int start, int pageLength , System.String maQuanLy);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;HeSoNgay&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;HeSoNgay&gt;"/></returns>
		public static TList<HeSoNgay> Fill(IDataReader reader, TList<HeSoNgay> rows, int start, int pageLength)
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
				
				PMS.Entities.HeSoNgay c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("HeSoNgay")
					.Append("|").Append((System.Int32)reader[((int)HeSoNgayColumn.MaHeSo - 1)]).ToString();
					c = EntityManager.LocateOrCreate<HeSoNgay>(
					key.ToString(), // EntityTrackingKey
					"HeSoNgay",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.HeSoNgay();
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
					c.MaHeSo = (System.Int32)reader[(HeSoNgayColumn.MaHeSo.ToString())];
					c.MaQuanLy = (System.String)reader[(HeSoNgayColumn.MaQuanLy.ToString())];
					c.TenHeSo = (reader[HeSoNgayColumn.TenHeSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoNgayColumn.TenHeSo.ToString())];
					c.HeSo = (reader[HeSoNgayColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HeSoNgayColumn.HeSo.ToString())];
					c.TietBatDau = (reader[HeSoNgayColumn.TietBatDau.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoNgayColumn.TietBatDau.ToString())];
					c.TietKetThuc = (reader[HeSoNgayColumn.TietKetThuc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoNgayColumn.TietKetThuc.ToString())];
					c.TietNghiaVu = (reader[HeSoNgayColumn.TietNghiaVu.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(HeSoNgayColumn.TietNghiaVu.ToString())];
					c.TrongGio = (reader[HeSoNgayColumn.TrongGio.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(HeSoNgayColumn.TrongGio.ToString())];
					c.MaBuoi = (reader[HeSoNgayColumn.MaBuoi.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoNgayColumn.MaBuoi.ToString())];
					c.TenBuoi = (reader[HeSoNgayColumn.TenBuoi.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoNgayColumn.TenBuoi.ToString())];
					c.ThuTu = (reader[HeSoNgayColumn.ThuTu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoNgayColumn.ThuTu.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HeSoNgay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HeSoNgay"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.HeSoNgay entity)
		{
			if (!reader.Read()) return;
			
			entity.MaHeSo = (System.Int32)reader[(HeSoNgayColumn.MaHeSo.ToString())];
			entity.MaQuanLy = (System.String)reader[(HeSoNgayColumn.MaQuanLy.ToString())];
			entity.TenHeSo = (reader[HeSoNgayColumn.TenHeSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoNgayColumn.TenHeSo.ToString())];
			entity.HeSo = (reader[HeSoNgayColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HeSoNgayColumn.HeSo.ToString())];
			entity.TietBatDau = (reader[HeSoNgayColumn.TietBatDau.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoNgayColumn.TietBatDau.ToString())];
			entity.TietKetThuc = (reader[HeSoNgayColumn.TietKetThuc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoNgayColumn.TietKetThuc.ToString())];
			entity.TietNghiaVu = (reader[HeSoNgayColumn.TietNghiaVu.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(HeSoNgayColumn.TietNghiaVu.ToString())];
			entity.TrongGio = (reader[HeSoNgayColumn.TrongGio.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(HeSoNgayColumn.TrongGio.ToString())];
			entity.MaBuoi = (reader[HeSoNgayColumn.MaBuoi.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoNgayColumn.MaBuoi.ToString())];
			entity.TenBuoi = (reader[HeSoNgayColumn.TenBuoi.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoNgayColumn.TenBuoi.ToString())];
			entity.ThuTu = (reader[HeSoNgayColumn.ThuTu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoNgayColumn.ThuTu.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HeSoNgay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HeSoNgay"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.HeSoNgay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaHeSo = (System.Int32)dataRow["MaHeSo"];
			entity.MaQuanLy = (System.String)dataRow["MaQuanLy"];
			entity.TenHeSo = Convert.IsDBNull(dataRow["TenHeSo"]) ? null : (System.String)dataRow["TenHeSo"];
			entity.HeSo = Convert.IsDBNull(dataRow["HeSo"]) ? null : (System.Decimal?)dataRow["HeSo"];
			entity.TietBatDau = Convert.IsDBNull(dataRow["TietBatDau"]) ? null : (System.Int32?)dataRow["TietBatDau"];
			entity.TietKetThuc = Convert.IsDBNull(dataRow["TietKetThuc"]) ? null : (System.Int32?)dataRow["TietKetThuc"];
			entity.TietNghiaVu = Convert.IsDBNull(dataRow["TietNghiaVu"]) ? null : (System.Boolean?)dataRow["TietNghiaVu"];
			entity.TrongGio = Convert.IsDBNull(dataRow["TrongGio"]) ? null : (System.Boolean?)dataRow["TrongGio"];
			entity.MaBuoi = Convert.IsDBNull(dataRow["MaBuoi"]) ? null : (System.String)dataRow["MaBuoi"];
			entity.TenBuoi = Convert.IsDBNull(dataRow["TenBuoi"]) ? null : (System.String)dataRow["TenBuoi"];
			entity.ThuTu = Convert.IsDBNull(dataRow["ThuTu"]) ? null : (System.Int32?)dataRow["ThuTu"];
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
		/// <param name="entity">The <see cref="PMS.Entities.HeSoNgay"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.HeSoNgay Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.HeSoNgay entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.HeSoNgay object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.HeSoNgay instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.HeSoNgay Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.HeSoNgay entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region HeSoNgayChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.HeSoNgay</c>
	///</summary>
	public enum HeSoNgayChildEntityTypes
	{
	}
	
	#endregion HeSoNgayChildEntityTypes
	
	#region HeSoNgayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;HeSoNgayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoNgay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoNgayFilterBuilder : SqlFilterBuilder<HeSoNgayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoNgayFilterBuilder class.
		/// </summary>
		public HeSoNgayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HeSoNgayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HeSoNgayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HeSoNgayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HeSoNgayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HeSoNgayFilterBuilder
	
	#region HeSoNgayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;HeSoNgayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoNgay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoNgayParameterBuilder : ParameterizedSqlFilterBuilder<HeSoNgayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoNgayParameterBuilder class.
		/// </summary>
		public HeSoNgayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HeSoNgayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HeSoNgayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HeSoNgayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HeSoNgayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HeSoNgayParameterBuilder
	
	#region HeSoNgaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;HeSoNgayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoNgay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class HeSoNgaySortBuilder : SqlSortBuilder<HeSoNgayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoNgaySqlSortBuilder class.
		/// </summary>
		public HeSoNgaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion HeSoNgaySortBuilder
	
} // end namespace
