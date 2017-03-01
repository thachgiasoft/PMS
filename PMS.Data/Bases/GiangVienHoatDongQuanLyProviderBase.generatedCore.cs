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
	/// This class is the base class for any <see cref="GiangVienHoatDongQuanLyProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GiangVienHoatDongQuanLyProviderBaseCore : EntityProviderBase<PMS.Entities.GiangVienHoatDongQuanLy, PMS.Entities.GiangVienHoatDongQuanLyKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.GiangVienHoatDongQuanLyKey key)
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
		/// 	Gets rows from the datasource based on the FK_GiangVienHoatDongQuanLy_DanhMucHoatDongQuanLy key.
		///		FK_GiangVienHoatDongQuanLy_DanhMucHoatDongQuanLy Description: 
		/// </summary>
		/// <param name="_maHoatDongQuanLy"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoatDongQuanLy objects.</returns>
		public TList<GiangVienHoatDongQuanLy> GetByMaHoatDongQuanLy(System.Int32? _maHoatDongQuanLy)
		{
			int count = -1;
			return GetByMaHoatDongQuanLy(_maHoatDongQuanLy, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVienHoatDongQuanLy_DanhMucHoatDongQuanLy key.
		///		FK_GiangVienHoatDongQuanLy_DanhMucHoatDongQuanLy Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHoatDongQuanLy"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoatDongQuanLy objects.</returns>
		/// <remarks></remarks>
		public TList<GiangVienHoatDongQuanLy> GetByMaHoatDongQuanLy(TransactionManager transactionManager, System.Int32? _maHoatDongQuanLy)
		{
			int count = -1;
			return GetByMaHoatDongQuanLy(transactionManager, _maHoatDongQuanLy, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVienHoatDongQuanLy_DanhMucHoatDongQuanLy key.
		///		FK_GiangVienHoatDongQuanLy_DanhMucHoatDongQuanLy Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHoatDongQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoatDongQuanLy objects.</returns>
		public TList<GiangVienHoatDongQuanLy> GetByMaHoatDongQuanLy(TransactionManager transactionManager, System.Int32? _maHoatDongQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHoatDongQuanLy(transactionManager, _maHoatDongQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVienHoatDongQuanLy_DanhMucHoatDongQuanLy key.
		///		fkGiangVienHoatDongQuanLyDanhMucHoatDongQuanLy Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maHoatDongQuanLy"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoatDongQuanLy objects.</returns>
		public TList<GiangVienHoatDongQuanLy> GetByMaHoatDongQuanLy(System.Int32? _maHoatDongQuanLy, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaHoatDongQuanLy(null, _maHoatDongQuanLy, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVienHoatDongQuanLy_DanhMucHoatDongQuanLy key.
		///		fkGiangVienHoatDongQuanLyDanhMucHoatDongQuanLy Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maHoatDongQuanLy"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoatDongQuanLy objects.</returns>
		public TList<GiangVienHoatDongQuanLy> GetByMaHoatDongQuanLy(System.Int32? _maHoatDongQuanLy, int start, int pageLength,out int count)
		{
			return GetByMaHoatDongQuanLy(null, _maHoatDongQuanLy, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVienHoatDongQuanLy_DanhMucHoatDongQuanLy key.
		///		FK_GiangVienHoatDongQuanLy_DanhMucHoatDongQuanLy Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHoatDongQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoatDongQuanLy objects.</returns>
		public abstract TList<GiangVienHoatDongQuanLy> GetByMaHoatDongQuanLy(TransactionManager transactionManager, System.Int32? _maHoatDongQuanLy, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVienHoatDongQuanLy_GiangVien key.
		///		FK_GiangVienHoatDongQuanLy_GiangVien Description: 
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoatDongQuanLy objects.</returns>
		public TList<GiangVienHoatDongQuanLy> GetByMaGiangVien(System.Int32? _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(_maGiangVien, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVienHoatDongQuanLy_GiangVien key.
		///		FK_GiangVienHoatDongQuanLy_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoatDongQuanLy objects.</returns>
		/// <remarks></remarks>
		public TList<GiangVienHoatDongQuanLy> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVienHoatDongQuanLy_GiangVien key.
		///		FK_GiangVienHoatDongQuanLy_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoatDongQuanLy objects.</returns>
		public TList<GiangVienHoatDongQuanLy> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVienHoatDongQuanLy_GiangVien key.
		///		fkGiangVienHoatDongQuanLyGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoatDongQuanLy objects.</returns>
		public TList<GiangVienHoatDongQuanLy> GetByMaGiangVien(System.Int32? _maGiangVien, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVienHoatDongQuanLy_GiangVien key.
		///		fkGiangVienHoatDongQuanLyGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoatDongQuanLy objects.</returns>
		public TList<GiangVienHoatDongQuanLy> GetByMaGiangVien(System.Int32? _maGiangVien, int start, int pageLength,out int count)
		{
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVienHoatDongQuanLy_GiangVien key.
		///		FK_GiangVienHoatDongQuanLy_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoatDongQuanLy objects.</returns>
		public abstract TList<GiangVienHoatDongQuanLy> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.GiangVienHoatDongQuanLy Get(TransactionManager transactionManager, PMS.Entities.GiangVienHoatDongQuanLyKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK__GiangVie__3214EC07E1CD661A index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienHoatDongQuanLy"/> class.</returns>
		public PMS.Entities.GiangVienHoatDongQuanLy GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__GiangVie__3214EC07E1CD661A index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienHoatDongQuanLy"/> class.</returns>
		public PMS.Entities.GiangVienHoatDongQuanLy GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__GiangVie__3214EC07E1CD661A index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienHoatDongQuanLy"/> class.</returns>
		public PMS.Entities.GiangVienHoatDongQuanLy GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__GiangVie__3214EC07E1CD661A index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienHoatDongQuanLy"/> class.</returns>
		public PMS.Entities.GiangVienHoatDongQuanLy GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__GiangVie__3214EC07E1CD661A index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienHoatDongQuanLy"/> class.</returns>
		public PMS.Entities.GiangVienHoatDongQuanLy GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__GiangVie__3214EC07E1CD661A index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienHoatDongQuanLy"/> class.</returns>
		public abstract PMS.Entities.GiangVienHoatDongQuanLy GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_GiangVienHoatDongQuanLy_Update 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_Update' stored procedure. 
		/// </summary>
		/// <param name="id"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hoKy"> A <c>System.String</c> instance.</param>
		/// <param name="professorId"> A <c>System.String</c> instance.</param>
		/// <param name="maHoatDongQuanLy"> A <c>System.Int32</c> instance.</param>
		/// <param name="noiDungCongViec"> A <c>System.String</c> instance.</param>
		/// <param name="ngayThucHien"> A <c>System.DateTime</c> instance.</param>
		/// <param name="soPhut"> A <c>System.Int32</c> instance.</param>
		/// <param name="ghiChu"> A <c>System.String</c> instance.</param>
			/// <param name="reval"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Update(System.Int32 id, System.String namHoc, System.String hoKy, System.String professorId, System.Int32 maHoatDongQuanLy, System.String noiDungCongViec, System.DateTime ngayThucHien, System.Int32 soPhut, System.String ghiChu, ref System.String reval)
		{
			 Update(null, 0, int.MaxValue , id, namHoc, hoKy, professorId, maHoatDongQuanLy, noiDungCongViec, ngayThucHien, soPhut, ghiChu, ref reval);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_Update' stored procedure. 
		/// </summary>
		/// <param name="id"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hoKy"> A <c>System.String</c> instance.</param>
		/// <param name="professorId"> A <c>System.String</c> instance.</param>
		/// <param name="maHoatDongQuanLy"> A <c>System.Int32</c> instance.</param>
		/// <param name="noiDungCongViec"> A <c>System.String</c> instance.</param>
		/// <param name="ngayThucHien"> A <c>System.DateTime</c> instance.</param>
		/// <param name="soPhut"> A <c>System.Int32</c> instance.</param>
		/// <param name="ghiChu"> A <c>System.String</c> instance.</param>
			/// <param name="reval"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Update(int start, int pageLength, System.Int32 id, System.String namHoc, System.String hoKy, System.String professorId, System.Int32 maHoatDongQuanLy, System.String noiDungCongViec, System.DateTime ngayThucHien, System.Int32 soPhut, System.String ghiChu, ref System.String reval)
		{
			 Update(null, start, pageLength , id, namHoc, hoKy, professorId, maHoatDongQuanLy, noiDungCongViec, ngayThucHien, soPhut, ghiChu, ref reval);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_Update' stored procedure. 
		/// </summary>
		/// <param name="id"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hoKy"> A <c>System.String</c> instance.</param>
		/// <param name="professorId"> A <c>System.String</c> instance.</param>
		/// <param name="maHoatDongQuanLy"> A <c>System.Int32</c> instance.</param>
		/// <param name="noiDungCongViec"> A <c>System.String</c> instance.</param>
		/// <param name="ngayThucHien"> A <c>System.DateTime</c> instance.</param>
		/// <param name="soPhut"> A <c>System.Int32</c> instance.</param>
		/// <param name="ghiChu"> A <c>System.String</c> instance.</param>
			/// <param name="reval"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Update(TransactionManager transactionManager, System.Int32 id, System.String namHoc, System.String hoKy, System.String professorId, System.Int32 maHoatDongQuanLy, System.String noiDungCongViec, System.DateTime ngayThucHien, System.Int32 soPhut, System.String ghiChu, ref System.String reval)
		{
			 Update(transactionManager, 0, int.MaxValue , id, namHoc, hoKy, professorId, maHoatDongQuanLy, noiDungCongViec, ngayThucHien, soPhut, ghiChu, ref reval);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_Update' stored procedure. 
		/// </summary>
		/// <param name="id"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hoKy"> A <c>System.String</c> instance.</param>
		/// <param name="professorId"> A <c>System.String</c> instance.</param>
		/// <param name="maHoatDongQuanLy"> A <c>System.Int32</c> instance.</param>
		/// <param name="noiDungCongViec"> A <c>System.String</c> instance.</param>
		/// <param name="ngayThucHien"> A <c>System.DateTime</c> instance.</param>
		/// <param name="soPhut"> A <c>System.Int32</c> instance.</param>
		/// <param name="ghiChu"> A <c>System.String</c> instance.</param>
			/// <param name="reval"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Update(TransactionManager transactionManager, int start, int pageLength , System.Int32 id, System.String namHoc, System.String hoKy, System.String professorId, System.Int32 maHoatDongQuanLy, System.String noiDungCongViec, System.DateTime ngayThucHien, System.Int32 soPhut, System.String ghiChu, ref System.String reval);
		
		#endregion
		
		#region cust_GiangVienHoatDongQuanLy_Chot 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_Chot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="chot"> A <c>System.Boolean</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Chot(System.String namHoc, System.String hocKy, System.String maDonVi, System.Boolean chot, ref System.Int32 reVal)
		{
			 Chot(null, 0, int.MaxValue , namHoc, hocKy, maDonVi, chot, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_Chot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="chot"> A <c>System.Boolean</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Chot(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi, System.Boolean chot, ref System.Int32 reVal)
		{
			 Chot(null, start, pageLength , namHoc, hocKy, maDonVi, chot, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_Chot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="chot"> A <c>System.Boolean</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Chot(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi, System.Boolean chot, ref System.Int32 reVal)
		{
			 Chot(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi, chot, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_Chot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="chot"> A <c>System.Boolean</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Chot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi, System.Boolean chot, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_GiangVienHoatDongQuanLy_Delete 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_Delete' stored procedure. 
		/// </summary>
		/// <param name="id"> A <c>System.Int32</c> instance.</param>
			/// <param name="reval"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Delete(System.Int32 id, ref System.String reval)
		{
			 Delete(null, 0, int.MaxValue , id, ref reval);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_Delete' stored procedure. 
		/// </summary>
		/// <param name="id"> A <c>System.Int32</c> instance.</param>
			/// <param name="reval"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Delete(int start, int pageLength, System.Int32 id, ref System.String reval)
		{
			 Delete(null, start, pageLength , id, ref reval);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_Delete' stored procedure. 
		/// </summary>
		/// <param name="id"> A <c>System.Int32</c> instance.</param>
			/// <param name="reval"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Delete(TransactionManager transactionManager, System.Int32 id, ref System.String reval)
		{
			 Delete(transactionManager, 0, int.MaxValue , id, ref reval);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_Delete' stored procedure. 
		/// </summary>
		/// <param name="id"> A <c>System.Int32</c> instance.</param>
			/// <param name="reval"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Delete(TransactionManager transactionManager, int start, int pageLength , System.Int32 id, ref System.String reval);
		
		#endregion
		
		#region cust_GiangVienHoatDongQuanLy_GetByNamHocHocKyHoatDongKhoaDonVi 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_GetByNamHocHocKyHoatDongKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="idHoatDong"> A <c>System.Int32</c> instance.</param>
		/// <param name="maKhoaDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyHoatDongKhoaDonVi(System.String namHoc, System.String hocKy, System.Int32 idHoatDong, System.String maKhoaDonVi)
		{
			return GetByNamHocHocKyHoatDongKhoaDonVi(null, 0, int.MaxValue , namHoc, hocKy, idHoatDong, maKhoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_GetByNamHocHocKyHoatDongKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="idHoatDong"> A <c>System.Int32</c> instance.</param>
		/// <param name="maKhoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyHoatDongKhoaDonVi(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 idHoatDong, System.String maKhoaDonVi)
		{
			return GetByNamHocHocKyHoatDongKhoaDonVi(null, start, pageLength , namHoc, hocKy, idHoatDong, maKhoaDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_GetByNamHocHocKyHoatDongKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="idHoatDong"> A <c>System.Int32</c> instance.</param>
		/// <param name="maKhoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyHoatDongKhoaDonVi(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 idHoatDong, System.String maKhoaDonVi)
		{
			return GetByNamHocHocKyHoatDongKhoaDonVi(transactionManager, 0, int.MaxValue , namHoc, hocKy, idHoatDong, maKhoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_GetByNamHocHocKyHoatDongKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="idHoatDong"> A <c>System.Int32</c> instance.</param>
		/// <param name="maKhoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKyHoatDongKhoaDonVi(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 idHoatDong, System.String maKhoaDonVi);
		
		#endregion
		
		#region cust_GiangVienHoatDongQuanLy_KiemTraChot 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_KiemTraChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraChot(System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 KiemTraChot(null, 0, int.MaxValue , namHoc, hocKy, maDonVi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_KiemTraChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraChot(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 KiemTraChot(null, start, pageLength , namHoc, hocKy, maDonVi, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_KiemTraChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraChot(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 KiemTraChot(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_KiemTraChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void KiemTraChot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_GiangVienHoatDongQuanLy_GetById_Web 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_GetById_Web' stored procedure. 
		/// </summary>
		/// <param name="id"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetById_Web(System.Int32 id)
		{
			return GetById_Web(null, 0, int.MaxValue , id);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_GetById_Web' stored procedure. 
		/// </summary>
		/// <param name="id"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetById_Web(int start, int pageLength, System.Int32 id)
		{
			return GetById_Web(null, start, pageLength , id);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_GetById_Web' stored procedure. 
		/// </summary>
		/// <param name="id"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetById_Web(TransactionManager transactionManager, System.Int32 id)
		{
			return GetById_Web(transactionManager, 0, int.MaxValue , id);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_GetById_Web' stored procedure. 
		/// </summary>
		/// <param name="id"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetById_Web(TransactionManager transactionManager, int start, int pageLength , System.Int32 id);
		
		#endregion
		
		#region cust_GiangVienHoatDongQuanLy_GetByGiangVienNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_GetByGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="professorId"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByGiangVienNamHocHocKy(System.String professorId, System.String namHoc, System.String hocKy)
		{
			return GetByGiangVienNamHocHocKy(null, 0, int.MaxValue , professorId, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_GetByGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="professorId"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByGiangVienNamHocHocKy(int start, int pageLength, System.String professorId, System.String namHoc, System.String hocKy)
		{
			return GetByGiangVienNamHocHocKy(null, start, pageLength , professorId, namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_GetByGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="professorId"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByGiangVienNamHocHocKy(TransactionManager transactionManager, System.String professorId, System.String namHoc, System.String hocKy)
		{
			return GetByGiangVienNamHocHocKy(transactionManager, 0, int.MaxValue , professorId, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_GetByGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="professorId"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByGiangVienNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String professorId, System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_GiangVienHoatDongQuanLy_Insert 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_Insert' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hoKy"> A <c>System.String</c> instance.</param>
		/// <param name="professorId"> A <c>System.String</c> instance.</param>
		/// <param name="maHoatDongQuanLy"> A <c>System.Int32</c> instance.</param>
		/// <param name="noiDungCongViec"> A <c>System.String</c> instance.</param>
		/// <param name="ngayThucHien"> A <c>System.DateTime</c> instance.</param>
		/// <param name="soPhut"> A <c>System.Int32</c> instance.</param>
		/// <param name="ghiChu"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Insert(System.String namHoc, System.String hoKy, System.String professorId, System.Int32 maHoatDongQuanLy, System.String noiDungCongViec, System.DateTime ngayThucHien, System.Int32 soPhut, System.String ghiChu)
		{
			 Insert(null, 0, int.MaxValue , namHoc, hoKy, professorId, maHoatDongQuanLy, noiDungCongViec, ngayThucHien, soPhut, ghiChu);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_Insert' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hoKy"> A <c>System.String</c> instance.</param>
		/// <param name="professorId"> A <c>System.String</c> instance.</param>
		/// <param name="maHoatDongQuanLy"> A <c>System.Int32</c> instance.</param>
		/// <param name="noiDungCongViec"> A <c>System.String</c> instance.</param>
		/// <param name="ngayThucHien"> A <c>System.DateTime</c> instance.</param>
		/// <param name="soPhut"> A <c>System.Int32</c> instance.</param>
		/// <param name="ghiChu"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Insert(int start, int pageLength, System.String namHoc, System.String hoKy, System.String professorId, System.Int32 maHoatDongQuanLy, System.String noiDungCongViec, System.DateTime ngayThucHien, System.Int32 soPhut, System.String ghiChu)
		{
			 Insert(null, start, pageLength , namHoc, hoKy, professorId, maHoatDongQuanLy, noiDungCongViec, ngayThucHien, soPhut, ghiChu);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_Insert' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hoKy"> A <c>System.String</c> instance.</param>
		/// <param name="professorId"> A <c>System.String</c> instance.</param>
		/// <param name="maHoatDongQuanLy"> A <c>System.Int32</c> instance.</param>
		/// <param name="noiDungCongViec"> A <c>System.String</c> instance.</param>
		/// <param name="ngayThucHien"> A <c>System.DateTime</c> instance.</param>
		/// <param name="soPhut"> A <c>System.Int32</c> instance.</param>
		/// <param name="ghiChu"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Insert(TransactionManager transactionManager, System.String namHoc, System.String hoKy, System.String professorId, System.Int32 maHoatDongQuanLy, System.String noiDungCongViec, System.DateTime ngayThucHien, System.Int32 soPhut, System.String ghiChu)
		{
			 Insert(transactionManager, 0, int.MaxValue , namHoc, hoKy, professorId, maHoatDongQuanLy, noiDungCongViec, ngayThucHien, soPhut, ghiChu);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_Insert' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hoKy"> A <c>System.String</c> instance.</param>
		/// <param name="professorId"> A <c>System.String</c> instance.</param>
		/// <param name="maHoatDongQuanLy"> A <c>System.Int32</c> instance.</param>
		/// <param name="noiDungCongViec"> A <c>System.String</c> instance.</param>
		/// <param name="ngayThucHien"> A <c>System.DateTime</c> instance.</param>
		/// <param name="soPhut"> A <c>System.Int32</c> instance.</param>
		/// <param name="ghiChu"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Insert(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hoKy, System.String professorId, System.Int32 maHoatDongQuanLy, System.String noiDungCongViec, System.DateTime ngayThucHien, System.Int32 soPhut, System.String ghiChu);
		
		#endregion
		
		#region cust_GiangVienHoatDongQuanLy_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="retVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, System.String namHoc, System.String hocKy, System.String maKhoaDonVi, ref System.Int32 retVal)
		{
			 Luu(null, 0, int.MaxValue , xmlData, namHoc, hocKy, maKhoaDonVi, ref retVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="retVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, System.String maKhoaDonVi, ref System.Int32 retVal)
		{
			 Luu(null, start, pageLength , xmlData, namHoc, hocKy, maKhoaDonVi, ref retVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="retVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, System.String maKhoaDonVi, ref System.Int32 retVal)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, maKhoaDonVi, ref retVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienHoatDongQuanLy_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="retVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, System.String maKhoaDonVi, ref System.Int32 retVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GiangVienHoatDongQuanLy&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GiangVienHoatDongQuanLy&gt;"/></returns>
		public static TList<GiangVienHoatDongQuanLy> Fill(IDataReader reader, TList<GiangVienHoatDongQuanLy> rows, int start, int pageLength)
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
				
				PMS.Entities.GiangVienHoatDongQuanLy c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GiangVienHoatDongQuanLy")
					.Append("|").Append((System.Int32)reader[((int)GiangVienHoatDongQuanLyColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<GiangVienHoatDongQuanLy>(
					key.ToString(), // EntityTrackingKey
					"GiangVienHoatDongQuanLy",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.GiangVienHoatDongQuanLy();
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
					c.Id = (System.Int32)reader[(GiangVienHoatDongQuanLyColumn.Id.ToString())];
					c.NamHoc = (reader[GiangVienHoatDongQuanLyColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienHoatDongQuanLyColumn.NamHoc.ToString())];
					c.HocKy = (reader[GiangVienHoatDongQuanLyColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienHoatDongQuanLyColumn.HocKy.ToString())];
					c.MaGiangVien = (reader[GiangVienHoatDongQuanLyColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienHoatDongQuanLyColumn.MaGiangVien.ToString())];
					c.MaHoatDongQuanLy = (reader[GiangVienHoatDongQuanLyColumn.MaHoatDongQuanLy.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienHoatDongQuanLyColumn.MaHoatDongQuanLy.ToString())];
					c.SoTiet = (reader[GiangVienHoatDongQuanLyColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienHoatDongQuanLyColumn.SoTiet.ToString())];
					c.GhiChu = (reader[GiangVienHoatDongQuanLyColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienHoatDongQuanLyColumn.GhiChu.ToString())];
					c.Chot = (reader[GiangVienHoatDongQuanLyColumn.Chot.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(GiangVienHoatDongQuanLyColumn.Chot.ToString())];
					c.NoiDungCongViec = (reader[GiangVienHoatDongQuanLyColumn.NoiDungCongViec.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienHoatDongQuanLyColumn.NoiDungCongViec.ToString())];
					c.NgayThucHien = (reader[GiangVienHoatDongQuanLyColumn.NgayThucHien.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienHoatDongQuanLyColumn.NgayThucHien.ToString())];
					c.SoPhut = (reader[GiangVienHoatDongQuanLyColumn.SoPhut.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienHoatDongQuanLyColumn.SoPhut.ToString())];
					c.HeSoQuyDoi = (reader[GiangVienHoatDongQuanLyColumn.HeSoQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienHoatDongQuanLyColumn.HeSoQuyDoi.ToString())];
					c.XacNhan = (reader[GiangVienHoatDongQuanLyColumn.XacNhan.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(GiangVienHoatDongQuanLyColumn.XacNhan.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienHoatDongQuanLy"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienHoatDongQuanLy"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.GiangVienHoatDongQuanLy entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(GiangVienHoatDongQuanLyColumn.Id.ToString())];
			entity.NamHoc = (reader[GiangVienHoatDongQuanLyColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienHoatDongQuanLyColumn.NamHoc.ToString())];
			entity.HocKy = (reader[GiangVienHoatDongQuanLyColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienHoatDongQuanLyColumn.HocKy.ToString())];
			entity.MaGiangVien = (reader[GiangVienHoatDongQuanLyColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienHoatDongQuanLyColumn.MaGiangVien.ToString())];
			entity.MaHoatDongQuanLy = (reader[GiangVienHoatDongQuanLyColumn.MaHoatDongQuanLy.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienHoatDongQuanLyColumn.MaHoatDongQuanLy.ToString())];
			entity.SoTiet = (reader[GiangVienHoatDongQuanLyColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienHoatDongQuanLyColumn.SoTiet.ToString())];
			entity.GhiChu = (reader[GiangVienHoatDongQuanLyColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienHoatDongQuanLyColumn.GhiChu.ToString())];
			entity.Chot = (reader[GiangVienHoatDongQuanLyColumn.Chot.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(GiangVienHoatDongQuanLyColumn.Chot.ToString())];
			entity.NoiDungCongViec = (reader[GiangVienHoatDongQuanLyColumn.NoiDungCongViec.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienHoatDongQuanLyColumn.NoiDungCongViec.ToString())];
			entity.NgayThucHien = (reader[GiangVienHoatDongQuanLyColumn.NgayThucHien.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienHoatDongQuanLyColumn.NgayThucHien.ToString())];
			entity.SoPhut = (reader[GiangVienHoatDongQuanLyColumn.SoPhut.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienHoatDongQuanLyColumn.SoPhut.ToString())];
			entity.HeSoQuyDoi = (reader[GiangVienHoatDongQuanLyColumn.HeSoQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienHoatDongQuanLyColumn.HeSoQuyDoi.ToString())];
			entity.XacNhan = (reader[GiangVienHoatDongQuanLyColumn.XacNhan.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(GiangVienHoatDongQuanLyColumn.XacNhan.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienHoatDongQuanLy"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienHoatDongQuanLy"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.GiangVienHoatDongQuanLy entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.Int32?)dataRow["MaGiangVien"];
			entity.MaHoatDongQuanLy = Convert.IsDBNull(dataRow["MaHoatDongQuanLy"]) ? null : (System.Int32?)dataRow["MaHoatDongQuanLy"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Decimal?)dataRow["SoTiet"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.Chot = Convert.IsDBNull(dataRow["Chot"]) ? null : (System.Boolean?)dataRow["Chot"];
			entity.NoiDungCongViec = Convert.IsDBNull(dataRow["NoiDungCongViec"]) ? null : (System.String)dataRow["NoiDungCongViec"];
			entity.NgayThucHien = Convert.IsDBNull(dataRow["NgayThucHien"]) ? null : (System.DateTime?)dataRow["NgayThucHien"];
			entity.SoPhut = Convert.IsDBNull(dataRow["SoPhut"]) ? null : (System.Int32?)dataRow["SoPhut"];
			entity.HeSoQuyDoi = Convert.IsDBNull(dataRow["HeSoQuyDoi"]) ? null : (System.Decimal?)dataRow["HeSoQuyDoi"];
			entity.XacNhan = Convert.IsDBNull(dataRow["XacNhan"]) ? null : (System.Boolean?)dataRow["XacNhan"];
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
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienHoatDongQuanLy"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienHoatDongQuanLy Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.GiangVienHoatDongQuanLy entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaHoatDongQuanLySource	
			if (CanDeepLoad(entity, "DanhMucHoatDongQuanLy|MaHoatDongQuanLySource", deepLoadType, innerList) 
				&& entity.MaHoatDongQuanLySource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaHoatDongQuanLy ?? (int)0);
				DanhMucHoatDongQuanLy tmpEntity = EntityManager.LocateEntity<DanhMucHoatDongQuanLy>(EntityLocator.ConstructKeyFromPkItems(typeof(DanhMucHoatDongQuanLy), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaHoatDongQuanLySource = tmpEntity;
				else
					entity.MaHoatDongQuanLySource = DataRepository.DanhMucHoatDongQuanLyProvider.GetById(transactionManager, (entity.MaHoatDongQuanLy ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaHoatDongQuanLySource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaHoatDongQuanLySource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.DanhMucHoatDongQuanLyProvider.DeepLoad(transactionManager, entity.MaHoatDongQuanLySource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaHoatDongQuanLySource

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
		/// Deep Save the entire object graph of the PMS.Entities.GiangVienHoatDongQuanLy object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.GiangVienHoatDongQuanLy instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienHoatDongQuanLy Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.GiangVienHoatDongQuanLy entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaHoatDongQuanLySource
			if (CanDeepSave(entity, "DanhMucHoatDongQuanLy|MaHoatDongQuanLySource", deepSaveType, innerList) 
				&& entity.MaHoatDongQuanLySource != null)
			{
				DataRepository.DanhMucHoatDongQuanLyProvider.Save(transactionManager, entity.MaHoatDongQuanLySource);
				entity.MaHoatDongQuanLy = entity.MaHoatDongQuanLySource.Id;
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
	
	#region GiangVienHoatDongQuanLyChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.GiangVienHoatDongQuanLy</c>
	///</summary>
	public enum GiangVienHoatDongQuanLyChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>DanhMucHoatDongQuanLy</c> at MaHoatDongQuanLySource
		///</summary>
		[ChildEntityType(typeof(DanhMucHoatDongQuanLy))]
		DanhMucHoatDongQuanLy,
		
		///<summary>
		/// Composite Property for <c>GiangVien</c> at MaGiangVienSource
		///</summary>
		[ChildEntityType(typeof(GiangVien))]
		GiangVien,
	}
	
	#endregion GiangVienHoatDongQuanLyChildEntityTypes
	
	#region GiangVienHoatDongQuanLyFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GiangVienHoatDongQuanLyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienHoatDongQuanLy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienHoatDongQuanLyFilterBuilder : SqlFilterBuilder<GiangVienHoatDongQuanLyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienHoatDongQuanLyFilterBuilder class.
		/// </summary>
		public GiangVienHoatDongQuanLyFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienHoatDongQuanLyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienHoatDongQuanLyFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienHoatDongQuanLyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienHoatDongQuanLyFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienHoatDongQuanLyFilterBuilder
	
	#region GiangVienHoatDongQuanLyParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GiangVienHoatDongQuanLyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienHoatDongQuanLy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienHoatDongQuanLyParameterBuilder : ParameterizedSqlFilterBuilder<GiangVienHoatDongQuanLyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienHoatDongQuanLyParameterBuilder class.
		/// </summary>
		public GiangVienHoatDongQuanLyParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienHoatDongQuanLyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienHoatDongQuanLyParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienHoatDongQuanLyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienHoatDongQuanLyParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienHoatDongQuanLyParameterBuilder
	
	#region GiangVienHoatDongQuanLySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GiangVienHoatDongQuanLyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienHoatDongQuanLy"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GiangVienHoatDongQuanLySortBuilder : SqlSortBuilder<GiangVienHoatDongQuanLyColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienHoatDongQuanLySqlSortBuilder class.
		/// </summary>
		public GiangVienHoatDongQuanLySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GiangVienHoatDongQuanLySortBuilder
	
} // end namespace
