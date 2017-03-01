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
	/// This class is the base class for any <see cref="ViewChiTienCoVanProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewChiTienCoVanProviderBaseCore : EntityViewProviderBase<ViewChiTienCoVan>
	{
		#region Custom Methods
		
		
		#region cust_View_ChiTien_CoVan_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTien_CoVan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewChiTienCoVan&gt;"/> instance.</returns>
		public VList<ViewChiTienCoVan> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTien_CoVan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewChiTienCoVan&gt;"/> instance.</returns>
		public VList<ViewChiTienCoVan> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ChiTien_CoVan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewChiTienCoVan&gt;"/> instance.</returns>
		public VList<ViewChiTienCoVan> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTien_CoVan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewChiTienCoVan&gt;"/> instance.</returns>
		public abstract VList<ViewChiTienCoVan> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#region cust_View_ChiTien_CoVan_GetByNamHocHocKy2
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTien_CoVan_GetByNamHocHocKy2' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKy2(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy2(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTien_CoVan_GetByNamHocHocKy2' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKy2(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy2(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ChiTien_CoVan_GetByNamHocHocKy2' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKy2(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy2(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTien_CoVan_GetByNamHocHocKy2' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKy2(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewChiTienCoVan&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewChiTienCoVan&gt;"/></returns>
		protected static VList&lt;ViewChiTienCoVan&gt; Fill(DataSet dataSet, VList<ViewChiTienCoVan> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewChiTienCoVan>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewChiTienCoVan&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewChiTienCoVan>"/></returns>
		protected static VList&lt;ViewChiTienCoVan&gt; Fill(DataTable dataTable, VList<ViewChiTienCoVan> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewChiTienCoVan c = new ViewChiTienCoVan();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32)row["MaGiangVien"];
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.HoLot = (Convert.IsDBNull(row["HoLot"]))?string.Empty:(System.String)row["HoLot"];
					c.Ten = (Convert.IsDBNull(row["Ten"]))?string.Empty:(System.String)row["Ten"];
					c.MaDonVi = (Convert.IsDBNull(row["MaDonVi"]))?string.Empty:(System.String)row["MaDonVi"];
					c.ChucDanh = (Convert.IsDBNull(row["ChucDanh"]))?string.Empty:(System.String)row["ChucDanh"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.SoTien = (Convert.IsDBNull(row["SoTien"]))?0.0m:(System.Decimal?)row["SoTien"];
					c.SoTiet = (Convert.IsDBNull(row["SoTiet"]))?(int)0:(System.Int32?)row["SoTiet"];
					c.ThanhTien = (Convert.IsDBNull(row["ThanhTien"]))?0.0m:(System.Decimal?)row["ThanhTien"];
					c.MaLop = (Convert.IsDBNull(row["MaLop"]))?string.Empty:(System.String)row["MaLop"];
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
		/// Fill an <see cref="VList&lt;ViewChiTienCoVan&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewChiTienCoVan&gt;"/></returns>
		protected VList<ViewChiTienCoVan> Fill(IDataReader reader, VList<ViewChiTienCoVan> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewChiTienCoVan entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewChiTienCoVan>("ViewChiTienCoVan",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewChiTienCoVan();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = (System.Int32)reader["MaGiangVien"];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
					entity.MaQuanLy = (System.String)reader["MaQuanLy"];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.HoLot = (System.String)reader["HoLot"];
					//entity.HoLot = (Convert.IsDBNull(reader["HoLot"]))?string.Empty:(System.String)reader["HoLot"];
					entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
					//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
					entity.MaDonVi = reader.IsDBNull(reader.GetOrdinal("MaDonVi")) ? null : (System.String)reader["MaDonVi"];
					//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
					entity.ChucDanh = (System.String)reader["ChucDanh"];
					//entity.ChucDanh = (Convert.IsDBNull(reader["ChucDanh"]))?string.Empty:(System.String)reader["ChucDanh"];
					entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.SoTien = reader.IsDBNull(reader.GetOrdinal("SoTien")) ? null : (System.Decimal?)reader["SoTien"];
					//entity.SoTien = (Convert.IsDBNull(reader["SoTien"]))?0.0m:(System.Decimal?)reader["SoTien"];
					entity.SoTiet = reader.IsDBNull(reader.GetOrdinal("SoTiet")) ? null : (System.Int32?)reader["SoTiet"];
					//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32?)reader["SoTiet"];
					entity.ThanhTien = reader.IsDBNull(reader.GetOrdinal("ThanhTien")) ? null : (System.Decimal?)reader["ThanhTien"];
					//entity.ThanhTien = (Convert.IsDBNull(reader["ThanhTien"]))?0.0m:(System.Decimal?)reader["ThanhTien"];
					entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
					//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
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
		/// Refreshes the <see cref="ViewChiTienCoVan"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewChiTienCoVan"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewChiTienCoVan entity)
		{
			reader.Read();
			entity.MaGiangVien = (System.Int32)reader["MaGiangVien"];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
			entity.MaQuanLy = (System.String)reader["MaQuanLy"];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.HoLot = (System.String)reader["HoLot"];
			//entity.HoLot = (Convert.IsDBNull(reader["HoLot"]))?string.Empty:(System.String)reader["HoLot"];
			entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
			//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
			entity.MaDonVi = reader.IsDBNull(reader.GetOrdinal("MaDonVi")) ? null : (System.String)reader["MaDonVi"];
			//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
			entity.ChucDanh = (System.String)reader["ChucDanh"];
			//entity.ChucDanh = (Convert.IsDBNull(reader["ChucDanh"]))?string.Empty:(System.String)reader["ChucDanh"];
			entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.SoTien = reader.IsDBNull(reader.GetOrdinal("SoTien")) ? null : (System.Decimal?)reader["SoTien"];
			//entity.SoTien = (Convert.IsDBNull(reader["SoTien"]))?0.0m:(System.Decimal?)reader["SoTien"];
			entity.SoTiet = reader.IsDBNull(reader.GetOrdinal("SoTiet")) ? null : (System.Int32?)reader["SoTiet"];
			//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32?)reader["SoTiet"];
			entity.ThanhTien = reader.IsDBNull(reader.GetOrdinal("ThanhTien")) ? null : (System.Decimal?)reader["ThanhTien"];
			//entity.ThanhTien = (Convert.IsDBNull(reader["ThanhTien"]))?0.0m:(System.Decimal?)reader["ThanhTien"];
			entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
			//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewChiTienCoVan"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewChiTienCoVan"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewChiTienCoVan entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32)dataRow["MaGiangVien"];
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.HoLot = (Convert.IsDBNull(dataRow["HoLot"]))?string.Empty:(System.String)dataRow["HoLot"];
			entity.Ten = (Convert.IsDBNull(dataRow["Ten"]))?string.Empty:(System.String)dataRow["Ten"];
			entity.MaDonVi = (Convert.IsDBNull(dataRow["MaDonVi"]))?string.Empty:(System.String)dataRow["MaDonVi"];
			entity.ChucDanh = (Convert.IsDBNull(dataRow["ChucDanh"]))?string.Empty:(System.String)dataRow["ChucDanh"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.SoTien = (Convert.IsDBNull(dataRow["SoTien"]))?0.0m:(System.Decimal?)dataRow["SoTien"];
			entity.SoTiet = (Convert.IsDBNull(dataRow["SoTiet"]))?(int)0:(System.Int32?)dataRow["SoTiet"];
			entity.ThanhTien = (Convert.IsDBNull(dataRow["ThanhTien"]))?0.0m:(System.Decimal?)dataRow["ThanhTien"];
			entity.MaLop = (Convert.IsDBNull(dataRow["MaLop"]))?string.Empty:(System.String)dataRow["MaLop"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewChiTienCoVanFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTienCoVan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewChiTienCoVanFilterBuilder : SqlFilterBuilder<ViewChiTienCoVanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTienCoVanFilterBuilder class.
		/// </summary>
		public ViewChiTienCoVanFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTienCoVanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewChiTienCoVanFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTienCoVanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewChiTienCoVanFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewChiTienCoVanFilterBuilder

	#region ViewChiTienCoVanParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTienCoVan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewChiTienCoVanParameterBuilder : ParameterizedSqlFilterBuilder<ViewChiTienCoVanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTienCoVanParameterBuilder class.
		/// </summary>
		public ViewChiTienCoVanParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTienCoVanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewChiTienCoVanParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTienCoVanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewChiTienCoVanParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewChiTienCoVanParameterBuilder
	
	#region ViewChiTienCoVanSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTienCoVan"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewChiTienCoVanSortBuilder : SqlSortBuilder<ViewChiTienCoVanColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTienCoVanSqlSortBuilder class.
		/// </summary>
		public ViewChiTienCoVanSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewChiTienCoVanSortBuilder

} // end namespace
