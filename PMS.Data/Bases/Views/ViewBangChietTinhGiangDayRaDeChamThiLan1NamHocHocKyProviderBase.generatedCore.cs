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
	/// This class is the base class for any <see cref="ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyProviderBaseCore : EntityViewProviderBase<ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy>
	{
		#region Custom Methods
		
		
		#region cust_View_BangChietTinhGiangDay_RaDe_ChamThiLan1_NamHocHocKy_GetByNamHocHocKyMaLop
		
		/// <summary>
		///	This method wrap the 'cust_View_BangChietTinhGiangDay_RaDe_ChamThiLan1_NamHocHocKy_GetByNamHocHocKyMaLop' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy&gt;"/> instance.</returns>
		public VList<ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy> GetByNamHocHocKyMaLop(System.String namHoc, System.String hocKy, System.String maLop)
		{
			return GetByNamHocHocKyMaLop(null, 0, int.MaxValue , namHoc, hocKy, maLop);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_BangChietTinhGiangDay_RaDe_ChamThiLan1_NamHocHocKy_GetByNamHocHocKyMaLop' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy&gt;"/> instance.</returns>
		public VList<ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy> GetByNamHocHocKyMaLop(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maLop)
		{
			return GetByNamHocHocKyMaLop(null, start, pageLength , namHoc, hocKy, maLop);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_BangChietTinhGiangDay_RaDe_ChamThiLan1_NamHocHocKy_GetByNamHocHocKyMaLop' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy&gt;"/> instance.</returns>
		public VList<ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy> GetByNamHocHocKyMaLop(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maLop)
		{
			return GetByNamHocHocKyMaLop(transactionManager, 0, int.MaxValue , namHoc, hocKy, maLop);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_BangChietTinhGiangDay_RaDe_ChamThiLan1_NamHocHocKy_GetByNamHocHocKyMaLop' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy&gt;"/> instance.</returns>
		public abstract VList<ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy> GetByNamHocHocKyMaLop(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, System.String maLop);
		
		#endregion

		
		#region cust_View_BangChietTinhGiangDay_RaDe_ChamThiLan1_NamHocHocKy_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_BangChietTinhGiangDay_RaDe_ChamThiLan1_NamHocHocKy_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy&gt;"/> instance.</returns>
		public VList<ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy> GetByNamHocHocKy(System.String namHoc, System.String hocKy, System.String maGiangVien)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_BangChietTinhGiangDay_RaDe_ChamThiLan1_NamHocHocKy_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy&gt;"/> instance.</returns>
		public VList<ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maGiangVien)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy, maGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_BangChietTinhGiangDay_RaDe_ChamThiLan1_NamHocHocKy_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy&gt;"/> instance.</returns>
		public VList<ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maGiangVien)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_BangChietTinhGiangDay_RaDe_ChamThiLan1_NamHocHocKy_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy&gt;"/> instance.</returns>
		public abstract VList<ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, System.String maGiangVien);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy&gt;"/></returns>
		protected static VList&lt;ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy&gt; Fill(DataSet dataSet, VList<ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy>"/></returns>
		protected static VList&lt;ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy&gt; Fill(DataTable dataTable, VList<ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy c = new ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy();
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.MaLopHocPhan = (Convert.IsDBNull(row["MaLopHocPhan"]))?string.Empty:(System.String)row["MaLopHocPhan"];
					c.SoLuong = (Convert.IsDBNull(row["SoLuong"]))?(int)0:(System.Int32?)row["SoLuong"];
					c.TietGiangDay = (Convert.IsDBNull(row["TietGiangDay"]))?(int)0:(System.Int32)row["TietGiangDay"];
					c.HeSoLopDong = (Convert.IsDBNull(row["HeSoLopDong"]))?0.0m:(System.Decimal?)row["HeSoLopDong"];
					c.SoBaiDaCham = (Convert.IsDBNull(row["SoBaiDaCham"]))?(int)0:(System.Int32)row["SoBaiDaCham"];
					c.SoDeThiDapAn = (Convert.IsDBNull(row["SoDeThiDapAn"]))?(int)0:(System.Int32)row["SoDeThiDapAn"];
					c.MaLopSinhVien = (Convert.IsDBNull(row["MaLopSinhVien"]))?string.Empty:(System.String)row["MaLopSinhVien"];
					c.TenLopSinhVien = (Convert.IsDBNull(row["TenLopSinhVien"]))?string.Empty:(System.String)row["TenLopSinhVien"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.NoiLamViec = (Convert.IsDBNull(row["NoiLamViec"]))?string.Empty:(System.String)row["NoiLamViec"];
					c.MaCoSo = (Convert.IsDBNull(row["MaCoSo"]))?string.Empty:(System.String)row["MaCoSo"];
					c.TenCoSo = (Convert.IsDBNull(row["TenCoSo"]))?string.Empty:(System.String)row["TenCoSo"];
					c.MaHocVi = (Convert.IsDBNull(row["MaHocVi"]))?string.Empty:(System.String)row["MaHocVi"];
					c.TenHocVi = (Convert.IsDBNull(row["TenHocVi"]))?string.Empty:(System.String)row["TenHocVi"];
					c.MaHocHam = (Convert.IsDBNull(row["MaHocHam"]))?string.Empty:(System.String)row["MaHocHam"];
					c.TenHocHam = (Convert.IsDBNull(row["TenHocHam"]))?string.Empty:(System.String)row["TenHocHam"];
					c.HeSoTinChi = (Convert.IsDBNull(row["HeSoTinChi"]))?0.0m:(System.Decimal)row["HeSoTinChi"];
					c.DonGiaMotTiet = (Convert.IsDBNull(row["DonGiaMotTiet"]))?0.0m:(System.Decimal?)row["DonGiaMotTiet"];
					c.TienGiangDayTruocThue = (Convert.IsDBNull(row["TienGiangDayTruocThue"]))?0.0m:(System.Decimal?)row["TienGiangDayTruocThue"];
					c.TienThueGiangDay = (Convert.IsDBNull(row["TienThueGiangDay"]))?0.0m:(System.Decimal?)row["TienThueGiangDay"];
					c.TienGiangDaySauThue = (Convert.IsDBNull(row["TienGiangDaySauThue"]))?0.0m:(System.Decimal?)row["TienGiangDaySauThue"];
					c.DonGiaChamThiChuan = (Convert.IsDBNull(row["DonGiaChamThiChuan"]))?0.0m:(System.Decimal?)row["DonGiaChamThiChuan"];
					c.TienChamThiTruocThue = (Convert.IsDBNull(row["TienChamThiTruocThue"]))?0.0m:(System.Decimal?)row["TienChamThiTruocThue"];
					c.TienThueChamThi = (Convert.IsDBNull(row["TienThueChamThi"]))?0.0m:(System.Decimal?)row["TienThueChamThi"];
					c.TienChamThiSauThue = (Convert.IsDBNull(row["TienChamThiSauThue"]))?0.0m:(System.Decimal?)row["TienChamThiSauThue"];
					c.DonGiaRaDeThiChuan = (Convert.IsDBNull(row["DonGiaRaDeThiChuan"]))?0.0m:(System.Decimal?)row["DonGiaRaDeThiChuan"];
					c.TienRaDeTruocThue = (Convert.IsDBNull(row["TienRaDeTruocThue"]))?0.0m:(System.Decimal?)row["TienRaDeTruocThue"];
					c.TienThueRaDe = (Convert.IsDBNull(row["TienThueRaDe"]))?0.0m:(System.Decimal?)row["TienThueRaDe"];
					c.TienRaDeSauThue = (Convert.IsDBNull(row["TienRaDeSauThue"]))?0.0m:(System.Decimal?)row["TienRaDeSauThue"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.TenHocKy = (Convert.IsDBNull(row["TenHocKy"]))?string.Empty:(System.String)row["TenHocKy"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.MaMonHoc = (Convert.IsDBNull(row["MaMonHoc"]))?string.Empty:(System.String)row["MaMonHoc"];
					c.TenMonHoc = (Convert.IsDBNull(row["TenMonHoc"]))?string.Empty:(System.String)row["TenMonHoc"];
					c.TenLopHocPhan = (Convert.IsDBNull(row["TenLopHocPhan"]))?string.Empty:(System.String)row["TenLopHocPhan"];
					c.TenHocPhan = (Convert.IsDBNull(row["TenHocPhan"]))?string.Empty:(System.String)row["TenHocPhan"];
					c.MaBacDaoTao = (Convert.IsDBNull(row["MaBacDaoTao"]))?string.Empty:(System.String)row["MaBacDaoTao"];
					c.TenBacDaoTao = (Convert.IsDBNull(row["TenBacDaoTao"]))?string.Empty:(System.String)row["TenBacDaoTao"];
					c.MaHeDaoTao = (Convert.IsDBNull(row["MaHeDaoTao"]))?string.Empty:(System.String)row["MaHeDaoTao"];
					c.TenHeDaoTao = (Convert.IsDBNull(row["TenHeDaoTao"]))?string.Empty:(System.String)row["TenHeDaoTao"];
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
					c.HoanTat = (Convert.IsDBNull(row["HoanTat"]))?false:(System.Boolean)row["HoanTat"];
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
		/// Fill an <see cref="VList&lt;ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy&gt;"/></returns>
		protected VList<ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy> Fill(IDataReader reader, VList<ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy>("ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaQuanLy = (System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.MaQuanLy)];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.MaLopHocPhan = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.MaLopHocPhan)))?null:(System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.MaLopHocPhan)];
					//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
					entity.SoLuong = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.SoLuong)))?null:(System.Int32?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.SoLuong)];
					//entity.SoLuong = (Convert.IsDBNull(reader["SoLuong"]))?(int)0:(System.Int32?)reader["SoLuong"];
					entity.TietGiangDay = (System.Int32)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TietGiangDay)];
					//entity.TietGiangDay = (Convert.IsDBNull(reader["TietGiangDay"]))?(int)0:(System.Int32)reader["TietGiangDay"];
					entity.HeSoLopDong = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.HeSoLopDong)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.HeSoLopDong)];
					//entity.HeSoLopDong = (Convert.IsDBNull(reader["HeSoLopDong"]))?0.0m:(System.Decimal?)reader["HeSoLopDong"];
					entity.SoBaiDaCham = (System.Int32)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.SoBaiDaCham)];
					//entity.SoBaiDaCham = (Convert.IsDBNull(reader["SoBaiDaCham"]))?(int)0:(System.Int32)reader["SoBaiDaCham"];
					entity.SoDeThiDapAn = (System.Int32)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.SoDeThiDapAn)];
					//entity.SoDeThiDapAn = (Convert.IsDBNull(reader["SoDeThiDapAn"]))?(int)0:(System.Int32)reader["SoDeThiDapAn"];
					entity.MaLopSinhVien = (System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.MaLopSinhVien)];
					//entity.MaLopSinhVien = (Convert.IsDBNull(reader["MaLopSinhVien"]))?string.Empty:(System.String)reader["MaLopSinhVien"];
					entity.TenLopSinhVien = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TenLopSinhVien)))?null:(System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TenLopSinhVien)];
					//entity.TenLopSinhVien = (Convert.IsDBNull(reader["TenLopSinhVien"]))?string.Empty:(System.String)reader["TenLopSinhVien"];
					entity.HoTen = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.HoTen)))?null:(System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.HoTen)];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.NoiLamViec = (System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.NoiLamViec)];
					//entity.NoiLamViec = (Convert.IsDBNull(reader["NoiLamViec"]))?string.Empty:(System.String)reader["NoiLamViec"];
					entity.MaCoSo = (System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.MaCoSo)];
					//entity.MaCoSo = (Convert.IsDBNull(reader["MaCoSo"]))?string.Empty:(System.String)reader["MaCoSo"];
					entity.TenCoSo = (System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TenCoSo)];
					//entity.TenCoSo = (Convert.IsDBNull(reader["TenCoSo"]))?string.Empty:(System.String)reader["TenCoSo"];
					entity.MaHocVi = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.MaHocVi)))?null:(System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.MaHocVi)];
					//entity.MaHocVi = (Convert.IsDBNull(reader["MaHocVi"]))?string.Empty:(System.String)reader["MaHocVi"];
					entity.TenHocVi = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TenHocVi)))?null:(System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TenHocVi)];
					//entity.TenHocVi = (Convert.IsDBNull(reader["TenHocVi"]))?string.Empty:(System.String)reader["TenHocVi"];
					entity.MaHocHam = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.MaHocHam)))?null:(System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.MaHocHam)];
					//entity.MaHocHam = (Convert.IsDBNull(reader["MaHocHam"]))?string.Empty:(System.String)reader["MaHocHam"];
					entity.TenHocHam = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TenHocHam)))?null:(System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TenHocHam)];
					//entity.TenHocHam = (Convert.IsDBNull(reader["TenHocHam"]))?string.Empty:(System.String)reader["TenHocHam"];
					entity.HeSoTinChi = (System.Decimal)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.HeSoTinChi)];
					//entity.HeSoTinChi = (Convert.IsDBNull(reader["HeSoTinChi"]))?0.0m:(System.Decimal)reader["HeSoTinChi"];
					entity.DonGiaMotTiet = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.DonGiaMotTiet)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.DonGiaMotTiet)];
					//entity.DonGiaMotTiet = (Convert.IsDBNull(reader["DonGiaMotTiet"]))?0.0m:(System.Decimal?)reader["DonGiaMotTiet"];
					entity.TienGiangDayTruocThue = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienGiangDayTruocThue)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienGiangDayTruocThue)];
					//entity.TienGiangDayTruocThue = (Convert.IsDBNull(reader["TienGiangDayTruocThue"]))?0.0m:(System.Decimal?)reader["TienGiangDayTruocThue"];
					entity.TienThueGiangDay = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienThueGiangDay)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienThueGiangDay)];
					//entity.TienThueGiangDay = (Convert.IsDBNull(reader["TienThueGiangDay"]))?0.0m:(System.Decimal?)reader["TienThueGiangDay"];
					entity.TienGiangDaySauThue = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienGiangDaySauThue)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienGiangDaySauThue)];
					//entity.TienGiangDaySauThue = (Convert.IsDBNull(reader["TienGiangDaySauThue"]))?0.0m:(System.Decimal?)reader["TienGiangDaySauThue"];
					entity.DonGiaChamThiChuan = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.DonGiaChamThiChuan)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.DonGiaChamThiChuan)];
					//entity.DonGiaChamThiChuan = (Convert.IsDBNull(reader["DonGiaChamThiChuan"]))?0.0m:(System.Decimal?)reader["DonGiaChamThiChuan"];
					entity.TienChamThiTruocThue = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienChamThiTruocThue)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienChamThiTruocThue)];
					//entity.TienChamThiTruocThue = (Convert.IsDBNull(reader["TienChamThiTruocThue"]))?0.0m:(System.Decimal?)reader["TienChamThiTruocThue"];
					entity.TienThueChamThi = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienThueChamThi)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienThueChamThi)];
					//entity.TienThueChamThi = (Convert.IsDBNull(reader["TienThueChamThi"]))?0.0m:(System.Decimal?)reader["TienThueChamThi"];
					entity.TienChamThiSauThue = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienChamThiSauThue)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienChamThiSauThue)];
					//entity.TienChamThiSauThue = (Convert.IsDBNull(reader["TienChamThiSauThue"]))?0.0m:(System.Decimal?)reader["TienChamThiSauThue"];
					entity.DonGiaRaDeThiChuan = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.DonGiaRaDeThiChuan)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.DonGiaRaDeThiChuan)];
					//entity.DonGiaRaDeThiChuan = (Convert.IsDBNull(reader["DonGiaRaDeThiChuan"]))?0.0m:(System.Decimal?)reader["DonGiaRaDeThiChuan"];
					entity.TienRaDeTruocThue = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienRaDeTruocThue)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienRaDeTruocThue)];
					//entity.TienRaDeTruocThue = (Convert.IsDBNull(reader["TienRaDeTruocThue"]))?0.0m:(System.Decimal?)reader["TienRaDeTruocThue"];
					entity.TienThueRaDe = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienThueRaDe)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienThueRaDe)];
					//entity.TienThueRaDe = (Convert.IsDBNull(reader["TienThueRaDe"]))?0.0m:(System.Decimal?)reader["TienThueRaDe"];
					entity.TienRaDeSauThue = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienRaDeSauThue)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienRaDeSauThue)];
					//entity.TienRaDeSauThue = (Convert.IsDBNull(reader["TienRaDeSauThue"]))?0.0m:(System.Decimal?)reader["TienRaDeSauThue"];
					entity.HocKy = (System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.HocKy)];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.TenHocKy = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TenHocKy)))?null:(System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TenHocKy)];
					//entity.TenHocKy = (Convert.IsDBNull(reader["TenHocKy"]))?string.Empty:(System.String)reader["TenHocKy"];
					entity.NamHoc = (System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.NamHoc)];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.MaMonHoc = (System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.MaMonHoc)];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.TenMonHoc = (System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TenMonHoc)];
					//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
					entity.TenLopHocPhan = (System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TenLopHocPhan)];
					//entity.TenLopHocPhan = (Convert.IsDBNull(reader["TenLopHocPhan"]))?string.Empty:(System.String)reader["TenLopHocPhan"];
					entity.TenHocPhan = (System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TenHocPhan)];
					//entity.TenHocPhan = (Convert.IsDBNull(reader["TenHocPhan"]))?string.Empty:(System.String)reader["TenHocPhan"];
					entity.MaBacDaoTao = (System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.MaBacDaoTao)];
					//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
					entity.TenBacDaoTao = (System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TenBacDaoTao)];
					//entity.TenBacDaoTao = (Convert.IsDBNull(reader["TenBacDaoTao"]))?string.Empty:(System.String)reader["TenBacDaoTao"];
					entity.MaHeDaoTao = (System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.MaHeDaoTao)];
					//entity.MaHeDaoTao = (Convert.IsDBNull(reader["MaHeDaoTao"]))?string.Empty:(System.String)reader["MaHeDaoTao"];
					entity.TenHeDaoTao = (System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TenHeDaoTao)];
					//entity.TenHeDaoTao = (Convert.IsDBNull(reader["TenHeDaoTao"]))?string.Empty:(System.String)reader["TenHeDaoTao"];
					entity.SoLanDiLai = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.SoLanDiLai)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.SoLanDiLai)];
					//entity.SoLanDiLai = (Convert.IsDBNull(reader["SoLanDiLai"]))?0.0m:(System.Decimal?)reader["SoLanDiLai"];
					entity.SoNgayLuuTru = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.SoNgayLuuTru)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.SoNgayLuuTru)];
					//entity.SoNgayLuuTru = (Convert.IsDBNull(reader["SoNgayLuuTru"]))?0.0m:(System.Decimal?)reader["SoNgayLuuTru"];
					entity.ChiPhiDiLai = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.ChiPhiDiLai)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.ChiPhiDiLai)];
					//entity.ChiPhiDiLai = (Convert.IsDBNull(reader["ChiPhiDiLai"]))?0.0m:(System.Decimal?)reader["ChiPhiDiLai"];
					entity.ChiPhiLuuTru = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.ChiPhiLuuTru)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.ChiPhiLuuTru)];
					//entity.ChiPhiLuuTru = (Convert.IsDBNull(reader["ChiPhiLuuTru"]))?0.0m:(System.Decimal?)reader["ChiPhiLuuTru"];
					entity.TienLuuTruTruocThue = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienLuuTruTruocThue)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienLuuTruTruocThue)];
					//entity.TienLuuTruTruocThue = (Convert.IsDBNull(reader["TienLuuTruTruocThue"]))?0.0m:(System.Decimal?)reader["TienLuuTruTruocThue"];
					entity.TienThueLuuTru = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienThueLuuTru)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienThueLuuTru)];
					//entity.TienThueLuuTru = (Convert.IsDBNull(reader["TienThueLuuTru"]))?0.0m:(System.Decimal?)reader["TienThueLuuTru"];
					entity.TienLuuTruSauThue = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienLuuTruSauThue)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienLuuTruSauThue)];
					//entity.TienLuuTruSauThue = (Convert.IsDBNull(reader["TienLuuTruSauThue"]))?0.0m:(System.Decimal?)reader["TienLuuTruSauThue"];
					entity.TienDiLaiTruocThue = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienDiLaiTruocThue)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienDiLaiTruocThue)];
					//entity.TienDiLaiTruocThue = (Convert.IsDBNull(reader["TienDiLaiTruocThue"]))?0.0m:(System.Decimal?)reader["TienDiLaiTruocThue"];
					entity.TienThueDiLai = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienThueDiLai)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienThueDiLai)];
					//entity.TienThueDiLai = (Convert.IsDBNull(reader["TienThueDiLai"]))?0.0m:(System.Decimal?)reader["TienThueDiLai"];
					entity.TienDiLaiSauThue = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienDiLaiSauThue)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienDiLaiSauThue)];
					//entity.TienDiLaiSauThue = (Convert.IsDBNull(reader["TienDiLaiSauThue"]))?0.0m:(System.Decimal?)reader["TienDiLaiSauThue"];
					entity.HoanTat = (System.Boolean)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.HoanTat)];
					//entity.HoanTat = (Convert.IsDBNull(reader["HoanTat"]))?false:(System.Boolean)reader["HoanTat"];
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
		/// Refreshes the <see cref="ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy entity)
		{
			reader.Read();
			entity.MaQuanLy = (System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.MaQuanLy)];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.MaLopHocPhan = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.MaLopHocPhan)))?null:(System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.MaLopHocPhan)];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			entity.SoLuong = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.SoLuong)))?null:(System.Int32?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.SoLuong)];
			//entity.SoLuong = (Convert.IsDBNull(reader["SoLuong"]))?(int)0:(System.Int32?)reader["SoLuong"];
			entity.TietGiangDay = (System.Int32)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TietGiangDay)];
			//entity.TietGiangDay = (Convert.IsDBNull(reader["TietGiangDay"]))?(int)0:(System.Int32)reader["TietGiangDay"];
			entity.HeSoLopDong = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.HeSoLopDong)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.HeSoLopDong)];
			//entity.HeSoLopDong = (Convert.IsDBNull(reader["HeSoLopDong"]))?0.0m:(System.Decimal?)reader["HeSoLopDong"];
			entity.SoBaiDaCham = (System.Int32)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.SoBaiDaCham)];
			//entity.SoBaiDaCham = (Convert.IsDBNull(reader["SoBaiDaCham"]))?(int)0:(System.Int32)reader["SoBaiDaCham"];
			entity.SoDeThiDapAn = (System.Int32)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.SoDeThiDapAn)];
			//entity.SoDeThiDapAn = (Convert.IsDBNull(reader["SoDeThiDapAn"]))?(int)0:(System.Int32)reader["SoDeThiDapAn"];
			entity.MaLopSinhVien = (System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.MaLopSinhVien)];
			//entity.MaLopSinhVien = (Convert.IsDBNull(reader["MaLopSinhVien"]))?string.Empty:(System.String)reader["MaLopSinhVien"];
			entity.TenLopSinhVien = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TenLopSinhVien)))?null:(System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TenLopSinhVien)];
			//entity.TenLopSinhVien = (Convert.IsDBNull(reader["TenLopSinhVien"]))?string.Empty:(System.String)reader["TenLopSinhVien"];
			entity.HoTen = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.HoTen)))?null:(System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.HoTen)];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.NoiLamViec = (System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.NoiLamViec)];
			//entity.NoiLamViec = (Convert.IsDBNull(reader["NoiLamViec"]))?string.Empty:(System.String)reader["NoiLamViec"];
			entity.MaCoSo = (System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.MaCoSo)];
			//entity.MaCoSo = (Convert.IsDBNull(reader["MaCoSo"]))?string.Empty:(System.String)reader["MaCoSo"];
			entity.TenCoSo = (System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TenCoSo)];
			//entity.TenCoSo = (Convert.IsDBNull(reader["TenCoSo"]))?string.Empty:(System.String)reader["TenCoSo"];
			entity.MaHocVi = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.MaHocVi)))?null:(System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.MaHocVi)];
			//entity.MaHocVi = (Convert.IsDBNull(reader["MaHocVi"]))?string.Empty:(System.String)reader["MaHocVi"];
			entity.TenHocVi = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TenHocVi)))?null:(System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TenHocVi)];
			//entity.TenHocVi = (Convert.IsDBNull(reader["TenHocVi"]))?string.Empty:(System.String)reader["TenHocVi"];
			entity.MaHocHam = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.MaHocHam)))?null:(System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.MaHocHam)];
			//entity.MaHocHam = (Convert.IsDBNull(reader["MaHocHam"]))?string.Empty:(System.String)reader["MaHocHam"];
			entity.TenHocHam = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TenHocHam)))?null:(System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TenHocHam)];
			//entity.TenHocHam = (Convert.IsDBNull(reader["TenHocHam"]))?string.Empty:(System.String)reader["TenHocHam"];
			entity.HeSoTinChi = (System.Decimal)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.HeSoTinChi)];
			//entity.HeSoTinChi = (Convert.IsDBNull(reader["HeSoTinChi"]))?0.0m:(System.Decimal)reader["HeSoTinChi"];
			entity.DonGiaMotTiet = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.DonGiaMotTiet)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.DonGiaMotTiet)];
			//entity.DonGiaMotTiet = (Convert.IsDBNull(reader["DonGiaMotTiet"]))?0.0m:(System.Decimal?)reader["DonGiaMotTiet"];
			entity.TienGiangDayTruocThue = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienGiangDayTruocThue)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienGiangDayTruocThue)];
			//entity.TienGiangDayTruocThue = (Convert.IsDBNull(reader["TienGiangDayTruocThue"]))?0.0m:(System.Decimal?)reader["TienGiangDayTruocThue"];
			entity.TienThueGiangDay = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienThueGiangDay)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienThueGiangDay)];
			//entity.TienThueGiangDay = (Convert.IsDBNull(reader["TienThueGiangDay"]))?0.0m:(System.Decimal?)reader["TienThueGiangDay"];
			entity.TienGiangDaySauThue = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienGiangDaySauThue)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienGiangDaySauThue)];
			//entity.TienGiangDaySauThue = (Convert.IsDBNull(reader["TienGiangDaySauThue"]))?0.0m:(System.Decimal?)reader["TienGiangDaySauThue"];
			entity.DonGiaChamThiChuan = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.DonGiaChamThiChuan)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.DonGiaChamThiChuan)];
			//entity.DonGiaChamThiChuan = (Convert.IsDBNull(reader["DonGiaChamThiChuan"]))?0.0m:(System.Decimal?)reader["DonGiaChamThiChuan"];
			entity.TienChamThiTruocThue = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienChamThiTruocThue)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienChamThiTruocThue)];
			//entity.TienChamThiTruocThue = (Convert.IsDBNull(reader["TienChamThiTruocThue"]))?0.0m:(System.Decimal?)reader["TienChamThiTruocThue"];
			entity.TienThueChamThi = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienThueChamThi)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienThueChamThi)];
			//entity.TienThueChamThi = (Convert.IsDBNull(reader["TienThueChamThi"]))?0.0m:(System.Decimal?)reader["TienThueChamThi"];
			entity.TienChamThiSauThue = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienChamThiSauThue)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienChamThiSauThue)];
			//entity.TienChamThiSauThue = (Convert.IsDBNull(reader["TienChamThiSauThue"]))?0.0m:(System.Decimal?)reader["TienChamThiSauThue"];
			entity.DonGiaRaDeThiChuan = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.DonGiaRaDeThiChuan)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.DonGiaRaDeThiChuan)];
			//entity.DonGiaRaDeThiChuan = (Convert.IsDBNull(reader["DonGiaRaDeThiChuan"]))?0.0m:(System.Decimal?)reader["DonGiaRaDeThiChuan"];
			entity.TienRaDeTruocThue = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienRaDeTruocThue)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienRaDeTruocThue)];
			//entity.TienRaDeTruocThue = (Convert.IsDBNull(reader["TienRaDeTruocThue"]))?0.0m:(System.Decimal?)reader["TienRaDeTruocThue"];
			entity.TienThueRaDe = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienThueRaDe)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienThueRaDe)];
			//entity.TienThueRaDe = (Convert.IsDBNull(reader["TienThueRaDe"]))?0.0m:(System.Decimal?)reader["TienThueRaDe"];
			entity.TienRaDeSauThue = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienRaDeSauThue)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienRaDeSauThue)];
			//entity.TienRaDeSauThue = (Convert.IsDBNull(reader["TienRaDeSauThue"]))?0.0m:(System.Decimal?)reader["TienRaDeSauThue"];
			entity.HocKy = (System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.HocKy)];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.TenHocKy = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TenHocKy)))?null:(System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TenHocKy)];
			//entity.TenHocKy = (Convert.IsDBNull(reader["TenHocKy"]))?string.Empty:(System.String)reader["TenHocKy"];
			entity.NamHoc = (System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.NamHoc)];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.MaMonHoc = (System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.MaMonHoc)];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.TenMonHoc = (System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TenMonHoc)];
			//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
			entity.TenLopHocPhan = (System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TenLopHocPhan)];
			//entity.TenLopHocPhan = (Convert.IsDBNull(reader["TenLopHocPhan"]))?string.Empty:(System.String)reader["TenLopHocPhan"];
			entity.TenHocPhan = (System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TenHocPhan)];
			//entity.TenHocPhan = (Convert.IsDBNull(reader["TenHocPhan"]))?string.Empty:(System.String)reader["TenHocPhan"];
			entity.MaBacDaoTao = (System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.MaBacDaoTao)];
			//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
			entity.TenBacDaoTao = (System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TenBacDaoTao)];
			//entity.TenBacDaoTao = (Convert.IsDBNull(reader["TenBacDaoTao"]))?string.Empty:(System.String)reader["TenBacDaoTao"];
			entity.MaHeDaoTao = (System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.MaHeDaoTao)];
			//entity.MaHeDaoTao = (Convert.IsDBNull(reader["MaHeDaoTao"]))?string.Empty:(System.String)reader["MaHeDaoTao"];
			entity.TenHeDaoTao = (System.String)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TenHeDaoTao)];
			//entity.TenHeDaoTao = (Convert.IsDBNull(reader["TenHeDaoTao"]))?string.Empty:(System.String)reader["TenHeDaoTao"];
			entity.SoLanDiLai = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.SoLanDiLai)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.SoLanDiLai)];
			//entity.SoLanDiLai = (Convert.IsDBNull(reader["SoLanDiLai"]))?0.0m:(System.Decimal?)reader["SoLanDiLai"];
			entity.SoNgayLuuTru = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.SoNgayLuuTru)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.SoNgayLuuTru)];
			//entity.SoNgayLuuTru = (Convert.IsDBNull(reader["SoNgayLuuTru"]))?0.0m:(System.Decimal?)reader["SoNgayLuuTru"];
			entity.ChiPhiDiLai = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.ChiPhiDiLai)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.ChiPhiDiLai)];
			//entity.ChiPhiDiLai = (Convert.IsDBNull(reader["ChiPhiDiLai"]))?0.0m:(System.Decimal?)reader["ChiPhiDiLai"];
			entity.ChiPhiLuuTru = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.ChiPhiLuuTru)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.ChiPhiLuuTru)];
			//entity.ChiPhiLuuTru = (Convert.IsDBNull(reader["ChiPhiLuuTru"]))?0.0m:(System.Decimal?)reader["ChiPhiLuuTru"];
			entity.TienLuuTruTruocThue = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienLuuTruTruocThue)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienLuuTruTruocThue)];
			//entity.TienLuuTruTruocThue = (Convert.IsDBNull(reader["TienLuuTruTruocThue"]))?0.0m:(System.Decimal?)reader["TienLuuTruTruocThue"];
			entity.TienThueLuuTru = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienThueLuuTru)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienThueLuuTru)];
			//entity.TienThueLuuTru = (Convert.IsDBNull(reader["TienThueLuuTru"]))?0.0m:(System.Decimal?)reader["TienThueLuuTru"];
			entity.TienLuuTruSauThue = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienLuuTruSauThue)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienLuuTruSauThue)];
			//entity.TienLuuTruSauThue = (Convert.IsDBNull(reader["TienLuuTruSauThue"]))?0.0m:(System.Decimal?)reader["TienLuuTruSauThue"];
			entity.TienDiLaiTruocThue = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienDiLaiTruocThue)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienDiLaiTruocThue)];
			//entity.TienDiLaiTruocThue = (Convert.IsDBNull(reader["TienDiLaiTruocThue"]))?0.0m:(System.Decimal?)reader["TienDiLaiTruocThue"];
			entity.TienThueDiLai = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienThueDiLai)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienThueDiLai)];
			//entity.TienThueDiLai = (Convert.IsDBNull(reader["TienThueDiLai"]))?0.0m:(System.Decimal?)reader["TienThueDiLai"];
			entity.TienDiLaiSauThue = (reader.IsDBNull(((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienDiLaiSauThue)))?null:(System.Decimal?)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.TienDiLaiSauThue)];
			//entity.TienDiLaiSauThue = (Convert.IsDBNull(reader["TienDiLaiSauThue"]))?0.0m:(System.Decimal?)reader["TienDiLaiSauThue"];
			entity.HoanTat = (System.Boolean)reader[((int)ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn.HoanTat)];
			//entity.HoanTat = (Convert.IsDBNull(reader["HoanTat"]))?false:(System.Boolean)reader["HoanTat"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.MaLopHocPhan = (Convert.IsDBNull(dataRow["MaLopHocPhan"]))?string.Empty:(System.String)dataRow["MaLopHocPhan"];
			entity.SoLuong = (Convert.IsDBNull(dataRow["SoLuong"]))?(int)0:(System.Int32?)dataRow["SoLuong"];
			entity.TietGiangDay = (Convert.IsDBNull(dataRow["TietGiangDay"]))?(int)0:(System.Int32)dataRow["TietGiangDay"];
			entity.HeSoLopDong = (Convert.IsDBNull(dataRow["HeSoLopDong"]))?0.0m:(System.Decimal?)dataRow["HeSoLopDong"];
			entity.SoBaiDaCham = (Convert.IsDBNull(dataRow["SoBaiDaCham"]))?(int)0:(System.Int32)dataRow["SoBaiDaCham"];
			entity.SoDeThiDapAn = (Convert.IsDBNull(dataRow["SoDeThiDapAn"]))?(int)0:(System.Int32)dataRow["SoDeThiDapAn"];
			entity.MaLopSinhVien = (Convert.IsDBNull(dataRow["MaLopSinhVien"]))?string.Empty:(System.String)dataRow["MaLopSinhVien"];
			entity.TenLopSinhVien = (Convert.IsDBNull(dataRow["TenLopSinhVien"]))?string.Empty:(System.String)dataRow["TenLopSinhVien"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.NoiLamViec = (Convert.IsDBNull(dataRow["NoiLamViec"]))?string.Empty:(System.String)dataRow["NoiLamViec"];
			entity.MaCoSo = (Convert.IsDBNull(dataRow["MaCoSo"]))?string.Empty:(System.String)dataRow["MaCoSo"];
			entity.TenCoSo = (Convert.IsDBNull(dataRow["TenCoSo"]))?string.Empty:(System.String)dataRow["TenCoSo"];
			entity.MaHocVi = (Convert.IsDBNull(dataRow["MaHocVi"]))?string.Empty:(System.String)dataRow["MaHocVi"];
			entity.TenHocVi = (Convert.IsDBNull(dataRow["TenHocVi"]))?string.Empty:(System.String)dataRow["TenHocVi"];
			entity.MaHocHam = (Convert.IsDBNull(dataRow["MaHocHam"]))?string.Empty:(System.String)dataRow["MaHocHam"];
			entity.TenHocHam = (Convert.IsDBNull(dataRow["TenHocHam"]))?string.Empty:(System.String)dataRow["TenHocHam"];
			entity.HeSoTinChi = (Convert.IsDBNull(dataRow["HeSoTinChi"]))?0.0m:(System.Decimal)dataRow["HeSoTinChi"];
			entity.DonGiaMotTiet = (Convert.IsDBNull(dataRow["DonGiaMotTiet"]))?0.0m:(System.Decimal?)dataRow["DonGiaMotTiet"];
			entity.TienGiangDayTruocThue = (Convert.IsDBNull(dataRow["TienGiangDayTruocThue"]))?0.0m:(System.Decimal?)dataRow["TienGiangDayTruocThue"];
			entity.TienThueGiangDay = (Convert.IsDBNull(dataRow["TienThueGiangDay"]))?0.0m:(System.Decimal?)dataRow["TienThueGiangDay"];
			entity.TienGiangDaySauThue = (Convert.IsDBNull(dataRow["TienGiangDaySauThue"]))?0.0m:(System.Decimal?)dataRow["TienGiangDaySauThue"];
			entity.DonGiaChamThiChuan = (Convert.IsDBNull(dataRow["DonGiaChamThiChuan"]))?0.0m:(System.Decimal?)dataRow["DonGiaChamThiChuan"];
			entity.TienChamThiTruocThue = (Convert.IsDBNull(dataRow["TienChamThiTruocThue"]))?0.0m:(System.Decimal?)dataRow["TienChamThiTruocThue"];
			entity.TienThueChamThi = (Convert.IsDBNull(dataRow["TienThueChamThi"]))?0.0m:(System.Decimal?)dataRow["TienThueChamThi"];
			entity.TienChamThiSauThue = (Convert.IsDBNull(dataRow["TienChamThiSauThue"]))?0.0m:(System.Decimal?)dataRow["TienChamThiSauThue"];
			entity.DonGiaRaDeThiChuan = (Convert.IsDBNull(dataRow["DonGiaRaDeThiChuan"]))?0.0m:(System.Decimal?)dataRow["DonGiaRaDeThiChuan"];
			entity.TienRaDeTruocThue = (Convert.IsDBNull(dataRow["TienRaDeTruocThue"]))?0.0m:(System.Decimal?)dataRow["TienRaDeTruocThue"];
			entity.TienThueRaDe = (Convert.IsDBNull(dataRow["TienThueRaDe"]))?0.0m:(System.Decimal?)dataRow["TienThueRaDe"];
			entity.TienRaDeSauThue = (Convert.IsDBNull(dataRow["TienRaDeSauThue"]))?0.0m:(System.Decimal?)dataRow["TienRaDeSauThue"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.TenHocKy = (Convert.IsDBNull(dataRow["TenHocKy"]))?string.Empty:(System.String)dataRow["TenHocKy"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.MaMonHoc = (Convert.IsDBNull(dataRow["MaMonHoc"]))?string.Empty:(System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = (Convert.IsDBNull(dataRow["TenMonHoc"]))?string.Empty:(System.String)dataRow["TenMonHoc"];
			entity.TenLopHocPhan = (Convert.IsDBNull(dataRow["TenLopHocPhan"]))?string.Empty:(System.String)dataRow["TenLopHocPhan"];
			entity.TenHocPhan = (Convert.IsDBNull(dataRow["TenHocPhan"]))?string.Empty:(System.String)dataRow["TenHocPhan"];
			entity.MaBacDaoTao = (Convert.IsDBNull(dataRow["MaBacDaoTao"]))?string.Empty:(System.String)dataRow["MaBacDaoTao"];
			entity.TenBacDaoTao = (Convert.IsDBNull(dataRow["TenBacDaoTao"]))?string.Empty:(System.String)dataRow["TenBacDaoTao"];
			entity.MaHeDaoTao = (Convert.IsDBNull(dataRow["MaHeDaoTao"]))?string.Empty:(System.String)dataRow["MaHeDaoTao"];
			entity.TenHeDaoTao = (Convert.IsDBNull(dataRow["TenHeDaoTao"]))?string.Empty:(System.String)dataRow["TenHeDaoTao"];
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
			entity.HoanTat = (Convert.IsDBNull(dataRow["HoanTat"]))?false:(System.Boolean)dataRow["HoanTat"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyFilterBuilder : SqlFilterBuilder<ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyFilterBuilder class.
		/// </summary>
		public ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyFilterBuilder

	#region ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyParameterBuilder : ParameterizedSqlFilterBuilder<ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyParameterBuilder class.
		/// </summary>
		public ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyParameterBuilder
	
	#region ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKy"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKySortBuilder : SqlSortBuilder<ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKyColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKySqlSortBuilder class.
		/// </summary>
		public ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewBangChietTinhGiangDayRaDeChamThiLan1NamHocHocKySortBuilder

} // end namespace
