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
	/// This class is the base class for any <see cref="ViewKhoiLuongGiangDayTungTuanProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewKhoiLuongGiangDayTungTuanProviderBaseCore : EntityViewProviderBase<ViewKhoiLuongGiangDayTungTuan>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewKhoiLuongGiangDayTungTuan&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewKhoiLuongGiangDayTungTuan&gt;"/></returns>
		protected static VList&lt;ViewKhoiLuongGiangDayTungTuan&gt; Fill(DataSet dataSet, VList<ViewKhoiLuongGiangDayTungTuan> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewKhoiLuongGiangDayTungTuan>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewKhoiLuongGiangDayTungTuan&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewKhoiLuongGiangDayTungTuan>"/></returns>
		protected static VList&lt;ViewKhoiLuongGiangDayTungTuan&gt; Fill(DataTable dataTable, VList<ViewKhoiLuongGiangDayTungTuan> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewKhoiLuongGiangDayTungTuan c = new ViewKhoiLuongGiangDayTungTuan();
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
		/// Fill an <see cref="VList&lt;ViewKhoiLuongGiangDayTungTuan&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewKhoiLuongGiangDayTungTuan&gt;"/></returns>
		protected VList<ViewKhoiLuongGiangDayTungTuan> Fill(IDataReader reader, VList<ViewKhoiLuongGiangDayTungTuan> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewKhoiLuongGiangDayTungTuan entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewKhoiLuongGiangDayTungTuan>("ViewKhoiLuongGiangDayTungTuan",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewKhoiLuongGiangDayTungTuan();
					}
					
					entity.SuppressEntityEvents = true;

					entity.Stt = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.Stt)))?null:(System.Int32?)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.Stt)];
					//entity.Stt = (Convert.IsDBNull(reader["Stt"]))?(int)0:(System.Int32?)reader["Stt"];
					entity.MaQuanLy = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.MaQuanLy)))?null:(System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.MaQuanLy)];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.MaQuanLy1 = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.MaQuanLy1)))?null:(System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.MaQuanLy1)];
					//entity.MaQuanLy1 = (Convert.IsDBNull(reader["MaQuanLy1"]))?string.Empty:(System.String)reader["MaQuanLy1"];
					entity.Ho = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.Ho)))?null:(System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.Ho)];
					//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
					entity.Ho1 = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.Ho1)))?null:(System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.Ho1)];
					//entity.Ho1 = (Convert.IsDBNull(reader["Ho1"]))?string.Empty:(System.String)reader["Ho1"];
					entity.Ten = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.Ten)))?null:(System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.Ten)];
					//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
					entity.Ten1 = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.Ten1)))?null:(System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.Ten1)];
					//entity.Ten1 = (Convert.IsDBNull(reader["Ten1"]))?string.Empty:(System.String)reader["Ten1"];
					entity.MaLopHocPhan = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.MaLopHocPhan)))?null:(System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.MaLopHocPhan)];
					//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
					entity.MaLop = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.MaLop)))?null:(System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.MaLop)];
					//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
					entity.MaHeDaoTao = (System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.MaHeDaoTao)];
					//entity.MaHeDaoTao = (Convert.IsDBNull(reader["MaHeDaoTao"]))?string.Empty:(System.String)reader["MaHeDaoTao"];
					entity.TenHeDaoTao = (System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.TenHeDaoTao)];
					//entity.TenHeDaoTao = (Convert.IsDBNull(reader["TenHeDaoTao"]))?string.Empty:(System.String)reader["TenHeDaoTao"];
					entity.MaBacDaoTao = (System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.MaBacDaoTao)];
					//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
					entity.TenBacDaoTao = (System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.TenBacDaoTao)];
					//entity.TenBacDaoTao = (Convert.IsDBNull(reader["TenBacDaoTao"]))?string.Empty:(System.String)reader["TenBacDaoTao"];
					entity.MaDonVi = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.MaDonVi)))?null:(System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.MaDonVi)];
					//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
					entity.TenDonVi = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.TenDonVi)))?null:(System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.TenDonVi)];
					//entity.TenDonVi = (Convert.IsDBNull(reader["TenDonVi"]))?string.Empty:(System.String)reader["TenDonVi"];
					entity.MaLoaiGiangVien = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.MaLoaiGiangVien)))?null:(System.Int32?)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.MaLoaiGiangVien)];
					//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32?)reader["MaLoaiGiangVien"];
					entity.MaKhoaHoc = (System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.MaKhoaHoc)];
					//entity.MaKhoaHoc = (Convert.IsDBNull(reader["MaKhoaHoc"]))?string.Empty:(System.String)reader["MaKhoaHoc"];
					entity.TenKhoaHoc = (System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.TenKhoaHoc)];
					//entity.TenKhoaHoc = (Convert.IsDBNull(reader["TenKhoaHoc"]))?string.Empty:(System.String)reader["TenKhoaHoc"];
					entity.MaMonHoc = (System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.MaMonHoc)];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.TenMonHoc = (System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.TenMonHoc)];
					//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
					entity.LoaiHocPhan = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.LoaiHocPhan)))?null:(System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.LoaiHocPhan)];
					//entity.LoaiHocPhan = (Convert.IsDBNull(reader["LoaiHocPhan"]))?string.Empty:(System.String)reader["LoaiHocPhan"];
					entity.HeSoLopDong = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.HeSoLopDong)))?null:(System.Decimal?)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.HeSoLopDong)];
					//entity.HeSoLopDong = (Convert.IsDBNull(reader["HeSoLopDong"]))?0.0m:(System.Decimal?)reader["HeSoLopDong"];
					entity.SiSoLop = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.SiSoLop)))?null:(System.Int32?)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.SiSoLop)];
					//entity.SiSoLop = (Convert.IsDBNull(reader["SiSoLop"]))?(int)0:(System.Int32?)reader["SiSoLop"];
					entity.LyThuyet = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.LyThuyet)))?null:(System.Decimal?)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.LyThuyet)];
					//entity.LyThuyet = (Convert.IsDBNull(reader["LyThuyet"]))?0.0m:(System.Decimal?)reader["LyThuyet"];
					entity.ThucHanh = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.ThucHanh)))?null:(System.Decimal?)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.ThucHanh)];
					//entity.ThucHanh = (Convert.IsDBNull(reader["ThucHanh"]))?0.0m:(System.Decimal?)reader["ThucHanh"];
					entity.LyThuyetCoHeSo = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.LyThuyetCoHeSo)))?null:(System.Decimal?)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.LyThuyetCoHeSo)];
					//entity.LyThuyetCoHeSo = (Convert.IsDBNull(reader["LyThuyetCoHeSo"]))?0.0m:(System.Decimal?)reader["LyThuyetCoHeSo"];
					entity.ThucHanhCoHeSo = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.ThucHanhCoHeSo)))?null:(System.Decimal?)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.ThucHanhCoHeSo)];
					//entity.ThucHanhCoHeSo = (Convert.IsDBNull(reader["ThucHanhCoHeSo"]))?0.0m:(System.Decimal?)reader["ThucHanhCoHeSo"];
					entity.NamHoc = (System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.NamHoc)];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = (System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.HocKy)];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.TongLyThuyetThucHanh = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.TongLyThuyetThucHanh)))?null:(System.Decimal?)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.TongLyThuyetThucHanh)];
					//entity.TongLyThuyetThucHanh = (Convert.IsDBNull(reader["TongLyThuyetThucHanh"]))?0.0m:(System.Decimal?)reader["TongLyThuyetThucHanh"];
					entity.TongLyThuyetThucHanhCoHeSo = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.TongLyThuyetThucHanhCoHeSo)))?null:(System.Decimal?)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.TongLyThuyetThucHanhCoHeSo)];
					//entity.TongLyThuyetThucHanhCoHeSo = (Convert.IsDBNull(reader["TongLyThuyetThucHanhCoHeSo"]))?0.0m:(System.Decimal?)reader["TongLyThuyetThucHanhCoHeSo"];
					entity.TongLyThuyetThucHanhTg = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.TongLyThuyetThucHanhTg)))?null:(System.Decimal?)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.TongLyThuyetThucHanhTg)];
					//entity.TongLyThuyetThucHanhTg = (Convert.IsDBNull(reader["TongLyThuyetThucHanh_TG"]))?0.0m:(System.Decimal?)reader["TongLyThuyetThucHanh_TG"];
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
		/// Refreshes the <see cref="ViewKhoiLuongGiangDayTungTuan"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewKhoiLuongGiangDayTungTuan"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewKhoiLuongGiangDayTungTuan entity)
		{
			reader.Read();
			entity.Stt = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.Stt)))?null:(System.Int32?)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.Stt)];
			//entity.Stt = (Convert.IsDBNull(reader["Stt"]))?(int)0:(System.Int32?)reader["Stt"];
			entity.MaQuanLy = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.MaQuanLy)))?null:(System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.MaQuanLy)];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.MaQuanLy1 = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.MaQuanLy1)))?null:(System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.MaQuanLy1)];
			//entity.MaQuanLy1 = (Convert.IsDBNull(reader["MaQuanLy1"]))?string.Empty:(System.String)reader["MaQuanLy1"];
			entity.Ho = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.Ho)))?null:(System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.Ho)];
			//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
			entity.Ho1 = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.Ho1)))?null:(System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.Ho1)];
			//entity.Ho1 = (Convert.IsDBNull(reader["Ho1"]))?string.Empty:(System.String)reader["Ho1"];
			entity.Ten = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.Ten)))?null:(System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.Ten)];
			//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
			entity.Ten1 = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.Ten1)))?null:(System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.Ten1)];
			//entity.Ten1 = (Convert.IsDBNull(reader["Ten1"]))?string.Empty:(System.String)reader["Ten1"];
			entity.MaLopHocPhan = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.MaLopHocPhan)))?null:(System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.MaLopHocPhan)];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			entity.MaLop = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.MaLop)))?null:(System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.MaLop)];
			//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
			entity.MaHeDaoTao = (System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.MaHeDaoTao)];
			//entity.MaHeDaoTao = (Convert.IsDBNull(reader["MaHeDaoTao"]))?string.Empty:(System.String)reader["MaHeDaoTao"];
			entity.TenHeDaoTao = (System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.TenHeDaoTao)];
			//entity.TenHeDaoTao = (Convert.IsDBNull(reader["TenHeDaoTao"]))?string.Empty:(System.String)reader["TenHeDaoTao"];
			entity.MaBacDaoTao = (System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.MaBacDaoTao)];
			//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
			entity.TenBacDaoTao = (System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.TenBacDaoTao)];
			//entity.TenBacDaoTao = (Convert.IsDBNull(reader["TenBacDaoTao"]))?string.Empty:(System.String)reader["TenBacDaoTao"];
			entity.MaDonVi = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.MaDonVi)))?null:(System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.MaDonVi)];
			//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
			entity.TenDonVi = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.TenDonVi)))?null:(System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.TenDonVi)];
			//entity.TenDonVi = (Convert.IsDBNull(reader["TenDonVi"]))?string.Empty:(System.String)reader["TenDonVi"];
			entity.MaLoaiGiangVien = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.MaLoaiGiangVien)))?null:(System.Int32?)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.MaLoaiGiangVien)];
			//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32?)reader["MaLoaiGiangVien"];
			entity.MaKhoaHoc = (System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.MaKhoaHoc)];
			//entity.MaKhoaHoc = (Convert.IsDBNull(reader["MaKhoaHoc"]))?string.Empty:(System.String)reader["MaKhoaHoc"];
			entity.TenKhoaHoc = (System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.TenKhoaHoc)];
			//entity.TenKhoaHoc = (Convert.IsDBNull(reader["TenKhoaHoc"]))?string.Empty:(System.String)reader["TenKhoaHoc"];
			entity.MaMonHoc = (System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.MaMonHoc)];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.TenMonHoc = (System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.TenMonHoc)];
			//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
			entity.LoaiHocPhan = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.LoaiHocPhan)))?null:(System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.LoaiHocPhan)];
			//entity.LoaiHocPhan = (Convert.IsDBNull(reader["LoaiHocPhan"]))?string.Empty:(System.String)reader["LoaiHocPhan"];
			entity.HeSoLopDong = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.HeSoLopDong)))?null:(System.Decimal?)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.HeSoLopDong)];
			//entity.HeSoLopDong = (Convert.IsDBNull(reader["HeSoLopDong"]))?0.0m:(System.Decimal?)reader["HeSoLopDong"];
			entity.SiSoLop = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.SiSoLop)))?null:(System.Int32?)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.SiSoLop)];
			//entity.SiSoLop = (Convert.IsDBNull(reader["SiSoLop"]))?(int)0:(System.Int32?)reader["SiSoLop"];
			entity.LyThuyet = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.LyThuyet)))?null:(System.Decimal?)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.LyThuyet)];
			//entity.LyThuyet = (Convert.IsDBNull(reader["LyThuyet"]))?0.0m:(System.Decimal?)reader["LyThuyet"];
			entity.ThucHanh = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.ThucHanh)))?null:(System.Decimal?)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.ThucHanh)];
			//entity.ThucHanh = (Convert.IsDBNull(reader["ThucHanh"]))?0.0m:(System.Decimal?)reader["ThucHanh"];
			entity.LyThuyetCoHeSo = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.LyThuyetCoHeSo)))?null:(System.Decimal?)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.LyThuyetCoHeSo)];
			//entity.LyThuyetCoHeSo = (Convert.IsDBNull(reader["LyThuyetCoHeSo"]))?0.0m:(System.Decimal?)reader["LyThuyetCoHeSo"];
			entity.ThucHanhCoHeSo = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.ThucHanhCoHeSo)))?null:(System.Decimal?)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.ThucHanhCoHeSo)];
			//entity.ThucHanhCoHeSo = (Convert.IsDBNull(reader["ThucHanhCoHeSo"]))?0.0m:(System.Decimal?)reader["ThucHanhCoHeSo"];
			entity.NamHoc = (System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.NamHoc)];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = (System.String)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.HocKy)];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.TongLyThuyetThucHanh = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.TongLyThuyetThucHanh)))?null:(System.Decimal?)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.TongLyThuyetThucHanh)];
			//entity.TongLyThuyetThucHanh = (Convert.IsDBNull(reader["TongLyThuyetThucHanh"]))?0.0m:(System.Decimal?)reader["TongLyThuyetThucHanh"];
			entity.TongLyThuyetThucHanhCoHeSo = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.TongLyThuyetThucHanhCoHeSo)))?null:(System.Decimal?)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.TongLyThuyetThucHanhCoHeSo)];
			//entity.TongLyThuyetThucHanhCoHeSo = (Convert.IsDBNull(reader["TongLyThuyetThucHanhCoHeSo"]))?0.0m:(System.Decimal?)reader["TongLyThuyetThucHanhCoHeSo"];
			entity.TongLyThuyetThucHanhTg = (reader.IsDBNull(((int)ViewKhoiLuongGiangDayTungTuanColumn.TongLyThuyetThucHanhTg)))?null:(System.Decimal?)reader[((int)ViewKhoiLuongGiangDayTungTuanColumn.TongLyThuyetThucHanhTg)];
			//entity.TongLyThuyetThucHanhTg = (Convert.IsDBNull(reader["TongLyThuyetThucHanh_TG"]))?0.0m:(System.Decimal?)reader["TongLyThuyetThucHanh_TG"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewKhoiLuongGiangDayTungTuan"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewKhoiLuongGiangDayTungTuan"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewKhoiLuongGiangDayTungTuan entity)
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
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewKhoiLuongGiangDayTungTuanFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoiLuongGiangDayTungTuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKhoiLuongGiangDayTungTuanFilterBuilder : SqlFilterBuilder<ViewKhoiLuongGiangDayTungTuanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongGiangDayTungTuanFilterBuilder class.
		/// </summary>
		public ViewKhoiLuongGiangDayTungTuanFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongGiangDayTungTuanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewKhoiLuongGiangDayTungTuanFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongGiangDayTungTuanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewKhoiLuongGiangDayTungTuanFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewKhoiLuongGiangDayTungTuanFilterBuilder

	#region ViewKhoiLuongGiangDayTungTuanParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoiLuongGiangDayTungTuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKhoiLuongGiangDayTungTuanParameterBuilder : ParameterizedSqlFilterBuilder<ViewKhoiLuongGiangDayTungTuanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongGiangDayTungTuanParameterBuilder class.
		/// </summary>
		public ViewKhoiLuongGiangDayTungTuanParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongGiangDayTungTuanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewKhoiLuongGiangDayTungTuanParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongGiangDayTungTuanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewKhoiLuongGiangDayTungTuanParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewKhoiLuongGiangDayTungTuanParameterBuilder
	
	#region ViewKhoiLuongGiangDayTungTuanSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoiLuongGiangDayTungTuan"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewKhoiLuongGiangDayTungTuanSortBuilder : SqlSortBuilder<ViewKhoiLuongGiangDayTungTuanColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongGiangDayTungTuanSqlSortBuilder class.
		/// </summary>
		public ViewKhoiLuongGiangDayTungTuanSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewKhoiLuongGiangDayTungTuanSortBuilder

} // end namespace
