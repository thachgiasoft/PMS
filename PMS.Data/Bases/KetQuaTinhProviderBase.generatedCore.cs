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
	/// This class is the base class for any <see cref="KetQuaTinhProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KetQuaTinhProviderBaseCore : EntityProviderBase<PMS.Entities.KetQuaTinh, PMS.Entities.KetQuaTinhKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KetQuaTinhKey key)
		{
			return Delete(transactionManager, key.MaKetQua);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maKetQua">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maKetQua)
		{
			return Delete(null, _maKetQua);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKetQua">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maKetQua);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KetQuaTinh_GiangVien key.
		///		FK_KetQuaTinh_GiangVien Description: 
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.KetQuaTinh objects.</returns>
		public TList<KetQuaTinh> GetByMaGiangVien(System.Int32? _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(_maGiangVien, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KetQuaTinh_GiangVien key.
		///		FK_KetQuaTinh_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.KetQuaTinh objects.</returns>
		/// <remarks></remarks>
		public TList<KetQuaTinh> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_KetQuaTinh_GiangVien key.
		///		FK_KetQuaTinh_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KetQuaTinh objects.</returns>
		public TList<KetQuaTinh> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KetQuaTinh_GiangVien key.
		///		fkKetQuaTinhGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KetQuaTinh objects.</returns>
		public TList<KetQuaTinh> GetByMaGiangVien(System.Int32? _maGiangVien, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KetQuaTinh_GiangVien key.
		///		fkKetQuaTinhGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KetQuaTinh objects.</returns>
		public TList<KetQuaTinh> GetByMaGiangVien(System.Int32? _maGiangVien, int start, int pageLength,out int count)
		{
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KetQuaTinh_GiangVien key.
		///		FK_KetQuaTinh_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.KetQuaTinh objects.</returns>
		public abstract TList<KetQuaTinh> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.KetQuaTinh Get(TransactionManager transactionManager, PMS.Entities.KetQuaTinhKey key, int start, int pageLength)
		{
			return GetByMaKetQua(transactionManager, key.MaKetQua, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_KetQuaTinh index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaTinh"/> class.</returns>
		public PMS.Entities.KetQuaTinh GetByMaGiangVienNamHocHocKy(System.Int32? _maGiangVien, System.String _namHoc, System.String _hocKy)
		{
			int count = -1;
			return GetByMaGiangVienNamHocHocKy(null,_maGiangVien, _namHoc, _hocKy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_KetQuaTinh index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaTinh"/> class.</returns>
		public PMS.Entities.KetQuaTinh GetByMaGiangVienNamHocHocKy(System.Int32? _maGiangVien, System.String _namHoc, System.String _hocKy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVienNamHocHocKy(null, _maGiangVien, _namHoc, _hocKy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_KetQuaTinh index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaTinh"/> class.</returns>
		public PMS.Entities.KetQuaTinh GetByMaGiangVienNamHocHocKy(TransactionManager transactionManager, System.Int32? _maGiangVien, System.String _namHoc, System.String _hocKy)
		{
			int count = -1;
			return GetByMaGiangVienNamHocHocKy(transactionManager, _maGiangVien, _namHoc, _hocKy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_KetQuaTinh index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaTinh"/> class.</returns>
		public PMS.Entities.KetQuaTinh GetByMaGiangVienNamHocHocKy(TransactionManager transactionManager, System.Int32? _maGiangVien, System.String _namHoc, System.String _hocKy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVienNamHocHocKy(transactionManager, _maGiangVien, _namHoc, _hocKy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_KetQuaTinh index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaTinh"/> class.</returns>
		public PMS.Entities.KetQuaTinh GetByMaGiangVienNamHocHocKy(System.Int32? _maGiangVien, System.String _namHoc, System.String _hocKy, int start, int pageLength, out int count)
		{
			return GetByMaGiangVienNamHocHocKy(null, _maGiangVien, _namHoc, _hocKy, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_KetQuaTinh index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaTinh"/> class.</returns>
		public abstract PMS.Entities.KetQuaTinh GetByMaGiangVienNamHocHocKy(TransactionManager transactionManager, System.Int32? _maGiangVien, System.String _namHoc, System.String _hocKy, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KetQuaTinh index.
		/// </summary>
		/// <param name="_maKetQua"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaTinh"/> class.</returns>
		public PMS.Entities.KetQuaTinh GetByMaKetQua(System.Int32 _maKetQua)
		{
			int count = -1;
			return GetByMaKetQua(null,_maKetQua, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KetQuaTinh index.
		/// </summary>
		/// <param name="_maKetQua"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaTinh"/> class.</returns>
		public PMS.Entities.KetQuaTinh GetByMaKetQua(System.Int32 _maKetQua, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKetQua(null, _maKetQua, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KetQuaTinh index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKetQua"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaTinh"/> class.</returns>
		public PMS.Entities.KetQuaTinh GetByMaKetQua(TransactionManager transactionManager, System.Int32 _maKetQua)
		{
			int count = -1;
			return GetByMaKetQua(transactionManager, _maKetQua, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KetQuaTinh index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKetQua"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaTinh"/> class.</returns>
		public PMS.Entities.KetQuaTinh GetByMaKetQua(TransactionManager transactionManager, System.Int32 _maKetQua, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKetQua(transactionManager, _maKetQua, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KetQuaTinh index.
		/// </summary>
		/// <param name="_maKetQua"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaTinh"/> class.</returns>
		public PMS.Entities.KetQuaTinh GetByMaKetQua(System.Int32 _maKetQua, int start, int pageLength, out int count)
		{
			return GetByMaKetQua(null, _maKetQua, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KetQuaTinh index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKetQua"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaTinh"/> class.</returns>
		public abstract PMS.Entities.KetQuaTinh GetByMaKetQua(TransactionManager transactionManager, System.Int32 _maKetQua, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_KetQuaTinh_GetKetQuaByMaGiangVienNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaTinh_GetKetQuaByMaGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32?</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KetQuaTinh&gt;"/> instance.</returns>
		public TList<KetQuaTinh> GetKetQuaByMaGiangVienNamHocHocKy(System.Int32? maGiangVien, System.String namHoc, System.String hocKy)
		{
			return GetKetQuaByMaGiangVienNamHocHocKy(null, 0, int.MaxValue , maGiangVien, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaTinh_GetKetQuaByMaGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32?</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KetQuaTinh&gt;"/> instance.</returns>
		public TList<KetQuaTinh> GetKetQuaByMaGiangVienNamHocHocKy(int start, int pageLength, System.Int32? maGiangVien, System.String namHoc, System.String hocKy)
		{
			return GetKetQuaByMaGiangVienNamHocHocKy(null, start, pageLength , maGiangVien, namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaTinh_GetKetQuaByMaGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32?</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KetQuaTinh&gt;"/> instance.</returns>
		public TList<KetQuaTinh> GetKetQuaByMaGiangVienNamHocHocKy(TransactionManager transactionManager, System.Int32? maGiangVien, System.String namHoc, System.String hocKy)
		{
			return GetKetQuaByMaGiangVienNamHocHocKy(transactionManager, 0, int.MaxValue , maGiangVien, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaTinh_GetKetQuaByMaGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32?</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KetQuaTinh&gt;"/> instance.</returns>
		public abstract TList<KetQuaTinh> GetKetQuaByMaGiangVienNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.Int32? maGiangVien, System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_KetQuaTinh_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaTinh_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KetQuaTinh&gt;"/> instance.</returns>
		public TList<KetQuaTinh> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaTinh_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KetQuaTinh&gt;"/> instance.</returns>
		public TList<KetQuaTinh> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KetQuaTinh_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KetQuaTinh&gt;"/> instance.</returns>
		public TList<KetQuaTinh> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KetQuaTinh_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KetQuaTinh&gt;"/> instance.</returns>
		public abstract TList<KetQuaTinh> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KetQuaTinh&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KetQuaTinh&gt;"/></returns>
		public static TList<KetQuaTinh> Fill(IDataReader reader, TList<KetQuaTinh> rows, int start, int pageLength)
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
				
				PMS.Entities.KetQuaTinh c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KetQuaTinh")
					.Append("|").Append((System.Int32)reader[((int)KetQuaTinhColumn.MaKetQua - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KetQuaTinh>(
					key.ToString(), // EntityTrackingKey
					"KetQuaTinh",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KetQuaTinh();
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
					c.MaKetQua = (System.Int32)reader[(KetQuaTinhColumn.MaKetQua.ToString())];
					c.MaGiangVien = (reader[KetQuaTinhColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KetQuaTinhColumn.MaGiangVien.ToString())];
					c.HocKy = (reader[KetQuaTinhColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaTinhColumn.HocKy.ToString())];
					c.NamHoc = (reader[KetQuaTinhColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaTinhColumn.NamHoc.ToString())];
					c.TietNghiaVu = (reader[KetQuaTinhColumn.TietNghiaVu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KetQuaTinhColumn.TietNghiaVu.ToString())];
					c.TietGioiHan = (reader[KetQuaTinhColumn.TietGioiHan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KetQuaTinhColumn.TietGioiHan.ToString())];
					c.DonGia = (reader[KetQuaTinhColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaTinhColumn.DonGia.ToString())];
					c.NgayTao = (reader[KetQuaTinhColumn.NgayTao.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KetQuaTinhColumn.NgayTao.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KetQuaTinh"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KetQuaTinh"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KetQuaTinh entity)
		{
			if (!reader.Read()) return;
			
			entity.MaKetQua = (System.Int32)reader[(KetQuaTinhColumn.MaKetQua.ToString())];
			entity.MaGiangVien = (reader[KetQuaTinhColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KetQuaTinhColumn.MaGiangVien.ToString())];
			entity.HocKy = (reader[KetQuaTinhColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaTinhColumn.HocKy.ToString())];
			entity.NamHoc = (reader[KetQuaTinhColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KetQuaTinhColumn.NamHoc.ToString())];
			entity.TietNghiaVu = (reader[KetQuaTinhColumn.TietNghiaVu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KetQuaTinhColumn.TietNghiaVu.ToString())];
			entity.TietGioiHan = (reader[KetQuaTinhColumn.TietGioiHan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KetQuaTinhColumn.TietGioiHan.ToString())];
			entity.DonGia = (reader[KetQuaTinhColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KetQuaTinhColumn.DonGia.ToString())];
			entity.NgayTao = (reader[KetQuaTinhColumn.NgayTao.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KetQuaTinhColumn.NgayTao.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KetQuaTinh"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KetQuaTinh"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KetQuaTinh entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaKetQua = (System.Int32)dataRow["MaKetQua"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.Int32?)dataRow["MaGiangVien"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.TietNghiaVu = Convert.IsDBNull(dataRow["TietNghiaVu"]) ? null : (System.Int32?)dataRow["TietNghiaVu"];
			entity.TietGioiHan = Convert.IsDBNull(dataRow["TietGioiHan"]) ? null : (System.Int32?)dataRow["TietGioiHan"];
			entity.DonGia = Convert.IsDBNull(dataRow["DonGia"]) ? null : (System.Decimal?)dataRow["DonGia"];
			entity.NgayTao = Convert.IsDBNull(dataRow["NgayTao"]) ? null : (System.DateTime?)dataRow["NgayTao"];
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
		/// <param name="entity">The <see cref="PMS.Entities.KetQuaTinh"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KetQuaTinh Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KetQuaTinh entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
			// Deep load child collections  - Call GetByMaKetQua methods when available
			
			#region KhoiLuongGiangDayCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<KhoiLuongGiangDay>|KhoiLuongGiangDayCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'KhoiLuongGiangDayCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.KhoiLuongGiangDayCollection = DataRepository.KhoiLuongGiangDayProvider.GetByMaKetQua(transactionManager, entity.MaKetQua);

				if (deep && entity.KhoiLuongGiangDayCollection.Count > 0)
				{
					deepHandles.Add("KhoiLuongGiangDayCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<KhoiLuongGiangDay>) DataRepository.KhoiLuongGiangDayProvider.DeepLoad,
						new object[] { transactionManager, entity.KhoiLuongGiangDayCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.KetQuaTinh object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KetQuaTinh instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KetQuaTinh Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KetQuaTinh entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<KhoiLuongGiangDay>
				if (CanDeepSave(entity.KhoiLuongGiangDayCollection, "List<KhoiLuongGiangDay>|KhoiLuongGiangDayCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(KhoiLuongGiangDay child in entity.KhoiLuongGiangDayCollection)
					{
						if(child.MaKetQuaSource != null)
						{
							child.MaKetQua = child.MaKetQuaSource.MaKetQua;
						}
						else
						{
							child.MaKetQua = entity.MaKetQua;
						}

					}

					if (entity.KhoiLuongGiangDayCollection.Count > 0 || entity.KhoiLuongGiangDayCollection.DeletedItems.Count > 0)
					{
						//DataRepository.KhoiLuongGiangDayProvider.Save(transactionManager, entity.KhoiLuongGiangDayCollection);
						
						deepHandles.Add("KhoiLuongGiangDayCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< KhoiLuongGiangDay >) DataRepository.KhoiLuongGiangDayProvider.DeepSave,
							new object[] { transactionManager, entity.KhoiLuongGiangDayCollection, deepSaveType, childTypes, innerList }
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
	
	#region KetQuaTinhChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KetQuaTinh</c>
	///</summary>
	public enum KetQuaTinhChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GiangVien</c> at MaGiangVienSource
		///</summary>
		[ChildEntityType(typeof(GiangVien))]
		GiangVien,
		///<summary>
		/// Collection of <c>KetQuaTinh</c> as OneToMany for KhoiLuongGiangDayCollection
		///</summary>
		[ChildEntityType(typeof(TList<KhoiLuongGiangDay>))]
		KhoiLuongGiangDayCollection,
	}
	
	#endregion KetQuaTinhChildEntityTypes
	
	#region KetQuaTinhFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KetQuaTinhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KetQuaTinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KetQuaTinhFilterBuilder : SqlFilterBuilder<KetQuaTinhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KetQuaTinhFilterBuilder class.
		/// </summary>
		public KetQuaTinhFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KetQuaTinhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KetQuaTinhFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KetQuaTinhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KetQuaTinhFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KetQuaTinhFilterBuilder
	
	#region KetQuaTinhParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KetQuaTinhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KetQuaTinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KetQuaTinhParameterBuilder : ParameterizedSqlFilterBuilder<KetQuaTinhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KetQuaTinhParameterBuilder class.
		/// </summary>
		public KetQuaTinhParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KetQuaTinhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KetQuaTinhParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KetQuaTinhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KetQuaTinhParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KetQuaTinhParameterBuilder
	
	#region KetQuaTinhSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KetQuaTinhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KetQuaTinh"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KetQuaTinhSortBuilder : SqlSortBuilder<KetQuaTinhColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KetQuaTinhSqlSortBuilder class.
		/// </summary>
		public KetQuaTinhSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KetQuaTinhSortBuilder
	
} // end namespace
