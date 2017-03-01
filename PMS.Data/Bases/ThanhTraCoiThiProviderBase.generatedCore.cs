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
	/// This class is the base class for any <see cref="ThanhTraCoiThiProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ThanhTraCoiThiProviderBaseCore : EntityProviderBase<PMS.Entities.ThanhTraCoiThi, PMS.Entities.ThanhTraCoiThiKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.ThanhTraCoiThiKey key)
		{
			return Delete(transactionManager, key.Examination, key.MaCanBoCoiThi);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_examination">. Primary Key.</param>
		/// <param name="_maCanBoCoiThi">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _examination, System.String _maCanBoCoiThi)
		{
			return Delete(null, _examination, _maCanBoCoiThi);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_examination">. Primary Key.</param>
		/// <param name="_maCanBoCoiThi">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _examination, System.String _maCanBoCoiThi);		
		
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
		public override PMS.Entities.ThanhTraCoiThi Get(TransactionManager transactionManager, PMS.Entities.ThanhTraCoiThiKey key, int start, int pageLength)
		{
			return GetByExaminationMaCanBoCoiThi(transactionManager, key.Examination, key.MaCanBoCoiThi, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ThanhTraCoiThi index.
		/// </summary>
		/// <param name="_examination"></param>
		/// <param name="_maCanBoCoiThi"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhTraCoiThi"/> class.</returns>
		public PMS.Entities.ThanhTraCoiThi GetByExaminationMaCanBoCoiThi(System.Int32 _examination, System.String _maCanBoCoiThi)
		{
			int count = -1;
			return GetByExaminationMaCanBoCoiThi(null,_examination, _maCanBoCoiThi, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThanhTraCoiThi index.
		/// </summary>
		/// <param name="_examination"></param>
		/// <param name="_maCanBoCoiThi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhTraCoiThi"/> class.</returns>
		public PMS.Entities.ThanhTraCoiThi GetByExaminationMaCanBoCoiThi(System.Int32 _examination, System.String _maCanBoCoiThi, int start, int pageLength)
		{
			int count = -1;
			return GetByExaminationMaCanBoCoiThi(null, _examination, _maCanBoCoiThi, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThanhTraCoiThi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_examination"></param>
		/// <param name="_maCanBoCoiThi"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhTraCoiThi"/> class.</returns>
		public PMS.Entities.ThanhTraCoiThi GetByExaminationMaCanBoCoiThi(TransactionManager transactionManager, System.Int32 _examination, System.String _maCanBoCoiThi)
		{
			int count = -1;
			return GetByExaminationMaCanBoCoiThi(transactionManager, _examination, _maCanBoCoiThi, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThanhTraCoiThi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_examination"></param>
		/// <param name="_maCanBoCoiThi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhTraCoiThi"/> class.</returns>
		public PMS.Entities.ThanhTraCoiThi GetByExaminationMaCanBoCoiThi(TransactionManager transactionManager, System.Int32 _examination, System.String _maCanBoCoiThi, int start, int pageLength)
		{
			int count = -1;
			return GetByExaminationMaCanBoCoiThi(transactionManager, _examination, _maCanBoCoiThi, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThanhTraCoiThi index.
		/// </summary>
		/// <param name="_examination"></param>
		/// <param name="_maCanBoCoiThi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhTraCoiThi"/> class.</returns>
		public PMS.Entities.ThanhTraCoiThi GetByExaminationMaCanBoCoiThi(System.Int32 _examination, System.String _maCanBoCoiThi, int start, int pageLength, out int count)
		{
			return GetByExaminationMaCanBoCoiThi(null, _examination, _maCanBoCoiThi, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThanhTraCoiThi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_examination"></param>
		/// <param name="_maCanBoCoiThi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhTraCoiThi"/> class.</returns>
		public abstract PMS.Entities.ThanhTraCoiThi GetByExaminationMaCanBoCoiThi(TransactionManager transactionManager, System.Int32 _examination, System.String _maCanBoCoiThi, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_ThanhTraCoiThi_ThongKeTongTietTheoKhoa 
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraCoiThi_ThongKeTongTietTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongTietTheoKhoa(System.String maDonVi, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return ThongKeTongTietTheoKhoa(null, 0, int.MaxValue , maDonVi, tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraCoiThi_ThongKeTongTietTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongTietTheoKhoa(int start, int pageLength, System.String maDonVi, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return ThongKeTongTietTheoKhoa(null, start, pageLength , maDonVi, tuNgay, denNgay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThanhTraCoiThi_ThongKeTongTietTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongTietTheoKhoa(TransactionManager transactionManager, System.String maDonVi, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return ThongKeTongTietTheoKhoa(transactionManager, 0, int.MaxValue , maDonVi, tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraCoiThi_ThongKeTongTietTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeTongTietTheoKhoa(TransactionManager transactionManager, int start, int pageLength , System.String maDonVi, System.DateTime tuNgay, System.DateTime denNgay);
		
		#endregion
		
		#region cust_ThanhTraCoiThi_ThongKeChiTietTheoNgay 
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraCoiThi_ThongKeChiTietTheoNgay' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeChiTietTheoNgay(System.String maQuanLy, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return ThongKeChiTietTheoNgay(null, 0, int.MaxValue , maQuanLy, tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraCoiThi_ThongKeChiTietTheoNgay' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeChiTietTheoNgay(int start, int pageLength, System.String maQuanLy, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return ThongKeChiTietTheoNgay(null, start, pageLength , maQuanLy, tuNgay, denNgay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThanhTraCoiThi_ThongKeChiTietTheoNgay' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeChiTietTheoNgay(TransactionManager transactionManager, System.String maQuanLy, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return ThongKeChiTietTheoNgay(transactionManager, 0, int.MaxValue , maQuanLy, tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraCoiThi_ThongKeChiTietTheoNgay' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeChiTietTheoNgay(TransactionManager transactionManager, int start, int pageLength , System.String maQuanLy, System.DateTime tuNgay, System.DateTime denNgay);
		
		#endregion
		
		#region cust_ThanhTraCoiThi_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraCoiThi_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, ref System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraCoiThi_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, ref System.Int32 reVal)
		{
			 Luu(null, start, pageLength , xmlData, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThanhTraCoiThi_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, ref System.Int32 reVal)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraCoiThi_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ThanhTraCoiThi&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ThanhTraCoiThi&gt;"/></returns>
		public static TList<ThanhTraCoiThi> Fill(IDataReader reader, TList<ThanhTraCoiThi> rows, int start, int pageLength)
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
				
				PMS.Entities.ThanhTraCoiThi c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ThanhTraCoiThi")
					.Append("|").Append((System.Int32)reader[((int)ThanhTraCoiThiColumn.Examination - 1)])
					.Append("|").Append((System.String)reader[((int)ThanhTraCoiThiColumn.MaCanBoCoiThi - 1)]).ToString();
					c = EntityManager.LocateOrCreate<ThanhTraCoiThi>(
					key.ToString(), // EntityTrackingKey
					"ThanhTraCoiThi",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.ThanhTraCoiThi();
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
					c.Examination = (System.Int32)reader[(ThanhTraCoiThiColumn.Examination.ToString())];
					c.OriginalExamination = c.Examination;
					c.MaCanBoCoiThi = (System.String)reader[(ThanhTraCoiThiColumn.MaCanBoCoiThi.ToString())];
					c.OriginalMaCanBoCoiThi = c.MaCanBoCoiThi;
					c.NgayThi = (reader[ThanhTraCoiThiColumn.NgayThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraCoiThiColumn.NgayThi.ToString())];
					c.ThoiGianBatDau = (reader[ThanhTraCoiThiColumn.ThoiGianBatDau.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraCoiThiColumn.ThoiGianBatDau.ToString())];
					c.MaPhong = (reader[ThanhTraCoiThiColumn.MaPhong.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraCoiThiColumn.MaPhong.ToString())];
					c.MaLopHocPhan = (reader[ThanhTraCoiThiColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraCoiThiColumn.MaLopHocPhan.ToString())];
					c.MaMonHoc = (reader[ThanhTraCoiThiColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraCoiThiColumn.MaMonHoc.ToString())];
					c.TenMonHoc = (reader[ThanhTraCoiThiColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraCoiThiColumn.TenMonHoc.ToString())];
					c.ThoiGianLamBai = (reader[ThanhTraCoiThiColumn.ThoiGianLamBai.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraCoiThiColumn.ThoiGianLamBai.ToString())];
					c.TietBatDau = (reader[ThanhTraCoiThiColumn.TietBatDau.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThanhTraCoiThiColumn.TietBatDau.ToString())];
					c.MaLopSinhVien = (reader[ThanhTraCoiThiColumn.MaLopSinhVien.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraCoiThiColumn.MaLopSinhVien.ToString())];
					c.SoLuongSinhVien = (reader[ThanhTraCoiThiColumn.SoLuongSinhVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThanhTraCoiThiColumn.SoLuongSinhVien.ToString())];
					c.MaViPham = (reader[ThanhTraCoiThiColumn.MaViPham.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraCoiThiColumn.MaViPham.ToString())];
					c.MaHinhThucViPhamHrm = (reader[ThanhTraCoiThiColumn.MaHinhThucViPhamHrm.ToString()] == DBNull.Value) ? null : (System.Guid?)reader[(ThanhTraCoiThiColumn.MaHinhThucViPhamHrm.ToString())];
					c.SiSoThanhTra = (reader[ThanhTraCoiThiColumn.SiSoThanhTra.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThanhTraCoiThiColumn.SiSoThanhTra.ToString())];
					c.ThoiDiemGhiNhan = (reader[ThanhTraCoiThiColumn.ThoiDiemGhiNhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraCoiThiColumn.ThoiDiemGhiNhan.ToString())];
					c.LyDo = (reader[ThanhTraCoiThiColumn.LyDo.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraCoiThiColumn.LyDo.ToString())];
					c.GhiChu = (reader[ThanhTraCoiThiColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraCoiThiColumn.GhiChu.ToString())];
					c.NgayCapNhat = (reader[ThanhTraCoiThiColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraCoiThiColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[ThanhTraCoiThiColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraCoiThiColumn.NguoiCapNhat.ToString())];
					c.XacNhan = (reader[ThanhTraCoiThiColumn.XacNhan.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ThanhTraCoiThiColumn.XacNhan.ToString())];
					c.MaLoaiHocPhan = (reader[ThanhTraCoiThiColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThanhTraCoiThiColumn.MaLoaiHocPhan.ToString())];
					c.SoTiet = (reader[ThanhTraCoiThiColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThanhTraCoiThiColumn.SoTiet.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThanhTraCoiThi"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThanhTraCoiThi"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.ThanhTraCoiThi entity)
		{
			if (!reader.Read()) return;
			
			entity.Examination = (System.Int32)reader[(ThanhTraCoiThiColumn.Examination.ToString())];
			entity.OriginalExamination = (System.Int32)reader["Examination"];
			entity.MaCanBoCoiThi = (System.String)reader[(ThanhTraCoiThiColumn.MaCanBoCoiThi.ToString())];
			entity.OriginalMaCanBoCoiThi = (System.String)reader["MaCanBoCoiThi"];
			entity.NgayThi = (reader[ThanhTraCoiThiColumn.NgayThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraCoiThiColumn.NgayThi.ToString())];
			entity.ThoiGianBatDau = (reader[ThanhTraCoiThiColumn.ThoiGianBatDau.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraCoiThiColumn.ThoiGianBatDau.ToString())];
			entity.MaPhong = (reader[ThanhTraCoiThiColumn.MaPhong.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraCoiThiColumn.MaPhong.ToString())];
			entity.MaLopHocPhan = (reader[ThanhTraCoiThiColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraCoiThiColumn.MaLopHocPhan.ToString())];
			entity.MaMonHoc = (reader[ThanhTraCoiThiColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraCoiThiColumn.MaMonHoc.ToString())];
			entity.TenMonHoc = (reader[ThanhTraCoiThiColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraCoiThiColumn.TenMonHoc.ToString())];
			entity.ThoiGianLamBai = (reader[ThanhTraCoiThiColumn.ThoiGianLamBai.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraCoiThiColumn.ThoiGianLamBai.ToString())];
			entity.TietBatDau = (reader[ThanhTraCoiThiColumn.TietBatDau.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThanhTraCoiThiColumn.TietBatDau.ToString())];
			entity.MaLopSinhVien = (reader[ThanhTraCoiThiColumn.MaLopSinhVien.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraCoiThiColumn.MaLopSinhVien.ToString())];
			entity.SoLuongSinhVien = (reader[ThanhTraCoiThiColumn.SoLuongSinhVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThanhTraCoiThiColumn.SoLuongSinhVien.ToString())];
			entity.MaViPham = (reader[ThanhTraCoiThiColumn.MaViPham.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraCoiThiColumn.MaViPham.ToString())];
			entity.MaHinhThucViPhamHrm = (reader[ThanhTraCoiThiColumn.MaHinhThucViPhamHrm.ToString()] == DBNull.Value) ? null : (System.Guid?)reader[(ThanhTraCoiThiColumn.MaHinhThucViPhamHrm.ToString())];
			entity.SiSoThanhTra = (reader[ThanhTraCoiThiColumn.SiSoThanhTra.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThanhTraCoiThiColumn.SiSoThanhTra.ToString())];
			entity.ThoiDiemGhiNhan = (reader[ThanhTraCoiThiColumn.ThoiDiemGhiNhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraCoiThiColumn.ThoiDiemGhiNhan.ToString())];
			entity.LyDo = (reader[ThanhTraCoiThiColumn.LyDo.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraCoiThiColumn.LyDo.ToString())];
			entity.GhiChu = (reader[ThanhTraCoiThiColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraCoiThiColumn.GhiChu.ToString())];
			entity.NgayCapNhat = (reader[ThanhTraCoiThiColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraCoiThiColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[ThanhTraCoiThiColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraCoiThiColumn.NguoiCapNhat.ToString())];
			entity.XacNhan = (reader[ThanhTraCoiThiColumn.XacNhan.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ThanhTraCoiThiColumn.XacNhan.ToString())];
			entity.MaLoaiHocPhan = (reader[ThanhTraCoiThiColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThanhTraCoiThiColumn.MaLoaiHocPhan.ToString())];
			entity.SoTiet = (reader[ThanhTraCoiThiColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThanhTraCoiThiColumn.SoTiet.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThanhTraCoiThi"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThanhTraCoiThi"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.ThanhTraCoiThi entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Examination = (System.Int32)dataRow["Examination"];
			entity.OriginalExamination = (System.Int32)dataRow["Examination"];
			entity.MaCanBoCoiThi = (System.String)dataRow["MaCanBoCoiThi"];
			entity.OriginalMaCanBoCoiThi = (System.String)dataRow["MaCanBoCoiThi"];
			entity.NgayThi = Convert.IsDBNull(dataRow["NgayThi"]) ? null : (System.String)dataRow["NgayThi"];
			entity.ThoiGianBatDau = Convert.IsDBNull(dataRow["ThoiGianBatDau"]) ? null : (System.String)dataRow["ThoiGianBatDau"];
			entity.MaPhong = Convert.IsDBNull(dataRow["MaPhong"]) ? null : (System.String)dataRow["MaPhong"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = Convert.IsDBNull(dataRow["TenMonHoc"]) ? null : (System.String)dataRow["TenMonHoc"];
			entity.ThoiGianLamBai = Convert.IsDBNull(dataRow["ThoiGianLamBai"]) ? null : (System.String)dataRow["ThoiGianLamBai"];
			entity.TietBatDau = Convert.IsDBNull(dataRow["TietBatDau"]) ? null : (System.Int32?)dataRow["TietBatDau"];
			entity.MaLopSinhVien = Convert.IsDBNull(dataRow["MaLopSinhVien"]) ? null : (System.String)dataRow["MaLopSinhVien"];
			entity.SoLuongSinhVien = Convert.IsDBNull(dataRow["SoLuongSinhVien"]) ? null : (System.Int32?)dataRow["SoLuongSinhVien"];
			entity.MaViPham = Convert.IsDBNull(dataRow["MaViPham"]) ? null : (System.String)dataRow["MaViPham"];
			entity.MaHinhThucViPhamHrm = Convert.IsDBNull(dataRow["MaHinhThucViPhamHrm"]) ? null : (System.Guid?)dataRow["MaHinhThucViPhamHrm"];
			entity.SiSoThanhTra = Convert.IsDBNull(dataRow["SiSoThanhTra"]) ? null : (System.Int32?)dataRow["SiSoThanhTra"];
			entity.ThoiDiemGhiNhan = Convert.IsDBNull(dataRow["ThoiDiemGhiNhan"]) ? null : (System.String)dataRow["ThoiDiemGhiNhan"];
			entity.LyDo = Convert.IsDBNull(dataRow["LyDo"]) ? null : (System.String)dataRow["LyDo"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.XacNhan = Convert.IsDBNull(dataRow["XacNhan"]) ? null : (System.Boolean?)dataRow["XacNhan"];
			entity.MaLoaiHocPhan = Convert.IsDBNull(dataRow["MaLoaiHocPhan"]) ? null : (System.Int32?)dataRow["MaLoaiHocPhan"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Int32?)dataRow["SoTiet"];
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
		/// <param name="entity">The <see cref="PMS.Entities.ThanhTraCoiThi"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.ThanhTraCoiThi Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.ThanhTraCoiThi entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.ThanhTraCoiThi object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.ThanhTraCoiThi instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.ThanhTraCoiThi Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.ThanhTraCoiThi entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region ThanhTraCoiThiChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.ThanhTraCoiThi</c>
	///</summary>
	public enum ThanhTraCoiThiChildEntityTypes
	{
	}
	
	#endregion ThanhTraCoiThiChildEntityTypes
	
	#region ThanhTraCoiThiFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ThanhTraCoiThiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThanhTraCoiThi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThanhTraCoiThiFilterBuilder : SqlFilterBuilder<ThanhTraCoiThiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThanhTraCoiThiFilterBuilder class.
		/// </summary>
		public ThanhTraCoiThiFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThanhTraCoiThiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThanhTraCoiThiFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThanhTraCoiThiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThanhTraCoiThiFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThanhTraCoiThiFilterBuilder
	
	#region ThanhTraCoiThiParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ThanhTraCoiThiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThanhTraCoiThi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThanhTraCoiThiParameterBuilder : ParameterizedSqlFilterBuilder<ThanhTraCoiThiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThanhTraCoiThiParameterBuilder class.
		/// </summary>
		public ThanhTraCoiThiParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThanhTraCoiThiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThanhTraCoiThiParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThanhTraCoiThiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThanhTraCoiThiParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThanhTraCoiThiParameterBuilder
	
	#region ThanhTraCoiThiSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ThanhTraCoiThiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThanhTraCoiThi"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ThanhTraCoiThiSortBuilder : SqlSortBuilder<ThanhTraCoiThiColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThanhTraCoiThiSqlSortBuilder class.
		/// </summary>
		public ThanhTraCoiThiSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ThanhTraCoiThiSortBuilder
	
} // end namespace
