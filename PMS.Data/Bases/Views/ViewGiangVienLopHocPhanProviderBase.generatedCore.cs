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
	/// This class is the base class for any <see cref="ViewGiangVienLopHocPhanProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewGiangVienLopHocPhanProviderBaseCore : EntityViewProviderBase<ViewGiangVienLopHocPhan>
	{
		#region Custom Methods
		
		
		#region cust_View_GiangVien_LopHocPhan_GetByNamHocHocKyMaGiangVien
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LopHocPhan_GetByNamHocHocKyMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVienLopHocPhan&gt;"/> instance.</returns>
		public VList<ViewGiangVienLopHocPhan> GetByNamHocHocKyMaGiangVien(System.String namHoc, System.String hocKy, System.Int32 maGiangVien)
		{
			return GetByNamHocHocKyMaGiangVien(null, 0, int.MaxValue , namHoc, hocKy, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LopHocPhan_GetByNamHocHocKyMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVienLopHocPhan&gt;"/> instance.</returns>
		public VList<ViewGiangVienLopHocPhan> GetByNamHocHocKyMaGiangVien(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 maGiangVien)
		{
			return GetByNamHocHocKyMaGiangVien(null, start, pageLength , namHoc, hocKy, maGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LopHocPhan_GetByNamHocHocKyMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewGiangVienLopHocPhan&gt;"/> instance.</returns>
		public VList<ViewGiangVienLopHocPhan> GetByNamHocHocKyMaGiangVien(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 maGiangVien)
		{
			return GetByNamHocHocKyMaGiangVien(transactionManager, 0, int.MaxValue , namHoc, hocKy, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LopHocPhan_GetByNamHocHocKyMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVienLopHocPhan&gt;"/> instance.</returns>
		public abstract VList<ViewGiangVienLopHocPhan> GetByNamHocHocKyMaGiangVien(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 maGiangVien);
		
		#endregion

		
		#region cust_View_GiangVien_LopHocPhan_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LopHocPhan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVienLopHocPhan&gt;"/> instance.</returns>
		public VList<ViewGiangVienLopHocPhan> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LopHocPhan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVienLopHocPhan&gt;"/> instance.</returns>
		public VList<ViewGiangVienLopHocPhan> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LopHocPhan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewGiangVienLopHocPhan&gt;"/> instance.</returns>
		public VList<ViewGiangVienLopHocPhan> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LopHocPhan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVienLopHocPhan&gt;"/> instance.</returns>
		public abstract VList<ViewGiangVienLopHocPhan> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#region cust_View_GiangVien_LopHocPhan_GetBatDauByTuNgayDenNgay
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LopHocPhan_GetBatDauByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVienLopHocPhan&gt;"/> instance.</returns>
		public VList<ViewGiangVienLopHocPhan> GetBatDauByTuNgayDenNgay(System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetBatDauByTuNgayDenNgay(null, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LopHocPhan_GetBatDauByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVienLopHocPhan&gt;"/> instance.</returns>
		public VList<ViewGiangVienLopHocPhan> GetBatDauByTuNgayDenNgay(int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetBatDauByTuNgayDenNgay(null, start, pageLength , tuNgay, denNgay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LopHocPhan_GetBatDauByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewGiangVienLopHocPhan&gt;"/> instance.</returns>
		public VList<ViewGiangVienLopHocPhan> GetBatDauByTuNgayDenNgay(TransactionManager transactionManager, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetBatDauByTuNgayDenNgay(transactionManager, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LopHocPhan_GetBatDauByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVienLopHocPhan&gt;"/> instance.</returns>
		public abstract VList<ViewGiangVienLopHocPhan> GetBatDauByTuNgayDenNgay(TransactionManager transactionManager, int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay);
		
		#endregion

		
		#region cust_View_GiangVien_LopHocPhan_GetKetThucByTuNgayDenNgay
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LopHocPhan_GetKetThucByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVienLopHocPhan&gt;"/> instance.</returns>
		public VList<ViewGiangVienLopHocPhan> GetKetThucByTuNgayDenNgay(System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetKetThucByTuNgayDenNgay(null, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LopHocPhan_GetKetThucByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVienLopHocPhan&gt;"/> instance.</returns>
		public VList<ViewGiangVienLopHocPhan> GetKetThucByTuNgayDenNgay(int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetKetThucByTuNgayDenNgay(null, start, pageLength , tuNgay, denNgay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LopHocPhan_GetKetThucByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewGiangVienLopHocPhan&gt;"/> instance.</returns>
		public VList<ViewGiangVienLopHocPhan> GetKetThucByTuNgayDenNgay(TransactionManager transactionManager, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetKetThucByTuNgayDenNgay(transactionManager, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LopHocPhan_GetKetThucByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVienLopHocPhan&gt;"/> instance.</returns>
		public abstract VList<ViewGiangVienLopHocPhan> GetKetThucByTuNgayDenNgay(TransactionManager transactionManager, int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewGiangVienLopHocPhan&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewGiangVienLopHocPhan&gt;"/></returns>
		protected static VList&lt;ViewGiangVienLopHocPhan&gt; Fill(DataSet dataSet, VList<ViewGiangVienLopHocPhan> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewGiangVienLopHocPhan>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewGiangVienLopHocPhan&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewGiangVienLopHocPhan>"/></returns>
		protected static VList&lt;ViewGiangVienLopHocPhan&gt; Fill(DataTable dataTable, VList<ViewGiangVienLopHocPhan> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewGiangVienLopHocPhan c = new ViewGiangVienLopHocPhan();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32?)row["MaGiangVien"];
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.MaLopHocPhan = (Convert.IsDBNull(row["MaLopHocPhan"]))?string.Empty:(System.String)row["MaLopHocPhan"];
					c.MaKhoaHoc = (Convert.IsDBNull(row["MaKhoaHoc"]))?string.Empty:(System.String)row["MaKhoaHoc"];
					c.MaBacDaoTao = (Convert.IsDBNull(row["MaBacDaoTao"]))?string.Empty:(System.String)row["MaBacDaoTao"];
					c.MaLoaiHinh = (Convert.IsDBNull(row["MaLoaiHinh"]))?string.Empty:(System.String)row["MaLoaiHinh"];
					c.MaBacLoaiHinh = (Convert.IsDBNull(row["MaBacLoaiHinh"]))?string.Empty:(System.String)row["MaBacLoaiHinh"];
					c.DonGia = (Convert.IsDBNull(row["DonGia"]))?0.0m:(System.Decimal)row["DonGia"];
					c.TienThem = (Convert.IsDBNull(row["TienThem"]))?0.0m:(System.Decimal)row["TienThem"];
					c.TongCong = (Convert.IsDBNull(row["TongCong"]))?0.0m:(System.Decimal?)row["TongCong"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.NgayBatDau = (Convert.IsDBNull(row["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)row["NgayBatDau"];
					c.NgayKetThuc = (Convert.IsDBNull(row["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)row["NgayKetThuc"];
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
		/// Fill an <see cref="VList&lt;ViewGiangVienLopHocPhan&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewGiangVienLopHocPhan&gt;"/></returns>
		protected VList<ViewGiangVienLopHocPhan> Fill(IDataReader reader, VList<ViewGiangVienLopHocPhan> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewGiangVienLopHocPhan entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewGiangVienLopHocPhan>("ViewGiangVienLopHocPhan",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewGiangVienLopHocPhan();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = reader.IsDBNull(reader.GetOrdinal("MaGiangVien")) ? null : (System.Int32?)reader["MaGiangVien"];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32?)reader["MaGiangVien"];
					entity.MaQuanLy = reader.IsDBNull(reader.GetOrdinal("MaQuanLy")) ? null : (System.String)reader["MaQuanLy"];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.MaLopHocPhan = (System.String)reader["MaLopHocPhan"];
					//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
					entity.MaKhoaHoc = reader.IsDBNull(reader.GetOrdinal("MaKhoaHoc")) ? null : (System.String)reader["MaKhoaHoc"];
					//entity.MaKhoaHoc = (Convert.IsDBNull(reader["MaKhoaHoc"]))?string.Empty:(System.String)reader["MaKhoaHoc"];
					entity.MaBacDaoTao = (System.String)reader["MaBacDaoTao"];
					//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
					entity.MaLoaiHinh = (System.String)reader["MaLoaiHinh"];
					//entity.MaLoaiHinh = (Convert.IsDBNull(reader["MaLoaiHinh"]))?string.Empty:(System.String)reader["MaLoaiHinh"];
					entity.MaBacLoaiHinh = (System.String)reader["MaBacLoaiHinh"];
					//entity.MaBacLoaiHinh = (Convert.IsDBNull(reader["MaBacLoaiHinh"]))?string.Empty:(System.String)reader["MaBacLoaiHinh"];
					entity.DonGia = (System.Decimal)reader["DonGia"];
					//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal)reader["DonGia"];
					entity.TienThem = (System.Decimal)reader["TienThem"];
					//entity.TienThem = (Convert.IsDBNull(reader["TienThem"]))?0.0m:(System.Decimal)reader["TienThem"];
					entity.TongCong = reader.IsDBNull(reader.GetOrdinal("TongCong")) ? null : (System.Decimal?)reader["TongCong"];
					//entity.TongCong = (Convert.IsDBNull(reader["TongCong"]))?0.0m:(System.Decimal?)reader["TongCong"];
					entity.NamHoc = (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.NgayBatDau = reader.IsDBNull(reader.GetOrdinal("NgayBatDau")) ? null : (System.DateTime?)reader["NgayBatDau"];
					//entity.NgayBatDau = (Convert.IsDBNull(reader["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)reader["NgayBatDau"];
					entity.NgayKetThuc = reader.IsDBNull(reader.GetOrdinal("NgayKetThuc")) ? null : (System.DateTime?)reader["NgayKetThuc"];
					//entity.NgayKetThuc = (Convert.IsDBNull(reader["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKetThuc"];
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
		/// Refreshes the <see cref="ViewGiangVienLopHocPhan"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewGiangVienLopHocPhan"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewGiangVienLopHocPhan entity)
		{
			reader.Read();
			entity.MaGiangVien = reader.IsDBNull(reader.GetOrdinal("MaGiangVien")) ? null : (System.Int32?)reader["MaGiangVien"];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32?)reader["MaGiangVien"];
			entity.MaQuanLy = reader.IsDBNull(reader.GetOrdinal("MaQuanLy")) ? null : (System.String)reader["MaQuanLy"];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.MaLopHocPhan = (System.String)reader["MaLopHocPhan"];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			entity.MaKhoaHoc = reader.IsDBNull(reader.GetOrdinal("MaKhoaHoc")) ? null : (System.String)reader["MaKhoaHoc"];
			//entity.MaKhoaHoc = (Convert.IsDBNull(reader["MaKhoaHoc"]))?string.Empty:(System.String)reader["MaKhoaHoc"];
			entity.MaBacDaoTao = (System.String)reader["MaBacDaoTao"];
			//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
			entity.MaLoaiHinh = (System.String)reader["MaLoaiHinh"];
			//entity.MaLoaiHinh = (Convert.IsDBNull(reader["MaLoaiHinh"]))?string.Empty:(System.String)reader["MaLoaiHinh"];
			entity.MaBacLoaiHinh = (System.String)reader["MaBacLoaiHinh"];
			//entity.MaBacLoaiHinh = (Convert.IsDBNull(reader["MaBacLoaiHinh"]))?string.Empty:(System.String)reader["MaBacLoaiHinh"];
			entity.DonGia = (System.Decimal)reader["DonGia"];
			//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal)reader["DonGia"];
			entity.TienThem = (System.Decimal)reader["TienThem"];
			//entity.TienThem = (Convert.IsDBNull(reader["TienThem"]))?0.0m:(System.Decimal)reader["TienThem"];
			entity.TongCong = reader.IsDBNull(reader.GetOrdinal("TongCong")) ? null : (System.Decimal?)reader["TongCong"];
			//entity.TongCong = (Convert.IsDBNull(reader["TongCong"]))?0.0m:(System.Decimal?)reader["TongCong"];
			entity.NamHoc = (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.NgayBatDau = reader.IsDBNull(reader.GetOrdinal("NgayBatDau")) ? null : (System.DateTime?)reader["NgayBatDau"];
			//entity.NgayBatDau = (Convert.IsDBNull(reader["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)reader["NgayBatDau"];
			entity.NgayKetThuc = reader.IsDBNull(reader.GetOrdinal("NgayKetThuc")) ? null : (System.DateTime?)reader["NgayKetThuc"];
			//entity.NgayKetThuc = (Convert.IsDBNull(reader["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKetThuc"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewGiangVienLopHocPhan"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewGiangVienLopHocPhan"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewGiangVienLopHocPhan entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32?)dataRow["MaGiangVien"];
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.MaLopHocPhan = (Convert.IsDBNull(dataRow["MaLopHocPhan"]))?string.Empty:(System.String)dataRow["MaLopHocPhan"];
			entity.MaKhoaHoc = (Convert.IsDBNull(dataRow["MaKhoaHoc"]))?string.Empty:(System.String)dataRow["MaKhoaHoc"];
			entity.MaBacDaoTao = (Convert.IsDBNull(dataRow["MaBacDaoTao"]))?string.Empty:(System.String)dataRow["MaBacDaoTao"];
			entity.MaLoaiHinh = (Convert.IsDBNull(dataRow["MaLoaiHinh"]))?string.Empty:(System.String)dataRow["MaLoaiHinh"];
			entity.MaBacLoaiHinh = (Convert.IsDBNull(dataRow["MaBacLoaiHinh"]))?string.Empty:(System.String)dataRow["MaBacLoaiHinh"];
			entity.DonGia = (Convert.IsDBNull(dataRow["DonGia"]))?0.0m:(System.Decimal)dataRow["DonGia"];
			entity.TienThem = (Convert.IsDBNull(dataRow["TienThem"]))?0.0m:(System.Decimal)dataRow["TienThem"];
			entity.TongCong = (Convert.IsDBNull(dataRow["TongCong"]))?0.0m:(System.Decimal?)dataRow["TongCong"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.NgayBatDau = (Convert.IsDBNull(dataRow["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayBatDau"];
			entity.NgayKetThuc = (Convert.IsDBNull(dataRow["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayKetThuc"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewGiangVienLopHocPhanFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVienLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewGiangVienLopHocPhanFilterBuilder : SqlFilterBuilder<ViewGiangVienLopHocPhanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienLopHocPhanFilterBuilder class.
		/// </summary>
		public ViewGiangVienLopHocPhanFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienLopHocPhanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewGiangVienLopHocPhanFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienLopHocPhanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewGiangVienLopHocPhanFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewGiangVienLopHocPhanFilterBuilder

	#region ViewGiangVienLopHocPhanParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVienLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewGiangVienLopHocPhanParameterBuilder : ParameterizedSqlFilterBuilder<ViewGiangVienLopHocPhanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienLopHocPhanParameterBuilder class.
		/// </summary>
		public ViewGiangVienLopHocPhanParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienLopHocPhanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewGiangVienLopHocPhanParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienLopHocPhanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewGiangVienLopHocPhanParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewGiangVienLopHocPhanParameterBuilder
	
	#region ViewGiangVienLopHocPhanSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVienLopHocPhan"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewGiangVienLopHocPhanSortBuilder : SqlSortBuilder<ViewGiangVienLopHocPhanColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienLopHocPhanSqlSortBuilder class.
		/// </summary>
		public ViewGiangVienLopHocPhanSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewGiangVienLopHocPhanSortBuilder

} // end namespace
