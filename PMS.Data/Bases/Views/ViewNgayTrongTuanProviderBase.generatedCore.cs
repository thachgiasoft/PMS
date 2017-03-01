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
	/// This class is the base class for any <see cref="ViewNgayTrongTuanProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewNgayTrongTuanProviderBaseCore : EntityViewProviderBase<ViewNgayTrongTuan>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewNgayTrongTuan&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewNgayTrongTuan&gt;"/></returns>
		protected static VList&lt;ViewNgayTrongTuan&gt; Fill(DataSet dataSet, VList<ViewNgayTrongTuan> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewNgayTrongTuan>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewNgayTrongTuan&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewNgayTrongTuan>"/></returns>
		protected static VList&lt;ViewNgayTrongTuan&gt; Fill(DataTable dataTable, VList<ViewNgayTrongTuan> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewNgayTrongTuan c = new ViewNgayTrongTuan();
					c.DayId = (Convert.IsDBNull(row["DayId"]))?string.Empty:(System.String)row["DayId"];
					c.DayName = (Convert.IsDBNull(row["DayName"]))?string.Empty:(System.String)row["DayName"];
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
		/// Fill an <see cref="VList&lt;ViewNgayTrongTuan&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewNgayTrongTuan&gt;"/></returns>
		protected VList<ViewNgayTrongTuan> Fill(IDataReader reader, VList<ViewNgayTrongTuan> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewNgayTrongTuan entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewNgayTrongTuan>("ViewNgayTrongTuan",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewNgayTrongTuan();
					}
					
					entity.SuppressEntityEvents = true;

					entity.DayId = (System.String)reader["DayId"];
					//entity.DayId = (Convert.IsDBNull(reader["DayId"]))?string.Empty:(System.String)reader["DayId"];
					entity.DayName = (System.String)reader["DayName"];
					//entity.DayName = (Convert.IsDBNull(reader["DayName"]))?string.Empty:(System.String)reader["DayName"];
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
		/// Refreshes the <see cref="ViewNgayTrongTuan"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewNgayTrongTuan"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewNgayTrongTuan entity)
		{
			reader.Read();
			entity.DayId = (System.String)reader["DayId"];
			//entity.DayId = (Convert.IsDBNull(reader["DayId"]))?string.Empty:(System.String)reader["DayId"];
			entity.DayName = (System.String)reader["DayName"];
			//entity.DayName = (Convert.IsDBNull(reader["DayName"]))?string.Empty:(System.String)reader["DayName"];
			entity.Coefficient = reader.IsDBNull(reader.GetOrdinal("Coefficient")) ? null : (System.Decimal?)reader["Coefficient"];
			//entity.Coefficient = (Convert.IsDBNull(reader["Coefficient"]))?0.0m:(System.Decimal?)reader["Coefficient"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewNgayTrongTuan"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewNgayTrongTuan"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewNgayTrongTuan entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.DayId = (Convert.IsDBNull(dataRow["DayId"]))?string.Empty:(System.String)dataRow["DayId"];
			entity.DayName = (Convert.IsDBNull(dataRow["DayName"]))?string.Empty:(System.String)dataRow["DayName"];
			entity.Coefficient = (Convert.IsDBNull(dataRow["Coefficient"]))?0.0m:(System.Decimal?)dataRow["Coefficient"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewNgayTrongTuanFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewNgayTrongTuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewNgayTrongTuanFilterBuilder : SqlFilterBuilder<ViewNgayTrongTuanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewNgayTrongTuanFilterBuilder class.
		/// </summary>
		public ViewNgayTrongTuanFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewNgayTrongTuanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewNgayTrongTuanFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewNgayTrongTuanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewNgayTrongTuanFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewNgayTrongTuanFilterBuilder

	#region ViewNgayTrongTuanParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewNgayTrongTuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewNgayTrongTuanParameterBuilder : ParameterizedSqlFilterBuilder<ViewNgayTrongTuanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewNgayTrongTuanParameterBuilder class.
		/// </summary>
		public ViewNgayTrongTuanParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewNgayTrongTuanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewNgayTrongTuanParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewNgayTrongTuanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewNgayTrongTuanParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewNgayTrongTuanParameterBuilder
	
	#region ViewNgayTrongTuanSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewNgayTrongTuan"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewNgayTrongTuanSortBuilder : SqlSortBuilder<ViewNgayTrongTuanColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewNgayTrongTuanSqlSortBuilder class.
		/// </summary>
		public ViewNgayTrongTuanSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewNgayTrongTuanSortBuilder

} // end namespace
