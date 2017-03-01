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
	/// This class is the base class for any <see cref="DinhMucGioChuanToiThieuTheoChucVuProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class DinhMucGioChuanToiThieuTheoChucVuProviderBaseCore : EntityProviderBase<PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu, PMS.Entities.DinhMucGioChuanToiThieuTheoChucVuKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.DinhMucGioChuanToiThieuTheoChucVuKey key)
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
		/// 	Gets rows from the datasource based on the FK_DinhMucGioChuanToiThieuTheoChucVu_ChucVu key.
		///		FK_DinhMucGioChuanToiThieuTheoChucVu_ChucVu Description: 
		/// </summary>
		/// <param name="_maChucVu"></param>
		/// <returns>Returns a typed collection of PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu objects.</returns>
		public TList<DinhMucGioChuanToiThieuTheoChucVu> GetByMaChucVu(System.Int32? _maChucVu)
		{
			int count = -1;
			return GetByMaChucVu(_maChucVu, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DinhMucGioChuanToiThieuTheoChucVu_ChucVu key.
		///		FK_DinhMucGioChuanToiThieuTheoChucVu_ChucVu Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maChucVu"></param>
		/// <returns>Returns a typed collection of PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu objects.</returns>
		/// <remarks></remarks>
		public TList<DinhMucGioChuanToiThieuTheoChucVu> GetByMaChucVu(TransactionManager transactionManager, System.Int32? _maChucVu)
		{
			int count = -1;
			return GetByMaChucVu(transactionManager, _maChucVu, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_DinhMucGioChuanToiThieuTheoChucVu_ChucVu key.
		///		FK_DinhMucGioChuanToiThieuTheoChucVu_ChucVu Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maChucVu"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu objects.</returns>
		public TList<DinhMucGioChuanToiThieuTheoChucVu> GetByMaChucVu(TransactionManager transactionManager, System.Int32? _maChucVu, int start, int pageLength)
		{
			int count = -1;
			return GetByMaChucVu(transactionManager, _maChucVu, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DinhMucGioChuanToiThieuTheoChucVu_ChucVu key.
		///		fkDinhMucGioChuanToiThieuTheoChucVuChucVu Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maChucVu"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu objects.</returns>
		public TList<DinhMucGioChuanToiThieuTheoChucVu> GetByMaChucVu(System.Int32? _maChucVu, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaChucVu(null, _maChucVu, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DinhMucGioChuanToiThieuTheoChucVu_ChucVu key.
		///		fkDinhMucGioChuanToiThieuTheoChucVuChucVu Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maChucVu"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu objects.</returns>
		public TList<DinhMucGioChuanToiThieuTheoChucVu> GetByMaChucVu(System.Int32? _maChucVu, int start, int pageLength,out int count)
		{
			return GetByMaChucVu(null, _maChucVu, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DinhMucGioChuanToiThieuTheoChucVu_ChucVu key.
		///		FK_DinhMucGioChuanToiThieuTheoChucVu_ChucVu Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maChucVu"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu objects.</returns>
		public abstract TList<DinhMucGioChuanToiThieuTheoChucVu> GetByMaChucVu(TransactionManager transactionManager, System.Int32? _maChucVu, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DinhMucGioChuanToiThieuTheoChucVu_DanhMucQuyMo key.
		///		FK_DinhMucGioChuanToiThieuTheoChucVu_DanhMucQuyMo Description: 
		/// </summary>
		/// <param name="_idQuyMo"></param>
		/// <returns>Returns a typed collection of PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu objects.</returns>
		public TList<DinhMucGioChuanToiThieuTheoChucVu> GetByIdQuyMo(System.Int32? _idQuyMo)
		{
			int count = -1;
			return GetByIdQuyMo(_idQuyMo, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DinhMucGioChuanToiThieuTheoChucVu_DanhMucQuyMo key.
		///		FK_DinhMucGioChuanToiThieuTheoChucVu_DanhMucQuyMo Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_idQuyMo"></param>
		/// <returns>Returns a typed collection of PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu objects.</returns>
		/// <remarks></remarks>
		public TList<DinhMucGioChuanToiThieuTheoChucVu> GetByIdQuyMo(TransactionManager transactionManager, System.Int32? _idQuyMo)
		{
			int count = -1;
			return GetByIdQuyMo(transactionManager, _idQuyMo, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_DinhMucGioChuanToiThieuTheoChucVu_DanhMucQuyMo key.
		///		FK_DinhMucGioChuanToiThieuTheoChucVu_DanhMucQuyMo Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_idQuyMo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu objects.</returns>
		public TList<DinhMucGioChuanToiThieuTheoChucVu> GetByIdQuyMo(TransactionManager transactionManager, System.Int32? _idQuyMo, int start, int pageLength)
		{
			int count = -1;
			return GetByIdQuyMo(transactionManager, _idQuyMo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DinhMucGioChuanToiThieuTheoChucVu_DanhMucQuyMo key.
		///		fkDinhMucGioChuanToiThieuTheoChucVuDanhMucQuyMo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_idQuyMo"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu objects.</returns>
		public TList<DinhMucGioChuanToiThieuTheoChucVu> GetByIdQuyMo(System.Int32? _idQuyMo, int start, int pageLength)
		{
			int count =  -1;
			return GetByIdQuyMo(null, _idQuyMo, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DinhMucGioChuanToiThieuTheoChucVu_DanhMucQuyMo key.
		///		fkDinhMucGioChuanToiThieuTheoChucVuDanhMucQuyMo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_idQuyMo"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu objects.</returns>
		public TList<DinhMucGioChuanToiThieuTheoChucVu> GetByIdQuyMo(System.Int32? _idQuyMo, int start, int pageLength,out int count)
		{
			return GetByIdQuyMo(null, _idQuyMo, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DinhMucGioChuanToiThieuTheoChucVu_DanhMucQuyMo key.
		///		FK_DinhMucGioChuanToiThieuTheoChucVu_DanhMucQuyMo Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_idQuyMo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu objects.</returns>
		public abstract TList<DinhMucGioChuanToiThieuTheoChucVu> GetByIdQuyMo(TransactionManager transactionManager, System.Int32? _idQuyMo, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu Get(TransactionManager transactionManager, PMS.Entities.DinhMucGioChuanToiThieuTheoChucVuKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_DinhMucGioChuanToiThieuTheoChucVu index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu"/> class.</returns>
		public PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DinhMucGioChuanToiThieuTheoChucVu index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu"/> class.</returns>
		public PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DinhMucGioChuanToiThieuTheoChucVu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu"/> class.</returns>
		public PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DinhMucGioChuanToiThieuTheoChucVu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu"/> class.</returns>
		public PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DinhMucGioChuanToiThieuTheoChucVu index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu"/> class.</returns>
		public PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DinhMucGioChuanToiThieuTheoChucVu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu"/> class.</returns>
		public abstract PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_DinhMucGioChuanToiThieuTheoChucVu_SaoChepTheoNam 
		
		/// <summary>
		///	This method wrap the 'cust_DinhMucGioChuanToiThieuTheoChucVu_SaoChepTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHocNguon"> A <c>System.String</c> instance.</param>
		/// <param name="namHocDich"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void SaoChepTheoNam(System.String namHocNguon, System.String namHocDich)
		{
			 SaoChepTheoNam(null, 0, int.MaxValue , namHocNguon, namHocDich);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DinhMucGioChuanToiThieuTheoChucVu_SaoChepTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHocNguon"> A <c>System.String</c> instance.</param>
		/// <param name="namHocDich"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void SaoChepTheoNam(int start, int pageLength, System.String namHocNguon, System.String namHocDich)
		{
			 SaoChepTheoNam(null, start, pageLength , namHocNguon, namHocDich);
		}
				
		/// <summary>
		///	This method wrap the 'cust_DinhMucGioChuanToiThieuTheoChucVu_SaoChepTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHocNguon"> A <c>System.String</c> instance.</param>
		/// <param name="namHocDich"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void SaoChepTheoNam(TransactionManager transactionManager, System.String namHocNguon, System.String namHocDich)
		{
			 SaoChepTheoNam(transactionManager, 0, int.MaxValue , namHocNguon, namHocDich);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DinhMucGioChuanToiThieuTheoChucVu_SaoChepTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHocNguon"> A <c>System.String</c> instance.</param>
		/// <param name="namHocDich"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void SaoChepTheoNam(TransactionManager transactionManager, int start, int pageLength , System.String namHocNguon, System.String namHocDich);
		
		#endregion
		
		#region cust_DinhMucGioChuanToiThieuTheoChucVu_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_DinhMucGioChuanToiThieuTheoChucVu_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;DinhMucGioChuanToiThieuTheoChucVu&gt;"/> instance.</returns>
		public TList<DinhMucGioChuanToiThieuTheoChucVu> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DinhMucGioChuanToiThieuTheoChucVu_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;DinhMucGioChuanToiThieuTheoChucVu&gt;"/> instance.</returns>
		public TList<DinhMucGioChuanToiThieuTheoChucVu> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_DinhMucGioChuanToiThieuTheoChucVu_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;DinhMucGioChuanToiThieuTheoChucVu&gt;"/> instance.</returns>
		public TList<DinhMucGioChuanToiThieuTheoChucVu> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DinhMucGioChuanToiThieuTheoChucVu_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;DinhMucGioChuanToiThieuTheoChucVu&gt;"/> instance.</returns>
		public abstract TList<DinhMucGioChuanToiThieuTheoChucVu> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_DinhMucGioChuanToiThieuTheoChucVu_GetByNamHoc 
		
		/// <summary>
		///	This method wrap the 'cust_DinhMucGioChuanToiThieuTheoChucVu_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;DinhMucGioChuanToiThieuTheoChucVu&gt;"/> instance.</returns>
		public TList<DinhMucGioChuanToiThieuTheoChucVu> GetByNamHoc(System.String namHoc)
		{
			return GetByNamHoc(null, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DinhMucGioChuanToiThieuTheoChucVu_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;DinhMucGioChuanToiThieuTheoChucVu&gt;"/> instance.</returns>
		public TList<DinhMucGioChuanToiThieuTheoChucVu> GetByNamHoc(int start, int pageLength, System.String namHoc)
		{
			return GetByNamHoc(null, start, pageLength , namHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_DinhMucGioChuanToiThieuTheoChucVu_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;DinhMucGioChuanToiThieuTheoChucVu&gt;"/> instance.</returns>
		public TList<DinhMucGioChuanToiThieuTheoChucVu> GetByNamHoc(TransactionManager transactionManager, System.String namHoc)
		{
			return GetByNamHoc(transactionManager, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DinhMucGioChuanToiThieuTheoChucVu_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;DinhMucGioChuanToiThieuTheoChucVu&gt;"/> instance.</returns>
		public abstract TList<DinhMucGioChuanToiThieuTheoChucVu> GetByNamHoc(TransactionManager transactionManager, int start, int pageLength , System.String namHoc);
		
		#endregion
		
		#region cust_DinhMucGioChuanToiThieuTheoChucVu_SaoChep 
		
		/// <summary>
		///	This method wrap the 'cust_DinhMucGioChuanToiThieuTheoChucVu_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_DinhMucGioChuanToiThieuTheoChucVu_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_DinhMucGioChuanToiThieuTheoChucVu_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_DinhMucGioChuanToiThieuTheoChucVu_SaoChep' stored procedure. 
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
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;DinhMucGioChuanToiThieuTheoChucVu&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;DinhMucGioChuanToiThieuTheoChucVu&gt;"/></returns>
		public static TList<DinhMucGioChuanToiThieuTheoChucVu> Fill(IDataReader reader, TList<DinhMucGioChuanToiThieuTheoChucVu> rows, int start, int pageLength)
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
				
				PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("DinhMucGioChuanToiThieuTheoChucVu")
					.Append("|").Append((System.Int32)reader[((int)DinhMucGioChuanToiThieuTheoChucVuColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<DinhMucGioChuanToiThieuTheoChucVu>(
					key.ToString(), // EntityTrackingKey
					"DinhMucGioChuanToiThieuTheoChucVu",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu();
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
					c.Id = (System.Int32)reader[(DinhMucGioChuanToiThieuTheoChucVuColumn.Id.ToString())];
					c.MaChucVu = (reader[DinhMucGioChuanToiThieuTheoChucVuColumn.MaChucVu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DinhMucGioChuanToiThieuTheoChucVuColumn.MaChucVu.ToString())];
					c.PhanTramGiamTru = (reader[DinhMucGioChuanToiThieuTheoChucVuColumn.PhanTramGiamTru.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DinhMucGioChuanToiThieuTheoChucVuColumn.PhanTramGiamTru.ToString())];
					c.NamHoc = (reader[DinhMucGioChuanToiThieuTheoChucVuColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DinhMucGioChuanToiThieuTheoChucVuColumn.NamHoc.ToString())];
					c.HocKy = (reader[DinhMucGioChuanToiThieuTheoChucVuColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(DinhMucGioChuanToiThieuTheoChucVuColumn.HocKy.ToString())];
					c.NgayCapNhat = (reader[DinhMucGioChuanToiThieuTheoChucVuColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(DinhMucGioChuanToiThieuTheoChucVuColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[DinhMucGioChuanToiThieuTheoChucVuColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(DinhMucGioChuanToiThieuTheoChucVuColumn.NguoiCapNhat.ToString())];
					c.SoTietNghiaVu = (reader[DinhMucGioChuanToiThieuTheoChucVuColumn.SoTietNghiaVu.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DinhMucGioChuanToiThieuTheoChucVuColumn.SoTietNghiaVu.ToString())];
					c.NhomGiangVien = (reader[DinhMucGioChuanToiThieuTheoChucVuColumn.NhomGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DinhMucGioChuanToiThieuTheoChucVuColumn.NhomGiangVien.ToString())];
					c.IdQuyMo = (reader[DinhMucGioChuanToiThieuTheoChucVuColumn.IdQuyMo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DinhMucGioChuanToiThieuTheoChucVuColumn.IdQuyMo.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(DinhMucGioChuanToiThieuTheoChucVuColumn.Id.ToString())];
			entity.MaChucVu = (reader[DinhMucGioChuanToiThieuTheoChucVuColumn.MaChucVu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DinhMucGioChuanToiThieuTheoChucVuColumn.MaChucVu.ToString())];
			entity.PhanTramGiamTru = (reader[DinhMucGioChuanToiThieuTheoChucVuColumn.PhanTramGiamTru.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DinhMucGioChuanToiThieuTheoChucVuColumn.PhanTramGiamTru.ToString())];
			entity.NamHoc = (reader[DinhMucGioChuanToiThieuTheoChucVuColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DinhMucGioChuanToiThieuTheoChucVuColumn.NamHoc.ToString())];
			entity.HocKy = (reader[DinhMucGioChuanToiThieuTheoChucVuColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(DinhMucGioChuanToiThieuTheoChucVuColumn.HocKy.ToString())];
			entity.NgayCapNhat = (reader[DinhMucGioChuanToiThieuTheoChucVuColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(DinhMucGioChuanToiThieuTheoChucVuColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[DinhMucGioChuanToiThieuTheoChucVuColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(DinhMucGioChuanToiThieuTheoChucVuColumn.NguoiCapNhat.ToString())];
			entity.SoTietNghiaVu = (reader[DinhMucGioChuanToiThieuTheoChucVuColumn.SoTietNghiaVu.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DinhMucGioChuanToiThieuTheoChucVuColumn.SoTietNghiaVu.ToString())];
			entity.NhomGiangVien = (reader[DinhMucGioChuanToiThieuTheoChucVuColumn.NhomGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DinhMucGioChuanToiThieuTheoChucVuColumn.NhomGiangVien.ToString())];
			entity.IdQuyMo = (reader[DinhMucGioChuanToiThieuTheoChucVuColumn.IdQuyMo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DinhMucGioChuanToiThieuTheoChucVuColumn.IdQuyMo.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaChucVu = Convert.IsDBNull(dataRow["MaChucVu"]) ? null : (System.Int32?)dataRow["MaChucVu"];
			entity.PhanTramGiamTru = Convert.IsDBNull(dataRow["PhanTramGiamTru"]) ? null : (System.Decimal?)dataRow["PhanTramGiamTru"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.SoTietNghiaVu = Convert.IsDBNull(dataRow["SoTietNghiaVu"]) ? null : (System.Decimal?)dataRow["SoTietNghiaVu"];
			entity.NhomGiangVien = Convert.IsDBNull(dataRow["NhomGiangVien"]) ? null : (System.Int32?)dataRow["NhomGiangVien"];
			entity.IdQuyMo = Convert.IsDBNull(dataRow["IdQuyMo"]) ? null : (System.Int32?)dataRow["IdQuyMo"];
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
		/// <param name="entity">The <see cref="PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaChucVuSource	
			if (CanDeepLoad(entity, "ChucVu|MaChucVuSource", deepLoadType, innerList) 
				&& entity.MaChucVuSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaChucVu ?? (int)0);
				ChucVu tmpEntity = EntityManager.LocateEntity<ChucVu>(EntityLocator.ConstructKeyFromPkItems(typeof(ChucVu), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaChucVuSource = tmpEntity;
				else
					entity.MaChucVuSource = DataRepository.ChucVuProvider.GetByMaChucVu(transactionManager, (entity.MaChucVu ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaChucVuSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaChucVuSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ChucVuProvider.DeepLoad(transactionManager, entity.MaChucVuSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaChucVuSource

			#region IdQuyMoSource	
			if (CanDeepLoad(entity, "DanhMucQuyMo|IdQuyMoSource", deepLoadType, innerList) 
				&& entity.IdQuyMoSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.IdQuyMo ?? (int)0);
				DanhMucQuyMo tmpEntity = EntityManager.LocateEntity<DanhMucQuyMo>(EntityLocator.ConstructKeyFromPkItems(typeof(DanhMucQuyMo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.IdQuyMoSource = tmpEntity;
				else
					entity.IdQuyMoSource = DataRepository.DanhMucQuyMoProvider.GetById(transactionManager, (entity.IdQuyMo ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'IdQuyMoSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.IdQuyMoSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.DanhMucQuyMoProvider.DeepLoad(transactionManager, entity.IdQuyMoSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion IdQuyMoSource
			
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
		/// Deep Save the entire object graph of the PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaChucVuSource
			if (CanDeepSave(entity, "ChucVu|MaChucVuSource", deepSaveType, innerList) 
				&& entity.MaChucVuSource != null)
			{
				DataRepository.ChucVuProvider.Save(transactionManager, entity.MaChucVuSource);
				entity.MaChucVu = entity.MaChucVuSource.MaChucVu;
			}
			#endregion 
			
			#region IdQuyMoSource
			if (CanDeepSave(entity, "DanhMucQuyMo|IdQuyMoSource", deepSaveType, innerList) 
				&& entity.IdQuyMoSource != null)
			{
				DataRepository.DanhMucQuyMoProvider.Save(transactionManager, entity.IdQuyMoSource);
				entity.IdQuyMo = entity.IdQuyMoSource.Id;
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
	
	#region DinhMucGioChuanToiThieuTheoChucVuChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.DinhMucGioChuanToiThieuTheoChucVu</c>
	///</summary>
	public enum DinhMucGioChuanToiThieuTheoChucVuChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>ChucVu</c> at MaChucVuSource
		///</summary>
		[ChildEntityType(typeof(ChucVu))]
		ChucVu,
		
		///<summary>
		/// Composite Property for <c>DanhMucQuyMo</c> at IdQuyMoSource
		///</summary>
		[ChildEntityType(typeof(DanhMucQuyMo))]
		DanhMucQuyMo,
	}
	
	#endregion DinhMucGioChuanToiThieuTheoChucVuChildEntityTypes
	
	#region DinhMucGioChuanToiThieuTheoChucVuFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;DinhMucGioChuanToiThieuTheoChucVuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DinhMucGioChuanToiThieuTheoChucVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DinhMucGioChuanToiThieuTheoChucVuFilterBuilder : SqlFilterBuilder<DinhMucGioChuanToiThieuTheoChucVuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DinhMucGioChuanToiThieuTheoChucVuFilterBuilder class.
		/// </summary>
		public DinhMucGioChuanToiThieuTheoChucVuFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DinhMucGioChuanToiThieuTheoChucVuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DinhMucGioChuanToiThieuTheoChucVuFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DinhMucGioChuanToiThieuTheoChucVuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DinhMucGioChuanToiThieuTheoChucVuFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DinhMucGioChuanToiThieuTheoChucVuFilterBuilder
	
	#region DinhMucGioChuanToiThieuTheoChucVuParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;DinhMucGioChuanToiThieuTheoChucVuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DinhMucGioChuanToiThieuTheoChucVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DinhMucGioChuanToiThieuTheoChucVuParameterBuilder : ParameterizedSqlFilterBuilder<DinhMucGioChuanToiThieuTheoChucVuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DinhMucGioChuanToiThieuTheoChucVuParameterBuilder class.
		/// </summary>
		public DinhMucGioChuanToiThieuTheoChucVuParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DinhMucGioChuanToiThieuTheoChucVuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DinhMucGioChuanToiThieuTheoChucVuParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DinhMucGioChuanToiThieuTheoChucVuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DinhMucGioChuanToiThieuTheoChucVuParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DinhMucGioChuanToiThieuTheoChucVuParameterBuilder
	
	#region DinhMucGioChuanToiThieuTheoChucVuSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;DinhMucGioChuanToiThieuTheoChucVuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DinhMucGioChuanToiThieuTheoChucVu"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class DinhMucGioChuanToiThieuTheoChucVuSortBuilder : SqlSortBuilder<DinhMucGioChuanToiThieuTheoChucVuColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DinhMucGioChuanToiThieuTheoChucVuSqlSortBuilder class.
		/// </summary>
		public DinhMucGioChuanToiThieuTheoChucVuSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion DinhMucGioChuanToiThieuTheoChucVuSortBuilder
	
} // end namespace
