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
	/// This class is the base class for any <see cref="ViewDonGiaNgoaiQuyCheProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewDonGiaNgoaiQuyCheProviderBaseCore : EntityViewProviderBase<ViewDonGiaNgoaiQuyChe>
	{
		#region Custom Methods
		
		
		#region cust_View_DonGiaNgoaiQuyChe_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_DonGiaNgoaiQuyChe_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewDonGiaNgoaiQuyChe&gt;"/> instance.</returns>
		public VList<ViewDonGiaNgoaiQuyChe> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_DonGiaNgoaiQuyChe_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewDonGiaNgoaiQuyChe&gt;"/> instance.</returns>
		public VList<ViewDonGiaNgoaiQuyChe> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_DonGiaNgoaiQuyChe_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewDonGiaNgoaiQuyChe&gt;"/> instance.</returns>
		public VList<ViewDonGiaNgoaiQuyChe> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_DonGiaNgoaiQuyChe_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewDonGiaNgoaiQuyChe&gt;"/> instance.</returns>
		public abstract VList<ViewDonGiaNgoaiQuyChe> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewDonGiaNgoaiQuyChe&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewDonGiaNgoaiQuyChe&gt;"/></returns>
		protected static VList&lt;ViewDonGiaNgoaiQuyChe&gt; Fill(DataSet dataSet, VList<ViewDonGiaNgoaiQuyChe> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewDonGiaNgoaiQuyChe>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewDonGiaNgoaiQuyChe&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewDonGiaNgoaiQuyChe>"/></returns>
		protected static VList&lt;ViewDonGiaNgoaiQuyChe&gt; Fill(DataTable dataTable, VList<ViewDonGiaNgoaiQuyChe> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewDonGiaNgoaiQuyChe c = new ViewDonGiaNgoaiQuyChe();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32)row["MaGiangVien"];
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.Ho = (Convert.IsDBNull(row["Ho"]))?string.Empty:(System.String)row["Ho"];
					c.Ten = (Convert.IsDBNull(row["Ten"]))?string.Empty:(System.String)row["Ten"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.DonGiaDaiTra = (Convert.IsDBNull(row["DonGiaDaiTra"]))?0.0m:(System.Decimal?)row["DonGiaDaiTra"];
					c.DonGiaClc = (Convert.IsDBNull(row["DonGiaClc"]))?0.0m:(System.Decimal?)row["DonGiaClc"];
					c.GhiChu = (Convert.IsDBNull(row["GhiChu"]))?string.Empty:(System.String)row["GhiChu"];
					c.NgayCapNhat = (Convert.IsDBNull(row["NgayCapNhat"]))?DateTime.MinValue:(System.DateTime?)row["NgayCapNhat"];
					c.TuNgay = (Convert.IsDBNull(row["TuNgay"]))?DateTime.MinValue:(System.DateTime?)row["TuNgay"];
					c.DenNgay = (Convert.IsDBNull(row["DenNgay"]))?DateTime.MinValue:(System.DateTime?)row["DenNgay"];
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
		/// Fill an <see cref="VList&lt;ViewDonGiaNgoaiQuyChe&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewDonGiaNgoaiQuyChe&gt;"/></returns>
		protected VList<ViewDonGiaNgoaiQuyChe> Fill(IDataReader reader, VList<ViewDonGiaNgoaiQuyChe> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewDonGiaNgoaiQuyChe entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewDonGiaNgoaiQuyChe>("ViewDonGiaNgoaiQuyChe",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewDonGiaNgoaiQuyChe();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = (System.Int32)reader["MaGiangVien"];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
					entity.MaQuanLy = (System.String)reader["MaQuanLy"];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.Ho = reader.IsDBNull(reader.GetOrdinal("Ho")) ? null : (System.String)reader["Ho"];
					//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
					entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
					//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
					entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.DonGiaDaiTra = reader.IsDBNull(reader.GetOrdinal("DonGiaDaiTra")) ? null : (System.Decimal?)reader["DonGiaDaiTra"];
					//entity.DonGiaDaiTra = (Convert.IsDBNull(reader["DonGiaDaiTra"]))?0.0m:(System.Decimal?)reader["DonGiaDaiTra"];
					entity.DonGiaClc = reader.IsDBNull(reader.GetOrdinal("DonGiaClc")) ? null : (System.Decimal?)reader["DonGiaClc"];
					//entity.DonGiaClc = (Convert.IsDBNull(reader["DonGiaClc"]))?0.0m:(System.Decimal?)reader["DonGiaClc"];
					entity.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : (System.String)reader["GhiChu"];
					//entity.GhiChu = (Convert.IsDBNull(reader["GhiChu"]))?string.Empty:(System.String)reader["GhiChu"];
					entity.NgayCapNhat = reader.IsDBNull(reader.GetOrdinal("NgayCapNhat")) ? null : (System.DateTime?)reader["NgayCapNhat"];
					//entity.NgayCapNhat = (Convert.IsDBNull(reader["NgayCapNhat"]))?DateTime.MinValue:(System.DateTime?)reader["NgayCapNhat"];
					entity.TuNgay = reader.IsDBNull(reader.GetOrdinal("TuNgay")) ? null : (System.DateTime?)reader["TuNgay"];
					//entity.TuNgay = (Convert.IsDBNull(reader["TuNgay"]))?DateTime.MinValue:(System.DateTime?)reader["TuNgay"];
					entity.DenNgay = reader.IsDBNull(reader.GetOrdinal("DenNgay")) ? null : (System.DateTime?)reader["DenNgay"];
					//entity.DenNgay = (Convert.IsDBNull(reader["DenNgay"]))?DateTime.MinValue:(System.DateTime?)reader["DenNgay"];
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
		/// Refreshes the <see cref="ViewDonGiaNgoaiQuyChe"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewDonGiaNgoaiQuyChe"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewDonGiaNgoaiQuyChe entity)
		{
			reader.Read();
			entity.MaGiangVien = (System.Int32)reader["MaGiangVien"];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
			entity.MaQuanLy = (System.String)reader["MaQuanLy"];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.Ho = reader.IsDBNull(reader.GetOrdinal("Ho")) ? null : (System.String)reader["Ho"];
			//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
			entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
			//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
			entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.DonGiaDaiTra = reader.IsDBNull(reader.GetOrdinal("DonGiaDaiTra")) ? null : (System.Decimal?)reader["DonGiaDaiTra"];
			//entity.DonGiaDaiTra = (Convert.IsDBNull(reader["DonGiaDaiTra"]))?0.0m:(System.Decimal?)reader["DonGiaDaiTra"];
			entity.DonGiaClc = reader.IsDBNull(reader.GetOrdinal("DonGiaClc")) ? null : (System.Decimal?)reader["DonGiaClc"];
			//entity.DonGiaClc = (Convert.IsDBNull(reader["DonGiaClc"]))?0.0m:(System.Decimal?)reader["DonGiaClc"];
			entity.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : (System.String)reader["GhiChu"];
			//entity.GhiChu = (Convert.IsDBNull(reader["GhiChu"]))?string.Empty:(System.String)reader["GhiChu"];
			entity.NgayCapNhat = reader.IsDBNull(reader.GetOrdinal("NgayCapNhat")) ? null : (System.DateTime?)reader["NgayCapNhat"];
			//entity.NgayCapNhat = (Convert.IsDBNull(reader["NgayCapNhat"]))?DateTime.MinValue:(System.DateTime?)reader["NgayCapNhat"];
			entity.TuNgay = reader.IsDBNull(reader.GetOrdinal("TuNgay")) ? null : (System.DateTime?)reader["TuNgay"];
			//entity.TuNgay = (Convert.IsDBNull(reader["TuNgay"]))?DateTime.MinValue:(System.DateTime?)reader["TuNgay"];
			entity.DenNgay = reader.IsDBNull(reader.GetOrdinal("DenNgay")) ? null : (System.DateTime?)reader["DenNgay"];
			//entity.DenNgay = (Convert.IsDBNull(reader["DenNgay"]))?DateTime.MinValue:(System.DateTime?)reader["DenNgay"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewDonGiaNgoaiQuyChe"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewDonGiaNgoaiQuyChe"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewDonGiaNgoaiQuyChe entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32)dataRow["MaGiangVien"];
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.Ho = (Convert.IsDBNull(dataRow["Ho"]))?string.Empty:(System.String)dataRow["Ho"];
			entity.Ten = (Convert.IsDBNull(dataRow["Ten"]))?string.Empty:(System.String)dataRow["Ten"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.DonGiaDaiTra = (Convert.IsDBNull(dataRow["DonGiaDaiTra"]))?0.0m:(System.Decimal?)dataRow["DonGiaDaiTra"];
			entity.DonGiaClc = (Convert.IsDBNull(dataRow["DonGiaClc"]))?0.0m:(System.Decimal?)dataRow["DonGiaClc"];
			entity.GhiChu = (Convert.IsDBNull(dataRow["GhiChu"]))?string.Empty:(System.String)dataRow["GhiChu"];
			entity.NgayCapNhat = (Convert.IsDBNull(dataRow["NgayCapNhat"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayCapNhat"];
			entity.TuNgay = (Convert.IsDBNull(dataRow["TuNgay"]))?DateTime.MinValue:(System.DateTime?)dataRow["TuNgay"];
			entity.DenNgay = (Convert.IsDBNull(dataRow["DenNgay"]))?DateTime.MinValue:(System.DateTime?)dataRow["DenNgay"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewDonGiaNgoaiQuyCheFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewDonGiaNgoaiQuyChe"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewDonGiaNgoaiQuyCheFilterBuilder : SqlFilterBuilder<ViewDonGiaNgoaiQuyCheColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewDonGiaNgoaiQuyCheFilterBuilder class.
		/// </summary>
		public ViewDonGiaNgoaiQuyCheFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewDonGiaNgoaiQuyCheFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewDonGiaNgoaiQuyCheFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewDonGiaNgoaiQuyCheFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewDonGiaNgoaiQuyCheFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewDonGiaNgoaiQuyCheFilterBuilder

	#region ViewDonGiaNgoaiQuyCheParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewDonGiaNgoaiQuyChe"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewDonGiaNgoaiQuyCheParameterBuilder : ParameterizedSqlFilterBuilder<ViewDonGiaNgoaiQuyCheColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewDonGiaNgoaiQuyCheParameterBuilder class.
		/// </summary>
		public ViewDonGiaNgoaiQuyCheParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewDonGiaNgoaiQuyCheParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewDonGiaNgoaiQuyCheParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewDonGiaNgoaiQuyCheParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewDonGiaNgoaiQuyCheParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewDonGiaNgoaiQuyCheParameterBuilder
	
	#region ViewDonGiaNgoaiQuyCheSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewDonGiaNgoaiQuyChe"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewDonGiaNgoaiQuyCheSortBuilder : SqlSortBuilder<ViewDonGiaNgoaiQuyCheColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewDonGiaNgoaiQuyCheSqlSortBuilder class.
		/// </summary>
		public ViewDonGiaNgoaiQuyCheSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewDonGiaNgoaiQuyCheSortBuilder

} // end namespace
