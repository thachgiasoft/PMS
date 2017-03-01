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
	/// This class is the base class for any <see cref="ViewUteKhoiLuongGiangDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewUteKhoiLuongGiangDayProviderBaseCore : EntityViewProviderBase<ViewUteKhoiLuongGiangDay>
	{
		#region Custom Methods
		
		
		#region cust_View_Ute_KhoiLuongGiangDay_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_Ute_KhoiLuongGiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewUteKhoiLuongGiangDay&gt;"/> instance.</returns>
		public VList<ViewUteKhoiLuongGiangDay> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Ute_KhoiLuongGiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewUteKhoiLuongGiangDay&gt;"/> instance.</returns>
		public VList<ViewUteKhoiLuongGiangDay> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_Ute_KhoiLuongGiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewUteKhoiLuongGiangDay&gt;"/> instance.</returns>
		public VList<ViewUteKhoiLuongGiangDay> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Ute_KhoiLuongGiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewUteKhoiLuongGiangDay&gt;"/> instance.</returns>
		public abstract VList<ViewUteKhoiLuongGiangDay> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewUteKhoiLuongGiangDay&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewUteKhoiLuongGiangDay&gt;"/></returns>
		protected static VList&lt;ViewUteKhoiLuongGiangDay&gt; Fill(DataSet dataSet, VList<ViewUteKhoiLuongGiangDay> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewUteKhoiLuongGiangDay>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewUteKhoiLuongGiangDay&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewUteKhoiLuongGiangDay>"/></returns>
		protected static VList&lt;ViewUteKhoiLuongGiangDay&gt; Fill(DataTable dataTable, VList<ViewUteKhoiLuongGiangDay> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewUteKhoiLuongGiangDay c = new ViewUteKhoiLuongGiangDay();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32)row["MaGiangVien"];
					c.MaGiangVienQuanLy = (Convert.IsDBNull(row["MaGiangVienQuanLy"]))?string.Empty:(System.String)row["MaGiangVienQuanLy"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.MaMonHoc = (Convert.IsDBNull(row["MaMonHoc"]))?string.Empty:(System.String)row["MaMonHoc"];
					c.TenMonHoc = (Convert.IsDBNull(row["TenMonHoc"]))?string.Empty:(System.String)row["TenMonHoc"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.MaLopHocPhan = (Convert.IsDBNull(row["MaLopHocPhan"]))?string.Empty:(System.String)row["MaLopHocPhan"];
					c.MaLop = (Convert.IsDBNull(row["MaLop"]))?string.Empty:(System.String)row["MaLop"];
					c.SoTinChi = (Convert.IsDBNull(row["SoTinChi"]))?(int)0:(System.Int32?)row["SoTinChi"];
					c.SiSo = (Convert.IsDBNull(row["SiSo"]))?(int)0:(System.Int32?)row["SiSo"];
					c.LopClc = (Convert.IsDBNull(row["LopClc"]))?false:(System.Boolean?)row["LopClc"];
					c.SoTiet = (Convert.IsDBNull(row["SoTiet"]))?0.0m:(System.Decimal?)row["SoTiet"];
					c.MaLoaiHocPhan = (Convert.IsDBNull(row["MaLoaiHocPhan"]))?(int)0:(System.Int32?)row["MaLoaiHocPhan"];
					c.MaLoaiHocPhanGanMoi = (Convert.IsDBNull(row["MaLoaiHocPhanGanMoi"]))?string.Empty:(System.String)row["MaLoaiHocPhanGanMoi"];
					c.Chon = (Convert.IsDBNull(row["Chon"]))?false:(System.Boolean?)row["Chon"];
					c.Nhom = (Convert.IsDBNull(row["Nhom"]))?string.Empty:(System.String)row["Nhom"];
					c.MaKhoa = (Convert.IsDBNull(row["MaKhoa"]))?string.Empty:(System.String)row["MaKhoa"];
					c.TenKhoa = (Convert.IsDBNull(row["TenKhoa"]))?string.Empty:(System.String)row["TenKhoa"];
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
		/// Fill an <see cref="VList&lt;ViewUteKhoiLuongGiangDay&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewUteKhoiLuongGiangDay&gt;"/></returns>
		protected VList<ViewUteKhoiLuongGiangDay> Fill(IDataReader reader, VList<ViewUteKhoiLuongGiangDay> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewUteKhoiLuongGiangDay entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewUteKhoiLuongGiangDay>("ViewUteKhoiLuongGiangDay",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewUteKhoiLuongGiangDay();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = (System.Int32)reader["MaGiangVien"];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
					entity.MaGiangVienQuanLy = reader.IsDBNull(reader.GetOrdinal("MaGiangVienQuanLy")) ? null : (System.String)reader["MaGiangVienQuanLy"];
					//entity.MaGiangVienQuanLy = (Convert.IsDBNull(reader["MaGiangVienQuanLy"]))?string.Empty:(System.String)reader["MaGiangVienQuanLy"];
					entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.MaMonHoc = reader.IsDBNull(reader.GetOrdinal("MaMonHoc")) ? null : (System.String)reader["MaMonHoc"];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.TenMonHoc = reader.IsDBNull(reader.GetOrdinal("TenMonHoc")) ? null : (System.String)reader["TenMonHoc"];
					//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
					entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.MaLopHocPhan = reader.IsDBNull(reader.GetOrdinal("MaLopHocPhan")) ? null : (System.String)reader["MaLopHocPhan"];
					//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
					entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
					//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
					entity.SoTinChi = reader.IsDBNull(reader.GetOrdinal("SoTinChi")) ? null : (System.Int32?)reader["SoTinChi"];
					//entity.SoTinChi = (Convert.IsDBNull(reader["SoTinChi"]))?(int)0:(System.Int32?)reader["SoTinChi"];
					entity.SiSo = reader.IsDBNull(reader.GetOrdinal("SiSo")) ? null : (System.Int32?)reader["SiSo"];
					//entity.SiSo = (Convert.IsDBNull(reader["SiSo"]))?(int)0:(System.Int32?)reader["SiSo"];
					entity.LopClc = reader.IsDBNull(reader.GetOrdinal("LopClc")) ? null : (System.Boolean?)reader["LopClc"];
					//entity.LopClc = (Convert.IsDBNull(reader["LopClc"]))?false:(System.Boolean?)reader["LopClc"];
					entity.SoTiet = reader.IsDBNull(reader.GetOrdinal("SoTiet")) ? null : (System.Decimal?)reader["SoTiet"];
					//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?0.0m:(System.Decimal?)reader["SoTiet"];
					entity.MaLoaiHocPhan = reader.IsDBNull(reader.GetOrdinal("MaLoaiHocPhan")) ? null : (System.Int32?)reader["MaLoaiHocPhan"];
					//entity.MaLoaiHocPhan = (Convert.IsDBNull(reader["MaLoaiHocPhan"]))?(int)0:(System.Int32?)reader["MaLoaiHocPhan"];
					entity.MaLoaiHocPhanGanMoi = (System.String)reader["MaLoaiHocPhanGanMoi"];
					//entity.MaLoaiHocPhanGanMoi = (Convert.IsDBNull(reader["MaLoaiHocPhanGanMoi"]))?string.Empty:(System.String)reader["MaLoaiHocPhanGanMoi"];
					entity.Chon = reader.IsDBNull(reader.GetOrdinal("Chon")) ? null : (System.Boolean?)reader["Chon"];
					//entity.Chon = (Convert.IsDBNull(reader["Chon"]))?false:(System.Boolean?)reader["Chon"];
					entity.Nhom = reader.IsDBNull(reader.GetOrdinal("Nhom")) ? null : (System.String)reader["Nhom"];
					//entity.Nhom = (Convert.IsDBNull(reader["Nhom"]))?string.Empty:(System.String)reader["Nhom"];
					entity.MaKhoa = (System.String)reader["MaKhoa"];
					//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
					entity.TenKhoa = (System.String)reader["TenKhoa"];
					//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
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
		/// Refreshes the <see cref="ViewUteKhoiLuongGiangDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewUteKhoiLuongGiangDay"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewUteKhoiLuongGiangDay entity)
		{
			reader.Read();
			entity.MaGiangVien = (System.Int32)reader["MaGiangVien"];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
			entity.MaGiangVienQuanLy = reader.IsDBNull(reader.GetOrdinal("MaGiangVienQuanLy")) ? null : (System.String)reader["MaGiangVienQuanLy"];
			//entity.MaGiangVienQuanLy = (Convert.IsDBNull(reader["MaGiangVienQuanLy"]))?string.Empty:(System.String)reader["MaGiangVienQuanLy"];
			entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.MaMonHoc = reader.IsDBNull(reader.GetOrdinal("MaMonHoc")) ? null : (System.String)reader["MaMonHoc"];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.TenMonHoc = reader.IsDBNull(reader.GetOrdinal("TenMonHoc")) ? null : (System.String)reader["TenMonHoc"];
			//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
			entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.MaLopHocPhan = reader.IsDBNull(reader.GetOrdinal("MaLopHocPhan")) ? null : (System.String)reader["MaLopHocPhan"];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
			//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
			entity.SoTinChi = reader.IsDBNull(reader.GetOrdinal("SoTinChi")) ? null : (System.Int32?)reader["SoTinChi"];
			//entity.SoTinChi = (Convert.IsDBNull(reader["SoTinChi"]))?(int)0:(System.Int32?)reader["SoTinChi"];
			entity.SiSo = reader.IsDBNull(reader.GetOrdinal("SiSo")) ? null : (System.Int32?)reader["SiSo"];
			//entity.SiSo = (Convert.IsDBNull(reader["SiSo"]))?(int)0:(System.Int32?)reader["SiSo"];
			entity.LopClc = reader.IsDBNull(reader.GetOrdinal("LopClc")) ? null : (System.Boolean?)reader["LopClc"];
			//entity.LopClc = (Convert.IsDBNull(reader["LopClc"]))?false:(System.Boolean?)reader["LopClc"];
			entity.SoTiet = reader.IsDBNull(reader.GetOrdinal("SoTiet")) ? null : (System.Decimal?)reader["SoTiet"];
			//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?0.0m:(System.Decimal?)reader["SoTiet"];
			entity.MaLoaiHocPhan = reader.IsDBNull(reader.GetOrdinal("MaLoaiHocPhan")) ? null : (System.Int32?)reader["MaLoaiHocPhan"];
			//entity.MaLoaiHocPhan = (Convert.IsDBNull(reader["MaLoaiHocPhan"]))?(int)0:(System.Int32?)reader["MaLoaiHocPhan"];
			entity.MaLoaiHocPhanGanMoi = (System.String)reader["MaLoaiHocPhanGanMoi"];
			//entity.MaLoaiHocPhanGanMoi = (Convert.IsDBNull(reader["MaLoaiHocPhanGanMoi"]))?string.Empty:(System.String)reader["MaLoaiHocPhanGanMoi"];
			entity.Chon = reader.IsDBNull(reader.GetOrdinal("Chon")) ? null : (System.Boolean?)reader["Chon"];
			//entity.Chon = (Convert.IsDBNull(reader["Chon"]))?false:(System.Boolean?)reader["Chon"];
			entity.Nhom = reader.IsDBNull(reader.GetOrdinal("Nhom")) ? null : (System.String)reader["Nhom"];
			//entity.Nhom = (Convert.IsDBNull(reader["Nhom"]))?string.Empty:(System.String)reader["Nhom"];
			entity.MaKhoa = (System.String)reader["MaKhoa"];
			//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
			entity.TenKhoa = (System.String)reader["TenKhoa"];
			//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewUteKhoiLuongGiangDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewUteKhoiLuongGiangDay"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewUteKhoiLuongGiangDay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32)dataRow["MaGiangVien"];
			entity.MaGiangVienQuanLy = (Convert.IsDBNull(dataRow["MaGiangVienQuanLy"]))?string.Empty:(System.String)dataRow["MaGiangVienQuanLy"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.MaMonHoc = (Convert.IsDBNull(dataRow["MaMonHoc"]))?string.Empty:(System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = (Convert.IsDBNull(dataRow["TenMonHoc"]))?string.Empty:(System.String)dataRow["TenMonHoc"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.MaLopHocPhan = (Convert.IsDBNull(dataRow["MaLopHocPhan"]))?string.Empty:(System.String)dataRow["MaLopHocPhan"];
			entity.MaLop = (Convert.IsDBNull(dataRow["MaLop"]))?string.Empty:(System.String)dataRow["MaLop"];
			entity.SoTinChi = (Convert.IsDBNull(dataRow["SoTinChi"]))?(int)0:(System.Int32?)dataRow["SoTinChi"];
			entity.SiSo = (Convert.IsDBNull(dataRow["SiSo"]))?(int)0:(System.Int32?)dataRow["SiSo"];
			entity.LopClc = (Convert.IsDBNull(dataRow["LopClc"]))?false:(System.Boolean?)dataRow["LopClc"];
			entity.SoTiet = (Convert.IsDBNull(dataRow["SoTiet"]))?0.0m:(System.Decimal?)dataRow["SoTiet"];
			entity.MaLoaiHocPhan = (Convert.IsDBNull(dataRow["MaLoaiHocPhan"]))?(int)0:(System.Int32?)dataRow["MaLoaiHocPhan"];
			entity.MaLoaiHocPhanGanMoi = (Convert.IsDBNull(dataRow["MaLoaiHocPhanGanMoi"]))?string.Empty:(System.String)dataRow["MaLoaiHocPhanGanMoi"];
			entity.Chon = (Convert.IsDBNull(dataRow["Chon"]))?false:(System.Boolean?)dataRow["Chon"];
			entity.Nhom = (Convert.IsDBNull(dataRow["Nhom"]))?string.Empty:(System.String)dataRow["Nhom"];
			entity.MaKhoa = (Convert.IsDBNull(dataRow["MaKhoa"]))?string.Empty:(System.String)dataRow["MaKhoa"];
			entity.TenKhoa = (Convert.IsDBNull(dataRow["TenKhoa"]))?string.Empty:(System.String)dataRow["TenKhoa"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewUteKhoiLuongGiangDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewUteKhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewUteKhoiLuongGiangDayFilterBuilder : SqlFilterBuilder<ViewUteKhoiLuongGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewUteKhoiLuongGiangDayFilterBuilder class.
		/// </summary>
		public ViewUteKhoiLuongGiangDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewUteKhoiLuongGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewUteKhoiLuongGiangDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewUteKhoiLuongGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewUteKhoiLuongGiangDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewUteKhoiLuongGiangDayFilterBuilder

	#region ViewUteKhoiLuongGiangDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewUteKhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewUteKhoiLuongGiangDayParameterBuilder : ParameterizedSqlFilterBuilder<ViewUteKhoiLuongGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewUteKhoiLuongGiangDayParameterBuilder class.
		/// </summary>
		public ViewUteKhoiLuongGiangDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewUteKhoiLuongGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewUteKhoiLuongGiangDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewUteKhoiLuongGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewUteKhoiLuongGiangDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewUteKhoiLuongGiangDayParameterBuilder
	
	#region ViewUteKhoiLuongGiangDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewUteKhoiLuongGiangDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewUteKhoiLuongGiangDaySortBuilder : SqlSortBuilder<ViewUteKhoiLuongGiangDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewUteKhoiLuongGiangDaySqlSortBuilder class.
		/// </summary>
		public ViewUteKhoiLuongGiangDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewUteKhoiLuongGiangDaySortBuilder

} // end namespace
