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
	/// This class is the base class for any <see cref="ViewPhanCongCoVanProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewPhanCongCoVanProviderBaseCore : EntityViewProviderBase<ViewPhanCongCoVan>
	{
		#region Custom Methods
		
		
		#region cust_View_PhanCong_CoVan_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_PhanCong_CoVan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewPhanCongCoVan&gt;"/> instance.</returns>
		public VList<ViewPhanCongCoVan> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_PhanCong_CoVan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewPhanCongCoVan&gt;"/> instance.</returns>
		public VList<ViewPhanCongCoVan> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_PhanCong_CoVan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewPhanCongCoVan&gt;"/> instance.</returns>
		public VList<ViewPhanCongCoVan> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_PhanCong_CoVan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewPhanCongCoVan&gt;"/> instance.</returns>
		public abstract VList<ViewPhanCongCoVan> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#region cust_View_PhanCong_CoVan_GetByMaDonViNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_PhanCong_CoVan_GetByMaDonViNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewPhanCongCoVan&gt;"/> instance.</returns>
		public VList<ViewPhanCongCoVan> GetByMaDonViNamHocHocKy(System.String maDonVi, System.String namHoc, System.String hocKy)
		{
			return GetByMaDonViNamHocHocKy(null, 0, int.MaxValue , maDonVi, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_PhanCong_CoVan_GetByMaDonViNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewPhanCongCoVan&gt;"/> instance.</returns>
		public VList<ViewPhanCongCoVan> GetByMaDonViNamHocHocKy(int start, int pageLength, System.String maDonVi, System.String namHoc, System.String hocKy)
		{
			return GetByMaDonViNamHocHocKy(null, start, pageLength , maDonVi, namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_PhanCong_CoVan_GetByMaDonViNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewPhanCongCoVan&gt;"/> instance.</returns>
		public VList<ViewPhanCongCoVan> GetByMaDonViNamHocHocKy(TransactionManager transactionManager, System.String maDonVi, System.String namHoc, System.String hocKy)
		{
			return GetByMaDonViNamHocHocKy(transactionManager, 0, int.MaxValue , maDonVi, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_PhanCong_CoVan_GetByMaDonViNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewPhanCongCoVan&gt;"/> instance.</returns>
		public abstract VList<ViewPhanCongCoVan> GetByMaDonViNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String maDonVi, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewPhanCongCoVan&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewPhanCongCoVan&gt;"/></returns>
		protected static VList&lt;ViewPhanCongCoVan&gt; Fill(DataSet dataSet, VList<ViewPhanCongCoVan> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewPhanCongCoVan>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewPhanCongCoVan&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewPhanCongCoVan>"/></returns>
		protected static VList&lt;ViewPhanCongCoVan&gt; Fill(DataTable dataTable, VList<ViewPhanCongCoVan> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewPhanCongCoVan c = new ViewPhanCongCoVan();
					c.MaKhoa = (Convert.IsDBNull(row["MaKhoa"]))?string.Empty:(System.String)row["MaKhoa"];
					c.TenKhoa = (Convert.IsDBNull(row["TenKhoa"]))?string.Empty:(System.String)row["TenKhoa"];
					c.MaKhoaHoc = (Convert.IsDBNull(row["MaKhoaHoc"]))?string.Empty:(System.String)row["MaKhoaHoc"];
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32?)row["MaGiangVien"];
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.ChucDanh = (Convert.IsDBNull(row["ChucDanh"]))?string.Empty:(System.String)row["ChucDanh"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.MaBacDaoTao = (Convert.IsDBNull(row["MaBacDaoTao"]))?string.Empty:(System.String)row["MaBacDaoTao"];
					c.MaLoaiHinh = (Convert.IsDBNull(row["MaLoaiHinh"]))?string.Empty:(System.String)row["MaLoaiHinh"];
					c.MaBacLoaiHinh = (Convert.IsDBNull(row["MaBacLoaiHinh"]))?string.Empty:(System.String)row["MaBacLoaiHinh"];
					c.MaLop = (Convert.IsDBNull(row["MaLop"]))?string.Empty:(System.String)row["MaLop"];
					c.TenLop = (Convert.IsDBNull(row["TenLop"]))?string.Empty:(System.String)row["TenLop"];
					c.NgayTao = (Convert.IsDBNull(row["NgayTao"]))?DateTime.MinValue:(System.DateTime?)row["NgayTao"];
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
		/// Fill an <see cref="VList&lt;ViewPhanCongCoVan&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewPhanCongCoVan&gt;"/></returns>
		protected VList<ViewPhanCongCoVan> Fill(IDataReader reader, VList<ViewPhanCongCoVan> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewPhanCongCoVan entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewPhanCongCoVan>("ViewPhanCongCoVan",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewPhanCongCoVan();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaKhoa = (System.String)reader["MaKhoa"];
					//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
					entity.TenKhoa = (System.String)reader["TenKhoa"];
					//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
					entity.MaKhoaHoc = (System.String)reader["MaKhoaHoc"];
					//entity.MaKhoaHoc = (Convert.IsDBNull(reader["MaKhoaHoc"]))?string.Empty:(System.String)reader["MaKhoaHoc"];
					entity.MaGiangVien = reader.IsDBNull(reader.GetOrdinal("MaGiangVien")) ? null : (System.Int32?)reader["MaGiangVien"];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32?)reader["MaGiangVien"];
					entity.MaQuanLy = (System.String)reader["MaQuanLy"];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.ChucDanh = reader.IsDBNull(reader.GetOrdinal("ChucDanh")) ? null : (System.String)reader["ChucDanh"];
					//entity.ChucDanh = (Convert.IsDBNull(reader["ChucDanh"]))?string.Empty:(System.String)reader["ChucDanh"];
					entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.MaBacDaoTao = (System.String)reader["MaBacDaoTao"];
					//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
					entity.MaLoaiHinh = (System.String)reader["MaLoaiHinh"];
					//entity.MaLoaiHinh = (Convert.IsDBNull(reader["MaLoaiHinh"]))?string.Empty:(System.String)reader["MaLoaiHinh"];
					entity.MaBacLoaiHinh = (System.String)reader["MaBacLoaiHinh"];
					//entity.MaBacLoaiHinh = (Convert.IsDBNull(reader["MaBacLoaiHinh"]))?string.Empty:(System.String)reader["MaBacLoaiHinh"];
					entity.MaLop = (System.String)reader["MaLop"];
					//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
					entity.TenLop = (System.String)reader["TenLop"];
					//entity.TenLop = (Convert.IsDBNull(reader["TenLop"]))?string.Empty:(System.String)reader["TenLop"];
					entity.NgayTao = reader.IsDBNull(reader.GetOrdinal("NgayTao")) ? null : (System.DateTime?)reader["NgayTao"];
					//entity.NgayTao = (Convert.IsDBNull(reader["NgayTao"]))?DateTime.MinValue:(System.DateTime?)reader["NgayTao"];
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
		/// Refreshes the <see cref="ViewPhanCongCoVan"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewPhanCongCoVan"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewPhanCongCoVan entity)
		{
			reader.Read();
			entity.MaKhoa = (System.String)reader["MaKhoa"];
			//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
			entity.TenKhoa = (System.String)reader["TenKhoa"];
			//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
			entity.MaKhoaHoc = (System.String)reader["MaKhoaHoc"];
			//entity.MaKhoaHoc = (Convert.IsDBNull(reader["MaKhoaHoc"]))?string.Empty:(System.String)reader["MaKhoaHoc"];
			entity.MaGiangVien = reader.IsDBNull(reader.GetOrdinal("MaGiangVien")) ? null : (System.Int32?)reader["MaGiangVien"];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32?)reader["MaGiangVien"];
			entity.MaQuanLy = (System.String)reader["MaQuanLy"];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.ChucDanh = reader.IsDBNull(reader.GetOrdinal("ChucDanh")) ? null : (System.String)reader["ChucDanh"];
			//entity.ChucDanh = (Convert.IsDBNull(reader["ChucDanh"]))?string.Empty:(System.String)reader["ChucDanh"];
			entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.MaBacDaoTao = (System.String)reader["MaBacDaoTao"];
			//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
			entity.MaLoaiHinh = (System.String)reader["MaLoaiHinh"];
			//entity.MaLoaiHinh = (Convert.IsDBNull(reader["MaLoaiHinh"]))?string.Empty:(System.String)reader["MaLoaiHinh"];
			entity.MaBacLoaiHinh = (System.String)reader["MaBacLoaiHinh"];
			//entity.MaBacLoaiHinh = (Convert.IsDBNull(reader["MaBacLoaiHinh"]))?string.Empty:(System.String)reader["MaBacLoaiHinh"];
			entity.MaLop = (System.String)reader["MaLop"];
			//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
			entity.TenLop = (System.String)reader["TenLop"];
			//entity.TenLop = (Convert.IsDBNull(reader["TenLop"]))?string.Empty:(System.String)reader["TenLop"];
			entity.NgayTao = reader.IsDBNull(reader.GetOrdinal("NgayTao")) ? null : (System.DateTime?)reader["NgayTao"];
			//entity.NgayTao = (Convert.IsDBNull(reader["NgayTao"]))?DateTime.MinValue:(System.DateTime?)reader["NgayTao"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewPhanCongCoVan"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewPhanCongCoVan"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewPhanCongCoVan entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaKhoa = (Convert.IsDBNull(dataRow["MaKhoa"]))?string.Empty:(System.String)dataRow["MaKhoa"];
			entity.TenKhoa = (Convert.IsDBNull(dataRow["TenKhoa"]))?string.Empty:(System.String)dataRow["TenKhoa"];
			entity.MaKhoaHoc = (Convert.IsDBNull(dataRow["MaKhoaHoc"]))?string.Empty:(System.String)dataRow["MaKhoaHoc"];
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32?)dataRow["MaGiangVien"];
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.ChucDanh = (Convert.IsDBNull(dataRow["ChucDanh"]))?string.Empty:(System.String)dataRow["ChucDanh"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.MaBacDaoTao = (Convert.IsDBNull(dataRow["MaBacDaoTao"]))?string.Empty:(System.String)dataRow["MaBacDaoTao"];
			entity.MaLoaiHinh = (Convert.IsDBNull(dataRow["MaLoaiHinh"]))?string.Empty:(System.String)dataRow["MaLoaiHinh"];
			entity.MaBacLoaiHinh = (Convert.IsDBNull(dataRow["MaBacLoaiHinh"]))?string.Empty:(System.String)dataRow["MaBacLoaiHinh"];
			entity.MaLop = (Convert.IsDBNull(dataRow["MaLop"]))?string.Empty:(System.String)dataRow["MaLop"];
			entity.TenLop = (Convert.IsDBNull(dataRow["TenLop"]))?string.Empty:(System.String)dataRow["TenLop"];
			entity.NgayTao = (Convert.IsDBNull(dataRow["NgayTao"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayTao"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewPhanCongCoVanFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhanCongCoVan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhanCongCoVanFilterBuilder : SqlFilterBuilder<ViewPhanCongCoVanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhanCongCoVanFilterBuilder class.
		/// </summary>
		public ViewPhanCongCoVanFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewPhanCongCoVanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewPhanCongCoVanFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewPhanCongCoVanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewPhanCongCoVanFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewPhanCongCoVanFilterBuilder

	#region ViewPhanCongCoVanParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhanCongCoVan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhanCongCoVanParameterBuilder : ParameterizedSqlFilterBuilder<ViewPhanCongCoVanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhanCongCoVanParameterBuilder class.
		/// </summary>
		public ViewPhanCongCoVanParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewPhanCongCoVanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewPhanCongCoVanParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewPhanCongCoVanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewPhanCongCoVanParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewPhanCongCoVanParameterBuilder
	
	#region ViewPhanCongCoVanSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhanCongCoVan"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewPhanCongCoVanSortBuilder : SqlSortBuilder<ViewPhanCongCoVanColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhanCongCoVanSqlSortBuilder class.
		/// </summary>
		public ViewPhanCongCoVanSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewPhanCongCoVanSortBuilder

} // end namespace
