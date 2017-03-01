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
	/// This class is the base class for any <see cref="TcbKetQuaQuyDoiProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class TcbKetQuaQuyDoiProviderBaseCore : EntityProviderBase<PMS.Entities.TcbKetQuaQuyDoi, PMS.Entities.TcbKetQuaQuyDoiKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.TcbKetQuaQuyDoiKey key)
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
		public override PMS.Entities.TcbKetQuaQuyDoi Get(TransactionManager transactionManager, PMS.Entities.TcbKetQuaQuyDoiKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_Tcb_KetQuaQuyDoi index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TcbKetQuaQuyDoi"/> class.</returns>
		public PMS.Entities.TcbKetQuaQuyDoi GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Tcb_KetQuaQuyDoi index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TcbKetQuaQuyDoi"/> class.</returns>
		public PMS.Entities.TcbKetQuaQuyDoi GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Tcb_KetQuaQuyDoi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TcbKetQuaQuyDoi"/> class.</returns>
		public PMS.Entities.TcbKetQuaQuyDoi GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Tcb_KetQuaQuyDoi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TcbKetQuaQuyDoi"/> class.</returns>
		public PMS.Entities.TcbKetQuaQuyDoi GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Tcb_KetQuaQuyDoi index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TcbKetQuaQuyDoi"/> class.</returns>
		public PMS.Entities.TcbKetQuaQuyDoi GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Tcb_KetQuaQuyDoi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TcbKetQuaQuyDoi"/> class.</returns>
		public abstract PMS.Entities.TcbKetQuaQuyDoi GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_Tcb_KetQuaQuyDoi_Import 
		
		/// <summary>
		///	This method wrap the 'cust_Tcb_KetQuaQuyDoi_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader Import(System.String xmlData, ref System.Int32 reVal)
		{
			return Import(null, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_Tcb_KetQuaQuyDoi_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader Import(int start, int pageLength, System.String xmlData, ref System.Int32 reVal)
		{
			return Import(null, start, pageLength , xmlData, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_Tcb_KetQuaQuyDoi_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader Import(TransactionManager transactionManager, System.String xmlData, ref System.Int32 reVal)
		{
			return Import(transactionManager, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_Tcb_KetQuaQuyDoi_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader Import(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_Tcb_KetQuaQuyDoi_DeleteByNgay 
		
		/// <summary>
		///	This method wrap the 'cust_Tcb_KetQuaQuyDoi_DeleteByNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteByNgay(System.DateTime tuNgay, System.DateTime denNgay)
		{
			 DeleteByNgay(null, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_Tcb_KetQuaQuyDoi_DeleteByNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteByNgay(int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay)
		{
			 DeleteByNgay(null, start, pageLength , tuNgay, denNgay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_Tcb_KetQuaQuyDoi_DeleteByNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteByNgay(TransactionManager transactionManager, System.DateTime tuNgay, System.DateTime denNgay)
		{
			 DeleteByNgay(transactionManager, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_Tcb_KetQuaQuyDoi_DeleteByNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DeleteByNgay(TransactionManager transactionManager, int start, int pageLength , System.DateTime tuNgay, System.DateTime denNgay);
		
		#endregion
		
		#region cust_Tcb_KetQuaQuyDoi_GetByMaGiangVienQuanLyNgay 
		
		/// <summary>
		///	This method wrap the 'cust_Tcb_KetQuaQuyDoi_GetByMaGiangVienQuanLyNgay' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaGiangVienQuanLyNgay(System.String maQuanLy, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByMaGiangVienQuanLyNgay(null, 0, int.MaxValue , maQuanLy, tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_Tcb_KetQuaQuyDoi_GetByMaGiangVienQuanLyNgay' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaGiangVienQuanLyNgay(int start, int pageLength, System.String maQuanLy, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByMaGiangVienQuanLyNgay(null, start, pageLength , maQuanLy, tuNgay, denNgay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_Tcb_KetQuaQuyDoi_GetByMaGiangVienQuanLyNgay' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaGiangVienQuanLyNgay(TransactionManager transactionManager, System.String maQuanLy, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByMaGiangVienQuanLyNgay(transactionManager, 0, int.MaxValue , maQuanLy, tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_Tcb_KetQuaQuyDoi_GetByMaGiangVienQuanLyNgay' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByMaGiangVienQuanLyNgay(TransactionManager transactionManager, int start, int pageLength , System.String maQuanLy, System.DateTime tuNgay, System.DateTime denNgay);
		
		#endregion
		
		#region cust_Tcb_KetQuaQuyDoi_GetByNgay 
		
		/// <summary>
		///	This method wrap the 'cust_Tcb_KetQuaQuyDoi_GetByNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNgay(System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByNgay(null, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_Tcb_KetQuaQuyDoi_GetByNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNgay(int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByNgay(null, start, pageLength , tuNgay, denNgay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_Tcb_KetQuaQuyDoi_GetByNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNgay(TransactionManager transactionManager, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByNgay(transactionManager, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_Tcb_KetQuaQuyDoi_GetByNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNgay(TransactionManager transactionManager, int start, int pageLength , System.DateTime tuNgay, System.DateTime denNgay);
		
		#endregion
		
		#region cust_Tcb_KetQuaQuyDoi_GetByNgayMaQuanLy 
		
		/// <summary>
		///	This method wrap the 'cust_Tcb_KetQuaQuyDoi_GetByNgayMaQuanLy' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNgayMaQuanLy(System.DateTime tuNgay, System.DateTime denNgay, System.String maQuanLy)
		{
			return GetByNgayMaQuanLy(null, 0, int.MaxValue , tuNgay, denNgay, maQuanLy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_Tcb_KetQuaQuyDoi_GetByNgayMaQuanLy' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNgayMaQuanLy(int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay, System.String maQuanLy)
		{
			return GetByNgayMaQuanLy(null, start, pageLength , tuNgay, denNgay, maQuanLy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_Tcb_KetQuaQuyDoi_GetByNgayMaQuanLy' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNgayMaQuanLy(TransactionManager transactionManager, System.DateTime tuNgay, System.DateTime denNgay, System.String maQuanLy)
		{
			return GetByNgayMaQuanLy(transactionManager, 0, int.MaxValue , tuNgay, denNgay, maQuanLy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_Tcb_KetQuaQuyDoi_GetByNgayMaQuanLy' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNgayMaQuanLy(TransactionManager transactionManager, int start, int pageLength , System.DateTime tuNgay, System.DateTime denNgay, System.String maQuanLy);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;TcbKetQuaQuyDoi&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;TcbKetQuaQuyDoi&gt;"/></returns>
		public static TList<TcbKetQuaQuyDoi> Fill(IDataReader reader, TList<TcbKetQuaQuyDoi> rows, int start, int pageLength)
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
				
				PMS.Entities.TcbKetQuaQuyDoi c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("TcbKetQuaQuyDoi")
					.Append("|").Append((System.Int32)reader[((int)TcbKetQuaQuyDoiColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<TcbKetQuaQuyDoi>(
					key.ToString(), // EntityTrackingKey
					"TcbKetQuaQuyDoi",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.TcbKetQuaQuyDoi();
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
					c.Id = (System.Int32)reader[(TcbKetQuaQuyDoiColumn.Id.ToString())];
					c.MaKhoiLuongGiangDay = (reader[TcbKetQuaQuyDoiColumn.MaKhoiLuongGiangDay.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(TcbKetQuaQuyDoiColumn.MaKhoiLuongGiangDay.ToString())];
					c.MaGiangVien = (reader[TcbKetQuaQuyDoiColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.String)reader[(TcbKetQuaQuyDoiColumn.MaGiangVien.ToString())];
					c.MaLopHocPhan = (reader[TcbKetQuaQuyDoiColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(TcbKetQuaQuyDoiColumn.MaLopHocPhan.ToString())];
					c.NamHoc = (reader[TcbKetQuaQuyDoiColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(TcbKetQuaQuyDoiColumn.NamHoc.ToString())];
					c.HocKy = (reader[TcbKetQuaQuyDoiColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(TcbKetQuaQuyDoiColumn.HocKy.ToString())];
					c.MaMonHoc = (reader[TcbKetQuaQuyDoiColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(TcbKetQuaQuyDoiColumn.MaMonHoc.ToString())];
					c.TenMonHoc = (reader[TcbKetQuaQuyDoiColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(TcbKetQuaQuyDoiColumn.TenMonHoc.ToString())];
					c.SoTinChi = (reader[TcbKetQuaQuyDoiColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TcbKetQuaQuyDoiColumn.SoTinChi.ToString())];
					c.SoLuong = (reader[TcbKetQuaQuyDoiColumn.SoLuong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(TcbKetQuaQuyDoiColumn.SoLuong.ToString())];
					c.MaLoaiHocPhan = (reader[TcbKetQuaQuyDoiColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(TcbKetQuaQuyDoiColumn.MaLoaiHocPhan.ToString())];
					c.LoaiHocPhan = (reader[TcbKetQuaQuyDoiColumn.LoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(TcbKetQuaQuyDoiColumn.LoaiHocPhan.ToString())];
					c.MaBuoiHoc = (reader[TcbKetQuaQuyDoiColumn.MaBuoiHoc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(TcbKetQuaQuyDoiColumn.MaBuoiHoc.ToString())];
					c.MaLop = (reader[TcbKetQuaQuyDoiColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(TcbKetQuaQuyDoiColumn.MaLop.ToString())];
					c.TietBatDau = (reader[TcbKetQuaQuyDoiColumn.TietBatDau.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(TcbKetQuaQuyDoiColumn.TietBatDau.ToString())];
					c.SoTiet = (reader[TcbKetQuaQuyDoiColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(TcbKetQuaQuyDoiColumn.SoTiet.ToString())];
					c.TinhTrang = (reader[TcbKetQuaQuyDoiColumn.TinhTrang.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(TcbKetQuaQuyDoiColumn.TinhTrang.ToString())];
					c.NgayDay = (reader[TcbKetQuaQuyDoiColumn.NgayDay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(TcbKetQuaQuyDoiColumn.NgayDay.ToString())];
					c.MaBacDaoTao = (reader[TcbKetQuaQuyDoiColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(TcbKetQuaQuyDoiColumn.MaBacDaoTao.ToString())];
					c.MaKhoaHoc = (reader[TcbKetQuaQuyDoiColumn.MaKhoaHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(TcbKetQuaQuyDoiColumn.MaKhoaHoc.ToString())];
					c.MaKhoa = (reader[TcbKetQuaQuyDoiColumn.MaKhoa.ToString()] == DBNull.Value) ? null : (System.String)reader[(TcbKetQuaQuyDoiColumn.MaKhoa.ToString())];
					c.MaNhomMonHoc = (reader[TcbKetQuaQuyDoiColumn.MaNhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(TcbKetQuaQuyDoiColumn.MaNhomMonHoc.ToString())];
					c.MaCoSo = (reader[TcbKetQuaQuyDoiColumn.MaCoSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(TcbKetQuaQuyDoiColumn.MaCoSo.ToString())];
					c.HeSoLopDong = (reader[TcbKetQuaQuyDoiColumn.HeSoLopDong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TcbKetQuaQuyDoiColumn.HeSoLopDong.ToString())];
					c.DonGia = (reader[TcbKetQuaQuyDoiColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TcbKetQuaQuyDoiColumn.DonGia.ToString())];
					c.ThanhTien = (reader[TcbKetQuaQuyDoiColumn.ThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TcbKetQuaQuyDoiColumn.ThanhTien.ToString())];
					c.CongTacPhi = (reader[TcbKetQuaQuyDoiColumn.CongTacPhi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TcbKetQuaQuyDoiColumn.CongTacPhi.ToString())];
					c.TienGiangNgoaiGio = (reader[TcbKetQuaQuyDoiColumn.TienGiangNgoaiGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TcbKetQuaQuyDoiColumn.TienGiangNgoaiGio.ToString())];
					c.TongThanhTien = (reader[TcbKetQuaQuyDoiColumn.TongThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TcbKetQuaQuyDoiColumn.TongThanhTien.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.TcbKetQuaQuyDoi"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.TcbKetQuaQuyDoi"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.TcbKetQuaQuyDoi entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(TcbKetQuaQuyDoiColumn.Id.ToString())];
			entity.MaKhoiLuongGiangDay = (reader[TcbKetQuaQuyDoiColumn.MaKhoiLuongGiangDay.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(TcbKetQuaQuyDoiColumn.MaKhoiLuongGiangDay.ToString())];
			entity.MaGiangVien = (reader[TcbKetQuaQuyDoiColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.String)reader[(TcbKetQuaQuyDoiColumn.MaGiangVien.ToString())];
			entity.MaLopHocPhan = (reader[TcbKetQuaQuyDoiColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(TcbKetQuaQuyDoiColumn.MaLopHocPhan.ToString())];
			entity.NamHoc = (reader[TcbKetQuaQuyDoiColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(TcbKetQuaQuyDoiColumn.NamHoc.ToString())];
			entity.HocKy = (reader[TcbKetQuaQuyDoiColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(TcbKetQuaQuyDoiColumn.HocKy.ToString())];
			entity.MaMonHoc = (reader[TcbKetQuaQuyDoiColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(TcbKetQuaQuyDoiColumn.MaMonHoc.ToString())];
			entity.TenMonHoc = (reader[TcbKetQuaQuyDoiColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(TcbKetQuaQuyDoiColumn.TenMonHoc.ToString())];
			entity.SoTinChi = (reader[TcbKetQuaQuyDoiColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TcbKetQuaQuyDoiColumn.SoTinChi.ToString())];
			entity.SoLuong = (reader[TcbKetQuaQuyDoiColumn.SoLuong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(TcbKetQuaQuyDoiColumn.SoLuong.ToString())];
			entity.MaLoaiHocPhan = (reader[TcbKetQuaQuyDoiColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(TcbKetQuaQuyDoiColumn.MaLoaiHocPhan.ToString())];
			entity.LoaiHocPhan = (reader[TcbKetQuaQuyDoiColumn.LoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(TcbKetQuaQuyDoiColumn.LoaiHocPhan.ToString())];
			entity.MaBuoiHoc = (reader[TcbKetQuaQuyDoiColumn.MaBuoiHoc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(TcbKetQuaQuyDoiColumn.MaBuoiHoc.ToString())];
			entity.MaLop = (reader[TcbKetQuaQuyDoiColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(TcbKetQuaQuyDoiColumn.MaLop.ToString())];
			entity.TietBatDau = (reader[TcbKetQuaQuyDoiColumn.TietBatDau.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(TcbKetQuaQuyDoiColumn.TietBatDau.ToString())];
			entity.SoTiet = (reader[TcbKetQuaQuyDoiColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(TcbKetQuaQuyDoiColumn.SoTiet.ToString())];
			entity.TinhTrang = (reader[TcbKetQuaQuyDoiColumn.TinhTrang.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(TcbKetQuaQuyDoiColumn.TinhTrang.ToString())];
			entity.NgayDay = (reader[TcbKetQuaQuyDoiColumn.NgayDay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(TcbKetQuaQuyDoiColumn.NgayDay.ToString())];
			entity.MaBacDaoTao = (reader[TcbKetQuaQuyDoiColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(TcbKetQuaQuyDoiColumn.MaBacDaoTao.ToString())];
			entity.MaKhoaHoc = (reader[TcbKetQuaQuyDoiColumn.MaKhoaHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(TcbKetQuaQuyDoiColumn.MaKhoaHoc.ToString())];
			entity.MaKhoa = (reader[TcbKetQuaQuyDoiColumn.MaKhoa.ToString()] == DBNull.Value) ? null : (System.String)reader[(TcbKetQuaQuyDoiColumn.MaKhoa.ToString())];
			entity.MaNhomMonHoc = (reader[TcbKetQuaQuyDoiColumn.MaNhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(TcbKetQuaQuyDoiColumn.MaNhomMonHoc.ToString())];
			entity.MaCoSo = (reader[TcbKetQuaQuyDoiColumn.MaCoSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(TcbKetQuaQuyDoiColumn.MaCoSo.ToString())];
			entity.HeSoLopDong = (reader[TcbKetQuaQuyDoiColumn.HeSoLopDong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TcbKetQuaQuyDoiColumn.HeSoLopDong.ToString())];
			entity.DonGia = (reader[TcbKetQuaQuyDoiColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TcbKetQuaQuyDoiColumn.DonGia.ToString())];
			entity.ThanhTien = (reader[TcbKetQuaQuyDoiColumn.ThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TcbKetQuaQuyDoiColumn.ThanhTien.ToString())];
			entity.CongTacPhi = (reader[TcbKetQuaQuyDoiColumn.CongTacPhi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TcbKetQuaQuyDoiColumn.CongTacPhi.ToString())];
			entity.TienGiangNgoaiGio = (reader[TcbKetQuaQuyDoiColumn.TienGiangNgoaiGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TcbKetQuaQuyDoiColumn.TienGiangNgoaiGio.ToString())];
			entity.TongThanhTien = (reader[TcbKetQuaQuyDoiColumn.TongThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TcbKetQuaQuyDoiColumn.TongThanhTien.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.TcbKetQuaQuyDoi"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.TcbKetQuaQuyDoi"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.TcbKetQuaQuyDoi entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaKhoiLuongGiangDay = Convert.IsDBNull(dataRow["MaKhoiLuongGiangDay"]) ? null : (System.Int32?)dataRow["MaKhoiLuongGiangDay"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.String)dataRow["MaGiangVien"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = Convert.IsDBNull(dataRow["TenMonHoc"]) ? null : (System.String)dataRow["TenMonHoc"];
			entity.SoTinChi = Convert.IsDBNull(dataRow["SoTinChi"]) ? null : (System.Decimal?)dataRow["SoTinChi"];
			entity.SoLuong = Convert.IsDBNull(dataRow["SoLuong"]) ? null : (System.Int32?)dataRow["SoLuong"];
			entity.MaLoaiHocPhan = Convert.IsDBNull(dataRow["MaLoaiHocPhan"]) ? null : (System.String)dataRow["MaLoaiHocPhan"];
			entity.LoaiHocPhan = Convert.IsDBNull(dataRow["LoaiHocPhan"]) ? null : (System.String)dataRow["LoaiHocPhan"];
			entity.MaBuoiHoc = Convert.IsDBNull(dataRow["MaBuoiHoc"]) ? null : (System.Int32?)dataRow["MaBuoiHoc"];
			entity.MaLop = Convert.IsDBNull(dataRow["MaLop"]) ? null : (System.String)dataRow["MaLop"];
			entity.TietBatDau = Convert.IsDBNull(dataRow["TietBatDau"]) ? null : (System.Int32?)dataRow["TietBatDau"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Int32?)dataRow["SoTiet"];
			entity.TinhTrang = Convert.IsDBNull(dataRow["TinhTrang"]) ? null : (System.Int32?)dataRow["TinhTrang"];
			entity.NgayDay = Convert.IsDBNull(dataRow["NgayDay"]) ? null : (System.DateTime?)dataRow["NgayDay"];
			entity.MaBacDaoTao = Convert.IsDBNull(dataRow["MaBacDaoTao"]) ? null : (System.String)dataRow["MaBacDaoTao"];
			entity.MaKhoaHoc = Convert.IsDBNull(dataRow["MaKhoaHoc"]) ? null : (System.String)dataRow["MaKhoaHoc"];
			entity.MaKhoa = Convert.IsDBNull(dataRow["MaKhoa"]) ? null : (System.String)dataRow["MaKhoa"];
			entity.MaNhomMonHoc = Convert.IsDBNull(dataRow["MaNhomMonHoc"]) ? null : (System.String)dataRow["MaNhomMonHoc"];
			entity.MaCoSo = Convert.IsDBNull(dataRow["MaCoSo"]) ? null : (System.String)dataRow["MaCoSo"];
			entity.HeSoLopDong = Convert.IsDBNull(dataRow["HeSoLopDong"]) ? null : (System.Decimal?)dataRow["HeSoLopDong"];
			entity.DonGia = Convert.IsDBNull(dataRow["DonGia"]) ? null : (System.Decimal?)dataRow["DonGia"];
			entity.ThanhTien = Convert.IsDBNull(dataRow["ThanhTien"]) ? null : (System.Decimal?)dataRow["ThanhTien"];
			entity.CongTacPhi = Convert.IsDBNull(dataRow["CongTacPhi"]) ? null : (System.Decimal?)dataRow["CongTacPhi"];
			entity.TienGiangNgoaiGio = Convert.IsDBNull(dataRow["TienGiangNgoaiGio"]) ? null : (System.Decimal?)dataRow["TienGiangNgoaiGio"];
			entity.TongThanhTien = Convert.IsDBNull(dataRow["TongThanhTien"]) ? null : (System.Decimal?)dataRow["TongThanhTien"];
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
		/// <param name="entity">The <see cref="PMS.Entities.TcbKetQuaQuyDoi"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.TcbKetQuaQuyDoi Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.TcbKetQuaQuyDoi entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
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
		/// Deep Save the entire object graph of the PMS.Entities.TcbKetQuaQuyDoi object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.TcbKetQuaQuyDoi instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.TcbKetQuaQuyDoi Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.TcbKetQuaQuyDoi entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
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
	
	#region TcbKetQuaQuyDoiChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.TcbKetQuaQuyDoi</c>
	///</summary>
	public enum TcbKetQuaQuyDoiChildEntityTypes
	{
	}
	
	#endregion TcbKetQuaQuyDoiChildEntityTypes
	
	#region TcbKetQuaQuyDoiFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;TcbKetQuaQuyDoiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TcbKetQuaQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TcbKetQuaQuyDoiFilterBuilder : SqlFilterBuilder<TcbKetQuaQuyDoiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TcbKetQuaQuyDoiFilterBuilder class.
		/// </summary>
		public TcbKetQuaQuyDoiFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TcbKetQuaQuyDoiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TcbKetQuaQuyDoiFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TcbKetQuaQuyDoiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TcbKetQuaQuyDoiFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TcbKetQuaQuyDoiFilterBuilder
	
	#region TcbKetQuaQuyDoiParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;TcbKetQuaQuyDoiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TcbKetQuaQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TcbKetQuaQuyDoiParameterBuilder : ParameterizedSqlFilterBuilder<TcbKetQuaQuyDoiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TcbKetQuaQuyDoiParameterBuilder class.
		/// </summary>
		public TcbKetQuaQuyDoiParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TcbKetQuaQuyDoiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TcbKetQuaQuyDoiParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TcbKetQuaQuyDoiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TcbKetQuaQuyDoiParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TcbKetQuaQuyDoiParameterBuilder
	
	#region TcbKetQuaQuyDoiSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;TcbKetQuaQuyDoiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TcbKetQuaQuyDoi"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class TcbKetQuaQuyDoiSortBuilder : SqlSortBuilder<TcbKetQuaQuyDoiColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TcbKetQuaQuyDoiSqlSortBuilder class.
		/// </summary>
		public TcbKetQuaQuyDoiSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion TcbKetQuaQuyDoiSortBuilder
	
} // end namespace
