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
	/// This class is the base class for any <see cref="ViewThongTinGiangDayNamHocHocKyProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewThongTinGiangDayNamHocHocKyProviderBaseCore : EntityViewProviderBase<ViewThongTinGiangDayNamHocHocKy>
	{
		#region Custom Methods
		
		
		#region cust_View_ThongTinGiangDay_NamHocHocKy_GetByNamHocHocKyMaLop
		
		/// <summary>
		///	This method wrap the 'cust_View_ThongTinGiangDay_NamHocHocKy_GetByNamHocHocKyMaLop' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThongTinGiangDayNamHocHocKy&gt;"/> instance.</returns>
		public VList<ViewThongTinGiangDayNamHocHocKy> GetByNamHocHocKyMaLop(System.String namHoc, System.String hocKy, System.String maLop)
		{
			return GetByNamHocHocKyMaLop(null, 0, int.MaxValue , namHoc, hocKy, maLop);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThongTinGiangDay_NamHocHocKy_GetByNamHocHocKyMaLop' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThongTinGiangDayNamHocHocKy&gt;"/> instance.</returns>
		public VList<ViewThongTinGiangDayNamHocHocKy> GetByNamHocHocKyMaLop(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maLop)
		{
			return GetByNamHocHocKyMaLop(null, start, pageLength , namHoc, hocKy, maLop);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ThongTinGiangDay_NamHocHocKy_GetByNamHocHocKyMaLop' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewThongTinGiangDayNamHocHocKy&gt;"/> instance.</returns>
		public VList<ViewThongTinGiangDayNamHocHocKy> GetByNamHocHocKyMaLop(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maLop)
		{
			return GetByNamHocHocKyMaLop(transactionManager, 0, int.MaxValue , namHoc, hocKy, maLop);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThongTinGiangDay_NamHocHocKy_GetByNamHocHocKyMaLop' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThongTinGiangDayNamHocHocKy&gt;"/> instance.</returns>
		public abstract VList<ViewThongTinGiangDayNamHocHocKy> GetByNamHocHocKyMaLop(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, System.String maLop);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewThongTinGiangDayNamHocHocKy&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewThongTinGiangDayNamHocHocKy&gt;"/></returns>
		protected static VList&lt;ViewThongTinGiangDayNamHocHocKy&gt; Fill(DataSet dataSet, VList<ViewThongTinGiangDayNamHocHocKy> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewThongTinGiangDayNamHocHocKy>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewThongTinGiangDayNamHocHocKy&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewThongTinGiangDayNamHocHocKy>"/></returns>
		protected static VList&lt;ViewThongTinGiangDayNamHocHocKy&gt; Fill(DataTable dataTable, VList<ViewThongTinGiangDayNamHocHocKy> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewThongTinGiangDayNamHocHocKy c = new ViewThongTinGiangDayNamHocHocKy();
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.ChuyenNganh = (Convert.IsDBNull(row["ChuyenNganh"]))?string.Empty:(System.String)row["ChuyenNganh"];
					c.NoiLamViec = (Convert.IsDBNull(row["NoiLamViec"]))?string.Empty:(System.String)row["NoiLamViec"];
					c.Cmnd = (Convert.IsDBNull(row["Cmnd"]))?string.Empty:(System.String)row["Cmnd"];
					c.MaSoThue = (Convert.IsDBNull(row["MaSoThue"]))?string.Empty:(System.String)row["MaSoThue"];
					c.ThuongTru = (Convert.IsDBNull(row["ThuongTru"]))?string.Empty:(System.String)row["ThuongTru"];
					c.MaHocVi = (Convert.IsDBNull(row["MaHocVi"]))?string.Empty:(System.String)row["MaHocVi"];
					c.TenHocVi = (Convert.IsDBNull(row["TenHocVi"]))?string.Empty:(System.String)row["TenHocVi"];
					c.MaHocHam = (Convert.IsDBNull(row["MaHocHam"]))?string.Empty:(System.String)row["MaHocHam"];
					c.TenHocHam = (Convert.IsDBNull(row["TenHocHam"]))?string.Empty:(System.String)row["TenHocHam"];
					c.MaLoaiGiangVien = (Convert.IsDBNull(row["MaLoaiGiangVien"]))?(int)0:(System.Int32?)row["MaLoaiGiangVien"];
					c.MaBacDaoTao = (Convert.IsDBNull(row["MaBacDaoTao"]))?string.Empty:(System.String)row["MaBacDaoTao"];
					c.MaLoaiHinh = (Convert.IsDBNull(row["MaLoaiHinh"]))?string.Empty:(System.String)row["MaLoaiHinh"];
					c.MaBacLoaiHinh = (Convert.IsDBNull(row["MaBacLoaiHinh"]))?string.Empty:(System.String)row["MaBacLoaiHinh"];
					c.TenBacDaoTao = (Convert.IsDBNull(row["TenBacDaoTao"]))?string.Empty:(System.String)row["TenBacDaoTao"];
					c.TenHeDaoTao = (Convert.IsDBNull(row["TenHeDaoTao"]))?string.Empty:(System.String)row["TenHeDaoTao"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.TenHocKy = (Convert.IsDBNull(row["TenHocKy"]))?string.Empty:(System.String)row["TenHocKy"];
					c.MaHocPhan = (Convert.IsDBNull(row["MaHocPhan"]))?string.Empty:(System.String)row["MaHocPhan"];
					c.TenHocPhan = (Convert.IsDBNull(row["TenHocPhan"]))?string.Empty:(System.String)row["TenHocPhan"];
					c.MaLopHocPhan = (Convert.IsDBNull(row["MaLopHocPhan"]))?string.Empty:(System.String)row["MaLopHocPhan"];
					c.TenLopHocPhan = (Convert.IsDBNull(row["TenLopHocPhan"]))?string.Empty:(System.String)row["TenLopHocPhan"];
					c.MaLopSinhVien = (Convert.IsDBNull(row["MaLopSinhVien"]))?string.Empty:(System.String)row["MaLopSinhVien"];
					c.TenLopSinhVien = (Convert.IsDBNull(row["TenLopSinhVien"]))?string.Empty:(System.String)row["TenLopSinhVien"];
					c.MaMonHoc = (Convert.IsDBNull(row["MaMonHoc"]))?string.Empty:(System.String)row["MaMonHoc"];
					c.TenMonHoc = (Convert.IsDBNull(row["TenMonHoc"]))?string.Empty:(System.String)row["TenMonHoc"];
					c.MaPhong = (Convert.IsDBNull(row["MaPhong"]))?string.Empty:(System.String)row["MaPhong"];
					c.TenPhong = (Convert.IsDBNull(row["TenPhong"]))?string.Empty:(System.String)row["TenPhong"];
					c.MaCoSo = (Convert.IsDBNull(row["MaCoSo"]))?string.Empty:(System.String)row["MaCoSo"];
					c.TenCoSo = (Convert.IsDBNull(row["TenCoSo"]))?string.Empty:(System.String)row["TenCoSo"];
					c.SoLuong = (Convert.IsDBNull(row["SoLuong"]))?(int)0:(System.Int32?)row["SoLuong"];
					c.HeSoLopDong = (Convert.IsDBNull(row["HeSoLopDong"]))?0.0m:(System.Decimal?)row["HeSoLopDong"];
					c.BuoiHoc = (Convert.IsDBNull(row["BuoiHoc"]))?string.Empty:(System.String)row["BuoiHoc"];
					c.SoTiet = (Convert.IsDBNull(row["SoTiet"]))?(int)0:(System.Int32?)row["SoTiet"];
					c.TietGiangDay = (Convert.IsDBNull(row["TietGiangDay"]))?(int)0:(System.Int32)row["TietGiangDay"];
					c.TietQuyDoi = (Convert.IsDBNull(row["TietQuyDoi"]))?0.0m:(System.Decimal?)row["TietQuyDoi"];
					c.NgayBatDauDay = (Convert.IsDBNull(row["NgayBatDauDay"]))?DateTime.MinValue:(System.DateTime?)row["NgayBatDauDay"];
					c.NgayKetThucDay = (Convert.IsDBNull(row["NgayKetThucDay"]))?DateTime.MinValue:(System.DateTime?)row["NgayKetThucDay"];
					c.HeSoTinChi = (Convert.IsDBNull(row["HeSoTinChi"]))?0.0m:(System.Decimal)row["HeSoTinChi"];
					c.HoanTat = (Convert.IsDBNull(row["HoanTat"]))?false:(System.Boolean)row["HoanTat"];
					c.DonGia = (Convert.IsDBNull(row["DonGia"]))?0.0m:(System.Decimal)row["DonGia"];
					c.TienThem = (Convert.IsDBNull(row["TienThem"]))?0.0m:(System.Decimal)row["TienThem"];
					c.TongCong = (Convert.IsDBNull(row["TongCong"]))?0.0m:(System.Decimal?)row["TongCong"];
					c.DonGiaMotTiet = (Convert.IsDBNull(row["DonGiaMotTiet"]))?0.0m:(System.Decimal?)row["DonGiaMotTiet"];
					c.TienGiangDayTruocThue = (Convert.IsDBNull(row["TienGiangDayTruocThue"]))?0.0m:(System.Decimal?)row["TienGiangDayTruocThue"];
					c.TienThueGiangDay = (Convert.IsDBNull(row["TienThueGiangDay"]))?0.0m:(System.Decimal?)row["TienThueGiangDay"];
					c.TienGiangDaySauThue = (Convert.IsDBNull(row["TienGiangDaySauThue"]))?0.0m:(System.Decimal?)row["TienGiangDaySauThue"];
					c.SoBaiDaCham = (Convert.IsDBNull(row["SoBaiDaCham"]))?(int)0:(System.Int32)row["SoBaiDaCham"];
					c.DonGiaChamThiChuan = (Convert.IsDBNull(row["DonGiaChamThiChuan"]))?0.0m:(System.Decimal?)row["DonGiaChamThiChuan"];
					c.TienChamThiTruocThue = (Convert.IsDBNull(row["TienChamThiTruocThue"]))?0.0m:(System.Decimal?)row["TienChamThiTruocThue"];
					c.TienThueChamThi = (Convert.IsDBNull(row["TienThueChamThi"]))?0.0m:(System.Decimal?)row["TienThueChamThi"];
					c.TienChamThiSauThue = (Convert.IsDBNull(row["TienChamThiSauThue"]))?0.0m:(System.Decimal?)row["TienChamThiSauThue"];
					c.SoDeThiDapAn = (Convert.IsDBNull(row["SoDeThiDapAn"]))?(int)0:(System.Int32)row["SoDeThiDapAn"];
					c.DonGiaRaDeThiChuan = (Convert.IsDBNull(row["DonGiaRaDeThiChuan"]))?0.0m:(System.Decimal?)row["DonGiaRaDeThiChuan"];
					c.TienRaDeTruocThue = (Convert.IsDBNull(row["TienRaDeTruocThue"]))?0.0m:(System.Decimal?)row["TienRaDeTruocThue"];
					c.TienThueRaDe = (Convert.IsDBNull(row["TienThueRaDe"]))?0.0m:(System.Decimal?)row["TienThueRaDe"];
					c.TienRaDeSauThue = (Convert.IsDBNull(row["TienRaDeSauThue"]))?0.0m:(System.Decimal?)row["TienRaDeSauThue"];
					c.SoLanDiLai = (Convert.IsDBNull(row["SoLanDiLai"]))?0.0m:(System.Decimal?)row["SoLanDiLai"];
					c.SoNgayLuuTru = (Convert.IsDBNull(row["SoNgayLuuTru"]))?0.0m:(System.Decimal?)row["SoNgayLuuTru"];
					c.ChiPhiDiLai = (Convert.IsDBNull(row["ChiPhiDiLai"]))?0.0m:(System.Decimal?)row["ChiPhiDiLai"];
					c.ChiPhiLuuTru = (Convert.IsDBNull(row["ChiPhiLuuTru"]))?0.0m:(System.Decimal?)row["ChiPhiLuuTru"];
					c.TienLuuTruTruocThue = (Convert.IsDBNull(row["TienLuuTruTruocThue"]))?0.0m:(System.Decimal?)row["TienLuuTruTruocThue"];
					c.TienThueLuuTru = (Convert.IsDBNull(row["TienThueLuuTru"]))?0.0m:(System.Decimal?)row["TienThueLuuTru"];
					c.TienLuuTruSauThue = (Convert.IsDBNull(row["TienLuuTruSauThue"]))?0.0m:(System.Decimal?)row["TienLuuTruSauThue"];
					c.TienDiLaiTruocThue = (Convert.IsDBNull(row["TienDiLaiTruocThue"]))?0.0m:(System.Decimal?)row["TienDiLaiTruocThue"];
					c.TienThueDiLai = (Convert.IsDBNull(row["TienThueDiLai"]))?0.0m:(System.Decimal?)row["TienThueDiLai"];
					c.TienDiLaiSauThue = (Convert.IsDBNull(row["TienDiLaiSauThue"]))?0.0m:(System.Decimal?)row["TienDiLaiSauThue"];
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
		/// Fill an <see cref="VList&lt;ViewThongTinGiangDayNamHocHocKy&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewThongTinGiangDayNamHocHocKy&gt;"/></returns>
		protected VList<ViewThongTinGiangDayNamHocHocKy> Fill(IDataReader reader, VList<ViewThongTinGiangDayNamHocHocKy> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewThongTinGiangDayNamHocHocKy entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewThongTinGiangDayNamHocHocKy>("ViewThongTinGiangDayNamHocHocKy",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewThongTinGiangDayNamHocHocKy();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaQuanLy = (System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.MaQuanLy)];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.HoTen = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.HoTen)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.HoTen)];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.ChuyenNganh = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.ChuyenNganh)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.ChuyenNganh)];
					//entity.ChuyenNganh = (Convert.IsDBNull(reader["ChuyenNganh"]))?string.Empty:(System.String)reader["ChuyenNganh"];
					entity.NoiLamViec = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.NoiLamViec)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.NoiLamViec)];
					//entity.NoiLamViec = (Convert.IsDBNull(reader["NoiLamViec"]))?string.Empty:(System.String)reader["NoiLamViec"];
					entity.Cmnd = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.Cmnd)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.Cmnd)];
					//entity.Cmnd = (Convert.IsDBNull(reader["Cmnd"]))?string.Empty:(System.String)reader["Cmnd"];
					entity.MaSoThue = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.MaSoThue)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.MaSoThue)];
					//entity.MaSoThue = (Convert.IsDBNull(reader["MaSoThue"]))?string.Empty:(System.String)reader["MaSoThue"];
					entity.ThuongTru = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.ThuongTru)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.ThuongTru)];
					//entity.ThuongTru = (Convert.IsDBNull(reader["ThuongTru"]))?string.Empty:(System.String)reader["ThuongTru"];
					entity.MaHocVi = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.MaHocVi)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.MaHocVi)];
					//entity.MaHocVi = (Convert.IsDBNull(reader["MaHocVi"]))?string.Empty:(System.String)reader["MaHocVi"];
					entity.TenHocVi = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TenHocVi)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TenHocVi)];
					//entity.TenHocVi = (Convert.IsDBNull(reader["TenHocVi"]))?string.Empty:(System.String)reader["TenHocVi"];
					entity.MaHocHam = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.MaHocHam)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.MaHocHam)];
					//entity.MaHocHam = (Convert.IsDBNull(reader["MaHocHam"]))?string.Empty:(System.String)reader["MaHocHam"];
					entity.TenHocHam = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TenHocHam)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TenHocHam)];
					//entity.TenHocHam = (Convert.IsDBNull(reader["TenHocHam"]))?string.Empty:(System.String)reader["TenHocHam"];
					entity.MaLoaiGiangVien = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.MaLoaiGiangVien)))?null:(System.Int32?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.MaLoaiGiangVien)];
					//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32?)reader["MaLoaiGiangVien"];
					entity.MaBacDaoTao = (System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.MaBacDaoTao)];
					//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
					entity.MaLoaiHinh = (System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.MaLoaiHinh)];
					//entity.MaLoaiHinh = (Convert.IsDBNull(reader["MaLoaiHinh"]))?string.Empty:(System.String)reader["MaLoaiHinh"];
					entity.MaBacLoaiHinh = (System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.MaBacLoaiHinh)];
					//entity.MaBacLoaiHinh = (Convert.IsDBNull(reader["MaBacLoaiHinh"]))?string.Empty:(System.String)reader["MaBacLoaiHinh"];
					entity.TenBacDaoTao = (System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TenBacDaoTao)];
					//entity.TenBacDaoTao = (Convert.IsDBNull(reader["TenBacDaoTao"]))?string.Empty:(System.String)reader["TenBacDaoTao"];
					entity.TenHeDaoTao = (System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TenHeDaoTao)];
					//entity.TenHeDaoTao = (Convert.IsDBNull(reader["TenHeDaoTao"]))?string.Empty:(System.String)reader["TenHeDaoTao"];
					entity.NamHoc = (System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.NamHoc)];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = (System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.HocKy)];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.TenHocKy = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TenHocKy)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TenHocKy)];
					//entity.TenHocKy = (Convert.IsDBNull(reader["TenHocKy"]))?string.Empty:(System.String)reader["TenHocKy"];
					entity.MaHocPhan = (System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.MaHocPhan)];
					//entity.MaHocPhan = (Convert.IsDBNull(reader["MaHocPhan"]))?string.Empty:(System.String)reader["MaHocPhan"];
					entity.TenHocPhan = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TenHocPhan)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TenHocPhan)];
					//entity.TenHocPhan = (Convert.IsDBNull(reader["TenHocPhan"]))?string.Empty:(System.String)reader["TenHocPhan"];
					entity.MaLopHocPhan = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.MaLopHocPhan)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.MaLopHocPhan)];
					//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
					entity.TenLopHocPhan = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TenLopHocPhan)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TenLopHocPhan)];
					//entity.TenLopHocPhan = (Convert.IsDBNull(reader["TenLopHocPhan"]))?string.Empty:(System.String)reader["TenLopHocPhan"];
					entity.MaLopSinhVien = (System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.MaLopSinhVien)];
					//entity.MaLopSinhVien = (Convert.IsDBNull(reader["MaLopSinhVien"]))?string.Empty:(System.String)reader["MaLopSinhVien"];
					entity.TenLopSinhVien = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TenLopSinhVien)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TenLopSinhVien)];
					//entity.TenLopSinhVien = (Convert.IsDBNull(reader["TenLopSinhVien"]))?string.Empty:(System.String)reader["TenLopSinhVien"];
					entity.MaMonHoc = (System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.MaMonHoc)];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.TenMonHoc = (System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TenMonHoc)];
					//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
					entity.MaPhong = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.MaPhong)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.MaPhong)];
					//entity.MaPhong = (Convert.IsDBNull(reader["MaPhong"]))?string.Empty:(System.String)reader["MaPhong"];
					entity.TenPhong = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TenPhong)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TenPhong)];
					//entity.TenPhong = (Convert.IsDBNull(reader["TenPhong"]))?string.Empty:(System.String)reader["TenPhong"];
					entity.MaCoSo = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.MaCoSo)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.MaCoSo)];
					//entity.MaCoSo = (Convert.IsDBNull(reader["MaCoSo"]))?string.Empty:(System.String)reader["MaCoSo"];
					entity.TenCoSo = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TenCoSo)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TenCoSo)];
					//entity.TenCoSo = (Convert.IsDBNull(reader["TenCoSo"]))?string.Empty:(System.String)reader["TenCoSo"];
					entity.SoLuong = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.SoLuong)))?null:(System.Int32?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.SoLuong)];
					//entity.SoLuong = (Convert.IsDBNull(reader["SoLuong"]))?(int)0:(System.Int32?)reader["SoLuong"];
					entity.HeSoLopDong = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.HeSoLopDong)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.HeSoLopDong)];
					//entity.HeSoLopDong = (Convert.IsDBNull(reader["HeSoLopDong"]))?0.0m:(System.Decimal?)reader["HeSoLopDong"];
					entity.BuoiHoc = (System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.BuoiHoc)];
					//entity.BuoiHoc = (Convert.IsDBNull(reader["BuoiHoc"]))?string.Empty:(System.String)reader["BuoiHoc"];
					entity.SoTiet = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.SoTiet)))?null:(System.Int32?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.SoTiet)];
					//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32?)reader["SoTiet"];
					entity.TietGiangDay = (System.Int32)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TietGiangDay)];
					//entity.TietGiangDay = (Convert.IsDBNull(reader["TietGiangDay"]))?(int)0:(System.Int32)reader["TietGiangDay"];
					entity.TietQuyDoi = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TietQuyDoi)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TietQuyDoi)];
					//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal?)reader["TietQuyDoi"];
					entity.NgayBatDauDay = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.NgayBatDauDay)))?null:(System.DateTime?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.NgayBatDauDay)];
					//entity.NgayBatDauDay = (Convert.IsDBNull(reader["NgayBatDauDay"]))?DateTime.MinValue:(System.DateTime?)reader["NgayBatDauDay"];
					entity.NgayKetThucDay = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.NgayKetThucDay)))?null:(System.DateTime?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.NgayKetThucDay)];
					//entity.NgayKetThucDay = (Convert.IsDBNull(reader["NgayKetThucDay"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKetThucDay"];
					entity.HeSoTinChi = (System.Decimal)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.HeSoTinChi)];
					//entity.HeSoTinChi = (Convert.IsDBNull(reader["HeSoTinChi"]))?0.0m:(System.Decimal)reader["HeSoTinChi"];
					entity.HoanTat = (System.Boolean)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.HoanTat)];
					//entity.HoanTat = (Convert.IsDBNull(reader["HoanTat"]))?false:(System.Boolean)reader["HoanTat"];
					entity.DonGia = (System.Decimal)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.DonGia)];
					//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal)reader["DonGia"];
					entity.TienThem = (System.Decimal)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TienThem)];
					//entity.TienThem = (Convert.IsDBNull(reader["TienThem"]))?0.0m:(System.Decimal)reader["TienThem"];
					entity.TongCong = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TongCong)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TongCong)];
					//entity.TongCong = (Convert.IsDBNull(reader["TongCong"]))?0.0m:(System.Decimal?)reader["TongCong"];
					entity.DonGiaMotTiet = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.DonGiaMotTiet)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.DonGiaMotTiet)];
					//entity.DonGiaMotTiet = (Convert.IsDBNull(reader["DonGiaMotTiet"]))?0.0m:(System.Decimal?)reader["DonGiaMotTiet"];
					entity.TienGiangDayTruocThue = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TienGiangDayTruocThue)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TienGiangDayTruocThue)];
					//entity.TienGiangDayTruocThue = (Convert.IsDBNull(reader["TienGiangDayTruocThue"]))?0.0m:(System.Decimal?)reader["TienGiangDayTruocThue"];
					entity.TienThueGiangDay = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TienThueGiangDay)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TienThueGiangDay)];
					//entity.TienThueGiangDay = (Convert.IsDBNull(reader["TienThueGiangDay"]))?0.0m:(System.Decimal?)reader["TienThueGiangDay"];
					entity.TienGiangDaySauThue = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TienGiangDaySauThue)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TienGiangDaySauThue)];
					//entity.TienGiangDaySauThue = (Convert.IsDBNull(reader["TienGiangDaySauThue"]))?0.0m:(System.Decimal?)reader["TienGiangDaySauThue"];
					entity.SoBaiDaCham = (System.Int32)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.SoBaiDaCham)];
					//entity.SoBaiDaCham = (Convert.IsDBNull(reader["SoBaiDaCham"]))?(int)0:(System.Int32)reader["SoBaiDaCham"];
					entity.DonGiaChamThiChuan = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.DonGiaChamThiChuan)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.DonGiaChamThiChuan)];
					//entity.DonGiaChamThiChuan = (Convert.IsDBNull(reader["DonGiaChamThiChuan"]))?0.0m:(System.Decimal?)reader["DonGiaChamThiChuan"];
					entity.TienChamThiTruocThue = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TienChamThiTruocThue)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TienChamThiTruocThue)];
					//entity.TienChamThiTruocThue = (Convert.IsDBNull(reader["TienChamThiTruocThue"]))?0.0m:(System.Decimal?)reader["TienChamThiTruocThue"];
					entity.TienThueChamThi = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TienThueChamThi)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TienThueChamThi)];
					//entity.TienThueChamThi = (Convert.IsDBNull(reader["TienThueChamThi"]))?0.0m:(System.Decimal?)reader["TienThueChamThi"];
					entity.TienChamThiSauThue = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TienChamThiSauThue)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TienChamThiSauThue)];
					//entity.TienChamThiSauThue = (Convert.IsDBNull(reader["TienChamThiSauThue"]))?0.0m:(System.Decimal?)reader["TienChamThiSauThue"];
					entity.SoDeThiDapAn = (System.Int32)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.SoDeThiDapAn)];
					//entity.SoDeThiDapAn = (Convert.IsDBNull(reader["SoDeThiDapAn"]))?(int)0:(System.Int32)reader["SoDeThiDapAn"];
					entity.DonGiaRaDeThiChuan = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.DonGiaRaDeThiChuan)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.DonGiaRaDeThiChuan)];
					//entity.DonGiaRaDeThiChuan = (Convert.IsDBNull(reader["DonGiaRaDeThiChuan"]))?0.0m:(System.Decimal?)reader["DonGiaRaDeThiChuan"];
					entity.TienRaDeTruocThue = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TienRaDeTruocThue)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TienRaDeTruocThue)];
					//entity.TienRaDeTruocThue = (Convert.IsDBNull(reader["TienRaDeTruocThue"]))?0.0m:(System.Decimal?)reader["TienRaDeTruocThue"];
					entity.TienThueRaDe = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TienThueRaDe)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TienThueRaDe)];
					//entity.TienThueRaDe = (Convert.IsDBNull(reader["TienThueRaDe"]))?0.0m:(System.Decimal?)reader["TienThueRaDe"];
					entity.TienRaDeSauThue = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TienRaDeSauThue)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TienRaDeSauThue)];
					//entity.TienRaDeSauThue = (Convert.IsDBNull(reader["TienRaDeSauThue"]))?0.0m:(System.Decimal?)reader["TienRaDeSauThue"];
					entity.SoLanDiLai = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.SoLanDiLai)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.SoLanDiLai)];
					//entity.SoLanDiLai = (Convert.IsDBNull(reader["SoLanDiLai"]))?0.0m:(System.Decimal?)reader["SoLanDiLai"];
					entity.SoNgayLuuTru = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.SoNgayLuuTru)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.SoNgayLuuTru)];
					//entity.SoNgayLuuTru = (Convert.IsDBNull(reader["SoNgayLuuTru"]))?0.0m:(System.Decimal?)reader["SoNgayLuuTru"];
					entity.ChiPhiDiLai = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.ChiPhiDiLai)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.ChiPhiDiLai)];
					//entity.ChiPhiDiLai = (Convert.IsDBNull(reader["ChiPhiDiLai"]))?0.0m:(System.Decimal?)reader["ChiPhiDiLai"];
					entity.ChiPhiLuuTru = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.ChiPhiLuuTru)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.ChiPhiLuuTru)];
					//entity.ChiPhiLuuTru = (Convert.IsDBNull(reader["ChiPhiLuuTru"]))?0.0m:(System.Decimal?)reader["ChiPhiLuuTru"];
					entity.TienLuuTruTruocThue = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TienLuuTruTruocThue)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TienLuuTruTruocThue)];
					//entity.TienLuuTruTruocThue = (Convert.IsDBNull(reader["TienLuuTruTruocThue"]))?0.0m:(System.Decimal?)reader["TienLuuTruTruocThue"];
					entity.TienThueLuuTru = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TienThueLuuTru)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TienThueLuuTru)];
					//entity.TienThueLuuTru = (Convert.IsDBNull(reader["TienThueLuuTru"]))?0.0m:(System.Decimal?)reader["TienThueLuuTru"];
					entity.TienLuuTruSauThue = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TienLuuTruSauThue)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TienLuuTruSauThue)];
					//entity.TienLuuTruSauThue = (Convert.IsDBNull(reader["TienLuuTruSauThue"]))?0.0m:(System.Decimal?)reader["TienLuuTruSauThue"];
					entity.TienDiLaiTruocThue = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TienDiLaiTruocThue)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TienDiLaiTruocThue)];
					//entity.TienDiLaiTruocThue = (Convert.IsDBNull(reader["TienDiLaiTruocThue"]))?0.0m:(System.Decimal?)reader["TienDiLaiTruocThue"];
					entity.TienThueDiLai = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TienThueDiLai)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TienThueDiLai)];
					//entity.TienThueDiLai = (Convert.IsDBNull(reader["TienThueDiLai"]))?0.0m:(System.Decimal?)reader["TienThueDiLai"];
					entity.TienDiLaiSauThue = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TienDiLaiSauThue)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TienDiLaiSauThue)];
					//entity.TienDiLaiSauThue = (Convert.IsDBNull(reader["TienDiLaiSauThue"]))?0.0m:(System.Decimal?)reader["TienDiLaiSauThue"];
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
		/// Refreshes the <see cref="ViewThongTinGiangDayNamHocHocKy"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThongTinGiangDayNamHocHocKy"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewThongTinGiangDayNamHocHocKy entity)
		{
			reader.Read();
			entity.MaQuanLy = (System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.MaQuanLy)];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.HoTen = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.HoTen)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.HoTen)];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.ChuyenNganh = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.ChuyenNganh)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.ChuyenNganh)];
			//entity.ChuyenNganh = (Convert.IsDBNull(reader["ChuyenNganh"]))?string.Empty:(System.String)reader["ChuyenNganh"];
			entity.NoiLamViec = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.NoiLamViec)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.NoiLamViec)];
			//entity.NoiLamViec = (Convert.IsDBNull(reader["NoiLamViec"]))?string.Empty:(System.String)reader["NoiLamViec"];
			entity.Cmnd = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.Cmnd)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.Cmnd)];
			//entity.Cmnd = (Convert.IsDBNull(reader["Cmnd"]))?string.Empty:(System.String)reader["Cmnd"];
			entity.MaSoThue = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.MaSoThue)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.MaSoThue)];
			//entity.MaSoThue = (Convert.IsDBNull(reader["MaSoThue"]))?string.Empty:(System.String)reader["MaSoThue"];
			entity.ThuongTru = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.ThuongTru)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.ThuongTru)];
			//entity.ThuongTru = (Convert.IsDBNull(reader["ThuongTru"]))?string.Empty:(System.String)reader["ThuongTru"];
			entity.MaHocVi = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.MaHocVi)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.MaHocVi)];
			//entity.MaHocVi = (Convert.IsDBNull(reader["MaHocVi"]))?string.Empty:(System.String)reader["MaHocVi"];
			entity.TenHocVi = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TenHocVi)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TenHocVi)];
			//entity.TenHocVi = (Convert.IsDBNull(reader["TenHocVi"]))?string.Empty:(System.String)reader["TenHocVi"];
			entity.MaHocHam = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.MaHocHam)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.MaHocHam)];
			//entity.MaHocHam = (Convert.IsDBNull(reader["MaHocHam"]))?string.Empty:(System.String)reader["MaHocHam"];
			entity.TenHocHam = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TenHocHam)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TenHocHam)];
			//entity.TenHocHam = (Convert.IsDBNull(reader["TenHocHam"]))?string.Empty:(System.String)reader["TenHocHam"];
			entity.MaLoaiGiangVien = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.MaLoaiGiangVien)))?null:(System.Int32?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.MaLoaiGiangVien)];
			//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32?)reader["MaLoaiGiangVien"];
			entity.MaBacDaoTao = (System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.MaBacDaoTao)];
			//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
			entity.MaLoaiHinh = (System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.MaLoaiHinh)];
			//entity.MaLoaiHinh = (Convert.IsDBNull(reader["MaLoaiHinh"]))?string.Empty:(System.String)reader["MaLoaiHinh"];
			entity.MaBacLoaiHinh = (System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.MaBacLoaiHinh)];
			//entity.MaBacLoaiHinh = (Convert.IsDBNull(reader["MaBacLoaiHinh"]))?string.Empty:(System.String)reader["MaBacLoaiHinh"];
			entity.TenBacDaoTao = (System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TenBacDaoTao)];
			//entity.TenBacDaoTao = (Convert.IsDBNull(reader["TenBacDaoTao"]))?string.Empty:(System.String)reader["TenBacDaoTao"];
			entity.TenHeDaoTao = (System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TenHeDaoTao)];
			//entity.TenHeDaoTao = (Convert.IsDBNull(reader["TenHeDaoTao"]))?string.Empty:(System.String)reader["TenHeDaoTao"];
			entity.NamHoc = (System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.NamHoc)];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = (System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.HocKy)];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.TenHocKy = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TenHocKy)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TenHocKy)];
			//entity.TenHocKy = (Convert.IsDBNull(reader["TenHocKy"]))?string.Empty:(System.String)reader["TenHocKy"];
			entity.MaHocPhan = (System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.MaHocPhan)];
			//entity.MaHocPhan = (Convert.IsDBNull(reader["MaHocPhan"]))?string.Empty:(System.String)reader["MaHocPhan"];
			entity.TenHocPhan = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TenHocPhan)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TenHocPhan)];
			//entity.TenHocPhan = (Convert.IsDBNull(reader["TenHocPhan"]))?string.Empty:(System.String)reader["TenHocPhan"];
			entity.MaLopHocPhan = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.MaLopHocPhan)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.MaLopHocPhan)];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			entity.TenLopHocPhan = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TenLopHocPhan)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TenLopHocPhan)];
			//entity.TenLopHocPhan = (Convert.IsDBNull(reader["TenLopHocPhan"]))?string.Empty:(System.String)reader["TenLopHocPhan"];
			entity.MaLopSinhVien = (System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.MaLopSinhVien)];
			//entity.MaLopSinhVien = (Convert.IsDBNull(reader["MaLopSinhVien"]))?string.Empty:(System.String)reader["MaLopSinhVien"];
			entity.TenLopSinhVien = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TenLopSinhVien)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TenLopSinhVien)];
			//entity.TenLopSinhVien = (Convert.IsDBNull(reader["TenLopSinhVien"]))?string.Empty:(System.String)reader["TenLopSinhVien"];
			entity.MaMonHoc = (System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.MaMonHoc)];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.TenMonHoc = (System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TenMonHoc)];
			//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
			entity.MaPhong = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.MaPhong)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.MaPhong)];
			//entity.MaPhong = (Convert.IsDBNull(reader["MaPhong"]))?string.Empty:(System.String)reader["MaPhong"];
			entity.TenPhong = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TenPhong)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TenPhong)];
			//entity.TenPhong = (Convert.IsDBNull(reader["TenPhong"]))?string.Empty:(System.String)reader["TenPhong"];
			entity.MaCoSo = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.MaCoSo)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.MaCoSo)];
			//entity.MaCoSo = (Convert.IsDBNull(reader["MaCoSo"]))?string.Empty:(System.String)reader["MaCoSo"];
			entity.TenCoSo = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TenCoSo)))?null:(System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TenCoSo)];
			//entity.TenCoSo = (Convert.IsDBNull(reader["TenCoSo"]))?string.Empty:(System.String)reader["TenCoSo"];
			entity.SoLuong = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.SoLuong)))?null:(System.Int32?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.SoLuong)];
			//entity.SoLuong = (Convert.IsDBNull(reader["SoLuong"]))?(int)0:(System.Int32?)reader["SoLuong"];
			entity.HeSoLopDong = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.HeSoLopDong)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.HeSoLopDong)];
			//entity.HeSoLopDong = (Convert.IsDBNull(reader["HeSoLopDong"]))?0.0m:(System.Decimal?)reader["HeSoLopDong"];
			entity.BuoiHoc = (System.String)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.BuoiHoc)];
			//entity.BuoiHoc = (Convert.IsDBNull(reader["BuoiHoc"]))?string.Empty:(System.String)reader["BuoiHoc"];
			entity.SoTiet = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.SoTiet)))?null:(System.Int32?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.SoTiet)];
			//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32?)reader["SoTiet"];
			entity.TietGiangDay = (System.Int32)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TietGiangDay)];
			//entity.TietGiangDay = (Convert.IsDBNull(reader["TietGiangDay"]))?(int)0:(System.Int32)reader["TietGiangDay"];
			entity.TietQuyDoi = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TietQuyDoi)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TietQuyDoi)];
			//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal?)reader["TietQuyDoi"];
			entity.NgayBatDauDay = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.NgayBatDauDay)))?null:(System.DateTime?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.NgayBatDauDay)];
			//entity.NgayBatDauDay = (Convert.IsDBNull(reader["NgayBatDauDay"]))?DateTime.MinValue:(System.DateTime?)reader["NgayBatDauDay"];
			entity.NgayKetThucDay = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.NgayKetThucDay)))?null:(System.DateTime?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.NgayKetThucDay)];
			//entity.NgayKetThucDay = (Convert.IsDBNull(reader["NgayKetThucDay"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKetThucDay"];
			entity.HeSoTinChi = (System.Decimal)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.HeSoTinChi)];
			//entity.HeSoTinChi = (Convert.IsDBNull(reader["HeSoTinChi"]))?0.0m:(System.Decimal)reader["HeSoTinChi"];
			entity.HoanTat = (System.Boolean)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.HoanTat)];
			//entity.HoanTat = (Convert.IsDBNull(reader["HoanTat"]))?false:(System.Boolean)reader["HoanTat"];
			entity.DonGia = (System.Decimal)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.DonGia)];
			//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal)reader["DonGia"];
			entity.TienThem = (System.Decimal)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TienThem)];
			//entity.TienThem = (Convert.IsDBNull(reader["TienThem"]))?0.0m:(System.Decimal)reader["TienThem"];
			entity.TongCong = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TongCong)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TongCong)];
			//entity.TongCong = (Convert.IsDBNull(reader["TongCong"]))?0.0m:(System.Decimal?)reader["TongCong"];
			entity.DonGiaMotTiet = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.DonGiaMotTiet)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.DonGiaMotTiet)];
			//entity.DonGiaMotTiet = (Convert.IsDBNull(reader["DonGiaMotTiet"]))?0.0m:(System.Decimal?)reader["DonGiaMotTiet"];
			entity.TienGiangDayTruocThue = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TienGiangDayTruocThue)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TienGiangDayTruocThue)];
			//entity.TienGiangDayTruocThue = (Convert.IsDBNull(reader["TienGiangDayTruocThue"]))?0.0m:(System.Decimal?)reader["TienGiangDayTruocThue"];
			entity.TienThueGiangDay = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TienThueGiangDay)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TienThueGiangDay)];
			//entity.TienThueGiangDay = (Convert.IsDBNull(reader["TienThueGiangDay"]))?0.0m:(System.Decimal?)reader["TienThueGiangDay"];
			entity.TienGiangDaySauThue = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TienGiangDaySauThue)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TienGiangDaySauThue)];
			//entity.TienGiangDaySauThue = (Convert.IsDBNull(reader["TienGiangDaySauThue"]))?0.0m:(System.Decimal?)reader["TienGiangDaySauThue"];
			entity.SoBaiDaCham = (System.Int32)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.SoBaiDaCham)];
			//entity.SoBaiDaCham = (Convert.IsDBNull(reader["SoBaiDaCham"]))?(int)0:(System.Int32)reader["SoBaiDaCham"];
			entity.DonGiaChamThiChuan = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.DonGiaChamThiChuan)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.DonGiaChamThiChuan)];
			//entity.DonGiaChamThiChuan = (Convert.IsDBNull(reader["DonGiaChamThiChuan"]))?0.0m:(System.Decimal?)reader["DonGiaChamThiChuan"];
			entity.TienChamThiTruocThue = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TienChamThiTruocThue)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TienChamThiTruocThue)];
			//entity.TienChamThiTruocThue = (Convert.IsDBNull(reader["TienChamThiTruocThue"]))?0.0m:(System.Decimal?)reader["TienChamThiTruocThue"];
			entity.TienThueChamThi = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TienThueChamThi)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TienThueChamThi)];
			//entity.TienThueChamThi = (Convert.IsDBNull(reader["TienThueChamThi"]))?0.0m:(System.Decimal?)reader["TienThueChamThi"];
			entity.TienChamThiSauThue = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TienChamThiSauThue)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TienChamThiSauThue)];
			//entity.TienChamThiSauThue = (Convert.IsDBNull(reader["TienChamThiSauThue"]))?0.0m:(System.Decimal?)reader["TienChamThiSauThue"];
			entity.SoDeThiDapAn = (System.Int32)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.SoDeThiDapAn)];
			//entity.SoDeThiDapAn = (Convert.IsDBNull(reader["SoDeThiDapAn"]))?(int)0:(System.Int32)reader["SoDeThiDapAn"];
			entity.DonGiaRaDeThiChuan = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.DonGiaRaDeThiChuan)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.DonGiaRaDeThiChuan)];
			//entity.DonGiaRaDeThiChuan = (Convert.IsDBNull(reader["DonGiaRaDeThiChuan"]))?0.0m:(System.Decimal?)reader["DonGiaRaDeThiChuan"];
			entity.TienRaDeTruocThue = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TienRaDeTruocThue)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TienRaDeTruocThue)];
			//entity.TienRaDeTruocThue = (Convert.IsDBNull(reader["TienRaDeTruocThue"]))?0.0m:(System.Decimal?)reader["TienRaDeTruocThue"];
			entity.TienThueRaDe = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TienThueRaDe)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TienThueRaDe)];
			//entity.TienThueRaDe = (Convert.IsDBNull(reader["TienThueRaDe"]))?0.0m:(System.Decimal?)reader["TienThueRaDe"];
			entity.TienRaDeSauThue = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TienRaDeSauThue)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TienRaDeSauThue)];
			//entity.TienRaDeSauThue = (Convert.IsDBNull(reader["TienRaDeSauThue"]))?0.0m:(System.Decimal?)reader["TienRaDeSauThue"];
			entity.SoLanDiLai = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.SoLanDiLai)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.SoLanDiLai)];
			//entity.SoLanDiLai = (Convert.IsDBNull(reader["SoLanDiLai"]))?0.0m:(System.Decimal?)reader["SoLanDiLai"];
			entity.SoNgayLuuTru = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.SoNgayLuuTru)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.SoNgayLuuTru)];
			//entity.SoNgayLuuTru = (Convert.IsDBNull(reader["SoNgayLuuTru"]))?0.0m:(System.Decimal?)reader["SoNgayLuuTru"];
			entity.ChiPhiDiLai = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.ChiPhiDiLai)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.ChiPhiDiLai)];
			//entity.ChiPhiDiLai = (Convert.IsDBNull(reader["ChiPhiDiLai"]))?0.0m:(System.Decimal?)reader["ChiPhiDiLai"];
			entity.ChiPhiLuuTru = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.ChiPhiLuuTru)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.ChiPhiLuuTru)];
			//entity.ChiPhiLuuTru = (Convert.IsDBNull(reader["ChiPhiLuuTru"]))?0.0m:(System.Decimal?)reader["ChiPhiLuuTru"];
			entity.TienLuuTruTruocThue = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TienLuuTruTruocThue)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TienLuuTruTruocThue)];
			//entity.TienLuuTruTruocThue = (Convert.IsDBNull(reader["TienLuuTruTruocThue"]))?0.0m:(System.Decimal?)reader["TienLuuTruTruocThue"];
			entity.TienThueLuuTru = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TienThueLuuTru)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TienThueLuuTru)];
			//entity.TienThueLuuTru = (Convert.IsDBNull(reader["TienThueLuuTru"]))?0.0m:(System.Decimal?)reader["TienThueLuuTru"];
			entity.TienLuuTruSauThue = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TienLuuTruSauThue)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TienLuuTruSauThue)];
			//entity.TienLuuTruSauThue = (Convert.IsDBNull(reader["TienLuuTruSauThue"]))?0.0m:(System.Decimal?)reader["TienLuuTruSauThue"];
			entity.TienDiLaiTruocThue = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TienDiLaiTruocThue)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TienDiLaiTruocThue)];
			//entity.TienDiLaiTruocThue = (Convert.IsDBNull(reader["TienDiLaiTruocThue"]))?0.0m:(System.Decimal?)reader["TienDiLaiTruocThue"];
			entity.TienThueDiLai = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TienThueDiLai)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TienThueDiLai)];
			//entity.TienThueDiLai = (Convert.IsDBNull(reader["TienThueDiLai"]))?0.0m:(System.Decimal?)reader["TienThueDiLai"];
			entity.TienDiLaiSauThue = (reader.IsDBNull(((int)ViewThongTinGiangDayNamHocHocKyColumn.TienDiLaiSauThue)))?null:(System.Decimal?)reader[((int)ViewThongTinGiangDayNamHocHocKyColumn.TienDiLaiSauThue)];
			//entity.TienDiLaiSauThue = (Convert.IsDBNull(reader["TienDiLaiSauThue"]))?0.0m:(System.Decimal?)reader["TienDiLaiSauThue"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewThongTinGiangDayNamHocHocKy"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThongTinGiangDayNamHocHocKy"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewThongTinGiangDayNamHocHocKy entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.ChuyenNganh = (Convert.IsDBNull(dataRow["ChuyenNganh"]))?string.Empty:(System.String)dataRow["ChuyenNganh"];
			entity.NoiLamViec = (Convert.IsDBNull(dataRow["NoiLamViec"]))?string.Empty:(System.String)dataRow["NoiLamViec"];
			entity.Cmnd = (Convert.IsDBNull(dataRow["Cmnd"]))?string.Empty:(System.String)dataRow["Cmnd"];
			entity.MaSoThue = (Convert.IsDBNull(dataRow["MaSoThue"]))?string.Empty:(System.String)dataRow["MaSoThue"];
			entity.ThuongTru = (Convert.IsDBNull(dataRow["ThuongTru"]))?string.Empty:(System.String)dataRow["ThuongTru"];
			entity.MaHocVi = (Convert.IsDBNull(dataRow["MaHocVi"]))?string.Empty:(System.String)dataRow["MaHocVi"];
			entity.TenHocVi = (Convert.IsDBNull(dataRow["TenHocVi"]))?string.Empty:(System.String)dataRow["TenHocVi"];
			entity.MaHocHam = (Convert.IsDBNull(dataRow["MaHocHam"]))?string.Empty:(System.String)dataRow["MaHocHam"];
			entity.TenHocHam = (Convert.IsDBNull(dataRow["TenHocHam"]))?string.Empty:(System.String)dataRow["TenHocHam"];
			entity.MaLoaiGiangVien = (Convert.IsDBNull(dataRow["MaLoaiGiangVien"]))?(int)0:(System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.MaBacDaoTao = (Convert.IsDBNull(dataRow["MaBacDaoTao"]))?string.Empty:(System.String)dataRow["MaBacDaoTao"];
			entity.MaLoaiHinh = (Convert.IsDBNull(dataRow["MaLoaiHinh"]))?string.Empty:(System.String)dataRow["MaLoaiHinh"];
			entity.MaBacLoaiHinh = (Convert.IsDBNull(dataRow["MaBacLoaiHinh"]))?string.Empty:(System.String)dataRow["MaBacLoaiHinh"];
			entity.TenBacDaoTao = (Convert.IsDBNull(dataRow["TenBacDaoTao"]))?string.Empty:(System.String)dataRow["TenBacDaoTao"];
			entity.TenHeDaoTao = (Convert.IsDBNull(dataRow["TenHeDaoTao"]))?string.Empty:(System.String)dataRow["TenHeDaoTao"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.TenHocKy = (Convert.IsDBNull(dataRow["TenHocKy"]))?string.Empty:(System.String)dataRow["TenHocKy"];
			entity.MaHocPhan = (Convert.IsDBNull(dataRow["MaHocPhan"]))?string.Empty:(System.String)dataRow["MaHocPhan"];
			entity.TenHocPhan = (Convert.IsDBNull(dataRow["TenHocPhan"]))?string.Empty:(System.String)dataRow["TenHocPhan"];
			entity.MaLopHocPhan = (Convert.IsDBNull(dataRow["MaLopHocPhan"]))?string.Empty:(System.String)dataRow["MaLopHocPhan"];
			entity.TenLopHocPhan = (Convert.IsDBNull(dataRow["TenLopHocPhan"]))?string.Empty:(System.String)dataRow["TenLopHocPhan"];
			entity.MaLopSinhVien = (Convert.IsDBNull(dataRow["MaLopSinhVien"]))?string.Empty:(System.String)dataRow["MaLopSinhVien"];
			entity.TenLopSinhVien = (Convert.IsDBNull(dataRow["TenLopSinhVien"]))?string.Empty:(System.String)dataRow["TenLopSinhVien"];
			entity.MaMonHoc = (Convert.IsDBNull(dataRow["MaMonHoc"]))?string.Empty:(System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = (Convert.IsDBNull(dataRow["TenMonHoc"]))?string.Empty:(System.String)dataRow["TenMonHoc"];
			entity.MaPhong = (Convert.IsDBNull(dataRow["MaPhong"]))?string.Empty:(System.String)dataRow["MaPhong"];
			entity.TenPhong = (Convert.IsDBNull(dataRow["TenPhong"]))?string.Empty:(System.String)dataRow["TenPhong"];
			entity.MaCoSo = (Convert.IsDBNull(dataRow["MaCoSo"]))?string.Empty:(System.String)dataRow["MaCoSo"];
			entity.TenCoSo = (Convert.IsDBNull(dataRow["TenCoSo"]))?string.Empty:(System.String)dataRow["TenCoSo"];
			entity.SoLuong = (Convert.IsDBNull(dataRow["SoLuong"]))?(int)0:(System.Int32?)dataRow["SoLuong"];
			entity.HeSoLopDong = (Convert.IsDBNull(dataRow["HeSoLopDong"]))?0.0m:(System.Decimal?)dataRow["HeSoLopDong"];
			entity.BuoiHoc = (Convert.IsDBNull(dataRow["BuoiHoc"]))?string.Empty:(System.String)dataRow["BuoiHoc"];
			entity.SoTiet = (Convert.IsDBNull(dataRow["SoTiet"]))?(int)0:(System.Int32?)dataRow["SoTiet"];
			entity.TietGiangDay = (Convert.IsDBNull(dataRow["TietGiangDay"]))?(int)0:(System.Int32)dataRow["TietGiangDay"];
			entity.TietQuyDoi = (Convert.IsDBNull(dataRow["TietQuyDoi"]))?0.0m:(System.Decimal?)dataRow["TietQuyDoi"];
			entity.NgayBatDauDay = (Convert.IsDBNull(dataRow["NgayBatDauDay"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayBatDauDay"];
			entity.NgayKetThucDay = (Convert.IsDBNull(dataRow["NgayKetThucDay"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayKetThucDay"];
			entity.HeSoTinChi = (Convert.IsDBNull(dataRow["HeSoTinChi"]))?0.0m:(System.Decimal)dataRow["HeSoTinChi"];
			entity.HoanTat = (Convert.IsDBNull(dataRow["HoanTat"]))?false:(System.Boolean)dataRow["HoanTat"];
			entity.DonGia = (Convert.IsDBNull(dataRow["DonGia"]))?0.0m:(System.Decimal)dataRow["DonGia"];
			entity.TienThem = (Convert.IsDBNull(dataRow["TienThem"]))?0.0m:(System.Decimal)dataRow["TienThem"];
			entity.TongCong = (Convert.IsDBNull(dataRow["TongCong"]))?0.0m:(System.Decimal?)dataRow["TongCong"];
			entity.DonGiaMotTiet = (Convert.IsDBNull(dataRow["DonGiaMotTiet"]))?0.0m:(System.Decimal?)dataRow["DonGiaMotTiet"];
			entity.TienGiangDayTruocThue = (Convert.IsDBNull(dataRow["TienGiangDayTruocThue"]))?0.0m:(System.Decimal?)dataRow["TienGiangDayTruocThue"];
			entity.TienThueGiangDay = (Convert.IsDBNull(dataRow["TienThueGiangDay"]))?0.0m:(System.Decimal?)dataRow["TienThueGiangDay"];
			entity.TienGiangDaySauThue = (Convert.IsDBNull(dataRow["TienGiangDaySauThue"]))?0.0m:(System.Decimal?)dataRow["TienGiangDaySauThue"];
			entity.SoBaiDaCham = (Convert.IsDBNull(dataRow["SoBaiDaCham"]))?(int)0:(System.Int32)dataRow["SoBaiDaCham"];
			entity.DonGiaChamThiChuan = (Convert.IsDBNull(dataRow["DonGiaChamThiChuan"]))?0.0m:(System.Decimal?)dataRow["DonGiaChamThiChuan"];
			entity.TienChamThiTruocThue = (Convert.IsDBNull(dataRow["TienChamThiTruocThue"]))?0.0m:(System.Decimal?)dataRow["TienChamThiTruocThue"];
			entity.TienThueChamThi = (Convert.IsDBNull(dataRow["TienThueChamThi"]))?0.0m:(System.Decimal?)dataRow["TienThueChamThi"];
			entity.TienChamThiSauThue = (Convert.IsDBNull(dataRow["TienChamThiSauThue"]))?0.0m:(System.Decimal?)dataRow["TienChamThiSauThue"];
			entity.SoDeThiDapAn = (Convert.IsDBNull(dataRow["SoDeThiDapAn"]))?(int)0:(System.Int32)dataRow["SoDeThiDapAn"];
			entity.DonGiaRaDeThiChuan = (Convert.IsDBNull(dataRow["DonGiaRaDeThiChuan"]))?0.0m:(System.Decimal?)dataRow["DonGiaRaDeThiChuan"];
			entity.TienRaDeTruocThue = (Convert.IsDBNull(dataRow["TienRaDeTruocThue"]))?0.0m:(System.Decimal?)dataRow["TienRaDeTruocThue"];
			entity.TienThueRaDe = (Convert.IsDBNull(dataRow["TienThueRaDe"]))?0.0m:(System.Decimal?)dataRow["TienThueRaDe"];
			entity.TienRaDeSauThue = (Convert.IsDBNull(dataRow["TienRaDeSauThue"]))?0.0m:(System.Decimal?)dataRow["TienRaDeSauThue"];
			entity.SoLanDiLai = (Convert.IsDBNull(dataRow["SoLanDiLai"]))?0.0m:(System.Decimal?)dataRow["SoLanDiLai"];
			entity.SoNgayLuuTru = (Convert.IsDBNull(dataRow["SoNgayLuuTru"]))?0.0m:(System.Decimal?)dataRow["SoNgayLuuTru"];
			entity.ChiPhiDiLai = (Convert.IsDBNull(dataRow["ChiPhiDiLai"]))?0.0m:(System.Decimal?)dataRow["ChiPhiDiLai"];
			entity.ChiPhiLuuTru = (Convert.IsDBNull(dataRow["ChiPhiLuuTru"]))?0.0m:(System.Decimal?)dataRow["ChiPhiLuuTru"];
			entity.TienLuuTruTruocThue = (Convert.IsDBNull(dataRow["TienLuuTruTruocThue"]))?0.0m:(System.Decimal?)dataRow["TienLuuTruTruocThue"];
			entity.TienThueLuuTru = (Convert.IsDBNull(dataRow["TienThueLuuTru"]))?0.0m:(System.Decimal?)dataRow["TienThueLuuTru"];
			entity.TienLuuTruSauThue = (Convert.IsDBNull(dataRow["TienLuuTruSauThue"]))?0.0m:(System.Decimal?)dataRow["TienLuuTruSauThue"];
			entity.TienDiLaiTruocThue = (Convert.IsDBNull(dataRow["TienDiLaiTruocThue"]))?0.0m:(System.Decimal?)dataRow["TienDiLaiTruocThue"];
			entity.TienThueDiLai = (Convert.IsDBNull(dataRow["TienThueDiLai"]))?0.0m:(System.Decimal?)dataRow["TienThueDiLai"];
			entity.TienDiLaiSauThue = (Convert.IsDBNull(dataRow["TienDiLaiSauThue"]))?0.0m:(System.Decimal?)dataRow["TienDiLaiSauThue"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewThongTinGiangDayNamHocHocKyFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongTinGiangDayNamHocHocKy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThongTinGiangDayNamHocHocKyFilterBuilder : SqlFilterBuilder<ViewThongTinGiangDayNamHocHocKyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongTinGiangDayNamHocHocKyFilterBuilder class.
		/// </summary>
		public ViewThongTinGiangDayNamHocHocKyFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThongTinGiangDayNamHocHocKyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThongTinGiangDayNamHocHocKyFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThongTinGiangDayNamHocHocKyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThongTinGiangDayNamHocHocKyFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThongTinGiangDayNamHocHocKyFilterBuilder

	#region ViewThongTinGiangDayNamHocHocKyParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongTinGiangDayNamHocHocKy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThongTinGiangDayNamHocHocKyParameterBuilder : ParameterizedSqlFilterBuilder<ViewThongTinGiangDayNamHocHocKyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongTinGiangDayNamHocHocKyParameterBuilder class.
		/// </summary>
		public ViewThongTinGiangDayNamHocHocKyParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThongTinGiangDayNamHocHocKyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThongTinGiangDayNamHocHocKyParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThongTinGiangDayNamHocHocKyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThongTinGiangDayNamHocHocKyParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThongTinGiangDayNamHocHocKyParameterBuilder
	
	#region ViewThongTinGiangDayNamHocHocKySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongTinGiangDayNamHocHocKy"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewThongTinGiangDayNamHocHocKySortBuilder : SqlSortBuilder<ViewThongTinGiangDayNamHocHocKyColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongTinGiangDayNamHocHocKySqlSortBuilder class.
		/// </summary>
		public ViewThongTinGiangDayNamHocHocKySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewThongTinGiangDayNamHocHocKySortBuilder

} // end namespace
