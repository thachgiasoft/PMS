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
	/// This class is the base class for any <see cref="ViewLoaiHocPhanProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewLoaiHocPhanProviderBaseCore : EntityViewProviderBase<ViewLoaiHocPhan>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewLoaiHocPhan&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewLoaiHocPhan&gt;"/></returns>
		protected static VList&lt;ViewLoaiHocPhan&gt; Fill(DataSet dataSet, VList<ViewLoaiHocPhan> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewLoaiHocPhan>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewLoaiHocPhan&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewLoaiHocPhan>"/></returns>
		protected static VList&lt;ViewLoaiHocPhan&gt; Fill(DataTable dataTable, VList<ViewLoaiHocPhan> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewLoaiHocPhan c = new ViewLoaiHocPhan();
					c.MaLoaiHocPhan = (Convert.IsDBNull(row["MaLoaiHocPhan"]))?(byte)0:(System.Byte)row["MaLoaiHocPhan"];
					c.TenLoaiHocPhan = (Convert.IsDBNull(row["TenLoaiHocPhan"]))?string.Empty:(System.String)row["TenLoaiHocPhan"];
					c.VietTat = (Convert.IsDBNull(row["VietTat"]))?string.Empty:(System.String)row["VietTat"];
					c.DonViTinh = (Convert.IsDBNull(row["DonViTinh"]))?string.Empty:(System.String)row["DonViTinh"];
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
		/// Fill an <see cref="VList&lt;ViewLoaiHocPhan&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewLoaiHocPhan&gt;"/></returns>
		protected VList<ViewLoaiHocPhan> Fill(IDataReader reader, VList<ViewLoaiHocPhan> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewLoaiHocPhan entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewLoaiHocPhan>("ViewLoaiHocPhan",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewLoaiHocPhan();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaLoaiHocPhan = (System.Byte)reader["MaLoaiHocPhan"];
					//entity.MaLoaiHocPhan = (Convert.IsDBNull(reader["MaLoaiHocPhan"]))?(byte)0:(System.Byte)reader["MaLoaiHocPhan"];
					entity.TenLoaiHocPhan = (System.String)reader["TenLoaiHocPhan"];
					//entity.TenLoaiHocPhan = (Convert.IsDBNull(reader["TenLoaiHocPhan"]))?string.Empty:(System.String)reader["TenLoaiHocPhan"];
					entity.VietTat = reader.IsDBNull(reader.GetOrdinal("VietTat")) ? null : (System.String)reader["VietTat"];
					//entity.VietTat = (Convert.IsDBNull(reader["VietTat"]))?string.Empty:(System.String)reader["VietTat"];
					entity.DonViTinh = reader.IsDBNull(reader.GetOrdinal("DonViTinh")) ? null : (System.String)reader["DonViTinh"];
					//entity.DonViTinh = (Convert.IsDBNull(reader["DonViTinh"]))?string.Empty:(System.String)reader["DonViTinh"];
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
		/// Refreshes the <see cref="ViewLoaiHocPhan"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewLoaiHocPhan"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewLoaiHocPhan entity)
		{
			reader.Read();
			entity.MaLoaiHocPhan = (System.Byte)reader["MaLoaiHocPhan"];
			//entity.MaLoaiHocPhan = (Convert.IsDBNull(reader["MaLoaiHocPhan"]))?(byte)0:(System.Byte)reader["MaLoaiHocPhan"];
			entity.TenLoaiHocPhan = (System.String)reader["TenLoaiHocPhan"];
			//entity.TenLoaiHocPhan = (Convert.IsDBNull(reader["TenLoaiHocPhan"]))?string.Empty:(System.String)reader["TenLoaiHocPhan"];
			entity.VietTat = reader.IsDBNull(reader.GetOrdinal("VietTat")) ? null : (System.String)reader["VietTat"];
			//entity.VietTat = (Convert.IsDBNull(reader["VietTat"]))?string.Empty:(System.String)reader["VietTat"];
			entity.DonViTinh = reader.IsDBNull(reader.GetOrdinal("DonViTinh")) ? null : (System.String)reader["DonViTinh"];
			//entity.DonViTinh = (Convert.IsDBNull(reader["DonViTinh"]))?string.Empty:(System.String)reader["DonViTinh"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewLoaiHocPhan"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewLoaiHocPhan"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewLoaiHocPhan entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaLoaiHocPhan = (Convert.IsDBNull(dataRow["MaLoaiHocPhan"]))?(byte)0:(System.Byte)dataRow["MaLoaiHocPhan"];
			entity.TenLoaiHocPhan = (Convert.IsDBNull(dataRow["TenLoaiHocPhan"]))?string.Empty:(System.String)dataRow["TenLoaiHocPhan"];
			entity.VietTat = (Convert.IsDBNull(dataRow["VietTat"]))?string.Empty:(System.String)dataRow["VietTat"];
			entity.DonViTinh = (Convert.IsDBNull(dataRow["DonViTinh"]))?string.Empty:(System.String)dataRow["DonViTinh"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewLoaiHocPhanFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLoaiHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLoaiHocPhanFilterBuilder : SqlFilterBuilder<ViewLoaiHocPhanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLoaiHocPhanFilterBuilder class.
		/// </summary>
		public ViewLoaiHocPhanFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewLoaiHocPhanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewLoaiHocPhanFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewLoaiHocPhanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewLoaiHocPhanFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewLoaiHocPhanFilterBuilder

	#region ViewLoaiHocPhanParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLoaiHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLoaiHocPhanParameterBuilder : ParameterizedSqlFilterBuilder<ViewLoaiHocPhanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLoaiHocPhanParameterBuilder class.
		/// </summary>
		public ViewLoaiHocPhanParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewLoaiHocPhanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewLoaiHocPhanParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewLoaiHocPhanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewLoaiHocPhanParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewLoaiHocPhanParameterBuilder
	
	#region ViewLoaiHocPhanSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLoaiHocPhan"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewLoaiHocPhanSortBuilder : SqlSortBuilder<ViewLoaiHocPhanColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLoaiHocPhanSqlSortBuilder class.
		/// </summary>
		public ViewLoaiHocPhanSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewLoaiHocPhanSortBuilder

} // end namespace
