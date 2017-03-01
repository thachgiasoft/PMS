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
	/// This class is the base class for any <see cref="ViewBangPhuTroiGioDayGiangVienProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewBangPhuTroiGioDayGiangVienProviderBaseCore : EntityViewProviderBase<ViewBangPhuTroiGioDayGiangVien>
	{
		#region Custom Methods
		
		
		#region cust_View_BangPhuTroiGioDay_GiangVien_GetByNamHocMaLoaiGiangVienMaDonVi
		
		/// <summary>
		///	This method wrap the 'cust_View_BangPhuTroiGioDay_GiangVien_GetByNamHocMaLoaiGiangVienMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewBangPhuTroiGioDayGiangVien&gt;"/> instance.</returns>
		public VList<ViewBangPhuTroiGioDayGiangVien> GetByNamHocMaLoaiGiangVienMaDonVi(System.String namHoc, System.Int32 maLoaiGiangVien, System.String maDonVi)
		{
			return GetByNamHocMaLoaiGiangVienMaDonVi(null, 0, int.MaxValue , namHoc, maLoaiGiangVien, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_BangPhuTroiGioDay_GiangVien_GetByNamHocMaLoaiGiangVienMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewBangPhuTroiGioDayGiangVien&gt;"/> instance.</returns>
		public VList<ViewBangPhuTroiGioDayGiangVien> GetByNamHocMaLoaiGiangVienMaDonVi(int start, int pageLength, System.String namHoc, System.Int32 maLoaiGiangVien, System.String maDonVi)
		{
			return GetByNamHocMaLoaiGiangVienMaDonVi(null, start, pageLength , namHoc, maLoaiGiangVien, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_BangPhuTroiGioDay_GiangVien_GetByNamHocMaLoaiGiangVienMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewBangPhuTroiGioDayGiangVien&gt;"/> instance.</returns>
		public VList<ViewBangPhuTroiGioDayGiangVien> GetByNamHocMaLoaiGiangVienMaDonVi(TransactionManager transactionManager, System.String namHoc, System.Int32 maLoaiGiangVien, System.String maDonVi)
		{
			return GetByNamHocMaLoaiGiangVienMaDonVi(transactionManager, 0, int.MaxValue , namHoc, maLoaiGiangVien, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_BangPhuTroiGioDay_GiangVien_GetByNamHocMaLoaiGiangVienMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewBangPhuTroiGioDayGiangVien&gt;"/> instance.</returns>
		public abstract VList<ViewBangPhuTroiGioDayGiangVien> GetByNamHocMaLoaiGiangVienMaDonVi(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.Int32 maLoaiGiangVien, System.String maDonVi);
		
		#endregion

		
		#region cust_View_BangPhuTroiGioDay_GiangVien_GetByNamHocHocKyMaDonViMaLoaiGiangVien
		
		/// <summary>
		///	This method wrap the 'cust_View_BangPhuTroiGioDay_GiangVien_GetByNamHocHocKyMaDonViMaLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGv"> A <c>System.Int32</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewBangPhuTroiGioDayGiangVien&gt;"/> instance.</returns>
		public VList<ViewBangPhuTroiGioDayGiangVien> GetByNamHocHocKyMaDonViMaLoaiGiangVien(System.String namHoc, System.Int32 maLoaiGv, System.String maDonVi)
		{
			return GetByNamHocHocKyMaDonViMaLoaiGiangVien(null, 0, int.MaxValue , namHoc, maLoaiGv, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_BangPhuTroiGioDay_GiangVien_GetByNamHocHocKyMaDonViMaLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGv"> A <c>System.Int32</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewBangPhuTroiGioDayGiangVien&gt;"/> instance.</returns>
		public VList<ViewBangPhuTroiGioDayGiangVien> GetByNamHocHocKyMaDonViMaLoaiGiangVien(int start, int pageLength, System.String namHoc, System.Int32 maLoaiGv, System.String maDonVi)
		{
			return GetByNamHocHocKyMaDonViMaLoaiGiangVien(null, start, pageLength , namHoc, maLoaiGv, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_BangPhuTroiGioDay_GiangVien_GetByNamHocHocKyMaDonViMaLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGv"> A <c>System.Int32</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewBangPhuTroiGioDayGiangVien&gt;"/> instance.</returns>
		public VList<ViewBangPhuTroiGioDayGiangVien> GetByNamHocHocKyMaDonViMaLoaiGiangVien(TransactionManager transactionManager, System.String namHoc, System.Int32 maLoaiGv, System.String maDonVi)
		{
			return GetByNamHocHocKyMaDonViMaLoaiGiangVien(transactionManager, 0, int.MaxValue , namHoc, maLoaiGv, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_BangPhuTroiGioDay_GiangVien_GetByNamHocHocKyMaDonViMaLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGv"> A <c>System.Int32</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewBangPhuTroiGioDayGiangVien&gt;"/> instance.</returns>
		public abstract VList<ViewBangPhuTroiGioDayGiangVien> GetByNamHocHocKyMaDonViMaLoaiGiangVien(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.Int32 maLoaiGv, System.String maDonVi);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewBangPhuTroiGioDayGiangVien&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewBangPhuTroiGioDayGiangVien&gt;"/></returns>
		protected static VList&lt;ViewBangPhuTroiGioDayGiangVien&gt; Fill(DataSet dataSet, VList<ViewBangPhuTroiGioDayGiangVien> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewBangPhuTroiGioDayGiangVien>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewBangPhuTroiGioDayGiangVien&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewBangPhuTroiGioDayGiangVien>"/></returns>
		protected static VList&lt;ViewBangPhuTroiGioDayGiangVien&gt; Fill(DataTable dataTable, VList<ViewBangPhuTroiGioDayGiangVien> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewBangPhuTroiGioDayGiangVien c = new ViewBangPhuTroiGioDayGiangVien();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32)row["MaGiangVien"];
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.Ho = (Convert.IsDBNull(row["Ho"]))?string.Empty:(System.String)row["Ho"];
					c.Ten = (Convert.IsDBNull(row["Ten"]))?string.Empty:(System.String)row["Ten"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.MaDonVi = (Convert.IsDBNull(row["MaDonVi"]))?string.Empty:(System.String)row["MaDonVi"];
					c.TenDonVi = (Convert.IsDBNull(row["TenDonVi"]))?string.Empty:(System.String)row["TenDonVi"];
					c.MaLoaiGiangVien = (Convert.IsDBNull(row["MaLoaiGiangVien"]))?(int)0:(System.Int32)row["MaLoaiGiangVien"];
					c.TenLoaiGiangVien = (Convert.IsDBNull(row["TenLoaiGiangVien"]))?string.Empty:(System.String)row["TenLoaiGiangVien"];
					c.TcThucDay = (Convert.IsDBNull(row["TCThucDay"]))?0.0m:(System.Decimal?)row["TCThucDay"];
					c.TietQd = (Convert.IsDBNull(row["TietQD"]))?0.0m:(System.Decimal?)row["TietQD"];
					c.NhiemVuGd = (Convert.IsDBNull(row["NhiemVuGD"]))?(int)0:(System.Int32?)row["NhiemVuGD"];
					c.NhiemVuNckh = (Convert.IsDBNull(row["NhiemVuNCKH"]))?0.0m:(System.Decimal?)row["NhiemVuNCKH"];
					c.PhanCongCn = (Convert.IsDBNull(row["PhanCongCN"]))?(int)0:(System.Int32?)row["PhanCongCN"];
					c.CongTrinhCd = (Convert.IsDBNull(row["CongTrinhCD"]))?(int)0:(System.Int32?)row["CongTrinhCD"];
					c.CongTrinhTc = (Convert.IsDBNull(row["CongTrinhTC"]))?(int)0:(System.Int32?)row["CongTrinhTC"];
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
		/// Fill an <see cref="VList&lt;ViewBangPhuTroiGioDayGiangVien&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewBangPhuTroiGioDayGiangVien&gt;"/></returns>
		protected VList<ViewBangPhuTroiGioDayGiangVien> Fill(IDataReader reader, VList<ViewBangPhuTroiGioDayGiangVien> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewBangPhuTroiGioDayGiangVien entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewBangPhuTroiGioDayGiangVien>("ViewBangPhuTroiGioDayGiangVien",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewBangPhuTroiGioDayGiangVien();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = (System.Int32)reader["MaGiangVien"];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
					entity.MaQuanLy = (System.String)reader["MaQuanLy"];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.Ho = reader.IsDBNull(reader.GetOrdinal("Ho")) ? null : (System.String)reader["Ho"];
					//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
					entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
					//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
					entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.MaDonVi = reader.IsDBNull(reader.GetOrdinal("MaDonVi")) ? null : (System.String)reader["MaDonVi"];
					//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
					entity.TenDonVi = (System.String)reader["TenDonVi"];
					//entity.TenDonVi = (Convert.IsDBNull(reader["TenDonVi"]))?string.Empty:(System.String)reader["TenDonVi"];
					entity.MaLoaiGiangVien = (System.Int32)reader["MaLoaiGiangVien"];
					//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32)reader["MaLoaiGiangVien"];
					entity.TenLoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("TenLoaiGiangVien")) ? null : (System.String)reader["TenLoaiGiangVien"];
					//entity.TenLoaiGiangVien = (Convert.IsDBNull(reader["TenLoaiGiangVien"]))?string.Empty:(System.String)reader["TenLoaiGiangVien"];
					entity.TcThucDay = reader.IsDBNull(reader.GetOrdinal("TcThucDay")) ? null : (System.Decimal?)reader["TcThucDay"];
					//entity.TcThucDay = (Convert.IsDBNull(reader["TCThucDay"]))?0.0m:(System.Decimal?)reader["TCThucDay"];
					entity.TietQd = reader.IsDBNull(reader.GetOrdinal("TietQd")) ? null : (System.Decimal?)reader["TietQd"];
					//entity.TietQd = (Convert.IsDBNull(reader["TietQD"]))?0.0m:(System.Decimal?)reader["TietQD"];
					entity.NhiemVuGd = reader.IsDBNull(reader.GetOrdinal("NhiemVuGd")) ? null : (System.Int32?)reader["NhiemVuGd"];
					//entity.NhiemVuGd = (Convert.IsDBNull(reader["NhiemVuGD"]))?(int)0:(System.Int32?)reader["NhiemVuGD"];
					entity.NhiemVuNckh = reader.IsDBNull(reader.GetOrdinal("NhiemVuNckh")) ? null : (System.Decimal?)reader["NhiemVuNckh"];
					//entity.NhiemVuNckh = (Convert.IsDBNull(reader["NhiemVuNCKH"]))?0.0m:(System.Decimal?)reader["NhiemVuNCKH"];
					entity.PhanCongCn = reader.IsDBNull(reader.GetOrdinal("PhanCongCn")) ? null : (System.Int32?)reader["PhanCongCn"];
					//entity.PhanCongCn = (Convert.IsDBNull(reader["PhanCongCN"]))?(int)0:(System.Int32?)reader["PhanCongCN"];
					entity.CongTrinhCd = reader.IsDBNull(reader.GetOrdinal("CongTrinhCd")) ? null : (System.Int32?)reader["CongTrinhCd"];
					//entity.CongTrinhCd = (Convert.IsDBNull(reader["CongTrinhCD"]))?(int)0:(System.Int32?)reader["CongTrinhCD"];
					entity.CongTrinhTc = reader.IsDBNull(reader.GetOrdinal("CongTrinhTc")) ? null : (System.Int32?)reader["CongTrinhTc"];
					//entity.CongTrinhTc = (Convert.IsDBNull(reader["CongTrinhTC"]))?(int)0:(System.Int32?)reader["CongTrinhTC"];
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
		/// Refreshes the <see cref="ViewBangPhuTroiGioDayGiangVien"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewBangPhuTroiGioDayGiangVien"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewBangPhuTroiGioDayGiangVien entity)
		{
			reader.Read();
			entity.MaGiangVien = (System.Int32)reader["MaGiangVien"];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
			entity.MaQuanLy = (System.String)reader["MaQuanLy"];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.Ho = reader.IsDBNull(reader.GetOrdinal("Ho")) ? null : (System.String)reader["Ho"];
			//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
			entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
			//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
			entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.MaDonVi = reader.IsDBNull(reader.GetOrdinal("MaDonVi")) ? null : (System.String)reader["MaDonVi"];
			//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
			entity.TenDonVi = (System.String)reader["TenDonVi"];
			//entity.TenDonVi = (Convert.IsDBNull(reader["TenDonVi"]))?string.Empty:(System.String)reader["TenDonVi"];
			entity.MaLoaiGiangVien = (System.Int32)reader["MaLoaiGiangVien"];
			//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32)reader["MaLoaiGiangVien"];
			entity.TenLoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("TenLoaiGiangVien")) ? null : (System.String)reader["TenLoaiGiangVien"];
			//entity.TenLoaiGiangVien = (Convert.IsDBNull(reader["TenLoaiGiangVien"]))?string.Empty:(System.String)reader["TenLoaiGiangVien"];
			entity.TcThucDay = reader.IsDBNull(reader.GetOrdinal("TcThucDay")) ? null : (System.Decimal?)reader["TcThucDay"];
			//entity.TcThucDay = (Convert.IsDBNull(reader["TCThucDay"]))?0.0m:(System.Decimal?)reader["TCThucDay"];
			entity.TietQd = reader.IsDBNull(reader.GetOrdinal("TietQd")) ? null : (System.Decimal?)reader["TietQd"];
			//entity.TietQd = (Convert.IsDBNull(reader["TietQD"]))?0.0m:(System.Decimal?)reader["TietQD"];
			entity.NhiemVuGd = reader.IsDBNull(reader.GetOrdinal("NhiemVuGd")) ? null : (System.Int32?)reader["NhiemVuGd"];
			//entity.NhiemVuGd = (Convert.IsDBNull(reader["NhiemVuGD"]))?(int)0:(System.Int32?)reader["NhiemVuGD"];
			entity.NhiemVuNckh = reader.IsDBNull(reader.GetOrdinal("NhiemVuNckh")) ? null : (System.Decimal?)reader["NhiemVuNckh"];
			//entity.NhiemVuNckh = (Convert.IsDBNull(reader["NhiemVuNCKH"]))?0.0m:(System.Decimal?)reader["NhiemVuNCKH"];
			entity.PhanCongCn = reader.IsDBNull(reader.GetOrdinal("PhanCongCn")) ? null : (System.Int32?)reader["PhanCongCn"];
			//entity.PhanCongCn = (Convert.IsDBNull(reader["PhanCongCN"]))?(int)0:(System.Int32?)reader["PhanCongCN"];
			entity.CongTrinhCd = reader.IsDBNull(reader.GetOrdinal("CongTrinhCd")) ? null : (System.Int32?)reader["CongTrinhCd"];
			//entity.CongTrinhCd = (Convert.IsDBNull(reader["CongTrinhCD"]))?(int)0:(System.Int32?)reader["CongTrinhCD"];
			entity.CongTrinhTc = reader.IsDBNull(reader.GetOrdinal("CongTrinhTc")) ? null : (System.Int32?)reader["CongTrinhTc"];
			//entity.CongTrinhTc = (Convert.IsDBNull(reader["CongTrinhTC"]))?(int)0:(System.Int32?)reader["CongTrinhTC"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewBangPhuTroiGioDayGiangVien"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewBangPhuTroiGioDayGiangVien"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewBangPhuTroiGioDayGiangVien entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32)dataRow["MaGiangVien"];
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.Ho = (Convert.IsDBNull(dataRow["Ho"]))?string.Empty:(System.String)dataRow["Ho"];
			entity.Ten = (Convert.IsDBNull(dataRow["Ten"]))?string.Empty:(System.String)dataRow["Ten"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.MaDonVi = (Convert.IsDBNull(dataRow["MaDonVi"]))?string.Empty:(System.String)dataRow["MaDonVi"];
			entity.TenDonVi = (Convert.IsDBNull(dataRow["TenDonVi"]))?string.Empty:(System.String)dataRow["TenDonVi"];
			entity.MaLoaiGiangVien = (Convert.IsDBNull(dataRow["MaLoaiGiangVien"]))?(int)0:(System.Int32)dataRow["MaLoaiGiangVien"];
			entity.TenLoaiGiangVien = (Convert.IsDBNull(dataRow["TenLoaiGiangVien"]))?string.Empty:(System.String)dataRow["TenLoaiGiangVien"];
			entity.TcThucDay = (Convert.IsDBNull(dataRow["TCThucDay"]))?0.0m:(System.Decimal?)dataRow["TCThucDay"];
			entity.TietQd = (Convert.IsDBNull(dataRow["TietQD"]))?0.0m:(System.Decimal?)dataRow["TietQD"];
			entity.NhiemVuGd = (Convert.IsDBNull(dataRow["NhiemVuGD"]))?(int)0:(System.Int32?)dataRow["NhiemVuGD"];
			entity.NhiemVuNckh = (Convert.IsDBNull(dataRow["NhiemVuNCKH"]))?0.0m:(System.Decimal?)dataRow["NhiemVuNCKH"];
			entity.PhanCongCn = (Convert.IsDBNull(dataRow["PhanCongCN"]))?(int)0:(System.Int32?)dataRow["PhanCongCN"];
			entity.CongTrinhCd = (Convert.IsDBNull(dataRow["CongTrinhCD"]))?(int)0:(System.Int32?)dataRow["CongTrinhCD"];
			entity.CongTrinhTc = (Convert.IsDBNull(dataRow["CongTrinhTC"]))?(int)0:(System.Int32?)dataRow["CongTrinhTC"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewBangPhuTroiGioDayGiangVienFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewBangPhuTroiGioDayGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewBangPhuTroiGioDayGiangVienFilterBuilder : SqlFilterBuilder<ViewBangPhuTroiGioDayGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewBangPhuTroiGioDayGiangVienFilterBuilder class.
		/// </summary>
		public ViewBangPhuTroiGioDayGiangVienFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewBangPhuTroiGioDayGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewBangPhuTroiGioDayGiangVienFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewBangPhuTroiGioDayGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewBangPhuTroiGioDayGiangVienFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewBangPhuTroiGioDayGiangVienFilterBuilder

	#region ViewBangPhuTroiGioDayGiangVienParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewBangPhuTroiGioDayGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewBangPhuTroiGioDayGiangVienParameterBuilder : ParameterizedSqlFilterBuilder<ViewBangPhuTroiGioDayGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewBangPhuTroiGioDayGiangVienParameterBuilder class.
		/// </summary>
		public ViewBangPhuTroiGioDayGiangVienParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewBangPhuTroiGioDayGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewBangPhuTroiGioDayGiangVienParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewBangPhuTroiGioDayGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewBangPhuTroiGioDayGiangVienParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewBangPhuTroiGioDayGiangVienParameterBuilder
	
	#region ViewBangPhuTroiGioDayGiangVienSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewBangPhuTroiGioDayGiangVien"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewBangPhuTroiGioDayGiangVienSortBuilder : SqlSortBuilder<ViewBangPhuTroiGioDayGiangVienColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewBangPhuTroiGioDayGiangVienSqlSortBuilder class.
		/// </summary>
		public ViewBangPhuTroiGioDayGiangVienSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewBangPhuTroiGioDayGiangVienSortBuilder

} // end namespace
