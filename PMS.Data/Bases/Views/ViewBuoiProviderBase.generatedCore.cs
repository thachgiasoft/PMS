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
	/// This class is the base class for any <see cref="ViewBuoiProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewBuoiProviderBaseCore : EntityViewProviderBase<ViewBuoi>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewBuoi&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewBuoi&gt;"/></returns>
		protected static VList&lt;ViewBuoi&gt; Fill(DataSet dataSet, VList<ViewBuoi> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewBuoi>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewBuoi&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewBuoi>"/></returns>
		protected static VList&lt;ViewBuoi&gt; Fill(DataTable dataTable, VList<ViewBuoi> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewBuoi c = new ViewBuoi();
					c.ShiftId = (Convert.IsDBNull(row["ShiftId"]))?string.Empty:(System.String)row["ShiftId"];
					c.ShiftName = (Convert.IsDBNull(row["ShiftName"]))?string.Empty:(System.String)row["ShiftName"];
					c.Coefficient = (Convert.IsDBNull(row["Coefficient"]))?0.0m:(System.Decimal?)row["Coefficient"];
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
		/// Fill an <see cref="VList&lt;ViewBuoi&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewBuoi&gt;"/></returns>
		protected VList<ViewBuoi> Fill(IDataReader reader, VList<ViewBuoi> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewBuoi entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewBuoi>("ViewBuoi",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewBuoi();
					}
					
					entity.SuppressEntityEvents = true;

					entity.ShiftId = (System.String)reader["ShiftId"];
					//entity.ShiftId = (Convert.IsDBNull(reader["ShiftId"]))?string.Empty:(System.String)reader["ShiftId"];
					entity.ShiftName = reader.IsDBNull(reader.GetOrdinal("ShiftName")) ? null : (System.String)reader["ShiftName"];
					//entity.ShiftName = (Convert.IsDBNull(reader["ShiftName"]))?string.Empty:(System.String)reader["ShiftName"];
					entity.Coefficient = reader.IsDBNull(reader.GetOrdinal("Coefficient")) ? null : (System.Decimal?)reader["Coefficient"];
					//entity.Coefficient = (Convert.IsDBNull(reader["Coefficient"]))?0.0m:(System.Decimal?)reader["Coefficient"];
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
		/// Refreshes the <see cref="ViewBuoi"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewBuoi"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewBuoi entity)
		{
			reader.Read();
			entity.ShiftId = (System.String)reader["ShiftId"];
			//entity.ShiftId = (Convert.IsDBNull(reader["ShiftId"]))?string.Empty:(System.String)reader["ShiftId"];
			entity.ShiftName = reader.IsDBNull(reader.GetOrdinal("ShiftName")) ? null : (System.String)reader["ShiftName"];
			//entity.ShiftName = (Convert.IsDBNull(reader["ShiftName"]))?string.Empty:(System.String)reader["ShiftName"];
			entity.Coefficient = reader.IsDBNull(reader.GetOrdinal("Coefficient")) ? null : (System.Decimal?)reader["Coefficient"];
			//entity.Coefficient = (Convert.IsDBNull(reader["Coefficient"]))?0.0m:(System.Decimal?)reader["Coefficient"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewBuoi"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewBuoi"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewBuoi entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ShiftId = (Convert.IsDBNull(dataRow["ShiftId"]))?string.Empty:(System.String)dataRow["ShiftId"];
			entity.ShiftName = (Convert.IsDBNull(dataRow["ShiftName"]))?string.Empty:(System.String)dataRow["ShiftName"];
			entity.Coefficient = (Convert.IsDBNull(dataRow["Coefficient"]))?0.0m:(System.Decimal?)dataRow["Coefficient"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewBuoiFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewBuoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewBuoiFilterBuilder : SqlFilterBuilder<ViewBuoiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewBuoiFilterBuilder class.
		/// </summary>
		public ViewBuoiFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewBuoiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewBuoiFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewBuoiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewBuoiFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewBuoiFilterBuilder

	#region ViewBuoiParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewBuoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewBuoiParameterBuilder : ParameterizedSqlFilterBuilder<ViewBuoiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewBuoiParameterBuilder class.
		/// </summary>
		public ViewBuoiParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewBuoiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewBuoiParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewBuoiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewBuoiParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewBuoiParameterBuilder
	
	#region ViewBuoiSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewBuoi"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewBuoiSortBuilder : SqlSortBuilder<ViewBuoiColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewBuoiSqlSortBuilder class.
		/// </summary>
		public ViewBuoiSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewBuoiSortBuilder

} // end namespace
