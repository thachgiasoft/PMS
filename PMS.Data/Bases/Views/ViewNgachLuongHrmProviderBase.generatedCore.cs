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
	/// This class is the base class for any <see cref="ViewNgachLuongHrmProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewNgachLuongHrmProviderBaseCore : EntityViewProviderBase<ViewNgachLuongHrm>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewNgachLuongHrm&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewNgachLuongHrm&gt;"/></returns>
		protected static VList&lt;ViewNgachLuongHrm&gt; Fill(DataSet dataSet, VList<ViewNgachLuongHrm> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewNgachLuongHrm>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewNgachLuongHrm&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewNgachLuongHrm>"/></returns>
		protected static VList&lt;ViewNgachLuongHrm&gt; Fill(DataTable dataTable, VList<ViewNgachLuongHrm> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewNgachLuongHrm c = new ViewNgachLuongHrm();
					c.MaNgach = (Convert.IsDBNull(row["MaNgach"]))?string.Empty:(System.String)row["MaNgach"];
					c.TenNgachLuong = (Convert.IsDBNull(row["TenNgachLuong"]))?string.Empty:(System.String)row["TenNgachLuong"];
					c.Oid = (Convert.IsDBNull(row["Oid"]))?Guid.Empty:(System.Guid)row["Oid"];
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
		/// Fill an <see cref="VList&lt;ViewNgachLuongHrm&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewNgachLuongHrm&gt;"/></returns>
		protected VList<ViewNgachLuongHrm> Fill(IDataReader reader, VList<ViewNgachLuongHrm> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewNgachLuongHrm entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewNgachLuongHrm>("ViewNgachLuongHrm",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewNgachLuongHrm();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaNgach = reader.IsDBNull(reader.GetOrdinal("MaNgach")) ? null : (System.String)reader["MaNgach"];
					//entity.MaNgach = (Convert.IsDBNull(reader["MaNgach"]))?string.Empty:(System.String)reader["MaNgach"];
					entity.TenNgachLuong = reader.IsDBNull(reader.GetOrdinal("TenNgachLuong")) ? null : (System.String)reader["TenNgachLuong"];
					//entity.TenNgachLuong = (Convert.IsDBNull(reader["TenNgachLuong"]))?string.Empty:(System.String)reader["TenNgachLuong"];
					entity.Oid = (System.Guid)reader["Oid"];
					//entity.Oid = (Convert.IsDBNull(reader["Oid"]))?Guid.Empty:(System.Guid)reader["Oid"];
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
		/// Refreshes the <see cref="ViewNgachLuongHrm"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewNgachLuongHrm"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewNgachLuongHrm entity)
		{
			reader.Read();
			entity.MaNgach = reader.IsDBNull(reader.GetOrdinal("MaNgach")) ? null : (System.String)reader["MaNgach"];
			//entity.MaNgach = (Convert.IsDBNull(reader["MaNgach"]))?string.Empty:(System.String)reader["MaNgach"];
			entity.TenNgachLuong = reader.IsDBNull(reader.GetOrdinal("TenNgachLuong")) ? null : (System.String)reader["TenNgachLuong"];
			//entity.TenNgachLuong = (Convert.IsDBNull(reader["TenNgachLuong"]))?string.Empty:(System.String)reader["TenNgachLuong"];
			entity.Oid = (System.Guid)reader["Oid"];
			//entity.Oid = (Convert.IsDBNull(reader["Oid"]))?Guid.Empty:(System.Guid)reader["Oid"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewNgachLuongHrm"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewNgachLuongHrm"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewNgachLuongHrm entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaNgach = (Convert.IsDBNull(dataRow["MaNgach"]))?string.Empty:(System.String)dataRow["MaNgach"];
			entity.TenNgachLuong = (Convert.IsDBNull(dataRow["TenNgachLuong"]))?string.Empty:(System.String)dataRow["TenNgachLuong"];
			entity.Oid = (Convert.IsDBNull(dataRow["Oid"]))?Guid.Empty:(System.Guid)dataRow["Oid"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewNgachLuongHrmFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewNgachLuongHrm"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewNgachLuongHrmFilterBuilder : SqlFilterBuilder<ViewNgachLuongHrmColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewNgachLuongHrmFilterBuilder class.
		/// </summary>
		public ViewNgachLuongHrmFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewNgachLuongHrmFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewNgachLuongHrmFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewNgachLuongHrmFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewNgachLuongHrmFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewNgachLuongHrmFilterBuilder

	#region ViewNgachLuongHrmParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewNgachLuongHrm"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewNgachLuongHrmParameterBuilder : ParameterizedSqlFilterBuilder<ViewNgachLuongHrmColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewNgachLuongHrmParameterBuilder class.
		/// </summary>
		public ViewNgachLuongHrmParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewNgachLuongHrmParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewNgachLuongHrmParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewNgachLuongHrmParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewNgachLuongHrmParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewNgachLuongHrmParameterBuilder
	
	#region ViewNgachLuongHrmSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewNgachLuongHrm"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewNgachLuongHrmSortBuilder : SqlSortBuilder<ViewNgachLuongHrmColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewNgachLuongHrmSqlSortBuilder class.
		/// </summary>
		public ViewNgachLuongHrmSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewNgachLuongHrmSortBuilder

} // end namespace
