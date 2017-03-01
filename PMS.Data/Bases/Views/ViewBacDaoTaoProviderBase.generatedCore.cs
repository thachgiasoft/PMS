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
	/// This class is the base class for any <see cref="ViewBacDaoTaoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewBacDaoTaoProviderBaseCore : EntityViewProviderBase<ViewBacDaoTao>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewBacDaoTao&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewBacDaoTao&gt;"/></returns>
		protected static VList&lt;ViewBacDaoTao&gt; Fill(DataSet dataSet, VList<ViewBacDaoTao> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewBacDaoTao>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewBacDaoTao&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewBacDaoTao>"/></returns>
		protected static VList&lt;ViewBacDaoTao&gt; Fill(DataTable dataTable, VList<ViewBacDaoTao> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewBacDaoTao c = new ViewBacDaoTao();
					c.MaBacDaoTao = (Convert.IsDBNull(row["MaBacDaoTao"]))?string.Empty:(System.String)row["MaBacDaoTao"];
					c.TenBacDaoTao = (Convert.IsDBNull(row["TenBacDaoTao"]))?string.Empty:(System.String)row["TenBacDaoTao"];
					c.Stt = (Convert.IsDBNull(row["Stt"]))?string.Empty:(System.String)row["Stt"];
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
		/// Fill an <see cref="VList&lt;ViewBacDaoTao&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewBacDaoTao&gt;"/></returns>
		protected VList<ViewBacDaoTao> Fill(IDataReader reader, VList<ViewBacDaoTao> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewBacDaoTao entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewBacDaoTao>("ViewBacDaoTao",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewBacDaoTao();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaBacDaoTao = (System.String)reader["MaBacDaoTao"];
					//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
					entity.TenBacDaoTao = (System.String)reader["TenBacDaoTao"];
					//entity.TenBacDaoTao = (Convert.IsDBNull(reader["TenBacDaoTao"]))?string.Empty:(System.String)reader["TenBacDaoTao"];
					entity.Stt = reader.IsDBNull(reader.GetOrdinal("Stt")) ? null : (System.String)reader["Stt"];
					//entity.Stt = (Convert.IsDBNull(reader["Stt"]))?string.Empty:(System.String)reader["Stt"];
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
		/// Refreshes the <see cref="ViewBacDaoTao"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewBacDaoTao"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewBacDaoTao entity)
		{
			reader.Read();
			entity.MaBacDaoTao = (System.String)reader["MaBacDaoTao"];
			//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
			entity.TenBacDaoTao = (System.String)reader["TenBacDaoTao"];
			//entity.TenBacDaoTao = (Convert.IsDBNull(reader["TenBacDaoTao"]))?string.Empty:(System.String)reader["TenBacDaoTao"];
			entity.Stt = reader.IsDBNull(reader.GetOrdinal("Stt")) ? null : (System.String)reader["Stt"];
			//entity.Stt = (Convert.IsDBNull(reader["Stt"]))?string.Empty:(System.String)reader["Stt"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewBacDaoTao"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewBacDaoTao"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewBacDaoTao entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaBacDaoTao = (Convert.IsDBNull(dataRow["MaBacDaoTao"]))?string.Empty:(System.String)dataRow["MaBacDaoTao"];
			entity.TenBacDaoTao = (Convert.IsDBNull(dataRow["TenBacDaoTao"]))?string.Empty:(System.String)dataRow["TenBacDaoTao"];
			entity.Stt = (Convert.IsDBNull(dataRow["Stt"]))?string.Empty:(System.String)dataRow["Stt"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewBacDaoTaoFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewBacDaoTao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewBacDaoTaoFilterBuilder : SqlFilterBuilder<ViewBacDaoTaoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewBacDaoTaoFilterBuilder class.
		/// </summary>
		public ViewBacDaoTaoFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewBacDaoTaoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewBacDaoTaoFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewBacDaoTaoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewBacDaoTaoFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewBacDaoTaoFilterBuilder

	#region ViewBacDaoTaoParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewBacDaoTao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewBacDaoTaoParameterBuilder : ParameterizedSqlFilterBuilder<ViewBacDaoTaoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewBacDaoTaoParameterBuilder class.
		/// </summary>
		public ViewBacDaoTaoParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewBacDaoTaoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewBacDaoTaoParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewBacDaoTaoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewBacDaoTaoParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewBacDaoTaoParameterBuilder
	
	#region ViewBacDaoTaoSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewBacDaoTao"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewBacDaoTaoSortBuilder : SqlSortBuilder<ViewBacDaoTaoColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewBacDaoTaoSqlSortBuilder class.
		/// </summary>
		public ViewBacDaoTaoSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewBacDaoTaoSortBuilder

} // end namespace
