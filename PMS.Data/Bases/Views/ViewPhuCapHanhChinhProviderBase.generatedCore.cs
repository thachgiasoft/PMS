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
	/// This class is the base class for any <see cref="ViewPhuCapHanhChinhProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewPhuCapHanhChinhProviderBaseCore : EntityViewProviderBase<ViewPhuCapHanhChinh>
	{
		#region Custom Methods
		
		
		#region cust_View_PhuCapHanhChinh_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_PhuCapHanhChinh_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewPhuCapHanhChinh&gt;"/> instance.</returns>
		public VList<ViewPhuCapHanhChinh> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_PhuCapHanhChinh_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewPhuCapHanhChinh&gt;"/> instance.</returns>
		public VList<ViewPhuCapHanhChinh> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_PhuCapHanhChinh_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewPhuCapHanhChinh&gt;"/> instance.</returns>
		public VList<ViewPhuCapHanhChinh> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_PhuCapHanhChinh_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewPhuCapHanhChinh&gt;"/> instance.</returns>
		public abstract VList<ViewPhuCapHanhChinh> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewPhuCapHanhChinh&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewPhuCapHanhChinh&gt;"/></returns>
		protected static VList&lt;ViewPhuCapHanhChinh&gt; Fill(DataSet dataSet, VList<ViewPhuCapHanhChinh> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewPhuCapHanhChinh>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewPhuCapHanhChinh&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewPhuCapHanhChinh>"/></returns>
		protected static VList&lt;ViewPhuCapHanhChinh&gt; Fill(DataTable dataTable, VList<ViewPhuCapHanhChinh> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewPhuCapHanhChinh c = new ViewPhuCapHanhChinh();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32)row["MaGiangVien"];
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.Ho = (Convert.IsDBNull(row["Ho"]))?string.Empty:(System.String)row["Ho"];
					c.Ten = (Convert.IsDBNull(row["Ten"]))?string.Empty:(System.String)row["Ten"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.SoThangTruPhuCapHanhChinh = (Convert.IsDBNull(row["SoThangTruPhuCapHanhChinh"]))?0.0m:(System.Decimal?)row["SoThangTruPhuCapHanhChinh"];
					c.DonGiaPhuCapHanhChinh = (Convert.IsDBNull(row["DonGiaPhuCapHanhChinh"]))?0.0m:(System.Decimal?)row["DonGiaPhuCapHanhChinh"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
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
		/// Fill an <see cref="VList&lt;ViewPhuCapHanhChinh&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewPhuCapHanhChinh&gt;"/></returns>
		protected VList<ViewPhuCapHanhChinh> Fill(IDataReader reader, VList<ViewPhuCapHanhChinh> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewPhuCapHanhChinh entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewPhuCapHanhChinh>("ViewPhuCapHanhChinh",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewPhuCapHanhChinh();
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
					entity.SoThangTruPhuCapHanhChinh = reader.IsDBNull(reader.GetOrdinal("SoThangTruPhuCapHanhChinh")) ? null : (System.Decimal?)reader["SoThangTruPhuCapHanhChinh"];
					//entity.SoThangTruPhuCapHanhChinh = (Convert.IsDBNull(reader["SoThangTruPhuCapHanhChinh"]))?0.0m:(System.Decimal?)reader["SoThangTruPhuCapHanhChinh"];
					entity.DonGiaPhuCapHanhChinh = reader.IsDBNull(reader.GetOrdinal("DonGiaPhuCapHanhChinh")) ? null : (System.Decimal?)reader["DonGiaPhuCapHanhChinh"];
					//entity.DonGiaPhuCapHanhChinh = (Convert.IsDBNull(reader["DonGiaPhuCapHanhChinh"]))?0.0m:(System.Decimal?)reader["DonGiaPhuCapHanhChinh"];
					entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
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
		/// Refreshes the <see cref="ViewPhuCapHanhChinh"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewPhuCapHanhChinh"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewPhuCapHanhChinh entity)
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
			entity.SoThangTruPhuCapHanhChinh = reader.IsDBNull(reader.GetOrdinal("SoThangTruPhuCapHanhChinh")) ? null : (System.Decimal?)reader["SoThangTruPhuCapHanhChinh"];
			//entity.SoThangTruPhuCapHanhChinh = (Convert.IsDBNull(reader["SoThangTruPhuCapHanhChinh"]))?0.0m:(System.Decimal?)reader["SoThangTruPhuCapHanhChinh"];
			entity.DonGiaPhuCapHanhChinh = reader.IsDBNull(reader.GetOrdinal("DonGiaPhuCapHanhChinh")) ? null : (System.Decimal?)reader["DonGiaPhuCapHanhChinh"];
			//entity.DonGiaPhuCapHanhChinh = (Convert.IsDBNull(reader["DonGiaPhuCapHanhChinh"]))?0.0m:(System.Decimal?)reader["DonGiaPhuCapHanhChinh"];
			entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewPhuCapHanhChinh"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewPhuCapHanhChinh"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewPhuCapHanhChinh entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32)dataRow["MaGiangVien"];
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.Ho = (Convert.IsDBNull(dataRow["Ho"]))?string.Empty:(System.String)dataRow["Ho"];
			entity.Ten = (Convert.IsDBNull(dataRow["Ten"]))?string.Empty:(System.String)dataRow["Ten"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.SoThangTruPhuCapHanhChinh = (Convert.IsDBNull(dataRow["SoThangTruPhuCapHanhChinh"]))?0.0m:(System.Decimal?)dataRow["SoThangTruPhuCapHanhChinh"];
			entity.DonGiaPhuCapHanhChinh = (Convert.IsDBNull(dataRow["DonGiaPhuCapHanhChinh"]))?0.0m:(System.Decimal?)dataRow["DonGiaPhuCapHanhChinh"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewPhuCapHanhChinhFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhuCapHanhChinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhuCapHanhChinhFilterBuilder : SqlFilterBuilder<ViewPhuCapHanhChinhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhuCapHanhChinhFilterBuilder class.
		/// </summary>
		public ViewPhuCapHanhChinhFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewPhuCapHanhChinhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewPhuCapHanhChinhFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewPhuCapHanhChinhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewPhuCapHanhChinhFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewPhuCapHanhChinhFilterBuilder

	#region ViewPhuCapHanhChinhParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhuCapHanhChinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhuCapHanhChinhParameterBuilder : ParameterizedSqlFilterBuilder<ViewPhuCapHanhChinhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhuCapHanhChinhParameterBuilder class.
		/// </summary>
		public ViewPhuCapHanhChinhParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewPhuCapHanhChinhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewPhuCapHanhChinhParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewPhuCapHanhChinhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewPhuCapHanhChinhParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewPhuCapHanhChinhParameterBuilder
	
	#region ViewPhuCapHanhChinhSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhuCapHanhChinh"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewPhuCapHanhChinhSortBuilder : SqlSortBuilder<ViewPhuCapHanhChinhColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhuCapHanhChinhSqlSortBuilder class.
		/// </summary>
		public ViewPhuCapHanhChinhSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewPhuCapHanhChinhSortBuilder

} // end namespace
