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
	/// This class is the base class for any <see cref="ViewDanTocProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewDanTocProviderBaseCore : EntityViewProviderBase<ViewDanToc>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewDanToc&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewDanToc&gt;"/></returns>
		protected static VList&lt;ViewDanToc&gt; Fill(DataSet dataSet, VList<ViewDanToc> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewDanToc>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewDanToc&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewDanToc>"/></returns>
		protected static VList&lt;ViewDanToc&gt; Fill(DataTable dataTable, VList<ViewDanToc> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewDanToc c = new ViewDanToc();
					c.MaDanToc = (Convert.IsDBNull(row["MaDanToc"]))?string.Empty:(System.String)row["MaDanToc"];
					c.TenDanToc = (Convert.IsDBNull(row["TenDanToc"]))?string.Empty:(System.String)row["TenDanToc"];
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
		/// Fill an <see cref="VList&lt;ViewDanToc&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewDanToc&gt;"/></returns>
		protected VList<ViewDanToc> Fill(IDataReader reader, VList<ViewDanToc> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewDanToc entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewDanToc>("ViewDanToc",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewDanToc();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaDanToc = (System.String)reader["MaDanToc"];
					//entity.MaDanToc = (Convert.IsDBNull(reader["MaDanToc"]))?string.Empty:(System.String)reader["MaDanToc"];
					entity.TenDanToc = (System.String)reader["TenDanToc"];
					//entity.TenDanToc = (Convert.IsDBNull(reader["TenDanToc"]))?string.Empty:(System.String)reader["TenDanToc"];
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
		/// Refreshes the <see cref="ViewDanToc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewDanToc"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewDanToc entity)
		{
			reader.Read();
			entity.MaDanToc = (System.String)reader["MaDanToc"];
			//entity.MaDanToc = (Convert.IsDBNull(reader["MaDanToc"]))?string.Empty:(System.String)reader["MaDanToc"];
			entity.TenDanToc = (System.String)reader["TenDanToc"];
			//entity.TenDanToc = (Convert.IsDBNull(reader["TenDanToc"]))?string.Empty:(System.String)reader["TenDanToc"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewDanToc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewDanToc"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewDanToc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaDanToc = (Convert.IsDBNull(dataRow["MaDanToc"]))?string.Empty:(System.String)dataRow["MaDanToc"];
			entity.TenDanToc = (Convert.IsDBNull(dataRow["TenDanToc"]))?string.Empty:(System.String)dataRow["TenDanToc"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewDanTocFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewDanToc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewDanTocFilterBuilder : SqlFilterBuilder<ViewDanTocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewDanTocFilterBuilder class.
		/// </summary>
		public ViewDanTocFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewDanTocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewDanTocFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewDanTocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewDanTocFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewDanTocFilterBuilder

	#region ViewDanTocParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewDanToc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewDanTocParameterBuilder : ParameterizedSqlFilterBuilder<ViewDanTocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewDanTocParameterBuilder class.
		/// </summary>
		public ViewDanTocParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewDanTocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewDanTocParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewDanTocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewDanTocParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewDanTocParameterBuilder
	
	#region ViewDanTocSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewDanToc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewDanTocSortBuilder : SqlSortBuilder<ViewDanTocColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewDanTocSqlSortBuilder class.
		/// </summary>
		public ViewDanTocSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewDanTocSortBuilder

} // end namespace
