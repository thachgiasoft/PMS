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
	/// This class is the base class for any <see cref="ViewTinhKhoiLuongProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewTinhKhoiLuongProviderBaseCore : EntityViewProviderBase<ViewTinhKhoiLuong>
	{
		#region Custom Methods
		
		
		#region cust_View_Tinh_KhoiLuong_GetByNamHocHocKyMaGiangVien
		
		/// <summary>
		///	This method wrap the 'cust_View_Tinh_KhoiLuong_GetByNamHocHocKyMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewTinhKhoiLuong&gt;"/> instance.</returns>
		public VList<ViewTinhKhoiLuong> GetByNamHocHocKyMaGiangVien(System.String namHoc, System.String hocKy, System.Int32 maGiangVien)
		{
			return GetByNamHocHocKyMaGiangVien(null, 0, int.MaxValue , namHoc, hocKy, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Tinh_KhoiLuong_GetByNamHocHocKyMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewTinhKhoiLuong&gt;"/> instance.</returns>
		public VList<ViewTinhKhoiLuong> GetByNamHocHocKyMaGiangVien(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 maGiangVien)
		{
			return GetByNamHocHocKyMaGiangVien(null, start, pageLength , namHoc, hocKy, maGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_Tinh_KhoiLuong_GetByNamHocHocKyMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewTinhKhoiLuong&gt;"/> instance.</returns>
		public VList<ViewTinhKhoiLuong> GetByNamHocHocKyMaGiangVien(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 maGiangVien)
		{
			return GetByNamHocHocKyMaGiangVien(transactionManager, 0, int.MaxValue , namHoc, hocKy, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Tinh_KhoiLuong_GetByNamHocHocKyMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewTinhKhoiLuong&gt;"/> instance.</returns>
		public abstract VList<ViewTinhKhoiLuong> GetByNamHocHocKyMaGiangVien(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 maGiangVien);
		
		#endregion

		
		#region cust_View_Tinh_KhoiLuong_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_Tinh_KhoiLuong_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewTinhKhoiLuong&gt;"/> instance.</returns>
		public VList<ViewTinhKhoiLuong> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Tinh_KhoiLuong_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewTinhKhoiLuong&gt;"/> instance.</returns>
		public VList<ViewTinhKhoiLuong> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_Tinh_KhoiLuong_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewTinhKhoiLuong&gt;"/> instance.</returns>
		public VList<ViewTinhKhoiLuong> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Tinh_KhoiLuong_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewTinhKhoiLuong&gt;"/> instance.</returns>
		public abstract VList<ViewTinhKhoiLuong> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#region cust_View_Tinh_KhoiLuong_TungTuan_GetByTuNgayDenNgay
		
		/// <summary>
		///	This method wrap the 'cust_View_Tinh_KhoiLuong_TungTuan_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader TungTuan_GetByTuNgayDenNgay(System.DateTime tuNgay, System.DateTime denNgay)
		{
			return TungTuan_GetByTuNgayDenNgay(null, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Tinh_KhoiLuong_TungTuan_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader TungTuan_GetByTuNgayDenNgay(int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return TungTuan_GetByTuNgayDenNgay(null, start, pageLength , tuNgay, denNgay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_Tinh_KhoiLuong_TungTuan_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader TungTuan_GetByTuNgayDenNgay(TransactionManager transactionManager, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return TungTuan_GetByTuNgayDenNgay(transactionManager, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Tinh_KhoiLuong_TungTuan_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader TungTuan_GetByTuNgayDenNgay(TransactionManager transactionManager, int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewTinhKhoiLuong&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewTinhKhoiLuong&gt;"/></returns>
		protected static VList&lt;ViewTinhKhoiLuong&gt; Fill(DataSet dataSet, VList<ViewTinhKhoiLuong> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewTinhKhoiLuong>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewTinhKhoiLuong&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewTinhKhoiLuong>"/></returns>
		protected static VList&lt;ViewTinhKhoiLuong&gt; Fill(DataTable dataTable, VList<ViewTinhKhoiLuong> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewTinhKhoiLuong c = new ViewTinhKhoiLuong();
					c.MaKetQua = (Convert.IsDBNull(row["MaKetQua"]))?(int)0:(System.Int32)row["MaKetQua"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32)row["MaGiangVien"];
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.TietQuyDoi = (Convert.IsDBNull(row["TietQuyDoi"]))?0.0m:(System.Decimal?)row["TietQuyDoi"];
					c.TrongGio = (Convert.IsDBNull(row["TrongGio"]))?0.0m:(System.Decimal?)row["TrongGio"];
					c.NgoaiGio = (Convert.IsDBNull(row["NgoaiGio"]))?0.0m:(System.Decimal?)row["NgoaiGio"];
					c.TietDoAn = (Convert.IsDBNull(row["TietDoAn"]))?0.0m:(System.Decimal?)row["TietDoAn"];
					c.TietNghiaVu = (Convert.IsDBNull(row["TietNghiaVu"]))?(int)0:(System.Int32?)row["TietNghiaVu"];
					c.TietGioiHan = (Convert.IsDBNull(row["TietGioiHan"]))?(int)0:(System.Int32?)row["TietGioiHan"];
					c.DonGia = (Convert.IsDBNull(row["DonGia"]))?0.0m:(System.Decimal?)row["DonGia"];
					c.TietThieu = (Convert.IsDBNull(row["TietThieu"]))?0.0m:(System.Decimal?)row["TietThieu"];
					c.TietVuot = (Convert.IsDBNull(row["TietVuot"]))?0.0m:(System.Decimal?)row["TietVuot"];
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
		/// Fill an <see cref="VList&lt;ViewTinhKhoiLuong&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewTinhKhoiLuong&gt;"/></returns>
		protected VList<ViewTinhKhoiLuong> Fill(IDataReader reader, VList<ViewTinhKhoiLuong> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewTinhKhoiLuong entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewTinhKhoiLuong>("ViewTinhKhoiLuong",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewTinhKhoiLuong();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaKetQua = (System.Int32)reader["MaKetQua"];
					//entity.MaKetQua = (Convert.IsDBNull(reader["MaKetQua"]))?(int)0:(System.Int32)reader["MaKetQua"];
					entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.MaGiangVien = (System.Int32)reader["MaGiangVien"];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
					entity.MaQuanLy = (System.String)reader["MaQuanLy"];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.TietQuyDoi = reader.IsDBNull(reader.GetOrdinal("TietQuyDoi")) ? null : (System.Decimal?)reader["TietQuyDoi"];
					//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal?)reader["TietQuyDoi"];
					entity.TrongGio = reader.IsDBNull(reader.GetOrdinal("TrongGio")) ? null : (System.Decimal?)reader["TrongGio"];
					//entity.TrongGio = (Convert.IsDBNull(reader["TrongGio"]))?0.0m:(System.Decimal?)reader["TrongGio"];
					entity.NgoaiGio = reader.IsDBNull(reader.GetOrdinal("NgoaiGio")) ? null : (System.Decimal?)reader["NgoaiGio"];
					//entity.NgoaiGio = (Convert.IsDBNull(reader["NgoaiGio"]))?0.0m:(System.Decimal?)reader["NgoaiGio"];
					entity.TietDoAn = reader.IsDBNull(reader.GetOrdinal("TietDoAn")) ? null : (System.Decimal?)reader["TietDoAn"];
					//entity.TietDoAn = (Convert.IsDBNull(reader["TietDoAn"]))?0.0m:(System.Decimal?)reader["TietDoAn"];
					entity.TietNghiaVu = reader.IsDBNull(reader.GetOrdinal("TietNghiaVu")) ? null : (System.Int32?)reader["TietNghiaVu"];
					//entity.TietNghiaVu = (Convert.IsDBNull(reader["TietNghiaVu"]))?(int)0:(System.Int32?)reader["TietNghiaVu"];
					entity.TietGioiHan = reader.IsDBNull(reader.GetOrdinal("TietGioiHan")) ? null : (System.Int32?)reader["TietGioiHan"];
					//entity.TietGioiHan = (Convert.IsDBNull(reader["TietGioiHan"]))?(int)0:(System.Int32?)reader["TietGioiHan"];
					entity.DonGia = reader.IsDBNull(reader.GetOrdinal("DonGia")) ? null : (System.Decimal?)reader["DonGia"];
					//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal?)reader["DonGia"];
					entity.TietThieu = reader.IsDBNull(reader.GetOrdinal("TietThieu")) ? null : (System.Decimal?)reader["TietThieu"];
					//entity.TietThieu = (Convert.IsDBNull(reader["TietThieu"]))?0.0m:(System.Decimal?)reader["TietThieu"];
					entity.TietVuot = reader.IsDBNull(reader.GetOrdinal("TietVuot")) ? null : (System.Decimal?)reader["TietVuot"];
					//entity.TietVuot = (Convert.IsDBNull(reader["TietVuot"]))?0.0m:(System.Decimal?)reader["TietVuot"];
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
		/// Refreshes the <see cref="ViewTinhKhoiLuong"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewTinhKhoiLuong"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewTinhKhoiLuong entity)
		{
			reader.Read();
			entity.MaKetQua = (System.Int32)reader["MaKetQua"];
			//entity.MaKetQua = (Convert.IsDBNull(reader["MaKetQua"]))?(int)0:(System.Int32)reader["MaKetQua"];
			entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.MaGiangVien = (System.Int32)reader["MaGiangVien"];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
			entity.MaQuanLy = (System.String)reader["MaQuanLy"];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.TietQuyDoi = reader.IsDBNull(reader.GetOrdinal("TietQuyDoi")) ? null : (System.Decimal?)reader["TietQuyDoi"];
			//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal?)reader["TietQuyDoi"];
			entity.TrongGio = reader.IsDBNull(reader.GetOrdinal("TrongGio")) ? null : (System.Decimal?)reader["TrongGio"];
			//entity.TrongGio = (Convert.IsDBNull(reader["TrongGio"]))?0.0m:(System.Decimal?)reader["TrongGio"];
			entity.NgoaiGio = reader.IsDBNull(reader.GetOrdinal("NgoaiGio")) ? null : (System.Decimal?)reader["NgoaiGio"];
			//entity.NgoaiGio = (Convert.IsDBNull(reader["NgoaiGio"]))?0.0m:(System.Decimal?)reader["NgoaiGio"];
			entity.TietDoAn = reader.IsDBNull(reader.GetOrdinal("TietDoAn")) ? null : (System.Decimal?)reader["TietDoAn"];
			//entity.TietDoAn = (Convert.IsDBNull(reader["TietDoAn"]))?0.0m:(System.Decimal?)reader["TietDoAn"];
			entity.TietNghiaVu = reader.IsDBNull(reader.GetOrdinal("TietNghiaVu")) ? null : (System.Int32?)reader["TietNghiaVu"];
			//entity.TietNghiaVu = (Convert.IsDBNull(reader["TietNghiaVu"]))?(int)0:(System.Int32?)reader["TietNghiaVu"];
			entity.TietGioiHan = reader.IsDBNull(reader.GetOrdinal("TietGioiHan")) ? null : (System.Int32?)reader["TietGioiHan"];
			//entity.TietGioiHan = (Convert.IsDBNull(reader["TietGioiHan"]))?(int)0:(System.Int32?)reader["TietGioiHan"];
			entity.DonGia = reader.IsDBNull(reader.GetOrdinal("DonGia")) ? null : (System.Decimal?)reader["DonGia"];
			//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal?)reader["DonGia"];
			entity.TietThieu = reader.IsDBNull(reader.GetOrdinal("TietThieu")) ? null : (System.Decimal?)reader["TietThieu"];
			//entity.TietThieu = (Convert.IsDBNull(reader["TietThieu"]))?0.0m:(System.Decimal?)reader["TietThieu"];
			entity.TietVuot = reader.IsDBNull(reader.GetOrdinal("TietVuot")) ? null : (System.Decimal?)reader["TietVuot"];
			//entity.TietVuot = (Convert.IsDBNull(reader["TietVuot"]))?0.0m:(System.Decimal?)reader["TietVuot"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewTinhKhoiLuong"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewTinhKhoiLuong"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewTinhKhoiLuong entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaKetQua = (Convert.IsDBNull(dataRow["MaKetQua"]))?(int)0:(System.Int32)dataRow["MaKetQua"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32)dataRow["MaGiangVien"];
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.TietQuyDoi = (Convert.IsDBNull(dataRow["TietQuyDoi"]))?0.0m:(System.Decimal?)dataRow["TietQuyDoi"];
			entity.TrongGio = (Convert.IsDBNull(dataRow["TrongGio"]))?0.0m:(System.Decimal?)dataRow["TrongGio"];
			entity.NgoaiGio = (Convert.IsDBNull(dataRow["NgoaiGio"]))?0.0m:(System.Decimal?)dataRow["NgoaiGio"];
			entity.TietDoAn = (Convert.IsDBNull(dataRow["TietDoAn"]))?0.0m:(System.Decimal?)dataRow["TietDoAn"];
			entity.TietNghiaVu = (Convert.IsDBNull(dataRow["TietNghiaVu"]))?(int)0:(System.Int32?)dataRow["TietNghiaVu"];
			entity.TietGioiHan = (Convert.IsDBNull(dataRow["TietGioiHan"]))?(int)0:(System.Int32?)dataRow["TietGioiHan"];
			entity.DonGia = (Convert.IsDBNull(dataRow["DonGia"]))?0.0m:(System.Decimal?)dataRow["DonGia"];
			entity.TietThieu = (Convert.IsDBNull(dataRow["TietThieu"]))?0.0m:(System.Decimal?)dataRow["TietThieu"];
			entity.TietVuot = (Convert.IsDBNull(dataRow["TietVuot"]))?0.0m:(System.Decimal?)dataRow["TietVuot"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewTinhKhoiLuongFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTinhKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTinhKhoiLuongFilterBuilder : SqlFilterBuilder<ViewTinhKhoiLuongColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTinhKhoiLuongFilterBuilder class.
		/// </summary>
		public ViewTinhKhoiLuongFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewTinhKhoiLuongFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewTinhKhoiLuongFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewTinhKhoiLuongFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewTinhKhoiLuongFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewTinhKhoiLuongFilterBuilder

	#region ViewTinhKhoiLuongParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTinhKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTinhKhoiLuongParameterBuilder : ParameterizedSqlFilterBuilder<ViewTinhKhoiLuongColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTinhKhoiLuongParameterBuilder class.
		/// </summary>
		public ViewTinhKhoiLuongParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewTinhKhoiLuongParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewTinhKhoiLuongParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewTinhKhoiLuongParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewTinhKhoiLuongParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewTinhKhoiLuongParameterBuilder
	
	#region ViewTinhKhoiLuongSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTinhKhoiLuong"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewTinhKhoiLuongSortBuilder : SqlSortBuilder<ViewTinhKhoiLuongColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTinhKhoiLuongSqlSortBuilder class.
		/// </summary>
		public ViewTinhKhoiLuongSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewTinhKhoiLuongSortBuilder

} // end namespace
