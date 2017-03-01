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
	/// This class is the base class for any <see cref="ViewTongHopGioDayGiangVienProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewTongHopGioDayGiangVienProviderBaseCore : EntityViewProviderBase<ViewTongHopGioDayGiangVien>
	{
		#region Custom Methods
		
		
		#region cust_View_TongHopGioDay_GiangVien_GetByNamHocHocKyMaBacDaoTao
		
		/// <summary>
		///	This method wrap the 'cust_View_TongHopGioDay_GiangVien_GetByNamHocHocKyMaBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <param name="khoahoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyMaBacDaoTao(System.String maBacDaoTao, System.String maHeDaoTao, System.Int32 maLoaiGiangVien, System.String namHoc, System.String hocKy, System.String maKhoa, System.String khoahoc)
		{
			return GetByNamHocHocKyMaBacDaoTao(null, 0, int.MaxValue , maBacDaoTao, maHeDaoTao, maLoaiGiangVien, namHoc, hocKy, maKhoa, khoahoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_TongHopGioDay_GiangVien_GetByNamHocHocKyMaBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <param name="khoahoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyMaBacDaoTao(int start, int pageLength, System.String maBacDaoTao, System.String maHeDaoTao, System.Int32 maLoaiGiangVien, System.String namHoc, System.String hocKy, System.String maKhoa, System.String khoahoc)
		{
			return GetByNamHocHocKyMaBacDaoTao(null, start, pageLength , maBacDaoTao, maHeDaoTao, maLoaiGiangVien, namHoc, hocKy, maKhoa, khoahoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_TongHopGioDay_GiangVien_GetByNamHocHocKyMaBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <param name="khoahoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyMaBacDaoTao(TransactionManager transactionManager, System.String maBacDaoTao, System.String maHeDaoTao, System.Int32 maLoaiGiangVien, System.String namHoc, System.String hocKy, System.String maKhoa, System.String khoahoc)
		{
			return GetByNamHocHocKyMaBacDaoTao(transactionManager, 0, int.MaxValue , maBacDaoTao, maHeDaoTao, maLoaiGiangVien, namHoc, hocKy, maKhoa, khoahoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_TongHopGioDay_GiangVien_GetByNamHocHocKyMaBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <param name="khoahoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKyMaBacDaoTao(TransactionManager transactionManager, int start, int pageLength, System.String maBacDaoTao, System.String maHeDaoTao, System.Int32 maLoaiGiangVien, System.String namHoc, System.String hocKy, System.String maKhoa, System.String khoahoc);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewTongHopGioDayGiangVien&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewTongHopGioDayGiangVien&gt;"/></returns>
		protected static VList&lt;ViewTongHopGioDayGiangVien&gt; Fill(DataSet dataSet, VList<ViewTongHopGioDayGiangVien> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewTongHopGioDayGiangVien>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewTongHopGioDayGiangVien&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewTongHopGioDayGiangVien>"/></returns>
		protected static VList&lt;ViewTongHopGioDayGiangVien&gt; Fill(DataTable dataTable, VList<ViewTongHopGioDayGiangVien> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewTongHopGioDayGiangVien c = new ViewTongHopGioDayGiangVien();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?string.Empty:(System.String)row["MaGiangVien"];
					c.Ho = (Convert.IsDBNull(row["Ho"]))?string.Empty:(System.String)row["Ho"];
					c.TenDem = (Convert.IsDBNull(row["TenDem"]))?string.Empty:(System.String)row["TenDem"];
					c.Ten = (Convert.IsDBNull(row["Ten"]))?string.Empty:(System.String)row["Ten"];
					c.MaLoaiGiangVien = (Convert.IsDBNull(row["MaLoaiGiangVien"]))?(int)0:(System.Int32?)row["MaLoaiGiangVien"];
					c.MaDonVi = (Convert.IsDBNull(row["MaDonVi"]))?string.Empty:(System.String)row["MaDonVi"];
					c.MaLop = (Convert.IsDBNull(row["MaLop"]))?string.Empty:(System.String)row["MaLop"];
					c.MaMonHoc = (Convert.IsDBNull(row["MaMonHoc"]))?string.Empty:(System.String)row["MaMonHoc"];
					c.TenMonHoc = (Convert.IsDBNull(row["TenMonHoc"]))?string.Empty:(System.String)row["TenMonHoc"];
					c.SiSoLop = (Convert.IsDBNull(row["SiSoLop"]))?(int)0:(System.Int32?)row["SiSoLop"];
					c.LoaiHocPhan = (Convert.IsDBNull(row["LoaiHocPhan"]))?string.Empty:(System.String)row["LoaiHocPhan"];
					c.HeSoLopDong = (Convert.IsDBNull(row["HeSoLopDong"]))?0.0m:(System.Decimal?)row["HeSoLopDong"];
					c.MaLopHocPhan = (Convert.IsDBNull(row["MaLopHocPhan"]))?string.Empty:(System.String)row["MaLopHocPhan"];
					c.MaBacDaoTao = (Convert.IsDBNull(row["MaBacDaoTao"]))?string.Empty:(System.String)row["MaBacDaoTao"];
					c.TenBacDaoTao = (Convert.IsDBNull(row["TenBacDaoTao"]))?string.Empty:(System.String)row["TenBacDaoTao"];
					c.MaHeDaoTao = (Convert.IsDBNull(row["MaHeDaoTao"]))?string.Empty:(System.String)row["MaHeDaoTao"];
					c.TenHeDaoTao = (Convert.IsDBNull(row["TenHeDaoTao"]))?string.Empty:(System.String)row["TenHeDaoTao"];
					c.MaKhoaHoc = (Convert.IsDBNull(row["MaKhoaHoc"]))?string.Empty:(System.String)row["MaKhoaHoc"];
					c.TenKhoaHoc = (Convert.IsDBNull(row["TenKhoaHoc"]))?string.Empty:(System.String)row["TenKhoaHoc"];
					c.ThucHanh = (Convert.IsDBNull(row["ThucHanh"]))?0.0m:(System.Decimal?)row["ThucHanh"];
					c.LyThuyet = (Convert.IsDBNull(row["LyThuyet"]))?0.0m:(System.Decimal?)row["LyThuyet"];
					c.Tong = (Convert.IsDBNull(row["Tong"]))?0.0m:(System.Decimal?)row["Tong"];
					c.TongHs = (Convert.IsDBNull(row["TongHS"]))?0.0m:(System.Decimal?)row["TongHS"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
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
		/// Fill an <see cref="VList&lt;ViewTongHopGioDayGiangVien&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewTongHopGioDayGiangVien&gt;"/></returns>
		protected VList<ViewTongHopGioDayGiangVien> Fill(IDataReader reader, VList<ViewTongHopGioDayGiangVien> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewTongHopGioDayGiangVien entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewTongHopGioDayGiangVien>("ViewTongHopGioDayGiangVien",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewTongHopGioDayGiangVien();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = (System.String)reader["MaGiangVien"];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?string.Empty:(System.String)reader["MaGiangVien"];
					entity.Ho = reader.IsDBNull(reader.GetOrdinal("Ho")) ? null : (System.String)reader["Ho"];
					//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
					entity.TenDem = reader.IsDBNull(reader.GetOrdinal("TenDem")) ? null : (System.String)reader["TenDem"];
					//entity.TenDem = (Convert.IsDBNull(reader["TenDem"]))?string.Empty:(System.String)reader["TenDem"];
					entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
					//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
					entity.MaLoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("MaLoaiGiangVien")) ? null : (System.Int32?)reader["MaLoaiGiangVien"];
					//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32?)reader["MaLoaiGiangVien"];
					entity.MaDonVi = reader.IsDBNull(reader.GetOrdinal("MaDonVi")) ? null : (System.String)reader["MaDonVi"];
					//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
					entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
					//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
					entity.MaMonHoc = (System.String)reader["MaMonHoc"];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.TenMonHoc = (System.String)reader["TenMonHoc"];
					//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
					entity.SiSoLop = reader.IsDBNull(reader.GetOrdinal("SiSoLop")) ? null : (System.Int32?)reader["SiSoLop"];
					//entity.SiSoLop = (Convert.IsDBNull(reader["SiSoLop"]))?(int)0:(System.Int32?)reader["SiSoLop"];
					entity.LoaiHocPhan = reader.IsDBNull(reader.GetOrdinal("LoaiHocPhan")) ? null : (System.String)reader["LoaiHocPhan"];
					//entity.LoaiHocPhan = (Convert.IsDBNull(reader["LoaiHocPhan"]))?string.Empty:(System.String)reader["LoaiHocPhan"];
					entity.HeSoLopDong = reader.IsDBNull(reader.GetOrdinal("HeSoLopDong")) ? null : (System.Decimal?)reader["HeSoLopDong"];
					//entity.HeSoLopDong = (Convert.IsDBNull(reader["HeSoLopDong"]))?0.0m:(System.Decimal?)reader["HeSoLopDong"];
					entity.MaLopHocPhan = reader.IsDBNull(reader.GetOrdinal("MaLopHocPhan")) ? null : (System.String)reader["MaLopHocPhan"];
					//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
					entity.MaBacDaoTao = (System.String)reader["MaBacDaoTao"];
					//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
					entity.TenBacDaoTao = (System.String)reader["TenBacDaoTao"];
					//entity.TenBacDaoTao = (Convert.IsDBNull(reader["TenBacDaoTao"]))?string.Empty:(System.String)reader["TenBacDaoTao"];
					entity.MaHeDaoTao = (System.String)reader["MaHeDaoTao"];
					//entity.MaHeDaoTao = (Convert.IsDBNull(reader["MaHeDaoTao"]))?string.Empty:(System.String)reader["MaHeDaoTao"];
					entity.TenHeDaoTao = reader.IsDBNull(reader.GetOrdinal("TenHeDaoTao")) ? null : (System.String)reader["TenHeDaoTao"];
					//entity.TenHeDaoTao = (Convert.IsDBNull(reader["TenHeDaoTao"]))?string.Empty:(System.String)reader["TenHeDaoTao"];
					entity.MaKhoaHoc = (System.String)reader["MaKhoaHoc"];
					//entity.MaKhoaHoc = (Convert.IsDBNull(reader["MaKhoaHoc"]))?string.Empty:(System.String)reader["MaKhoaHoc"];
					entity.TenKhoaHoc = (System.String)reader["TenKhoaHoc"];
					//entity.TenKhoaHoc = (Convert.IsDBNull(reader["TenKhoaHoc"]))?string.Empty:(System.String)reader["TenKhoaHoc"];
					entity.ThucHanh = reader.IsDBNull(reader.GetOrdinal("ThucHanh")) ? null : (System.Decimal?)reader["ThucHanh"];
					//entity.ThucHanh = (Convert.IsDBNull(reader["ThucHanh"]))?0.0m:(System.Decimal?)reader["ThucHanh"];
					entity.LyThuyet = reader.IsDBNull(reader.GetOrdinal("LyThuyet")) ? null : (System.Decimal?)reader["LyThuyet"];
					//entity.LyThuyet = (Convert.IsDBNull(reader["LyThuyet"]))?0.0m:(System.Decimal?)reader["LyThuyet"];
					entity.Tong = reader.IsDBNull(reader.GetOrdinal("Tong")) ? null : (System.Decimal?)reader["Tong"];
					//entity.Tong = (Convert.IsDBNull(reader["Tong"]))?0.0m:(System.Decimal?)reader["Tong"];
					entity.TongHs = reader.IsDBNull(reader.GetOrdinal("TongHs")) ? null : (System.Decimal?)reader["TongHs"];
					//entity.TongHs = (Convert.IsDBNull(reader["TongHS"]))?0.0m:(System.Decimal?)reader["TongHS"];
					entity.HocKy = (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.NamHoc = (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
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
		/// Refreshes the <see cref="ViewTongHopGioDayGiangVien"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewTongHopGioDayGiangVien"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewTongHopGioDayGiangVien entity)
		{
			reader.Read();
			entity.MaGiangVien = (System.String)reader["MaGiangVien"];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?string.Empty:(System.String)reader["MaGiangVien"];
			entity.Ho = reader.IsDBNull(reader.GetOrdinal("Ho")) ? null : (System.String)reader["Ho"];
			//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
			entity.TenDem = reader.IsDBNull(reader.GetOrdinal("TenDem")) ? null : (System.String)reader["TenDem"];
			//entity.TenDem = (Convert.IsDBNull(reader["TenDem"]))?string.Empty:(System.String)reader["TenDem"];
			entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
			//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
			entity.MaLoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("MaLoaiGiangVien")) ? null : (System.Int32?)reader["MaLoaiGiangVien"];
			//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32?)reader["MaLoaiGiangVien"];
			entity.MaDonVi = reader.IsDBNull(reader.GetOrdinal("MaDonVi")) ? null : (System.String)reader["MaDonVi"];
			//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
			entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
			//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
			entity.MaMonHoc = (System.String)reader["MaMonHoc"];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.TenMonHoc = (System.String)reader["TenMonHoc"];
			//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
			entity.SiSoLop = reader.IsDBNull(reader.GetOrdinal("SiSoLop")) ? null : (System.Int32?)reader["SiSoLop"];
			//entity.SiSoLop = (Convert.IsDBNull(reader["SiSoLop"]))?(int)0:(System.Int32?)reader["SiSoLop"];
			entity.LoaiHocPhan = reader.IsDBNull(reader.GetOrdinal("LoaiHocPhan")) ? null : (System.String)reader["LoaiHocPhan"];
			//entity.LoaiHocPhan = (Convert.IsDBNull(reader["LoaiHocPhan"]))?string.Empty:(System.String)reader["LoaiHocPhan"];
			entity.HeSoLopDong = reader.IsDBNull(reader.GetOrdinal("HeSoLopDong")) ? null : (System.Decimal?)reader["HeSoLopDong"];
			//entity.HeSoLopDong = (Convert.IsDBNull(reader["HeSoLopDong"]))?0.0m:(System.Decimal?)reader["HeSoLopDong"];
			entity.MaLopHocPhan = reader.IsDBNull(reader.GetOrdinal("MaLopHocPhan")) ? null : (System.String)reader["MaLopHocPhan"];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			entity.MaBacDaoTao = (System.String)reader["MaBacDaoTao"];
			//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
			entity.TenBacDaoTao = (System.String)reader["TenBacDaoTao"];
			//entity.TenBacDaoTao = (Convert.IsDBNull(reader["TenBacDaoTao"]))?string.Empty:(System.String)reader["TenBacDaoTao"];
			entity.MaHeDaoTao = (System.String)reader["MaHeDaoTao"];
			//entity.MaHeDaoTao = (Convert.IsDBNull(reader["MaHeDaoTao"]))?string.Empty:(System.String)reader["MaHeDaoTao"];
			entity.TenHeDaoTao = reader.IsDBNull(reader.GetOrdinal("TenHeDaoTao")) ? null : (System.String)reader["TenHeDaoTao"];
			//entity.TenHeDaoTao = (Convert.IsDBNull(reader["TenHeDaoTao"]))?string.Empty:(System.String)reader["TenHeDaoTao"];
			entity.MaKhoaHoc = (System.String)reader["MaKhoaHoc"];
			//entity.MaKhoaHoc = (Convert.IsDBNull(reader["MaKhoaHoc"]))?string.Empty:(System.String)reader["MaKhoaHoc"];
			entity.TenKhoaHoc = (System.String)reader["TenKhoaHoc"];
			//entity.TenKhoaHoc = (Convert.IsDBNull(reader["TenKhoaHoc"]))?string.Empty:(System.String)reader["TenKhoaHoc"];
			entity.ThucHanh = reader.IsDBNull(reader.GetOrdinal("ThucHanh")) ? null : (System.Decimal?)reader["ThucHanh"];
			//entity.ThucHanh = (Convert.IsDBNull(reader["ThucHanh"]))?0.0m:(System.Decimal?)reader["ThucHanh"];
			entity.LyThuyet = reader.IsDBNull(reader.GetOrdinal("LyThuyet")) ? null : (System.Decimal?)reader["LyThuyet"];
			//entity.LyThuyet = (Convert.IsDBNull(reader["LyThuyet"]))?0.0m:(System.Decimal?)reader["LyThuyet"];
			entity.Tong = reader.IsDBNull(reader.GetOrdinal("Tong")) ? null : (System.Decimal?)reader["Tong"];
			//entity.Tong = (Convert.IsDBNull(reader["Tong"]))?0.0m:(System.Decimal?)reader["Tong"];
			entity.TongHs = reader.IsDBNull(reader.GetOrdinal("TongHs")) ? null : (System.Decimal?)reader["TongHs"];
			//entity.TongHs = (Convert.IsDBNull(reader["TongHS"]))?0.0m:(System.Decimal?)reader["TongHS"];
			entity.HocKy = (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.NamHoc = (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewTongHopGioDayGiangVien"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewTongHopGioDayGiangVien"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewTongHopGioDayGiangVien entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?string.Empty:(System.String)dataRow["MaGiangVien"];
			entity.Ho = (Convert.IsDBNull(dataRow["Ho"]))?string.Empty:(System.String)dataRow["Ho"];
			entity.TenDem = (Convert.IsDBNull(dataRow["TenDem"]))?string.Empty:(System.String)dataRow["TenDem"];
			entity.Ten = (Convert.IsDBNull(dataRow["Ten"]))?string.Empty:(System.String)dataRow["Ten"];
			entity.MaLoaiGiangVien = (Convert.IsDBNull(dataRow["MaLoaiGiangVien"]))?(int)0:(System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.MaDonVi = (Convert.IsDBNull(dataRow["MaDonVi"]))?string.Empty:(System.String)dataRow["MaDonVi"];
			entity.MaLop = (Convert.IsDBNull(dataRow["MaLop"]))?string.Empty:(System.String)dataRow["MaLop"];
			entity.MaMonHoc = (Convert.IsDBNull(dataRow["MaMonHoc"]))?string.Empty:(System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = (Convert.IsDBNull(dataRow["TenMonHoc"]))?string.Empty:(System.String)dataRow["TenMonHoc"];
			entity.SiSoLop = (Convert.IsDBNull(dataRow["SiSoLop"]))?(int)0:(System.Int32?)dataRow["SiSoLop"];
			entity.LoaiHocPhan = (Convert.IsDBNull(dataRow["LoaiHocPhan"]))?string.Empty:(System.String)dataRow["LoaiHocPhan"];
			entity.HeSoLopDong = (Convert.IsDBNull(dataRow["HeSoLopDong"]))?0.0m:(System.Decimal?)dataRow["HeSoLopDong"];
			entity.MaLopHocPhan = (Convert.IsDBNull(dataRow["MaLopHocPhan"]))?string.Empty:(System.String)dataRow["MaLopHocPhan"];
			entity.MaBacDaoTao = (Convert.IsDBNull(dataRow["MaBacDaoTao"]))?string.Empty:(System.String)dataRow["MaBacDaoTao"];
			entity.TenBacDaoTao = (Convert.IsDBNull(dataRow["TenBacDaoTao"]))?string.Empty:(System.String)dataRow["TenBacDaoTao"];
			entity.MaHeDaoTao = (Convert.IsDBNull(dataRow["MaHeDaoTao"]))?string.Empty:(System.String)dataRow["MaHeDaoTao"];
			entity.TenHeDaoTao = (Convert.IsDBNull(dataRow["TenHeDaoTao"]))?string.Empty:(System.String)dataRow["TenHeDaoTao"];
			entity.MaKhoaHoc = (Convert.IsDBNull(dataRow["MaKhoaHoc"]))?string.Empty:(System.String)dataRow["MaKhoaHoc"];
			entity.TenKhoaHoc = (Convert.IsDBNull(dataRow["TenKhoaHoc"]))?string.Empty:(System.String)dataRow["TenKhoaHoc"];
			entity.ThucHanh = (Convert.IsDBNull(dataRow["ThucHanh"]))?0.0m:(System.Decimal?)dataRow["ThucHanh"];
			entity.LyThuyet = (Convert.IsDBNull(dataRow["LyThuyet"]))?0.0m:(System.Decimal?)dataRow["LyThuyet"];
			entity.Tong = (Convert.IsDBNull(dataRow["Tong"]))?0.0m:(System.Decimal?)dataRow["Tong"];
			entity.TongHs = (Convert.IsDBNull(dataRow["TongHS"]))?0.0m:(System.Decimal?)dataRow["TongHS"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewTongHopGioDayGiangVienFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTongHopGioDayGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTongHopGioDayGiangVienFilterBuilder : SqlFilterBuilder<ViewTongHopGioDayGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTongHopGioDayGiangVienFilterBuilder class.
		/// </summary>
		public ViewTongHopGioDayGiangVienFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewTongHopGioDayGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewTongHopGioDayGiangVienFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewTongHopGioDayGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewTongHopGioDayGiangVienFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewTongHopGioDayGiangVienFilterBuilder

	#region ViewTongHopGioDayGiangVienParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTongHopGioDayGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTongHopGioDayGiangVienParameterBuilder : ParameterizedSqlFilterBuilder<ViewTongHopGioDayGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTongHopGioDayGiangVienParameterBuilder class.
		/// </summary>
		public ViewTongHopGioDayGiangVienParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewTongHopGioDayGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewTongHopGioDayGiangVienParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewTongHopGioDayGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewTongHopGioDayGiangVienParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewTongHopGioDayGiangVienParameterBuilder
	
	#region ViewTongHopGioDayGiangVienSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTongHopGioDayGiangVien"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewTongHopGioDayGiangVienSortBuilder : SqlSortBuilder<ViewTongHopGioDayGiangVienColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTongHopGioDayGiangVienSqlSortBuilder class.
		/// </summary>
		public ViewTongHopGioDayGiangVienSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewTongHopGioDayGiangVienSortBuilder

} // end namespace
