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
	/// This class is the base class for any <see cref="GiangVienProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GiangVienProviderBaseCore : EntityProviderBase<PMS.Entities.GiangVien, PMS.Entities.GiangVienKey>
	{		
		#region Get from Many To Many Relationship Functions
		#region GetByMaHoSoFromGiangVienHoSo
		
		/// <summary>
		///		Gets GiangVien objects from the datasource by MaHoSo in the
		///		GiangVien_HoSo table. Table GiangVien is related to table HoSo
		///		through the (M:N) relationship defined in the GiangVien_HoSo table.
		/// </summary>
		/// <param name="_maHoSo"></param>
		/// <returns>Returns a typed collection of GiangVien objects.</returns>
		public TList<GiangVien> GetByMaHoSoFromGiangVienHoSo(System.Int32 _maHoSo)
		{
			int count = -1;
			return GetByMaHoSoFromGiangVienHoSo(null,_maHoSo, 0, int.MaxValue, out count);
			
		}
		
		/// <summary>
		///		Gets PMS.Entities.GiangVien objects from the datasource by MaHoSo in the
		///		GiangVien_HoSo table. Table GiangVien is related to table HoSo
		///		through the (M:N) relationship defined in the GiangVien_HoSo table.
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maHoSo"></param>
		/// <remarks></remarks>
		/// <returns>Returns a TList of GiangVien objects.</returns>
		public TList<GiangVien> GetByMaHoSoFromGiangVienHoSo(System.Int32 _maHoSo, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHoSoFromGiangVienHoSo(null, _maHoSo, start, pageLength, out count);
		}
		
		/// <summary>
		///		Gets GiangVien objects from the datasource by MaHoSo in the
		///		GiangVien_HoSo table. Table GiangVien is related to table HoSo
		///		through the (M:N) relationship defined in the GiangVien_HoSo table.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHoSo"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of GiangVien objects.</returns>
		public TList<GiangVien> GetByMaHoSoFromGiangVienHoSo(TransactionManager transactionManager, System.Int32 _maHoSo)
		{
			int count = -1;
			return GetByMaHoSoFromGiangVienHoSo(transactionManager, _maHoSo, 0, int.MaxValue, out count);
		}
		
		
		/// <summary>
		///		Gets GiangVien objects from the datasource by MaHoSo in the
		///		GiangVien_HoSo table. Table GiangVien is related to table HoSo
		///		through the (M:N) relationship defined in the GiangVien_HoSo table.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHoSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of GiangVien objects.</returns>
		public TList<GiangVien> GetByMaHoSoFromGiangVienHoSo(TransactionManager transactionManager, System.Int32 _maHoSo,int start, int pageLength)
		{
			int count = -1;
			return GetByMaHoSoFromGiangVienHoSo(transactionManager, _maHoSo, start, pageLength, out count);
		}
		
		/// <summary>
		///		Gets GiangVien objects from the datasource by MaHoSo in the
		///		GiangVien_HoSo table. Table GiangVien is related to table HoSo
		///		through the (M:N) relationship defined in the GiangVien_HoSo table.
		/// </summary>
		/// <param name="_maHoSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of GiangVien objects.</returns>
		public TList<GiangVien> GetByMaHoSoFromGiangVienHoSo(System.Int32 _maHoSo,int start, int pageLength, out int count)
		{
			
			return GetByMaHoSoFromGiangVienHoSo(null, _maHoSo, start, pageLength, out count);
		}


		/// <summary>
		///		Gets GiangVien objects from the datasource by MaHoSo in the
		///		GiangVien_HoSo table. Table GiangVien is related to table HoSo
		///		through the (M:N) relationship defined in the GiangVien_HoSo table.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <param name="_maHoSo"></param>
		/// <remarks></remarks>
		/// <returns>Returns a TList of GiangVien objects.</returns>
		public abstract TList<GiangVien> GetByMaHoSoFromGiangVienHoSo(TransactionManager transactionManager,System.Int32 _maHoSo, int start, int pageLength, out int count);
		
		#endregion GetByMaHoSoFromGiangVienHoSo
		
		#endregion	
		
		#region Delete Methods

		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
		/// <param name="key">The unique identifier of the row to delete.</param>
		/// <returns>Returns true if operation suceeded.</returns>
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.GiangVienKey key)
		{
			return Delete(transactionManager, key.MaGiangVien);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maGiangVien">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maGiangVien)
		{
			return Delete(null, _maGiangVien);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maGiangVien);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HocHam key.
		///		FK_GiangVien_HocHam Description: 
		/// </summary>
		/// <param name="_maHocHam"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaHocHam(System.Int32? _maHocHam)
		{
			int count = -1;
			return GetByMaHocHam(_maHocHam, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HocHam key.
		///		FK_GiangVien_HocHam Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocHam"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		/// <remarks></remarks>
		public TList<GiangVien> GetByMaHocHam(TransactionManager transactionManager, System.Int32? _maHocHam)
		{
			int count = -1;
			return GetByMaHocHam(transactionManager, _maHocHam, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HocHam key.
		///		FK_GiangVien_HocHam Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocHam"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaHocHam(TransactionManager transactionManager, System.Int32? _maHocHam, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHocHam(transactionManager, _maHocHam, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HocHam key.
		///		fkGiangVienHocHam Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maHocHam"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaHocHam(System.Int32? _maHocHam, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaHocHam(null, _maHocHam, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HocHam key.
		///		fkGiangVienHocHam Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maHocHam"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaHocHam(System.Int32? _maHocHam, int start, int pageLength,out int count)
		{
			return GetByMaHocHam(null, _maHocHam, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HocHam key.
		///		FK_GiangVien_HocHam Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocHam"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public abstract TList<GiangVien> GetByMaHocHam(TransactionManager transactionManager, System.Int32? _maHocHam, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HocVi key.
		///		FK_GiangVien_HocVi Description: 
		/// </summary>
		/// <param name="_maHocVi"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaHocVi(System.Int32? _maHocVi)
		{
			int count = -1;
			return GetByMaHocVi(_maHocVi, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HocVi key.
		///		FK_GiangVien_HocVi Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocVi"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		/// <remarks></remarks>
		public TList<GiangVien> GetByMaHocVi(TransactionManager transactionManager, System.Int32? _maHocVi)
		{
			int count = -1;
			return GetByMaHocVi(transactionManager, _maHocVi, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HocVi key.
		///		FK_GiangVien_HocVi Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocVi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaHocVi(TransactionManager transactionManager, System.Int32? _maHocVi, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHocVi(transactionManager, _maHocVi, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HocVi key.
		///		fkGiangVienHocVi Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maHocVi"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaHocVi(System.Int32? _maHocVi, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaHocVi(null, _maHocVi, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HocVi key.
		///		fkGiangVienHocVi Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maHocVi"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaHocVi(System.Int32? _maHocVi, int start, int pageLength,out int count)
		{
			return GetByMaHocVi(null, _maHocVi, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HocVi key.
		///		FK_GiangVien_HocVi Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocVi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public abstract TList<GiangVien> GetByMaHocVi(TransactionManager transactionManager, System.Int32? _maHocVi, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_LoaiGiangVien key.
		///		FK_GiangVien_LoaiGiangVien Description: 
		/// </summary>
		/// <param name="_maLoaiGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaLoaiGiangVien(System.Int32? _maLoaiGiangVien)
		{
			int count = -1;
			return GetByMaLoaiGiangVien(_maLoaiGiangVien, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_LoaiGiangVien key.
		///		FK_GiangVien_LoaiGiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		/// <remarks></remarks>
		public TList<GiangVien> GetByMaLoaiGiangVien(TransactionManager transactionManager, System.Int32? _maLoaiGiangVien)
		{
			int count = -1;
			return GetByMaLoaiGiangVien(transactionManager, _maLoaiGiangVien, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_LoaiGiangVien key.
		///		FK_GiangVien_LoaiGiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaLoaiGiangVien(TransactionManager transactionManager, System.Int32? _maLoaiGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLoaiGiangVien(transactionManager, _maLoaiGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_LoaiGiangVien key.
		///		fkGiangVienLoaiGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maLoaiGiangVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaLoaiGiangVien(System.Int32? _maLoaiGiangVien, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaLoaiGiangVien(null, _maLoaiGiangVien, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_LoaiGiangVien key.
		///		fkGiangVienLoaiGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maLoaiGiangVien"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaLoaiGiangVien(System.Int32? _maLoaiGiangVien, int start, int pageLength,out int count)
		{
			return GetByMaLoaiGiangVien(null, _maLoaiGiangVien, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_LoaiGiangVien key.
		///		FK_GiangVien_LoaiGiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public abstract TList<GiangVien> GetByMaLoaiGiangVien(TransactionManager transactionManager, System.Int32? _maLoaiGiangVien, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_LoaiNhanVien key.
		///		FK_GiangVien_LoaiNhanVien Description: 
		/// </summary>
		/// <param name="_maLoaiNhanVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaLoaiNhanVien(System.Int32? _maLoaiNhanVien)
		{
			int count = -1;
			return GetByMaLoaiNhanVien(_maLoaiNhanVien, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_LoaiNhanVien key.
		///		FK_GiangVien_LoaiNhanVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiNhanVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		/// <remarks></remarks>
		public TList<GiangVien> GetByMaLoaiNhanVien(TransactionManager transactionManager, System.Int32? _maLoaiNhanVien)
		{
			int count = -1;
			return GetByMaLoaiNhanVien(transactionManager, _maLoaiNhanVien, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_LoaiNhanVien key.
		///		FK_GiangVien_LoaiNhanVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiNhanVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaLoaiNhanVien(TransactionManager transactionManager, System.Int32? _maLoaiNhanVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLoaiNhanVien(transactionManager, _maLoaiNhanVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_LoaiNhanVien key.
		///		fkGiangVienLoaiNhanVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maLoaiNhanVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaLoaiNhanVien(System.Int32? _maLoaiNhanVien, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaLoaiNhanVien(null, _maLoaiNhanVien, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_LoaiNhanVien key.
		///		fkGiangVienLoaiNhanVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maLoaiNhanVien"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaLoaiNhanVien(System.Int32? _maLoaiNhanVien, int start, int pageLength,out int count)
		{
			return GetByMaLoaiNhanVien(null, _maLoaiNhanVien, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_LoaiNhanVien key.
		///		FK_GiangVien_LoaiNhanVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiNhanVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public abstract TList<GiangVien> GetByMaLoaiNhanVien(TransactionManager transactionManager, System.Int32? _maLoaiNhanVien, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_NgachCongChuc key.
		///		FK_GiangVien_NgachCongChuc Description: 
		/// </summary>
		/// <param name="_maNgachCongChuc"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaNgachCongChuc(System.Int32? _maNgachCongChuc)
		{
			int count = -1;
			return GetByMaNgachCongChuc(_maNgachCongChuc, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_NgachCongChuc key.
		///		FK_GiangVien_NgachCongChuc Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNgachCongChuc"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		/// <remarks></remarks>
		public TList<GiangVien> GetByMaNgachCongChuc(TransactionManager transactionManager, System.Int32? _maNgachCongChuc)
		{
			int count = -1;
			return GetByMaNgachCongChuc(transactionManager, _maNgachCongChuc, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_NgachCongChuc key.
		///		FK_GiangVien_NgachCongChuc Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNgachCongChuc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaNgachCongChuc(TransactionManager transactionManager, System.Int32? _maNgachCongChuc, int start, int pageLength)
		{
			int count = -1;
			return GetByMaNgachCongChuc(transactionManager, _maNgachCongChuc, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_NgachCongChuc key.
		///		fkGiangVienNgachCongChuc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maNgachCongChuc"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaNgachCongChuc(System.Int32? _maNgachCongChuc, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaNgachCongChuc(null, _maNgachCongChuc, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_NgachCongChuc key.
		///		fkGiangVienNgachCongChuc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maNgachCongChuc"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaNgachCongChuc(System.Int32? _maNgachCongChuc, int start, int pageLength,out int count)
		{
			return GetByMaNgachCongChuc(null, _maNgachCongChuc, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_NgachCongChuc key.
		///		FK_GiangVien_NgachCongChuc Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNgachCongChuc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public abstract TList<GiangVien> GetByMaNgachCongChuc(TransactionManager transactionManager, System.Int32? _maNgachCongChuc, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TaiKhoan key.
		///		FK_GiangVien_TaiKhoan Description: 
		/// </summary>
		/// <param name="_maNguoiLap"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaNguoiLap(System.Int32? _maNguoiLap)
		{
			int count = -1;
			return GetByMaNguoiLap(_maNguoiLap, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TaiKhoan key.
		///		FK_GiangVien_TaiKhoan Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNguoiLap"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		/// <remarks></remarks>
		public TList<GiangVien> GetByMaNguoiLap(TransactionManager transactionManager, System.Int32? _maNguoiLap)
		{
			int count = -1;
			return GetByMaNguoiLap(transactionManager, _maNguoiLap, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TaiKhoan key.
		///		FK_GiangVien_TaiKhoan Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNguoiLap"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaNguoiLap(TransactionManager transactionManager, System.Int32? _maNguoiLap, int start, int pageLength)
		{
			int count = -1;
			return GetByMaNguoiLap(transactionManager, _maNguoiLap, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TaiKhoan key.
		///		fkGiangVienTaiKhoan Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maNguoiLap"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaNguoiLap(System.Int32? _maNguoiLap, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaNguoiLap(null, _maNguoiLap, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TaiKhoan key.
		///		fkGiangVienTaiKhoan Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maNguoiLap"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaNguoiLap(System.Int32? _maNguoiLap, int start, int pageLength,out int count)
		{
			return GetByMaNguoiLap(null, _maNguoiLap, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TaiKhoan key.
		///		FK_GiangVien_TaiKhoan Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNguoiLap"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public abstract TList<GiangVien> GetByMaNguoiLap(TransactionManager transactionManager, System.Int32? _maNguoiLap, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TinhTrang key.
		///		FK_GiangVien_TinhTrang Description: 
		/// </summary>
		/// <param name="_maTinhTrang"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaTinhTrang(System.Int32? _maTinhTrang)
		{
			int count = -1;
			return GetByMaTinhTrang(_maTinhTrang, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TinhTrang key.
		///		FK_GiangVien_TinhTrang Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maTinhTrang"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		/// <remarks></remarks>
		public TList<GiangVien> GetByMaTinhTrang(TransactionManager transactionManager, System.Int32? _maTinhTrang)
		{
			int count = -1;
			return GetByMaTinhTrang(transactionManager, _maTinhTrang, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TinhTrang key.
		///		FK_GiangVien_TinhTrang Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maTinhTrang"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaTinhTrang(TransactionManager transactionManager, System.Int32? _maTinhTrang, int start, int pageLength)
		{
			int count = -1;
			return GetByMaTinhTrang(transactionManager, _maTinhTrang, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TinhTrang key.
		///		fkGiangVienTinhTrang Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maTinhTrang"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaTinhTrang(System.Int32? _maTinhTrang, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaTinhTrang(null, _maTinhTrang, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TinhTrang key.
		///		fkGiangVienTinhTrang Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maTinhTrang"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaTinhTrang(System.Int32? _maTinhTrang, int start, int pageLength,out int count)
		{
			return GetByMaTinhTrang(null, _maTinhTrang, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TinhTrang key.
		///		FK_GiangVien_TinhTrang Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maTinhTrang"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public abstract TList<GiangVien> GetByMaTinhTrang(TransactionManager transactionManager, System.Int32? _maTinhTrang, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TrinhDoChinhTri key.
		///		FK_GiangVien_TrinhDoChinhTri Description: 
		/// </summary>
		/// <param name="_maTrinhDoChinhTri"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaTrinhDoChinhTri(System.Int32? _maTrinhDoChinhTri)
		{
			int count = -1;
			return GetByMaTrinhDoChinhTri(_maTrinhDoChinhTri, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TrinhDoChinhTri key.
		///		FK_GiangVien_TrinhDoChinhTri Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maTrinhDoChinhTri"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		/// <remarks></remarks>
		public TList<GiangVien> GetByMaTrinhDoChinhTri(TransactionManager transactionManager, System.Int32? _maTrinhDoChinhTri)
		{
			int count = -1;
			return GetByMaTrinhDoChinhTri(transactionManager, _maTrinhDoChinhTri, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TrinhDoChinhTri key.
		///		FK_GiangVien_TrinhDoChinhTri Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maTrinhDoChinhTri"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaTrinhDoChinhTri(TransactionManager transactionManager, System.Int32? _maTrinhDoChinhTri, int start, int pageLength)
		{
			int count = -1;
			return GetByMaTrinhDoChinhTri(transactionManager, _maTrinhDoChinhTri, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TrinhDoChinhTri key.
		///		fkGiangVienTrinhDoChinhTri Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maTrinhDoChinhTri"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaTrinhDoChinhTri(System.Int32? _maTrinhDoChinhTri, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaTrinhDoChinhTri(null, _maTrinhDoChinhTri, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TrinhDoChinhTri key.
		///		fkGiangVienTrinhDoChinhTri Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maTrinhDoChinhTri"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaTrinhDoChinhTri(System.Int32? _maTrinhDoChinhTri, int start, int pageLength,out int count)
		{
			return GetByMaTrinhDoChinhTri(null, _maTrinhDoChinhTri, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TrinhDoChinhTri key.
		///		FK_GiangVien_TrinhDoChinhTri Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maTrinhDoChinhTri"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public abstract TList<GiangVien> GetByMaTrinhDoChinhTri(TransactionManager transactionManager, System.Int32? _maTrinhDoChinhTri, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TrinhDoNgoaiNgu key.
		///		FK_GiangVien_TrinhDoNgoaiNgu Description: 
		/// </summary>
		/// <param name="_maTrinhDoNgoaiNgu"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaTrinhDoNgoaiNgu(System.Int32? _maTrinhDoNgoaiNgu)
		{
			int count = -1;
			return GetByMaTrinhDoNgoaiNgu(_maTrinhDoNgoaiNgu, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TrinhDoNgoaiNgu key.
		///		FK_GiangVien_TrinhDoNgoaiNgu Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maTrinhDoNgoaiNgu"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		/// <remarks></remarks>
		public TList<GiangVien> GetByMaTrinhDoNgoaiNgu(TransactionManager transactionManager, System.Int32? _maTrinhDoNgoaiNgu)
		{
			int count = -1;
			return GetByMaTrinhDoNgoaiNgu(transactionManager, _maTrinhDoNgoaiNgu, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TrinhDoNgoaiNgu key.
		///		FK_GiangVien_TrinhDoNgoaiNgu Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maTrinhDoNgoaiNgu"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaTrinhDoNgoaiNgu(TransactionManager transactionManager, System.Int32? _maTrinhDoNgoaiNgu, int start, int pageLength)
		{
			int count = -1;
			return GetByMaTrinhDoNgoaiNgu(transactionManager, _maTrinhDoNgoaiNgu, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TrinhDoNgoaiNgu key.
		///		fkGiangVienTrinhDoNgoaiNgu Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maTrinhDoNgoaiNgu"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaTrinhDoNgoaiNgu(System.Int32? _maTrinhDoNgoaiNgu, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaTrinhDoNgoaiNgu(null, _maTrinhDoNgoaiNgu, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TrinhDoNgoaiNgu key.
		///		fkGiangVienTrinhDoNgoaiNgu Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maTrinhDoNgoaiNgu"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaTrinhDoNgoaiNgu(System.Int32? _maTrinhDoNgoaiNgu, int start, int pageLength,out int count)
		{
			return GetByMaTrinhDoNgoaiNgu(null, _maTrinhDoNgoaiNgu, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TrinhDoNgoaiNgu key.
		///		FK_GiangVien_TrinhDoNgoaiNgu Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maTrinhDoNgoaiNgu"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public abstract TList<GiangVien> GetByMaTrinhDoNgoaiNgu(TransactionManager transactionManager, System.Int32? _maTrinhDoNgoaiNgu, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TrinhDoQuanLyNhaNuoc key.
		///		FK_GiangVien_TrinhDoQuanLyNhaNuoc Description: 
		/// </summary>
		/// <param name="_maTrinhDoQuanLyNhaNuoc"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaTrinhDoQuanLyNhaNuoc(System.Int32? _maTrinhDoQuanLyNhaNuoc)
		{
			int count = -1;
			return GetByMaTrinhDoQuanLyNhaNuoc(_maTrinhDoQuanLyNhaNuoc, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TrinhDoQuanLyNhaNuoc key.
		///		FK_GiangVien_TrinhDoQuanLyNhaNuoc Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maTrinhDoQuanLyNhaNuoc"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		/// <remarks></remarks>
		public TList<GiangVien> GetByMaTrinhDoQuanLyNhaNuoc(TransactionManager transactionManager, System.Int32? _maTrinhDoQuanLyNhaNuoc)
		{
			int count = -1;
			return GetByMaTrinhDoQuanLyNhaNuoc(transactionManager, _maTrinhDoQuanLyNhaNuoc, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TrinhDoQuanLyNhaNuoc key.
		///		FK_GiangVien_TrinhDoQuanLyNhaNuoc Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maTrinhDoQuanLyNhaNuoc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaTrinhDoQuanLyNhaNuoc(TransactionManager transactionManager, System.Int32? _maTrinhDoQuanLyNhaNuoc, int start, int pageLength)
		{
			int count = -1;
			return GetByMaTrinhDoQuanLyNhaNuoc(transactionManager, _maTrinhDoQuanLyNhaNuoc, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TrinhDoQuanLyNhaNuoc key.
		///		fkGiangVienTrinhDoQuanLyNhaNuoc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maTrinhDoQuanLyNhaNuoc"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaTrinhDoQuanLyNhaNuoc(System.Int32? _maTrinhDoQuanLyNhaNuoc, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaTrinhDoQuanLyNhaNuoc(null, _maTrinhDoQuanLyNhaNuoc, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TrinhDoQuanLyNhaNuoc key.
		///		fkGiangVienTrinhDoQuanLyNhaNuoc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maTrinhDoQuanLyNhaNuoc"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaTrinhDoQuanLyNhaNuoc(System.Int32? _maTrinhDoQuanLyNhaNuoc, int start, int pageLength,out int count)
		{
			return GetByMaTrinhDoQuanLyNhaNuoc(null, _maTrinhDoQuanLyNhaNuoc, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TrinhDoQuanLyNhaNuoc key.
		///		FK_GiangVien_TrinhDoQuanLyNhaNuoc Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maTrinhDoQuanLyNhaNuoc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public abstract TList<GiangVien> GetByMaTrinhDoQuanLyNhaNuoc(TransactionManager transactionManager, System.Int32? _maTrinhDoQuanLyNhaNuoc, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TrinhDoSuPham key.
		///		FK_GiangVien_TrinhDoSuPham Description: 
		/// </summary>
		/// <param name="_maTrinhDoSuPham"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaTrinhDoSuPham(System.Int32? _maTrinhDoSuPham)
		{
			int count = -1;
			return GetByMaTrinhDoSuPham(_maTrinhDoSuPham, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TrinhDoSuPham key.
		///		FK_GiangVien_TrinhDoSuPham Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maTrinhDoSuPham"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		/// <remarks></remarks>
		public TList<GiangVien> GetByMaTrinhDoSuPham(TransactionManager transactionManager, System.Int32? _maTrinhDoSuPham)
		{
			int count = -1;
			return GetByMaTrinhDoSuPham(transactionManager, _maTrinhDoSuPham, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TrinhDoSuPham key.
		///		FK_GiangVien_TrinhDoSuPham Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maTrinhDoSuPham"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaTrinhDoSuPham(TransactionManager transactionManager, System.Int32? _maTrinhDoSuPham, int start, int pageLength)
		{
			int count = -1;
			return GetByMaTrinhDoSuPham(transactionManager, _maTrinhDoSuPham, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TrinhDoSuPham key.
		///		fkGiangVienTrinhDoSuPham Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maTrinhDoSuPham"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaTrinhDoSuPham(System.Int32? _maTrinhDoSuPham, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaTrinhDoSuPham(null, _maTrinhDoSuPham, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TrinhDoSuPham key.
		///		fkGiangVienTrinhDoSuPham Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maTrinhDoSuPham"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaTrinhDoSuPham(System.Int32? _maTrinhDoSuPham, int start, int pageLength,out int count)
		{
			return GetByMaTrinhDoSuPham(null, _maTrinhDoSuPham, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TrinhDoSuPham key.
		///		FK_GiangVien_TrinhDoSuPham Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maTrinhDoSuPham"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public abstract TList<GiangVien> GetByMaTrinhDoSuPham(TransactionManager transactionManager, System.Int32? _maTrinhDoSuPham, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TrinhDoTinHoc key.
		///		FK_GiangVien_TrinhDoTinHoc Description: 
		/// </summary>
		/// <param name="_maTrinhDoTinHoc"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaTrinhDoTinHoc(System.Int32? _maTrinhDoTinHoc)
		{
			int count = -1;
			return GetByMaTrinhDoTinHoc(_maTrinhDoTinHoc, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TrinhDoTinHoc key.
		///		FK_GiangVien_TrinhDoTinHoc Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maTrinhDoTinHoc"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		/// <remarks></remarks>
		public TList<GiangVien> GetByMaTrinhDoTinHoc(TransactionManager transactionManager, System.Int32? _maTrinhDoTinHoc)
		{
			int count = -1;
			return GetByMaTrinhDoTinHoc(transactionManager, _maTrinhDoTinHoc, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TrinhDoTinHoc key.
		///		FK_GiangVien_TrinhDoTinHoc Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maTrinhDoTinHoc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaTrinhDoTinHoc(TransactionManager transactionManager, System.Int32? _maTrinhDoTinHoc, int start, int pageLength)
		{
			int count = -1;
			return GetByMaTrinhDoTinHoc(transactionManager, _maTrinhDoTinHoc, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TrinhDoTinHoc key.
		///		fkGiangVienTrinhDoTinHoc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maTrinhDoTinHoc"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaTrinhDoTinHoc(System.Int32? _maTrinhDoTinHoc, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaTrinhDoTinHoc(null, _maTrinhDoTinHoc, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TrinhDoTinHoc key.
		///		fkGiangVienTrinhDoTinHoc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maTrinhDoTinHoc"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public TList<GiangVien> GetByMaTrinhDoTinHoc(System.Int32? _maTrinhDoTinHoc, int start, int pageLength,out int count)
		{
			return GetByMaTrinhDoTinHoc(null, _maTrinhDoTinHoc, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_TrinhDoTinHoc key.
		///		FK_GiangVien_TrinhDoTinHoc Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maTrinhDoTinHoc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVien objects.</returns>
		public abstract TList<GiangVien> GetByMaTrinhDoTinHoc(TransactionManager transactionManager, System.Int32? _maTrinhDoTinHoc, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.GiangVien Get(TransactionManager transactionManager, PMS.Entities.GiangVienKey key, int start, int pageLength)
		{
			return GetByMaGiangVien(transactionManager, key.MaGiangVien, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GiangVien index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;GiangVien&gt;"/> class.</returns>
		public TList<GiangVien> GetByMaQuanLy(System.String _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(null,_maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GiangVien index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GiangVien&gt;"/> class.</returns>
		public TList<GiangVien> GetByMaQuanLy(System.String _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GiangVien index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GiangVien&gt;"/> class.</returns>
		public TList<GiangVien> GetByMaQuanLy(TransactionManager transactionManager, System.String _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GiangVien index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GiangVien&gt;"/> class.</returns>
		public TList<GiangVien> GetByMaQuanLy(TransactionManager transactionManager, System.String _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GiangVien index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GiangVien&gt;"/> class.</returns>
		public TList<GiangVien> GetByMaQuanLy(System.String _maQuanLy, int start, int pageLength, out int count)
		{
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GiangVien index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;GiangVien&gt;"/> class.</returns>
		public abstract TList<GiangVien> GetByMaQuanLy(TransactionManager transactionManager, System.String _maQuanLy, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GiangVien index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVien"/> class.</returns>
		public PMS.Entities.GiangVien GetByMaGiangVien(System.Int32 _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(null,_maGiangVien, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVien"/> class.</returns>
		public PMS.Entities.GiangVien GetByMaGiangVien(System.Int32 _maGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVien"/> class.</returns>
		public PMS.Entities.GiangVien GetByMaGiangVien(TransactionManager transactionManager, System.Int32 _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVien"/> class.</returns>
		public PMS.Entities.GiangVien GetByMaGiangVien(TransactionManager transactionManager, System.Int32 _maGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVien"/> class.</returns>
		public PMS.Entities.GiangVien GetByMaGiangVien(System.Int32 _maGiangVien, int start, int pageLength, out int count)
		{
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVien"/> class.</returns>
		public abstract PMS.Entities.GiangVien GetByMaGiangVien(TransactionManager transactionManager, System.Int32 _maGiangVien, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_GiangVien_ThongKeSoLuongTheoLoaiGiangVien 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ThongKeSoLuongTheoLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeSoLuongTheoLoaiGiangVien()
		{
			return ThongKeSoLuongTheoLoaiGiangVien(null, 0, int.MaxValue );
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ThongKeSoLuongTheoLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeSoLuongTheoLoaiGiangVien(int start, int pageLength)
		{
			return ThongKeSoLuongTheoLoaiGiangVien(null, start, pageLength );
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ThongKeSoLuongTheoLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeSoLuongTheoLoaiGiangVien(TransactionManager transactionManager)
		{
			return ThongKeSoLuongTheoLoaiGiangVien(transactionManager, 0, int.MaxValue );
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ThongKeSoLuongTheoLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeSoLuongTheoLoaiGiangVien(TransactionManager transactionManager, int start, int pageLength );
		
		#endregion
		
		#region cust_GiangVien_DinhMucKhauTru_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_DinhMucKhauTru_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reval"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DinhMucKhauTru_Luu(System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reval)
		{
			 DinhMucKhauTru_Luu(null, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reval);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_DinhMucKhauTru_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reval"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DinhMucKhauTru_Luu(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reval)
		{
			 DinhMucKhauTru_Luu(null, start, pageLength , xmlData, namHoc, hocKy, ref reval);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_DinhMucKhauTru_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reval"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DinhMucKhauTru_Luu(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reval)
		{
			 DinhMucKhauTru_Luu(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reval);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_DinhMucKhauTru_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reval"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DinhMucKhauTru_Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reval);
		
		#endregion
		
		#region cust_GiangVien_NghienCuuKH_ThongKeDuThieu 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_ThongKeDuThieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader NghienCuuKH_ThongKeDuThieu(System.String namHoc, System.String khoaDonVi)
		{
			return NghienCuuKH_ThongKeDuThieu(null, 0, int.MaxValue , namHoc, khoaDonVi);
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
		public IDataReader NghienCuuKH_ThongKeDuThieu(int start, int pageLength, System.String namHoc, System.String khoaDonVi)
		{
			return NghienCuuKH_ThongKeDuThieu(null, start, pageLength , namHoc, khoaDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_ThongKeDuThieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader NghienCuuKH_ThongKeDuThieu(TransactionManager transactionManager, System.String namHoc, System.String khoaDonVi)
		{
			return NghienCuuKH_ThongKeDuThieu(transactionManager, 0, int.MaxValue , namHoc, khoaDonVi);
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
		public abstract IDataReader NghienCuuKH_ThongKeDuThieu(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String khoaDonVi);
		
		#endregion
		
		#region cust_GiangVien_GetAllTaiKhoan 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetAllTaiKhoan' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetAllTaiKhoan(System.String maDonVi, System.String maGiangVien)
		{
			return GetAllTaiKhoan(null, 0, int.MaxValue , maDonVi, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetAllTaiKhoan' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetAllTaiKhoan(int start, int pageLength, System.String maDonVi, System.String maGiangVien)
		{
			return GetAllTaiKhoan(null, start, pageLength , maDonVi, maGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetAllTaiKhoan' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetAllTaiKhoan(TransactionManager transactionManager, System.String maDonVi, System.String maGiangVien)
		{
			return GetAllTaiKhoan(transactionManager, 0, int.MaxValue , maDonVi, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetAllTaiKhoan' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetAllTaiKhoan(TransactionManager transactionManager, int start, int pageLength , System.String maDonVi, System.String maGiangVien);
		
		#endregion
		
		#region cust_GiangVien_GetHeSoQuyDoiTietChuanCtim 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetHeSoQuyDoiTietChuanCtim' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maPhongHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiHocPhan"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetHeSoQuyDoiTietChuanCtim(System.String maQuanLy, System.String namHoc, System.String hocKy, System.String maMonHoc, System.Int32 siSo, System.Int32 tietBatDau, System.DateTime ngayDay, System.String maPhongHoc, System.String maLopHocPhan, System.String maBacDaoTao, System.Int32 maLoaiHocPhan)
		{
			return GetHeSoQuyDoiTietChuanCtim(null, 0, int.MaxValue , maQuanLy, namHoc, hocKy, maMonHoc, siSo, tietBatDau, ngayDay, maPhongHoc, maLopHocPhan, maBacDaoTao, maLoaiHocPhan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetHeSoQuyDoiTietChuanCtim' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maPhongHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiHocPhan"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetHeSoQuyDoiTietChuanCtim(int start, int pageLength, System.String maQuanLy, System.String namHoc, System.String hocKy, System.String maMonHoc, System.Int32 siSo, System.Int32 tietBatDau, System.DateTime ngayDay, System.String maPhongHoc, System.String maLopHocPhan, System.String maBacDaoTao, System.Int32 maLoaiHocPhan)
		{
			return GetHeSoQuyDoiTietChuanCtim(null, start, pageLength , maQuanLy, namHoc, hocKy, maMonHoc, siSo, tietBatDau, ngayDay, maPhongHoc, maLopHocPhan, maBacDaoTao, maLoaiHocPhan);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetHeSoQuyDoiTietChuanCtim' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maPhongHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiHocPhan"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetHeSoQuyDoiTietChuanCtim(TransactionManager transactionManager, System.String maQuanLy, System.String namHoc, System.String hocKy, System.String maMonHoc, System.Int32 siSo, System.Int32 tietBatDau, System.DateTime ngayDay, System.String maPhongHoc, System.String maLopHocPhan, System.String maBacDaoTao, System.Int32 maLoaiHocPhan)
		{
			return GetHeSoQuyDoiTietChuanCtim(transactionManager, 0, int.MaxValue , maQuanLy, namHoc, hocKy, maMonHoc, siSo, tietBatDau, ngayDay, maPhongHoc, maLopHocPhan, maBacDaoTao, maLoaiHocPhan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetHeSoQuyDoiTietChuanCtim' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maPhongHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiHocPhan"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetHeSoQuyDoiTietChuanCtim(TransactionManager transactionManager, int start, int pageLength , System.String maQuanLy, System.String namHoc, System.String hocKy, System.String maMonHoc, System.Int32 siSo, System.Int32 tietBatDau, System.DateTime ngayDay, System.String maPhongHoc, System.String maLopHocPhan, System.String maBacDaoTao, System.Int32 maLoaiHocPhan);
		
		#endregion
		
		#region cust_GiangVien_DongBoDuLieuHRM 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_DongBoDuLieuHRM' stored procedure. 
		/// </summary>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBoDuLieuHRM()
		{
			 DongBoDuLieuHRM(null, 0, int.MaxValue );
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_DongBoDuLieuHRM' stored procedure. 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBoDuLieuHRM(int start, int pageLength)
		{
			 DongBoDuLieuHRM(null, start, pageLength );
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_DongBoDuLieuHRM' stored procedure. 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBoDuLieuHRM(TransactionManager transactionManager)
		{
			 DongBoDuLieuHRM(transactionManager, 0, int.MaxValue );
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_DongBoDuLieuHRM' stored procedure. 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DongBoDuLieuHRM(TransactionManager transactionManager, int start, int pageLength );
		
		#endregion
		
		#region cust_GiangVien_KiemTraGiangVienImport 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_KiemTraGiangVienImport' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="checkHocHam"> A <c>System.String</c> instance.</param>
			/// <param name="checkHocVi"> A <c>System.String</c> instance.</param>
			/// <param name="checkLoaiGv"> A <c>System.String</c> instance.</param>
			/// <param name="checkTinhTrang"> A <c>System.String</c> instance.</param>
			/// <param name="checkDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader KiemTraGiangVienImport(System.String xmlData, ref System.String checkHocHam, ref System.String checkHocVi, ref System.String checkLoaiGv, ref System.String checkTinhTrang, ref System.String checkDonVi)
		{
			return KiemTraGiangVienImport(null, 0, int.MaxValue , xmlData, ref checkHocHam, ref checkHocVi, ref checkLoaiGv, ref checkTinhTrang, ref checkDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_KiemTraGiangVienImport' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="checkHocHam"> A <c>System.String</c> instance.</param>
			/// <param name="checkHocVi"> A <c>System.String</c> instance.</param>
			/// <param name="checkLoaiGv"> A <c>System.String</c> instance.</param>
			/// <param name="checkTinhTrang"> A <c>System.String</c> instance.</param>
			/// <param name="checkDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader KiemTraGiangVienImport(int start, int pageLength, System.String xmlData, ref System.String checkHocHam, ref System.String checkHocVi, ref System.String checkLoaiGv, ref System.String checkTinhTrang, ref System.String checkDonVi)
		{
			return KiemTraGiangVienImport(null, start, pageLength , xmlData, ref checkHocHam, ref checkHocVi, ref checkLoaiGv, ref checkTinhTrang, ref checkDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_KiemTraGiangVienImport' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="checkHocHam"> A <c>System.String</c> instance.</param>
			/// <param name="checkHocVi"> A <c>System.String</c> instance.</param>
			/// <param name="checkLoaiGv"> A <c>System.String</c> instance.</param>
			/// <param name="checkTinhTrang"> A <c>System.String</c> instance.</param>
			/// <param name="checkDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader KiemTraGiangVienImport(TransactionManager transactionManager, System.String xmlData, ref System.String checkHocHam, ref System.String checkHocVi, ref System.String checkLoaiGv, ref System.String checkTinhTrang, ref System.String checkDonVi)
		{
			return KiemTraGiangVienImport(transactionManager, 0, int.MaxValue , xmlData, ref checkHocHam, ref checkHocVi, ref checkLoaiGv, ref checkTinhTrang, ref checkDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_KiemTraGiangVienImport' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="checkHocHam"> A <c>System.String</c> instance.</param>
			/// <param name="checkHocVi"> A <c>System.String</c> instance.</param>
			/// <param name="checkLoaiGv"> A <c>System.String</c> instance.</param>
			/// <param name="checkTinhTrang"> A <c>System.String</c> instance.</param>
			/// <param name="checkDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader KiemTraGiangVienImport(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, ref System.String checkHocHam, ref System.String checkHocVi, ref System.String checkLoaiGv, ref System.String checkTinhTrang, ref System.String checkDonVi);
		
		#endregion
		
		#region cust_GiangVien_GetTienCanTren 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetTienCanTren' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetTienCanTren(System.String namHoc, System.String hocKy, System.String maLoaiGiangVien)
		{
			return GetTienCanTren(null, 0, int.MaxValue , namHoc, hocKy, maLoaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetTienCanTren' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetTienCanTren(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maLoaiGiangVien)
		{
			return GetTienCanTren(null, start, pageLength , namHoc, hocKy, maLoaiGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetTienCanTren' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetTienCanTren(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maLoaiGiangVien)
		{
			return GetTienCanTren(transactionManager, 0, int.MaxValue , namHoc, hocKy, maLoaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetTienCanTren' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetTienCanTren(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maLoaiGiangVien);
		
		#endregion
		
		#region cust_GiangVien_GetThongKeCanBoNhanVienByNgay 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetThongKeCanBoNhanVienByNgay' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThongKeCanBoNhanVienByNgay(System.DateTime ngay)
		{
			return GetThongKeCanBoNhanVienByNgay(null, 0, int.MaxValue , ngay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetThongKeCanBoNhanVienByNgay' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThongKeCanBoNhanVienByNgay(int start, int pageLength, System.DateTime ngay)
		{
			return GetThongKeCanBoNhanVienByNgay(null, start, pageLength , ngay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetThongKeCanBoNhanVienByNgay' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThongKeCanBoNhanVienByNgay(TransactionManager transactionManager, System.DateTime ngay)
		{
			return GetThongKeCanBoNhanVienByNgay(transactionManager, 0, int.MaxValue , ngay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetThongKeCanBoNhanVienByNgay' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetThongKeCanBoNhanVienByNgay(TransactionManager transactionManager, int start, int pageLength , System.DateTime ngay);
		
		#endregion
		
		#region cust_GiangVien_GetMaDonViMaTinhTrang 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetMaDonViMaTinhTrang' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maTinhTrang"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVien&gt;"/> instance.</returns>
		public TList<GiangVien> GetMaDonViMaTinhTrang(System.String maDonVi, System.Int32 maTinhTrang)
		{
			return GetMaDonViMaTinhTrang(null, 0, int.MaxValue , maDonVi, maTinhTrang);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetMaDonViMaTinhTrang' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maTinhTrang"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVien&gt;"/> instance.</returns>
		public TList<GiangVien> GetMaDonViMaTinhTrang(int start, int pageLength, System.String maDonVi, System.Int32 maTinhTrang)
		{
			return GetMaDonViMaTinhTrang(null, start, pageLength , maDonVi, maTinhTrang);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetMaDonViMaTinhTrang' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maTinhTrang"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVien&gt;"/> instance.</returns>
		public TList<GiangVien> GetMaDonViMaTinhTrang(TransactionManager transactionManager, System.String maDonVi, System.Int32 maTinhTrang)
		{
			return GetMaDonViMaTinhTrang(transactionManager, 0, int.MaxValue , maDonVi, maTinhTrang);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetMaDonViMaTinhTrang' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maTinhTrang"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVien&gt;"/> instance.</returns>
		public abstract TList<GiangVien> GetMaDonViMaTinhTrang(TransactionManager transactionManager, int start, int pageLength , System.String maDonVi, System.Int32 maTinhTrang);
		
		#endregion
		
		#region cust_GiangVien_HoatDongNgoaiGiangDay_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader HoatDongNgoaiGiangDay_GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return HoatDongNgoaiGiangDay_GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader HoatDongNgoaiGiangDay_GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return HoatDongNgoaiGiangDay_GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader HoatDongNgoaiGiangDay_GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return HoatDongNgoaiGiangDay_GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader HoatDongNgoaiGiangDay_GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_GiangVien_GetSoTietNghiaVuByMaQuanLyNamHocHocKy_Act 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetSoTietNghiaVuByMaQuanLyNamHocHocKy_Act' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="tietNghiaVu"> A <c>System.Double</c> instance.</param>
			/// <param name="tietNghiaVuKhac"> A <c>System.Double</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetSoTietNghiaVuByMaQuanLyNamHocHocKy_Act(System.String maQuanLy, System.String namHoc, System.String hocKy, ref System.Double tietNghiaVu, ref System.Double tietNghiaVuKhac)
		{
			 GetSoTietNghiaVuByMaQuanLyNamHocHocKy_Act(null, 0, int.MaxValue , maQuanLy, namHoc, hocKy, ref tietNghiaVu, ref tietNghiaVuKhac);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetSoTietNghiaVuByMaQuanLyNamHocHocKy_Act' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="tietNghiaVu"> A <c>System.Double</c> instance.</param>
			/// <param name="tietNghiaVuKhac"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetSoTietNghiaVuByMaQuanLyNamHocHocKy_Act(int start, int pageLength, System.String maQuanLy, System.String namHoc, System.String hocKy, ref System.Double tietNghiaVu, ref System.Double tietNghiaVuKhac)
		{
			 GetSoTietNghiaVuByMaQuanLyNamHocHocKy_Act(null, start, pageLength , maQuanLy, namHoc, hocKy, ref tietNghiaVu, ref tietNghiaVuKhac);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetSoTietNghiaVuByMaQuanLyNamHocHocKy_Act' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="tietNghiaVu"> A <c>System.Double</c> instance.</param>
			/// <param name="tietNghiaVuKhac"> A <c>System.Double</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetSoTietNghiaVuByMaQuanLyNamHocHocKy_Act(TransactionManager transactionManager, System.String maQuanLy, System.String namHoc, System.String hocKy, ref System.Double tietNghiaVu, ref System.Double tietNghiaVuKhac)
		{
			 GetSoTietNghiaVuByMaQuanLyNamHocHocKy_Act(transactionManager, 0, int.MaxValue , maQuanLy, namHoc, hocKy, ref tietNghiaVu, ref tietNghiaVuKhac);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetSoTietNghiaVuByMaQuanLyNamHocHocKy_Act' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="tietNghiaVu"> A <c>System.Double</c> instance.</param>
			/// <param name="tietNghiaVuKhac"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetSoTietNghiaVuByMaQuanLyNamHocHocKy_Act(TransactionManager transactionManager, int start, int pageLength , System.String maQuanLy, System.String namHoc, System.String hocKy, ref System.Double tietNghiaVu, ref System.Double tietNghiaVuKhac);
		
		#endregion
		
		#region cust_GiangVien_HoatDongNgoaiGiangDay_GetByNamHoc 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader HoatDongNgoaiGiangDay_GetByNamHoc(System.String namHoc)
		{
			return HoatDongNgoaiGiangDay_GetByNamHoc(null, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader HoatDongNgoaiGiangDay_GetByNamHoc(int start, int pageLength, System.String namHoc)
		{
			return HoatDongNgoaiGiangDay_GetByNamHoc(null, start, pageLength , namHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader HoatDongNgoaiGiangDay_GetByNamHoc(TransactionManager transactionManager, System.String namHoc)
		{
			return HoatDongNgoaiGiangDay_GetByNamHoc(transactionManager, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader HoatDongNgoaiGiangDay_GetByNamHoc(TransactionManager transactionManager, int start, int pageLength , System.String namHoc);
		
		#endregion
		
		#region cust_GiangVien_ThongKeHopDongTheoThoiGian 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ThongKeHopDongTheoThoiGian' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeHopDongTheoThoiGian(System.String maDonVi, System.DateTime ngay)
		{
			return ThongKeHopDongTheoThoiGian(null, 0, int.MaxValue , maDonVi, ngay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ThongKeHopDongTheoThoiGian' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeHopDongTheoThoiGian(int start, int pageLength, System.String maDonVi, System.DateTime ngay)
		{
			return ThongKeHopDongTheoThoiGian(null, start, pageLength , maDonVi, ngay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ThongKeHopDongTheoThoiGian' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeHopDongTheoThoiGian(TransactionManager transactionManager, System.String maDonVi, System.DateTime ngay)
		{
			return ThongKeHopDongTheoThoiGian(transactionManager, 0, int.MaxValue , maDonVi, ngay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ThongKeHopDongTheoThoiGian' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeHopDongTheoThoiGian(TransactionManager transactionManager, int start, int pageLength , System.String maDonVi, System.DateTime ngay);
		
		#endregion
		
		#region cust_GiangVien_NghienCuuKH_GetBangThanhToan 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_GetBangThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader NghienCuuKH_GetBangThanhToan(System.String namHoc, System.String khoaDonVi)
		{
			return NghienCuuKH_GetBangThanhToan(null, 0, int.MaxValue , namHoc, khoaDonVi);
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
		public IDataReader NghienCuuKH_GetBangThanhToan(int start, int pageLength, System.String namHoc, System.String khoaDonVi)
		{
			return NghienCuuKH_GetBangThanhToan(null, start, pageLength , namHoc, khoaDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_GetBangThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader NghienCuuKH_GetBangThanhToan(TransactionManager transactionManager, System.String namHoc, System.String khoaDonVi)
		{
			return NghienCuuKH_GetBangThanhToan(transactionManager, 0, int.MaxValue , namHoc, khoaDonVi);
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
		public abstract IDataReader NghienCuuKH_GetBangThanhToan(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String khoaDonVi);
		
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
		public void NghienCuuKH_Update(System.Int32 id, System.String maQuanLy, System.Int32 maNckh, System.String namHoc, System.String tenNckh, System.Int32 soLuongThanhVien, System.Int32 maVaiTro, System.Boolean duKien, ref System.String reval)
		{
			 NghienCuuKH_Update(null, 0, int.MaxValue , id, maQuanLy, maNckh, namHoc, tenNckh, soLuongThanhVien, maVaiTro, duKien, ref reval);
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
		public void NghienCuuKH_Update(int start, int pageLength, System.Int32 id, System.String maQuanLy, System.Int32 maNckh, System.String namHoc, System.String tenNckh, System.Int32 soLuongThanhVien, System.Int32 maVaiTro, System.Boolean duKien, ref System.String reval)
		{
			 NghienCuuKH_Update(null, start, pageLength , id, maQuanLy, maNckh, namHoc, tenNckh, soLuongThanhVien, maVaiTro, duKien, ref reval);
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
		public void NghienCuuKH_Update(TransactionManager transactionManager, System.Int32 id, System.String maQuanLy, System.Int32 maNckh, System.String namHoc, System.String tenNckh, System.Int32 soLuongThanhVien, System.Int32 maVaiTro, System.Boolean duKien, ref System.String reval)
		{
			 NghienCuuKH_Update(transactionManager, 0, int.MaxValue , id, maQuanLy, maNckh, namHoc, tenNckh, soLuongThanhVien, maVaiTro, duKien, ref reval);
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
		public abstract void NghienCuuKH_Update(TransactionManager transactionManager, int start, int pageLength , System.Int32 id, System.String maQuanLy, System.Int32 maNckh, System.String namHoc, System.String tenNckh, System.Int32 soLuongThanhVien, System.Int32 maVaiTro, System.Boolean duKien, ref System.String reval);
		
		#endregion
		
		#region cust_GiangVien_GetByNhomQuyen 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetByNhomQuyen' stored procedure. 
		/// </summary>
		/// <param name="nhomQuyen"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVien&gt;"/> instance.</returns>
		public TList<GiangVien> GetByNhomQuyen(System.String nhomQuyen)
		{
			return GetByNhomQuyen(null, 0, int.MaxValue , nhomQuyen);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetByNhomQuyen' stored procedure. 
		/// </summary>
		/// <param name="nhomQuyen"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVien&gt;"/> instance.</returns>
		public TList<GiangVien> GetByNhomQuyen(int start, int pageLength, System.String nhomQuyen)
		{
			return GetByNhomQuyen(null, start, pageLength , nhomQuyen);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetByNhomQuyen' stored procedure. 
		/// </summary>
		/// <param name="nhomQuyen"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVien&gt;"/> instance.</returns>
		public TList<GiangVien> GetByNhomQuyen(TransactionManager transactionManager, System.String nhomQuyen)
		{
			return GetByNhomQuyen(transactionManager, 0, int.MaxValue , nhomQuyen);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetByNhomQuyen' stored procedure. 
		/// </summary>
		/// <param name="nhomQuyen"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVien&gt;"/> instance.</returns>
		public abstract TList<GiangVien> GetByNhomQuyen(TransactionManager transactionManager, int start, int pageLength , System.String nhomQuyen);
		
		#endregion
		
		#region cust_GiangVien_TrichXuatThongTinTheoChuyenMonTrinhDo 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_TrichXuatThongTinTheoChuyenMonTrinhDo' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="listHocHam"> A <c>System.String</c> instance.</param>
		/// <param name="listHocVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader TrichXuatThongTinTheoChuyenMonTrinhDo(System.DateTime ngay, System.String listHocHam, System.String listHocVi)
		{
			return TrichXuatThongTinTheoChuyenMonTrinhDo(null, 0, int.MaxValue , ngay, listHocHam, listHocVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_TrichXuatThongTinTheoChuyenMonTrinhDo' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="listHocHam"> A <c>System.String</c> instance.</param>
		/// <param name="listHocVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader TrichXuatThongTinTheoChuyenMonTrinhDo(int start, int pageLength, System.DateTime ngay, System.String listHocHam, System.String listHocVi)
		{
			return TrichXuatThongTinTheoChuyenMonTrinhDo(null, start, pageLength , ngay, listHocHam, listHocVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_TrichXuatThongTinTheoChuyenMonTrinhDo' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="listHocHam"> A <c>System.String</c> instance.</param>
		/// <param name="listHocVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader TrichXuatThongTinTheoChuyenMonTrinhDo(TransactionManager transactionManager, System.DateTime ngay, System.String listHocHam, System.String listHocVi)
		{
			return TrichXuatThongTinTheoChuyenMonTrinhDo(transactionManager, 0, int.MaxValue , ngay, listHocHam, listHocVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_TrichXuatThongTinTheoChuyenMonTrinhDo' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="listHocHam"> A <c>System.String</c> instance.</param>
		/// <param name="listHocVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader TrichXuatThongTinTheoChuyenMonTrinhDo(TransactionManager transactionManager, int start, int pageLength , System.DateTime ngay, System.String listHocHam, System.String listHocVi);
		
		#endregion
		
		#region cust_GiangVien_LopHocPhan_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_LopHocPhan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader LopHocPhan_GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return LopHocPhan_GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_LopHocPhan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader LopHocPhan_GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return LopHocPhan_GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_LopHocPhan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader LopHocPhan_GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return LopHocPhan_GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_LopHocPhan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader LopHocPhan_GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_GiangVien_DinhMucKhauTru_GetByNamHocHocKyMaDonVi 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_DinhMucKhauTru_GetByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader DinhMucKhauTru_GetByNamHocHocKyMaDonVi(System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return DinhMucKhauTru_GetByNamHocHocKyMaDonVi(null, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_DinhMucKhauTru_GetByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader DinhMucKhauTru_GetByNamHocHocKyMaDonVi(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return DinhMucKhauTru_GetByNamHocHocKyMaDonVi(null, start, pageLength , namHoc, hocKy, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_DinhMucKhauTru_GetByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader DinhMucKhauTru_GetByNamHocHocKyMaDonVi(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return DinhMucKhauTru_GetByNamHocHocKyMaDonVi(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_DinhMucKhauTru_GetByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader DinhMucKhauTru_GetByNamHocHocKyMaDonVi(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi);
		
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
		public void NghienCuuKH_Luu(System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 NghienCuuKH_Luu(null, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
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
		public void NghienCuuKH_Luu(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 NghienCuuKH_Luu(null, start, pageLength , xmlData, namHoc, hocKy, ref reVal);
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
		public void NghienCuuKH_Luu(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 NghienCuuKH_Luu(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
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
		public abstract void NghienCuuKH_Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_GiangVien_ThongKeGioGiangBuh 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ThongKeGioGiangBuh' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeGioGiangBuh(System.String namHoc, System.String donVi, System.String loaiGiangVien, System.Int32 lanChotHk01, System.Int32 lanChotHk02)
		{
			return ThongKeGioGiangBuh(null, 0, int.MaxValue , namHoc, donVi, loaiGiangVien, lanChotHk01, lanChotHk02);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ThongKeGioGiangBuh' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeGioGiangBuh(int start, int pageLength, System.String namHoc, System.String donVi, System.String loaiGiangVien, System.Int32 lanChotHk01, System.Int32 lanChotHk02)
		{
			return ThongKeGioGiangBuh(null, start, pageLength , namHoc, donVi, loaiGiangVien, lanChotHk01, lanChotHk02);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ThongKeGioGiangBuh' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeGioGiangBuh(TransactionManager transactionManager, System.String namHoc, System.String donVi, System.String loaiGiangVien, System.Int32 lanChotHk01, System.Int32 lanChotHk02)
		{
			return ThongKeGioGiangBuh(transactionManager, 0, int.MaxValue , namHoc, donVi, loaiGiangVien, lanChotHk01, lanChotHk02);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ThongKeGioGiangBuh' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeGioGiangBuh(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String donVi, System.String loaiGiangVien, System.Int32 lanChotHk01, System.Int32 lanChotHk02);
		
		#endregion
		
		#region cust_GiangVien_GetHeSoQuyDoiTietChuan 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetHeSoQuyDoiTietChuan' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maPhongHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetHeSoQuyDoiTietChuan(System.String maQuanLy, System.String namHoc, System.String hocKy, System.String maMonHoc, System.Int32 siSo, System.Int32 tietBatDau, System.DateTime ngayDay, System.String maPhongHoc, System.String maLopHocPhan)
		{
			return GetHeSoQuyDoiTietChuan(null, 0, int.MaxValue , maQuanLy, namHoc, hocKy, maMonHoc, siSo, tietBatDau, ngayDay, maPhongHoc, maLopHocPhan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetHeSoQuyDoiTietChuan' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maPhongHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetHeSoQuyDoiTietChuan(int start, int pageLength, System.String maQuanLy, System.String namHoc, System.String hocKy, System.String maMonHoc, System.Int32 siSo, System.Int32 tietBatDau, System.DateTime ngayDay, System.String maPhongHoc, System.String maLopHocPhan)
		{
			return GetHeSoQuyDoiTietChuan(null, start, pageLength , maQuanLy, namHoc, hocKy, maMonHoc, siSo, tietBatDau, ngayDay, maPhongHoc, maLopHocPhan);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetHeSoQuyDoiTietChuan' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maPhongHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetHeSoQuyDoiTietChuan(TransactionManager transactionManager, System.String maQuanLy, System.String namHoc, System.String hocKy, System.String maMonHoc, System.Int32 siSo, System.Int32 tietBatDau, System.DateTime ngayDay, System.String maPhongHoc, System.String maLopHocPhan)
		{
			return GetHeSoQuyDoiTietChuan(transactionManager, 0, int.MaxValue , maQuanLy, namHoc, hocKy, maMonHoc, siSo, tietBatDau, ngayDay, maPhongHoc, maLopHocPhan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetHeSoQuyDoiTietChuan' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maPhongHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetHeSoQuyDoiTietChuan(TransactionManager transactionManager, int start, int pageLength , System.String maQuanLy, System.String namHoc, System.String hocKy, System.String maMonHoc, System.Int32 siSo, System.Int32 tietBatDau, System.DateTime ngayDay, System.String maPhongHoc, System.String maLopHocPhan);
		
		#endregion
		
		#region cust_GiangVien_GetByMaGiangVienMocTangLuong 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetByMaGiangVienMocTangLuong' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaGiangVienMocTangLuong(System.DateTime ngay)
		{
			return GetByMaGiangVienMocTangLuong(null, 0, int.MaxValue , ngay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetByMaGiangVienMocTangLuong' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaGiangVienMocTangLuong(int start, int pageLength, System.DateTime ngay)
		{
			return GetByMaGiangVienMocTangLuong(null, start, pageLength , ngay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetByMaGiangVienMocTangLuong' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaGiangVienMocTangLuong(TransactionManager transactionManager, System.DateTime ngay)
		{
			return GetByMaGiangVienMocTangLuong(transactionManager, 0, int.MaxValue , ngay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetByMaGiangVienMocTangLuong' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByMaGiangVienMocTangLuong(TransactionManager transactionManager, int start, int pageLength , System.DateTime ngay);
		
		#endregion
		
		#region cust_GiangVien_GetThongTinChiTietByMaDonViLoaiGiangVienTinhTrang 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetThongTinChiTietByMaDonViLoaiGiangVienTinhTrang' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="tinhTrang"> A <c>System.String</c> instance.</param>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThongTinChiTietByMaDonViLoaiGiangVienTinhTrang(System.String maDonVi, System.String loaiGiangVien, System.String tinhTrang, System.DateTime ngay)
		{
			return GetThongTinChiTietByMaDonViLoaiGiangVienTinhTrang(null, 0, int.MaxValue , maDonVi, loaiGiangVien, tinhTrang, ngay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetThongTinChiTietByMaDonViLoaiGiangVienTinhTrang' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="tinhTrang"> A <c>System.String</c> instance.</param>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThongTinChiTietByMaDonViLoaiGiangVienTinhTrang(int start, int pageLength, System.String maDonVi, System.String loaiGiangVien, System.String tinhTrang, System.DateTime ngay)
		{
			return GetThongTinChiTietByMaDonViLoaiGiangVienTinhTrang(null, start, pageLength , maDonVi, loaiGiangVien, tinhTrang, ngay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetThongTinChiTietByMaDonViLoaiGiangVienTinhTrang' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="tinhTrang"> A <c>System.String</c> instance.</param>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThongTinChiTietByMaDonViLoaiGiangVienTinhTrang(TransactionManager transactionManager, System.String maDonVi, System.String loaiGiangVien, System.String tinhTrang, System.DateTime ngay)
		{
			return GetThongTinChiTietByMaDonViLoaiGiangVienTinhTrang(transactionManager, 0, int.MaxValue , maDonVi, loaiGiangVien, tinhTrang, ngay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetThongTinChiTietByMaDonViLoaiGiangVienTinhTrang' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="tinhTrang"> A <c>System.String</c> instance.</param>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetThongTinChiTietByMaDonViLoaiGiangVienTinhTrang(TransactionManager transactionManager, int start, int pageLength , System.String maDonVi, System.String loaiGiangVien, System.String tinhTrang, System.DateTime ngay);
		
		#endregion
		
		#region cust_GiangVien_UpdateGiangVienHRM_Temp 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_UpdateGiangVienHRM_Temp' stored procedure. 
		/// </summary>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void UpdateGiangVienHRM_Temp()
		{
			 UpdateGiangVienHRM_Temp(null, 0, int.MaxValue );
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_UpdateGiangVienHRM_Temp' stored procedure. 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void UpdateGiangVienHRM_Temp(int start, int pageLength)
		{
			 UpdateGiangVienHRM_Temp(null, start, pageLength );
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_UpdateGiangVienHRM_Temp' stored procedure. 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void UpdateGiangVienHRM_Temp(TransactionManager transactionManager)
		{
			 UpdateGiangVienHRM_Temp(transactionManager, 0, int.MaxValue );
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_UpdateGiangVienHRM_Temp' stored procedure. 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void UpdateGiangVienHRM_Temp(TransactionManager transactionManager, int start, int pageLength );
		
		#endregion
		
		#region cust_GiangVien_GetByMaDonViLoaiGiangVien 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetByMaDonViLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="tinhTrang"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaDonViLoaiGiangVien(System.String maDonVi, System.String loaiGiangVien, System.String tinhTrang)
		{
			return GetByMaDonViLoaiGiangVien(null, 0, int.MaxValue , maDonVi, loaiGiangVien, tinhTrang);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetByMaDonViLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="tinhTrang"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaDonViLoaiGiangVien(int start, int pageLength, System.String maDonVi, System.String loaiGiangVien, System.String tinhTrang)
		{
			return GetByMaDonViLoaiGiangVien(null, start, pageLength , maDonVi, loaiGiangVien, tinhTrang);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetByMaDonViLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="tinhTrang"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaDonViLoaiGiangVien(TransactionManager transactionManager, System.String maDonVi, System.String loaiGiangVien, System.String tinhTrang)
		{
			return GetByMaDonViLoaiGiangVien(transactionManager, 0, int.MaxValue , maDonVi, loaiGiangVien, tinhTrang);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetByMaDonViLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="tinhTrang"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByMaDonViLoaiGiangVien(TransactionManager transactionManager, int start, int pageLength , System.String maDonVi, System.String loaiGiangVien, System.String tinhTrang);
		
		#endregion
		
		#region cust_GiangVien_DinhMucKhauTru_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_DinhMucKhauTru_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader DinhMucKhauTru_GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return DinhMucKhauTru_GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_DinhMucKhauTru_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader DinhMucKhauTru_GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return DinhMucKhauTru_GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_DinhMucKhauTru_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader DinhMucKhauTru_GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return DinhMucKhauTru_GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_DinhMucKhauTru_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader DinhMucKhauTru_GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_GiangVien_UpdatePassWord 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_UpdatePassWord' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="matKhau"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader UpdatePassWord(System.Int32 maGiangVien, System.String matKhau)
		{
			return UpdatePassWord(null, 0, int.MaxValue , maGiangVien, matKhau);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_UpdatePassWord' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="matKhau"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader UpdatePassWord(int start, int pageLength, System.Int32 maGiangVien, System.String matKhau)
		{
			return UpdatePassWord(null, start, pageLength , maGiangVien, matKhau);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_UpdatePassWord' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="matKhau"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader UpdatePassWord(TransactionManager transactionManager, System.Int32 maGiangVien, System.String matKhau)
		{
			return UpdatePassWord(transactionManager, 0, int.MaxValue , maGiangVien, matKhau);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_UpdatePassWord' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="matKhau"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader UpdatePassWord(TransactionManager transactionManager, int start, int pageLength , System.Int32 maGiangVien, System.String matKhau);
		
		#endregion
		
		#region cust_GiangVien_HoatDongNgoaiGiangDay_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HoatDongNgoaiGiangDay_Luu(System.String xmlData, System.String maDonVi, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 HoatDongNgoaiGiangDay_Luu(null, 0, int.MaxValue , xmlData, maDonVi, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HoatDongNgoaiGiangDay_Luu(int start, int pageLength, System.String xmlData, System.String maDonVi, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 HoatDongNgoaiGiangDay_Luu(null, start, pageLength , xmlData, maDonVi, namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HoatDongNgoaiGiangDay_Luu(TransactionManager transactionManager, System.String xmlData, System.String maDonVi, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 HoatDongNgoaiGiangDay_Luu(transactionManager, 0, int.MaxValue , xmlData, maDonVi, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void HoatDongNgoaiGiangDay_Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String maDonVi, System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_GiangVien_KiemTraTrungTenCmnd 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_KiemTraTrungTenCmnd' stored procedure. 
		/// </summary>
		/// <param name="hoTen"> A <c>System.String</c> instance.</param>
		/// <param name="cmnd"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraTrungTenCmnd(System.String hoTen, System.String cmnd, ref System.Int32 reVal)
		{
			 KiemTraTrungTenCmnd(null, 0, int.MaxValue , hoTen, cmnd, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_KiemTraTrungTenCmnd' stored procedure. 
		/// </summary>
		/// <param name="hoTen"> A <c>System.String</c> instance.</param>
		/// <param name="cmnd"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraTrungTenCmnd(int start, int pageLength, System.String hoTen, System.String cmnd, ref System.Int32 reVal)
		{
			 KiemTraTrungTenCmnd(null, start, pageLength , hoTen, cmnd, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_KiemTraTrungTenCmnd' stored procedure. 
		/// </summary>
		/// <param name="hoTen"> A <c>System.String</c> instance.</param>
		/// <param name="cmnd"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraTrungTenCmnd(TransactionManager transactionManager, System.String hoTen, System.String cmnd, ref System.Int32 reVal)
		{
			 KiemTraTrungTenCmnd(transactionManager, 0, int.MaxValue , hoTen, cmnd, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_KiemTraTrungTenCmnd' stored procedure. 
		/// </summary>
		/// <param name="hoTen"> A <c>System.String</c> instance.</param>
		/// <param name="cmnd"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void KiemTraTrungTenCmnd(TransactionManager transactionManager, int start, int pageLength , System.String hoTen, System.String cmnd, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_GiangVien_GetByMaDonVi 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetByMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVien&gt;"/> instance.</returns>
		public TList<GiangVien> GetByMaDonVi(System.String maDonVi)
		{
			return GetByMaDonVi(null, 0, int.MaxValue , maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetByMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVien&gt;"/> instance.</returns>
		public TList<GiangVien> GetByMaDonVi(int start, int pageLength, System.String maDonVi)
		{
			return GetByMaDonVi(null, start, pageLength , maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetByMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVien&gt;"/> instance.</returns>
		public TList<GiangVien> GetByMaDonVi(TransactionManager transactionManager, System.String maDonVi)
		{
			return GetByMaDonVi(transactionManager, 0, int.MaxValue , maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetByMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVien&gt;"/> instance.</returns>
		public abstract TList<GiangVien> GetByMaDonVi(TransactionManager transactionManager, int start, int pageLength , System.String maDonVi);
		
		#endregion
		
		#region cust_GiangVien_GetMaDonViMaHocHamMaHocVi 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetMaDonViMaHocHamMaHocVi' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVien&gt;"/> instance.</returns>
		public TList<GiangVien> GetMaDonViMaHocHamMaHocVi(System.String maDonVi, System.Int32 maHocHam, System.Int32 maHocVi)
		{
			return GetMaDonViMaHocHamMaHocVi(null, 0, int.MaxValue , maDonVi, maHocHam, maHocVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetMaDonViMaHocHamMaHocVi' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVien&gt;"/> instance.</returns>
		public TList<GiangVien> GetMaDonViMaHocHamMaHocVi(int start, int pageLength, System.String maDonVi, System.Int32 maHocHam, System.Int32 maHocVi)
		{
			return GetMaDonViMaHocHamMaHocVi(null, start, pageLength , maDonVi, maHocHam, maHocVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetMaDonViMaHocHamMaHocVi' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVien&gt;"/> instance.</returns>
		public TList<GiangVien> GetMaDonViMaHocHamMaHocVi(TransactionManager transactionManager, System.String maDonVi, System.Int32 maHocHam, System.Int32 maHocVi)
		{
			return GetMaDonViMaHocHamMaHocVi(transactionManager, 0, int.MaxValue , maDonVi, maHocHam, maHocVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetMaDonViMaHocHamMaHocVi' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVien&gt;"/> instance.</returns>
		public abstract TList<GiangVien> GetMaDonViMaHocHamMaHocVi(TransactionManager transactionManager, int start, int pageLength , System.String maDonVi, System.Int32 maHocHam, System.Int32 maHocVi);
		
		#endregion
		
		#region cust_GiangVien_GetHeSoQuyDoiTietChuanChung 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetHeSoQuyDoiTietChuanChung' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="maLopSinhVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
		/// <param name="thuTrongTuan"> A <c>System.String</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <param name="maPhongHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="daoTaoTinChi"> A <c>System.Boolean</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetHeSoQuyDoiTietChuanChung(System.String namHoc, System.String hocKy, System.String maBacDaoTao, System.String maLopHocPhan, System.String maMonHoc, System.Int32 siSo, System.String maLopSinhVien, System.String maLoaiHocPhan, System.DateTime ngayDay, System.Int32 tietBatDau, System.String thuTrongTuan, System.Int32 maHocHam, System.Int32 maHocVi, System.String maPhongHoc, System.String maKhoaBoMon, System.Boolean daoTaoTinChi, System.Int32 maLoaiGiangVien)
		{
			return GetHeSoQuyDoiTietChuanChung(null, 0, int.MaxValue , namHoc, hocKy, maBacDaoTao, maLopHocPhan, maMonHoc, siSo, maLopSinhVien, maLoaiHocPhan, ngayDay, tietBatDau, thuTrongTuan, maHocHam, maHocVi, maPhongHoc, maKhoaBoMon, daoTaoTinChi, maLoaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetHeSoQuyDoiTietChuanChung' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="maLopSinhVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
		/// <param name="thuTrongTuan"> A <c>System.String</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <param name="maPhongHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="daoTaoTinChi"> A <c>System.Boolean</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetHeSoQuyDoiTietChuanChung(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maBacDaoTao, System.String maLopHocPhan, System.String maMonHoc, System.Int32 siSo, System.String maLopSinhVien, System.String maLoaiHocPhan, System.DateTime ngayDay, System.Int32 tietBatDau, System.String thuTrongTuan, System.Int32 maHocHam, System.Int32 maHocVi, System.String maPhongHoc, System.String maKhoaBoMon, System.Boolean daoTaoTinChi, System.Int32 maLoaiGiangVien)
		{
			return GetHeSoQuyDoiTietChuanChung(null, start, pageLength , namHoc, hocKy, maBacDaoTao, maLopHocPhan, maMonHoc, siSo, maLopSinhVien, maLoaiHocPhan, ngayDay, tietBatDau, thuTrongTuan, maHocHam, maHocVi, maPhongHoc, maKhoaBoMon, daoTaoTinChi, maLoaiGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetHeSoQuyDoiTietChuanChung' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="maLopSinhVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
		/// <param name="thuTrongTuan"> A <c>System.String</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <param name="maPhongHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="daoTaoTinChi"> A <c>System.Boolean</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetHeSoQuyDoiTietChuanChung(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maBacDaoTao, System.String maLopHocPhan, System.String maMonHoc, System.Int32 siSo, System.String maLopSinhVien, System.String maLoaiHocPhan, System.DateTime ngayDay, System.Int32 tietBatDau, System.String thuTrongTuan, System.Int32 maHocHam, System.Int32 maHocVi, System.String maPhongHoc, System.String maKhoaBoMon, System.Boolean daoTaoTinChi, System.Int32 maLoaiGiangVien)
		{
			return GetHeSoQuyDoiTietChuanChung(transactionManager, 0, int.MaxValue , namHoc, hocKy, maBacDaoTao, maLopHocPhan, maMonHoc, siSo, maLopSinhVien, maLoaiHocPhan, ngayDay, tietBatDau, thuTrongTuan, maHocHam, maHocVi, maPhongHoc, maKhoaBoMon, daoTaoTinChi, maLoaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetHeSoQuyDoiTietChuanChung' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="maLopSinhVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
		/// <param name="thuTrongTuan"> A <c>System.String</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <param name="maPhongHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="daoTaoTinChi"> A <c>System.Boolean</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetHeSoQuyDoiTietChuanChung(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maBacDaoTao, System.String maLopHocPhan, System.String maMonHoc, System.Int32 siSo, System.String maLopSinhVien, System.String maLoaiHocPhan, System.DateTime ngayDay, System.Int32 tietBatDau, System.String thuTrongTuan, System.Int32 maHocHam, System.Int32 maHocVi, System.String maPhongHoc, System.String maKhoaBoMon, System.Boolean daoTaoTinChi, System.Int32 maLoaiGiangVien);
		
		#endregion
		
		#region cust_GiangVien_GetChucVuByMaGiangVienNgay 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetChucVuByMaGiangVienNgay' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
			/// <param name="tenChucVu"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetChucVuByMaGiangVienNgay(System.Int32 maGiangVien, System.DateTime ngay, ref System.String tenChucVu)
		{
			 GetChucVuByMaGiangVienNgay(null, 0, int.MaxValue , maGiangVien, ngay, ref tenChucVu);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetChucVuByMaGiangVienNgay' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
			/// <param name="tenChucVu"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetChucVuByMaGiangVienNgay(int start, int pageLength, System.Int32 maGiangVien, System.DateTime ngay, ref System.String tenChucVu)
		{
			 GetChucVuByMaGiangVienNgay(null, start, pageLength , maGiangVien, ngay, ref tenChucVu);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetChucVuByMaGiangVienNgay' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
			/// <param name="tenChucVu"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetChucVuByMaGiangVienNgay(TransactionManager transactionManager, System.Int32 maGiangVien, System.DateTime ngay, ref System.String tenChucVu)
		{
			 GetChucVuByMaGiangVienNgay(transactionManager, 0, int.MaxValue , maGiangVien, ngay, ref tenChucVu);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetChucVuByMaGiangVienNgay' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
			/// <param name="tenChucVu"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetChucVuByMaGiangVienNgay(TransactionManager transactionManager, int start, int pageLength , System.Int32 maGiangVien, System.DateTime ngay, ref System.String tenChucVu);
		
		#endregion
		
		#region cust_GiangVien_ResetPassword 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ResetPassword' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ResetPassword(System.String maQuanLy)
		{
			return ResetPassword(null, 0, int.MaxValue , maQuanLy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ResetPassword' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ResetPassword(int start, int pageLength, System.String maQuanLy)
		{
			return ResetPassword(null, start, pageLength , maQuanLy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ResetPassword' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ResetPassword(TransactionManager transactionManager, System.String maQuanLy)
		{
			return ResetPassword(transactionManager, 0, int.MaxValue , maQuanLy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ResetPassword' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ResetPassword(TransactionManager transactionManager, int start, int pageLength , System.String maQuanLy);
		
		#endregion
		
		#region cust_GiangVien_GetDanhSachGiangVienCoHuuByNgay 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetDanhSachGiangVienCoHuuByNgay' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDanhSachGiangVienCoHuuByNgay(System.DateTime ngay)
		{
			return GetDanhSachGiangVienCoHuuByNgay(null, 0, int.MaxValue , ngay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetDanhSachGiangVienCoHuuByNgay' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDanhSachGiangVienCoHuuByNgay(int start, int pageLength, System.DateTime ngay)
		{
			return GetDanhSachGiangVienCoHuuByNgay(null, start, pageLength , ngay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetDanhSachGiangVienCoHuuByNgay' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDanhSachGiangVienCoHuuByNgay(TransactionManager transactionManager, System.DateTime ngay)
		{
			return GetDanhSachGiangVienCoHuuByNgay(transactionManager, 0, int.MaxValue , ngay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetDanhSachGiangVienCoHuuByNgay' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetDanhSachGiangVienCoHuuByNgay(TransactionManager transactionManager, int start, int pageLength , System.DateTime ngay);
		
		#endregion
		
		#region cust_GiangVien_ChuyenMon_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ChuyenMon_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ChuyenMon_Luu(System.String xmlData, System.String maGiangVien)
		{
			 ChuyenMon_Luu(null, 0, int.MaxValue , xmlData, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ChuyenMon_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ChuyenMon_Luu(int start, int pageLength, System.String xmlData, System.String maGiangVien)
		{
			 ChuyenMon_Luu(null, start, pageLength , xmlData, maGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ChuyenMon_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ChuyenMon_Luu(TransactionManager transactionManager, System.String xmlData, System.String maGiangVien)
		{
			 ChuyenMon_Luu(transactionManager, 0, int.MaxValue , xmlData, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ChuyenMon_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void ChuyenMon_Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String maGiangVien);
		
		#endregion
		
		#region cust_GiangVien_ThongKeHoSoGiangVien 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ThongKeHoSoGiangVien' stored procedure. 
		/// </summary>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeHoSoGiangVien(System.String khoaDonVi)
		{
			return ThongKeHoSoGiangVien(null, 0, int.MaxValue , khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ThongKeHoSoGiangVien' stored procedure. 
		/// </summary>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeHoSoGiangVien(int start, int pageLength, System.String khoaDonVi)
		{
			return ThongKeHoSoGiangVien(null, start, pageLength , khoaDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ThongKeHoSoGiangVien' stored procedure. 
		/// </summary>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeHoSoGiangVien(TransactionManager transactionManager, System.String khoaDonVi)
		{
			return ThongKeHoSoGiangVien(transactionManager, 0, int.MaxValue , khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ThongKeHoSoGiangVien' stored procedure. 
		/// </summary>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeHoSoGiangVien(TransactionManager transactionManager, int start, int pageLength , System.String khoaDonVi);
		
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
		public void NghienCuuKH_LuuTheoKhoa(System.String xmlData, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 NghienCuuKH_LuuTheoKhoa(null, 0, int.MaxValue , xmlData, namHoc, hocKy, maDonVi, ref reVal);
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
		public void NghienCuuKH_LuuTheoKhoa(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 NghienCuuKH_LuuTheoKhoa(null, start, pageLength , xmlData, namHoc, hocKy, maDonVi, ref reVal);
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
		public void NghienCuuKH_LuuTheoKhoa(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 NghienCuuKH_LuuTheoKhoa(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, maDonVi, ref reVal);
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
		public abstract void NghienCuuKH_LuuTheoKhoa(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal);
		
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
		public IDataReader NghienCuuKH_GetLichSuNghienCuuKhoaHoc(System.Int32 maGiangVien, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return NghienCuuKH_GetLichSuNghienCuuKhoaHoc(null, 0, int.MaxValue , maGiangVien, tuNgay, denNgay);
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
		public IDataReader NghienCuuKH_GetLichSuNghienCuuKhoaHoc(int start, int pageLength, System.Int32 maGiangVien, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return NghienCuuKH_GetLichSuNghienCuuKhoaHoc(null, start, pageLength , maGiangVien, tuNgay, denNgay);
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
		public IDataReader NghienCuuKH_GetLichSuNghienCuuKhoaHoc(TransactionManager transactionManager, System.Int32 maGiangVien, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return NghienCuuKH_GetLichSuNghienCuuKhoaHoc(transactionManager, 0, int.MaxValue , maGiangVien, tuNgay, denNgay);
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
		public abstract IDataReader NghienCuuKH_GetLichSuNghienCuuKhoaHoc(TransactionManager transactionManager, int start, int pageLength , System.Int32 maGiangVien, System.DateTime tuNgay, System.DateTime denNgay);
		
		#endregion
		
		#region cust_GiangVien_HoatDongNgoaiGiangDay_GetByNamHocHocKyKhoa 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_GetByNamHocHocKyKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader HoatDongNgoaiGiangDay_GetByNamHocHocKyKhoa(System.String namHoc, System.String hocKy, System.String maKhoa)
		{
			return HoatDongNgoaiGiangDay_GetByNamHocHocKyKhoa(null, 0, int.MaxValue , namHoc, hocKy, maKhoa);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_GetByNamHocHocKyKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader HoatDongNgoaiGiangDay_GetByNamHocHocKyKhoa(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maKhoa)
		{
			return HoatDongNgoaiGiangDay_GetByNamHocHocKyKhoa(null, start, pageLength , namHoc, hocKy, maKhoa);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_GetByNamHocHocKyKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader HoatDongNgoaiGiangDay_GetByNamHocHocKyKhoa(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maKhoa)
		{
			return HoatDongNgoaiGiangDay_GetByNamHocHocKyKhoa(transactionManager, 0, int.MaxValue , namHoc, hocKy, maKhoa);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_GetByNamHocHocKyKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader HoatDongNgoaiGiangDay_GetByNamHocHocKyKhoa(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maKhoa);
		
		#endregion
		
		#region cust_GiangVien_GetThongKeSoLuongGiangVienCoHuuTheoKhoaBoMonByNgay 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetThongKeSoLuongGiangVienCoHuuTheoKhoaBoMonByNgay' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThongKeSoLuongGiangVienCoHuuTheoKhoaBoMonByNgay(System.DateTime ngay)
		{
			return GetThongKeSoLuongGiangVienCoHuuTheoKhoaBoMonByNgay(null, 0, int.MaxValue , ngay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetThongKeSoLuongGiangVienCoHuuTheoKhoaBoMonByNgay' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThongKeSoLuongGiangVienCoHuuTheoKhoaBoMonByNgay(int start, int pageLength, System.DateTime ngay)
		{
			return GetThongKeSoLuongGiangVienCoHuuTheoKhoaBoMonByNgay(null, start, pageLength , ngay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetThongKeSoLuongGiangVienCoHuuTheoKhoaBoMonByNgay' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThongKeSoLuongGiangVienCoHuuTheoKhoaBoMonByNgay(TransactionManager transactionManager, System.DateTime ngay)
		{
			return GetThongKeSoLuongGiangVienCoHuuTheoKhoaBoMonByNgay(transactionManager, 0, int.MaxValue , ngay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetThongKeSoLuongGiangVienCoHuuTheoKhoaBoMonByNgay' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetThongKeSoLuongGiangVienCoHuuTheoKhoaBoMonByNgay(TransactionManager transactionManager, int start, int pageLength , System.DateTime ngay);
		
		#endregion
		
		#region cust_GiangVien_ChucVu_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ChucVu_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ChucVu_Luu(System.String xmlData, System.Int32 maGiangVien, ref System.Int32 reVal)
		{
			 ChucVu_Luu(null, 0, int.MaxValue , xmlData, maGiangVien, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ChucVu_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ChucVu_Luu(int start, int pageLength, System.String xmlData, System.Int32 maGiangVien, ref System.Int32 reVal)
		{
			 ChucVu_Luu(null, start, pageLength , xmlData, maGiangVien, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ChucVu_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ChucVu_Luu(TransactionManager transactionManager, System.String xmlData, System.Int32 maGiangVien, ref System.Int32 reVal)
		{
			 ChucVu_Luu(transactionManager, 0, int.MaxValue , xmlData, maGiangVien, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ChucVu_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void ChucVu_Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.Int32 maGiangVien, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_GiangVien_DinhMucKhauTru_LuuTheoKhoa 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_DinhMucKhauTru_LuuTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reval"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DinhMucKhauTru_LuuTheoKhoa(System.String xmlData, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reval)
		{
			 DinhMucKhauTru_LuuTheoKhoa(null, 0, int.MaxValue , xmlData, namHoc, hocKy, maDonVi, ref reval);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_DinhMucKhauTru_LuuTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reval"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DinhMucKhauTru_LuuTheoKhoa(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reval)
		{
			 DinhMucKhauTru_LuuTheoKhoa(null, start, pageLength , xmlData, namHoc, hocKy, maDonVi, ref reval);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_DinhMucKhauTru_LuuTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reval"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DinhMucKhauTru_LuuTheoKhoa(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reval)
		{
			 DinhMucKhauTru_LuuTheoKhoa(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, maDonVi, ref reval);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_DinhMucKhauTru_LuuTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reval"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DinhMucKhauTru_LuuTheoKhoa(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reval);
		
		#endregion
		
		#region cust_GiangVien_GetSoTietNghiaVuByMaQuanLyNamHoc 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetSoTietNghiaVuByMaQuanLyNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Double</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetSoTietNghiaVuByMaQuanLyNamHoc(System.String maQuanLy, System.String namHoc, ref System.Double ketQua)
		{
			 GetSoTietNghiaVuByMaQuanLyNamHoc(null, 0, int.MaxValue , maQuanLy, namHoc, ref ketQua);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetSoTietNghiaVuByMaQuanLyNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetSoTietNghiaVuByMaQuanLyNamHoc(int start, int pageLength, System.String maQuanLy, System.String namHoc, ref System.Double ketQua)
		{
			 GetSoTietNghiaVuByMaQuanLyNamHoc(null, start, pageLength , maQuanLy, namHoc, ref ketQua);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetSoTietNghiaVuByMaQuanLyNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Double</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetSoTietNghiaVuByMaQuanLyNamHoc(TransactionManager transactionManager, System.String maQuanLy, System.String namHoc, ref System.Double ketQua)
		{
			 GetSoTietNghiaVuByMaQuanLyNamHoc(transactionManager, 0, int.MaxValue , maQuanLy, namHoc, ref ketQua);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetSoTietNghiaVuByMaQuanLyNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetSoTietNghiaVuByMaQuanLyNamHoc(TransactionManager transactionManager, int start, int pageLength , System.String maQuanLy, System.String namHoc, ref System.Double ketQua);
		
		#endregion
		
		#region cust_GiangVien_GioDinhMucCuaGiangVien 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GioDinhMucCuaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GioDinhMucCuaGiangVien(System.String namHoc, System.String hocKy, System.String maDonVi, System.String loaiGiangVien)
		{
			return GioDinhMucCuaGiangVien(null, 0, int.MaxValue , namHoc, hocKy, maDonVi, loaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GioDinhMucCuaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GioDinhMucCuaGiangVien(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi, System.String loaiGiangVien)
		{
			return GioDinhMucCuaGiangVien(null, start, pageLength , namHoc, hocKy, maDonVi, loaiGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GioDinhMucCuaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GioDinhMucCuaGiangVien(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi, System.String loaiGiangVien)
		{
			return GioDinhMucCuaGiangVien(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi, loaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GioDinhMucCuaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GioDinhMucCuaGiangVien(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi, System.String loaiGiangVien);
		
		#endregion
		
		#region cust_GiangVien_GetSoTietNghiaVuByMaQuanLyNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetSoTietNghiaVuByMaQuanLyNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Double</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetSoTietNghiaVuByMaQuanLyNamHocHocKy(System.String maQuanLy, System.String namHoc, System.String hocKy, ref System.Double ketQua)
		{
			 GetSoTietNghiaVuByMaQuanLyNamHocHocKy(null, 0, int.MaxValue , maQuanLy, namHoc, hocKy, ref ketQua);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetSoTietNghiaVuByMaQuanLyNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetSoTietNghiaVuByMaQuanLyNamHocHocKy(int start, int pageLength, System.String maQuanLy, System.String namHoc, System.String hocKy, ref System.Double ketQua)
		{
			 GetSoTietNghiaVuByMaQuanLyNamHocHocKy(null, start, pageLength , maQuanLy, namHoc, hocKy, ref ketQua);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetSoTietNghiaVuByMaQuanLyNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Double</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetSoTietNghiaVuByMaQuanLyNamHocHocKy(TransactionManager transactionManager, System.String maQuanLy, System.String namHoc, System.String hocKy, ref System.Double ketQua)
		{
			 GetSoTietNghiaVuByMaQuanLyNamHocHocKy(transactionManager, 0, int.MaxValue , maQuanLy, namHoc, hocKy, ref ketQua);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetSoTietNghiaVuByMaQuanLyNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetSoTietNghiaVuByMaQuanLyNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String maQuanLy, System.String namHoc, System.String hocKy, ref System.Double ketQua);
		
		#endregion
		
		#region cust_GiangVien_NghienCuuKH_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader NghienCuuKH_GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return NghienCuuKH_GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
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
		public IDataReader NghienCuuKH_GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return NghienCuuKH_GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader NghienCuuKH_GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return NghienCuuKH_GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
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
		public abstract IDataReader NghienCuuKH_GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_GiangVien_GetThongKeSoLuongGiangVienTheoKhoaBoMonByNgay 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetThongKeSoLuongGiangVienTheoKhoaBoMonByNgay' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThongKeSoLuongGiangVienTheoKhoaBoMonByNgay(System.DateTime ngay)
		{
			return GetThongKeSoLuongGiangVienTheoKhoaBoMonByNgay(null, 0, int.MaxValue , ngay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetThongKeSoLuongGiangVienTheoKhoaBoMonByNgay' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThongKeSoLuongGiangVienTheoKhoaBoMonByNgay(int start, int pageLength, System.DateTime ngay)
		{
			return GetThongKeSoLuongGiangVienTheoKhoaBoMonByNgay(null, start, pageLength , ngay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetThongKeSoLuongGiangVienTheoKhoaBoMonByNgay' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThongKeSoLuongGiangVienTheoKhoaBoMonByNgay(TransactionManager transactionManager, System.DateTime ngay)
		{
			return GetThongKeSoLuongGiangVienTheoKhoaBoMonByNgay(transactionManager, 0, int.MaxValue , ngay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetThongKeSoLuongGiangVienTheoKhoaBoMonByNgay' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetThongKeSoLuongGiangVienTheoKhoaBoMonByNgay(TransactionManager transactionManager, int start, int pageLength , System.DateTime ngay);
		
		#endregion
		
		#region cust_GiangVien_GetHoTen 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetHoTen' stored procedure. 
		/// </summary>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetHoTen()
		{
			return GetHoTen(null, 0, int.MaxValue );
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetHoTen' stored procedure. 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetHoTen(int start, int pageLength)
		{
			return GetHoTen(null, start, pageLength );
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetHoTen' stored procedure. 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetHoTen(TransactionManager transactionManager)
		{
			return GetHoTen(transactionManager, 0, int.MaxValue );
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetHoTen' stored procedure. 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetHoTen(TransactionManager transactionManager, int start, int pageLength );
		
		#endregion
		
		#region cust_GiangVien_Import 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Import(System.String xmlData, ref System.Int32 reVal)
		{
			 Import(null, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_Import' stored procedure. 
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
		///	This method wrap the 'cust_GiangVien_Import' stored procedure. 
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
		///	This method wrap the 'cust_GiangVien_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Import(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_GiangVien_NghienCuuKH_Import 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void NghienCuuKH_Import(System.String xmlData, ref System.Int32 reVal)
		{
			 NghienCuuKH_Import(null, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void NghienCuuKH_Import(int start, int pageLength, System.String xmlData, ref System.Int32 reVal)
		{
			 NghienCuuKH_Import(null, start, pageLength , xmlData, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void NghienCuuKH_Import(TransactionManager transactionManager, System.String xmlData, ref System.Int32 reVal)
		{
			 NghienCuuKH_Import(transactionManager, 0, int.MaxValue , xmlData, ref reVal);
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
		public abstract void NghienCuuKH_Import(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_GiangVien_HopDongMoiGiangDay 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HopDongMoiGiangDay' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader HopDongMoiGiangDay(System.String maBacDaoTao, System.String khoaDonVi, System.String maGiangVien, System.String namHoc, System.String hocKy)
		{
			return HopDongMoiGiangDay(null, 0, int.MaxValue , maBacDaoTao, khoaDonVi, maGiangVien, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HopDongMoiGiangDay' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader HopDongMoiGiangDay(int start, int pageLength, System.String maBacDaoTao, System.String khoaDonVi, System.String maGiangVien, System.String namHoc, System.String hocKy)
		{
			return HopDongMoiGiangDay(null, start, pageLength , maBacDaoTao, khoaDonVi, maGiangVien, namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HopDongMoiGiangDay' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader HopDongMoiGiangDay(TransactionManager transactionManager, System.String maBacDaoTao, System.String khoaDonVi, System.String maGiangVien, System.String namHoc, System.String hocKy)
		{
			return HopDongMoiGiangDay(transactionManager, 0, int.MaxValue , maBacDaoTao, khoaDonVi, maGiangVien, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HopDongMoiGiangDay' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader HopDongMoiGiangDay(TransactionManager transactionManager, int start, int pageLength , System.String maBacDaoTao, System.String khoaDonVi, System.String maGiangVien, System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_GiangVien_GetThongTinByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetThongTinByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="hoTen"> A <c>System.String</c> instance.</param>
			/// <param name="tenDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="tenHocVi"> A <c>System.String</c> instance.</param>
			/// <param name="tenHocHam"> A <c>System.String</c> instance.</param>
			/// <param name="maSoThue"> A <c>System.String</c> instance.</param>
			/// <param name="soTaiKhoan"> A <c>System.String</c> instance.</param>
			/// <param name="chiNhanhNganHang"> A <c>System.String</c> instance.</param>
			/// <param name="chucVu"> A <c>System.String</c> instance.</param>
			/// <param name="giangVienTrongTruong"> A <c>System.Boolean</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetThongTinByNamHocHocKy(System.Int32 maGiangVien, System.String namHoc, System.String hocKy, ref System.String hoTen, ref System.String tenDonVi, ref System.String tenHocVi, ref System.String tenHocHam, ref System.String maSoThue, ref System.String soTaiKhoan, ref System.String chiNhanhNganHang, ref System.String chucVu, ref System.Boolean giangVienTrongTruong)
		{
			 GetThongTinByNamHocHocKy(null, 0, int.MaxValue , maGiangVien, namHoc, hocKy, ref hoTen, ref tenDonVi, ref tenHocVi, ref tenHocHam, ref maSoThue, ref soTaiKhoan, ref chiNhanhNganHang, ref chucVu, ref giangVienTrongTruong);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetThongTinByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="hoTen"> A <c>System.String</c> instance.</param>
			/// <param name="tenDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="tenHocVi"> A <c>System.String</c> instance.</param>
			/// <param name="tenHocHam"> A <c>System.String</c> instance.</param>
			/// <param name="maSoThue"> A <c>System.String</c> instance.</param>
			/// <param name="soTaiKhoan"> A <c>System.String</c> instance.</param>
			/// <param name="chiNhanhNganHang"> A <c>System.String</c> instance.</param>
			/// <param name="chucVu"> A <c>System.String</c> instance.</param>
			/// <param name="giangVienTrongTruong"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetThongTinByNamHocHocKy(int start, int pageLength, System.Int32 maGiangVien, System.String namHoc, System.String hocKy, ref System.String hoTen, ref System.String tenDonVi, ref System.String tenHocVi, ref System.String tenHocHam, ref System.String maSoThue, ref System.String soTaiKhoan, ref System.String chiNhanhNganHang, ref System.String chucVu, ref System.Boolean giangVienTrongTruong)
		{
			 GetThongTinByNamHocHocKy(null, start, pageLength , maGiangVien, namHoc, hocKy, ref hoTen, ref tenDonVi, ref tenHocVi, ref tenHocHam, ref maSoThue, ref soTaiKhoan, ref chiNhanhNganHang, ref chucVu, ref giangVienTrongTruong);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetThongTinByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="hoTen"> A <c>System.String</c> instance.</param>
			/// <param name="tenDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="tenHocVi"> A <c>System.String</c> instance.</param>
			/// <param name="tenHocHam"> A <c>System.String</c> instance.</param>
			/// <param name="maSoThue"> A <c>System.String</c> instance.</param>
			/// <param name="soTaiKhoan"> A <c>System.String</c> instance.</param>
			/// <param name="chiNhanhNganHang"> A <c>System.String</c> instance.</param>
			/// <param name="chucVu"> A <c>System.String</c> instance.</param>
			/// <param name="giangVienTrongTruong"> A <c>System.Boolean</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetThongTinByNamHocHocKy(TransactionManager transactionManager, System.Int32 maGiangVien, System.String namHoc, System.String hocKy, ref System.String hoTen, ref System.String tenDonVi, ref System.String tenHocVi, ref System.String tenHocHam, ref System.String maSoThue, ref System.String soTaiKhoan, ref System.String chiNhanhNganHang, ref System.String chucVu, ref System.Boolean giangVienTrongTruong)
		{
			 GetThongTinByNamHocHocKy(transactionManager, 0, int.MaxValue , maGiangVien, namHoc, hocKy, ref hoTen, ref tenDonVi, ref tenHocVi, ref tenHocHam, ref maSoThue, ref soTaiKhoan, ref chiNhanhNganHang, ref chucVu, ref giangVienTrongTruong);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetThongTinByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="hoTen"> A <c>System.String</c> instance.</param>
			/// <param name="tenDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="tenHocVi"> A <c>System.String</c> instance.</param>
			/// <param name="tenHocHam"> A <c>System.String</c> instance.</param>
			/// <param name="maSoThue"> A <c>System.String</c> instance.</param>
			/// <param name="soTaiKhoan"> A <c>System.String</c> instance.</param>
			/// <param name="chiNhanhNganHang"> A <c>System.String</c> instance.</param>
			/// <param name="chucVu"> A <c>System.String</c> instance.</param>
			/// <param name="giangVienTrongTruong"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetThongTinByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.Int32 maGiangVien, System.String namHoc, System.String hocKy, ref System.String hoTen, ref System.String tenDonVi, ref System.String tenHocVi, ref System.String tenHocHam, ref System.String maSoThue, ref System.String soTaiKhoan, ref System.String chiNhanhNganHang, ref System.String chucVu, ref System.Boolean giangVienTrongTruong);
		
		#endregion
		
		#region cust_GiangVien_GetMaDonViMaHocHamMaHocViMaTinhTrang 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetMaDonViMaHocHamMaHocViMaTinhTrang' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <param name="maTinhTrang"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVien&gt;"/> instance.</returns>
		public TList<GiangVien> GetMaDonViMaHocHamMaHocViMaTinhTrang(System.String maDonVi, System.Int32 maHocHam, System.Int32 maHocVi, System.String maTinhTrang)
		{
			return GetMaDonViMaHocHamMaHocViMaTinhTrang(null, 0, int.MaxValue , maDonVi, maHocHam, maHocVi, maTinhTrang);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetMaDonViMaHocHamMaHocViMaTinhTrang' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <param name="maTinhTrang"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVien&gt;"/> instance.</returns>
		public TList<GiangVien> GetMaDonViMaHocHamMaHocViMaTinhTrang(int start, int pageLength, System.String maDonVi, System.Int32 maHocHam, System.Int32 maHocVi, System.String maTinhTrang)
		{
			return GetMaDonViMaHocHamMaHocViMaTinhTrang(null, start, pageLength , maDonVi, maHocHam, maHocVi, maTinhTrang);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetMaDonViMaHocHamMaHocViMaTinhTrang' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <param name="maTinhTrang"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVien&gt;"/> instance.</returns>
		public TList<GiangVien> GetMaDonViMaHocHamMaHocViMaTinhTrang(TransactionManager transactionManager, System.String maDonVi, System.Int32 maHocHam, System.Int32 maHocVi, System.String maTinhTrang)
		{
			return GetMaDonViMaHocHamMaHocViMaTinhTrang(transactionManager, 0, int.MaxValue , maDonVi, maHocHam, maHocVi, maTinhTrang);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetMaDonViMaHocHamMaHocViMaTinhTrang' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <param name="maTinhTrang"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVien&gt;"/> instance.</returns>
		public abstract TList<GiangVien> GetMaDonViMaHocHamMaHocViMaTinhTrang(TransactionManager transactionManager, int start, int pageLength , System.String maDonVi, System.Int32 maHocHam, System.Int32 maHocVi, System.String maTinhTrang);
		
		#endregion
		
		#region cust_GiangVien_TruongKhoaXemThuLaoTrenWeb_Cdgtvt 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_TruongKhoaXemThuLaoTrenWeb_Cdgtvt' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maCanBoGiangDay"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader TruongKhoaXemThuLaoTrenWeb_Cdgtvt(System.String namHoc, System.String maCanBoGiangDay)
		{
			return TruongKhoaXemThuLaoTrenWeb_Cdgtvt(null, 0, int.MaxValue , namHoc, maCanBoGiangDay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_TruongKhoaXemThuLaoTrenWeb_Cdgtvt' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maCanBoGiangDay"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader TruongKhoaXemThuLaoTrenWeb_Cdgtvt(int start, int pageLength, System.String namHoc, System.String maCanBoGiangDay)
		{
			return TruongKhoaXemThuLaoTrenWeb_Cdgtvt(null, start, pageLength , namHoc, maCanBoGiangDay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_TruongKhoaXemThuLaoTrenWeb_Cdgtvt' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maCanBoGiangDay"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader TruongKhoaXemThuLaoTrenWeb_Cdgtvt(TransactionManager transactionManager, System.String namHoc, System.String maCanBoGiangDay)
		{
			return TruongKhoaXemThuLaoTrenWeb_Cdgtvt(transactionManager, 0, int.MaxValue , namHoc, maCanBoGiangDay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_TruongKhoaXemThuLaoTrenWeb_Cdgtvt' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maCanBoGiangDay"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader TruongKhoaXemThuLaoTrenWeb_Cdgtvt(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String maCanBoGiangDay);
		
		#endregion
		
		#region cust_GiangVien_LuuTinNhan 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_LuuTinNhan' stored procedure. 
		/// </summary>
		/// <param name="tieuDe"> A <c>System.String</c> instance.</param>
		/// <param name="nguoiNhanTin"> A <c>System.String</c> instance.</param>
		/// <param name="noiDung"> A <c>System.String</c> instance.</param>
		/// <param name="nguoiTao"> A <c>System.String</c> instance.</param>
			/// <param name="reval"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuTinNhan(System.String tieuDe, System.String nguoiNhanTin, System.String noiDung, System.String nguoiTao, ref System.Int32 reval)
		{
			 LuuTinNhan(null, 0, int.MaxValue , tieuDe, nguoiNhanTin, noiDung, nguoiTao, ref reval);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_LuuTinNhan' stored procedure. 
		/// </summary>
		/// <param name="tieuDe"> A <c>System.String</c> instance.</param>
		/// <param name="nguoiNhanTin"> A <c>System.String</c> instance.</param>
		/// <param name="noiDung"> A <c>System.String</c> instance.</param>
		/// <param name="nguoiTao"> A <c>System.String</c> instance.</param>
			/// <param name="reval"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuTinNhan(int start, int pageLength, System.String tieuDe, System.String nguoiNhanTin, System.String noiDung, System.String nguoiTao, ref System.Int32 reval)
		{
			 LuuTinNhan(null, start, pageLength , tieuDe, nguoiNhanTin, noiDung, nguoiTao, ref reval);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_LuuTinNhan' stored procedure. 
		/// </summary>
		/// <param name="tieuDe"> A <c>System.String</c> instance.</param>
		/// <param name="nguoiNhanTin"> A <c>System.String</c> instance.</param>
		/// <param name="noiDung"> A <c>System.String</c> instance.</param>
		/// <param name="nguoiTao"> A <c>System.String</c> instance.</param>
			/// <param name="reval"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuTinNhan(TransactionManager transactionManager, System.String tieuDe, System.String nguoiNhanTin, System.String noiDung, System.String nguoiTao, ref System.Int32 reval)
		{
			 LuuTinNhan(transactionManager, 0, int.MaxValue , tieuDe, nguoiNhanTin, noiDung, nguoiTao, ref reval);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_LuuTinNhan' stored procedure. 
		/// </summary>
		/// <param name="tieuDe"> A <c>System.String</c> instance.</param>
		/// <param name="nguoiNhanTin"> A <c>System.String</c> instance.</param>
		/// <param name="noiDung"> A <c>System.String</c> instance.</param>
		/// <param name="nguoiTao"> A <c>System.String</c> instance.</param>
			/// <param name="reval"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LuuTinNhan(TransactionManager transactionManager, int start, int pageLength , System.String tieuDe, System.String nguoiNhanTin, System.String noiDung, System.String nguoiTao, ref System.Int32 reval);
		
		#endregion
		
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
		public void NghienCuuKH_Insert(System.String maQuanLy, System.Int32 maNckh, System.String namHoc, System.String tenNckh, System.Int32 soLuongThanhVien, System.Int32 maVaiTro, System.Boolean duKien)
		{
			 NghienCuuKH_Insert(null, 0, int.MaxValue , maQuanLy, maNckh, namHoc, tenNckh, soLuongThanhVien, maVaiTro, duKien);
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
		public void NghienCuuKH_Insert(int start, int pageLength, System.String maQuanLy, System.Int32 maNckh, System.String namHoc, System.String tenNckh, System.Int32 soLuongThanhVien, System.Int32 maVaiTro, System.Boolean duKien)
		{
			 NghienCuuKH_Insert(null, start, pageLength , maQuanLy, maNckh, namHoc, tenNckh, soLuongThanhVien, maVaiTro, duKien);
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
		public void NghienCuuKH_Insert(TransactionManager transactionManager, System.String maQuanLy, System.Int32 maNckh, System.String namHoc, System.String tenNckh, System.Int32 soLuongThanhVien, System.Int32 maVaiTro, System.Boolean duKien)
		{
			 NghienCuuKH_Insert(transactionManager, 0, int.MaxValue , maQuanLy, maNckh, namHoc, tenNckh, soLuongThanhVien, maVaiTro, duKien);
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
		public abstract void NghienCuuKH_Insert(TransactionManager transactionManager, int start, int pageLength , System.String maQuanLy, System.Int32 maNckh, System.String namHoc, System.String tenNckh, System.Int32 soLuongThanhVien, System.Int32 maVaiTro, System.Boolean duKien);
		
		#endregion
		
		#region cust_GiangVien_GetDonVi 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetDonVi' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
			/// <param name="tenDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetDonVi(System.String maQuanLy, ref System.String tenDonVi)
		{
			 GetDonVi(null, 0, int.MaxValue , maQuanLy, ref tenDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetDonVi' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
			/// <param name="tenDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetDonVi(int start, int pageLength, System.String maQuanLy, ref System.String tenDonVi)
		{
			 GetDonVi(null, start, pageLength , maQuanLy, ref tenDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetDonVi' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
			/// <param name="tenDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetDonVi(TransactionManager transactionManager, System.String maQuanLy, ref System.String tenDonVi)
		{
			 GetDonVi(transactionManager, 0, int.MaxValue , maQuanLy, ref tenDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetDonVi' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
			/// <param name="tenDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetDonVi(TransactionManager transactionManager, int start, int pageLength , System.String maQuanLy, ref System.String tenDonVi);
		
		#endregion
		
		#region cust_GiangVien_GetThongKeByMaDonViMaLoaiNhanVien 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetThongKeByMaDonViMaLoaiNhanVien' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiNhanVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThongKeByMaDonViMaLoaiNhanVien(System.String maDonVi, System.String maLoaiNhanVien)
		{
			return GetThongKeByMaDonViMaLoaiNhanVien(null, 0, int.MaxValue , maDonVi, maLoaiNhanVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetThongKeByMaDonViMaLoaiNhanVien' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiNhanVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThongKeByMaDonViMaLoaiNhanVien(int start, int pageLength, System.String maDonVi, System.String maLoaiNhanVien)
		{
			return GetThongKeByMaDonViMaLoaiNhanVien(null, start, pageLength , maDonVi, maLoaiNhanVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetThongKeByMaDonViMaLoaiNhanVien' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiNhanVien"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThongKeByMaDonViMaLoaiNhanVien(TransactionManager transactionManager, System.String maDonVi, System.String maLoaiNhanVien)
		{
			return GetThongKeByMaDonViMaLoaiNhanVien(transactionManager, 0, int.MaxValue , maDonVi, maLoaiNhanVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetThongKeByMaDonViMaLoaiNhanVien' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiNhanVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetThongKeByMaDonViMaLoaiNhanVien(TransactionManager transactionManager, int start, int pageLength , System.String maDonVi, System.String maLoaiNhanVien);
		
		#endregion
		
		#region cust_GiangVien_DeleteThongTinGiangVien 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_DeleteThongTinGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteThongTinGiangVien(System.Int32 maGiangVien)
		{
			 DeleteThongTinGiangVien(null, 0, int.MaxValue , maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_DeleteThongTinGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteThongTinGiangVien(int start, int pageLength, System.Int32 maGiangVien)
		{
			 DeleteThongTinGiangVien(null, start, pageLength , maGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_DeleteThongTinGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteThongTinGiangVien(TransactionManager transactionManager, System.Int32 maGiangVien)
		{
			 DeleteThongTinGiangVien(transactionManager, 0, int.MaxValue , maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_DeleteThongTinGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DeleteThongTinGiangVien(TransactionManager transactionManager, int start, int pageLength , System.Int32 maGiangVien);
		
		#endregion
		
		#region cust_GiangVien_ThongKeCanBoNhanVien 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ThongKeCanBoNhanVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeCanBoNhanVien(System.String namHoc)
		{
			return ThongKeCanBoNhanVien(null, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ThongKeCanBoNhanVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeCanBoNhanVien(int start, int pageLength, System.String namHoc)
		{
			return ThongKeCanBoNhanVien(null, start, pageLength , namHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ThongKeCanBoNhanVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeCanBoNhanVien(TransactionManager transactionManager, System.String namHoc)
		{
			return ThongKeCanBoNhanVien(transactionManager, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ThongKeCanBoNhanVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeCanBoNhanVien(TransactionManager transactionManager, int start, int pageLength , System.String namHoc);
		
		#endregion
		
		#region cust_GiangVien_ThongKeSoLuongGiangVienTheoKhoaBoMon 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ThongKeSoLuongGiangVienTheoKhoaBoMon' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeSoLuongGiangVienTheoKhoaBoMon(System.String namHoc)
		{
			return ThongKeSoLuongGiangVienTheoKhoaBoMon(null, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ThongKeSoLuongGiangVienTheoKhoaBoMon' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeSoLuongGiangVienTheoKhoaBoMon(int start, int pageLength, System.String namHoc)
		{
			return ThongKeSoLuongGiangVienTheoKhoaBoMon(null, start, pageLength , namHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ThongKeSoLuongGiangVienTheoKhoaBoMon' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeSoLuongGiangVienTheoKhoaBoMon(TransactionManager transactionManager, System.String namHoc)
		{
			return ThongKeSoLuongGiangVienTheoKhoaBoMon(transactionManager, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ThongKeSoLuongGiangVienTheoKhoaBoMon' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeSoLuongGiangVienTheoKhoaBoMon(TransactionManager transactionManager, int start, int pageLength , System.String namHoc);
		
		#endregion
		
		#region cust_GiangVien_XemThuLaoTrenWeb_Cdgtvt 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_XemThuLaoTrenWeb_Cdgtvt' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maCanBoGiangDay"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader XemThuLaoTrenWeb_Cdgtvt(System.String namHoc, System.String maCanBoGiangDay)
		{
			return XemThuLaoTrenWeb_Cdgtvt(null, 0, int.MaxValue , namHoc, maCanBoGiangDay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_XemThuLaoTrenWeb_Cdgtvt' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maCanBoGiangDay"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader XemThuLaoTrenWeb_Cdgtvt(int start, int pageLength, System.String namHoc, System.String maCanBoGiangDay)
		{
			return XemThuLaoTrenWeb_Cdgtvt(null, start, pageLength , namHoc, maCanBoGiangDay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_XemThuLaoTrenWeb_Cdgtvt' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maCanBoGiangDay"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader XemThuLaoTrenWeb_Cdgtvt(TransactionManager transactionManager, System.String namHoc, System.String maCanBoGiangDay)
		{
			return XemThuLaoTrenWeb_Cdgtvt(transactionManager, 0, int.MaxValue , namHoc, maCanBoGiangDay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_XemThuLaoTrenWeb_Cdgtvt' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maCanBoGiangDay"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader XemThuLaoTrenWeb_Cdgtvt(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String maCanBoGiangDay);
		
		#endregion
		
		#region cust_GiangVien_CapNhatThongTin 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_CapNhatThongTin' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void CapNhatThongTin(System.String xmlData, ref System.Int32 reVal)
		{
			 CapNhatThongTin(null, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_CapNhatThongTin' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void CapNhatThongTin(int start, int pageLength, System.String xmlData, ref System.Int32 reVal)
		{
			 CapNhatThongTin(null, start, pageLength , xmlData, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_CapNhatThongTin' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void CapNhatThongTin(TransactionManager transactionManager, System.String xmlData, ref System.Int32 reVal)
		{
			 CapNhatThongTin(transactionManager, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_CapNhatThongTin' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void CapNhatThongTin(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_GiangVien_HoatDongNgoaiGiangDay_LayDuLieu 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_LayDuLieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader HoatDongNgoaiGiangDay_LayDuLieu(System.String namHoc, System.String hocKy, System.String maKhoa)
		{
			return HoatDongNgoaiGiangDay_LayDuLieu(null, 0, int.MaxValue , namHoc, hocKy, maKhoa);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_LayDuLieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader HoatDongNgoaiGiangDay_LayDuLieu(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maKhoa)
		{
			return HoatDongNgoaiGiangDay_LayDuLieu(null, start, pageLength , namHoc, hocKy, maKhoa);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_LayDuLieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader HoatDongNgoaiGiangDay_LayDuLieu(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maKhoa)
		{
			return HoatDongNgoaiGiangDay_LayDuLieu(transactionManager, 0, int.MaxValue , namHoc, hocKy, maKhoa);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_LayDuLieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader HoatDongNgoaiGiangDay_LayDuLieu(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maKhoa);
		
		#endregion
		
		#region cust_GiangVien_GiamTruDinhMuc_GetByNamHoc 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GiamTruDinhMuc_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GiamTruDinhMuc_GetByNamHoc(System.String namHoc)
		{
			return GiamTruDinhMuc_GetByNamHoc(null, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GiamTruDinhMuc_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GiamTruDinhMuc_GetByNamHoc(int start, int pageLength, System.String namHoc)
		{
			return GiamTruDinhMuc_GetByNamHoc(null, start, pageLength , namHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GiamTruDinhMuc_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GiamTruDinhMuc_GetByNamHoc(TransactionManager transactionManager, System.String namHoc)
		{
			return GiamTruDinhMuc_GetByNamHoc(transactionManager, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GiamTruDinhMuc_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GiamTruDinhMuc_GetByNamHoc(TransactionManager transactionManager, int start, int pageLength , System.String namHoc);
		
		#endregion
		
		#region cust_GiangVien_HopDongMoiGiangDayNhomMonThucTapCuoiKhoa 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HopDongMoiGiangDayNhomMonThucTapCuoiKhoa' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader HopDongMoiGiangDayNhomMonThucTapCuoiKhoa(System.String maBacDaoTao, System.String khoaDonVi, System.String maGiangVien, System.String namHoc, System.String hocKy)
		{
			return HopDongMoiGiangDayNhomMonThucTapCuoiKhoa(null, 0, int.MaxValue , maBacDaoTao, khoaDonVi, maGiangVien, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HopDongMoiGiangDayNhomMonThucTapCuoiKhoa' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader HopDongMoiGiangDayNhomMonThucTapCuoiKhoa(int start, int pageLength, System.String maBacDaoTao, System.String khoaDonVi, System.String maGiangVien, System.String namHoc, System.String hocKy)
		{
			return HopDongMoiGiangDayNhomMonThucTapCuoiKhoa(null, start, pageLength , maBacDaoTao, khoaDonVi, maGiangVien, namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HopDongMoiGiangDayNhomMonThucTapCuoiKhoa' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader HopDongMoiGiangDayNhomMonThucTapCuoiKhoa(TransactionManager transactionManager, System.String maBacDaoTao, System.String khoaDonVi, System.String maGiangVien, System.String namHoc, System.String hocKy)
		{
			return HopDongMoiGiangDayNhomMonThucTapCuoiKhoa(transactionManager, 0, int.MaxValue , maBacDaoTao, khoaDonVi, maGiangVien, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HopDongMoiGiangDayNhomMonThucTapCuoiKhoa' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader HopDongMoiGiangDayNhomMonThucTapCuoiKhoa(TransactionManager transactionManager, int start, int pageLength , System.String maBacDaoTao, System.String khoaDonVi, System.String maGiangVien, System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_GiangVien_NghienCuuKH_GetByGiangVienNamHoc 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_GetByGiangVienNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maQuanLyGv"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader NghienCuuKH_GetByGiangVienNamHoc(System.String maQuanLyGv, System.String namHoc)
		{
			return NghienCuuKH_GetByGiangVienNamHoc(null, 0, int.MaxValue , maQuanLyGv, namHoc);
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
		public IDataReader NghienCuuKH_GetByGiangVienNamHoc(int start, int pageLength, System.String maQuanLyGv, System.String namHoc)
		{
			return NghienCuuKH_GetByGiangVienNamHoc(null, start, pageLength , maQuanLyGv, namHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_GetByGiangVienNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maQuanLyGv"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader NghienCuuKH_GetByGiangVienNamHoc(TransactionManager transactionManager, System.String maQuanLyGv, System.String namHoc)
		{
			return NghienCuuKH_GetByGiangVienNamHoc(transactionManager, 0, int.MaxValue , maQuanLyGv, namHoc);
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
		public abstract IDataReader NghienCuuKH_GetByGiangVienNamHoc(TransactionManager transactionManager, int start, int pageLength , System.String maQuanLyGv, System.String namHoc);
		
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
		public void NghienCuuKH_LuuNckhVhu(System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 NghienCuuKH_LuuNckhVhu(null, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
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
		public void NghienCuuKH_LuuNckhVhu(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 NghienCuuKH_LuuNckhVhu(null, start, pageLength , xmlData, namHoc, hocKy, ref reVal);
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
		public void NghienCuuKH_LuuNckhVhu(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 NghienCuuKH_LuuNckhVhu(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
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
		public abstract void NghienCuuKH_LuuNckhVhu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_GiangVien_ThongKeGioGiangBuh_Bk 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ThongKeGioGiangBuh_Bk' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeGioGiangBuh_Bk(System.String namHoc, System.String donVi, System.String loaiGiangVien, System.Int32 lanChotHk01, System.Int32 lanChotHk02)
		{
			return ThongKeGioGiangBuh_Bk(null, 0, int.MaxValue , namHoc, donVi, loaiGiangVien, lanChotHk01, lanChotHk02);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ThongKeGioGiangBuh_Bk' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeGioGiangBuh_Bk(int start, int pageLength, System.String namHoc, System.String donVi, System.String loaiGiangVien, System.Int32 lanChotHk01, System.Int32 lanChotHk02)
		{
			return ThongKeGioGiangBuh_Bk(null, start, pageLength , namHoc, donVi, loaiGiangVien, lanChotHk01, lanChotHk02);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ThongKeGioGiangBuh_Bk' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeGioGiangBuh_Bk(TransactionManager transactionManager, System.String namHoc, System.String donVi, System.String loaiGiangVien, System.Int32 lanChotHk01, System.Int32 lanChotHk02)
		{
			return ThongKeGioGiangBuh_Bk(transactionManager, 0, int.MaxValue , namHoc, donVi, loaiGiangVien, lanChotHk01, lanChotHk02);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_ThongKeGioGiangBuh_Bk' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChotHk01"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotHk02"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeGioGiangBuh_Bk(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String donVi, System.String loaiGiangVien, System.Int32 lanChotHk01, System.Int32 lanChotHk02);
		
		#endregion
		
		#region cust_GiangVien_NghienCuuKH_LuuWeb 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_LuuWeb' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void NghienCuuKH_LuuWeb(System.String xmlData, System.String namHoc, ref System.Int32 reVal)
		{
			 NghienCuuKH_LuuWeb(null, 0, int.MaxValue , xmlData, namHoc, ref reVal);
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
		public void NghienCuuKH_LuuWeb(int start, int pageLength, System.String xmlData, System.String namHoc, ref System.Int32 reVal)
		{
			 NghienCuuKH_LuuWeb(null, start, pageLength , xmlData, namHoc, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_NghienCuuKH_LuuWeb' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void NghienCuuKH_LuuWeb(TransactionManager transactionManager, System.String xmlData, System.String namHoc, ref System.Int32 reVal)
		{
			 NghienCuuKH_LuuWeb(transactionManager, 0, int.MaxValue , xmlData, namHoc, ref reVal);
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
		public abstract void NghienCuuKH_LuuWeb(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, ref System.Int32 reVal);
		
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
		public void NghienCuuKH_LuuTheoHocKy(System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 NghienCuuKH_LuuTheoHocKy(null, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
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
		public void NghienCuuKH_LuuTheoHocKy(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 NghienCuuKH_LuuTheoHocKy(null, start, pageLength , xmlData, namHoc, hocKy, ref reVal);
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
		public void NghienCuuKH_LuuTheoHocKy(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 NghienCuuKH_LuuTheoHocKy(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
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
		public abstract void NghienCuuKH_LuuTheoHocKy(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_GiangVien_GetHeSoQuyDoiTietChuanLaw 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetHeSoQuyDoiTietChuanLaw' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maPhongHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <param name="daoTaoTinChi"> A <c>System.Boolean</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetHeSoQuyDoiTietChuanLaw(System.String maQuanLy, System.String namHoc, System.String hocKy, System.String maMonHoc, System.Int32 siSo, System.Int32 tietBatDau, System.DateTime ngayDay, System.String maPhongHoc, System.String maLopHocPhan, System.String maLoaiHocPhan, System.String maBacDaoTao, System.String maKhoaBoMon, System.Int32 maHocHam, System.Int32 maHocVi, System.Boolean daoTaoTinChi)
		{
			return GetHeSoQuyDoiTietChuanLaw(null, 0, int.MaxValue , maQuanLy, namHoc, hocKy, maMonHoc, siSo, tietBatDau, ngayDay, maPhongHoc, maLopHocPhan, maLoaiHocPhan, maBacDaoTao, maKhoaBoMon, maHocHam, maHocVi, daoTaoTinChi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetHeSoQuyDoiTietChuanLaw' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maPhongHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <param name="daoTaoTinChi"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetHeSoQuyDoiTietChuanLaw(int start, int pageLength, System.String maQuanLy, System.String namHoc, System.String hocKy, System.String maMonHoc, System.Int32 siSo, System.Int32 tietBatDau, System.DateTime ngayDay, System.String maPhongHoc, System.String maLopHocPhan, System.String maLoaiHocPhan, System.String maBacDaoTao, System.String maKhoaBoMon, System.Int32 maHocHam, System.Int32 maHocVi, System.Boolean daoTaoTinChi)
		{
			return GetHeSoQuyDoiTietChuanLaw(null, start, pageLength , maQuanLy, namHoc, hocKy, maMonHoc, siSo, tietBatDau, ngayDay, maPhongHoc, maLopHocPhan, maLoaiHocPhan, maBacDaoTao, maKhoaBoMon, maHocHam, maHocVi, daoTaoTinChi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetHeSoQuyDoiTietChuanLaw' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maPhongHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <param name="daoTaoTinChi"> A <c>System.Boolean</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetHeSoQuyDoiTietChuanLaw(TransactionManager transactionManager, System.String maQuanLy, System.String namHoc, System.String hocKy, System.String maMonHoc, System.Int32 siSo, System.Int32 tietBatDau, System.DateTime ngayDay, System.String maPhongHoc, System.String maLopHocPhan, System.String maLoaiHocPhan, System.String maBacDaoTao, System.String maKhoaBoMon, System.Int32 maHocHam, System.Int32 maHocVi, System.Boolean daoTaoTinChi)
		{
			return GetHeSoQuyDoiTietChuanLaw(transactionManager, 0, int.MaxValue , maQuanLy, namHoc, hocKy, maMonHoc, siSo, tietBatDau, ngayDay, maPhongHoc, maLopHocPhan, maLoaiHocPhan, maBacDaoTao, maKhoaBoMon, maHocHam, maHocVi, daoTaoTinChi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetHeSoQuyDoiTietChuanLaw' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maPhongHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <param name="daoTaoTinChi"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetHeSoQuyDoiTietChuanLaw(TransactionManager transactionManager, int start, int pageLength , System.String maQuanLy, System.String namHoc, System.String hocKy, System.String maMonHoc, System.Int32 siSo, System.Int32 tietBatDau, System.DateTime ngayDay, System.String maPhongHoc, System.String maLopHocPhan, System.String maLoaiHocPhan, System.String maBacDaoTao, System.String maKhoaBoMon, System.Int32 maHocHam, System.Int32 maHocVi, System.Boolean daoTaoTinChi);
		
		#endregion
		
		#region cust_GiangVien_GetSoTietNoGioNghiaVu 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetSoTietNoGioNghiaVu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
			/// <param name="tietNoGiangDay"> A <c>System.Double</c> instance.</param>
			/// <param name="tietNoKhac"> A <c>System.Double</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetSoTietNoGioNghiaVu(System.String namHoc, System.String hocKy, System.Int32 maGiangVien, ref System.Double tietNoGiangDay, ref System.Double tietNoKhac)
		{
			 GetSoTietNoGioNghiaVu(null, 0, int.MaxValue , namHoc, hocKy, maGiangVien, ref tietNoGiangDay, ref tietNoKhac);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetSoTietNoGioNghiaVu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
			/// <param name="tietNoGiangDay"> A <c>System.Double</c> instance.</param>
			/// <param name="tietNoKhac"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetSoTietNoGioNghiaVu(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 maGiangVien, ref System.Double tietNoGiangDay, ref System.Double tietNoKhac)
		{
			 GetSoTietNoGioNghiaVu(null, start, pageLength , namHoc, hocKy, maGiangVien, ref tietNoGiangDay, ref tietNoKhac);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetSoTietNoGioNghiaVu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
			/// <param name="tietNoGiangDay"> A <c>System.Double</c> instance.</param>
			/// <param name="tietNoKhac"> A <c>System.Double</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetSoTietNoGioNghiaVu(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 maGiangVien, ref System.Double tietNoGiangDay, ref System.Double tietNoKhac)
		{
			 GetSoTietNoGioNghiaVu(transactionManager, 0, int.MaxValue , namHoc, hocKy, maGiangVien, ref tietNoGiangDay, ref tietNoKhac);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GetSoTietNoGioNghiaVu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
			/// <param name="tietNoGiangDay"> A <c>System.Double</c> instance.</param>
			/// <param name="tietNoKhac"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetSoTietNoGioNghiaVu(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 maGiangVien, ref System.Double tietNoGiangDay, ref System.Double tietNoKhac);
		
		#endregion
		
		#region cust_GiangVien_TrinhDoChuyenMonNghiepVu 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_TrinhDoChuyenMonNghiepVu' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader TrinhDoChuyenMonNghiepVu(System.DateTime ngay)
		{
			return TrinhDoChuyenMonNghiepVu(null, 0, int.MaxValue , ngay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_TrinhDoChuyenMonNghiepVu' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader TrinhDoChuyenMonNghiepVu(int start, int pageLength, System.DateTime ngay)
		{
			return TrinhDoChuyenMonNghiepVu(null, start, pageLength , ngay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_TrinhDoChuyenMonNghiepVu' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader TrinhDoChuyenMonNghiepVu(TransactionManager transactionManager, System.DateTime ngay)
		{
			return TrinhDoChuyenMonNghiepVu(transactionManager, 0, int.MaxValue , ngay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_TrinhDoChuyenMonNghiepVu' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader TrinhDoChuyenMonNghiepVu(TransactionManager transactionManager, int start, int pageLength , System.DateTime ngay);
		
		#endregion
		
		#region cust_GiangVien_HoatDongNgoaiGiangDay_KiemTraDuLieu 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_KiemTraDuLieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HoatDongNgoaiGiangDay_KiemTraDuLieu(System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 HoatDongNgoaiGiangDay_KiemTraDuLieu(null, 0, int.MaxValue , namHoc, hocKy, maDonVi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_KiemTraDuLieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HoatDongNgoaiGiangDay_KiemTraDuLieu(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 HoatDongNgoaiGiangDay_KiemTraDuLieu(null, start, pageLength , namHoc, hocKy, maDonVi, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_KiemTraDuLieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HoatDongNgoaiGiangDay_KiemTraDuLieu(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 HoatDongNgoaiGiangDay_KiemTraDuLieu(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_KiemTraDuLieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void HoatDongNgoaiGiangDay_KiemTraDuLieu(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GiangVien&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GiangVien&gt;"/></returns>
		public static TList<GiangVien> Fill(IDataReader reader, TList<GiangVien> rows, int start, int pageLength)
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
				
				PMS.Entities.GiangVien c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GiangVien")
					.Append("|").Append((System.Int32)reader[((int)GiangVienColumn.MaGiangVien - 1)]).ToString();
					c = EntityManager.LocateOrCreate<GiangVien>(
					key.ToString(), // EntityTrackingKey
					"GiangVien",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.GiangVien();
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
					c.MaGiangVien = (System.Int32)reader[(GiangVienColumn.MaGiangVien.ToString())];
					c.MaDanToc = (reader[GiangVienColumn.MaDanToc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.MaDanToc.ToString())];
					c.MaTonGiao = (reader[GiangVienColumn.MaTonGiao.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.MaTonGiao.ToString())];
					c.MaDonVi = (reader[GiangVienColumn.MaDonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.MaDonVi.ToString())];
					c.MaHocHam = (reader[GiangVienColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[GiangVienColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienColumn.MaHocVi.ToString())];
					c.MaLoaiGiangVien = (reader[GiangVienColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienColumn.MaLoaiGiangVien.ToString())];
					c.MaNguoiLap = (reader[GiangVienColumn.MaNguoiLap.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienColumn.MaNguoiLap.ToString())];
					c.MatKhau = (reader[GiangVienColumn.MatKhau.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.MatKhau.ToString())];
					c.MaTinhTrang = (reader[GiangVienColumn.MaTinhTrang.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienColumn.MaTinhTrang.ToString())];
					c.MaQuanLy = (System.String)reader[(GiangVienColumn.MaQuanLy.ToString())];
					c.Ho = (reader[GiangVienColumn.Ho.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.Ho.ToString())];
					c.TenDem = (reader[GiangVienColumn.TenDem.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.TenDem.ToString())];
					c.Ten = (reader[GiangVienColumn.Ten.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.Ten.ToString())];
					c.NgaySinh = (reader[GiangVienColumn.NgaySinh.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.NgaySinh.ToString())];
					c.GioiTinh = (reader[GiangVienColumn.GioiTinh.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(GiangVienColumn.GioiTinh.ToString())];
					c.NoiSinh = (reader[GiangVienColumn.NoiSinh.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.NoiSinh.ToString())];
					c.Cmnd = (reader[GiangVienColumn.Cmnd.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.Cmnd.ToString())];
					c.NgayCap = (reader[GiangVienColumn.NgayCap.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.NgayCap.ToString())];
					c.NoiCap = (reader[GiangVienColumn.NoiCap.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.NoiCap.ToString())];
					c.DoanDang = (reader[GiangVienColumn.DoanDang.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(GiangVienColumn.DoanDang.ToString())];
					c.NgayVaoDoanDang = (reader[GiangVienColumn.NgayVaoDoanDang.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.NgayVaoDoanDang.ToString())];
					c.NgayKyHopDong = (reader[GiangVienColumn.NgayKyHopDong.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienColumn.NgayKyHopDong.ToString())];
					c.NgayKetThucHopDong = (reader[GiangVienColumn.NgayKetThucHopDong.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienColumn.NgayKetThucHopDong.ToString())];
					c.HinhAnh = (reader[GiangVienColumn.HinhAnh.ToString()] == DBNull.Value) ? null : (System.Byte[])reader[(GiangVienColumn.HinhAnh.ToString())];
					c.DiaChi = (reader[GiangVienColumn.DiaChi.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.DiaChi.ToString())];
					c.ThuongTru = (reader[GiangVienColumn.ThuongTru.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.ThuongTru.ToString())];
					c.NoiLamViec = (reader[GiangVienColumn.NoiLamViec.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.NoiLamViec.ToString())];
					c.Email = (reader[GiangVienColumn.Email.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.Email.ToString())];
					c.DienThoai = (reader[GiangVienColumn.DienThoai.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.DienThoai.ToString())];
					c.SoDiDong = (reader[GiangVienColumn.SoDiDong.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.SoDiDong.ToString())];
					c.SoTaiKhoan = (reader[GiangVienColumn.SoTaiKhoan.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.SoTaiKhoan.ToString())];
					c.TenNganHang = (reader[GiangVienColumn.TenNganHang.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.TenNganHang.ToString())];
					c.MaSoThue = (reader[GiangVienColumn.MaSoThue.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.MaSoThue.ToString())];
					c.ChiNhanh = (reader[GiangVienColumn.ChiNhanh.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.ChiNhanh.ToString())];
					c.SoSoBaoHiem = (reader[GiangVienColumn.SoSoBaoHiem.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.SoSoBaoHiem.ToString())];
					c.ThoiGianBatDau = (reader[GiangVienColumn.ThoiGianBatDau.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.ThoiGianBatDau.ToString())];
					c.BacLuong = (reader[GiangVienColumn.BacLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienColumn.BacLuong.ToString())];
					c.NgayHuongLuong = (reader[GiangVienColumn.NgayHuongLuong.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.NgayHuongLuong.ToString())];
					c.NamLamViec = (reader[GiangVienColumn.NamLamViec.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.NamLamViec.ToString())];
					c.ChuyenNganh = (reader[GiangVienColumn.ChuyenNganh.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.ChuyenNganh.ToString())];
					c.MaHeSoThuLao = (reader[GiangVienColumn.MaHeSoThuLao.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.MaHeSoThuLao.ToString())];
					c.Ngach = (reader[GiangVienColumn.Ngach.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.Ngach.ToString())];
					c.SoHieuCongChuc = (reader[GiangVienColumn.SoHieuCongChuc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.SoHieuCongChuc.ToString())];
					c.Hrmid = (reader[GiangVienColumn.Hrmid.ToString()] == DBNull.Value) ? null : (System.Guid?)reader[(GiangVienColumn.Hrmid.ToString())];
					c.NoiCapBang = (reader[GiangVienColumn.NoiCapBang.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.NoiCapBang.ToString())];
					c.KhoaTaiKhoan = (reader[GiangVienColumn.KhoaTaiKhoan.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(GiangVienColumn.KhoaTaiKhoan.ToString())];
					c.MaLoaiNhanVien = (reader[GiangVienColumn.MaLoaiNhanVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienColumn.MaLoaiNhanVien.ToString())];
					c.MaNgachCongChuc = (reader[GiangVienColumn.MaNgachCongChuc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienColumn.MaNgachCongChuc.ToString())];
					c.MaTrinhDoChinhTri = (reader[GiangVienColumn.MaTrinhDoChinhTri.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienColumn.MaTrinhDoChinhTri.ToString())];
					c.MaTrinhDoSuPham = (reader[GiangVienColumn.MaTrinhDoSuPham.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienColumn.MaTrinhDoSuPham.ToString())];
					c.MaTrinhDoNgoaiNgu = (reader[GiangVienColumn.MaTrinhDoNgoaiNgu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienColumn.MaTrinhDoNgoaiNgu.ToString())];
					c.MaTrinhDoTinHoc = (reader[GiangVienColumn.MaTrinhDoTinHoc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienColumn.MaTrinhDoTinHoc.ToString())];
					c.MaTrinhDoQuanLyNhaNuoc = (reader[GiangVienColumn.MaTrinhDoQuanLyNhaNuoc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienColumn.MaTrinhDoQuanLyNhaNuoc.ToString())];
					c.NguoiCapNhat = (reader[GiangVienColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.NguoiCapNhat.ToString())];
					c.NgayCapNhat = (reader[GiangVienColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienColumn.NgayCapNhat.ToString())];
					c.KhoiKienThucGiangDay = (reader[GiangVienColumn.KhoiKienThucGiangDay.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.KhoiKienThucGiangDay.ToString())];
					c.NganhDaoTao = (reader[GiangVienColumn.NganhDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.NganhDaoTao.ToString())];
					c.DonViGiangDay = (reader[GiangVienColumn.DonViGiangDay.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.DonViGiangDay.ToString())];
					c.IdHoSo = (reader[GiangVienColumn.IdHoSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienColumn.IdHoSo.ToString())];
					c.MaQuocTich = (reader[GiangVienColumn.MaQuocTich.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienColumn.MaQuocTich.ToString())];
					c.DaXoaHrm = (reader[GiangVienColumn.DaXoaHrm.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(GiangVienColumn.DaXoaHrm.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVien"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVien"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.GiangVien entity)
		{
			if (!reader.Read()) return;
			
			entity.MaGiangVien = (System.Int32)reader[(GiangVienColumn.MaGiangVien.ToString())];
			entity.MaDanToc = (reader[GiangVienColumn.MaDanToc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.MaDanToc.ToString())];
			entity.MaTonGiao = (reader[GiangVienColumn.MaTonGiao.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.MaTonGiao.ToString())];
			entity.MaDonVi = (reader[GiangVienColumn.MaDonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.MaDonVi.ToString())];
			entity.MaHocHam = (reader[GiangVienColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[GiangVienColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienColumn.MaHocVi.ToString())];
			entity.MaLoaiGiangVien = (reader[GiangVienColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienColumn.MaLoaiGiangVien.ToString())];
			entity.MaNguoiLap = (reader[GiangVienColumn.MaNguoiLap.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienColumn.MaNguoiLap.ToString())];
			entity.MatKhau = (reader[GiangVienColumn.MatKhau.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.MatKhau.ToString())];
			entity.MaTinhTrang = (reader[GiangVienColumn.MaTinhTrang.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienColumn.MaTinhTrang.ToString())];
			entity.MaQuanLy = (System.String)reader[(GiangVienColumn.MaQuanLy.ToString())];
			entity.Ho = (reader[GiangVienColumn.Ho.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.Ho.ToString())];
			entity.TenDem = (reader[GiangVienColumn.TenDem.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.TenDem.ToString())];
			entity.Ten = (reader[GiangVienColumn.Ten.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.Ten.ToString())];
			entity.NgaySinh = (reader[GiangVienColumn.NgaySinh.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.NgaySinh.ToString())];
			entity.GioiTinh = (reader[GiangVienColumn.GioiTinh.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(GiangVienColumn.GioiTinh.ToString())];
			entity.NoiSinh = (reader[GiangVienColumn.NoiSinh.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.NoiSinh.ToString())];
			entity.Cmnd = (reader[GiangVienColumn.Cmnd.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.Cmnd.ToString())];
			entity.NgayCap = (reader[GiangVienColumn.NgayCap.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.NgayCap.ToString())];
			entity.NoiCap = (reader[GiangVienColumn.NoiCap.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.NoiCap.ToString())];
			entity.DoanDang = (reader[GiangVienColumn.DoanDang.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(GiangVienColumn.DoanDang.ToString())];
			entity.NgayVaoDoanDang = (reader[GiangVienColumn.NgayVaoDoanDang.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.NgayVaoDoanDang.ToString())];
			entity.NgayKyHopDong = (reader[GiangVienColumn.NgayKyHopDong.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienColumn.NgayKyHopDong.ToString())];
			entity.NgayKetThucHopDong = (reader[GiangVienColumn.NgayKetThucHopDong.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienColumn.NgayKetThucHopDong.ToString())];
			entity.HinhAnh = (reader[GiangVienColumn.HinhAnh.ToString()] == DBNull.Value) ? null : (System.Byte[])reader[(GiangVienColumn.HinhAnh.ToString())];
			entity.DiaChi = (reader[GiangVienColumn.DiaChi.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.DiaChi.ToString())];
			entity.ThuongTru = (reader[GiangVienColumn.ThuongTru.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.ThuongTru.ToString())];
			entity.NoiLamViec = (reader[GiangVienColumn.NoiLamViec.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.NoiLamViec.ToString())];
			entity.Email = (reader[GiangVienColumn.Email.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.Email.ToString())];
			entity.DienThoai = (reader[GiangVienColumn.DienThoai.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.DienThoai.ToString())];
			entity.SoDiDong = (reader[GiangVienColumn.SoDiDong.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.SoDiDong.ToString())];
			entity.SoTaiKhoan = (reader[GiangVienColumn.SoTaiKhoan.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.SoTaiKhoan.ToString())];
			entity.TenNganHang = (reader[GiangVienColumn.TenNganHang.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.TenNganHang.ToString())];
			entity.MaSoThue = (reader[GiangVienColumn.MaSoThue.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.MaSoThue.ToString())];
			entity.ChiNhanh = (reader[GiangVienColumn.ChiNhanh.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.ChiNhanh.ToString())];
			entity.SoSoBaoHiem = (reader[GiangVienColumn.SoSoBaoHiem.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.SoSoBaoHiem.ToString())];
			entity.ThoiGianBatDau = (reader[GiangVienColumn.ThoiGianBatDau.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.ThoiGianBatDau.ToString())];
			entity.BacLuong = (reader[GiangVienColumn.BacLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienColumn.BacLuong.ToString())];
			entity.NgayHuongLuong = (reader[GiangVienColumn.NgayHuongLuong.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.NgayHuongLuong.ToString())];
			entity.NamLamViec = (reader[GiangVienColumn.NamLamViec.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.NamLamViec.ToString())];
			entity.ChuyenNganh = (reader[GiangVienColumn.ChuyenNganh.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.ChuyenNganh.ToString())];
			entity.MaHeSoThuLao = (reader[GiangVienColumn.MaHeSoThuLao.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.MaHeSoThuLao.ToString())];
			entity.Ngach = (reader[GiangVienColumn.Ngach.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.Ngach.ToString())];
			entity.SoHieuCongChuc = (reader[GiangVienColumn.SoHieuCongChuc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.SoHieuCongChuc.ToString())];
			entity.Hrmid = (reader[GiangVienColumn.Hrmid.ToString()] == DBNull.Value) ? null : (System.Guid?)reader[(GiangVienColumn.Hrmid.ToString())];
			entity.NoiCapBang = (reader[GiangVienColumn.NoiCapBang.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.NoiCapBang.ToString())];
			entity.KhoaTaiKhoan = (reader[GiangVienColumn.KhoaTaiKhoan.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(GiangVienColumn.KhoaTaiKhoan.ToString())];
			entity.MaLoaiNhanVien = (reader[GiangVienColumn.MaLoaiNhanVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienColumn.MaLoaiNhanVien.ToString())];
			entity.MaNgachCongChuc = (reader[GiangVienColumn.MaNgachCongChuc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienColumn.MaNgachCongChuc.ToString())];
			entity.MaTrinhDoChinhTri = (reader[GiangVienColumn.MaTrinhDoChinhTri.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienColumn.MaTrinhDoChinhTri.ToString())];
			entity.MaTrinhDoSuPham = (reader[GiangVienColumn.MaTrinhDoSuPham.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienColumn.MaTrinhDoSuPham.ToString())];
			entity.MaTrinhDoNgoaiNgu = (reader[GiangVienColumn.MaTrinhDoNgoaiNgu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienColumn.MaTrinhDoNgoaiNgu.ToString())];
			entity.MaTrinhDoTinHoc = (reader[GiangVienColumn.MaTrinhDoTinHoc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienColumn.MaTrinhDoTinHoc.ToString())];
			entity.MaTrinhDoQuanLyNhaNuoc = (reader[GiangVienColumn.MaTrinhDoQuanLyNhaNuoc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienColumn.MaTrinhDoQuanLyNhaNuoc.ToString())];
			entity.NguoiCapNhat = (reader[GiangVienColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.NguoiCapNhat.ToString())];
			entity.NgayCapNhat = (reader[GiangVienColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienColumn.NgayCapNhat.ToString())];
			entity.KhoiKienThucGiangDay = (reader[GiangVienColumn.KhoiKienThucGiangDay.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.KhoiKienThucGiangDay.ToString())];
			entity.NganhDaoTao = (reader[GiangVienColumn.NganhDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.NganhDaoTao.ToString())];
			entity.DonViGiangDay = (reader[GiangVienColumn.DonViGiangDay.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienColumn.DonViGiangDay.ToString())];
			entity.IdHoSo = (reader[GiangVienColumn.IdHoSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienColumn.IdHoSo.ToString())];
			entity.MaQuocTich = (reader[GiangVienColumn.MaQuocTich.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienColumn.MaQuocTich.ToString())];
			entity.DaXoaHrm = (reader[GiangVienColumn.DaXoaHrm.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(GiangVienColumn.DaXoaHrm.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVien"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVien"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.GiangVien entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (System.Int32)dataRow["MaGiangVien"];
			entity.MaDanToc = Convert.IsDBNull(dataRow["MaDanToc"]) ? null : (System.String)dataRow["MaDanToc"];
			entity.MaTonGiao = Convert.IsDBNull(dataRow["MaTonGiao"]) ? null : (System.String)dataRow["MaTonGiao"];
			entity.MaDonVi = Convert.IsDBNull(dataRow["MaDonVi"]) ? null : (System.String)dataRow["MaDonVi"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
			entity.MaLoaiGiangVien = Convert.IsDBNull(dataRow["MaLoaiGiangVien"]) ? null : (System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.MaNguoiLap = Convert.IsDBNull(dataRow["MaNguoiLap"]) ? null : (System.Int32?)dataRow["MaNguoiLap"];
			entity.MatKhau = Convert.IsDBNull(dataRow["MatKhau"]) ? null : (System.String)dataRow["MatKhau"];
			entity.MaTinhTrang = Convert.IsDBNull(dataRow["MaTinhTrang"]) ? null : (System.Int32?)dataRow["MaTinhTrang"];
			entity.MaQuanLy = (System.String)dataRow["MaQuanLy"];
			entity.Ho = Convert.IsDBNull(dataRow["Ho"]) ? null : (System.String)dataRow["Ho"];
			entity.TenDem = Convert.IsDBNull(dataRow["TenDem"]) ? null : (System.String)dataRow["TenDem"];
			entity.Ten = Convert.IsDBNull(dataRow["Ten"]) ? null : (System.String)dataRow["Ten"];
			entity.NgaySinh = Convert.IsDBNull(dataRow["NgaySinh"]) ? null : (System.String)dataRow["NgaySinh"];
			entity.GioiTinh = Convert.IsDBNull(dataRow["GioiTinh"]) ? null : (System.Boolean?)dataRow["GioiTinh"];
			entity.NoiSinh = Convert.IsDBNull(dataRow["NoiSinh"]) ? null : (System.String)dataRow["NoiSinh"];
			entity.Cmnd = Convert.IsDBNull(dataRow["Cmnd"]) ? null : (System.String)dataRow["Cmnd"];
			entity.NgayCap = Convert.IsDBNull(dataRow["NgayCap"]) ? null : (System.String)dataRow["NgayCap"];
			entity.NoiCap = Convert.IsDBNull(dataRow["NoiCap"]) ? null : (System.String)dataRow["NoiCap"];
			entity.DoanDang = Convert.IsDBNull(dataRow["DoanDang"]) ? null : (System.Boolean?)dataRow["DoanDang"];
			entity.NgayVaoDoanDang = Convert.IsDBNull(dataRow["NgayVaoDoanDang"]) ? null : (System.String)dataRow["NgayVaoDoanDang"];
			entity.NgayKyHopDong = Convert.IsDBNull(dataRow["NgayKyHopDong"]) ? null : (System.DateTime?)dataRow["NgayKyHopDong"];
			entity.NgayKetThucHopDong = Convert.IsDBNull(dataRow["NgayKetThucHopDong"]) ? null : (System.DateTime?)dataRow["NgayKetThucHopDong"];
			entity.HinhAnh = Convert.IsDBNull(dataRow["HinhAnh"]) ? null : (System.Byte[])dataRow["HinhAnh"];
			entity.DiaChi = Convert.IsDBNull(dataRow["DiaChi"]) ? null : (System.String)dataRow["DiaChi"];
			entity.ThuongTru = Convert.IsDBNull(dataRow["ThuongTru"]) ? null : (System.String)dataRow["ThuongTru"];
			entity.NoiLamViec = Convert.IsDBNull(dataRow["NoiLamViec"]) ? null : (System.String)dataRow["NoiLamViec"];
			entity.Email = Convert.IsDBNull(dataRow["Email"]) ? null : (System.String)dataRow["Email"];
			entity.DienThoai = Convert.IsDBNull(dataRow["DienThoai"]) ? null : (System.String)dataRow["DienThoai"];
			entity.SoDiDong = Convert.IsDBNull(dataRow["SoDiDong"]) ? null : (System.String)dataRow["SoDiDong"];
			entity.SoTaiKhoan = Convert.IsDBNull(dataRow["SoTaiKhoan"]) ? null : (System.String)dataRow["SoTaiKhoan"];
			entity.TenNganHang = Convert.IsDBNull(dataRow["TenNganHang"]) ? null : (System.String)dataRow["TenNganHang"];
			entity.MaSoThue = Convert.IsDBNull(dataRow["MaSoThue"]) ? null : (System.String)dataRow["MaSoThue"];
			entity.ChiNhanh = Convert.IsDBNull(dataRow["ChiNhanh"]) ? null : (System.String)dataRow["ChiNhanh"];
			entity.SoSoBaoHiem = Convert.IsDBNull(dataRow["SoSoBaoHiem"]) ? null : (System.String)dataRow["SoSoBaoHiem"];
			entity.ThoiGianBatDau = Convert.IsDBNull(dataRow["ThoiGianBatDau"]) ? null : (System.String)dataRow["ThoiGianBatDau"];
			entity.BacLuong = Convert.IsDBNull(dataRow["BacLuong"]) ? null : (System.Decimal?)dataRow["BacLuong"];
			entity.NgayHuongLuong = Convert.IsDBNull(dataRow["NgayHuongLuong"]) ? null : (System.String)dataRow["NgayHuongLuong"];
			entity.NamLamViec = Convert.IsDBNull(dataRow["NamLamViec"]) ? null : (System.String)dataRow["NamLamViec"];
			entity.ChuyenNganh = Convert.IsDBNull(dataRow["ChuyenNganh"]) ? null : (System.String)dataRow["ChuyenNganh"];
			entity.MaHeSoThuLao = Convert.IsDBNull(dataRow["MaHeSoThuLao"]) ? null : (System.String)dataRow["MaHeSoThuLao"];
			entity.Ngach = Convert.IsDBNull(dataRow["Ngach"]) ? null : (System.String)dataRow["Ngach"];
			entity.SoHieuCongChuc = Convert.IsDBNull(dataRow["SoHieuCongChuc"]) ? null : (System.String)dataRow["SoHieuCongChuc"];
			entity.Hrmid = Convert.IsDBNull(dataRow["HRMID"]) ? null : (System.Guid?)dataRow["HRMID"];
			entity.NoiCapBang = Convert.IsDBNull(dataRow["NoiCapBang"]) ? null : (System.String)dataRow["NoiCapBang"];
			entity.KhoaTaiKhoan = Convert.IsDBNull(dataRow["KhoaTaiKhoan"]) ? null : (System.Boolean?)dataRow["KhoaTaiKhoan"];
			entity.MaLoaiNhanVien = Convert.IsDBNull(dataRow["MaLoaiNhanVien"]) ? null : (System.Int32?)dataRow["MaLoaiNhanVien"];
			entity.MaNgachCongChuc = Convert.IsDBNull(dataRow["MaNgachCongChuc"]) ? null : (System.Int32?)dataRow["MaNgachCongChuc"];
			entity.MaTrinhDoChinhTri = Convert.IsDBNull(dataRow["MaTrinhDoChinhTri"]) ? null : (System.Int32?)dataRow["MaTrinhDoChinhTri"];
			entity.MaTrinhDoSuPham = Convert.IsDBNull(dataRow["MaTrinhDoSuPham"]) ? null : (System.Int32?)dataRow["MaTrinhDoSuPham"];
			entity.MaTrinhDoNgoaiNgu = Convert.IsDBNull(dataRow["MaTrinhDoNgoaiNgu"]) ? null : (System.Int32?)dataRow["MaTrinhDoNgoaiNgu"];
			entity.MaTrinhDoTinHoc = Convert.IsDBNull(dataRow["MaTrinhDoTinHoc"]) ? null : (System.Int32?)dataRow["MaTrinhDoTinHoc"];
			entity.MaTrinhDoQuanLyNhaNuoc = Convert.IsDBNull(dataRow["MaTrinhDoQuanLyNhaNuoc"]) ? null : (System.Int32?)dataRow["MaTrinhDoQuanLyNhaNuoc"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
			entity.KhoiKienThucGiangDay = Convert.IsDBNull(dataRow["KhoiKienThucGiangDay"]) ? null : (System.String)dataRow["KhoiKienThucGiangDay"];
			entity.NganhDaoTao = Convert.IsDBNull(dataRow["NganhDaoTao"]) ? null : (System.String)dataRow["NganhDaoTao"];
			entity.DonViGiangDay = Convert.IsDBNull(dataRow["DonViGiangDay"]) ? null : (System.String)dataRow["DonViGiangDay"];
			entity.IdHoSo = Convert.IsDBNull(dataRow["IdHoSo"]) ? null : (System.Int32?)dataRow["IdHoSo"];
			entity.MaQuocTich = Convert.IsDBNull(dataRow["MaQuocTich"]) ? null : (System.Int32?)dataRow["MaQuocTich"];
			entity.DaXoaHrm = Convert.IsDBNull(dataRow["DaXoaHRM"]) ? null : (System.Boolean?)dataRow["DaXoaHRM"];
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
		/// <param name="entity">The <see cref="PMS.Entities.GiangVien"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.GiangVien Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.GiangVien entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region MaNgachCongChucSource	
			if (CanDeepLoad(entity, "NgachCongChuc|MaNgachCongChucSource", deepLoadType, innerList) 
				&& entity.MaNgachCongChucSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaNgachCongChuc ?? (int)0);
				NgachCongChuc tmpEntity = EntityManager.LocateEntity<NgachCongChuc>(EntityLocator.ConstructKeyFromPkItems(typeof(NgachCongChuc), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaNgachCongChucSource = tmpEntity;
				else
					entity.MaNgachCongChucSource = DataRepository.NgachCongChucProvider.GetByMaNgachCongChuc(transactionManager, (entity.MaNgachCongChuc ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaNgachCongChucSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaNgachCongChucSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.NgachCongChucProvider.DeepLoad(transactionManager, entity.MaNgachCongChucSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaNgachCongChucSource

			#region MaNguoiLapSource	
			if (CanDeepLoad(entity, "TaiKhoan|MaNguoiLapSource", deepLoadType, innerList) 
				&& entity.MaNguoiLapSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaNguoiLap ?? (int)0);
				TaiKhoan tmpEntity = EntityManager.LocateEntity<TaiKhoan>(EntityLocator.ConstructKeyFromPkItems(typeof(TaiKhoan), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaNguoiLapSource = tmpEntity;
				else
					entity.MaNguoiLapSource = DataRepository.TaiKhoanProvider.GetByMaTaiKhoan(transactionManager, (entity.MaNguoiLap ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaNguoiLapSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaNguoiLapSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.TaiKhoanProvider.DeepLoad(transactionManager, entity.MaNguoiLapSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaNguoiLapSource

			#region MaTinhTrangSource	
			if (CanDeepLoad(entity, "TinhTrang|MaTinhTrangSource", deepLoadType, innerList) 
				&& entity.MaTinhTrangSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaTinhTrang ?? (int)0);
				TinhTrang tmpEntity = EntityManager.LocateEntity<TinhTrang>(EntityLocator.ConstructKeyFromPkItems(typeof(TinhTrang), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaTinhTrangSource = tmpEntity;
				else
					entity.MaTinhTrangSource = DataRepository.TinhTrangProvider.GetByMaTinhTrang(transactionManager, (entity.MaTinhTrang ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaTinhTrangSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaTinhTrangSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.TinhTrangProvider.DeepLoad(transactionManager, entity.MaTinhTrangSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaTinhTrangSource

			#region MaTrinhDoChinhTriSource	
			if (CanDeepLoad(entity, "TrinhDoChinhTri|MaTrinhDoChinhTriSource", deepLoadType, innerList) 
				&& entity.MaTrinhDoChinhTriSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaTrinhDoChinhTri ?? (int)0);
				TrinhDoChinhTri tmpEntity = EntityManager.LocateEntity<TrinhDoChinhTri>(EntityLocator.ConstructKeyFromPkItems(typeof(TrinhDoChinhTri), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaTrinhDoChinhTriSource = tmpEntity;
				else
					entity.MaTrinhDoChinhTriSource = DataRepository.TrinhDoChinhTriProvider.GetByMaTrinhDoChinhTri(transactionManager, (entity.MaTrinhDoChinhTri ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaTrinhDoChinhTriSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaTrinhDoChinhTriSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.TrinhDoChinhTriProvider.DeepLoad(transactionManager, entity.MaTrinhDoChinhTriSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaTrinhDoChinhTriSource

			#region MaTrinhDoNgoaiNguSource	
			if (CanDeepLoad(entity, "TrinhDoNgoaiNgu|MaTrinhDoNgoaiNguSource", deepLoadType, innerList) 
				&& entity.MaTrinhDoNgoaiNguSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaTrinhDoNgoaiNgu ?? (int)0);
				TrinhDoNgoaiNgu tmpEntity = EntityManager.LocateEntity<TrinhDoNgoaiNgu>(EntityLocator.ConstructKeyFromPkItems(typeof(TrinhDoNgoaiNgu), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaTrinhDoNgoaiNguSource = tmpEntity;
				else
					entity.MaTrinhDoNgoaiNguSource = DataRepository.TrinhDoNgoaiNguProvider.GetByMaTrinhDoNgoaiNgu(transactionManager, (entity.MaTrinhDoNgoaiNgu ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaTrinhDoNgoaiNguSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaTrinhDoNgoaiNguSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.TrinhDoNgoaiNguProvider.DeepLoad(transactionManager, entity.MaTrinhDoNgoaiNguSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaTrinhDoNgoaiNguSource

			#region MaTrinhDoQuanLyNhaNuocSource	
			if (CanDeepLoad(entity, "TrinhDoQuanLyNhaNuoc|MaTrinhDoQuanLyNhaNuocSource", deepLoadType, innerList) 
				&& entity.MaTrinhDoQuanLyNhaNuocSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaTrinhDoQuanLyNhaNuoc ?? (int)0);
				TrinhDoQuanLyNhaNuoc tmpEntity = EntityManager.LocateEntity<TrinhDoQuanLyNhaNuoc>(EntityLocator.ConstructKeyFromPkItems(typeof(TrinhDoQuanLyNhaNuoc), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaTrinhDoQuanLyNhaNuocSource = tmpEntity;
				else
					entity.MaTrinhDoQuanLyNhaNuocSource = DataRepository.TrinhDoQuanLyNhaNuocProvider.GetByMaTrinhDoQuanLyNhaNuoc(transactionManager, (entity.MaTrinhDoQuanLyNhaNuoc ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaTrinhDoQuanLyNhaNuocSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaTrinhDoQuanLyNhaNuocSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.TrinhDoQuanLyNhaNuocProvider.DeepLoad(transactionManager, entity.MaTrinhDoQuanLyNhaNuocSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaTrinhDoQuanLyNhaNuocSource

			#region MaTrinhDoSuPhamSource	
			if (CanDeepLoad(entity, "TrinhDoSuPham|MaTrinhDoSuPhamSource", deepLoadType, innerList) 
				&& entity.MaTrinhDoSuPhamSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaTrinhDoSuPham ?? (int)0);
				TrinhDoSuPham tmpEntity = EntityManager.LocateEntity<TrinhDoSuPham>(EntityLocator.ConstructKeyFromPkItems(typeof(TrinhDoSuPham), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaTrinhDoSuPhamSource = tmpEntity;
				else
					entity.MaTrinhDoSuPhamSource = DataRepository.TrinhDoSuPhamProvider.GetByMaTrinhDoSuPham(transactionManager, (entity.MaTrinhDoSuPham ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaTrinhDoSuPhamSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaTrinhDoSuPhamSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.TrinhDoSuPhamProvider.DeepLoad(transactionManager, entity.MaTrinhDoSuPhamSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaTrinhDoSuPhamSource

			#region MaTrinhDoTinHocSource	
			if (CanDeepLoad(entity, "TrinhDoTinHoc|MaTrinhDoTinHocSource", deepLoadType, innerList) 
				&& entity.MaTrinhDoTinHocSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaTrinhDoTinHoc ?? (int)0);
				TrinhDoTinHoc tmpEntity = EntityManager.LocateEntity<TrinhDoTinHoc>(EntityLocator.ConstructKeyFromPkItems(typeof(TrinhDoTinHoc), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaTrinhDoTinHocSource = tmpEntity;
				else
					entity.MaTrinhDoTinHocSource = DataRepository.TrinhDoTinHocProvider.GetByMaTrinhDoTinHoc(transactionManager, (entity.MaTrinhDoTinHoc ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaTrinhDoTinHocSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaTrinhDoTinHocSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.TrinhDoTinHocProvider.DeepLoad(transactionManager, entity.MaTrinhDoTinHocSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaTrinhDoTinHocSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMaGiangVien methods when available
			
			#region TietNoKyTruocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<TietNoKyTruoc>|TietNoKyTruocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'TietNoKyTruocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.TietNoKyTruocCollection = DataRepository.TietNoKyTruocProvider.GetByMaGiangVien(transactionManager, entity.MaGiangVien);

				if (deep && entity.TietNoKyTruocCollection.Count > 0)
				{
					deepHandles.Add("TietNoKyTruocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<TietNoKyTruoc>) DataRepository.TietNoKyTruocProvider.DeepLoad,
						new object[] { transactionManager, entity.TietNoKyTruocCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region KcqKhoiLuongKhacCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<KcqKhoiLuongKhac>|KcqKhoiLuongKhacCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'KcqKhoiLuongKhacCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.KcqKhoiLuongKhacCollection = DataRepository.KcqKhoiLuongKhacProvider.GetByMaGiangVien(transactionManager, entity.MaGiangVien);

				if (deep && entity.KcqKhoiLuongKhacCollection.Count > 0)
				{
					deepHandles.Add("KcqKhoiLuongKhacCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<KcqKhoiLuongKhac>) DataRepository.KcqKhoiLuongKhacProvider.DeepLoad,
						new object[] { transactionManager, entity.KcqKhoiLuongKhacCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ThuLaoThoaThuanCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ThuLaoThoaThuan>|ThuLaoThoaThuanCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ThuLaoThoaThuanCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ThuLaoThoaThuanCollection = DataRepository.ThuLaoThoaThuanProvider.GetByMaGiangVien(transactionManager, entity.MaGiangVien);

				if (deep && entity.ThuLaoThoaThuanCollection.Count > 0)
				{
					deepHandles.Add("ThuLaoThoaThuanCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ThuLaoThoaThuan>) DataRepository.ThuLaoThoaThuanProvider.DeepLoad,
						new object[] { transactionManager, entity.ThuLaoThoaThuanCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GiangVienCamKetKhongTruThueCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GiangVienCamKetKhongTruThue>|GiangVienCamKetKhongTruThueCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GiangVienCamKetKhongTruThueCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GiangVienCamKetKhongTruThueCollection = DataRepository.GiangVienCamKetKhongTruThueProvider.GetByMaGiangVien(transactionManager, entity.MaGiangVien);

				if (deep && entity.GiangVienCamKetKhongTruThueCollection.Count > 0)
				{
					deepHandles.Add("GiangVienCamKetKhongTruThueCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GiangVienCamKetKhongTruThue>) DataRepository.GiangVienCamKetKhongTruThueProvider.DeepLoad,
						new object[] { transactionManager, entity.GiangVienCamKetKhongTruThueCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ThamDinhLuanVanThacSyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ThamDinhLuanVanThacSy>|ThamDinhLuanVanThacSyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ThamDinhLuanVanThacSyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ThamDinhLuanVanThacSyCollection = DataRepository.ThamDinhLuanVanThacSyProvider.GetByMaGiangVien(transactionManager, entity.MaGiangVien);

				if (deep && entity.ThamDinhLuanVanThacSyCollection.Count > 0)
				{
					deepHandles.Add("ThamDinhLuanVanThacSyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ThamDinhLuanVanThacSy>) DataRepository.ThamDinhLuanVanThacSyProvider.DeepLoad,
						new object[] { transactionManager, entity.ThamDinhLuanVanThacSyCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GiangVienHoSoCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GiangVienHoSo>|GiangVienHoSoCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GiangVienHoSoCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GiangVienHoSoCollection = DataRepository.GiangVienHoSoProvider.GetByMaGiangVien(transactionManager, entity.MaGiangVien);

				if (deep && entity.GiangVienHoSoCollection.Count > 0)
				{
					deepHandles.Add("GiangVienHoSoCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GiangVienHoSo>) DataRepository.GiangVienHoSoProvider.DeepLoad,
						new object[] { transactionManager, entity.GiangVienHoSoCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ThoiGianLamViecCuaNhanVienCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ThoiGianLamViecCuaNhanVien>|ThoiGianLamViecCuaNhanVienCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ThoiGianLamViecCuaNhanVienCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ThoiGianLamViecCuaNhanVienCollection = DataRepository.ThoiGianLamViecCuaNhanVienProvider.GetByMaGiangVien(transactionManager, entity.MaGiangVien);

				if (deep && entity.ThoiGianLamViecCuaNhanVienCollection.Count > 0)
				{
					deepHandles.Add("ThoiGianLamViecCuaNhanVienCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ThoiGianLamViecCuaNhanVien>) DataRepository.ThoiGianLamViecCuaNhanVienProvider.DeepLoad,
						new object[] { transactionManager, entity.ThoiGianLamViecCuaNhanVienCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GiangVienHoatDongQuanLyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GiangVienHoatDongQuanLy>|GiangVienHoatDongQuanLyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GiangVienHoatDongQuanLyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GiangVienHoatDongQuanLyCollection = DataRepository.GiangVienHoatDongQuanLyProvider.GetByMaGiangVien(transactionManager, entity.MaGiangVien);

				if (deep && entity.GiangVienHoatDongQuanLyCollection.Count > 0)
				{
					deepHandles.Add("GiangVienHoatDongQuanLyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GiangVienHoatDongQuanLy>) DataRepository.GiangVienHoatDongQuanLyProvider.DeepLoad,
						new object[] { transactionManager, entity.GiangVienHoatDongQuanLyCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region KhoiLuongKhacCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<KhoiLuongKhac>|KhoiLuongKhacCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'KhoiLuongKhacCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.KhoiLuongKhacCollection = DataRepository.KhoiLuongKhacProvider.GetByMaGiangVien(transactionManager, entity.MaGiangVien);

				if (deep && entity.KhoiLuongKhacCollection.Count > 0)
				{
					deepHandles.Add("KhoiLuongKhacCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<KhoiLuongKhac>) DataRepository.KhoiLuongKhacProvider.DeepLoad,
						new object[] { transactionManager, entity.KhoiLuongKhacCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoVanHocTapCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoVanHocTap>|CoVanHocTapCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoVanHocTapCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoVanHocTapCollection = DataRepository.CoVanHocTapProvider.GetByMaGiangVien(transactionManager, entity.MaGiangVien);

				if (deep && entity.CoVanHocTapCollection.Count > 0)
				{
					deepHandles.Add("CoVanHocTapCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoVanHocTap>) DataRepository.CoVanHocTapProvider.DeepLoad,
						new object[] { transactionManager, entity.CoVanHocTapCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GiangVienNghienCuuKhCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GiangVienNghienCuuKh>|GiangVienNghienCuuKhCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GiangVienNghienCuuKhCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GiangVienNghienCuuKhCollection = DataRepository.GiangVienNghienCuuKhProvider.GetByMaGiangVien(transactionManager, entity.MaGiangVien);

				if (deep && entity.GiangVienNghienCuuKhCollection.Count > 0)
				{
					deepHandles.Add("GiangVienNghienCuuKhCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GiangVienNghienCuuKh>) DataRepository.GiangVienNghienCuuKhProvider.DeepLoad,
						new object[] { transactionManager, entity.GiangVienNghienCuuKhCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GiangVienChucVuCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GiangVienChucVu>|GiangVienChucVuCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GiangVienChucVuCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GiangVienChucVuCollection = DataRepository.GiangVienChucVuProvider.GetByMaGiangVien(transactionManager, entity.MaGiangVien);

				if (deep && entity.GiangVienChucVuCollection.Count > 0)
				{
					deepHandles.Add("GiangVienChucVuCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GiangVienChucVu>) DataRepository.GiangVienChucVuProvider.DeepLoad,
						new object[] { transactionManager, entity.GiangVienChucVuCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region XetDuyetDeCuongLuanVanCaoHocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<XetDuyetDeCuongLuanVanCaoHoc>|XetDuyetDeCuongLuanVanCaoHocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'XetDuyetDeCuongLuanVanCaoHocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.XetDuyetDeCuongLuanVanCaoHocCollection = DataRepository.XetDuyetDeCuongLuanVanCaoHocProvider.GetByMaGiangVien(transactionManager, entity.MaGiangVien);

				if (deep && entity.XetDuyetDeCuongLuanVanCaoHocCollection.Count > 0)
				{
					deepHandles.Add("XetDuyetDeCuongLuanVanCaoHocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<XetDuyetDeCuongLuanVanCaoHoc>) DataRepository.XetDuyetDeCuongLuanVanCaoHocProvider.DeepLoad,
						new object[] { transactionManager, entity.XetDuyetDeCuongLuanVanCaoHocCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region KetQuaTinhCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<KetQuaTinh>|KetQuaTinhCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'KetQuaTinhCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.KetQuaTinhCollection = DataRepository.KetQuaTinhProvider.GetByMaGiangVien(transactionManager, entity.MaGiangVien);

				if (deep && entity.KetQuaTinhCollection.Count > 0)
				{
					deepHandles.Add("KetQuaTinhCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<KetQuaTinh>) DataRepository.KetQuaTinhProvider.DeepLoad,
						new object[] { transactionManager, entity.KetQuaTinhCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ThoiGianNghiTamThoiCuaGiangVienCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ThoiGianNghiTamThoiCuaGiangVien>|ThoiGianNghiTamThoiCuaGiangVienCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ThoiGianNghiTamThoiCuaGiangVienCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ThoiGianNghiTamThoiCuaGiangVienCollection = DataRepository.ThoiGianNghiTamThoiCuaGiangVienProvider.GetByMaGiangVien(transactionManager, entity.MaGiangVien);

				if (deep && entity.ThoiGianNghiTamThoiCuaGiangVienCollection.Count > 0)
				{
					deepHandles.Add("ThoiGianNghiTamThoiCuaGiangVienCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ThoiGianNghiTamThoiCuaGiangVien>) DataRepository.ThoiGianNghiTamThoiCuaGiangVienProvider.DeepLoad,
						new object[] { transactionManager, entity.ThoiGianNghiTamThoiCuaGiangVienCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GiangVienTinhLuongThinhGiangCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GiangVienTinhLuongThinhGiang>|GiangVienTinhLuongThinhGiangCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GiangVienTinhLuongThinhGiangCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GiangVienTinhLuongThinhGiangCollection = DataRepository.GiangVienTinhLuongThinhGiangProvider.GetByMaGiangVien(transactionManager, entity.MaGiangVien);

				if (deep && entity.GiangVienTinhLuongThinhGiangCollection.Count > 0)
				{
					deepHandles.Add("GiangVienTinhLuongThinhGiangCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GiangVienTinhLuongThinhGiang>) DataRepository.GiangVienTinhLuongThinhGiangProvider.DeepLoad,
						new object[] { transactionManager, entity.GiangVienTinhLuongThinhGiangCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GiangVienChuyenMonCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GiangVienChuyenMon>|GiangVienChuyenMonCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GiangVienChuyenMonCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GiangVienChuyenMonCollection = DataRepository.GiangVienChuyenMonProvider.GetByMaGiangVien(transactionManager, entity.MaGiangVien);

				if (deep && entity.GiangVienChuyenMonCollection.Count > 0)
				{
					deepHandles.Add("GiangVienChuyenMonCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GiangVienChuyenMon>) DataRepository.GiangVienChuyenMonProvider.DeepLoad,
						new object[] { transactionManager, entity.GiangVienChuyenMonCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region BangPhuTroiNamHocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<BangPhuTroiNamHoc>|BangPhuTroiNamHocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'BangPhuTroiNamHocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.BangPhuTroiNamHocCollection = DataRepository.BangPhuTroiNamHocProvider.GetByMaGiangVien(transactionManager, entity.MaGiangVien);

				if (deep && entity.BangPhuTroiNamHocCollection.Count > 0)
				{
					deepHandles.Add("BangPhuTroiNamHocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<BangPhuTroiNamHoc>) DataRepository.BangPhuTroiNamHocProvider.DeepLoad,
						new object[] { transactionManager, entity.BangPhuTroiNamHocCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region TietNghiaVuCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<TietNghiaVu>|TietNghiaVuCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'TietNghiaVuCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.TietNghiaVuCollection = DataRepository.TietNghiaVuProvider.GetByMaGiangVien(transactionManager, entity.MaGiangVien);

				if (deep && entity.TietNghiaVuCollection.Count > 0)
				{
					deepHandles.Add("TietNghiaVuCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<TietNghiaVu>) DataRepository.TietNghiaVuProvider.DeepLoad,
						new object[] { transactionManager, entity.TietNghiaVuCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GiangVienMocTangLuongCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GiangVienMocTangLuong>|GiangVienMocTangLuongCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GiangVienMocTangLuongCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GiangVienMocTangLuongCollection = DataRepository.GiangVienMocTangLuongProvider.GetByMaGiangVien(transactionManager, entity.MaGiangVien);

				if (deep && entity.GiangVienMocTangLuongCollection.Count > 0)
				{
					deepHandles.Add("GiangVienMocTangLuongCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GiangVienMocTangLuong>) DataRepository.GiangVienMocTangLuongProvider.DeepLoad,
						new object[] { transactionManager, entity.GiangVienMocTangLuongCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GiangVienGiamTruDinhMucCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GiangVienGiamTruDinhMuc>|GiangVienGiamTruDinhMucCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GiangVienGiamTruDinhMucCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GiangVienGiamTruDinhMucCollection = DataRepository.GiangVienGiamTruDinhMucProvider.GetByMaGiangVien(transactionManager, entity.MaGiangVien);

				if (deep && entity.GiangVienGiamTruDinhMucCollection.Count > 0)
				{
					deepHandles.Add("GiangVienGiamTruDinhMucCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GiangVienGiamTruDinhMuc>) DataRepository.GiangVienGiamTruDinhMucProvider.DeepLoad,
						new object[] { transactionManager, entity.GiangVienGiamTruDinhMucCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MaHoSoHoSoCollection_From_GiangVienHoSo
			// RelationshipType.ManyToMany
			if (CanDeepLoad(entity, "List<HoSo>|MaHoSoHoSoCollection_From_GiangVienHoSo", deepLoadType, innerList))
			{
				entity.MaHoSoHoSoCollection_From_GiangVienHoSo = DataRepository.HoSoProvider.GetByMaGiangVienFromGiangVienHoSo(transactionManager, entity.MaGiangVien);			 
		
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaHoSoHoSoCollection_From_GiangVienHoSo' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaHoSoHoSoCollection_From_GiangVienHoSo != null)
				{
					deepHandles.Add("MaHoSoHoSoCollection_From_GiangVienHoSo",
						new KeyValuePair<Delegate, object>((DeepLoadHandle< HoSo >) DataRepository.HoSoProvider.DeepLoad,
						new object[] { transactionManager, entity.MaHoSoHoSoCollection_From_GiangVienHoSo, deep, deepLoadType, childTypes, innerList }
					));
				}
			}
			#endregion
			
			
			
			#region GiangVienHoatDongNgoaiGiangDayCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GiangVienHoatDongNgoaiGiangDay>|GiangVienHoatDongNgoaiGiangDayCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GiangVienHoatDongNgoaiGiangDayCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GiangVienHoatDongNgoaiGiangDayCollection = DataRepository.GiangVienHoatDongNgoaiGiangDayProvider.GetByMaGiangVien(transactionManager, entity.MaGiangVien);

				if (deep && entity.GiangVienHoatDongNgoaiGiangDayCollection.Count > 0)
				{
					deepHandles.Add("GiangVienHoatDongNgoaiGiangDayCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GiangVienHoatDongNgoaiGiangDay>) DataRepository.GiangVienHoatDongNgoaiGiangDayProvider.DeepLoad,
						new object[] { transactionManager, entity.GiangVienHoatDongNgoaiGiangDayCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
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
		/// Deep Save the entire object graph of the PMS.Entities.GiangVien object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.GiangVien instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.GiangVien Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.GiangVien entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region MaNgachCongChucSource
			if (CanDeepSave(entity, "NgachCongChuc|MaNgachCongChucSource", deepSaveType, innerList) 
				&& entity.MaNgachCongChucSource != null)
			{
				DataRepository.NgachCongChucProvider.Save(transactionManager, entity.MaNgachCongChucSource);
				entity.MaNgachCongChuc = entity.MaNgachCongChucSource.MaNgachCongChuc;
			}
			#endregion 
			
			#region MaNguoiLapSource
			if (CanDeepSave(entity, "TaiKhoan|MaNguoiLapSource", deepSaveType, innerList) 
				&& entity.MaNguoiLapSource != null)
			{
				DataRepository.TaiKhoanProvider.Save(transactionManager, entity.MaNguoiLapSource);
				entity.MaNguoiLap = entity.MaNguoiLapSource.MaTaiKhoan;
			}
			#endregion 
			
			#region MaTinhTrangSource
			if (CanDeepSave(entity, "TinhTrang|MaTinhTrangSource", deepSaveType, innerList) 
				&& entity.MaTinhTrangSource != null)
			{
				DataRepository.TinhTrangProvider.Save(transactionManager, entity.MaTinhTrangSource);
				entity.MaTinhTrang = entity.MaTinhTrangSource.MaTinhTrang;
			}
			#endregion 
			
			#region MaTrinhDoChinhTriSource
			if (CanDeepSave(entity, "TrinhDoChinhTri|MaTrinhDoChinhTriSource", deepSaveType, innerList) 
				&& entity.MaTrinhDoChinhTriSource != null)
			{
				DataRepository.TrinhDoChinhTriProvider.Save(transactionManager, entity.MaTrinhDoChinhTriSource);
				entity.MaTrinhDoChinhTri = entity.MaTrinhDoChinhTriSource.MaTrinhDoChinhTri;
			}
			#endregion 
			
			#region MaTrinhDoNgoaiNguSource
			if (CanDeepSave(entity, "TrinhDoNgoaiNgu|MaTrinhDoNgoaiNguSource", deepSaveType, innerList) 
				&& entity.MaTrinhDoNgoaiNguSource != null)
			{
				DataRepository.TrinhDoNgoaiNguProvider.Save(transactionManager, entity.MaTrinhDoNgoaiNguSource);
				entity.MaTrinhDoNgoaiNgu = entity.MaTrinhDoNgoaiNguSource.MaTrinhDoNgoaiNgu;
			}
			#endregion 
			
			#region MaTrinhDoQuanLyNhaNuocSource
			if (CanDeepSave(entity, "TrinhDoQuanLyNhaNuoc|MaTrinhDoQuanLyNhaNuocSource", deepSaveType, innerList) 
				&& entity.MaTrinhDoQuanLyNhaNuocSource != null)
			{
				DataRepository.TrinhDoQuanLyNhaNuocProvider.Save(transactionManager, entity.MaTrinhDoQuanLyNhaNuocSource);
				entity.MaTrinhDoQuanLyNhaNuoc = entity.MaTrinhDoQuanLyNhaNuocSource.MaTrinhDoQuanLyNhaNuoc;
			}
			#endregion 
			
			#region MaTrinhDoSuPhamSource
			if (CanDeepSave(entity, "TrinhDoSuPham|MaTrinhDoSuPhamSource", deepSaveType, innerList) 
				&& entity.MaTrinhDoSuPhamSource != null)
			{
				DataRepository.TrinhDoSuPhamProvider.Save(transactionManager, entity.MaTrinhDoSuPhamSource);
				entity.MaTrinhDoSuPham = entity.MaTrinhDoSuPhamSource.MaTrinhDoSuPham;
			}
			#endregion 
			
			#region MaTrinhDoTinHocSource
			if (CanDeepSave(entity, "TrinhDoTinHoc|MaTrinhDoTinHocSource", deepSaveType, innerList) 
				&& entity.MaTrinhDoTinHocSource != null)
			{
				DataRepository.TrinhDoTinHocProvider.Save(transactionManager, entity.MaTrinhDoTinHocSource);
				entity.MaTrinhDoTinHoc = entity.MaTrinhDoTinHocSource.MaTrinhDoTinHoc;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();

			#region MaHoSoHoSoCollection_From_GiangVienHoSo>
			if (CanDeepSave(entity.MaHoSoHoSoCollection_From_GiangVienHoSo, "List<HoSo>|MaHoSoHoSoCollection_From_GiangVienHoSo", deepSaveType, innerList))
			{
				if (entity.MaHoSoHoSoCollection_From_GiangVienHoSo.Count > 0 || entity.MaHoSoHoSoCollection_From_GiangVienHoSo.DeletedItems.Count > 0)
				{
					DataRepository.HoSoProvider.Save(transactionManager, entity.MaHoSoHoSoCollection_From_GiangVienHoSo); 
					deepHandles.Add("MaHoSoHoSoCollection_From_GiangVienHoSo",
						new KeyValuePair<Delegate, object>((DeepSaveHandle<HoSo>) DataRepository.HoSoProvider.DeepSave,
						new object[] { transactionManager, entity.MaHoSoHoSoCollection_From_GiangVienHoSo, deepSaveType, childTypes, innerList }
					));
				}
			}
			#endregion 
	
			#region List<TietNoKyTruoc>
				if (CanDeepSave(entity.TietNoKyTruocCollection, "List<TietNoKyTruoc>|TietNoKyTruocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(TietNoKyTruoc child in entity.TietNoKyTruocCollection)
					{
						if(child.MaGiangVienSource != null)
						{
							child.MaGiangVien = child.MaGiangVienSource.MaGiangVien;
						}
						else
						{
							child.MaGiangVien = entity.MaGiangVien;
						}

					}

					if (entity.TietNoKyTruocCollection.Count > 0 || entity.TietNoKyTruocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.TietNoKyTruocProvider.Save(transactionManager, entity.TietNoKyTruocCollection);
						
						deepHandles.Add("TietNoKyTruocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< TietNoKyTruoc >) DataRepository.TietNoKyTruocProvider.DeepSave,
							new object[] { transactionManager, entity.TietNoKyTruocCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<KcqKhoiLuongKhac>
				if (CanDeepSave(entity.KcqKhoiLuongKhacCollection, "List<KcqKhoiLuongKhac>|KcqKhoiLuongKhacCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(KcqKhoiLuongKhac child in entity.KcqKhoiLuongKhacCollection)
					{
						if(child.MaGiangVienSource != null)
						{
							child.MaGiangVien = child.MaGiangVienSource.MaGiangVien;
						}
						else
						{
							child.MaGiangVien = entity.MaGiangVien;
						}

					}

					if (entity.KcqKhoiLuongKhacCollection.Count > 0 || entity.KcqKhoiLuongKhacCollection.DeletedItems.Count > 0)
					{
						//DataRepository.KcqKhoiLuongKhacProvider.Save(transactionManager, entity.KcqKhoiLuongKhacCollection);
						
						deepHandles.Add("KcqKhoiLuongKhacCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< KcqKhoiLuongKhac >) DataRepository.KcqKhoiLuongKhacProvider.DeepSave,
							new object[] { transactionManager, entity.KcqKhoiLuongKhacCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ThuLaoThoaThuan>
				if (CanDeepSave(entity.ThuLaoThoaThuanCollection, "List<ThuLaoThoaThuan>|ThuLaoThoaThuanCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ThuLaoThoaThuan child in entity.ThuLaoThoaThuanCollection)
					{
						if(child.MaGiangVienSource != null)
						{
							child.MaGiangVien = child.MaGiangVienSource.MaGiangVien;
						}
						else
						{
							child.MaGiangVien = entity.MaGiangVien;
						}

					}

					if (entity.ThuLaoThoaThuanCollection.Count > 0 || entity.ThuLaoThoaThuanCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ThuLaoThoaThuanProvider.Save(transactionManager, entity.ThuLaoThoaThuanCollection);
						
						deepHandles.Add("ThuLaoThoaThuanCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ThuLaoThoaThuan >) DataRepository.ThuLaoThoaThuanProvider.DeepSave,
							new object[] { transactionManager, entity.ThuLaoThoaThuanCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GiangVienCamKetKhongTruThue>
				if (CanDeepSave(entity.GiangVienCamKetKhongTruThueCollection, "List<GiangVienCamKetKhongTruThue>|GiangVienCamKetKhongTruThueCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GiangVienCamKetKhongTruThue child in entity.GiangVienCamKetKhongTruThueCollection)
					{
						if(child.MaGiangVienSource != null)
						{
							child.MaGiangVien = child.MaGiangVienSource.MaGiangVien;
						}
						else
						{
							child.MaGiangVien = entity.MaGiangVien;
						}

					}

					if (entity.GiangVienCamKetKhongTruThueCollection.Count > 0 || entity.GiangVienCamKetKhongTruThueCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GiangVienCamKetKhongTruThueProvider.Save(transactionManager, entity.GiangVienCamKetKhongTruThueCollection);
						
						deepHandles.Add("GiangVienCamKetKhongTruThueCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GiangVienCamKetKhongTruThue >) DataRepository.GiangVienCamKetKhongTruThueProvider.DeepSave,
							new object[] { transactionManager, entity.GiangVienCamKetKhongTruThueCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ThamDinhLuanVanThacSy>
				if (CanDeepSave(entity.ThamDinhLuanVanThacSyCollection, "List<ThamDinhLuanVanThacSy>|ThamDinhLuanVanThacSyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ThamDinhLuanVanThacSy child in entity.ThamDinhLuanVanThacSyCollection)
					{
						if(child.MaGiangVienSource != null)
						{
							child.MaGiangVien = child.MaGiangVienSource.MaGiangVien;
						}
						else
						{
							child.MaGiangVien = entity.MaGiangVien;
						}

					}

					if (entity.ThamDinhLuanVanThacSyCollection.Count > 0 || entity.ThamDinhLuanVanThacSyCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ThamDinhLuanVanThacSyProvider.Save(transactionManager, entity.ThamDinhLuanVanThacSyCollection);
						
						deepHandles.Add("ThamDinhLuanVanThacSyCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ThamDinhLuanVanThacSy >) DataRepository.ThamDinhLuanVanThacSyProvider.DeepSave,
							new object[] { transactionManager, entity.ThamDinhLuanVanThacSyCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GiangVienHoSo>
				if (CanDeepSave(entity.GiangVienHoSoCollection, "List<GiangVienHoSo>|GiangVienHoSoCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GiangVienHoSo child in entity.GiangVienHoSoCollection)
					{
						if(child.MaGiangVienSource != null)
						{
								child.MaGiangVien = child.MaGiangVienSource.MaGiangVien;
						}

						if(child.MaHoSoSource != null)
						{
								child.MaHoSo = child.MaHoSoSource.MaHoSo;
						}

					}

					if (entity.GiangVienHoSoCollection.Count > 0 || entity.GiangVienHoSoCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GiangVienHoSoProvider.Save(transactionManager, entity.GiangVienHoSoCollection);
						
						deepHandles.Add("GiangVienHoSoCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GiangVienHoSo >) DataRepository.GiangVienHoSoProvider.DeepSave,
							new object[] { transactionManager, entity.GiangVienHoSoCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ThoiGianLamViecCuaNhanVien>
				if (CanDeepSave(entity.ThoiGianLamViecCuaNhanVienCollection, "List<ThoiGianLamViecCuaNhanVien>|ThoiGianLamViecCuaNhanVienCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ThoiGianLamViecCuaNhanVien child in entity.ThoiGianLamViecCuaNhanVienCollection)
					{
						if(child.MaGiangVienSource != null)
						{
							child.MaGiangVien = child.MaGiangVienSource.MaGiangVien;
						}
						else
						{
							child.MaGiangVien = entity.MaGiangVien;
						}

					}

					if (entity.ThoiGianLamViecCuaNhanVienCollection.Count > 0 || entity.ThoiGianLamViecCuaNhanVienCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ThoiGianLamViecCuaNhanVienProvider.Save(transactionManager, entity.ThoiGianLamViecCuaNhanVienCollection);
						
						deepHandles.Add("ThoiGianLamViecCuaNhanVienCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ThoiGianLamViecCuaNhanVien >) DataRepository.ThoiGianLamViecCuaNhanVienProvider.DeepSave,
							new object[] { transactionManager, entity.ThoiGianLamViecCuaNhanVienCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GiangVienHoatDongQuanLy>
				if (CanDeepSave(entity.GiangVienHoatDongQuanLyCollection, "List<GiangVienHoatDongQuanLy>|GiangVienHoatDongQuanLyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GiangVienHoatDongQuanLy child in entity.GiangVienHoatDongQuanLyCollection)
					{
						if(child.MaGiangVienSource != null)
						{
							child.MaGiangVien = child.MaGiangVienSource.MaGiangVien;
						}
						else
						{
							child.MaGiangVien = entity.MaGiangVien;
						}

					}

					if (entity.GiangVienHoatDongQuanLyCollection.Count > 0 || entity.GiangVienHoatDongQuanLyCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GiangVienHoatDongQuanLyProvider.Save(transactionManager, entity.GiangVienHoatDongQuanLyCollection);
						
						deepHandles.Add("GiangVienHoatDongQuanLyCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GiangVienHoatDongQuanLy >) DataRepository.GiangVienHoatDongQuanLyProvider.DeepSave,
							new object[] { transactionManager, entity.GiangVienHoatDongQuanLyCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<KhoiLuongKhac>
				if (CanDeepSave(entity.KhoiLuongKhacCollection, "List<KhoiLuongKhac>|KhoiLuongKhacCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(KhoiLuongKhac child in entity.KhoiLuongKhacCollection)
					{
						if(child.MaGiangVienSource != null)
						{
							child.MaGiangVien = child.MaGiangVienSource.MaGiangVien;
						}
						else
						{
							child.MaGiangVien = entity.MaGiangVien;
						}

					}

					if (entity.KhoiLuongKhacCollection.Count > 0 || entity.KhoiLuongKhacCollection.DeletedItems.Count > 0)
					{
						//DataRepository.KhoiLuongKhacProvider.Save(transactionManager, entity.KhoiLuongKhacCollection);
						
						deepHandles.Add("KhoiLuongKhacCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< KhoiLuongKhac >) DataRepository.KhoiLuongKhacProvider.DeepSave,
							new object[] { transactionManager, entity.KhoiLuongKhacCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoVanHocTap>
				if (CanDeepSave(entity.CoVanHocTapCollection, "List<CoVanHocTap>|CoVanHocTapCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoVanHocTap child in entity.CoVanHocTapCollection)
					{
						if(child.MaGiangVienSource != null)
						{
							child.MaGiangVien = child.MaGiangVienSource.MaGiangVien;
						}
						else
						{
							child.MaGiangVien = entity.MaGiangVien;
						}

					}

					if (entity.CoVanHocTapCollection.Count > 0 || entity.CoVanHocTapCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoVanHocTapProvider.Save(transactionManager, entity.CoVanHocTapCollection);
						
						deepHandles.Add("CoVanHocTapCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoVanHocTap >) DataRepository.CoVanHocTapProvider.DeepSave,
							new object[] { transactionManager, entity.CoVanHocTapCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GiangVienNghienCuuKh>
				if (CanDeepSave(entity.GiangVienNghienCuuKhCollection, "List<GiangVienNghienCuuKh>|GiangVienNghienCuuKhCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GiangVienNghienCuuKh child in entity.GiangVienNghienCuuKhCollection)
					{
						if(child.MaGiangVienSource != null)
						{
							child.MaGiangVien = child.MaGiangVienSource.MaGiangVien;
						}
						else
						{
							child.MaGiangVien = entity.MaGiangVien;
						}

					}

					if (entity.GiangVienNghienCuuKhCollection.Count > 0 || entity.GiangVienNghienCuuKhCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GiangVienNghienCuuKhProvider.Save(transactionManager, entity.GiangVienNghienCuuKhCollection);
						
						deepHandles.Add("GiangVienNghienCuuKhCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GiangVienNghienCuuKh >) DataRepository.GiangVienNghienCuuKhProvider.DeepSave,
							new object[] { transactionManager, entity.GiangVienNghienCuuKhCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GiangVienChucVu>
				if (CanDeepSave(entity.GiangVienChucVuCollection, "List<GiangVienChucVu>|GiangVienChucVuCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GiangVienChucVu child in entity.GiangVienChucVuCollection)
					{
						if(child.MaGiangVienSource != null)
						{
							child.MaGiangVien = child.MaGiangVienSource.MaGiangVien;
						}
						else
						{
							child.MaGiangVien = entity.MaGiangVien;
						}

					}

					if (entity.GiangVienChucVuCollection.Count > 0 || entity.GiangVienChucVuCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GiangVienChucVuProvider.Save(transactionManager, entity.GiangVienChucVuCollection);
						
						deepHandles.Add("GiangVienChucVuCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GiangVienChucVu >) DataRepository.GiangVienChucVuProvider.DeepSave,
							new object[] { transactionManager, entity.GiangVienChucVuCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<XetDuyetDeCuongLuanVanCaoHoc>
				if (CanDeepSave(entity.XetDuyetDeCuongLuanVanCaoHocCollection, "List<XetDuyetDeCuongLuanVanCaoHoc>|XetDuyetDeCuongLuanVanCaoHocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(XetDuyetDeCuongLuanVanCaoHoc child in entity.XetDuyetDeCuongLuanVanCaoHocCollection)
					{
						if(child.MaGiangVienSource != null)
						{
							child.MaGiangVien = child.MaGiangVienSource.MaGiangVien;
						}
						else
						{
							child.MaGiangVien = entity.MaGiangVien;
						}

					}

					if (entity.XetDuyetDeCuongLuanVanCaoHocCollection.Count > 0 || entity.XetDuyetDeCuongLuanVanCaoHocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.XetDuyetDeCuongLuanVanCaoHocProvider.Save(transactionManager, entity.XetDuyetDeCuongLuanVanCaoHocCollection);
						
						deepHandles.Add("XetDuyetDeCuongLuanVanCaoHocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< XetDuyetDeCuongLuanVanCaoHoc >) DataRepository.XetDuyetDeCuongLuanVanCaoHocProvider.DeepSave,
							new object[] { transactionManager, entity.XetDuyetDeCuongLuanVanCaoHocCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<KetQuaTinh>
				if (CanDeepSave(entity.KetQuaTinhCollection, "List<KetQuaTinh>|KetQuaTinhCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(KetQuaTinh child in entity.KetQuaTinhCollection)
					{
						if(child.MaGiangVienSource != null)
						{
							child.MaGiangVien = child.MaGiangVienSource.MaGiangVien;
						}
						else
						{
							child.MaGiangVien = entity.MaGiangVien;
						}

					}

					if (entity.KetQuaTinhCollection.Count > 0 || entity.KetQuaTinhCollection.DeletedItems.Count > 0)
					{
						//DataRepository.KetQuaTinhProvider.Save(transactionManager, entity.KetQuaTinhCollection);
						
						deepHandles.Add("KetQuaTinhCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< KetQuaTinh >) DataRepository.KetQuaTinhProvider.DeepSave,
							new object[] { transactionManager, entity.KetQuaTinhCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ThoiGianNghiTamThoiCuaGiangVien>
				if (CanDeepSave(entity.ThoiGianNghiTamThoiCuaGiangVienCollection, "List<ThoiGianNghiTamThoiCuaGiangVien>|ThoiGianNghiTamThoiCuaGiangVienCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ThoiGianNghiTamThoiCuaGiangVien child in entity.ThoiGianNghiTamThoiCuaGiangVienCollection)
					{
						if(child.MaGiangVienSource != null)
						{
							child.MaGiangVien = child.MaGiangVienSource.MaGiangVien;
						}
						else
						{
							child.MaGiangVien = entity.MaGiangVien;
						}

					}

					if (entity.ThoiGianNghiTamThoiCuaGiangVienCollection.Count > 0 || entity.ThoiGianNghiTamThoiCuaGiangVienCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ThoiGianNghiTamThoiCuaGiangVienProvider.Save(transactionManager, entity.ThoiGianNghiTamThoiCuaGiangVienCollection);
						
						deepHandles.Add("ThoiGianNghiTamThoiCuaGiangVienCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ThoiGianNghiTamThoiCuaGiangVien >) DataRepository.ThoiGianNghiTamThoiCuaGiangVienProvider.DeepSave,
							new object[] { transactionManager, entity.ThoiGianNghiTamThoiCuaGiangVienCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GiangVienTinhLuongThinhGiang>
				if (CanDeepSave(entity.GiangVienTinhLuongThinhGiangCollection, "List<GiangVienTinhLuongThinhGiang>|GiangVienTinhLuongThinhGiangCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GiangVienTinhLuongThinhGiang child in entity.GiangVienTinhLuongThinhGiangCollection)
					{
						if(child.MaGiangVienSource != null)
						{
							child.MaGiangVien = child.MaGiangVienSource.MaGiangVien;
						}
						else
						{
							child.MaGiangVien = entity.MaGiangVien;
						}

					}

					if (entity.GiangVienTinhLuongThinhGiangCollection.Count > 0 || entity.GiangVienTinhLuongThinhGiangCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GiangVienTinhLuongThinhGiangProvider.Save(transactionManager, entity.GiangVienTinhLuongThinhGiangCollection);
						
						deepHandles.Add("GiangVienTinhLuongThinhGiangCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GiangVienTinhLuongThinhGiang >) DataRepository.GiangVienTinhLuongThinhGiangProvider.DeepSave,
							new object[] { transactionManager, entity.GiangVienTinhLuongThinhGiangCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GiangVienChuyenMon>
				if (CanDeepSave(entity.GiangVienChuyenMonCollection, "List<GiangVienChuyenMon>|GiangVienChuyenMonCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GiangVienChuyenMon child in entity.GiangVienChuyenMonCollection)
					{
						if(child.MaGiangVienSource != null)
						{
							child.MaGiangVien = child.MaGiangVienSource.MaGiangVien;
						}
						else
						{
							child.MaGiangVien = entity.MaGiangVien;
						}

					}

					if (entity.GiangVienChuyenMonCollection.Count > 0 || entity.GiangVienChuyenMonCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GiangVienChuyenMonProvider.Save(transactionManager, entity.GiangVienChuyenMonCollection);
						
						deepHandles.Add("GiangVienChuyenMonCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GiangVienChuyenMon >) DataRepository.GiangVienChuyenMonProvider.DeepSave,
							new object[] { transactionManager, entity.GiangVienChuyenMonCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<BangPhuTroiNamHoc>
				if (CanDeepSave(entity.BangPhuTroiNamHocCollection, "List<BangPhuTroiNamHoc>|BangPhuTroiNamHocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(BangPhuTroiNamHoc child in entity.BangPhuTroiNamHocCollection)
					{
						if(child.MaGiangVienSource != null)
						{
							child.MaGiangVien = child.MaGiangVienSource.MaGiangVien;
						}
						else
						{
							child.MaGiangVien = entity.MaGiangVien;
						}

					}

					if (entity.BangPhuTroiNamHocCollection.Count > 0 || entity.BangPhuTroiNamHocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.BangPhuTroiNamHocProvider.Save(transactionManager, entity.BangPhuTroiNamHocCollection);
						
						deepHandles.Add("BangPhuTroiNamHocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< BangPhuTroiNamHoc >) DataRepository.BangPhuTroiNamHocProvider.DeepSave,
							new object[] { transactionManager, entity.BangPhuTroiNamHocCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<TietNghiaVu>
				if (CanDeepSave(entity.TietNghiaVuCollection, "List<TietNghiaVu>|TietNghiaVuCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(TietNghiaVu child in entity.TietNghiaVuCollection)
					{
						if(child.MaGiangVienSource != null)
						{
							child.MaGiangVien = child.MaGiangVienSource.MaGiangVien;
						}
						else
						{
							child.MaGiangVien = entity.MaGiangVien;
						}

					}

					if (entity.TietNghiaVuCollection.Count > 0 || entity.TietNghiaVuCollection.DeletedItems.Count > 0)
					{
						//DataRepository.TietNghiaVuProvider.Save(transactionManager, entity.TietNghiaVuCollection);
						
						deepHandles.Add("TietNghiaVuCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< TietNghiaVu >) DataRepository.TietNghiaVuProvider.DeepSave,
							new object[] { transactionManager, entity.TietNghiaVuCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GiangVienMocTangLuong>
				if (CanDeepSave(entity.GiangVienMocTangLuongCollection, "List<GiangVienMocTangLuong>|GiangVienMocTangLuongCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GiangVienMocTangLuong child in entity.GiangVienMocTangLuongCollection)
					{
						if(child.MaGiangVienSource != null)
						{
							child.MaGiangVien = child.MaGiangVienSource.MaGiangVien;
						}
						else
						{
							child.MaGiangVien = entity.MaGiangVien;
						}

					}

					if (entity.GiangVienMocTangLuongCollection.Count > 0 || entity.GiangVienMocTangLuongCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GiangVienMocTangLuongProvider.Save(transactionManager, entity.GiangVienMocTangLuongCollection);
						
						deepHandles.Add("GiangVienMocTangLuongCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GiangVienMocTangLuong >) DataRepository.GiangVienMocTangLuongProvider.DeepSave,
							new object[] { transactionManager, entity.GiangVienMocTangLuongCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GiangVienGiamTruDinhMuc>
				if (CanDeepSave(entity.GiangVienGiamTruDinhMucCollection, "List<GiangVienGiamTruDinhMuc>|GiangVienGiamTruDinhMucCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GiangVienGiamTruDinhMuc child in entity.GiangVienGiamTruDinhMucCollection)
					{
						if(child.MaGiangVienSource != null)
						{
							child.MaGiangVien = child.MaGiangVienSource.MaGiangVien;
						}
						else
						{
							child.MaGiangVien = entity.MaGiangVien;
						}

					}

					if (entity.GiangVienGiamTruDinhMucCollection.Count > 0 || entity.GiangVienGiamTruDinhMucCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GiangVienGiamTruDinhMucProvider.Save(transactionManager, entity.GiangVienGiamTruDinhMucCollection);
						
						deepHandles.Add("GiangVienGiamTruDinhMucCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GiangVienGiamTruDinhMuc >) DataRepository.GiangVienGiamTruDinhMucProvider.DeepSave,
							new object[] { transactionManager, entity.GiangVienGiamTruDinhMucCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GiangVienHoatDongNgoaiGiangDay>
				if (CanDeepSave(entity.GiangVienHoatDongNgoaiGiangDayCollection, "List<GiangVienHoatDongNgoaiGiangDay>|GiangVienHoatDongNgoaiGiangDayCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GiangVienHoatDongNgoaiGiangDay child in entity.GiangVienHoatDongNgoaiGiangDayCollection)
					{
						if(child.MaGiangVienSource != null)
						{
							child.MaGiangVien = child.MaGiangVienSource.MaGiangVien;
						}
						else
						{
							child.MaGiangVien = entity.MaGiangVien;
						}

					}

					if (entity.GiangVienHoatDongNgoaiGiangDayCollection.Count > 0 || entity.GiangVienHoatDongNgoaiGiangDayCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GiangVienHoatDongNgoaiGiangDayProvider.Save(transactionManager, entity.GiangVienHoatDongNgoaiGiangDayCollection);
						
						deepHandles.Add("GiangVienHoatDongNgoaiGiangDayCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GiangVienHoatDongNgoaiGiangDay >) DataRepository.GiangVienHoatDongNgoaiGiangDayProvider.DeepSave,
							new object[] { transactionManager, entity.GiangVienHoatDongNgoaiGiangDayCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
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
	
	#region GiangVienChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.GiangVien</c>
	///</summary>
	public enum GiangVienChildEntityTypes
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
		
		///<summary>
		/// Composite Property for <c>NgachCongChuc</c> at MaNgachCongChucSource
		///</summary>
		[ChildEntityType(typeof(NgachCongChuc))]
		NgachCongChuc,
		
		///<summary>
		/// Composite Property for <c>TaiKhoan</c> at MaNguoiLapSource
		///</summary>
		[ChildEntityType(typeof(TaiKhoan))]
		TaiKhoan,
		
		///<summary>
		/// Composite Property for <c>TinhTrang</c> at MaTinhTrangSource
		///</summary>
		[ChildEntityType(typeof(TinhTrang))]
		TinhTrang,
		
		///<summary>
		/// Composite Property for <c>TrinhDoChinhTri</c> at MaTrinhDoChinhTriSource
		///</summary>
		[ChildEntityType(typeof(TrinhDoChinhTri))]
		TrinhDoChinhTri,
		
		///<summary>
		/// Composite Property for <c>TrinhDoNgoaiNgu</c> at MaTrinhDoNgoaiNguSource
		///</summary>
		[ChildEntityType(typeof(TrinhDoNgoaiNgu))]
		TrinhDoNgoaiNgu,
		
		///<summary>
		/// Composite Property for <c>TrinhDoQuanLyNhaNuoc</c> at MaTrinhDoQuanLyNhaNuocSource
		///</summary>
		[ChildEntityType(typeof(TrinhDoQuanLyNhaNuoc))]
		TrinhDoQuanLyNhaNuoc,
		
		///<summary>
		/// Composite Property for <c>TrinhDoSuPham</c> at MaTrinhDoSuPhamSource
		///</summary>
		[ChildEntityType(typeof(TrinhDoSuPham))]
		TrinhDoSuPham,
		
		///<summary>
		/// Composite Property for <c>TrinhDoTinHoc</c> at MaTrinhDoTinHocSource
		///</summary>
		[ChildEntityType(typeof(TrinhDoTinHoc))]
		TrinhDoTinHoc,
		///<summary>
		/// Collection of <c>GiangVien</c> as OneToMany for TietNoKyTruocCollection
		///</summary>
		[ChildEntityType(typeof(TList<TietNoKyTruoc>))]
		TietNoKyTruocCollection,
		///<summary>
		/// Collection of <c>GiangVien</c> as OneToMany for KcqKhoiLuongKhacCollection
		///</summary>
		[ChildEntityType(typeof(TList<KcqKhoiLuongKhac>))]
		KcqKhoiLuongKhacCollection,
		///<summary>
		/// Collection of <c>GiangVien</c> as OneToMany for ThuLaoThoaThuanCollection
		///</summary>
		[ChildEntityType(typeof(TList<ThuLaoThoaThuan>))]
		ThuLaoThoaThuanCollection,
		///<summary>
		/// Collection of <c>GiangVien</c> as OneToMany for GiangVienCamKetKhongTruThueCollection
		///</summary>
		[ChildEntityType(typeof(TList<GiangVienCamKetKhongTruThue>))]
		GiangVienCamKetKhongTruThueCollection,
		///<summary>
		/// Collection of <c>GiangVien</c> as OneToMany for ThamDinhLuanVanThacSyCollection
		///</summary>
		[ChildEntityType(typeof(TList<ThamDinhLuanVanThacSy>))]
		ThamDinhLuanVanThacSyCollection,
		///<summary>
		/// Collection of <c>GiangVien</c> as OneToMany for GiangVienHoSoCollection
		///</summary>
		[ChildEntityType(typeof(TList<GiangVienHoSo>))]
		GiangVienHoSoCollection,
		///<summary>
		/// Collection of <c>GiangVien</c> as OneToMany for ThoiGianLamViecCuaNhanVienCollection
		///</summary>
		[ChildEntityType(typeof(TList<ThoiGianLamViecCuaNhanVien>))]
		ThoiGianLamViecCuaNhanVienCollection,
		///<summary>
		/// Collection of <c>GiangVien</c> as OneToMany for GiangVienHoatDongQuanLyCollection
		///</summary>
		[ChildEntityType(typeof(TList<GiangVienHoatDongQuanLy>))]
		GiangVienHoatDongQuanLyCollection,
		///<summary>
		/// Collection of <c>GiangVien</c> as OneToMany for KhoiLuongKhacCollection
		///</summary>
		[ChildEntityType(typeof(TList<KhoiLuongKhac>))]
		KhoiLuongKhacCollection,
		///<summary>
		/// Collection of <c>GiangVien</c> as OneToMany for CoVanHocTapCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoVanHocTap>))]
		CoVanHocTapCollection,
		///<summary>
		/// Collection of <c>GiangVien</c> as OneToMany for GiangVienNghienCuuKhCollection
		///</summary>
		[ChildEntityType(typeof(TList<GiangVienNghienCuuKh>))]
		GiangVienNghienCuuKhCollection,
		///<summary>
		/// Collection of <c>GiangVien</c> as OneToMany for GiangVienChucVuCollection
		///</summary>
		[ChildEntityType(typeof(TList<GiangVienChucVu>))]
		GiangVienChucVuCollection,
		///<summary>
		/// Collection of <c>GiangVien</c> as OneToMany for XetDuyetDeCuongLuanVanCaoHocCollection
		///</summary>
		[ChildEntityType(typeof(TList<XetDuyetDeCuongLuanVanCaoHoc>))]
		XetDuyetDeCuongLuanVanCaoHocCollection,
		///<summary>
		/// Collection of <c>GiangVien</c> as OneToMany for KetQuaTinhCollection
		///</summary>
		[ChildEntityType(typeof(TList<KetQuaTinh>))]
		KetQuaTinhCollection,
		///<summary>
		/// Collection of <c>GiangVien</c> as OneToMany for ThoiGianNghiTamThoiCuaGiangVienCollection
		///</summary>
		[ChildEntityType(typeof(TList<ThoiGianNghiTamThoiCuaGiangVien>))]
		ThoiGianNghiTamThoiCuaGiangVienCollection,
		///<summary>
		/// Collection of <c>GiangVien</c> as OneToMany for GiangVienTinhLuongThinhGiangCollection
		///</summary>
		[ChildEntityType(typeof(TList<GiangVienTinhLuongThinhGiang>))]
		GiangVienTinhLuongThinhGiangCollection,
		///<summary>
		/// Collection of <c>GiangVien</c> as OneToMany for GiangVienChuyenMonCollection
		///</summary>
		[ChildEntityType(typeof(TList<GiangVienChuyenMon>))]
		GiangVienChuyenMonCollection,
		///<summary>
		/// Collection of <c>GiangVien</c> as OneToMany for BangPhuTroiNamHocCollection
		///</summary>
		[ChildEntityType(typeof(TList<BangPhuTroiNamHoc>))]
		BangPhuTroiNamHocCollection,
		///<summary>
		/// Collection of <c>GiangVien</c> as OneToMany for TietNghiaVuCollection
		///</summary>
		[ChildEntityType(typeof(TList<TietNghiaVu>))]
		TietNghiaVuCollection,
		///<summary>
		/// Collection of <c>GiangVien</c> as OneToMany for GiangVienMocTangLuongCollection
		///</summary>
		[ChildEntityType(typeof(TList<GiangVienMocTangLuong>))]
		GiangVienMocTangLuongCollection,
		///<summary>
		/// Collection of <c>GiangVien</c> as OneToMany for GiangVienGiamTruDinhMucCollection
		///</summary>
		[ChildEntityType(typeof(TList<GiangVienGiamTruDinhMuc>))]
		GiangVienGiamTruDinhMucCollection,
		///<summary>
		/// Collection of <c>GiangVien</c> as ManyToMany for HoSoCollection_From_GiangVienHoSo
		///</summary>
		[ChildEntityType(typeof(TList<HoSo>))]
		MaHoSoHoSoCollection_From_GiangVienHoSo,
		///<summary>
		/// Collection of <c>GiangVien</c> as OneToMany for GiangVienHoatDongNgoaiGiangDayCollection
		///</summary>
		[ChildEntityType(typeof(TList<GiangVienHoatDongNgoaiGiangDay>))]
		GiangVienHoatDongNgoaiGiangDayCollection,
	}
	
	#endregion GiangVienChildEntityTypes
	
	#region GiangVienFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GiangVienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienFilterBuilder : SqlFilterBuilder<GiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienFilterBuilder class.
		/// </summary>
		public GiangVienFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienFilterBuilder
	
	#region GiangVienParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GiangVienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienParameterBuilder : ParameterizedSqlFilterBuilder<GiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienParameterBuilder class.
		/// </summary>
		public GiangVienParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienParameterBuilder
	
	#region GiangVienSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GiangVienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVien"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GiangVienSortBuilder : SqlSortBuilder<GiangVienColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienSqlSortBuilder class.
		/// </summary>
		public GiangVienSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GiangVienSortBuilder
	
} // end namespace
