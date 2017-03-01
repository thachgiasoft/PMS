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
	/// This class is the base class for any <see cref="ViewLuongGiangVienProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewLuongGiangVienProviderBaseCore : EntityViewProviderBase<ViewLuongGiangVien>
	{
		#region Custom Methods
		
		
		#region cust_View_Luong_GiangVien_GetByNgay1
		
		/// <summary>
		///	This method wrap the 'cust_View_Luong_GiangVien_GetByNgay1' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewLuongGiangVien&gt;"/> instance.</returns>
		public VList<ViewLuongGiangVien> GetByNgay1(System.String maBacDaoTao, System.String maHeDaoTao, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByNgay1(null, 0, int.MaxValue , maBacDaoTao, maHeDaoTao, tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Luong_GiangVien_GetByNgay1' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewLuongGiangVien&gt;"/> instance.</returns>
		public VList<ViewLuongGiangVien> GetByNgay1(int start, int pageLength, System.String maBacDaoTao, System.String maHeDaoTao, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByNgay1(null, start, pageLength , maBacDaoTao, maHeDaoTao, tuNgay, denNgay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_Luong_GiangVien_GetByNgay1' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewLuongGiangVien&gt;"/> instance.</returns>
		public VList<ViewLuongGiangVien> GetByNgay1(TransactionManager transactionManager, System.String maBacDaoTao, System.String maHeDaoTao, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByNgay1(transactionManager, 0, int.MaxValue , maBacDaoTao, maHeDaoTao, tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Luong_GiangVien_GetByNgay1' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewLuongGiangVien&gt;"/> instance.</returns>
		public abstract VList<ViewLuongGiangVien> GetByNgay1(TransactionManager transactionManager, int start, int pageLength, System.String maBacDaoTao, System.String maHeDaoTao, System.DateTime tuNgay, System.DateTime denNgay);
		
		#endregion

		
		#region cust_View_Luong_GiangVien_TheoNgay_GetByNgay
		
		/// <summary>
		///	This method wrap the 'cust_View_Luong_GiangVien_TheoNgay_GetByNgay' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader TheoNgay_GetByNgay(System.String maBacDaoTao, System.String maHeDaoTao, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return TheoNgay_GetByNgay(null, 0, int.MaxValue , maBacDaoTao, maHeDaoTao, tuNgay, denNgay);
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
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader TheoNgay_GetByNgay(int start, int pageLength, System.String maBacDaoTao, System.String maHeDaoTao, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return TheoNgay_GetByNgay(null, start, pageLength , maBacDaoTao, maHeDaoTao, tuNgay, denNgay);
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
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader TheoNgay_GetByNgay(TransactionManager transactionManager, System.String maBacDaoTao, System.String maHeDaoTao, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return TheoNgay_GetByNgay(transactionManager, 0, int.MaxValue , maBacDaoTao, maHeDaoTao, tuNgay, denNgay);
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
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader TheoNgay_GetByNgay(TransactionManager transactionManager, int start, int pageLength, System.String maBacDaoTao, System.String maHeDaoTao, System.DateTime tuNgay, System.DateTime denNgay);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewLuongGiangVien&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewLuongGiangVien&gt;"/></returns>
		protected static VList&lt;ViewLuongGiangVien&gt; Fill(DataSet dataSet, VList<ViewLuongGiangVien> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewLuongGiangVien>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewLuongGiangVien&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewLuongGiangVien>"/></returns>
		protected static VList&lt;ViewLuongGiangVien&gt; Fill(DataTable dataTable, VList<ViewLuongGiangVien> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewLuongGiangVien c = new ViewLuongGiangVien();
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
					c.TietQuyDoi = (Convert.IsDBNull(row["TietQuyDoi"]))?0.0m:(System.Decimal?)row["TietQuyDoi"];
					c.SiSoLop = (Convert.IsDBNull(row["SiSoLop"]))?(int)0:(System.Int32?)row["SiSoLop"];
					c.SoTien = (Convert.IsDBNull(row["SoTien"]))?0:(System.Decimal?)row["SoTien"];
					c.ThanhTien = (Convert.IsDBNull(row["ThanhTien"]))?0:(System.Decimal?)row["ThanhTien"];
					c.TongTien = (Convert.IsDBNull(row["TongTien"]))?0:(System.Decimal?)row["TongTien"];
					c.ThueTncn = (Convert.IsDBNull(row["ThueTNCN"]))?0:(System.Decimal?)row["ThueTNCN"];
					c.TienThucNhan = (Convert.IsDBNull(row["TienThucNhan"]))?0:(System.Decimal?)row["TienThucNhan"];
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
		/// Fill an <see cref="VList&lt;ViewLuongGiangVien&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewLuongGiangVien&gt;"/></returns>
		protected VList<ViewLuongGiangVien> Fill(IDataReader reader, VList<ViewLuongGiangVien> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewLuongGiangVien entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewLuongGiangVien>("ViewLuongGiangVien",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewLuongGiangVien();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = (System.Int32)reader[((int)ViewLuongGiangVienColumn.MaGiangVien)];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
					entity.Ho = (reader.IsDBNull(((int)ViewLuongGiangVienColumn.Ho)))?null:(System.String)reader[((int)ViewLuongGiangVienColumn.Ho)];
					//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
					entity.Ten = (reader.IsDBNull(((int)ViewLuongGiangVienColumn.Ten)))?null:(System.String)reader[((int)ViewLuongGiangVienColumn.Ten)];
					//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
					entity.SoTaiKhoan = (reader.IsDBNull(((int)ViewLuongGiangVienColumn.SoTaiKhoan)))?null:(System.String)reader[((int)ViewLuongGiangVienColumn.SoTaiKhoan)];
					//entity.SoTaiKhoan = (Convert.IsDBNull(reader["SoTaiKhoan"]))?string.Empty:(System.String)reader["SoTaiKhoan"];
					entity.MaLop = (System.String)reader[((int)ViewLuongGiangVienColumn.MaLop)];
					//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
					entity.TenLop = (System.String)reader[((int)ViewLuongGiangVienColumn.TenLop)];
					//entity.TenLop = (Convert.IsDBNull(reader["TenLop"]))?string.Empty:(System.String)reader["TenLop"];
					entity.MaMonHoc = (System.String)reader[((int)ViewLuongGiangVienColumn.MaMonHoc)];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.TenMonHoc = (System.String)reader[((int)ViewLuongGiangVienColumn.TenMonHoc)];
					//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
					entity.NgayBatDau = (reader.IsDBNull(((int)ViewLuongGiangVienColumn.NgayBatDau)))?null:(System.DateTime?)reader[((int)ViewLuongGiangVienColumn.NgayBatDau)];
					//entity.NgayBatDau = (Convert.IsDBNull(reader["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)reader["NgayBatDau"];
					entity.NgayKetThuc = (reader.IsDBNull(((int)ViewLuongGiangVienColumn.NgayKetThuc)))?null:(System.DateTime?)reader[((int)ViewLuongGiangVienColumn.NgayKetThuc)];
					//entity.NgayKetThuc = (Convert.IsDBNull(reader["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKetThuc"];
					entity.TietQuyDoi = (reader.IsDBNull(((int)ViewLuongGiangVienColumn.TietQuyDoi)))?null:(System.Decimal?)reader[((int)ViewLuongGiangVienColumn.TietQuyDoi)];
					//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal?)reader["TietQuyDoi"];
					entity.SiSoLop = (reader.IsDBNull(((int)ViewLuongGiangVienColumn.SiSoLop)))?null:(System.Int32?)reader[((int)ViewLuongGiangVienColumn.SiSoLop)];
					//entity.SiSoLop = (Convert.IsDBNull(reader["SiSoLop"]))?(int)0:(System.Int32?)reader["SiSoLop"];
					entity.SoTien = (reader.IsDBNull(((int)ViewLuongGiangVienColumn.SoTien)))?null:(System.Decimal?)reader[((int)ViewLuongGiangVienColumn.SoTien)];
					//entity.SoTien = (Convert.IsDBNull(reader["SoTien"]))?0:(System.Decimal?)reader["SoTien"];
					entity.ThanhTien = (reader.IsDBNull(((int)ViewLuongGiangVienColumn.ThanhTien)))?null:(System.Decimal?)reader[((int)ViewLuongGiangVienColumn.ThanhTien)];
					//entity.ThanhTien = (Convert.IsDBNull(reader["ThanhTien"]))?0:(System.Decimal?)reader["ThanhTien"];
					entity.TongTien = (reader.IsDBNull(((int)ViewLuongGiangVienColumn.TongTien)))?null:(System.Decimal?)reader[((int)ViewLuongGiangVienColumn.TongTien)];
					//entity.TongTien = (Convert.IsDBNull(reader["TongTien"]))?0:(System.Decimal?)reader["TongTien"];
					entity.ThueTncn = (reader.IsDBNull(((int)ViewLuongGiangVienColumn.ThueTncn)))?null:(System.Decimal?)reader[((int)ViewLuongGiangVienColumn.ThueTncn)];
					//entity.ThueTncn = (Convert.IsDBNull(reader["ThueTNCN"]))?0:(System.Decimal?)reader["ThueTNCN"];
					entity.TienThucNhan = (reader.IsDBNull(((int)ViewLuongGiangVienColumn.TienThucNhan)))?null:(System.Decimal?)reader[((int)ViewLuongGiangVienColumn.TienThucNhan)];
					//entity.TienThucNhan = (Convert.IsDBNull(reader["TienThucNhan"]))?0:(System.Decimal?)reader["TienThucNhan"];
					entity.MaBacDaoTao = (reader.IsDBNull(((int)ViewLuongGiangVienColumn.MaBacDaoTao)))?null:(System.String)reader[((int)ViewLuongGiangVienColumn.MaBacDaoTao)];
					//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
					entity.MaHeDaoTao = (reader.IsDBNull(((int)ViewLuongGiangVienColumn.MaHeDaoTao)))?null:(System.String)reader[((int)ViewLuongGiangVienColumn.MaHeDaoTao)];
					//entity.MaHeDaoTao = (Convert.IsDBNull(reader["MaHeDaoTao"]))?string.Empty:(System.String)reader["MaHeDaoTao"];
					entity.MaVaiTroGiangDay = (reader.IsDBNull(((int)ViewLuongGiangVienColumn.MaVaiTroGiangDay)))?null:(System.String)reader[((int)ViewLuongGiangVienColumn.MaVaiTroGiangDay)];
					//entity.MaVaiTroGiangDay = (Convert.IsDBNull(reader["MaVaiTroGiangDay"]))?string.Empty:(System.String)reader["MaVaiTroGiangDay"];
					entity.MaLopHocPhan = (System.String)reader[((int)ViewLuongGiangVienColumn.MaLopHocPhan)];
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
		/// Refreshes the <see cref="ViewLuongGiangVien"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewLuongGiangVien"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewLuongGiangVien entity)
		{
			reader.Read();
			entity.MaGiangVien = (System.Int32)reader[((int)ViewLuongGiangVienColumn.MaGiangVien)];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
			entity.Ho = (reader.IsDBNull(((int)ViewLuongGiangVienColumn.Ho)))?null:(System.String)reader[((int)ViewLuongGiangVienColumn.Ho)];
			//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
			entity.Ten = (reader.IsDBNull(((int)ViewLuongGiangVienColumn.Ten)))?null:(System.String)reader[((int)ViewLuongGiangVienColumn.Ten)];
			//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
			entity.SoTaiKhoan = (reader.IsDBNull(((int)ViewLuongGiangVienColumn.SoTaiKhoan)))?null:(System.String)reader[((int)ViewLuongGiangVienColumn.SoTaiKhoan)];
			//entity.SoTaiKhoan = (Convert.IsDBNull(reader["SoTaiKhoan"]))?string.Empty:(System.String)reader["SoTaiKhoan"];
			entity.MaLop = (System.String)reader[((int)ViewLuongGiangVienColumn.MaLop)];
			//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
			entity.TenLop = (System.String)reader[((int)ViewLuongGiangVienColumn.TenLop)];
			//entity.TenLop = (Convert.IsDBNull(reader["TenLop"]))?string.Empty:(System.String)reader["TenLop"];
			entity.MaMonHoc = (System.String)reader[((int)ViewLuongGiangVienColumn.MaMonHoc)];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.TenMonHoc = (System.String)reader[((int)ViewLuongGiangVienColumn.TenMonHoc)];
			//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
			entity.NgayBatDau = (reader.IsDBNull(((int)ViewLuongGiangVienColumn.NgayBatDau)))?null:(System.DateTime?)reader[((int)ViewLuongGiangVienColumn.NgayBatDau)];
			//entity.NgayBatDau = (Convert.IsDBNull(reader["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)reader["NgayBatDau"];
			entity.NgayKetThuc = (reader.IsDBNull(((int)ViewLuongGiangVienColumn.NgayKetThuc)))?null:(System.DateTime?)reader[((int)ViewLuongGiangVienColumn.NgayKetThuc)];
			//entity.NgayKetThuc = (Convert.IsDBNull(reader["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKetThuc"];
			entity.TietQuyDoi = (reader.IsDBNull(((int)ViewLuongGiangVienColumn.TietQuyDoi)))?null:(System.Decimal?)reader[((int)ViewLuongGiangVienColumn.TietQuyDoi)];
			//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal?)reader["TietQuyDoi"];
			entity.SiSoLop = (reader.IsDBNull(((int)ViewLuongGiangVienColumn.SiSoLop)))?null:(System.Int32?)reader[((int)ViewLuongGiangVienColumn.SiSoLop)];
			//entity.SiSoLop = (Convert.IsDBNull(reader["SiSoLop"]))?(int)0:(System.Int32?)reader["SiSoLop"];
			entity.SoTien = (reader.IsDBNull(((int)ViewLuongGiangVienColumn.SoTien)))?null:(System.Decimal?)reader[((int)ViewLuongGiangVienColumn.SoTien)];
			//entity.SoTien = (Convert.IsDBNull(reader["SoTien"]))?0:(System.Decimal?)reader["SoTien"];
			entity.ThanhTien = (reader.IsDBNull(((int)ViewLuongGiangVienColumn.ThanhTien)))?null:(System.Decimal?)reader[((int)ViewLuongGiangVienColumn.ThanhTien)];
			//entity.ThanhTien = (Convert.IsDBNull(reader["ThanhTien"]))?0:(System.Decimal?)reader["ThanhTien"];
			entity.TongTien = (reader.IsDBNull(((int)ViewLuongGiangVienColumn.TongTien)))?null:(System.Decimal?)reader[((int)ViewLuongGiangVienColumn.TongTien)];
			//entity.TongTien = (Convert.IsDBNull(reader["TongTien"]))?0:(System.Decimal?)reader["TongTien"];
			entity.ThueTncn = (reader.IsDBNull(((int)ViewLuongGiangVienColumn.ThueTncn)))?null:(System.Decimal?)reader[((int)ViewLuongGiangVienColumn.ThueTncn)];
			//entity.ThueTncn = (Convert.IsDBNull(reader["ThueTNCN"]))?0:(System.Decimal?)reader["ThueTNCN"];
			entity.TienThucNhan = (reader.IsDBNull(((int)ViewLuongGiangVienColumn.TienThucNhan)))?null:(System.Decimal?)reader[((int)ViewLuongGiangVienColumn.TienThucNhan)];
			//entity.TienThucNhan = (Convert.IsDBNull(reader["TienThucNhan"]))?0:(System.Decimal?)reader["TienThucNhan"];
			entity.MaBacDaoTao = (reader.IsDBNull(((int)ViewLuongGiangVienColumn.MaBacDaoTao)))?null:(System.String)reader[((int)ViewLuongGiangVienColumn.MaBacDaoTao)];
			//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
			entity.MaHeDaoTao = (reader.IsDBNull(((int)ViewLuongGiangVienColumn.MaHeDaoTao)))?null:(System.String)reader[((int)ViewLuongGiangVienColumn.MaHeDaoTao)];
			//entity.MaHeDaoTao = (Convert.IsDBNull(reader["MaHeDaoTao"]))?string.Empty:(System.String)reader["MaHeDaoTao"];
			entity.MaVaiTroGiangDay = (reader.IsDBNull(((int)ViewLuongGiangVienColumn.MaVaiTroGiangDay)))?null:(System.String)reader[((int)ViewLuongGiangVienColumn.MaVaiTroGiangDay)];
			//entity.MaVaiTroGiangDay = (Convert.IsDBNull(reader["MaVaiTroGiangDay"]))?string.Empty:(System.String)reader["MaVaiTroGiangDay"];
			entity.MaLopHocPhan = (System.String)reader[((int)ViewLuongGiangVienColumn.MaLopHocPhan)];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewLuongGiangVien"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewLuongGiangVien"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewLuongGiangVien entity)
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
			entity.TietQuyDoi = (Convert.IsDBNull(dataRow["TietQuyDoi"]))?0.0m:(System.Decimal?)dataRow["TietQuyDoi"];
			entity.SiSoLop = (Convert.IsDBNull(dataRow["SiSoLop"]))?(int)0:(System.Int32?)dataRow["SiSoLop"];
			entity.SoTien = (Convert.IsDBNull(dataRow["SoTien"]))?0:(System.Decimal?)dataRow["SoTien"];
			entity.ThanhTien = (Convert.IsDBNull(dataRow["ThanhTien"]))?0:(System.Decimal?)dataRow["ThanhTien"];
			entity.TongTien = (Convert.IsDBNull(dataRow["TongTien"]))?0:(System.Decimal?)dataRow["TongTien"];
			entity.ThueTncn = (Convert.IsDBNull(dataRow["ThueTNCN"]))?0:(System.Decimal?)dataRow["ThueTNCN"];
			entity.TienThucNhan = (Convert.IsDBNull(dataRow["TienThucNhan"]))?0:(System.Decimal?)dataRow["TienThucNhan"];
			entity.MaBacDaoTao = (Convert.IsDBNull(dataRow["MaBacDaoTao"]))?string.Empty:(System.String)dataRow["MaBacDaoTao"];
			entity.MaHeDaoTao = (Convert.IsDBNull(dataRow["MaHeDaoTao"]))?string.Empty:(System.String)dataRow["MaHeDaoTao"];
			entity.MaVaiTroGiangDay = (Convert.IsDBNull(dataRow["MaVaiTroGiangDay"]))?string.Empty:(System.String)dataRow["MaVaiTroGiangDay"];
			entity.MaLopHocPhan = (Convert.IsDBNull(dataRow["MaLopHocPhan"]))?string.Empty:(System.String)dataRow["MaLopHocPhan"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewLuongGiangVienFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLuongGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLuongGiangVienFilterBuilder : SqlFilterBuilder<ViewLuongGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLuongGiangVienFilterBuilder class.
		/// </summary>
		public ViewLuongGiangVienFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewLuongGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewLuongGiangVienFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewLuongGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewLuongGiangVienFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewLuongGiangVienFilterBuilder

	#region ViewLuongGiangVienParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLuongGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLuongGiangVienParameterBuilder : ParameterizedSqlFilterBuilder<ViewLuongGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLuongGiangVienParameterBuilder class.
		/// </summary>
		public ViewLuongGiangVienParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewLuongGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewLuongGiangVienParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewLuongGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewLuongGiangVienParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewLuongGiangVienParameterBuilder
	
	#region ViewLuongGiangVienSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLuongGiangVien"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewLuongGiangVienSortBuilder : SqlSortBuilder<ViewLuongGiangVienColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLuongGiangVienSqlSortBuilder class.
		/// </summary>
		public ViewLuongGiangVienSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewLuongGiangVienSortBuilder

} // end namespace
