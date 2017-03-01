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
	/// This class is the base class for any <see cref="ViewSoTietCoiThiTieuChuanCuaGiangVienProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewSoTietCoiThiTieuChuanCuaGiangVienProviderBaseCore : EntityViewProviderBase<ViewSoTietCoiThiTieuChuanCuaGiangVien>
	{
		#region Custom Methods
		
		
		#region cust_View_SoTietCoiThiTieuChuanCuaGiangVien_GetByNamHoc
		
		/// <summary>
		///	This method wrap the 'cust_View_SoTietCoiThiTieuChuanCuaGiangVien_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewSoTietCoiThiTieuChuanCuaGiangVien&gt;"/> instance.</returns>
		public VList<ViewSoTietCoiThiTieuChuanCuaGiangVien> GetByNamHoc(System.String namHoc)
		{
			return GetByNamHoc(null, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_SoTietCoiThiTieuChuanCuaGiangVien_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewSoTietCoiThiTieuChuanCuaGiangVien&gt;"/> instance.</returns>
		public VList<ViewSoTietCoiThiTieuChuanCuaGiangVien> GetByNamHoc(int start, int pageLength, System.String namHoc)
		{
			return GetByNamHoc(null, start, pageLength , namHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_SoTietCoiThiTieuChuanCuaGiangVien_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewSoTietCoiThiTieuChuanCuaGiangVien&gt;"/> instance.</returns>
		public VList<ViewSoTietCoiThiTieuChuanCuaGiangVien> GetByNamHoc(TransactionManager transactionManager, System.String namHoc)
		{
			return GetByNamHoc(transactionManager, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_SoTietCoiThiTieuChuanCuaGiangVien_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewSoTietCoiThiTieuChuanCuaGiangVien&gt;"/> instance.</returns>
		public abstract VList<ViewSoTietCoiThiTieuChuanCuaGiangVien> GetByNamHoc(TransactionManager transactionManager, int start, int pageLength, System.String namHoc);
		
		#endregion

		
		#region cust_View_SoTietCoiThiTieuChuanCuaGiangVien_Luu
		
		/// <summary>
		///	This method wrap the 'cust_View_SoTietCoiThiTieuChuanCuaGiangVien_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, System.String namHoc, ref System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , xmlData, namHoc, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_SoTietCoiThiTieuChuanCuaGiangVien_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, System.String namHoc, ref System.Int32 reVal)
		{
			 Luu(null, start, pageLength , xmlData, namHoc, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_SoTietCoiThiTieuChuanCuaGiangVien_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, System.String namHoc, ref System.Int32 reVal)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, namHoc, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_SoTietCoiThiTieuChuanCuaGiangVien_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength, System.String xmlData, System.String namHoc, ref System.Int32 reVal);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewSoTietCoiThiTieuChuanCuaGiangVien&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewSoTietCoiThiTieuChuanCuaGiangVien&gt;"/></returns>
		protected static VList&lt;ViewSoTietCoiThiTieuChuanCuaGiangVien&gt; Fill(DataSet dataSet, VList<ViewSoTietCoiThiTieuChuanCuaGiangVien> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewSoTietCoiThiTieuChuanCuaGiangVien>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewSoTietCoiThiTieuChuanCuaGiangVien&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewSoTietCoiThiTieuChuanCuaGiangVien>"/></returns>
		protected static VList&lt;ViewSoTietCoiThiTieuChuanCuaGiangVien&gt; Fill(DataTable dataTable, VList<ViewSoTietCoiThiTieuChuanCuaGiangVien> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewSoTietCoiThiTieuChuanCuaGiangVien c = new ViewSoTietCoiThiTieuChuanCuaGiangVien();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32)row["MaGiangVien"];
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.TenHocHam = (Convert.IsDBNull(row["TenHocHam"]))?string.Empty:(System.String)row["TenHocHam"];
					c.TenHocVi = (Convert.IsDBNull(row["TenHocVi"]))?string.Empty:(System.String)row["TenHocVi"];
					c.TenLoaiGiangVien = (Convert.IsDBNull(row["TenLoaiGiangVien"]))?string.Empty:(System.String)row["TenLoaiGiangVien"];
					c.TenDonVi = (Convert.IsDBNull(row["TenDonVi"]))?string.Empty:(System.String)row["TenDonVi"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.SoTietCoiThiTieuChuan = (Convert.IsDBNull(row["SoTietCoiThiTieuChuan"]))?0.0m:(System.Decimal?)row["SoTietCoiThiTieuChuan"];
					c.NgayCapNhat = (Convert.IsDBNull(row["NgayCapNhat"]))?string.Empty:(System.String)row["NgayCapNhat"];
					c.NguoiCapNhat = (Convert.IsDBNull(row["NguoiCapNhat"]))?string.Empty:(System.String)row["NguoiCapNhat"];
					c.GhiChu = (Convert.IsDBNull(row["GhiChu"]))?string.Empty:(System.String)row["GhiChu"];
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
		/// Fill an <see cref="VList&lt;ViewSoTietCoiThiTieuChuanCuaGiangVien&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewSoTietCoiThiTieuChuanCuaGiangVien&gt;"/></returns>
		protected VList<ViewSoTietCoiThiTieuChuanCuaGiangVien> Fill(IDataReader reader, VList<ViewSoTietCoiThiTieuChuanCuaGiangVien> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewSoTietCoiThiTieuChuanCuaGiangVien entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewSoTietCoiThiTieuChuanCuaGiangVien>("ViewSoTietCoiThiTieuChuanCuaGiangVien",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewSoTietCoiThiTieuChuanCuaGiangVien();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = (System.Int32)reader["MaGiangVien"];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
					entity.MaQuanLy = (System.String)reader["MaQuanLy"];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.TenHocHam = reader.IsDBNull(reader.GetOrdinal("TenHocHam")) ? null : (System.String)reader["TenHocHam"];
					//entity.TenHocHam = (Convert.IsDBNull(reader["TenHocHam"]))?string.Empty:(System.String)reader["TenHocHam"];
					entity.TenHocVi = reader.IsDBNull(reader.GetOrdinal("TenHocVi")) ? null : (System.String)reader["TenHocVi"];
					//entity.TenHocVi = (Convert.IsDBNull(reader["TenHocVi"]))?string.Empty:(System.String)reader["TenHocVi"];
					entity.TenLoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("TenLoaiGiangVien")) ? null : (System.String)reader["TenLoaiGiangVien"];
					//entity.TenLoaiGiangVien = (Convert.IsDBNull(reader["TenLoaiGiangVien"]))?string.Empty:(System.String)reader["TenLoaiGiangVien"];
					entity.TenDonVi = (System.String)reader["TenDonVi"];
					//entity.TenDonVi = (Convert.IsDBNull(reader["TenDonVi"]))?string.Empty:(System.String)reader["TenDonVi"];
					entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.SoTietCoiThiTieuChuan = reader.IsDBNull(reader.GetOrdinal("SoTietCoiThiTieuChuan")) ? null : (System.Decimal?)reader["SoTietCoiThiTieuChuan"];
					//entity.SoTietCoiThiTieuChuan = (Convert.IsDBNull(reader["SoTietCoiThiTieuChuan"]))?0.0m:(System.Decimal?)reader["SoTietCoiThiTieuChuan"];
					entity.NgayCapNhat = reader.IsDBNull(reader.GetOrdinal("NgayCapNhat")) ? null : (System.String)reader["NgayCapNhat"];
					//entity.NgayCapNhat = (Convert.IsDBNull(reader["NgayCapNhat"]))?string.Empty:(System.String)reader["NgayCapNhat"];
					entity.NguoiCapNhat = reader.IsDBNull(reader.GetOrdinal("NguoiCapNhat")) ? null : (System.String)reader["NguoiCapNhat"];
					//entity.NguoiCapNhat = (Convert.IsDBNull(reader["NguoiCapNhat"]))?string.Empty:(System.String)reader["NguoiCapNhat"];
					entity.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : (System.String)reader["GhiChu"];
					//entity.GhiChu = (Convert.IsDBNull(reader["GhiChu"]))?string.Empty:(System.String)reader["GhiChu"];
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
		/// Refreshes the <see cref="ViewSoTietCoiThiTieuChuanCuaGiangVien"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewSoTietCoiThiTieuChuanCuaGiangVien"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewSoTietCoiThiTieuChuanCuaGiangVien entity)
		{
			reader.Read();
			entity.MaGiangVien = (System.Int32)reader["MaGiangVien"];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
			entity.MaQuanLy = (System.String)reader["MaQuanLy"];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.TenHocHam = reader.IsDBNull(reader.GetOrdinal("TenHocHam")) ? null : (System.String)reader["TenHocHam"];
			//entity.TenHocHam = (Convert.IsDBNull(reader["TenHocHam"]))?string.Empty:(System.String)reader["TenHocHam"];
			entity.TenHocVi = reader.IsDBNull(reader.GetOrdinal("TenHocVi")) ? null : (System.String)reader["TenHocVi"];
			//entity.TenHocVi = (Convert.IsDBNull(reader["TenHocVi"]))?string.Empty:(System.String)reader["TenHocVi"];
			entity.TenLoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("TenLoaiGiangVien")) ? null : (System.String)reader["TenLoaiGiangVien"];
			//entity.TenLoaiGiangVien = (Convert.IsDBNull(reader["TenLoaiGiangVien"]))?string.Empty:(System.String)reader["TenLoaiGiangVien"];
			entity.TenDonVi = (System.String)reader["TenDonVi"];
			//entity.TenDonVi = (Convert.IsDBNull(reader["TenDonVi"]))?string.Empty:(System.String)reader["TenDonVi"];
			entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.SoTietCoiThiTieuChuan = reader.IsDBNull(reader.GetOrdinal("SoTietCoiThiTieuChuan")) ? null : (System.Decimal?)reader["SoTietCoiThiTieuChuan"];
			//entity.SoTietCoiThiTieuChuan = (Convert.IsDBNull(reader["SoTietCoiThiTieuChuan"]))?0.0m:(System.Decimal?)reader["SoTietCoiThiTieuChuan"];
			entity.NgayCapNhat = reader.IsDBNull(reader.GetOrdinal("NgayCapNhat")) ? null : (System.String)reader["NgayCapNhat"];
			//entity.NgayCapNhat = (Convert.IsDBNull(reader["NgayCapNhat"]))?string.Empty:(System.String)reader["NgayCapNhat"];
			entity.NguoiCapNhat = reader.IsDBNull(reader.GetOrdinal("NguoiCapNhat")) ? null : (System.String)reader["NguoiCapNhat"];
			//entity.NguoiCapNhat = (Convert.IsDBNull(reader["NguoiCapNhat"]))?string.Empty:(System.String)reader["NguoiCapNhat"];
			entity.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : (System.String)reader["GhiChu"];
			//entity.GhiChu = (Convert.IsDBNull(reader["GhiChu"]))?string.Empty:(System.String)reader["GhiChu"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewSoTietCoiThiTieuChuanCuaGiangVien"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewSoTietCoiThiTieuChuanCuaGiangVien"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewSoTietCoiThiTieuChuanCuaGiangVien entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32)dataRow["MaGiangVien"];
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.TenHocHam = (Convert.IsDBNull(dataRow["TenHocHam"]))?string.Empty:(System.String)dataRow["TenHocHam"];
			entity.TenHocVi = (Convert.IsDBNull(dataRow["TenHocVi"]))?string.Empty:(System.String)dataRow["TenHocVi"];
			entity.TenLoaiGiangVien = (Convert.IsDBNull(dataRow["TenLoaiGiangVien"]))?string.Empty:(System.String)dataRow["TenLoaiGiangVien"];
			entity.TenDonVi = (Convert.IsDBNull(dataRow["TenDonVi"]))?string.Empty:(System.String)dataRow["TenDonVi"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.SoTietCoiThiTieuChuan = (Convert.IsDBNull(dataRow["SoTietCoiThiTieuChuan"]))?0.0m:(System.Decimal?)dataRow["SoTietCoiThiTieuChuan"];
			entity.NgayCapNhat = (Convert.IsDBNull(dataRow["NgayCapNhat"]))?string.Empty:(System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = (Convert.IsDBNull(dataRow["NguoiCapNhat"]))?string.Empty:(System.String)dataRow["NguoiCapNhat"];
			entity.GhiChu = (Convert.IsDBNull(dataRow["GhiChu"]))?string.Empty:(System.String)dataRow["GhiChu"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewSoTietCoiThiTieuChuanCuaGiangVienFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewSoTietCoiThiTieuChuanCuaGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewSoTietCoiThiTieuChuanCuaGiangVienFilterBuilder : SqlFilterBuilder<ViewSoTietCoiThiTieuChuanCuaGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewSoTietCoiThiTieuChuanCuaGiangVienFilterBuilder class.
		/// </summary>
		public ViewSoTietCoiThiTieuChuanCuaGiangVienFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewSoTietCoiThiTieuChuanCuaGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewSoTietCoiThiTieuChuanCuaGiangVienFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewSoTietCoiThiTieuChuanCuaGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewSoTietCoiThiTieuChuanCuaGiangVienFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewSoTietCoiThiTieuChuanCuaGiangVienFilterBuilder

	#region ViewSoTietCoiThiTieuChuanCuaGiangVienParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewSoTietCoiThiTieuChuanCuaGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewSoTietCoiThiTieuChuanCuaGiangVienParameterBuilder : ParameterizedSqlFilterBuilder<ViewSoTietCoiThiTieuChuanCuaGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewSoTietCoiThiTieuChuanCuaGiangVienParameterBuilder class.
		/// </summary>
		public ViewSoTietCoiThiTieuChuanCuaGiangVienParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewSoTietCoiThiTieuChuanCuaGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewSoTietCoiThiTieuChuanCuaGiangVienParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewSoTietCoiThiTieuChuanCuaGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewSoTietCoiThiTieuChuanCuaGiangVienParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewSoTietCoiThiTieuChuanCuaGiangVienParameterBuilder
	
	#region ViewSoTietCoiThiTieuChuanCuaGiangVienSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewSoTietCoiThiTieuChuanCuaGiangVien"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewSoTietCoiThiTieuChuanCuaGiangVienSortBuilder : SqlSortBuilder<ViewSoTietCoiThiTieuChuanCuaGiangVienColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewSoTietCoiThiTieuChuanCuaGiangVienSqlSortBuilder class.
		/// </summary>
		public ViewSoTietCoiThiTieuChuanCuaGiangVienSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewSoTietCoiThiTieuChuanCuaGiangVienSortBuilder

} // end namespace
