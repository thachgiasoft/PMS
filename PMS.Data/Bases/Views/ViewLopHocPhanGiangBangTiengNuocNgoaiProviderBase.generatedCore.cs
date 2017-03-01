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
	/// This class is the base class for any <see cref="ViewLopHocPhanGiangBangTiengNuocNgoaiProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewLopHocPhanGiangBangTiengNuocNgoaiProviderBaseCore : EntityViewProviderBase<ViewLopHocPhanGiangBangTiengNuocNgoai>
	{
		#region Custom Methods
		
		
		#region cust_View_LopHocPhanGiangBangTiengNuocNgoai_GetByNamHocHocKyMaDonVi
		
		/// <summary>
		///	This method wrap the 'cust_View_LopHocPhanGiangBangTiengNuocNgoai_GetByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewLopHocPhanGiangBangTiengNuocNgoai&gt;"/> instance.</returns>
		public VList<ViewLopHocPhanGiangBangTiengNuocNgoai> GetByNamHocHocKyMaDonVi(System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetByNamHocHocKyMaDonVi(null, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_LopHocPhanGiangBangTiengNuocNgoai_GetByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewLopHocPhanGiangBangTiengNuocNgoai&gt;"/> instance.</returns>
		public VList<ViewLopHocPhanGiangBangTiengNuocNgoai> GetByNamHocHocKyMaDonVi(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetByNamHocHocKyMaDonVi(null, start, pageLength , namHoc, hocKy, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_LopHocPhanGiangBangTiengNuocNgoai_GetByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewLopHocPhanGiangBangTiengNuocNgoai&gt;"/> instance.</returns>
		public VList<ViewLopHocPhanGiangBangTiengNuocNgoai> GetByNamHocHocKyMaDonVi(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetByNamHocHocKyMaDonVi(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_LopHocPhanGiangBangTiengNuocNgoai_GetByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewLopHocPhanGiangBangTiengNuocNgoai&gt;"/> instance.</returns>
		public abstract VList<ViewLopHocPhanGiangBangTiengNuocNgoai> GetByNamHocHocKyMaDonVi(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi);
		
		#endregion

		
		#region cust_View_LopHocPhanGiangBangTiengNuocNgoai_GetByNamHocHocKy_BUH
		
		/// <summary>
		///	This method wrap the 'cust_View_LopHocPhanGiangBangTiengNuocNgoai_GetByNamHocHocKy_BUH' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKy_BUH(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy_BUH(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_LopHocPhanGiangBangTiengNuocNgoai_GetByNamHocHocKy_BUH' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKy_BUH(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy_BUH(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_LopHocPhanGiangBangTiengNuocNgoai_GetByNamHocHocKy_BUH' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKy_BUH(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy_BUH(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_LopHocPhanGiangBangTiengNuocNgoai_GetByNamHocHocKy_BUH' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKy_BUH(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#region cust_View_LopHocPhanGiangBangTiengNuocNgoai_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_LopHocPhanGiangBangTiengNuocNgoai_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewLopHocPhanGiangBangTiengNuocNgoai&gt;"/> instance.</returns>
		public VList<ViewLopHocPhanGiangBangTiengNuocNgoai> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_LopHocPhanGiangBangTiengNuocNgoai_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewLopHocPhanGiangBangTiengNuocNgoai&gt;"/> instance.</returns>
		public VList<ViewLopHocPhanGiangBangTiengNuocNgoai> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_LopHocPhanGiangBangTiengNuocNgoai_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewLopHocPhanGiangBangTiengNuocNgoai&gt;"/> instance.</returns>
		public VList<ViewLopHocPhanGiangBangTiengNuocNgoai> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_LopHocPhanGiangBangTiengNuocNgoai_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewLopHocPhanGiangBangTiengNuocNgoai&gt;"/> instance.</returns>
		public abstract VList<ViewLopHocPhanGiangBangTiengNuocNgoai> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewLopHocPhanGiangBangTiengNuocNgoai&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewLopHocPhanGiangBangTiengNuocNgoai&gt;"/></returns>
		protected static VList&lt;ViewLopHocPhanGiangBangTiengNuocNgoai&gt; Fill(DataSet dataSet, VList<ViewLopHocPhanGiangBangTiengNuocNgoai> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewLopHocPhanGiangBangTiengNuocNgoai>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewLopHocPhanGiangBangTiengNuocNgoai&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewLopHocPhanGiangBangTiengNuocNgoai>"/></returns>
		protected static VList&lt;ViewLopHocPhanGiangBangTiengNuocNgoai&gt; Fill(DataTable dataTable, VList<ViewLopHocPhanGiangBangTiengNuocNgoai> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewLopHocPhanGiangBangTiengNuocNgoai c = new ViewLopHocPhanGiangBangTiengNuocNgoai();
					c.ScheduleStudyUnitId = (Convert.IsDBNull(row["ScheduleStudyUnitID"]))?string.Empty:(System.String)row["ScheduleStudyUnitID"];
					c.StudyUnitId = (Convert.IsDBNull(row["StudyUnitID"]))?string.Empty:(System.String)row["StudyUnitID"];
					c.CurriculumId = (Convert.IsDBNull(row["CurriculumID"]))?string.Empty:(System.String)row["CurriculumID"];
					c.CurriculumName = (Convert.IsDBNull(row["CurriculumName"]))?string.Empty:(System.String)row["CurriculumName"];
					c.ListOfClassStudentId = (Convert.IsDBNull(row["ListOfClassStudentID"]))?string.Empty:(System.String)row["ListOfClassStudentID"];
					c.ListOfProfessorId = (Convert.IsDBNull(row["ListOfProfessorID"]))?string.Empty:(System.String)row["ListOfProfessorID"];
					c.ListOfProfessorFirstName = (Convert.IsDBNull(row["ListOfProfessorFirstName"]))?string.Empty:(System.String)row["ListOfProfessorFirstName"];
					c.YearStudy = (Convert.IsDBNull(row["YearStudy"]))?string.Empty:(System.String)row["YearStudy"];
					c.TermId = (Convert.IsDBNull(row["TermID"]))?string.Empty:(System.String)row["TermID"];
					c.Chon = (Convert.IsDBNull(row["Chon"]))?false:(System.Boolean?)row["Chon"];
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
		/// Fill an <see cref="VList&lt;ViewLopHocPhanGiangBangTiengNuocNgoai&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewLopHocPhanGiangBangTiengNuocNgoai&gt;"/></returns>
		protected VList<ViewLopHocPhanGiangBangTiengNuocNgoai> Fill(IDataReader reader, VList<ViewLopHocPhanGiangBangTiengNuocNgoai> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewLopHocPhanGiangBangTiengNuocNgoai entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewLopHocPhanGiangBangTiengNuocNgoai>("ViewLopHocPhanGiangBangTiengNuocNgoai",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewLopHocPhanGiangBangTiengNuocNgoai();
					}
					
					entity.SuppressEntityEvents = true;

					entity.ScheduleStudyUnitId = (System.String)reader["ScheduleStudyUnitId"];
					//entity.ScheduleStudyUnitId = (Convert.IsDBNull(reader["ScheduleStudyUnitID"]))?string.Empty:(System.String)reader["ScheduleStudyUnitID"];
					entity.StudyUnitId = reader.IsDBNull(reader.GetOrdinal("StudyUnitId")) ? null : (System.String)reader["StudyUnitId"];
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
					entity.Chon = reader.IsDBNull(reader.GetOrdinal("Chon")) ? null : (System.Boolean?)reader["Chon"];
					//entity.Chon = (Convert.IsDBNull(reader["Chon"]))?false:(System.Boolean?)reader["Chon"];
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
		/// Refreshes the <see cref="ViewLopHocPhanGiangBangTiengNuocNgoai"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewLopHocPhanGiangBangTiengNuocNgoai"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewLopHocPhanGiangBangTiengNuocNgoai entity)
		{
			reader.Read();
			entity.ScheduleStudyUnitId = (System.String)reader["ScheduleStudyUnitId"];
			//entity.ScheduleStudyUnitId = (Convert.IsDBNull(reader["ScheduleStudyUnitID"]))?string.Empty:(System.String)reader["ScheduleStudyUnitID"];
			entity.StudyUnitId = reader.IsDBNull(reader.GetOrdinal("StudyUnitId")) ? null : (System.String)reader["StudyUnitId"];
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
			entity.Chon = reader.IsDBNull(reader.GetOrdinal("Chon")) ? null : (System.Boolean?)reader["Chon"];
			//entity.Chon = (Convert.IsDBNull(reader["Chon"]))?false:(System.Boolean?)reader["Chon"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewLopHocPhanGiangBangTiengNuocNgoai"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewLopHocPhanGiangBangTiengNuocNgoai"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewLopHocPhanGiangBangTiengNuocNgoai entity)
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
			entity.Chon = (Convert.IsDBNull(dataRow["Chon"]))?false:(System.Boolean?)dataRow["Chon"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewLopHocPhanGiangBangTiengNuocNgoaiFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLopHocPhanGiangBangTiengNuocNgoai"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLopHocPhanGiangBangTiengNuocNgoaiFilterBuilder : SqlFilterBuilder<ViewLopHocPhanGiangBangTiengNuocNgoaiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLopHocPhanGiangBangTiengNuocNgoaiFilterBuilder class.
		/// </summary>
		public ViewLopHocPhanGiangBangTiengNuocNgoaiFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewLopHocPhanGiangBangTiengNuocNgoaiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewLopHocPhanGiangBangTiengNuocNgoaiFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewLopHocPhanGiangBangTiengNuocNgoaiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewLopHocPhanGiangBangTiengNuocNgoaiFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewLopHocPhanGiangBangTiengNuocNgoaiFilterBuilder

	#region ViewLopHocPhanGiangBangTiengNuocNgoaiParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLopHocPhanGiangBangTiengNuocNgoai"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLopHocPhanGiangBangTiengNuocNgoaiParameterBuilder : ParameterizedSqlFilterBuilder<ViewLopHocPhanGiangBangTiengNuocNgoaiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLopHocPhanGiangBangTiengNuocNgoaiParameterBuilder class.
		/// </summary>
		public ViewLopHocPhanGiangBangTiengNuocNgoaiParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewLopHocPhanGiangBangTiengNuocNgoaiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewLopHocPhanGiangBangTiengNuocNgoaiParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewLopHocPhanGiangBangTiengNuocNgoaiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewLopHocPhanGiangBangTiengNuocNgoaiParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewLopHocPhanGiangBangTiengNuocNgoaiParameterBuilder
	
	#region ViewLopHocPhanGiangBangTiengNuocNgoaiSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLopHocPhanGiangBangTiengNuocNgoai"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewLopHocPhanGiangBangTiengNuocNgoaiSortBuilder : SqlSortBuilder<ViewLopHocPhanGiangBangTiengNuocNgoaiColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLopHocPhanGiangBangTiengNuocNgoaiSqlSortBuilder class.
		/// </summary>
		public ViewLopHocPhanGiangBangTiengNuocNgoaiSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewLopHocPhanGiangBangTiengNuocNgoaiSortBuilder

} // end namespace
