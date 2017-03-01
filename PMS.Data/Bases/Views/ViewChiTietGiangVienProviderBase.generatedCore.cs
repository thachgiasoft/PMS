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
	/// This class is the base class for any <see cref="ViewChiTietGiangVienProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewChiTietGiangVienProviderBaseCore : EntityViewProviderBase<ViewChiTietGiangVien>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewChiTietGiangVien&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewChiTietGiangVien&gt;"/></returns>
		protected static VList&lt;ViewChiTietGiangVien&gt; Fill(DataSet dataSet, VList<ViewChiTietGiangVien> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewChiTietGiangVien>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewChiTietGiangVien&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewChiTietGiangVien>"/></returns>
		protected static VList&lt;ViewChiTietGiangVien&gt; Fill(DataTable dataTable, VList<ViewChiTietGiangVien> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewChiTietGiangVien c = new ViewChiTietGiangVien();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?string.Empty:(System.String)row["MaGiangVien"];
					c.MatKhau = (Convert.IsDBNull(row["MatKhau"]))?string.Empty:(System.String)row["MatKhau"];
					c.TenTinhTrang = (Convert.IsDBNull(row["TenTinhTrang"]))?string.Empty:(System.String)row["TenTinhTrang"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.GioiTinh = (Convert.IsDBNull(row["GioiTinh"]))?string.Empty:(System.String)row["GioiTinh"];
					c.NgaySinh = (Convert.IsDBNull(row["NgaySinh"]))?string.Empty:(System.String)row["NgaySinh"];
					c.NoiSinh = (Convert.IsDBNull(row["NoiSinh"]))?string.Empty:(System.String)row["NoiSinh"];
					c.Cmnd = (Convert.IsDBNull(row["Cmnd"]))?string.Empty:(System.String)row["Cmnd"];
					c.NgayCap = (Convert.IsDBNull(row["NgayCap"]))?string.Empty:(System.String)row["NgayCap"];
					c.NoiCap = (Convert.IsDBNull(row["NoiCap"]))?string.Empty:(System.String)row["NoiCap"];
					c.TenDanToc = (Convert.IsDBNull(row["TenDanToc"]))?string.Empty:(System.String)row["TenDanToc"];
					c.TenTonGiao = (Convert.IsDBNull(row["TenTonGiao"]))?string.Empty:(System.String)row["TenTonGiao"];
					c.DoanDang = (Convert.IsDBNull(row["DoanDang"]))?string.Empty:(System.String)row["DoanDang"];
					c.NgayVaoDoanDang = (Convert.IsDBNull(row["NgayVaoDoanDang"]))?string.Empty:(System.String)row["NgayVaoDoanDang"];
					c.ThuongTru = (Convert.IsDBNull(row["ThuongTru"]))?string.Empty:(System.String)row["ThuongTru"];
					c.DiaChi = (Convert.IsDBNull(row["DiaChi"]))?string.Empty:(System.String)row["DiaChi"];
					c.SoDiDong = (Convert.IsDBNull(row["SoDiDong"]))?string.Empty:(System.String)row["SoDiDong"];
					c.DienThoai = (Convert.IsDBNull(row["DienThoai"]))?string.Empty:(System.String)row["DienThoai"];
					c.SoSoBaoHiem = (Convert.IsDBNull(row["SoSoBaoHiem"]))?string.Empty:(System.String)row["SoSoBaoHiem"];
					c.Email = (Convert.IsDBNull(row["Email"]))?string.Empty:(System.String)row["Email"];
					c.SoTaiKhoan = (Convert.IsDBNull(row["SoTaiKhoan"]))?string.Empty:(System.String)row["SoTaiKhoan"];
					c.MaSoThue = (Convert.IsDBNull(row["MaSoThue"]))?string.Empty:(System.String)row["MaSoThue"];
					c.TenNganHang = (Convert.IsDBNull(row["TenNganHang"]))?string.Empty:(System.String)row["TenNganHang"];
					c.TenHocHam = (Convert.IsDBNull(row["TenHocHam"]))?string.Empty:(System.String)row["TenHocHam"];
					c.TenHocVi = (Convert.IsDBNull(row["TenHocVi"]))?string.Empty:(System.String)row["TenHocVi"];
					c.TenLoaiGiangVien = (Convert.IsDBNull(row["TenLoaiGiangVien"]))?string.Empty:(System.String)row["TenLoaiGiangVien"];
					c.NgayKyHopDong = (Convert.IsDBNull(row["NgayKyHopDong"]))?DateTime.MinValue:(System.DateTime?)row["NgayKyHopDong"];
					c.NgayKetThucHopDong = (Convert.IsDBNull(row["NgayKetThucHopDong"]))?DateTime.MinValue:(System.DateTime?)row["NgayKetThucHopDong"];
					c.TenKhoa = (Convert.IsDBNull(row["TenKhoa"]))?string.Empty:(System.String)row["TenKhoa"];
					c.ChuyenNganh = (Convert.IsDBNull(row["ChuyenNganh"]))?string.Empty:(System.String)row["ChuyenNganh"];
					c.MaHeSoThuLao = (Convert.IsDBNull(row["MaHeSoThuLao"]))?string.Empty:(System.String)row["MaHeSoThuLao"];
					c.NoiLamViec = (Convert.IsDBNull(row["NoiLamViec"]))?string.Empty:(System.String)row["NoiLamViec"];
					c.NamLamViec = (Convert.IsDBNull(row["NamLamViec"]))?string.Empty:(System.String)row["NamLamViec"];
					c.BacLuong = (Convert.IsDBNull(row["BacLuong"]))?0.0m:(System.Decimal?)row["BacLuong"];
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
		/// Fill an <see cref="VList&lt;ViewChiTietGiangVien&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewChiTietGiangVien&gt;"/></returns>
		protected VList<ViewChiTietGiangVien> Fill(IDataReader reader, VList<ViewChiTietGiangVien> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewChiTietGiangVien entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewChiTietGiangVien>("ViewChiTietGiangVien",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewChiTietGiangVien();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = (System.String)reader[((int)ViewChiTietGiangVienColumn.MaGiangVien)];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?string.Empty:(System.String)reader["MaGiangVien"];
					entity.MatKhau = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.MatKhau)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.MatKhau)];
					//entity.MatKhau = (Convert.IsDBNull(reader["MatKhau"]))?string.Empty:(System.String)reader["MatKhau"];
					entity.TenTinhTrang = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.TenTinhTrang)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.TenTinhTrang)];
					//entity.TenTinhTrang = (Convert.IsDBNull(reader["TenTinhTrang"]))?string.Empty:(System.String)reader["TenTinhTrang"];
					entity.HoTen = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.HoTen)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.HoTen)];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.GioiTinh = (System.String)reader[((int)ViewChiTietGiangVienColumn.GioiTinh)];
					//entity.GioiTinh = (Convert.IsDBNull(reader["GioiTinh"]))?string.Empty:(System.String)reader["GioiTinh"];
					entity.NgaySinh = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.NgaySinh)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.NgaySinh)];
					//entity.NgaySinh = (Convert.IsDBNull(reader["NgaySinh"]))?string.Empty:(System.String)reader["NgaySinh"];
					entity.NoiSinh = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.NoiSinh)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.NoiSinh)];
					//entity.NoiSinh = (Convert.IsDBNull(reader["NoiSinh"]))?string.Empty:(System.String)reader["NoiSinh"];
					entity.Cmnd = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.Cmnd)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.Cmnd)];
					//entity.Cmnd = (Convert.IsDBNull(reader["Cmnd"]))?string.Empty:(System.String)reader["Cmnd"];
					entity.NgayCap = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.NgayCap)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.NgayCap)];
					//entity.NgayCap = (Convert.IsDBNull(reader["NgayCap"]))?string.Empty:(System.String)reader["NgayCap"];
					entity.NoiCap = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.NoiCap)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.NoiCap)];
					//entity.NoiCap = (Convert.IsDBNull(reader["NoiCap"]))?string.Empty:(System.String)reader["NoiCap"];
					entity.TenDanToc = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.TenDanToc)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.TenDanToc)];
					//entity.TenDanToc = (Convert.IsDBNull(reader["TenDanToc"]))?string.Empty:(System.String)reader["TenDanToc"];
					entity.TenTonGiao = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.TenTonGiao)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.TenTonGiao)];
					//entity.TenTonGiao = (Convert.IsDBNull(reader["TenTonGiao"]))?string.Empty:(System.String)reader["TenTonGiao"];
					entity.DoanDang = (System.String)reader[((int)ViewChiTietGiangVienColumn.DoanDang)];
					//entity.DoanDang = (Convert.IsDBNull(reader["DoanDang"]))?string.Empty:(System.String)reader["DoanDang"];
					entity.NgayVaoDoanDang = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.NgayVaoDoanDang)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.NgayVaoDoanDang)];
					//entity.NgayVaoDoanDang = (Convert.IsDBNull(reader["NgayVaoDoanDang"]))?string.Empty:(System.String)reader["NgayVaoDoanDang"];
					entity.ThuongTru = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.ThuongTru)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.ThuongTru)];
					//entity.ThuongTru = (Convert.IsDBNull(reader["ThuongTru"]))?string.Empty:(System.String)reader["ThuongTru"];
					entity.DiaChi = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.DiaChi)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.DiaChi)];
					//entity.DiaChi = (Convert.IsDBNull(reader["DiaChi"]))?string.Empty:(System.String)reader["DiaChi"];
					entity.SoDiDong = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.SoDiDong)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.SoDiDong)];
					//entity.SoDiDong = (Convert.IsDBNull(reader["SoDiDong"]))?string.Empty:(System.String)reader["SoDiDong"];
					entity.DienThoai = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.DienThoai)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.DienThoai)];
					//entity.DienThoai = (Convert.IsDBNull(reader["DienThoai"]))?string.Empty:(System.String)reader["DienThoai"];
					entity.SoSoBaoHiem = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.SoSoBaoHiem)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.SoSoBaoHiem)];
					//entity.SoSoBaoHiem = (Convert.IsDBNull(reader["SoSoBaoHiem"]))?string.Empty:(System.String)reader["SoSoBaoHiem"];
					entity.Email = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.Email)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.Email)];
					//entity.Email = (Convert.IsDBNull(reader["Email"]))?string.Empty:(System.String)reader["Email"];
					entity.SoTaiKhoan = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.SoTaiKhoan)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.SoTaiKhoan)];
					//entity.SoTaiKhoan = (Convert.IsDBNull(reader["SoTaiKhoan"]))?string.Empty:(System.String)reader["SoTaiKhoan"];
					entity.MaSoThue = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.MaSoThue)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.MaSoThue)];
					//entity.MaSoThue = (Convert.IsDBNull(reader["MaSoThue"]))?string.Empty:(System.String)reader["MaSoThue"];
					entity.TenNganHang = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.TenNganHang)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.TenNganHang)];
					//entity.TenNganHang = (Convert.IsDBNull(reader["TenNganHang"]))?string.Empty:(System.String)reader["TenNganHang"];
					entity.TenHocHam = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.TenHocHam)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.TenHocHam)];
					//entity.TenHocHam = (Convert.IsDBNull(reader["TenHocHam"]))?string.Empty:(System.String)reader["TenHocHam"];
					entity.TenHocVi = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.TenHocVi)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.TenHocVi)];
					//entity.TenHocVi = (Convert.IsDBNull(reader["TenHocVi"]))?string.Empty:(System.String)reader["TenHocVi"];
					entity.TenLoaiGiangVien = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.TenLoaiGiangVien)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.TenLoaiGiangVien)];
					//entity.TenLoaiGiangVien = (Convert.IsDBNull(reader["TenLoaiGiangVien"]))?string.Empty:(System.String)reader["TenLoaiGiangVien"];
					entity.NgayKyHopDong = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.NgayKyHopDong)))?null:(System.DateTime?)reader[((int)ViewChiTietGiangVienColumn.NgayKyHopDong)];
					//entity.NgayKyHopDong = (Convert.IsDBNull(reader["NgayKyHopDong"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKyHopDong"];
					entity.NgayKetThucHopDong = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.NgayKetThucHopDong)))?null:(System.DateTime?)reader[((int)ViewChiTietGiangVienColumn.NgayKetThucHopDong)];
					//entity.NgayKetThucHopDong = (Convert.IsDBNull(reader["NgayKetThucHopDong"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKetThucHopDong"];
					entity.TenKhoa = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.TenKhoa)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.TenKhoa)];
					//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
					entity.ChuyenNganh = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.ChuyenNganh)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.ChuyenNganh)];
					//entity.ChuyenNganh = (Convert.IsDBNull(reader["ChuyenNganh"]))?string.Empty:(System.String)reader["ChuyenNganh"];
					entity.MaHeSoThuLao = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.MaHeSoThuLao)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.MaHeSoThuLao)];
					//entity.MaHeSoThuLao = (Convert.IsDBNull(reader["MaHeSoThuLao"]))?string.Empty:(System.String)reader["MaHeSoThuLao"];
					entity.NoiLamViec = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.NoiLamViec)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.NoiLamViec)];
					//entity.NoiLamViec = (Convert.IsDBNull(reader["NoiLamViec"]))?string.Empty:(System.String)reader["NoiLamViec"];
					entity.NamLamViec = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.NamLamViec)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.NamLamViec)];
					//entity.NamLamViec = (Convert.IsDBNull(reader["NamLamViec"]))?string.Empty:(System.String)reader["NamLamViec"];
					entity.BacLuong = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.BacLuong)))?null:(System.Decimal?)reader[((int)ViewChiTietGiangVienColumn.BacLuong)];
					//entity.BacLuong = (Convert.IsDBNull(reader["BacLuong"]))?0.0m:(System.Decimal?)reader["BacLuong"];
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
		/// Refreshes the <see cref="ViewChiTietGiangVien"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewChiTietGiangVien"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewChiTietGiangVien entity)
		{
			reader.Read();
			entity.MaGiangVien = (System.String)reader[((int)ViewChiTietGiangVienColumn.MaGiangVien)];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?string.Empty:(System.String)reader["MaGiangVien"];
			entity.MatKhau = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.MatKhau)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.MatKhau)];
			//entity.MatKhau = (Convert.IsDBNull(reader["MatKhau"]))?string.Empty:(System.String)reader["MatKhau"];
			entity.TenTinhTrang = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.TenTinhTrang)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.TenTinhTrang)];
			//entity.TenTinhTrang = (Convert.IsDBNull(reader["TenTinhTrang"]))?string.Empty:(System.String)reader["TenTinhTrang"];
			entity.HoTen = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.HoTen)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.HoTen)];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.GioiTinh = (System.String)reader[((int)ViewChiTietGiangVienColumn.GioiTinh)];
			//entity.GioiTinh = (Convert.IsDBNull(reader["GioiTinh"]))?string.Empty:(System.String)reader["GioiTinh"];
			entity.NgaySinh = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.NgaySinh)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.NgaySinh)];
			//entity.NgaySinh = (Convert.IsDBNull(reader["NgaySinh"]))?string.Empty:(System.String)reader["NgaySinh"];
			entity.NoiSinh = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.NoiSinh)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.NoiSinh)];
			//entity.NoiSinh = (Convert.IsDBNull(reader["NoiSinh"]))?string.Empty:(System.String)reader["NoiSinh"];
			entity.Cmnd = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.Cmnd)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.Cmnd)];
			//entity.Cmnd = (Convert.IsDBNull(reader["Cmnd"]))?string.Empty:(System.String)reader["Cmnd"];
			entity.NgayCap = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.NgayCap)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.NgayCap)];
			//entity.NgayCap = (Convert.IsDBNull(reader["NgayCap"]))?string.Empty:(System.String)reader["NgayCap"];
			entity.NoiCap = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.NoiCap)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.NoiCap)];
			//entity.NoiCap = (Convert.IsDBNull(reader["NoiCap"]))?string.Empty:(System.String)reader["NoiCap"];
			entity.TenDanToc = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.TenDanToc)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.TenDanToc)];
			//entity.TenDanToc = (Convert.IsDBNull(reader["TenDanToc"]))?string.Empty:(System.String)reader["TenDanToc"];
			entity.TenTonGiao = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.TenTonGiao)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.TenTonGiao)];
			//entity.TenTonGiao = (Convert.IsDBNull(reader["TenTonGiao"]))?string.Empty:(System.String)reader["TenTonGiao"];
			entity.DoanDang = (System.String)reader[((int)ViewChiTietGiangVienColumn.DoanDang)];
			//entity.DoanDang = (Convert.IsDBNull(reader["DoanDang"]))?string.Empty:(System.String)reader["DoanDang"];
			entity.NgayVaoDoanDang = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.NgayVaoDoanDang)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.NgayVaoDoanDang)];
			//entity.NgayVaoDoanDang = (Convert.IsDBNull(reader["NgayVaoDoanDang"]))?string.Empty:(System.String)reader["NgayVaoDoanDang"];
			entity.ThuongTru = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.ThuongTru)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.ThuongTru)];
			//entity.ThuongTru = (Convert.IsDBNull(reader["ThuongTru"]))?string.Empty:(System.String)reader["ThuongTru"];
			entity.DiaChi = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.DiaChi)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.DiaChi)];
			//entity.DiaChi = (Convert.IsDBNull(reader["DiaChi"]))?string.Empty:(System.String)reader["DiaChi"];
			entity.SoDiDong = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.SoDiDong)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.SoDiDong)];
			//entity.SoDiDong = (Convert.IsDBNull(reader["SoDiDong"]))?string.Empty:(System.String)reader["SoDiDong"];
			entity.DienThoai = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.DienThoai)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.DienThoai)];
			//entity.DienThoai = (Convert.IsDBNull(reader["DienThoai"]))?string.Empty:(System.String)reader["DienThoai"];
			entity.SoSoBaoHiem = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.SoSoBaoHiem)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.SoSoBaoHiem)];
			//entity.SoSoBaoHiem = (Convert.IsDBNull(reader["SoSoBaoHiem"]))?string.Empty:(System.String)reader["SoSoBaoHiem"];
			entity.Email = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.Email)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.Email)];
			//entity.Email = (Convert.IsDBNull(reader["Email"]))?string.Empty:(System.String)reader["Email"];
			entity.SoTaiKhoan = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.SoTaiKhoan)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.SoTaiKhoan)];
			//entity.SoTaiKhoan = (Convert.IsDBNull(reader["SoTaiKhoan"]))?string.Empty:(System.String)reader["SoTaiKhoan"];
			entity.MaSoThue = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.MaSoThue)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.MaSoThue)];
			//entity.MaSoThue = (Convert.IsDBNull(reader["MaSoThue"]))?string.Empty:(System.String)reader["MaSoThue"];
			entity.TenNganHang = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.TenNganHang)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.TenNganHang)];
			//entity.TenNganHang = (Convert.IsDBNull(reader["TenNganHang"]))?string.Empty:(System.String)reader["TenNganHang"];
			entity.TenHocHam = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.TenHocHam)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.TenHocHam)];
			//entity.TenHocHam = (Convert.IsDBNull(reader["TenHocHam"]))?string.Empty:(System.String)reader["TenHocHam"];
			entity.TenHocVi = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.TenHocVi)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.TenHocVi)];
			//entity.TenHocVi = (Convert.IsDBNull(reader["TenHocVi"]))?string.Empty:(System.String)reader["TenHocVi"];
			entity.TenLoaiGiangVien = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.TenLoaiGiangVien)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.TenLoaiGiangVien)];
			//entity.TenLoaiGiangVien = (Convert.IsDBNull(reader["TenLoaiGiangVien"]))?string.Empty:(System.String)reader["TenLoaiGiangVien"];
			entity.NgayKyHopDong = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.NgayKyHopDong)))?null:(System.DateTime?)reader[((int)ViewChiTietGiangVienColumn.NgayKyHopDong)];
			//entity.NgayKyHopDong = (Convert.IsDBNull(reader["NgayKyHopDong"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKyHopDong"];
			entity.NgayKetThucHopDong = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.NgayKetThucHopDong)))?null:(System.DateTime?)reader[((int)ViewChiTietGiangVienColumn.NgayKetThucHopDong)];
			//entity.NgayKetThucHopDong = (Convert.IsDBNull(reader["NgayKetThucHopDong"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKetThucHopDong"];
			entity.TenKhoa = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.TenKhoa)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.TenKhoa)];
			//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
			entity.ChuyenNganh = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.ChuyenNganh)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.ChuyenNganh)];
			//entity.ChuyenNganh = (Convert.IsDBNull(reader["ChuyenNganh"]))?string.Empty:(System.String)reader["ChuyenNganh"];
			entity.MaHeSoThuLao = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.MaHeSoThuLao)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.MaHeSoThuLao)];
			//entity.MaHeSoThuLao = (Convert.IsDBNull(reader["MaHeSoThuLao"]))?string.Empty:(System.String)reader["MaHeSoThuLao"];
			entity.NoiLamViec = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.NoiLamViec)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.NoiLamViec)];
			//entity.NoiLamViec = (Convert.IsDBNull(reader["NoiLamViec"]))?string.Empty:(System.String)reader["NoiLamViec"];
			entity.NamLamViec = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.NamLamViec)))?null:(System.String)reader[((int)ViewChiTietGiangVienColumn.NamLamViec)];
			//entity.NamLamViec = (Convert.IsDBNull(reader["NamLamViec"]))?string.Empty:(System.String)reader["NamLamViec"];
			entity.BacLuong = (reader.IsDBNull(((int)ViewChiTietGiangVienColumn.BacLuong)))?null:(System.Decimal?)reader[((int)ViewChiTietGiangVienColumn.BacLuong)];
			//entity.BacLuong = (Convert.IsDBNull(reader["BacLuong"]))?0.0m:(System.Decimal?)reader["BacLuong"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewChiTietGiangVien"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewChiTietGiangVien"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewChiTietGiangVien entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?string.Empty:(System.String)dataRow["MaGiangVien"];
			entity.MatKhau = (Convert.IsDBNull(dataRow["MatKhau"]))?string.Empty:(System.String)dataRow["MatKhau"];
			entity.TenTinhTrang = (Convert.IsDBNull(dataRow["TenTinhTrang"]))?string.Empty:(System.String)dataRow["TenTinhTrang"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.GioiTinh = (Convert.IsDBNull(dataRow["GioiTinh"]))?string.Empty:(System.String)dataRow["GioiTinh"];
			entity.NgaySinh = (Convert.IsDBNull(dataRow["NgaySinh"]))?string.Empty:(System.String)dataRow["NgaySinh"];
			entity.NoiSinh = (Convert.IsDBNull(dataRow["NoiSinh"]))?string.Empty:(System.String)dataRow["NoiSinh"];
			entity.Cmnd = (Convert.IsDBNull(dataRow["Cmnd"]))?string.Empty:(System.String)dataRow["Cmnd"];
			entity.NgayCap = (Convert.IsDBNull(dataRow["NgayCap"]))?string.Empty:(System.String)dataRow["NgayCap"];
			entity.NoiCap = (Convert.IsDBNull(dataRow["NoiCap"]))?string.Empty:(System.String)dataRow["NoiCap"];
			entity.TenDanToc = (Convert.IsDBNull(dataRow["TenDanToc"]))?string.Empty:(System.String)dataRow["TenDanToc"];
			entity.TenTonGiao = (Convert.IsDBNull(dataRow["TenTonGiao"]))?string.Empty:(System.String)dataRow["TenTonGiao"];
			entity.DoanDang = (Convert.IsDBNull(dataRow["DoanDang"]))?string.Empty:(System.String)dataRow["DoanDang"];
			entity.NgayVaoDoanDang = (Convert.IsDBNull(dataRow["NgayVaoDoanDang"]))?string.Empty:(System.String)dataRow["NgayVaoDoanDang"];
			entity.ThuongTru = (Convert.IsDBNull(dataRow["ThuongTru"]))?string.Empty:(System.String)dataRow["ThuongTru"];
			entity.DiaChi = (Convert.IsDBNull(dataRow["DiaChi"]))?string.Empty:(System.String)dataRow["DiaChi"];
			entity.SoDiDong = (Convert.IsDBNull(dataRow["SoDiDong"]))?string.Empty:(System.String)dataRow["SoDiDong"];
			entity.DienThoai = (Convert.IsDBNull(dataRow["DienThoai"]))?string.Empty:(System.String)dataRow["DienThoai"];
			entity.SoSoBaoHiem = (Convert.IsDBNull(dataRow["SoSoBaoHiem"]))?string.Empty:(System.String)dataRow["SoSoBaoHiem"];
			entity.Email = (Convert.IsDBNull(dataRow["Email"]))?string.Empty:(System.String)dataRow["Email"];
			entity.SoTaiKhoan = (Convert.IsDBNull(dataRow["SoTaiKhoan"]))?string.Empty:(System.String)dataRow["SoTaiKhoan"];
			entity.MaSoThue = (Convert.IsDBNull(dataRow["MaSoThue"]))?string.Empty:(System.String)dataRow["MaSoThue"];
			entity.TenNganHang = (Convert.IsDBNull(dataRow["TenNganHang"]))?string.Empty:(System.String)dataRow["TenNganHang"];
			entity.TenHocHam = (Convert.IsDBNull(dataRow["TenHocHam"]))?string.Empty:(System.String)dataRow["TenHocHam"];
			entity.TenHocVi = (Convert.IsDBNull(dataRow["TenHocVi"]))?string.Empty:(System.String)dataRow["TenHocVi"];
			entity.TenLoaiGiangVien = (Convert.IsDBNull(dataRow["TenLoaiGiangVien"]))?string.Empty:(System.String)dataRow["TenLoaiGiangVien"];
			entity.NgayKyHopDong = (Convert.IsDBNull(dataRow["NgayKyHopDong"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayKyHopDong"];
			entity.NgayKetThucHopDong = (Convert.IsDBNull(dataRow["NgayKetThucHopDong"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayKetThucHopDong"];
			entity.TenKhoa = (Convert.IsDBNull(dataRow["TenKhoa"]))?string.Empty:(System.String)dataRow["TenKhoa"];
			entity.ChuyenNganh = (Convert.IsDBNull(dataRow["ChuyenNganh"]))?string.Empty:(System.String)dataRow["ChuyenNganh"];
			entity.MaHeSoThuLao = (Convert.IsDBNull(dataRow["MaHeSoThuLao"]))?string.Empty:(System.String)dataRow["MaHeSoThuLao"];
			entity.NoiLamViec = (Convert.IsDBNull(dataRow["NoiLamViec"]))?string.Empty:(System.String)dataRow["NoiLamViec"];
			entity.NamLamViec = (Convert.IsDBNull(dataRow["NamLamViec"]))?string.Empty:(System.String)dataRow["NamLamViec"];
			entity.BacLuong = (Convert.IsDBNull(dataRow["BacLuong"]))?0.0m:(System.Decimal?)dataRow["BacLuong"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewChiTietGiangVienFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTietGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewChiTietGiangVienFilterBuilder : SqlFilterBuilder<ViewChiTietGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTietGiangVienFilterBuilder class.
		/// </summary>
		public ViewChiTietGiangVienFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTietGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewChiTietGiangVienFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTietGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewChiTietGiangVienFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewChiTietGiangVienFilterBuilder

	#region ViewChiTietGiangVienParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTietGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewChiTietGiangVienParameterBuilder : ParameterizedSqlFilterBuilder<ViewChiTietGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTietGiangVienParameterBuilder class.
		/// </summary>
		public ViewChiTietGiangVienParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTietGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewChiTietGiangVienParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTietGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewChiTietGiangVienParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewChiTietGiangVienParameterBuilder
	
	#region ViewChiTietGiangVienSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTietGiangVien"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewChiTietGiangVienSortBuilder : SqlSortBuilder<ViewChiTietGiangVienColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTietGiangVienSqlSortBuilder class.
		/// </summary>
		public ViewChiTietGiangVienSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewChiTietGiangVienSortBuilder

} // end namespace
