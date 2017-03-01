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
	/// This class is the base class for any <see cref="ViewTheoDoiLichGiangProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewTheoDoiLichGiangProviderBaseCore : EntityViewProviderBase<ViewTheoDoiLichGiang>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewTheoDoiLichGiang&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewTheoDoiLichGiang&gt;"/></returns>
		protected static VList&lt;ViewTheoDoiLichGiang&gt; Fill(DataSet dataSet, VList<ViewTheoDoiLichGiang> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewTheoDoiLichGiang>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewTheoDoiLichGiang&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewTheoDoiLichGiang>"/></returns>
		protected static VList&lt;ViewTheoDoiLichGiang&gt; Fill(DataTable dataTable, VList<ViewTheoDoiLichGiang> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewTheoDoiLichGiang c = new ViewTheoDoiLichGiang();
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
		/// Fill an <see cref="VList&lt;ViewTheoDoiLichGiang&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewTheoDoiLichGiang&gt;"/></returns>
		protected VList<ViewTheoDoiLichGiang> Fill(IDataReader reader, VList<ViewTheoDoiLichGiang> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewTheoDoiLichGiang entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewTheoDoiLichGiang>("ViewTheoDoiLichGiang",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewTheoDoiLichGiang();
					}
					
					entity.SuppressEntityEvents = true;

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
		/// Refreshes the <see cref="ViewTheoDoiLichGiang"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewTheoDoiLichGiang"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewTheoDoiLichGiang entity)
		{
			reader.Read();
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewTheoDoiLichGiang"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewTheoDoiLichGiang"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewTheoDoiLichGiang entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewTheoDoiLichGiangFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTheoDoiLichGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTheoDoiLichGiangFilterBuilder : SqlFilterBuilder<ViewTheoDoiLichGiangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTheoDoiLichGiangFilterBuilder class.
		/// </summary>
		public ViewTheoDoiLichGiangFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewTheoDoiLichGiangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewTheoDoiLichGiangFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewTheoDoiLichGiangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewTheoDoiLichGiangFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewTheoDoiLichGiangFilterBuilder

	#region ViewTheoDoiLichGiangParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTheoDoiLichGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTheoDoiLichGiangParameterBuilder : ParameterizedSqlFilterBuilder<ViewTheoDoiLichGiangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTheoDoiLichGiangParameterBuilder class.
		/// </summary>
		public ViewTheoDoiLichGiangParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewTheoDoiLichGiangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewTheoDoiLichGiangParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewTheoDoiLichGiangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewTheoDoiLichGiangParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewTheoDoiLichGiangParameterBuilder
	
	#region ViewTheoDoiLichGiangSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTheoDoiLichGiang"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewTheoDoiLichGiangSortBuilder : SqlSortBuilder<ViewTheoDoiLichGiangColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTheoDoiLichGiangSqlSortBuilder class.
		/// </summary>
		public ViewTheoDoiLichGiangSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewTheoDoiLichGiangSortBuilder

} // end namespace
