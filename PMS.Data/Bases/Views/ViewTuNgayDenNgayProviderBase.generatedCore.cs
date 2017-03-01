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
	/// This class is the base class for any <see cref="ViewTuNgayDenNgayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewTuNgayDenNgayProviderBaseCore : EntityViewProviderBase<ViewTuNgayDenNgay>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewTuNgayDenNgay&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewTuNgayDenNgay&gt;"/></returns>
		protected static VList&lt;ViewTuNgayDenNgay&gt; Fill(DataSet dataSet, VList<ViewTuNgayDenNgay> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewTuNgayDenNgay>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewTuNgayDenNgay&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewTuNgayDenNgay>"/></returns>
		protected static VList&lt;ViewTuNgayDenNgay&gt; Fill(DataTable dataTable, VList<ViewTuNgayDenNgay> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewTuNgayDenNgay c = new ViewTuNgayDenNgay();
					c.Tungay = (Convert.IsDBNull(row["tungay"]))?DateTime.MinValue:(System.DateTime?)row["tungay"];
					c.Denngay = (Convert.IsDBNull(row["denngay"]))?DateTime.MinValue:(System.DateTime?)row["denngay"];
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
		/// Fill an <see cref="VList&lt;ViewTuNgayDenNgay&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewTuNgayDenNgay&gt;"/></returns>
		protected VList<ViewTuNgayDenNgay> Fill(IDataReader reader, VList<ViewTuNgayDenNgay> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewTuNgayDenNgay entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewTuNgayDenNgay>("ViewTuNgayDenNgay",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewTuNgayDenNgay();
					}
					
					entity.SuppressEntityEvents = true;

					entity.Tungay = (reader.IsDBNull(((int)ViewTuNgayDenNgayColumn.Tungay)))?null:(System.DateTime?)reader[((int)ViewTuNgayDenNgayColumn.Tungay)];
					//entity.Tungay = (Convert.IsDBNull(reader["tungay"]))?DateTime.MinValue:(System.DateTime?)reader["tungay"];
					entity.Denngay = (reader.IsDBNull(((int)ViewTuNgayDenNgayColumn.Denngay)))?null:(System.DateTime?)reader[((int)ViewTuNgayDenNgayColumn.Denngay)];
					//entity.Denngay = (Convert.IsDBNull(reader["denngay"]))?DateTime.MinValue:(System.DateTime?)reader["denngay"];
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
		/// Refreshes the <see cref="ViewTuNgayDenNgay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewTuNgayDenNgay"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewTuNgayDenNgay entity)
		{
			reader.Read();
			entity.Tungay = (reader.IsDBNull(((int)ViewTuNgayDenNgayColumn.Tungay)))?null:(System.DateTime?)reader[((int)ViewTuNgayDenNgayColumn.Tungay)];
			//entity.Tungay = (Convert.IsDBNull(reader["tungay"]))?DateTime.MinValue:(System.DateTime?)reader["tungay"];
			entity.Denngay = (reader.IsDBNull(((int)ViewTuNgayDenNgayColumn.Denngay)))?null:(System.DateTime?)reader[((int)ViewTuNgayDenNgayColumn.Denngay)];
			//entity.Denngay = (Convert.IsDBNull(reader["denngay"]))?DateTime.MinValue:(System.DateTime?)reader["denngay"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewTuNgayDenNgay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewTuNgayDenNgay"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewTuNgayDenNgay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Tungay = (Convert.IsDBNull(dataRow["tungay"]))?DateTime.MinValue:(System.DateTime?)dataRow["tungay"];
			entity.Denngay = (Convert.IsDBNull(dataRow["denngay"]))?DateTime.MinValue:(System.DateTime?)dataRow["denngay"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewTuNgayDenNgayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTuNgayDenNgay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTuNgayDenNgayFilterBuilder : SqlFilterBuilder<ViewTuNgayDenNgayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTuNgayDenNgayFilterBuilder class.
		/// </summary>
		public ViewTuNgayDenNgayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewTuNgayDenNgayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewTuNgayDenNgayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewTuNgayDenNgayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewTuNgayDenNgayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewTuNgayDenNgayFilterBuilder

	#region ViewTuNgayDenNgayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTuNgayDenNgay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTuNgayDenNgayParameterBuilder : ParameterizedSqlFilterBuilder<ViewTuNgayDenNgayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTuNgayDenNgayParameterBuilder class.
		/// </summary>
		public ViewTuNgayDenNgayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewTuNgayDenNgayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewTuNgayDenNgayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewTuNgayDenNgayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewTuNgayDenNgayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewTuNgayDenNgayParameterBuilder
	
	#region ViewTuNgayDenNgaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTuNgayDenNgay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewTuNgayDenNgaySortBuilder : SqlSortBuilder<ViewTuNgayDenNgayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTuNgayDenNgaySqlSortBuilder class.
		/// </summary>
		public ViewTuNgayDenNgaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewTuNgayDenNgaySortBuilder

} // end namespace
