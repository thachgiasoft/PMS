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
	/// This class is the base class for any <see cref="ViewLopHocPhanGiangBangTiengNuocNgoaiBuhProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewLopHocPhanGiangBangTiengNuocNgoaiBuhProviderBaseCore : EntityViewProviderBase<ViewLopHocPhanGiangBangTiengNuocNgoaiBuh>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewLopHocPhanGiangBangTiengNuocNgoaiBuh&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewLopHocPhanGiangBangTiengNuocNgoaiBuh&gt;"/></returns>
		protected static VList&lt;ViewLopHocPhanGiangBangTiengNuocNgoaiBuh&gt; Fill(DataSet dataSet, VList<ViewLopHocPhanGiangBangTiengNuocNgoaiBuh> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewLopHocPhanGiangBangTiengNuocNgoaiBuh>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewLopHocPhanGiangBangTiengNuocNgoaiBuh&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewLopHocPhanGiangBangTiengNuocNgoaiBuh>"/></returns>
		protected static VList&lt;ViewLopHocPhanGiangBangTiengNuocNgoaiBuh&gt; Fill(DataTable dataTable, VList<ViewLopHocPhanGiangBangTiengNuocNgoaiBuh> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewLopHocPhanGiangBangTiengNuocNgoaiBuh c = new ViewLopHocPhanGiangBangTiengNuocNgoaiBuh();
					c.ScheduleStudyUnitId = (Convert.IsDBNull(row["ScheduleStudyUnitID"]))?string.Empty:(System.String)row["ScheduleStudyUnitID"];
					c.StudyUnitId = (Convert.IsDBNull(row["StudyUnitID"]))?string.Empty:(System.String)row["StudyUnitID"];
					c.CurriculumId = (Convert.IsDBNull(row["CurriculumID"]))?string.Empty:(System.String)row["CurriculumID"];
					c.CurriculumName = (Convert.IsDBNull(row["CurriculumName"]))?string.Empty:(System.String)row["CurriculumName"];
					c.ListOfClassStudentId = (Convert.IsDBNull(row["ListOfClassStudentID"]))?string.Empty:(System.String)row["ListOfClassStudentID"];
					c.ListOfProfessorId = (Convert.IsDBNull(row["ListOfProfessorID"]))?string.Empty:(System.String)row["ListOfProfessorID"];
					c.ListOfProfessorFirstName = (Convert.IsDBNull(row["ListOfProfessorFirstName"]))?string.Empty:(System.String)row["ListOfProfessorFirstName"];
					c.YearStudy = (Convert.IsDBNull(row["YearStudy"]))?string.Empty:(System.String)row["YearStudy"];
					c.TermId = (Convert.IsDBNull(row["TermID"]))?string.Empty:(System.String)row["TermID"];
					c.NgonNgu = (Convert.IsDBNull(row["NgonNgu"]))?string.Empty:(System.String)row["NgonNgu"];
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
		/// Fill an <see cref="VList&lt;ViewLopHocPhanGiangBangTiengNuocNgoaiBuh&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewLopHocPhanGiangBangTiengNuocNgoaiBuh&gt;"/></returns>
		protected VList<ViewLopHocPhanGiangBangTiengNuocNgoaiBuh> Fill(IDataReader reader, VList<ViewLopHocPhanGiangBangTiengNuocNgoaiBuh> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewLopHocPhanGiangBangTiengNuocNgoaiBuh entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewLopHocPhanGiangBangTiengNuocNgoaiBuh>("ViewLopHocPhanGiangBangTiengNuocNgoaiBuh",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewLopHocPhanGiangBangTiengNuocNgoaiBuh();
					}
					
					entity.SuppressEntityEvents = true;

					entity.ScheduleStudyUnitId = (System.String)reader["ScheduleStudyUnitId"];
					//entity.ScheduleStudyUnitId = (Convert.IsDBNull(reader["ScheduleStudyUnitID"]))?string.Empty:(System.String)reader["ScheduleStudyUnitID"];
					entity.StudyUnitId = (System.String)reader["StudyUnitId"];
					//entity.StudyUnitId = (Convert.IsDBNull(reader["StudyUnitID"]))?string.Empty:(System.String)reader["StudyUnitID"];
					entity.CurriculumId = (System.String)reader["CurriculumId"];
					//entity.CurriculumId = (Convert.IsDBNull(reader["CurriculumID"]))?string.Empty:(System.String)reader["CurriculumID"];
					entity.CurriculumName = (System.String)reader["CurriculumName"];
					//entity.CurriculumName = (Convert.IsDBNull(reader["CurriculumName"]))?string.Empty:(System.String)reader["CurriculumName"];
					entity.ListOfClassStudentId = (System.String)reader["ListOfClassStudentId"];
					//entity.ListOfClassStudentId = (Convert.IsDBNull(reader["ListOfClassStudentID"]))?string.Empty:(System.String)reader["ListOfClassStudentID"];
					entity.ListOfProfessorId = (System.String)reader["ListOfProfessorId"];
					//entity.ListOfProfessorId = (Convert.IsDBNull(reader["ListOfProfessorID"]))?string.Empty:(System.String)reader["ListOfProfessorID"];
					entity.ListOfProfessorFirstName = (System.String)reader["ListOfProfessorFirstName"];
					//entity.ListOfProfessorFirstName = (Convert.IsDBNull(reader["ListOfProfessorFirstName"]))?string.Empty:(System.String)reader["ListOfProfessorFirstName"];
					entity.YearStudy = (System.String)reader["YearStudy"];
					//entity.YearStudy = (Convert.IsDBNull(reader["YearStudy"]))?string.Empty:(System.String)reader["YearStudy"];
					entity.TermId = (System.String)reader["TermId"];
					//entity.TermId = (Convert.IsDBNull(reader["TermID"]))?string.Empty:(System.String)reader["TermID"];
					entity.NgonNgu = reader.IsDBNull(reader.GetOrdinal("NgonNgu")) ? null : (System.String)reader["NgonNgu"];
					//entity.NgonNgu = (Convert.IsDBNull(reader["NgonNgu"]))?string.Empty:(System.String)reader["NgonNgu"];
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
		/// Refreshes the <see cref="ViewLopHocPhanGiangBangTiengNuocNgoaiBuh"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewLopHocPhanGiangBangTiengNuocNgoaiBuh"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewLopHocPhanGiangBangTiengNuocNgoaiBuh entity)
		{
			reader.Read();
			entity.ScheduleStudyUnitId = (System.String)reader["ScheduleStudyUnitId"];
			//entity.ScheduleStudyUnitId = (Convert.IsDBNull(reader["ScheduleStudyUnitID"]))?string.Empty:(System.String)reader["ScheduleStudyUnitID"];
			entity.StudyUnitId = (System.String)reader["StudyUnitId"];
			//entity.StudyUnitId = (Convert.IsDBNull(reader["StudyUnitID"]))?string.Empty:(System.String)reader["StudyUnitID"];
			entity.CurriculumId = (System.String)reader["CurriculumId"];
			//entity.CurriculumId = (Convert.IsDBNull(reader["CurriculumID"]))?string.Empty:(System.String)reader["CurriculumID"];
			entity.CurriculumName = (System.String)reader["CurriculumName"];
			//entity.CurriculumName = (Convert.IsDBNull(reader["CurriculumName"]))?string.Empty:(System.String)reader["CurriculumName"];
			entity.ListOfClassStudentId = (System.String)reader["ListOfClassStudentId"];
			//entity.ListOfClassStudentId = (Convert.IsDBNull(reader["ListOfClassStudentID"]))?string.Empty:(System.String)reader["ListOfClassStudentID"];
			entity.ListOfProfessorId = (System.String)reader["ListOfProfessorId"];
			//entity.ListOfProfessorId = (Convert.IsDBNull(reader["ListOfProfessorID"]))?string.Empty:(System.String)reader["ListOfProfessorID"];
			entity.ListOfProfessorFirstName = (System.String)reader["ListOfProfessorFirstName"];
			//entity.ListOfProfessorFirstName = (Convert.IsDBNull(reader["ListOfProfessorFirstName"]))?string.Empty:(System.String)reader["ListOfProfessorFirstName"];
			entity.YearStudy = (System.String)reader["YearStudy"];
			//entity.YearStudy = (Convert.IsDBNull(reader["YearStudy"]))?string.Empty:(System.String)reader["YearStudy"];
			entity.TermId = (System.String)reader["TermId"];
			//entity.TermId = (Convert.IsDBNull(reader["TermID"]))?string.Empty:(System.String)reader["TermID"];
			entity.NgonNgu = reader.IsDBNull(reader.GetOrdinal("NgonNgu")) ? null : (System.String)reader["NgonNgu"];
			//entity.NgonNgu = (Convert.IsDBNull(reader["NgonNgu"]))?string.Empty:(System.String)reader["NgonNgu"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewLopHocPhanGiangBangTiengNuocNgoaiBuh"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewLopHocPhanGiangBangTiengNuocNgoaiBuh"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewLopHocPhanGiangBangTiengNuocNgoaiBuh entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ScheduleStudyUnitId = (Convert.IsDBNull(dataRow["ScheduleStudyUnitID"]))?string.Empty:(System.String)dataRow["ScheduleStudyUnitID"];
			entity.StudyUnitId = (Convert.IsDBNull(dataRow["StudyUnitID"]))?string.Empty:(System.String)dataRow["StudyUnitID"];
			entity.CurriculumId = (Convert.IsDBNull(dataRow["CurriculumID"]))?string.Empty:(System.String)dataRow["CurriculumID"];
			entity.CurriculumName = (Convert.IsDBNull(dataRow["CurriculumName"]))?string.Empty:(System.String)dataRow["CurriculumName"];
			entity.ListOfClassStudentId = (Convert.IsDBNull(dataRow["ListOfClassStudentID"]))?string.Empty:(System.String)dataRow["ListOfClassStudentID"];
			entity.ListOfProfessorId = (Convert.IsDBNull(dataRow["ListOfProfessorID"]))?string.Empty:(System.String)dataRow["ListOfProfessorID"];
			entity.ListOfProfessorFirstName = (Convert.IsDBNull(dataRow["ListOfProfessorFirstName"]))?string.Empty:(System.String)dataRow["ListOfProfessorFirstName"];
			entity.YearStudy = (Convert.IsDBNull(dataRow["YearStudy"]))?string.Empty:(System.String)dataRow["YearStudy"];
			entity.TermId = (Convert.IsDBNull(dataRow["TermID"]))?string.Empty:(System.String)dataRow["TermID"];
			entity.NgonNgu = (Convert.IsDBNull(dataRow["NgonNgu"]))?string.Empty:(System.String)dataRow["NgonNgu"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewLopHocPhanGiangBangTiengNuocNgoaiBuhFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLopHocPhanGiangBangTiengNuocNgoaiBuh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLopHocPhanGiangBangTiengNuocNgoaiBuhFilterBuilder : SqlFilterBuilder<ViewLopHocPhanGiangBangTiengNuocNgoaiBuhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLopHocPhanGiangBangTiengNuocNgoaiBuhFilterBuilder class.
		/// </summary>
		public ViewLopHocPhanGiangBangTiengNuocNgoaiBuhFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewLopHocPhanGiangBangTiengNuocNgoaiBuhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewLopHocPhanGiangBangTiengNuocNgoaiBuhFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewLopHocPhanGiangBangTiengNuocNgoaiBuhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewLopHocPhanGiangBangTiengNuocNgoaiBuhFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewLopHocPhanGiangBangTiengNuocNgoaiBuhFilterBuilder

	#region ViewLopHocPhanGiangBangTiengNuocNgoaiBuhParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLopHocPhanGiangBangTiengNuocNgoaiBuh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLopHocPhanGiangBangTiengNuocNgoaiBuhParameterBuilder : ParameterizedSqlFilterBuilder<ViewLopHocPhanGiangBangTiengNuocNgoaiBuhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLopHocPhanGiangBangTiengNuocNgoaiBuhParameterBuilder class.
		/// </summary>
		public ViewLopHocPhanGiangBangTiengNuocNgoaiBuhParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewLopHocPhanGiangBangTiengNuocNgoaiBuhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewLopHocPhanGiangBangTiengNuocNgoaiBuhParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewLopHocPhanGiangBangTiengNuocNgoaiBuhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewLopHocPhanGiangBangTiengNuocNgoaiBuhParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewLopHocPhanGiangBangTiengNuocNgoaiBuhParameterBuilder
	
	#region ViewLopHocPhanGiangBangTiengNuocNgoaiBuhSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLopHocPhanGiangBangTiengNuocNgoaiBuh"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewLopHocPhanGiangBangTiengNuocNgoaiBuhSortBuilder : SqlSortBuilder<ViewLopHocPhanGiangBangTiengNuocNgoaiBuhColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLopHocPhanGiangBangTiengNuocNgoaiBuhSqlSortBuilder class.
		/// </summary>
		public ViewLopHocPhanGiangBangTiengNuocNgoaiBuhSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewLopHocPhanGiangBangTiengNuocNgoaiBuhSortBuilder

} // end namespace
