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
	/// This class is the base class for any <see cref="ViewCoSoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewCoSoProviderBaseCore : EntityViewProviderBase<ViewCoSo>
	{
		#region Custom Methods
		
		
		#region cust_View_CoSo_GetDayNhaByCoSo
		
		/// <summary>
		///	This method wrap the 'cust_View_CoSo_GetDayNhaByCoSo' stored procedure. 
		/// </summary>
		/// <param name="coSo"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDayNhaByCoSo(System.String coSo)
		{
			return GetDayNhaByCoSo(null, 0, int.MaxValue , coSo);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_CoSo_GetDayNhaByCoSo' stored procedure. 
		/// </summary>
		/// <param name="coSo"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDayNhaByCoSo(int start, int pageLength, System.String coSo)
		{
			return GetDayNhaByCoSo(null, start, pageLength , coSo);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_CoSo_GetDayNhaByCoSo' stored procedure. 
		/// </summary>
		/// <param name="coSo"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDayNhaByCoSo(TransactionManager transactionManager, System.String coSo)
		{
			return GetDayNhaByCoSo(transactionManager, 0, int.MaxValue , coSo);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_CoSo_GetDayNhaByCoSo' stored procedure. 
		/// </summary>
		/// <param name="coSo"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetDayNhaByCoSo(TransactionManager transactionManager, int start, int pageLength, System.String coSo);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewCoSo&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewCoSo&gt;"/></returns>
		protected static VList&lt;ViewCoSo&gt; Fill(DataSet dataSet, VList<ViewCoSo> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewCoSo>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewCoSo&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewCoSo>"/></returns>
		protected static VList&lt;ViewCoSo&gt; Fill(DataTable dataTable, VList<ViewCoSo> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewCoSo c = new ViewCoSo();
					c.MaCoSo = (Convert.IsDBNull(row["MaCoSo"]))?string.Empty:(System.String)row["MaCoSo"];
					c.TenCoSo = (Convert.IsDBNull(row["TenCoSo"]))?string.Empty:(System.String)row["TenCoSo"];
					c.DiaChi = (Convert.IsDBNull(row["DiaChi"]))?string.Empty:(System.String)row["DiaChi"];
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
		/// Fill an <see cref="VList&lt;ViewCoSo&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewCoSo&gt;"/></returns>
		protected VList<ViewCoSo> Fill(IDataReader reader, VList<ViewCoSo> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewCoSo entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewCoSo>("ViewCoSo",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewCoSo();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaCoSo = (System.String)reader["MaCoSo"];
					//entity.MaCoSo = (Convert.IsDBNull(reader["MaCoSo"]))?string.Empty:(System.String)reader["MaCoSo"];
					entity.TenCoSo = (System.String)reader["TenCoSo"];
					//entity.TenCoSo = (Convert.IsDBNull(reader["TenCoSo"]))?string.Empty:(System.String)reader["TenCoSo"];
					entity.DiaChi = reader.IsDBNull(reader.GetOrdinal("DiaChi")) ? null : (System.String)reader["DiaChi"];
					//entity.DiaChi = (Convert.IsDBNull(reader["DiaChi"]))?string.Empty:(System.String)reader["DiaChi"];
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
		/// Refreshes the <see cref="ViewCoSo"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewCoSo"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewCoSo entity)
		{
			reader.Read();
			entity.MaCoSo = (System.String)reader["MaCoSo"];
			//entity.MaCoSo = (Convert.IsDBNull(reader["MaCoSo"]))?string.Empty:(System.String)reader["MaCoSo"];
			entity.TenCoSo = (System.String)reader["TenCoSo"];
			//entity.TenCoSo = (Convert.IsDBNull(reader["TenCoSo"]))?string.Empty:(System.String)reader["TenCoSo"];
			entity.DiaChi = reader.IsDBNull(reader.GetOrdinal("DiaChi")) ? null : (System.String)reader["DiaChi"];
			//entity.DiaChi = (Convert.IsDBNull(reader["DiaChi"]))?string.Empty:(System.String)reader["DiaChi"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewCoSo"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewCoSo"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewCoSo entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaCoSo = (Convert.IsDBNull(dataRow["MaCoSo"]))?string.Empty:(System.String)dataRow["MaCoSo"];
			entity.TenCoSo = (Convert.IsDBNull(dataRow["TenCoSo"]))?string.Empty:(System.String)dataRow["TenCoSo"];
			entity.DiaChi = (Convert.IsDBNull(dataRow["DiaChi"]))?string.Empty:(System.String)dataRow["DiaChi"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewCoSoFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewCoSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewCoSoFilterBuilder : SqlFilterBuilder<ViewCoSoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewCoSoFilterBuilder class.
		/// </summary>
		public ViewCoSoFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewCoSoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewCoSoFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewCoSoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewCoSoFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewCoSoFilterBuilder

	#region ViewCoSoParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewCoSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewCoSoParameterBuilder : ParameterizedSqlFilterBuilder<ViewCoSoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewCoSoParameterBuilder class.
		/// </summary>
		public ViewCoSoParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewCoSoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewCoSoParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewCoSoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewCoSoParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewCoSoParameterBuilder
	
	#region ViewCoSoSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewCoSo"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewCoSoSortBuilder : SqlSortBuilder<ViewCoSoColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewCoSoSqlSortBuilder class.
		/// </summary>
		public ViewCoSoSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewCoSoSortBuilder

} // end namespace
