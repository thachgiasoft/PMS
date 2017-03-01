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
	/// This class is the base class for any <see cref="ViewLuongGiangVienTheoNgayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewLuongGiangVienTheoNgayProviderBaseCore : EntityViewProviderBase<ViewLuongGiangVienTheoNgay>
	{
		#region Custom Methods
		
		
		#region cust_View_Luong_GiangVien_TheoNgay_GetByNgay
		
		/// <summary>
		///	This method wrap the 'cust_View_Luong_GiangVien_TheoNgay_GetByNgay' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewLuongGiangVienTheoNgay&gt;"/> instance.</returns>
		public VList<ViewLuongGiangVienTheoNgay> GetByNgay(System.String maBacDaoTao, System.String maHeDaoTao, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByNgay(null, 0, int.MaxValue , maBacDaoTao, maHeDaoTao, tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Luong_GiangVien_TheoNgay_GetByNgay' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewLuongGiangVienTheoNgay&gt;"/> instance.</returns>
		public VList<ViewLuongGiangVienTheoNgay> GetByNgay(int start, int pageLength, System.String maBacDaoTao, System.String maHeDaoTao, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByNgay(null, start, pageLength , maBacDaoTao, maHeDaoTao, tuNgay, denNgay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_Luong_GiangVien_TheoNgay_GetByNgay' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewLuongGiangVienTheoNgay&gt;"/> instance.</returns>
		public VList<ViewLuongGiangVienTheoNgay> GetByNgay(TransactionManager transactionManager, System.String maBacDaoTao, System.String maHeDaoTao, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByNgay(transactionManager, 0, int.MaxValue , maBacDaoTao, maHeDaoTao, tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Luong_GiangVien_TheoNgay_GetByNgay' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewLuongGiangVienTheoNgay&gt;"/> instance.</returns>
		public abstract VList<ViewLuongGiangVienTheoNgay> GetByNgay(TransactionManager transactionManager, int start, int pageLength, System.String maBacDaoTao, System.String maHeDaoTao, System.DateTime tuNgay, System.DateTime denNgay);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewLuongGiangVienTheoNgay&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewLuongGiangVienTheoNgay&gt;"/></returns>
		protected static VList&lt;ViewLuongGiangVienTheoNgay&gt; Fill(DataSet dataSet, VList<ViewLuongGiangVienTheoNgay> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewLuongGiangVienTheoNgay>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewLuongGiangVienTheoNgay&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewLuongGiangVienTheoNgay>"/></returns>
		protected static VList&lt;ViewLuongGiangVienTheoNgay&gt; Fill(DataTable dataTable, VList<ViewLuongGiangVienTheoNgay> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewLuongGiangVienTheoNgay c = new ViewLuongGiangVienTheoNgay();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32)row["MaGiangVien"];
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.Ho = (Convert.IsDBNull(row["Ho"]))?string.Empty:(System.String)row["Ho"];
					c.Ten = (Convert.IsDBNull(row["Ten"]))?string.Empty:(System.String)row["Ten"];
					c.SoTaiKhoan = (Convert.IsDBNull(row["SoTaiKhoan"]))?string.Empty:(System.String)row["SoTaiKhoan"];
					c.MaLop = (Convert.IsDBNull(row["MaLop"]))?string.Empty:(System.String)row["MaLop"];
					c.MaMonHoc = (Convert.IsDBNull(row["MaMonHoc"]))?string.Empty:(System.String)row["MaMonHoc"];
					c.TenMonHoc = (Convert.IsDBNull(row["TenMonHoc"]))?string.Empty:(System.String)row["TenMonHoc"];
					c.MaLopHocPhan = (Convert.IsDBNull(row["MaLopHocPhan"]))?string.Empty:(System.String)row["MaLopHocPhan"];
					c.TenLopHocPhan = (Convert.IsDBNull(row["TenLopHocPhan"]))?string.Empty:(System.String)row["TenLopHocPhan"];
					c.NgayBatDau = (Convert.IsDBNull(row["NgayBatDau"]))?string.Empty:(System.String)row["NgayBatDau"];
					c.NgayKetThuc = (Convert.IsDBNull(row["NgayKetThuc"]))?string.Empty:(System.String)row["NgayKetThuc"];
					c.TrongGio = (Convert.IsDBNull(row["TrongGio"]))?0.0m:(System.Decimal?)row["TrongGio"];
					c.NgoaiGio = (Convert.IsDBNull(row["NgoaiGio"]))?0.0m:(System.Decimal?)row["NgoaiGio"];
					c.TietQuyDoi = (Convert.IsDBNull(row["TietQuyDoi"]))?0.0m:(System.Decimal?)row["TietQuyDoi"];
					c.SiSoLop = (Convert.IsDBNull(row["SiSoLop"]))?(int)0:(System.Int32?)row["SiSoLop"];
					c.MaBacDaoTao = (Convert.IsDBNull(row["MaBacDaoTao"]))?string.Empty:(System.String)row["MaBacDaoTao"];
					c.MaHeDaoTao = (Convert.IsDBNull(row["MaHeDaoTao"]))?string.Empty:(System.String)row["MaHeDaoTao"];
					c.MaLoaiGiangVien = (Convert.IsDBNull(row["MaLoaiGiangVien"]))?string.Empty:(System.String)row["MaLoaiGiangVien"];
					c.SoTien = (Convert.IsDBNull(row["SoTien"]))?0:(System.Decimal?)row["SoTien"];
					c.TienTruocThue = (Convert.IsDBNull(row["TienTruocThue"]))?0.0m:(System.Decimal?)row["TienTruocThue"];
					c.TienThue = (Convert.IsDBNull(row["TienThue"]))?0.0m:(System.Decimal?)row["TienThue"];
					c.TienSauThue = (Convert.IsDBNull(row["TienSauThue"]))?0.0m:(System.Decimal?)row["TienSauThue"];
					c.NgayDay = (Convert.IsDBNull(row["NgayDay"]))?DateTime.MinValue:(System.DateTime?)row["NgayDay"];
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
		/// Fill an <see cref="VList&lt;ViewLuongGiangVienTheoNgay&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewLuongGiangVienTheoNgay&gt;"/></returns>
		protected VList<ViewLuongGiangVienTheoNgay> Fill(IDataReader reader, VList<ViewLuongGiangVienTheoNgay> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewLuongGiangVienTheoNgay entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewLuongGiangVienTheoNgay>("ViewLuongGiangVienTheoNgay",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewLuongGiangVienTheoNgay();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = (System.Int32)reader[((int)ViewLuongGiangVienTheoNgayColumn.MaGiangVien)];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
					entity.MaQuanLy = (System.String)reader[((int)ViewLuongGiangVienTheoNgayColumn.MaQuanLy)];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.Ho = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.Ho)))?null:(System.String)reader[((int)ViewLuongGiangVienTheoNgayColumn.Ho)];
					//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
					entity.Ten = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.Ten)))?null:(System.String)reader[((int)ViewLuongGiangVienTheoNgayColumn.Ten)];
					//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
					entity.SoTaiKhoan = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.SoTaiKhoan)))?null:(System.String)reader[((int)ViewLuongGiangVienTheoNgayColumn.SoTaiKhoan)];
					//entity.SoTaiKhoan = (Convert.IsDBNull(reader["SoTaiKhoan"]))?string.Empty:(System.String)reader["SoTaiKhoan"];
					entity.MaLop = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.MaLop)))?null:(System.String)reader[((int)ViewLuongGiangVienTheoNgayColumn.MaLop)];
					//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
					entity.MaMonHoc = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.MaMonHoc)))?null:(System.String)reader[((int)ViewLuongGiangVienTheoNgayColumn.MaMonHoc)];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.TenMonHoc = (System.String)reader[((int)ViewLuongGiangVienTheoNgayColumn.TenMonHoc)];
					//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
					entity.MaLopHocPhan = (System.String)reader[((int)ViewLuongGiangVienTheoNgayColumn.MaLopHocPhan)];
					//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
					entity.TenLopHocPhan = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.TenLopHocPhan)))?null:(System.String)reader[((int)ViewLuongGiangVienTheoNgayColumn.TenLopHocPhan)];
					//entity.TenLopHocPhan = (Convert.IsDBNull(reader["TenLopHocPhan"]))?string.Empty:(System.String)reader["TenLopHocPhan"];
					entity.NgayBatDau = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.NgayBatDau)))?null:(System.String)reader[((int)ViewLuongGiangVienTheoNgayColumn.NgayBatDau)];
					//entity.NgayBatDau = (Convert.IsDBNull(reader["NgayBatDau"]))?string.Empty:(System.String)reader["NgayBatDau"];
					entity.NgayKetThuc = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.NgayKetThuc)))?null:(System.String)reader[((int)ViewLuongGiangVienTheoNgayColumn.NgayKetThuc)];
					//entity.NgayKetThuc = (Convert.IsDBNull(reader["NgayKetThuc"]))?string.Empty:(System.String)reader["NgayKetThuc"];
					entity.TrongGio = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.TrongGio)))?null:(System.Decimal?)reader[((int)ViewLuongGiangVienTheoNgayColumn.TrongGio)];
					//entity.TrongGio = (Convert.IsDBNull(reader["TrongGio"]))?0.0m:(System.Decimal?)reader["TrongGio"];
					entity.NgoaiGio = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.NgoaiGio)))?null:(System.Decimal?)reader[((int)ViewLuongGiangVienTheoNgayColumn.NgoaiGio)];
					//entity.NgoaiGio = (Convert.IsDBNull(reader["NgoaiGio"]))?0.0m:(System.Decimal?)reader["NgoaiGio"];
					entity.TietQuyDoi = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.TietQuyDoi)))?null:(System.Decimal?)reader[((int)ViewLuongGiangVienTheoNgayColumn.TietQuyDoi)];
					//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal?)reader["TietQuyDoi"];
					entity.SiSoLop = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.SiSoLop)))?null:(System.Int32?)reader[((int)ViewLuongGiangVienTheoNgayColumn.SiSoLop)];
					//entity.SiSoLop = (Convert.IsDBNull(reader["SiSoLop"]))?(int)0:(System.Int32?)reader["SiSoLop"];
					entity.MaBacDaoTao = (System.String)reader[((int)ViewLuongGiangVienTheoNgayColumn.MaBacDaoTao)];
					//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
					entity.MaHeDaoTao = (System.String)reader[((int)ViewLuongGiangVienTheoNgayColumn.MaHeDaoTao)];
					//entity.MaHeDaoTao = (Convert.IsDBNull(reader["MaHeDaoTao"]))?string.Empty:(System.String)reader["MaHeDaoTao"];
					entity.MaLoaiGiangVien = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.MaLoaiGiangVien)))?null:(System.String)reader[((int)ViewLuongGiangVienTheoNgayColumn.MaLoaiGiangVien)];
					//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?string.Empty:(System.String)reader["MaLoaiGiangVien"];
					entity.SoTien = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.SoTien)))?null:(System.Decimal?)reader[((int)ViewLuongGiangVienTheoNgayColumn.SoTien)];
					//entity.SoTien = (Convert.IsDBNull(reader["SoTien"]))?0:(System.Decimal?)reader["SoTien"];
					entity.TienTruocThue = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.TienTruocThue)))?null:(System.Decimal?)reader[((int)ViewLuongGiangVienTheoNgayColumn.TienTruocThue)];
					//entity.TienTruocThue = (Convert.IsDBNull(reader["TienTruocThue"]))?0.0m:(System.Decimal?)reader["TienTruocThue"];
					entity.TienThue = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.TienThue)))?null:(System.Decimal?)reader[((int)ViewLuongGiangVienTheoNgayColumn.TienThue)];
					//entity.TienThue = (Convert.IsDBNull(reader["TienThue"]))?0.0m:(System.Decimal?)reader["TienThue"];
					entity.TienSauThue = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.TienSauThue)))?null:(System.Decimal?)reader[((int)ViewLuongGiangVienTheoNgayColumn.TienSauThue)];
					//entity.TienSauThue = (Convert.IsDBNull(reader["TienSauThue"]))?0.0m:(System.Decimal?)reader["TienSauThue"];
					entity.NgayDay = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.NgayDay)))?null:(System.DateTime?)reader[((int)ViewLuongGiangVienTheoNgayColumn.NgayDay)];
					//entity.NgayDay = (Convert.IsDBNull(reader["NgayDay"]))?DateTime.MinValue:(System.DateTime?)reader["NgayDay"];
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
		/// Refreshes the <see cref="ViewLuongGiangVienTheoNgay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewLuongGiangVienTheoNgay"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewLuongGiangVienTheoNgay entity)
		{
			reader.Read();
			entity.MaGiangVien = (System.Int32)reader[((int)ViewLuongGiangVienTheoNgayColumn.MaGiangVien)];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
			entity.MaQuanLy = (System.String)reader[((int)ViewLuongGiangVienTheoNgayColumn.MaQuanLy)];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.Ho = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.Ho)))?null:(System.String)reader[((int)ViewLuongGiangVienTheoNgayColumn.Ho)];
			//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
			entity.Ten = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.Ten)))?null:(System.String)reader[((int)ViewLuongGiangVienTheoNgayColumn.Ten)];
			//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
			entity.SoTaiKhoan = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.SoTaiKhoan)))?null:(System.String)reader[((int)ViewLuongGiangVienTheoNgayColumn.SoTaiKhoan)];
			//entity.SoTaiKhoan = (Convert.IsDBNull(reader["SoTaiKhoan"]))?string.Empty:(System.String)reader["SoTaiKhoan"];
			entity.MaLop = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.MaLop)))?null:(System.String)reader[((int)ViewLuongGiangVienTheoNgayColumn.MaLop)];
			//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
			entity.MaMonHoc = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.MaMonHoc)))?null:(System.String)reader[((int)ViewLuongGiangVienTheoNgayColumn.MaMonHoc)];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.TenMonHoc = (System.String)reader[((int)ViewLuongGiangVienTheoNgayColumn.TenMonHoc)];
			//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
			entity.MaLopHocPhan = (System.String)reader[((int)ViewLuongGiangVienTheoNgayColumn.MaLopHocPhan)];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			entity.TenLopHocPhan = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.TenLopHocPhan)))?null:(System.String)reader[((int)ViewLuongGiangVienTheoNgayColumn.TenLopHocPhan)];
			//entity.TenLopHocPhan = (Convert.IsDBNull(reader["TenLopHocPhan"]))?string.Empty:(System.String)reader["TenLopHocPhan"];
			entity.NgayBatDau = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.NgayBatDau)))?null:(System.String)reader[((int)ViewLuongGiangVienTheoNgayColumn.NgayBatDau)];
			//entity.NgayBatDau = (Convert.IsDBNull(reader["NgayBatDau"]))?string.Empty:(System.String)reader["NgayBatDau"];
			entity.NgayKetThuc = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.NgayKetThuc)))?null:(System.String)reader[((int)ViewLuongGiangVienTheoNgayColumn.NgayKetThuc)];
			//entity.NgayKetThuc = (Convert.IsDBNull(reader["NgayKetThuc"]))?string.Empty:(System.String)reader["NgayKetThuc"];
			entity.TrongGio = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.TrongGio)))?null:(System.Decimal?)reader[((int)ViewLuongGiangVienTheoNgayColumn.TrongGio)];
			//entity.TrongGio = (Convert.IsDBNull(reader["TrongGio"]))?0.0m:(System.Decimal?)reader["TrongGio"];
			entity.NgoaiGio = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.NgoaiGio)))?null:(System.Decimal?)reader[((int)ViewLuongGiangVienTheoNgayColumn.NgoaiGio)];
			//entity.NgoaiGio = (Convert.IsDBNull(reader["NgoaiGio"]))?0.0m:(System.Decimal?)reader["NgoaiGio"];
			entity.TietQuyDoi = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.TietQuyDoi)))?null:(System.Decimal?)reader[((int)ViewLuongGiangVienTheoNgayColumn.TietQuyDoi)];
			//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal?)reader["TietQuyDoi"];
			entity.SiSoLop = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.SiSoLop)))?null:(System.Int32?)reader[((int)ViewLuongGiangVienTheoNgayColumn.SiSoLop)];
			//entity.SiSoLop = (Convert.IsDBNull(reader["SiSoLop"]))?(int)0:(System.Int32?)reader["SiSoLop"];
			entity.MaBacDaoTao = (System.String)reader[((int)ViewLuongGiangVienTheoNgayColumn.MaBacDaoTao)];
			//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
			entity.MaHeDaoTao = (System.String)reader[((int)ViewLuongGiangVienTheoNgayColumn.MaHeDaoTao)];
			//entity.MaHeDaoTao = (Convert.IsDBNull(reader["MaHeDaoTao"]))?string.Empty:(System.String)reader["MaHeDaoTao"];
			entity.MaLoaiGiangVien = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.MaLoaiGiangVien)))?null:(System.String)reader[((int)ViewLuongGiangVienTheoNgayColumn.MaLoaiGiangVien)];
			//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?string.Empty:(System.String)reader["MaLoaiGiangVien"];
			entity.SoTien = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.SoTien)))?null:(System.Decimal?)reader[((int)ViewLuongGiangVienTheoNgayColumn.SoTien)];
			//entity.SoTien = (Convert.IsDBNull(reader["SoTien"]))?0:(System.Decimal?)reader["SoTien"];
			entity.TienTruocThue = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.TienTruocThue)))?null:(System.Decimal?)reader[((int)ViewLuongGiangVienTheoNgayColumn.TienTruocThue)];
			//entity.TienTruocThue = (Convert.IsDBNull(reader["TienTruocThue"]))?0.0m:(System.Decimal?)reader["TienTruocThue"];
			entity.TienThue = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.TienThue)))?null:(System.Decimal?)reader[((int)ViewLuongGiangVienTheoNgayColumn.TienThue)];
			//entity.TienThue = (Convert.IsDBNull(reader["TienThue"]))?0.0m:(System.Decimal?)reader["TienThue"];
			entity.TienSauThue = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.TienSauThue)))?null:(System.Decimal?)reader[((int)ViewLuongGiangVienTheoNgayColumn.TienSauThue)];
			//entity.TienSauThue = (Convert.IsDBNull(reader["TienSauThue"]))?0.0m:(System.Decimal?)reader["TienSauThue"];
			entity.NgayDay = (reader.IsDBNull(((int)ViewLuongGiangVienTheoNgayColumn.NgayDay)))?null:(System.DateTime?)reader[((int)ViewLuongGiangVienTheoNgayColumn.NgayDay)];
			//entity.NgayDay = (Convert.IsDBNull(reader["NgayDay"]))?DateTime.MinValue:(System.DateTime?)reader["NgayDay"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewLuongGiangVienTheoNgay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewLuongGiangVienTheoNgay"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewLuongGiangVienTheoNgay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32)dataRow["MaGiangVien"];
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.Ho = (Convert.IsDBNull(dataRow["Ho"]))?string.Empty:(System.String)dataRow["Ho"];
			entity.Ten = (Convert.IsDBNull(dataRow["Ten"]))?string.Empty:(System.String)dataRow["Ten"];
			entity.SoTaiKhoan = (Convert.IsDBNull(dataRow["SoTaiKhoan"]))?string.Empty:(System.String)dataRow["SoTaiKhoan"];
			entity.MaLop = (Convert.IsDBNull(dataRow["MaLop"]))?string.Empty:(System.String)dataRow["MaLop"];
			entity.MaMonHoc = (Convert.IsDBNull(dataRow["MaMonHoc"]))?string.Empty:(System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = (Convert.IsDBNull(dataRow["TenMonHoc"]))?string.Empty:(System.String)dataRow["TenMonHoc"];
			entity.MaLopHocPhan = (Convert.IsDBNull(dataRow["MaLopHocPhan"]))?string.Empty:(System.String)dataRow["MaLopHocPhan"];
			entity.TenLopHocPhan = (Convert.IsDBNull(dataRow["TenLopHocPhan"]))?string.Empty:(System.String)dataRow["TenLopHocPhan"];
			entity.NgayBatDau = (Convert.IsDBNull(dataRow["NgayBatDau"]))?string.Empty:(System.String)dataRow["NgayBatDau"];
			entity.NgayKetThuc = (Convert.IsDBNull(dataRow["NgayKetThuc"]))?string.Empty:(System.String)dataRow["NgayKetThuc"];
			entity.TrongGio = (Convert.IsDBNull(dataRow["TrongGio"]))?0.0m:(System.Decimal?)dataRow["TrongGio"];
			entity.NgoaiGio = (Convert.IsDBNull(dataRow["NgoaiGio"]))?0.0m:(System.Decimal?)dataRow["NgoaiGio"];
			entity.TietQuyDoi = (Convert.IsDBNull(dataRow["TietQuyDoi"]))?0.0m:(System.Decimal?)dataRow["TietQuyDoi"];
			entity.SiSoLop = (Convert.IsDBNull(dataRow["SiSoLop"]))?(int)0:(System.Int32?)dataRow["SiSoLop"];
			entity.MaBacDaoTao = (Convert.IsDBNull(dataRow["MaBacDaoTao"]))?string.Empty:(System.String)dataRow["MaBacDaoTao"];
			entity.MaHeDaoTao = (Convert.IsDBNull(dataRow["MaHeDaoTao"]))?string.Empty:(System.String)dataRow["MaHeDaoTao"];
			entity.MaLoaiGiangVien = (Convert.IsDBNull(dataRow["MaLoaiGiangVien"]))?string.Empty:(System.String)dataRow["MaLoaiGiangVien"];
			entity.SoTien = (Convert.IsDBNull(dataRow["SoTien"]))?0:(System.Decimal?)dataRow["SoTien"];
			entity.TienTruocThue = (Convert.IsDBNull(dataRow["TienTruocThue"]))?0.0m:(System.Decimal?)dataRow["TienTruocThue"];
			entity.TienThue = (Convert.IsDBNull(dataRow["TienThue"]))?0.0m:(System.Decimal?)dataRow["TienThue"];
			entity.TienSauThue = (Convert.IsDBNull(dataRow["TienSauThue"]))?0.0m:(System.Decimal?)dataRow["TienSauThue"];
			entity.NgayDay = (Convert.IsDBNull(dataRow["NgayDay"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayDay"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewLuongGiangVienTheoNgayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLuongGiangVienTheoNgay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLuongGiangVienTheoNgayFilterBuilder : SqlFilterBuilder<ViewLuongGiangVienTheoNgayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLuongGiangVienTheoNgayFilterBuilder class.
		/// </summary>
		public ViewLuongGiangVienTheoNgayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewLuongGiangVienTheoNgayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewLuongGiangVienTheoNgayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewLuongGiangVienTheoNgayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewLuongGiangVienTheoNgayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewLuongGiangVienTheoNgayFilterBuilder

	#region ViewLuongGiangVienTheoNgayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLuongGiangVienTheoNgay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLuongGiangVienTheoNgayParameterBuilder : ParameterizedSqlFilterBuilder<ViewLuongGiangVienTheoNgayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLuongGiangVienTheoNgayParameterBuilder class.
		/// </summary>
		public ViewLuongGiangVienTheoNgayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewLuongGiangVienTheoNgayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewLuongGiangVienTheoNgayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewLuongGiangVienTheoNgayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewLuongGiangVienTheoNgayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewLuongGiangVienTheoNgayParameterBuilder
	
	#region ViewLuongGiangVienTheoNgaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLuongGiangVienTheoNgay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewLuongGiangVienTheoNgaySortBuilder : SqlSortBuilder<ViewLuongGiangVienTheoNgayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLuongGiangVienTheoNgaySqlSortBuilder class.
		/// </summary>
		public ViewLuongGiangVienTheoNgaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewLuongGiangVienTheoNgaySortBuilder

} // end namespace
