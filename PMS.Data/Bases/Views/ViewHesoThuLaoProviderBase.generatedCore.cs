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
	/// This class is the base class for any <see cref="ViewHesoThuLaoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewHesoThuLaoProviderBaseCore : EntityViewProviderBase<ViewHesoThuLao>
	{
		#region Custom Methods
		
		
		#region cust_View_HesoThuLao_Luu
		
		/// <summary>
		///	This method wrap the 'cust_View_HesoThuLao_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader Luu(System.String xmlData)
		{
			return Luu(null, 0, int.MaxValue , xmlData);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_HesoThuLao_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader Luu(int start, int pageLength, System.String xmlData)
		{
			return Luu(null, start, pageLength , xmlData);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_HesoThuLao_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader Luu(TransactionManager transactionManager, System.String xmlData)
		{
			return Luu(transactionManager, 0, int.MaxValue , xmlData);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_HesoThuLao_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader Luu(TransactionManager transactionManager, int start, int pageLength, System.String xmlData);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewHesoThuLao&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewHesoThuLao&gt;"/></returns>
		protected static VList&lt;ViewHesoThuLao&gt; Fill(DataSet dataSet, VList<ViewHesoThuLao> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewHesoThuLao>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewHesoThuLao&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewHesoThuLao>"/></returns>
		protected static VList&lt;ViewHesoThuLao&gt; Fill(DataTable dataTable, VList<ViewHesoThuLao> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewHesoThuLao c = new ViewHesoThuLao();
					c.MaThuLao = (Convert.IsDBNull(row["MaThuLao"]))?string.Empty:(System.String)row["MaThuLao"];
					c.HeSoThuLao = (Convert.IsDBNull(row["HeSoThuLao"]))?0.0m:(System.Decimal)row["HeSoThuLao"];
					c.TenHeSoThuLao = (Convert.IsDBNull(row["TenHeSoThuLao"]))?string.Empty:(System.String)row["TenHeSoThuLao"];
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
		/// Fill an <see cref="VList&lt;ViewHesoThuLao&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewHesoThuLao&gt;"/></returns>
		protected VList<ViewHesoThuLao> Fill(IDataReader reader, VList<ViewHesoThuLao> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewHesoThuLao entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewHesoThuLao>("ViewHesoThuLao",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewHesoThuLao();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaThuLao = (System.String)reader["MaThuLao"];
					//entity.MaThuLao = (Convert.IsDBNull(reader["MaThuLao"]))?string.Empty:(System.String)reader["MaThuLao"];
					entity.HeSoThuLao = (System.Decimal)reader["HeSoThuLao"];
					//entity.HeSoThuLao = (Convert.IsDBNull(reader["HeSoThuLao"]))?0.0m:(System.Decimal)reader["HeSoThuLao"];
					entity.TenHeSoThuLao = reader.IsDBNull(reader.GetOrdinal("TenHeSoThuLao")) ? null : (System.String)reader["TenHeSoThuLao"];
					//entity.TenHeSoThuLao = (Convert.IsDBNull(reader["TenHeSoThuLao"]))?string.Empty:(System.String)reader["TenHeSoThuLao"];
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
		/// Refreshes the <see cref="ViewHesoThuLao"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewHesoThuLao"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewHesoThuLao entity)
		{
			reader.Read();
			entity.MaThuLao = (System.String)reader["MaThuLao"];
			//entity.MaThuLao = (Convert.IsDBNull(reader["MaThuLao"]))?string.Empty:(System.String)reader["MaThuLao"];
			entity.HeSoThuLao = (System.Decimal)reader["HeSoThuLao"];
			//entity.HeSoThuLao = (Convert.IsDBNull(reader["HeSoThuLao"]))?0.0m:(System.Decimal)reader["HeSoThuLao"];
			entity.TenHeSoThuLao = reader.IsDBNull(reader.GetOrdinal("TenHeSoThuLao")) ? null : (System.String)reader["TenHeSoThuLao"];
			//entity.TenHeSoThuLao = (Convert.IsDBNull(reader["TenHeSoThuLao"]))?string.Empty:(System.String)reader["TenHeSoThuLao"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewHesoThuLao"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewHesoThuLao"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewHesoThuLao entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaThuLao = (Convert.IsDBNull(dataRow["MaThuLao"]))?string.Empty:(System.String)dataRow["MaThuLao"];
			entity.HeSoThuLao = (Convert.IsDBNull(dataRow["HeSoThuLao"]))?0.0m:(System.Decimal)dataRow["HeSoThuLao"];
			entity.TenHeSoThuLao = (Convert.IsDBNull(dataRow["TenHeSoThuLao"]))?string.Empty:(System.String)dataRow["TenHeSoThuLao"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewHesoThuLaoFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHesoThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHesoThuLaoFilterBuilder : SqlFilterBuilder<ViewHesoThuLaoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHesoThuLaoFilterBuilder class.
		/// </summary>
		public ViewHesoThuLaoFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewHesoThuLaoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewHesoThuLaoFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewHesoThuLaoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewHesoThuLaoFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewHesoThuLaoFilterBuilder

	#region ViewHesoThuLaoParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHesoThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHesoThuLaoParameterBuilder : ParameterizedSqlFilterBuilder<ViewHesoThuLaoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHesoThuLaoParameterBuilder class.
		/// </summary>
		public ViewHesoThuLaoParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewHesoThuLaoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewHesoThuLaoParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewHesoThuLaoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewHesoThuLaoParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewHesoThuLaoParameterBuilder
	
	#region ViewHesoThuLaoSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHesoThuLao"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewHesoThuLaoSortBuilder : SqlSortBuilder<ViewHesoThuLaoColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHesoThuLaoSqlSortBuilder class.
		/// </summary>
		public ViewHesoThuLaoSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewHesoThuLaoSortBuilder

} // end namespace
