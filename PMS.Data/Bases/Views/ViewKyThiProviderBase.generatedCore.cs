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
	/// This class is the base class for any <see cref="ViewKyThiProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewKyThiProviderBaseCore : EntityViewProviderBase<ViewKyThi>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewKyThi&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewKyThi&gt;"/></returns>
		protected static VList&lt;ViewKyThi&gt; Fill(DataSet dataSet, VList<ViewKyThi> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewKyThi>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewKyThi&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewKyThi>"/></returns>
		protected static VList&lt;ViewKyThi&gt; Fill(DataTable dataTable, VList<ViewKyThi> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewKyThi c = new ViewKyThi();
					c.MaKyThi = (Convert.IsDBNull(row["MaKyThi"]))?string.Empty:(System.String)row["MaKyThi"];
					c.TenKyThi = (Convert.IsDBNull(row["TenKyThi"]))?string.Empty:(System.String)row["TenKyThi"];
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
		/// Fill an <see cref="VList&lt;ViewKyThi&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewKyThi&gt;"/></returns>
		protected VList<ViewKyThi> Fill(IDataReader reader, VList<ViewKyThi> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewKyThi entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewKyThi>("ViewKyThi",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewKyThi();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaKyThi = (System.String)reader["MaKyThi"];
					//entity.MaKyThi = (Convert.IsDBNull(reader["MaKyThi"]))?string.Empty:(System.String)reader["MaKyThi"];
					entity.TenKyThi = reader.IsDBNull(reader.GetOrdinal("TenKyThi")) ? null : (System.String)reader["TenKyThi"];
					//entity.TenKyThi = (Convert.IsDBNull(reader["TenKyThi"]))?string.Empty:(System.String)reader["TenKyThi"];
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
		/// Refreshes the <see cref="ViewKyThi"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewKyThi"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewKyThi entity)
		{
			reader.Read();
			entity.MaKyThi = (System.String)reader["MaKyThi"];
			//entity.MaKyThi = (Convert.IsDBNull(reader["MaKyThi"]))?string.Empty:(System.String)reader["MaKyThi"];
			entity.TenKyThi = reader.IsDBNull(reader.GetOrdinal("TenKyThi")) ? null : (System.String)reader["TenKyThi"];
			//entity.TenKyThi = (Convert.IsDBNull(reader["TenKyThi"]))?string.Empty:(System.String)reader["TenKyThi"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewKyThi"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewKyThi"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewKyThi entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaKyThi = (Convert.IsDBNull(dataRow["MaKyThi"]))?string.Empty:(System.String)dataRow["MaKyThi"];
			entity.TenKyThi = (Convert.IsDBNull(dataRow["TenKyThi"]))?string.Empty:(System.String)dataRow["TenKyThi"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewKyThiFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKyThi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKyThiFilterBuilder : SqlFilterBuilder<ViewKyThiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKyThiFilterBuilder class.
		/// </summary>
		public ViewKyThiFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewKyThiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewKyThiFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewKyThiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewKyThiFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewKyThiFilterBuilder

	#region ViewKyThiParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKyThi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKyThiParameterBuilder : ParameterizedSqlFilterBuilder<ViewKyThiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKyThiParameterBuilder class.
		/// </summary>
		public ViewKyThiParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewKyThiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewKyThiParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewKyThiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewKyThiParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewKyThiParameterBuilder
	
	#region ViewKyThiSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKyThi"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewKyThiSortBuilder : SqlSortBuilder<ViewKyThiColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKyThiSqlSortBuilder class.
		/// </summary>
		public ViewKyThiSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewKyThiSortBuilder

} // end namespace
