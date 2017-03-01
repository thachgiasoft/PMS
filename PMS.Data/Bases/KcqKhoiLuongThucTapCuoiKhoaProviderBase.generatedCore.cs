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
	/// This class is the base class for any <see cref="KcqKhoiLuongThucTapCuoiKhoaProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KcqKhoiLuongThucTapCuoiKhoaProviderBaseCore : EntityProviderBase<PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa, PMS.Entities.KcqKhoiLuongThucTapCuoiKhoaKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KcqKhoiLuongThucTapCuoiKhoaKey key)
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
		public override PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa Get(TransactionManager transactionManager, PMS.Entities.KcqKhoiLuongThucTapCuoiKhoaKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KcqKhoiLuongThucTapCuoiKhoa index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa"/> class.</returns>
		public PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqKhoiLuongThucTapCuoiKhoa index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa"/> class.</returns>
		public PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqKhoiLuongThucTapCuoiKhoa index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa"/> class.</returns>
		public PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqKhoiLuongThucTapCuoiKhoa index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa"/> class.</returns>
		public PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqKhoiLuongThucTapCuoiKhoa index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa"/> class.</returns>
		public PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqKhoiLuongThucTapCuoiKhoa index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa"/> class.</returns>
		public abstract PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_KcqKhoiLuongThucTapCuoiKhoa_DongBo 
		
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongThucTapCuoiKhoa_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBo(System.String namHoc, System.String hocKy)
		{
			 DongBo(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongThucTapCuoiKhoa_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBo(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			 DongBo(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongThucTapCuoiKhoa_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBo(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			 DongBo(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongThucTapCuoiKhoa_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DongBo(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_KcqKhoiLuongThucTapCuoiKhoa_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongThucTapCuoiKhoa_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongThucTapCuoiKhoa_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongThucTapCuoiKhoa_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongThucTapCuoiKhoa_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_KcqKhoiLuongThucTapCuoiKhoa_ThongKeTheoNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongThucTapCuoiKhoa_ThongKeTheoNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTheoNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return ThongKeTheoNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongThucTapCuoiKhoa_ThongKeTheoNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTheoNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return ThongKeTheoNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongThucTapCuoiKhoa_ThongKeTheoNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTheoNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return ThongKeTheoNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongThucTapCuoiKhoa_ThongKeTheoNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeTheoNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_KcqKhoiLuongThucTapCuoiKhoa_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongThucTapCuoiKhoa_Luu' stored procedure. 
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
		///	This method wrap the 'cust_KcqKhoiLuongThucTapCuoiKhoa_Luu' stored procedure. 
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
		///	This method wrap the 'cust_KcqKhoiLuongThucTapCuoiKhoa_Luu' stored procedure. 
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
		///	This method wrap the 'cust_KcqKhoiLuongThucTapCuoiKhoa_Luu' stored procedure. 
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
		/// Fill a TList&lt;KcqKhoiLuongThucTapCuoiKhoa&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KcqKhoiLuongThucTapCuoiKhoa&gt;"/></returns>
		public static TList<KcqKhoiLuongThucTapCuoiKhoa> Fill(IDataReader reader, TList<KcqKhoiLuongThucTapCuoiKhoa> rows, int start, int pageLength)
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
				
				PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KcqKhoiLuongThucTapCuoiKhoa")
					.Append("|").Append((System.Int32)reader[((int)KcqKhoiLuongThucTapCuoiKhoaColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KcqKhoiLuongThucTapCuoiKhoa>(
					key.ToString(), // EntityTrackingKey
					"KcqKhoiLuongThucTapCuoiKhoa",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa();
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
					c.Id = (System.Int32)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.Id.ToString())];
					c.NamHoc = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.NamHoc.ToString())];
					c.HocKy = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.HocKy.ToString())];
					c.MaGiangVien = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.MaGiangVien.ToString())];
					c.MaMonHoc = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.MaMonHoc.ToString())];
					c.MaLopHocPhan = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.MaLopHocPhan.ToString())];
					c.MaLoaiHocPhan = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.MaLoaiHocPhan.ToString())];
					c.MaNhom = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.MaNhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.MaNhom.ToString())];
					c.MaLop = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.MaLop.ToString())];
					c.SiSo = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.SiSo.ToString())];
					c.SoTinChi = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.SoTinChi.ToString())];
					c.SoTuan = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.SoTuan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.SoTuan.ToString())];
					c.HeSoHocKy = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.HeSoHocKy.ToString())];
					c.TietQuyDoi = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.TietQuyDoi.ToString())];
					c.DonGia = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.DonGia.ToString())];
					c.MaDiaDiem = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.MaDiaDiem.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.MaDiaDiem.ToString())];
					c.HeSoDiaDiem = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.HeSoDiaDiem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.HeSoDiaDiem.ToString())];
					c.DonGiaDiaDiem = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.DonGiaDiaDiem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.DonGiaDiaDiem.ToString())];
					c.TienXeDiaDiem = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.TienXeDiaDiem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.TienXeDiaDiem.ToString())];
					c.ThanhTienGiangDay = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.ThanhTienGiangDay.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.ThanhTienGiangDay.ToString())];
					c.GhiChu = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.GhiChu.ToString())];
					c.DotThanhToan = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.DotThanhToan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.DotThanhToan.ToString())];
					c.MaDonVi = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.MaDonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.MaDonVi.ToString())];
					c.MaHocHam = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.MaHocVi.ToString())];
					c.MaLoaiGiangVien = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.MaLoaiGiangVien.ToString())];
					c.HeSoQuyDoi = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.HeSoQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.HeSoQuyDoi.ToString())];
					c.Loai = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.Loai.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.Loai.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.Id.ToString())];
			entity.NamHoc = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.NamHoc.ToString())];
			entity.HocKy = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.HocKy.ToString())];
			entity.MaGiangVien = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.MaGiangVien.ToString())];
			entity.MaMonHoc = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.MaMonHoc.ToString())];
			entity.MaLopHocPhan = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.MaLopHocPhan.ToString())];
			entity.MaLoaiHocPhan = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.MaLoaiHocPhan.ToString())];
			entity.MaNhom = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.MaNhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.MaNhom.ToString())];
			entity.MaLop = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.MaLop.ToString())];
			entity.SiSo = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.SiSo.ToString())];
			entity.SoTinChi = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.SoTinChi.ToString())];
			entity.SoTuan = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.SoTuan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.SoTuan.ToString())];
			entity.HeSoHocKy = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.HeSoHocKy.ToString())];
			entity.TietQuyDoi = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.TietQuyDoi.ToString())];
			entity.DonGia = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.DonGia.ToString())];
			entity.MaDiaDiem = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.MaDiaDiem.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.MaDiaDiem.ToString())];
			entity.HeSoDiaDiem = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.HeSoDiaDiem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.HeSoDiaDiem.ToString())];
			entity.DonGiaDiaDiem = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.DonGiaDiaDiem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.DonGiaDiaDiem.ToString())];
			entity.TienXeDiaDiem = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.TienXeDiaDiem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.TienXeDiaDiem.ToString())];
			entity.ThanhTienGiangDay = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.ThanhTienGiangDay.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.ThanhTienGiangDay.ToString())];
			entity.GhiChu = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.GhiChu.ToString())];
			entity.DotThanhToan = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.DotThanhToan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.DotThanhToan.ToString())];
			entity.MaDonVi = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.MaDonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.MaDonVi.ToString())];
			entity.MaHocHam = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.MaHocVi.ToString())];
			entity.MaLoaiGiangVien = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.MaLoaiGiangVien.ToString())];
			entity.HeSoQuyDoi = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.HeSoQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.HeSoQuyDoi.ToString())];
			entity.Loai = (reader[KcqKhoiLuongThucTapCuoiKhoaColumn.Loai.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongThucTapCuoiKhoaColumn.Loai.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.Int32?)dataRow["MaGiangVien"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.MaLoaiHocPhan = Convert.IsDBNull(dataRow["MaLoaiHocPhan"]) ? null : (System.Int32?)dataRow["MaLoaiHocPhan"];
			entity.MaNhom = Convert.IsDBNull(dataRow["MaNhom"]) ? null : (System.String)dataRow["MaNhom"];
			entity.MaLop = Convert.IsDBNull(dataRow["MaLop"]) ? null : (System.String)dataRow["MaLop"];
			entity.SiSo = Convert.IsDBNull(dataRow["SiSo"]) ? null : (System.Int32?)dataRow["SiSo"];
			entity.SoTinChi = Convert.IsDBNull(dataRow["SoTinChi"]) ? null : (System.Int32?)dataRow["SoTinChi"];
			entity.SoTuan = Convert.IsDBNull(dataRow["SoTuan"]) ? null : (System.Int32?)dataRow["SoTuan"];
			entity.HeSoHocKy = Convert.IsDBNull(dataRow["HeSoHocKy"]) ? null : (System.Decimal?)dataRow["HeSoHocKy"];
			entity.TietQuyDoi = Convert.IsDBNull(dataRow["TietQuyDoi"]) ? null : (System.Decimal?)dataRow["TietQuyDoi"];
			entity.DonGia = Convert.IsDBNull(dataRow["DonGia"]) ? null : (System.Decimal?)dataRow["DonGia"];
			entity.MaDiaDiem = Convert.IsDBNull(dataRow["MaDiaDiem"]) ? null : (System.Int32?)dataRow["MaDiaDiem"];
			entity.HeSoDiaDiem = Convert.IsDBNull(dataRow["HeSoDiaDiem"]) ? null : (System.Decimal?)dataRow["HeSoDiaDiem"];
			entity.DonGiaDiaDiem = Convert.IsDBNull(dataRow["DonGiaDiaDiem"]) ? null : (System.Decimal?)dataRow["DonGiaDiaDiem"];
			entity.TienXeDiaDiem = Convert.IsDBNull(dataRow["TienXeDiaDiem"]) ? null : (System.Decimal?)dataRow["TienXeDiaDiem"];
			entity.ThanhTienGiangDay = Convert.IsDBNull(dataRow["ThanhTienGiangDay"]) ? null : (System.Decimal?)dataRow["ThanhTienGiangDay"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.DotThanhToan = Convert.IsDBNull(dataRow["DotThanhToan"]) ? null : (System.String)dataRow["DotThanhToan"];
			entity.MaDonVi = Convert.IsDBNull(dataRow["MaDonVi"]) ? null : (System.String)dataRow["MaDonVi"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
			entity.MaLoaiGiangVien = Convert.IsDBNull(dataRow["MaLoaiGiangVien"]) ? null : (System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.HeSoQuyDoi = Convert.IsDBNull(dataRow["HeSoQuyDoi"]) ? null : (System.Decimal?)dataRow["HeSoQuyDoi"];
			entity.Loai = Convert.IsDBNull(dataRow["Loai"]) ? null : (System.String)dataRow["Loai"];
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
		/// <param name="entity">The <see cref="PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region KcqKhoiLuongThucTapCuoiKhoaChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa</c>
	///</summary>
	public enum KcqKhoiLuongThucTapCuoiKhoaChildEntityTypes
	{
	}
	
	#endregion KcqKhoiLuongThucTapCuoiKhoaChildEntityTypes
	
	#region KcqKhoiLuongThucTapCuoiKhoaFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KcqKhoiLuongThucTapCuoiKhoaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongThucTapCuoiKhoa"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKhoiLuongThucTapCuoiKhoaFilterBuilder : SqlFilterBuilder<KcqKhoiLuongThucTapCuoiKhoaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongThucTapCuoiKhoaFilterBuilder class.
		/// </summary>
		public KcqKhoiLuongThucTapCuoiKhoaFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongThucTapCuoiKhoaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqKhoiLuongThucTapCuoiKhoaFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongThucTapCuoiKhoaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqKhoiLuongThucTapCuoiKhoaFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqKhoiLuongThucTapCuoiKhoaFilterBuilder
	
	#region KcqKhoiLuongThucTapCuoiKhoaParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KcqKhoiLuongThucTapCuoiKhoaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongThucTapCuoiKhoa"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKhoiLuongThucTapCuoiKhoaParameterBuilder : ParameterizedSqlFilterBuilder<KcqKhoiLuongThucTapCuoiKhoaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongThucTapCuoiKhoaParameterBuilder class.
		/// </summary>
		public KcqKhoiLuongThucTapCuoiKhoaParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongThucTapCuoiKhoaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqKhoiLuongThucTapCuoiKhoaParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongThucTapCuoiKhoaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqKhoiLuongThucTapCuoiKhoaParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqKhoiLuongThucTapCuoiKhoaParameterBuilder
	
	#region KcqKhoiLuongThucTapCuoiKhoaSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KcqKhoiLuongThucTapCuoiKhoaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongThucTapCuoiKhoa"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KcqKhoiLuongThucTapCuoiKhoaSortBuilder : SqlSortBuilder<KcqKhoiLuongThucTapCuoiKhoaColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongThucTapCuoiKhoaSqlSortBuilder class.
		/// </summary>
		public KcqKhoiLuongThucTapCuoiKhoaSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KcqKhoiLuongThucTapCuoiKhoaSortBuilder
	
} // end namespace
