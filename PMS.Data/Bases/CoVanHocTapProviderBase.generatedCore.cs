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
	/// This class is the base class for any <see cref="CoVanHocTapProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CoVanHocTapProviderBaseCore : EntityProviderBase<PMS.Entities.CoVanHocTap, PMS.Entities.CoVanHocTapKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.CoVanHocTapKey key)
		{
			return Delete(transactionManager, key.MaCoVan);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maCoVan">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maCoVan)
		{
			return Delete(null, _maCoVan);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCoVan">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maCoVan);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CoVanHocTap_GiangVien key.
		///		FK_CoVanHocTap_GiangVien Description: 
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.CoVanHocTap objects.</returns>
		public TList<CoVanHocTap> GetByMaGiangVien(System.Int32? _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(_maGiangVien, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CoVanHocTap_GiangVien key.
		///		FK_CoVanHocTap_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.CoVanHocTap objects.</returns>
		/// <remarks></remarks>
		public TList<CoVanHocTap> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CoVanHocTap_GiangVien key.
		///		FK_CoVanHocTap_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.CoVanHocTap objects.</returns>
		public TList<CoVanHocTap> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CoVanHocTap_GiangVien key.
		///		fkCoVanHocTapGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.CoVanHocTap objects.</returns>
		public TList<CoVanHocTap> GetByMaGiangVien(System.Int32? _maGiangVien, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CoVanHocTap_GiangVien key.
		///		fkCoVanHocTapGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.CoVanHocTap objects.</returns>
		public TList<CoVanHocTap> GetByMaGiangVien(System.Int32? _maGiangVien, int start, int pageLength,out int count)
		{
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CoVanHocTap_GiangVien key.
		///		FK_CoVanHocTap_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.CoVanHocTap objects.</returns>
		public abstract TList<CoVanHocTap> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.CoVanHocTap Get(TransactionManager transactionManager, PMS.Entities.CoVanHocTapKey key, int start, int pageLength)
		{
			return GetByMaCoVan(transactionManager, key.MaCoVan, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_CoVanHocTap index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maLop"></param>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CoVanHocTap"/> class.</returns>
		public PMS.Entities.CoVanHocTap GetByMaGiangVienMaLopNamHocHocKy(System.Int32? _maGiangVien, System.String _maLop, System.String _namHoc, System.String _hocKy)
		{
			int count = -1;
			return GetByMaGiangVienMaLopNamHocHocKy(null,_maGiangVien, _maLop, _namHoc, _hocKy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CoVanHocTap index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maLop"></param>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CoVanHocTap"/> class.</returns>
		public PMS.Entities.CoVanHocTap GetByMaGiangVienMaLopNamHocHocKy(System.Int32? _maGiangVien, System.String _maLop, System.String _namHoc, System.String _hocKy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVienMaLopNamHocHocKy(null, _maGiangVien, _maLop, _namHoc, _hocKy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CoVanHocTap index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maLop"></param>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CoVanHocTap"/> class.</returns>
		public PMS.Entities.CoVanHocTap GetByMaGiangVienMaLopNamHocHocKy(TransactionManager transactionManager, System.Int32? _maGiangVien, System.String _maLop, System.String _namHoc, System.String _hocKy)
		{
			int count = -1;
			return GetByMaGiangVienMaLopNamHocHocKy(transactionManager, _maGiangVien, _maLop, _namHoc, _hocKy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CoVanHocTap index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maLop"></param>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CoVanHocTap"/> class.</returns>
		public PMS.Entities.CoVanHocTap GetByMaGiangVienMaLopNamHocHocKy(TransactionManager transactionManager, System.Int32? _maGiangVien, System.String _maLop, System.String _namHoc, System.String _hocKy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVienMaLopNamHocHocKy(transactionManager, _maGiangVien, _maLop, _namHoc, _hocKy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CoVanHocTap index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maLop"></param>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CoVanHocTap"/> class.</returns>
		public PMS.Entities.CoVanHocTap GetByMaGiangVienMaLopNamHocHocKy(System.Int32? _maGiangVien, System.String _maLop, System.String _namHoc, System.String _hocKy, int start, int pageLength, out int count)
		{
			return GetByMaGiangVienMaLopNamHocHocKy(null, _maGiangVien, _maLop, _namHoc, _hocKy, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CoVanHocTap index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maLop"></param>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CoVanHocTap"/> class.</returns>
		public abstract PMS.Entities.CoVanHocTap GetByMaGiangVienMaLopNamHocHocKy(TransactionManager transactionManager, System.Int32? _maGiangVien, System.String _maLop, System.String _namHoc, System.String _hocKy, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CoVanHocTap index.
		/// </summary>
		/// <param name="_maCoVan"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CoVanHocTap"/> class.</returns>
		public PMS.Entities.CoVanHocTap GetByMaCoVan(System.Int32 _maCoVan)
		{
			int count = -1;
			return GetByMaCoVan(null,_maCoVan, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CoVanHocTap index.
		/// </summary>
		/// <param name="_maCoVan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CoVanHocTap"/> class.</returns>
		public PMS.Entities.CoVanHocTap GetByMaCoVan(System.Int32 _maCoVan, int start, int pageLength)
		{
			int count = -1;
			return GetByMaCoVan(null, _maCoVan, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CoVanHocTap index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCoVan"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CoVanHocTap"/> class.</returns>
		public PMS.Entities.CoVanHocTap GetByMaCoVan(TransactionManager transactionManager, System.Int32 _maCoVan)
		{
			int count = -1;
			return GetByMaCoVan(transactionManager, _maCoVan, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CoVanHocTap index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCoVan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CoVanHocTap"/> class.</returns>
		public PMS.Entities.CoVanHocTap GetByMaCoVan(TransactionManager transactionManager, System.Int32 _maCoVan, int start, int pageLength)
		{
			int count = -1;
			return GetByMaCoVan(transactionManager, _maCoVan, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CoVanHocTap index.
		/// </summary>
		/// <param name="_maCoVan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CoVanHocTap"/> class.</returns>
		public PMS.Entities.CoVanHocTap GetByMaCoVan(System.Int32 _maCoVan, int start, int pageLength, out int count)
		{
			return GetByMaCoVan(null, _maCoVan, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CoVanHocTap index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCoVan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CoVanHocTap"/> class.</returns>
		public abstract PMS.Entities.CoVanHocTap GetByMaCoVan(TransactionManager transactionManager, System.Int32 _maCoVan, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_CoVanHocTap_GetByNamHocHocKyMaKhoaHoc 
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByNamHocHocKyMaKhoaHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CoVanHocTap&gt;"/> instance.</returns>
		public TList<CoVanHocTap> GetByNamHocHocKyMaKhoaHoc(System.String namHoc, System.String hocKy, System.String maKhoaHoc)
		{
			return GetByNamHocHocKyMaKhoaHoc(null, 0, int.MaxValue , namHoc, hocKy, maKhoaHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByNamHocHocKyMaKhoaHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CoVanHocTap&gt;"/> instance.</returns>
		public TList<CoVanHocTap> GetByNamHocHocKyMaKhoaHoc(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maKhoaHoc)
		{
			return GetByNamHocHocKyMaKhoaHoc(null, start, pageLength , namHoc, hocKy, maKhoaHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByNamHocHocKyMaKhoaHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CoVanHocTap&gt;"/> instance.</returns>
		public TList<CoVanHocTap> GetByNamHocHocKyMaKhoaHoc(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maKhoaHoc)
		{
			return GetByNamHocHocKyMaKhoaHoc(transactionManager, 0, int.MaxValue , namHoc, hocKy, maKhoaHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByNamHocHocKyMaKhoaHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CoVanHocTap&gt;"/> instance.</returns>
		public abstract TList<CoVanHocTap> GetByNamHocHocKyMaKhoaHoc(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maKhoaHoc);
		
		#endregion
		
		#region cust_CoVanHocTap_GetByNamHocHocKyBacDaoTaoKhoaHoc 
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByNamHocHocKyBacDaoTaoKhoaHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyBacDaoTaoKhoaHoc(System.String namHoc, System.String hocKy, System.String maBacDaoTao, System.String khoaHoc)
		{
			return GetByNamHocHocKyBacDaoTaoKhoaHoc(null, 0, int.MaxValue , namHoc, hocKy, maBacDaoTao, khoaHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByNamHocHocKyBacDaoTaoKhoaHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyBacDaoTaoKhoaHoc(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maBacDaoTao, System.String khoaHoc)
		{
			return GetByNamHocHocKyBacDaoTaoKhoaHoc(null, start, pageLength , namHoc, hocKy, maBacDaoTao, khoaHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByNamHocHocKyBacDaoTaoKhoaHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyBacDaoTaoKhoaHoc(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maBacDaoTao, System.String khoaHoc)
		{
			return GetByNamHocHocKyBacDaoTaoKhoaHoc(transactionManager, 0, int.MaxValue , namHoc, hocKy, maBacDaoTao, khoaHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByNamHocHocKyBacDaoTaoKhoaHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKyBacDaoTaoKhoaHoc(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maBacDaoTao, System.String khoaHoc);
		
		#endregion
		
		#region cust_CoVanHocTap_GetAllClassStudentByYearStudyTermIdDepartmentId 
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetAllClassStudentByYearStudyTermIdDepartmentId' stored procedure. 
		/// </summary>
		/// <param name="yearStudy"> A <c>System.String</c> instance.</param>
		/// <param name="termId"> A <c>System.String</c> instance.</param>
		/// <param name="departmentId"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetAllClassStudentByYearStudyTermIdDepartmentId(System.String yearStudy, System.String termId, System.String departmentId)
		{
			return GetAllClassStudentByYearStudyTermIdDepartmentId(null, 0, int.MaxValue , yearStudy, termId, departmentId);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetAllClassStudentByYearStudyTermIdDepartmentId' stored procedure. 
		/// </summary>
		/// <param name="yearStudy"> A <c>System.String</c> instance.</param>
		/// <param name="termId"> A <c>System.String</c> instance.</param>
		/// <param name="departmentId"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetAllClassStudentByYearStudyTermIdDepartmentId(int start, int pageLength, System.String yearStudy, System.String termId, System.String departmentId)
		{
			return GetAllClassStudentByYearStudyTermIdDepartmentId(null, start, pageLength , yearStudy, termId, departmentId);
		}
				
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetAllClassStudentByYearStudyTermIdDepartmentId' stored procedure. 
		/// </summary>
		/// <param name="yearStudy"> A <c>System.String</c> instance.</param>
		/// <param name="termId"> A <c>System.String</c> instance.</param>
		/// <param name="departmentId"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetAllClassStudentByYearStudyTermIdDepartmentId(TransactionManager transactionManager, System.String yearStudy, System.String termId, System.String departmentId)
		{
			return GetAllClassStudentByYearStudyTermIdDepartmentId(transactionManager, 0, int.MaxValue , yearStudy, termId, departmentId);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetAllClassStudentByYearStudyTermIdDepartmentId' stored procedure. 
		/// </summary>
		/// <param name="yearStudy"> A <c>System.String</c> instance.</param>
		/// <param name="termId"> A <c>System.String</c> instance.</param>
		/// <param name="departmentId"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetAllClassStudentByYearStudyTermIdDepartmentId(TransactionManager transactionManager, int start, int pageLength , System.String yearStudy, System.String termId, System.String departmentId);
		
		#endregion
		
		#region cust_CoVanHocTap_GetByNamHocHocKyKhoaDonVi 
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByNamHocHocKyKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoa"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyKhoaDonVi(System.String namHoc, System.String hocKy, System.String khoa)
		{
			return GetByNamHocHocKyKhoaDonVi(null, 0, int.MaxValue , namHoc, hocKy, khoa);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByNamHocHocKyKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoa"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyKhoaDonVi(int start, int pageLength, System.String namHoc, System.String hocKy, System.String khoa)
		{
			return GetByNamHocHocKyKhoaDonVi(null, start, pageLength , namHoc, hocKy, khoa);
		}
				
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByNamHocHocKyKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoa"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyKhoaDonVi(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String khoa)
		{
			return GetByNamHocHocKyKhoaDonVi(transactionManager, 0, int.MaxValue , namHoc, hocKy, khoa);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByNamHocHocKyKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoa"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKyKhoaDonVi(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String khoa);
		
		#endregion
		
		#region cust_CoVanHocTap_LayDuLieu 
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_LayDuLieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LayDuLieu(System.String namHoc, System.String hocKy)
		{
			 LayDuLieu(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_LayDuLieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LayDuLieu(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			 LayDuLieu(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_LayDuLieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LayDuLieu(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			 LayDuLieu(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_LayDuLieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LayDuLieu(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_CoVanHocTap_InsertUpdate 
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_InsertUpdate' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32?</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="ngayTao"> A <c>System.DateTime</c> instance.</param>
		/// <param name="soTiet"> A <c>System.Int32?</c> instance.</param>
		/// <param name="soTien"> A <c>System.Decimal?</c> instance.</param>
		/// <param name="trangThai"> A <c>System.Boolean?</c> instance.</param>
		/// <param name="nguoiCapNhat"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void InsertUpdate(System.Int32? maGiangVien, System.String namHoc, System.String hocKy, System.String maLop, System.String maKhoaHoc, System.DateTime ngayTao, System.Int32? soTiet, System.Decimal? soTien, System.Boolean? trangThai, System.String nguoiCapNhat)
		{
			 InsertUpdate(null, 0, int.MaxValue , maGiangVien, namHoc, hocKy, maLop, maKhoaHoc, ngayTao, soTiet, soTien, trangThai, nguoiCapNhat);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_InsertUpdate' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32?</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="ngayTao"> A <c>System.DateTime</c> instance.</param>
		/// <param name="soTiet"> A <c>System.Int32?</c> instance.</param>
		/// <param name="soTien"> A <c>System.Decimal?</c> instance.</param>
		/// <param name="trangThai"> A <c>System.Boolean?</c> instance.</param>
		/// <param name="nguoiCapNhat"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void InsertUpdate(int start, int pageLength, System.Int32? maGiangVien, System.String namHoc, System.String hocKy, System.String maLop, System.String maKhoaHoc, System.DateTime ngayTao, System.Int32? soTiet, System.Decimal? soTien, System.Boolean? trangThai, System.String nguoiCapNhat)
		{
			 InsertUpdate(null, start, pageLength , maGiangVien, namHoc, hocKy, maLop, maKhoaHoc, ngayTao, soTiet, soTien, trangThai, nguoiCapNhat);
		}
				
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_InsertUpdate' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32?</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="ngayTao"> A <c>System.DateTime</c> instance.</param>
		/// <param name="soTiet"> A <c>System.Int32?</c> instance.</param>
		/// <param name="soTien"> A <c>System.Decimal?</c> instance.</param>
		/// <param name="trangThai"> A <c>System.Boolean?</c> instance.</param>
		/// <param name="nguoiCapNhat"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void InsertUpdate(TransactionManager transactionManager, System.Int32? maGiangVien, System.String namHoc, System.String hocKy, System.String maLop, System.String maKhoaHoc, System.DateTime ngayTao, System.Int32? soTiet, System.Decimal? soTien, System.Boolean? trangThai, System.String nguoiCapNhat)
		{
			 InsertUpdate(transactionManager, 0, int.MaxValue , maGiangVien, namHoc, hocKy, maLop, maKhoaHoc, ngayTao, soTiet, soTien, trangThai, nguoiCapNhat);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_InsertUpdate' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32?</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="ngayTao"> A <c>System.DateTime</c> instance.</param>
		/// <param name="soTiet"> A <c>System.Int32?</c> instance.</param>
		/// <param name="soTien"> A <c>System.Decimal?</c> instance.</param>
		/// <param name="trangThai"> A <c>System.Boolean?</c> instance.</param>
		/// <param name="nguoiCapNhat"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void InsertUpdate(TransactionManager transactionManager, int start, int pageLength , System.Int32? maGiangVien, System.String namHoc, System.String hocKy, System.String maLop, System.String maKhoaHoc, System.DateTime ngayTao, System.Int32? soTiet, System.Decimal? soTien, System.Boolean? trangThai, System.String nguoiCapNhat);
		
		#endregion
		
		#region cust_CoVanHocTap_GetByMaGiangVienNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByMaGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CoVanHocTap&gt;"/> instance.</returns>
		public TList<CoVanHocTap> GetByMaGiangVienNamHocHocKy(System.Int32 maGiangVien, System.String namHoc, System.String hocKy)
		{
			return GetByMaGiangVienNamHocHocKy(null, 0, int.MaxValue , maGiangVien, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByMaGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CoVanHocTap&gt;"/> instance.</returns>
		public TList<CoVanHocTap> GetByMaGiangVienNamHocHocKy(int start, int pageLength, System.Int32 maGiangVien, System.String namHoc, System.String hocKy)
		{
			return GetByMaGiangVienNamHocHocKy(null, start, pageLength , maGiangVien, namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByMaGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CoVanHocTap&gt;"/> instance.</returns>
		public TList<CoVanHocTap> GetByMaGiangVienNamHocHocKy(TransactionManager transactionManager, System.Int32 maGiangVien, System.String namHoc, System.String hocKy)
		{
			return GetByMaGiangVienNamHocHocKy(transactionManager, 0, int.MaxValue , maGiangVien, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByMaGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CoVanHocTap&gt;"/> instance.</returns>
		public abstract TList<CoVanHocTap> GetByMaGiangVienNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.Int32 maGiangVien, System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_CoVanHocTap_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CoVanHocTap&gt;"/> instance.</returns>
		public TList<CoVanHocTap> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CoVanHocTap&gt;"/> instance.</returns>
		public TList<CoVanHocTap> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CoVanHocTap&gt;"/> instance.</returns>
		public TList<CoVanHocTap> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CoVanHocTap&gt;"/> instance.</returns>
		public abstract TList<CoVanHocTap> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_CoVanHocTap_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, System.String maGiangVien)
		{
			 Luu(null, 0, int.MaxValue , xmlData, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, System.String maGiangVien)
		{
			 Luu(null, start, pageLength , xmlData, maGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, System.String maGiangVien)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String maGiangVien);
		
		#endregion
		
		#region cust_CoVanHocTap_GetByNamHocKhoaBoMon 
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByNamHocKhoaBoMon' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="khoa"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocKhoaBoMon(System.String namHoc, System.String khoa)
		{
			return GetByNamHocKhoaBoMon(null, 0, int.MaxValue , namHoc, khoa);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByNamHocKhoaBoMon' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="khoa"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocKhoaBoMon(int start, int pageLength, System.String namHoc, System.String khoa)
		{
			return GetByNamHocKhoaBoMon(null, start, pageLength , namHoc, khoa);
		}
				
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByNamHocKhoaBoMon' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="khoa"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocKhoaBoMon(TransactionManager transactionManager, System.String namHoc, System.String khoa)
		{
			return GetByNamHocKhoaBoMon(transactionManager, 0, int.MaxValue , namHoc, khoa);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByNamHocKhoaBoMon' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="khoa"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocKhoaBoMon(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String khoa);
		
		#endregion
		
		#region cust_CoVanHocTap_GetByNamHocHocKyNhomQuyen 
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByNamHocHocKyNhomQuyen' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="nhomQuyen"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CoVanHocTap&gt;"/> instance.</returns>
		public TList<CoVanHocTap> GetByNamHocHocKyNhomQuyen(System.String namHoc, System.String hocKy, System.String nhomQuyen)
		{
			return GetByNamHocHocKyNhomQuyen(null, 0, int.MaxValue , namHoc, hocKy, nhomQuyen);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByNamHocHocKyNhomQuyen' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="nhomQuyen"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CoVanHocTap&gt;"/> instance.</returns>
		public TList<CoVanHocTap> GetByNamHocHocKyNhomQuyen(int start, int pageLength, System.String namHoc, System.String hocKy, System.String nhomQuyen)
		{
			return GetByNamHocHocKyNhomQuyen(null, start, pageLength , namHoc, hocKy, nhomQuyen);
		}
				
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByNamHocHocKyNhomQuyen' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="nhomQuyen"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CoVanHocTap&gt;"/> instance.</returns>
		public TList<CoVanHocTap> GetByNamHocHocKyNhomQuyen(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String nhomQuyen)
		{
			return GetByNamHocHocKyNhomQuyen(transactionManager, 0, int.MaxValue , namHoc, hocKy, nhomQuyen);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByNamHocHocKyNhomQuyen' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="nhomQuyen"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CoVanHocTap&gt;"/> instance.</returns>
		public abstract TList<CoVanHocTap> GetByNamHocHocKyNhomQuyen(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String nhomQuyen);
		
		#endregion
		
		#region cust_CoVanHocTap_Import 
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Import(System.String xmlData, ref System.Int32 reVal)
		{
			 Import(null, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_Import' stored procedure. 
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
		///	This method wrap the 'cust_CoVanHocTap_Import' stored procedure. 
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
		///	This method wrap the 'cust_CoVanHocTap_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Import(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_CoVanHocTap_GetByNamHocMaDonVi 
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByNamHocMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocMaDonVi(System.String namHoc, System.String donVi)
		{
			return GetByNamHocMaDonVi(null, 0, int.MaxValue , namHoc, donVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByNamHocMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocMaDonVi(int start, int pageLength, System.String namHoc, System.String donVi)
		{
			return GetByNamHocMaDonVi(null, start, pageLength , namHoc, donVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByNamHocMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocMaDonVi(TransactionManager transactionManager, System.String namHoc, System.String donVi)
		{
			return GetByNamHocMaDonVi(transactionManager, 0, int.MaxValue , namHoc, donVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByNamHocMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocMaDonVi(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String donVi);
		
		#endregion
		
		#region cust_CoVanHocTap_GetSiSoByMaLopNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetSiSoByMaLopNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetSiSoByMaLopNamHocHocKy(System.String maLop, System.String namHoc, System.String hocKy, ref System.Int32 siSo)
		{
			 GetSiSoByMaLopNamHocHocKy(null, 0, int.MaxValue , maLop, namHoc, hocKy, ref siSo);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetSiSoByMaLopNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetSiSoByMaLopNamHocHocKy(int start, int pageLength, System.String maLop, System.String namHoc, System.String hocKy, ref System.Int32 siSo)
		{
			 GetSiSoByMaLopNamHocHocKy(null, start, pageLength , maLop, namHoc, hocKy, ref siSo);
		}
				
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetSiSoByMaLopNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetSiSoByMaLopNamHocHocKy(TransactionManager transactionManager, System.String maLop, System.String namHoc, System.String hocKy, ref System.Int32 siSo)
		{
			 GetSiSoByMaLopNamHocHocKy(transactionManager, 0, int.MaxValue , maLop, namHoc, hocKy, ref siSo);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetSiSoByMaLopNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetSiSoByMaLopNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String maLop, System.String namHoc, System.String hocKy, ref System.Int32 siSo);
		
		#endregion
		
		#region cust_CoVanHocTap_SaoChep 
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_CoVanHocTap_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_CoVanHocTap_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_CoVanHocTap_SaoChep' stored procedure. 
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
		
		#region cust_CoVanHocTap_TheoDoiTheoNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_TheoDoiTheoNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader TheoDoiTheoNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return TheoDoiTheoNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_TheoDoiTheoNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader TheoDoiTheoNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return TheoDoiTheoNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_TheoDoiTheoNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader TheoDoiTheoNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return TheoDoiTheoNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_TheoDoiTheoNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader TheoDoiTheoNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_CoVanHocTap_GetByTrangThai 
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByTrangThai' stored procedure. 
		/// </summary>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CoVanHocTap&gt;"/> instance.</returns>
		public TList<CoVanHocTap> GetByTrangThai(System.Boolean trangThai)
		{
			return GetByTrangThai(null, 0, int.MaxValue , trangThai);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByTrangThai' stored procedure. 
		/// </summary>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CoVanHocTap&gt;"/> instance.</returns>
		public TList<CoVanHocTap> GetByTrangThai(int start, int pageLength, System.Boolean trangThai)
		{
			return GetByTrangThai(null, start, pageLength , trangThai);
		}
				
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByTrangThai' stored procedure. 
		/// </summary>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CoVanHocTap&gt;"/> instance.</returns>
		public TList<CoVanHocTap> GetByTrangThai(TransactionManager transactionManager, System.Boolean trangThai)
		{
			return GetByTrangThai(transactionManager, 0, int.MaxValue , trangThai);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CoVanHocTap_GetByTrangThai' stored procedure. 
		/// </summary>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CoVanHocTap&gt;"/> instance.</returns>
		public abstract TList<CoVanHocTap> GetByTrangThai(TransactionManager transactionManager, int start, int pageLength , System.Boolean trangThai);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CoVanHocTap&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CoVanHocTap&gt;"/></returns>
		public static TList<CoVanHocTap> Fill(IDataReader reader, TList<CoVanHocTap> rows, int start, int pageLength)
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
				
				PMS.Entities.CoVanHocTap c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CoVanHocTap")
					.Append("|").Append((System.Int32)reader[((int)CoVanHocTapColumn.MaCoVan - 1)]).ToString();
					c = EntityManager.LocateOrCreate<CoVanHocTap>(
					key.ToString(), // EntityTrackingKey
					"CoVanHocTap",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.CoVanHocTap();
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
					c.MaCoVan = (System.Int32)reader[(CoVanHocTapColumn.MaCoVan.ToString())];
					c.MaGiangVien = (reader[CoVanHocTapColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(CoVanHocTapColumn.MaGiangVien.ToString())];
					c.NamHoc = (reader[CoVanHocTapColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(CoVanHocTapColumn.NamHoc.ToString())];
					c.HocKy = (reader[CoVanHocTapColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(CoVanHocTapColumn.HocKy.ToString())];
					c.MaLop = (reader[CoVanHocTapColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(CoVanHocTapColumn.MaLop.ToString())];
					c.MaKhoaHoc = (reader[CoVanHocTapColumn.MaKhoaHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(CoVanHocTapColumn.MaKhoaHoc.ToString())];
					c.SoTiet = (reader[CoVanHocTapColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(CoVanHocTapColumn.SoTiet.ToString())];
					c.SoTien = (reader[CoVanHocTapColumn.SoTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(CoVanHocTapColumn.SoTien.ToString())];
					c.NgayTao = (reader[CoVanHocTapColumn.NgayTao.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(CoVanHocTapColumn.NgayTao.ToString())];
					c.TrangThai = (reader[CoVanHocTapColumn.TrangThai.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(CoVanHocTapColumn.TrangThai.ToString())];
					c.SiSo = (reader[CoVanHocTapColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(CoVanHocTapColumn.SiSo.ToString())];
					c.DanhGiaHoanThanh = (reader[CoVanHocTapColumn.DanhGiaHoanThanh.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(CoVanHocTapColumn.DanhGiaHoanThanh.ToString())];
					c.NgayKetThuc = (reader[CoVanHocTapColumn.NgayKetThuc.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(CoVanHocTapColumn.NgayKetThuc.ToString())];
					c.GhiChu = (reader[CoVanHocTapColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(CoVanHocTapColumn.GhiChu.ToString())];
					c.NgayCapNhat = (reader[CoVanHocTapColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(CoVanHocTapColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[CoVanHocTapColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(CoVanHocTapColumn.NguoiCapNhat.ToString())];
					c.Nhom = (reader[CoVanHocTapColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(CoVanHocTapColumn.Nhom.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.CoVanHocTap"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.CoVanHocTap"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.CoVanHocTap entity)
		{
			if (!reader.Read()) return;
			
			entity.MaCoVan = (System.Int32)reader[(CoVanHocTapColumn.MaCoVan.ToString())];
			entity.MaGiangVien = (reader[CoVanHocTapColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(CoVanHocTapColumn.MaGiangVien.ToString())];
			entity.NamHoc = (reader[CoVanHocTapColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(CoVanHocTapColumn.NamHoc.ToString())];
			entity.HocKy = (reader[CoVanHocTapColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(CoVanHocTapColumn.HocKy.ToString())];
			entity.MaLop = (reader[CoVanHocTapColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(CoVanHocTapColumn.MaLop.ToString())];
			entity.MaKhoaHoc = (reader[CoVanHocTapColumn.MaKhoaHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(CoVanHocTapColumn.MaKhoaHoc.ToString())];
			entity.SoTiet = (reader[CoVanHocTapColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(CoVanHocTapColumn.SoTiet.ToString())];
			entity.SoTien = (reader[CoVanHocTapColumn.SoTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(CoVanHocTapColumn.SoTien.ToString())];
			entity.NgayTao = (reader[CoVanHocTapColumn.NgayTao.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(CoVanHocTapColumn.NgayTao.ToString())];
			entity.TrangThai = (reader[CoVanHocTapColumn.TrangThai.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(CoVanHocTapColumn.TrangThai.ToString())];
			entity.SiSo = (reader[CoVanHocTapColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(CoVanHocTapColumn.SiSo.ToString())];
			entity.DanhGiaHoanThanh = (reader[CoVanHocTapColumn.DanhGiaHoanThanh.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(CoVanHocTapColumn.DanhGiaHoanThanh.ToString())];
			entity.NgayKetThuc = (reader[CoVanHocTapColumn.NgayKetThuc.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(CoVanHocTapColumn.NgayKetThuc.ToString())];
			entity.GhiChu = (reader[CoVanHocTapColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(CoVanHocTapColumn.GhiChu.ToString())];
			entity.NgayCapNhat = (reader[CoVanHocTapColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(CoVanHocTapColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[CoVanHocTapColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(CoVanHocTapColumn.NguoiCapNhat.ToString())];
			entity.Nhom = (reader[CoVanHocTapColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(CoVanHocTapColumn.Nhom.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.CoVanHocTap"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.CoVanHocTap"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.CoVanHocTap entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaCoVan = (System.Int32)dataRow["MaCoVan"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.Int32?)dataRow["MaGiangVien"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaLop = Convert.IsDBNull(dataRow["MaLop"]) ? null : (System.String)dataRow["MaLop"];
			entity.MaKhoaHoc = Convert.IsDBNull(dataRow["MaKhoaHoc"]) ? null : (System.String)dataRow["MaKhoaHoc"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Int32?)dataRow["SoTiet"];
			entity.SoTien = Convert.IsDBNull(dataRow["SoTien"]) ? null : (System.Decimal?)dataRow["SoTien"];
			entity.NgayTao = Convert.IsDBNull(dataRow["NgayTao"]) ? null : (System.DateTime?)dataRow["NgayTao"];
			entity.TrangThai = Convert.IsDBNull(dataRow["TrangThai"]) ? null : (System.Boolean?)dataRow["TrangThai"];
			entity.SiSo = Convert.IsDBNull(dataRow["SiSo"]) ? null : (System.Int32?)dataRow["SiSo"];
			entity.DanhGiaHoanThanh = Convert.IsDBNull(dataRow["DanhGiaHoanThanh"]) ? null : (System.Int32?)dataRow["DanhGiaHoanThanh"];
			entity.NgayKetThuc = Convert.IsDBNull(dataRow["NgayKetThuc"]) ? null : (System.DateTime?)dataRow["NgayKetThuc"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.Nhom = Convert.IsDBNull(dataRow["Nhom"]) ? null : (System.Int32?)dataRow["Nhom"];
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
		/// <param name="entity">The <see cref="PMS.Entities.CoVanHocTap"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.CoVanHocTap Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.CoVanHocTap entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaGiangVienSource	
			if (CanDeepLoad(entity, "GiangVien|MaGiangVienSource", deepLoadType, innerList) 
				&& entity.MaGiangVienSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaGiangVien ?? (int)0);
				GiangVien tmpEntity = EntityManager.LocateEntity<GiangVien>(EntityLocator.ConstructKeyFromPkItems(typeof(GiangVien), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaGiangVienSource = tmpEntity;
				else
					entity.MaGiangVienSource = DataRepository.GiangVienProvider.GetByMaGiangVien(transactionManager, (entity.MaGiangVien ?? (int)0));		
				
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
		/// Deep Save the entire object graph of the PMS.Entities.CoVanHocTap object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.CoVanHocTap instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.CoVanHocTap Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.CoVanHocTap entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region CoVanHocTapChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.CoVanHocTap</c>
	///</summary>
	public enum CoVanHocTapChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GiangVien</c> at MaGiangVienSource
		///</summary>
		[ChildEntityType(typeof(GiangVien))]
		GiangVien,
	}
	
	#endregion CoVanHocTapChildEntityTypes
	
	#region CoVanHocTapFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CoVanHocTapColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoVanHocTap"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoVanHocTapFilterBuilder : SqlFilterBuilder<CoVanHocTapColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoVanHocTapFilterBuilder class.
		/// </summary>
		public CoVanHocTapFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoVanHocTapFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoVanHocTapFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoVanHocTapFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoVanHocTapFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoVanHocTapFilterBuilder
	
	#region CoVanHocTapParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CoVanHocTapColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoVanHocTap"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoVanHocTapParameterBuilder : ParameterizedSqlFilterBuilder<CoVanHocTapColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoVanHocTapParameterBuilder class.
		/// </summary>
		public CoVanHocTapParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoVanHocTapParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoVanHocTapParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoVanHocTapParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoVanHocTapParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoVanHocTapParameterBuilder
	
	#region CoVanHocTapSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CoVanHocTapColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoVanHocTap"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CoVanHocTapSortBuilder : SqlSortBuilder<CoVanHocTapColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoVanHocTapSqlSortBuilder class.
		/// </summary>
		public CoVanHocTapSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CoVanHocTapSortBuilder
	
} // end namespace
