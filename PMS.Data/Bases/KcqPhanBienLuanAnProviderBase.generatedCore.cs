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
	/// This class is the base class for any <see cref="KcqPhanBienLuanAnProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KcqPhanBienLuanAnProviderBaseCore : EntityProviderBase<PMS.Entities.KcqPhanBienLuanAn, PMS.Entities.KcqPhanBienLuanAnKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KcqPhanBienLuanAnKey key)
		{
			return Delete(transactionManager, key.MaGiangVien, key.NamHoc, key.HocKy, key.Loai);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maGiangVien">. Primary Key.</param>
		/// <param name="_namHoc">. Primary Key.</param>
		/// <param name="_hocKy">. Primary Key.</param>
		/// <param name="_loai">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maGiangVien, System.String _namHoc, System.String _hocKy, System.String _loai)
		{
			return Delete(null, _maGiangVien, _namHoc, _hocKy, _loai);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien">. Primary Key.</param>
		/// <param name="_namHoc">. Primary Key.</param>
		/// <param name="_hocKy">. Primary Key.</param>
		/// <param name="_loai">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maGiangVien, System.String _namHoc, System.String _hocKy, System.String _loai);		
		
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
		public override PMS.Entities.KcqPhanBienLuanAn Get(TransactionManager transactionManager, PMS.Entities.KcqPhanBienLuanAnKey key, int start, int pageLength)
		{
			return GetByMaGiangVienNamHocHocKyLoai(transactionManager, key.MaGiangVien, key.NamHoc, key.HocKy, key.Loai, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KcqPhanBienLuanAn index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <param name="_loai"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqPhanBienLuanAn"/> class.</returns>
		public PMS.Entities.KcqPhanBienLuanAn GetByMaGiangVienNamHocHocKyLoai(System.Int32 _maGiangVien, System.String _namHoc, System.String _hocKy, System.String _loai)
		{
			int count = -1;
			return GetByMaGiangVienNamHocHocKyLoai(null,_maGiangVien, _namHoc, _hocKy, _loai, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqPhanBienLuanAn index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <param name="_loai"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqPhanBienLuanAn"/> class.</returns>
		public PMS.Entities.KcqPhanBienLuanAn GetByMaGiangVienNamHocHocKyLoai(System.Int32 _maGiangVien, System.String _namHoc, System.String _hocKy, System.String _loai, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVienNamHocHocKyLoai(null, _maGiangVien, _namHoc, _hocKy, _loai, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqPhanBienLuanAn index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <param name="_loai"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqPhanBienLuanAn"/> class.</returns>
		public PMS.Entities.KcqPhanBienLuanAn GetByMaGiangVienNamHocHocKyLoai(TransactionManager transactionManager, System.Int32 _maGiangVien, System.String _namHoc, System.String _hocKy, System.String _loai)
		{
			int count = -1;
			return GetByMaGiangVienNamHocHocKyLoai(transactionManager, _maGiangVien, _namHoc, _hocKy, _loai, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqPhanBienLuanAn index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <param name="_loai"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqPhanBienLuanAn"/> class.</returns>
		public PMS.Entities.KcqPhanBienLuanAn GetByMaGiangVienNamHocHocKyLoai(TransactionManager transactionManager, System.Int32 _maGiangVien, System.String _namHoc, System.String _hocKy, System.String _loai, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVienNamHocHocKyLoai(transactionManager, _maGiangVien, _namHoc, _hocKy, _loai, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqPhanBienLuanAn index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <param name="_loai"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqPhanBienLuanAn"/> class.</returns>
		public PMS.Entities.KcqPhanBienLuanAn GetByMaGiangVienNamHocHocKyLoai(System.Int32 _maGiangVien, System.String _namHoc, System.String _hocKy, System.String _loai, int start, int pageLength, out int count)
		{
			return GetByMaGiangVienNamHocHocKyLoai(null, _maGiangVien, _namHoc, _hocKy, _loai, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqPhanBienLuanAn index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <param name="_loai"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqPhanBienLuanAn"/> class.</returns>
		public abstract PMS.Entities.KcqPhanBienLuanAn GetByMaGiangVienNamHocHocKyLoai(TransactionManager transactionManager, System.Int32 _maGiangVien, System.String _namHoc, System.String _hocKy, System.String _loai, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_KcqPhanBienLuanAn_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_KcqPhanBienLuanAn_Luu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String namHoc, System.String hocKy)
		{
			 Luu(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqPhanBienLuanAn_Luu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			 Luu(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KcqPhanBienLuanAn_Luu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			 Luu(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqPhanBienLuanAn_Luu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KcqPhanBienLuanAn&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KcqPhanBienLuanAn&gt;"/></returns>
		public static TList<KcqPhanBienLuanAn> Fill(IDataReader reader, TList<KcqPhanBienLuanAn> rows, int start, int pageLength)
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
				
				PMS.Entities.KcqPhanBienLuanAn c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KcqPhanBienLuanAn")
					.Append("|").Append((System.Int32)reader[((int)KcqPhanBienLuanAnColumn.MaGiangVien - 1)])
					.Append("|").Append((System.String)reader[((int)KcqPhanBienLuanAnColumn.NamHoc - 1)])
					.Append("|").Append((System.String)reader[((int)KcqPhanBienLuanAnColumn.HocKy - 1)])
					.Append("|").Append((System.String)reader[((int)KcqPhanBienLuanAnColumn.Loai - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KcqPhanBienLuanAn>(
					key.ToString(), // EntityTrackingKey
					"KcqPhanBienLuanAn",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KcqPhanBienLuanAn();
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
					c.MaGiangVien = (System.Int32)reader[(KcqPhanBienLuanAnColumn.MaGiangVien.ToString())];
					c.OriginalMaGiangVien = c.MaGiangVien;
					c.NamHoc = (System.String)reader[(KcqPhanBienLuanAnColumn.NamHoc.ToString())];
					c.OriginalNamHoc = c.NamHoc;
					c.HocKy = (System.String)reader[(KcqPhanBienLuanAnColumn.HocKy.ToString())];
					c.OriginalHocKy = c.HocKy;
					c.MaHocHam = (reader[KcqPhanBienLuanAnColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqPhanBienLuanAnColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[KcqPhanBienLuanAnColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqPhanBienLuanAnColumn.MaHocVi.ToString())];
					c.MaLoaiGiangVien = (reader[KcqPhanBienLuanAnColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqPhanBienLuanAnColumn.MaLoaiGiangVien.ToString())];
					c.SoLuong = (reader[KcqPhanBienLuanAnColumn.SoLuong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqPhanBienLuanAnColumn.SoLuong.ToString())];
					c.HeSo = (reader[KcqPhanBienLuanAnColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqPhanBienLuanAnColumn.HeSo.ToString())];
					c.TietQuyDoi = (reader[KcqPhanBienLuanAnColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqPhanBienLuanAnColumn.TietQuyDoi.ToString())];
					c.DonGia = (reader[KcqPhanBienLuanAnColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqPhanBienLuanAnColumn.DonGia.ToString())];
					c.TongThanhTien = (reader[KcqPhanBienLuanAnColumn.TongThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqPhanBienLuanAnColumn.TongThanhTien.ToString())];
					c.NgayCapNhat = (reader[KcqPhanBienLuanAnColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KcqPhanBienLuanAnColumn.NgayCapNhat.ToString())];
					c.HeSoHocKy = (reader[KcqPhanBienLuanAnColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqPhanBienLuanAnColumn.HeSoHocKy.ToString())];
					c.Loai = (System.String)reader[(KcqPhanBienLuanAnColumn.Loai.ToString())];
					c.OriginalLoai = c.Loai;
					c.MaDot = (reader[KcqPhanBienLuanAnColumn.MaDot.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqPhanBienLuanAnColumn.MaDot.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqPhanBienLuanAn"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqPhanBienLuanAn"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KcqPhanBienLuanAn entity)
		{
			if (!reader.Read()) return;
			
			entity.MaGiangVien = (System.Int32)reader[(KcqPhanBienLuanAnColumn.MaGiangVien.ToString())];
			entity.OriginalMaGiangVien = (System.Int32)reader["MaGiangVien"];
			entity.NamHoc = (System.String)reader[(KcqPhanBienLuanAnColumn.NamHoc.ToString())];
			entity.OriginalNamHoc = (System.String)reader["NamHoc"];
			entity.HocKy = (System.String)reader[(KcqPhanBienLuanAnColumn.HocKy.ToString())];
			entity.OriginalHocKy = (System.String)reader["HocKy"];
			entity.MaHocHam = (reader[KcqPhanBienLuanAnColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqPhanBienLuanAnColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[KcqPhanBienLuanAnColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqPhanBienLuanAnColumn.MaHocVi.ToString())];
			entity.MaLoaiGiangVien = (reader[KcqPhanBienLuanAnColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqPhanBienLuanAnColumn.MaLoaiGiangVien.ToString())];
			entity.SoLuong = (reader[KcqPhanBienLuanAnColumn.SoLuong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqPhanBienLuanAnColumn.SoLuong.ToString())];
			entity.HeSo = (reader[KcqPhanBienLuanAnColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqPhanBienLuanAnColumn.HeSo.ToString())];
			entity.TietQuyDoi = (reader[KcqPhanBienLuanAnColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqPhanBienLuanAnColumn.TietQuyDoi.ToString())];
			entity.DonGia = (reader[KcqPhanBienLuanAnColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqPhanBienLuanAnColumn.DonGia.ToString())];
			entity.TongThanhTien = (reader[KcqPhanBienLuanAnColumn.TongThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqPhanBienLuanAnColumn.TongThanhTien.ToString())];
			entity.NgayCapNhat = (reader[KcqPhanBienLuanAnColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KcqPhanBienLuanAnColumn.NgayCapNhat.ToString())];
			entity.HeSoHocKy = (reader[KcqPhanBienLuanAnColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqPhanBienLuanAnColumn.HeSoHocKy.ToString())];
			entity.Loai = (System.String)reader[(KcqPhanBienLuanAnColumn.Loai.ToString())];
			entity.OriginalLoai = (System.String)reader["Loai"];
			entity.MaDot = (reader[KcqPhanBienLuanAnColumn.MaDot.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqPhanBienLuanAnColumn.MaDot.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqPhanBienLuanAn"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqPhanBienLuanAn"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KcqPhanBienLuanAn entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (System.Int32)dataRow["MaGiangVien"];
			entity.OriginalMaGiangVien = (System.Int32)dataRow["MaGiangVien"];
			entity.NamHoc = (System.String)dataRow["NamHoc"];
			entity.OriginalNamHoc = (System.String)dataRow["NamHoc"];
			entity.HocKy = (System.String)dataRow["HocKy"];
			entity.OriginalHocKy = (System.String)dataRow["HocKy"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
			entity.MaLoaiGiangVien = Convert.IsDBNull(dataRow["MaLoaiGiangVien"]) ? null : (System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.SoLuong = Convert.IsDBNull(dataRow["SoLuong"]) ? null : (System.Int32?)dataRow["SoLuong"];
			entity.HeSo = Convert.IsDBNull(dataRow["HeSo"]) ? null : (System.Decimal?)dataRow["HeSo"];
			entity.TietQuyDoi = Convert.IsDBNull(dataRow["TietQuyDoi"]) ? null : (System.Decimal?)dataRow["TietQuyDoi"];
			entity.DonGia = Convert.IsDBNull(dataRow["DonGia"]) ? null : (System.Decimal?)dataRow["DonGia"];
			entity.TongThanhTien = Convert.IsDBNull(dataRow["TongThanhTien"]) ? null : (System.Decimal?)dataRow["TongThanhTien"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
			entity.HeSoHocKy = Convert.IsDBNull(dataRow["HeSoHocKy"]) ? null : (System.Decimal?)dataRow["HeSoHocKy"];
			entity.Loai = (System.String)dataRow["Loai"];
			entity.OriginalLoai = (System.String)dataRow["Loai"];
			entity.MaDot = Convert.IsDBNull(dataRow["MaDot"]) ? null : (System.String)dataRow["MaDot"];
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
		/// <param name="entity">The <see cref="PMS.Entities.KcqPhanBienLuanAn"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KcqPhanBienLuanAn Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KcqPhanBienLuanAn entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.KcqPhanBienLuanAn object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KcqPhanBienLuanAn instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KcqPhanBienLuanAn Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KcqPhanBienLuanAn entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region KcqPhanBienLuanAnChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KcqPhanBienLuanAn</c>
	///</summary>
	public enum KcqPhanBienLuanAnChildEntityTypes
	{
	}
	
	#endregion KcqPhanBienLuanAnChildEntityTypes
	
	#region KcqPhanBienLuanAnFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KcqPhanBienLuanAnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqPhanBienLuanAn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqPhanBienLuanAnFilterBuilder : SqlFilterBuilder<KcqPhanBienLuanAnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqPhanBienLuanAnFilterBuilder class.
		/// </summary>
		public KcqPhanBienLuanAnFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqPhanBienLuanAnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqPhanBienLuanAnFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqPhanBienLuanAnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqPhanBienLuanAnFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqPhanBienLuanAnFilterBuilder
	
	#region KcqPhanBienLuanAnParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KcqPhanBienLuanAnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqPhanBienLuanAn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqPhanBienLuanAnParameterBuilder : ParameterizedSqlFilterBuilder<KcqPhanBienLuanAnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqPhanBienLuanAnParameterBuilder class.
		/// </summary>
		public KcqPhanBienLuanAnParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqPhanBienLuanAnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqPhanBienLuanAnParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqPhanBienLuanAnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqPhanBienLuanAnParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqPhanBienLuanAnParameterBuilder
	
	#region KcqPhanBienLuanAnSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KcqPhanBienLuanAnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqPhanBienLuanAn"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KcqPhanBienLuanAnSortBuilder : SqlSortBuilder<KcqPhanBienLuanAnColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqPhanBienLuanAnSqlSortBuilder class.
		/// </summary>
		public KcqPhanBienLuanAnSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KcqPhanBienLuanAnSortBuilder
	
} // end namespace
