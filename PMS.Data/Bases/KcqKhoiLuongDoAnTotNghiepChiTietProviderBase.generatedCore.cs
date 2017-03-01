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
	/// This class is the base class for any <see cref="KcqKhoiLuongDoAnTotNghiepChiTietProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KcqKhoiLuongDoAnTotNghiepChiTietProviderBaseCore : EntityProviderBase<PMS.Entities.KcqKhoiLuongDoAnTotNghiepChiTiet, PMS.Entities.KcqKhoiLuongDoAnTotNghiepChiTietKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KcqKhoiLuongDoAnTotNghiepChiTietKey key)
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
		public override PMS.Entities.KcqKhoiLuongDoAnTotNghiepChiTiet Get(TransactionManager transactionManager, PMS.Entities.KcqKhoiLuongDoAnTotNghiepChiTietKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KcqKhoiLuongDoAnTotNghiepChiTiet index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongDoAnTotNghiepChiTiet"/> class.</returns>
		public PMS.Entities.KcqKhoiLuongDoAnTotNghiepChiTiet GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqKhoiLuongDoAnTotNghiepChiTiet index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongDoAnTotNghiepChiTiet"/> class.</returns>
		public PMS.Entities.KcqKhoiLuongDoAnTotNghiepChiTiet GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqKhoiLuongDoAnTotNghiepChiTiet index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongDoAnTotNghiepChiTiet"/> class.</returns>
		public PMS.Entities.KcqKhoiLuongDoAnTotNghiepChiTiet GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqKhoiLuongDoAnTotNghiepChiTiet index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongDoAnTotNghiepChiTiet"/> class.</returns>
		public PMS.Entities.KcqKhoiLuongDoAnTotNghiepChiTiet GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqKhoiLuongDoAnTotNghiepChiTiet index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongDoAnTotNghiepChiTiet"/> class.</returns>
		public PMS.Entities.KcqKhoiLuongDoAnTotNghiepChiTiet GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqKhoiLuongDoAnTotNghiepChiTiet index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongDoAnTotNghiepChiTiet"/> class.</returns>
		public abstract PMS.Entities.KcqKhoiLuongDoAnTotNghiepChiTiet GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_KcqKhoiLuongDoAnTotNghiepChiTiet_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongDoAnTotNghiepChiTiet_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_KcqKhoiLuongDoAnTotNghiepChiTiet_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_KcqKhoiLuongDoAnTotNghiepChiTiet_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_KcqKhoiLuongDoAnTotNghiepChiTiet_GetByNamHocHocKy' stored procedure. 
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
		
		#region cust_KcqKhoiLuongDoAnTotNghiepChiTiet_QuyDoi 
		
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongDoAnTotNghiepChiTiet_QuyDoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoi(System.String namHoc, System.String hocKy, System.String xmlData)
		{
			 QuyDoi(null, 0, int.MaxValue , namHoc, hocKy, xmlData);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongDoAnTotNghiepChiTiet_QuyDoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoi(int start, int pageLength, System.String namHoc, System.String hocKy, System.String xmlData)
		{
			 QuyDoi(null, start, pageLength , namHoc, hocKy, xmlData);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongDoAnTotNghiepChiTiet_QuyDoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoi(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String xmlData)
		{
			 QuyDoi(transactionManager, 0, int.MaxValue , namHoc, hocKy, xmlData);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongDoAnTotNghiepChiTiet_QuyDoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void QuyDoi(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String xmlData);
		
		#endregion
		
		#region cust_KcqKhoiLuongDoAnTotNghiepChiTiet_DongBoKcq 
		
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongDoAnTotNghiepChiTiet_DongBoKcq' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBoKcq(System.String namHoc, System.String hocKy)
		{
			 DongBoKcq(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongDoAnTotNghiepChiTiet_DongBoKcq' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBoKcq(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			 DongBoKcq(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongDoAnTotNghiepChiTiet_DongBoKcq' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBoKcq(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			 DongBoKcq(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongDoAnTotNghiepChiTiet_DongBoKcq' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DongBoKcq(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_KcqKhoiLuongDoAnTotNghiepChiTiet_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongDoAnTotNghiepChiTiet_Luu' stored procedure. 
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
		///	This method wrap the 'cust_KcqKhoiLuongDoAnTotNghiepChiTiet_Luu' stored procedure. 
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
		///	This method wrap the 'cust_KcqKhoiLuongDoAnTotNghiepChiTiet_Luu' stored procedure. 
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
		///	This method wrap the 'cust_KcqKhoiLuongDoAnTotNghiepChiTiet_Luu' stored procedure. 
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
		
		#region cust_KcqKhoiLuongDoAnTotNghiepChiTiet_GetByNamHocHocKyDot 
		
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongDoAnTotNghiepChiTiet_GetByNamHocHocKyDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqKhoiLuongDoAnTotNghiepChiTiet&gt;"/> instance.</returns>
		public TList<KcqKhoiLuongDoAnTotNghiepChiTiet> GetByNamHocHocKyDot(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKyDot(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongDoAnTotNghiepChiTiet_GetByNamHocHocKyDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqKhoiLuongDoAnTotNghiepChiTiet&gt;"/> instance.</returns>
		public TList<KcqKhoiLuongDoAnTotNghiepChiTiet> GetByNamHocHocKyDot(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKyDot(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongDoAnTotNghiepChiTiet_GetByNamHocHocKyDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqKhoiLuongDoAnTotNghiepChiTiet&gt;"/> instance.</returns>
		public TList<KcqKhoiLuongDoAnTotNghiepChiTiet> GetByNamHocHocKyDot(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKyDot(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongDoAnTotNghiepChiTiet_GetByNamHocHocKyDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqKhoiLuongDoAnTotNghiepChiTiet&gt;"/> instance.</returns>
		public abstract TList<KcqKhoiLuongDoAnTotNghiepChiTiet> GetByNamHocHocKyDot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KcqKhoiLuongDoAnTotNghiepChiTiet&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KcqKhoiLuongDoAnTotNghiepChiTiet&gt;"/></returns>
		public static TList<KcqKhoiLuongDoAnTotNghiepChiTiet> Fill(IDataReader reader, TList<KcqKhoiLuongDoAnTotNghiepChiTiet> rows, int start, int pageLength)
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
				
				PMS.Entities.KcqKhoiLuongDoAnTotNghiepChiTiet c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KcqKhoiLuongDoAnTotNghiepChiTiet")
					.Append("|").Append((System.Int32)reader[((int)KcqKhoiLuongDoAnTotNghiepChiTietColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KcqKhoiLuongDoAnTotNghiepChiTiet>(
					key.ToString(), // EntityTrackingKey
					"KcqKhoiLuongDoAnTotNghiepChiTiet",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KcqKhoiLuongDoAnTotNghiepChiTiet();
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
					c.Id = (System.Int32)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.Id.ToString())];
					c.MaGiangVien = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.MaGiangVien.ToString())];
					c.HoTen = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.HoTen.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.HoTen.ToString())];
					c.MaMonHoc = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.MaMonHoc.ToString())];
					c.TenMonHoc = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.TenMonHoc.ToString())];
					c.SoTinChi = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.SoTinChi.ToString())];
					c.NamHoc = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.NamHoc.ToString())];
					c.HocKy = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.HocKy.ToString())];
					c.MaLopHocPhan = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.MaLopHocPhan.ToString())];
					c.MaLop = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.MaLop.ToString())];
					c.Nhom = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.Nhom.ToString())];
					c.MaLoaiHocPhan = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.MaLoaiHocPhan.ToString())];
					c.LopClc = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.LopClc.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.LopClc.ToString())];
					c.SoLuongHuongDan = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.SoLuongHuongDan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.SoLuongHuongDan.ToString())];
					c.SoTiet = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.SoTiet.ToString())];
					c.DonGia = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.DonGia.ToString())];
					c.SoTien = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.SoTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.SoTien.ToString())];
					c.NgayCapNhat = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.NgayCapNhat.ToString())];
					c.HeSoHocKy = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.HeSoHocKy.ToString())];
					c.MaDot = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.MaDot.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.MaDot.ToString())];
					c.MaDiaDiem = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.MaDiaDiem.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.MaDiaDiem.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqKhoiLuongDoAnTotNghiepChiTiet"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqKhoiLuongDoAnTotNghiepChiTiet"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KcqKhoiLuongDoAnTotNghiepChiTiet entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.Id.ToString())];
			entity.MaGiangVien = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.MaGiangVien.ToString())];
			entity.HoTen = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.HoTen.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.HoTen.ToString())];
			entity.MaMonHoc = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.MaMonHoc.ToString())];
			entity.TenMonHoc = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.TenMonHoc.ToString())];
			entity.SoTinChi = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.SoTinChi.ToString())];
			entity.NamHoc = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.NamHoc.ToString())];
			entity.HocKy = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.HocKy.ToString())];
			entity.MaLopHocPhan = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.MaLopHocPhan.ToString())];
			entity.MaLop = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.MaLop.ToString())];
			entity.Nhom = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.Nhom.ToString())];
			entity.MaLoaiHocPhan = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.MaLoaiHocPhan.ToString())];
			entity.LopClc = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.LopClc.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.LopClc.ToString())];
			entity.SoLuongHuongDan = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.SoLuongHuongDan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.SoLuongHuongDan.ToString())];
			entity.SoTiet = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.SoTiet.ToString())];
			entity.DonGia = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.DonGia.ToString())];
			entity.SoTien = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.SoTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.SoTien.ToString())];
			entity.NgayCapNhat = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.NgayCapNhat.ToString())];
			entity.HeSoHocKy = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.HeSoHocKy.ToString())];
			entity.MaDot = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.MaDot.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.MaDot.ToString())];
			entity.MaDiaDiem = (reader[KcqKhoiLuongDoAnTotNghiepChiTietColumn.MaDiaDiem.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongDoAnTotNghiepChiTietColumn.MaDiaDiem.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqKhoiLuongDoAnTotNghiepChiTiet"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqKhoiLuongDoAnTotNghiepChiTiet"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KcqKhoiLuongDoAnTotNghiepChiTiet entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.Int32?)dataRow["MaGiangVien"];
			entity.HoTen = Convert.IsDBNull(dataRow["HoTen"]) ? null : (System.String)dataRow["HoTen"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = Convert.IsDBNull(dataRow["TenMonHoc"]) ? null : (System.String)dataRow["TenMonHoc"];
			entity.SoTinChi = Convert.IsDBNull(dataRow["SoTinChi"]) ? null : (System.Int32?)dataRow["SoTinChi"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.MaLop = Convert.IsDBNull(dataRow["MaLop"]) ? null : (System.String)dataRow["MaLop"];
			entity.Nhom = Convert.IsDBNull(dataRow["Nhom"]) ? null : (System.String)dataRow["Nhom"];
			entity.MaLoaiHocPhan = Convert.IsDBNull(dataRow["MaLoaiHocPhan"]) ? null : (System.Int32?)dataRow["MaLoaiHocPhan"];
			entity.LopClc = Convert.IsDBNull(dataRow["LopClc"]) ? null : (System.Boolean?)dataRow["LopClc"];
			entity.SoLuongHuongDan = Convert.IsDBNull(dataRow["SoLuongHuongDan"]) ? null : (System.Int32?)dataRow["SoLuongHuongDan"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Decimal?)dataRow["SoTiet"];
			entity.DonGia = Convert.IsDBNull(dataRow["DonGia"]) ? null : (System.Decimal?)dataRow["DonGia"];
			entity.SoTien = Convert.IsDBNull(dataRow["SoTien"]) ? null : (System.Decimal?)dataRow["SoTien"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
			entity.HeSoHocKy = Convert.IsDBNull(dataRow["HeSoHocKy"]) ? null : (System.Decimal?)dataRow["HeSoHocKy"];
			entity.MaDot = Convert.IsDBNull(dataRow["MaDot"]) ? null : (System.String)dataRow["MaDot"];
			entity.MaDiaDiem = Convert.IsDBNull(dataRow["MaDiaDiem"]) ? null : (System.String)dataRow["MaDiaDiem"];
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
		/// <param name="entity">The <see cref="PMS.Entities.KcqKhoiLuongDoAnTotNghiepChiTiet"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KcqKhoiLuongDoAnTotNghiepChiTiet Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KcqKhoiLuongDoAnTotNghiepChiTiet entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.KcqKhoiLuongDoAnTotNghiepChiTiet object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KcqKhoiLuongDoAnTotNghiepChiTiet instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KcqKhoiLuongDoAnTotNghiepChiTiet Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KcqKhoiLuongDoAnTotNghiepChiTiet entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region KcqKhoiLuongDoAnTotNghiepChiTietChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KcqKhoiLuongDoAnTotNghiepChiTiet</c>
	///</summary>
	public enum KcqKhoiLuongDoAnTotNghiepChiTietChildEntityTypes
	{
	}
	
	#endregion KcqKhoiLuongDoAnTotNghiepChiTietChildEntityTypes
	
	#region KcqKhoiLuongDoAnTotNghiepChiTietFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KcqKhoiLuongDoAnTotNghiepChiTietColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongDoAnTotNghiepChiTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKhoiLuongDoAnTotNghiepChiTietFilterBuilder : SqlFilterBuilder<KcqKhoiLuongDoAnTotNghiepChiTietColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongDoAnTotNghiepChiTietFilterBuilder class.
		/// </summary>
		public KcqKhoiLuongDoAnTotNghiepChiTietFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongDoAnTotNghiepChiTietFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqKhoiLuongDoAnTotNghiepChiTietFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongDoAnTotNghiepChiTietFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqKhoiLuongDoAnTotNghiepChiTietFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqKhoiLuongDoAnTotNghiepChiTietFilterBuilder
	
	#region KcqKhoiLuongDoAnTotNghiepChiTietParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KcqKhoiLuongDoAnTotNghiepChiTietColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongDoAnTotNghiepChiTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKhoiLuongDoAnTotNghiepChiTietParameterBuilder : ParameterizedSqlFilterBuilder<KcqKhoiLuongDoAnTotNghiepChiTietColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongDoAnTotNghiepChiTietParameterBuilder class.
		/// </summary>
		public KcqKhoiLuongDoAnTotNghiepChiTietParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongDoAnTotNghiepChiTietParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqKhoiLuongDoAnTotNghiepChiTietParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongDoAnTotNghiepChiTietParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqKhoiLuongDoAnTotNghiepChiTietParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqKhoiLuongDoAnTotNghiepChiTietParameterBuilder
	
	#region KcqKhoiLuongDoAnTotNghiepChiTietSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KcqKhoiLuongDoAnTotNghiepChiTietColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongDoAnTotNghiepChiTiet"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KcqKhoiLuongDoAnTotNghiepChiTietSortBuilder : SqlSortBuilder<KcqKhoiLuongDoAnTotNghiepChiTietColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongDoAnTotNghiepChiTietSqlSortBuilder class.
		/// </summary>
		public KcqKhoiLuongDoAnTotNghiepChiTietSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KcqKhoiLuongDoAnTotNghiepChiTietSortBuilder
	
} // end namespace
