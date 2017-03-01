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
	/// This class is the base class for any <see cref="ViewHeDaoTaoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewHeDaoTaoProviderBaseCore : EntityViewProviderBase<ViewHeDaoTao>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewHeDaoTao&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewHeDaoTao&gt;"/></returns>
		protected static VList&lt;ViewHeDaoTao&gt; Fill(DataSet dataSet, VList<ViewHeDaoTao> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewHeDaoTao>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewHeDaoTao&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewHeDaoTao>"/></returns>
		protected static VList&lt;ViewHeDaoTao&gt; Fill(DataTable dataTable, VList<ViewHeDaoTao> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewHeDaoTao c = new ViewHeDaoTao();
					c.MaHeDaoTao = (Convert.IsDBNull(row["MaHeDaoTao"]))?string.Empty:(System.String)row["MaHeDaoTao"];
					c.TenHeDaoTao = (Convert.IsDBNull(row["TenHeDaoTao"]))?string.Empty:(System.String)row["TenHeDaoTao"];
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
		/// Fill an <see cref="VList&lt;ViewHeDaoTao&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewHeDaoTao&gt;"/></returns>
		protected VList<ViewHeDaoTao> Fill(IDataReader reader, VList<ViewHeDaoTao> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewHeDaoTao entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewHeDaoTao>("ViewHeDaoTao",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewHeDaoTao();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaHeDaoTao = (System.String)reader["MaHeDaoTao"];
					//entity.MaHeDaoTao = (Convert.IsDBNull(reader["MaHeDaoTao"]))?string.Empty:(System.String)reader["MaHeDaoTao"];
					entity.TenHeDaoTao = (System.String)reader["TenHeDaoTao"];
					//entity.TenHeDaoTao = (Convert.IsDBNull(reader["TenHeDaoTao"]))?string.Empty:(System.String)reader["TenHeDaoTao"];
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
		/// Refreshes the <see cref="ViewHeDaoTao"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewHeDaoTao"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewHeDaoTao entity)
		{
			reader.Read();
			entity.MaHeDaoTao = (System.String)reader["MaHeDaoTao"];
			//entity.MaHeDaoTao = (Convert.IsDBNull(reader["MaHeDaoTao"]))?string.Empty:(System.String)reader["MaHeDaoTao"];
			entity.TenHeDaoTao = (System.String)reader["TenHeDaoTao"];
			//entity.TenHeDaoTao = (Convert.IsDBNull(reader["TenHeDaoTao"]))?string.Empty:(System.String)reader["TenHeDaoTao"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewHeDaoTao"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewHeDaoTao"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewHeDaoTao entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaHeDaoTao = (Convert.IsDBNull(dataRow["MaHeDaoTao"]))?string.Empty:(System.String)dataRow["MaHeDaoTao"];
			entity.TenHeDaoTao = (Convert.IsDBNull(dataRow["TenHeDaoTao"]))?string.Empty:(System.String)dataRow["TenHeDaoTao"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewHeDaoTaoFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHeDaoTao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHeDaoTaoFilterBuilder : SqlFilterBuilder<ViewHeDaoTaoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHeDaoTaoFilterBuilder class.
		/// </summary>
		public ViewHeDaoTaoFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewHeDaoTaoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewHeDaoTaoFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewHeDaoTaoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewHeDaoTaoFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewHeDaoTaoFilterBuilder

	#region ViewHeDaoTaoParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHeDaoTao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHeDaoTaoParameterBuilder : ParameterizedSqlFilterBuilder<ViewHeDaoTaoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHeDaoTaoParameterBuilder class.
		/// </summary>
		public ViewHeDaoTaoParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewHeDaoTaoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewHeDaoTaoParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewHeDaoTaoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewHeDaoTaoParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewHeDaoTaoParameterBuilder
	
	#region ViewHeDaoTaoSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHeDaoTao"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewHeDaoTaoSortBuilder : SqlSortBuilder<ViewHeDaoTaoColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHeDaoTaoSqlSortBuilder class.
		/// </summary>
		public ViewHeDaoTaoSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewHeDaoTaoSortBuilder

} // end namespace
