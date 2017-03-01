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
	/// This class is the base class for any <see cref="ViewThuLaoGiangDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewThuLaoGiangDayProviderBaseCore : EntityViewProviderBase<ViewThuLaoGiangDay>
	{
		#region Custom Methods
		
		
		#region cust_View_ThuLao_GiangDay_GetByMaDonViNamHocHocKyMaLoaiGiangVien
		
		/// <summary>
		///	This method wrap the 'cust_View_ThuLao_GiangDay_GetByMaDonViNamHocHocKyMaLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaDonViNamHocHocKyMaLoaiGiangVien(System.String maDonVi, System.String namHoc, System.String hocKy, System.Int32 maLoaiGiangVien)
		{
			 GetByMaDonViNamHocHocKyMaLoaiGiangVien(null, 0, int.MaxValue , maDonVi, namHoc, hocKy, maLoaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThuLao_GiangDay_GetByMaDonViNamHocHocKyMaLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaDonViNamHocHocKyMaLoaiGiangVien(int start, int pageLength, System.String maDonVi, System.String namHoc, System.String hocKy, System.Int32 maLoaiGiangVien)
		{
			 GetByMaDonViNamHocHocKyMaLoaiGiangVien(null, start, pageLength , maDonVi, namHoc, hocKy, maLoaiGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ThuLao_GiangDay_GetByMaDonViNamHocHocKyMaLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaDonViNamHocHocKyMaLoaiGiangVien(TransactionManager transactionManager, System.String maDonVi, System.String namHoc, System.String hocKy, System.Int32 maLoaiGiangVien)
		{
			 GetByMaDonViNamHocHocKyMaLoaiGiangVien(transactionManager, 0, int.MaxValue , maDonVi, namHoc, hocKy, maLoaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThuLao_GiangDay_GetByMaDonViNamHocHocKyMaLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetByMaDonViNamHocHocKyMaLoaiGiangVien(TransactionManager transactionManager, int start, int pageLength, System.String maDonVi, System.String namHoc, System.String hocKy, System.Int32 maLoaiGiangVien);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewThuLaoGiangDay&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewThuLaoGiangDay&gt;"/></returns>
		protected static VList&lt;ViewThuLaoGiangDay&gt; Fill(DataSet dataSet, VList<ViewThuLaoGiangDay> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewThuLaoGiangDay>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewThuLaoGiangDay&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewThuLaoGiangDay>"/></returns>
		protected static VList&lt;ViewThuLaoGiangDay&gt; Fill(DataTable dataTable, VList<ViewThuLaoGiangDay> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewThuLaoGiangDay c = new ViewThuLaoGiangDay();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?string.Empty:(System.String)row["MaGiangVien"];
					c.MaDonVi = (Convert.IsDBNull(row["MaDonVi"]))?string.Empty:(System.String)row["MaDonVi"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.ChucDanh = (Convert.IsDBNull(row["ChucDanh"]))?string.Empty:(System.String)row["ChucDanh"];
					c.TietNghiVu = (Convert.IsDBNull(row["TietNghiVu"]))?0.0m:(System.Decimal?)row["TietNghiVu"];
					c.TietDoAn = (Convert.IsDBNull(row["TietDoAn"]))?0.0m:(System.Decimal?)row["TietDoAn"];
					c.TietQuyDoi = (Convert.IsDBNull(row["TietQuyDoi"]))?0.0m:(System.Decimal?)row["TietQuyDoi"];
					c.DonGia = (Convert.IsDBNull(row["DonGia"]))?0.0m:(System.Decimal?)row["DonGia"];
					c.TienGiangDay = (Convert.IsDBNull(row["TienGiangDay"]))?0.0m:(System.Decimal?)row["TienGiangDay"];
					c.TienDoAn = (Convert.IsDBNull(row["TienDoAn"]))?0.0m:(System.Decimal?)row["TienDoAn"];
					c.TietThieu = (Convert.IsDBNull(row["TietThieu"]))?0.0m:(System.Decimal?)row["TietThieu"];
					c.TietVuot = (Convert.IsDBNull(row["TietVuot"]))?0.0m:(System.Decimal?)row["TietVuot"];
					c.TienVuot = (Convert.IsDBNull(row["TienVuot"]))?0.0m:(System.Decimal?)row["TienVuot"];
					c.MaLoaiGiangVien = (Convert.IsDBNull(row["MaLoaiGiangVien"]))?(int)0:(System.Int32)row["MaLoaiGiangVien"];
					c.TietGioiHan = (Convert.IsDBNull(row["TietGioiHan"]))?0.0m:(System.Decimal?)row["TietGioiHan"];
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
		/// Fill an <see cref="VList&lt;ViewThuLaoGiangDay&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewThuLaoGiangDay&gt;"/></returns>
		protected VList<ViewThuLaoGiangDay> Fill(IDataReader reader, VList<ViewThuLaoGiangDay> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewThuLaoGiangDay entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewThuLaoGiangDay>("ViewThuLaoGiangDay",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewThuLaoGiangDay();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = (System.String)reader[((int)ViewThuLaoGiangDayColumn.MaGiangVien)];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?string.Empty:(System.String)reader["MaGiangVien"];
					entity.MaDonVi = (System.String)reader[((int)ViewThuLaoGiangDayColumn.MaDonVi)];
					//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
					entity.HoTen = (reader.IsDBNull(((int)ViewThuLaoGiangDayColumn.HoTen)))?null:(System.String)reader[((int)ViewThuLaoGiangDayColumn.HoTen)];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.NamHoc = (reader.IsDBNull(((int)ViewThuLaoGiangDayColumn.NamHoc)))?null:(System.String)reader[((int)ViewThuLaoGiangDayColumn.NamHoc)];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = (reader.IsDBNull(((int)ViewThuLaoGiangDayColumn.HocKy)))?null:(System.String)reader[((int)ViewThuLaoGiangDayColumn.HocKy)];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.ChucDanh = (System.String)reader[((int)ViewThuLaoGiangDayColumn.ChucDanh)];
					//entity.ChucDanh = (Convert.IsDBNull(reader["ChucDanh"]))?string.Empty:(System.String)reader["ChucDanh"];
					entity.TietNghiVu = (reader.IsDBNull(((int)ViewThuLaoGiangDayColumn.TietNghiVu)))?null:(System.Decimal?)reader[((int)ViewThuLaoGiangDayColumn.TietNghiVu)];
					//entity.TietNghiVu = (Convert.IsDBNull(reader["TietNghiVu"]))?0.0m:(System.Decimal?)reader["TietNghiVu"];
					entity.TietDoAn = (reader.IsDBNull(((int)ViewThuLaoGiangDayColumn.TietDoAn)))?null:(System.Decimal?)reader[((int)ViewThuLaoGiangDayColumn.TietDoAn)];
					//entity.TietDoAn = (Convert.IsDBNull(reader["TietDoAn"]))?0.0m:(System.Decimal?)reader["TietDoAn"];
					entity.TietQuyDoi = (reader.IsDBNull(((int)ViewThuLaoGiangDayColumn.TietQuyDoi)))?null:(System.Decimal?)reader[((int)ViewThuLaoGiangDayColumn.TietQuyDoi)];
					//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal?)reader["TietQuyDoi"];
					entity.DonGia = (reader.IsDBNull(((int)ViewThuLaoGiangDayColumn.DonGia)))?null:(System.Decimal?)reader[((int)ViewThuLaoGiangDayColumn.DonGia)];
					//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal?)reader["DonGia"];
					entity.TienGiangDay = (reader.IsDBNull(((int)ViewThuLaoGiangDayColumn.TienGiangDay)))?null:(System.Decimal?)reader[((int)ViewThuLaoGiangDayColumn.TienGiangDay)];
					//entity.TienGiangDay = (Convert.IsDBNull(reader["TienGiangDay"]))?0.0m:(System.Decimal?)reader["TienGiangDay"];
					entity.TienDoAn = (reader.IsDBNull(((int)ViewThuLaoGiangDayColumn.TienDoAn)))?null:(System.Decimal?)reader[((int)ViewThuLaoGiangDayColumn.TienDoAn)];
					//entity.TienDoAn = (Convert.IsDBNull(reader["TienDoAn"]))?0.0m:(System.Decimal?)reader["TienDoAn"];
					entity.TietThieu = (reader.IsDBNull(((int)ViewThuLaoGiangDayColumn.TietThieu)))?null:(System.Decimal?)reader[((int)ViewThuLaoGiangDayColumn.TietThieu)];
					//entity.TietThieu = (Convert.IsDBNull(reader["TietThieu"]))?0.0m:(System.Decimal?)reader["TietThieu"];
					entity.TietVuot = (reader.IsDBNull(((int)ViewThuLaoGiangDayColumn.TietVuot)))?null:(System.Decimal?)reader[((int)ViewThuLaoGiangDayColumn.TietVuot)];
					//entity.TietVuot = (Convert.IsDBNull(reader["TietVuot"]))?0.0m:(System.Decimal?)reader["TietVuot"];
					entity.TienVuot = (reader.IsDBNull(((int)ViewThuLaoGiangDayColumn.TienVuot)))?null:(System.Decimal?)reader[((int)ViewThuLaoGiangDayColumn.TienVuot)];
					//entity.TienVuot = (Convert.IsDBNull(reader["TienVuot"]))?0.0m:(System.Decimal?)reader["TienVuot"];
					entity.MaLoaiGiangVien = (System.Int32)reader[((int)ViewThuLaoGiangDayColumn.MaLoaiGiangVien)];
					//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32)reader["MaLoaiGiangVien"];
					entity.TietGioiHan = (reader.IsDBNull(((int)ViewThuLaoGiangDayColumn.TietGioiHan)))?null:(System.Decimal?)reader[((int)ViewThuLaoGiangDayColumn.TietGioiHan)];
					//entity.TietGioiHan = (Convert.IsDBNull(reader["TietGioiHan"]))?0.0m:(System.Decimal?)reader["TietGioiHan"];
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
		/// Refreshes the <see cref="ViewThuLaoGiangDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThuLaoGiangDay"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewThuLaoGiangDay entity)
		{
			reader.Read();
			entity.MaGiangVien = (System.String)reader[((int)ViewThuLaoGiangDayColumn.MaGiangVien)];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?string.Empty:(System.String)reader["MaGiangVien"];
			entity.MaDonVi = (System.String)reader[((int)ViewThuLaoGiangDayColumn.MaDonVi)];
			//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
			entity.HoTen = (reader.IsDBNull(((int)ViewThuLaoGiangDayColumn.HoTen)))?null:(System.String)reader[((int)ViewThuLaoGiangDayColumn.HoTen)];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.NamHoc = (reader.IsDBNull(((int)ViewThuLaoGiangDayColumn.NamHoc)))?null:(System.String)reader[((int)ViewThuLaoGiangDayColumn.NamHoc)];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = (reader.IsDBNull(((int)ViewThuLaoGiangDayColumn.HocKy)))?null:(System.String)reader[((int)ViewThuLaoGiangDayColumn.HocKy)];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.ChucDanh = (System.String)reader[((int)ViewThuLaoGiangDayColumn.ChucDanh)];
			//entity.ChucDanh = (Convert.IsDBNull(reader["ChucDanh"]))?string.Empty:(System.String)reader["ChucDanh"];
			entity.TietNghiVu = (reader.IsDBNull(((int)ViewThuLaoGiangDayColumn.TietNghiVu)))?null:(System.Decimal?)reader[((int)ViewThuLaoGiangDayColumn.TietNghiVu)];
			//entity.TietNghiVu = (Convert.IsDBNull(reader["TietNghiVu"]))?0.0m:(System.Decimal?)reader["TietNghiVu"];
			entity.TietDoAn = (reader.IsDBNull(((int)ViewThuLaoGiangDayColumn.TietDoAn)))?null:(System.Decimal?)reader[((int)ViewThuLaoGiangDayColumn.TietDoAn)];
			//entity.TietDoAn = (Convert.IsDBNull(reader["TietDoAn"]))?0.0m:(System.Decimal?)reader["TietDoAn"];
			entity.TietQuyDoi = (reader.IsDBNull(((int)ViewThuLaoGiangDayColumn.TietQuyDoi)))?null:(System.Decimal?)reader[((int)ViewThuLaoGiangDayColumn.TietQuyDoi)];
			//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal?)reader["TietQuyDoi"];
			entity.DonGia = (reader.IsDBNull(((int)ViewThuLaoGiangDayColumn.DonGia)))?null:(System.Decimal?)reader[((int)ViewThuLaoGiangDayColumn.DonGia)];
			//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal?)reader["DonGia"];
			entity.TienGiangDay = (reader.IsDBNull(((int)ViewThuLaoGiangDayColumn.TienGiangDay)))?null:(System.Decimal?)reader[((int)ViewThuLaoGiangDayColumn.TienGiangDay)];
			//entity.TienGiangDay = (Convert.IsDBNull(reader["TienGiangDay"]))?0.0m:(System.Decimal?)reader["TienGiangDay"];
			entity.TienDoAn = (reader.IsDBNull(((int)ViewThuLaoGiangDayColumn.TienDoAn)))?null:(System.Decimal?)reader[((int)ViewThuLaoGiangDayColumn.TienDoAn)];
			//entity.TienDoAn = (Convert.IsDBNull(reader["TienDoAn"]))?0.0m:(System.Decimal?)reader["TienDoAn"];
			entity.TietThieu = (reader.IsDBNull(((int)ViewThuLaoGiangDayColumn.TietThieu)))?null:(System.Decimal?)reader[((int)ViewThuLaoGiangDayColumn.TietThieu)];
			//entity.TietThieu = (Convert.IsDBNull(reader["TietThieu"]))?0.0m:(System.Decimal?)reader["TietThieu"];
			entity.TietVuot = (reader.IsDBNull(((int)ViewThuLaoGiangDayColumn.TietVuot)))?null:(System.Decimal?)reader[((int)ViewThuLaoGiangDayColumn.TietVuot)];
			//entity.TietVuot = (Convert.IsDBNull(reader["TietVuot"]))?0.0m:(System.Decimal?)reader["TietVuot"];
			entity.TienVuot = (reader.IsDBNull(((int)ViewThuLaoGiangDayColumn.TienVuot)))?null:(System.Decimal?)reader[((int)ViewThuLaoGiangDayColumn.TienVuot)];
			//entity.TienVuot = (Convert.IsDBNull(reader["TienVuot"]))?0.0m:(System.Decimal?)reader["TienVuot"];
			entity.MaLoaiGiangVien = (System.Int32)reader[((int)ViewThuLaoGiangDayColumn.MaLoaiGiangVien)];
			//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32)reader["MaLoaiGiangVien"];
			entity.TietGioiHan = (reader.IsDBNull(((int)ViewThuLaoGiangDayColumn.TietGioiHan)))?null:(System.Decimal?)reader[((int)ViewThuLaoGiangDayColumn.TietGioiHan)];
			//entity.TietGioiHan = (Convert.IsDBNull(reader["TietGioiHan"]))?0.0m:(System.Decimal?)reader["TietGioiHan"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewThuLaoGiangDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThuLaoGiangDay"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewThuLaoGiangDay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?string.Empty:(System.String)dataRow["MaGiangVien"];
			entity.MaDonVi = (Convert.IsDBNull(dataRow["MaDonVi"]))?string.Empty:(System.String)dataRow["MaDonVi"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.ChucDanh = (Convert.IsDBNull(dataRow["ChucDanh"]))?string.Empty:(System.String)dataRow["ChucDanh"];
			entity.TietNghiVu = (Convert.IsDBNull(dataRow["TietNghiVu"]))?0.0m:(System.Decimal?)dataRow["TietNghiVu"];
			entity.TietDoAn = (Convert.IsDBNull(dataRow["TietDoAn"]))?0.0m:(System.Decimal?)dataRow["TietDoAn"];
			entity.TietQuyDoi = (Convert.IsDBNull(dataRow["TietQuyDoi"]))?0.0m:(System.Decimal?)dataRow["TietQuyDoi"];
			entity.DonGia = (Convert.IsDBNull(dataRow["DonGia"]))?0.0m:(System.Decimal?)dataRow["DonGia"];
			entity.TienGiangDay = (Convert.IsDBNull(dataRow["TienGiangDay"]))?0.0m:(System.Decimal?)dataRow["TienGiangDay"];
			entity.TienDoAn = (Convert.IsDBNull(dataRow["TienDoAn"]))?0.0m:(System.Decimal?)dataRow["TienDoAn"];
			entity.TietThieu = (Convert.IsDBNull(dataRow["TietThieu"]))?0.0m:(System.Decimal?)dataRow["TietThieu"];
			entity.TietVuot = (Convert.IsDBNull(dataRow["TietVuot"]))?0.0m:(System.Decimal?)dataRow["TietVuot"];
			entity.TienVuot = (Convert.IsDBNull(dataRow["TienVuot"]))?0.0m:(System.Decimal?)dataRow["TienVuot"];
			entity.MaLoaiGiangVien = (Convert.IsDBNull(dataRow["MaLoaiGiangVien"]))?(int)0:(System.Int32)dataRow["MaLoaiGiangVien"];
			entity.TietGioiHan = (Convert.IsDBNull(dataRow["TietGioiHan"]))?0.0m:(System.Decimal?)dataRow["TietGioiHan"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewThuLaoGiangDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThuLaoGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThuLaoGiangDayFilterBuilder : SqlFilterBuilder<ViewThuLaoGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThuLaoGiangDayFilterBuilder class.
		/// </summary>
		public ViewThuLaoGiangDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThuLaoGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThuLaoGiangDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThuLaoGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThuLaoGiangDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThuLaoGiangDayFilterBuilder

	#region ViewThuLaoGiangDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThuLaoGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThuLaoGiangDayParameterBuilder : ParameterizedSqlFilterBuilder<ViewThuLaoGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThuLaoGiangDayParameterBuilder class.
		/// </summary>
		public ViewThuLaoGiangDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThuLaoGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThuLaoGiangDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThuLaoGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThuLaoGiangDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThuLaoGiangDayParameterBuilder
	
	#region ViewThuLaoGiangDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThuLaoGiangDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewThuLaoGiangDaySortBuilder : SqlSortBuilder<ViewThuLaoGiangDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThuLaoGiangDaySqlSortBuilder class.
		/// </summary>
		public ViewThuLaoGiangDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewThuLaoGiangDaySortBuilder

} // end namespace
