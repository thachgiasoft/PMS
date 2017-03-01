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
	/// This class is the base class for any <see cref="HeSoNhomThucHanhProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class HeSoNhomThucHanhProviderBaseCore : EntityProviderBase<PMS.Entities.HeSoNhomThucHanh, PMS.Entities.HeSoNhomThucHanhKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.HeSoNhomThucHanhKey key)
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
		public override PMS.Entities.HeSoNhomThucHanh Get(TransactionManager transactionManager, PMS.Entities.HeSoNhomThucHanhKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_HeSoNhomThucHanh index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoNhomThucHanh"/> class.</returns>
		public PMS.Entities.HeSoNhomThucHanh GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoNhomThucHanh index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoNhomThucHanh"/> class.</returns>
		public PMS.Entities.HeSoNhomThucHanh GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoNhomThucHanh index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoNhomThucHanh"/> class.</returns>
		public PMS.Entities.HeSoNhomThucHanh GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoNhomThucHanh index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoNhomThucHanh"/> class.</returns>
		public PMS.Entities.HeSoNhomThucHanh GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoNhomThucHanh index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoNhomThucHanh"/> class.</returns>
		public PMS.Entities.HeSoNhomThucHanh GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoNhomThucHanh index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoNhomThucHanh"/> class.</returns>
		public abstract PMS.Entities.HeSoNhomThucHanh GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_HeSoNhomThucHanh_GetBySiSoNhomMonHocBacDaoTao 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNhomThucHanh_GetBySiSoNhomMonHocBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="maNhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetBySiSoNhomMonHocBacDaoTao(System.Int32 siSo, System.String maNhomMonHoc, System.String maBacDaoTao, ref System.Double reVal)
		{
			 GetBySiSoNhomMonHocBacDaoTao(null, 0, int.MaxValue , siSo, maNhomMonHoc, maBacDaoTao, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNhomThucHanh_GetBySiSoNhomMonHocBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="maNhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetBySiSoNhomMonHocBacDaoTao(int start, int pageLength, System.Int32 siSo, System.String maNhomMonHoc, System.String maBacDaoTao, ref System.Double reVal)
		{
			 GetBySiSoNhomMonHocBacDaoTao(null, start, pageLength , siSo, maNhomMonHoc, maBacDaoTao, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoNhomThucHanh_GetBySiSoNhomMonHocBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="maNhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetBySiSoNhomMonHocBacDaoTao(TransactionManager transactionManager, System.Int32 siSo, System.String maNhomMonHoc, System.String maBacDaoTao, ref System.Double reVal)
		{
			 GetBySiSoNhomMonHocBacDaoTao(transactionManager, 0, int.MaxValue , siSo, maNhomMonHoc, maBacDaoTao, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNhomThucHanh_GetBySiSoNhomMonHocBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="maNhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetBySiSoNhomMonHocBacDaoTao(TransactionManager transactionManager, int start, int pageLength , System.Int32 siSo, System.String maNhomMonHoc, System.String maBacDaoTao, ref System.Double reVal);
		
		#endregion
		
		#region cust_HeSoNhomThucHanh_GetByMaMonHocSiSoNamHoc 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNhomThucHanh_GetByMaMonHocSiSoNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaMonHocSiSoNamHoc(System.String maMonHoc, System.Int32 siSo, System.String namHoc, ref System.Double reVal)
		{
			 GetByMaMonHocSiSoNamHoc(null, 0, int.MaxValue , maMonHoc, siSo, namHoc, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNhomThucHanh_GetByMaMonHocSiSoNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaMonHocSiSoNamHoc(int start, int pageLength, System.String maMonHoc, System.Int32 siSo, System.String namHoc, ref System.Double reVal)
		{
			 GetByMaMonHocSiSoNamHoc(null, start, pageLength , maMonHoc, siSo, namHoc, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoNhomThucHanh_GetByMaMonHocSiSoNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaMonHocSiSoNamHoc(TransactionManager transactionManager, System.String maMonHoc, System.Int32 siSo, System.String namHoc, ref System.Double reVal)
		{
			 GetByMaMonHocSiSoNamHoc(transactionManager, 0, int.MaxValue , maMonHoc, siSo, namHoc, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNhomThucHanh_GetByMaMonHocSiSoNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetByMaMonHocSiSoNamHoc(TransactionManager transactionManager, int start, int pageLength , System.String maMonHoc, System.Int32 siSo, System.String namHoc, ref System.Double reVal);
		
		#endregion
		
		#region cust_HeSoNhomThucHanh_SaoChep 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNhomThucHanh_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_HeSoNhomThucHanh_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_HeSoNhomThucHanh_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_HeSoNhomThucHanh_SaoChep' stored procedure. 
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
		
		#region cust_HeSoNhomThucHanh_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNhomThucHanh_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoNhomThucHanh&gt;"/> instance.</returns>
		public TList<HeSoNhomThucHanh> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNhomThucHanh_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoNhomThucHanh&gt;"/> instance.</returns>
		public TList<HeSoNhomThucHanh> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoNhomThucHanh_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoNhomThucHanh&gt;"/> instance.</returns>
		public TList<HeSoNhomThucHanh> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNhomThucHanh_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoNhomThucHanh&gt;"/> instance.</returns>
		public abstract TList<HeSoNhomThucHanh> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_HeSoNhomThucHanh_GetByNhomMonHocSiSo 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNhomThucHanh_GetByNhomMonHocSiSo' stored procedure. 
		/// </summary>
		/// <param name="maNhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNhomMonHocSiSo(System.String maNhomMonHoc, System.Int32 siSo)
		{
			return GetByNhomMonHocSiSo(null, 0, int.MaxValue , maNhomMonHoc, siSo);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNhomThucHanh_GetByNhomMonHocSiSo' stored procedure. 
		/// </summary>
		/// <param name="maNhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNhomMonHocSiSo(int start, int pageLength, System.String maNhomMonHoc, System.Int32 siSo)
		{
			return GetByNhomMonHocSiSo(null, start, pageLength , maNhomMonHoc, siSo);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoNhomThucHanh_GetByNhomMonHocSiSo' stored procedure. 
		/// </summary>
		/// <param name="maNhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNhomMonHocSiSo(TransactionManager transactionManager, System.String maNhomMonHoc, System.Int32 siSo)
		{
			return GetByNhomMonHocSiSo(transactionManager, 0, int.MaxValue , maNhomMonHoc, siSo);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNhomThucHanh_GetByNhomMonHocSiSo' stored procedure. 
		/// </summary>
		/// <param name="maNhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNhomMonHocSiSo(TransactionManager transactionManager, int start, int pageLength , System.String maNhomMonHoc, System.Int32 siSo);
		
		#endregion
		
		#region cust_HeSoNhomThucHanh_GetBySiSo 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNhomThucHanh_GetBySiSo' stored procedure. 
		/// </summary>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetBySiSo(System.Int32 siSo, ref System.Double reVal)
		{
			 GetBySiSo(null, 0, int.MaxValue , siSo, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNhomThucHanh_GetBySiSo' stored procedure. 
		/// </summary>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetBySiSo(int start, int pageLength, System.Int32 siSo, ref System.Double reVal)
		{
			 GetBySiSo(null, start, pageLength , siSo, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoNhomThucHanh_GetBySiSo' stored procedure. 
		/// </summary>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetBySiSo(TransactionManager transactionManager, System.Int32 siSo, ref System.Double reVal)
		{
			 GetBySiSo(transactionManager, 0, int.MaxValue , siSo, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNhomThucHanh_GetBySiSo' stored procedure. 
		/// </summary>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetBySiSo(TransactionManager transactionManager, int start, int pageLength , System.Int32 siSo, ref System.Double reVal);
		
		#endregion
		
		#region cust_HeSoNhomThucHanh_GetBySiSoBacDaoTao 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNhomThucHanh_GetBySiSoBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetBySiSoBacDaoTao(System.Int32 siSo, System.String maBacDaoTao, ref System.Double reVal)
		{
			 GetBySiSoBacDaoTao(null, 0, int.MaxValue , siSo, maBacDaoTao, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNhomThucHanh_GetBySiSoBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetBySiSoBacDaoTao(int start, int pageLength, System.Int32 siSo, System.String maBacDaoTao, ref System.Double reVal)
		{
			 GetBySiSoBacDaoTao(null, start, pageLength , siSo, maBacDaoTao, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoNhomThucHanh_GetBySiSoBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetBySiSoBacDaoTao(TransactionManager transactionManager, System.Int32 siSo, System.String maBacDaoTao, ref System.Double reVal)
		{
			 GetBySiSoBacDaoTao(transactionManager, 0, int.MaxValue , siSo, maBacDaoTao, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNhomThucHanh_GetBySiSoBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetBySiSoBacDaoTao(TransactionManager transactionManager, int start, int pageLength , System.Int32 siSo, System.String maBacDaoTao, ref System.Double reVal);
		
		#endregion
		
		#region cust_HeSoNhomThucHanh_GetBySiSoByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNhomThucHanh_GetBySiSoByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetBySiSoByNamHocHocKy(System.String namHoc, System.String hocKy, System.Int32 siSo, ref System.Double reVal)
		{
			 GetBySiSoByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy, siSo, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNhomThucHanh_GetBySiSoByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetBySiSoByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 siSo, ref System.Double reVal)
		{
			 GetBySiSoByNamHocHocKy(null, start, pageLength , namHoc, hocKy, siSo, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoNhomThucHanh_GetBySiSoByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetBySiSoByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 siSo, ref System.Double reVal)
		{
			 GetBySiSoByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy, siSo, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNhomThucHanh_GetBySiSoByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetBySiSoByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 siSo, ref System.Double reVal);
		
		#endregion
		
		#region cust_HeSoNhomThucHanh_GetBySiSoNhomMonHoc 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNhomThucHanh_GetBySiSoNhomMonHoc' stored procedure. 
		/// </summary>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="maNhomMonHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetBySiSoNhomMonHoc(System.Int32 siSo, System.String maNhomMonHoc, ref System.Double reVal)
		{
			 GetBySiSoNhomMonHoc(null, 0, int.MaxValue , siSo, maNhomMonHoc, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNhomThucHanh_GetBySiSoNhomMonHoc' stored procedure. 
		/// </summary>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="maNhomMonHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetBySiSoNhomMonHoc(int start, int pageLength, System.Int32 siSo, System.String maNhomMonHoc, ref System.Double reVal)
		{
			 GetBySiSoNhomMonHoc(null, start, pageLength , siSo, maNhomMonHoc, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoNhomThucHanh_GetBySiSoNhomMonHoc' stored procedure. 
		/// </summary>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="maNhomMonHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetBySiSoNhomMonHoc(TransactionManager transactionManager, System.Int32 siSo, System.String maNhomMonHoc, ref System.Double reVal)
		{
			 GetBySiSoNhomMonHoc(transactionManager, 0, int.MaxValue , siSo, maNhomMonHoc, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNhomThucHanh_GetBySiSoNhomMonHoc' stored procedure. 
		/// </summary>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="maNhomMonHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetBySiSoNhomMonHoc(TransactionManager transactionManager, int start, int pageLength , System.Int32 siSo, System.String maNhomMonHoc, ref System.Double reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;HeSoNhomThucHanh&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;HeSoNhomThucHanh&gt;"/></returns>
		public static TList<HeSoNhomThucHanh> Fill(IDataReader reader, TList<HeSoNhomThucHanh> rows, int start, int pageLength)
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
				
				PMS.Entities.HeSoNhomThucHanh c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("HeSoNhomThucHanh")
					.Append("|").Append((System.Int32)reader[((int)HeSoNhomThucHanhColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<HeSoNhomThucHanh>(
					key.ToString(), // EntityTrackingKey
					"HeSoNhomThucHanh",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.HeSoNhomThucHanh();
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
					c.Id = (System.Int32)reader[(HeSoNhomThucHanhColumn.Id.ToString())];
					c.TuKhoan = (reader[HeSoNhomThucHanhColumn.TuKhoan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoNhomThucHanhColumn.TuKhoan.ToString())];
					c.DenKhoan = (reader[HeSoNhomThucHanhColumn.DenKhoan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoNhomThucHanhColumn.DenKhoan.ToString())];
					c.HeSo = (reader[HeSoNhomThucHanhColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HeSoNhomThucHanhColumn.HeSo.ToString())];
					c.NgayCapNhat = (reader[HeSoNhomThucHanhColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoNhomThucHanhColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[HeSoNhomThucHanhColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoNhomThucHanhColumn.NguoiCapNhat.ToString())];
					c.MaNhomMonHoc = (reader[HeSoNhomThucHanhColumn.MaNhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoNhomThucHanhColumn.MaNhomMonHoc.ToString())];
					c.GhiChu = (reader[HeSoNhomThucHanhColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoNhomThucHanhColumn.GhiChu.ToString())];
					c.MaBacDaoTao = (reader[HeSoNhomThucHanhColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoNhomThucHanhColumn.MaBacDaoTao.ToString())];
					c.NamHoc = (reader[HeSoNhomThucHanhColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoNhomThucHanhColumn.NamHoc.ToString())];
					c.HocKy = (reader[HeSoNhomThucHanhColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoNhomThucHanhColumn.HocKy.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HeSoNhomThucHanh"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HeSoNhomThucHanh"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.HeSoNhomThucHanh entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(HeSoNhomThucHanhColumn.Id.ToString())];
			entity.TuKhoan = (reader[HeSoNhomThucHanhColumn.TuKhoan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoNhomThucHanhColumn.TuKhoan.ToString())];
			entity.DenKhoan = (reader[HeSoNhomThucHanhColumn.DenKhoan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoNhomThucHanhColumn.DenKhoan.ToString())];
			entity.HeSo = (reader[HeSoNhomThucHanhColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HeSoNhomThucHanhColumn.HeSo.ToString())];
			entity.NgayCapNhat = (reader[HeSoNhomThucHanhColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoNhomThucHanhColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[HeSoNhomThucHanhColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoNhomThucHanhColumn.NguoiCapNhat.ToString())];
			entity.MaNhomMonHoc = (reader[HeSoNhomThucHanhColumn.MaNhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoNhomThucHanhColumn.MaNhomMonHoc.ToString())];
			entity.GhiChu = (reader[HeSoNhomThucHanhColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoNhomThucHanhColumn.GhiChu.ToString())];
			entity.MaBacDaoTao = (reader[HeSoNhomThucHanhColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoNhomThucHanhColumn.MaBacDaoTao.ToString())];
			entity.NamHoc = (reader[HeSoNhomThucHanhColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoNhomThucHanhColumn.NamHoc.ToString())];
			entity.HocKy = (reader[HeSoNhomThucHanhColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoNhomThucHanhColumn.HocKy.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HeSoNhomThucHanh"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HeSoNhomThucHanh"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.HeSoNhomThucHanh entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.TuKhoan = Convert.IsDBNull(dataRow["TuKhoan"]) ? null : (System.Int32?)dataRow["TuKhoan"];
			entity.DenKhoan = Convert.IsDBNull(dataRow["DenKhoan"]) ? null : (System.Int32?)dataRow["DenKhoan"];
			entity.HeSo = Convert.IsDBNull(dataRow["HeSo"]) ? null : (System.Decimal?)dataRow["HeSo"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.MaNhomMonHoc = Convert.IsDBNull(dataRow["MaNhomMonHoc"]) ? null : (System.String)dataRow["MaNhomMonHoc"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.MaBacDaoTao = Convert.IsDBNull(dataRow["MaBacDaoTao"]) ? null : (System.String)dataRow["MaBacDaoTao"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
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
		/// <param name="entity">The <see cref="PMS.Entities.HeSoNhomThucHanh"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.HeSoNhomThucHanh Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.HeSoNhomThucHanh entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.HeSoNhomThucHanh object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.HeSoNhomThucHanh instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.HeSoNhomThucHanh Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.HeSoNhomThucHanh entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region HeSoNhomThucHanhChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.HeSoNhomThucHanh</c>
	///</summary>
	public enum HeSoNhomThucHanhChildEntityTypes
	{
	}
	
	#endregion HeSoNhomThucHanhChildEntityTypes
	
	#region HeSoNhomThucHanhFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;HeSoNhomThucHanhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoNhomThucHanh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoNhomThucHanhFilterBuilder : SqlFilterBuilder<HeSoNhomThucHanhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoNhomThucHanhFilterBuilder class.
		/// </summary>
		public HeSoNhomThucHanhFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HeSoNhomThucHanhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HeSoNhomThucHanhFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HeSoNhomThucHanhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HeSoNhomThucHanhFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HeSoNhomThucHanhFilterBuilder
	
	#region HeSoNhomThucHanhParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;HeSoNhomThucHanhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoNhomThucHanh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoNhomThucHanhParameterBuilder : ParameterizedSqlFilterBuilder<HeSoNhomThucHanhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoNhomThucHanhParameterBuilder class.
		/// </summary>
		public HeSoNhomThucHanhParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HeSoNhomThucHanhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HeSoNhomThucHanhParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HeSoNhomThucHanhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HeSoNhomThucHanhParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HeSoNhomThucHanhParameterBuilder
	
	#region HeSoNhomThucHanhSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;HeSoNhomThucHanhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoNhomThucHanh"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class HeSoNhomThucHanhSortBuilder : SqlSortBuilder<HeSoNhomThucHanhColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoNhomThucHanhSqlSortBuilder class.
		/// </summary>
		public HeSoNhomThucHanhSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion HeSoNhomThucHanhSortBuilder
	
} // end namespace
