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
	/// This class is the base class for any <see cref="ViewChiTietPhanCongGiangDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewChiTietPhanCongGiangDayProviderBaseCore : EntityViewProviderBase<ViewChiTietPhanCongGiangDay>
	{
		#region Custom Methods
		
		
		#region cust_View_ChiTiet_PhanCongGiangDay_GetByMaLopHocPhan
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_PhanCongGiangDay_GetByMaLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewChiTietPhanCongGiangDay&gt;"/> instance.</returns>
		public VList<ViewChiTietPhanCongGiangDay> GetByMaLopHocPhan(System.String maLopHocPhan)
		{
			return GetByMaLopHocPhan(null, 0, int.MaxValue , maLopHocPhan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_PhanCongGiangDay_GetByMaLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewChiTietPhanCongGiangDay&gt;"/> instance.</returns>
		public VList<ViewChiTietPhanCongGiangDay> GetByMaLopHocPhan(int start, int pageLength, System.String maLopHocPhan)
		{
			return GetByMaLopHocPhan(null, start, pageLength , maLopHocPhan);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_PhanCongGiangDay_GetByMaLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewChiTietPhanCongGiangDay&gt;"/> instance.</returns>
		public VList<ViewChiTietPhanCongGiangDay> GetByMaLopHocPhan(TransactionManager transactionManager, System.String maLopHocPhan)
		{
			return GetByMaLopHocPhan(transactionManager, 0, int.MaxValue , maLopHocPhan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_PhanCongGiangDay_GetByMaLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewChiTietPhanCongGiangDay&gt;"/> instance.</returns>
		public abstract VList<ViewChiTietPhanCongGiangDay> GetByMaLopHocPhan(TransactionManager transactionManager, int start, int pageLength, System.String maLopHocPhan);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewChiTietPhanCongGiangDay&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewChiTietPhanCongGiangDay&gt;"/></returns>
		protected static VList&lt;ViewChiTietPhanCongGiangDay&gt; Fill(DataSet dataSet, VList<ViewChiTietPhanCongGiangDay> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewChiTietPhanCongGiangDay>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewChiTietPhanCongGiangDay&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewChiTietPhanCongGiangDay>"/></returns>
		protected static VList&lt;ViewChiTietPhanCongGiangDay&gt; Fill(DataTable dataTable, VList<ViewChiTietPhanCongGiangDay> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewChiTietPhanCongGiangDay c = new ViewChiTietPhanCongGiangDay();
					c.MaLhpGoc = (Convert.IsDBNull(row["MaLHPGoc"]))?string.Empty:(System.String)row["MaLHPGoc"];
					c.MaLhp = (Convert.IsDBNull(row["MaLHP"]))?string.Empty:(System.String)row["MaLHP"];
					c.MaHp = (Convert.IsDBNull(row["MaHP"]))?string.Empty:(System.String)row["MaHP"];
					c.TenLhp = (Convert.IsDBNull(row["TenLHP"]))?string.Empty:(System.String)row["TenLHP"];
					c.MaMonHoc = (Convert.IsDBNull(row["MaMonHoc"]))?string.Empty:(System.String)row["MaMonHoc"];
					c.MaNhom = (Convert.IsDBNull(row["MaNhom"]))?string.Empty:(System.String)row["MaNhom"];
					c.TenNhom = (Convert.IsDBNull(row["TenNhom"]))?string.Empty:(System.String)row["TenNhom"];
					c.TenLoaiHp = (Convert.IsDBNull(row["TenLoaiHP"]))?string.Empty:(System.String)row["TenLoaiHP"];
					c.MaLich = (Convert.IsDBNull(row["MaLich"]))?(int)0:(System.Int32)row["MaLich"];
					c.Nam = (Convert.IsDBNull(row["Nam"]))?(int)0:(System.Int32?)row["Nam"];
					c.Tuan = (Convert.IsDBNull(row["Tuan"]))?(int)0:(System.Int32?)row["Tuan"];
					c.TuanHienThi = (Convert.IsDBNull(row["TuanHienThi"]))?(int)0:(System.Int32)row["TuanHienThi"];
					c.MaNgayTrongTuan = (Convert.IsDBNull(row["MaNgayTrongTuan"]))?(int)0:(System.Int32?)row["MaNgayTrongTuan"];
					c.NgayTrongTuan = (Convert.IsDBNull(row["NgayTrongTuan"]))?string.Empty:(System.String)row["NgayTrongTuan"];
					c.MaTiet = (Convert.IsDBNull(row["MaTiet"]))?(int)0:(System.Int32?)row["MaTiet"];
					c.KhoanTiet = (Convert.IsDBNull(row["KhoanTiet"]))?string.Empty:(System.String)row["KhoanTiet"];
					c.SoTiet = (Convert.IsDBNull(row["SoTiet"]))?(int)0:(System.Int32?)row["SoTiet"];
					c.MaPhong = (Convert.IsDBNull(row["MaPhong"]))?string.Empty:(System.String)row["MaPhong"];
					c.TenPhong = (Convert.IsDBNull(row["TenPhong"]))?string.Empty:(System.String)row["TenPhong"];
					c.NgayDay = (Convert.IsDBNull(row["NgayDay"]))?string.Empty:(System.String)row["NgayDay"];
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?string.Empty:(System.String)row["MaGiangVien"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.DanhSachLop = (Convert.IsDBNull(row["DanhSachLop"]))?string.Empty:(System.String)row["DanhSachLop"];
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
		/// Fill an <see cref="VList&lt;ViewChiTietPhanCongGiangDay&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewChiTietPhanCongGiangDay&gt;"/></returns>
		protected VList<ViewChiTietPhanCongGiangDay> Fill(IDataReader reader, VList<ViewChiTietPhanCongGiangDay> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewChiTietPhanCongGiangDay entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewChiTietPhanCongGiangDay>("ViewChiTietPhanCongGiangDay",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewChiTietPhanCongGiangDay();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaLhpGoc = (System.String)reader["MaLhpGoc"];
					//entity.MaLhpGoc = (Convert.IsDBNull(reader["MaLHPGoc"]))?string.Empty:(System.String)reader["MaLHPGoc"];
					entity.MaLhp = reader.IsDBNull(reader.GetOrdinal("MaLhp")) ? null : (System.String)reader["MaLhp"];
					//entity.MaLhp = (Convert.IsDBNull(reader["MaLHP"]))?string.Empty:(System.String)reader["MaLHP"];
					entity.MaHp = (System.String)reader["MaHp"];
					//entity.MaHp = (Convert.IsDBNull(reader["MaHP"]))?string.Empty:(System.String)reader["MaHP"];
					entity.TenLhp = reader.IsDBNull(reader.GetOrdinal("TenLhp")) ? null : (System.String)reader["TenLhp"];
					//entity.TenLhp = (Convert.IsDBNull(reader["TenLHP"]))?string.Empty:(System.String)reader["TenLHP"];
					entity.MaMonHoc = (System.String)reader["MaMonHoc"];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.MaNhom = reader.IsDBNull(reader.GetOrdinal("MaNhom")) ? null : (System.String)reader["MaNhom"];
					//entity.MaNhom = (Convert.IsDBNull(reader["MaNhom"]))?string.Empty:(System.String)reader["MaNhom"];
					entity.TenNhom = (System.String)reader["TenNhom"];
					//entity.TenNhom = (Convert.IsDBNull(reader["TenNhom"]))?string.Empty:(System.String)reader["TenNhom"];
					entity.TenLoaiHp = (System.String)reader["TenLoaiHp"];
					//entity.TenLoaiHp = (Convert.IsDBNull(reader["TenLoaiHP"]))?string.Empty:(System.String)reader["TenLoaiHP"];
					entity.MaLich = (System.Int32)reader["MaLich"];
					//entity.MaLich = (Convert.IsDBNull(reader["MaLich"]))?(int)0:(System.Int32)reader["MaLich"];
					entity.Nam = reader.IsDBNull(reader.GetOrdinal("Nam")) ? null : (System.Int32?)reader["Nam"];
					//entity.Nam = (Convert.IsDBNull(reader["Nam"]))?(int)0:(System.Int32?)reader["Nam"];
					entity.Tuan = reader.IsDBNull(reader.GetOrdinal("Tuan")) ? null : (System.Int32?)reader["Tuan"];
					//entity.Tuan = (Convert.IsDBNull(reader["Tuan"]))?(int)0:(System.Int32?)reader["Tuan"];
					entity.TuanHienThi = (System.Int32)reader["TuanHienThi"];
					//entity.TuanHienThi = (Convert.IsDBNull(reader["TuanHienThi"]))?(int)0:(System.Int32)reader["TuanHienThi"];
					entity.MaNgayTrongTuan = reader.IsDBNull(reader.GetOrdinal("MaNgayTrongTuan")) ? null : (System.Int32?)reader["MaNgayTrongTuan"];
					//entity.MaNgayTrongTuan = (Convert.IsDBNull(reader["MaNgayTrongTuan"]))?(int)0:(System.Int32?)reader["MaNgayTrongTuan"];
					entity.NgayTrongTuan = reader.IsDBNull(reader.GetOrdinal("NgayTrongTuan")) ? null : (System.String)reader["NgayTrongTuan"];
					//entity.NgayTrongTuan = (Convert.IsDBNull(reader["NgayTrongTuan"]))?string.Empty:(System.String)reader["NgayTrongTuan"];
					entity.MaTiet = reader.IsDBNull(reader.GetOrdinal("MaTiet")) ? null : (System.Int32?)reader["MaTiet"];
					//entity.MaTiet = (Convert.IsDBNull(reader["MaTiet"]))?(int)0:(System.Int32?)reader["MaTiet"];
					entity.KhoanTiet = reader.IsDBNull(reader.GetOrdinal("KhoanTiet")) ? null : (System.String)reader["KhoanTiet"];
					//entity.KhoanTiet = (Convert.IsDBNull(reader["KhoanTiet"]))?string.Empty:(System.String)reader["KhoanTiet"];
					entity.SoTiet = reader.IsDBNull(reader.GetOrdinal("SoTiet")) ? null : (System.Int32?)reader["SoTiet"];
					//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32?)reader["SoTiet"];
					entity.MaPhong = reader.IsDBNull(reader.GetOrdinal("MaPhong")) ? null : (System.String)reader["MaPhong"];
					//entity.MaPhong = (Convert.IsDBNull(reader["MaPhong"]))?string.Empty:(System.String)reader["MaPhong"];
					entity.TenPhong = (System.String)reader["TenPhong"];
					//entity.TenPhong = (Convert.IsDBNull(reader["TenPhong"]))?string.Empty:(System.String)reader["TenPhong"];
					entity.NgayDay = reader.IsDBNull(reader.GetOrdinal("NgayDay")) ? null : (System.String)reader["NgayDay"];
					//entity.NgayDay = (Convert.IsDBNull(reader["NgayDay"]))?string.Empty:(System.String)reader["NgayDay"];
					entity.MaGiangVien = reader.IsDBNull(reader.GetOrdinal("MaGiangVien")) ? null : (System.String)reader["MaGiangVien"];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?string.Empty:(System.String)reader["MaGiangVien"];
					entity.HoTen = (System.String)reader["HoTen"];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.DanhSachLop = reader.IsDBNull(reader.GetOrdinal("DanhSachLop")) ? null : (System.String)reader["DanhSachLop"];
					//entity.DanhSachLop = (Convert.IsDBNull(reader["DanhSachLop"]))?string.Empty:(System.String)reader["DanhSachLop"];
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
		/// Refreshes the <see cref="ViewChiTietPhanCongGiangDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewChiTietPhanCongGiangDay"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewChiTietPhanCongGiangDay entity)
		{
			reader.Read();
			entity.MaLhpGoc = (System.String)reader["MaLhpGoc"];
			//entity.MaLhpGoc = (Convert.IsDBNull(reader["MaLHPGoc"]))?string.Empty:(System.String)reader["MaLHPGoc"];
			entity.MaLhp = reader.IsDBNull(reader.GetOrdinal("MaLhp")) ? null : (System.String)reader["MaLhp"];
			//entity.MaLhp = (Convert.IsDBNull(reader["MaLHP"]))?string.Empty:(System.String)reader["MaLHP"];
			entity.MaHp = (System.String)reader["MaHp"];
			//entity.MaHp = (Convert.IsDBNull(reader["MaHP"]))?string.Empty:(System.String)reader["MaHP"];
			entity.TenLhp = reader.IsDBNull(reader.GetOrdinal("TenLhp")) ? null : (System.String)reader["TenLhp"];
			//entity.TenLhp = (Convert.IsDBNull(reader["TenLHP"]))?string.Empty:(System.String)reader["TenLHP"];
			entity.MaMonHoc = (System.String)reader["MaMonHoc"];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.MaNhom = reader.IsDBNull(reader.GetOrdinal("MaNhom")) ? null : (System.String)reader["MaNhom"];
			//entity.MaNhom = (Convert.IsDBNull(reader["MaNhom"]))?string.Empty:(System.String)reader["MaNhom"];
			entity.TenNhom = (System.String)reader["TenNhom"];
			//entity.TenNhom = (Convert.IsDBNull(reader["TenNhom"]))?string.Empty:(System.String)reader["TenNhom"];
			entity.TenLoaiHp = (System.String)reader["TenLoaiHp"];
			//entity.TenLoaiHp = (Convert.IsDBNull(reader["TenLoaiHP"]))?string.Empty:(System.String)reader["TenLoaiHP"];
			entity.MaLich = (System.Int32)reader["MaLich"];
			//entity.MaLich = (Convert.IsDBNull(reader["MaLich"]))?(int)0:(System.Int32)reader["MaLich"];
			entity.Nam = reader.IsDBNull(reader.GetOrdinal("Nam")) ? null : (System.Int32?)reader["Nam"];
			//entity.Nam = (Convert.IsDBNull(reader["Nam"]))?(int)0:(System.Int32?)reader["Nam"];
			entity.Tuan = reader.IsDBNull(reader.GetOrdinal("Tuan")) ? null : (System.Int32?)reader["Tuan"];
			//entity.Tuan = (Convert.IsDBNull(reader["Tuan"]))?(int)0:(System.Int32?)reader["Tuan"];
			entity.TuanHienThi = (System.Int32)reader["TuanHienThi"];
			//entity.TuanHienThi = (Convert.IsDBNull(reader["TuanHienThi"]))?(int)0:(System.Int32)reader["TuanHienThi"];
			entity.MaNgayTrongTuan = reader.IsDBNull(reader.GetOrdinal("MaNgayTrongTuan")) ? null : (System.Int32?)reader["MaNgayTrongTuan"];
			//entity.MaNgayTrongTuan = (Convert.IsDBNull(reader["MaNgayTrongTuan"]))?(int)0:(System.Int32?)reader["MaNgayTrongTuan"];
			entity.NgayTrongTuan = reader.IsDBNull(reader.GetOrdinal("NgayTrongTuan")) ? null : (System.String)reader["NgayTrongTuan"];
			//entity.NgayTrongTuan = (Convert.IsDBNull(reader["NgayTrongTuan"]))?string.Empty:(System.String)reader["NgayTrongTuan"];
			entity.MaTiet = reader.IsDBNull(reader.GetOrdinal("MaTiet")) ? null : (System.Int32?)reader["MaTiet"];
			//entity.MaTiet = (Convert.IsDBNull(reader["MaTiet"]))?(int)0:(System.Int32?)reader["MaTiet"];
			entity.KhoanTiet = reader.IsDBNull(reader.GetOrdinal("KhoanTiet")) ? null : (System.String)reader["KhoanTiet"];
			//entity.KhoanTiet = (Convert.IsDBNull(reader["KhoanTiet"]))?string.Empty:(System.String)reader["KhoanTiet"];
			entity.SoTiet = reader.IsDBNull(reader.GetOrdinal("SoTiet")) ? null : (System.Int32?)reader["SoTiet"];
			//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32?)reader["SoTiet"];
			entity.MaPhong = reader.IsDBNull(reader.GetOrdinal("MaPhong")) ? null : (System.String)reader["MaPhong"];
			//entity.MaPhong = (Convert.IsDBNull(reader["MaPhong"]))?string.Empty:(System.String)reader["MaPhong"];
			entity.TenPhong = (System.String)reader["TenPhong"];
			//entity.TenPhong = (Convert.IsDBNull(reader["TenPhong"]))?string.Empty:(System.String)reader["TenPhong"];
			entity.NgayDay = reader.IsDBNull(reader.GetOrdinal("NgayDay")) ? null : (System.String)reader["NgayDay"];
			//entity.NgayDay = (Convert.IsDBNull(reader["NgayDay"]))?string.Empty:(System.String)reader["NgayDay"];
			entity.MaGiangVien = reader.IsDBNull(reader.GetOrdinal("MaGiangVien")) ? null : (System.String)reader["MaGiangVien"];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?string.Empty:(System.String)reader["MaGiangVien"];
			entity.HoTen = (System.String)reader["HoTen"];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.DanhSachLop = reader.IsDBNull(reader.GetOrdinal("DanhSachLop")) ? null : (System.String)reader["DanhSachLop"];
			//entity.DanhSachLop = (Convert.IsDBNull(reader["DanhSachLop"]))?string.Empty:(System.String)reader["DanhSachLop"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewChiTietPhanCongGiangDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewChiTietPhanCongGiangDay"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewChiTietPhanCongGiangDay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaLhpGoc = (Convert.IsDBNull(dataRow["MaLHPGoc"]))?string.Empty:(System.String)dataRow["MaLHPGoc"];
			entity.MaLhp = (Convert.IsDBNull(dataRow["MaLHP"]))?string.Empty:(System.String)dataRow["MaLHP"];
			entity.MaHp = (Convert.IsDBNull(dataRow["MaHP"]))?string.Empty:(System.String)dataRow["MaHP"];
			entity.TenLhp = (Convert.IsDBNull(dataRow["TenLHP"]))?string.Empty:(System.String)dataRow["TenLHP"];
			entity.MaMonHoc = (Convert.IsDBNull(dataRow["MaMonHoc"]))?string.Empty:(System.String)dataRow["MaMonHoc"];
			entity.MaNhom = (Convert.IsDBNull(dataRow["MaNhom"]))?string.Empty:(System.String)dataRow["MaNhom"];
			entity.TenNhom = (Convert.IsDBNull(dataRow["TenNhom"]))?string.Empty:(System.String)dataRow["TenNhom"];
			entity.TenLoaiHp = (Convert.IsDBNull(dataRow["TenLoaiHP"]))?string.Empty:(System.String)dataRow["TenLoaiHP"];
			entity.MaLich = (Convert.IsDBNull(dataRow["MaLich"]))?(int)0:(System.Int32)dataRow["MaLich"];
			entity.Nam = (Convert.IsDBNull(dataRow["Nam"]))?(int)0:(System.Int32?)dataRow["Nam"];
			entity.Tuan = (Convert.IsDBNull(dataRow["Tuan"]))?(int)0:(System.Int32?)dataRow["Tuan"];
			entity.TuanHienThi = (Convert.IsDBNull(dataRow["TuanHienThi"]))?(int)0:(System.Int32)dataRow["TuanHienThi"];
			entity.MaNgayTrongTuan = (Convert.IsDBNull(dataRow["MaNgayTrongTuan"]))?(int)0:(System.Int32?)dataRow["MaNgayTrongTuan"];
			entity.NgayTrongTuan = (Convert.IsDBNull(dataRow["NgayTrongTuan"]))?string.Empty:(System.String)dataRow["NgayTrongTuan"];
			entity.MaTiet = (Convert.IsDBNull(dataRow["MaTiet"]))?(int)0:(System.Int32?)dataRow["MaTiet"];
			entity.KhoanTiet = (Convert.IsDBNull(dataRow["KhoanTiet"]))?string.Empty:(System.String)dataRow["KhoanTiet"];
			entity.SoTiet = (Convert.IsDBNull(dataRow["SoTiet"]))?(int)0:(System.Int32?)dataRow["SoTiet"];
			entity.MaPhong = (Convert.IsDBNull(dataRow["MaPhong"]))?string.Empty:(System.String)dataRow["MaPhong"];
			entity.TenPhong = (Convert.IsDBNull(dataRow["TenPhong"]))?string.Empty:(System.String)dataRow["TenPhong"];
			entity.NgayDay = (Convert.IsDBNull(dataRow["NgayDay"]))?string.Empty:(System.String)dataRow["NgayDay"];
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?string.Empty:(System.String)dataRow["MaGiangVien"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.DanhSachLop = (Convert.IsDBNull(dataRow["DanhSachLop"]))?string.Empty:(System.String)dataRow["DanhSachLop"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewChiTietPhanCongGiangDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTietPhanCongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewChiTietPhanCongGiangDayFilterBuilder : SqlFilterBuilder<ViewChiTietPhanCongGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTietPhanCongGiangDayFilterBuilder class.
		/// </summary>
		public ViewChiTietPhanCongGiangDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTietPhanCongGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewChiTietPhanCongGiangDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTietPhanCongGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewChiTietPhanCongGiangDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewChiTietPhanCongGiangDayFilterBuilder

	#region ViewChiTietPhanCongGiangDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTietPhanCongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewChiTietPhanCongGiangDayParameterBuilder : ParameterizedSqlFilterBuilder<ViewChiTietPhanCongGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTietPhanCongGiangDayParameterBuilder class.
		/// </summary>
		public ViewChiTietPhanCongGiangDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTietPhanCongGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewChiTietPhanCongGiangDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTietPhanCongGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewChiTietPhanCongGiangDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewChiTietPhanCongGiangDayParameterBuilder
	
	#region ViewChiTietPhanCongGiangDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTietPhanCongGiangDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewChiTietPhanCongGiangDaySortBuilder : SqlSortBuilder<ViewChiTietPhanCongGiangDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTietPhanCongGiangDaySqlSortBuilder class.
		/// </summary>
		public ViewChiTietPhanCongGiangDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewChiTietPhanCongGiangDaySortBuilder

} // end namespace
