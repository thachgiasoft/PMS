#region Using directives

using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using PMS.Entities;
using PMS.Data;

#endregion

namespace PMS.Data.Bases
{	
	///<summary>
	/// This class is the base class for any <see cref="ViewPhuTroiProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewPhuTroiProviderBaseCore : EntityViewProviderBase<ViewPhuTroi>
	{
		#region Custom Methods
		
		
		#region cust_View_PhuTroi_GetByMaGiangVien
		
		/// <summary>
		///	This method wrap the 'cust_View_PhuTroi_GetByMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewPhuTroi&gt;"/> instance.</returns>
		public VList<ViewPhuTroi> GetByMaGiangVien(System.String maGiangVien)
		{
			return GetByMaGiangVien(null, 0, int.MaxValue , maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_PhuTroi_GetByMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewPhuTroi&gt;"/> instance.</returns>
		public VList<ViewPhuTroi> GetByMaGiangVien(int start, int pageLength, System.String maGiangVien)
		{
			return GetByMaGiangVien(null, start, pageLength , maGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_PhuTroi_GetByMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewPhuTroi&gt;"/> instance.</returns>
		public VList<ViewPhuTroi> GetByMaGiangVien(TransactionManager transactionManager, System.String maGiangVien)
		{
			return GetByMaGiangVien(transactionManager, 0, int.MaxValue , maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_PhuTroi_GetByMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewPhuTroi&gt;"/> instance.</returns>
		public abstract VList<ViewPhuTroi> GetByMaGiangVien(TransactionManager transactionManager, int start, int pageLength, System.String maGiangVien);
		
		#endregion

		
		#region cust_View_PhuTroi_GetByNamHocMaLoaiGiangVienMaBoMon
		
		/// <summary>
		///	This method wrap the 'cust_View_PhuTroi_GetByNamHocMaLoaiGiangVienMaBoMon' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maLoaiGiangvien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maBoMon"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewPhuTroi&gt;"/> instance.</returns>
		public VList<ViewPhuTroi> GetByNamHocMaLoaiGiangVienMaBoMon(System.DateTime tuNgay, System.DateTime denNgay, System.Int32 maLoaiGiangvien, System.String maBoMon)
		{
			return GetByNamHocMaLoaiGiangVienMaBoMon(null, 0, int.MaxValue , tuNgay, denNgay, maLoaiGiangvien, maBoMon);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_PhuTroi_GetByNamHocMaLoaiGiangVienMaBoMon' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maLoaiGiangvien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewPhuTroi&gt;"/> instance.</returns>
		public VList<ViewPhuTroi> GetByNamHocMaLoaiGiangVienMaBoMon(int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay, System.Int32 maLoaiGiangvien, System.String maBoMon)
		{
			return GetByNamHocMaLoaiGiangVienMaBoMon(null, start, pageLength , tuNgay, denNgay, maLoaiGiangvien, maBoMon);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_PhuTroi_GetByNamHocMaLoaiGiangVienMaBoMon' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maLoaiGiangvien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maBoMon"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewPhuTroi&gt;"/> instance.</returns>
		public VList<ViewPhuTroi> GetByNamHocMaLoaiGiangVienMaBoMon(TransactionManager transactionManager, System.DateTime tuNgay, System.DateTime denNgay, System.Int32 maLoaiGiangvien, System.String maBoMon)
		{
			return GetByNamHocMaLoaiGiangVienMaBoMon(transactionManager, 0, int.MaxValue , tuNgay, denNgay, maLoaiGiangvien, maBoMon);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_PhuTroi_GetByNamHocMaLoaiGiangVienMaBoMon' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maLoaiGiangvien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewPhuTroi&gt;"/> instance.</returns>
		public abstract VList<ViewPhuTroi> GetByNamHocMaLoaiGiangVienMaBoMon(TransactionManager transactionManager, int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay, System.Int32 maLoaiGiangvien, System.String maBoMon);
		
		#endregion

		
		#region cust_View_PhuTroi_NamHoc_GetByTuNgayDenNgay
		
		/// <summary>
		///	This method wrap the 'cust_View_PhuTroi_NamHoc_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader NamHoc_GetByTuNgayDenNgay(System.DateTime tuNgay, System.DateTime denNgay, System.String maDonVi, System.Int32 maLoaiGiangVien)
		{
			return NamHoc_GetByTuNgayDenNgay(null, 0, int.MaxValue , tuNgay, denNgay, maDonVi, maLoaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_PhuTroi_NamHoc_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader NamHoc_GetByTuNgayDenNgay(int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay, System.String maDonVi, System.Int32 maLoaiGiangVien)
		{
			return NamHoc_GetByTuNgayDenNgay(null, start, pageLength , tuNgay, denNgay, maDonVi, maLoaiGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_PhuTroi_NamHoc_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader NamHoc_GetByTuNgayDenNgay(TransactionManager transactionManager, System.DateTime tuNgay, System.DateTime denNgay, System.String maDonVi, System.Int32 maLoaiGiangVien)
		{
			return NamHoc_GetByTuNgayDenNgay(transactionManager, 0, int.MaxValue , tuNgay, denNgay, maDonVi, maLoaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_PhuTroi_NamHoc_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader NamHoc_GetByTuNgayDenNgay(TransactionManager transactionManager, int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay, System.String maDonVi, System.Int32 maLoaiGiangVien);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewPhuTroi&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewPhuTroi&gt;"/></returns>
		protected static VList&lt;ViewPhuTroi&gt; Fill(DataSet dataSet, VList<ViewPhuTroi> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewPhuTroi>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewPhuTroi&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewPhuTroi>"/></returns>
		protected static VList&lt;ViewPhuTroi&gt; Fill(DataTable dataTable, VList<ViewPhuTroi> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewPhuTroi c = new ViewPhuTroi();
					c.MaCauHinhChotGio = (Convert.IsDBNull(row["MaCauHinhChotGio"]))?(int)0:(System.Int32)row["MaCauHinhChotGio"];
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?string.Empty:(System.String)row["MaGiangVien"];
					c.MaChotGio = (Convert.IsDBNull(row["MaChotGio"]))?(int)0:(System.Int32?)row["MaChotGio"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.MaKhoa = (Convert.IsDBNull(row["MaKhoa"]))?string.Empty:(System.String)row["MaKhoa"];
					c.MaBoMon = (Convert.IsDBNull(row["MaBoMon"]))?string.Empty:(System.String)row["MaBoMon"];
					c.TenKhoa = (Convert.IsDBNull(row["TenKhoa"]))?string.Empty:(System.String)row["TenKhoa"];
					c.TenBoMon = (Convert.IsDBNull(row["TenBoMon"]))?string.Empty:(System.String)row["TenBoMon"];
					c.MaLoaiGiangVien = (Convert.IsDBNull(row["MaLoaiGiangVien"]))?(int)0:(System.Int32)row["MaLoaiGiangVien"];
					c.TenLoaiGiangVien = (Convert.IsDBNull(row["TenLoaiGiangVien"]))?string.Empty:(System.String)row["TenLoaiGiangVien"];
					c.MaBacDaoTao = (Convert.IsDBNull(row["MaBacDaoTao"]))?string.Empty:(System.String)row["MaBacDaoTao"];
					c.MaHeDaoTao = (Convert.IsDBNull(row["MaHeDaoTao"]))?string.Empty:(System.String)row["MaHeDaoTao"];
					c.TuNgay = (Convert.IsDBNull(row["TuNgay"]))?DateTime.MinValue:(System.DateTime?)row["TuNgay"];
					c.DenNgay = (Convert.IsDBNull(row["DenNgay"]))?DateTime.MinValue:(System.DateTime?)row["DenNgay"];
					c.TenQuanLy = (Convert.IsDBNull(row["TenQuanLy"]))?string.Empty:(System.String)row["TenQuanLy"];
					c.MaChucVu = (Convert.IsDBNull(row["MaChucVu"]))?string.Empty:(System.String)row["MaChucVu"];
					c.TenChucVu = (Convert.IsDBNull(row["TenChucVu"]))?string.Empty:(System.String)row["TenChucVu"];
					c.TietNghiaVu = (Convert.IsDBNull(row["TietNghiaVu"]))?(int)0:(System.Int32)row["TietNghiaVu"];
					c.Nckh = (Convert.IsDBNull(row["Nckh"]))?0.0m:(System.Decimal)row["Nckh"];
					c.NhiemVuKhac = (Convert.IsDBNull(row["NhiemVuKhac"]))?0.0m:(System.Decimal)row["NhiemVuKhac"];
					c.GioChuan = (Convert.IsDBNull(row["GioChuan"]))?0.0m:(System.Decimal)row["GioChuan"];
					c.TietThucDayCd = (Convert.IsDBNull(row["TietThucDayCD"]))?0.0m:(System.Decimal)row["TietThucDayCD"];
					c.TietThucDayTc = (Convert.IsDBNull(row["TietThucDayTC"]))?0.0m:(System.Decimal)row["TietThucDayTC"];
					c.TietQuyDoiCd = (Convert.IsDBNull(row["TietQuyDoiCD"]))?0.0m:(System.Decimal)row["TietQuyDoiCD"];
					c.TietQuyDoiTc = (Convert.IsDBNull(row["TietQuyDoiTC"]))?0.0m:(System.Decimal)row["TietQuyDoiTC"];
					c.TcQuyDoi = (Convert.IsDBNull(row["TCQuyDoi"]))?0.0m:(System.Decimal)row["TCQuyDoi"];
					c.AcceptChanges();
					rows.Add(c);
					pagelen -= 1;
				}
				recordnum += 1;
			}
			return rows;
		}
		*/	
						
		///<summary>
		/// Fill an <see cref="VList&lt;ViewPhuTroi&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewPhuTroi&gt;"/></returns>
		protected VList<ViewPhuTroi> Fill(IDataReader reader, VList<ViewPhuTroi> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewPhuTroi entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewPhuTroi>("ViewPhuTroi",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewPhuTroi();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaCauHinhChotGio = (System.Int32)reader[((int)ViewPhuTroiColumn.MaCauHinhChotGio)];
					//entity.MaCauHinhChotGio = (Convert.IsDBNull(reader["MaCauHinhChotGio"]))?(int)0:(System.Int32)reader["MaCauHinhChotGio"];
					entity.MaGiangVien = (reader.IsDBNull(((int)ViewPhuTroiColumn.MaGiangVien)))?null:(System.String)reader[((int)ViewPhuTroiColumn.MaGiangVien)];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?string.Empty:(System.String)reader["MaGiangVien"];
					entity.MaChotGio = (reader.IsDBNull(((int)ViewPhuTroiColumn.MaChotGio)))?null:(System.Int32?)reader[((int)ViewPhuTroiColumn.MaChotGio)];
					//entity.MaChotGio = (Convert.IsDBNull(reader["MaChotGio"]))?(int)0:(System.Int32?)reader["MaChotGio"];
					entity.HoTen = (reader.IsDBNull(((int)ViewPhuTroiColumn.HoTen)))?null:(System.String)reader[((int)ViewPhuTroiColumn.HoTen)];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.MaKhoa = (reader.IsDBNull(((int)ViewPhuTroiColumn.MaKhoa)))?null:(System.String)reader[((int)ViewPhuTroiColumn.MaKhoa)];
					//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
					entity.MaBoMon = (System.String)reader[((int)ViewPhuTroiColumn.MaBoMon)];
					//entity.MaBoMon = (Convert.IsDBNull(reader["MaBoMon"]))?string.Empty:(System.String)reader["MaBoMon"];
					entity.TenKhoa = (reader.IsDBNull(((int)ViewPhuTroiColumn.TenKhoa)))?null:(System.String)reader[((int)ViewPhuTroiColumn.TenKhoa)];
					//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
					entity.TenBoMon = (System.String)reader[((int)ViewPhuTroiColumn.TenBoMon)];
					//entity.TenBoMon = (Convert.IsDBNull(reader["TenBoMon"]))?string.Empty:(System.String)reader["TenBoMon"];
					entity.MaLoaiGiangVien = (System.Int32)reader[((int)ViewPhuTroiColumn.MaLoaiGiangVien)];
					//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32)reader["MaLoaiGiangVien"];
					entity.TenLoaiGiangVien = (reader.IsDBNull(((int)ViewPhuTroiColumn.TenLoaiGiangVien)))?null:(System.String)reader[((int)ViewPhuTroiColumn.TenLoaiGiangVien)];
					//entity.TenLoaiGiangVien = (Convert.IsDBNull(reader["TenLoaiGiangVien"]))?string.Empty:(System.String)reader["TenLoaiGiangVien"];
					entity.MaBacDaoTao = (reader.IsDBNull(((int)ViewPhuTroiColumn.MaBacDaoTao)))?null:(System.String)reader[((int)ViewPhuTroiColumn.MaBacDaoTao)];
					//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
					entity.MaHeDaoTao = (reader.IsDBNull(((int)ViewPhuTroiColumn.MaHeDaoTao)))?null:(System.String)reader[((int)ViewPhuTroiColumn.MaHeDaoTao)];
					//entity.MaHeDaoTao = (Convert.IsDBNull(reader["MaHeDaoTao"]))?string.Empty:(System.String)reader["MaHeDaoTao"];
					entity.TuNgay = (reader.IsDBNull(((int)ViewPhuTroiColumn.TuNgay)))?null:(System.DateTime?)reader[((int)ViewPhuTroiColumn.TuNgay)];
					//entity.TuNgay = (Convert.IsDBNull(reader["TuNgay"]))?DateTime.MinValue:(System.DateTime?)reader["TuNgay"];
					entity.DenNgay = (reader.IsDBNull(((int)ViewPhuTroiColumn.DenNgay)))?null:(System.DateTime?)reader[((int)ViewPhuTroiColumn.DenNgay)];
					//entity.DenNgay = (Convert.IsDBNull(reader["DenNgay"]))?DateTime.MinValue:(System.DateTime?)reader["DenNgay"];
					entity.TenQuanLy = (reader.IsDBNull(((int)ViewPhuTroiColumn.TenQuanLy)))?null:(System.String)reader[((int)ViewPhuTroiColumn.TenQuanLy)];
					//entity.TenQuanLy = (Convert.IsDBNull(reader["TenQuanLy"]))?string.Empty:(System.String)reader["TenQuanLy"];
					entity.MaChucVu = (System.String)reader[((int)ViewPhuTroiColumn.MaChucVu)];
					//entity.MaChucVu = (Convert.IsDBNull(reader["MaChucVu"]))?string.Empty:(System.String)reader["MaChucVu"];
					entity.TenChucVu = (System.String)reader[((int)ViewPhuTroiColumn.TenChucVu)];
					//entity.TenChucVu = (Convert.IsDBNull(reader["TenChucVu"]))?string.Empty:(System.String)reader["TenChucVu"];
					entity.TietNghiaVu = (System.Int32)reader[((int)ViewPhuTroiColumn.TietNghiaVu)];
					//entity.TietNghiaVu = (Convert.IsDBNull(reader["TietNghiaVu"]))?(int)0:(System.Int32)reader["TietNghiaVu"];
					entity.Nckh = (System.Decimal)reader[((int)ViewPhuTroiColumn.Nckh)];
					//entity.Nckh = (Convert.IsDBNull(reader["Nckh"]))?0.0m:(System.Decimal)reader["Nckh"];
					entity.NhiemVuKhac = (System.Decimal)reader[((int)ViewPhuTroiColumn.NhiemVuKhac)];
					//entity.NhiemVuKhac = (Convert.IsDBNull(reader["NhiemVuKhac"]))?0.0m:(System.Decimal)reader["NhiemVuKhac"];
					entity.GioChuan = (System.Decimal)reader[((int)ViewPhuTroiColumn.GioChuan)];
					//entity.GioChuan = (Convert.IsDBNull(reader["GioChuan"]))?0.0m:(System.Decimal)reader["GioChuan"];
					entity.TietThucDayCd = (System.Decimal)reader[((int)ViewPhuTroiColumn.TietThucDayCd)];
					//entity.TietThucDayCd = (Convert.IsDBNull(reader["TietThucDayCD"]))?0.0m:(System.Decimal)reader["TietThucDayCD"];
					entity.TietThucDayTc = (System.Decimal)reader[((int)ViewPhuTroiColumn.TietThucDayTc)];
					//entity.TietThucDayTc = (Convert.IsDBNull(reader["TietThucDayTC"]))?0.0m:(System.Decimal)reader["TietThucDayTC"];
					entity.TietQuyDoiCd = (System.Decimal)reader[((int)ViewPhuTroiColumn.TietQuyDoiCd)];
					//entity.TietQuyDoiCd = (Convert.IsDBNull(reader["TietQuyDoiCD"]))?0.0m:(System.Decimal)reader["TietQuyDoiCD"];
					entity.TietQuyDoiTc = (System.Decimal)reader[((int)ViewPhuTroiColumn.TietQuyDoiTc)];
					//entity.TietQuyDoiTc = (Convert.IsDBNull(reader["TietQuyDoiTC"]))?0.0m:(System.Decimal)reader["TietQuyDoiTC"];
					entity.TcQuyDoi = (System.Decimal)reader[((int)ViewPhuTroiColumn.TcQuyDoi)];
					//entity.TcQuyDoi = (Convert.IsDBNull(reader["TCQuyDoi"]))?0.0m:(System.Decimal)reader["TCQuyDoi"];
					entity.AcceptChanges();
					entity.SuppressEntityEvents = false;
					
					rows.Add(entity);
					pageLength -= 1;
				}
				recordnum += 1;
			}
			return rows;
		}
		
		
		/// <summary>
		/// Refreshes the <see cref="ViewPhuTroi"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewPhuTroi"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewPhuTroi entity)
		{
			reader.Read();
			entity.MaCauHinhChotGio = (System.Int32)reader[((int)ViewPhuTroiColumn.MaCauHinhChotGio)];
			//entity.MaCauHinhChotGio = (Convert.IsDBNull(reader["MaCauHinhChotGio"]))?(int)0:(System.Int32)reader["MaCauHinhChotGio"];
			entity.MaGiangVien = (reader.IsDBNull(((int)ViewPhuTroiColumn.MaGiangVien)))?null:(System.String)reader[((int)ViewPhuTroiColumn.MaGiangVien)];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?string.Empty:(System.String)reader["MaGiangVien"];
			entity.MaChotGio = (reader.IsDBNull(((int)ViewPhuTroiColumn.MaChotGio)))?null:(System.Int32?)reader[((int)ViewPhuTroiColumn.MaChotGio)];
			//entity.MaChotGio = (Convert.IsDBNull(reader["MaChotGio"]))?(int)0:(System.Int32?)reader["MaChotGio"];
			entity.HoTen = (reader.IsDBNull(((int)ViewPhuTroiColumn.HoTen)))?null:(System.String)reader[((int)ViewPhuTroiColumn.HoTen)];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.MaKhoa = (reader.IsDBNull(((int)ViewPhuTroiColumn.MaKhoa)))?null:(System.String)reader[((int)ViewPhuTroiColumn.MaKhoa)];
			//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
			entity.MaBoMon = (System.String)reader[((int)ViewPhuTroiColumn.MaBoMon)];
			//entity.MaBoMon = (Convert.IsDBNull(reader["MaBoMon"]))?string.Empty:(System.String)reader["MaBoMon"];
			entity.TenKhoa = (reader.IsDBNull(((int)ViewPhuTroiColumn.TenKhoa)))?null:(System.String)reader[((int)ViewPhuTroiColumn.TenKhoa)];
			//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
			entity.TenBoMon = (System.String)reader[((int)ViewPhuTroiColumn.TenBoMon)];
			//entity.TenBoMon = (Convert.IsDBNull(reader["TenBoMon"]))?string.Empty:(System.String)reader["TenBoMon"];
			entity.MaLoaiGiangVien = (System.Int32)reader[((int)ViewPhuTroiColumn.MaLoaiGiangVien)];
			//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32)reader["MaLoaiGiangVien"];
			entity.TenLoaiGiangVien = (reader.IsDBNull(((int)ViewPhuTroiColumn.TenLoaiGiangVien)))?null:(System.String)reader[((int)ViewPhuTroiColumn.TenLoaiGiangVien)];
			//entity.TenLoaiGiangVien = (Convert.IsDBNull(reader["TenLoaiGiangVien"]))?string.Empty:(System.String)reader["TenLoaiGiangVien"];
			entity.MaBacDaoTao = (reader.IsDBNull(((int)ViewPhuTroiColumn.MaBacDaoTao)))?null:(System.String)reader[((int)ViewPhuTroiColumn.MaBacDaoTao)];
			//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
			entity.MaHeDaoTao = (reader.IsDBNull(((int)ViewPhuTroiColumn.MaHeDaoTao)))?null:(System.String)reader[((int)ViewPhuTroiColumn.MaHeDaoTao)];
			//entity.MaHeDaoTao = (Convert.IsDBNull(reader["MaHeDaoTao"]))?string.Empty:(System.String)reader["MaHeDaoTao"];
			entity.TuNgay = (reader.IsDBNull(((int)ViewPhuTroiColumn.TuNgay)))?null:(System.DateTime?)reader[((int)ViewPhuTroiColumn.TuNgay)];
			//entity.TuNgay = (Convert.IsDBNull(reader["TuNgay"]))?DateTime.MinValue:(System.DateTime?)reader["TuNgay"];
			entity.DenNgay = (reader.IsDBNull(((int)ViewPhuTroiColumn.DenNgay)))?null:(System.DateTime?)reader[((int)ViewPhuTroiColumn.DenNgay)];
			//entity.DenNgay = (Convert.IsDBNull(reader["DenNgay"]))?DateTime.MinValue:(System.DateTime?)reader["DenNgay"];
			entity.TenQuanLy = (reader.IsDBNull(((int)ViewPhuTroiColumn.TenQuanLy)))?null:(System.String)reader[((int)ViewPhuTroiColumn.TenQuanLy)];
			//entity.TenQuanLy = (Convert.IsDBNull(reader["TenQuanLy"]))?string.Empty:(System.String)reader["TenQuanLy"];
			entity.MaChucVu = (System.String)reader[((int)ViewPhuTroiColumn.MaChucVu)];
			//entity.MaChucVu = (Convert.IsDBNull(reader["MaChucVu"]))?string.Empty:(System.String)reader["MaChucVu"];
			entity.TenChucVu = (System.String)reader[((int)ViewPhuTroiColumn.TenChucVu)];
			//entity.TenChucVu = (Convert.IsDBNull(reader["TenChucVu"]))?string.Empty:(System.String)reader["TenChucVu"];
			entity.TietNghiaVu = (System.Int32)reader[((int)ViewPhuTroiColumn.TietNghiaVu)];
			//entity.TietNghiaVu = (Convert.IsDBNull(reader["TietNghiaVu"]))?(int)0:(System.Int32)reader["TietNghiaVu"];
			entity.Nckh = (System.Decimal)reader[((int)ViewPhuTroiColumn.Nckh)];
			//entity.Nckh = (Convert.IsDBNull(reader["Nckh"]))?0.0m:(System.Decimal)reader["Nckh"];
			entity.NhiemVuKhac = (System.Decimal)reader[((int)ViewPhuTroiColumn.NhiemVuKhac)];
			//entity.NhiemVuKhac = (Convert.IsDBNull(reader["NhiemVuKhac"]))?0.0m:(System.Decimal)reader["NhiemVuKhac"];
			entity.GioChuan = (System.Decimal)reader[((int)ViewPhuTroiColumn.GioChuan)];
			//entity.GioChuan = (Convert.IsDBNull(reader["GioChuan"]))?0.0m:(System.Decimal)reader["GioChuan"];
			entity.TietThucDayCd = (System.Decimal)reader[((int)ViewPhuTroiColumn.TietThucDayCd)];
			//entity.TietThucDayCd = (Convert.IsDBNull(reader["TietThucDayCD"]))?0.0m:(System.Decimal)reader["TietThucDayCD"];
			entity.TietThucDayTc = (System.Decimal)reader[((int)ViewPhuTroiColumn.TietThucDayTc)];
			//entity.TietThucDayTc = (Convert.IsDBNull(reader["TietThucDayTC"]))?0.0m:(System.Decimal)reader["TietThucDayTC"];
			entity.TietQuyDoiCd = (System.Decimal)reader[((int)ViewPhuTroiColumn.TietQuyDoiCd)];
			//entity.TietQuyDoiCd = (Convert.IsDBNull(reader["TietQuyDoiCD"]))?0.0m:(System.Decimal)reader["TietQuyDoiCD"];
			entity.TietQuyDoiTc = (System.Decimal)reader[((int)ViewPhuTroiColumn.TietQuyDoiTc)];
			//entity.TietQuyDoiTc = (Convert.IsDBNull(reader["TietQuyDoiTC"]))?0.0m:(System.Decimal)reader["TietQuyDoiTC"];
			entity.TcQuyDoi = (System.Decimal)reader[((int)ViewPhuTroiColumn.TcQuyDoi)];
			//entity.TcQuyDoi = (Convert.IsDBNull(reader["TCQuyDoi"]))?0.0m:(System.Decimal)reader["TCQuyDoi"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewPhuTroi"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewPhuTroi"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewPhuTroi entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaCauHinhChotGio = (Convert.IsDBNull(dataRow["MaCauHinhChotGio"]))?(int)0:(System.Int32)dataRow["MaCauHinhChotGio"];
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?string.Empty:(System.String)dataRow["MaGiangVien"];
			entity.MaChotGio = (Convert.IsDBNull(dataRow["MaChotGio"]))?(int)0:(System.Int32?)dataRow["MaChotGio"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.MaKhoa = (Convert.IsDBNull(dataRow["MaKhoa"]))?string.Empty:(System.String)dataRow["MaKhoa"];
			entity.MaBoMon = (Convert.IsDBNull(dataRow["MaBoMon"]))?string.Empty:(System.String)dataRow["MaBoMon"];
			entity.TenKhoa = (Convert.IsDBNull(dataRow["TenKhoa"]))?string.Empty:(System.String)dataRow["TenKhoa"];
			entity.TenBoMon = (Convert.IsDBNull(dataRow["TenBoMon"]))?string.Empty:(System.String)dataRow["TenBoMon"];
			entity.MaLoaiGiangVien = (Convert.IsDBNull(dataRow["MaLoaiGiangVien"]))?(int)0:(System.Int32)dataRow["MaLoaiGiangVien"];
			entity.TenLoaiGiangVien = (Convert.IsDBNull(dataRow["TenLoaiGiangVien"]))?string.Empty:(System.String)dataRow["TenLoaiGiangVien"];
			entity.MaBacDaoTao = (Convert.IsDBNull(dataRow["MaBacDaoTao"]))?string.Empty:(System.String)dataRow["MaBacDaoTao"];
			entity.MaHeDaoTao = (Convert.IsDBNull(dataRow["MaHeDaoTao"]))?string.Empty:(System.String)dataRow["MaHeDaoTao"];
			entity.TuNgay = (Convert.IsDBNull(dataRow["TuNgay"]))?DateTime.MinValue:(System.DateTime?)dataRow["TuNgay"];
			entity.DenNgay = (Convert.IsDBNull(dataRow["DenNgay"]))?DateTime.MinValue:(System.DateTime?)dataRow["DenNgay"];
			entity.TenQuanLy = (Convert.IsDBNull(dataRow["TenQuanLy"]))?string.Empty:(System.String)dataRow["TenQuanLy"];
			entity.MaChucVu = (Convert.IsDBNull(dataRow["MaChucVu"]))?string.Empty:(System.String)dataRow["MaChucVu"];
			entity.TenChucVu = (Convert.IsDBNull(dataRow["TenChucVu"]))?string.Empty:(System.String)dataRow["TenChucVu"];
			entity.TietNghiaVu = (Convert.IsDBNull(dataRow["TietNghiaVu"]))?(int)0:(System.Int32)dataRow["TietNghiaVu"];
			entity.Nckh = (Convert.IsDBNull(dataRow["Nckh"]))?0.0m:(System.Decimal)dataRow["Nckh"];
			entity.NhiemVuKhac = (Convert.IsDBNull(dataRow["NhiemVuKhac"]))?0.0m:(System.Decimal)dataRow["NhiemVuKhac"];
			entity.GioChuan = (Convert.IsDBNull(dataRow["GioChuan"]))?0.0m:(System.Decimal)dataRow["GioChuan"];
			entity.TietThucDayCd = (Convert.IsDBNull(dataRow["TietThucDayCD"]))?0.0m:(System.Decimal)dataRow["TietThucDayCD"];
			entity.TietThucDayTc = (Convert.IsDBNull(dataRow["TietThucDayTC"]))?0.0m:(System.Decimal)dataRow["TietThucDayTC"];
			entity.TietQuyDoiCd = (Convert.IsDBNull(dataRow["TietQuyDoiCD"]))?0.0m:(System.Decimal)dataRow["TietQuyDoiCD"];
			entity.TietQuyDoiTc = (Convert.IsDBNull(dataRow["TietQuyDoiTC"]))?0.0m:(System.Decimal)dataRow["TietQuyDoiTC"];
			entity.TcQuyDoi = (Convert.IsDBNull(dataRow["TCQuyDoi"]))?0.0m:(System.Decimal)dataRow["TCQuyDoi"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewPhuTroiFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhuTroi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhuTroiFilterBuilder : SqlFilterBuilder<ViewPhuTroiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhuTroiFilterBuilder class.
		/// </summary>
		public ViewPhuTroiFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewPhuTroiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewPhuTroiFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewPhuTroiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewPhuTroiFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewPhuTroiFilterBuilder

	#region ViewPhuTroiParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhuTroi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhuTroiParameterBuilder : ParameterizedSqlFilterBuilder<ViewPhuTroiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhuTroiParameterBuilder class.
		/// </summary>
		public ViewPhuTroiParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewPhuTroiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewPhuTroiParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewPhuTroiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewPhuTroiParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewPhuTroiParameterBuilder
	
	#region ViewPhuTroiSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhuTroi"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewPhuTroiSortBuilder : SqlSortBuilder<ViewPhuTroiColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhuTroiSqlSortBuilder class.
		/// </summary>
		public ViewPhuTroiSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewPhuTroiSortBuilder

} // end namespace
