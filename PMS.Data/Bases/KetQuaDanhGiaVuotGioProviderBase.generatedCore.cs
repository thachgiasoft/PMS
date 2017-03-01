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
	/// This class is the base class for any <see cref="KetQuaDanhGiaVuotGioProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KetQuaDanhGiaVuotGioProviderBaseCore : EntityProviderBase<PMS.Entities.KetQuaDanhGiaVuotGio, PMS.Entities.KetQuaDanhGiaVuotGioKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KetQuaDanhGiaVuotGioKey key)
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
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KetQuaDanhGiaVuotGio_NoiDungDanhGia key.
		///		FK_KetQuaDanhGiaVuotGio_NoiDungDanhGia Description: 
		/// </summary>
		/// <param name="_maNoiDungDanhGia"></param>
		/// <returns>Returns a typed collection of PMS.Entities.KetQuaDanhGiaVuotGio objects.</returns>
		public TList<KetQuaDanhGiaVuotGio> GetByMaNoiDungDanhGia(System.String _maNoiDungDanhGia)
		{
			int count = -1;
			return GetByMaNoiDungDanhGia(_maNoiDungDanhGia, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KetQuaDanhGiaVuotGio_NoiDungDanhGia key.
		///		FK_KetQuaDanhGiaVuotGio_NoiDungDanhGia Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNoiDungDanhGia"></param>
		/// <returns>Returns a typed collection of PMS.Entities.KetQuaDanhGiaVuotGio objects.</returns>
		/// <remarks></remarks>
		public TList<KetQuaDanhGiaVuotGio> GetByMaNoiDungDanhGia(TransactionManager transactionManager, System.String _maNoiDungDanhGia)
		{
			int count = -1;
			return GetByMaNoiDungDanhGia(transactionManager, _maNoiDungDanhGia, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_KetQuaDanhGiaVuotGio_NoiDungDanhGia key.
		///		FK_KetQuaDanhGiaVuotGio_NoiDungDanhGia Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNoiDungDanhGia"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KetQuaDanhGiaVuotGio objects.</returns>
		public TList<KetQuaDanhGiaVuotGio> GetByMaNoiDungDanhGia(TransactionManager transactionManager, System.String _maNoiDungDanhGia, int start, int pageLength)
		{
			int count = -1;
			return GetByMaNoiDungDanhGia(transactionManager, _maNoiDungDanhGia, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KetQuaDanhGiaVuotGio_NoiDungDanhGia key.
		///		fkKetQuaDanhGiaVuotGioNoiDungDanhGia Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maNoiDungDanhGia"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KetQuaDanhGiaVuotGio objects.</returns>
		public TList<KetQuaDanhGiaVuotGio> GetByMaNoiDungDanhGia(System.String _maNoiDungDanhGia, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaNoiDungDanhGia(null, _maNoiDungDanhGia, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KetQuaDanhGiaVuotGio_NoiDungDanhGia key.
		///		fkKetQuaDanhGiaVuotGioNoiDungDanhGia Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maNoiDungDanhGia"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KetQuaDanhGiaVuotGio objects.</returns>
		public TList<KetQuaDanhGiaVuotGio> GetByMaNoiDungDanhGia(System.String _maNoiDungDanhGia, int start, int pageLength,out int count)
		{
			return GetByMaNoiDungDanhGia(null, _maNoiDungDanhGia, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KetQuaDanhGiaVuotGio_NoiDungDanhGia key.
		///		FK_KetQuaDanhGiaVuotGio_NoiDungDanhGia Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNoiDungDanhGia"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.KetQuaDanhGiaVuotGio objects.</returns>
		public abstract TList<KetQuaDanhGiaVuotGio> GetByMaNoiDungDanhGia(TransactionManager transactionManager, System.String _maNoiDungDanhGia, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.KetQuaDanhGiaVuotGio Get(TransactionManager transactionManager, PMS.Entities.KetQuaDanhGiaVuotGioKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KetQuaDanhGiaVuotGio index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaDanhGiaVuotGio"/> class.</returns>
		public PMS.Entities.KetQuaDanhGiaVuotGio GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KetQuaDanhGiaVuotGio index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaDanhGiaVuotGio"/> class.</returns>
		public PMS.Entities.KetQuaDanhGiaVuotGio GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KetQuaDanhGiaVuotGio index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaDanhGiaVuotGio"/> class.</returns>
		public PMS.Entities.KetQuaDanhGiaVuotGio GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KetQuaDanhGiaVuotGio index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaDanhGiaVuotGio"/> class.</returns>
		public PMS.Entities.KetQuaDanhGiaVuotGio GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KetQuaDanhGiaVuotGio index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaDanhGiaVuotGio"/> class.</returns>
		public PMS.Entities.KetQuaDanhGiaVuotGio GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KetQuaDanhGiaVuotGio index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaDanhGiaVuotGio"/> class.</returns>
		public abstract PMS.Entities.KetQuaDanhGiaVuotGio GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_KetQuaDanhGiaVuotGio_ThongKeByNamHocKhoaDonViMaGiangVien 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaDanhGiaVuotGio_ThongKeByNamHocKhoaDonViMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeByNamHocKhoaDonViMaGiangVien(System.String namHoc, System.String khoaDonVi, System.String maGiangVien)
		{
			return ThongKeByNamHocKhoaDonViMaGiangVien(null, 0, int.MaxValue , namHoc, khoaDonVi, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaDanhGiaVuotGio_ThongKeByNamHocKhoaDonViMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeByNamHocKhoaDonViMaGiangVien(int start, int pageLength, System.String namHoc, System.String khoaDonVi, System.String maGiangVien)
		{
			return ThongKeByNamHocKhoaDonViMaGiangVien(null, start, pageLength , namHoc, khoaDonVi, maGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaDanhGiaVuotGio_ThongKeByNamHocKhoaDonViMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeByNamHocKhoaDonViMaGiangVien(TransactionManager transactionManager, System.String namHoc, System.String khoaDonVi, System.String maGiangVien)
		{
			return ThongKeByNamHocKhoaDonViMaGiangVien(transactionManager, 0, int.MaxValue , namHoc, khoaDonVi, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaDanhGiaVuotGio_ThongKeByNamHocKhoaDonViMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeByNamHocKhoaDonViMaGiangVien(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String khoaDonVi, System.String maGiangVien);
		
		#endregion
		
		#region cust_KetQuaDanhGiaVuotGio_GetByNamHocMaDonVi 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaDanhGiaVuotGio_GetByNamHocMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocMaDonVi(System.String namHoc, System.String maDonVi)
		{
			return GetByNamHocMaDonVi(null, 0, int.MaxValue , namHoc, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaDanhGiaVuotGio_GetByNamHocMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocMaDonVi(int start, int pageLength, System.String namHoc, System.String maDonVi)
		{
			return GetByNamHocMaDonVi(null, start, pageLength , namHoc, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaDanhGiaVuotGio_GetByNamHocMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocMaDonVi(TransactionManager transactionManager, System.String namHoc, System.String maDonVi)
		{
			return GetByNamHocMaDonVi(transactionManager, 0, int.MaxValue , namHoc, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaDanhGiaVuotGio_GetByNamHocMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocMaDonVi(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String maDonVi);
		
		#endregion
		
		#region cust_KetQuaDanhGiaVuotGio_ThongKeTheoNamHocMaDonVi 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaDanhGiaVuotGio_ThongKeTheoNamHocMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTheoNamHocMaDonVi(System.String namHoc, System.String maDonVi)
		{
			return ThongKeTheoNamHocMaDonVi(null, 0, int.MaxValue , namHoc, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaDanhGiaVuotGio_ThongKeTheoNamHocMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTheoNamHocMaDonVi(int start, int pageLength, System.String namHoc, System.String maDonVi)
		{
			return ThongKeTheoNamHocMaDonVi(null, start, pageLength , namHoc, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaDanhGiaVuotGio_ThongKeTheoNamHocMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTheoNamHocMaDonVi(TransactionManager transactionManager, System.String namHoc, System.String maDonVi)
		{
			return ThongKeTheoNamHocMaDonVi(transactionManager, 0, int.MaxValue , namHoc, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaDanhGiaVuotGio_ThongKeTheoNamHocMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeTheoNamHocMaDonVi(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String maDonVi);
		
		#endregion
		
		#region cust_KetQuaDanhGiaVuotGio_GetDanhGiaThucHienByNamHocMaDonVi 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaDanhGiaVuotGio_GetDanhGiaThucHienByNamHocMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDanhGiaThucHienByNamHocMaDonVi(System.String namHoc, System.String maDonVi)
		{
			return GetDanhGiaThucHienByNamHocMaDonVi(null, 0, int.MaxValue , namHoc, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaDanhGiaVuotGio_GetDanhGiaThucHienByNamHocMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDanhGiaThucHienByNamHocMaDonVi(int start, int pageLength, System.String namHoc, System.String maDonVi)
		{
			return GetDanhGiaThucHienByNamHocMaDonVi(null, start, pageLength , namHoc, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaDanhGiaVuotGio_GetDanhGiaThucHienByNamHocMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDanhGiaThucHienByNamHocMaDonVi(TransactionManager transactionManager, System.String namHoc, System.String maDonVi)
		{
			return GetDanhGiaThucHienByNamHocMaDonVi(transactionManager, 0, int.MaxValue , namHoc, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaDanhGiaVuotGio_GetDanhGiaThucHienByNamHocMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetDanhGiaThucHienByNamHocMaDonVi(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String maDonVi);
		
		#endregion
		
		#region cust_KetQuaDanhGiaVuotGio_ThongKeByNamHocKhoaDonVi 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaDanhGiaVuotGio_ThongKeByNamHocKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeByNamHocKhoaDonVi(System.String namHoc, System.String khoaDonVi)
		{
			return ThongKeByNamHocKhoaDonVi(null, 0, int.MaxValue , namHoc, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaDanhGiaVuotGio_ThongKeByNamHocKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeByNamHocKhoaDonVi(int start, int pageLength, System.String namHoc, System.String khoaDonVi)
		{
			return ThongKeByNamHocKhoaDonVi(null, start, pageLength , namHoc, khoaDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaDanhGiaVuotGio_ThongKeByNamHocKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeByNamHocKhoaDonVi(TransactionManager transactionManager, System.String namHoc, System.String khoaDonVi)
		{
			return ThongKeByNamHocKhoaDonVi(transactionManager, 0, int.MaxValue , namHoc, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaDanhGiaVuotGio_ThongKeByNamHocKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeByNamHocKhoaDonVi(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String khoaDonVi);
		
		#endregion
		
		#region cust_KetQuaDanhGiaVuotGio_DongBoTheoNamHocKhoaDonVi 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaDanhGiaVuotGio_DongBoTheoNamHocKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBoTheoNamHocKhoaDonVi(System.String namHoc, System.String maDonVi, ref System.Int32 reVal)
		{
			 DongBoTheoNamHocKhoaDonVi(null, 0, int.MaxValue , namHoc, maDonVi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaDanhGiaVuotGio_DongBoTheoNamHocKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBoTheoNamHocKhoaDonVi(int start, int pageLength, System.String namHoc, System.String maDonVi, ref System.Int32 reVal)
		{
			 DongBoTheoNamHocKhoaDonVi(null, start, pageLength , namHoc, maDonVi, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaDanhGiaVuotGio_DongBoTheoNamHocKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBoTheoNamHocKhoaDonVi(TransactionManager transactionManager, System.String namHoc, System.String maDonVi, ref System.Int32 reVal)
		{
			 DongBoTheoNamHocKhoaDonVi(transactionManager, 0, int.MaxValue , namHoc, maDonVi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaDanhGiaVuotGio_DongBoTheoNamHocKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DongBoTheoNamHocKhoaDonVi(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String maDonVi, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_KetQuaDanhGiaVuotGio_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaDanhGiaVuotGio_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, System.String namHoc, System.String maDonVi, ref System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , xmlData, namHoc, maDonVi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaDanhGiaVuotGio_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, System.String namHoc, System.String maDonVi, ref System.Int32 reVal)
		{
			 Luu(null, start, pageLength , xmlData, namHoc, maDonVi, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaDanhGiaVuotGio_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String maDonVi, ref System.Int32 reVal)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, namHoc, maDonVi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaDanhGiaVuotGio_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String maDonVi, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KetQuaDanhGiaVuotGio&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KetQuaDanhGiaVuotGio&gt;"/></returns>
		public static TList<KetQuaDanhGiaVuotGio> Fill(IDataReader reader, TList<KetQuaDanhGiaVuotGio> rows, int start, int pageLength)
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
				
				PMS.Entities.KetQuaDanhGiaVuotGio c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KetQuaDanhGiaVuotGio")
					.Append("|").Append((System.Int32)reader[((int)KetQuaDanhGiaVuotGioColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KetQuaDanhGiaVuotGio>(
					key.ToString(), // EntityTrackingKey
					"KetQuaDanhGiaVuotGio",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KetQuaDanhGiaVuotGio();
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
					c.Id = (System.Int32)reader[(KetQuaDanhGiaVuotGioColumn.Id.ToString())];
					c.NamHoc = (reader[KetQuaDanhGiaVuotGioColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaDanhGiaVuotGioColumn.NamHoc.ToString())];
					c.MaGiangVien = (reader[KetQuaDanhGiaVuotGioColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KetQuaDanhGiaVuotGioColumn.MaGiangVien.ToString())];
					c.MaNoiDungDanhGia = (reader[KetQuaDanhGiaVuotGioColumn.MaNoiDungDanhGia.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaDanhGiaVuotGioColumn.MaNoiDungDanhGia.ToString())];
					c.ThoiGianLamViecQuyDinh = (reader[KetQuaDanhGiaVuotGioColumn.ThoiGianLamViecQuyDinh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaDanhGiaVuotGioColumn.ThoiGianLamViecQuyDinh.ToString())];
					c.DanhGiaThoiGianThucHien = (reader[KetQuaDanhGiaVuotGioColumn.DanhGiaThoiGianThucHien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaDanhGiaVuotGioColumn.DanhGiaThoiGianThucHien.ToString())];
					c.PhanTramDanhGia = (reader[KetQuaDanhGiaVuotGioColumn.PhanTramDanhGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaDanhGiaVuotGioColumn.PhanTramDanhGia.ToString())];
					c.GhiChu = (reader[KetQuaDanhGiaVuotGioColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaDanhGiaVuotGioColumn.GhiChu.ToString())];
					c.NgayCapNhat = (reader[KetQuaDanhGiaVuotGioColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaDanhGiaVuotGioColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[KetQuaDanhGiaVuotGioColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaDanhGiaVuotGioColumn.NguoiCapNhat.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KetQuaDanhGiaVuotGio"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KetQuaDanhGiaVuotGio"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KetQuaDanhGiaVuotGio entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(KetQuaDanhGiaVuotGioColumn.Id.ToString())];
			entity.NamHoc = (reader[KetQuaDanhGiaVuotGioColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaDanhGiaVuotGioColumn.NamHoc.ToString())];
			entity.MaGiangVien = (reader[KetQuaDanhGiaVuotGioColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KetQuaDanhGiaVuotGioColumn.MaGiangVien.ToString())];
			entity.MaNoiDungDanhGia = (reader[KetQuaDanhGiaVuotGioColumn.MaNoiDungDanhGia.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaDanhGiaVuotGioColumn.MaNoiDungDanhGia.ToString())];
			entity.ThoiGianLamViecQuyDinh = (reader[KetQuaDanhGiaVuotGioColumn.ThoiGianLamViecQuyDinh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaDanhGiaVuotGioColumn.ThoiGianLamViecQuyDinh.ToString())];
			entity.DanhGiaThoiGianThucHien = (reader[KetQuaDanhGiaVuotGioColumn.DanhGiaThoiGianThucHien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaDanhGiaVuotGioColumn.DanhGiaThoiGianThucHien.ToString())];
			entity.PhanTramDanhGia = (reader[KetQuaDanhGiaVuotGioColumn.PhanTramDanhGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaDanhGiaVuotGioColumn.PhanTramDanhGia.ToString())];
			entity.GhiChu = (reader[KetQuaDanhGiaVuotGioColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaDanhGiaVuotGioColumn.GhiChu.ToString())];
			entity.NgayCapNhat = (reader[KetQuaDanhGiaVuotGioColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaDanhGiaVuotGioColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[KetQuaDanhGiaVuotGioColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaDanhGiaVuotGioColumn.NguoiCapNhat.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KetQuaDanhGiaVuotGio"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KetQuaDanhGiaVuotGio"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KetQuaDanhGiaVuotGio entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.Int32?)dataRow["MaGiangVien"];
			entity.MaNoiDungDanhGia = Convert.IsDBNull(dataRow["MaNoiDungDanhGia"]) ? null : (System.String)dataRow["MaNoiDungDanhGia"];
			entity.ThoiGianLamViecQuyDinh = Convert.IsDBNull(dataRow["ThoiGianLamViecQuyDinh"]) ? null : (System.Decimal?)dataRow["ThoiGianLamViecQuyDinh"];
			entity.DanhGiaThoiGianThucHien = Convert.IsDBNull(dataRow["DanhGiaThoiGianThucHien"]) ? null : (System.Decimal?)dataRow["DanhGiaThoiGianThucHien"];
			entity.PhanTramDanhGia = Convert.IsDBNull(dataRow["PhanTramDanhGia"]) ? null : (System.Decimal?)dataRow["PhanTramDanhGia"];
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
		/// <param name="entity">The <see cref="PMS.Entities.KetQuaDanhGiaVuotGio"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KetQuaDanhGiaVuotGio Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KetQuaDanhGiaVuotGio entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaNoiDungDanhGiaSource	
			if (CanDeepLoad(entity, "NoiDungDanhGia|MaNoiDungDanhGiaSource", deepLoadType, innerList) 
				&& entity.MaNoiDungDanhGiaSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaNoiDungDanhGia ?? string.Empty);
				NoiDungDanhGia tmpEntity = EntityManager.LocateEntity<NoiDungDanhGia>(EntityLocator.ConstructKeyFromPkItems(typeof(NoiDungDanhGia), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaNoiDungDanhGiaSource = tmpEntity;
				else
					entity.MaNoiDungDanhGiaSource = DataRepository.NoiDungDanhGiaProvider.GetByMaQuanLy(transactionManager, (entity.MaNoiDungDanhGia ?? string.Empty));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaNoiDungDanhGiaSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaNoiDungDanhGiaSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.NoiDungDanhGiaProvider.DeepLoad(transactionManager, entity.MaNoiDungDanhGiaSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaNoiDungDanhGiaSource
			
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
		/// Deep Save the entire object graph of the PMS.Entities.KetQuaDanhGiaVuotGio object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KetQuaDanhGiaVuotGio instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KetQuaDanhGiaVuotGio Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KetQuaDanhGiaVuotGio entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaNoiDungDanhGiaSource
			if (CanDeepSave(entity, "NoiDungDanhGia|MaNoiDungDanhGiaSource", deepSaveType, innerList) 
				&& entity.MaNoiDungDanhGiaSource != null)
			{
				DataRepository.NoiDungDanhGiaProvider.Save(transactionManager, entity.MaNoiDungDanhGiaSource);
				entity.MaNoiDungDanhGia = entity.MaNoiDungDanhGiaSource.MaQuanLy;
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
	
	#region KetQuaDanhGiaVuotGioChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KetQuaDanhGiaVuotGio</c>
	///</summary>
	public enum KetQuaDanhGiaVuotGioChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>NoiDungDanhGia</c> at MaNoiDungDanhGiaSource
		///</summary>
		[ChildEntityType(typeof(NoiDungDanhGia))]
		NoiDungDanhGia,
	}
	
	#endregion KetQuaDanhGiaVuotGioChildEntityTypes
	
	#region KetQuaDanhGiaVuotGioFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KetQuaDanhGiaVuotGioColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KetQuaDanhGiaVuotGio"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KetQuaDanhGiaVuotGioFilterBuilder : SqlFilterBuilder<KetQuaDanhGiaVuotGioColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KetQuaDanhGiaVuotGioFilterBuilder class.
		/// </summary>
		public KetQuaDanhGiaVuotGioFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KetQuaDanhGiaVuotGioFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KetQuaDanhGiaVuotGioFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KetQuaDanhGiaVuotGioFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KetQuaDanhGiaVuotGioFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KetQuaDanhGiaVuotGioFilterBuilder
	
	#region KetQuaDanhGiaVuotGioParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KetQuaDanhGiaVuotGioColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KetQuaDanhGiaVuotGio"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KetQuaDanhGiaVuotGioParameterBuilder : ParameterizedSqlFilterBuilder<KetQuaDanhGiaVuotGioColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KetQuaDanhGiaVuotGioParameterBuilder class.
		/// </summary>
		public KetQuaDanhGiaVuotGioParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KetQuaDanhGiaVuotGioParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KetQuaDanhGiaVuotGioParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KetQuaDanhGiaVuotGioParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KetQuaDanhGiaVuotGioParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KetQuaDanhGiaVuotGioParameterBuilder
	
	#region KetQuaDanhGiaVuotGioSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KetQuaDanhGiaVuotGioColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KetQuaDanhGiaVuotGio"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KetQuaDanhGiaVuotGioSortBuilder : SqlSortBuilder<KetQuaDanhGiaVuotGioColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KetQuaDanhGiaVuotGioSqlSortBuilder class.
		/// </summary>
		public KetQuaDanhGiaVuotGioSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KetQuaDanhGiaVuotGioSortBuilder
	
} // end namespace
