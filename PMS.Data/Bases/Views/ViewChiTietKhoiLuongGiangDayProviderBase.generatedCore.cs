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
	/// This class is the base class for any <see cref="ViewChiTietKhoiLuongGiangDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewChiTietKhoiLuongGiangDayProviderBaseCore : EntityViewProviderBase<ViewChiTietKhoiLuongGiangDay>
	{
		#region Custom Methods
		
		
		#region cust_View_ChiTiet_KhoiLuong_GiangDay_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_KhoiLuong_GiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewChiTietKhoiLuongGiangDay&gt;"/> instance.</returns>
		public VList<ViewChiTietKhoiLuongGiangDay> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_KhoiLuong_GiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewChiTietKhoiLuongGiangDay&gt;"/> instance.</returns>
		public VList<ViewChiTietKhoiLuongGiangDay> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_KhoiLuong_GiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewChiTietKhoiLuongGiangDay&gt;"/> instance.</returns>
		public VList<ViewChiTietKhoiLuongGiangDay> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_KhoiLuong_GiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewChiTietKhoiLuongGiangDay&gt;"/> instance.</returns>
		public abstract VList<ViewChiTietKhoiLuongGiangDay> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewChiTietKhoiLuongGiangDay&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewChiTietKhoiLuongGiangDay&gt;"/></returns>
		protected static VList&lt;ViewChiTietKhoiLuongGiangDay&gt; Fill(DataSet dataSet, VList<ViewChiTietKhoiLuongGiangDay> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewChiTietKhoiLuongGiangDay>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewChiTietKhoiLuongGiangDay&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewChiTietKhoiLuongGiangDay>"/></returns>
		protected static VList&lt;ViewChiTietKhoiLuongGiangDay&gt; Fill(DataTable dataTable, VList<ViewChiTietKhoiLuongGiangDay> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewChiTietKhoiLuongGiangDay c = new ViewChiTietKhoiLuongGiangDay();
					c.MaLichHoc = (Convert.IsDBNull(row["MaLichHoc"]))?(int)0:(System.Int32?)row["MaLichHoc"];
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32?)row["MaGiangVien"];
					c.MaLopHocPhan = (Convert.IsDBNull(row["MaLopHocPhan"]))?string.Empty:(System.String)row["MaLopHocPhan"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.MaMonHoc = (Convert.IsDBNull(row["MaMonHoc"]))?string.Empty:(System.String)row["MaMonHoc"];
					c.TenMonHoc = (Convert.IsDBNull(row["TenMonHoc"]))?string.Empty:(System.String)row["TenMonHoc"];
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
					c.SoLuong = (Convert.IsDBNull(row["SoLuong"]))?(int)0:(System.Int32?)row["SoLuong"];
					c.MaLoaiHocPhan = (Convert.IsDBNull(row["MaLoaiHocPhan"]))?(byte)0:(System.Byte)row["MaLoaiHocPhan"];
					c.LoaiHocPhan = (Convert.IsDBNull(row["LoaiHocPhan"]))?string.Empty:(System.String)row["LoaiHocPhan"];
					c.PhanLoai = (Convert.IsDBNull(row["PhanLoai"]))?string.Empty:(System.String)row["PhanLoai"];
					c.HeSoThanhPhan = (Convert.IsDBNull(row["HeSoThanhPhan"]))?0.0m:(System.Decimal)row["HeSoThanhPhan"];
					c.Nam = (Convert.IsDBNull(row["Nam"]))?(int)0:(System.Int32?)row["Nam"];
					c.Tuan = (Convert.IsDBNull(row["Tuan"]))?(int)0:(System.Int32?)row["Tuan"];
					c.DonViTinh = (Convert.IsDBNull(row["DonViTinh"]))?string.Empty:(System.String)row["DonViTinh"];
					c.MaBuoiHoc = (Convert.IsDBNull(row["MaBuoiHoc"]))?(int)0:(System.Int32?)row["MaBuoiHoc"];
					c.MaLop = (Convert.IsDBNull(row["MaLop"]))?string.Empty:(System.String)row["MaLop"];
					c.TietBatDau = (Convert.IsDBNull(row["TietBatDau"]))?(int)0:(System.Int32?)row["TietBatDau"];
					c.SoTiet = (Convert.IsDBNull(row["SoTiet"]))?(int)0:(System.Int32?)row["SoTiet"];
					c.LoaiHocKy = (Convert.IsDBNull(row["LoaiHocKy"]))?(byte)0:(System.Byte?)row["LoaiHocKy"];
					c.HeSoHocKy = (Convert.IsDBNull(row["HeSoHocKy"]))?0.0m:(System.Decimal)row["HeSoHocKy"];
					c.TinhTrang = (Convert.IsDBNull(row["TinhTrang"]))?(int)0:(System.Int32?)row["TinhTrang"];
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
		/// Fill an <see cref="VList&lt;ViewChiTietKhoiLuongGiangDay&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewChiTietKhoiLuongGiangDay&gt;"/></returns>
		protected VList<ViewChiTietKhoiLuongGiangDay> Fill(IDataReader reader, VList<ViewChiTietKhoiLuongGiangDay> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewChiTietKhoiLuongGiangDay entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewChiTietKhoiLuongGiangDay>("ViewChiTietKhoiLuongGiangDay",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewChiTietKhoiLuongGiangDay();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaLichHoc = reader.IsDBNull(reader.GetOrdinal("MaLichHoc")) ? null : (System.Int32?)reader["MaLichHoc"];
					//entity.MaLichHoc = (Convert.IsDBNull(reader["MaLichHoc"]))?(int)0:(System.Int32?)reader["MaLichHoc"];
					entity.MaGiangVien = reader.IsDBNull(reader.GetOrdinal("MaGiangVien")) ? null : (System.Int32?)reader["MaGiangVien"];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32?)reader["MaGiangVien"];
					entity.MaLopHocPhan = (System.String)reader["MaLopHocPhan"];
					//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
					entity.NamHoc = (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.MaMonHoc = (System.String)reader["MaMonHoc"];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.TenMonHoc = (System.String)reader["TenMonHoc"];
					//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
					entity.Nhom = reader.IsDBNull(reader.GetOrdinal("Nhom")) ? null : (System.String)reader["Nhom"];
					//entity.Nhom = (Convert.IsDBNull(reader["Nhom"]))?string.Empty:(System.String)reader["Nhom"];
					entity.SoTinChi = (System.Decimal)reader["SoTinChi"];
					//entity.SoTinChi = (Convert.IsDBNull(reader["SoTinChi"]))?0.0m:(System.Decimal)reader["SoTinChi"];
					entity.LyThuyet = (System.Decimal)reader["LyThuyet"];
					//entity.LyThuyet = (Convert.IsDBNull(reader["LyThuyet"]))?0.0m:(System.Decimal)reader["LyThuyet"];
					entity.ThucHanh = (System.Decimal)reader["ThucHanh"];
					//entity.ThucHanh = (Convert.IsDBNull(reader["ThucHanh"]))?0.0m:(System.Decimal)reader["ThucHanh"];
					entity.BaiTap = (System.Decimal)reader["BaiTap"];
					//entity.BaiTap = (Convert.IsDBNull(reader["BaiTap"]))?0.0m:(System.Decimal)reader["BaiTap"];
					entity.BaiTapLon = (System.Decimal)reader["BaiTapLon"];
					//entity.BaiTapLon = (Convert.IsDBNull(reader["BaiTapLon"]))?0.0m:(System.Decimal)reader["BaiTapLon"];
					entity.DoAn = (System.Decimal)reader["DoAn"];
					//entity.DoAn = (Convert.IsDBNull(reader["DoAn"]))?0.0m:(System.Decimal)reader["DoAn"];
					entity.LuanAn = (System.Decimal)reader["LuanAn"];
					//entity.LuanAn = (Convert.IsDBNull(reader["LuanAn"]))?0.0m:(System.Decimal)reader["LuanAn"];
					entity.TieuLuan = (System.Decimal)reader["TieuLuan"];
					//entity.TieuLuan = (Convert.IsDBNull(reader["TieuLuan"]))?0.0m:(System.Decimal)reader["TieuLuan"];
					entity.ThucTap = (System.Decimal)reader["ThucTap"];
					//entity.ThucTap = (Convert.IsDBNull(reader["ThucTap"]))?0.0m:(System.Decimal)reader["ThucTap"];
					entity.SoLuong = reader.IsDBNull(reader.GetOrdinal("SoLuong")) ? null : (System.Int32?)reader["SoLuong"];
					//entity.SoLuong = (Convert.IsDBNull(reader["SoLuong"]))?(int)0:(System.Int32?)reader["SoLuong"];
					entity.MaLoaiHocPhan = (System.Byte)reader["MaLoaiHocPhan"];
					//entity.MaLoaiHocPhan = (Convert.IsDBNull(reader["MaLoaiHocPhan"]))?(byte)0:(System.Byte)reader["MaLoaiHocPhan"];
					entity.LoaiHocPhan = reader.IsDBNull(reader.GetOrdinal("LoaiHocPhan")) ? null : (System.String)reader["LoaiHocPhan"];
					//entity.LoaiHocPhan = (Convert.IsDBNull(reader["LoaiHocPhan"]))?string.Empty:(System.String)reader["LoaiHocPhan"];
					entity.PhanLoai = reader.IsDBNull(reader.GetOrdinal("PhanLoai")) ? null : (System.String)reader["PhanLoai"];
					//entity.PhanLoai = (Convert.IsDBNull(reader["PhanLoai"]))?string.Empty:(System.String)reader["PhanLoai"];
					entity.HeSoThanhPhan = (System.Decimal)reader["HeSoThanhPhan"];
					//entity.HeSoThanhPhan = (Convert.IsDBNull(reader["HeSoThanhPhan"]))?0.0m:(System.Decimal)reader["HeSoThanhPhan"];
					entity.Nam = reader.IsDBNull(reader.GetOrdinal("Nam")) ? null : (System.Int32?)reader["Nam"];
					//entity.Nam = (Convert.IsDBNull(reader["Nam"]))?(int)0:(System.Int32?)reader["Nam"];
					entity.Tuan = reader.IsDBNull(reader.GetOrdinal("Tuan")) ? null : (System.Int32?)reader["Tuan"];
					//entity.Tuan = (Convert.IsDBNull(reader["Tuan"]))?(int)0:(System.Int32?)reader["Tuan"];
					entity.DonViTinh = reader.IsDBNull(reader.GetOrdinal("DonViTinh")) ? null : (System.String)reader["DonViTinh"];
					//entity.DonViTinh = (Convert.IsDBNull(reader["DonViTinh"]))?string.Empty:(System.String)reader["DonViTinh"];
					entity.MaBuoiHoc = reader.IsDBNull(reader.GetOrdinal("MaBuoiHoc")) ? null : (System.Int32?)reader["MaBuoiHoc"];
					//entity.MaBuoiHoc = (Convert.IsDBNull(reader["MaBuoiHoc"]))?(int)0:(System.Int32?)reader["MaBuoiHoc"];
					entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
					//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
					entity.TietBatDau = reader.IsDBNull(reader.GetOrdinal("TietBatDau")) ? null : (System.Int32?)reader["TietBatDau"];
					//entity.TietBatDau = (Convert.IsDBNull(reader["TietBatDau"]))?(int)0:(System.Int32?)reader["TietBatDau"];
					entity.SoTiet = reader.IsDBNull(reader.GetOrdinal("SoTiet")) ? null : (System.Int32?)reader["SoTiet"];
					//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32?)reader["SoTiet"];
					entity.LoaiHocKy = reader.IsDBNull(reader.GetOrdinal("LoaiHocKy")) ? null : (System.Byte?)reader["LoaiHocKy"];
					//entity.LoaiHocKy = (Convert.IsDBNull(reader["LoaiHocKy"]))?(byte)0:(System.Byte?)reader["LoaiHocKy"];
					entity.HeSoHocKy = (System.Decimal)reader["HeSoHocKy"];
					//entity.HeSoHocKy = (Convert.IsDBNull(reader["HeSoHocKy"]))?0.0m:(System.Decimal)reader["HeSoHocKy"];
					entity.TinhTrang = reader.IsDBNull(reader.GetOrdinal("TinhTrang")) ? null : (System.Int32?)reader["TinhTrang"];
					//entity.TinhTrang = (Convert.IsDBNull(reader["TinhTrang"]))?(int)0:(System.Int32?)reader["TinhTrang"];
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
		/// Refreshes the <see cref="ViewChiTietKhoiLuongGiangDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewChiTietKhoiLuongGiangDay"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewChiTietKhoiLuongGiangDay entity)
		{
			reader.Read();
			entity.MaLichHoc = reader.IsDBNull(reader.GetOrdinal("MaLichHoc")) ? null : (System.Int32?)reader["MaLichHoc"];
			//entity.MaLichHoc = (Convert.IsDBNull(reader["MaLichHoc"]))?(int)0:(System.Int32?)reader["MaLichHoc"];
			entity.MaGiangVien = reader.IsDBNull(reader.GetOrdinal("MaGiangVien")) ? null : (System.Int32?)reader["MaGiangVien"];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32?)reader["MaGiangVien"];
			entity.MaLopHocPhan = (System.String)reader["MaLopHocPhan"];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			entity.NamHoc = (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.MaMonHoc = (System.String)reader["MaMonHoc"];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.TenMonHoc = (System.String)reader["TenMonHoc"];
			//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
			entity.Nhom = reader.IsDBNull(reader.GetOrdinal("Nhom")) ? null : (System.String)reader["Nhom"];
			//entity.Nhom = (Convert.IsDBNull(reader["Nhom"]))?string.Empty:(System.String)reader["Nhom"];
			entity.SoTinChi = (System.Decimal)reader["SoTinChi"];
			//entity.SoTinChi = (Convert.IsDBNull(reader["SoTinChi"]))?0.0m:(System.Decimal)reader["SoTinChi"];
			entity.LyThuyet = (System.Decimal)reader["LyThuyet"];
			//entity.LyThuyet = (Convert.IsDBNull(reader["LyThuyet"]))?0.0m:(System.Decimal)reader["LyThuyet"];
			entity.ThucHanh = (System.Decimal)reader["ThucHanh"];
			//entity.ThucHanh = (Convert.IsDBNull(reader["ThucHanh"]))?0.0m:(System.Decimal)reader["ThucHanh"];
			entity.BaiTap = (System.Decimal)reader["BaiTap"];
			//entity.BaiTap = (Convert.IsDBNull(reader["BaiTap"]))?0.0m:(System.Decimal)reader["BaiTap"];
			entity.BaiTapLon = (System.Decimal)reader["BaiTapLon"];
			//entity.BaiTapLon = (Convert.IsDBNull(reader["BaiTapLon"]))?0.0m:(System.Decimal)reader["BaiTapLon"];
			entity.DoAn = (System.Decimal)reader["DoAn"];
			//entity.DoAn = (Convert.IsDBNull(reader["DoAn"]))?0.0m:(System.Decimal)reader["DoAn"];
			entity.LuanAn = (System.Decimal)reader["LuanAn"];
			//entity.LuanAn = (Convert.IsDBNull(reader["LuanAn"]))?0.0m:(System.Decimal)reader["LuanAn"];
			entity.TieuLuan = (System.Decimal)reader["TieuLuan"];
			//entity.TieuLuan = (Convert.IsDBNull(reader["TieuLuan"]))?0.0m:(System.Decimal)reader["TieuLuan"];
			entity.ThucTap = (System.Decimal)reader["ThucTap"];
			//entity.ThucTap = (Convert.IsDBNull(reader["ThucTap"]))?0.0m:(System.Decimal)reader["ThucTap"];
			entity.SoLuong = reader.IsDBNull(reader.GetOrdinal("SoLuong")) ? null : (System.Int32?)reader["SoLuong"];
			//entity.SoLuong = (Convert.IsDBNull(reader["SoLuong"]))?(int)0:(System.Int32?)reader["SoLuong"];
			entity.MaLoaiHocPhan = (System.Byte)reader["MaLoaiHocPhan"];
			//entity.MaLoaiHocPhan = (Convert.IsDBNull(reader["MaLoaiHocPhan"]))?(byte)0:(System.Byte)reader["MaLoaiHocPhan"];
			entity.LoaiHocPhan = reader.IsDBNull(reader.GetOrdinal("LoaiHocPhan")) ? null : (System.String)reader["LoaiHocPhan"];
			//entity.LoaiHocPhan = (Convert.IsDBNull(reader["LoaiHocPhan"]))?string.Empty:(System.String)reader["LoaiHocPhan"];
			entity.PhanLoai = reader.IsDBNull(reader.GetOrdinal("PhanLoai")) ? null : (System.String)reader["PhanLoai"];
			//entity.PhanLoai = (Convert.IsDBNull(reader["PhanLoai"]))?string.Empty:(System.String)reader["PhanLoai"];
			entity.HeSoThanhPhan = (System.Decimal)reader["HeSoThanhPhan"];
			//entity.HeSoThanhPhan = (Convert.IsDBNull(reader["HeSoThanhPhan"]))?0.0m:(System.Decimal)reader["HeSoThanhPhan"];
			entity.Nam = reader.IsDBNull(reader.GetOrdinal("Nam")) ? null : (System.Int32?)reader["Nam"];
			//entity.Nam = (Convert.IsDBNull(reader["Nam"]))?(int)0:(System.Int32?)reader["Nam"];
			entity.Tuan = reader.IsDBNull(reader.GetOrdinal("Tuan")) ? null : (System.Int32?)reader["Tuan"];
			//entity.Tuan = (Convert.IsDBNull(reader["Tuan"]))?(int)0:(System.Int32?)reader["Tuan"];
			entity.DonViTinh = reader.IsDBNull(reader.GetOrdinal("DonViTinh")) ? null : (System.String)reader["DonViTinh"];
			//entity.DonViTinh = (Convert.IsDBNull(reader["DonViTinh"]))?string.Empty:(System.String)reader["DonViTinh"];
			entity.MaBuoiHoc = reader.IsDBNull(reader.GetOrdinal("MaBuoiHoc")) ? null : (System.Int32?)reader["MaBuoiHoc"];
			//entity.MaBuoiHoc = (Convert.IsDBNull(reader["MaBuoiHoc"]))?(int)0:(System.Int32?)reader["MaBuoiHoc"];
			entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
			//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
			entity.TietBatDau = reader.IsDBNull(reader.GetOrdinal("TietBatDau")) ? null : (System.Int32?)reader["TietBatDau"];
			//entity.TietBatDau = (Convert.IsDBNull(reader["TietBatDau"]))?(int)0:(System.Int32?)reader["TietBatDau"];
			entity.SoTiet = reader.IsDBNull(reader.GetOrdinal("SoTiet")) ? null : (System.Int32?)reader["SoTiet"];
			//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32?)reader["SoTiet"];
			entity.LoaiHocKy = reader.IsDBNull(reader.GetOrdinal("LoaiHocKy")) ? null : (System.Byte?)reader["LoaiHocKy"];
			//entity.LoaiHocKy = (Convert.IsDBNull(reader["LoaiHocKy"]))?(byte)0:(System.Byte?)reader["LoaiHocKy"];
			entity.HeSoHocKy = (System.Decimal)reader["HeSoHocKy"];
			//entity.HeSoHocKy = (Convert.IsDBNull(reader["HeSoHocKy"]))?0.0m:(System.Decimal)reader["HeSoHocKy"];
			entity.TinhTrang = reader.IsDBNull(reader.GetOrdinal("TinhTrang")) ? null : (System.Int32?)reader["TinhTrang"];
			//entity.TinhTrang = (Convert.IsDBNull(reader["TinhTrang"]))?(int)0:(System.Int32?)reader["TinhTrang"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewChiTietKhoiLuongGiangDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewChiTietKhoiLuongGiangDay"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewChiTietKhoiLuongGiangDay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaLichHoc = (Convert.IsDBNull(dataRow["MaLichHoc"]))?(int)0:(System.Int32?)dataRow["MaLichHoc"];
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32?)dataRow["MaGiangVien"];
			entity.MaLopHocPhan = (Convert.IsDBNull(dataRow["MaLopHocPhan"]))?string.Empty:(System.String)dataRow["MaLopHocPhan"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.MaMonHoc = (Convert.IsDBNull(dataRow["MaMonHoc"]))?string.Empty:(System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = (Convert.IsDBNull(dataRow["TenMonHoc"]))?string.Empty:(System.String)dataRow["TenMonHoc"];
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
			entity.SoLuong = (Convert.IsDBNull(dataRow["SoLuong"]))?(int)0:(System.Int32?)dataRow["SoLuong"];
			entity.MaLoaiHocPhan = (Convert.IsDBNull(dataRow["MaLoaiHocPhan"]))?(byte)0:(System.Byte)dataRow["MaLoaiHocPhan"];
			entity.LoaiHocPhan = (Convert.IsDBNull(dataRow["LoaiHocPhan"]))?string.Empty:(System.String)dataRow["LoaiHocPhan"];
			entity.PhanLoai = (Convert.IsDBNull(dataRow["PhanLoai"]))?string.Empty:(System.String)dataRow["PhanLoai"];
			entity.HeSoThanhPhan = (Convert.IsDBNull(dataRow["HeSoThanhPhan"]))?0.0m:(System.Decimal)dataRow["HeSoThanhPhan"];
			entity.Nam = (Convert.IsDBNull(dataRow["Nam"]))?(int)0:(System.Int32?)dataRow["Nam"];
			entity.Tuan = (Convert.IsDBNull(dataRow["Tuan"]))?(int)0:(System.Int32?)dataRow["Tuan"];
			entity.DonViTinh = (Convert.IsDBNull(dataRow["DonViTinh"]))?string.Empty:(System.String)dataRow["DonViTinh"];
			entity.MaBuoiHoc = (Convert.IsDBNull(dataRow["MaBuoiHoc"]))?(int)0:(System.Int32?)dataRow["MaBuoiHoc"];
			entity.MaLop = (Convert.IsDBNull(dataRow["MaLop"]))?string.Empty:(System.String)dataRow["MaLop"];
			entity.TietBatDau = (Convert.IsDBNull(dataRow["TietBatDau"]))?(int)0:(System.Int32?)dataRow["TietBatDau"];
			entity.SoTiet = (Convert.IsDBNull(dataRow["SoTiet"]))?(int)0:(System.Int32?)dataRow["SoTiet"];
			entity.LoaiHocKy = (Convert.IsDBNull(dataRow["LoaiHocKy"]))?(byte)0:(System.Byte?)dataRow["LoaiHocKy"];
			entity.HeSoHocKy = (Convert.IsDBNull(dataRow["HeSoHocKy"]))?0.0m:(System.Decimal)dataRow["HeSoHocKy"];
			entity.TinhTrang = (Convert.IsDBNull(dataRow["TinhTrang"]))?(int)0:(System.Int32?)dataRow["TinhTrang"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewChiTietKhoiLuongGiangDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTietKhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewChiTietKhoiLuongGiangDayFilterBuilder : SqlFilterBuilder<ViewChiTietKhoiLuongGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongGiangDayFilterBuilder class.
		/// </summary>
		public ViewChiTietKhoiLuongGiangDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewChiTietKhoiLuongGiangDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewChiTietKhoiLuongGiangDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewChiTietKhoiLuongGiangDayFilterBuilder

	#region ViewChiTietKhoiLuongGiangDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTietKhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewChiTietKhoiLuongGiangDayParameterBuilder : ParameterizedSqlFilterBuilder<ViewChiTietKhoiLuongGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongGiangDayParameterBuilder class.
		/// </summary>
		public ViewChiTietKhoiLuongGiangDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewChiTietKhoiLuongGiangDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewChiTietKhoiLuongGiangDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewChiTietKhoiLuongGiangDayParameterBuilder
	
	#region ViewChiTietKhoiLuongGiangDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTietKhoiLuongGiangDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewChiTietKhoiLuongGiangDaySortBuilder : SqlSortBuilder<ViewChiTietKhoiLuongGiangDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongGiangDaySqlSortBuilder class.
		/// </summary>
		public ViewChiTietKhoiLuongGiangDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewChiTietKhoiLuongGiangDaySortBuilder

} // end namespace
