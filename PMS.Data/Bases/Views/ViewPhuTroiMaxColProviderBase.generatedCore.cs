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
	/// This class is the base class for any <see cref="ViewPhuTroiMaxColProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewPhuTroiMaxColProviderBaseCore : EntityViewProviderBase<ViewPhuTroiMaxCol>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewPhuTroiMaxCol&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewPhuTroiMaxCol&gt;"/></returns>
		protected static VList&lt;ViewPhuTroiMaxCol&gt; Fill(DataSet dataSet, VList<ViewPhuTroiMaxCol> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewPhuTroiMaxCol>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewPhuTroiMaxCol&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewPhuTroiMaxCol>"/></returns>
		protected static VList&lt;ViewPhuTroiMaxCol&gt; Fill(DataTable dataTable, VList<ViewPhuTroiMaxCol> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewPhuTroiMaxCol c = new ViewPhuTroiMaxCol();
					c.MaxCol = (Convert.IsDBNull(row["MaxCol"]))?(int)0:(System.Int32?)row["MaxCol"];
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
		/// Fill an <see cref="VList&lt;ViewPhuTroiMaxCol&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewPhuTroiMaxCol&gt;"/></returns>
		protected VList<ViewPhuTroiMaxCol> Fill(IDataReader reader, VList<ViewPhuTroiMaxCol> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewPhuTroiMaxCol entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewPhuTroiMaxCol>("ViewPhuTroiMaxCol",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewPhuTroiMaxCol();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaxCol = (reader.IsDBNull(((int)ViewPhuTroiMaxColColumn.MaxCol)))?null:(System.Int32?)reader[((int)ViewPhuTroiMaxColColumn.MaxCol)];
					//entity.MaxCol = (Convert.IsDBNull(reader["MaxCol"]))?(int)0:(System.Int32?)reader["MaxCol"];
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
		/// Refreshes the <see cref="ViewPhuTroiMaxCol"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewPhuTroiMaxCol"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewPhuTroiMaxCol entity)
		{
			reader.Read();
			entity.MaxCol = (reader.IsDBNull(((int)ViewPhuTroiMaxColColumn.MaxCol)))?null:(System.Int32?)reader[((int)ViewPhuTroiMaxColColumn.MaxCol)];
			//entity.MaxCol = (Convert.IsDBNull(reader["MaxCol"]))?(int)0:(System.Int32?)reader["MaxCol"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewPhuTroiMaxCol"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewPhuTroiMaxCol"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewPhuTroiMaxCol entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaxCol = (Convert.IsDBNull(dataRow["MaxCol"]))?(int)0:(System.Int32?)dataRow["MaxCol"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewPhuTroiMaxColFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhuTroiMaxCol"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhuTroiMaxColFilterBuilder : SqlFilterBuilder<ViewPhuTroiMaxColColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhuTroiMaxColFilterBuilder class.
		/// </summary>
		public ViewPhuTroiMaxColFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewPhuTroiMaxColFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewPhuTroiMaxColFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewPhuTroiMaxColFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewPhuTroiMaxColFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewPhuTroiMaxColFilterBuilder

	#region ViewPhuTroiMaxColParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhuTroiMaxCol"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhuTroiMaxColParameterBuilder : ParameterizedSqlFilterBuilder<ViewPhuTroiMaxColColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhuTroiMaxColParameterBuilder class.
		/// </summary>
		public ViewPhuTroiMaxColParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewPhuTroiMaxColParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewPhuTroiMaxColParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewPhuTroiMaxColParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewPhuTroiMaxColParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewPhuTroiMaxColParameterBuilder
	
	#region ViewPhuTroiMaxColSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhuTroiMaxCol"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewPhuTroiMaxColSortBuilder : SqlSortBuilder<ViewPhuTroiMaxColColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhuTroiMaxColSqlSortBuilder class.
		/// </summary>
		public ViewPhuTroiMaxColSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewPhuTroiMaxColSortBuilder

} // end namespace
