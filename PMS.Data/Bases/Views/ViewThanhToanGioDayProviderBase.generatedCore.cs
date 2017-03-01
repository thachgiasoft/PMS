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
	/// This class is the base class for any <see cref="ViewThanhToanGioDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewThanhToanGioDayProviderBaseCore : EntityViewProviderBase<ViewThanhToanGioDay>
	{
		#region Custom Methods
		
		
		#region cust_View_ThanhToan_GioDay_GetByNamHocHocKyMaDonVi
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhToan_GioDay_GetByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThanhToanGioDay&gt;"/> instance.</returns>
		public VList<ViewThanhToanGioDay> GetByNamHocHocKyMaDonVi(System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetByNamHocHocKyMaDonVi(null, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhToan_GioDay_GetByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThanhToanGioDay&gt;"/> instance.</returns>
		public VList<ViewThanhToanGioDay> GetByNamHocHocKyMaDonVi(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetByNamHocHocKyMaDonVi(null, start, pageLength , namHoc, hocKy, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ThanhToan_GioDay_GetByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewThanhToanGioDay&gt;"/> instance.</returns>
		public VList<ViewThanhToanGioDay> GetByNamHocHocKyMaDonVi(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetByNamHocHocKyMaDonVi(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhToan_GioDay_GetByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThanhToanGioDay&gt;"/> instance.</returns>
		public abstract VList<ViewThanhToanGioDay> GetByNamHocHocKyMaDonVi(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi);
		
		#endregion

		
		#region cust_View_ThanhToan_GioDay_GetByNamHocHocKyMaDonViMaLoaiGiangVien
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhToan_GioDay_GetByNamHocHocKyMaDonViMaLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThanhToanGioDay&gt;"/> instance.</returns>
		public VList<ViewThanhToanGioDay> GetByNamHocHocKyMaDonViMaLoaiGiangVien(System.String namHoc, System.String hocKy, System.String maDonVi, System.Int32 maLoaiGiangVien)
		{
			return GetByNamHocHocKyMaDonViMaLoaiGiangVien(null, 0, int.MaxValue , namHoc, hocKy, maDonVi, maLoaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhToan_GioDay_GetByNamHocHocKyMaDonViMaLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThanhToanGioDay&gt;"/> instance.</returns>
		public VList<ViewThanhToanGioDay> GetByNamHocHocKyMaDonViMaLoaiGiangVien(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi, System.Int32 maLoaiGiangVien)
		{
			return GetByNamHocHocKyMaDonViMaLoaiGiangVien(null, start, pageLength , namHoc, hocKy, maDonVi, maLoaiGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ThanhToan_GioDay_GetByNamHocHocKyMaDonViMaLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewThanhToanGioDay&gt;"/> instance.</returns>
		public VList<ViewThanhToanGioDay> GetByNamHocHocKyMaDonViMaLoaiGiangVien(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi, System.Int32 maLoaiGiangVien)
		{
			return GetByNamHocHocKyMaDonViMaLoaiGiangVien(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi, maLoaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhToan_GioDay_GetByNamHocHocKyMaDonViMaLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThanhToanGioDay&gt;"/> instance.</returns>
		public abstract VList<ViewThanhToanGioDay> GetByNamHocHocKyMaDonViMaLoaiGiangVien(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi, System.Int32 maLoaiGiangVien);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewThanhToanGioDay&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewThanhToanGioDay&gt;"/></returns>
		protected static VList&lt;ViewThanhToanGioDay&gt; Fill(DataSet dataSet, VList<ViewThanhToanGioDay> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewThanhToanGioDay>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewThanhToanGioDay&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewThanhToanGioDay>"/></returns>
		protected static VList&lt;ViewThanhToanGioDay&gt; Fill(DataTable dataTable, VList<ViewThanhToanGioDay> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewThanhToanGioDay c = new ViewThanhToanGioDay();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32)row["MaGiangVien"];
					c.MaQuanLyGiangVien = (Convert.IsDBNull(row["MaQuanLyGiangVien"]))?string.Empty:(System.String)row["MaQuanLyGiangVien"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.HoTenHocHamHocVi = (Convert.IsDBNull(row["HoTen_HocHam_HocVi"]))?string.Empty:(System.String)row["HoTen_HocHam_HocVi"];
					c.MaDonVi = (Convert.IsDBNull(row["MaDonVi"]))?string.Empty:(System.String)row["MaDonVi"];
					c.MaLoaiGiangVien = (Convert.IsDBNull(row["MaLoaiGiangVien"]))?(int)0:(System.Int32?)row["MaLoaiGiangVien"];
					c.BacLuong = (Convert.IsDBNull(row["BacLuong"]))?0.0m:(System.Decimal)row["BacLuong"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.TietThucDay = (Convert.IsDBNull(row["TietThucDay"]))?0.0m:(System.Decimal?)row["TietThucDay"];
					c.TietQuyDoi = (Convert.IsDBNull(row["TietQuyDoi"]))?0.0m:(System.Decimal)row["TietQuyDoi"];
					c.TietNghiaVu = (Convert.IsDBNull(row["TietNghiaVu"]))?(int)0:(System.Int32?)row["TietNghiaVu"];
					c.TietGioiHan = (Convert.IsDBNull(row["TietGioiHan"]))?(int)0:(System.Int32?)row["TietGioiHan"];
					c.MaHocHamQuanLy = (Convert.IsDBNull(row["MaHocHamQuanLy"]))?string.Empty:(System.String)row["MaHocHamQuanLy"];
					c.MaHocViQuanLy = (Convert.IsDBNull(row["MaHocViQuanLy"]))?string.Empty:(System.String)row["MaHocViQuanLy"];
					c.TietTdTietQd = (Convert.IsDBNull(row["TietTD_TietQD"]))?string.Empty:(System.String)row["TietTD_TietQD"];
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
		/// Fill an <see cref="VList&lt;ViewThanhToanGioDay&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewThanhToanGioDay&gt;"/></returns>
		protected VList<ViewThanhToanGioDay> Fill(IDataReader reader, VList<ViewThanhToanGioDay> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewThanhToanGioDay entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewThanhToanGioDay>("ViewThanhToanGioDay",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewThanhToanGioDay();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = (System.Int32)reader["MaGiangVien"];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
					entity.MaQuanLyGiangVien = (System.String)reader["MaQuanLyGiangVien"];
					//entity.MaQuanLyGiangVien = (Convert.IsDBNull(reader["MaQuanLyGiangVien"]))?string.Empty:(System.String)reader["MaQuanLyGiangVien"];
					entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.HoTenHocHamHocVi = reader.IsDBNull(reader.GetOrdinal("HoTenHocHamHocVi")) ? null : (System.String)reader["HoTenHocHamHocVi"];
					//entity.HoTenHocHamHocVi = (Convert.IsDBNull(reader["HoTen_HocHam_HocVi"]))?string.Empty:(System.String)reader["HoTen_HocHam_HocVi"];
					entity.MaDonVi = reader.IsDBNull(reader.GetOrdinal("MaDonVi")) ? null : (System.String)reader["MaDonVi"];
					//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
					entity.MaLoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("MaLoaiGiangVien")) ? null : (System.Int32?)reader["MaLoaiGiangVien"];
					//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32?)reader["MaLoaiGiangVien"];
					entity.BacLuong = (System.Decimal)reader["BacLuong"];
					//entity.BacLuong = (Convert.IsDBNull(reader["BacLuong"]))?0.0m:(System.Decimal)reader["BacLuong"];
					entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.TietThucDay = reader.IsDBNull(reader.GetOrdinal("TietThucDay")) ? null : (System.Decimal?)reader["TietThucDay"];
					//entity.TietThucDay = (Convert.IsDBNull(reader["TietThucDay"]))?0.0m:(System.Decimal?)reader["TietThucDay"];
					entity.TietQuyDoi = (System.Decimal)reader["TietQuyDoi"];
					//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal)reader["TietQuyDoi"];
					entity.TietNghiaVu = reader.IsDBNull(reader.GetOrdinal("TietNghiaVu")) ? null : (System.Int32?)reader["TietNghiaVu"];
					//entity.TietNghiaVu = (Convert.IsDBNull(reader["TietNghiaVu"]))?(int)0:(System.Int32?)reader["TietNghiaVu"];
					entity.TietGioiHan = reader.IsDBNull(reader.GetOrdinal("TietGioiHan")) ? null : (System.Int32?)reader["TietGioiHan"];
					//entity.TietGioiHan = (Convert.IsDBNull(reader["TietGioiHan"]))?(int)0:(System.Int32?)reader["TietGioiHan"];
					entity.MaHocHamQuanLy = reader.IsDBNull(reader.GetOrdinal("MaHocHamQuanLy")) ? null : (System.String)reader["MaHocHamQuanLy"];
					//entity.MaHocHamQuanLy = (Convert.IsDBNull(reader["MaHocHamQuanLy"]))?string.Empty:(System.String)reader["MaHocHamQuanLy"];
					entity.MaHocViQuanLy = reader.IsDBNull(reader.GetOrdinal("MaHocViQuanLy")) ? null : (System.String)reader["MaHocViQuanLy"];
					//entity.MaHocViQuanLy = (Convert.IsDBNull(reader["MaHocViQuanLy"]))?string.Empty:(System.String)reader["MaHocViQuanLy"];
					entity.TietTdTietQd = reader.IsDBNull(reader.GetOrdinal("TietTdTietQd")) ? null : (System.String)reader["TietTdTietQd"];
					//entity.TietTdTietQd = (Convert.IsDBNull(reader["TietTD_TietQD"]))?string.Empty:(System.String)reader["TietTD_TietQD"];
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
		/// Refreshes the <see cref="ViewThanhToanGioDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThanhToanGioDay"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewThanhToanGioDay entity)
		{
			reader.Read();
			entity.MaGiangVien = (System.Int32)reader["MaGiangVien"];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
			entity.MaQuanLyGiangVien = (System.String)reader["MaQuanLyGiangVien"];
			//entity.MaQuanLyGiangVien = (Convert.IsDBNull(reader["MaQuanLyGiangVien"]))?string.Empty:(System.String)reader["MaQuanLyGiangVien"];
			entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.HoTenHocHamHocVi = reader.IsDBNull(reader.GetOrdinal("HoTenHocHamHocVi")) ? null : (System.String)reader["HoTenHocHamHocVi"];
			//entity.HoTenHocHamHocVi = (Convert.IsDBNull(reader["HoTen_HocHam_HocVi"]))?string.Empty:(System.String)reader["HoTen_HocHam_HocVi"];
			entity.MaDonVi = reader.IsDBNull(reader.GetOrdinal("MaDonVi")) ? null : (System.String)reader["MaDonVi"];
			//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
			entity.MaLoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("MaLoaiGiangVien")) ? null : (System.Int32?)reader["MaLoaiGiangVien"];
			//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32?)reader["MaLoaiGiangVien"];
			entity.BacLuong = (System.Decimal)reader["BacLuong"];
			//entity.BacLuong = (Convert.IsDBNull(reader["BacLuong"]))?0.0m:(System.Decimal)reader["BacLuong"];
			entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.TietThucDay = reader.IsDBNull(reader.GetOrdinal("TietThucDay")) ? null : (System.Decimal?)reader["TietThucDay"];
			//entity.TietThucDay = (Convert.IsDBNull(reader["TietThucDay"]))?0.0m:(System.Decimal?)reader["TietThucDay"];
			entity.TietQuyDoi = (System.Decimal)reader["TietQuyDoi"];
			//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal)reader["TietQuyDoi"];
			entity.TietNghiaVu = reader.IsDBNull(reader.GetOrdinal("TietNghiaVu")) ? null : (System.Int32?)reader["TietNghiaVu"];
			//entity.TietNghiaVu = (Convert.IsDBNull(reader["TietNghiaVu"]))?(int)0:(System.Int32?)reader["TietNghiaVu"];
			entity.TietGioiHan = reader.IsDBNull(reader.GetOrdinal("TietGioiHan")) ? null : (System.Int32?)reader["TietGioiHan"];
			//entity.TietGioiHan = (Convert.IsDBNull(reader["TietGioiHan"]))?(int)0:(System.Int32?)reader["TietGioiHan"];
			entity.MaHocHamQuanLy = reader.IsDBNull(reader.GetOrdinal("MaHocHamQuanLy")) ? null : (System.String)reader["MaHocHamQuanLy"];
			//entity.MaHocHamQuanLy = (Convert.IsDBNull(reader["MaHocHamQuanLy"]))?string.Empty:(System.String)reader["MaHocHamQuanLy"];
			entity.MaHocViQuanLy = reader.IsDBNull(reader.GetOrdinal("MaHocViQuanLy")) ? null : (System.String)reader["MaHocViQuanLy"];
			//entity.MaHocViQuanLy = (Convert.IsDBNull(reader["MaHocViQuanLy"]))?string.Empty:(System.String)reader["MaHocViQuanLy"];
			entity.TietTdTietQd = reader.IsDBNull(reader.GetOrdinal("TietTdTietQd")) ? null : (System.String)reader["TietTdTietQd"];
			//entity.TietTdTietQd = (Convert.IsDBNull(reader["TietTD_TietQD"]))?string.Empty:(System.String)reader["TietTD_TietQD"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewThanhToanGioDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThanhToanGioDay"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewThanhToanGioDay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32)dataRow["MaGiangVien"];
			entity.MaQuanLyGiangVien = (Convert.IsDBNull(dataRow["MaQuanLyGiangVien"]))?string.Empty:(System.String)dataRow["MaQuanLyGiangVien"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.HoTenHocHamHocVi = (Convert.IsDBNull(dataRow["HoTen_HocHam_HocVi"]))?string.Empty:(System.String)dataRow["HoTen_HocHam_HocVi"];
			entity.MaDonVi = (Convert.IsDBNull(dataRow["MaDonVi"]))?string.Empty:(System.String)dataRow["MaDonVi"];
			entity.MaLoaiGiangVien = (Convert.IsDBNull(dataRow["MaLoaiGiangVien"]))?(int)0:(System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.BacLuong = (Convert.IsDBNull(dataRow["BacLuong"]))?0.0m:(System.Decimal)dataRow["BacLuong"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.TietThucDay = (Convert.IsDBNull(dataRow["TietThucDay"]))?0.0m:(System.Decimal?)dataRow["TietThucDay"];
			entity.TietQuyDoi = (Convert.IsDBNull(dataRow["TietQuyDoi"]))?0.0m:(System.Decimal)dataRow["TietQuyDoi"];
			entity.TietNghiaVu = (Convert.IsDBNull(dataRow["TietNghiaVu"]))?(int)0:(System.Int32?)dataRow["TietNghiaVu"];
			entity.TietGioiHan = (Convert.IsDBNull(dataRow["TietGioiHan"]))?(int)0:(System.Int32?)dataRow["TietGioiHan"];
			entity.MaHocHamQuanLy = (Convert.IsDBNull(dataRow["MaHocHamQuanLy"]))?string.Empty:(System.String)dataRow["MaHocHamQuanLy"];
			entity.MaHocViQuanLy = (Convert.IsDBNull(dataRow["MaHocViQuanLy"]))?string.Empty:(System.String)dataRow["MaHocViQuanLy"];
			entity.TietTdTietQd = (Convert.IsDBNull(dataRow["TietTD_TietQD"]))?string.Empty:(System.String)dataRow["TietTD_TietQD"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewThanhToanGioDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThanhToanGioDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThanhToanGioDayFilterBuilder : SqlFilterBuilder<ViewThanhToanGioDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThanhToanGioDayFilterBuilder class.
		/// </summary>
		public ViewThanhToanGioDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThanhToanGioDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThanhToanGioDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThanhToanGioDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThanhToanGioDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThanhToanGioDayFilterBuilder

	#region ViewThanhToanGioDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThanhToanGioDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThanhToanGioDayParameterBuilder : ParameterizedSqlFilterBuilder<ViewThanhToanGioDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThanhToanGioDayParameterBuilder class.
		/// </summary>
		public ViewThanhToanGioDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThanhToanGioDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThanhToanGioDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThanhToanGioDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThanhToanGioDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThanhToanGioDayParameterBuilder
	
	#region ViewThanhToanGioDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThanhToanGioDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewThanhToanGioDaySortBuilder : SqlSortBuilder<ViewThanhToanGioDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThanhToanGioDaySqlSortBuilder class.
		/// </summary>
		public ViewThanhToanGioDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewThanhToanGioDaySortBuilder

} // end namespace
