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
	/// This class is the base class for any <see cref="ViewHocPhanMonHocProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewHocPhanMonHocProviderBaseCore : EntityViewProviderBase<ViewHocPhanMonHoc>
	{
		#region Custom Methods
		
		
		#region cust_View_HocPhan_MonHoc_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_HocPhan_MonHoc_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewHocPhanMonHoc&gt;"/> instance.</returns>
		public VList<ViewHocPhanMonHoc> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_HocPhan_MonHoc_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewHocPhanMonHoc&gt;"/> instance.</returns>
		public VList<ViewHocPhanMonHoc> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_HocPhan_MonHoc_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewHocPhanMonHoc&gt;"/> instance.</returns>
		public VList<ViewHocPhanMonHoc> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_HocPhan_MonHoc_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewHocPhanMonHoc&gt;"/> instance.</returns>
		public abstract VList<ViewHocPhanMonHoc> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewHocPhanMonHoc&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewHocPhanMonHoc&gt;"/></returns>
		protected static VList&lt;ViewHocPhanMonHoc&gt; Fill(DataSet dataSet, VList<ViewHocPhanMonHoc> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewHocPhanMonHoc>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewHocPhanMonHoc&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewHocPhanMonHoc>"/></returns>
		protected static VList&lt;ViewHocPhanMonHoc&gt; Fill(DataTable dataTable, VList<ViewHocPhanMonHoc> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewHocPhanMonHoc c = new ViewHocPhanMonHoc();
					c.YearStudy = (Convert.IsDBNull(row["YearStudy"]))?string.Empty:(System.String)row["YearStudy"];
					c.TermId = (Convert.IsDBNull(row["TermId"]))?string.Empty:(System.String)row["TermId"];
					c.CurriculumId = (Convert.IsDBNull(row["CurriculumId"]))?string.Empty:(System.String)row["CurriculumId"];
					c.CurriculumName = (Convert.IsDBNull(row["CurriculumName"]))?string.Empty:(System.String)row["CurriculumName"];
					c.Credits = (Convert.IsDBNull(row["Credits"]))?0.0m:(System.Decimal)row["Credits"];
					c.DepartmentId = (Convert.IsDBNull(row["DepartmentId"]))?string.Empty:(System.String)row["DepartmentId"];
					c.DepartmentName = (Convert.IsDBNull(row["DepartmentName"]))?string.Empty:(System.String)row["DepartmentName"];
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
		/// Fill an <see cref="VList&lt;ViewHocPhanMonHoc&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewHocPhanMonHoc&gt;"/></returns>
		protected VList<ViewHocPhanMonHoc> Fill(IDataReader reader, VList<ViewHocPhanMonHoc> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewHocPhanMonHoc entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewHocPhanMonHoc>("ViewHocPhanMonHoc",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewHocPhanMonHoc();
					}
					
					entity.SuppressEntityEvents = true;

					entity.YearStudy = (System.String)reader["YearStudy"];
					//entity.YearStudy = (Convert.IsDBNull(reader["YearStudy"]))?string.Empty:(System.String)reader["YearStudy"];
					entity.TermId = (System.String)reader["TermId"];
					//entity.TermId = (Convert.IsDBNull(reader["TermId"]))?string.Empty:(System.String)reader["TermId"];
					entity.CurriculumId = (System.String)reader["CurriculumId"];
					//entity.CurriculumId = (Convert.IsDBNull(reader["CurriculumId"]))?string.Empty:(System.String)reader["CurriculumId"];
					entity.CurriculumName = (System.String)reader["CurriculumName"];
					//entity.CurriculumName = (Convert.IsDBNull(reader["CurriculumName"]))?string.Empty:(System.String)reader["CurriculumName"];
					entity.Credits = (System.Decimal)reader["Credits"];
					//entity.Credits = (Convert.IsDBNull(reader["Credits"]))?0.0m:(System.Decimal)reader["Credits"];
					entity.DepartmentId = (System.String)reader["DepartmentId"];
					//entity.DepartmentId = (Convert.IsDBNull(reader["DepartmentId"]))?string.Empty:(System.String)reader["DepartmentId"];
					entity.DepartmentName = (System.String)reader["DepartmentName"];
					//entity.DepartmentName = (Convert.IsDBNull(reader["DepartmentName"]))?string.Empty:(System.String)reader["DepartmentName"];
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
		/// Refreshes the <see cref="ViewHocPhanMonHoc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewHocPhanMonHoc"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewHocPhanMonHoc entity)
		{
			reader.Read();
			entity.YearStudy = (System.String)reader["YearStudy"];
			//entity.YearStudy = (Convert.IsDBNull(reader["YearStudy"]))?string.Empty:(System.String)reader["YearStudy"];
			entity.TermId = (System.String)reader["TermId"];
			//entity.TermId = (Convert.IsDBNull(reader["TermId"]))?string.Empty:(System.String)reader["TermId"];
			entity.CurriculumId = (System.String)reader["CurriculumId"];
			//entity.CurriculumId = (Convert.IsDBNull(reader["CurriculumId"]))?string.Empty:(System.String)reader["CurriculumId"];
			entity.CurriculumName = (System.String)reader["CurriculumName"];
			//entity.CurriculumName = (Convert.IsDBNull(reader["CurriculumName"]))?string.Empty:(System.String)reader["CurriculumName"];
			entity.Credits = (System.Decimal)reader["Credits"];
			//entity.Credits = (Convert.IsDBNull(reader["Credits"]))?0.0m:(System.Decimal)reader["Credits"];
			entity.DepartmentId = (System.String)reader["DepartmentId"];
			//entity.DepartmentId = (Convert.IsDBNull(reader["DepartmentId"]))?string.Empty:(System.String)reader["DepartmentId"];
			entity.DepartmentName = (System.String)reader["DepartmentName"];
			//entity.DepartmentName = (Convert.IsDBNull(reader["DepartmentName"]))?string.Empty:(System.String)reader["DepartmentName"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewHocPhanMonHoc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewHocPhanMonHoc"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewHocPhanMonHoc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.YearStudy = (Convert.IsDBNull(dataRow["YearStudy"]))?string.Empty:(System.String)dataRow["YearStudy"];
			entity.TermId = (Convert.IsDBNull(dataRow["TermId"]))?string.Empty:(System.String)dataRow["TermId"];
			entity.CurriculumId = (Convert.IsDBNull(dataRow["CurriculumId"]))?string.Empty:(System.String)dataRow["CurriculumId"];
			entity.CurriculumName = (Convert.IsDBNull(dataRow["CurriculumName"]))?string.Empty:(System.String)dataRow["CurriculumName"];
			entity.Credits = (Convert.IsDBNull(dataRow["Credits"]))?0.0m:(System.Decimal)dataRow["Credits"];
			entity.DepartmentId = (Convert.IsDBNull(dataRow["DepartmentId"]))?string.Empty:(System.String)dataRow["DepartmentId"];
			entity.DepartmentName = (Convert.IsDBNull(dataRow["DepartmentName"]))?string.Empty:(System.String)dataRow["DepartmentName"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewHocPhanMonHocFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHocPhanMonHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHocPhanMonHocFilterBuilder : SqlFilterBuilder<ViewHocPhanMonHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHocPhanMonHocFilterBuilder class.
		/// </summary>
		public ViewHocPhanMonHocFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewHocPhanMonHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewHocPhanMonHocFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewHocPhanMonHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewHocPhanMonHocFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewHocPhanMonHocFilterBuilder

	#region ViewHocPhanMonHocParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHocPhanMonHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHocPhanMonHocParameterBuilder : ParameterizedSqlFilterBuilder<ViewHocPhanMonHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHocPhanMonHocParameterBuilder class.
		/// </summary>
		public ViewHocPhanMonHocParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewHocPhanMonHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewHocPhanMonHocParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewHocPhanMonHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewHocPhanMonHocParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewHocPhanMonHocParameterBuilder
	
	#region ViewHocPhanMonHocSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHocPhanMonHoc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewHocPhanMonHocSortBuilder : SqlSortBuilder<ViewHocPhanMonHocColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHocPhanMonHocSqlSortBuilder class.
		/// </summary>
		public ViewHocPhanMonHocSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewHocPhanMonHocSortBuilder

} // end namespace
