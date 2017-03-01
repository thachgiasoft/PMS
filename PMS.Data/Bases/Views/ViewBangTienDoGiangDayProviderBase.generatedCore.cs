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
	/// This class is the base class for any <see cref="ViewBangTienDoGiangDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewBangTienDoGiangDayProviderBaseCore : EntityViewProviderBase<ViewBangTienDoGiangDay>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewBangTienDoGiangDay&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewBangTienDoGiangDay&gt;"/></returns>
		protected static VList&lt;ViewBangTienDoGiangDay&gt; Fill(DataSet dataSet, VList<ViewBangTienDoGiangDay> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewBangTienDoGiangDay>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewBangTienDoGiangDay&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewBangTienDoGiangDay>"/></returns>
		protected static VList&lt;ViewBangTienDoGiangDay&gt; Fill(DataTable dataTable, VList<ViewBangTienDoGiangDay> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewBangTienDoGiangDay c = new ViewBangTienDoGiangDay();
					c.MaLichHoc = (Convert.IsDBNull(row["MaLichHoc"]))?(int)0:(System.Int32)row["MaLichHoc"];
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?string.Empty:(System.String)row["MaGiangVien"];
					c.Ho = (Convert.IsDBNull(row["Ho"]))?string.Empty:(System.String)row["Ho"];
					c.Ten = (Convert.IsDBNull(row["Ten"]))?string.Empty:(System.String)row["Ten"];
					c.MaLopHocPhan = (Convert.IsDBNull(row["MaLopHocPhan"]))?string.Empty:(System.String)row["MaLopHocPhan"];
					c.MaLop = (Convert.IsDBNull(row["MaLop"]))?string.Empty:(System.String)row["MaLop"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.MaMonHoc = (Convert.IsDBNull(row["MaMonHoc"]))?string.Empty:(System.String)row["MaMonHoc"];
					c.MaLoaiHocPhan = (Convert.IsDBNull(row["MaLoaiHocPhan"]))?(byte)0:(System.Byte)row["MaLoaiHocPhan"];
					c.LoaiHocPhan = (Convert.IsDBNull(row["LoaiHocPhan"]))?string.Empty:(System.String)row["LoaiHocPhan"];
					c.PhanLoai = (Convert.IsDBNull(row["PhanLoai"]))?string.Empty:(System.String)row["PhanLoai"];
					c.SiSoLop = (Convert.IsDBNull(row["SiSoLop"]))?(int)0:(System.Int32?)row["SiSoLop"];
					c.TrongGio = (Convert.IsDBNull(row["TrongGio"]))?0.0m:(System.Decimal?)row["TrongGio"];
					c.NgoaiGio = (Convert.IsDBNull(row["NgoaiGio"]))?0.0m:(System.Decimal?)row["NgoaiGio"];
					c.ChatLuongCao = (Convert.IsDBNull(row["ChatLuongCao"]))?0.0m:(System.Decimal?)row["ChatLuongCao"];
					c.Nhom = (Convert.IsDBNull(row["Nhom"]))?string.Empty:(System.String)row["Nhom"];
					c.SoTinChi = (Convert.IsDBNull(row["SoTinChi"]))?0.0m:(System.Decimal)row["SoTinChi"];
					c.LyThuyet = (Convert.IsDBNull(row["LyThuyet"]))?0.0m:(System.Decimal)row["LyThuyet"];
					c.ThucHanh = (Convert.IsDBNull(row["ThucHanh"]))?0.0m:(System.Decimal)row["ThucHanh"];
					c.BaiTap = (Convert.IsDBNull(row["BaiTap"]))?0.0m:(System.Decimal)row["BaiTap"];
					c.BaiTapLon = (Convert.IsDBNull(row["BaiTapLon"]))?0.0m:(System.Decimal)row["BaiTapLon"];
					c.DoAn = (Convert.IsDBNull(row["DoAn"]))?0.0m:(System.Decimal)row["DoAn"];
					c.LuanAn = (Convert.IsDBNull(row["LuanAn"]))?0.0m:(System.Decimal)row["LuanAn"];
					c.TieuLuan = (Convert.IsDBNull(row["TieuLuan"]))?0.0m:(System.Decimal)row["TieuLuan"];
					c.ThucTap = (Convert.IsDBNull(row["ThucTap"]))?0.0m:(System.Decimal)row["ThucTap"];
					c.Tuan = (Convert.IsDBNull(row["Tuan"]))?(int)0:(System.Int32?)row["Tuan"];
					c.Nam = (Convert.IsDBNull(row["Nam"]))?(int)0:(System.Int32?)row["Nam"];
					c.NgayBatDau = (Convert.IsDBNull(row["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)row["NgayBatDau"];
					c.NgayKetThuc = (Convert.IsDBNull(row["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)row["NgayKetThuc"];
					c.MaBuoiHoc = (Convert.IsDBNull(row["MaBuoiHoc"]))?(int)0:(System.Int32?)row["MaBuoiHoc"];
					c.TenBuoiHoc = (Convert.IsDBNull(row["TenBuoiHoc"]))?string.Empty:(System.String)row["TenBuoiHoc"];
					c.ThoiGianHoc = (Convert.IsDBNull(row["ThoiGianHoc"]))?string.Empty:(System.String)row["ThoiGianHoc"];
					c.SoTiet = (Convert.IsDBNull(row["SoTiet"]))?(int)0:(System.Int32?)row["SoTiet"];
					c.TietBatDau = (Convert.IsDBNull(row["TietBatDau"]))?(int)0:(System.Int32?)row["TietBatDau"];
					c.NgayTao = (Convert.IsDBNull(row["NgayTao"]))?DateTime.MinValue:(System.DateTime?)row["NgayTao"];
					c.RowIndex = (Convert.IsDBNull(row["RowIndex"]))?(int)0:(System.Int32?)row["RowIndex"];
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
		/// Fill an <see cref="VList&lt;ViewBangTienDoGiangDay&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewBangTienDoGiangDay&gt;"/></returns>
		protected VList<ViewBangTienDoGiangDay> Fill(IDataReader reader, VList<ViewBangTienDoGiangDay> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewBangTienDoGiangDay entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewBangTienDoGiangDay>("ViewBangTienDoGiangDay",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewBangTienDoGiangDay();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaLichHoc = (System.Int32)reader[((int)ViewBangTienDoGiangDayColumn.MaLichHoc)];
					//entity.MaLichHoc = (Convert.IsDBNull(reader["MaLichHoc"]))?(int)0:(System.Int32)reader["MaLichHoc"];
					entity.MaGiangVien = (System.String)reader[((int)ViewBangTienDoGiangDayColumn.MaGiangVien)];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?string.Empty:(System.String)reader["MaGiangVien"];
					entity.Ho = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.Ho)))?null:(System.String)reader[((int)ViewBangTienDoGiangDayColumn.Ho)];
					//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
					entity.Ten = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.Ten)))?null:(System.String)reader[((int)ViewBangTienDoGiangDayColumn.Ten)];
					//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
					entity.MaLopHocPhan = (System.String)reader[((int)ViewBangTienDoGiangDayColumn.MaLopHocPhan)];
					//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
					entity.MaLop = (System.String)reader[((int)ViewBangTienDoGiangDayColumn.MaLop)];
					//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
					entity.NamHoc = (System.String)reader[((int)ViewBangTienDoGiangDayColumn.NamHoc)];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = (System.String)reader[((int)ViewBangTienDoGiangDayColumn.HocKy)];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.MaMonHoc = (System.String)reader[((int)ViewBangTienDoGiangDayColumn.MaMonHoc)];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.MaLoaiHocPhan = (System.Byte)reader[((int)ViewBangTienDoGiangDayColumn.MaLoaiHocPhan)];
					//entity.MaLoaiHocPhan = (Convert.IsDBNull(reader["MaLoaiHocPhan"]))?(byte)0:(System.Byte)reader["MaLoaiHocPhan"];
					entity.LoaiHocPhan = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.LoaiHocPhan)))?null:(System.String)reader[((int)ViewBangTienDoGiangDayColumn.LoaiHocPhan)];
					//entity.LoaiHocPhan = (Convert.IsDBNull(reader["LoaiHocPhan"]))?string.Empty:(System.String)reader["LoaiHocPhan"];
					entity.PhanLoai = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.PhanLoai)))?null:(System.String)reader[((int)ViewBangTienDoGiangDayColumn.PhanLoai)];
					//entity.PhanLoai = (Convert.IsDBNull(reader["PhanLoai"]))?string.Empty:(System.String)reader["PhanLoai"];
					entity.SiSoLop = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.SiSoLop)))?null:(System.Int32?)reader[((int)ViewBangTienDoGiangDayColumn.SiSoLop)];
					//entity.SiSoLop = (Convert.IsDBNull(reader["SiSoLop"]))?(int)0:(System.Int32?)reader["SiSoLop"];
					entity.TrongGio = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.TrongGio)))?null:(System.Decimal?)reader[((int)ViewBangTienDoGiangDayColumn.TrongGio)];
					//entity.TrongGio = (Convert.IsDBNull(reader["TrongGio"]))?0.0m:(System.Decimal?)reader["TrongGio"];
					entity.NgoaiGio = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.NgoaiGio)))?null:(System.Decimal?)reader[((int)ViewBangTienDoGiangDayColumn.NgoaiGio)];
					//entity.NgoaiGio = (Convert.IsDBNull(reader["NgoaiGio"]))?0.0m:(System.Decimal?)reader["NgoaiGio"];
					entity.ChatLuongCao = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.ChatLuongCao)))?null:(System.Decimal?)reader[((int)ViewBangTienDoGiangDayColumn.ChatLuongCao)];
					//entity.ChatLuongCao = (Convert.IsDBNull(reader["ChatLuongCao"]))?0.0m:(System.Decimal?)reader["ChatLuongCao"];
					entity.Nhom = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.Nhom)))?null:(System.String)reader[((int)ViewBangTienDoGiangDayColumn.Nhom)];
					//entity.Nhom = (Convert.IsDBNull(reader["Nhom"]))?string.Empty:(System.String)reader["Nhom"];
					entity.SoTinChi = (System.Decimal)reader[((int)ViewBangTienDoGiangDayColumn.SoTinChi)];
					//entity.SoTinChi = (Convert.IsDBNull(reader["SoTinChi"]))?0.0m:(System.Decimal)reader["SoTinChi"];
					entity.LyThuyet = (System.Decimal)reader[((int)ViewBangTienDoGiangDayColumn.LyThuyet)];
					//entity.LyThuyet = (Convert.IsDBNull(reader["LyThuyet"]))?0.0m:(System.Decimal)reader["LyThuyet"];
					entity.ThucHanh = (System.Decimal)reader[((int)ViewBangTienDoGiangDayColumn.ThucHanh)];
					//entity.ThucHanh = (Convert.IsDBNull(reader["ThucHanh"]))?0.0m:(System.Decimal)reader["ThucHanh"];
					entity.BaiTap = (System.Decimal)reader[((int)ViewBangTienDoGiangDayColumn.BaiTap)];
					//entity.BaiTap = (Convert.IsDBNull(reader["BaiTap"]))?0.0m:(System.Decimal)reader["BaiTap"];
					entity.BaiTapLon = (System.Decimal)reader[((int)ViewBangTienDoGiangDayColumn.BaiTapLon)];
					//entity.BaiTapLon = (Convert.IsDBNull(reader["BaiTapLon"]))?0.0m:(System.Decimal)reader["BaiTapLon"];
					entity.DoAn = (System.Decimal)reader[((int)ViewBangTienDoGiangDayColumn.DoAn)];
					//entity.DoAn = (Convert.IsDBNull(reader["DoAn"]))?0.0m:(System.Decimal)reader["DoAn"];
					entity.LuanAn = (System.Decimal)reader[((int)ViewBangTienDoGiangDayColumn.LuanAn)];
					//entity.LuanAn = (Convert.IsDBNull(reader["LuanAn"]))?0.0m:(System.Decimal)reader["LuanAn"];
					entity.TieuLuan = (System.Decimal)reader[((int)ViewBangTienDoGiangDayColumn.TieuLuan)];
					//entity.TieuLuan = (Convert.IsDBNull(reader["TieuLuan"]))?0.0m:(System.Decimal)reader["TieuLuan"];
					entity.ThucTap = (System.Decimal)reader[((int)ViewBangTienDoGiangDayColumn.ThucTap)];
					//entity.ThucTap = (Convert.IsDBNull(reader["ThucTap"]))?0.0m:(System.Decimal)reader["ThucTap"];
					entity.Tuan = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.Tuan)))?null:(System.Int32?)reader[((int)ViewBangTienDoGiangDayColumn.Tuan)];
					//entity.Tuan = (Convert.IsDBNull(reader["Tuan"]))?(int)0:(System.Int32?)reader["Tuan"];
					entity.Nam = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.Nam)))?null:(System.Int32?)reader[((int)ViewBangTienDoGiangDayColumn.Nam)];
					//entity.Nam = (Convert.IsDBNull(reader["Nam"]))?(int)0:(System.Int32?)reader["Nam"];
					entity.NgayBatDau = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.NgayBatDau)))?null:(System.DateTime?)reader[((int)ViewBangTienDoGiangDayColumn.NgayBatDau)];
					//entity.NgayBatDau = (Convert.IsDBNull(reader["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)reader["NgayBatDau"];
					entity.NgayKetThuc = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.NgayKetThuc)))?null:(System.DateTime?)reader[((int)ViewBangTienDoGiangDayColumn.NgayKetThuc)];
					//entity.NgayKetThuc = (Convert.IsDBNull(reader["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKetThuc"];
					entity.MaBuoiHoc = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.MaBuoiHoc)))?null:(System.Int32?)reader[((int)ViewBangTienDoGiangDayColumn.MaBuoiHoc)];
					//entity.MaBuoiHoc = (Convert.IsDBNull(reader["MaBuoiHoc"]))?(int)0:(System.Int32?)reader["MaBuoiHoc"];
					entity.TenBuoiHoc = (System.String)reader[((int)ViewBangTienDoGiangDayColumn.TenBuoiHoc)];
					//entity.TenBuoiHoc = (Convert.IsDBNull(reader["TenBuoiHoc"]))?string.Empty:(System.String)reader["TenBuoiHoc"];
					entity.ThoiGianHoc = (System.String)reader[((int)ViewBangTienDoGiangDayColumn.ThoiGianHoc)];
					//entity.ThoiGianHoc = (Convert.IsDBNull(reader["ThoiGianHoc"]))?string.Empty:(System.String)reader["ThoiGianHoc"];
					entity.SoTiet = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.SoTiet)))?null:(System.Int32?)reader[((int)ViewBangTienDoGiangDayColumn.SoTiet)];
					//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32?)reader["SoTiet"];
					entity.TietBatDau = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.TietBatDau)))?null:(System.Int32?)reader[((int)ViewBangTienDoGiangDayColumn.TietBatDau)];
					//entity.TietBatDau = (Convert.IsDBNull(reader["TietBatDau"]))?(int)0:(System.Int32?)reader["TietBatDau"];
					entity.NgayTao = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.NgayTao)))?null:(System.DateTime?)reader[((int)ViewBangTienDoGiangDayColumn.NgayTao)];
					//entity.NgayTao = (Convert.IsDBNull(reader["NgayTao"]))?DateTime.MinValue:(System.DateTime?)reader["NgayTao"];
					entity.RowIndex = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.RowIndex)))?null:(System.Int32?)reader[((int)ViewBangTienDoGiangDayColumn.RowIndex)];
					//entity.RowIndex = (Convert.IsDBNull(reader["RowIndex"]))?(int)0:(System.Int32?)reader["RowIndex"];
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
		/// Refreshes the <see cref="ViewBangTienDoGiangDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewBangTienDoGiangDay"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewBangTienDoGiangDay entity)
		{
			reader.Read();
			entity.MaLichHoc = (System.Int32)reader[((int)ViewBangTienDoGiangDayColumn.MaLichHoc)];
			//entity.MaLichHoc = (Convert.IsDBNull(reader["MaLichHoc"]))?(int)0:(System.Int32)reader["MaLichHoc"];
			entity.MaGiangVien = (System.String)reader[((int)ViewBangTienDoGiangDayColumn.MaGiangVien)];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?string.Empty:(System.String)reader["MaGiangVien"];
			entity.Ho = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.Ho)))?null:(System.String)reader[((int)ViewBangTienDoGiangDayColumn.Ho)];
			//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
			entity.Ten = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.Ten)))?null:(System.String)reader[((int)ViewBangTienDoGiangDayColumn.Ten)];
			//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
			entity.MaLopHocPhan = (System.String)reader[((int)ViewBangTienDoGiangDayColumn.MaLopHocPhan)];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			entity.MaLop = (System.String)reader[((int)ViewBangTienDoGiangDayColumn.MaLop)];
			//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
			entity.NamHoc = (System.String)reader[((int)ViewBangTienDoGiangDayColumn.NamHoc)];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = (System.String)reader[((int)ViewBangTienDoGiangDayColumn.HocKy)];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.MaMonHoc = (System.String)reader[((int)ViewBangTienDoGiangDayColumn.MaMonHoc)];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.MaLoaiHocPhan = (System.Byte)reader[((int)ViewBangTienDoGiangDayColumn.MaLoaiHocPhan)];
			//entity.MaLoaiHocPhan = (Convert.IsDBNull(reader["MaLoaiHocPhan"]))?(byte)0:(System.Byte)reader["MaLoaiHocPhan"];
			entity.LoaiHocPhan = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.LoaiHocPhan)))?null:(System.String)reader[((int)ViewBangTienDoGiangDayColumn.LoaiHocPhan)];
			//entity.LoaiHocPhan = (Convert.IsDBNull(reader["LoaiHocPhan"]))?string.Empty:(System.String)reader["LoaiHocPhan"];
			entity.PhanLoai = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.PhanLoai)))?null:(System.String)reader[((int)ViewBangTienDoGiangDayColumn.PhanLoai)];
			//entity.PhanLoai = (Convert.IsDBNull(reader["PhanLoai"]))?string.Empty:(System.String)reader["PhanLoai"];
			entity.SiSoLop = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.SiSoLop)))?null:(System.Int32?)reader[((int)ViewBangTienDoGiangDayColumn.SiSoLop)];
			//entity.SiSoLop = (Convert.IsDBNull(reader["SiSoLop"]))?(int)0:(System.Int32?)reader["SiSoLop"];
			entity.TrongGio = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.TrongGio)))?null:(System.Decimal?)reader[((int)ViewBangTienDoGiangDayColumn.TrongGio)];
			//entity.TrongGio = (Convert.IsDBNull(reader["TrongGio"]))?0.0m:(System.Decimal?)reader["TrongGio"];
			entity.NgoaiGio = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.NgoaiGio)))?null:(System.Decimal?)reader[((int)ViewBangTienDoGiangDayColumn.NgoaiGio)];
			//entity.NgoaiGio = (Convert.IsDBNull(reader["NgoaiGio"]))?0.0m:(System.Decimal?)reader["NgoaiGio"];
			entity.ChatLuongCao = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.ChatLuongCao)))?null:(System.Decimal?)reader[((int)ViewBangTienDoGiangDayColumn.ChatLuongCao)];
			//entity.ChatLuongCao = (Convert.IsDBNull(reader["ChatLuongCao"]))?0.0m:(System.Decimal?)reader["ChatLuongCao"];
			entity.Nhom = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.Nhom)))?null:(System.String)reader[((int)ViewBangTienDoGiangDayColumn.Nhom)];
			//entity.Nhom = (Convert.IsDBNull(reader["Nhom"]))?string.Empty:(System.String)reader["Nhom"];
			entity.SoTinChi = (System.Decimal)reader[((int)ViewBangTienDoGiangDayColumn.SoTinChi)];
			//entity.SoTinChi = (Convert.IsDBNull(reader["SoTinChi"]))?0.0m:(System.Decimal)reader["SoTinChi"];
			entity.LyThuyet = (System.Decimal)reader[((int)ViewBangTienDoGiangDayColumn.LyThuyet)];
			//entity.LyThuyet = (Convert.IsDBNull(reader["LyThuyet"]))?0.0m:(System.Decimal)reader["LyThuyet"];
			entity.ThucHanh = (System.Decimal)reader[((int)ViewBangTienDoGiangDayColumn.ThucHanh)];
			//entity.ThucHanh = (Convert.IsDBNull(reader["ThucHanh"]))?0.0m:(System.Decimal)reader["ThucHanh"];
			entity.BaiTap = (System.Decimal)reader[((int)ViewBangTienDoGiangDayColumn.BaiTap)];
			//entity.BaiTap = (Convert.IsDBNull(reader["BaiTap"]))?0.0m:(System.Decimal)reader["BaiTap"];
			entity.BaiTapLon = (System.Decimal)reader[((int)ViewBangTienDoGiangDayColumn.BaiTapLon)];
			//entity.BaiTapLon = (Convert.IsDBNull(reader["BaiTapLon"]))?0.0m:(System.Decimal)reader["BaiTapLon"];
			entity.DoAn = (System.Decimal)reader[((int)ViewBangTienDoGiangDayColumn.DoAn)];
			//entity.DoAn = (Convert.IsDBNull(reader["DoAn"]))?0.0m:(System.Decimal)reader["DoAn"];
			entity.LuanAn = (System.Decimal)reader[((int)ViewBangTienDoGiangDayColumn.LuanAn)];
			//entity.LuanAn = (Convert.IsDBNull(reader["LuanAn"]))?0.0m:(System.Decimal)reader["LuanAn"];
			entity.TieuLuan = (System.Decimal)reader[((int)ViewBangTienDoGiangDayColumn.TieuLuan)];
			//entity.TieuLuan = (Convert.IsDBNull(reader["TieuLuan"]))?0.0m:(System.Decimal)reader["TieuLuan"];
			entity.ThucTap = (System.Decimal)reader[((int)ViewBangTienDoGiangDayColumn.ThucTap)];
			//entity.ThucTap = (Convert.IsDBNull(reader["ThucTap"]))?0.0m:(System.Decimal)reader["ThucTap"];
			entity.Tuan = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.Tuan)))?null:(System.Int32?)reader[((int)ViewBangTienDoGiangDayColumn.Tuan)];
			//entity.Tuan = (Convert.IsDBNull(reader["Tuan"]))?(int)0:(System.Int32?)reader["Tuan"];
			entity.Nam = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.Nam)))?null:(System.Int32?)reader[((int)ViewBangTienDoGiangDayColumn.Nam)];
			//entity.Nam = (Convert.IsDBNull(reader["Nam"]))?(int)0:(System.Int32?)reader["Nam"];
			entity.NgayBatDau = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.NgayBatDau)))?null:(System.DateTime?)reader[((int)ViewBangTienDoGiangDayColumn.NgayBatDau)];
			//entity.NgayBatDau = (Convert.IsDBNull(reader["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)reader["NgayBatDau"];
			entity.NgayKetThuc = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.NgayKetThuc)))?null:(System.DateTime?)reader[((int)ViewBangTienDoGiangDayColumn.NgayKetThuc)];
			//entity.NgayKetThuc = (Convert.IsDBNull(reader["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKetThuc"];
			entity.MaBuoiHoc = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.MaBuoiHoc)))?null:(System.Int32?)reader[((int)ViewBangTienDoGiangDayColumn.MaBuoiHoc)];
			//entity.MaBuoiHoc = (Convert.IsDBNull(reader["MaBuoiHoc"]))?(int)0:(System.Int32?)reader["MaBuoiHoc"];
			entity.TenBuoiHoc = (System.String)reader[((int)ViewBangTienDoGiangDayColumn.TenBuoiHoc)];
			//entity.TenBuoiHoc = (Convert.IsDBNull(reader["TenBuoiHoc"]))?string.Empty:(System.String)reader["TenBuoiHoc"];
			entity.ThoiGianHoc = (System.String)reader[((int)ViewBangTienDoGiangDayColumn.ThoiGianHoc)];
			//entity.ThoiGianHoc = (Convert.IsDBNull(reader["ThoiGianHoc"]))?string.Empty:(System.String)reader["ThoiGianHoc"];
			entity.SoTiet = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.SoTiet)))?null:(System.Int32?)reader[((int)ViewBangTienDoGiangDayColumn.SoTiet)];
			//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32?)reader["SoTiet"];
			entity.TietBatDau = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.TietBatDau)))?null:(System.Int32?)reader[((int)ViewBangTienDoGiangDayColumn.TietBatDau)];
			//entity.TietBatDau = (Convert.IsDBNull(reader["TietBatDau"]))?(int)0:(System.Int32?)reader["TietBatDau"];
			entity.NgayTao = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.NgayTao)))?null:(System.DateTime?)reader[((int)ViewBangTienDoGiangDayColumn.NgayTao)];
			//entity.NgayTao = (Convert.IsDBNull(reader["NgayTao"]))?DateTime.MinValue:(System.DateTime?)reader["NgayTao"];
			entity.RowIndex = (reader.IsDBNull(((int)ViewBangTienDoGiangDayColumn.RowIndex)))?null:(System.Int32?)reader[((int)ViewBangTienDoGiangDayColumn.RowIndex)];
			//entity.RowIndex = (Convert.IsDBNull(reader["RowIndex"]))?(int)0:(System.Int32?)reader["RowIndex"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewBangTienDoGiangDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewBangTienDoGiangDay"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewBangTienDoGiangDay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaLichHoc = (Convert.IsDBNull(dataRow["MaLichHoc"]))?(int)0:(System.Int32)dataRow["MaLichHoc"];
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?string.Empty:(System.String)dataRow["MaGiangVien"];
			entity.Ho = (Convert.IsDBNull(dataRow["Ho"]))?string.Empty:(System.String)dataRow["Ho"];
			entity.Ten = (Convert.IsDBNull(dataRow["Ten"]))?string.Empty:(System.String)dataRow["Ten"];
			entity.MaLopHocPhan = (Convert.IsDBNull(dataRow["MaLopHocPhan"]))?string.Empty:(System.String)dataRow["MaLopHocPhan"];
			entity.MaLop = (Convert.IsDBNull(dataRow["MaLop"]))?string.Empty:(System.String)dataRow["MaLop"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.MaMonHoc = (Convert.IsDBNull(dataRow["MaMonHoc"]))?string.Empty:(System.String)dataRow["MaMonHoc"];
			entity.MaLoaiHocPhan = (Convert.IsDBNull(dataRow["MaLoaiHocPhan"]))?(byte)0:(System.Byte)dataRow["MaLoaiHocPhan"];
			entity.LoaiHocPhan = (Convert.IsDBNull(dataRow["LoaiHocPhan"]))?string.Empty:(System.String)dataRow["LoaiHocPhan"];
			entity.PhanLoai = (Convert.IsDBNull(dataRow["PhanLoai"]))?string.Empty:(System.String)dataRow["PhanLoai"];
			entity.SiSoLop = (Convert.IsDBNull(dataRow["SiSoLop"]))?(int)0:(System.Int32?)dataRow["SiSoLop"];
			entity.TrongGio = (Convert.IsDBNull(dataRow["TrongGio"]))?0.0m:(System.Decimal?)dataRow["TrongGio"];
			entity.NgoaiGio = (Convert.IsDBNull(dataRow["NgoaiGio"]))?0.0m:(System.Decimal?)dataRow["NgoaiGio"];
			entity.ChatLuongCao = (Convert.IsDBNull(dataRow["ChatLuongCao"]))?0.0m:(System.Decimal?)dataRow["ChatLuongCao"];
			entity.Nhom = (Convert.IsDBNull(dataRow["Nhom"]))?string.Empty:(System.String)dataRow["Nhom"];
			entity.SoTinChi = (Convert.IsDBNull(dataRow["SoTinChi"]))?0.0m:(System.Decimal)dataRow["SoTinChi"];
			entity.LyThuyet = (Convert.IsDBNull(dataRow["LyThuyet"]))?0.0m:(System.Decimal)dataRow["LyThuyet"];
			entity.ThucHanh = (Convert.IsDBNull(dataRow["ThucHanh"]))?0.0m:(System.Decimal)dataRow["ThucHanh"];
			entity.BaiTap = (Convert.IsDBNull(dataRow["BaiTap"]))?0.0m:(System.Decimal)dataRow["BaiTap"];
			entity.BaiTapLon = (Convert.IsDBNull(dataRow["BaiTapLon"]))?0.0m:(System.Decimal)dataRow["BaiTapLon"];
			entity.DoAn = (Convert.IsDBNull(dataRow["DoAn"]))?0.0m:(System.Decimal)dataRow["DoAn"];
			entity.LuanAn = (Convert.IsDBNull(dataRow["LuanAn"]))?0.0m:(System.Decimal)dataRow["LuanAn"];
			entity.TieuLuan = (Convert.IsDBNull(dataRow["TieuLuan"]))?0.0m:(System.Decimal)dataRow["TieuLuan"];
			entity.ThucTap = (Convert.IsDBNull(dataRow["ThucTap"]))?0.0m:(System.Decimal)dataRow["ThucTap"];
			entity.Tuan = (Convert.IsDBNull(dataRow["Tuan"]))?(int)0:(System.Int32?)dataRow["Tuan"];
			entity.Nam = (Convert.IsDBNull(dataRow["Nam"]))?(int)0:(System.Int32?)dataRow["Nam"];
			entity.NgayBatDau = (Convert.IsDBNull(dataRow["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayBatDau"];
			entity.NgayKetThuc = (Convert.IsDBNull(dataRow["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayKetThuc"];
			entity.MaBuoiHoc = (Convert.IsDBNull(dataRow["MaBuoiHoc"]))?(int)0:(System.Int32?)dataRow["MaBuoiHoc"];
			entity.TenBuoiHoc = (Convert.IsDBNull(dataRow["TenBuoiHoc"]))?string.Empty:(System.String)dataRow["TenBuoiHoc"];
			entity.ThoiGianHoc = (Convert.IsDBNull(dataRow["ThoiGianHoc"]))?string.Empty:(System.String)dataRow["ThoiGianHoc"];
			entity.SoTiet = (Convert.IsDBNull(dataRow["SoTiet"]))?(int)0:(System.Int32?)dataRow["SoTiet"];
			entity.TietBatDau = (Convert.IsDBNull(dataRow["TietBatDau"]))?(int)0:(System.Int32?)dataRow["TietBatDau"];
			entity.NgayTao = (Convert.IsDBNull(dataRow["NgayTao"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayTao"];
			entity.RowIndex = (Convert.IsDBNull(dataRow["RowIndex"]))?(int)0:(System.Int32?)dataRow["RowIndex"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewBangTienDoGiangDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewBangTienDoGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewBangTienDoGiangDayFilterBuilder : SqlFilterBuilder<ViewBangTienDoGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewBangTienDoGiangDayFilterBuilder class.
		/// </summary>
		public ViewBangTienDoGiangDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewBangTienDoGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewBangTienDoGiangDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewBangTienDoGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewBangTienDoGiangDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewBangTienDoGiangDayFilterBuilder

	#region ViewBangTienDoGiangDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewBangTienDoGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewBangTienDoGiangDayParameterBuilder : ParameterizedSqlFilterBuilder<ViewBangTienDoGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewBangTienDoGiangDayParameterBuilder class.
		/// </summary>
		public ViewBangTienDoGiangDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewBangTienDoGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewBangTienDoGiangDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewBangTienDoGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewBangTienDoGiangDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewBangTienDoGiangDayParameterBuilder
	
	#region ViewBangTienDoGiangDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewBangTienDoGiangDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewBangTienDoGiangDaySortBuilder : SqlSortBuilder<ViewBangTienDoGiangDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewBangTienDoGiangDaySqlSortBuilder class.
		/// </summary>
		public ViewBangTienDoGiangDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewBangTienDoGiangDaySortBuilder

} // end namespace
