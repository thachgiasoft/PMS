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
	/// This class is the base class for any <see cref="QuyDinhTienCanTrenProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class QuyDinhTienCanTrenProviderBaseCore : EntityProviderBase<PMS.Entities.QuyDinhTienCanTren, PMS.Entities.QuyDinhTienCanTrenKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.QuyDinhTienCanTrenKey key)
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
		/// 	Gets rows from the datasource based on the FK_QDTCT_HH key.
		///		FK_QDTCT_HH Description: 
		/// </summary>
		/// <param name="_maHocHam"></param>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDinhTienCanTren objects.</returns>
		public TList<QuyDinhTienCanTren> GetByMaHocHam(System.Int32? _maHocHam)
		{
			int count = -1;
			return GetByMaHocHam(_maHocHam, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QDTCT_HH key.
		///		FK_QDTCT_HH Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocHam"></param>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDinhTienCanTren objects.</returns>
		/// <remarks></remarks>
		public TList<QuyDinhTienCanTren> GetByMaHocHam(TransactionManager transactionManager, System.Int32? _maHocHam)
		{
			int count = -1;
			return GetByMaHocHam(transactionManager, _maHocHam, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_QDTCT_HH key.
		///		FK_QDTCT_HH Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocHam"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDinhTienCanTren objects.</returns>
		public TList<QuyDinhTienCanTren> GetByMaHocHam(TransactionManager transactionManager, System.Int32? _maHocHam, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHocHam(transactionManager, _maHocHam, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QDTCT_HH key.
		///		fkQdtctHh Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maHocHam"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDinhTienCanTren objects.</returns>
		public TList<QuyDinhTienCanTren> GetByMaHocHam(System.Int32? _maHocHam, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaHocHam(null, _maHocHam, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QDTCT_HH key.
		///		fkQdtctHh Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maHocHam"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDinhTienCanTren objects.</returns>
		public TList<QuyDinhTienCanTren> GetByMaHocHam(System.Int32? _maHocHam, int start, int pageLength,out int count)
		{
			return GetByMaHocHam(null, _maHocHam, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QDTCT_HH key.
		///		FK_QDTCT_HH Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocHam"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDinhTienCanTren objects.</returns>
		public abstract TList<QuyDinhTienCanTren> GetByMaHocHam(TransactionManager transactionManager, System.Int32? _maHocHam, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QDTCT_HV key.
		///		FK_QDTCT_HV Description: 
		/// </summary>
		/// <param name="_maHocVi"></param>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDinhTienCanTren objects.</returns>
		public TList<QuyDinhTienCanTren> GetByMaHocVi(System.Int32? _maHocVi)
		{
			int count = -1;
			return GetByMaHocVi(_maHocVi, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QDTCT_HV key.
		///		FK_QDTCT_HV Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocVi"></param>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDinhTienCanTren objects.</returns>
		/// <remarks></remarks>
		public TList<QuyDinhTienCanTren> GetByMaHocVi(TransactionManager transactionManager, System.Int32? _maHocVi)
		{
			int count = -1;
			return GetByMaHocVi(transactionManager, _maHocVi, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_QDTCT_HV key.
		///		FK_QDTCT_HV Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocVi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDinhTienCanTren objects.</returns>
		public TList<QuyDinhTienCanTren> GetByMaHocVi(TransactionManager transactionManager, System.Int32? _maHocVi, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHocVi(transactionManager, _maHocVi, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QDTCT_HV key.
		///		fkQdtctHv Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maHocVi"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDinhTienCanTren objects.</returns>
		public TList<QuyDinhTienCanTren> GetByMaHocVi(System.Int32? _maHocVi, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaHocVi(null, _maHocVi, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QDTCT_HV key.
		///		fkQdtctHv Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maHocVi"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDinhTienCanTren objects.</returns>
		public TList<QuyDinhTienCanTren> GetByMaHocVi(System.Int32? _maHocVi, int start, int pageLength,out int count)
		{
			return GetByMaHocVi(null, _maHocVi, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QDTCT_HV key.
		///		FK_QDTCT_HV Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocVi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDinhTienCanTren objects.</returns>
		public abstract TList<QuyDinhTienCanTren> GetByMaHocVi(TransactionManager transactionManager, System.Int32? _maHocVi, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QDTCT_LGV key.
		///		FK_QDTCT_LGV Description: 
		/// </summary>
		/// <param name="_maLoaiGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDinhTienCanTren objects.</returns>
		public TList<QuyDinhTienCanTren> GetByMaLoaiGiangVien(System.Int32? _maLoaiGiangVien)
		{
			int count = -1;
			return GetByMaLoaiGiangVien(_maLoaiGiangVien, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QDTCT_LGV key.
		///		FK_QDTCT_LGV Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDinhTienCanTren objects.</returns>
		/// <remarks></remarks>
		public TList<QuyDinhTienCanTren> GetByMaLoaiGiangVien(TransactionManager transactionManager, System.Int32? _maLoaiGiangVien)
		{
			int count = -1;
			return GetByMaLoaiGiangVien(transactionManager, _maLoaiGiangVien, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_QDTCT_LGV key.
		///		FK_QDTCT_LGV Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDinhTienCanTren objects.</returns>
		public TList<QuyDinhTienCanTren> GetByMaLoaiGiangVien(TransactionManager transactionManager, System.Int32? _maLoaiGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLoaiGiangVien(transactionManager, _maLoaiGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QDTCT_LGV key.
		///		fkQdtctLgv Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maLoaiGiangVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDinhTienCanTren objects.</returns>
		public TList<QuyDinhTienCanTren> GetByMaLoaiGiangVien(System.Int32? _maLoaiGiangVien, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaLoaiGiangVien(null, _maLoaiGiangVien, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QDTCT_LGV key.
		///		fkQdtctLgv Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maLoaiGiangVien"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDinhTienCanTren objects.</returns>
		public TList<QuyDinhTienCanTren> GetByMaLoaiGiangVien(System.Int32? _maLoaiGiangVien, int start, int pageLength,out int count)
		{
			return GetByMaLoaiGiangVien(null, _maLoaiGiangVien, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QDTCT_LGV key.
		///		FK_QDTCT_LGV Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDinhTienCanTren objects.</returns>
		public abstract TList<QuyDinhTienCanTren> GetByMaLoaiGiangVien(TransactionManager transactionManager, System.Int32? _maLoaiGiangVien, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QDTCT_LNV key.
		///		FK_QDTCT_LNV Description: 
		/// </summary>
		/// <param name="_maLoaiNhanVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDinhTienCanTren objects.</returns>
		public TList<QuyDinhTienCanTren> GetByMaLoaiNhanVien(System.Int32? _maLoaiNhanVien)
		{
			int count = -1;
			return GetByMaLoaiNhanVien(_maLoaiNhanVien, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QDTCT_LNV key.
		///		FK_QDTCT_LNV Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiNhanVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDinhTienCanTren objects.</returns>
		/// <remarks></remarks>
		public TList<QuyDinhTienCanTren> GetByMaLoaiNhanVien(TransactionManager transactionManager, System.Int32? _maLoaiNhanVien)
		{
			int count = -1;
			return GetByMaLoaiNhanVien(transactionManager, _maLoaiNhanVien, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_QDTCT_LNV key.
		///		FK_QDTCT_LNV Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiNhanVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDinhTienCanTren objects.</returns>
		public TList<QuyDinhTienCanTren> GetByMaLoaiNhanVien(TransactionManager transactionManager, System.Int32? _maLoaiNhanVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLoaiNhanVien(transactionManager, _maLoaiNhanVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QDTCT_LNV key.
		///		fkQdtctLnv Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maLoaiNhanVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDinhTienCanTren objects.</returns>
		public TList<QuyDinhTienCanTren> GetByMaLoaiNhanVien(System.Int32? _maLoaiNhanVien, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaLoaiNhanVien(null, _maLoaiNhanVien, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QDTCT_LNV key.
		///		fkQdtctLnv Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maLoaiNhanVien"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDinhTienCanTren objects.</returns>
		public TList<QuyDinhTienCanTren> GetByMaLoaiNhanVien(System.Int32? _maLoaiNhanVien, int start, int pageLength,out int count)
		{
			return GetByMaLoaiNhanVien(null, _maLoaiNhanVien, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QDTCT_LNV key.
		///		FK_QDTCT_LNV Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiNhanVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDinhTienCanTren objects.</returns>
		public abstract TList<QuyDinhTienCanTren> GetByMaLoaiNhanVien(TransactionManager transactionManager, System.Int32? _maLoaiNhanVien, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.QuyDinhTienCanTren Get(TransactionManager transactionManager, PMS.Entities.QuyDinhTienCanTrenKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK__QuyDinhT__3214EC2784901242 index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyDinhTienCanTren"/> class.</returns>
		public PMS.Entities.QuyDinhTienCanTren GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__QuyDinhT__3214EC2784901242 index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyDinhTienCanTren"/> class.</returns>
		public PMS.Entities.QuyDinhTienCanTren GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__QuyDinhT__3214EC2784901242 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyDinhTienCanTren"/> class.</returns>
		public PMS.Entities.QuyDinhTienCanTren GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__QuyDinhT__3214EC2784901242 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyDinhTienCanTren"/> class.</returns>
		public PMS.Entities.QuyDinhTienCanTren GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__QuyDinhT__3214EC2784901242 index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyDinhTienCanTren"/> class.</returns>
		public PMS.Entities.QuyDinhTienCanTren GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__QuyDinhT__3214EC2784901242 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyDinhTienCanTren"/> class.</returns>
		public abstract PMS.Entities.QuyDinhTienCanTren GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_QuyDinhTienCanTren_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_QuyDinhTienCanTren_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;QuyDinhTienCanTren&gt;"/> instance.</returns>
		public TList<QuyDinhTienCanTren> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_QuyDinhTienCanTren_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;QuyDinhTienCanTren&gt;"/> instance.</returns>
		public TList<QuyDinhTienCanTren> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_QuyDinhTienCanTren_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;QuyDinhTienCanTren&gt;"/> instance.</returns>
		public TList<QuyDinhTienCanTren> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_QuyDinhTienCanTren_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;QuyDinhTienCanTren&gt;"/> instance.</returns>
		public abstract TList<QuyDinhTienCanTren> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_QuyDinhTienCanTren_SaoChep 
		
		/// <summary>
		///	This method wrap the 'cust_QuyDinhTienCanTren_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_QuyDinhTienCanTren_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_QuyDinhTienCanTren_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_QuyDinhTienCanTren_SaoChep' stored procedure. 
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
		/// Fill a TList&lt;QuyDinhTienCanTren&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;QuyDinhTienCanTren&gt;"/></returns>
		public static TList<QuyDinhTienCanTren> Fill(IDataReader reader, TList<QuyDinhTienCanTren> rows, int start, int pageLength)
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
				
				PMS.Entities.QuyDinhTienCanTren c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("QuyDinhTienCanTren")
					.Append("|").Append((System.Int32)reader[((int)QuyDinhTienCanTrenColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<QuyDinhTienCanTren>(
					key.ToString(), // EntityTrackingKey
					"QuyDinhTienCanTren",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.QuyDinhTienCanTren();
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
					c.Id = (System.Int32)reader[(QuyDinhTienCanTrenColumn.Id.ToString())];
					c.Stt = (reader[QuyDinhTienCanTrenColumn.Stt.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(QuyDinhTienCanTrenColumn.Stt.ToString())];
					c.NamHoc = (reader[QuyDinhTienCanTrenColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyDinhTienCanTrenColumn.NamHoc.ToString())];
					c.HocKy = (reader[QuyDinhTienCanTrenColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyDinhTienCanTrenColumn.HocKy.ToString())];
					c.MaHocHam = (reader[QuyDinhTienCanTrenColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(QuyDinhTienCanTrenColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[QuyDinhTienCanTrenColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(QuyDinhTienCanTrenColumn.MaHocVi.ToString())];
					c.MaLoaiNhanVien = (reader[QuyDinhTienCanTrenColumn.MaLoaiNhanVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(QuyDinhTienCanTrenColumn.MaLoaiNhanVien.ToString())];
					c.MaLoaiGiangVien = (reader[QuyDinhTienCanTrenColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(QuyDinhTienCanTrenColumn.MaLoaiGiangVien.ToString())];
					c.TienCanTren = (reader[QuyDinhTienCanTrenColumn.TienCanTren.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDinhTienCanTrenColumn.TienCanTren.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.QuyDinhTienCanTren"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.QuyDinhTienCanTren"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.QuyDinhTienCanTren entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(QuyDinhTienCanTrenColumn.Id.ToString())];
			entity.Stt = (reader[QuyDinhTienCanTrenColumn.Stt.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(QuyDinhTienCanTrenColumn.Stt.ToString())];
			entity.NamHoc = (reader[QuyDinhTienCanTrenColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyDinhTienCanTrenColumn.NamHoc.ToString())];
			entity.HocKy = (reader[QuyDinhTienCanTrenColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyDinhTienCanTrenColumn.HocKy.ToString())];
			entity.MaHocHam = (reader[QuyDinhTienCanTrenColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(QuyDinhTienCanTrenColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[QuyDinhTienCanTrenColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(QuyDinhTienCanTrenColumn.MaHocVi.ToString())];
			entity.MaLoaiNhanVien = (reader[QuyDinhTienCanTrenColumn.MaLoaiNhanVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(QuyDinhTienCanTrenColumn.MaLoaiNhanVien.ToString())];
			entity.MaLoaiGiangVien = (reader[QuyDinhTienCanTrenColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(QuyDinhTienCanTrenColumn.MaLoaiGiangVien.ToString())];
			entity.TienCanTren = (reader[QuyDinhTienCanTrenColumn.TienCanTren.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDinhTienCanTrenColumn.TienCanTren.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.QuyDinhTienCanTren"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.QuyDinhTienCanTren"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.QuyDinhTienCanTren entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["ID"];
			entity.Stt = Convert.IsDBNull(dataRow["STT"]) ? null : (System.Int32?)dataRow["STT"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
			entity.MaLoaiNhanVien = Convert.IsDBNull(dataRow["MaLoaiNhanVien"]) ? null : (System.Int32?)dataRow["MaLoaiNhanVien"];
			entity.MaLoaiGiangVien = Convert.IsDBNull(dataRow["MaLoaiGiangVien"]) ? null : (System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.TienCanTren = Convert.IsDBNull(dataRow["TienCanTren"]) ? null : (System.Decimal?)dataRow["TienCanTren"];
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
		/// <param name="entity">The <see cref="PMS.Entities.QuyDinhTienCanTren"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.QuyDinhTienCanTren Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.QuyDinhTienCanTren entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region MaLoaiNhanVienSource	
			if (CanDeepLoad(entity, "LoaiNhanVien|MaLoaiNhanVienSource", deepLoadType, innerList) 
				&& entity.MaLoaiNhanVienSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaLoaiNhanVien ?? (int)0);
				LoaiNhanVien tmpEntity = EntityManager.LocateEntity<LoaiNhanVien>(EntityLocator.ConstructKeyFromPkItems(typeof(LoaiNhanVien), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaLoaiNhanVienSource = tmpEntity;
				else
					entity.MaLoaiNhanVienSource = DataRepository.LoaiNhanVienProvider.GetByMaLoaiNhanVien(transactionManager, (entity.MaLoaiNhanVien ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaLoaiNhanVienSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaLoaiNhanVienSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.LoaiNhanVienProvider.DeepLoad(transactionManager, entity.MaLoaiNhanVienSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaLoaiNhanVienSource
			
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
		/// Deep Save the entire object graph of the PMS.Entities.QuyDinhTienCanTren object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.QuyDinhTienCanTren instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.QuyDinhTienCanTren Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.QuyDinhTienCanTren entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
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
			
			#region MaLoaiNhanVienSource
			if (CanDeepSave(entity, "LoaiNhanVien|MaLoaiNhanVienSource", deepSaveType, innerList) 
				&& entity.MaLoaiNhanVienSource != null)
			{
				DataRepository.LoaiNhanVienProvider.Save(transactionManager, entity.MaLoaiNhanVienSource);
				entity.MaLoaiNhanVien = entity.MaLoaiNhanVienSource.MaLoaiNhanVien;
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
	
	#region QuyDinhTienCanTrenChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.QuyDinhTienCanTren</c>
	///</summary>
	public enum QuyDinhTienCanTrenChildEntityTypes
	{
		
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
		/// Composite Property for <c>LoaiNhanVien</c> at MaLoaiNhanVienSource
		///</summary>
		[ChildEntityType(typeof(LoaiNhanVien))]
		LoaiNhanVien,
	}
	
	#endregion QuyDinhTienCanTrenChildEntityTypes
	
	#region QuyDinhTienCanTrenFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;QuyDinhTienCanTrenColumn&gt;"/> class
	/// that is used exclusively with a <see cref="QuyDinhTienCanTren"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class QuyDinhTienCanTrenFilterBuilder : SqlFilterBuilder<QuyDinhTienCanTrenColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the QuyDinhTienCanTrenFilterBuilder class.
		/// </summary>
		public QuyDinhTienCanTrenFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the QuyDinhTienCanTrenFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public QuyDinhTienCanTrenFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the QuyDinhTienCanTrenFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public QuyDinhTienCanTrenFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion QuyDinhTienCanTrenFilterBuilder
	
	#region QuyDinhTienCanTrenParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;QuyDinhTienCanTrenColumn&gt;"/> class
	/// that is used exclusively with a <see cref="QuyDinhTienCanTren"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class QuyDinhTienCanTrenParameterBuilder : ParameterizedSqlFilterBuilder<QuyDinhTienCanTrenColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the QuyDinhTienCanTrenParameterBuilder class.
		/// </summary>
		public QuyDinhTienCanTrenParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the QuyDinhTienCanTrenParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public QuyDinhTienCanTrenParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the QuyDinhTienCanTrenParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public QuyDinhTienCanTrenParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion QuyDinhTienCanTrenParameterBuilder
	
	#region QuyDinhTienCanTrenSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;QuyDinhTienCanTrenColumn&gt;"/> class
	/// that is used exclusively with a <see cref="QuyDinhTienCanTren"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class QuyDinhTienCanTrenSortBuilder : SqlSortBuilder<QuyDinhTienCanTrenColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the QuyDinhTienCanTrenSqlSortBuilder class.
		/// </summary>
		public QuyDinhTienCanTrenSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion QuyDinhTienCanTrenSortBuilder
	
} // end namespace
