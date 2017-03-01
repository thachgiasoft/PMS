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
	/// This class is the base class for any <see cref="ViewPhuTroiGioDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewPhuTroiGioDayProviderBaseCore : EntityViewProviderBase<ViewPhuTroiGioDay>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewPhuTroiGioDay&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewPhuTroiGioDay&gt;"/></returns>
		protected static VList&lt;ViewPhuTroiGioDay&gt; Fill(DataSet dataSet, VList<ViewPhuTroiGioDay> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewPhuTroiGioDay>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewPhuTroiGioDay&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewPhuTroiGioDay>"/></returns>
		protected static VList&lt;ViewPhuTroiGioDay&gt; Fill(DataTable dataTable, VList<ViewPhuTroiGioDay> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewPhuTroiGioDay c = new ViewPhuTroiGioDay();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?string.Empty:(System.String)row["MaGiangVien"];
					c.TenQuanLy = (Convert.IsDBNull(row["TenQuanLy"]))?string.Empty:(System.String)row["TenQuanLy"];
					c.TietThucDayCd = (Convert.IsDBNull(row["TietThucDayCD"]))?string.Empty:(System.String)row["TietThucDayCD"];
					c.TietThucDayTc = (Convert.IsDBNull(row["TietThucDayTC"]))?string.Empty:(System.String)row["TietThucDayTC"];
					c.TietQuyDoiCd = (Convert.IsDBNull(row["TietQuyDoiCD"]))?string.Empty:(System.String)row["TietQuyDoiCD"];
					c.TietQuyDoiTc = (Convert.IsDBNull(row["TietQuyDoiTC"]))?string.Empty:(System.String)row["TietQuyDoiTC"];
					c.TcQuyDoi = (Convert.IsDBNull(row["TCQuyDoi"]))?string.Empty:(System.String)row["TCQuyDoi"];
					c.MaKhoa = (Convert.IsDBNull(row["MaKhoa"]))?string.Empty:(System.String)row["MaKhoa"];
					c.MaBoMon = (Convert.IsDBNull(row["MaBoMon"]))?string.Empty:(System.String)row["MaBoMon"];
					c.TenKhoa = (Convert.IsDBNull(row["TenKhoa"]))?string.Empty:(System.String)row["TenKhoa"];
					c.TenBoMon = (Convert.IsDBNull(row["TenBoMon"]))?string.Empty:(System.String)row["TenBoMon"];
					c.MaLoaiGiangVien = (Convert.IsDBNull(row["MaLoaiGiangVien"]))?(int)0:(System.Int32?)row["MaLoaiGiangVien"];
					c.TenLoaiGiangVien = (Convert.IsDBNull(row["TenLoaiGiangVien"]))?string.Empty:(System.String)row["TenLoaiGiangVien"];
					c.MaBacDaoTao = (Convert.IsDBNull(row["MaBacDaoTao"]))?string.Empty:(System.String)row["MaBacDaoTao"];
					c.MaHeDaoTao = (Convert.IsDBNull(row["MaHeDaoTao"]))?string.Empty:(System.String)row["MaHeDaoTao"];
					c.MaChucVu = (Convert.IsDBNull(row["MaChucVu"]))?string.Empty:(System.String)row["MaChucVu"];
					c.TenChucVu = (Convert.IsDBNull(row["TenChucVu"]))?string.Empty:(System.String)row["TenChucVu"];
					c.TietNghiaVu = (Convert.IsDBNull(row["TietNghiaVu"]))?(int)0:(System.Int32)row["TietNghiaVu"];
					c.Nckh = (Convert.IsDBNull(row["Nckh"]))?0.0m:(System.Decimal?)row["Nckh"];
					c.NhiemVuKhac = (Convert.IsDBNull(row["NhiemVuKhac"]))?0.0m:(System.Decimal?)row["NhiemVuKhac"];
					c.GioChuan = (Convert.IsDBNull(row["GioChuan"]))?0.0m:(System.Decimal?)row["GioChuan"];
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
		/// Fill an <see cref="VList&lt;ViewPhuTroiGioDay&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewPhuTroiGioDay&gt;"/></returns>
		protected VList<ViewPhuTroiGioDay> Fill(IDataReader reader, VList<ViewPhuTroiGioDay> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewPhuTroiGioDay entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewPhuTroiGioDay>("ViewPhuTroiGioDay",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewPhuTroiGioDay();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.MaGiangVien)))?null:(System.String)reader[((int)ViewPhuTroiGioDayColumn.MaGiangVien)];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?string.Empty:(System.String)reader["MaGiangVien"];
					entity.TenQuanLy = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.TenQuanLy)))?null:(System.String)reader[((int)ViewPhuTroiGioDayColumn.TenQuanLy)];
					//entity.TenQuanLy = (Convert.IsDBNull(reader["TenQuanLy"]))?string.Empty:(System.String)reader["TenQuanLy"];
					entity.TietThucDayCd = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.TietThucDayCd)))?null:(System.String)reader[((int)ViewPhuTroiGioDayColumn.TietThucDayCd)];
					//entity.TietThucDayCd = (Convert.IsDBNull(reader["TietThucDayCD"]))?string.Empty:(System.String)reader["TietThucDayCD"];
					entity.TietThucDayTc = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.TietThucDayTc)))?null:(System.String)reader[((int)ViewPhuTroiGioDayColumn.TietThucDayTc)];
					//entity.TietThucDayTc = (Convert.IsDBNull(reader["TietThucDayTC"]))?string.Empty:(System.String)reader["TietThucDayTC"];
					entity.TietQuyDoiCd = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.TietQuyDoiCd)))?null:(System.String)reader[((int)ViewPhuTroiGioDayColumn.TietQuyDoiCd)];
					//entity.TietQuyDoiCd = (Convert.IsDBNull(reader["TietQuyDoiCD"]))?string.Empty:(System.String)reader["TietQuyDoiCD"];
					entity.TietQuyDoiTc = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.TietQuyDoiTc)))?null:(System.String)reader[((int)ViewPhuTroiGioDayColumn.TietQuyDoiTc)];
					//entity.TietQuyDoiTc = (Convert.IsDBNull(reader["TietQuyDoiTC"]))?string.Empty:(System.String)reader["TietQuyDoiTC"];
					entity.TcQuyDoi = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.TcQuyDoi)))?null:(System.String)reader[((int)ViewPhuTroiGioDayColumn.TcQuyDoi)];
					//entity.TcQuyDoi = (Convert.IsDBNull(reader["TCQuyDoi"]))?string.Empty:(System.String)reader["TCQuyDoi"];
					entity.MaKhoa = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.MaKhoa)))?null:(System.String)reader[((int)ViewPhuTroiGioDayColumn.MaKhoa)];
					//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
					entity.MaBoMon = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.MaBoMon)))?null:(System.String)reader[((int)ViewPhuTroiGioDayColumn.MaBoMon)];
					//entity.MaBoMon = (Convert.IsDBNull(reader["MaBoMon"]))?string.Empty:(System.String)reader["MaBoMon"];
					entity.TenKhoa = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.TenKhoa)))?null:(System.String)reader[((int)ViewPhuTroiGioDayColumn.TenKhoa)];
					//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
					entity.TenBoMon = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.TenBoMon)))?null:(System.String)reader[((int)ViewPhuTroiGioDayColumn.TenBoMon)];
					//entity.TenBoMon = (Convert.IsDBNull(reader["TenBoMon"]))?string.Empty:(System.String)reader["TenBoMon"];
					entity.MaLoaiGiangVien = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.MaLoaiGiangVien)))?null:(System.Int32?)reader[((int)ViewPhuTroiGioDayColumn.MaLoaiGiangVien)];
					//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32?)reader["MaLoaiGiangVien"];
					entity.TenLoaiGiangVien = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.TenLoaiGiangVien)))?null:(System.String)reader[((int)ViewPhuTroiGioDayColumn.TenLoaiGiangVien)];
					//entity.TenLoaiGiangVien = (Convert.IsDBNull(reader["TenLoaiGiangVien"]))?string.Empty:(System.String)reader["TenLoaiGiangVien"];
					entity.MaBacDaoTao = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.MaBacDaoTao)))?null:(System.String)reader[((int)ViewPhuTroiGioDayColumn.MaBacDaoTao)];
					//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
					entity.MaHeDaoTao = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.MaHeDaoTao)))?null:(System.String)reader[((int)ViewPhuTroiGioDayColumn.MaHeDaoTao)];
					//entity.MaHeDaoTao = (Convert.IsDBNull(reader["MaHeDaoTao"]))?string.Empty:(System.String)reader["MaHeDaoTao"];
					entity.MaChucVu = (System.String)reader[((int)ViewPhuTroiGioDayColumn.MaChucVu)];
					//entity.MaChucVu = (Convert.IsDBNull(reader["MaChucVu"]))?string.Empty:(System.String)reader["MaChucVu"];
					entity.TenChucVu = (System.String)reader[((int)ViewPhuTroiGioDayColumn.TenChucVu)];
					//entity.TenChucVu = (Convert.IsDBNull(reader["TenChucVu"]))?string.Empty:(System.String)reader["TenChucVu"];
					entity.TietNghiaVu = (System.Int32)reader[((int)ViewPhuTroiGioDayColumn.TietNghiaVu)];
					//entity.TietNghiaVu = (Convert.IsDBNull(reader["TietNghiaVu"]))?(int)0:(System.Int32)reader["TietNghiaVu"];
					entity.Nckh = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.Nckh)))?null:(System.Decimal?)reader[((int)ViewPhuTroiGioDayColumn.Nckh)];
					//entity.Nckh = (Convert.IsDBNull(reader["Nckh"]))?0.0m:(System.Decimal?)reader["Nckh"];
					entity.NhiemVuKhac = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.NhiemVuKhac)))?null:(System.Decimal?)reader[((int)ViewPhuTroiGioDayColumn.NhiemVuKhac)];
					//entity.NhiemVuKhac = (Convert.IsDBNull(reader["NhiemVuKhac"]))?0.0m:(System.Decimal?)reader["NhiemVuKhac"];
					entity.GioChuan = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.GioChuan)))?null:(System.Decimal?)reader[((int)ViewPhuTroiGioDayColumn.GioChuan)];
					//entity.GioChuan = (Convert.IsDBNull(reader["GioChuan"]))?0.0m:(System.Decimal?)reader["GioChuan"];
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
		/// Refreshes the <see cref="ViewPhuTroiGioDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewPhuTroiGioDay"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewPhuTroiGioDay entity)
		{
			reader.Read();
			entity.MaGiangVien = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.MaGiangVien)))?null:(System.String)reader[((int)ViewPhuTroiGioDayColumn.MaGiangVien)];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?string.Empty:(System.String)reader["MaGiangVien"];
			entity.TenQuanLy = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.TenQuanLy)))?null:(System.String)reader[((int)ViewPhuTroiGioDayColumn.TenQuanLy)];
			//entity.TenQuanLy = (Convert.IsDBNull(reader["TenQuanLy"]))?string.Empty:(System.String)reader["TenQuanLy"];
			entity.TietThucDayCd = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.TietThucDayCd)))?null:(System.String)reader[((int)ViewPhuTroiGioDayColumn.TietThucDayCd)];
			//entity.TietThucDayCd = (Convert.IsDBNull(reader["TietThucDayCD"]))?string.Empty:(System.String)reader["TietThucDayCD"];
			entity.TietThucDayTc = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.TietThucDayTc)))?null:(System.String)reader[((int)ViewPhuTroiGioDayColumn.TietThucDayTc)];
			//entity.TietThucDayTc = (Convert.IsDBNull(reader["TietThucDayTC"]))?string.Empty:(System.String)reader["TietThucDayTC"];
			entity.TietQuyDoiCd = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.TietQuyDoiCd)))?null:(System.String)reader[((int)ViewPhuTroiGioDayColumn.TietQuyDoiCd)];
			//entity.TietQuyDoiCd = (Convert.IsDBNull(reader["TietQuyDoiCD"]))?string.Empty:(System.String)reader["TietQuyDoiCD"];
			entity.TietQuyDoiTc = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.TietQuyDoiTc)))?null:(System.String)reader[((int)ViewPhuTroiGioDayColumn.TietQuyDoiTc)];
			//entity.TietQuyDoiTc = (Convert.IsDBNull(reader["TietQuyDoiTC"]))?string.Empty:(System.String)reader["TietQuyDoiTC"];
			entity.TcQuyDoi = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.TcQuyDoi)))?null:(System.String)reader[((int)ViewPhuTroiGioDayColumn.TcQuyDoi)];
			//entity.TcQuyDoi = (Convert.IsDBNull(reader["TCQuyDoi"]))?string.Empty:(System.String)reader["TCQuyDoi"];
			entity.MaKhoa = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.MaKhoa)))?null:(System.String)reader[((int)ViewPhuTroiGioDayColumn.MaKhoa)];
			//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
			entity.MaBoMon = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.MaBoMon)))?null:(System.String)reader[((int)ViewPhuTroiGioDayColumn.MaBoMon)];
			//entity.MaBoMon = (Convert.IsDBNull(reader["MaBoMon"]))?string.Empty:(System.String)reader["MaBoMon"];
			entity.TenKhoa = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.TenKhoa)))?null:(System.String)reader[((int)ViewPhuTroiGioDayColumn.TenKhoa)];
			//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
			entity.TenBoMon = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.TenBoMon)))?null:(System.String)reader[((int)ViewPhuTroiGioDayColumn.TenBoMon)];
			//entity.TenBoMon = (Convert.IsDBNull(reader["TenBoMon"]))?string.Empty:(System.String)reader["TenBoMon"];
			entity.MaLoaiGiangVien = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.MaLoaiGiangVien)))?null:(System.Int32?)reader[((int)ViewPhuTroiGioDayColumn.MaLoaiGiangVien)];
			//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32?)reader["MaLoaiGiangVien"];
			entity.TenLoaiGiangVien = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.TenLoaiGiangVien)))?null:(System.String)reader[((int)ViewPhuTroiGioDayColumn.TenLoaiGiangVien)];
			//entity.TenLoaiGiangVien = (Convert.IsDBNull(reader["TenLoaiGiangVien"]))?string.Empty:(System.String)reader["TenLoaiGiangVien"];
			entity.MaBacDaoTao = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.MaBacDaoTao)))?null:(System.String)reader[((int)ViewPhuTroiGioDayColumn.MaBacDaoTao)];
			//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
			entity.MaHeDaoTao = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.MaHeDaoTao)))?null:(System.String)reader[((int)ViewPhuTroiGioDayColumn.MaHeDaoTao)];
			//entity.MaHeDaoTao = (Convert.IsDBNull(reader["MaHeDaoTao"]))?string.Empty:(System.String)reader["MaHeDaoTao"];
			entity.MaChucVu = (System.String)reader[((int)ViewPhuTroiGioDayColumn.MaChucVu)];
			//entity.MaChucVu = (Convert.IsDBNull(reader["MaChucVu"]))?string.Empty:(System.String)reader["MaChucVu"];
			entity.TenChucVu = (System.String)reader[((int)ViewPhuTroiGioDayColumn.TenChucVu)];
			//entity.TenChucVu = (Convert.IsDBNull(reader["TenChucVu"]))?string.Empty:(System.String)reader["TenChucVu"];
			entity.TietNghiaVu = (System.Int32)reader[((int)ViewPhuTroiGioDayColumn.TietNghiaVu)];
			//entity.TietNghiaVu = (Convert.IsDBNull(reader["TietNghiaVu"]))?(int)0:(System.Int32)reader["TietNghiaVu"];
			entity.Nckh = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.Nckh)))?null:(System.Decimal?)reader[((int)ViewPhuTroiGioDayColumn.Nckh)];
			//entity.Nckh = (Convert.IsDBNull(reader["Nckh"]))?0.0m:(System.Decimal?)reader["Nckh"];
			entity.NhiemVuKhac = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.NhiemVuKhac)))?null:(System.Decimal?)reader[((int)ViewPhuTroiGioDayColumn.NhiemVuKhac)];
			//entity.NhiemVuKhac = (Convert.IsDBNull(reader["NhiemVuKhac"]))?0.0m:(System.Decimal?)reader["NhiemVuKhac"];
			entity.GioChuan = (reader.IsDBNull(((int)ViewPhuTroiGioDayColumn.GioChuan)))?null:(System.Decimal?)reader[((int)ViewPhuTroiGioDayColumn.GioChuan)];
			//entity.GioChuan = (Convert.IsDBNull(reader["GioChuan"]))?0.0m:(System.Decimal?)reader["GioChuan"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewPhuTroiGioDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewPhuTroiGioDay"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewPhuTroiGioDay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?string.Empty:(System.String)dataRow["MaGiangVien"];
			entity.TenQuanLy = (Convert.IsDBNull(dataRow["TenQuanLy"]))?string.Empty:(System.String)dataRow["TenQuanLy"];
			entity.TietThucDayCd = (Convert.IsDBNull(dataRow["TietThucDayCD"]))?string.Empty:(System.String)dataRow["TietThucDayCD"];
			entity.TietThucDayTc = (Convert.IsDBNull(dataRow["TietThucDayTC"]))?string.Empty:(System.String)dataRow["TietThucDayTC"];
			entity.TietQuyDoiCd = (Convert.IsDBNull(dataRow["TietQuyDoiCD"]))?string.Empty:(System.String)dataRow["TietQuyDoiCD"];
			entity.TietQuyDoiTc = (Convert.IsDBNull(dataRow["TietQuyDoiTC"]))?string.Empty:(System.String)dataRow["TietQuyDoiTC"];
			entity.TcQuyDoi = (Convert.IsDBNull(dataRow["TCQuyDoi"]))?string.Empty:(System.String)dataRow["TCQuyDoi"];
			entity.MaKhoa = (Convert.IsDBNull(dataRow["MaKhoa"]))?string.Empty:(System.String)dataRow["MaKhoa"];
			entity.MaBoMon = (Convert.IsDBNull(dataRow["MaBoMon"]))?string.Empty:(System.String)dataRow["MaBoMon"];
			entity.TenKhoa = (Convert.IsDBNull(dataRow["TenKhoa"]))?string.Empty:(System.String)dataRow["TenKhoa"];
			entity.TenBoMon = (Convert.IsDBNull(dataRow["TenBoMon"]))?string.Empty:(System.String)dataRow["TenBoMon"];
			entity.MaLoaiGiangVien = (Convert.IsDBNull(dataRow["MaLoaiGiangVien"]))?(int)0:(System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.TenLoaiGiangVien = (Convert.IsDBNull(dataRow["TenLoaiGiangVien"]))?string.Empty:(System.String)dataRow["TenLoaiGiangVien"];
			entity.MaBacDaoTao = (Convert.IsDBNull(dataRow["MaBacDaoTao"]))?string.Empty:(System.String)dataRow["MaBacDaoTao"];
			entity.MaHeDaoTao = (Convert.IsDBNull(dataRow["MaHeDaoTao"]))?string.Empty:(System.String)dataRow["MaHeDaoTao"];
			entity.MaChucVu = (Convert.IsDBNull(dataRow["MaChucVu"]))?string.Empty:(System.String)dataRow["MaChucVu"];
			entity.TenChucVu = (Convert.IsDBNull(dataRow["TenChucVu"]))?string.Empty:(System.String)dataRow["TenChucVu"];
			entity.TietNghiaVu = (Convert.IsDBNull(dataRow["TietNghiaVu"]))?(int)0:(System.Int32)dataRow["TietNghiaVu"];
			entity.Nckh = (Convert.IsDBNull(dataRow["Nckh"]))?0.0m:(System.Decimal?)dataRow["Nckh"];
			entity.NhiemVuKhac = (Convert.IsDBNull(dataRow["NhiemVuKhac"]))?0.0m:(System.Decimal?)dataRow["NhiemVuKhac"];
			entity.GioChuan = (Convert.IsDBNull(dataRow["GioChuan"]))?0.0m:(System.Decimal?)dataRow["GioChuan"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewPhuTroiGioDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhuTroiGioDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhuTroiGioDayFilterBuilder : SqlFilterBuilder<ViewPhuTroiGioDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhuTroiGioDayFilterBuilder class.
		/// </summary>
		public ViewPhuTroiGioDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewPhuTroiGioDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewPhuTroiGioDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewPhuTroiGioDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewPhuTroiGioDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewPhuTroiGioDayFilterBuilder

	#region ViewPhuTroiGioDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhuTroiGioDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhuTroiGioDayParameterBuilder : ParameterizedSqlFilterBuilder<ViewPhuTroiGioDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhuTroiGioDayParameterBuilder class.
		/// </summary>
		public ViewPhuTroiGioDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewPhuTroiGioDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewPhuTroiGioDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewPhuTroiGioDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewPhuTroiGioDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewPhuTroiGioDayParameterBuilder
	
	#region ViewPhuTroiGioDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhuTroiGioDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewPhuTroiGioDaySortBuilder : SqlSortBuilder<ViewPhuTroiGioDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhuTroiGioDaySqlSortBuilder class.
		/// </summary>
		public ViewPhuTroiGioDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewPhuTroiGioDaySortBuilder

} // end namespace
