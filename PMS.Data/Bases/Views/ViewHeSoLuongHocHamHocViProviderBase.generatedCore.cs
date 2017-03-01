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
	/// This class is the base class for any <see cref="ViewHeSoLuongHocHamHocViProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewHeSoLuongHocHamHocViProviderBaseCore : EntityViewProviderBase<ViewHeSoLuongHocHamHocVi>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewHeSoLuongHocHamHocVi&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewHeSoLuongHocHamHocVi&gt;"/></returns>
		protected static VList&lt;ViewHeSoLuongHocHamHocVi&gt; Fill(DataSet dataSet, VList<ViewHeSoLuongHocHamHocVi> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewHeSoLuongHocHamHocVi>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewHeSoLuongHocHamHocVi&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewHeSoLuongHocHamHocVi>"/></returns>
		protected static VList&lt;ViewHeSoLuongHocHamHocVi&gt; Fill(DataTable dataTable, VList<ViewHeSoLuongHocHamHocVi> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewHeSoLuongHocHamHocVi c = new ViewHeSoLuongHocHamHocVi();
					c.MaHeSoLuong = (Convert.IsDBNull(row["MaHeSoLuong"]))?string.Empty:(System.String)row["MaHeSoLuong"];
					c.TenHeSoLuong = (Convert.IsDBNull(row["TenHeSoLuong"]))?string.Empty:(System.String)row["TenHeSoLuong"];
					c.HeSoLuong = (Convert.IsDBNull(row["HeSoLuong"]))?0.0m:(System.Decimal)row["HeSoLuong"];
					c.MaHocVi = (Convert.IsDBNull(row["MaHocVi"]))?string.Empty:(System.String)row["MaHocVi"];
					c.TenHocVi = (Convert.IsDBNull(row["TenHocVi"]))?string.Empty:(System.String)row["TenHocVi"];
					c.MaHocHam = (Convert.IsDBNull(row["MaHocHam"]))?string.Empty:(System.String)row["MaHocHam"];
					c.TenHocHam = (Convert.IsDBNull(row["TenHocHam"]))?string.Empty:(System.String)row["TenHocHam"];
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
		/// Fill an <see cref="VList&lt;ViewHeSoLuongHocHamHocVi&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewHeSoLuongHocHamHocVi&gt;"/></returns>
		protected VList<ViewHeSoLuongHocHamHocVi> Fill(IDataReader reader, VList<ViewHeSoLuongHocHamHocVi> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewHeSoLuongHocHamHocVi entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewHeSoLuongHocHamHocVi>("ViewHeSoLuongHocHamHocVi",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewHeSoLuongHocHamHocVi();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaHeSoLuong = (System.String)reader["MaHeSoLuong"];
					//entity.MaHeSoLuong = (Convert.IsDBNull(reader["MaHeSoLuong"]))?string.Empty:(System.String)reader["MaHeSoLuong"];
					entity.TenHeSoLuong = (System.String)reader["TenHeSoLuong"];
					//entity.TenHeSoLuong = (Convert.IsDBNull(reader["TenHeSoLuong"]))?string.Empty:(System.String)reader["TenHeSoLuong"];
					entity.HeSoLuong = (System.Decimal)reader["HeSoLuong"];
					//entity.HeSoLuong = (Convert.IsDBNull(reader["HeSoLuong"]))?0.0m:(System.Decimal)reader["HeSoLuong"];
					entity.MaHocVi = reader.IsDBNull(reader.GetOrdinal("MaHocVi")) ? null : (System.String)reader["MaHocVi"];
					//entity.MaHocVi = (Convert.IsDBNull(reader["MaHocVi"]))?string.Empty:(System.String)reader["MaHocVi"];
					entity.TenHocVi = reader.IsDBNull(reader.GetOrdinal("TenHocVi")) ? null : (System.String)reader["TenHocVi"];
					//entity.TenHocVi = (Convert.IsDBNull(reader["TenHocVi"]))?string.Empty:(System.String)reader["TenHocVi"];
					entity.MaHocHam = reader.IsDBNull(reader.GetOrdinal("MaHocHam")) ? null : (System.String)reader["MaHocHam"];
					//entity.MaHocHam = (Convert.IsDBNull(reader["MaHocHam"]))?string.Empty:(System.String)reader["MaHocHam"];
					entity.TenHocHam = reader.IsDBNull(reader.GetOrdinal("TenHocHam")) ? null : (System.String)reader["TenHocHam"];
					//entity.TenHocHam = (Convert.IsDBNull(reader["TenHocHam"]))?string.Empty:(System.String)reader["TenHocHam"];
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
		/// Refreshes the <see cref="ViewHeSoLuongHocHamHocVi"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewHeSoLuongHocHamHocVi"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewHeSoLuongHocHamHocVi entity)
		{
			reader.Read();
			entity.MaHeSoLuong = (System.String)reader["MaHeSoLuong"];
			//entity.MaHeSoLuong = (Convert.IsDBNull(reader["MaHeSoLuong"]))?string.Empty:(System.String)reader["MaHeSoLuong"];
			entity.TenHeSoLuong = (System.String)reader["TenHeSoLuong"];
			//entity.TenHeSoLuong = (Convert.IsDBNull(reader["TenHeSoLuong"]))?string.Empty:(System.String)reader["TenHeSoLuong"];
			entity.HeSoLuong = (System.Decimal)reader["HeSoLuong"];
			//entity.HeSoLuong = (Convert.IsDBNull(reader["HeSoLuong"]))?0.0m:(System.Decimal)reader["HeSoLuong"];
			entity.MaHocVi = reader.IsDBNull(reader.GetOrdinal("MaHocVi")) ? null : (System.String)reader["MaHocVi"];
			//entity.MaHocVi = (Convert.IsDBNull(reader["MaHocVi"]))?string.Empty:(System.String)reader["MaHocVi"];
			entity.TenHocVi = reader.IsDBNull(reader.GetOrdinal("TenHocVi")) ? null : (System.String)reader["TenHocVi"];
			//entity.TenHocVi = (Convert.IsDBNull(reader["TenHocVi"]))?string.Empty:(System.String)reader["TenHocVi"];
			entity.MaHocHam = reader.IsDBNull(reader.GetOrdinal("MaHocHam")) ? null : (System.String)reader["MaHocHam"];
			//entity.MaHocHam = (Convert.IsDBNull(reader["MaHocHam"]))?string.Empty:(System.String)reader["MaHocHam"];
			entity.TenHocHam = reader.IsDBNull(reader.GetOrdinal("TenHocHam")) ? null : (System.String)reader["TenHocHam"];
			//entity.TenHocHam = (Convert.IsDBNull(reader["TenHocHam"]))?string.Empty:(System.String)reader["TenHocHam"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewHeSoLuongHocHamHocVi"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewHeSoLuongHocHamHocVi"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewHeSoLuongHocHamHocVi entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaHeSoLuong = (Convert.IsDBNull(dataRow["MaHeSoLuong"]))?string.Empty:(System.String)dataRow["MaHeSoLuong"];
			entity.TenHeSoLuong = (Convert.IsDBNull(dataRow["TenHeSoLuong"]))?string.Empty:(System.String)dataRow["TenHeSoLuong"];
			entity.HeSoLuong = (Convert.IsDBNull(dataRow["HeSoLuong"]))?0.0m:(System.Decimal)dataRow["HeSoLuong"];
			entity.MaHocVi = (Convert.IsDBNull(dataRow["MaHocVi"]))?string.Empty:(System.String)dataRow["MaHocVi"];
			entity.TenHocVi = (Convert.IsDBNull(dataRow["TenHocVi"]))?string.Empty:(System.String)dataRow["TenHocVi"];
			entity.MaHocHam = (Convert.IsDBNull(dataRow["MaHocHam"]))?string.Empty:(System.String)dataRow["MaHocHam"];
			entity.TenHocHam = (Convert.IsDBNull(dataRow["TenHocHam"]))?string.Empty:(System.String)dataRow["TenHocHam"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewHeSoLuongHocHamHocViFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHeSoLuongHocHamHocVi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHeSoLuongHocHamHocViFilterBuilder : SqlFilterBuilder<ViewHeSoLuongHocHamHocViColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHeSoLuongHocHamHocViFilterBuilder class.
		/// </summary>
		public ViewHeSoLuongHocHamHocViFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewHeSoLuongHocHamHocViFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewHeSoLuongHocHamHocViFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewHeSoLuongHocHamHocViFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewHeSoLuongHocHamHocViFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewHeSoLuongHocHamHocViFilterBuilder

	#region ViewHeSoLuongHocHamHocViParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHeSoLuongHocHamHocVi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHeSoLuongHocHamHocViParameterBuilder : ParameterizedSqlFilterBuilder<ViewHeSoLuongHocHamHocViColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHeSoLuongHocHamHocViParameterBuilder class.
		/// </summary>
		public ViewHeSoLuongHocHamHocViParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewHeSoLuongHocHamHocViParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewHeSoLuongHocHamHocViParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewHeSoLuongHocHamHocViParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewHeSoLuongHocHamHocViParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewHeSoLuongHocHamHocViParameterBuilder
	
	#region ViewHeSoLuongHocHamHocViSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHeSoLuongHocHamHocVi"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewHeSoLuongHocHamHocViSortBuilder : SqlSortBuilder<ViewHeSoLuongHocHamHocViColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHeSoLuongHocHamHocViSqlSortBuilder class.
		/// </summary>
		public ViewHeSoLuongHocHamHocViSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewHeSoLuongHocHamHocViSortBuilder

} // end namespace
