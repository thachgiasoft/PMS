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
	/// This class is the base class for any <see cref="ViewCoVanHocTapProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewCoVanHocTapProviderBaseCore : EntityViewProviderBase<ViewCoVanHocTap>
	{
		#region Custom Methods
		
		
		#region cust_View_CoVanHocTap_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_CoVanHocTap_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewCoVanHocTap&gt;"/> instance.</returns>
		public VList<ViewCoVanHocTap> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_CoVanHocTap_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewCoVanHocTap&gt;"/> instance.</returns>
		public VList<ViewCoVanHocTap> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_CoVanHocTap_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewCoVanHocTap&gt;"/> instance.</returns>
		public VList<ViewCoVanHocTap> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_CoVanHocTap_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewCoVanHocTap&gt;"/> instance.</returns>
		public abstract VList<ViewCoVanHocTap> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#region cust_View_CoVanHocTap_Luu
		
		/// <summary>
		///	This method wrap the 'cust_View_CoVanHocTap_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_CoVanHocTap_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Luu(null, start, pageLength , xmlData, namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_CoVanHocTap_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_CoVanHocTap_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewCoVanHocTap&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewCoVanHocTap&gt;"/></returns>
		protected static VList&lt;ViewCoVanHocTap&gt; Fill(DataSet dataSet, VList<ViewCoVanHocTap> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewCoVanHocTap>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewCoVanHocTap&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewCoVanHocTap>"/></returns>
		protected static VList&lt;ViewCoVanHocTap&gt; Fill(DataTable dataTable, VList<ViewCoVanHocTap> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewCoVanHocTap c = new ViewCoVanHocTap();
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.MaLop = (Convert.IsDBNull(row["MaLop"]))?string.Empty:(System.String)row["MaLop"];
					c.SiSo = (Convert.IsDBNull(row["SiSo"]))?(int)0:(System.Int32?)row["SiSo"];
					c.DepartmentId = (Convert.IsDBNull(row["DepartmentID"]))?string.Empty:(System.String)row["DepartmentID"];
					c.DepartmentName = (Convert.IsDBNull(row["DepartmentName"]))?string.Empty:(System.String)row["DepartmentName"];
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32?)row["MaGiangVien"];
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.Ho = (Convert.IsDBNull(row["Ho"]))?string.Empty:(System.String)row["Ho"];
					c.Ten = (Convert.IsDBNull(row["Ten"]))?string.Empty:(System.String)row["Ten"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.SoTiet = (Convert.IsDBNull(row["SoTiet"]))?(int)0:(System.Int32?)row["SoTiet"];
					c.SoTien = (Convert.IsDBNull(row["SoTien"]))?0.0m:(System.Decimal?)row["SoTien"];
					c.NgayTao = (Convert.IsDBNull(row["NgayTao"]))?DateTime.MinValue:(System.DateTime?)row["NgayTao"];
					c.TrangThai = (Convert.IsDBNull(row["TrangThai"]))?false:(System.Boolean?)row["TrangThai"];
					c.MaKhoaHoc = (Convert.IsDBNull(row["MaKhoaHoc"]))?string.Empty:(System.String)row["MaKhoaHoc"];
					c.MaCoVan = (Convert.IsDBNull(row["MaCoVan"]))?(int)0:(System.Int32)row["MaCoVan"];
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
		/// Fill an <see cref="VList&lt;ViewCoVanHocTap&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewCoVanHocTap&gt;"/></returns>
		protected VList<ViewCoVanHocTap> Fill(IDataReader reader, VList<ViewCoVanHocTap> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewCoVanHocTap entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewCoVanHocTap>("ViewCoVanHocTap",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewCoVanHocTap();
					}
					
					entity.SuppressEntityEvents = true;

					entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
					//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
					entity.SiSo = reader.IsDBNull(reader.GetOrdinal("SiSo")) ? null : (System.Int32?)reader["SiSo"];
					//entity.SiSo = (Convert.IsDBNull(reader["SiSo"]))?(int)0:(System.Int32?)reader["SiSo"];
					entity.DepartmentId = reader.IsDBNull(reader.GetOrdinal("DepartmentId")) ? null : (System.String)reader["DepartmentId"];
					//entity.DepartmentId = (Convert.IsDBNull(reader["DepartmentID"]))?string.Empty:(System.String)reader["DepartmentID"];
					entity.DepartmentName = reader.IsDBNull(reader.GetOrdinal("DepartmentName")) ? null : (System.String)reader["DepartmentName"];
					//entity.DepartmentName = (Convert.IsDBNull(reader["DepartmentName"]))?string.Empty:(System.String)reader["DepartmentName"];
					entity.MaGiangVien = reader.IsDBNull(reader.GetOrdinal("MaGiangVien")) ? null : (System.Int32?)reader["MaGiangVien"];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32?)reader["MaGiangVien"];
					entity.MaQuanLy = reader.IsDBNull(reader.GetOrdinal("MaQuanLy")) ? null : (System.String)reader["MaQuanLy"];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.Ho = reader.IsDBNull(reader.GetOrdinal("Ho")) ? null : (System.String)reader["Ho"];
					//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
					entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
					//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
					entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.SoTiet = reader.IsDBNull(reader.GetOrdinal("SoTiet")) ? null : (System.Int32?)reader["SoTiet"];
					//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32?)reader["SoTiet"];
					entity.SoTien = reader.IsDBNull(reader.GetOrdinal("SoTien")) ? null : (System.Decimal?)reader["SoTien"];
					//entity.SoTien = (Convert.IsDBNull(reader["SoTien"]))?0.0m:(System.Decimal?)reader["SoTien"];
					entity.NgayTao = reader.IsDBNull(reader.GetOrdinal("NgayTao")) ? null : (System.DateTime?)reader["NgayTao"];
					//entity.NgayTao = (Convert.IsDBNull(reader["NgayTao"]))?DateTime.MinValue:(System.DateTime?)reader["NgayTao"];
					entity.TrangThai = reader.IsDBNull(reader.GetOrdinal("TrangThai")) ? null : (System.Boolean?)reader["TrangThai"];
					//entity.TrangThai = (Convert.IsDBNull(reader["TrangThai"]))?false:(System.Boolean?)reader["TrangThai"];
					entity.MaKhoaHoc = reader.IsDBNull(reader.GetOrdinal("MaKhoaHoc")) ? null : (System.String)reader["MaKhoaHoc"];
					//entity.MaKhoaHoc = (Convert.IsDBNull(reader["MaKhoaHoc"]))?string.Empty:(System.String)reader["MaKhoaHoc"];
					entity.MaCoVan = (System.Int32)reader["MaCoVan"];
					//entity.MaCoVan = (Convert.IsDBNull(reader["MaCoVan"]))?(int)0:(System.Int32)reader["MaCoVan"];
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
		/// Refreshes the <see cref="ViewCoVanHocTap"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewCoVanHocTap"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewCoVanHocTap entity)
		{
			reader.Read();
			entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
			//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
			entity.SiSo = reader.IsDBNull(reader.GetOrdinal("SiSo")) ? null : (System.Int32?)reader["SiSo"];
			//entity.SiSo = (Convert.IsDBNull(reader["SiSo"]))?(int)0:(System.Int32?)reader["SiSo"];
			entity.DepartmentId = reader.IsDBNull(reader.GetOrdinal("DepartmentId")) ? null : (System.String)reader["DepartmentId"];
			//entity.DepartmentId = (Convert.IsDBNull(reader["DepartmentID"]))?string.Empty:(System.String)reader["DepartmentID"];
			entity.DepartmentName = reader.IsDBNull(reader.GetOrdinal("DepartmentName")) ? null : (System.String)reader["DepartmentName"];
			//entity.DepartmentName = (Convert.IsDBNull(reader["DepartmentName"]))?string.Empty:(System.String)reader["DepartmentName"];
			entity.MaGiangVien = reader.IsDBNull(reader.GetOrdinal("MaGiangVien")) ? null : (System.Int32?)reader["MaGiangVien"];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32?)reader["MaGiangVien"];
			entity.MaQuanLy = reader.IsDBNull(reader.GetOrdinal("MaQuanLy")) ? null : (System.String)reader["MaQuanLy"];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.Ho = reader.IsDBNull(reader.GetOrdinal("Ho")) ? null : (System.String)reader["Ho"];
			//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
			entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
			//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
			entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.SoTiet = reader.IsDBNull(reader.GetOrdinal("SoTiet")) ? null : (System.Int32?)reader["SoTiet"];
			//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32?)reader["SoTiet"];
			entity.SoTien = reader.IsDBNull(reader.GetOrdinal("SoTien")) ? null : (System.Decimal?)reader["SoTien"];
			//entity.SoTien = (Convert.IsDBNull(reader["SoTien"]))?0.0m:(System.Decimal?)reader["SoTien"];
			entity.NgayTao = reader.IsDBNull(reader.GetOrdinal("NgayTao")) ? null : (System.DateTime?)reader["NgayTao"];
			//entity.NgayTao = (Convert.IsDBNull(reader["NgayTao"]))?DateTime.MinValue:(System.DateTime?)reader["NgayTao"];
			entity.TrangThai = reader.IsDBNull(reader.GetOrdinal("TrangThai")) ? null : (System.Boolean?)reader["TrangThai"];
			//entity.TrangThai = (Convert.IsDBNull(reader["TrangThai"]))?false:(System.Boolean?)reader["TrangThai"];
			entity.MaKhoaHoc = reader.IsDBNull(reader.GetOrdinal("MaKhoaHoc")) ? null : (System.String)reader["MaKhoaHoc"];
			//entity.MaKhoaHoc = (Convert.IsDBNull(reader["MaKhoaHoc"]))?string.Empty:(System.String)reader["MaKhoaHoc"];
			entity.MaCoVan = (System.Int32)reader["MaCoVan"];
			//entity.MaCoVan = (Convert.IsDBNull(reader["MaCoVan"]))?(int)0:(System.Int32)reader["MaCoVan"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewCoVanHocTap"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewCoVanHocTap"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewCoVanHocTap entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.MaLop = (Convert.IsDBNull(dataRow["MaLop"]))?string.Empty:(System.String)dataRow["MaLop"];
			entity.SiSo = (Convert.IsDBNull(dataRow["SiSo"]))?(int)0:(System.Int32?)dataRow["SiSo"];
			entity.DepartmentId = (Convert.IsDBNull(dataRow["DepartmentID"]))?string.Empty:(System.String)dataRow["DepartmentID"];
			entity.DepartmentName = (Convert.IsDBNull(dataRow["DepartmentName"]))?string.Empty:(System.String)dataRow["DepartmentName"];
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32?)dataRow["MaGiangVien"];
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.Ho = (Convert.IsDBNull(dataRow["Ho"]))?string.Empty:(System.String)dataRow["Ho"];
			entity.Ten = (Convert.IsDBNull(dataRow["Ten"]))?string.Empty:(System.String)dataRow["Ten"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.SoTiet = (Convert.IsDBNull(dataRow["SoTiet"]))?(int)0:(System.Int32?)dataRow["SoTiet"];
			entity.SoTien = (Convert.IsDBNull(dataRow["SoTien"]))?0.0m:(System.Decimal?)dataRow["SoTien"];
			entity.NgayTao = (Convert.IsDBNull(dataRow["NgayTao"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayTao"];
			entity.TrangThai = (Convert.IsDBNull(dataRow["TrangThai"]))?false:(System.Boolean?)dataRow["TrangThai"];
			entity.MaKhoaHoc = (Convert.IsDBNull(dataRow["MaKhoaHoc"]))?string.Empty:(System.String)dataRow["MaKhoaHoc"];
			entity.MaCoVan = (Convert.IsDBNull(dataRow["MaCoVan"]))?(int)0:(System.Int32)dataRow["MaCoVan"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewCoVanHocTapFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewCoVanHocTap"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewCoVanHocTapFilterBuilder : SqlFilterBuilder<ViewCoVanHocTapColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewCoVanHocTapFilterBuilder class.
		/// </summary>
		public ViewCoVanHocTapFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewCoVanHocTapFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewCoVanHocTapFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewCoVanHocTapFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewCoVanHocTapFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewCoVanHocTapFilterBuilder

	#region ViewCoVanHocTapParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewCoVanHocTap"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewCoVanHocTapParameterBuilder : ParameterizedSqlFilterBuilder<ViewCoVanHocTapColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewCoVanHocTapParameterBuilder class.
		/// </summary>
		public ViewCoVanHocTapParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewCoVanHocTapParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewCoVanHocTapParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewCoVanHocTapParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewCoVanHocTapParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewCoVanHocTapParameterBuilder
	
	#region ViewCoVanHocTapSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewCoVanHocTap"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewCoVanHocTapSortBuilder : SqlSortBuilder<ViewCoVanHocTapColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewCoVanHocTapSqlSortBuilder class.
		/// </summary>
		public ViewCoVanHocTapSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewCoVanHocTapSortBuilder

} // end namespace
