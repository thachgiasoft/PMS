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
	/// This class is the base class for any <see cref="ViewKetQuaCacKhoanChiKhacProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewKetQuaCacKhoanChiKhacProviderBaseCore : EntityViewProviderBase<ViewKetQuaCacKhoanChiKhac>
	{
		#region Custom Methods
		
		
		#region cust_View_KetQuaCacKhoanChiKhac_GetByNgay
		
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaCacKhoanChiKhac_GetByNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKetQuaCacKhoanChiKhac&gt;"/> instance.</returns>
		public VList<ViewKetQuaCacKhoanChiKhac> GetByNgay(System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByNgay(null, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaCacKhoanChiKhac_GetByNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKetQuaCacKhoanChiKhac&gt;"/> instance.</returns>
		public VList<ViewKetQuaCacKhoanChiKhac> GetByNgay(int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByNgay(null, start, pageLength , tuNgay, denNgay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaCacKhoanChiKhac_GetByNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewKetQuaCacKhoanChiKhac&gt;"/> instance.</returns>
		public VList<ViewKetQuaCacKhoanChiKhac> GetByNgay(TransactionManager transactionManager, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByNgay(transactionManager, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaCacKhoanChiKhac_GetByNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKetQuaCacKhoanChiKhac&gt;"/> instance.</returns>
		public abstract VList<ViewKetQuaCacKhoanChiKhac> GetByNgay(TransactionManager transactionManager, int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewKetQuaCacKhoanChiKhac&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewKetQuaCacKhoanChiKhac&gt;"/></returns>
		protected static VList&lt;ViewKetQuaCacKhoanChiKhac&gt; Fill(DataSet dataSet, VList<ViewKetQuaCacKhoanChiKhac> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewKetQuaCacKhoanChiKhac>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewKetQuaCacKhoanChiKhac&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewKetQuaCacKhoanChiKhac>"/></returns>
		protected static VList&lt;ViewKetQuaCacKhoanChiKhac&gt; Fill(DataTable dataTable, VList<ViewKetQuaCacKhoanChiKhac> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewKetQuaCacKhoanChiKhac c = new ViewKetQuaCacKhoanChiKhac();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32)row["MaGiangVien"];
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.Ho = (Convert.IsDBNull(row["ho"]))?string.Empty:(System.String)row["ho"];
					c.Ten = (Convert.IsDBNull(row["Ten"]))?string.Empty:(System.String)row["Ten"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.GioiTinh = (Convert.IsDBNull(row["GioiTinh"]))?string.Empty:(System.String)row["GioiTinh"];
					c.NgaySinh = (Convert.IsDBNull(row["NgaySinh"]))?string.Empty:(System.String)row["NgaySinh"];
					c.MaHocHam = (Convert.IsDBNull(row["MaHocHam"]))?(int)0:(System.Int32?)row["MaHocHam"];
					c.MaHocVi = (Convert.IsDBNull(row["MaHocVi"]))?(int)0:(System.Int32?)row["MaHocVi"];
					c.MaLoaiGiangVien = (Convert.IsDBNull(row["MaLoaiGiangVien"]))?(int)0:(System.Int32?)row["MaLoaiGiangVien"];
					c.TenHocHam = (Convert.IsDBNull(row["TenHocHam"]))?string.Empty:(System.String)row["TenHocHam"];
					c.TenHocVi = (Convert.IsDBNull(row["TenHocVi"]))?string.Empty:(System.String)row["TenHocVi"];
					c.TenLoaiGiangVien = (Convert.IsDBNull(row["TenLoaiGiangVien"]))?string.Empty:(System.String)row["TenLoaiGiangVien"];
					c.MaDonVi = (Convert.IsDBNull(row["MaDonVi"]))?string.Empty:(System.String)row["MaDonVi"];
					c.TenDonVi = (Convert.IsDBNull(row["TenDonVi"]))?string.Empty:(System.String)row["TenDonVi"];
					c.Lop = (Convert.IsDBNull(row["Lop"]))?string.Empty:(System.String)row["Lop"];
					c.MaSo = (Convert.IsDBNull(row["MaSo"]))?string.Empty:(System.String)row["MaSo"];
					c.Ngay = (Convert.IsDBNull(row["Ngay"]))?DateTime.MinValue:(System.DateTime?)row["Ngay"];
					c.NoiDung = (Convert.IsDBNull(row["NoiDung"]))?string.Empty:(System.String)row["NoiDung"];
					c.HeSo = (Convert.IsDBNull(row["HeSo"]))?0.0m:(System.Decimal?)row["HeSo"];
					c.SoTiet = (Convert.IsDBNull(row["SoTiet"]))?0.0m:(System.Decimal?)row["SoTiet"];
					c.TienMotTiet = (Convert.IsDBNull(row["TienMotTiet"]))?0.0m:(System.Decimal?)row["TienMotTiet"];
					c.ThanhTien = (Convert.IsDBNull(row["ThanhTien"]))?0.0m:(System.Decimal?)row["ThanhTien"];
					c.PhiCongTac = (Convert.IsDBNull(row["PhiCongTac"]))?0.0m:(System.Decimal?)row["PhiCongTac"];
					c.TienGiangNgoaiGio = (Convert.IsDBNull(row["TienGiangNgoaiGio"]))?0.0m:(System.Decimal?)row["TienGiangNgoaiGio"];
					c.TongThanhTien = (Convert.IsDBNull(row["TongThanhTien"]))?0.0m:(System.Decimal?)row["TongThanhTien"];
					c.Id = (Convert.IsDBNull(row["Id"]))?(int)0:(System.Int32)row["Id"];
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
		/// Fill an <see cref="VList&lt;ViewKetQuaCacKhoanChiKhac&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewKetQuaCacKhoanChiKhac&gt;"/></returns>
		protected VList<ViewKetQuaCacKhoanChiKhac> Fill(IDataReader reader, VList<ViewKetQuaCacKhoanChiKhac> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewKetQuaCacKhoanChiKhac entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewKetQuaCacKhoanChiKhac>("ViewKetQuaCacKhoanChiKhac",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewKetQuaCacKhoanChiKhac();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = (System.Int32)reader["MaGiangVien"];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
					entity.MaQuanLy = (System.String)reader["MaQuanLy"];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.Ho = reader.IsDBNull(reader.GetOrdinal("Ho")) ? null : (System.String)reader["Ho"];
					//entity.Ho = (Convert.IsDBNull(reader["ho"]))?string.Empty:(System.String)reader["ho"];
					entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
					//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
					entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.GioiTinh = (System.String)reader["GioiTinh"];
					//entity.GioiTinh = (Convert.IsDBNull(reader["GioiTinh"]))?string.Empty:(System.String)reader["GioiTinh"];
					entity.NgaySinh = reader.IsDBNull(reader.GetOrdinal("NgaySinh")) ? null : (System.String)reader["NgaySinh"];
					//entity.NgaySinh = (Convert.IsDBNull(reader["NgaySinh"]))?string.Empty:(System.String)reader["NgaySinh"];
					entity.MaHocHam = reader.IsDBNull(reader.GetOrdinal("MaHocHam")) ? null : (System.Int32?)reader["MaHocHam"];
					//entity.MaHocHam = (Convert.IsDBNull(reader["MaHocHam"]))?(int)0:(System.Int32?)reader["MaHocHam"];
					entity.MaHocVi = reader.IsDBNull(reader.GetOrdinal("MaHocVi")) ? null : (System.Int32?)reader["MaHocVi"];
					//entity.MaHocVi = (Convert.IsDBNull(reader["MaHocVi"]))?(int)0:(System.Int32?)reader["MaHocVi"];
					entity.MaLoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("MaLoaiGiangVien")) ? null : (System.Int32?)reader["MaLoaiGiangVien"];
					//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32?)reader["MaLoaiGiangVien"];
					entity.TenHocHam = reader.IsDBNull(reader.GetOrdinal("TenHocHam")) ? null : (System.String)reader["TenHocHam"];
					//entity.TenHocHam = (Convert.IsDBNull(reader["TenHocHam"]))?string.Empty:(System.String)reader["TenHocHam"];
					entity.TenHocVi = reader.IsDBNull(reader.GetOrdinal("TenHocVi")) ? null : (System.String)reader["TenHocVi"];
					//entity.TenHocVi = (Convert.IsDBNull(reader["TenHocVi"]))?string.Empty:(System.String)reader["TenHocVi"];
					entity.TenLoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("TenLoaiGiangVien")) ? null : (System.String)reader["TenLoaiGiangVien"];
					//entity.TenLoaiGiangVien = (Convert.IsDBNull(reader["TenLoaiGiangVien"]))?string.Empty:(System.String)reader["TenLoaiGiangVien"];
					entity.MaDonVi = reader.IsDBNull(reader.GetOrdinal("MaDonVi")) ? null : (System.String)reader["MaDonVi"];
					//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
					entity.TenDonVi = (System.String)reader["TenDonVi"];
					//entity.TenDonVi = (Convert.IsDBNull(reader["TenDonVi"]))?string.Empty:(System.String)reader["TenDonVi"];
					entity.Lop = reader.IsDBNull(reader.GetOrdinal("Lop")) ? null : (System.String)reader["Lop"];
					//entity.Lop = (Convert.IsDBNull(reader["Lop"]))?string.Empty:(System.String)reader["Lop"];
					entity.MaSo = reader.IsDBNull(reader.GetOrdinal("MaSo")) ? null : (System.String)reader["MaSo"];
					//entity.MaSo = (Convert.IsDBNull(reader["MaSo"]))?string.Empty:(System.String)reader["MaSo"];
					entity.Ngay = reader.IsDBNull(reader.GetOrdinal("Ngay")) ? null : (System.DateTime?)reader["Ngay"];
					//entity.Ngay = (Convert.IsDBNull(reader["Ngay"]))?DateTime.MinValue:(System.DateTime?)reader["Ngay"];
					entity.NoiDung = reader.IsDBNull(reader.GetOrdinal("NoiDung")) ? null : (System.String)reader["NoiDung"];
					//entity.NoiDung = (Convert.IsDBNull(reader["NoiDung"]))?string.Empty:(System.String)reader["NoiDung"];
					entity.HeSo = reader.IsDBNull(reader.GetOrdinal("HeSo")) ? null : (System.Decimal?)reader["HeSo"];
					//entity.HeSo = (Convert.IsDBNull(reader["HeSo"]))?0.0m:(System.Decimal?)reader["HeSo"];
					entity.SoTiet = reader.IsDBNull(reader.GetOrdinal("SoTiet")) ? null : (System.Decimal?)reader["SoTiet"];
					//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?0.0m:(System.Decimal?)reader["SoTiet"];
					entity.TienMotTiet = reader.IsDBNull(reader.GetOrdinal("TienMotTiet")) ? null : (System.Decimal?)reader["TienMotTiet"];
					//entity.TienMotTiet = (Convert.IsDBNull(reader["TienMotTiet"]))?0.0m:(System.Decimal?)reader["TienMotTiet"];
					entity.ThanhTien = reader.IsDBNull(reader.GetOrdinal("ThanhTien")) ? null : (System.Decimal?)reader["ThanhTien"];
					//entity.ThanhTien = (Convert.IsDBNull(reader["ThanhTien"]))?0.0m:(System.Decimal?)reader["ThanhTien"];
					entity.PhiCongTac = reader.IsDBNull(reader.GetOrdinal("PhiCongTac")) ? null : (System.Decimal?)reader["PhiCongTac"];
					//entity.PhiCongTac = (Convert.IsDBNull(reader["PhiCongTac"]))?0.0m:(System.Decimal?)reader["PhiCongTac"];
					entity.TienGiangNgoaiGio = reader.IsDBNull(reader.GetOrdinal("TienGiangNgoaiGio")) ? null : (System.Decimal?)reader["TienGiangNgoaiGio"];
					//entity.TienGiangNgoaiGio = (Convert.IsDBNull(reader["TienGiangNgoaiGio"]))?0.0m:(System.Decimal?)reader["TienGiangNgoaiGio"];
					entity.TongThanhTien = reader.IsDBNull(reader.GetOrdinal("TongThanhTien")) ? null : (System.Decimal?)reader["TongThanhTien"];
					//entity.TongThanhTien = (Convert.IsDBNull(reader["TongThanhTien"]))?0.0m:(System.Decimal?)reader["TongThanhTien"];
					entity.Id = (System.Int32)reader["Id"];
					//entity.Id = (Convert.IsDBNull(reader["Id"]))?(int)0:(System.Int32)reader["Id"];
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
		/// Refreshes the <see cref="ViewKetQuaCacKhoanChiKhac"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewKetQuaCacKhoanChiKhac"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewKetQuaCacKhoanChiKhac entity)
		{
			reader.Read();
			entity.MaGiangVien = (System.Int32)reader["MaGiangVien"];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
			entity.MaQuanLy = (System.String)reader["MaQuanLy"];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.Ho = reader.IsDBNull(reader.GetOrdinal("Ho")) ? null : (System.String)reader["Ho"];
			//entity.Ho = (Convert.IsDBNull(reader["ho"]))?string.Empty:(System.String)reader["ho"];
			entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
			//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
			entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.GioiTinh = (System.String)reader["GioiTinh"];
			//entity.GioiTinh = (Convert.IsDBNull(reader["GioiTinh"]))?string.Empty:(System.String)reader["GioiTinh"];
			entity.NgaySinh = reader.IsDBNull(reader.GetOrdinal("NgaySinh")) ? null : (System.String)reader["NgaySinh"];
			//entity.NgaySinh = (Convert.IsDBNull(reader["NgaySinh"]))?string.Empty:(System.String)reader["NgaySinh"];
			entity.MaHocHam = reader.IsDBNull(reader.GetOrdinal("MaHocHam")) ? null : (System.Int32?)reader["MaHocHam"];
			//entity.MaHocHam = (Convert.IsDBNull(reader["MaHocHam"]))?(int)0:(System.Int32?)reader["MaHocHam"];
			entity.MaHocVi = reader.IsDBNull(reader.GetOrdinal("MaHocVi")) ? null : (System.Int32?)reader["MaHocVi"];
			//entity.MaHocVi = (Convert.IsDBNull(reader["MaHocVi"]))?(int)0:(System.Int32?)reader["MaHocVi"];
			entity.MaLoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("MaLoaiGiangVien")) ? null : (System.Int32?)reader["MaLoaiGiangVien"];
			//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32?)reader["MaLoaiGiangVien"];
			entity.TenHocHam = reader.IsDBNull(reader.GetOrdinal("TenHocHam")) ? null : (System.String)reader["TenHocHam"];
			//entity.TenHocHam = (Convert.IsDBNull(reader["TenHocHam"]))?string.Empty:(System.String)reader["TenHocHam"];
			entity.TenHocVi = reader.IsDBNull(reader.GetOrdinal("TenHocVi")) ? null : (System.String)reader["TenHocVi"];
			//entity.TenHocVi = (Convert.IsDBNull(reader["TenHocVi"]))?string.Empty:(System.String)reader["TenHocVi"];
			entity.TenLoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("TenLoaiGiangVien")) ? null : (System.String)reader["TenLoaiGiangVien"];
			//entity.TenLoaiGiangVien = (Convert.IsDBNull(reader["TenLoaiGiangVien"]))?string.Empty:(System.String)reader["TenLoaiGiangVien"];
			entity.MaDonVi = reader.IsDBNull(reader.GetOrdinal("MaDonVi")) ? null : (System.String)reader["MaDonVi"];
			//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
			entity.TenDonVi = (System.String)reader["TenDonVi"];
			//entity.TenDonVi = (Convert.IsDBNull(reader["TenDonVi"]))?string.Empty:(System.String)reader["TenDonVi"];
			entity.Lop = reader.IsDBNull(reader.GetOrdinal("Lop")) ? null : (System.String)reader["Lop"];
			//entity.Lop = (Convert.IsDBNull(reader["Lop"]))?string.Empty:(System.String)reader["Lop"];
			entity.MaSo = reader.IsDBNull(reader.GetOrdinal("MaSo")) ? null : (System.String)reader["MaSo"];
			//entity.MaSo = (Convert.IsDBNull(reader["MaSo"]))?string.Empty:(System.String)reader["MaSo"];
			entity.Ngay = reader.IsDBNull(reader.GetOrdinal("Ngay")) ? null : (System.DateTime?)reader["Ngay"];
			//entity.Ngay = (Convert.IsDBNull(reader["Ngay"]))?DateTime.MinValue:(System.DateTime?)reader["Ngay"];
			entity.NoiDung = reader.IsDBNull(reader.GetOrdinal("NoiDung")) ? null : (System.String)reader["NoiDung"];
			//entity.NoiDung = (Convert.IsDBNull(reader["NoiDung"]))?string.Empty:(System.String)reader["NoiDung"];
			entity.HeSo = reader.IsDBNull(reader.GetOrdinal("HeSo")) ? null : (System.Decimal?)reader["HeSo"];
			//entity.HeSo = (Convert.IsDBNull(reader["HeSo"]))?0.0m:(System.Decimal?)reader["HeSo"];
			entity.SoTiet = reader.IsDBNull(reader.GetOrdinal("SoTiet")) ? null : (System.Decimal?)reader["SoTiet"];
			//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?0.0m:(System.Decimal?)reader["SoTiet"];
			entity.TienMotTiet = reader.IsDBNull(reader.GetOrdinal("TienMotTiet")) ? null : (System.Decimal?)reader["TienMotTiet"];
			//entity.TienMotTiet = (Convert.IsDBNull(reader["TienMotTiet"]))?0.0m:(System.Decimal?)reader["TienMotTiet"];
			entity.ThanhTien = reader.IsDBNull(reader.GetOrdinal("ThanhTien")) ? null : (System.Decimal?)reader["ThanhTien"];
			//entity.ThanhTien = (Convert.IsDBNull(reader["ThanhTien"]))?0.0m:(System.Decimal?)reader["ThanhTien"];
			entity.PhiCongTac = reader.IsDBNull(reader.GetOrdinal("PhiCongTac")) ? null : (System.Decimal?)reader["PhiCongTac"];
			//entity.PhiCongTac = (Convert.IsDBNull(reader["PhiCongTac"]))?0.0m:(System.Decimal?)reader["PhiCongTac"];
			entity.TienGiangNgoaiGio = reader.IsDBNull(reader.GetOrdinal("TienGiangNgoaiGio")) ? null : (System.Decimal?)reader["TienGiangNgoaiGio"];
			//entity.TienGiangNgoaiGio = (Convert.IsDBNull(reader["TienGiangNgoaiGio"]))?0.0m:(System.Decimal?)reader["TienGiangNgoaiGio"];
			entity.TongThanhTien = reader.IsDBNull(reader.GetOrdinal("TongThanhTien")) ? null : (System.Decimal?)reader["TongThanhTien"];
			//entity.TongThanhTien = (Convert.IsDBNull(reader["TongThanhTien"]))?0.0m:(System.Decimal?)reader["TongThanhTien"];
			entity.Id = (System.Int32)reader["Id"];
			//entity.Id = (Convert.IsDBNull(reader["Id"]))?(int)0:(System.Int32)reader["Id"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewKetQuaCacKhoanChiKhac"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewKetQuaCacKhoanChiKhac"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewKetQuaCacKhoanChiKhac entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32)dataRow["MaGiangVien"];
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.Ho = (Convert.IsDBNull(dataRow["ho"]))?string.Empty:(System.String)dataRow["ho"];
			entity.Ten = (Convert.IsDBNull(dataRow["Ten"]))?string.Empty:(System.String)dataRow["Ten"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.GioiTinh = (Convert.IsDBNull(dataRow["GioiTinh"]))?string.Empty:(System.String)dataRow["GioiTinh"];
			entity.NgaySinh = (Convert.IsDBNull(dataRow["NgaySinh"]))?string.Empty:(System.String)dataRow["NgaySinh"];
			entity.MaHocHam = (Convert.IsDBNull(dataRow["MaHocHam"]))?(int)0:(System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = (Convert.IsDBNull(dataRow["MaHocVi"]))?(int)0:(System.Int32?)dataRow["MaHocVi"];
			entity.MaLoaiGiangVien = (Convert.IsDBNull(dataRow["MaLoaiGiangVien"]))?(int)0:(System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.TenHocHam = (Convert.IsDBNull(dataRow["TenHocHam"]))?string.Empty:(System.String)dataRow["TenHocHam"];
			entity.TenHocVi = (Convert.IsDBNull(dataRow["TenHocVi"]))?string.Empty:(System.String)dataRow["TenHocVi"];
			entity.TenLoaiGiangVien = (Convert.IsDBNull(dataRow["TenLoaiGiangVien"]))?string.Empty:(System.String)dataRow["TenLoaiGiangVien"];
			entity.MaDonVi = (Convert.IsDBNull(dataRow["MaDonVi"]))?string.Empty:(System.String)dataRow["MaDonVi"];
			entity.TenDonVi = (Convert.IsDBNull(dataRow["TenDonVi"]))?string.Empty:(System.String)dataRow["TenDonVi"];
			entity.Lop = (Convert.IsDBNull(dataRow["Lop"]))?string.Empty:(System.String)dataRow["Lop"];
			entity.MaSo = (Convert.IsDBNull(dataRow["MaSo"]))?string.Empty:(System.String)dataRow["MaSo"];
			entity.Ngay = (Convert.IsDBNull(dataRow["Ngay"]))?DateTime.MinValue:(System.DateTime?)dataRow["Ngay"];
			entity.NoiDung = (Convert.IsDBNull(dataRow["NoiDung"]))?string.Empty:(System.String)dataRow["NoiDung"];
			entity.HeSo = (Convert.IsDBNull(dataRow["HeSo"]))?0.0m:(System.Decimal?)dataRow["HeSo"];
			entity.SoTiet = (Convert.IsDBNull(dataRow["SoTiet"]))?0.0m:(System.Decimal?)dataRow["SoTiet"];
			entity.TienMotTiet = (Convert.IsDBNull(dataRow["TienMotTiet"]))?0.0m:(System.Decimal?)dataRow["TienMotTiet"];
			entity.ThanhTien = (Convert.IsDBNull(dataRow["ThanhTien"]))?0.0m:(System.Decimal?)dataRow["ThanhTien"];
			entity.PhiCongTac = (Convert.IsDBNull(dataRow["PhiCongTac"]))?0.0m:(System.Decimal?)dataRow["PhiCongTac"];
			entity.TienGiangNgoaiGio = (Convert.IsDBNull(dataRow["TienGiangNgoaiGio"]))?0.0m:(System.Decimal?)dataRow["TienGiangNgoaiGio"];
			entity.TongThanhTien = (Convert.IsDBNull(dataRow["TongThanhTien"]))?0.0m:(System.Decimal?)dataRow["TongThanhTien"];
			entity.Id = (Convert.IsDBNull(dataRow["Id"]))?(int)0:(System.Int32)dataRow["Id"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewKetQuaCacKhoanChiKhacFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKetQuaCacKhoanChiKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKetQuaCacKhoanChiKhacFilterBuilder : SqlFilterBuilder<ViewKetQuaCacKhoanChiKhacColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKetQuaCacKhoanChiKhacFilterBuilder class.
		/// </summary>
		public ViewKetQuaCacKhoanChiKhacFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewKetQuaCacKhoanChiKhacFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewKetQuaCacKhoanChiKhacFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewKetQuaCacKhoanChiKhacFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewKetQuaCacKhoanChiKhacFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewKetQuaCacKhoanChiKhacFilterBuilder

	#region ViewKetQuaCacKhoanChiKhacParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKetQuaCacKhoanChiKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKetQuaCacKhoanChiKhacParameterBuilder : ParameterizedSqlFilterBuilder<ViewKetQuaCacKhoanChiKhacColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKetQuaCacKhoanChiKhacParameterBuilder class.
		/// </summary>
		public ViewKetQuaCacKhoanChiKhacParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewKetQuaCacKhoanChiKhacParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewKetQuaCacKhoanChiKhacParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewKetQuaCacKhoanChiKhacParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewKetQuaCacKhoanChiKhacParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewKetQuaCacKhoanChiKhacParameterBuilder
	
	#region ViewKetQuaCacKhoanChiKhacSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKetQuaCacKhoanChiKhac"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewKetQuaCacKhoanChiKhacSortBuilder : SqlSortBuilder<ViewKetQuaCacKhoanChiKhacColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKetQuaCacKhoanChiKhacSqlSortBuilder class.
		/// </summary>
		public ViewKetQuaCacKhoanChiKhacSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewKetQuaCacKhoanChiKhacSortBuilder

} // end namespace
