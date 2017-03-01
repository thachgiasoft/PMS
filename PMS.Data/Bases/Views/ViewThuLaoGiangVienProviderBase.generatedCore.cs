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
	/// This class is the base class for any <see cref="ViewThuLaoGiangVienProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewThuLaoGiangVienProviderBaseCore : EntityViewProviderBase<ViewThuLaoGiangVien>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewThuLaoGiangVien&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewThuLaoGiangVien&gt;"/></returns>
		protected static VList&lt;ViewThuLaoGiangVien&gt; Fill(DataSet dataSet, VList<ViewThuLaoGiangVien> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewThuLaoGiangVien>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewThuLaoGiangVien&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewThuLaoGiangVien>"/></returns>
		protected static VList&lt;ViewThuLaoGiangVien&gt; Fill(DataTable dataTable, VList<ViewThuLaoGiangVien> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewThuLaoGiangVien c = new ViewThuLaoGiangVien();
					c.ProfessorId = (Convert.IsDBNull(row["ProfessorID"]))?string.Empty:(System.String)row["ProfessorID"];
					c.GraduateLevelId = (Convert.IsDBNull(row["GraduateLevelID"]))?string.Empty:(System.String)row["GraduateLevelID"];
					c.StudyTypeId = (Convert.IsDBNull(row["StudyTypeID"]))?string.Empty:(System.String)row["StudyTypeID"];
					c.TeachingRoleId = (Convert.IsDBNull(row["TeachingRoleID"]))?string.Empty:(System.String)row["TeachingRoleID"];
					c.StandardPayment = (Convert.IsDBNull(row["StandardPayment"]))?0:(System.Decimal?)row["StandardPayment"];
					c.StandardCoefficientPayment = (Convert.IsDBNull(row["StandardCoefficientPayment"]))?0:(System.Decimal?)row["StandardCoefficientPayment"];
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
		/// Fill an <see cref="VList&lt;ViewThuLaoGiangVien&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewThuLaoGiangVien&gt;"/></returns>
		protected VList<ViewThuLaoGiangVien> Fill(IDataReader reader, VList<ViewThuLaoGiangVien> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewThuLaoGiangVien entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewThuLaoGiangVien>("ViewThuLaoGiangVien",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewThuLaoGiangVien();
					}
					
					entity.SuppressEntityEvents = true;

					entity.ProfessorId = (System.String)reader[((int)ViewThuLaoGiangVienColumn.ProfessorId)];
					//entity.ProfessorId = (Convert.IsDBNull(reader["ProfessorID"]))?string.Empty:(System.String)reader["ProfessorID"];
					entity.GraduateLevelId = (System.String)reader[((int)ViewThuLaoGiangVienColumn.GraduateLevelId)];
					//entity.GraduateLevelId = (Convert.IsDBNull(reader["GraduateLevelID"]))?string.Empty:(System.String)reader["GraduateLevelID"];
					entity.StudyTypeId = (System.String)reader[((int)ViewThuLaoGiangVienColumn.StudyTypeId)];
					//entity.StudyTypeId = (Convert.IsDBNull(reader["StudyTypeID"]))?string.Empty:(System.String)reader["StudyTypeID"];
					entity.TeachingRoleId = (System.String)reader[((int)ViewThuLaoGiangVienColumn.TeachingRoleId)];
					//entity.TeachingRoleId = (Convert.IsDBNull(reader["TeachingRoleID"]))?string.Empty:(System.String)reader["TeachingRoleID"];
					entity.StandardPayment = (reader.IsDBNull(((int)ViewThuLaoGiangVienColumn.StandardPayment)))?null:(System.Decimal?)reader[((int)ViewThuLaoGiangVienColumn.StandardPayment)];
					//entity.StandardPayment = (Convert.IsDBNull(reader["StandardPayment"]))?0:(System.Decimal?)reader["StandardPayment"];
					entity.StandardCoefficientPayment = (reader.IsDBNull(((int)ViewThuLaoGiangVienColumn.StandardCoefficientPayment)))?null:(System.Decimal?)reader[((int)ViewThuLaoGiangVienColumn.StandardCoefficientPayment)];
					//entity.StandardCoefficientPayment = (Convert.IsDBNull(reader["StandardCoefficientPayment"]))?0:(System.Decimal?)reader["StandardCoefficientPayment"];
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
		/// Refreshes the <see cref="ViewThuLaoGiangVien"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThuLaoGiangVien"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewThuLaoGiangVien entity)
		{
			reader.Read();
			entity.ProfessorId = (System.String)reader[((int)ViewThuLaoGiangVienColumn.ProfessorId)];
			//entity.ProfessorId = (Convert.IsDBNull(reader["ProfessorID"]))?string.Empty:(System.String)reader["ProfessorID"];
			entity.GraduateLevelId = (System.String)reader[((int)ViewThuLaoGiangVienColumn.GraduateLevelId)];
			//entity.GraduateLevelId = (Convert.IsDBNull(reader["GraduateLevelID"]))?string.Empty:(System.String)reader["GraduateLevelID"];
			entity.StudyTypeId = (System.String)reader[((int)ViewThuLaoGiangVienColumn.StudyTypeId)];
			//entity.StudyTypeId = (Convert.IsDBNull(reader["StudyTypeID"]))?string.Empty:(System.String)reader["StudyTypeID"];
			entity.TeachingRoleId = (System.String)reader[((int)ViewThuLaoGiangVienColumn.TeachingRoleId)];
			//entity.TeachingRoleId = (Convert.IsDBNull(reader["TeachingRoleID"]))?string.Empty:(System.String)reader["TeachingRoleID"];
			entity.StandardPayment = (reader.IsDBNull(((int)ViewThuLaoGiangVienColumn.StandardPayment)))?null:(System.Decimal?)reader[((int)ViewThuLaoGiangVienColumn.StandardPayment)];
			//entity.StandardPayment = (Convert.IsDBNull(reader["StandardPayment"]))?0:(System.Decimal?)reader["StandardPayment"];
			entity.StandardCoefficientPayment = (reader.IsDBNull(((int)ViewThuLaoGiangVienColumn.StandardCoefficientPayment)))?null:(System.Decimal?)reader[((int)ViewThuLaoGiangVienColumn.StandardCoefficientPayment)];
			//entity.StandardCoefficientPayment = (Convert.IsDBNull(reader["StandardCoefficientPayment"]))?0:(System.Decimal?)reader["StandardCoefficientPayment"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewThuLaoGiangVien"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThuLaoGiangVien"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewThuLaoGiangVien entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ProfessorId = (Convert.IsDBNull(dataRow["ProfessorID"]))?string.Empty:(System.String)dataRow["ProfessorID"];
			entity.GraduateLevelId = (Convert.IsDBNull(dataRow["GraduateLevelID"]))?string.Empty:(System.String)dataRow["GraduateLevelID"];
			entity.StudyTypeId = (Convert.IsDBNull(dataRow["StudyTypeID"]))?string.Empty:(System.String)dataRow["StudyTypeID"];
			entity.TeachingRoleId = (Convert.IsDBNull(dataRow["TeachingRoleID"]))?string.Empty:(System.String)dataRow["TeachingRoleID"];
			entity.StandardPayment = (Convert.IsDBNull(dataRow["StandardPayment"]))?0:(System.Decimal?)dataRow["StandardPayment"];
			entity.StandardCoefficientPayment = (Convert.IsDBNull(dataRow["StandardCoefficientPayment"]))?0:(System.Decimal?)dataRow["StandardCoefficientPayment"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewThuLaoGiangVienFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThuLaoGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThuLaoGiangVienFilterBuilder : SqlFilterBuilder<ViewThuLaoGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThuLaoGiangVienFilterBuilder class.
		/// </summary>
		public ViewThuLaoGiangVienFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThuLaoGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThuLaoGiangVienFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThuLaoGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThuLaoGiangVienFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThuLaoGiangVienFilterBuilder

	#region ViewThuLaoGiangVienParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThuLaoGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThuLaoGiangVienParameterBuilder : ParameterizedSqlFilterBuilder<ViewThuLaoGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThuLaoGiangVienParameterBuilder class.
		/// </summary>
		public ViewThuLaoGiangVienParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThuLaoGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThuLaoGiangVienParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThuLaoGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThuLaoGiangVienParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThuLaoGiangVienParameterBuilder
	
	#region ViewThuLaoGiangVienSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThuLaoGiangVien"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewThuLaoGiangVienSortBuilder : SqlSortBuilder<ViewThuLaoGiangVienColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThuLaoGiangVienSqlSortBuilder class.
		/// </summary>
		public ViewThuLaoGiangVienSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewThuLaoGiangVienSortBuilder

} // end namespace
