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
	/// This class is the base class for any <see cref="ViewBangLuongGiangVienProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewBangLuongGiangVienProviderBaseCore : EntityViewProviderBase<ViewBangLuongGiangVien>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewBangLuongGiangVien&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewBangLuongGiangVien&gt;"/></returns>
		protected static VList&lt;ViewBangLuongGiangVien&gt; Fill(DataSet dataSet, VList<ViewBangLuongGiangVien> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewBangLuongGiangVien>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewBangLuongGiangVien&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewBangLuongGiangVien>"/></returns>
		protected static VList&lt;ViewBangLuongGiangVien&gt; Fill(DataTable dataTable, VList<ViewBangLuongGiangVien> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewBangLuongGiangVien c = new ViewBangLuongGiangVien();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32)row["MaGiangVien"];
					c.Ho = (Convert.IsDBNull(row["Ho"]))?string.Empty:(System.String)row["Ho"];
					c.Ten = (Convert.IsDBNull(row["Ten"]))?string.Empty:(System.String)row["Ten"];
					c.SoTaiKhoan = (Convert.IsDBNull(row["SoTaiKhoan"]))?string.Empty:(System.String)row["SoTaiKhoan"];
					c.MaLop = (Convert.IsDBNull(row["MaLop"]))?string.Empty:(System.String)row["MaLop"];
					c.TenLop = (Convert.IsDBNull(row["TenLop"]))?string.Empty:(System.String)row["TenLop"];
					c.MaMonHoc = (Convert.IsDBNull(row["MaMonHoc"]))?string.Empty:(System.String)row["MaMonHoc"];
					c.TenMonHoc = (Convert.IsDBNull(row["TenMonHoc"]))?string.Empty:(System.String)row["TenMonHoc"];
					c.NgayBatDau = (Convert.IsDBNull(row["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)row["NgayBatDau"];
					c.NgayKetThuc = (Convert.IsDBNull(row["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)row["NgayKetThuc"];
					c.SoTiet = (Convert.IsDBNull(row["SoTiet"]))?(int)0:(System.Int32?)row["SoTiet"];
					c.TietQuyDoi = (Convert.IsDBNull(row["TietQuyDoi"]))?0.0m:(System.Decimal?)row["TietQuyDoi"];
					c.SiSoLop = (Convert.IsDBNull(row["SiSoLop"]))?(int)0:(System.Int32?)row["SiSoLop"];
					c.SoTien = (Convert.IsDBNull(row["SoTien"]))?0:(System.Decimal?)row["SoTien"];
					c.ThanhTien = (Convert.IsDBNull(row["ThanhTien"]))?(int)0:(System.Int32?)row["ThanhTien"];
					c.TongTien = (Convert.IsDBNull(row["TongTien"]))?(int)0:(System.Int32?)row["TongTien"];
					c.ThueTncn = (Convert.IsDBNull(row["ThueTNCN"]))?(int)0:(System.Int32?)row["ThueTNCN"];
					c.TienThucNhan = (Convert.IsDBNull(row["TienThucNhan"]))?(int)0:(System.Int32?)row["TienThucNhan"];
					c.MaBacDaoTao = (Convert.IsDBNull(row["MaBacDaoTao"]))?string.Empty:(System.String)row["MaBacDaoTao"];
					c.MaHeDaoTao = (Convert.IsDBNull(row["MaHeDaoTao"]))?string.Empty:(System.String)row["MaHeDaoTao"];
					c.MaVaiTroGiangDay = (Convert.IsDBNull(row["MaVaiTroGiangDay"]))?string.Empty:(System.String)row["MaVaiTroGiangDay"];
					c.MaLopHocPhan = (Convert.IsDBNull(row["MaLopHocPhan"]))?string.Empty:(System.String)row["MaLopHocPhan"];
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
		/// Fill an <see cref="VList&lt;ViewBangLuongGiangVien&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewBangLuongGiangVien&gt;"/></returns>
		protected VList<ViewBangLuongGiangVien> Fill(IDataReader reader, VList<ViewBangLuongGiangVien> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewBangLuongGiangVien entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewBangLuongGiangVien>("ViewBangLuongGiangVien",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewBangLuongGiangVien();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = (System.Int32)reader[((int)ViewBangLuongGiangVienColumn.MaGiangVien)];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
					entity.Ho = (reader.IsDBNull(((int)ViewBangLuongGiangVienColumn.Ho)))?null:(System.String)reader[((int)ViewBangLuongGiangVienColumn.Ho)];
					//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
					entity.Ten = (reader.IsDBNull(((int)ViewBangLuongGiangVienColumn.Ten)))?null:(System.String)reader[((int)ViewBangLuongGiangVienColumn.Ten)];
					//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
					entity.SoTaiKhoan = (reader.IsDBNull(((int)ViewBangLuongGiangVienColumn.SoTaiKhoan)))?null:(System.String)reader[((int)ViewBangLuongGiangVienColumn.SoTaiKhoan)];
					//entity.SoTaiKhoan = (Convert.IsDBNull(reader["SoTaiKhoan"]))?string.Empty:(System.String)reader["SoTaiKhoan"];
					entity.MaLop = (System.String)reader[((int)ViewBangLuongGiangVienColumn.MaLop)];
					//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
					entity.TenLop = (System.String)reader[((int)ViewBangLuongGiangVienColumn.TenLop)];
					//entity.TenLop = (Convert.IsDBNull(reader["TenLop"]))?string.Empty:(System.String)reader["TenLop"];
					entity.MaMonHoc = (System.String)reader[((int)ViewBangLuongGiangVienColumn.MaMonHoc)];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.TenMonHoc = (System.String)reader[((int)ViewBangLuongGiangVienColumn.TenMonHoc)];
					//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
					entity.NgayBatDau = (reader.IsDBNull(((int)ViewBangLuongGiangVienColumn.NgayBatDau)))?null:(System.DateTime?)reader[((int)ViewBangLuongGiangVienColumn.NgayBatDau)];
					//entity.NgayBatDau = (Convert.IsDBNull(reader["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)reader["NgayBatDau"];
					entity.NgayKetThuc = (reader.IsDBNull(((int)ViewBangLuongGiangVienColumn.NgayKetThuc)))?null:(System.DateTime?)reader[((int)ViewBangLuongGiangVienColumn.NgayKetThuc)];
					//entity.NgayKetThuc = (Convert.IsDBNull(reader["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKetThuc"];
					entity.SoTiet = (reader.IsDBNull(((int)ViewBangLuongGiangVienColumn.SoTiet)))?null:(System.Int32?)reader[((int)ViewBangLuongGiangVienColumn.SoTiet)];
					//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32?)reader["SoTiet"];
					entity.TietQuyDoi = (reader.IsDBNull(((int)ViewBangLuongGiangVienColumn.TietQuyDoi)))?null:(System.Decimal?)reader[((int)ViewBangLuongGiangVienColumn.TietQuyDoi)];
					//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal?)reader["TietQuyDoi"];
					entity.SiSoLop = (reader.IsDBNull(((int)ViewBangLuongGiangVienColumn.SiSoLop)))?null:(System.Int32?)reader[((int)ViewBangLuongGiangVienColumn.SiSoLop)];
					//entity.SiSoLop = (Convert.IsDBNull(reader["SiSoLop"]))?(int)0:(System.Int32?)reader["SiSoLop"];
					entity.SoTien = (reader.IsDBNull(((int)ViewBangLuongGiangVienColumn.SoTien)))?null:(System.Decimal?)reader[((int)ViewBangLuongGiangVienColumn.SoTien)];
					//entity.SoTien = (Convert.IsDBNull(reader["SoTien"]))?0:(System.Decimal?)reader["SoTien"];
					entity.ThanhTien = (reader.IsDBNull(((int)ViewBangLuongGiangVienColumn.ThanhTien)))?null:(System.Int32?)reader[((int)ViewBangLuongGiangVienColumn.ThanhTien)];
					//entity.ThanhTien = (Convert.IsDBNull(reader["ThanhTien"]))?(int)0:(System.Int32?)reader["ThanhTien"];
					entity.TongTien = (reader.IsDBNull(((int)ViewBangLuongGiangVienColumn.TongTien)))?null:(System.Int32?)reader[((int)ViewBangLuongGiangVienColumn.TongTien)];
					//entity.TongTien = (Convert.IsDBNull(reader["TongTien"]))?(int)0:(System.Int32?)reader["TongTien"];
					entity.ThueTncn = (reader.IsDBNull(((int)ViewBangLuongGiangVienColumn.ThueTncn)))?null:(System.Int32?)reader[((int)ViewBangLuongGiangVienColumn.ThueTncn)];
					//entity.ThueTncn = (Convert.IsDBNull(reader["ThueTNCN"]))?(int)0:(System.Int32?)reader["ThueTNCN"];
					entity.TienThucNhan = (reader.IsDBNull(((int)ViewBangLuongGiangVienColumn.TienThucNhan)))?null:(System.Int32?)reader[((int)ViewBangLuongGiangVienColumn.TienThucNhan)];
					//entity.TienThucNhan = (Convert.IsDBNull(reader["TienThucNhan"]))?(int)0:(System.Int32?)reader["TienThucNhan"];
					entity.MaBacDaoTao = (reader.IsDBNull(((int)ViewBangLuongGiangVienColumn.MaBacDaoTao)))?null:(System.String)reader[((int)ViewBangLuongGiangVienColumn.MaBacDaoTao)];
					//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
					entity.MaHeDaoTao = (reader.IsDBNull(((int)ViewBangLuongGiangVienColumn.MaHeDaoTao)))?null:(System.String)reader[((int)ViewBangLuongGiangVienColumn.MaHeDaoTao)];
					//entity.MaHeDaoTao = (Convert.IsDBNull(reader["MaHeDaoTao"]))?string.Empty:(System.String)reader["MaHeDaoTao"];
					entity.MaVaiTroGiangDay = (reader.IsDBNull(((int)ViewBangLuongGiangVienColumn.MaVaiTroGiangDay)))?null:(System.String)reader[((int)ViewBangLuongGiangVienColumn.MaVaiTroGiangDay)];
					//entity.MaVaiTroGiangDay = (Convert.IsDBNull(reader["MaVaiTroGiangDay"]))?string.Empty:(System.String)reader["MaVaiTroGiangDay"];
					entity.MaLopHocPhan = (System.String)reader[((int)ViewBangLuongGiangVienColumn.MaLopHocPhan)];
					//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
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
		/// Refreshes the <see cref="ViewBangLuongGiangVien"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewBangLuongGiangVien"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewBangLuongGiangVien entity)
		{
			reader.Read();
			entity.MaGiangVien = (System.Int32)reader[((int)ViewBangLuongGiangVienColumn.MaGiangVien)];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
			entity.Ho = (reader.IsDBNull(((int)ViewBangLuongGiangVienColumn.Ho)))?null:(System.String)reader[((int)ViewBangLuongGiangVienColumn.Ho)];
			//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
			entity.Ten = (reader.IsDBNull(((int)ViewBangLuongGiangVienColumn.Ten)))?null:(System.String)reader[((int)ViewBangLuongGiangVienColumn.Ten)];
			//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
			entity.SoTaiKhoan = (reader.IsDBNull(((int)ViewBangLuongGiangVienColumn.SoTaiKhoan)))?null:(System.String)reader[((int)ViewBangLuongGiangVienColumn.SoTaiKhoan)];
			//entity.SoTaiKhoan = (Convert.IsDBNull(reader["SoTaiKhoan"]))?string.Empty:(System.String)reader["SoTaiKhoan"];
			entity.MaLop = (System.String)reader[((int)ViewBangLuongGiangVienColumn.MaLop)];
			//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
			entity.TenLop = (System.String)reader[((int)ViewBangLuongGiangVienColumn.TenLop)];
			//entity.TenLop = (Convert.IsDBNull(reader["TenLop"]))?string.Empty:(System.String)reader["TenLop"];
			entity.MaMonHoc = (System.String)reader[((int)ViewBangLuongGiangVienColumn.MaMonHoc)];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.TenMonHoc = (System.String)reader[((int)ViewBangLuongGiangVienColumn.TenMonHoc)];
			//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
			entity.NgayBatDau = (reader.IsDBNull(((int)ViewBangLuongGiangVienColumn.NgayBatDau)))?null:(System.DateTime?)reader[((int)ViewBangLuongGiangVienColumn.NgayBatDau)];
			//entity.NgayBatDau = (Convert.IsDBNull(reader["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)reader["NgayBatDau"];
			entity.NgayKetThuc = (reader.IsDBNull(((int)ViewBangLuongGiangVienColumn.NgayKetThuc)))?null:(System.DateTime?)reader[((int)ViewBangLuongGiangVienColumn.NgayKetThuc)];
			//entity.NgayKetThuc = (Convert.IsDBNull(reader["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKetThuc"];
			entity.SoTiet = (reader.IsDBNull(((int)ViewBangLuongGiangVienColumn.SoTiet)))?null:(System.Int32?)reader[((int)ViewBangLuongGiangVienColumn.SoTiet)];
			//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32?)reader["SoTiet"];
			entity.TietQuyDoi = (reader.IsDBNull(((int)ViewBangLuongGiangVienColumn.TietQuyDoi)))?null:(System.Decimal?)reader[((int)ViewBangLuongGiangVienColumn.TietQuyDoi)];
			//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal?)reader["TietQuyDoi"];
			entity.SiSoLop = (reader.IsDBNull(((int)ViewBangLuongGiangVienColumn.SiSoLop)))?null:(System.Int32?)reader[((int)ViewBangLuongGiangVienColumn.SiSoLop)];
			//entity.SiSoLop = (Convert.IsDBNull(reader["SiSoLop"]))?(int)0:(System.Int32?)reader["SiSoLop"];
			entity.SoTien = (reader.IsDBNull(((int)ViewBangLuongGiangVienColumn.SoTien)))?null:(System.Decimal?)reader[((int)ViewBangLuongGiangVienColumn.SoTien)];
			//entity.SoTien = (Convert.IsDBNull(reader["SoTien"]))?0:(System.Decimal?)reader["SoTien"];
			entity.ThanhTien = (reader.IsDBNull(((int)ViewBangLuongGiangVienColumn.ThanhTien)))?null:(System.Int32?)reader[((int)ViewBangLuongGiangVienColumn.ThanhTien)];
			//entity.ThanhTien = (Convert.IsDBNull(reader["ThanhTien"]))?(int)0:(System.Int32?)reader["ThanhTien"];
			entity.TongTien = (reader.IsDBNull(((int)ViewBangLuongGiangVienColumn.TongTien)))?null:(System.Int32?)reader[((int)ViewBangLuongGiangVienColumn.TongTien)];
			//entity.TongTien = (Convert.IsDBNull(reader["TongTien"]))?(int)0:(System.Int32?)reader["TongTien"];
			entity.ThueTncn = (reader.IsDBNull(((int)ViewBangLuongGiangVienColumn.ThueTncn)))?null:(System.Int32?)reader[((int)ViewBangLuongGiangVienColumn.ThueTncn)];
			//entity.ThueTncn = (Convert.IsDBNull(reader["ThueTNCN"]))?(int)0:(System.Int32?)reader["ThueTNCN"];
			entity.TienThucNhan = (reader.IsDBNull(((int)ViewBangLuongGiangVienColumn.TienThucNhan)))?null:(System.Int32?)reader[((int)ViewBangLuongGiangVienColumn.TienThucNhan)];
			//entity.TienThucNhan = (Convert.IsDBNull(reader["TienThucNhan"]))?(int)0:(System.Int32?)reader["TienThucNhan"];
			entity.MaBacDaoTao = (reader.IsDBNull(((int)ViewBangLuongGiangVienColumn.MaBacDaoTao)))?null:(System.String)reader[((int)ViewBangLuongGiangVienColumn.MaBacDaoTao)];
			//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
			entity.MaHeDaoTao = (reader.IsDBNull(((int)ViewBangLuongGiangVienColumn.MaHeDaoTao)))?null:(System.String)reader[((int)ViewBangLuongGiangVienColumn.MaHeDaoTao)];
			//entity.MaHeDaoTao = (Convert.IsDBNull(reader["MaHeDaoTao"]))?string.Empty:(System.String)reader["MaHeDaoTao"];
			entity.MaVaiTroGiangDay = (reader.IsDBNull(((int)ViewBangLuongGiangVienColumn.MaVaiTroGiangDay)))?null:(System.String)reader[((int)ViewBangLuongGiangVienColumn.MaVaiTroGiangDay)];
			//entity.MaVaiTroGiangDay = (Convert.IsDBNull(reader["MaVaiTroGiangDay"]))?string.Empty:(System.String)reader["MaVaiTroGiangDay"];
			entity.MaLopHocPhan = (System.String)reader[((int)ViewBangLuongGiangVienColumn.MaLopHocPhan)];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewBangLuongGiangVien"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewBangLuongGiangVien"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewBangLuongGiangVien entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32)dataRow["MaGiangVien"];
			entity.Ho = (Convert.IsDBNull(dataRow["Ho"]))?string.Empty:(System.String)dataRow["Ho"];
			entity.Ten = (Convert.IsDBNull(dataRow["Ten"]))?string.Empty:(System.String)dataRow["Ten"];
			entity.SoTaiKhoan = (Convert.IsDBNull(dataRow["SoTaiKhoan"]))?string.Empty:(System.String)dataRow["SoTaiKhoan"];
			entity.MaLop = (Convert.IsDBNull(dataRow["MaLop"]))?string.Empty:(System.String)dataRow["MaLop"];
			entity.TenLop = (Convert.IsDBNull(dataRow["TenLop"]))?string.Empty:(System.String)dataRow["TenLop"];
			entity.MaMonHoc = (Convert.IsDBNull(dataRow["MaMonHoc"]))?string.Empty:(System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = (Convert.IsDBNull(dataRow["TenMonHoc"]))?string.Empty:(System.String)dataRow["TenMonHoc"];
			entity.NgayBatDau = (Convert.IsDBNull(dataRow["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayBatDau"];
			entity.NgayKetThuc = (Convert.IsDBNull(dataRow["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayKetThuc"];
			entity.SoTiet = (Convert.IsDBNull(dataRow["SoTiet"]))?(int)0:(System.Int32?)dataRow["SoTiet"];
			entity.TietQuyDoi = (Convert.IsDBNull(dataRow["TietQuyDoi"]))?0.0m:(System.Decimal?)dataRow["TietQuyDoi"];
			entity.SiSoLop = (Convert.IsDBNull(dataRow["SiSoLop"]))?(int)0:(System.Int32?)dataRow["SiSoLop"];
			entity.SoTien = (Convert.IsDBNull(dataRow["SoTien"]))?0:(System.Decimal?)dataRow["SoTien"];
			entity.ThanhTien = (Convert.IsDBNull(dataRow["ThanhTien"]))?(int)0:(System.Int32?)dataRow["ThanhTien"];
			entity.TongTien = (Convert.IsDBNull(dataRow["TongTien"]))?(int)0:(System.Int32?)dataRow["TongTien"];
			entity.ThueTncn = (Convert.IsDBNull(dataRow["ThueTNCN"]))?(int)0:(System.Int32?)dataRow["ThueTNCN"];
			entity.TienThucNhan = (Convert.IsDBNull(dataRow["TienThucNhan"]))?(int)0:(System.Int32?)dataRow["TienThucNhan"];
			entity.MaBacDaoTao = (Convert.IsDBNull(dataRow["MaBacDaoTao"]))?string.Empty:(System.String)dataRow["MaBacDaoTao"];
			entity.MaHeDaoTao = (Convert.IsDBNull(dataRow["MaHeDaoTao"]))?string.Empty:(System.String)dataRow["MaHeDaoTao"];
			entity.MaVaiTroGiangDay = (Convert.IsDBNull(dataRow["MaVaiTroGiangDay"]))?string.Empty:(System.String)dataRow["MaVaiTroGiangDay"];
			entity.MaLopHocPhan = (Convert.IsDBNull(dataRow["MaLopHocPhan"]))?string.Empty:(System.String)dataRow["MaLopHocPhan"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewBangLuongGiangVienFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewBangLuongGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewBangLuongGiangVienFilterBuilder : SqlFilterBuilder<ViewBangLuongGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewBangLuongGiangVienFilterBuilder class.
		/// </summary>
		public ViewBangLuongGiangVienFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewBangLuongGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewBangLuongGiangVienFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewBangLuongGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewBangLuongGiangVienFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewBangLuongGiangVienFilterBuilder

	#region ViewBangLuongGiangVienParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewBangLuongGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewBangLuongGiangVienParameterBuilder : ParameterizedSqlFilterBuilder<ViewBangLuongGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewBangLuongGiangVienParameterBuilder class.
		/// </summary>
		public ViewBangLuongGiangVienParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewBangLuongGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewBangLuongGiangVienParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewBangLuongGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewBangLuongGiangVienParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewBangLuongGiangVienParameterBuilder
	
	#region ViewBangLuongGiangVienSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewBangLuongGiangVien"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewBangLuongGiangVienSortBuilder : SqlSortBuilder<ViewBangLuongGiangVienColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewBangLuongGiangVienSqlSortBuilder class.
		/// </summary>
		public ViewBangLuongGiangVienSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewBangLuongGiangVienSortBuilder

} // end namespace
