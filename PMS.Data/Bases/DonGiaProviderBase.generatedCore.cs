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
	/// This class is the base class for any <see cref="DonGiaProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class DonGiaProviderBaseCore : EntityProviderBase<PMS.Entities.DonGia, PMS.Entities.DonGiaKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.DonGiaKey key)
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
		/// 	Gets rows from the datasource based on the FK_DG_NMH key.
		///		FK_DG_NMH Description: 
		/// </summary>
		/// <param name="_maNhomMon"></param>
		/// <returns>Returns a typed collection of PMS.Entities.DonGia objects.</returns>
		public TList<DonGia> GetByMaNhomMon(System.Int32? _maNhomMon)
		{
			int count = -1;
			return GetByMaNhomMon(_maNhomMon, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DG_NMH key.
		///		FK_DG_NMH Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomMon"></param>
		/// <returns>Returns a typed collection of PMS.Entities.DonGia objects.</returns>
		/// <remarks></remarks>
		public TList<DonGia> GetByMaNhomMon(TransactionManager transactionManager, System.Int32? _maNhomMon)
		{
			int count = -1;
			return GetByMaNhomMon(transactionManager, _maNhomMon, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_DG_NMH key.
		///		FK_DG_NMH Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomMon"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DonGia objects.</returns>
		public TList<DonGia> GetByMaNhomMon(TransactionManager transactionManager, System.Int32? _maNhomMon, int start, int pageLength)
		{
			int count = -1;
			return GetByMaNhomMon(transactionManager, _maNhomMon, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DG_NMH key.
		///		fkDgNmh Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maNhomMon"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DonGia objects.</returns>
		public TList<DonGia> GetByMaNhomMon(System.Int32? _maNhomMon, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaNhomMon(null, _maNhomMon, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DG_NMH key.
		///		fkDgNmh Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maNhomMon"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DonGia objects.</returns>
		public TList<DonGia> GetByMaNhomMon(System.Int32? _maNhomMon, int start, int pageLength,out int count)
		{
			return GetByMaNhomMon(null, _maNhomMon, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DG_NMH key.
		///		FK_DG_NMH Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomMon"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.DonGia objects.</returns>
		public abstract TList<DonGia> GetByMaNhomMon(TransactionManager transactionManager, System.Int32? _maNhomMon, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGia_HocHam key.
		///		FK_DonGia_HocHam Description: 
		/// </summary>
		/// <param name="_maHocHam"></param>
		/// <returns>Returns a typed collection of PMS.Entities.DonGia objects.</returns>
		public TList<DonGia> GetByMaHocHam(System.Int32? _maHocHam)
		{
			int count = -1;
			return GetByMaHocHam(_maHocHam, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGia_HocHam key.
		///		FK_DonGia_HocHam Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocHam"></param>
		/// <returns>Returns a typed collection of PMS.Entities.DonGia objects.</returns>
		/// <remarks></remarks>
		public TList<DonGia> GetByMaHocHam(TransactionManager transactionManager, System.Int32? _maHocHam)
		{
			int count = -1;
			return GetByMaHocHam(transactionManager, _maHocHam, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGia_HocHam key.
		///		FK_DonGia_HocHam Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocHam"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DonGia objects.</returns>
		public TList<DonGia> GetByMaHocHam(TransactionManager transactionManager, System.Int32? _maHocHam, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHocHam(transactionManager, _maHocHam, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGia_HocHam key.
		///		fkDonGiaHocHam Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maHocHam"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DonGia objects.</returns>
		public TList<DonGia> GetByMaHocHam(System.Int32? _maHocHam, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaHocHam(null, _maHocHam, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGia_HocHam key.
		///		fkDonGiaHocHam Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maHocHam"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DonGia objects.</returns>
		public TList<DonGia> GetByMaHocHam(System.Int32? _maHocHam, int start, int pageLength,out int count)
		{
			return GetByMaHocHam(null, _maHocHam, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGia_HocHam key.
		///		FK_DonGia_HocHam Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocHam"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.DonGia objects.</returns>
		public abstract TList<DonGia> GetByMaHocHam(TransactionManager transactionManager, System.Int32? _maHocHam, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGia_HocVi key.
		///		FK_DonGia_HocVi Description: 
		/// </summary>
		/// <param name="_maHocVi"></param>
		/// <returns>Returns a typed collection of PMS.Entities.DonGia objects.</returns>
		public TList<DonGia> GetByMaHocVi(System.Int32? _maHocVi)
		{
			int count = -1;
			return GetByMaHocVi(_maHocVi, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGia_HocVi key.
		///		FK_DonGia_HocVi Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocVi"></param>
		/// <returns>Returns a typed collection of PMS.Entities.DonGia objects.</returns>
		/// <remarks></remarks>
		public TList<DonGia> GetByMaHocVi(TransactionManager transactionManager, System.Int32? _maHocVi)
		{
			int count = -1;
			return GetByMaHocVi(transactionManager, _maHocVi, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGia_HocVi key.
		///		FK_DonGia_HocVi Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocVi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DonGia objects.</returns>
		public TList<DonGia> GetByMaHocVi(TransactionManager transactionManager, System.Int32? _maHocVi, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHocVi(transactionManager, _maHocVi, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGia_HocVi key.
		///		fkDonGiaHocVi Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maHocVi"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DonGia objects.</returns>
		public TList<DonGia> GetByMaHocVi(System.Int32? _maHocVi, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaHocVi(null, _maHocVi, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGia_HocVi key.
		///		fkDonGiaHocVi Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maHocVi"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DonGia objects.</returns>
		public TList<DonGia> GetByMaHocVi(System.Int32? _maHocVi, int start, int pageLength,out int count)
		{
			return GetByMaHocVi(null, _maHocVi, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGia_HocVi key.
		///		FK_DonGia_HocVi Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocVi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.DonGia objects.</returns>
		public abstract TList<DonGia> GetByMaHocVi(TransactionManager transactionManager, System.Int32? _maHocVi, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGia_LoaiGiangVien key.
		///		FK_DonGia_LoaiGiangVien Description: 
		/// </summary>
		/// <param name="_maLoaiGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.DonGia objects.</returns>
		public TList<DonGia> GetByMaLoaiGiangVien(System.Int32? _maLoaiGiangVien)
		{
			int count = -1;
			return GetByMaLoaiGiangVien(_maLoaiGiangVien, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGia_LoaiGiangVien key.
		///		FK_DonGia_LoaiGiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.DonGia objects.</returns>
		/// <remarks></remarks>
		public TList<DonGia> GetByMaLoaiGiangVien(TransactionManager transactionManager, System.Int32? _maLoaiGiangVien)
		{
			int count = -1;
			return GetByMaLoaiGiangVien(transactionManager, _maLoaiGiangVien, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGia_LoaiGiangVien key.
		///		FK_DonGia_LoaiGiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DonGia objects.</returns>
		public TList<DonGia> GetByMaLoaiGiangVien(TransactionManager transactionManager, System.Int32? _maLoaiGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLoaiGiangVien(transactionManager, _maLoaiGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGia_LoaiGiangVien key.
		///		fkDonGiaLoaiGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maLoaiGiangVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DonGia objects.</returns>
		public TList<DonGia> GetByMaLoaiGiangVien(System.Int32? _maLoaiGiangVien, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaLoaiGiangVien(null, _maLoaiGiangVien, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGia_LoaiGiangVien key.
		///		fkDonGiaLoaiGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maLoaiGiangVien"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DonGia objects.</returns>
		public TList<DonGia> GetByMaLoaiGiangVien(System.Int32? _maLoaiGiangVien, int start, int pageLength,out int count)
		{
			return GetByMaLoaiGiangVien(null, _maLoaiGiangVien, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGia_LoaiGiangVien key.
		///		FK_DonGia_LoaiGiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.DonGia objects.</returns>
		public abstract TList<DonGia> GetByMaLoaiGiangVien(TransactionManager transactionManager, System.Int32? _maLoaiGiangVien, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGia_NgonNguGiangDay key.
		///		FK_DonGia_NgonNguGiangDay Description: 
		/// </summary>
		/// <param name="_ngonNguGiangDay"></param>
		/// <returns>Returns a typed collection of PMS.Entities.DonGia objects.</returns>
		public TList<DonGia> GetByNgonNguGiangDay(System.String _ngonNguGiangDay)
		{
			int count = -1;
			return GetByNgonNguGiangDay(_ngonNguGiangDay, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGia_NgonNguGiangDay key.
		///		FK_DonGia_NgonNguGiangDay Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ngonNguGiangDay"></param>
		/// <returns>Returns a typed collection of PMS.Entities.DonGia objects.</returns>
		/// <remarks></remarks>
		public TList<DonGia> GetByNgonNguGiangDay(TransactionManager transactionManager, System.String _ngonNguGiangDay)
		{
			int count = -1;
			return GetByNgonNguGiangDay(transactionManager, _ngonNguGiangDay, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGia_NgonNguGiangDay key.
		///		FK_DonGia_NgonNguGiangDay Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ngonNguGiangDay"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DonGia objects.</returns>
		public TList<DonGia> GetByNgonNguGiangDay(TransactionManager transactionManager, System.String _ngonNguGiangDay, int start, int pageLength)
		{
			int count = -1;
			return GetByNgonNguGiangDay(transactionManager, _ngonNguGiangDay, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGia_NgonNguGiangDay key.
		///		fkDonGiaNgonNguGiangDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_ngonNguGiangDay"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DonGia objects.</returns>
		public TList<DonGia> GetByNgonNguGiangDay(System.String _ngonNguGiangDay, int start, int pageLength)
		{
			int count =  -1;
			return GetByNgonNguGiangDay(null, _ngonNguGiangDay, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGia_NgonNguGiangDay key.
		///		fkDonGiaNgonNguGiangDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_ngonNguGiangDay"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DonGia objects.</returns>
		public TList<DonGia> GetByNgonNguGiangDay(System.String _ngonNguGiangDay, int start, int pageLength,out int count)
		{
			return GetByNgonNguGiangDay(null, _ngonNguGiangDay, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGia_NgonNguGiangDay key.
		///		FK_DonGia_NgonNguGiangDay Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ngonNguGiangDay"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.DonGia objects.</returns>
		public abstract TList<DonGia> GetByNgonNguGiangDay(TransactionManager transactionManager, System.String _ngonNguGiangDay, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.DonGia Get(TransactionManager transactionManager, PMS.Entities.DonGiaKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_DonGia index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGia"/> class.</returns>
		public PMS.Entities.DonGia GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DonGia index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGia"/> class.</returns>
		public PMS.Entities.DonGia GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DonGia index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGia"/> class.</returns>
		public PMS.Entities.DonGia GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DonGia index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGia"/> class.</returns>
		public PMS.Entities.DonGia GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DonGia index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGia"/> class.</returns>
		public PMS.Entities.DonGia GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DonGia index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGia"/> class.</returns>
		public abstract PMS.Entities.DonGia GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_DonGia_GetByHinhThucDaoTao 
		
		/// <summary>
		///	This method wrap the 'cust_DonGia_GetByHinhThucDaoTao' stored procedure. 
		/// </summary>
		/// <param name="maHinhThucDaoTao"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;DonGia&gt;"/> instance.</returns>
		public TList<DonGia> GetByHinhThucDaoTao(System.Int32 maHinhThucDaoTao)
		{
			return GetByHinhThucDaoTao(null, 0, int.MaxValue , maHinhThucDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DonGia_GetByHinhThucDaoTao' stored procedure. 
		/// </summary>
		/// <param name="maHinhThucDaoTao"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;DonGia&gt;"/> instance.</returns>
		public TList<DonGia> GetByHinhThucDaoTao(int start, int pageLength, System.Int32 maHinhThucDaoTao)
		{
			return GetByHinhThucDaoTao(null, start, pageLength , maHinhThucDaoTao);
		}
				
		/// <summary>
		///	This method wrap the 'cust_DonGia_GetByHinhThucDaoTao' stored procedure. 
		/// </summary>
		/// <param name="maHinhThucDaoTao"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;DonGia&gt;"/> instance.</returns>
		public TList<DonGia> GetByHinhThucDaoTao(TransactionManager transactionManager, System.Int32 maHinhThucDaoTao)
		{
			return GetByHinhThucDaoTao(transactionManager, 0, int.MaxValue , maHinhThucDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DonGia_GetByHinhThucDaoTao' stored procedure. 
		/// </summary>
		/// <param name="maHinhThucDaoTao"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;DonGia&gt;"/> instance.</returns>
		public abstract TList<DonGia> GetByHinhThucDaoTao(TransactionManager transactionManager, int start, int pageLength , System.Int32 maHinhThucDaoTao);
		
		#endregion
		
		#region cust_DonGia_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_DonGia_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;DonGia&gt;"/> instance.</returns>
		public TList<DonGia> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DonGia_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;DonGia&gt;"/> instance.</returns>
		public TList<DonGia> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_DonGia_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;DonGia&gt;"/> instance.</returns>
		public TList<DonGia> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DonGia_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;DonGia&gt;"/> instance.</returns>
		public abstract TList<DonGia> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_DonGia_GetByMaQuanLyNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_DonGia_GetByMaQuanLyNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Double</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaQuanLyNamHocHocKy(System.String maQuanLy, System.String namHoc, System.String hocKy, ref System.Double ketQua)
		{
			 GetByMaQuanLyNamHocHocKy(null, 0, int.MaxValue , maQuanLy, namHoc, hocKy, ref ketQua);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DonGia_GetByMaQuanLyNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaQuanLyNamHocHocKy(int start, int pageLength, System.String maQuanLy, System.String namHoc, System.String hocKy, ref System.Double ketQua)
		{
			 GetByMaQuanLyNamHocHocKy(null, start, pageLength , maQuanLy, namHoc, hocKy, ref ketQua);
		}
				
		/// <summary>
		///	This method wrap the 'cust_DonGia_GetByMaQuanLyNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Double</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaQuanLyNamHocHocKy(TransactionManager transactionManager, System.String maQuanLy, System.String namHoc, System.String hocKy, ref System.Double ketQua)
		{
			 GetByMaQuanLyNamHocHocKy(transactionManager, 0, int.MaxValue , maQuanLy, namHoc, hocKy, ref ketQua);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DonGia_GetByMaQuanLyNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetByMaQuanLyNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String maQuanLy, System.String namHoc, System.String hocKy, ref System.Double ketQua);
		
		#endregion
		
		#region cust_DonGia_GetByMaLoaiGiangVienMaHocHamMaHocViLopClc 
		
		/// <summary>
		///	This method wrap the 'cust_DonGia_GetByMaLoaiGiangVienMaHocHamMaHocViLopClc' stored procedure. 
		/// </summary>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <param name="lopClc"> A <c>System.Boolean</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaLoaiGiangVienMaHocHamMaHocViLopClc(System.Int32 maLoaiGiangVien, System.Int32 maHocHam, System.Int32 maHocVi, System.Boolean lopClc, ref System.Int32 ketQua)
		{
			 GetByMaLoaiGiangVienMaHocHamMaHocViLopClc(null, 0, int.MaxValue , maLoaiGiangVien, maHocHam, maHocVi, lopClc, ref ketQua);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DonGia_GetByMaLoaiGiangVienMaHocHamMaHocViLopClc' stored procedure. 
		/// </summary>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <param name="lopClc"> A <c>System.Boolean</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaLoaiGiangVienMaHocHamMaHocViLopClc(int start, int pageLength, System.Int32 maLoaiGiangVien, System.Int32 maHocHam, System.Int32 maHocVi, System.Boolean lopClc, ref System.Int32 ketQua)
		{
			 GetByMaLoaiGiangVienMaHocHamMaHocViLopClc(null, start, pageLength , maLoaiGiangVien, maHocHam, maHocVi, lopClc, ref ketQua);
		}
				
		/// <summary>
		///	This method wrap the 'cust_DonGia_GetByMaLoaiGiangVienMaHocHamMaHocViLopClc' stored procedure. 
		/// </summary>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <param name="lopClc"> A <c>System.Boolean</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaLoaiGiangVienMaHocHamMaHocViLopClc(TransactionManager transactionManager, System.Int32 maLoaiGiangVien, System.Int32 maHocHam, System.Int32 maHocVi, System.Boolean lopClc, ref System.Int32 ketQua)
		{
			 GetByMaLoaiGiangVienMaHocHamMaHocViLopClc(transactionManager, 0, int.MaxValue , maLoaiGiangVien, maHocHam, maHocVi, lopClc, ref ketQua);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DonGia_GetByMaLoaiGiangVienMaHocHamMaHocViLopClc' stored procedure. 
		/// </summary>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <param name="lopClc"> A <c>System.Boolean</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetByMaLoaiGiangVienMaHocHamMaHocViLopClc(TransactionManager transactionManager, int start, int pageLength , System.Int32 maLoaiGiangVien, System.Int32 maHocHam, System.Int32 maHocVi, System.Boolean lopClc, ref System.Int32 ketQua);
		
		#endregion
		
		#region cust_DonGia_SaoChep 
		
		/// <summary>
		///	This method wrap the 'cust_DonGia_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_DonGia_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_DonGia_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_DonGia_SaoChep' stored procedure. 
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
		
		#region cust_DonGia_GetByMaQuanLyNamHocHocKyLopClc 
		
		/// <summary>
		///	This method wrap the 'cust_DonGia_GetByMaQuanLyNamHocHocKyLopClc' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lopClc"> A <c>System.Boolean</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Double</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaQuanLyNamHocHocKyLopClc(System.String maQuanLy, System.String namHoc, System.String hocKy, System.Boolean lopClc, ref System.Double ketQua)
		{
			 GetByMaQuanLyNamHocHocKyLopClc(null, 0, int.MaxValue , maQuanLy, namHoc, hocKy, lopClc, ref ketQua);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DonGia_GetByMaQuanLyNamHocHocKyLopClc' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lopClc"> A <c>System.Boolean</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaQuanLyNamHocHocKyLopClc(int start, int pageLength, System.String maQuanLy, System.String namHoc, System.String hocKy, System.Boolean lopClc, ref System.Double ketQua)
		{
			 GetByMaQuanLyNamHocHocKyLopClc(null, start, pageLength , maQuanLy, namHoc, hocKy, lopClc, ref ketQua);
		}
				
		/// <summary>
		///	This method wrap the 'cust_DonGia_GetByMaQuanLyNamHocHocKyLopClc' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lopClc"> A <c>System.Boolean</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Double</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaQuanLyNamHocHocKyLopClc(TransactionManager transactionManager, System.String maQuanLy, System.String namHoc, System.String hocKy, System.Boolean lopClc, ref System.Double ketQua)
		{
			 GetByMaQuanLyNamHocHocKyLopClc(transactionManager, 0, int.MaxValue , maQuanLy, namHoc, hocKy, lopClc, ref ketQua);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DonGia_GetByMaQuanLyNamHocHocKyLopClc' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lopClc"> A <c>System.Boolean</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetByMaQuanLyNamHocHocKyLopClc(TransactionManager transactionManager, int start, int pageLength , System.String maQuanLy, System.String namHoc, System.String hocKy, System.Boolean lopClc, ref System.Double ketQua);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;DonGia&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;DonGia&gt;"/></returns>
		public static TList<DonGia> Fill(IDataReader reader, TList<DonGia> rows, int start, int pageLength)
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
				
				PMS.Entities.DonGia c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("DonGia")
					.Append("|").Append((System.Int32)reader[((int)DonGiaColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<DonGia>(
					key.ToString(), // EntityTrackingKey
					"DonGia",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.DonGia();
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
					c.Id = (System.Int32)reader[(DonGiaColumn.Id.ToString())];
					c.MaQuanLy = (reader[DonGiaColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaColumn.MaQuanLy.ToString())];
					c.MaLoaiGiangVien = (reader[DonGiaColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DonGiaColumn.MaLoaiGiangVien.ToString())];
					c.MaHocHam = (reader[DonGiaColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DonGiaColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[DonGiaColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DonGiaColumn.MaHocVi.ToString())];
					c.DonGia = (reader[DonGiaColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaColumn.DonGia.ToString())];
					c.NgayCapNhat = (reader[DonGiaColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(DonGiaColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[DonGiaColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaColumn.NguoiCapNhat.ToString())];
					c.DonGiaClc = (reader[DonGiaColumn.DonGiaClc.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaColumn.DonGiaClc.ToString())];
					c.HeSoQuyDoiChatLuong = (reader[DonGiaColumn.HeSoQuyDoiChatLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaColumn.HeSoQuyDoiChatLuong.ToString())];
					c.DonGiaTrongChuan = (reader[DonGiaColumn.DonGiaTrongChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaColumn.DonGiaTrongChuan.ToString())];
					c.DonGiaNgoaiChuan = (reader[DonGiaColumn.DonGiaNgoaiChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaColumn.DonGiaNgoaiChuan.ToString())];
					c.MaHinhThucDaoTao = (reader[DonGiaColumn.MaHinhThucDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaColumn.MaHinhThucDaoTao.ToString())];
					c.BacDaoTao = (reader[DonGiaColumn.BacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaColumn.BacDaoTao.ToString())];
					c.NgonNguGiangDay = (reader[DonGiaColumn.NgonNguGiangDay.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaColumn.NgonNguGiangDay.ToString())];
					c.NamHoc = (reader[DonGiaColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaColumn.NamHoc.ToString())];
					c.HocKy = (reader[DonGiaColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaColumn.HocKy.ToString())];
					c.MaNhomMon = (reader[DonGiaColumn.MaNhomMon.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DonGiaColumn.MaNhomMon.ToString())];
					c.NhomMonHoc = (reader[DonGiaColumn.NhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaColumn.NhomMonHoc.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DonGia"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DonGia"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.DonGia entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(DonGiaColumn.Id.ToString())];
			entity.MaQuanLy = (reader[DonGiaColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaColumn.MaQuanLy.ToString())];
			entity.MaLoaiGiangVien = (reader[DonGiaColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DonGiaColumn.MaLoaiGiangVien.ToString())];
			entity.MaHocHam = (reader[DonGiaColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DonGiaColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[DonGiaColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DonGiaColumn.MaHocVi.ToString())];
			entity.DonGia = (reader[DonGiaColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaColumn.DonGia.ToString())];
			entity.NgayCapNhat = (reader[DonGiaColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(DonGiaColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[DonGiaColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaColumn.NguoiCapNhat.ToString())];
			entity.DonGiaClc = (reader[DonGiaColumn.DonGiaClc.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaColumn.DonGiaClc.ToString())];
			entity.HeSoQuyDoiChatLuong = (reader[DonGiaColumn.HeSoQuyDoiChatLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaColumn.HeSoQuyDoiChatLuong.ToString())];
			entity.DonGiaTrongChuan = (reader[DonGiaColumn.DonGiaTrongChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaColumn.DonGiaTrongChuan.ToString())];
			entity.DonGiaNgoaiChuan = (reader[DonGiaColumn.DonGiaNgoaiChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaColumn.DonGiaNgoaiChuan.ToString())];
			entity.MaHinhThucDaoTao = (reader[DonGiaColumn.MaHinhThucDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaColumn.MaHinhThucDaoTao.ToString())];
			entity.BacDaoTao = (reader[DonGiaColumn.BacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaColumn.BacDaoTao.ToString())];
			entity.NgonNguGiangDay = (reader[DonGiaColumn.NgonNguGiangDay.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaColumn.NgonNguGiangDay.ToString())];
			entity.NamHoc = (reader[DonGiaColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaColumn.NamHoc.ToString())];
			entity.HocKy = (reader[DonGiaColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaColumn.HocKy.ToString())];
			entity.MaNhomMon = (reader[DonGiaColumn.MaNhomMon.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DonGiaColumn.MaNhomMon.ToString())];
			entity.NhomMonHoc = (reader[DonGiaColumn.NhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaColumn.NhomMonHoc.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DonGia"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DonGia"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.DonGia entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaQuanLy = Convert.IsDBNull(dataRow["MaQuanLy"]) ? null : (System.String)dataRow["MaQuanLy"];
			entity.MaLoaiGiangVien = Convert.IsDBNull(dataRow["MaLoaiGiangVien"]) ? null : (System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
			entity.DonGia = Convert.IsDBNull(dataRow["DonGia"]) ? null : (System.Decimal?)dataRow["DonGia"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.DonGiaClc = Convert.IsDBNull(dataRow["DonGiaClc"]) ? null : (System.Decimal?)dataRow["DonGiaClc"];
			entity.HeSoQuyDoiChatLuong = Convert.IsDBNull(dataRow["HeSoQuyDoiChatLuong"]) ? null : (System.Decimal?)dataRow["HeSoQuyDoiChatLuong"];
			entity.DonGiaTrongChuan = Convert.IsDBNull(dataRow["DonGiaTrongChuan"]) ? null : (System.Decimal?)dataRow["DonGiaTrongChuan"];
			entity.DonGiaNgoaiChuan = Convert.IsDBNull(dataRow["DonGiaNgoaiChuan"]) ? null : (System.Decimal?)dataRow["DonGiaNgoaiChuan"];
			entity.MaHinhThucDaoTao = Convert.IsDBNull(dataRow["MaHinhThucDaoTao"]) ? null : (System.String)dataRow["MaHinhThucDaoTao"];
			entity.BacDaoTao = Convert.IsDBNull(dataRow["BacDaoTao"]) ? null : (System.String)dataRow["BacDaoTao"];
			entity.NgonNguGiangDay = Convert.IsDBNull(dataRow["NgonNguGiangDay"]) ? null : (System.String)dataRow["NgonNguGiangDay"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaNhomMon = Convert.IsDBNull(dataRow["MaNhomMon"]) ? null : (System.Int32?)dataRow["MaNhomMon"];
			entity.NhomMonHoc = Convert.IsDBNull(dataRow["NhomMonHoc"]) ? null : (System.String)dataRow["NhomMonHoc"];
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
		/// <param name="entity">The <see cref="PMS.Entities.DonGia"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.DonGia Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.DonGia entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaNhomMonSource	
			if (CanDeepLoad(entity, "NhomMonHoc|MaNhomMonSource", deepLoadType, innerList) 
				&& entity.MaNhomMonSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaNhomMon ?? (int)0);
				NhomMonHoc tmpEntity = EntityManager.LocateEntity<NhomMonHoc>(EntityLocator.ConstructKeyFromPkItems(typeof(NhomMonHoc), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaNhomMonSource = tmpEntity;
				else
					entity.MaNhomMonSource = DataRepository.NhomMonHocProvider.GetByMaNhomMon(transactionManager, (entity.MaNhomMon ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaNhomMonSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaNhomMonSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.NhomMonHocProvider.DeepLoad(transactionManager, entity.MaNhomMonSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaNhomMonSource

			#region MaHocHamSource	
			if (CanDeepLoad(entity, "HocHam|MaHocHamSource", deepLoadType, innerList) 
				&& entity.MaHocHamSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaHocHam ?? (int)0);
				HocHam tmpEntity = EntityManager.LocateEntity<HocHam>(EntityLocator.ConstructKeyFromPkItems(typeof(HocHam), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaHocHamSource = tmpEntity;
				else
					entity.MaHocHamSource = DataRepository.HocHamProvider.GetByMaHocHam(transactionManager, (entity.MaHocHam ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaHocHamSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaHocHamSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.HocHamProvider.DeepLoad(transactionManager, entity.MaHocHamSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaHocHamSource

			#region MaHocViSource	
			if (CanDeepLoad(entity, "HocVi|MaHocViSource", deepLoadType, innerList) 
				&& entity.MaHocViSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaHocVi ?? (int)0);
				HocVi tmpEntity = EntityManager.LocateEntity<HocVi>(EntityLocator.ConstructKeyFromPkItems(typeof(HocVi), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaHocViSource = tmpEntity;
				else
					entity.MaHocViSource = DataRepository.HocViProvider.GetByMaHocVi(transactionManager, (entity.MaHocVi ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaHocViSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaHocViSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.HocViProvider.DeepLoad(transactionManager, entity.MaHocViSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaHocViSource

			#region MaLoaiGiangVienSource	
			if (CanDeepLoad(entity, "LoaiGiangVien|MaLoaiGiangVienSource", deepLoadType, innerList) 
				&& entity.MaLoaiGiangVienSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaLoaiGiangVien ?? (int)0);
				LoaiGiangVien tmpEntity = EntityManager.LocateEntity<LoaiGiangVien>(EntityLocator.ConstructKeyFromPkItems(typeof(LoaiGiangVien), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaLoaiGiangVienSource = tmpEntity;
				else
					entity.MaLoaiGiangVienSource = DataRepository.LoaiGiangVienProvider.GetByMaLoaiGiangVien(transactionManager, (entity.MaLoaiGiangVien ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaLoaiGiangVienSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaLoaiGiangVienSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.LoaiGiangVienProvider.DeepLoad(transactionManager, entity.MaLoaiGiangVienSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaLoaiGiangVienSource

			#region NgonNguGiangDaySource	
			if (CanDeepLoad(entity, "NgonNguGiangDay|NgonNguGiangDaySource", deepLoadType, innerList) 
				&& entity.NgonNguGiangDaySource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.NgonNguGiangDay ?? string.Empty);
				NgonNguGiangDay tmpEntity = EntityManager.LocateEntity<NgonNguGiangDay>(EntityLocator.ConstructKeyFromPkItems(typeof(NgonNguGiangDay), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.NgonNguGiangDaySource = tmpEntity;
				else
					entity.NgonNguGiangDaySource = DataRepository.NgonNguGiangDayProvider.GetByMaNgonNgu(transactionManager, (entity.NgonNguGiangDay ?? string.Empty));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'NgonNguGiangDaySource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.NgonNguGiangDaySource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.NgonNguGiangDayProvider.DeepLoad(transactionManager, entity.NgonNguGiangDaySource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion NgonNguGiangDaySource
			
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
		/// Deep Save the entire object graph of the PMS.Entities.DonGia object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.DonGia instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.DonGia Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.DonGia entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaNhomMonSource
			if (CanDeepSave(entity, "NhomMonHoc|MaNhomMonSource", deepSaveType, innerList) 
				&& entity.MaNhomMonSource != null)
			{
				DataRepository.NhomMonHocProvider.Save(transactionManager, entity.MaNhomMonSource);
				entity.MaNhomMon = entity.MaNhomMonSource.MaNhomMon;
			}
			#endregion 
			
			#region MaHocHamSource
			if (CanDeepSave(entity, "HocHam|MaHocHamSource", deepSaveType, innerList) 
				&& entity.MaHocHamSource != null)
			{
				DataRepository.HocHamProvider.Save(transactionManager, entity.MaHocHamSource);
				entity.MaHocHam = entity.MaHocHamSource.MaHocHam;
			}
			#endregion 
			
			#region MaHocViSource
			if (CanDeepSave(entity, "HocVi|MaHocViSource", deepSaveType, innerList) 
				&& entity.MaHocViSource != null)
			{
				DataRepository.HocViProvider.Save(transactionManager, entity.MaHocViSource);
				entity.MaHocVi = entity.MaHocViSource.MaHocVi;
			}
			#endregion 
			
			#region MaLoaiGiangVienSource
			if (CanDeepSave(entity, "LoaiGiangVien|MaLoaiGiangVienSource", deepSaveType, innerList) 
				&& entity.MaLoaiGiangVienSource != null)
			{
				DataRepository.LoaiGiangVienProvider.Save(transactionManager, entity.MaLoaiGiangVienSource);
				entity.MaLoaiGiangVien = entity.MaLoaiGiangVienSource.MaLoaiGiangVien;
			}
			#endregion 
			
			#region NgonNguGiangDaySource
			if (CanDeepSave(entity, "NgonNguGiangDay|NgonNguGiangDaySource", deepSaveType, innerList) 
				&& entity.NgonNguGiangDaySource != null)
			{
				DataRepository.NgonNguGiangDayProvider.Save(transactionManager, entity.NgonNguGiangDaySource);
				entity.NgonNguGiangDay = entity.NgonNguGiangDaySource.MaNgonNgu;
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
	
	#region DonGiaChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.DonGia</c>
	///</summary>
	public enum DonGiaChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>NhomMonHoc</c> at MaNhomMonSource
		///</summary>
		[ChildEntityType(typeof(NhomMonHoc))]
		NhomMonHoc,
		
		///<summary>
		/// Composite Property for <c>HocHam</c> at MaHocHamSource
		///</summary>
		[ChildEntityType(typeof(HocHam))]
		HocHam,
		
		///<summary>
		/// Composite Property for <c>HocVi</c> at MaHocViSource
		///</summary>
		[ChildEntityType(typeof(HocVi))]
		HocVi,
		
		///<summary>
		/// Composite Property for <c>LoaiGiangVien</c> at MaLoaiGiangVienSource
		///</summary>
		[ChildEntityType(typeof(LoaiGiangVien))]
		LoaiGiangVien,
		
		///<summary>
		/// Composite Property for <c>NgonNguGiangDay</c> at NgonNguGiangDaySource
		///</summary>
		[ChildEntityType(typeof(NgonNguGiangDay))]
		NgonNguGiangDay,
	}
	
	#endregion DonGiaChildEntityTypes
	
	#region DonGiaFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;DonGiaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGia"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonGiaFilterBuilder : SqlFilterBuilder<DonGiaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaFilterBuilder class.
		/// </summary>
		public DonGiaFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DonGiaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DonGiaFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DonGiaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DonGiaFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DonGiaFilterBuilder
	
	#region DonGiaParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;DonGiaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGia"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonGiaParameterBuilder : ParameterizedSqlFilterBuilder<DonGiaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaParameterBuilder class.
		/// </summary>
		public DonGiaParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DonGiaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DonGiaParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DonGiaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DonGiaParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DonGiaParameterBuilder
	
	#region DonGiaSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;DonGiaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGia"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class DonGiaSortBuilder : SqlSortBuilder<DonGiaColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaSqlSortBuilder class.
		/// </summary>
		public DonGiaSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion DonGiaSortBuilder
	
} // end namespace
