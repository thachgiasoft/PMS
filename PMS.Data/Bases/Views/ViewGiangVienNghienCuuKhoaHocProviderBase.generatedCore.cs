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
	/// This class is the base class for any <see cref="ViewGiangVienNghienCuuKhoaHocProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewGiangVienNghienCuuKhoaHocProviderBaseCore : EntityViewProviderBase<ViewGiangVienNghienCuuKhoaHoc>
	{
		#region Custom Methods
		
		
		#region cust_view_GiangVien_NghienCuuKhoaHoc_GetByMaDonViNamHoc
		
		/// <summary>
		///	This method wrap the 'cust_view_GiangVien_NghienCuuKhoaHoc_GetByMaDonViNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVienNghienCuuKhoaHoc&gt;"/> instance.</returns>
		public VList<ViewGiangVienNghienCuuKhoaHoc> GetByMaDonViNamHoc(System.String maDonVi, System.String namHoc)
		{
			return GetByMaDonViNamHoc(null, 0, int.MaxValue , maDonVi, namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_view_GiangVien_NghienCuuKhoaHoc_GetByMaDonViNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVienNghienCuuKhoaHoc&gt;"/> instance.</returns>
		public VList<ViewGiangVienNghienCuuKhoaHoc> GetByMaDonViNamHoc(int start, int pageLength, System.String maDonVi, System.String namHoc)
		{
			return GetByMaDonViNamHoc(null, start, pageLength , maDonVi, namHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_view_GiangVien_NghienCuuKhoaHoc_GetByMaDonViNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewGiangVienNghienCuuKhoaHoc&gt;"/> instance.</returns>
		public VList<ViewGiangVienNghienCuuKhoaHoc> GetByMaDonViNamHoc(TransactionManager transactionManager, System.String maDonVi, System.String namHoc)
		{
			return GetByMaDonViNamHoc(transactionManager, 0, int.MaxValue , maDonVi, namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_view_GiangVien_NghienCuuKhoaHoc_GetByMaDonViNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVienNghienCuuKhoaHoc&gt;"/> instance.</returns>
		public abstract VList<ViewGiangVienNghienCuuKhoaHoc> GetByMaDonViNamHoc(TransactionManager transactionManager, int start, int pageLength, System.String maDonVi, System.String namHoc);
		
		#endregion

		
		#region cust_view_GiangVien_NghienCuuKhoaHoc_GetByMaDonViNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_view_GiangVien_NghienCuuKhoaHoc_GetByMaDonViNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVienNghienCuuKhoaHoc&gt;"/> instance.</returns>
		public VList<ViewGiangVienNghienCuuKhoaHoc> GetByMaDonViNamHocHocKy(System.String maDonVi, System.String namHoc, System.String hocKy)
		{
			return GetByMaDonViNamHocHocKy(null, 0, int.MaxValue , maDonVi, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_view_GiangVien_NghienCuuKhoaHoc_GetByMaDonViNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVienNghienCuuKhoaHoc&gt;"/> instance.</returns>
		public VList<ViewGiangVienNghienCuuKhoaHoc> GetByMaDonViNamHocHocKy(int start, int pageLength, System.String maDonVi, System.String namHoc, System.String hocKy)
		{
			return GetByMaDonViNamHocHocKy(null, start, pageLength , maDonVi, namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_view_GiangVien_NghienCuuKhoaHoc_GetByMaDonViNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewGiangVienNghienCuuKhoaHoc&gt;"/> instance.</returns>
		public VList<ViewGiangVienNghienCuuKhoaHoc> GetByMaDonViNamHocHocKy(TransactionManager transactionManager, System.String maDonVi, System.String namHoc, System.String hocKy)
		{
			return GetByMaDonViNamHocHocKy(transactionManager, 0, int.MaxValue , maDonVi, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_view_GiangVien_NghienCuuKhoaHoc_GetByMaDonViNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVienNghienCuuKhoaHoc&gt;"/> instance.</returns>
		public abstract VList<ViewGiangVienNghienCuuKhoaHoc> GetByMaDonViNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String maDonVi, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewGiangVienNghienCuuKhoaHoc&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewGiangVienNghienCuuKhoaHoc&gt;"/></returns>
		protected static VList&lt;ViewGiangVienNghienCuuKhoaHoc&gt; Fill(DataSet dataSet, VList<ViewGiangVienNghienCuuKhoaHoc> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewGiangVienNghienCuuKhoaHoc>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewGiangVienNghienCuuKhoaHoc&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewGiangVienNghienCuuKhoaHoc>"/></returns>
		protected static VList&lt;ViewGiangVienNghienCuuKhoaHoc&gt; Fill(DataTable dataTable, VList<ViewGiangVienNghienCuuKhoaHoc> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewGiangVienNghienCuuKhoaHoc c = new ViewGiangVienNghienCuuKhoaHoc();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32)row["MaGiangVien"];
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.Ho = (Convert.IsDBNull(row["Ho"]))?string.Empty:(System.String)row["Ho"];
					c.Ten = (Convert.IsDBNull(row["Ten"]))?string.Empty:(System.String)row["Ten"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.GioiTinh = (Convert.IsDBNull(row["GioiTinh"]))?false:(System.Boolean?)row["GioiTinh"];
					c.NgaySinh = (Convert.IsDBNull(row["NgaySinh"]))?string.Empty:(System.String)row["NgaySinh"];
					c.MaHocHam = (Convert.IsDBNull(row["MaHocHam"]))?(int)0:(System.Int32?)row["MaHocHam"];
					c.MaHocVi = (Convert.IsDBNull(row["MaHocVi"]))?(int)0:(System.Int32?)row["MaHocVi"];
					c.TenHocHam = (Convert.IsDBNull(row["TenHocHam"]))?string.Empty:(System.String)row["TenHocHam"];
					c.TenHocVi = (Convert.IsDBNull(row["TenHocVi"]))?string.Empty:(System.String)row["TenHocVi"];
					c.SoTietDinhMuc = (Convert.IsDBNull(row["SoTietDinhMuc"]))?0.0m:(System.Decimal?)row["SoTietDinhMuc"];
					c.SoTietThucHien = (Convert.IsDBNull(row["SoTietThucHien"]))?0.0m:(System.Decimal?)row["SoTietThucHien"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.MaDonVi = (Convert.IsDBNull(row["MaDonVi"]))?string.Empty:(System.String)row["MaDonVi"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
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
		/// Fill an <see cref="VList&lt;ViewGiangVienNghienCuuKhoaHoc&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewGiangVienNghienCuuKhoaHoc&gt;"/></returns>
		protected VList<ViewGiangVienNghienCuuKhoaHoc> Fill(IDataReader reader, VList<ViewGiangVienNghienCuuKhoaHoc> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewGiangVienNghienCuuKhoaHoc entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewGiangVienNghienCuuKhoaHoc>("ViewGiangVienNghienCuuKhoaHoc",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewGiangVienNghienCuuKhoaHoc();
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
					entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.GioiTinh = reader.IsDBNull(reader.GetOrdinal("GioiTinh")) ? null : (System.Boolean?)reader["GioiTinh"];
					//entity.GioiTinh = (Convert.IsDBNull(reader["GioiTinh"]))?false:(System.Boolean?)reader["GioiTinh"];
					entity.NgaySinh = reader.IsDBNull(reader.GetOrdinal("NgaySinh")) ? null : (System.String)reader["NgaySinh"];
					//entity.NgaySinh = (Convert.IsDBNull(reader["NgaySinh"]))?string.Empty:(System.String)reader["NgaySinh"];
					entity.MaHocHam = reader.IsDBNull(reader.GetOrdinal("MaHocHam")) ? null : (System.Int32?)reader["MaHocHam"];
					//entity.MaHocHam = (Convert.IsDBNull(reader["MaHocHam"]))?(int)0:(System.Int32?)reader["MaHocHam"];
					entity.MaHocVi = reader.IsDBNull(reader.GetOrdinal("MaHocVi")) ? null : (System.Int32?)reader["MaHocVi"];
					//entity.MaHocVi = (Convert.IsDBNull(reader["MaHocVi"]))?(int)0:(System.Int32?)reader["MaHocVi"];
					entity.TenHocHam = reader.IsDBNull(reader.GetOrdinal("TenHocHam")) ? null : (System.String)reader["TenHocHam"];
					//entity.TenHocHam = (Convert.IsDBNull(reader["TenHocHam"]))?string.Empty:(System.String)reader["TenHocHam"];
					entity.TenHocVi = reader.IsDBNull(reader.GetOrdinal("TenHocVi")) ? null : (System.String)reader["TenHocVi"];
					//entity.TenHocVi = (Convert.IsDBNull(reader["TenHocVi"]))?string.Empty:(System.String)reader["TenHocVi"];
					entity.SoTietDinhMuc = reader.IsDBNull(reader.GetOrdinal("SoTietDinhMuc")) ? null : (System.Decimal?)reader["SoTietDinhMuc"];
					//entity.SoTietDinhMuc = (Convert.IsDBNull(reader["SoTietDinhMuc"]))?0.0m:(System.Decimal?)reader["SoTietDinhMuc"];
					entity.SoTietThucHien = reader.IsDBNull(reader.GetOrdinal("SoTietThucHien")) ? null : (System.Decimal?)reader["SoTietThucHien"];
					//entity.SoTietThucHien = (Convert.IsDBNull(reader["SoTietThucHien"]))?0.0m:(System.Decimal?)reader["SoTietThucHien"];
					entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.MaDonVi = reader.IsDBNull(reader.GetOrdinal("MaDonVi")) ? null : (System.String)reader["MaDonVi"];
					//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
					entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
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
		/// Refreshes the <see cref="ViewGiangVienNghienCuuKhoaHoc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewGiangVienNghienCuuKhoaHoc"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewGiangVienNghienCuuKhoaHoc entity)
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
			entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.GioiTinh = reader.IsDBNull(reader.GetOrdinal("GioiTinh")) ? null : (System.Boolean?)reader["GioiTinh"];
			//entity.GioiTinh = (Convert.IsDBNull(reader["GioiTinh"]))?false:(System.Boolean?)reader["GioiTinh"];
			entity.NgaySinh = reader.IsDBNull(reader.GetOrdinal("NgaySinh")) ? null : (System.String)reader["NgaySinh"];
			//entity.NgaySinh = (Convert.IsDBNull(reader["NgaySinh"]))?string.Empty:(System.String)reader["NgaySinh"];
			entity.MaHocHam = reader.IsDBNull(reader.GetOrdinal("MaHocHam")) ? null : (System.Int32?)reader["MaHocHam"];
			//entity.MaHocHam = (Convert.IsDBNull(reader["MaHocHam"]))?(int)0:(System.Int32?)reader["MaHocHam"];
			entity.MaHocVi = reader.IsDBNull(reader.GetOrdinal("MaHocVi")) ? null : (System.Int32?)reader["MaHocVi"];
			//entity.MaHocVi = (Convert.IsDBNull(reader["MaHocVi"]))?(int)0:(System.Int32?)reader["MaHocVi"];
			entity.TenHocHam = reader.IsDBNull(reader.GetOrdinal("TenHocHam")) ? null : (System.String)reader["TenHocHam"];
			//entity.TenHocHam = (Convert.IsDBNull(reader["TenHocHam"]))?string.Empty:(System.String)reader["TenHocHam"];
			entity.TenHocVi = reader.IsDBNull(reader.GetOrdinal("TenHocVi")) ? null : (System.String)reader["TenHocVi"];
			//entity.TenHocVi = (Convert.IsDBNull(reader["TenHocVi"]))?string.Empty:(System.String)reader["TenHocVi"];
			entity.SoTietDinhMuc = reader.IsDBNull(reader.GetOrdinal("SoTietDinhMuc")) ? null : (System.Decimal?)reader["SoTietDinhMuc"];
			//entity.SoTietDinhMuc = (Convert.IsDBNull(reader["SoTietDinhMuc"]))?0.0m:(System.Decimal?)reader["SoTietDinhMuc"];
			entity.SoTietThucHien = reader.IsDBNull(reader.GetOrdinal("SoTietThucHien")) ? null : (System.Decimal?)reader["SoTietThucHien"];
			//entity.SoTietThucHien = (Convert.IsDBNull(reader["SoTietThucHien"]))?0.0m:(System.Decimal?)reader["SoTietThucHien"];
			entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.MaDonVi = reader.IsDBNull(reader.GetOrdinal("MaDonVi")) ? null : (System.String)reader["MaDonVi"];
			//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
			entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewGiangVienNghienCuuKhoaHoc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewGiangVienNghienCuuKhoaHoc"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewGiangVienNghienCuuKhoaHoc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32)dataRow["MaGiangVien"];
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.Ho = (Convert.IsDBNull(dataRow["Ho"]))?string.Empty:(System.String)dataRow["Ho"];
			entity.Ten = (Convert.IsDBNull(dataRow["Ten"]))?string.Empty:(System.String)dataRow["Ten"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.GioiTinh = (Convert.IsDBNull(dataRow["GioiTinh"]))?false:(System.Boolean?)dataRow["GioiTinh"];
			entity.NgaySinh = (Convert.IsDBNull(dataRow["NgaySinh"]))?string.Empty:(System.String)dataRow["NgaySinh"];
			entity.MaHocHam = (Convert.IsDBNull(dataRow["MaHocHam"]))?(int)0:(System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = (Convert.IsDBNull(dataRow["MaHocVi"]))?(int)0:(System.Int32?)dataRow["MaHocVi"];
			entity.TenHocHam = (Convert.IsDBNull(dataRow["TenHocHam"]))?string.Empty:(System.String)dataRow["TenHocHam"];
			entity.TenHocVi = (Convert.IsDBNull(dataRow["TenHocVi"]))?string.Empty:(System.String)dataRow["TenHocVi"];
			entity.SoTietDinhMuc = (Convert.IsDBNull(dataRow["SoTietDinhMuc"]))?0.0m:(System.Decimal?)dataRow["SoTietDinhMuc"];
			entity.SoTietThucHien = (Convert.IsDBNull(dataRow["SoTietThucHien"]))?0.0m:(System.Decimal?)dataRow["SoTietThucHien"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.MaDonVi = (Convert.IsDBNull(dataRow["MaDonVi"]))?string.Empty:(System.String)dataRow["MaDonVi"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewGiangVienNghienCuuKhoaHocFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVienNghienCuuKhoaHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewGiangVienNghienCuuKhoaHocFilterBuilder : SqlFilterBuilder<ViewGiangVienNghienCuuKhoaHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienNghienCuuKhoaHocFilterBuilder class.
		/// </summary>
		public ViewGiangVienNghienCuuKhoaHocFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienNghienCuuKhoaHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewGiangVienNghienCuuKhoaHocFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienNghienCuuKhoaHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewGiangVienNghienCuuKhoaHocFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewGiangVienNghienCuuKhoaHocFilterBuilder

	#region ViewGiangVienNghienCuuKhoaHocParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVienNghienCuuKhoaHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewGiangVienNghienCuuKhoaHocParameterBuilder : ParameterizedSqlFilterBuilder<ViewGiangVienNghienCuuKhoaHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienNghienCuuKhoaHocParameterBuilder class.
		/// </summary>
		public ViewGiangVienNghienCuuKhoaHocParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienNghienCuuKhoaHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewGiangVienNghienCuuKhoaHocParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienNghienCuuKhoaHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewGiangVienNghienCuuKhoaHocParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewGiangVienNghienCuuKhoaHocParameterBuilder
	
	#region ViewGiangVienNghienCuuKhoaHocSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVienNghienCuuKhoaHoc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewGiangVienNghienCuuKhoaHocSortBuilder : SqlSortBuilder<ViewGiangVienNghienCuuKhoaHocColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienNghienCuuKhoaHocSqlSortBuilder class.
		/// </summary>
		public ViewGiangVienNghienCuuKhoaHocSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewGiangVienNghienCuuKhoaHocSortBuilder

} // end namespace
