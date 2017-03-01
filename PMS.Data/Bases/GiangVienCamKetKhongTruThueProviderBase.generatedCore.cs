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
	/// This class is the base class for any <see cref="GiangVienCamKetKhongTruThueProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GiangVienCamKetKhongTruThueProviderBaseCore : EntityProviderBase<PMS.Entities.GiangVienCamKetKhongTruThue, PMS.Entities.GiangVienCamKetKhongTruThueKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.GiangVienCamKetKhongTruThueKey key)
		{
			return Delete(transactionManager, key.MaGiangVien, key.NamHoc, key.HocKy);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maGiangVien">. Primary Key.</param>
		/// <param name="_namHoc">. Primary Key.</param>
		/// <param name="_hocKy">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maGiangVien, System.String _namHoc, System.String _hocKy)
		{
			return Delete(null, _maGiangVien, _namHoc, _hocKy);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien">. Primary Key.</param>
		/// <param name="_namHoc">. Primary Key.</param>
		/// <param name="_hocKy">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maGiangVien, System.String _namHoc, System.String _hocKy);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVienCamKetKhongTruThue_GiangVien key.
		///		FK_GiangVienCamKetKhongTruThue_GiangVien Description: 
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienCamKetKhongTruThue objects.</returns>
		public TList<GiangVienCamKetKhongTruThue> GetByMaGiangVien(System.Int32 _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(_maGiangVien, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVienCamKetKhongTruThue_GiangVien key.
		///		FK_GiangVienCamKetKhongTruThue_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienCamKetKhongTruThue objects.</returns>
		/// <remarks></remarks>
		public TList<GiangVienCamKetKhongTruThue> GetByMaGiangVien(TransactionManager transactionManager, System.Int32 _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVienCamKetKhongTruThue_GiangVien key.
		///		FK_GiangVienCamKetKhongTruThue_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienCamKetKhongTruThue objects.</returns>
		public TList<GiangVienCamKetKhongTruThue> GetByMaGiangVien(TransactionManager transactionManager, System.Int32 _maGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVienCamKetKhongTruThue_GiangVien key.
		///		fkGiangVienCamKetKhongTruThueGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienCamKetKhongTruThue objects.</returns>
		public TList<GiangVienCamKetKhongTruThue> GetByMaGiangVien(System.Int32 _maGiangVien, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVienCamKetKhongTruThue_GiangVien key.
		///		fkGiangVienCamKetKhongTruThueGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienCamKetKhongTruThue objects.</returns>
		public TList<GiangVienCamKetKhongTruThue> GetByMaGiangVien(System.Int32 _maGiangVien, int start, int pageLength,out int count)
		{
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVienCamKetKhongTruThue_GiangVien key.
		///		FK_GiangVienCamKetKhongTruThue_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienCamKetKhongTruThue objects.</returns>
		public abstract TList<GiangVienCamKetKhongTruThue> GetByMaGiangVien(TransactionManager transactionManager, System.Int32 _maGiangVien, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.GiangVienCamKetKhongTruThue Get(TransactionManager transactionManager, PMS.Entities.GiangVienCamKetKhongTruThueKey key, int start, int pageLength)
		{
			return GetByMaGiangVienNamHocHocKy(transactionManager, key.MaGiangVien, key.NamHoc, key.HocKy, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GiangVienCamKetKhongTruThue index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienCamKetKhongTruThue"/> class.</returns>
		public PMS.Entities.GiangVienCamKetKhongTruThue GetByMaGiangVienNamHocHocKy(System.Int32 _maGiangVien, System.String _namHoc, System.String _hocKy)
		{
			int count = -1;
			return GetByMaGiangVienNamHocHocKy(null,_maGiangVien, _namHoc, _hocKy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVienCamKetKhongTruThue index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienCamKetKhongTruThue"/> class.</returns>
		public PMS.Entities.GiangVienCamKetKhongTruThue GetByMaGiangVienNamHocHocKy(System.Int32 _maGiangVien, System.String _namHoc, System.String _hocKy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVienNamHocHocKy(null, _maGiangVien, _namHoc, _hocKy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVienCamKetKhongTruThue index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienCamKetKhongTruThue"/> class.</returns>
		public PMS.Entities.GiangVienCamKetKhongTruThue GetByMaGiangVienNamHocHocKy(TransactionManager transactionManager, System.Int32 _maGiangVien, System.String _namHoc, System.String _hocKy)
		{
			int count = -1;
			return GetByMaGiangVienNamHocHocKy(transactionManager, _maGiangVien, _namHoc, _hocKy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVienCamKetKhongTruThue index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienCamKetKhongTruThue"/> class.</returns>
		public PMS.Entities.GiangVienCamKetKhongTruThue GetByMaGiangVienNamHocHocKy(TransactionManager transactionManager, System.Int32 _maGiangVien, System.String _namHoc, System.String _hocKy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVienNamHocHocKy(transactionManager, _maGiangVien, _namHoc, _hocKy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVienCamKetKhongTruThue index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienCamKetKhongTruThue"/> class.</returns>
		public PMS.Entities.GiangVienCamKetKhongTruThue GetByMaGiangVienNamHocHocKy(System.Int32 _maGiangVien, System.String _namHoc, System.String _hocKy, int start, int pageLength, out int count)
		{
			return GetByMaGiangVienNamHocHocKy(null, _maGiangVien, _namHoc, _hocKy, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVienCamKetKhongTruThue index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienCamKetKhongTruThue"/> class.</returns>
		public abstract PMS.Entities.GiangVienCamKetKhongTruThue GetByMaGiangVienNamHocHocKy(TransactionManager transactionManager, System.Int32 _maGiangVien, System.String _namHoc, System.String _hocKy, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_GiangVienCamKetKhongTruThue_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienCamKetKhongTruThue_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_GiangVienCamKetKhongTruThue_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_GiangVienCamKetKhongTruThue_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_GiangVienCamKetKhongTruThue_GetByNamHocHocKy' stored procedure. 
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
		
		#region cust_GiangVienCamKetKhongTruThue_GetByNamHocHocKyNhomQuyen 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienCamKetKhongTruThue_GetByNamHocHocKyNhomQuyen' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="nhomQuyen"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyNhomQuyen(System.String namHoc, System.String hocKy, System.String nhomQuyen)
		{
			return GetByNamHocHocKyNhomQuyen(null, 0, int.MaxValue , namHoc, hocKy, nhomQuyen);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienCamKetKhongTruThue_GetByNamHocHocKyNhomQuyen' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="nhomQuyen"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyNhomQuyen(int start, int pageLength, System.String namHoc, System.String hocKy, System.String nhomQuyen)
		{
			return GetByNamHocHocKyNhomQuyen(null, start, pageLength , namHoc, hocKy, nhomQuyen);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVienCamKetKhongTruThue_GetByNamHocHocKyNhomQuyen' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="nhomQuyen"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyNhomQuyen(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String nhomQuyen)
		{
			return GetByNamHocHocKyNhomQuyen(transactionManager, 0, int.MaxValue , namHoc, hocKy, nhomQuyen);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienCamKetKhongTruThue_GetByNamHocHocKyNhomQuyen' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="nhomQuyen"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKyNhomQuyen(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String nhomQuyen);
		
		#endregion
		
		#region cust_GiangVienCamKetKhongTruThue_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienCamKetKhongTruThue_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="nhomQuyen"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, System.String namHoc, System.String hocKy, System.String nhomQuyen, ref System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , xmlData, namHoc, hocKy, nhomQuyen, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienCamKetKhongTruThue_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="nhomQuyen"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, System.String nhomQuyen, ref System.Int32 reVal)
		{
			 Luu(null, start, pageLength , xmlData, namHoc, hocKy, nhomQuyen, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVienCamKetKhongTruThue_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="nhomQuyen"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, System.String nhomQuyen, ref System.Int32 reVal)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, nhomQuyen, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienCamKetKhongTruThue_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="nhomQuyen"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, System.String nhomQuyen, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GiangVienCamKetKhongTruThue&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GiangVienCamKetKhongTruThue&gt;"/></returns>
		public static TList<GiangVienCamKetKhongTruThue> Fill(IDataReader reader, TList<GiangVienCamKetKhongTruThue> rows, int start, int pageLength)
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
				
				PMS.Entities.GiangVienCamKetKhongTruThue c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GiangVienCamKetKhongTruThue")
					.Append("|").Append((System.Int32)reader[((int)GiangVienCamKetKhongTruThueColumn.MaGiangVien - 1)])
					.Append("|").Append((System.String)reader[((int)GiangVienCamKetKhongTruThueColumn.NamHoc - 1)])
					.Append("|").Append((System.String)reader[((int)GiangVienCamKetKhongTruThueColumn.HocKy - 1)]).ToString();
					c = EntityManager.LocateOrCreate<GiangVienCamKetKhongTruThue>(
					key.ToString(), // EntityTrackingKey
					"GiangVienCamKetKhongTruThue",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.GiangVienCamKetKhongTruThue();
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
					c.MaGiangVien = (System.Int32)reader[(GiangVienCamKetKhongTruThueColumn.MaGiangVien.ToString())];
					c.OriginalMaGiangVien = c.MaGiangVien;
					c.NamHoc = (System.String)reader[(GiangVienCamKetKhongTruThueColumn.NamHoc.ToString())];
					c.OriginalNamHoc = c.NamHoc;
					c.HocKy = (System.String)reader[(GiangVienCamKetKhongTruThueColumn.HocKy.ToString())];
					c.OriginalHocKy = c.HocKy;
					c.GhiChu = (reader[GiangVienCamKetKhongTruThueColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienCamKetKhongTruThueColumn.GhiChu.ToString())];
					c.NgayCapNhat = (reader[GiangVienCamKetKhongTruThueColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienCamKetKhongTruThueColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[GiangVienCamKetKhongTruThueColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienCamKetKhongTruThueColumn.NguoiCapNhat.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienCamKetKhongTruThue"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienCamKetKhongTruThue"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.GiangVienCamKetKhongTruThue entity)
		{
			if (!reader.Read()) return;
			
			entity.MaGiangVien = (System.Int32)reader[(GiangVienCamKetKhongTruThueColumn.MaGiangVien.ToString())];
			entity.OriginalMaGiangVien = (System.Int32)reader["MaGiangVien"];
			entity.NamHoc = (System.String)reader[(GiangVienCamKetKhongTruThueColumn.NamHoc.ToString())];
			entity.OriginalNamHoc = (System.String)reader["NamHoc"];
			entity.HocKy = (System.String)reader[(GiangVienCamKetKhongTruThueColumn.HocKy.ToString())];
			entity.OriginalHocKy = (System.String)reader["HocKy"];
			entity.GhiChu = (reader[GiangVienCamKetKhongTruThueColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienCamKetKhongTruThueColumn.GhiChu.ToString())];
			entity.NgayCapNhat = (reader[GiangVienCamKetKhongTruThueColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienCamKetKhongTruThueColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[GiangVienCamKetKhongTruThueColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienCamKetKhongTruThueColumn.NguoiCapNhat.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienCamKetKhongTruThue"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienCamKetKhongTruThue"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.GiangVienCamKetKhongTruThue entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (System.Int32)dataRow["MaGiangVien"];
			entity.OriginalMaGiangVien = (System.Int32)dataRow["MaGiangVien"];
			entity.NamHoc = (System.String)dataRow["NamHoc"];
			entity.OriginalNamHoc = (System.String)dataRow["NamHoc"];
			entity.HocKy = (System.String)dataRow["HocKy"];
			entity.OriginalHocKy = (System.String)dataRow["HocKy"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
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
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienCamKetKhongTruThue"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienCamKetKhongTruThue Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.GiangVienCamKetKhongTruThue entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.GiangVienCamKetKhongTruThue object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.GiangVienCamKetKhongTruThue instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienCamKetKhongTruThue Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.GiangVienCamKetKhongTruThue entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region GiangVienCamKetKhongTruThueChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.GiangVienCamKetKhongTruThue</c>
	///</summary>
	public enum GiangVienCamKetKhongTruThueChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GiangVien</c> at MaGiangVienSource
		///</summary>
		[ChildEntityType(typeof(GiangVien))]
		GiangVien,
	}
	
	#endregion GiangVienCamKetKhongTruThueChildEntityTypes
	
	#region GiangVienCamKetKhongTruThueFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GiangVienCamKetKhongTruThueColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienCamKetKhongTruThue"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienCamKetKhongTruThueFilterBuilder : SqlFilterBuilder<GiangVienCamKetKhongTruThueColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienCamKetKhongTruThueFilterBuilder class.
		/// </summary>
		public GiangVienCamKetKhongTruThueFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienCamKetKhongTruThueFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienCamKetKhongTruThueFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienCamKetKhongTruThueFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienCamKetKhongTruThueFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienCamKetKhongTruThueFilterBuilder
	
	#region GiangVienCamKetKhongTruThueParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GiangVienCamKetKhongTruThueColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienCamKetKhongTruThue"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienCamKetKhongTruThueParameterBuilder : ParameterizedSqlFilterBuilder<GiangVienCamKetKhongTruThueColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienCamKetKhongTruThueParameterBuilder class.
		/// </summary>
		public GiangVienCamKetKhongTruThueParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienCamKetKhongTruThueParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienCamKetKhongTruThueParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienCamKetKhongTruThueParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienCamKetKhongTruThueParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienCamKetKhongTruThueParameterBuilder
	
	#region GiangVienCamKetKhongTruThueSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GiangVienCamKetKhongTruThueColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienCamKetKhongTruThue"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GiangVienCamKetKhongTruThueSortBuilder : SqlSortBuilder<GiangVienCamKetKhongTruThueColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienCamKetKhongTruThueSqlSortBuilder class.
		/// </summary>
		public GiangVienCamKetKhongTruThueSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GiangVienCamKetKhongTruThueSortBuilder
	
} // end namespace
