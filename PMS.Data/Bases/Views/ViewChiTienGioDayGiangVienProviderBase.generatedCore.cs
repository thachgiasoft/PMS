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
	/// This class is the base class for any <see cref="ViewChiTienGioDayGiangVienProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewChiTienGioDayGiangVienProviderBaseCore : EntityViewProviderBase<ViewChiTienGioDayGiangVien>
	{
		#region Custom Methods
		
		
		#region cust_View_ChiTienGioDay_GiangVien_GetByTuNgayDenNgay
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTienGioDay_GiangVien_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewChiTienGioDayGiangVien&gt;"/> instance.</returns>
		public VList<ViewChiTienGioDayGiangVien> GetByTuNgayDenNgay(System.String maBacDaoTao, System.String maHeDaoTao, System.DateTime tuNgay, System.DateTime denNgay, System.Int32 maLoaiGiangVien)
		{
			return GetByTuNgayDenNgay(null, 0, int.MaxValue , maBacDaoTao, maHeDaoTao, tuNgay, denNgay, maLoaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTienGioDay_GiangVien_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewChiTienGioDayGiangVien&gt;"/> instance.</returns>
		public VList<ViewChiTienGioDayGiangVien> GetByTuNgayDenNgay(int start, int pageLength, System.String maBacDaoTao, System.String maHeDaoTao, System.DateTime tuNgay, System.DateTime denNgay, System.Int32 maLoaiGiangVien)
		{
			return GetByTuNgayDenNgay(null, start, pageLength , maBacDaoTao, maHeDaoTao, tuNgay, denNgay, maLoaiGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ChiTienGioDay_GiangVien_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewChiTienGioDayGiangVien&gt;"/> instance.</returns>
		public VList<ViewChiTienGioDayGiangVien> GetByTuNgayDenNgay(TransactionManager transactionManager, System.String maBacDaoTao, System.String maHeDaoTao, System.DateTime tuNgay, System.DateTime denNgay, System.Int32 maLoaiGiangVien)
		{
			return GetByTuNgayDenNgay(transactionManager, 0, int.MaxValue , maBacDaoTao, maHeDaoTao, tuNgay, denNgay, maLoaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTienGioDay_GiangVien_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewChiTienGioDayGiangVien&gt;"/> instance.</returns>
		public abstract VList<ViewChiTienGioDayGiangVien> GetByTuNgayDenNgay(TransactionManager transactionManager, int start, int pageLength, System.String maBacDaoTao, System.String maHeDaoTao, System.DateTime tuNgay, System.DateTime denNgay, System.Int32 maLoaiGiangVien);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewChiTienGioDayGiangVien&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewChiTienGioDayGiangVien&gt;"/></returns>
		protected static VList&lt;ViewChiTienGioDayGiangVien&gt; Fill(DataSet dataSet, VList<ViewChiTienGioDayGiangVien> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewChiTienGioDayGiangVien>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewChiTienGioDayGiangVien&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewChiTienGioDayGiangVien>"/></returns>
		protected static VList&lt;ViewChiTienGioDayGiangVien&gt; Fill(DataTable dataTable, VList<ViewChiTienGioDayGiangVien> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewChiTienGioDayGiangVien c = new ViewChiTienGioDayGiangVien();
					c.Stt = (Convert.IsDBNull(row["Stt"]))?(int)0:(System.Int32?)row["Stt"];
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.MaQuanLy1 = (Convert.IsDBNull(row["MaQuanLy1"]))?string.Empty:(System.String)row["MaQuanLy1"];
					c.Ho = (Convert.IsDBNull(row["Ho"]))?string.Empty:(System.String)row["Ho"];
					c.Ho1 = (Convert.IsDBNull(row["Ho1"]))?string.Empty:(System.String)row["Ho1"];
					c.Ten = (Convert.IsDBNull(row["Ten"]))?string.Empty:(System.String)row["Ten"];
					c.Ten1 = (Convert.IsDBNull(row["Ten1"]))?string.Empty:(System.String)row["Ten1"];
					c.MaLopHocPhan = (Convert.IsDBNull(row["MaLopHocPhan"]))?string.Empty:(System.String)row["MaLopHocPhan"];
					c.MaLop = (Convert.IsDBNull(row["MaLop"]))?string.Empty:(System.String)row["MaLop"];
					c.MaHeDaoTao = (Convert.IsDBNull(row["MaHeDaoTao"]))?string.Empty:(System.String)row["MaHeDaoTao"];
					c.TenHeDaoTao = (Convert.IsDBNull(row["TenHeDaoTao"]))?string.Empty:(System.String)row["TenHeDaoTao"];
					c.MaBacDaoTao = (Convert.IsDBNull(row["MaBacDaoTao"]))?string.Empty:(System.String)row["MaBacDaoTao"];
					c.TenBacDaoTao = (Convert.IsDBNull(row["TenBacDaoTao"]))?string.Empty:(System.String)row["TenBacDaoTao"];
					c.MaDonVi = (Convert.IsDBNull(row["MaDonVi"]))?string.Empty:(System.String)row["MaDonVi"];
					c.TenDonVi = (Convert.IsDBNull(row["TenDonVi"]))?string.Empty:(System.String)row["TenDonVi"];
					c.MaHocHam = (Convert.IsDBNull(row["MaHocHam"]))?(int)0:(System.Int32?)row["MaHocHam"];
					c.MaHocVi = (Convert.IsDBNull(row["MaHocVi"]))?(int)0:(System.Int32?)row["MaHocVi"];
					c.MaLoaiGiangVien = (Convert.IsDBNull(row["MaLoaiGiangVien"]))?(int)0:(System.Int32?)row["MaLoaiGiangVien"];
					c.MaKhoaHoc = (Convert.IsDBNull(row["MaKhoaHoc"]))?string.Empty:(System.String)row["MaKhoaHoc"];
					c.TenKhoaHoc = (Convert.IsDBNull(row["TenKhoaHoc"]))?string.Empty:(System.String)row["TenKhoaHoc"];
					c.MaMonHoc = (Convert.IsDBNull(row["MaMonHoc"]))?string.Empty:(System.String)row["MaMonHoc"];
					c.TenMonHoc = (Convert.IsDBNull(row["TenMonHoc"]))?string.Empty:(System.String)row["TenMonHoc"];
					c.LoaiHocPhan = (Convert.IsDBNull(row["LoaiHocPhan"]))?string.Empty:(System.String)row["LoaiHocPhan"];
					c.HeSoLopDong = (Convert.IsDBNull(row["HeSoLopDong"]))?0.0m:(System.Decimal?)row["HeSoLopDong"];
					c.SiSoLop = (Convert.IsDBNull(row["SiSoLop"]))?(int)0:(System.Int32?)row["SiSoLop"];
					c.LyThuyet = (Convert.IsDBNull(row["LyThuyet"]))?0.0m:(System.Decimal?)row["LyThuyet"];
					c.ThucHanh = (Convert.IsDBNull(row["ThucHanh"]))?0.0m:(System.Decimal?)row["ThucHanh"];
					c.LyThuyetCoHeSo = (Convert.IsDBNull(row["LyThuyetCoHeSo"]))?0.0m:(System.Decimal?)row["LyThuyetCoHeSo"];
					c.ThucHanhCoHeSo = (Convert.IsDBNull(row["ThucHanhCoHeSo"]))?0.0m:(System.Decimal?)row["ThucHanhCoHeSo"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.TongLyThuyetThucHanh = (Convert.IsDBNull(row["TongLyThuyetThucHanh"]))?0.0m:(System.Decimal?)row["TongLyThuyetThucHanh"];
					c.TongLyThuyetThucHanhCoHeSo = (Convert.IsDBNull(row["TongLyThuyetThucHanhCoHeSo"]))?0.0m:(System.Decimal?)row["TongLyThuyetThucHanhCoHeSo"];
					c.TongLyThuyetThucHanhTg = (Convert.IsDBNull(row["TongLyThuyetThucHanh_TG"]))?0.0m:(System.Decimal?)row["TongLyThuyetThucHanh_TG"];
					c.SoTien = (Convert.IsDBNull(row["SoTien"]))?0.0m:(System.Decimal?)row["SoTien"];
					c.TongLyThuyetThucHanhTungMon = (Convert.IsDBNull(row["TongLyThuyetThucHanhTungMon"]))?0.0m:(System.Decimal?)row["TongLyThuyetThucHanhTungMon"];
					c.ThanhTien = (Convert.IsDBNull(row["ThanhTien"]))?0.0m:(System.Decimal?)row["ThanhTien"];
					c.TongTien = (Convert.IsDBNull(row["TongTien"]))?0.0m:(System.Decimal?)row["TongTien"];
					c.Thue = (Convert.IsDBNull(row["Thue"]))?0.0m:(System.Decimal?)row["Thue"];
					c.TienThucNhan = (Convert.IsDBNull(row["TienThucNhan"]))?0.0m:(System.Decimal?)row["TienThucNhan"];
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
		/// Fill an <see cref="VList&lt;ViewChiTienGioDayGiangVien&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewChiTienGioDayGiangVien&gt;"/></returns>
		protected VList<ViewChiTienGioDayGiangVien> Fill(IDataReader reader, VList<ViewChiTienGioDayGiangVien> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewChiTienGioDayGiangVien entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewChiTienGioDayGiangVien>("ViewChiTienGioDayGiangVien",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewChiTienGioDayGiangVien();
					}
					
					entity.SuppressEntityEvents = true;

					entity.Stt = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.Stt)))?null:(System.Int32?)reader[((int)ViewChiTienGioDayGiangVienColumn.Stt)];
					//entity.Stt = (Convert.IsDBNull(reader["Stt"]))?(int)0:(System.Int32?)reader["Stt"];
					entity.MaQuanLy = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.MaQuanLy)))?null:(System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.MaQuanLy)];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.MaQuanLy1 = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.MaQuanLy1)))?null:(System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.MaQuanLy1)];
					//entity.MaQuanLy1 = (Convert.IsDBNull(reader["MaQuanLy1"]))?string.Empty:(System.String)reader["MaQuanLy1"];
					entity.Ho = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.Ho)))?null:(System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.Ho)];
					//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
					entity.Ho1 = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.Ho1)))?null:(System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.Ho1)];
					//entity.Ho1 = (Convert.IsDBNull(reader["Ho1"]))?string.Empty:(System.String)reader["Ho1"];
					entity.Ten = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.Ten)))?null:(System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.Ten)];
					//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
					entity.Ten1 = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.Ten1)))?null:(System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.Ten1)];
					//entity.Ten1 = (Convert.IsDBNull(reader["Ten1"]))?string.Empty:(System.String)reader["Ten1"];
					entity.MaLopHocPhan = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.MaLopHocPhan)))?null:(System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.MaLopHocPhan)];
					//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
					entity.MaLop = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.MaLop)))?null:(System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.MaLop)];
					//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
					entity.MaHeDaoTao = (System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.MaHeDaoTao)];
					//entity.MaHeDaoTao = (Convert.IsDBNull(reader["MaHeDaoTao"]))?string.Empty:(System.String)reader["MaHeDaoTao"];
					entity.TenHeDaoTao = (System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.TenHeDaoTao)];
					//entity.TenHeDaoTao = (Convert.IsDBNull(reader["TenHeDaoTao"]))?string.Empty:(System.String)reader["TenHeDaoTao"];
					entity.MaBacDaoTao = (System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.MaBacDaoTao)];
					//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
					entity.TenBacDaoTao = (System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.TenBacDaoTao)];
					//entity.TenBacDaoTao = (Convert.IsDBNull(reader["TenBacDaoTao"]))?string.Empty:(System.String)reader["TenBacDaoTao"];
					entity.MaDonVi = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.MaDonVi)))?null:(System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.MaDonVi)];
					//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
					entity.TenDonVi = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.TenDonVi)))?null:(System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.TenDonVi)];
					//entity.TenDonVi = (Convert.IsDBNull(reader["TenDonVi"]))?string.Empty:(System.String)reader["TenDonVi"];
					entity.MaHocHam = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.MaHocHam)))?null:(System.Int32?)reader[((int)ViewChiTienGioDayGiangVienColumn.MaHocHam)];
					//entity.MaHocHam = (Convert.IsDBNull(reader["MaHocHam"]))?(int)0:(System.Int32?)reader["MaHocHam"];
					entity.MaHocVi = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.MaHocVi)))?null:(System.Int32?)reader[((int)ViewChiTienGioDayGiangVienColumn.MaHocVi)];
					//entity.MaHocVi = (Convert.IsDBNull(reader["MaHocVi"]))?(int)0:(System.Int32?)reader["MaHocVi"];
					entity.MaLoaiGiangVien = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.MaLoaiGiangVien)))?null:(System.Int32?)reader[((int)ViewChiTienGioDayGiangVienColumn.MaLoaiGiangVien)];
					//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32?)reader["MaLoaiGiangVien"];
					entity.MaKhoaHoc = (System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.MaKhoaHoc)];
					//entity.MaKhoaHoc = (Convert.IsDBNull(reader["MaKhoaHoc"]))?string.Empty:(System.String)reader["MaKhoaHoc"];
					entity.TenKhoaHoc = (System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.TenKhoaHoc)];
					//entity.TenKhoaHoc = (Convert.IsDBNull(reader["TenKhoaHoc"]))?string.Empty:(System.String)reader["TenKhoaHoc"];
					entity.MaMonHoc = (System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.MaMonHoc)];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.TenMonHoc = (System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.TenMonHoc)];
					//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
					entity.LoaiHocPhan = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.LoaiHocPhan)))?null:(System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.LoaiHocPhan)];
					//entity.LoaiHocPhan = (Convert.IsDBNull(reader["LoaiHocPhan"]))?string.Empty:(System.String)reader["LoaiHocPhan"];
					entity.HeSoLopDong = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.HeSoLopDong)))?null:(System.Decimal?)reader[((int)ViewChiTienGioDayGiangVienColumn.HeSoLopDong)];
					//entity.HeSoLopDong = (Convert.IsDBNull(reader["HeSoLopDong"]))?0.0m:(System.Decimal?)reader["HeSoLopDong"];
					entity.SiSoLop = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.SiSoLop)))?null:(System.Int32?)reader[((int)ViewChiTienGioDayGiangVienColumn.SiSoLop)];
					//entity.SiSoLop = (Convert.IsDBNull(reader["SiSoLop"]))?(int)0:(System.Int32?)reader["SiSoLop"];
					entity.LyThuyet = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.LyThuyet)))?null:(System.Decimal?)reader[((int)ViewChiTienGioDayGiangVienColumn.LyThuyet)];
					//entity.LyThuyet = (Convert.IsDBNull(reader["LyThuyet"]))?0.0m:(System.Decimal?)reader["LyThuyet"];
					entity.ThucHanh = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.ThucHanh)))?null:(System.Decimal?)reader[((int)ViewChiTienGioDayGiangVienColumn.ThucHanh)];
					//entity.ThucHanh = (Convert.IsDBNull(reader["ThucHanh"]))?0.0m:(System.Decimal?)reader["ThucHanh"];
					entity.LyThuyetCoHeSo = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.LyThuyetCoHeSo)))?null:(System.Decimal?)reader[((int)ViewChiTienGioDayGiangVienColumn.LyThuyetCoHeSo)];
					//entity.LyThuyetCoHeSo = (Convert.IsDBNull(reader["LyThuyetCoHeSo"]))?0.0m:(System.Decimal?)reader["LyThuyetCoHeSo"];
					entity.ThucHanhCoHeSo = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.ThucHanhCoHeSo)))?null:(System.Decimal?)reader[((int)ViewChiTienGioDayGiangVienColumn.ThucHanhCoHeSo)];
					//entity.ThucHanhCoHeSo = (Convert.IsDBNull(reader["ThucHanhCoHeSo"]))?0.0m:(System.Decimal?)reader["ThucHanhCoHeSo"];
					entity.NamHoc = (System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.NamHoc)];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = (System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.HocKy)];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.TongLyThuyetThucHanh = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.TongLyThuyetThucHanh)))?null:(System.Decimal?)reader[((int)ViewChiTienGioDayGiangVienColumn.TongLyThuyetThucHanh)];
					//entity.TongLyThuyetThucHanh = (Convert.IsDBNull(reader["TongLyThuyetThucHanh"]))?0.0m:(System.Decimal?)reader["TongLyThuyetThucHanh"];
					entity.TongLyThuyetThucHanhCoHeSo = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.TongLyThuyetThucHanhCoHeSo)))?null:(System.Decimal?)reader[((int)ViewChiTienGioDayGiangVienColumn.TongLyThuyetThucHanhCoHeSo)];
					//entity.TongLyThuyetThucHanhCoHeSo = (Convert.IsDBNull(reader["TongLyThuyetThucHanhCoHeSo"]))?0.0m:(System.Decimal?)reader["TongLyThuyetThucHanhCoHeSo"];
					entity.TongLyThuyetThucHanhTg = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.TongLyThuyetThucHanhTg)))?null:(System.Decimal?)reader[((int)ViewChiTienGioDayGiangVienColumn.TongLyThuyetThucHanhTg)];
					//entity.TongLyThuyetThucHanhTg = (Convert.IsDBNull(reader["TongLyThuyetThucHanh_TG"]))?0.0m:(System.Decimal?)reader["TongLyThuyetThucHanh_TG"];
					entity.SoTien = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.SoTien)))?null:(System.Decimal?)reader[((int)ViewChiTienGioDayGiangVienColumn.SoTien)];
					//entity.SoTien = (Convert.IsDBNull(reader["SoTien"]))?0.0m:(System.Decimal?)reader["SoTien"];
					entity.TongLyThuyetThucHanhTungMon = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.TongLyThuyetThucHanhTungMon)))?null:(System.Decimal?)reader[((int)ViewChiTienGioDayGiangVienColumn.TongLyThuyetThucHanhTungMon)];
					//entity.TongLyThuyetThucHanhTungMon = (Convert.IsDBNull(reader["TongLyThuyetThucHanhTungMon"]))?0.0m:(System.Decimal?)reader["TongLyThuyetThucHanhTungMon"];
					entity.ThanhTien = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.ThanhTien)))?null:(System.Decimal?)reader[((int)ViewChiTienGioDayGiangVienColumn.ThanhTien)];
					//entity.ThanhTien = (Convert.IsDBNull(reader["ThanhTien"]))?0.0m:(System.Decimal?)reader["ThanhTien"];
					entity.TongTien = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.TongTien)))?null:(System.Decimal?)reader[((int)ViewChiTienGioDayGiangVienColumn.TongTien)];
					//entity.TongTien = (Convert.IsDBNull(reader["TongTien"]))?0.0m:(System.Decimal?)reader["TongTien"];
					entity.Thue = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.Thue)))?null:(System.Decimal?)reader[((int)ViewChiTienGioDayGiangVienColumn.Thue)];
					//entity.Thue = (Convert.IsDBNull(reader["Thue"]))?0.0m:(System.Decimal?)reader["Thue"];
					entity.TienThucNhan = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.TienThucNhan)))?null:(System.Decimal?)reader[((int)ViewChiTienGioDayGiangVienColumn.TienThucNhan)];
					//entity.TienThucNhan = (Convert.IsDBNull(reader["TienThucNhan"]))?0.0m:(System.Decimal?)reader["TienThucNhan"];
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
		/// Refreshes the <see cref="ViewChiTienGioDayGiangVien"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewChiTienGioDayGiangVien"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewChiTienGioDayGiangVien entity)
		{
			reader.Read();
			entity.Stt = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.Stt)))?null:(System.Int32?)reader[((int)ViewChiTienGioDayGiangVienColumn.Stt)];
			//entity.Stt = (Convert.IsDBNull(reader["Stt"]))?(int)0:(System.Int32?)reader["Stt"];
			entity.MaQuanLy = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.MaQuanLy)))?null:(System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.MaQuanLy)];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.MaQuanLy1 = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.MaQuanLy1)))?null:(System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.MaQuanLy1)];
			//entity.MaQuanLy1 = (Convert.IsDBNull(reader["MaQuanLy1"]))?string.Empty:(System.String)reader["MaQuanLy1"];
			entity.Ho = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.Ho)))?null:(System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.Ho)];
			//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
			entity.Ho1 = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.Ho1)))?null:(System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.Ho1)];
			//entity.Ho1 = (Convert.IsDBNull(reader["Ho1"]))?string.Empty:(System.String)reader["Ho1"];
			entity.Ten = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.Ten)))?null:(System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.Ten)];
			//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
			entity.Ten1 = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.Ten1)))?null:(System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.Ten1)];
			//entity.Ten1 = (Convert.IsDBNull(reader["Ten1"]))?string.Empty:(System.String)reader["Ten1"];
			entity.MaLopHocPhan = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.MaLopHocPhan)))?null:(System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.MaLopHocPhan)];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			entity.MaLop = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.MaLop)))?null:(System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.MaLop)];
			//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
			entity.MaHeDaoTao = (System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.MaHeDaoTao)];
			//entity.MaHeDaoTao = (Convert.IsDBNull(reader["MaHeDaoTao"]))?string.Empty:(System.String)reader["MaHeDaoTao"];
			entity.TenHeDaoTao = (System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.TenHeDaoTao)];
			//entity.TenHeDaoTao = (Convert.IsDBNull(reader["TenHeDaoTao"]))?string.Empty:(System.String)reader["TenHeDaoTao"];
			entity.MaBacDaoTao = (System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.MaBacDaoTao)];
			//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
			entity.TenBacDaoTao = (System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.TenBacDaoTao)];
			//entity.TenBacDaoTao = (Convert.IsDBNull(reader["TenBacDaoTao"]))?string.Empty:(System.String)reader["TenBacDaoTao"];
			entity.MaDonVi = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.MaDonVi)))?null:(System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.MaDonVi)];
			//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
			entity.TenDonVi = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.TenDonVi)))?null:(System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.TenDonVi)];
			//entity.TenDonVi = (Convert.IsDBNull(reader["TenDonVi"]))?string.Empty:(System.String)reader["TenDonVi"];
			entity.MaHocHam = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.MaHocHam)))?null:(System.Int32?)reader[((int)ViewChiTienGioDayGiangVienColumn.MaHocHam)];
			//entity.MaHocHam = (Convert.IsDBNull(reader["MaHocHam"]))?(int)0:(System.Int32?)reader["MaHocHam"];
			entity.MaHocVi = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.MaHocVi)))?null:(System.Int32?)reader[((int)ViewChiTienGioDayGiangVienColumn.MaHocVi)];
			//entity.MaHocVi = (Convert.IsDBNull(reader["MaHocVi"]))?(int)0:(System.Int32?)reader["MaHocVi"];
			entity.MaLoaiGiangVien = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.MaLoaiGiangVien)))?null:(System.Int32?)reader[((int)ViewChiTienGioDayGiangVienColumn.MaLoaiGiangVien)];
			//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32?)reader["MaLoaiGiangVien"];
			entity.MaKhoaHoc = (System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.MaKhoaHoc)];
			//entity.MaKhoaHoc = (Convert.IsDBNull(reader["MaKhoaHoc"]))?string.Empty:(System.String)reader["MaKhoaHoc"];
			entity.TenKhoaHoc = (System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.TenKhoaHoc)];
			//entity.TenKhoaHoc = (Convert.IsDBNull(reader["TenKhoaHoc"]))?string.Empty:(System.String)reader["TenKhoaHoc"];
			entity.MaMonHoc = (System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.MaMonHoc)];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.TenMonHoc = (System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.TenMonHoc)];
			//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
			entity.LoaiHocPhan = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.LoaiHocPhan)))?null:(System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.LoaiHocPhan)];
			//entity.LoaiHocPhan = (Convert.IsDBNull(reader["LoaiHocPhan"]))?string.Empty:(System.String)reader["LoaiHocPhan"];
			entity.HeSoLopDong = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.HeSoLopDong)))?null:(System.Decimal?)reader[((int)ViewChiTienGioDayGiangVienColumn.HeSoLopDong)];
			//entity.HeSoLopDong = (Convert.IsDBNull(reader["HeSoLopDong"]))?0.0m:(System.Decimal?)reader["HeSoLopDong"];
			entity.SiSoLop = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.SiSoLop)))?null:(System.Int32?)reader[((int)ViewChiTienGioDayGiangVienColumn.SiSoLop)];
			//entity.SiSoLop = (Convert.IsDBNull(reader["SiSoLop"]))?(int)0:(System.Int32?)reader["SiSoLop"];
			entity.LyThuyet = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.LyThuyet)))?null:(System.Decimal?)reader[((int)ViewChiTienGioDayGiangVienColumn.LyThuyet)];
			//entity.LyThuyet = (Convert.IsDBNull(reader["LyThuyet"]))?0.0m:(System.Decimal?)reader["LyThuyet"];
			entity.ThucHanh = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.ThucHanh)))?null:(System.Decimal?)reader[((int)ViewChiTienGioDayGiangVienColumn.ThucHanh)];
			//entity.ThucHanh = (Convert.IsDBNull(reader["ThucHanh"]))?0.0m:(System.Decimal?)reader["ThucHanh"];
			entity.LyThuyetCoHeSo = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.LyThuyetCoHeSo)))?null:(System.Decimal?)reader[((int)ViewChiTienGioDayGiangVienColumn.LyThuyetCoHeSo)];
			//entity.LyThuyetCoHeSo = (Convert.IsDBNull(reader["LyThuyetCoHeSo"]))?0.0m:(System.Decimal?)reader["LyThuyetCoHeSo"];
			entity.ThucHanhCoHeSo = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.ThucHanhCoHeSo)))?null:(System.Decimal?)reader[((int)ViewChiTienGioDayGiangVienColumn.ThucHanhCoHeSo)];
			//entity.ThucHanhCoHeSo = (Convert.IsDBNull(reader["ThucHanhCoHeSo"]))?0.0m:(System.Decimal?)reader["ThucHanhCoHeSo"];
			entity.NamHoc = (System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.NamHoc)];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = (System.String)reader[((int)ViewChiTienGioDayGiangVienColumn.HocKy)];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.TongLyThuyetThucHanh = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.TongLyThuyetThucHanh)))?null:(System.Decimal?)reader[((int)ViewChiTienGioDayGiangVienColumn.TongLyThuyetThucHanh)];
			//entity.TongLyThuyetThucHanh = (Convert.IsDBNull(reader["TongLyThuyetThucHanh"]))?0.0m:(System.Decimal?)reader["TongLyThuyetThucHanh"];
			entity.TongLyThuyetThucHanhCoHeSo = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.TongLyThuyetThucHanhCoHeSo)))?null:(System.Decimal?)reader[((int)ViewChiTienGioDayGiangVienColumn.TongLyThuyetThucHanhCoHeSo)];
			//entity.TongLyThuyetThucHanhCoHeSo = (Convert.IsDBNull(reader["TongLyThuyetThucHanhCoHeSo"]))?0.0m:(System.Decimal?)reader["TongLyThuyetThucHanhCoHeSo"];
			entity.TongLyThuyetThucHanhTg = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.TongLyThuyetThucHanhTg)))?null:(System.Decimal?)reader[((int)ViewChiTienGioDayGiangVienColumn.TongLyThuyetThucHanhTg)];
			//entity.TongLyThuyetThucHanhTg = (Convert.IsDBNull(reader["TongLyThuyetThucHanh_TG"]))?0.0m:(System.Decimal?)reader["TongLyThuyetThucHanh_TG"];
			entity.SoTien = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.SoTien)))?null:(System.Decimal?)reader[((int)ViewChiTienGioDayGiangVienColumn.SoTien)];
			//entity.SoTien = (Convert.IsDBNull(reader["SoTien"]))?0.0m:(System.Decimal?)reader["SoTien"];
			entity.TongLyThuyetThucHanhTungMon = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.TongLyThuyetThucHanhTungMon)))?null:(System.Decimal?)reader[((int)ViewChiTienGioDayGiangVienColumn.TongLyThuyetThucHanhTungMon)];
			//entity.TongLyThuyetThucHanhTungMon = (Convert.IsDBNull(reader["TongLyThuyetThucHanhTungMon"]))?0.0m:(System.Decimal?)reader["TongLyThuyetThucHanhTungMon"];
			entity.ThanhTien = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.ThanhTien)))?null:(System.Decimal?)reader[((int)ViewChiTienGioDayGiangVienColumn.ThanhTien)];
			//entity.ThanhTien = (Convert.IsDBNull(reader["ThanhTien"]))?0.0m:(System.Decimal?)reader["ThanhTien"];
			entity.TongTien = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.TongTien)))?null:(System.Decimal?)reader[((int)ViewChiTienGioDayGiangVienColumn.TongTien)];
			//entity.TongTien = (Convert.IsDBNull(reader["TongTien"]))?0.0m:(System.Decimal?)reader["TongTien"];
			entity.Thue = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.Thue)))?null:(System.Decimal?)reader[((int)ViewChiTienGioDayGiangVienColumn.Thue)];
			//entity.Thue = (Convert.IsDBNull(reader["Thue"]))?0.0m:(System.Decimal?)reader["Thue"];
			entity.TienThucNhan = (reader.IsDBNull(((int)ViewChiTienGioDayGiangVienColumn.TienThucNhan)))?null:(System.Decimal?)reader[((int)ViewChiTienGioDayGiangVienColumn.TienThucNhan)];
			//entity.TienThucNhan = (Convert.IsDBNull(reader["TienThucNhan"]))?0.0m:(System.Decimal?)reader["TienThucNhan"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewChiTienGioDayGiangVien"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewChiTienGioDayGiangVien"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewChiTienGioDayGiangVien entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Stt = (Convert.IsDBNull(dataRow["Stt"]))?(int)0:(System.Int32?)dataRow["Stt"];
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.MaQuanLy1 = (Convert.IsDBNull(dataRow["MaQuanLy1"]))?string.Empty:(System.String)dataRow["MaQuanLy1"];
			entity.Ho = (Convert.IsDBNull(dataRow["Ho"]))?string.Empty:(System.String)dataRow["Ho"];
			entity.Ho1 = (Convert.IsDBNull(dataRow["Ho1"]))?string.Empty:(System.String)dataRow["Ho1"];
			entity.Ten = (Convert.IsDBNull(dataRow["Ten"]))?string.Empty:(System.String)dataRow["Ten"];
			entity.Ten1 = (Convert.IsDBNull(dataRow["Ten1"]))?string.Empty:(System.String)dataRow["Ten1"];
			entity.MaLopHocPhan = (Convert.IsDBNull(dataRow["MaLopHocPhan"]))?string.Empty:(System.String)dataRow["MaLopHocPhan"];
			entity.MaLop = (Convert.IsDBNull(dataRow["MaLop"]))?string.Empty:(System.String)dataRow["MaLop"];
			entity.MaHeDaoTao = (Convert.IsDBNull(dataRow["MaHeDaoTao"]))?string.Empty:(System.String)dataRow["MaHeDaoTao"];
			entity.TenHeDaoTao = (Convert.IsDBNull(dataRow["TenHeDaoTao"]))?string.Empty:(System.String)dataRow["TenHeDaoTao"];
			entity.MaBacDaoTao = (Convert.IsDBNull(dataRow["MaBacDaoTao"]))?string.Empty:(System.String)dataRow["MaBacDaoTao"];
			entity.TenBacDaoTao = (Convert.IsDBNull(dataRow["TenBacDaoTao"]))?string.Empty:(System.String)dataRow["TenBacDaoTao"];
			entity.MaDonVi = (Convert.IsDBNull(dataRow["MaDonVi"]))?string.Empty:(System.String)dataRow["MaDonVi"];
			entity.TenDonVi = (Convert.IsDBNull(dataRow["TenDonVi"]))?string.Empty:(System.String)dataRow["TenDonVi"];
			entity.MaHocHam = (Convert.IsDBNull(dataRow["MaHocHam"]))?(int)0:(System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = (Convert.IsDBNull(dataRow["MaHocVi"]))?(int)0:(System.Int32?)dataRow["MaHocVi"];
			entity.MaLoaiGiangVien = (Convert.IsDBNull(dataRow["MaLoaiGiangVien"]))?(int)0:(System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.MaKhoaHoc = (Convert.IsDBNull(dataRow["MaKhoaHoc"]))?string.Empty:(System.String)dataRow["MaKhoaHoc"];
			entity.TenKhoaHoc = (Convert.IsDBNull(dataRow["TenKhoaHoc"]))?string.Empty:(System.String)dataRow["TenKhoaHoc"];
			entity.MaMonHoc = (Convert.IsDBNull(dataRow["MaMonHoc"]))?string.Empty:(System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = (Convert.IsDBNull(dataRow["TenMonHoc"]))?string.Empty:(System.String)dataRow["TenMonHoc"];
			entity.LoaiHocPhan = (Convert.IsDBNull(dataRow["LoaiHocPhan"]))?string.Empty:(System.String)dataRow["LoaiHocPhan"];
			entity.HeSoLopDong = (Convert.IsDBNull(dataRow["HeSoLopDong"]))?0.0m:(System.Decimal?)dataRow["HeSoLopDong"];
			entity.SiSoLop = (Convert.IsDBNull(dataRow["SiSoLop"]))?(int)0:(System.Int32?)dataRow["SiSoLop"];
			entity.LyThuyet = (Convert.IsDBNull(dataRow["LyThuyet"]))?0.0m:(System.Decimal?)dataRow["LyThuyet"];
			entity.ThucHanh = (Convert.IsDBNull(dataRow["ThucHanh"]))?0.0m:(System.Decimal?)dataRow["ThucHanh"];
			entity.LyThuyetCoHeSo = (Convert.IsDBNull(dataRow["LyThuyetCoHeSo"]))?0.0m:(System.Decimal?)dataRow["LyThuyetCoHeSo"];
			entity.ThucHanhCoHeSo = (Convert.IsDBNull(dataRow["ThucHanhCoHeSo"]))?0.0m:(System.Decimal?)dataRow["ThucHanhCoHeSo"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.TongLyThuyetThucHanh = (Convert.IsDBNull(dataRow["TongLyThuyetThucHanh"]))?0.0m:(System.Decimal?)dataRow["TongLyThuyetThucHanh"];
			entity.TongLyThuyetThucHanhCoHeSo = (Convert.IsDBNull(dataRow["TongLyThuyetThucHanhCoHeSo"]))?0.0m:(System.Decimal?)dataRow["TongLyThuyetThucHanhCoHeSo"];
			entity.TongLyThuyetThucHanhTg = (Convert.IsDBNull(dataRow["TongLyThuyetThucHanh_TG"]))?0.0m:(System.Decimal?)dataRow["TongLyThuyetThucHanh_TG"];
			entity.SoTien = (Convert.IsDBNull(dataRow["SoTien"]))?0.0m:(System.Decimal?)dataRow["SoTien"];
			entity.TongLyThuyetThucHanhTungMon = (Convert.IsDBNull(dataRow["TongLyThuyetThucHanhTungMon"]))?0.0m:(System.Decimal?)dataRow["TongLyThuyetThucHanhTungMon"];
			entity.ThanhTien = (Convert.IsDBNull(dataRow["ThanhTien"]))?0.0m:(System.Decimal?)dataRow["ThanhTien"];
			entity.TongTien = (Convert.IsDBNull(dataRow["TongTien"]))?0.0m:(System.Decimal?)dataRow["TongTien"];
			entity.Thue = (Convert.IsDBNull(dataRow["Thue"]))?0.0m:(System.Decimal?)dataRow["Thue"];
			entity.TienThucNhan = (Convert.IsDBNull(dataRow["TienThucNhan"]))?0.0m:(System.Decimal?)dataRow["TienThucNhan"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewChiTienGioDayGiangVienFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTienGioDayGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewChiTienGioDayGiangVienFilterBuilder : SqlFilterBuilder<ViewChiTienGioDayGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTienGioDayGiangVienFilterBuilder class.
		/// </summary>
		public ViewChiTienGioDayGiangVienFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTienGioDayGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewChiTienGioDayGiangVienFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTienGioDayGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewChiTienGioDayGiangVienFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewChiTienGioDayGiangVienFilterBuilder

	#region ViewChiTienGioDayGiangVienParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTienGioDayGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewChiTienGioDayGiangVienParameterBuilder : ParameterizedSqlFilterBuilder<ViewChiTienGioDayGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTienGioDayGiangVienParameterBuilder class.
		/// </summary>
		public ViewChiTienGioDayGiangVienParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTienGioDayGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewChiTienGioDayGiangVienParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTienGioDayGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewChiTienGioDayGiangVienParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewChiTienGioDayGiangVienParameterBuilder
	
	#region ViewChiTienGioDayGiangVienSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTienGioDayGiangVien"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewChiTienGioDayGiangVienSortBuilder : SqlSortBuilder<ViewChiTienGioDayGiangVienColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTienGioDayGiangVienSqlSortBuilder class.
		/// </summary>
		public ViewChiTienGioDayGiangVienSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewChiTienGioDayGiangVienSortBuilder

} // end namespace
