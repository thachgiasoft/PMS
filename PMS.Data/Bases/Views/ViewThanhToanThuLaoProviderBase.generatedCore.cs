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
	/// This class is the base class for any <see cref="ViewThanhToanThuLaoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewThanhToanThuLaoProviderBaseCore : EntityViewProviderBase<ViewThanhToanThuLao>
	{
		#region Custom Methods
		
		
		#region cust_View_ThanhToan_ThuLao_GetByNamHocHocKyDonViLoaiGiangVien
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhToan_ThuLao_GetByNamHocHocKyDonViLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThanhToanThuLao&gt;"/> instance.</returns>
		public VList<ViewThanhToanThuLao> GetByNamHocHocKyDonViLoaiGiangVien(System.String namHoc, System.String hocKy, System.String maDonVi, System.Int32 maLoaiGiangVien)
		{
			return GetByNamHocHocKyDonViLoaiGiangVien(null, 0, int.MaxValue , namHoc, hocKy, maDonVi, maLoaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhToan_ThuLao_GetByNamHocHocKyDonViLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThanhToanThuLao&gt;"/> instance.</returns>
		public VList<ViewThanhToanThuLao> GetByNamHocHocKyDonViLoaiGiangVien(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi, System.Int32 maLoaiGiangVien)
		{
			return GetByNamHocHocKyDonViLoaiGiangVien(null, start, pageLength , namHoc, hocKy, maDonVi, maLoaiGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ThanhToan_ThuLao_GetByNamHocHocKyDonViLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewThanhToanThuLao&gt;"/> instance.</returns>
		public VList<ViewThanhToanThuLao> GetByNamHocHocKyDonViLoaiGiangVien(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi, System.Int32 maLoaiGiangVien)
		{
			return GetByNamHocHocKyDonViLoaiGiangVien(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi, maLoaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhToan_ThuLao_GetByNamHocHocKyDonViLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThanhToanThuLao&gt;"/> instance.</returns>
		public abstract VList<ViewThanhToanThuLao> GetByNamHocHocKyDonViLoaiGiangVien(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi, System.Int32 maLoaiGiangVien);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewThanhToanThuLao&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewThanhToanThuLao&gt;"/></returns>
		protected static VList&lt;ViewThanhToanThuLao&gt; Fill(DataSet dataSet, VList<ViewThanhToanThuLao> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewThanhToanThuLao>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewThanhToanThuLao&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewThanhToanThuLao>"/></returns>
		protected static VList&lt;ViewThanhToanThuLao&gt; Fill(DataTable dataTable, VList<ViewThanhToanThuLao> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewThanhToanThuLao c = new ViewThanhToanThuLao();
					c.MaLoaiGiangVien = (Convert.IsDBNull(row["MaLoaiGiangVien"]))?(int)0:(System.Int32?)row["MaLoaiGiangVien"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.HoDem = (Convert.IsDBNull(row["HoDem"]))?string.Empty:(System.String)row["HoDem"];
					c.Ten = (Convert.IsDBNull(row["Ten"]))?string.Empty:(System.String)row["Ten"];
					c.ChucDanh = (Convert.IsDBNull(row["ChucDanh"]))?string.Empty:(System.String)row["ChucDanh"];
					c.MaDonVi = (Convert.IsDBNull(row["MaDonVi"]))?string.Empty:(System.String)row["MaDonVi"];
					c.TietNghiaVu = (Convert.IsDBNull(row["TietNghiaVu"]))?(int)0:(System.Int32?)row["TietNghiaVu"];
					c.TietGioiHan = (Convert.IsDBNull(row["TietGioiHan"]))?0.0m:(System.Decimal?)row["TietGioiHan"];
					c.TietQuyDoi = (Convert.IsDBNull(row["TietQuyDoi"]))?0.0m:(System.Decimal?)row["TietQuyDoi"];
					c.TietDoAn = (Convert.IsDBNull(row["TietDoAn"]))?0.0m:(System.Decimal?)row["TietDoAn"];
					c.NgoaiGio = (Convert.IsDBNull(row["NgoaiGio"]))?0.0m:(System.Decimal?)row["NgoaiGio"];
					c.DonGia = (Convert.IsDBNull(row["DonGia"]))?0.0m:(System.Decimal?)row["DonGia"];
					c.TienDay = (Convert.IsDBNull(row["TienDay"]))?0.0m:(System.Decimal?)row["TienDay"];
					c.TienDoAn = (Convert.IsDBNull(row["TienDoAn"]))?0.0m:(System.Decimal?)row["TienDoAn"];
					c.TietThieu = (Convert.IsDBNull(row["TietThieu"]))?0.0m:(System.Decimal?)row["TietThieu"];
					c.TietVuot = (Convert.IsDBNull(row["TietVuot"]))?0.0m:(System.Decimal?)row["TietVuot"];
					c.TienVuot = (Convert.IsDBNull(row["TienVuot"]))?0.0m:(System.Decimal?)row["TienVuot"];
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
		/// Fill an <see cref="VList&lt;ViewThanhToanThuLao&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewThanhToanThuLao&gt;"/></returns>
		protected VList<ViewThanhToanThuLao> Fill(IDataReader reader, VList<ViewThanhToanThuLao> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewThanhToanThuLao entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewThanhToanThuLao>("ViewThanhToanThuLao",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewThanhToanThuLao();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaLoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("MaLoaiGiangVien")) ? null : (System.Int32?)reader["MaLoaiGiangVien"];
					//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32?)reader["MaLoaiGiangVien"];
					entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.MaQuanLy = (System.String)reader["MaQuanLy"];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.HoDem = (System.String)reader["HoDem"];
					//entity.HoDem = (Convert.IsDBNull(reader["HoDem"]))?string.Empty:(System.String)reader["HoDem"];
					entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
					//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
					entity.ChucDanh = reader.IsDBNull(reader.GetOrdinal("ChucDanh")) ? null : (System.String)reader["ChucDanh"];
					//entity.ChucDanh = (Convert.IsDBNull(reader["ChucDanh"]))?string.Empty:(System.String)reader["ChucDanh"];
					entity.MaDonVi = reader.IsDBNull(reader.GetOrdinal("MaDonVi")) ? null : (System.String)reader["MaDonVi"];
					//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
					entity.TietNghiaVu = reader.IsDBNull(reader.GetOrdinal("TietNghiaVu")) ? null : (System.Int32?)reader["TietNghiaVu"];
					//entity.TietNghiaVu = (Convert.IsDBNull(reader["TietNghiaVu"]))?(int)0:(System.Int32?)reader["TietNghiaVu"];
					entity.TietGioiHan = reader.IsDBNull(reader.GetOrdinal("TietGioiHan")) ? null : (System.Decimal?)reader["TietGioiHan"];
					//entity.TietGioiHan = (Convert.IsDBNull(reader["TietGioiHan"]))?0.0m:(System.Decimal?)reader["TietGioiHan"];
					entity.TietQuyDoi = reader.IsDBNull(reader.GetOrdinal("TietQuyDoi")) ? null : (System.Decimal?)reader["TietQuyDoi"];
					//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal?)reader["TietQuyDoi"];
					entity.TietDoAn = reader.IsDBNull(reader.GetOrdinal("TietDoAn")) ? null : (System.Decimal?)reader["TietDoAn"];
					//entity.TietDoAn = (Convert.IsDBNull(reader["TietDoAn"]))?0.0m:(System.Decimal?)reader["TietDoAn"];
					entity.NgoaiGio = reader.IsDBNull(reader.GetOrdinal("NgoaiGio")) ? null : (System.Decimal?)reader["NgoaiGio"];
					//entity.NgoaiGio = (Convert.IsDBNull(reader["NgoaiGio"]))?0.0m:(System.Decimal?)reader["NgoaiGio"];
					entity.DonGia = reader.IsDBNull(reader.GetOrdinal("DonGia")) ? null : (System.Decimal?)reader["DonGia"];
					//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal?)reader["DonGia"];
					entity.TienDay = reader.IsDBNull(reader.GetOrdinal("TienDay")) ? null : (System.Decimal?)reader["TienDay"];
					//entity.TienDay = (Convert.IsDBNull(reader["TienDay"]))?0.0m:(System.Decimal?)reader["TienDay"];
					entity.TienDoAn = reader.IsDBNull(reader.GetOrdinal("TienDoAn")) ? null : (System.Decimal?)reader["TienDoAn"];
					//entity.TienDoAn = (Convert.IsDBNull(reader["TienDoAn"]))?0.0m:(System.Decimal?)reader["TienDoAn"];
					entity.TietThieu = reader.IsDBNull(reader.GetOrdinal("TietThieu")) ? null : (System.Decimal?)reader["TietThieu"];
					//entity.TietThieu = (Convert.IsDBNull(reader["TietThieu"]))?0.0m:(System.Decimal?)reader["TietThieu"];
					entity.TietVuot = reader.IsDBNull(reader.GetOrdinal("TietVuot")) ? null : (System.Decimal?)reader["TietVuot"];
					//entity.TietVuot = (Convert.IsDBNull(reader["TietVuot"]))?0.0m:(System.Decimal?)reader["TietVuot"];
					entity.TienVuot = reader.IsDBNull(reader.GetOrdinal("TienVuot")) ? null : (System.Decimal?)reader["TienVuot"];
					//entity.TienVuot = (Convert.IsDBNull(reader["TienVuot"]))?0.0m:(System.Decimal?)reader["TienVuot"];
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
		/// Refreshes the <see cref="ViewThanhToanThuLao"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThanhToanThuLao"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewThanhToanThuLao entity)
		{
			reader.Read();
			entity.MaLoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("MaLoaiGiangVien")) ? null : (System.Int32?)reader["MaLoaiGiangVien"];
			//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32?)reader["MaLoaiGiangVien"];
			entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.MaQuanLy = (System.String)reader["MaQuanLy"];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.HoDem = (System.String)reader["HoDem"];
			//entity.HoDem = (Convert.IsDBNull(reader["HoDem"]))?string.Empty:(System.String)reader["HoDem"];
			entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
			//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
			entity.ChucDanh = reader.IsDBNull(reader.GetOrdinal("ChucDanh")) ? null : (System.String)reader["ChucDanh"];
			//entity.ChucDanh = (Convert.IsDBNull(reader["ChucDanh"]))?string.Empty:(System.String)reader["ChucDanh"];
			entity.MaDonVi = reader.IsDBNull(reader.GetOrdinal("MaDonVi")) ? null : (System.String)reader["MaDonVi"];
			//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
			entity.TietNghiaVu = reader.IsDBNull(reader.GetOrdinal("TietNghiaVu")) ? null : (System.Int32?)reader["TietNghiaVu"];
			//entity.TietNghiaVu = (Convert.IsDBNull(reader["TietNghiaVu"]))?(int)0:(System.Int32?)reader["TietNghiaVu"];
			entity.TietGioiHan = reader.IsDBNull(reader.GetOrdinal("TietGioiHan")) ? null : (System.Decimal?)reader["TietGioiHan"];
			//entity.TietGioiHan = (Convert.IsDBNull(reader["TietGioiHan"]))?0.0m:(System.Decimal?)reader["TietGioiHan"];
			entity.TietQuyDoi = reader.IsDBNull(reader.GetOrdinal("TietQuyDoi")) ? null : (System.Decimal?)reader["TietQuyDoi"];
			//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal?)reader["TietQuyDoi"];
			entity.TietDoAn = reader.IsDBNull(reader.GetOrdinal("TietDoAn")) ? null : (System.Decimal?)reader["TietDoAn"];
			//entity.TietDoAn = (Convert.IsDBNull(reader["TietDoAn"]))?0.0m:(System.Decimal?)reader["TietDoAn"];
			entity.NgoaiGio = reader.IsDBNull(reader.GetOrdinal("NgoaiGio")) ? null : (System.Decimal?)reader["NgoaiGio"];
			//entity.NgoaiGio = (Convert.IsDBNull(reader["NgoaiGio"]))?0.0m:(System.Decimal?)reader["NgoaiGio"];
			entity.DonGia = reader.IsDBNull(reader.GetOrdinal("DonGia")) ? null : (System.Decimal?)reader["DonGia"];
			//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal?)reader["DonGia"];
			entity.TienDay = reader.IsDBNull(reader.GetOrdinal("TienDay")) ? null : (System.Decimal?)reader["TienDay"];
			//entity.TienDay = (Convert.IsDBNull(reader["TienDay"]))?0.0m:(System.Decimal?)reader["TienDay"];
			entity.TienDoAn = reader.IsDBNull(reader.GetOrdinal("TienDoAn")) ? null : (System.Decimal?)reader["TienDoAn"];
			//entity.TienDoAn = (Convert.IsDBNull(reader["TienDoAn"]))?0.0m:(System.Decimal?)reader["TienDoAn"];
			entity.TietThieu = reader.IsDBNull(reader.GetOrdinal("TietThieu")) ? null : (System.Decimal?)reader["TietThieu"];
			//entity.TietThieu = (Convert.IsDBNull(reader["TietThieu"]))?0.0m:(System.Decimal?)reader["TietThieu"];
			entity.TietVuot = reader.IsDBNull(reader.GetOrdinal("TietVuot")) ? null : (System.Decimal?)reader["TietVuot"];
			//entity.TietVuot = (Convert.IsDBNull(reader["TietVuot"]))?0.0m:(System.Decimal?)reader["TietVuot"];
			entity.TienVuot = reader.IsDBNull(reader.GetOrdinal("TienVuot")) ? null : (System.Decimal?)reader["TienVuot"];
			//entity.TienVuot = (Convert.IsDBNull(reader["TienVuot"]))?0.0m:(System.Decimal?)reader["TienVuot"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewThanhToanThuLao"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThanhToanThuLao"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewThanhToanThuLao entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaLoaiGiangVien = (Convert.IsDBNull(dataRow["MaLoaiGiangVien"]))?(int)0:(System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.HoDem = (Convert.IsDBNull(dataRow["HoDem"]))?string.Empty:(System.String)dataRow["HoDem"];
			entity.Ten = (Convert.IsDBNull(dataRow["Ten"]))?string.Empty:(System.String)dataRow["Ten"];
			entity.ChucDanh = (Convert.IsDBNull(dataRow["ChucDanh"]))?string.Empty:(System.String)dataRow["ChucDanh"];
			entity.MaDonVi = (Convert.IsDBNull(dataRow["MaDonVi"]))?string.Empty:(System.String)dataRow["MaDonVi"];
			entity.TietNghiaVu = (Convert.IsDBNull(dataRow["TietNghiaVu"]))?(int)0:(System.Int32?)dataRow["TietNghiaVu"];
			entity.TietGioiHan = (Convert.IsDBNull(dataRow["TietGioiHan"]))?0.0m:(System.Decimal?)dataRow["TietGioiHan"];
			entity.TietQuyDoi = (Convert.IsDBNull(dataRow["TietQuyDoi"]))?0.0m:(System.Decimal?)dataRow["TietQuyDoi"];
			entity.TietDoAn = (Convert.IsDBNull(dataRow["TietDoAn"]))?0.0m:(System.Decimal?)dataRow["TietDoAn"];
			entity.NgoaiGio = (Convert.IsDBNull(dataRow["NgoaiGio"]))?0.0m:(System.Decimal?)dataRow["NgoaiGio"];
			entity.DonGia = (Convert.IsDBNull(dataRow["DonGia"]))?0.0m:(System.Decimal?)dataRow["DonGia"];
			entity.TienDay = (Convert.IsDBNull(dataRow["TienDay"]))?0.0m:(System.Decimal?)dataRow["TienDay"];
			entity.TienDoAn = (Convert.IsDBNull(dataRow["TienDoAn"]))?0.0m:(System.Decimal?)dataRow["TienDoAn"];
			entity.TietThieu = (Convert.IsDBNull(dataRow["TietThieu"]))?0.0m:(System.Decimal?)dataRow["TietThieu"];
			entity.TietVuot = (Convert.IsDBNull(dataRow["TietVuot"]))?0.0m:(System.Decimal?)dataRow["TietVuot"];
			entity.TienVuot = (Convert.IsDBNull(dataRow["TienVuot"]))?0.0m:(System.Decimal?)dataRow["TienVuot"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewThanhToanThuLaoFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThanhToanThuLaoFilterBuilder : SqlFilterBuilder<ViewThanhToanThuLaoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThanhToanThuLaoFilterBuilder class.
		/// </summary>
		public ViewThanhToanThuLaoFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThanhToanThuLaoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThanhToanThuLaoFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThanhToanThuLaoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThanhToanThuLaoFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThanhToanThuLaoFilterBuilder

	#region ViewThanhToanThuLaoParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThanhToanThuLaoParameterBuilder : ParameterizedSqlFilterBuilder<ViewThanhToanThuLaoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThanhToanThuLaoParameterBuilder class.
		/// </summary>
		public ViewThanhToanThuLaoParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThanhToanThuLaoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThanhToanThuLaoParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThanhToanThuLaoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThanhToanThuLaoParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThanhToanThuLaoParameterBuilder
	
	#region ViewThanhToanThuLaoSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThanhToanThuLao"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewThanhToanThuLaoSortBuilder : SqlSortBuilder<ViewThanhToanThuLaoColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThanhToanThuLaoSqlSortBuilder class.
		/// </summary>
		public ViewThanhToanThuLaoSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewThanhToanThuLaoSortBuilder

} // end namespace
