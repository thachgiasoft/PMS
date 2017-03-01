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
	/// This class is the base class for any <see cref="TietNghiaVuProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class TietNghiaVuProviderBaseCore : EntityProviderBase<PMS.Entities.TietNghiaVu, PMS.Entities.TietNghiaVuKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.TietNghiaVuKey key)
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
		/// 	Gets rows from the datasource based on the FK_TietNghiaVu_GiamTruDinhMuc key.
		///		FK_TietNghiaVu_GiamTruDinhMuc Description: 
		/// </summary>
		/// <param name="_maGiamTruKhac"></param>
		/// <returns>Returns a typed collection of PMS.Entities.TietNghiaVu objects.</returns>
		public TList<TietNghiaVu> GetByMaGiamTruKhac(System.Int32? _maGiamTruKhac)
		{
			int count = -1;
			return GetByMaGiamTruKhac(_maGiamTruKhac, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TietNghiaVu_GiamTruDinhMuc key.
		///		FK_TietNghiaVu_GiamTruDinhMuc Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiamTruKhac"></param>
		/// <returns>Returns a typed collection of PMS.Entities.TietNghiaVu objects.</returns>
		/// <remarks></remarks>
		public TList<TietNghiaVu> GetByMaGiamTruKhac(TransactionManager transactionManager, System.Int32? _maGiamTruKhac)
		{
			int count = -1;
			return GetByMaGiamTruKhac(transactionManager, _maGiamTruKhac, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_TietNghiaVu_GiamTruDinhMuc key.
		///		FK_TietNghiaVu_GiamTruDinhMuc Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiamTruKhac"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.TietNghiaVu objects.</returns>
		public TList<TietNghiaVu> GetByMaGiamTruKhac(TransactionManager transactionManager, System.Int32? _maGiamTruKhac, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiamTruKhac(transactionManager, _maGiamTruKhac, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TietNghiaVu_GiamTruDinhMuc key.
		///		fkTietNghiaVuGiamTruDinhMuc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiamTruKhac"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.TietNghiaVu objects.</returns>
		public TList<TietNghiaVu> GetByMaGiamTruKhac(System.Int32? _maGiamTruKhac, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaGiamTruKhac(null, _maGiamTruKhac, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TietNghiaVu_GiamTruDinhMuc key.
		///		fkTietNghiaVuGiamTruDinhMuc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiamTruKhac"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.TietNghiaVu objects.</returns>
		public TList<TietNghiaVu> GetByMaGiamTruKhac(System.Int32? _maGiamTruKhac, int start, int pageLength,out int count)
		{
			return GetByMaGiamTruKhac(null, _maGiamTruKhac, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TietNghiaVu_GiamTruDinhMuc key.
		///		FK_TietNghiaVu_GiamTruDinhMuc Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiamTruKhac"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.TietNghiaVu objects.</returns>
		public abstract TList<TietNghiaVu> GetByMaGiamTruKhac(TransactionManager transactionManager, System.Int32? _maGiamTruKhac, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TietNghiaVu_GiangVien key.
		///		FK_TietNghiaVu_GiangVien Description: 
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.TietNghiaVu objects.</returns>
		public TList<TietNghiaVu> GetByMaGiangVien(System.Int32? _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(_maGiangVien, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TietNghiaVu_GiangVien key.
		///		FK_TietNghiaVu_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.TietNghiaVu objects.</returns>
		/// <remarks></remarks>
		public TList<TietNghiaVu> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_TietNghiaVu_GiangVien key.
		///		FK_TietNghiaVu_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.TietNghiaVu objects.</returns>
		public TList<TietNghiaVu> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TietNghiaVu_GiangVien key.
		///		fkTietNghiaVuGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.TietNghiaVu objects.</returns>
		public TList<TietNghiaVu> GetByMaGiangVien(System.Int32? _maGiangVien, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TietNghiaVu_GiangVien key.
		///		fkTietNghiaVuGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.TietNghiaVu objects.</returns>
		public TList<TietNghiaVu> GetByMaGiangVien(System.Int32? _maGiangVien, int start, int pageLength,out int count)
		{
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TietNghiaVu_GiangVien key.
		///		FK_TietNghiaVu_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.TietNghiaVu objects.</returns>
		public abstract TList<TietNghiaVu> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.TietNghiaVu Get(TransactionManager transactionManager, PMS.Entities.TietNghiaVuKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_TietNghiaVu index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TietNghiaVu"/> class.</returns>
		public PMS.Entities.TietNghiaVu GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TietNghiaVu index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TietNghiaVu"/> class.</returns>
		public PMS.Entities.TietNghiaVu GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TietNghiaVu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TietNghiaVu"/> class.</returns>
		public PMS.Entities.TietNghiaVu GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TietNghiaVu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TietNghiaVu"/> class.</returns>
		public PMS.Entities.TietNghiaVu GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TietNghiaVu index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TietNghiaVu"/> class.</returns>
		public PMS.Entities.TietNghiaVu GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TietNghiaVu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TietNghiaVu"/> class.</returns>
		public abstract PMS.Entities.TietNghiaVu GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_TietNghiaVu_LuuUel 
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_LuuUel' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuUel(System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 LuuUel(null, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_LuuUel' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuUel(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 LuuUel(null, start, pageLength , xmlData, namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_LuuUel' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuUel(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 LuuUel(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_LuuUel' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LuuUel(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_TietNghiaVu_Luu2 
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_Luu2' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu2(System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Luu2(null, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_Luu2' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu2(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Luu2(null, start, pageLength , xmlData, namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_Luu2' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu2(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Luu2(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_Luu2' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu2(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_TietNghiaVu_Luu3 
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_Luu3' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu3(System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Luu3(null, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_Luu3' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu3(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Luu3(null, start, pageLength , xmlData, namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_Luu3' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu3(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Luu3(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_Luu3' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu3(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_TietNghiaVu_GetByMaGiangVienNamHoc 
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_GetByMaGiangVienNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="tietNghiaVu"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaGiangVienNamHoc(System.Int32 maGiangVien, System.String namHoc, ref System.Int32 tietNghiaVu)
		{
			 GetByMaGiangVienNamHoc(null, 0, int.MaxValue , maGiangVien, namHoc, ref tietNghiaVu);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_GetByMaGiangVienNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="tietNghiaVu"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaGiangVienNamHoc(int start, int pageLength, System.Int32 maGiangVien, System.String namHoc, ref System.Int32 tietNghiaVu)
		{
			 GetByMaGiangVienNamHoc(null, start, pageLength , maGiangVien, namHoc, ref tietNghiaVu);
		}
				
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_GetByMaGiangVienNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="tietNghiaVu"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaGiangVienNamHoc(TransactionManager transactionManager, System.Int32 maGiangVien, System.String namHoc, ref System.Int32 tietNghiaVu)
		{
			 GetByMaGiangVienNamHoc(transactionManager, 0, int.MaxValue , maGiangVien, namHoc, ref tietNghiaVu);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_GetByMaGiangVienNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="tietNghiaVu"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetByMaGiangVienNamHoc(TransactionManager transactionManager, int start, int pageLength , System.Int32 maGiangVien, System.String namHoc, ref System.Int32 tietNghiaVu);
		
		#endregion
		
		#region cust_TietNghiaVu_SaoChepTheoNam 
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_SaoChepTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHocNguon"> A <c>System.String</c> instance.</param>
		/// <param name="namHocDich"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void SaoChepTheoNam(System.String namHocNguon, System.String namHocDich)
		{
			 SaoChepTheoNam(null, 0, int.MaxValue , namHocNguon, namHocDich);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_SaoChepTheoNam' stored procedure. 
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
		///	This method wrap the 'cust_TietNghiaVu_SaoChepTheoNam' stored procedure. 
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
		///	This method wrap the 'cust_TietNghiaVu_SaoChepTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHocNguon"> A <c>System.String</c> instance.</param>
		/// <param name="namHocDich"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void SaoChepTheoNam(TransactionManager transactionManager, int start, int pageLength , System.String namHocNguon, System.String namHocDich);
		
		#endregion
		
		#region cust_TietNghiaVu_LuuTietNghiaVuUte 
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_LuuTietNghiaVuUte' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuTietNghiaVuUte(System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 LuuTietNghiaVuUte(null, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_LuuTietNghiaVuUte' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuTietNghiaVuUte(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 LuuTietNghiaVuUte(null, start, pageLength , xmlData, namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_LuuTietNghiaVuUte' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuTietNghiaVuUte(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 LuuTietNghiaVuUte(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_LuuTietNghiaVuUte' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LuuTietNghiaVuUte(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_TietNghiaVu_KiemTra 
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_KiemTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTra(System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 KiemTra(null, 0, int.MaxValue , namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_KiemTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTra(int start, int pageLength, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 KiemTra(null, start, pageLength , namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_KiemTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTra(TransactionManager transactionManager, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 KiemTra(transactionManager, 0, int.MaxValue , namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_KiemTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void KiemTra(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_TietNghiaVu_GetTietNghiaVuUte 
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_GetTietNghiaVuUte' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetTietNghiaVuUte(System.String namHoc, System.String hocKy)
		{
			return GetTietNghiaVuUte(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_GetTietNghiaVuUte' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetTietNghiaVuUte(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetTietNghiaVuUte(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_GetTietNghiaVuUte' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetTietNghiaVuUte(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetTietNghiaVuUte(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_GetTietNghiaVuUte' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetTietNghiaVuUte(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_TietNghiaVu_LuuTheoNam 
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_LuuTheoNam' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuTheoNam(System.String xmlData, System.String namHoc, ref System.Int32 reVal)
		{
			 LuuTheoNam(null, 0, int.MaxValue , xmlData, namHoc, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_LuuTheoNam' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuTheoNam(int start, int pageLength, System.String xmlData, System.String namHoc, ref System.Int32 reVal)
		{
			 LuuTheoNam(null, start, pageLength , xmlData, namHoc, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_LuuTheoNam' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuTheoNam(TransactionManager transactionManager, System.String xmlData, System.String namHoc, ref System.Int32 reVal)
		{
			 LuuTheoNam(transactionManager, 0, int.MaxValue , xmlData, namHoc, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_LuuTheoNam' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LuuTheoNam(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_TietNghiaVu_UteChiTiet 
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_UteChiTiet' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader UteChiTiet(System.String namHoc, System.String hocKy)
		{
			return UteChiTiet(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_UteChiTiet' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader UteChiTiet(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return UteChiTiet(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_UteChiTiet' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader UteChiTiet(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return UteChiTiet(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_UteChiTiet' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader UteChiTiet(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_TietNghiaVu_HuyChot 
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_HuyChot' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChot(System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 HuyChot(null, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_HuyChot' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChot(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 HuyChot(null, start, pageLength , xmlData, namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_HuyChot' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChot(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 HuyChot(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_HuyChot' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void HuyChot(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_TietNghiaVu_GetTietNghiaVuBuh 
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_GetTietNghiaVuBuh' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetTietNghiaVuBuh(System.String namHoc, System.String hocKy)
		{
			return GetTietNghiaVuBuh(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_GetTietNghiaVuBuh' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetTietNghiaVuBuh(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetTietNghiaVuBuh(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_GetTietNghiaVuBuh' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetTietNghiaVuBuh(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetTietNghiaVuBuh(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_GetTietNghiaVuBuh' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetTietNghiaVuBuh(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_TietNghiaVu_LuuTietNghiaVu 
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_LuuTietNghiaVu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuTietNghiaVu(System.String xmlData, System.String namHoc, ref System.Int32 reVal)
		{
			 LuuTietNghiaVu(null, 0, int.MaxValue , xmlData, namHoc, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_LuuTietNghiaVu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuTietNghiaVu(int start, int pageLength, System.String xmlData, System.String namHoc, ref System.Int32 reVal)
		{
			 LuuTietNghiaVu(null, start, pageLength , xmlData, namHoc, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_LuuTietNghiaVu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuTietNghiaVu(TransactionManager transactionManager, System.String xmlData, System.String namHoc, ref System.Int32 reVal)
		{
			 LuuTietNghiaVu(transactionManager, 0, int.MaxValue , xmlData, namHoc, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_LuuTietNghiaVu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LuuTietNghiaVu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_TietNghiaVu_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_Luu' stored procedure. 
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
		///	This method wrap the 'cust_TietNghiaVu_Luu' stored procedure. 
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
		///	This method wrap the 'cust_TietNghiaVu_Luu' stored procedure. 
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
		///	This method wrap the 'cust_TietNghiaVu_Luu' stored procedure. 
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
		
		#region cust_TietNghiaVu_GetGiangVienGiamTru 
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_GetGiangVienGiamTru' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetGiangVienGiamTru(System.String namHoc)
		{
			return GetGiangVienGiamTru(null, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_GetGiangVienGiamTru' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetGiangVienGiamTru(int start, int pageLength, System.String namHoc)
		{
			return GetGiangVienGiamTru(null, start, pageLength , namHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_GetGiangVienGiamTru' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetGiangVienGiamTru(TransactionManager transactionManager, System.String namHoc)
		{
			return GetGiangVienGiamTru(transactionManager, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_GetGiangVienGiamTru' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetGiangVienGiamTru(TransactionManager transactionManager, int start, int pageLength , System.String namHoc);
		
		#endregion
		
		#region cust_TietNghiaVu_Chot 
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_Chot' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Chot(System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Chot(null, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_Chot' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Chot(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Chot(null, start, pageLength , xmlData, namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_Chot' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Chot(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Chot(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_Chot' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Chot(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_TietNghiaVu_Import 
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Import(System.String xmlData, ref System.Int32 reVal)
		{
			 Import(null, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_Import' stored procedure. 
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
		///	This method wrap the 'cust_TietNghiaVu_Import' stored procedure. 
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
		///	This method wrap the 'cust_TietNghiaVu_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Import(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_TietNghiaVu_LuuBuh 
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_LuuBuh' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuBuh(System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 LuuBuh(null, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_LuuBuh' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuBuh(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 LuuBuh(null, start, pageLength , xmlData, namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_LuuBuh' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuBuh(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 LuuBuh(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_LuuBuh' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LuuBuh(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_TietNghiaVu_GetTietNghiaVuCuaGiangVienCoChucVu 
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_GetTietNghiaVuCuaGiangVienCoChucVu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetTietNghiaVuCuaGiangVienCoChucVu(System.String namHoc)
		{
			return GetTietNghiaVuCuaGiangVienCoChucVu(null, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_GetTietNghiaVuCuaGiangVienCoChucVu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetTietNghiaVuCuaGiangVienCoChucVu(int start, int pageLength, System.String namHoc)
		{
			return GetTietNghiaVuCuaGiangVienCoChucVu(null, start, pageLength , namHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_GetTietNghiaVuCuaGiangVienCoChucVu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetTietNghiaVuCuaGiangVienCoChucVu(TransactionManager transactionManager, System.String namHoc)
		{
			return GetTietNghiaVuCuaGiangVienCoChucVu(transactionManager, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_GetTietNghiaVuCuaGiangVienCoChucVu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetTietNghiaVuCuaGiangVienCoChucVu(TransactionManager transactionManager, int start, int pageLength , System.String namHoc);
		
		#endregion
		
		#region cust_TietNghiaVu_SaoChep 
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_TietNghiaVu_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_TietNghiaVu_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_TietNghiaVu_SaoChep' stored procedure. 
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
		
		#region cust_TietNghiaVu_GetByNamHoc 
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHoc(System.String namHoc)
		{
			return GetByNamHoc(null, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHoc(int start, int pageLength, System.String namHoc)
		{
			return GetByNamHoc(null, start, pageLength , namHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHoc(TransactionManager transactionManager, System.String namHoc)
		{
			return GetByNamHoc(transactionManager, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHoc(TransactionManager transactionManager, int start, int pageLength , System.String namHoc);
		
		#endregion
		
		#region cust_TietNghiaVu_XoaTietNghiaVuTheoMaGiangVienNamHoc 
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_XoaTietNghiaVuTheoMaGiangVienNamHoc' stored procedure. 
		/// </summary>
		/// <param name="listMaGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void XoaTietNghiaVuTheoMaGiangVienNamHoc(System.String listMaGiangVien, System.String namHoc, ref System.Int32 reVal)
		{
			 XoaTietNghiaVuTheoMaGiangVienNamHoc(null, 0, int.MaxValue , listMaGiangVien, namHoc, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_XoaTietNghiaVuTheoMaGiangVienNamHoc' stored procedure. 
		/// </summary>
		/// <param name="listMaGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void XoaTietNghiaVuTheoMaGiangVienNamHoc(int start, int pageLength, System.String listMaGiangVien, System.String namHoc, ref System.Int32 reVal)
		{
			 XoaTietNghiaVuTheoMaGiangVienNamHoc(null, start, pageLength , listMaGiangVien, namHoc, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_XoaTietNghiaVuTheoMaGiangVienNamHoc' stored procedure. 
		/// </summary>
		/// <param name="listMaGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void XoaTietNghiaVuTheoMaGiangVienNamHoc(TransactionManager transactionManager, System.String listMaGiangVien, System.String namHoc, ref System.Int32 reVal)
		{
			 XoaTietNghiaVuTheoMaGiangVienNamHoc(transactionManager, 0, int.MaxValue , listMaGiangVien, namHoc, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TietNghiaVu_XoaTietNghiaVuTheoMaGiangVienNamHoc' stored procedure. 
		/// </summary>
		/// <param name="listMaGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void XoaTietNghiaVuTheoMaGiangVienNamHoc(TransactionManager transactionManager, int start, int pageLength , System.String listMaGiangVien, System.String namHoc, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;TietNghiaVu&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;TietNghiaVu&gt;"/></returns>
		public static TList<TietNghiaVu> Fill(IDataReader reader, TList<TietNghiaVu> rows, int start, int pageLength)
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
				
				PMS.Entities.TietNghiaVu c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("TietNghiaVu")
					.Append("|").Append((System.Int32)reader[((int)TietNghiaVuColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<TietNghiaVu>(
					key.ToString(), // EntityTrackingKey
					"TietNghiaVu",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.TietNghiaVu();
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
					c.Id = (System.Int32)reader[(TietNghiaVuColumn.Id.ToString())];
					c.MaGiangVien = (reader[TietNghiaVuColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(TietNghiaVuColumn.MaGiangVien.ToString())];
					c.NamHoc = (reader[TietNghiaVuColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(TietNghiaVuColumn.NamHoc.ToString())];
					c.HocKy = (reader[TietNghiaVuColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(TietNghiaVuColumn.HocKy.ToString())];
					c.MaHocHam = (reader[TietNghiaVuColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(TietNghiaVuColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[TietNghiaVuColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(TietNghiaVuColumn.MaHocVi.ToString())];
					c.SoTietNghiaVu = (reader[TietNghiaVuColumn.SoTietNghiaVu.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TietNghiaVuColumn.SoTietNghiaVu.ToString())];
					c.GhiChu = (reader[TietNghiaVuColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(TietNghiaVuColumn.GhiChu.ToString())];
					c.NgayCapNhat = (reader[TietNghiaVuColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(TietNghiaVuColumn.NgayCapNhat.ToString())];
					c.TietGioiHan = (reader[TietNghiaVuColumn.TietGioiHan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TietNghiaVuColumn.TietGioiHan.ToString())];
					c.GhiChu2 = (reader[TietNghiaVuColumn.GhiChu2.ToString()] == DBNull.Value) ? null : (System.String)reader[(TietNghiaVuColumn.GhiChu2.ToString())];
					c.NguoiCapNhat = (reader[TietNghiaVuColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(TietNghiaVuColumn.NguoiCapNhat.ToString())];
					c.MaGiamTruKhac = (reader[TietNghiaVuColumn.MaGiamTruKhac.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(TietNghiaVuColumn.MaGiamTruKhac.ToString())];
					c.SoTietGiamTruKhac = (reader[TietNghiaVuColumn.SoTietGiamTruKhac.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TietNghiaVuColumn.SoTietGiamTruKhac.ToString())];
					c.TietNghiaVuCongTacKhac = (reader[TietNghiaVuColumn.TietNghiaVuCongTacKhac.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TietNghiaVuColumn.TietNghiaVuCongTacKhac.ToString())];
					c.TietNghiaVuCongTacKhacSauGiamTru = (reader[TietNghiaVuColumn.TietNghiaVuCongTacKhacSauGiamTru.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TietNghiaVuColumn.TietNghiaVuCongTacKhacSauGiamTru.ToString())];
					c.Chot = (reader[TietNghiaVuColumn.Chot.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(TietNghiaVuColumn.Chot.ToString())];
					c.TietNghiaVuGiangDay = (reader[TietNghiaVuColumn.TietNghiaVuGiangDay.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TietNghiaVuColumn.TietNghiaVuGiangDay.ToString())];
					c.TietNghiaVuNckh = (reader[TietNghiaVuColumn.TietNghiaVuNckh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TietNghiaVuColumn.TietNghiaVuNckh.ToString())];
					c.GioChuanGiangDayChuyenSangNckh = (reader[TietNghiaVuColumn.GioChuanGiangDayChuyenSangNckh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TietNghiaVuColumn.GioChuanGiangDayChuyenSangNckh.ToString())];
					c.TietGiamKhacGiangDay = (reader[TietNghiaVuColumn.TietGiamKhacGiangDay.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TietNghiaVuColumn.TietGiamKhacGiangDay.ToString())];
					c.TietGiamKhacNckh = (reader[TietNghiaVuColumn.TietGiamKhacNckh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TietNghiaVuColumn.TietGiamKhacNckh.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.TietNghiaVu"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.TietNghiaVu"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.TietNghiaVu entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(TietNghiaVuColumn.Id.ToString())];
			entity.MaGiangVien = (reader[TietNghiaVuColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(TietNghiaVuColumn.MaGiangVien.ToString())];
			entity.NamHoc = (reader[TietNghiaVuColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(TietNghiaVuColumn.NamHoc.ToString())];
			entity.HocKy = (reader[TietNghiaVuColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(TietNghiaVuColumn.HocKy.ToString())];
			entity.MaHocHam = (reader[TietNghiaVuColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(TietNghiaVuColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[TietNghiaVuColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(TietNghiaVuColumn.MaHocVi.ToString())];
			entity.SoTietNghiaVu = (reader[TietNghiaVuColumn.SoTietNghiaVu.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TietNghiaVuColumn.SoTietNghiaVu.ToString())];
			entity.GhiChu = (reader[TietNghiaVuColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(TietNghiaVuColumn.GhiChu.ToString())];
			entity.NgayCapNhat = (reader[TietNghiaVuColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(TietNghiaVuColumn.NgayCapNhat.ToString())];
			entity.TietGioiHan = (reader[TietNghiaVuColumn.TietGioiHan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TietNghiaVuColumn.TietGioiHan.ToString())];
			entity.GhiChu2 = (reader[TietNghiaVuColumn.GhiChu2.ToString()] == DBNull.Value) ? null : (System.String)reader[(TietNghiaVuColumn.GhiChu2.ToString())];
			entity.NguoiCapNhat = (reader[TietNghiaVuColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(TietNghiaVuColumn.NguoiCapNhat.ToString())];
			entity.MaGiamTruKhac = (reader[TietNghiaVuColumn.MaGiamTruKhac.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(TietNghiaVuColumn.MaGiamTruKhac.ToString())];
			entity.SoTietGiamTruKhac = (reader[TietNghiaVuColumn.SoTietGiamTruKhac.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TietNghiaVuColumn.SoTietGiamTruKhac.ToString())];
			entity.TietNghiaVuCongTacKhac = (reader[TietNghiaVuColumn.TietNghiaVuCongTacKhac.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TietNghiaVuColumn.TietNghiaVuCongTacKhac.ToString())];
			entity.TietNghiaVuCongTacKhacSauGiamTru = (reader[TietNghiaVuColumn.TietNghiaVuCongTacKhacSauGiamTru.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TietNghiaVuColumn.TietNghiaVuCongTacKhacSauGiamTru.ToString())];
			entity.Chot = (reader[TietNghiaVuColumn.Chot.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(TietNghiaVuColumn.Chot.ToString())];
			entity.TietNghiaVuGiangDay = (reader[TietNghiaVuColumn.TietNghiaVuGiangDay.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TietNghiaVuColumn.TietNghiaVuGiangDay.ToString())];
			entity.TietNghiaVuNckh = (reader[TietNghiaVuColumn.TietNghiaVuNckh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TietNghiaVuColumn.TietNghiaVuNckh.ToString())];
			entity.GioChuanGiangDayChuyenSangNckh = (reader[TietNghiaVuColumn.GioChuanGiangDayChuyenSangNckh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TietNghiaVuColumn.GioChuanGiangDayChuyenSangNckh.ToString())];
			entity.TietGiamKhacGiangDay = (reader[TietNghiaVuColumn.TietGiamKhacGiangDay.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TietNghiaVuColumn.TietGiamKhacGiangDay.ToString())];
			entity.TietGiamKhacNckh = (reader[TietNghiaVuColumn.TietGiamKhacNckh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TietNghiaVuColumn.TietGiamKhacNckh.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.TietNghiaVu"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.TietNghiaVu"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.TietNghiaVu entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.Int32?)dataRow["MaGiangVien"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
			entity.SoTietNghiaVu = Convert.IsDBNull(dataRow["SoTietNghiaVu"]) ? null : (System.Decimal?)dataRow["SoTietNghiaVu"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.Boolean?)dataRow["GhiChu"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
			entity.TietGioiHan = Convert.IsDBNull(dataRow["TietGioiHan"]) ? null : (System.Decimal?)dataRow["TietGioiHan"];
			entity.GhiChu2 = Convert.IsDBNull(dataRow["GhiChu2"]) ? null : (System.String)dataRow["GhiChu2"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.MaGiamTruKhac = Convert.IsDBNull(dataRow["MaGiamTruKhac"]) ? null : (System.Int32?)dataRow["MaGiamTruKhac"];
			entity.SoTietGiamTruKhac = Convert.IsDBNull(dataRow["SoTietGiamTruKhac"]) ? null : (System.Decimal?)dataRow["SoTietGiamTruKhac"];
			entity.TietNghiaVuCongTacKhac = Convert.IsDBNull(dataRow["TietNghiaVuCongTacKhac"]) ? null : (System.Decimal?)dataRow["TietNghiaVuCongTacKhac"];
			entity.TietNghiaVuCongTacKhacSauGiamTru = Convert.IsDBNull(dataRow["TietNghiaVuCongTacKhacSauGiamTru"]) ? null : (System.Decimal?)dataRow["TietNghiaVuCongTacKhacSauGiamTru"];
			entity.Chot = Convert.IsDBNull(dataRow["Chot"]) ? null : (System.Boolean?)dataRow["Chot"];
			entity.TietNghiaVuGiangDay = Convert.IsDBNull(dataRow["TietNghiaVuGiangDay"]) ? null : (System.Decimal?)dataRow["TietNghiaVuGiangDay"];
			entity.TietNghiaVuNckh = Convert.IsDBNull(dataRow["TietNghiaVuNckh"]) ? null : (System.Decimal?)dataRow["TietNghiaVuNckh"];
			entity.GioChuanGiangDayChuyenSangNckh = Convert.IsDBNull(dataRow["GioChuanGiangDayChuyenSangNckh"]) ? null : (System.Decimal?)dataRow["GioChuanGiangDayChuyenSangNckh"];
			entity.TietGiamKhacGiangDay = Convert.IsDBNull(dataRow["TietGiamKhacGiangDay"]) ? null : (System.Decimal?)dataRow["TietGiamKhacGiangDay"];
			entity.TietGiamKhacNckh = Convert.IsDBNull(dataRow["TietGiamKhacNckh"]) ? null : (System.Decimal?)dataRow["TietGiamKhacNckh"];
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
		/// <param name="entity">The <see cref="PMS.Entities.TietNghiaVu"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.TietNghiaVu Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.TietNghiaVu entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaGiamTruKhacSource	
			if (CanDeepLoad(entity, "GiamTruDinhMuc|MaGiamTruKhacSource", deepLoadType, innerList) 
				&& entity.MaGiamTruKhacSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaGiamTruKhac ?? (int)0);
				GiamTruDinhMuc tmpEntity = EntityManager.LocateEntity<GiamTruDinhMuc>(EntityLocator.ConstructKeyFromPkItems(typeof(GiamTruDinhMuc), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaGiamTruKhacSource = tmpEntity;
				else
					entity.MaGiamTruKhacSource = DataRepository.GiamTruDinhMucProvider.GetByMaQuanLy(transactionManager, (entity.MaGiamTruKhac ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaGiamTruKhacSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaGiamTruKhacSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GiamTruDinhMucProvider.DeepLoad(transactionManager, entity.MaGiamTruKhacSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaGiamTruKhacSource

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
		/// Deep Save the entire object graph of the PMS.Entities.TietNghiaVu object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.TietNghiaVu instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.TietNghiaVu Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.TietNghiaVu entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaGiamTruKhacSource
			if (CanDeepSave(entity, "GiamTruDinhMuc|MaGiamTruKhacSource", deepSaveType, innerList) 
				&& entity.MaGiamTruKhacSource != null)
			{
				DataRepository.GiamTruDinhMucProvider.Save(transactionManager, entity.MaGiamTruKhacSource);
				entity.MaGiamTruKhac = entity.MaGiamTruKhacSource.MaQuanLy;
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
	
	#region TietNghiaVuChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.TietNghiaVu</c>
	///</summary>
	public enum TietNghiaVuChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GiamTruDinhMuc</c> at MaGiamTruKhacSource
		///</summary>
		[ChildEntityType(typeof(GiamTruDinhMuc))]
		GiamTruDinhMuc,
		
		///<summary>
		/// Composite Property for <c>GiangVien</c> at MaGiangVienSource
		///</summary>
		[ChildEntityType(typeof(GiangVien))]
		GiangVien,
	}
	
	#endregion TietNghiaVuChildEntityTypes
	
	#region TietNghiaVuFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;TietNghiaVuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TietNghiaVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TietNghiaVuFilterBuilder : SqlFilterBuilder<TietNghiaVuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TietNghiaVuFilterBuilder class.
		/// </summary>
		public TietNghiaVuFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TietNghiaVuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TietNghiaVuFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TietNghiaVuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TietNghiaVuFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TietNghiaVuFilterBuilder
	
	#region TietNghiaVuParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;TietNghiaVuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TietNghiaVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TietNghiaVuParameterBuilder : ParameterizedSqlFilterBuilder<TietNghiaVuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TietNghiaVuParameterBuilder class.
		/// </summary>
		public TietNghiaVuParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TietNghiaVuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TietNghiaVuParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TietNghiaVuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TietNghiaVuParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TietNghiaVuParameterBuilder
	
	#region TietNghiaVuSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;TietNghiaVuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TietNghiaVu"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class TietNghiaVuSortBuilder : SqlSortBuilder<TietNghiaVuColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TietNghiaVuSqlSortBuilder class.
		/// </summary>
		public TietNghiaVuSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion TietNghiaVuSortBuilder
	
} // end namespace
