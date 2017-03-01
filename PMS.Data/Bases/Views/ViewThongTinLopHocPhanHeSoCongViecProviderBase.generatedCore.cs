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
	/// This class is the base class for any <see cref="ViewThongTinLopHocPhanHeSoCongViecProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewThongTinLopHocPhanHeSoCongViecProviderBaseCore : EntityViewProviderBase<ViewThongTinLopHocPhanHeSoCongViec>
	{
		#region Custom Methods
		
		
		#region cust_View_ThongTinLopHocPhan_HeSoCongViec_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_ThongTinLopHocPhan_HeSoCongViec_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThongTinLopHocPhanHeSoCongViec&gt;"/> instance.</returns>
		public VList<ViewThongTinLopHocPhanHeSoCongViec> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThongTinLopHocPhan_HeSoCongViec_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThongTinLopHocPhanHeSoCongViec&gt;"/> instance.</returns>
		public VList<ViewThongTinLopHocPhanHeSoCongViec> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ThongTinLopHocPhan_HeSoCongViec_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewThongTinLopHocPhanHeSoCongViec&gt;"/> instance.</returns>
		public VList<ViewThongTinLopHocPhanHeSoCongViec> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThongTinLopHocPhan_HeSoCongViec_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThongTinLopHocPhanHeSoCongViec&gt;"/> instance.</returns>
		public abstract VList<ViewThongTinLopHocPhanHeSoCongViec> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewThongTinLopHocPhanHeSoCongViec&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewThongTinLopHocPhanHeSoCongViec&gt;"/></returns>
		protected static VList&lt;ViewThongTinLopHocPhanHeSoCongViec&gt; Fill(DataSet dataSet, VList<ViewThongTinLopHocPhanHeSoCongViec> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewThongTinLopHocPhanHeSoCongViec>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewThongTinLopHocPhanHeSoCongViec&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewThongTinLopHocPhanHeSoCongViec>"/></returns>
		protected static VList&lt;ViewThongTinLopHocPhanHeSoCongViec&gt; Fill(DataTable dataTable, VList<ViewThongTinLopHocPhanHeSoCongViec> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewThongTinLopHocPhanHeSoCongViec c = new ViewThongTinLopHocPhanHeSoCongViec();
					c.YearStudy = (Convert.IsDBNull(row["YearStudy"]))?string.Empty:(System.String)row["YearStudy"];
					c.TermId = (Convert.IsDBNull(row["TermID"]))?string.Empty:(System.String)row["TermID"];
					c.StudyUnitId = (Convert.IsDBNull(row["StudyUnitID"]))?string.Empty:(System.String)row["StudyUnitID"];
					c.ScheduleStudyUnitId = (Convert.IsDBNull(row["ScheduleStudyUnitID"]))?string.Empty:(System.String)row["ScheduleStudyUnitID"];
					c.CurriculumId = (Convert.IsDBNull(row["CurriculumID"]))?string.Empty:(System.String)row["CurriculumID"];
					c.CurriculumName = (Convert.IsDBNull(row["CurriculumName"]))?string.Empty:(System.String)row["CurriculumName"];
					c.Credits = (Convert.IsDBNull(row["Credits"]))?(int)0:(System.Int32?)row["Credits"];
					c.StudyUnitTypeId = (Convert.IsDBNull(row["StudyUnitTypeID"]))?(byte)0:(System.Byte)row["StudyUnitTypeID"];
					c.StudyUnitTypeName = (Convert.IsDBNull(row["StudyUnitTypeName"]))?string.Empty:(System.String)row["StudyUnitTypeName"];
					c.StudyUnitTypeAbbreviation = (Convert.IsDBNull(row["StudyUnitTypeAbbreviation"]))?string.Empty:(System.String)row["StudyUnitTypeAbbreviation"];
					c.ListOfClassStudentId = (Convert.IsDBNull(row["ListOfClassStudentID"]))?string.Empty:(System.String)row["ListOfClassStudentID"];
					c.ListOfProfessorId = (Convert.IsDBNull(row["ListOfProfessorID"]))?string.Empty:(System.String)row["ListOfProfessorID"];
					c.ListOfProfessorFirstName = (Convert.IsDBNull(row["ListOfProfessorFirstName"]))?string.Empty:(System.String)row["ListOfProfessorFirstName"];
					c.MaHeSoCongViec = (Convert.IsDBNull(row["MaHeSoCongViec"]))?(int)0:(System.Int32?)row["MaHeSoCongViec"];
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
		/// Fill an <see cref="VList&lt;ViewThongTinLopHocPhanHeSoCongViec&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewThongTinLopHocPhanHeSoCongViec&gt;"/></returns>
		protected VList<ViewThongTinLopHocPhanHeSoCongViec> Fill(IDataReader reader, VList<ViewThongTinLopHocPhanHeSoCongViec> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewThongTinLopHocPhanHeSoCongViec entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewThongTinLopHocPhanHeSoCongViec>("ViewThongTinLopHocPhanHeSoCongViec",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewThongTinLopHocPhanHeSoCongViec();
					}
					
					entity.SuppressEntityEvents = true;

					entity.YearStudy = (System.String)reader["YearStudy"];
					//entity.YearStudy = (Convert.IsDBNull(reader["YearStudy"]))?string.Empty:(System.String)reader["YearStudy"];
					entity.TermId = (System.String)reader["TermId"];
					//entity.TermId = (Convert.IsDBNull(reader["TermID"]))?string.Empty:(System.String)reader["TermID"];
					entity.StudyUnitId = (System.String)reader["StudyUnitId"];
					//entity.StudyUnitId = (Convert.IsDBNull(reader["StudyUnitID"]))?string.Empty:(System.String)reader["StudyUnitID"];
					entity.ScheduleStudyUnitId = (System.String)reader["ScheduleStudyUnitId"];
					//entity.ScheduleStudyUnitId = (Convert.IsDBNull(reader["ScheduleStudyUnitID"]))?string.Empty:(System.String)reader["ScheduleStudyUnitID"];
					entity.CurriculumId = (System.String)reader["CurriculumId"];
					//entity.CurriculumId = (Convert.IsDBNull(reader["CurriculumID"]))?string.Empty:(System.String)reader["CurriculumID"];
					entity.CurriculumName = (System.String)reader["CurriculumName"];
					//entity.CurriculumName = (Convert.IsDBNull(reader["CurriculumName"]))?string.Empty:(System.String)reader["CurriculumName"];
					entity.Credits = reader.IsDBNull(reader.GetOrdinal("Credits")) ? null : (System.Int32?)reader["Credits"];
					//entity.Credits = (Convert.IsDBNull(reader["Credits"]))?(int)0:(System.Int32?)reader["Credits"];
					entity.StudyUnitTypeId = (System.Byte)reader["StudyUnitTypeId"];
					//entity.StudyUnitTypeId = (Convert.IsDBNull(reader["StudyUnitTypeID"]))?(byte)0:(System.Byte)reader["StudyUnitTypeID"];
					entity.StudyUnitTypeName = (System.String)reader["StudyUnitTypeName"];
					//entity.StudyUnitTypeName = (Convert.IsDBNull(reader["StudyUnitTypeName"]))?string.Empty:(System.String)reader["StudyUnitTypeName"];
					entity.StudyUnitTypeAbbreviation = reader.IsDBNull(reader.GetOrdinal("StudyUnitTypeAbbreviation")) ? null : (System.String)reader["StudyUnitTypeAbbreviation"];
					//entity.StudyUnitTypeAbbreviation = (Convert.IsDBNull(reader["StudyUnitTypeAbbreviation"]))?string.Empty:(System.String)reader["StudyUnitTypeAbbreviation"];
					entity.ListOfClassStudentId = (System.String)reader["ListOfClassStudentId"];
					//entity.ListOfClassStudentId = (Convert.IsDBNull(reader["ListOfClassStudentID"]))?string.Empty:(System.String)reader["ListOfClassStudentID"];
					entity.ListOfProfessorId = (System.String)reader["ListOfProfessorId"];
					//entity.ListOfProfessorId = (Convert.IsDBNull(reader["ListOfProfessorID"]))?string.Empty:(System.String)reader["ListOfProfessorID"];
					entity.ListOfProfessorFirstName = (System.String)reader["ListOfProfessorFirstName"];
					//entity.ListOfProfessorFirstName = (Convert.IsDBNull(reader["ListOfProfessorFirstName"]))?string.Empty:(System.String)reader["ListOfProfessorFirstName"];
					entity.MaHeSoCongViec = reader.IsDBNull(reader.GetOrdinal("MaHeSoCongViec")) ? null : (System.Int32?)reader["MaHeSoCongViec"];
					//entity.MaHeSoCongViec = (Convert.IsDBNull(reader["MaHeSoCongViec"]))?(int)0:(System.Int32?)reader["MaHeSoCongViec"];
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
		/// Refreshes the <see cref="ViewThongTinLopHocPhanHeSoCongViec"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThongTinLopHocPhanHeSoCongViec"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewThongTinLopHocPhanHeSoCongViec entity)
		{
			reader.Read();
			entity.YearStudy = (System.String)reader["YearStudy"];
			//entity.YearStudy = (Convert.IsDBNull(reader["YearStudy"]))?string.Empty:(System.String)reader["YearStudy"];
			entity.TermId = (System.String)reader["TermId"];
			//entity.TermId = (Convert.IsDBNull(reader["TermID"]))?string.Empty:(System.String)reader["TermID"];
			entity.StudyUnitId = (System.String)reader["StudyUnitId"];
			//entity.StudyUnitId = (Convert.IsDBNull(reader["StudyUnitID"]))?string.Empty:(System.String)reader["StudyUnitID"];
			entity.ScheduleStudyUnitId = (System.String)reader["ScheduleStudyUnitId"];
			//entity.ScheduleStudyUnitId = (Convert.IsDBNull(reader["ScheduleStudyUnitID"]))?string.Empty:(System.String)reader["ScheduleStudyUnitID"];
			entity.CurriculumId = (System.String)reader["CurriculumId"];
			//entity.CurriculumId = (Convert.IsDBNull(reader["CurriculumID"]))?string.Empty:(System.String)reader["CurriculumID"];
			entity.CurriculumName = (System.String)reader["CurriculumName"];
			//entity.CurriculumName = (Convert.IsDBNull(reader["CurriculumName"]))?string.Empty:(System.String)reader["CurriculumName"];
			entity.Credits = reader.IsDBNull(reader.GetOrdinal("Credits")) ? null : (System.Int32?)reader["Credits"];
			//entity.Credits = (Convert.IsDBNull(reader["Credits"]))?(int)0:(System.Int32?)reader["Credits"];
			entity.StudyUnitTypeId = (System.Byte)reader["StudyUnitTypeId"];
			//entity.StudyUnitTypeId = (Convert.IsDBNull(reader["StudyUnitTypeID"]))?(byte)0:(System.Byte)reader["StudyUnitTypeID"];
			entity.StudyUnitTypeName = (System.String)reader["StudyUnitTypeName"];
			//entity.StudyUnitTypeName = (Convert.IsDBNull(reader["StudyUnitTypeName"]))?string.Empty:(System.String)reader["StudyUnitTypeName"];
			entity.StudyUnitTypeAbbreviation = reader.IsDBNull(reader.GetOrdinal("StudyUnitTypeAbbreviation")) ? null : (System.String)reader["StudyUnitTypeAbbreviation"];
			//entity.StudyUnitTypeAbbreviation = (Convert.IsDBNull(reader["StudyUnitTypeAbbreviation"]))?string.Empty:(System.String)reader["StudyUnitTypeAbbreviation"];
			entity.ListOfClassStudentId = (System.String)reader["ListOfClassStudentId"];
			//entity.ListOfClassStudentId = (Convert.IsDBNull(reader["ListOfClassStudentID"]))?string.Empty:(System.String)reader["ListOfClassStudentID"];
			entity.ListOfProfessorId = (System.String)reader["ListOfProfessorId"];
			//entity.ListOfProfessorId = (Convert.IsDBNull(reader["ListOfProfessorID"]))?string.Empty:(System.String)reader["ListOfProfessorID"];
			entity.ListOfProfessorFirstName = (System.String)reader["ListOfProfessorFirstName"];
			//entity.ListOfProfessorFirstName = (Convert.IsDBNull(reader["ListOfProfessorFirstName"]))?string.Empty:(System.String)reader["ListOfProfessorFirstName"];
			entity.MaHeSoCongViec = reader.IsDBNull(reader.GetOrdinal("MaHeSoCongViec")) ? null : (System.Int32?)reader["MaHeSoCongViec"];
			//entity.MaHeSoCongViec = (Convert.IsDBNull(reader["MaHeSoCongViec"]))?(int)0:(System.Int32?)reader["MaHeSoCongViec"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewThongTinLopHocPhanHeSoCongViec"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThongTinLopHocPhanHeSoCongViec"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewThongTinLopHocPhanHeSoCongViec entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.YearStudy = (Convert.IsDBNull(dataRow["YearStudy"]))?string.Empty:(System.String)dataRow["YearStudy"];
			entity.TermId = (Convert.IsDBNull(dataRow["TermID"]))?string.Empty:(System.String)dataRow["TermID"];
			entity.StudyUnitId = (Convert.IsDBNull(dataRow["StudyUnitID"]))?string.Empty:(System.String)dataRow["StudyUnitID"];
			entity.ScheduleStudyUnitId = (Convert.IsDBNull(dataRow["ScheduleStudyUnitID"]))?string.Empty:(System.String)dataRow["ScheduleStudyUnitID"];
			entity.CurriculumId = (Convert.IsDBNull(dataRow["CurriculumID"]))?string.Empty:(System.String)dataRow["CurriculumID"];
			entity.CurriculumName = (Convert.IsDBNull(dataRow["CurriculumName"]))?string.Empty:(System.String)dataRow["CurriculumName"];
			entity.Credits = (Convert.IsDBNull(dataRow["Credits"]))?(int)0:(System.Int32?)dataRow["Credits"];
			entity.StudyUnitTypeId = (Convert.IsDBNull(dataRow["StudyUnitTypeID"]))?(byte)0:(System.Byte)dataRow["StudyUnitTypeID"];
			entity.StudyUnitTypeName = (Convert.IsDBNull(dataRow["StudyUnitTypeName"]))?string.Empty:(System.String)dataRow["StudyUnitTypeName"];
			entity.StudyUnitTypeAbbreviation = (Convert.IsDBNull(dataRow["StudyUnitTypeAbbreviation"]))?string.Empty:(System.String)dataRow["StudyUnitTypeAbbreviation"];
			entity.ListOfClassStudentId = (Convert.IsDBNull(dataRow["ListOfClassStudentID"]))?string.Empty:(System.String)dataRow["ListOfClassStudentID"];
			entity.ListOfProfessorId = (Convert.IsDBNull(dataRow["ListOfProfessorID"]))?string.Empty:(System.String)dataRow["ListOfProfessorID"];
			entity.ListOfProfessorFirstName = (Convert.IsDBNull(dataRow["ListOfProfessorFirstName"]))?string.Empty:(System.String)dataRow["ListOfProfessorFirstName"];
			entity.MaHeSoCongViec = (Convert.IsDBNull(dataRow["MaHeSoCongViec"]))?(int)0:(System.Int32?)dataRow["MaHeSoCongViec"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewThongTinLopHocPhanHeSoCongViecFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongTinLopHocPhanHeSoCongViec"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThongTinLopHocPhanHeSoCongViecFilterBuilder : SqlFilterBuilder<ViewThongTinLopHocPhanHeSoCongViecColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongTinLopHocPhanHeSoCongViecFilterBuilder class.
		/// </summary>
		public ViewThongTinLopHocPhanHeSoCongViecFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThongTinLopHocPhanHeSoCongViecFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThongTinLopHocPhanHeSoCongViecFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThongTinLopHocPhanHeSoCongViecFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThongTinLopHocPhanHeSoCongViecFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThongTinLopHocPhanHeSoCongViecFilterBuilder

	#region ViewThongTinLopHocPhanHeSoCongViecParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongTinLopHocPhanHeSoCongViec"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThongTinLopHocPhanHeSoCongViecParameterBuilder : ParameterizedSqlFilterBuilder<ViewThongTinLopHocPhanHeSoCongViecColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongTinLopHocPhanHeSoCongViecParameterBuilder class.
		/// </summary>
		public ViewThongTinLopHocPhanHeSoCongViecParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThongTinLopHocPhanHeSoCongViecParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThongTinLopHocPhanHeSoCongViecParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThongTinLopHocPhanHeSoCongViecParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThongTinLopHocPhanHeSoCongViecParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThongTinLopHocPhanHeSoCongViecParameterBuilder
	
	#region ViewThongTinLopHocPhanHeSoCongViecSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongTinLopHocPhanHeSoCongViec"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewThongTinLopHocPhanHeSoCongViecSortBuilder : SqlSortBuilder<ViewThongTinLopHocPhanHeSoCongViecColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongTinLopHocPhanHeSoCongViecSqlSortBuilder class.
		/// </summary>
		public ViewThongTinLopHocPhanHeSoCongViecSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewThongTinLopHocPhanHeSoCongViecSortBuilder

} // end namespace
