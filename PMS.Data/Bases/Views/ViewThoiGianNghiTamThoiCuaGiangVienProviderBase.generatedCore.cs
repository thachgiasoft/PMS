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
	/// This class is the base class for any <see cref="ViewThoiGianNghiTamThoiCuaGiangVienProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewThoiGianNghiTamThoiCuaGiangVienProviderBaseCore : EntityViewProviderBase<ViewThoiGianNghiTamThoiCuaGiangVien>
	{
		#region Custom Methods
		
		
		#region cust_View_ThoiGianNghiTamThoiCuaGiangVien_GetByNamHoc
		
		/// <summary>
		///	This method wrap the 'cust_View_ThoiGianNghiTamThoiCuaGiangVien_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThoiGianNghiTamThoiCuaGiangVien&gt;"/> instance.</returns>
		public VList<ViewThoiGianNghiTamThoiCuaGiangVien> GetByNamHoc(System.String namHoc)
		{
			return GetByNamHoc(null, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThoiGianNghiTamThoiCuaGiangVien_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThoiGianNghiTamThoiCuaGiangVien&gt;"/> instance.</returns>
		public VList<ViewThoiGianNghiTamThoiCuaGiangVien> GetByNamHoc(int start, int pageLength, System.String namHoc)
		{
			return GetByNamHoc(null, start, pageLength , namHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ThoiGianNghiTamThoiCuaGiangVien_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewThoiGianNghiTamThoiCuaGiangVien&gt;"/> instance.</returns>
		public VList<ViewThoiGianNghiTamThoiCuaGiangVien> GetByNamHoc(TransactionManager transactionManager, System.String namHoc)
		{
			return GetByNamHoc(transactionManager, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThoiGianNghiTamThoiCuaGiangVien_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThoiGianNghiTamThoiCuaGiangVien&gt;"/> instance.</returns>
		public abstract VList<ViewThoiGianNghiTamThoiCuaGiangVien> GetByNamHoc(TransactionManager transactionManager, int start, int pageLength, System.String namHoc);
		
		#endregion

		
		#region cust_View_ThoiGianNghiTamThoiCuaGiangVien_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_ThoiGianNghiTamThoiCuaGiangVien_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThoiGianNghiTamThoiCuaGiangVien&gt;"/> instance.</returns>
		public VList<ViewThoiGianNghiTamThoiCuaGiangVien> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThoiGianNghiTamThoiCuaGiangVien_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThoiGianNghiTamThoiCuaGiangVien&gt;"/> instance.</returns>
		public VList<ViewThoiGianNghiTamThoiCuaGiangVien> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ThoiGianNghiTamThoiCuaGiangVien_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewThoiGianNghiTamThoiCuaGiangVien&gt;"/> instance.</returns>
		public VList<ViewThoiGianNghiTamThoiCuaGiangVien> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThoiGianNghiTamThoiCuaGiangVien_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThoiGianNghiTamThoiCuaGiangVien&gt;"/> instance.</returns>
		public abstract VList<ViewThoiGianNghiTamThoiCuaGiangVien> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewThoiGianNghiTamThoiCuaGiangVien&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewThoiGianNghiTamThoiCuaGiangVien&gt;"/></returns>
		protected static VList&lt;ViewThoiGianNghiTamThoiCuaGiangVien&gt; Fill(DataSet dataSet, VList<ViewThoiGianNghiTamThoiCuaGiangVien> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewThoiGianNghiTamThoiCuaGiangVien>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewThoiGianNghiTamThoiCuaGiangVien&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewThoiGianNghiTamThoiCuaGiangVien>"/></returns>
		protected static VList&lt;ViewThoiGianNghiTamThoiCuaGiangVien&gt; Fill(DataTable dataTable, VList<ViewThoiGianNghiTamThoiCuaGiangVien> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewThoiGianNghiTamThoiCuaGiangVien c = new ViewThoiGianNghiTamThoiCuaGiangVien();
					c.Id = (Convert.IsDBNull(row["Id"]))?(int)0:(System.Int32)row["Id"];
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32?)row["MaGiangVien"];
					c.Ho = (Convert.IsDBNull(row["Ho"]))?string.Empty:(System.String)row["Ho"];
					c.Ten = (Convert.IsDBNull(row["Ten"]))?string.Empty:(System.String)row["Ten"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.NoiDung = (Convert.IsDBNull(row["NoiDung"]))?string.Empty:(System.String)row["NoiDung"];
					c.TuNgay = (Convert.IsDBNull(row["TuNgay"]))?DateTime.MinValue:(System.DateTime?)row["TuNgay"];
					c.DenNgay = (Convert.IsDBNull(row["DenNgay"]))?DateTime.MinValue:(System.DateTime?)row["DenNgay"];
					c.NgayCapNhat = (Convert.IsDBNull(row["NgayCapNhat"]))?string.Empty:(System.String)row["NgayCapNhat"];
					c.NguoiCapNhat = (Convert.IsDBNull(row["NguoiCapNhat"]))?string.Empty:(System.String)row["NguoiCapNhat"];
					c.MaDonVi = (Convert.IsDBNull(row["MaDonVi"]))?string.Empty:(System.String)row["MaDonVi"];
					c.TenDonVi = (Convert.IsDBNull(row["TenDonVi"]))?string.Empty:(System.String)row["TenDonVi"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.MaGiamTruDinhMuc = (Convert.IsDBNull(row["MaGiamTruDinhMuc"]))?(int)0:(System.Int32?)row["MaGiamTruDinhMuc"];
					c.GioChuanHk01 = (Convert.IsDBNull(row["GioChuanHk01"]))?0.0m:(System.Decimal?)row["GioChuanHk01"];
					c.GioChuanHk02 = (Convert.IsDBNull(row["GioChuanHk02"]))?0.0m:(System.Decimal?)row["GioChuanHk02"];
					c.GhiChu = (Convert.IsDBNull(row["GhiChu"]))?string.Empty:(System.String)row["GhiChu"];
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
		/// Fill an <see cref="VList&lt;ViewThoiGianNghiTamThoiCuaGiangVien&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewThoiGianNghiTamThoiCuaGiangVien&gt;"/></returns>
		protected VList<ViewThoiGianNghiTamThoiCuaGiangVien> Fill(IDataReader reader, VList<ViewThoiGianNghiTamThoiCuaGiangVien> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewThoiGianNghiTamThoiCuaGiangVien entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewThoiGianNghiTamThoiCuaGiangVien>("ViewThoiGianNghiTamThoiCuaGiangVien",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewThoiGianNghiTamThoiCuaGiangVien();
					}
					
					entity.SuppressEntityEvents = true;

					entity.Id = (System.Int32)reader["Id"];
					//entity.Id = (Convert.IsDBNull(reader["Id"]))?(int)0:(System.Int32)reader["Id"];
					entity.MaGiangVien = reader.IsDBNull(reader.GetOrdinal("MaGiangVien")) ? null : (System.Int32?)reader["MaGiangVien"];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32?)reader["MaGiangVien"];
					entity.Ho = reader.IsDBNull(reader.GetOrdinal("Ho")) ? null : (System.String)reader["Ho"];
					//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
					entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
					//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
					entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.NoiDung = reader.IsDBNull(reader.GetOrdinal("NoiDung")) ? null : (System.String)reader["NoiDung"];
					//entity.NoiDung = (Convert.IsDBNull(reader["NoiDung"]))?string.Empty:(System.String)reader["NoiDung"];
					entity.TuNgay = reader.IsDBNull(reader.GetOrdinal("TuNgay")) ? null : (System.DateTime?)reader["TuNgay"];
					//entity.TuNgay = (Convert.IsDBNull(reader["TuNgay"]))?DateTime.MinValue:(System.DateTime?)reader["TuNgay"];
					entity.DenNgay = reader.IsDBNull(reader.GetOrdinal("DenNgay")) ? null : (System.DateTime?)reader["DenNgay"];
					//entity.DenNgay = (Convert.IsDBNull(reader["DenNgay"]))?DateTime.MinValue:(System.DateTime?)reader["DenNgay"];
					entity.NgayCapNhat = reader.IsDBNull(reader.GetOrdinal("NgayCapNhat")) ? null : (System.String)reader["NgayCapNhat"];
					//entity.NgayCapNhat = (Convert.IsDBNull(reader["NgayCapNhat"]))?string.Empty:(System.String)reader["NgayCapNhat"];
					entity.NguoiCapNhat = reader.IsDBNull(reader.GetOrdinal("NguoiCapNhat")) ? null : (System.String)reader["NguoiCapNhat"];
					//entity.NguoiCapNhat = (Convert.IsDBNull(reader["NguoiCapNhat"]))?string.Empty:(System.String)reader["NguoiCapNhat"];
					entity.MaDonVi = reader.IsDBNull(reader.GetOrdinal("MaDonVi")) ? null : (System.String)reader["MaDonVi"];
					//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
					entity.TenDonVi = reader.IsDBNull(reader.GetOrdinal("TenDonVi")) ? null : (System.String)reader["TenDonVi"];
					//entity.TenDonVi = (Convert.IsDBNull(reader["TenDonVi"]))?string.Empty:(System.String)reader["TenDonVi"];
					entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.MaGiamTruDinhMuc = reader.IsDBNull(reader.GetOrdinal("MaGiamTruDinhMuc")) ? null : (System.Int32?)reader["MaGiamTruDinhMuc"];
					//entity.MaGiamTruDinhMuc = (Convert.IsDBNull(reader["MaGiamTruDinhMuc"]))?(int)0:(System.Int32?)reader["MaGiamTruDinhMuc"];
					entity.GioChuanHk01 = reader.IsDBNull(reader.GetOrdinal("GioChuanHk01")) ? null : (System.Decimal?)reader["GioChuanHk01"];
					//entity.GioChuanHk01 = (Convert.IsDBNull(reader["GioChuanHk01"]))?0.0m:(System.Decimal?)reader["GioChuanHk01"];
					entity.GioChuanHk02 = reader.IsDBNull(reader.GetOrdinal("GioChuanHk02")) ? null : (System.Decimal?)reader["GioChuanHk02"];
					//entity.GioChuanHk02 = (Convert.IsDBNull(reader["GioChuanHk02"]))?0.0m:(System.Decimal?)reader["GioChuanHk02"];
					entity.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : (System.String)reader["GhiChu"];
					//entity.GhiChu = (Convert.IsDBNull(reader["GhiChu"]))?string.Empty:(System.String)reader["GhiChu"];
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
		/// Refreshes the <see cref="ViewThoiGianNghiTamThoiCuaGiangVien"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThoiGianNghiTamThoiCuaGiangVien"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewThoiGianNghiTamThoiCuaGiangVien entity)
		{
			reader.Read();
			entity.Id = (System.Int32)reader["Id"];
			//entity.Id = (Convert.IsDBNull(reader["Id"]))?(int)0:(System.Int32)reader["Id"];
			entity.MaGiangVien = reader.IsDBNull(reader.GetOrdinal("MaGiangVien")) ? null : (System.Int32?)reader["MaGiangVien"];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32?)reader["MaGiangVien"];
			entity.Ho = reader.IsDBNull(reader.GetOrdinal("Ho")) ? null : (System.String)reader["Ho"];
			//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
			entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
			//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
			entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.NoiDung = reader.IsDBNull(reader.GetOrdinal("NoiDung")) ? null : (System.String)reader["NoiDung"];
			//entity.NoiDung = (Convert.IsDBNull(reader["NoiDung"]))?string.Empty:(System.String)reader["NoiDung"];
			entity.TuNgay = reader.IsDBNull(reader.GetOrdinal("TuNgay")) ? null : (System.DateTime?)reader["TuNgay"];
			//entity.TuNgay = (Convert.IsDBNull(reader["TuNgay"]))?DateTime.MinValue:(System.DateTime?)reader["TuNgay"];
			entity.DenNgay = reader.IsDBNull(reader.GetOrdinal("DenNgay")) ? null : (System.DateTime?)reader["DenNgay"];
			//entity.DenNgay = (Convert.IsDBNull(reader["DenNgay"]))?DateTime.MinValue:(System.DateTime?)reader["DenNgay"];
			entity.NgayCapNhat = reader.IsDBNull(reader.GetOrdinal("NgayCapNhat")) ? null : (System.String)reader["NgayCapNhat"];
			//entity.NgayCapNhat = (Convert.IsDBNull(reader["NgayCapNhat"]))?string.Empty:(System.String)reader["NgayCapNhat"];
			entity.NguoiCapNhat = reader.IsDBNull(reader.GetOrdinal("NguoiCapNhat")) ? null : (System.String)reader["NguoiCapNhat"];
			//entity.NguoiCapNhat = (Convert.IsDBNull(reader["NguoiCapNhat"]))?string.Empty:(System.String)reader["NguoiCapNhat"];
			entity.MaDonVi = reader.IsDBNull(reader.GetOrdinal("MaDonVi")) ? null : (System.String)reader["MaDonVi"];
			//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
			entity.TenDonVi = reader.IsDBNull(reader.GetOrdinal("TenDonVi")) ? null : (System.String)reader["TenDonVi"];
			//entity.TenDonVi = (Convert.IsDBNull(reader["TenDonVi"]))?string.Empty:(System.String)reader["TenDonVi"];
			entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.MaGiamTruDinhMuc = reader.IsDBNull(reader.GetOrdinal("MaGiamTruDinhMuc")) ? null : (System.Int32?)reader["MaGiamTruDinhMuc"];
			//entity.MaGiamTruDinhMuc = (Convert.IsDBNull(reader["MaGiamTruDinhMuc"]))?(int)0:(System.Int32?)reader["MaGiamTruDinhMuc"];
			entity.GioChuanHk01 = reader.IsDBNull(reader.GetOrdinal("GioChuanHk01")) ? null : (System.Decimal?)reader["GioChuanHk01"];
			//entity.GioChuanHk01 = (Convert.IsDBNull(reader["GioChuanHk01"]))?0.0m:(System.Decimal?)reader["GioChuanHk01"];
			entity.GioChuanHk02 = reader.IsDBNull(reader.GetOrdinal("GioChuanHk02")) ? null : (System.Decimal?)reader["GioChuanHk02"];
			//entity.GioChuanHk02 = (Convert.IsDBNull(reader["GioChuanHk02"]))?0.0m:(System.Decimal?)reader["GioChuanHk02"];
			entity.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : (System.String)reader["GhiChu"];
			//entity.GhiChu = (Convert.IsDBNull(reader["GhiChu"]))?string.Empty:(System.String)reader["GhiChu"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewThoiGianNghiTamThoiCuaGiangVien"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThoiGianNghiTamThoiCuaGiangVien"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewThoiGianNghiTamThoiCuaGiangVien entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (Convert.IsDBNull(dataRow["Id"]))?(int)0:(System.Int32)dataRow["Id"];
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32?)dataRow["MaGiangVien"];
			entity.Ho = (Convert.IsDBNull(dataRow["Ho"]))?string.Empty:(System.String)dataRow["Ho"];
			entity.Ten = (Convert.IsDBNull(dataRow["Ten"]))?string.Empty:(System.String)dataRow["Ten"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.NoiDung = (Convert.IsDBNull(dataRow["NoiDung"]))?string.Empty:(System.String)dataRow["NoiDung"];
			entity.TuNgay = (Convert.IsDBNull(dataRow["TuNgay"]))?DateTime.MinValue:(System.DateTime?)dataRow["TuNgay"];
			entity.DenNgay = (Convert.IsDBNull(dataRow["DenNgay"]))?DateTime.MinValue:(System.DateTime?)dataRow["DenNgay"];
			entity.NgayCapNhat = (Convert.IsDBNull(dataRow["NgayCapNhat"]))?string.Empty:(System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = (Convert.IsDBNull(dataRow["NguoiCapNhat"]))?string.Empty:(System.String)dataRow["NguoiCapNhat"];
			entity.MaDonVi = (Convert.IsDBNull(dataRow["MaDonVi"]))?string.Empty:(System.String)dataRow["MaDonVi"];
			entity.TenDonVi = (Convert.IsDBNull(dataRow["TenDonVi"]))?string.Empty:(System.String)dataRow["TenDonVi"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.MaGiamTruDinhMuc = (Convert.IsDBNull(dataRow["MaGiamTruDinhMuc"]))?(int)0:(System.Int32?)dataRow["MaGiamTruDinhMuc"];
			entity.GioChuanHk01 = (Convert.IsDBNull(dataRow["GioChuanHk01"]))?0.0m:(System.Decimal?)dataRow["GioChuanHk01"];
			entity.GioChuanHk02 = (Convert.IsDBNull(dataRow["GioChuanHk02"]))?0.0m:(System.Decimal?)dataRow["GioChuanHk02"];
			entity.GhiChu = (Convert.IsDBNull(dataRow["GhiChu"]))?string.Empty:(System.String)dataRow["GhiChu"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewThoiGianNghiTamThoiCuaGiangVienFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThoiGianNghiTamThoiCuaGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThoiGianNghiTamThoiCuaGiangVienFilterBuilder : SqlFilterBuilder<ViewThoiGianNghiTamThoiCuaGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThoiGianNghiTamThoiCuaGiangVienFilterBuilder class.
		/// </summary>
		public ViewThoiGianNghiTamThoiCuaGiangVienFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThoiGianNghiTamThoiCuaGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThoiGianNghiTamThoiCuaGiangVienFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThoiGianNghiTamThoiCuaGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThoiGianNghiTamThoiCuaGiangVienFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThoiGianNghiTamThoiCuaGiangVienFilterBuilder

	#region ViewThoiGianNghiTamThoiCuaGiangVienParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThoiGianNghiTamThoiCuaGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThoiGianNghiTamThoiCuaGiangVienParameterBuilder : ParameterizedSqlFilterBuilder<ViewThoiGianNghiTamThoiCuaGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThoiGianNghiTamThoiCuaGiangVienParameterBuilder class.
		/// </summary>
		public ViewThoiGianNghiTamThoiCuaGiangVienParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThoiGianNghiTamThoiCuaGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThoiGianNghiTamThoiCuaGiangVienParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThoiGianNghiTamThoiCuaGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThoiGianNghiTamThoiCuaGiangVienParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThoiGianNghiTamThoiCuaGiangVienParameterBuilder
	
	#region ViewThoiGianNghiTamThoiCuaGiangVienSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThoiGianNghiTamThoiCuaGiangVien"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewThoiGianNghiTamThoiCuaGiangVienSortBuilder : SqlSortBuilder<ViewThoiGianNghiTamThoiCuaGiangVienColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThoiGianNghiTamThoiCuaGiangVienSqlSortBuilder class.
		/// </summary>
		public ViewThoiGianNghiTamThoiCuaGiangVienSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewThoiGianNghiTamThoiCuaGiangVienSortBuilder

} // end namespace
