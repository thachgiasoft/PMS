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
	/// This class is the base class for any <see cref="ViewKcqPhuCapHanhChinhProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewKcqPhuCapHanhChinhProviderBaseCore : EntityViewProviderBase<ViewKcqPhuCapHanhChinh>
	{
		#region Custom Methods
		
		
		#region cust_View_KcqPhuCapHanhChinh_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_KcqPhuCapHanhChinh_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKcqPhuCapHanhChinh&gt;"/> instance.</returns>
		public VList<ViewKcqPhuCapHanhChinh> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KcqPhuCapHanhChinh_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKcqPhuCapHanhChinh&gt;"/> instance.</returns>
		public VList<ViewKcqPhuCapHanhChinh> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_KcqPhuCapHanhChinh_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewKcqPhuCapHanhChinh&gt;"/> instance.</returns>
		public VList<ViewKcqPhuCapHanhChinh> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KcqPhuCapHanhChinh_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKcqPhuCapHanhChinh&gt;"/> instance.</returns>
		public abstract VList<ViewKcqPhuCapHanhChinh> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewKcqPhuCapHanhChinh&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewKcqPhuCapHanhChinh&gt;"/></returns>
		protected static VList&lt;ViewKcqPhuCapHanhChinh&gt; Fill(DataSet dataSet, VList<ViewKcqPhuCapHanhChinh> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewKcqPhuCapHanhChinh>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewKcqPhuCapHanhChinh&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewKcqPhuCapHanhChinh>"/></returns>
		protected static VList&lt;ViewKcqPhuCapHanhChinh&gt; Fill(DataTable dataTable, VList<ViewKcqPhuCapHanhChinh> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewKcqPhuCapHanhChinh c = new ViewKcqPhuCapHanhChinh();
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
		/// Fill an <see cref="VList&lt;ViewKcqPhuCapHanhChinh&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewKcqPhuCapHanhChinh&gt;"/></returns>
		protected VList<ViewKcqPhuCapHanhChinh> Fill(IDataReader reader, VList<ViewKcqPhuCapHanhChinh> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewKcqPhuCapHanhChinh entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewKcqPhuCapHanhChinh>("ViewKcqPhuCapHanhChinh",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewKcqPhuCapHanhChinh();
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
		/// Refreshes the <see cref="ViewKcqPhuCapHanhChinh"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewKcqPhuCapHanhChinh"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewKcqPhuCapHanhChinh entity)
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
		/// Refreshes the <see cref="ViewKcqPhuCapHanhChinh"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewKcqPhuCapHanhChinh"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewKcqPhuCapHanhChinh entity)
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

	#region ViewKcqPhuCapHanhChinhFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKcqPhuCapHanhChinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKcqPhuCapHanhChinhFilterBuilder : SqlFilterBuilder<ViewKcqPhuCapHanhChinhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKcqPhuCapHanhChinhFilterBuilder class.
		/// </summary>
		public ViewKcqPhuCapHanhChinhFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewKcqPhuCapHanhChinhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewKcqPhuCapHanhChinhFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewKcqPhuCapHanhChinhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewKcqPhuCapHanhChinhFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewKcqPhuCapHanhChinhFilterBuilder

	#region ViewKcqPhuCapHanhChinhParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKcqPhuCapHanhChinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKcqPhuCapHanhChinhParameterBuilder : ParameterizedSqlFilterBuilder<ViewKcqPhuCapHanhChinhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKcqPhuCapHanhChinhParameterBuilder class.
		/// </summary>
		public ViewKcqPhuCapHanhChinhParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewKcqPhuCapHanhChinhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewKcqPhuCapHanhChinhParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewKcqPhuCapHanhChinhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewKcqPhuCapHanhChinhParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewKcqPhuCapHanhChinhParameterBuilder
	
	#region ViewKcqPhuCapHanhChinhSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKcqPhuCapHanhChinh"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewKcqPhuCapHanhChinhSortBuilder : SqlSortBuilder<ViewKcqPhuCapHanhChinhColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKcqPhuCapHanhChinhSqlSortBuilder class.
		/// </summary>
		public ViewKcqPhuCapHanhChinhSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewKcqPhuCapHanhChinhSortBuilder

} // end namespace
