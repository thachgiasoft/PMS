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
	/// This class is the base class for any <see cref="ViewTonGiaoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewTonGiaoProviderBaseCore : EntityViewProviderBase<ViewTonGiao>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewTonGiao&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewTonGiao&gt;"/></returns>
		protected static VList&lt;ViewTonGiao&gt; Fill(DataSet dataSet, VList<ViewTonGiao> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewTonGiao>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewTonGiao&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewTonGiao>"/></returns>
		protected static VList&lt;ViewTonGiao&gt; Fill(DataTable dataTable, VList<ViewTonGiao> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewTonGiao c = new ViewTonGiao();
					c.MaTonGiao = (Convert.IsDBNull(row["MaTonGiao"]))?string.Empty:(System.String)row["MaTonGiao"];
					c.TenTonGiao = (Convert.IsDBNull(row["TenTonGiao"]))?string.Empty:(System.String)row["TenTonGiao"];
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
		/// Fill an <see cref="VList&lt;ViewTonGiao&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewTonGiao&gt;"/></returns>
		protected VList<ViewTonGiao> Fill(IDataReader reader, VList<ViewTonGiao> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewTonGiao entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewTonGiao>("ViewTonGiao",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewTonGiao();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaTonGiao = (System.String)reader["MaTonGiao"];
					//entity.MaTonGiao = (Convert.IsDBNull(reader["MaTonGiao"]))?string.Empty:(System.String)reader["MaTonGiao"];
					entity.TenTonGiao = (System.String)reader["TenTonGiao"];
					//entity.TenTonGiao = (Convert.IsDBNull(reader["TenTonGiao"]))?string.Empty:(System.String)reader["TenTonGiao"];
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
		/// Refreshes the <see cref="ViewTonGiao"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewTonGiao"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewTonGiao entity)
		{
			reader.Read();
			entity.MaTonGiao = (System.String)reader["MaTonGiao"];
			//entity.MaTonGiao = (Convert.IsDBNull(reader["MaTonGiao"]))?string.Empty:(System.String)reader["MaTonGiao"];
			entity.TenTonGiao = (System.String)reader["TenTonGiao"];
			//entity.TenTonGiao = (Convert.IsDBNull(reader["TenTonGiao"]))?string.Empty:(System.String)reader["TenTonGiao"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewTonGiao"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewTonGiao"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewTonGiao entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaTonGiao = (Convert.IsDBNull(dataRow["MaTonGiao"]))?string.Empty:(System.String)dataRow["MaTonGiao"];
			entity.TenTonGiao = (Convert.IsDBNull(dataRow["TenTonGiao"]))?string.Empty:(System.String)dataRow["TenTonGiao"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewTonGiaoFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTonGiao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTonGiaoFilterBuilder : SqlFilterBuilder<ViewTonGiaoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTonGiaoFilterBuilder class.
		/// </summary>
		public ViewTonGiaoFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewTonGiaoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewTonGiaoFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewTonGiaoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewTonGiaoFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewTonGiaoFilterBuilder

	#region ViewTonGiaoParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTonGiao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTonGiaoParameterBuilder : ParameterizedSqlFilterBuilder<ViewTonGiaoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTonGiaoParameterBuilder class.
		/// </summary>
		public ViewTonGiaoParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewTonGiaoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewTonGiaoParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewTonGiaoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewTonGiaoParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewTonGiaoParameterBuilder
	
	#region ViewTonGiaoSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTonGiao"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewTonGiaoSortBuilder : SqlSortBuilder<ViewTonGiaoColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTonGiaoSqlSortBuilder class.
		/// </summary>
		public ViewTonGiaoSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewTonGiaoSortBuilder

} // end namespace
