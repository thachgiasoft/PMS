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
	/// This class is the base class for any <see cref="GiangVienNghienCuuKhProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GiangVienNghienCuuKhProviderBaseCore : EntityProviderBase<PMS.Entities.GiangVienNghienCuuKh, PMS.Entities.GiangVienNghienCuuKhKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.GiangVienNghienCuuKhKey key)
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
		/// 	Gets rows from the datasource based on the FK_GiangVien_NghienCuuKH_DanhMucNghienCuuKhoaHoc key.
		///		FK_GiangVien_NghienCuuKH_DanhMucNghienCuuKhoaHoc Description: 
		/// </summary>
		/// <param name="_maNckh"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienNghienCuuKh objects.</returns>
		public TList<GiangVienNghienCuuKh> GetByMaNckh(System.Int32? _maNckh)
		{
			int count = -1;
			return GetByMaNckh(_maNckh, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_NghienCuuKH_DanhMucNghienCuuKhoaHoc key.
		///		FK_GiangVien_NghienCuuKH_DanhMucNghienCuuKhoaHoc Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNckh"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienNghienCuuKh objects.</returns>
		/// <remarks></remarks>
		public TList<GiangVienNghienCuuKh> GetByMaNckh(TransactionManager transactionManager, System.Int32? _maNckh)
		{
			int count = -1;
			return GetByMaNckh(transactionManager, _maNckh, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_NghienCuuKH_DanhMucNghienCuuKhoaHoc key.
		///		FK_GiangVien_NghienCuuKH_DanhMucNghienCuuKhoaHoc Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNckh"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienNghienCuuKh objects.</returns>
		public TList<GiangVienNghienCuuKh> GetByMaNckh(TransactionManager transactionManager, System.Int32? _maNckh, int start, int pageLength)
		{
			int count = -1;
			return GetByMaNckh(transactionManager, _maNckh, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_NghienCuuKH_DanhMucNghienCuuKhoaHoc key.
		///		fkGiangVienNghienCuuKhDanhMucNghienCuuKhoaHoc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maNckh"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienNghienCuuKh objects.</returns>
		public TList<GiangVienNghienCuuKh> GetByMaNckh(System.Int32? _maNckh, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaNckh(null, _maNckh, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_NghienCuuKH_DanhMucNghienCuuKhoaHoc key.
		///		fkGiangVienNghienCuuKhDanhMucNghienCuuKhoaHoc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maNckh"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienNghienCuuKh objects.</returns>
		public TList<GiangVienNghienCuuKh> GetByMaNckh(System.Int32? _maNckh, int start, int pageLength,out int count)
		{
			return GetByMaNckh(null, _maNckh, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_NghienCuuKH_DanhMucNghienCuuKhoaHoc key.
		///		FK_GiangVien_NghienCuuKH_DanhMucNghienCuuKhoaHoc Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNckh"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienNghienCuuKh objects.</returns>
		public abstract TList<GiangVienNghienCuuKh> GetByMaNckh(TransactionManager transactionManager, System.Int32? _maNckh, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_NghienCuuKH_GiangVien key.
		///		FK_GiangVien_NghienCuuKH_GiangVien Description: 
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienNghienCuuKh objects.</returns>
		public TList<GiangVienNghienCuuKh> GetByMaGiangVien(System.Int32 _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(_maGiangVien, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_NghienCuuKH_GiangVien key.
		///		FK_GiangVien_NghienCuuKH_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienNghienCuuKh objects.</returns>
		/// <remarks></remarks>
		public TList<GiangVienNghienCuuKh> GetByMaGiangVien(TransactionManager transactionManager, System.Int32 _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_NghienCuuKH_GiangVien key.
		///		FK_GiangVien_NghienCuuKH_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienNghienCuuKh objects.</returns>
		public TList<GiangVienNghienCuuKh> GetByMaGiangVien(TransactionManager transactionManager, System.Int32 _maGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_NghienCuuKH_GiangVien key.
		///		fkGiangVienNghienCuuKhGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienNghienCuuKh objects.</returns>
		public TList<GiangVienNghienCuuKh> GetByMaGiangVien(System.Int32 _maGiangVien, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_NghienCuuKH_GiangVien key.
		///		fkGiangVienNghienCuuKhGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienNghienCuuKh objects.</returns>
		public TList<GiangVienNghienCuuKh> GetByMaGiangVien(System.Int32 _maGiangVien, int start, int pageLength,out int count)
		{
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_NghienCuuKH_GiangVien key.
		///		FK_GiangVien_NghienCuuKH_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienNghienCuuKh objects.</returns>
		public abstract TList<GiangVienNghienCuuKh> GetByMaGiangVien(TransactionManager transactionManager, System.Int32 _maGiangVien, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_NghienCuuKH_VaiTro key.
		///		FK_GiangVien_NghienCuuKH_VaiTro Description: 
		/// </summary>
		/// <param name="_maVaiTro"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienNghienCuuKh objects.</returns>
		public TList<GiangVienNghienCuuKh> GetByMaVaiTro(System.Int32? _maVaiTro)
		{
			int count = -1;
			return GetByMaVaiTro(_maVaiTro, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_NghienCuuKH_VaiTro key.
		///		FK_GiangVien_NghienCuuKH_VaiTro Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maVaiTro"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienNghienCuuKh objects.</returns>
		/// <remarks></remarks>
		public TList<GiangVienNghienCuuKh> GetByMaVaiTro(TransactionManager transactionManager, System.Int32? _maVaiTro)
		{
			int count = -1;
			return GetByMaVaiTro(transactionManager, _maVaiTro, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_NghienCuuKH_VaiTro key.
		///		FK_GiangVien_NghienCuuKH_VaiTro Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maVaiTro"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienNghienCuuKh objects.</returns>
		public TList<GiangVienNghienCuuKh> GetByMaVaiTro(TransactionManager transactionManager, System.Int32? _maVaiTro, int start, int pageLength)
		{
			int count = -1;
			return GetByMaVaiTro(transactionManager, _maVaiTro, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_NghienCuuKH_VaiTro key.
		///		fkGiangVienNghienCuuKhVaiTro Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maVaiTro"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienNghienCuuKh objects.</returns>
		public TList<GiangVienNghienCuuKh> GetByMaVaiTro(System.Int32? _maVaiTro, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaVaiTro(null, _maVaiTro, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_NghienCuuKH_VaiTro key.
		///		fkGiangVienNghienCuuKhVaiTro Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maVaiTro"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienNghienCuuKh objects.</returns>
		public TList<GiangVienNghienCuuKh> GetByMaVaiTro(System.Int32? _maVaiTro, int start, int pageLength,out int count)
		{
			return GetByMaVaiTro(null, _maVaiTro, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_NghienCuuKH_VaiTro key.
		///		FK_GiangVien_NghienCuuKH_VaiTro Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maVaiTro"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienNghienCuuKh objects.</returns>
		public abstract TList<GiangVienNghienCuuKh> GetByMaVaiTro(TransactionManager transactionManager, System.Int32? _maVaiTro, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GVNCKH_MDHT key.
		///		FK_GVNCKH_MDHT Description: 
		/// </summary>
		/// <param name="_mucDoHoanThanh"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienNghienCuuKh objects.</returns>
		public TList<GiangVienNghienCuuKh> GetByMucDoHoanThanh(System.Int32? _mucDoHoanThanh)
		{
			int count = -1;
			return GetByMucDoHoanThanh(_mucDoHoanThanh, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GVNCKH_MDHT key.
		///		FK_GVNCKH_MDHT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mucDoHoanThanh"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienNghienCuuKh objects.</returns>
		/// <remarks></remarks>
		public TList<GiangVienNghienCuuKh> GetByMucDoHoanThanh(TransactionManager transactionManager, System.Int32? _mucDoHoanThanh)
		{
			int count = -1;
			return GetByMucDoHoanThanh(transactionManager, _mucDoHoanThanh, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GVNCKH_MDHT key.
		///		FK_GVNCKH_MDHT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mucDoHoanThanh"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienNghienCuuKh objects.</returns>
		public TList<GiangVienNghienCuuKh> GetByMucDoHoanThanh(TransactionManager transactionManager, System.Int32? _mucDoHoanThanh, int start, int pageLength)
		{
			int count = -1;
			return GetByMucDoHoanThanh(transactionManager, _mucDoHoanThanh, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GVNCKH_MDHT key.
		///		fkGvnckhMdht Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mucDoHoanThanh"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienNghienCuuKh objects.</returns>
		public TList<GiangVienNghienCuuKh> GetByMucDoHoanThanh(System.Int32? _mucDoHoanThanh, int start, int pageLength)
		{
			int count =  -1;
			return GetByMucDoHoanThanh(null, _mucDoHoanThanh, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GVNCKH_MDHT key.
		///		fkGvnckhMdht Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mucDoHoanThanh"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienNghienCuuKh objects.</returns>
		public TList<GiangVienNghienCuuKh> GetByMucDoHoanThanh(System.Int32? _mucDoHoanThanh, int start, int pageLength,out int count)
		{
			return GetByMucDoHoanThanh(null, _mucDoHoanThanh, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GVNCKH_MDHT key.
		///		FK_GVNCKH_MDHT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mucDoHoanThanh"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienNghienCuuKh objects.</returns>
		public abstract TList<GiangVienNghienCuuKh> GetByMucDoHoanThanh(TransactionManager transactionManager, System.Int32? _mucDoHoanThanh, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.GiangVienNghienCuuKh Get(TransactionManager transactionManager, PMS.Entities.GiangVienNghienCuuKhKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GiangVien_NghienCuuKH index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienNghienCuuKh"/> class.</returns>
		public PMS.Entities.GiangVienNghienCuuKh GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien_NghienCuuKH index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienNghienCuuKh"/> class.</returns>
		public PMS.Entities.GiangVienNghienCuuKh GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien_NghienCuuKH index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienNghienCuuKh"/> class.</returns>
		public PMS.Entities.GiangVienNghienCuuKh GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien_NghienCuuKH index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienNghienCuuKh"/> class.</returns>
		public PMS.Entities.GiangVienNghienCuuKh GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien_NghienCuuKH index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienNghienCuuKh"/> class.</returns>
		public PMS.Entities.GiangVienNghienCuuKh GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien_NghienCuuKH index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienNghienCuuKh"/> class.</returns>
		public abstract PMS.Entities.GiangVienNghienCuuKh GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_GiangVien_NghienCuuKH_Insert 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_Insert' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="maNckh"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="tenNckh"> A <c>System.String</c> instance.</param>
		/// <param name="soLuongThanhVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maVaiTro"> A <c>System.Int32</c> instance.</param>
		/// <param name="duKien"> A <c>System.Boolean</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Insert(System.String maQuanLy, System.Int32 maNckh, System.String namHoc, System.String tenNckh, System.Int32 soLuongThanhVien, System.Int32 maVaiTro, System.Boolean duKien)
		{
			 Insert(null, 0, int.MaxValue , maQuanLy, maNckh, namHoc, tenNckh, soLuongThanhVien, maVaiTro, duKien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_Insert' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="maNckh"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="tenNckh"> A <c>System.String</c> instance.</param>
		/// <param name="soLuongThanhVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maVaiTro"> A <c>System.Int32</c> instance.</param>
		/// <param name="duKien"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Insert(int start, int pageLength, System.String maQuanLy, System.Int32 maNckh, System.String namHoc, System.String tenNckh, System.Int32 soLuongThanhVien, System.Int32 maVaiTro, System.Boolean duKien)
		{
			 Insert(null, start, pageLength , maQuanLy, maNckh, namHoc, tenNckh, soLuongThanhVien, maVaiTro, duKien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_Insert' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="maNckh"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="tenNckh"> A <c>System.String</c> instance.</param>
		/// <param name="soLuongThanhVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maVaiTro"> A <c>System.Int32</c> instance.</param>
		/// <param name="duKien"> A <c>System.Boolean</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Insert(TransactionManager transactionManager, System.String maQuanLy, System.Int32 maNckh, System.String namHoc, System.String tenNckh, System.Int32 soLuongThanhVien, System.Int32 maVaiTro, System.Boolean duKien)
		{
			 Insert(transactionManager, 0, int.MaxValue , maQuanLy, maNckh, namHoc, tenNckh, soLuongThanhVien, maVaiTro, duKien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_Insert' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="maNckh"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="tenNckh"> A <c>System.String</c> instance.</param>
		/// <param name="soLuongThanhVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maVaiTro"> A <c>System.Int32</c> instance.</param>
		/// <param name="duKien"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Insert(TransactionManager transactionManager, int start, int pageLength , System.String maQuanLy, System.Int32 maNckh, System.String namHoc, System.String tenNckh, System.Int32 soLuongThanhVien, System.Int32 maVaiTro, System.Boolean duKien);
		
		#endregion
		
		#region cust_GiangVien_NghienCuuKH_Update 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_Update' stored procedure. 
		/// </summary>
		/// <param name="id"> A <c>System.Int32</c> instance.</param>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="maNckh"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="tenNckh"> A <c>System.String</c> instance.</param>
		/// <param name="soLuongThanhVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maVaiTro"> A <c>System.Int32</c> instance.</param>
		/// <param name="duKien"> A <c>System.Boolean</c> instance.</param>
			/// <param name="reval"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Update(System.Int32 id, System.String maQuanLy, System.Int32 maNckh, System.String namHoc, System.String tenNckh, System.Int32 soLuongThanhVien, System.Int32 maVaiTro, System.Boolean duKien, ref System.String reval)
		{
			 Update(null, 0, int.MaxValue , id, maQuanLy, maNckh, namHoc, tenNckh, soLuongThanhVien, maVaiTro, duKien, ref reval);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_Update' stored procedure. 
		/// </summary>
		/// <param name="id"> A <c>System.Int32</c> instance.</param>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="maNckh"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="tenNckh"> A <c>System.String</c> instance.</param>
		/// <param name="soLuongThanhVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maVaiTro"> A <c>System.Int32</c> instance.</param>
		/// <param name="duKien"> A <c>System.Boolean</c> instance.</param>
			/// <param name="reval"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Update(int start, int pageLength, System.Int32 id, System.String maQuanLy, System.Int32 maNckh, System.String namHoc, System.String tenNckh, System.Int32 soLuongThanhVien, System.Int32 maVaiTro, System.Boolean duKien, ref System.String reval)
		{
			 Update(null, start, pageLength , id, maQuanLy, maNckh, namHoc, tenNckh, soLuongThanhVien, maVaiTro, duKien, ref reval);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_Update' stored procedure. 
		/// </summary>
		/// <param name="id"> A <c>System.Int32</c> instance.</param>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="maNckh"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="tenNckh"> A <c>System.String</c> instance.</param>
		/// <param name="soLuongThanhVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maVaiTro"> A <c>System.Int32</c> instance.</param>
		/// <param name="duKien"> A <c>System.Boolean</c> instance.</param>
			/// <param name="reval"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Update(TransactionManager transactionManager, System.Int32 id, System.String maQuanLy, System.Int32 maNckh, System.String namHoc, System.String tenNckh, System.Int32 soLuongThanhVien, System.Int32 maVaiTro, System.Boolean duKien, ref System.String reval)
		{
			 Update(transactionManager, 0, int.MaxValue , id, maQuanLy, maNckh, namHoc, tenNckh, soLuongThanhVien, maVaiTro, duKien, ref reval);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_Update' stored procedure. 
		/// </summary>
		/// <param name="id"> A <c>System.Int32</c> instance.</param>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="maNckh"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="tenNckh"> A <c>System.String</c> instance.</param>
		/// <param name="soLuongThanhVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maVaiTro"> A <c>System.Int32</c> instance.</param>
		/// <param name="duKien"> A <c>System.Boolean</c> instance.</param>
			/// <param name="reval"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Update(TransactionManager transactionManager, int start, int pageLength , System.Int32 id, System.String maQuanLy, System.Int32 maNckh, System.String namHoc, System.String tenNckh, System.Int32 soLuongThanhVien, System.Int32 maVaiTro, System.Boolean duKien, ref System.String reval);
		
		#endregion
		
		#region cust_GiangVien_NghienCuuKH_ThongKeDuThieu 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_ThongKeDuThieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeDuThieu(System.String namHoc, System.String khoaDonVi)
		{
			return ThongKeDuThieu(null, 0, int.MaxValue , namHoc, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_ThongKeDuThieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeDuThieu(int start, int pageLength, System.String namHoc, System.String khoaDonVi)
		{
			return ThongKeDuThieu(null, start, pageLength , namHoc, khoaDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_ThongKeDuThieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeDuThieu(TransactionManager transactionManager, System.String namHoc, System.String khoaDonVi)
		{
			return ThongKeDuThieu(transactionManager, 0, int.MaxValue , namHoc, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_ThongKeDuThieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeDuThieu(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String khoaDonVi);
		
		#endregion
		
		#region cust_GiangVien_NghienCuuKH_GetLichSuNghienCuuKhoaHoc 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_GetLichSuNghienCuuKhoaHoc' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetLichSuNghienCuuKhoaHoc(System.Int32 maGiangVien, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetLichSuNghienCuuKhoaHoc(null, 0, int.MaxValue , maGiangVien, tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_GetLichSuNghienCuuKhoaHoc' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetLichSuNghienCuuKhoaHoc(int start, int pageLength, System.Int32 maGiangVien, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetLichSuNghienCuuKhoaHoc(null, start, pageLength , maGiangVien, tuNgay, denNgay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_GetLichSuNghienCuuKhoaHoc' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetLichSuNghienCuuKhoaHoc(TransactionManager transactionManager, System.Int32 maGiangVien, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetLichSuNghienCuuKhoaHoc(transactionManager, 0, int.MaxValue , maGiangVien, tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_GetLichSuNghienCuuKhoaHoc' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetLichSuNghienCuuKhoaHoc(TransactionManager transactionManager, int start, int pageLength , System.Int32 maGiangVien, System.DateTime tuNgay, System.DateTime denNgay);
		
		#endregion
		
		#region cust_GiangVien_NghienCuuKH_LuuTheoHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_LuuTheoHocKy' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuTheoHocKy(System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 LuuTheoHocKy(null, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_LuuTheoHocKy' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuTheoHocKy(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 LuuTheoHocKy(null, start, pageLength , xmlData, namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_LuuTheoHocKy' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuTheoHocKy(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 LuuTheoHocKy(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_LuuTheoHocKy' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LuuTheoHocKy(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_GiangVien_NghienCuuKH_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_GetByNamHocHocKy' stored procedure. 
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
		
		#region cust_GiangVien_NghienCuuKH_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_Luu' stored procedure. 
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
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_Luu' stored procedure. 
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
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_Luu' stored procedure. 
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
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_Luu' stored procedure. 
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
		
		#region cust_GiangVien_NghienCuuKH_LuuNckhVhu 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_LuuNckhVhu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuNckhVhu(System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 LuuNckhVhu(null, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_LuuNckhVhu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuNckhVhu(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 LuuNckhVhu(null, start, pageLength , xmlData, namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_LuuNckhVhu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuNckhVhu(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 LuuNckhVhu(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_LuuNckhVhu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LuuNckhVhu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_GiangVien_NghienCuuKH_LuuWeb 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_LuuWeb' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuWeb(System.String xmlData, System.String namHoc, ref System.Int32 reVal)
		{
			 LuuWeb(null, 0, int.MaxValue , xmlData, namHoc, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_LuuWeb' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuWeb(int start, int pageLength, System.String xmlData, System.String namHoc, ref System.Int32 reVal)
		{
			 LuuWeb(null, start, pageLength , xmlData, namHoc, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_LuuWeb' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuWeb(TransactionManager transactionManager, System.String xmlData, System.String namHoc, ref System.Int32 reVal)
		{
			 LuuWeb(transactionManager, 0, int.MaxValue , xmlData, namHoc, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_LuuWeb' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LuuWeb(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_GiangVien_NghienCuuKH_Import 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Import(System.String xmlData, ref System.Int32 reVal)
		{
			 Import(null, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Import(int start, int pageLength, System.String xmlData, ref System.Int32 reVal)
		{
			 Import(null, start, pageLength , xmlData, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Import(TransactionManager transactionManager, System.String xmlData, ref System.Int32 reVal)
		{
			 Import(transactionManager, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Import(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_GiangVien_NghienCuuKH_LuuTheoKhoa 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_LuuTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuTheoKhoa(System.String xmlData, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 LuuTheoKhoa(null, 0, int.MaxValue , xmlData, namHoc, hocKy, maDonVi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_LuuTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuTheoKhoa(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 LuuTheoKhoa(null, start, pageLength , xmlData, namHoc, hocKy, maDonVi, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_LuuTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuTheoKhoa(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 LuuTheoKhoa(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, maDonVi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_LuuTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LuuTheoKhoa(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_GiangVien_NghienCuuKH_GetBangThanhToan 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_GetBangThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetBangThanhToan(System.String namHoc, System.String khoaDonVi)
		{
			return GetBangThanhToan(null, 0, int.MaxValue , namHoc, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_GetBangThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetBangThanhToan(int start, int pageLength, System.String namHoc, System.String khoaDonVi)
		{
			return GetBangThanhToan(null, start, pageLength , namHoc, khoaDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_GetBangThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetBangThanhToan(TransactionManager transactionManager, System.String namHoc, System.String khoaDonVi)
		{
			return GetBangThanhToan(transactionManager, 0, int.MaxValue , namHoc, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_GetBangThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetBangThanhToan(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String khoaDonVi);
		
		#endregion
		
		#region cust_GiangVien_NghienCuuKH_GetByGiangVienNamHoc 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_GetByGiangVienNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maQuanLyGv"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByGiangVienNamHoc(System.String maQuanLyGv, System.String namHoc)
		{
			return GetByGiangVienNamHoc(null, 0, int.MaxValue , maQuanLyGv, namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_GetByGiangVienNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maQuanLyGv"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByGiangVienNamHoc(int start, int pageLength, System.String maQuanLyGv, System.String namHoc)
		{
			return GetByGiangVienNamHoc(null, start, pageLength , maQuanLyGv, namHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_GetByGiangVienNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maQuanLyGv"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByGiangVienNamHoc(TransactionManager transactionManager, System.String maQuanLyGv, System.String namHoc)
		{
			return GetByGiangVienNamHoc(transactionManager, 0, int.MaxValue , maQuanLyGv, namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_GetByGiangVienNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maQuanLyGv"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByGiangVienNamHoc(TransactionManager transactionManager, int start, int pageLength , System.String maQuanLyGv, System.String namHoc);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GiangVienNghienCuuKh&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GiangVienNghienCuuKh&gt;"/></returns>
		public static TList<GiangVienNghienCuuKh> Fill(IDataReader reader, TList<GiangVienNghienCuuKh> rows, int start, int pageLength)
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
				
				PMS.Entities.GiangVienNghienCuuKh c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GiangVienNghienCuuKh")
					.Append("|").Append((System.Int32)reader[((int)GiangVienNghienCuuKhColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<GiangVienNghienCuuKh>(
					key.ToString(), // EntityTrackingKey
					"GiangVienNghienCuuKh",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.GiangVienNghienCuuKh();
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
					c.MaGiangVien = (System.Int32)reader[(GiangVienNghienCuuKhColumn.MaGiangVien.ToString())];
					c.MaNckh = (reader[GiangVienNghienCuuKhColumn.MaNckh.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienNghienCuuKhColumn.MaNckh.ToString())];
					c.SoTiet = (reader[GiangVienNghienCuuKhColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienNghienCuuKhColumn.SoTiet.ToString())];
					c.NgayHieuLuc = (reader[GiangVienNghienCuuKhColumn.NgayHieuLuc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienNghienCuuKhColumn.NgayHieuLuc.ToString())];
					c.TrangThai = (reader[GiangVienNghienCuuKhColumn.TrangThai.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(GiangVienNghienCuuKhColumn.TrangThai.ToString())];
					c.NgayHetHieuLuc = (reader[GiangVienNghienCuuKhColumn.NgayHetHieuLuc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienNghienCuuKhColumn.NgayHetHieuLuc.ToString())];
					c.NamHoc = (reader[GiangVienNghienCuuKhColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienNghienCuuKhColumn.NamHoc.ToString())];
					c.HocKy = (reader[GiangVienNghienCuuKhColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienNghienCuuKhColumn.HocKy.ToString())];
					c.NgayCapNhat = (reader[GiangVienNghienCuuKhColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienNghienCuuKhColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[GiangVienNghienCuuKhColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienNghienCuuKhColumn.NguoiCapNhat.ToString())];
					c.TenNckh = (reader[GiangVienNghienCuuKhColumn.TenNckh.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienNghienCuuKhColumn.TenNckh.ToString())];
					c.GioGiangChuyenSangNckh = (reader[GiangVienNghienCuuKhColumn.GioGiangChuyenSangNckh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienNghienCuuKhColumn.GioGiangChuyenSangNckh.ToString())];
					c.NgayNhap = (reader[GiangVienNghienCuuKhColumn.NgayNhap.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienNghienCuuKhColumn.NgayNhap.ToString())];
					c.SoLuongThanhVien = (reader[GiangVienNghienCuuKhColumn.SoLuongThanhVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienNghienCuuKhColumn.SoLuongThanhVien.ToString())];
					c.MaVaiTro = (reader[GiangVienNghienCuuKhColumn.MaVaiTro.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienNghienCuuKhColumn.MaVaiTro.ToString())];
					c.DuKien = (reader[GiangVienNghienCuuKhColumn.DuKien.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(GiangVienNghienCuuKhColumn.DuKien.ToString())];
					c.XacNhan = (reader[GiangVienNghienCuuKhColumn.XacNhan.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(GiangVienNghienCuuKhColumn.XacNhan.ToString())];
					c.NgayXacNhan = (reader[GiangVienNghienCuuKhColumn.NgayXacNhan.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienNghienCuuKhColumn.NgayXacNhan.ToString())];
					c.Id = (System.Int32)reader[(GiangVienNghienCuuKhColumn.Id.ToString())];
					c.MucDoHoanThanh = (reader[GiangVienNghienCuuKhColumn.MucDoHoanThanh.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienNghienCuuKhColumn.MucDoHoanThanh.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienNghienCuuKh"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienNghienCuuKh"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.GiangVienNghienCuuKh entity)
		{
			if (!reader.Read()) return;
			
			entity.MaGiangVien = (System.Int32)reader[(GiangVienNghienCuuKhColumn.MaGiangVien.ToString())];
			entity.MaNckh = (reader[GiangVienNghienCuuKhColumn.MaNckh.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienNghienCuuKhColumn.MaNckh.ToString())];
			entity.SoTiet = (reader[GiangVienNghienCuuKhColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienNghienCuuKhColumn.SoTiet.ToString())];
			entity.NgayHieuLuc = (reader[GiangVienNghienCuuKhColumn.NgayHieuLuc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienNghienCuuKhColumn.NgayHieuLuc.ToString())];
			entity.TrangThai = (reader[GiangVienNghienCuuKhColumn.TrangThai.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(GiangVienNghienCuuKhColumn.TrangThai.ToString())];
			entity.NgayHetHieuLuc = (reader[GiangVienNghienCuuKhColumn.NgayHetHieuLuc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienNghienCuuKhColumn.NgayHetHieuLuc.ToString())];
			entity.NamHoc = (reader[GiangVienNghienCuuKhColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienNghienCuuKhColumn.NamHoc.ToString())];
			entity.HocKy = (reader[GiangVienNghienCuuKhColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienNghienCuuKhColumn.HocKy.ToString())];
			entity.NgayCapNhat = (reader[GiangVienNghienCuuKhColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienNghienCuuKhColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[GiangVienNghienCuuKhColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienNghienCuuKhColumn.NguoiCapNhat.ToString())];
			entity.TenNckh = (reader[GiangVienNghienCuuKhColumn.TenNckh.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienNghienCuuKhColumn.TenNckh.ToString())];
			entity.GioGiangChuyenSangNckh = (reader[GiangVienNghienCuuKhColumn.GioGiangChuyenSangNckh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienNghienCuuKhColumn.GioGiangChuyenSangNckh.ToString())];
			entity.NgayNhap = (reader[GiangVienNghienCuuKhColumn.NgayNhap.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienNghienCuuKhColumn.NgayNhap.ToString())];
			entity.SoLuongThanhVien = (reader[GiangVienNghienCuuKhColumn.SoLuongThanhVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienNghienCuuKhColumn.SoLuongThanhVien.ToString())];
			entity.MaVaiTro = (reader[GiangVienNghienCuuKhColumn.MaVaiTro.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienNghienCuuKhColumn.MaVaiTro.ToString())];
			entity.DuKien = (reader[GiangVienNghienCuuKhColumn.DuKien.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(GiangVienNghienCuuKhColumn.DuKien.ToString())];
			entity.XacNhan = (reader[GiangVienNghienCuuKhColumn.XacNhan.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(GiangVienNghienCuuKhColumn.XacNhan.ToString())];
			entity.NgayXacNhan = (reader[GiangVienNghienCuuKhColumn.NgayXacNhan.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienNghienCuuKhColumn.NgayXacNhan.ToString())];
			entity.Id = (System.Int32)reader[(GiangVienNghienCuuKhColumn.Id.ToString())];
			entity.MucDoHoanThanh = (reader[GiangVienNghienCuuKhColumn.MucDoHoanThanh.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienNghienCuuKhColumn.MucDoHoanThanh.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienNghienCuuKh"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienNghienCuuKh"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.GiangVienNghienCuuKh entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (System.Int32)dataRow["MaGiangVien"];
			entity.MaNckh = Convert.IsDBNull(dataRow["MaNCKH"]) ? null : (System.Int32?)dataRow["MaNCKH"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Decimal?)dataRow["SoTiet"];
			entity.NgayHieuLuc = Convert.IsDBNull(dataRow["NgayHieuLuc"]) ? null : (System.String)dataRow["NgayHieuLuc"];
			entity.TrangThai = Convert.IsDBNull(dataRow["TrangThai"]) ? null : (System.Boolean?)dataRow["TrangThai"];
			entity.NgayHetHieuLuc = Convert.IsDBNull(dataRow["NgayHetHieuLuc"]) ? null : (System.String)dataRow["NgayHetHieuLuc"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.TenNckh = Convert.IsDBNull(dataRow["TenNckh"]) ? null : (System.String)dataRow["TenNckh"];
			entity.GioGiangChuyenSangNckh = Convert.IsDBNull(dataRow["GioGiangChuyenSangNckh"]) ? null : (System.Decimal?)dataRow["GioGiangChuyenSangNckh"];
			entity.NgayNhap = Convert.IsDBNull(dataRow["NgayNhap"]) ? null : (System.DateTime?)dataRow["NgayNhap"];
			entity.SoLuongThanhVien = Convert.IsDBNull(dataRow["SoLuongThanhVien"]) ? null : (System.Int32?)dataRow["SoLuongThanhVien"];
			entity.MaVaiTro = Convert.IsDBNull(dataRow["MaVaiTro"]) ? null : (System.Int32?)dataRow["MaVaiTro"];
			entity.DuKien = Convert.IsDBNull(dataRow["DuKien"]) ? null : (System.Boolean?)dataRow["DuKien"];
			entity.XacNhan = Convert.IsDBNull(dataRow["XacNhan"]) ? null : (System.Boolean?)dataRow["XacNhan"];
			entity.NgayXacNhan = Convert.IsDBNull(dataRow["NgayXacNhan"]) ? null : (System.DateTime?)dataRow["NgayXacNhan"];
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MucDoHoanThanh = Convert.IsDBNull(dataRow["MucDoHoanThanh"]) ? null : (System.Int32?)dataRow["MucDoHoanThanh"];
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
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienNghienCuuKh"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienNghienCuuKh Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.GiangVienNghienCuuKh entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaNckhSource	
			if (CanDeepLoad(entity, "DanhMucNghienCuuKhoaHoc|MaNckhSource", deepLoadType, innerList) 
				&& entity.MaNckhSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaNckh ?? (int)0);
				DanhMucNghienCuuKhoaHoc tmpEntity = EntityManager.LocateEntity<DanhMucNghienCuuKhoaHoc>(EntityLocator.ConstructKeyFromPkItems(typeof(DanhMucNghienCuuKhoaHoc), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaNckhSource = tmpEntity;
				else
					entity.MaNckhSource = DataRepository.DanhMucNghienCuuKhoaHocProvider.GetById(transactionManager, (entity.MaNckh ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaNckhSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaNckhSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.DanhMucNghienCuuKhoaHocProvider.DeepLoad(transactionManager, entity.MaNckhSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaNckhSource

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

			#region MaVaiTroSource	
			if (CanDeepLoad(entity, "VaiTro|MaVaiTroSource", deepLoadType, innerList) 
				&& entity.MaVaiTroSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaVaiTro ?? (int)0);
				VaiTro tmpEntity = EntityManager.LocateEntity<VaiTro>(EntityLocator.ConstructKeyFromPkItems(typeof(VaiTro), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaVaiTroSource = tmpEntity;
				else
					entity.MaVaiTroSource = DataRepository.VaiTroProvider.GetById(transactionManager, (entity.MaVaiTro ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaVaiTroSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaVaiTroSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.VaiTroProvider.DeepLoad(transactionManager, entity.MaVaiTroSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaVaiTroSource

			#region MucDoHoanThanhSource	
			if (CanDeepLoad(entity, "MucDoHoanThanhNckh|MucDoHoanThanhSource", deepLoadType, innerList) 
				&& entity.MucDoHoanThanhSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MucDoHoanThanh ?? (int)0);
				MucDoHoanThanhNckh tmpEntity = EntityManager.LocateEntity<MucDoHoanThanhNckh>(EntityLocator.ConstructKeyFromPkItems(typeof(MucDoHoanThanhNckh), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MucDoHoanThanhSource = tmpEntity;
				else
					entity.MucDoHoanThanhSource = DataRepository.MucDoHoanThanhNckhProvider.GetById(transactionManager, (entity.MucDoHoanThanh ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MucDoHoanThanhSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MucDoHoanThanhSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.MucDoHoanThanhNckhProvider.DeepLoad(transactionManager, entity.MucDoHoanThanhSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MucDoHoanThanhSource
			
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
		/// Deep Save the entire object graph of the PMS.Entities.GiangVienNghienCuuKh object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.GiangVienNghienCuuKh instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienNghienCuuKh Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.GiangVienNghienCuuKh entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaNckhSource
			if (CanDeepSave(entity, "DanhMucNghienCuuKhoaHoc|MaNckhSource", deepSaveType, innerList) 
				&& entity.MaNckhSource != null)
			{
				DataRepository.DanhMucNghienCuuKhoaHocProvider.Save(transactionManager, entity.MaNckhSource);
				entity.MaNckh = entity.MaNckhSource.Id;
			}
			#endregion 
			
			#region MaGiangVienSource
			if (CanDeepSave(entity, "GiangVien|MaGiangVienSource", deepSaveType, innerList) 
				&& entity.MaGiangVienSource != null)
			{
				DataRepository.GiangVienProvider.Save(transactionManager, entity.MaGiangVienSource);
				entity.MaGiangVien = entity.MaGiangVienSource.MaGiangVien;
			}
			#endregion 
			
			#region MaVaiTroSource
			if (CanDeepSave(entity, "VaiTro|MaVaiTroSource", deepSaveType, innerList) 
				&& entity.MaVaiTroSource != null)
			{
				DataRepository.VaiTroProvider.Save(transactionManager, entity.MaVaiTroSource);
				entity.MaVaiTro = entity.MaVaiTroSource.Id;
			}
			#endregion 
			
			#region MucDoHoanThanhSource
			if (CanDeepSave(entity, "MucDoHoanThanhNckh|MucDoHoanThanhSource", deepSaveType, innerList) 
				&& entity.MucDoHoanThanhSource != null)
			{
				DataRepository.MucDoHoanThanhNckhProvider.Save(transactionManager, entity.MucDoHoanThanhSource);
				entity.MucDoHoanThanh = entity.MucDoHoanThanhSource.Id;
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
	
	#region GiangVienNghienCuuKhChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.GiangVienNghienCuuKh</c>
	///</summary>
	public enum GiangVienNghienCuuKhChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>DanhMucNghienCuuKhoaHoc</c> at MaNckhSource
		///</summary>
		[ChildEntityType(typeof(DanhMucNghienCuuKhoaHoc))]
		DanhMucNghienCuuKhoaHoc,
		
		///<summary>
		/// Composite Property for <c>GiangVien</c> at MaGiangVienSource
		///</summary>
		[ChildEntityType(typeof(GiangVien))]
		GiangVien,
		
		///<summary>
		/// Composite Property for <c>VaiTro</c> at MaVaiTroSource
		///</summary>
		[ChildEntityType(typeof(VaiTro))]
		VaiTro,
		
		///<summary>
		/// Composite Property for <c>MucDoHoanThanhNckh</c> at MucDoHoanThanhSource
		///</summary>
		[ChildEntityType(typeof(MucDoHoanThanhNckh))]
		MucDoHoanThanhNckh,
	}
	
	#endregion GiangVienNghienCuuKhChildEntityTypes
	
	#region GiangVienNghienCuuKhFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GiangVienNghienCuuKhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienNghienCuuKh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienNghienCuuKhFilterBuilder : SqlFilterBuilder<GiangVienNghienCuuKhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienNghienCuuKhFilterBuilder class.
		/// </summary>
		public GiangVienNghienCuuKhFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienNghienCuuKhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienNghienCuuKhFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienNghienCuuKhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienNghienCuuKhFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienNghienCuuKhFilterBuilder
	
	#region GiangVienNghienCuuKhParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GiangVienNghienCuuKhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienNghienCuuKh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienNghienCuuKhParameterBuilder : ParameterizedSqlFilterBuilder<GiangVienNghienCuuKhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienNghienCuuKhParameterBuilder class.
		/// </summary>
		public GiangVienNghienCuuKhParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienNghienCuuKhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienNghienCuuKhParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienNghienCuuKhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienNghienCuuKhParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienNghienCuuKhParameterBuilder
	
	#region GiangVienNghienCuuKhSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GiangVienNghienCuuKhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienNghienCuuKh"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GiangVienNghienCuuKhSortBuilder : SqlSortBuilder<GiangVienNghienCuuKhColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienNghienCuuKhSqlSortBuilder class.
		/// </summary>
		public GiangVienNghienCuuKhSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GiangVienNghienCuuKhSortBuilder
	
} // end namespace
