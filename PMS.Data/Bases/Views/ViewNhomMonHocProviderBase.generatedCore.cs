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
	/// This class is the base class for any <see cref="ViewNhomMonHocProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewNhomMonHocProviderBaseCore : EntityViewProviderBase<ViewNhomMonHoc>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewNhomMonHoc&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewNhomMonHoc&gt;"/></returns>
		protected static VList&lt;ViewNhomMonHoc&gt; Fill(DataSet dataSet, VList<ViewNhomMonHoc> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewNhomMonHoc>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewNhomMonHoc&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewNhomMonHoc>"/></returns>
		protected static VList&lt;ViewNhomMonHoc&gt; Fill(DataTable dataTable, VList<ViewNhomMonHoc> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewNhomMonHoc c = new ViewNhomMonHoc();
					c.MaNhomMonHoc = (Convert.IsDBNull(row["MaNhomMonHoc"]))?string.Empty:(System.String)row["MaNhomMonHoc"];
					c.TenNhomMonHoc = (Convert.IsDBNull(row["TenNhomMonHoc"]))?string.Empty:(System.String)row["TenNhomMonHoc"];
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
		/// Fill an <see cref="VList&lt;ViewNhomMonHoc&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewNhomMonHoc&gt;"/></returns>
		protected VList<ViewNhomMonHoc> Fill(IDataReader reader, VList<ViewNhomMonHoc> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewNhomMonHoc entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewNhomMonHoc>("ViewNhomMonHoc",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewNhomMonHoc();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaNhomMonHoc = (System.String)reader["MaNhomMonHoc"];
					//entity.MaNhomMonHoc = (Convert.IsDBNull(reader["MaNhomMonHoc"]))?string.Empty:(System.String)reader["MaNhomMonHoc"];
					entity.TenNhomMonHoc = reader.IsDBNull(reader.GetOrdinal("TenNhomMonHoc")) ? null : (System.String)reader["TenNhomMonHoc"];
					//entity.TenNhomMonHoc = (Convert.IsDBNull(reader["TenNhomMonHoc"]))?string.Empty:(System.String)reader["TenNhomMonHoc"];
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
		/// Refreshes the <see cref="ViewNhomMonHoc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewNhomMonHoc"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewNhomMonHoc entity)
		{
			reader.Read();
			entity.MaNhomMonHoc = (System.String)reader["MaNhomMonHoc"];
			//entity.MaNhomMonHoc = (Convert.IsDBNull(reader["MaNhomMonHoc"]))?string.Empty:(System.String)reader["MaNhomMonHoc"];
			entity.TenNhomMonHoc = reader.IsDBNull(reader.GetOrdinal("TenNhomMonHoc")) ? null : (System.String)reader["TenNhomMonHoc"];
			//entity.TenNhomMonHoc = (Convert.IsDBNull(reader["TenNhomMonHoc"]))?string.Empty:(System.String)reader["TenNhomMonHoc"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewNhomMonHoc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewNhomMonHoc"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewNhomMonHoc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaNhomMonHoc = (Convert.IsDBNull(dataRow["MaNhomMonHoc"]))?string.Empty:(System.String)dataRow["MaNhomMonHoc"];
			entity.TenNhomMonHoc = (Convert.IsDBNull(dataRow["TenNhomMonHoc"]))?string.Empty:(System.String)dataRow["TenNhomMonHoc"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewNhomMonHocFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewNhomMonHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewNhomMonHocFilterBuilder : SqlFilterBuilder<ViewNhomMonHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewNhomMonHocFilterBuilder class.
		/// </summary>
		public ViewNhomMonHocFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewNhomMonHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewNhomMonHocFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewNhomMonHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewNhomMonHocFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewNhomMonHocFilterBuilder

	#region ViewNhomMonHocParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewNhomMonHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewNhomMonHocParameterBuilder : ParameterizedSqlFilterBuilder<ViewNhomMonHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewNhomMonHocParameterBuilder class.
		/// </summary>
		public ViewNhomMonHocParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewNhomMonHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewNhomMonHocParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewNhomMonHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewNhomMonHocParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewNhomMonHocParameterBuilder
	
	#region ViewNhomMonHocSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewNhomMonHoc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewNhomMonHocSortBuilder : SqlSortBuilder<ViewNhomMonHocColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewNhomMonHocSqlSortBuilder class.
		/// </summary>
		public ViewNhomMonHocSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewNhomMonHocSortBuilder

} // end namespace
