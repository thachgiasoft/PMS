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
	/// This class is the base class for any <see cref="ViewTietNghiaVuTheoNamHocHocKyProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewTietNghiaVuTheoNamHocHocKyProviderBaseCore : EntityViewProviderBase<ViewTietNghiaVuTheoNamHocHocKy>
	{
		#region Custom Methods
		
		
		#region cust_View_TietNghiaVuTheoNamHocHocKy_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_TietNghiaVuTheoNamHocHocKy_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewTietNghiaVuTheoNamHocHocKy&gt;"/> instance.</returns>
		public VList<ViewTietNghiaVuTheoNamHocHocKy> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_TietNghiaVuTheoNamHocHocKy_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewTietNghiaVuTheoNamHocHocKy&gt;"/> instance.</returns>
		public VList<ViewTietNghiaVuTheoNamHocHocKy> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_TietNghiaVuTheoNamHocHocKy_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewTietNghiaVuTheoNamHocHocKy&gt;"/> instance.</returns>
		public VList<ViewTietNghiaVuTheoNamHocHocKy> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_TietNghiaVuTheoNamHocHocKy_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewTietNghiaVuTheoNamHocHocKy&gt;"/> instance.</returns>
		public abstract VList<ViewTietNghiaVuTheoNamHocHocKy> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#region cust_View_TietNghiaVuTheoNamHocHocKy_GetByNamHocGroupId
		
		/// <summary>
		///	This method wrap the 'cust_View_TietNghiaVuTheoNamHocHocKy_GetByNamHocGroupId' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="groupId"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocGroupId(System.String namHoc, System.String groupId)
		{
			return GetByNamHocGroupId(null, 0, int.MaxValue , namHoc, groupId);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_TietNghiaVuTheoNamHocHocKy_GetByNamHocGroupId' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="groupId"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocGroupId(int start, int pageLength, System.String namHoc, System.String groupId)
		{
			return GetByNamHocGroupId(null, start, pageLength , namHoc, groupId);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_TietNghiaVuTheoNamHocHocKy_GetByNamHocGroupId' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="groupId"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocGroupId(TransactionManager transactionManager, System.String namHoc, System.String groupId)
		{
			return GetByNamHocGroupId(transactionManager, 0, int.MaxValue , namHoc, groupId);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_TietNghiaVuTheoNamHocHocKy_GetByNamHocGroupId' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="groupId"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocGroupId(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String groupId);
		
		#endregion

		
		#region cust_View_TietNghiaVuTheoNamHocHocKy_GetByNamHoc
		
		/// <summary>
		///	This method wrap the 'cust_View_TietNghiaVuTheoNamHocHocKy_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewTietNghiaVuTheoNamHocHocKy&gt;"/> instance.</returns>
		public VList<ViewTietNghiaVuTheoNamHocHocKy> GetByNamHoc(System.String namHoc)
		{
			return GetByNamHoc(null, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_TietNghiaVuTheoNamHocHocKy_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewTietNghiaVuTheoNamHocHocKy&gt;"/> instance.</returns>
		public VList<ViewTietNghiaVuTheoNamHocHocKy> GetByNamHoc(int start, int pageLength, System.String namHoc)
		{
			return GetByNamHoc(null, start, pageLength , namHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_TietNghiaVuTheoNamHocHocKy_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewTietNghiaVuTheoNamHocHocKy&gt;"/> instance.</returns>
		public VList<ViewTietNghiaVuTheoNamHocHocKy> GetByNamHoc(TransactionManager transactionManager, System.String namHoc)
		{
			return GetByNamHoc(transactionManager, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_TietNghiaVuTheoNamHocHocKy_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewTietNghiaVuTheoNamHocHocKy&gt;"/> instance.</returns>
		public abstract VList<ViewTietNghiaVuTheoNamHocHocKy> GetByNamHoc(TransactionManager transactionManager, int start, int pageLength, System.String namHoc);
		
		#endregion

		
		#region cust_View_TietNghiaVuTheoNamHocHocKy_GetByNamHocCdgtvt
		
		/// <summary>
		///	This method wrap the 'cust_View_TietNghiaVuTheoNamHocHocKy_GetByNamHocCdgtvt' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocCdgtvt(System.String namHoc)
		{
			return GetByNamHocCdgtvt(null, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_TietNghiaVuTheoNamHocHocKy_GetByNamHocCdgtvt' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocCdgtvt(int start, int pageLength, System.String namHoc)
		{
			return GetByNamHocCdgtvt(null, start, pageLength , namHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_TietNghiaVuTheoNamHocHocKy_GetByNamHocCdgtvt' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocCdgtvt(TransactionManager transactionManager, System.String namHoc)
		{
			return GetByNamHocCdgtvt(transactionManager, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_TietNghiaVuTheoNamHocHocKy_GetByNamHocCdgtvt' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocCdgtvt(TransactionManager transactionManager, int start, int pageLength, System.String namHoc);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewTietNghiaVuTheoNamHocHocKy&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewTietNghiaVuTheoNamHocHocKy&gt;"/></returns>
		protected static VList&lt;ViewTietNghiaVuTheoNamHocHocKy&gt; Fill(DataSet dataSet, VList<ViewTietNghiaVuTheoNamHocHocKy> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewTietNghiaVuTheoNamHocHocKy>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewTietNghiaVuTheoNamHocHocKy&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewTietNghiaVuTheoNamHocHocKy>"/></returns>
		protected static VList&lt;ViewTietNghiaVuTheoNamHocHocKy&gt; Fill(DataTable dataTable, VList<ViewTietNghiaVuTheoNamHocHocKy> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewTietNghiaVuTheoNamHocHocKy c = new ViewTietNghiaVuTheoNamHocHocKy();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32?)row["MaGiangVien"];
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.Ho = (Convert.IsDBNull(row["Ho"]))?string.Empty:(System.String)row["Ho"];
					c.Ten = (Convert.IsDBNull(row["Ten"]))?string.Empty:(System.String)row["Ten"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.MaHocHam = (Convert.IsDBNull(row["MaHocHam"]))?(int)0:(System.Int32?)row["MaHocHam"];
					c.MaHocVi = (Convert.IsDBNull(row["MaHocVi"]))?(int)0:(System.Int32?)row["MaHocVi"];
					c.TenHocHam = (Convert.IsDBNull(row["TenHocHam"]))?string.Empty:(System.String)row["TenHocHam"];
					c.TenHocVi = (Convert.IsDBNull(row["TenHocVi"]))?string.Empty:(System.String)row["TenHocVi"];
					c.MaChucVu = (Convert.IsDBNull(row["MaChucVu"]))?(int)0:(System.Int32?)row["MaChucVu"];
					c.TenChucVu = (Convert.IsDBNull(row["TenChucVu"]))?string.Empty:(System.String)row["TenChucVu"];
					c.SoTietNghiaVu = (Convert.IsDBNull(row["SoTietNghiaVu"]))?0.0m:(System.Decimal?)row["SoTietNghiaVu"];
					c.PhanTramGiamTru = (Convert.IsDBNull(row["PhanTramGiamTru"]))?0.0m:(System.Decimal?)row["PhanTramGiamTru"];
					c.TietNghiaVuSauGiamTru = (Convert.IsDBNull(row["TietNghiaVuSauGiamTru"]))?0.0m:(System.Decimal?)row["TietNghiaVuSauGiamTru"];
					c.TietGioiHan = (Convert.IsDBNull(row["TietGioiHan"]))?0.0m:(System.Decimal?)row["TietGioiHan"];
					c.GhiChu = (Convert.IsDBNull(row["GhiChu"]))?false:(System.Boolean?)row["GhiChu"];
					c.GhiChu2 = (Convert.IsDBNull(row["GhiChu2"]))?string.Empty:(System.String)row["GhiChu2"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.NgayCapNhat = (Convert.IsDBNull(row["NgayCapNhat"]))?string.Empty:(System.String)row["NgayCapNhat"];
					c.NguoiCapNhat = (Convert.IsDBNull(row["NguoiCapNhat"]))?string.Empty:(System.String)row["NguoiCapNhat"];
					c.MaGiamTruKhac = (Convert.IsDBNull(row["MaGiamTruKhac"]))?(int)0:(System.Int32?)row["MaGiamTruKhac"];
					c.SoTietGiamTruKhac = (Convert.IsDBNull(row["SoTietGiamTruKhac"]))?0.0m:(System.Decimal?)row["SoTietGiamTruKhac"];
					c.TietNghiaVuCongTacKhac = (Convert.IsDBNull(row["TietNghiaVuCongTacKhac"]))?0.0m:(System.Decimal?)row["TietNghiaVuCongTacKhac"];
					c.TietNghiaVuCongTacKhacSauGiamTru = (Convert.IsDBNull(row["TietNghiaVuCongTacKhacSauGiamTru"]))?0.0m:(System.Decimal?)row["TietNghiaVuCongTacKhacSauGiamTru"];
					c.MaDonVi = (Convert.IsDBNull(row["MaDonVi"]))?string.Empty:(System.String)row["MaDonVi"];
					c.TenDonVi = (Convert.IsDBNull(row["TenDonVi"]))?string.Empty:(System.String)row["TenDonVi"];
					c.TenNgach = (Convert.IsDBNull(row["TenNgach"]))?string.Empty:(System.String)row["TenNgach"];
					c.ChucDanh = (Convert.IsDBNull(row["ChucDanh"]))?string.Empty:(System.String)row["ChucDanh"];
					c.PhanTramDuocGiam = (Convert.IsDBNull(row["PhanTramDuocGiam"]))?0.0m:(System.Decimal?)row["PhanTramDuocGiam"];
					c.CongPhanTramGiam = (Convert.IsDBNull(row["CongPhanTramGiam"]))?0.0m:(System.Decimal?)row["CongPhanTramGiam"];
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
		/// Fill an <see cref="VList&lt;ViewTietNghiaVuTheoNamHocHocKy&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewTietNghiaVuTheoNamHocHocKy&gt;"/></returns>
		protected VList<ViewTietNghiaVuTheoNamHocHocKy> Fill(IDataReader reader, VList<ViewTietNghiaVuTheoNamHocHocKy> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewTietNghiaVuTheoNamHocHocKy entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewTietNghiaVuTheoNamHocHocKy>("ViewTietNghiaVuTheoNamHocHocKy",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewTietNghiaVuTheoNamHocHocKy();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = reader.IsDBNull(reader.GetOrdinal("MaGiangVien")) ? null : (System.Int32?)reader["MaGiangVien"];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32?)reader["MaGiangVien"];
					entity.MaQuanLy = reader.IsDBNull(reader.GetOrdinal("MaQuanLy")) ? null : (System.String)reader["MaQuanLy"];
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
					entity.MaChucVu = reader.IsDBNull(reader.GetOrdinal("MaChucVu")) ? null : (System.Int32?)reader["MaChucVu"];
					//entity.MaChucVu = (Convert.IsDBNull(reader["MaChucVu"]))?(int)0:(System.Int32?)reader["MaChucVu"];
					entity.TenChucVu = reader.IsDBNull(reader.GetOrdinal("TenChucVu")) ? null : (System.String)reader["TenChucVu"];
					//entity.TenChucVu = (Convert.IsDBNull(reader["TenChucVu"]))?string.Empty:(System.String)reader["TenChucVu"];
					entity.SoTietNghiaVu = reader.IsDBNull(reader.GetOrdinal("SoTietNghiaVu")) ? null : (System.Decimal?)reader["SoTietNghiaVu"];
					//entity.SoTietNghiaVu = (Convert.IsDBNull(reader["SoTietNghiaVu"]))?0.0m:(System.Decimal?)reader["SoTietNghiaVu"];
					entity.PhanTramGiamTru = reader.IsDBNull(reader.GetOrdinal("PhanTramGiamTru")) ? null : (System.Decimal?)reader["PhanTramGiamTru"];
					//entity.PhanTramGiamTru = (Convert.IsDBNull(reader["PhanTramGiamTru"]))?0.0m:(System.Decimal?)reader["PhanTramGiamTru"];
					entity.TietNghiaVuSauGiamTru = reader.IsDBNull(reader.GetOrdinal("TietNghiaVuSauGiamTru")) ? null : (System.Decimal?)reader["TietNghiaVuSauGiamTru"];
					//entity.TietNghiaVuSauGiamTru = (Convert.IsDBNull(reader["TietNghiaVuSauGiamTru"]))?0.0m:(System.Decimal?)reader["TietNghiaVuSauGiamTru"];
					entity.TietGioiHan = reader.IsDBNull(reader.GetOrdinal("TietGioiHan")) ? null : (System.Decimal?)reader["TietGioiHan"];
					//entity.TietGioiHan = (Convert.IsDBNull(reader["TietGioiHan"]))?0.0m:(System.Decimal?)reader["TietGioiHan"];
					entity.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : (System.Boolean?)reader["GhiChu"];
					//entity.GhiChu = (Convert.IsDBNull(reader["GhiChu"]))?false:(System.Boolean?)reader["GhiChu"];
					entity.GhiChu2 = reader.IsDBNull(reader.GetOrdinal("GhiChu2")) ? null : (System.String)reader["GhiChu2"];
					//entity.GhiChu2 = (Convert.IsDBNull(reader["GhiChu2"]))?string.Empty:(System.String)reader["GhiChu2"];
					entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.NgayCapNhat = reader.IsDBNull(reader.GetOrdinal("NgayCapNhat")) ? null : (System.String)reader["NgayCapNhat"];
					//entity.NgayCapNhat = (Convert.IsDBNull(reader["NgayCapNhat"]))?string.Empty:(System.String)reader["NgayCapNhat"];
					entity.NguoiCapNhat = reader.IsDBNull(reader.GetOrdinal("NguoiCapNhat")) ? null : (System.String)reader["NguoiCapNhat"];
					//entity.NguoiCapNhat = (Convert.IsDBNull(reader["NguoiCapNhat"]))?string.Empty:(System.String)reader["NguoiCapNhat"];
					entity.MaGiamTruKhac = reader.IsDBNull(reader.GetOrdinal("MaGiamTruKhac")) ? null : (System.Int32?)reader["MaGiamTruKhac"];
					//entity.MaGiamTruKhac = (Convert.IsDBNull(reader["MaGiamTruKhac"]))?(int)0:(System.Int32?)reader["MaGiamTruKhac"];
					entity.SoTietGiamTruKhac = reader.IsDBNull(reader.GetOrdinal("SoTietGiamTruKhac")) ? null : (System.Decimal?)reader["SoTietGiamTruKhac"];
					//entity.SoTietGiamTruKhac = (Convert.IsDBNull(reader["SoTietGiamTruKhac"]))?0.0m:(System.Decimal?)reader["SoTietGiamTruKhac"];
					entity.TietNghiaVuCongTacKhac = reader.IsDBNull(reader.GetOrdinal("TietNghiaVuCongTacKhac")) ? null : (System.Decimal?)reader["TietNghiaVuCongTacKhac"];
					//entity.TietNghiaVuCongTacKhac = (Convert.IsDBNull(reader["TietNghiaVuCongTacKhac"]))?0.0m:(System.Decimal?)reader["TietNghiaVuCongTacKhac"];
					entity.TietNghiaVuCongTacKhacSauGiamTru = reader.IsDBNull(reader.GetOrdinal("TietNghiaVuCongTacKhacSauGiamTru")) ? null : (System.Decimal?)reader["TietNghiaVuCongTacKhacSauGiamTru"];
					//entity.TietNghiaVuCongTacKhacSauGiamTru = (Convert.IsDBNull(reader["TietNghiaVuCongTacKhacSauGiamTru"]))?0.0m:(System.Decimal?)reader["TietNghiaVuCongTacKhacSauGiamTru"];
					entity.MaDonVi = reader.IsDBNull(reader.GetOrdinal("MaDonVi")) ? null : (System.String)reader["MaDonVi"];
					//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
					entity.TenDonVi = reader.IsDBNull(reader.GetOrdinal("TenDonVi")) ? null : (System.String)reader["TenDonVi"];
					//entity.TenDonVi = (Convert.IsDBNull(reader["TenDonVi"]))?string.Empty:(System.String)reader["TenDonVi"];
					entity.TenNgach = reader.IsDBNull(reader.GetOrdinal("TenNgach")) ? null : (System.String)reader["TenNgach"];
					//entity.TenNgach = (Convert.IsDBNull(reader["TenNgach"]))?string.Empty:(System.String)reader["TenNgach"];
					entity.ChucDanh = reader.IsDBNull(reader.GetOrdinal("ChucDanh")) ? null : (System.String)reader["ChucDanh"];
					//entity.ChucDanh = (Convert.IsDBNull(reader["ChucDanh"]))?string.Empty:(System.String)reader["ChucDanh"];
					entity.PhanTramDuocGiam = reader.IsDBNull(reader.GetOrdinal("PhanTramDuocGiam")) ? null : (System.Decimal?)reader["PhanTramDuocGiam"];
					//entity.PhanTramDuocGiam = (Convert.IsDBNull(reader["PhanTramDuocGiam"]))?0.0m:(System.Decimal?)reader["PhanTramDuocGiam"];
					entity.CongPhanTramGiam = reader.IsDBNull(reader.GetOrdinal("CongPhanTramGiam")) ? null : (System.Decimal?)reader["CongPhanTramGiam"];
					//entity.CongPhanTramGiam = (Convert.IsDBNull(reader["CongPhanTramGiam"]))?0.0m:(System.Decimal?)reader["CongPhanTramGiam"];
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
		/// Refreshes the <see cref="ViewTietNghiaVuTheoNamHocHocKy"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewTietNghiaVuTheoNamHocHocKy"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewTietNghiaVuTheoNamHocHocKy entity)
		{
			reader.Read();
			entity.MaGiangVien = reader.IsDBNull(reader.GetOrdinal("MaGiangVien")) ? null : (System.Int32?)reader["MaGiangVien"];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32?)reader["MaGiangVien"];
			entity.MaQuanLy = reader.IsDBNull(reader.GetOrdinal("MaQuanLy")) ? null : (System.String)reader["MaQuanLy"];
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
			entity.MaChucVu = reader.IsDBNull(reader.GetOrdinal("MaChucVu")) ? null : (System.Int32?)reader["MaChucVu"];
			//entity.MaChucVu = (Convert.IsDBNull(reader["MaChucVu"]))?(int)0:(System.Int32?)reader["MaChucVu"];
			entity.TenChucVu = reader.IsDBNull(reader.GetOrdinal("TenChucVu")) ? null : (System.String)reader["TenChucVu"];
			//entity.TenChucVu = (Convert.IsDBNull(reader["TenChucVu"]))?string.Empty:(System.String)reader["TenChucVu"];
			entity.SoTietNghiaVu = reader.IsDBNull(reader.GetOrdinal("SoTietNghiaVu")) ? null : (System.Decimal?)reader["SoTietNghiaVu"];
			//entity.SoTietNghiaVu = (Convert.IsDBNull(reader["SoTietNghiaVu"]))?0.0m:(System.Decimal?)reader["SoTietNghiaVu"];
			entity.PhanTramGiamTru = reader.IsDBNull(reader.GetOrdinal("PhanTramGiamTru")) ? null : (System.Decimal?)reader["PhanTramGiamTru"];
			//entity.PhanTramGiamTru = (Convert.IsDBNull(reader["PhanTramGiamTru"]))?0.0m:(System.Decimal?)reader["PhanTramGiamTru"];
			entity.TietNghiaVuSauGiamTru = reader.IsDBNull(reader.GetOrdinal("TietNghiaVuSauGiamTru")) ? null : (System.Decimal?)reader["TietNghiaVuSauGiamTru"];
			//entity.TietNghiaVuSauGiamTru = (Convert.IsDBNull(reader["TietNghiaVuSauGiamTru"]))?0.0m:(System.Decimal?)reader["TietNghiaVuSauGiamTru"];
			entity.TietGioiHan = reader.IsDBNull(reader.GetOrdinal("TietGioiHan")) ? null : (System.Decimal?)reader["TietGioiHan"];
			//entity.TietGioiHan = (Convert.IsDBNull(reader["TietGioiHan"]))?0.0m:(System.Decimal?)reader["TietGioiHan"];
			entity.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : (System.Boolean?)reader["GhiChu"];
			//entity.GhiChu = (Convert.IsDBNull(reader["GhiChu"]))?false:(System.Boolean?)reader["GhiChu"];
			entity.GhiChu2 = reader.IsDBNull(reader.GetOrdinal("GhiChu2")) ? null : (System.String)reader["GhiChu2"];
			//entity.GhiChu2 = (Convert.IsDBNull(reader["GhiChu2"]))?string.Empty:(System.String)reader["GhiChu2"];
			entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.NgayCapNhat = reader.IsDBNull(reader.GetOrdinal("NgayCapNhat")) ? null : (System.String)reader["NgayCapNhat"];
			//entity.NgayCapNhat = (Convert.IsDBNull(reader["NgayCapNhat"]))?string.Empty:(System.String)reader["NgayCapNhat"];
			entity.NguoiCapNhat = reader.IsDBNull(reader.GetOrdinal("NguoiCapNhat")) ? null : (System.String)reader["NguoiCapNhat"];
			//entity.NguoiCapNhat = (Convert.IsDBNull(reader["NguoiCapNhat"]))?string.Empty:(System.String)reader["NguoiCapNhat"];
			entity.MaGiamTruKhac = reader.IsDBNull(reader.GetOrdinal("MaGiamTruKhac")) ? null : (System.Int32?)reader["MaGiamTruKhac"];
			//entity.MaGiamTruKhac = (Convert.IsDBNull(reader["MaGiamTruKhac"]))?(int)0:(System.Int32?)reader["MaGiamTruKhac"];
			entity.SoTietGiamTruKhac = reader.IsDBNull(reader.GetOrdinal("SoTietGiamTruKhac")) ? null : (System.Decimal?)reader["SoTietGiamTruKhac"];
			//entity.SoTietGiamTruKhac = (Convert.IsDBNull(reader["SoTietGiamTruKhac"]))?0.0m:(System.Decimal?)reader["SoTietGiamTruKhac"];
			entity.TietNghiaVuCongTacKhac = reader.IsDBNull(reader.GetOrdinal("TietNghiaVuCongTacKhac")) ? null : (System.Decimal?)reader["TietNghiaVuCongTacKhac"];
			//entity.TietNghiaVuCongTacKhac = (Convert.IsDBNull(reader["TietNghiaVuCongTacKhac"]))?0.0m:(System.Decimal?)reader["TietNghiaVuCongTacKhac"];
			entity.TietNghiaVuCongTacKhacSauGiamTru = reader.IsDBNull(reader.GetOrdinal("TietNghiaVuCongTacKhacSauGiamTru")) ? null : (System.Decimal?)reader["TietNghiaVuCongTacKhacSauGiamTru"];
			//entity.TietNghiaVuCongTacKhacSauGiamTru = (Convert.IsDBNull(reader["TietNghiaVuCongTacKhacSauGiamTru"]))?0.0m:(System.Decimal?)reader["TietNghiaVuCongTacKhacSauGiamTru"];
			entity.MaDonVi = reader.IsDBNull(reader.GetOrdinal("MaDonVi")) ? null : (System.String)reader["MaDonVi"];
			//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
			entity.TenDonVi = reader.IsDBNull(reader.GetOrdinal("TenDonVi")) ? null : (System.String)reader["TenDonVi"];
			//entity.TenDonVi = (Convert.IsDBNull(reader["TenDonVi"]))?string.Empty:(System.String)reader["TenDonVi"];
			entity.TenNgach = reader.IsDBNull(reader.GetOrdinal("TenNgach")) ? null : (System.String)reader["TenNgach"];
			//entity.TenNgach = (Convert.IsDBNull(reader["TenNgach"]))?string.Empty:(System.String)reader["TenNgach"];
			entity.ChucDanh = reader.IsDBNull(reader.GetOrdinal("ChucDanh")) ? null : (System.String)reader["ChucDanh"];
			//entity.ChucDanh = (Convert.IsDBNull(reader["ChucDanh"]))?string.Empty:(System.String)reader["ChucDanh"];
			entity.PhanTramDuocGiam = reader.IsDBNull(reader.GetOrdinal("PhanTramDuocGiam")) ? null : (System.Decimal?)reader["PhanTramDuocGiam"];
			//entity.PhanTramDuocGiam = (Convert.IsDBNull(reader["PhanTramDuocGiam"]))?0.0m:(System.Decimal?)reader["PhanTramDuocGiam"];
			entity.CongPhanTramGiam = reader.IsDBNull(reader.GetOrdinal("CongPhanTramGiam")) ? null : (System.Decimal?)reader["CongPhanTramGiam"];
			//entity.CongPhanTramGiam = (Convert.IsDBNull(reader["CongPhanTramGiam"]))?0.0m:(System.Decimal?)reader["CongPhanTramGiam"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewTietNghiaVuTheoNamHocHocKy"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewTietNghiaVuTheoNamHocHocKy"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewTietNghiaVuTheoNamHocHocKy entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32?)dataRow["MaGiangVien"];
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.Ho = (Convert.IsDBNull(dataRow["Ho"]))?string.Empty:(System.String)dataRow["Ho"];
			entity.Ten = (Convert.IsDBNull(dataRow["Ten"]))?string.Empty:(System.String)dataRow["Ten"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.MaHocHam = (Convert.IsDBNull(dataRow["MaHocHam"]))?(int)0:(System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = (Convert.IsDBNull(dataRow["MaHocVi"]))?(int)0:(System.Int32?)dataRow["MaHocVi"];
			entity.TenHocHam = (Convert.IsDBNull(dataRow["TenHocHam"]))?string.Empty:(System.String)dataRow["TenHocHam"];
			entity.TenHocVi = (Convert.IsDBNull(dataRow["TenHocVi"]))?string.Empty:(System.String)dataRow["TenHocVi"];
			entity.MaChucVu = (Convert.IsDBNull(dataRow["MaChucVu"]))?(int)0:(System.Int32?)dataRow["MaChucVu"];
			entity.TenChucVu = (Convert.IsDBNull(dataRow["TenChucVu"]))?string.Empty:(System.String)dataRow["TenChucVu"];
			entity.SoTietNghiaVu = (Convert.IsDBNull(dataRow["SoTietNghiaVu"]))?0.0m:(System.Decimal?)dataRow["SoTietNghiaVu"];
			entity.PhanTramGiamTru = (Convert.IsDBNull(dataRow["PhanTramGiamTru"]))?0.0m:(System.Decimal?)dataRow["PhanTramGiamTru"];
			entity.TietNghiaVuSauGiamTru = (Convert.IsDBNull(dataRow["TietNghiaVuSauGiamTru"]))?0.0m:(System.Decimal?)dataRow["TietNghiaVuSauGiamTru"];
			entity.TietGioiHan = (Convert.IsDBNull(dataRow["TietGioiHan"]))?0.0m:(System.Decimal?)dataRow["TietGioiHan"];
			entity.GhiChu = (Convert.IsDBNull(dataRow["GhiChu"]))?false:(System.Boolean?)dataRow["GhiChu"];
			entity.GhiChu2 = (Convert.IsDBNull(dataRow["GhiChu2"]))?string.Empty:(System.String)dataRow["GhiChu2"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.NgayCapNhat = (Convert.IsDBNull(dataRow["NgayCapNhat"]))?string.Empty:(System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = (Convert.IsDBNull(dataRow["NguoiCapNhat"]))?string.Empty:(System.String)dataRow["NguoiCapNhat"];
			entity.MaGiamTruKhac = (Convert.IsDBNull(dataRow["MaGiamTruKhac"]))?(int)0:(System.Int32?)dataRow["MaGiamTruKhac"];
			entity.SoTietGiamTruKhac = (Convert.IsDBNull(dataRow["SoTietGiamTruKhac"]))?0.0m:(System.Decimal?)dataRow["SoTietGiamTruKhac"];
			entity.TietNghiaVuCongTacKhac = (Convert.IsDBNull(dataRow["TietNghiaVuCongTacKhac"]))?0.0m:(System.Decimal?)dataRow["TietNghiaVuCongTacKhac"];
			entity.TietNghiaVuCongTacKhacSauGiamTru = (Convert.IsDBNull(dataRow["TietNghiaVuCongTacKhacSauGiamTru"]))?0.0m:(System.Decimal?)dataRow["TietNghiaVuCongTacKhacSauGiamTru"];
			entity.MaDonVi = (Convert.IsDBNull(dataRow["MaDonVi"]))?string.Empty:(System.String)dataRow["MaDonVi"];
			entity.TenDonVi = (Convert.IsDBNull(dataRow["TenDonVi"]))?string.Empty:(System.String)dataRow["TenDonVi"];
			entity.TenNgach = (Convert.IsDBNull(dataRow["TenNgach"]))?string.Empty:(System.String)dataRow["TenNgach"];
			entity.ChucDanh = (Convert.IsDBNull(dataRow["ChucDanh"]))?string.Empty:(System.String)dataRow["ChucDanh"];
			entity.PhanTramDuocGiam = (Convert.IsDBNull(dataRow["PhanTramDuocGiam"]))?0.0m:(System.Decimal?)dataRow["PhanTramDuocGiam"];
			entity.CongPhanTramGiam = (Convert.IsDBNull(dataRow["CongPhanTramGiam"]))?0.0m:(System.Decimal?)dataRow["CongPhanTramGiam"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewTietNghiaVuTheoNamHocHocKyFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTietNghiaVuTheoNamHocHocKy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTietNghiaVuTheoNamHocHocKyFilterBuilder : SqlFilterBuilder<ViewTietNghiaVuTheoNamHocHocKyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTietNghiaVuTheoNamHocHocKyFilterBuilder class.
		/// </summary>
		public ViewTietNghiaVuTheoNamHocHocKyFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewTietNghiaVuTheoNamHocHocKyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewTietNghiaVuTheoNamHocHocKyFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewTietNghiaVuTheoNamHocHocKyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewTietNghiaVuTheoNamHocHocKyFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewTietNghiaVuTheoNamHocHocKyFilterBuilder

	#region ViewTietNghiaVuTheoNamHocHocKyParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTietNghiaVuTheoNamHocHocKy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTietNghiaVuTheoNamHocHocKyParameterBuilder : ParameterizedSqlFilterBuilder<ViewTietNghiaVuTheoNamHocHocKyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTietNghiaVuTheoNamHocHocKyParameterBuilder class.
		/// </summary>
		public ViewTietNghiaVuTheoNamHocHocKyParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewTietNghiaVuTheoNamHocHocKyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewTietNghiaVuTheoNamHocHocKyParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewTietNghiaVuTheoNamHocHocKyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewTietNghiaVuTheoNamHocHocKyParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewTietNghiaVuTheoNamHocHocKyParameterBuilder
	
	#region ViewTietNghiaVuTheoNamHocHocKySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTietNghiaVuTheoNamHocHocKy"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewTietNghiaVuTheoNamHocHocKySortBuilder : SqlSortBuilder<ViewTietNghiaVuTheoNamHocHocKyColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTietNghiaVuTheoNamHocHocKySqlSortBuilder class.
		/// </summary>
		public ViewTietNghiaVuTheoNamHocHocKySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewTietNghiaVuTheoNamHocHocKySortBuilder

} // end namespace
