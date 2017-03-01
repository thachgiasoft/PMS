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
	/// This class is the base class for any <see cref="ViewPhanNhomMonHocProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewPhanNhomMonHocProviderBaseCore : EntityViewProviderBase<ViewPhanNhomMonHoc>
	{
		#region Custom Methods
		
		
		#region cust_View_PhanNhomMonHoc_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_PhanNhomMonHoc_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewPhanNhomMonHoc&gt;"/> instance.</returns>
		public VList<ViewPhanNhomMonHoc> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_PhanNhomMonHoc_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewPhanNhomMonHoc&gt;"/> instance.</returns>
		public VList<ViewPhanNhomMonHoc> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_PhanNhomMonHoc_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewPhanNhomMonHoc&gt;"/> instance.</returns>
		public VList<ViewPhanNhomMonHoc> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_PhanNhomMonHoc_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewPhanNhomMonHoc&gt;"/> instance.</returns>
		public abstract VList<ViewPhanNhomMonHoc> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#region cust_View_PhanNhomMonHoc_Act_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_PhanNhomMonHoc_Act_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader Act_GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return Act_GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_PhanNhomMonHoc_Act_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader Act_GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return Act_GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_PhanNhomMonHoc_Act_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader Act_GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return Act_GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_PhanNhomMonHoc_Act_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader Act_GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewPhanNhomMonHoc&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewPhanNhomMonHoc&gt;"/></returns>
		protected static VList&lt;ViewPhanNhomMonHoc&gt; Fill(DataSet dataSet, VList<ViewPhanNhomMonHoc> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewPhanNhomMonHoc>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewPhanNhomMonHoc&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewPhanNhomMonHoc>"/></returns>
		protected static VList&lt;ViewPhanNhomMonHoc&gt; Fill(DataTable dataTable, VList<ViewPhanNhomMonHoc> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewPhanNhomMonHoc c = new ViewPhanNhomMonHoc();
					c.CurriculumId = (Convert.IsDBNull(row["CurriculumID"]))?string.Empty:(System.String)row["CurriculumID"];
					c.CurriculumName = (Convert.IsDBNull(row["CurriculumName"]))?string.Empty:(System.String)row["CurriculumName"];
					c.Credits = (Convert.IsDBNull(row["Credits"]))?0.0m:(System.Decimal)row["Credits"];
					c.DepartmentId = (Convert.IsDBNull(row["DepartmentID"]))?string.Empty:(System.String)row["DepartmentID"];
					c.DepartmentName = (Convert.IsDBNull(row["DepartmentName"]))?string.Empty:(System.String)row["DepartmentName"];
					c.StudyUnitTypeId = (Convert.IsDBNull(row["StudyUnitTypeID"]))?(byte)0:(System.Byte)row["StudyUnitTypeID"];
					c.NumberOfPeriods = (Convert.IsDBNull(row["NumberOfPeriods"]))?0.0m:(System.Decimal)row["NumberOfPeriods"];
					c.MaNhomMonHoc = (Convert.IsDBNull(row["MaNhomMonHoc"]))?(int)0:(System.Int32?)row["MaNhomMonHoc"];
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
		/// Fill an <see cref="VList&lt;ViewPhanNhomMonHoc&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewPhanNhomMonHoc&gt;"/></returns>
		protected VList<ViewPhanNhomMonHoc> Fill(IDataReader reader, VList<ViewPhanNhomMonHoc> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewPhanNhomMonHoc entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewPhanNhomMonHoc>("ViewPhanNhomMonHoc",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewPhanNhomMonHoc();
					}
					
					entity.SuppressEntityEvents = true;

					entity.CurriculumId = (System.String)reader["CurriculumId"];
					//entity.CurriculumId = (Convert.IsDBNull(reader["CurriculumID"]))?string.Empty:(System.String)reader["CurriculumID"];
					entity.CurriculumName = (System.String)reader["CurriculumName"];
					//entity.CurriculumName = (Convert.IsDBNull(reader["CurriculumName"]))?string.Empty:(System.String)reader["CurriculumName"];
					entity.Credits = (System.Decimal)reader["Credits"];
					//entity.Credits = (Convert.IsDBNull(reader["Credits"]))?0.0m:(System.Decimal)reader["Credits"];
					entity.DepartmentId = (System.String)reader["DepartmentId"];
					//entity.DepartmentId = (Convert.IsDBNull(reader["DepartmentID"]))?string.Empty:(System.String)reader["DepartmentID"];
					entity.DepartmentName = (System.String)reader["DepartmentName"];
					//entity.DepartmentName = (Convert.IsDBNull(reader["DepartmentName"]))?string.Empty:(System.String)reader["DepartmentName"];
					entity.StudyUnitTypeId = (System.Byte)reader["StudyUnitTypeId"];
					//entity.StudyUnitTypeId = (Convert.IsDBNull(reader["StudyUnitTypeID"]))?(byte)0:(System.Byte)reader["StudyUnitTypeID"];
					entity.NumberOfPeriods = (System.Decimal)reader["NumberOfPeriods"];
					//entity.NumberOfPeriods = (Convert.IsDBNull(reader["NumberOfPeriods"]))?0.0m:(System.Decimal)reader["NumberOfPeriods"];
					entity.MaNhomMonHoc = reader.IsDBNull(reader.GetOrdinal("MaNhomMonHoc")) ? null : (System.Int32?)reader["MaNhomMonHoc"];
					//entity.MaNhomMonHoc = (Convert.IsDBNull(reader["MaNhomMonHoc"]))?(int)0:(System.Int32?)reader["MaNhomMonHoc"];
					entity.NamHoc = (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = (System.String)reader["HocKy"];
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
		/// Refreshes the <see cref="ViewPhanNhomMonHoc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewPhanNhomMonHoc"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewPhanNhomMonHoc entity)
		{
			reader.Read();
			entity.CurriculumId = (System.String)reader["CurriculumId"];
			//entity.CurriculumId = (Convert.IsDBNull(reader["CurriculumID"]))?string.Empty:(System.String)reader["CurriculumID"];
			entity.CurriculumName = (System.String)reader["CurriculumName"];
			//entity.CurriculumName = (Convert.IsDBNull(reader["CurriculumName"]))?string.Empty:(System.String)reader["CurriculumName"];
			entity.Credits = (System.Decimal)reader["Credits"];
			//entity.Credits = (Convert.IsDBNull(reader["Credits"]))?0.0m:(System.Decimal)reader["Credits"];
			entity.DepartmentId = (System.String)reader["DepartmentId"];
			//entity.DepartmentId = (Convert.IsDBNull(reader["DepartmentID"]))?string.Empty:(System.String)reader["DepartmentID"];
			entity.DepartmentName = (System.String)reader["DepartmentName"];
			//entity.DepartmentName = (Convert.IsDBNull(reader["DepartmentName"]))?string.Empty:(System.String)reader["DepartmentName"];
			entity.StudyUnitTypeId = (System.Byte)reader["StudyUnitTypeId"];
			//entity.StudyUnitTypeId = (Convert.IsDBNull(reader["StudyUnitTypeID"]))?(byte)0:(System.Byte)reader["StudyUnitTypeID"];
			entity.NumberOfPeriods = (System.Decimal)reader["NumberOfPeriods"];
			//entity.NumberOfPeriods = (Convert.IsDBNull(reader["NumberOfPeriods"]))?0.0m:(System.Decimal)reader["NumberOfPeriods"];
			entity.MaNhomMonHoc = reader.IsDBNull(reader.GetOrdinal("MaNhomMonHoc")) ? null : (System.Int32?)reader["MaNhomMonHoc"];
			//entity.MaNhomMonHoc = (Convert.IsDBNull(reader["MaNhomMonHoc"]))?(int)0:(System.Int32?)reader["MaNhomMonHoc"];
			entity.NamHoc = (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewPhanNhomMonHoc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewPhanNhomMonHoc"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewPhanNhomMonHoc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CurriculumId = (Convert.IsDBNull(dataRow["CurriculumID"]))?string.Empty:(System.String)dataRow["CurriculumID"];
			entity.CurriculumName = (Convert.IsDBNull(dataRow["CurriculumName"]))?string.Empty:(System.String)dataRow["CurriculumName"];
			entity.Credits = (Convert.IsDBNull(dataRow["Credits"]))?0.0m:(System.Decimal)dataRow["Credits"];
			entity.DepartmentId = (Convert.IsDBNull(dataRow["DepartmentID"]))?string.Empty:(System.String)dataRow["DepartmentID"];
			entity.DepartmentName = (Convert.IsDBNull(dataRow["DepartmentName"]))?string.Empty:(System.String)dataRow["DepartmentName"];
			entity.StudyUnitTypeId = (Convert.IsDBNull(dataRow["StudyUnitTypeID"]))?(byte)0:(System.Byte)dataRow["StudyUnitTypeID"];
			entity.NumberOfPeriods = (Convert.IsDBNull(dataRow["NumberOfPeriods"]))?0.0m:(System.Decimal)dataRow["NumberOfPeriods"];
			entity.MaNhomMonHoc = (Convert.IsDBNull(dataRow["MaNhomMonHoc"]))?(int)0:(System.Int32?)dataRow["MaNhomMonHoc"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewPhanNhomMonHocFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhanNhomMonHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhanNhomMonHocFilterBuilder : SqlFilterBuilder<ViewPhanNhomMonHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhanNhomMonHocFilterBuilder class.
		/// </summary>
		public ViewPhanNhomMonHocFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewPhanNhomMonHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewPhanNhomMonHocFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewPhanNhomMonHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewPhanNhomMonHocFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewPhanNhomMonHocFilterBuilder

	#region ViewPhanNhomMonHocParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhanNhomMonHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhanNhomMonHocParameterBuilder : ParameterizedSqlFilterBuilder<ViewPhanNhomMonHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhanNhomMonHocParameterBuilder class.
		/// </summary>
		public ViewPhanNhomMonHocParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewPhanNhomMonHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewPhanNhomMonHocParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewPhanNhomMonHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewPhanNhomMonHocParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewPhanNhomMonHocParameterBuilder
	
	#region ViewPhanNhomMonHocSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhanNhomMonHoc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewPhanNhomMonHocSortBuilder : SqlSortBuilder<ViewPhanNhomMonHocColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhanNhomMonHocSqlSortBuilder class.
		/// </summary>
		public ViewPhanNhomMonHocSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewPhanNhomMonHocSortBuilder

} // end namespace
