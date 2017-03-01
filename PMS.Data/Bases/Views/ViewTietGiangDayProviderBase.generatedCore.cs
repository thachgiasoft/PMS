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
	/// This class is the base class for any <see cref="ViewTietGiangDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewTietGiangDayProviderBaseCore : EntityViewProviderBase<ViewTietGiangDay>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewTietGiangDay&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewTietGiangDay&gt;"/></returns>
		protected static VList&lt;ViewTietGiangDay&gt; Fill(DataSet dataSet, VList<ViewTietGiangDay> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewTietGiangDay>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewTietGiangDay&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewTietGiangDay>"/></returns>
		protected static VList&lt;ViewTietGiangDay&gt; Fill(DataTable dataTable, VList<ViewTietGiangDay> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewTietGiangDay c = new ViewTietGiangDay();
					c.PeriodId = (Convert.IsDBNull(row["PeriodId"]))?(int)0:(System.Int32)row["PeriodId"];
					c.PeriodName = (Convert.IsDBNull(row["PeriodName"]))?string.Empty:(System.String)row["PeriodName"];
					c.BeginTime = (Convert.IsDBNull(row["BeginTime"]))?string.Empty:(System.String)row["BeginTime"];
					c.EndTime = (Convert.IsDBNull(row["EndTime"]))?string.Empty:(System.String)row["EndTime"];
					c.ShiftId = (Convert.IsDBNull(row["ShiftId"]))?string.Empty:(System.String)row["ShiftId"];
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
		/// Fill an <see cref="VList&lt;ViewTietGiangDay&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewTietGiangDay&gt;"/></returns>
		protected VList<ViewTietGiangDay> Fill(IDataReader reader, VList<ViewTietGiangDay> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewTietGiangDay entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewTietGiangDay>("ViewTietGiangDay",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewTietGiangDay();
					}
					
					entity.SuppressEntityEvents = true;

					entity.PeriodId = (System.Int32)reader["PeriodId"];
					//entity.PeriodId = (Convert.IsDBNull(reader["PeriodId"]))?(int)0:(System.Int32)reader["PeriodId"];
					entity.PeriodName = (System.String)reader["PeriodName"];
					//entity.PeriodName = (Convert.IsDBNull(reader["PeriodName"]))?string.Empty:(System.String)reader["PeriodName"];
					entity.BeginTime = (System.String)reader["BeginTime"];
					//entity.BeginTime = (Convert.IsDBNull(reader["BeginTime"]))?string.Empty:(System.String)reader["BeginTime"];
					entity.EndTime = (System.String)reader["EndTime"];
					//entity.EndTime = (Convert.IsDBNull(reader["EndTime"]))?string.Empty:(System.String)reader["EndTime"];
					entity.ShiftId = reader.IsDBNull(reader.GetOrdinal("ShiftId")) ? null : (System.String)reader["ShiftId"];
					//entity.ShiftId = (Convert.IsDBNull(reader["ShiftId"]))?string.Empty:(System.String)reader["ShiftId"];
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
		/// Refreshes the <see cref="ViewTietGiangDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewTietGiangDay"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewTietGiangDay entity)
		{
			reader.Read();
			entity.PeriodId = (System.Int32)reader["PeriodId"];
			//entity.PeriodId = (Convert.IsDBNull(reader["PeriodId"]))?(int)0:(System.Int32)reader["PeriodId"];
			entity.PeriodName = (System.String)reader["PeriodName"];
			//entity.PeriodName = (Convert.IsDBNull(reader["PeriodName"]))?string.Empty:(System.String)reader["PeriodName"];
			entity.BeginTime = (System.String)reader["BeginTime"];
			//entity.BeginTime = (Convert.IsDBNull(reader["BeginTime"]))?string.Empty:(System.String)reader["BeginTime"];
			entity.EndTime = (System.String)reader["EndTime"];
			//entity.EndTime = (Convert.IsDBNull(reader["EndTime"]))?string.Empty:(System.String)reader["EndTime"];
			entity.ShiftId = reader.IsDBNull(reader.GetOrdinal("ShiftId")) ? null : (System.String)reader["ShiftId"];
			//entity.ShiftId = (Convert.IsDBNull(reader["ShiftId"]))?string.Empty:(System.String)reader["ShiftId"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewTietGiangDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewTietGiangDay"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewTietGiangDay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PeriodId = (Convert.IsDBNull(dataRow["PeriodId"]))?(int)0:(System.Int32)dataRow["PeriodId"];
			entity.PeriodName = (Convert.IsDBNull(dataRow["PeriodName"]))?string.Empty:(System.String)dataRow["PeriodName"];
			entity.BeginTime = (Convert.IsDBNull(dataRow["BeginTime"]))?string.Empty:(System.String)dataRow["BeginTime"];
			entity.EndTime = (Convert.IsDBNull(dataRow["EndTime"]))?string.Empty:(System.String)dataRow["EndTime"];
			entity.ShiftId = (Convert.IsDBNull(dataRow["ShiftId"]))?string.Empty:(System.String)dataRow["ShiftId"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewTietGiangDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTietGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTietGiangDayFilterBuilder : SqlFilterBuilder<ViewTietGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTietGiangDayFilterBuilder class.
		/// </summary>
		public ViewTietGiangDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewTietGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewTietGiangDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewTietGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewTietGiangDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewTietGiangDayFilterBuilder

	#region ViewTietGiangDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTietGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTietGiangDayParameterBuilder : ParameterizedSqlFilterBuilder<ViewTietGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTietGiangDayParameterBuilder class.
		/// </summary>
		public ViewTietGiangDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewTietGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewTietGiangDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewTietGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewTietGiangDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewTietGiangDayParameterBuilder
	
	#region ViewTietGiangDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTietGiangDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewTietGiangDaySortBuilder : SqlSortBuilder<ViewTietGiangDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTietGiangDaySqlSortBuilder class.
		/// </summary>
		public ViewTietGiangDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewTietGiangDaySortBuilder

} // end namespace
