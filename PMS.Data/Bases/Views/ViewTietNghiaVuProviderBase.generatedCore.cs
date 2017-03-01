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
	/// This class is the base class for any <see cref="ViewTietNghiaVuProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewTietNghiaVuProviderBaseCore : EntityViewProviderBase<ViewTietNghiaVu>
	{
		#region Custom Methods
		
		
		#region cust_View_TietNghiaVu_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_TietNghiaVu_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewTietNghiaVu&gt;"/> instance.</returns>
		public VList<ViewTietNghiaVu> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_TietNghiaVu_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewTietNghiaVu&gt;"/> instance.</returns>
		public VList<ViewTietNghiaVu> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_TietNghiaVu_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewTietNghiaVu&gt;"/> instance.</returns>
		public VList<ViewTietNghiaVu> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_TietNghiaVu_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewTietNghiaVu&gt;"/> instance.</returns>
		public abstract VList<ViewTietNghiaVu> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewTietNghiaVu&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewTietNghiaVu&gt;"/></returns>
		protected static VList&lt;ViewTietNghiaVu&gt; Fill(DataSet dataSet, VList<ViewTietNghiaVu> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewTietNghiaVu>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewTietNghiaVu&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewTietNghiaVu>"/></returns>
		protected static VList&lt;ViewTietNghiaVu&gt; Fill(DataTable dataTable, VList<ViewTietNghiaVu> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewTietNghiaVu c = new ViewTietNghiaVu();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32)row["MaGiangVien"];
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.Ho = (Convert.IsDBNull(row["Ho"]))?string.Empty:(System.String)row["Ho"];
					c.Ten = (Convert.IsDBNull(row["Ten"]))?string.Empty:(System.String)row["Ten"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.MaHocHam = (Convert.IsDBNull(row["MaHocHam"]))?(int)0:(System.Int32?)row["MaHocHam"];
					c.MaHocVi = (Convert.IsDBNull(row["MaHocVi"]))?(int)0:(System.Int32?)row["MaHocVi"];
					c.TenHocHam = (Convert.IsDBNull(row["TenHocHam"]))?string.Empty:(System.String)row["TenHocHam"];
					c.TenHocVi = (Convert.IsDBNull(row["TenHocVi"]))?string.Empty:(System.String)row["TenHocVi"];
					c.SoTietNghiaVu = (Convert.IsDBNull(row["SoTietNghiaVu"]))?0.0m:(System.Decimal?)row["SoTietNghiaVu"];
					c.GhiChu = (Convert.IsDBNull(row["GhiChu"]))?false:(System.Boolean?)row["GhiChu"];
					c.NgayCapNhat = (Convert.IsDBNull(row["NgayCapNhat"]))?string.Empty:(System.String)row["NgayCapNhat"];
					c.TietGioiHan = (Convert.IsDBNull(row["TietGioiHan"]))?0.0m:(System.Decimal?)row["TietGioiHan"];
					c.GhiChu2 = (Convert.IsDBNull(row["GhiChu2"]))?string.Empty:(System.String)row["GhiChu2"];
					c.NguoiCapNhat = (Convert.IsDBNull(row["NguoiCapNhat"]))?string.Empty:(System.String)row["NguoiCapNhat"];
					c.MaDonVi = (Convert.IsDBNull(row["MaDonVi"]))?string.Empty:(System.String)row["MaDonVi"];
					c.TenDonVi = (Convert.IsDBNull(row["TenDonVi"]))?string.Empty:(System.String)row["TenDonVi"];
					c.DinhMucTietNghiaVuCaNam = (Convert.IsDBNull(row["DinhMucTietNghiaVuCaNam"]))?0.0m:(System.Decimal?)row["DinhMucTietNghiaVuCaNam"];
					c.MaChucVu = (Convert.IsDBNull(row["MaChucVu"]))?(int)0:(System.Int32?)row["MaChucVu"];
					c.TenChucVu = (Convert.IsDBNull(row["TenChucVu"]))?string.Empty:(System.String)row["TenChucVu"];
					c.TenTinhTrang = (Convert.IsDBNull(row["TenTinhTrang"]))?string.Empty:(System.String)row["TenTinhTrang"];
					c.TenHocHamHrm = (Convert.IsDBNull(row["TenHocHamHrm"]))?string.Empty:(System.String)row["TenHocHamHrm"];
					c.TenHocViHrm = (Convert.IsDBNull(row["TenHocViHrm"]))?string.Empty:(System.String)row["TenHocViHrm"];
					c.TenChucVuHrm = (Convert.IsDBNull(row["TenChucVuHrm"]))?string.Empty:(System.String)row["TenChucVuHrm"];
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
		/// Fill an <see cref="VList&lt;ViewTietNghiaVu&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewTietNghiaVu&gt;"/></returns>
		protected VList<ViewTietNghiaVu> Fill(IDataReader reader, VList<ViewTietNghiaVu> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewTietNghiaVu entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewTietNghiaVu>("ViewTietNghiaVu",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewTietNghiaVu();
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
					entity.MaHocHam = reader.IsDBNull(reader.GetOrdinal("MaHocHam")) ? null : (System.Int32?)reader["MaHocHam"];
					//entity.MaHocHam = (Convert.IsDBNull(reader["MaHocHam"]))?(int)0:(System.Int32?)reader["MaHocHam"];
					entity.MaHocVi = reader.IsDBNull(reader.GetOrdinal("MaHocVi")) ? null : (System.Int32?)reader["MaHocVi"];
					//entity.MaHocVi = (Convert.IsDBNull(reader["MaHocVi"]))?(int)0:(System.Int32?)reader["MaHocVi"];
					entity.TenHocHam = reader.IsDBNull(reader.GetOrdinal("TenHocHam")) ? null : (System.String)reader["TenHocHam"];
					//entity.TenHocHam = (Convert.IsDBNull(reader["TenHocHam"]))?string.Empty:(System.String)reader["TenHocHam"];
					entity.TenHocVi = reader.IsDBNull(reader.GetOrdinal("TenHocVi")) ? null : (System.String)reader["TenHocVi"];
					//entity.TenHocVi = (Convert.IsDBNull(reader["TenHocVi"]))?string.Empty:(System.String)reader["TenHocVi"];
					entity.SoTietNghiaVu = reader.IsDBNull(reader.GetOrdinal("SoTietNghiaVu")) ? null : (System.Decimal?)reader["SoTietNghiaVu"];
					//entity.SoTietNghiaVu = (Convert.IsDBNull(reader["SoTietNghiaVu"]))?0.0m:(System.Decimal?)reader["SoTietNghiaVu"];
					entity.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : (System.Boolean?)reader["GhiChu"];
					//entity.GhiChu = (Convert.IsDBNull(reader["GhiChu"]))?false:(System.Boolean?)reader["GhiChu"];
					entity.NgayCapNhat = reader.IsDBNull(reader.GetOrdinal("NgayCapNhat")) ? null : (System.String)reader["NgayCapNhat"];
					//entity.NgayCapNhat = (Convert.IsDBNull(reader["NgayCapNhat"]))?string.Empty:(System.String)reader["NgayCapNhat"];
					entity.TietGioiHan = reader.IsDBNull(reader.GetOrdinal("TietGioiHan")) ? null : (System.Decimal?)reader["TietGioiHan"];
					//entity.TietGioiHan = (Convert.IsDBNull(reader["TietGioiHan"]))?0.0m:(System.Decimal?)reader["TietGioiHan"];
					entity.GhiChu2 = (System.String)reader["GhiChu2"];
					//entity.GhiChu2 = (Convert.IsDBNull(reader["GhiChu2"]))?string.Empty:(System.String)reader["GhiChu2"];
					entity.NguoiCapNhat = reader.IsDBNull(reader.GetOrdinal("NguoiCapNhat")) ? null : (System.String)reader["NguoiCapNhat"];
					//entity.NguoiCapNhat = (Convert.IsDBNull(reader["NguoiCapNhat"]))?string.Empty:(System.String)reader["NguoiCapNhat"];
					entity.MaDonVi = reader.IsDBNull(reader.GetOrdinal("MaDonVi")) ? null : (System.String)reader["MaDonVi"];
					//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
					entity.TenDonVi = reader.IsDBNull(reader.GetOrdinal("TenDonVi")) ? null : (System.String)reader["TenDonVi"];
					//entity.TenDonVi = (Convert.IsDBNull(reader["TenDonVi"]))?string.Empty:(System.String)reader["TenDonVi"];
					entity.DinhMucTietNghiaVuCaNam = reader.IsDBNull(reader.GetOrdinal("DinhMucTietNghiaVuCaNam")) ? null : (System.Decimal?)reader["DinhMucTietNghiaVuCaNam"];
					//entity.DinhMucTietNghiaVuCaNam = (Convert.IsDBNull(reader["DinhMucTietNghiaVuCaNam"]))?0.0m:(System.Decimal?)reader["DinhMucTietNghiaVuCaNam"];
					entity.MaChucVu = reader.IsDBNull(reader.GetOrdinal("MaChucVu")) ? null : (System.Int32?)reader["MaChucVu"];
					//entity.MaChucVu = (Convert.IsDBNull(reader["MaChucVu"]))?(int)0:(System.Int32?)reader["MaChucVu"];
					entity.TenChucVu = reader.IsDBNull(reader.GetOrdinal("TenChucVu")) ? null : (System.String)reader["TenChucVu"];
					//entity.TenChucVu = (Convert.IsDBNull(reader["TenChucVu"]))?string.Empty:(System.String)reader["TenChucVu"];
					entity.TenTinhTrang = reader.IsDBNull(reader.GetOrdinal("TenTinhTrang")) ? null : (System.String)reader["TenTinhTrang"];
					//entity.TenTinhTrang = (Convert.IsDBNull(reader["TenTinhTrang"]))?string.Empty:(System.String)reader["TenTinhTrang"];
					entity.TenHocHamHrm = reader.IsDBNull(reader.GetOrdinal("TenHocHamHrm")) ? null : (System.String)reader["TenHocHamHrm"];
					//entity.TenHocHamHrm = (Convert.IsDBNull(reader["TenHocHamHrm"]))?string.Empty:(System.String)reader["TenHocHamHrm"];
					entity.TenHocViHrm = reader.IsDBNull(reader.GetOrdinal("TenHocViHrm")) ? null : (System.String)reader["TenHocViHrm"];
					//entity.TenHocViHrm = (Convert.IsDBNull(reader["TenHocViHrm"]))?string.Empty:(System.String)reader["TenHocViHrm"];
					entity.TenChucVuHrm = reader.IsDBNull(reader.GetOrdinal("TenChucVuHrm")) ? null : (System.String)reader["TenChucVuHrm"];
					//entity.TenChucVuHrm = (Convert.IsDBNull(reader["TenChucVuHrm"]))?string.Empty:(System.String)reader["TenChucVuHrm"];
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
		/// Refreshes the <see cref="ViewTietNghiaVu"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewTietNghiaVu"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewTietNghiaVu entity)
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
			entity.MaHocHam = reader.IsDBNull(reader.GetOrdinal("MaHocHam")) ? null : (System.Int32?)reader["MaHocHam"];
			//entity.MaHocHam = (Convert.IsDBNull(reader["MaHocHam"]))?(int)0:(System.Int32?)reader["MaHocHam"];
			entity.MaHocVi = reader.IsDBNull(reader.GetOrdinal("MaHocVi")) ? null : (System.Int32?)reader["MaHocVi"];
			//entity.MaHocVi = (Convert.IsDBNull(reader["MaHocVi"]))?(int)0:(System.Int32?)reader["MaHocVi"];
			entity.TenHocHam = reader.IsDBNull(reader.GetOrdinal("TenHocHam")) ? null : (System.String)reader["TenHocHam"];
			//entity.TenHocHam = (Convert.IsDBNull(reader["TenHocHam"]))?string.Empty:(System.String)reader["TenHocHam"];
			entity.TenHocVi = reader.IsDBNull(reader.GetOrdinal("TenHocVi")) ? null : (System.String)reader["TenHocVi"];
			//entity.TenHocVi = (Convert.IsDBNull(reader["TenHocVi"]))?string.Empty:(System.String)reader["TenHocVi"];
			entity.SoTietNghiaVu = reader.IsDBNull(reader.GetOrdinal("SoTietNghiaVu")) ? null : (System.Decimal?)reader["SoTietNghiaVu"];
			//entity.SoTietNghiaVu = (Convert.IsDBNull(reader["SoTietNghiaVu"]))?0.0m:(System.Decimal?)reader["SoTietNghiaVu"];
			entity.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : (System.Boolean?)reader["GhiChu"];
			//entity.GhiChu = (Convert.IsDBNull(reader["GhiChu"]))?false:(System.Boolean?)reader["GhiChu"];
			entity.NgayCapNhat = reader.IsDBNull(reader.GetOrdinal("NgayCapNhat")) ? null : (System.String)reader["NgayCapNhat"];
			//entity.NgayCapNhat = (Convert.IsDBNull(reader["NgayCapNhat"]))?string.Empty:(System.String)reader["NgayCapNhat"];
			entity.TietGioiHan = reader.IsDBNull(reader.GetOrdinal("TietGioiHan")) ? null : (System.Decimal?)reader["TietGioiHan"];
			//entity.TietGioiHan = (Convert.IsDBNull(reader["TietGioiHan"]))?0.0m:(System.Decimal?)reader["TietGioiHan"];
			entity.GhiChu2 = (System.String)reader["GhiChu2"];
			//entity.GhiChu2 = (Convert.IsDBNull(reader["GhiChu2"]))?string.Empty:(System.String)reader["GhiChu2"];
			entity.NguoiCapNhat = reader.IsDBNull(reader.GetOrdinal("NguoiCapNhat")) ? null : (System.String)reader["NguoiCapNhat"];
			//entity.NguoiCapNhat = (Convert.IsDBNull(reader["NguoiCapNhat"]))?string.Empty:(System.String)reader["NguoiCapNhat"];
			entity.MaDonVi = reader.IsDBNull(reader.GetOrdinal("MaDonVi")) ? null : (System.String)reader["MaDonVi"];
			//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
			entity.TenDonVi = reader.IsDBNull(reader.GetOrdinal("TenDonVi")) ? null : (System.String)reader["TenDonVi"];
			//entity.TenDonVi = (Convert.IsDBNull(reader["TenDonVi"]))?string.Empty:(System.String)reader["TenDonVi"];
			entity.DinhMucTietNghiaVuCaNam = reader.IsDBNull(reader.GetOrdinal("DinhMucTietNghiaVuCaNam")) ? null : (System.Decimal?)reader["DinhMucTietNghiaVuCaNam"];
			//entity.DinhMucTietNghiaVuCaNam = (Convert.IsDBNull(reader["DinhMucTietNghiaVuCaNam"]))?0.0m:(System.Decimal?)reader["DinhMucTietNghiaVuCaNam"];
			entity.MaChucVu = reader.IsDBNull(reader.GetOrdinal("MaChucVu")) ? null : (System.Int32?)reader["MaChucVu"];
			//entity.MaChucVu = (Convert.IsDBNull(reader["MaChucVu"]))?(int)0:(System.Int32?)reader["MaChucVu"];
			entity.TenChucVu = reader.IsDBNull(reader.GetOrdinal("TenChucVu")) ? null : (System.String)reader["TenChucVu"];
			//entity.TenChucVu = (Convert.IsDBNull(reader["TenChucVu"]))?string.Empty:(System.String)reader["TenChucVu"];
			entity.TenTinhTrang = reader.IsDBNull(reader.GetOrdinal("TenTinhTrang")) ? null : (System.String)reader["TenTinhTrang"];
			//entity.TenTinhTrang = (Convert.IsDBNull(reader["TenTinhTrang"]))?string.Empty:(System.String)reader["TenTinhTrang"];
			entity.TenHocHamHrm = reader.IsDBNull(reader.GetOrdinal("TenHocHamHrm")) ? null : (System.String)reader["TenHocHamHrm"];
			//entity.TenHocHamHrm = (Convert.IsDBNull(reader["TenHocHamHrm"]))?string.Empty:(System.String)reader["TenHocHamHrm"];
			entity.TenHocViHrm = reader.IsDBNull(reader.GetOrdinal("TenHocViHrm")) ? null : (System.String)reader["TenHocViHrm"];
			//entity.TenHocViHrm = (Convert.IsDBNull(reader["TenHocViHrm"]))?string.Empty:(System.String)reader["TenHocViHrm"];
			entity.TenChucVuHrm = reader.IsDBNull(reader.GetOrdinal("TenChucVuHrm")) ? null : (System.String)reader["TenChucVuHrm"];
			//entity.TenChucVuHrm = (Convert.IsDBNull(reader["TenChucVuHrm"]))?string.Empty:(System.String)reader["TenChucVuHrm"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewTietNghiaVu"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewTietNghiaVu"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewTietNghiaVu entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32)dataRow["MaGiangVien"];
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.Ho = (Convert.IsDBNull(dataRow["Ho"]))?string.Empty:(System.String)dataRow["Ho"];
			entity.Ten = (Convert.IsDBNull(dataRow["Ten"]))?string.Empty:(System.String)dataRow["Ten"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.MaHocHam = (Convert.IsDBNull(dataRow["MaHocHam"]))?(int)0:(System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = (Convert.IsDBNull(dataRow["MaHocVi"]))?(int)0:(System.Int32?)dataRow["MaHocVi"];
			entity.TenHocHam = (Convert.IsDBNull(dataRow["TenHocHam"]))?string.Empty:(System.String)dataRow["TenHocHam"];
			entity.TenHocVi = (Convert.IsDBNull(dataRow["TenHocVi"]))?string.Empty:(System.String)dataRow["TenHocVi"];
			entity.SoTietNghiaVu = (Convert.IsDBNull(dataRow["SoTietNghiaVu"]))?0.0m:(System.Decimal?)dataRow["SoTietNghiaVu"];
			entity.GhiChu = (Convert.IsDBNull(dataRow["GhiChu"]))?false:(System.Boolean?)dataRow["GhiChu"];
			entity.NgayCapNhat = (Convert.IsDBNull(dataRow["NgayCapNhat"]))?string.Empty:(System.String)dataRow["NgayCapNhat"];
			entity.TietGioiHan = (Convert.IsDBNull(dataRow["TietGioiHan"]))?0.0m:(System.Decimal?)dataRow["TietGioiHan"];
			entity.GhiChu2 = (Convert.IsDBNull(dataRow["GhiChu2"]))?string.Empty:(System.String)dataRow["GhiChu2"];
			entity.NguoiCapNhat = (Convert.IsDBNull(dataRow["NguoiCapNhat"]))?string.Empty:(System.String)dataRow["NguoiCapNhat"];
			entity.MaDonVi = (Convert.IsDBNull(dataRow["MaDonVi"]))?string.Empty:(System.String)dataRow["MaDonVi"];
			entity.TenDonVi = (Convert.IsDBNull(dataRow["TenDonVi"]))?string.Empty:(System.String)dataRow["TenDonVi"];
			entity.DinhMucTietNghiaVuCaNam = (Convert.IsDBNull(dataRow["DinhMucTietNghiaVuCaNam"]))?0.0m:(System.Decimal?)dataRow["DinhMucTietNghiaVuCaNam"];
			entity.MaChucVu = (Convert.IsDBNull(dataRow["MaChucVu"]))?(int)0:(System.Int32?)dataRow["MaChucVu"];
			entity.TenChucVu = (Convert.IsDBNull(dataRow["TenChucVu"]))?string.Empty:(System.String)dataRow["TenChucVu"];
			entity.TenTinhTrang = (Convert.IsDBNull(dataRow["TenTinhTrang"]))?string.Empty:(System.String)dataRow["TenTinhTrang"];
			entity.TenHocHamHrm = (Convert.IsDBNull(dataRow["TenHocHamHrm"]))?string.Empty:(System.String)dataRow["TenHocHamHrm"];
			entity.TenHocViHrm = (Convert.IsDBNull(dataRow["TenHocViHrm"]))?string.Empty:(System.String)dataRow["TenHocViHrm"];
			entity.TenChucVuHrm = (Convert.IsDBNull(dataRow["TenChucVuHrm"]))?string.Empty:(System.String)dataRow["TenChucVuHrm"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewTietNghiaVuFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTietNghiaVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTietNghiaVuFilterBuilder : SqlFilterBuilder<ViewTietNghiaVuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTietNghiaVuFilterBuilder class.
		/// </summary>
		public ViewTietNghiaVuFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewTietNghiaVuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewTietNghiaVuFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewTietNghiaVuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewTietNghiaVuFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewTietNghiaVuFilterBuilder

	#region ViewTietNghiaVuParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTietNghiaVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTietNghiaVuParameterBuilder : ParameterizedSqlFilterBuilder<ViewTietNghiaVuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTietNghiaVuParameterBuilder class.
		/// </summary>
		public ViewTietNghiaVuParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewTietNghiaVuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewTietNghiaVuParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewTietNghiaVuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewTietNghiaVuParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewTietNghiaVuParameterBuilder
	
	#region ViewTietNghiaVuSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTietNghiaVu"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewTietNghiaVuSortBuilder : SqlSortBuilder<ViewTietNghiaVuColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTietNghiaVuSqlSortBuilder class.
		/// </summary>
		public ViewTietNghiaVuSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewTietNghiaVuSortBuilder

} // end namespace
