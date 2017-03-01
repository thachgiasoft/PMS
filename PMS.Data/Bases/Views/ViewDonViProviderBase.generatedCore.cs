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
	/// This class is the base class for any <see cref="ViewDonViProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewDonViProviderBaseCore : EntityViewProviderBase<ViewDonVi>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewDonVi&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewDonVi&gt;"/></returns>
		protected static VList&lt;ViewDonVi&gt; Fill(DataSet dataSet, VList<ViewDonVi> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewDonVi>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewDonVi&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewDonVi>"/></returns>
		protected static VList&lt;ViewDonVi&gt; Fill(DataTable dataTable, VList<ViewDonVi> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewDonVi c = new ViewDonVi();
					c.MaDonVi = (Convert.IsDBNull(row["MaDonVi"]))?string.Empty:(System.String)row["MaDonVi"];
					c.TenDonVi = (Convert.IsDBNull(row["TenDonVi"]))?string.Empty:(System.String)row["TenDonVi"];
					c.BoMon = (Convert.IsDBNull(row["BoMon"]))?string.Empty:(System.String)row["BoMon"];
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
		/// Fill an <see cref="VList&lt;ViewDonVi&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewDonVi&gt;"/></returns>
		protected VList<ViewDonVi> Fill(IDataReader reader, VList<ViewDonVi> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewDonVi entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewDonVi>("ViewDonVi",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewDonVi();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaDonVi = (System.String)reader["MaDonVi"];
					//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
					entity.TenDonVi = (System.String)reader["TenDonVi"];
					//entity.TenDonVi = (Convert.IsDBNull(reader["TenDonVi"]))?string.Empty:(System.String)reader["TenDonVi"];
					entity.BoMon = reader.IsDBNull(reader.GetOrdinal("BoMon")) ? null : (System.String)reader["BoMon"];
					//entity.BoMon = (Convert.IsDBNull(reader["BoMon"]))?string.Empty:(System.String)reader["BoMon"];
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
		/// Refreshes the <see cref="ViewDonVi"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewDonVi"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewDonVi entity)
		{
			reader.Read();
			entity.MaDonVi = (System.String)reader["MaDonVi"];
			//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
			entity.TenDonVi = (System.String)reader["TenDonVi"];
			//entity.TenDonVi = (Convert.IsDBNull(reader["TenDonVi"]))?string.Empty:(System.String)reader["TenDonVi"];
			entity.BoMon = reader.IsDBNull(reader.GetOrdinal("BoMon")) ? null : (System.String)reader["BoMon"];
			//entity.BoMon = (Convert.IsDBNull(reader["BoMon"]))?string.Empty:(System.String)reader["BoMon"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewDonVi"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewDonVi"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewDonVi entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaDonVi = (Convert.IsDBNull(dataRow["MaDonVi"]))?string.Empty:(System.String)dataRow["MaDonVi"];
			entity.TenDonVi = (Convert.IsDBNull(dataRow["TenDonVi"]))?string.Empty:(System.String)dataRow["TenDonVi"];
			entity.BoMon = (Convert.IsDBNull(dataRow["BoMon"]))?string.Empty:(System.String)dataRow["BoMon"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewDonViFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewDonVi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewDonViFilterBuilder : SqlFilterBuilder<ViewDonViColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewDonViFilterBuilder class.
		/// </summary>
		public ViewDonViFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewDonViFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewDonViFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewDonViFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewDonViFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewDonViFilterBuilder

	#region ViewDonViParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewDonVi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewDonViParameterBuilder : ParameterizedSqlFilterBuilder<ViewDonViColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewDonViParameterBuilder class.
		/// </summary>
		public ViewDonViParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewDonViParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewDonViParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewDonViParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewDonViParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewDonViParameterBuilder
	
	#region ViewDonViSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewDonVi"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewDonViSortBuilder : SqlSortBuilder<ViewDonViColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewDonViSqlSortBuilder class.
		/// </summary>
		public ViewDonViSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewDonViSortBuilder

} // end namespace
