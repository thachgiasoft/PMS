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
	/// This class is the base class for any <see cref="ViewPhanNhomLopHocPhanProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewPhanNhomLopHocPhanProviderBaseCore : EntityViewProviderBase<ViewPhanNhomLopHocPhan>
	{
		#region Custom Methods
		
		
		#region cust_view_PhanNhomLopHocPhan_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_view_PhanNhomLopHocPhan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewPhanNhomLopHocPhan&gt;"/> instance.</returns>
		public VList<ViewPhanNhomLopHocPhan> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_view_PhanNhomLopHocPhan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewPhanNhomLopHocPhan&gt;"/> instance.</returns>
		public VList<ViewPhanNhomLopHocPhan> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_view_PhanNhomLopHocPhan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewPhanNhomLopHocPhan&gt;"/> instance.</returns>
		public VList<ViewPhanNhomLopHocPhan> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_view_PhanNhomLopHocPhan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewPhanNhomLopHocPhan&gt;"/> instance.</returns>
		public abstract VList<ViewPhanNhomLopHocPhan> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewPhanNhomLopHocPhan&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewPhanNhomLopHocPhan&gt;"/></returns>
		protected static VList&lt;ViewPhanNhomLopHocPhan&gt; Fill(DataSet dataSet, VList<ViewPhanNhomLopHocPhan> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewPhanNhomLopHocPhan>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewPhanNhomLopHocPhan&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewPhanNhomLopHocPhan>"/></returns>
		protected static VList&lt;ViewPhanNhomLopHocPhan&gt; Fill(DataTable dataTable, VList<ViewPhanNhomLopHocPhan> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewPhanNhomLopHocPhan c = new ViewPhanNhomLopHocPhan();
					c.Id = (Convert.IsDBNull(row["Id"]))?(int)0:(System.Int32)row["Id"];
					c.MaMonHoc = (Convert.IsDBNull(row["MaMonHoc"]))?string.Empty:(System.String)row["MaMonHoc"];
					c.TenMonHoc = (Convert.IsDBNull(row["TenMonHoc"]))?string.Empty:(System.String)row["TenMonHoc"];
					c.NhomMonHoc = (Convert.IsDBNull(row["NhomMonHoc"]))?string.Empty:(System.String)row["NhomMonHoc"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.MaLopHocPhan = (Convert.IsDBNull(row["MaLopHocPhan"]))?string.Empty:(System.String)row["MaLopHocPhan"];
					c.MaLop = (Convert.IsDBNull(row["MaLop"]))?string.Empty:(System.String)row["MaLop"];
					c.MaGiangVienQuanLy = (Convert.IsDBNull(row["MaGiangVienQuanLy"]))?string.Empty:(System.String)row["MaGiangVienQuanLy"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.SoTinChi = (Convert.IsDBNull(row["SoTinChi"]))?(int)0:(System.Int32?)row["SoTinChi"];
					c.SiSo = (Convert.IsDBNull(row["SiSo"]))?(int)0:(System.Int32?)row["SiSo"];
					c.SoTiet = (Convert.IsDBNull(row["SoTiet"]))?(int)0:(System.Int32?)row["SoTiet"];
					c.MaKhoa = (Convert.IsDBNull(row["MaKhoa"]))?string.Empty:(System.String)row["MaKhoa"];
					c.TenKhoa = (Convert.IsDBNull(row["TenKhoa"]))?string.Empty:(System.String)row["TenKhoa"];
					c.MaLoaiHocPhan = (Convert.IsDBNull(row["MaLoaiHocPhan"]))?(int)0:(System.Int32?)row["MaLoaiHocPhan"];
					c.MaNhomMon = (Convert.IsDBNull(row["MaNhomMon"]))?(int)0:(System.Int32?)row["MaNhomMon"];
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
		/// Fill an <see cref="VList&lt;ViewPhanNhomLopHocPhan&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewPhanNhomLopHocPhan&gt;"/></returns>
		protected VList<ViewPhanNhomLopHocPhan> Fill(IDataReader reader, VList<ViewPhanNhomLopHocPhan> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewPhanNhomLopHocPhan entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewPhanNhomLopHocPhan>("ViewPhanNhomLopHocPhan",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewPhanNhomLopHocPhan();
					}
					
					entity.SuppressEntityEvents = true;

					entity.Id = (System.Int32)reader[((int)ViewPhanNhomLopHocPhanColumn.Id)];
					//entity.Id = (Convert.IsDBNull(reader["Id"]))?(int)0:(System.Int32)reader["Id"];
					entity.MaMonHoc = (reader.IsDBNull(((int)ViewPhanNhomLopHocPhanColumn.MaMonHoc)))?null:(System.String)reader[((int)ViewPhanNhomLopHocPhanColumn.MaMonHoc)];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.TenMonHoc = (reader.IsDBNull(((int)ViewPhanNhomLopHocPhanColumn.TenMonHoc)))?null:(System.String)reader[((int)ViewPhanNhomLopHocPhanColumn.TenMonHoc)];
					//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
					entity.NhomMonHoc = (reader.IsDBNull(((int)ViewPhanNhomLopHocPhanColumn.NhomMonHoc)))?null:(System.String)reader[((int)ViewPhanNhomLopHocPhanColumn.NhomMonHoc)];
					//entity.NhomMonHoc = (Convert.IsDBNull(reader["NhomMonHoc"]))?string.Empty:(System.String)reader["NhomMonHoc"];
					entity.NamHoc = (reader.IsDBNull(((int)ViewPhanNhomLopHocPhanColumn.NamHoc)))?null:(System.String)reader[((int)ViewPhanNhomLopHocPhanColumn.NamHoc)];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = (reader.IsDBNull(((int)ViewPhanNhomLopHocPhanColumn.HocKy)))?null:(System.String)reader[((int)ViewPhanNhomLopHocPhanColumn.HocKy)];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.MaLopHocPhan = (reader.IsDBNull(((int)ViewPhanNhomLopHocPhanColumn.MaLopHocPhan)))?null:(System.String)reader[((int)ViewPhanNhomLopHocPhanColumn.MaLopHocPhan)];
					//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
					entity.MaLop = (reader.IsDBNull(((int)ViewPhanNhomLopHocPhanColumn.MaLop)))?null:(System.String)reader[((int)ViewPhanNhomLopHocPhanColumn.MaLop)];
					//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
					entity.MaGiangVienQuanLy = (reader.IsDBNull(((int)ViewPhanNhomLopHocPhanColumn.MaGiangVienQuanLy)))?null:(System.String)reader[((int)ViewPhanNhomLopHocPhanColumn.MaGiangVienQuanLy)];
					//entity.MaGiangVienQuanLy = (Convert.IsDBNull(reader["MaGiangVienQuanLy"]))?string.Empty:(System.String)reader["MaGiangVienQuanLy"];
					entity.HoTen = (reader.IsDBNull(((int)ViewPhanNhomLopHocPhanColumn.HoTen)))?null:(System.String)reader[((int)ViewPhanNhomLopHocPhanColumn.HoTen)];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.SoTinChi = (reader.IsDBNull(((int)ViewPhanNhomLopHocPhanColumn.SoTinChi)))?null:(System.Int32?)reader[((int)ViewPhanNhomLopHocPhanColumn.SoTinChi)];
					//entity.SoTinChi = (Convert.IsDBNull(reader["SoTinChi"]))?(int)0:(System.Int32?)reader["SoTinChi"];
					entity.SiSo = (reader.IsDBNull(((int)ViewPhanNhomLopHocPhanColumn.SiSo)))?null:(System.Int32?)reader[((int)ViewPhanNhomLopHocPhanColumn.SiSo)];
					//entity.SiSo = (Convert.IsDBNull(reader["SiSo"]))?(int)0:(System.Int32?)reader["SiSo"];
					entity.SoTiet = (reader.IsDBNull(((int)ViewPhanNhomLopHocPhanColumn.SoTiet)))?null:(System.Int32?)reader[((int)ViewPhanNhomLopHocPhanColumn.SoTiet)];
					//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32?)reader["SoTiet"];
					entity.MaKhoa = (System.String)reader[((int)ViewPhanNhomLopHocPhanColumn.MaKhoa)];
					//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
					entity.TenKhoa = (System.String)reader[((int)ViewPhanNhomLopHocPhanColumn.TenKhoa)];
					//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
					entity.MaLoaiHocPhan = (reader.IsDBNull(((int)ViewPhanNhomLopHocPhanColumn.MaLoaiHocPhan)))?null:(System.Int32?)reader[((int)ViewPhanNhomLopHocPhanColumn.MaLoaiHocPhan)];
					//entity.MaLoaiHocPhan = (Convert.IsDBNull(reader["MaLoaiHocPhan"]))?(int)0:(System.Int32?)reader["MaLoaiHocPhan"];
					entity.MaNhomMon = (reader.IsDBNull(((int)ViewPhanNhomLopHocPhanColumn.MaNhomMon)))?null:(System.Int32?)reader[((int)ViewPhanNhomLopHocPhanColumn.MaNhomMon)];
					//entity.MaNhomMon = (Convert.IsDBNull(reader["MaNhomMon"]))?(int)0:(System.Int32?)reader["MaNhomMon"];
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
		/// Refreshes the <see cref="ViewPhanNhomLopHocPhan"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewPhanNhomLopHocPhan"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewPhanNhomLopHocPhan entity)
		{
			reader.Read();
			entity.Id = (System.Int32)reader[((int)ViewPhanNhomLopHocPhanColumn.Id)];
			//entity.Id = (Convert.IsDBNull(reader["Id"]))?(int)0:(System.Int32)reader["Id"];
			entity.MaMonHoc = (reader.IsDBNull(((int)ViewPhanNhomLopHocPhanColumn.MaMonHoc)))?null:(System.String)reader[((int)ViewPhanNhomLopHocPhanColumn.MaMonHoc)];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.TenMonHoc = (reader.IsDBNull(((int)ViewPhanNhomLopHocPhanColumn.TenMonHoc)))?null:(System.String)reader[((int)ViewPhanNhomLopHocPhanColumn.TenMonHoc)];
			//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
			entity.NhomMonHoc = (reader.IsDBNull(((int)ViewPhanNhomLopHocPhanColumn.NhomMonHoc)))?null:(System.String)reader[((int)ViewPhanNhomLopHocPhanColumn.NhomMonHoc)];
			//entity.NhomMonHoc = (Convert.IsDBNull(reader["NhomMonHoc"]))?string.Empty:(System.String)reader["NhomMonHoc"];
			entity.NamHoc = (reader.IsDBNull(((int)ViewPhanNhomLopHocPhanColumn.NamHoc)))?null:(System.String)reader[((int)ViewPhanNhomLopHocPhanColumn.NamHoc)];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = (reader.IsDBNull(((int)ViewPhanNhomLopHocPhanColumn.HocKy)))?null:(System.String)reader[((int)ViewPhanNhomLopHocPhanColumn.HocKy)];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.MaLopHocPhan = (reader.IsDBNull(((int)ViewPhanNhomLopHocPhanColumn.MaLopHocPhan)))?null:(System.String)reader[((int)ViewPhanNhomLopHocPhanColumn.MaLopHocPhan)];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			entity.MaLop = (reader.IsDBNull(((int)ViewPhanNhomLopHocPhanColumn.MaLop)))?null:(System.String)reader[((int)ViewPhanNhomLopHocPhanColumn.MaLop)];
			//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
			entity.MaGiangVienQuanLy = (reader.IsDBNull(((int)ViewPhanNhomLopHocPhanColumn.MaGiangVienQuanLy)))?null:(System.String)reader[((int)ViewPhanNhomLopHocPhanColumn.MaGiangVienQuanLy)];
			//entity.MaGiangVienQuanLy = (Convert.IsDBNull(reader["MaGiangVienQuanLy"]))?string.Empty:(System.String)reader["MaGiangVienQuanLy"];
			entity.HoTen = (reader.IsDBNull(((int)ViewPhanNhomLopHocPhanColumn.HoTen)))?null:(System.String)reader[((int)ViewPhanNhomLopHocPhanColumn.HoTen)];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.SoTinChi = (reader.IsDBNull(((int)ViewPhanNhomLopHocPhanColumn.SoTinChi)))?null:(System.Int32?)reader[((int)ViewPhanNhomLopHocPhanColumn.SoTinChi)];
			//entity.SoTinChi = (Convert.IsDBNull(reader["SoTinChi"]))?(int)0:(System.Int32?)reader["SoTinChi"];
			entity.SiSo = (reader.IsDBNull(((int)ViewPhanNhomLopHocPhanColumn.SiSo)))?null:(System.Int32?)reader[((int)ViewPhanNhomLopHocPhanColumn.SiSo)];
			//entity.SiSo = (Convert.IsDBNull(reader["SiSo"]))?(int)0:(System.Int32?)reader["SiSo"];
			entity.SoTiet = (reader.IsDBNull(((int)ViewPhanNhomLopHocPhanColumn.SoTiet)))?null:(System.Int32?)reader[((int)ViewPhanNhomLopHocPhanColumn.SoTiet)];
			//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32?)reader["SoTiet"];
			entity.MaKhoa = (System.String)reader[((int)ViewPhanNhomLopHocPhanColumn.MaKhoa)];
			//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
			entity.TenKhoa = (System.String)reader[((int)ViewPhanNhomLopHocPhanColumn.TenKhoa)];
			//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
			entity.MaLoaiHocPhan = (reader.IsDBNull(((int)ViewPhanNhomLopHocPhanColumn.MaLoaiHocPhan)))?null:(System.Int32?)reader[((int)ViewPhanNhomLopHocPhanColumn.MaLoaiHocPhan)];
			//entity.MaLoaiHocPhan = (Convert.IsDBNull(reader["MaLoaiHocPhan"]))?(int)0:(System.Int32?)reader["MaLoaiHocPhan"];
			entity.MaNhomMon = (reader.IsDBNull(((int)ViewPhanNhomLopHocPhanColumn.MaNhomMon)))?null:(System.Int32?)reader[((int)ViewPhanNhomLopHocPhanColumn.MaNhomMon)];
			//entity.MaNhomMon = (Convert.IsDBNull(reader["MaNhomMon"]))?(int)0:(System.Int32?)reader["MaNhomMon"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewPhanNhomLopHocPhan"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewPhanNhomLopHocPhan"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewPhanNhomLopHocPhan entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (Convert.IsDBNull(dataRow["Id"]))?(int)0:(System.Int32)dataRow["Id"];
			entity.MaMonHoc = (Convert.IsDBNull(dataRow["MaMonHoc"]))?string.Empty:(System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = (Convert.IsDBNull(dataRow["TenMonHoc"]))?string.Empty:(System.String)dataRow["TenMonHoc"];
			entity.NhomMonHoc = (Convert.IsDBNull(dataRow["NhomMonHoc"]))?string.Empty:(System.String)dataRow["NhomMonHoc"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.MaLopHocPhan = (Convert.IsDBNull(dataRow["MaLopHocPhan"]))?string.Empty:(System.String)dataRow["MaLopHocPhan"];
			entity.MaLop = (Convert.IsDBNull(dataRow["MaLop"]))?string.Empty:(System.String)dataRow["MaLop"];
			entity.MaGiangVienQuanLy = (Convert.IsDBNull(dataRow["MaGiangVienQuanLy"]))?string.Empty:(System.String)dataRow["MaGiangVienQuanLy"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.SoTinChi = (Convert.IsDBNull(dataRow["SoTinChi"]))?(int)0:(System.Int32?)dataRow["SoTinChi"];
			entity.SiSo = (Convert.IsDBNull(dataRow["SiSo"]))?(int)0:(System.Int32?)dataRow["SiSo"];
			entity.SoTiet = (Convert.IsDBNull(dataRow["SoTiet"]))?(int)0:(System.Int32?)dataRow["SoTiet"];
			entity.MaKhoa = (Convert.IsDBNull(dataRow["MaKhoa"]))?string.Empty:(System.String)dataRow["MaKhoa"];
			entity.TenKhoa = (Convert.IsDBNull(dataRow["TenKhoa"]))?string.Empty:(System.String)dataRow["TenKhoa"];
			entity.MaLoaiHocPhan = (Convert.IsDBNull(dataRow["MaLoaiHocPhan"]))?(int)0:(System.Int32?)dataRow["MaLoaiHocPhan"];
			entity.MaNhomMon = (Convert.IsDBNull(dataRow["MaNhomMon"]))?(int)0:(System.Int32?)dataRow["MaNhomMon"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewPhanNhomLopHocPhanFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhanNhomLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhanNhomLopHocPhanFilterBuilder : SqlFilterBuilder<ViewPhanNhomLopHocPhanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhanNhomLopHocPhanFilterBuilder class.
		/// </summary>
		public ViewPhanNhomLopHocPhanFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewPhanNhomLopHocPhanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewPhanNhomLopHocPhanFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewPhanNhomLopHocPhanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewPhanNhomLopHocPhanFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewPhanNhomLopHocPhanFilterBuilder

	#region ViewPhanNhomLopHocPhanParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhanNhomLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhanNhomLopHocPhanParameterBuilder : ParameterizedSqlFilterBuilder<ViewPhanNhomLopHocPhanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhanNhomLopHocPhanParameterBuilder class.
		/// </summary>
		public ViewPhanNhomLopHocPhanParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewPhanNhomLopHocPhanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewPhanNhomLopHocPhanParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewPhanNhomLopHocPhanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewPhanNhomLopHocPhanParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewPhanNhomLopHocPhanParameterBuilder
	
	#region ViewPhanNhomLopHocPhanSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhanNhomLopHocPhan"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewPhanNhomLopHocPhanSortBuilder : SqlSortBuilder<ViewPhanNhomLopHocPhanColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhanNhomLopHocPhanSqlSortBuilder class.
		/// </summary>
		public ViewPhanNhomLopHocPhanSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewPhanNhomLopHocPhanSortBuilder

} // end namespace
