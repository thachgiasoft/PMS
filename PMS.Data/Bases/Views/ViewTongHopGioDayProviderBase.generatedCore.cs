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
	/// This class is the base class for any <see cref="ViewTongHopGioDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewTongHopGioDayProviderBaseCore : EntityViewProviderBase<ViewTongHopGioDay>
	{
		#region Custom Methods
		
		
		#region cust_View_TongHop_GioDay_GetByNamHocHocKyMaBacDaoTao
		
		/// <summary>
		///	This method wrap the 'cust_View_TongHop_GioDay_GetByNamHocHocKyMaBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyMaBacDaoTao(System.String maBacDaoTao, System.String maHeDaoTao, System.Int32 maLoaiGiangVien, System.DateTime tuNgay, System.DateTime denNgay, System.String maKhoa)
		{
			return GetByNamHocHocKyMaBacDaoTao(null, 0, int.MaxValue , maBacDaoTao, maHeDaoTao, maLoaiGiangVien, tuNgay, denNgay, maKhoa);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_TongHop_GioDay_GetByNamHocHocKyMaBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyMaBacDaoTao(int start, int pageLength, System.String maBacDaoTao, System.String maHeDaoTao, System.Int32 maLoaiGiangVien, System.DateTime tuNgay, System.DateTime denNgay, System.String maKhoa)
		{
			return GetByNamHocHocKyMaBacDaoTao(null, start, pageLength , maBacDaoTao, maHeDaoTao, maLoaiGiangVien, tuNgay, denNgay, maKhoa);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_TongHop_GioDay_GetByNamHocHocKyMaBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyMaBacDaoTao(TransactionManager transactionManager, System.String maBacDaoTao, System.String maHeDaoTao, System.Int32 maLoaiGiangVien, System.DateTime tuNgay, System.DateTime denNgay, System.String maKhoa)
		{
			return GetByNamHocHocKyMaBacDaoTao(transactionManager, 0, int.MaxValue , maBacDaoTao, maHeDaoTao, maLoaiGiangVien, tuNgay, denNgay, maKhoa);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_TongHop_GioDay_GetByNamHocHocKyMaBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKyMaBacDaoTao(TransactionManager transactionManager, int start, int pageLength, System.String maBacDaoTao, System.String maHeDaoTao, System.Int32 maLoaiGiangVien, System.DateTime tuNgay, System.DateTime denNgay, System.String maKhoa);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewTongHopGioDay&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewTongHopGioDay&gt;"/></returns>
		protected static VList&lt;ViewTongHopGioDay&gt; Fill(DataSet dataSet, VList<ViewTongHopGioDay> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewTongHopGioDay>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewTongHopGioDay&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewTongHopGioDay>"/></returns>
		protected static VList&lt;ViewTongHopGioDay&gt; Fill(DataTable dataTable, VList<ViewTongHopGioDay> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewTongHopGioDay c = new ViewTongHopGioDay();
					c.Ho = (Convert.IsDBNull(row["Ho"]))?string.Empty:(System.String)row["Ho"];
					c.Ten = (Convert.IsDBNull(row["Ten"]))?string.Empty:(System.String)row["Ten"];
					c.TenLop = (Convert.IsDBNull(row["TenLop"]))?string.Empty:(System.String)row["TenLop"];
					c.MaLop = (Convert.IsDBNull(row["MaLop"]))?string.Empty:(System.String)row["MaLop"];
					c.MaMonHoc = (Convert.IsDBNull(row["MaMonHoc"]))?string.Empty:(System.String)row["MaMonHoc"];
					c.TenMonHoc = (Convert.IsDBNull(row["TenMonHoc"]))?string.Empty:(System.String)row["TenMonHoc"];
					c.SiSoLop = (Convert.IsDBNull(row["SiSoLop"]))?(int)0:(System.Int32?)row["SiSoLop"];
					c.HeSoLopDong = (Convert.IsDBNull(row["HeSoLopDong"]))?0.0m:(System.Decimal?)row["HeSoLopDong"];
					c.MaBacDaoTao = (Convert.IsDBNull(row["MaBacDaoTao"]))?string.Empty:(System.String)row["MaBacDaoTao"];
					c.MaHeDaoTao = (Convert.IsDBNull(row["MaHeDaoTao"]))?string.Empty:(System.String)row["MaHeDaoTao"];
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?string.Empty:(System.String)row["MaGiangVien"];
					c.MaLopHocPhan = (Convert.IsDBNull(row["MaLopHocPhan"]))?string.Empty:(System.String)row["MaLopHocPhan"];
					c.LyThuyet = (Convert.IsDBNull(row["LyThuyet"]))?0.0m:(System.Decimal)row["LyThuyet"];
					c.LyThuyetHs = (Convert.IsDBNull(row["LyThuyetHS"]))?0.0m:(System.Decimal?)row["LyThuyetHS"];
					c.ThucHanh = (Convert.IsDBNull(row["ThucHanh"]))?0.0m:(System.Decimal)row["ThucHanh"];
					c.ThucHanhHs = (Convert.IsDBNull(row["ThucHanhHS"]))?0.0m:(System.Decimal?)row["ThucHanhHS"];
					c.Tong = (Convert.IsDBNull(row["Tong"]))?0.0m:(System.Decimal?)row["Tong"];
					c.TongHs = (Convert.IsDBNull(row["TongHS"]))?0.0m:(System.Decimal?)row["TongHS"];
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
		/// Fill an <see cref="VList&lt;ViewTongHopGioDay&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewTongHopGioDay&gt;"/></returns>
		protected VList<ViewTongHopGioDay> Fill(IDataReader reader, VList<ViewTongHopGioDay> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewTongHopGioDay entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewTongHopGioDay>("ViewTongHopGioDay",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewTongHopGioDay();
					}
					
					entity.SuppressEntityEvents = true;

					entity.Ho = (reader.IsDBNull(((int)ViewTongHopGioDayColumn.Ho)))?null:(System.String)reader[((int)ViewTongHopGioDayColumn.Ho)];
					//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
					entity.Ten = (reader.IsDBNull(((int)ViewTongHopGioDayColumn.Ten)))?null:(System.String)reader[((int)ViewTongHopGioDayColumn.Ten)];
					//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
					entity.TenLop = (System.String)reader[((int)ViewTongHopGioDayColumn.TenLop)];
					//entity.TenLop = (Convert.IsDBNull(reader["TenLop"]))?string.Empty:(System.String)reader["TenLop"];
					entity.MaLop = (System.String)reader[((int)ViewTongHopGioDayColumn.MaLop)];
					//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
					entity.MaMonHoc = (System.String)reader[((int)ViewTongHopGioDayColumn.MaMonHoc)];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.TenMonHoc = (System.String)reader[((int)ViewTongHopGioDayColumn.TenMonHoc)];
					//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
					entity.SiSoLop = (reader.IsDBNull(((int)ViewTongHopGioDayColumn.SiSoLop)))?null:(System.Int32?)reader[((int)ViewTongHopGioDayColumn.SiSoLop)];
					//entity.SiSoLop = (Convert.IsDBNull(reader["SiSoLop"]))?(int)0:(System.Int32?)reader["SiSoLop"];
					entity.HeSoLopDong = (reader.IsDBNull(((int)ViewTongHopGioDayColumn.HeSoLopDong)))?null:(System.Decimal?)reader[((int)ViewTongHopGioDayColumn.HeSoLopDong)];
					//entity.HeSoLopDong = (Convert.IsDBNull(reader["HeSoLopDong"]))?0.0m:(System.Decimal?)reader["HeSoLopDong"];
					entity.MaBacDaoTao = (reader.IsDBNull(((int)ViewTongHopGioDayColumn.MaBacDaoTao)))?null:(System.String)reader[((int)ViewTongHopGioDayColumn.MaBacDaoTao)];
					//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
					entity.MaHeDaoTao = (reader.IsDBNull(((int)ViewTongHopGioDayColumn.MaHeDaoTao)))?null:(System.String)reader[((int)ViewTongHopGioDayColumn.MaHeDaoTao)];
					//entity.MaHeDaoTao = (Convert.IsDBNull(reader["MaHeDaoTao"]))?string.Empty:(System.String)reader["MaHeDaoTao"];
					entity.MaGiangVien = (System.String)reader[((int)ViewTongHopGioDayColumn.MaGiangVien)];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?string.Empty:(System.String)reader["MaGiangVien"];
					entity.MaLopHocPhan = (System.String)reader[((int)ViewTongHopGioDayColumn.MaLopHocPhan)];
					//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
					entity.LyThuyet = (System.Decimal)reader[((int)ViewTongHopGioDayColumn.LyThuyet)];
					//entity.LyThuyet = (Convert.IsDBNull(reader["LyThuyet"]))?0.0m:(System.Decimal)reader["LyThuyet"];
					entity.LyThuyetHs = (reader.IsDBNull(((int)ViewTongHopGioDayColumn.LyThuyetHs)))?null:(System.Decimal?)reader[((int)ViewTongHopGioDayColumn.LyThuyetHs)];
					//entity.LyThuyetHs = (Convert.IsDBNull(reader["LyThuyetHS"]))?0.0m:(System.Decimal?)reader["LyThuyetHS"];
					entity.ThucHanh = (System.Decimal)reader[((int)ViewTongHopGioDayColumn.ThucHanh)];
					//entity.ThucHanh = (Convert.IsDBNull(reader["ThucHanh"]))?0.0m:(System.Decimal)reader["ThucHanh"];
					entity.ThucHanhHs = (reader.IsDBNull(((int)ViewTongHopGioDayColumn.ThucHanhHs)))?null:(System.Decimal?)reader[((int)ViewTongHopGioDayColumn.ThucHanhHs)];
					//entity.ThucHanhHs = (Convert.IsDBNull(reader["ThucHanhHS"]))?0.0m:(System.Decimal?)reader["ThucHanhHS"];
					entity.Tong = (reader.IsDBNull(((int)ViewTongHopGioDayColumn.Tong)))?null:(System.Decimal?)reader[((int)ViewTongHopGioDayColumn.Tong)];
					//entity.Tong = (Convert.IsDBNull(reader["Tong"]))?0.0m:(System.Decimal?)reader["Tong"];
					entity.TongHs = (reader.IsDBNull(((int)ViewTongHopGioDayColumn.TongHs)))?null:(System.Decimal?)reader[((int)ViewTongHopGioDayColumn.TongHs)];
					//entity.TongHs = (Convert.IsDBNull(reader["TongHS"]))?0.0m:(System.Decimal?)reader["TongHS"];
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
		/// Refreshes the <see cref="ViewTongHopGioDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewTongHopGioDay"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewTongHopGioDay entity)
		{
			reader.Read();
			entity.Ho = (reader.IsDBNull(((int)ViewTongHopGioDayColumn.Ho)))?null:(System.String)reader[((int)ViewTongHopGioDayColumn.Ho)];
			//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
			entity.Ten = (reader.IsDBNull(((int)ViewTongHopGioDayColumn.Ten)))?null:(System.String)reader[((int)ViewTongHopGioDayColumn.Ten)];
			//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
			entity.TenLop = (System.String)reader[((int)ViewTongHopGioDayColumn.TenLop)];
			//entity.TenLop = (Convert.IsDBNull(reader["TenLop"]))?string.Empty:(System.String)reader["TenLop"];
			entity.MaLop = (System.String)reader[((int)ViewTongHopGioDayColumn.MaLop)];
			//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
			entity.MaMonHoc = (System.String)reader[((int)ViewTongHopGioDayColumn.MaMonHoc)];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.TenMonHoc = (System.String)reader[((int)ViewTongHopGioDayColumn.TenMonHoc)];
			//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
			entity.SiSoLop = (reader.IsDBNull(((int)ViewTongHopGioDayColumn.SiSoLop)))?null:(System.Int32?)reader[((int)ViewTongHopGioDayColumn.SiSoLop)];
			//entity.SiSoLop = (Convert.IsDBNull(reader["SiSoLop"]))?(int)0:(System.Int32?)reader["SiSoLop"];
			entity.HeSoLopDong = (reader.IsDBNull(((int)ViewTongHopGioDayColumn.HeSoLopDong)))?null:(System.Decimal?)reader[((int)ViewTongHopGioDayColumn.HeSoLopDong)];
			//entity.HeSoLopDong = (Convert.IsDBNull(reader["HeSoLopDong"]))?0.0m:(System.Decimal?)reader["HeSoLopDong"];
			entity.MaBacDaoTao = (reader.IsDBNull(((int)ViewTongHopGioDayColumn.MaBacDaoTao)))?null:(System.String)reader[((int)ViewTongHopGioDayColumn.MaBacDaoTao)];
			//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
			entity.MaHeDaoTao = (reader.IsDBNull(((int)ViewTongHopGioDayColumn.MaHeDaoTao)))?null:(System.String)reader[((int)ViewTongHopGioDayColumn.MaHeDaoTao)];
			//entity.MaHeDaoTao = (Convert.IsDBNull(reader["MaHeDaoTao"]))?string.Empty:(System.String)reader["MaHeDaoTao"];
			entity.MaGiangVien = (System.String)reader[((int)ViewTongHopGioDayColumn.MaGiangVien)];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?string.Empty:(System.String)reader["MaGiangVien"];
			entity.MaLopHocPhan = (System.String)reader[((int)ViewTongHopGioDayColumn.MaLopHocPhan)];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			entity.LyThuyet = (System.Decimal)reader[((int)ViewTongHopGioDayColumn.LyThuyet)];
			//entity.LyThuyet = (Convert.IsDBNull(reader["LyThuyet"]))?0.0m:(System.Decimal)reader["LyThuyet"];
			entity.LyThuyetHs = (reader.IsDBNull(((int)ViewTongHopGioDayColumn.LyThuyetHs)))?null:(System.Decimal?)reader[((int)ViewTongHopGioDayColumn.LyThuyetHs)];
			//entity.LyThuyetHs = (Convert.IsDBNull(reader["LyThuyetHS"]))?0.0m:(System.Decimal?)reader["LyThuyetHS"];
			entity.ThucHanh = (System.Decimal)reader[((int)ViewTongHopGioDayColumn.ThucHanh)];
			//entity.ThucHanh = (Convert.IsDBNull(reader["ThucHanh"]))?0.0m:(System.Decimal)reader["ThucHanh"];
			entity.ThucHanhHs = (reader.IsDBNull(((int)ViewTongHopGioDayColumn.ThucHanhHs)))?null:(System.Decimal?)reader[((int)ViewTongHopGioDayColumn.ThucHanhHs)];
			//entity.ThucHanhHs = (Convert.IsDBNull(reader["ThucHanhHS"]))?0.0m:(System.Decimal?)reader["ThucHanhHS"];
			entity.Tong = (reader.IsDBNull(((int)ViewTongHopGioDayColumn.Tong)))?null:(System.Decimal?)reader[((int)ViewTongHopGioDayColumn.Tong)];
			//entity.Tong = (Convert.IsDBNull(reader["Tong"]))?0.0m:(System.Decimal?)reader["Tong"];
			entity.TongHs = (reader.IsDBNull(((int)ViewTongHopGioDayColumn.TongHs)))?null:(System.Decimal?)reader[((int)ViewTongHopGioDayColumn.TongHs)];
			//entity.TongHs = (Convert.IsDBNull(reader["TongHS"]))?0.0m:(System.Decimal?)reader["TongHS"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewTongHopGioDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewTongHopGioDay"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewTongHopGioDay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Ho = (Convert.IsDBNull(dataRow["Ho"]))?string.Empty:(System.String)dataRow["Ho"];
			entity.Ten = (Convert.IsDBNull(dataRow["Ten"]))?string.Empty:(System.String)dataRow["Ten"];
			entity.TenLop = (Convert.IsDBNull(dataRow["TenLop"]))?string.Empty:(System.String)dataRow["TenLop"];
			entity.MaLop = (Convert.IsDBNull(dataRow["MaLop"]))?string.Empty:(System.String)dataRow["MaLop"];
			entity.MaMonHoc = (Convert.IsDBNull(dataRow["MaMonHoc"]))?string.Empty:(System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = (Convert.IsDBNull(dataRow["TenMonHoc"]))?string.Empty:(System.String)dataRow["TenMonHoc"];
			entity.SiSoLop = (Convert.IsDBNull(dataRow["SiSoLop"]))?(int)0:(System.Int32?)dataRow["SiSoLop"];
			entity.HeSoLopDong = (Convert.IsDBNull(dataRow["HeSoLopDong"]))?0.0m:(System.Decimal?)dataRow["HeSoLopDong"];
			entity.MaBacDaoTao = (Convert.IsDBNull(dataRow["MaBacDaoTao"]))?string.Empty:(System.String)dataRow["MaBacDaoTao"];
			entity.MaHeDaoTao = (Convert.IsDBNull(dataRow["MaHeDaoTao"]))?string.Empty:(System.String)dataRow["MaHeDaoTao"];
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?string.Empty:(System.String)dataRow["MaGiangVien"];
			entity.MaLopHocPhan = (Convert.IsDBNull(dataRow["MaLopHocPhan"]))?string.Empty:(System.String)dataRow["MaLopHocPhan"];
			entity.LyThuyet = (Convert.IsDBNull(dataRow["LyThuyet"]))?0.0m:(System.Decimal)dataRow["LyThuyet"];
			entity.LyThuyetHs = (Convert.IsDBNull(dataRow["LyThuyetHS"]))?0.0m:(System.Decimal?)dataRow["LyThuyetHS"];
			entity.ThucHanh = (Convert.IsDBNull(dataRow["ThucHanh"]))?0.0m:(System.Decimal)dataRow["ThucHanh"];
			entity.ThucHanhHs = (Convert.IsDBNull(dataRow["ThucHanhHS"]))?0.0m:(System.Decimal?)dataRow["ThucHanhHS"];
			entity.Tong = (Convert.IsDBNull(dataRow["Tong"]))?0.0m:(System.Decimal?)dataRow["Tong"];
			entity.TongHs = (Convert.IsDBNull(dataRow["TongHS"]))?0.0m:(System.Decimal?)dataRow["TongHS"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewTongHopGioDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTongHopGioDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTongHopGioDayFilterBuilder : SqlFilterBuilder<ViewTongHopGioDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTongHopGioDayFilterBuilder class.
		/// </summary>
		public ViewTongHopGioDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewTongHopGioDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewTongHopGioDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewTongHopGioDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewTongHopGioDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewTongHopGioDayFilterBuilder

	#region ViewTongHopGioDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTongHopGioDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTongHopGioDayParameterBuilder : ParameterizedSqlFilterBuilder<ViewTongHopGioDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTongHopGioDayParameterBuilder class.
		/// </summary>
		public ViewTongHopGioDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewTongHopGioDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewTongHopGioDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewTongHopGioDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewTongHopGioDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewTongHopGioDayParameterBuilder
	
	#region ViewTongHopGioDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTongHopGioDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewTongHopGioDaySortBuilder : SqlSortBuilder<ViewTongHopGioDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTongHopGioDaySqlSortBuilder class.
		/// </summary>
		public ViewTongHopGioDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewTongHopGioDaySortBuilder

} // end namespace
