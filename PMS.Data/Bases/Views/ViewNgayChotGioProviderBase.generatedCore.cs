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
	/// This class is the base class for any <see cref="ViewNgayChotGioProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewNgayChotGioProviderBaseCore : EntityViewProviderBase<ViewNgayChotGio>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewNgayChotGio&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewNgayChotGio&gt;"/></returns>
		protected static VList&lt;ViewNgayChotGio&gt; Fill(DataSet dataSet, VList<ViewNgayChotGio> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewNgayChotGio>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewNgayChotGio&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewNgayChotGio>"/></returns>
		protected static VList&lt;ViewNgayChotGio&gt; Fill(DataTable dataTable, VList<ViewNgayChotGio> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewNgayChotGio c = new ViewNgayChotGio();
					c.MaCauHinhChotGio = (Convert.IsDBNull(row["MaCauHinhChotGio"]))?(int)0:(System.Int32)row["MaCauHinhChotGio"];
					c.TuNgay = (Convert.IsDBNull(row["TuNgay"]))?DateTime.MinValue:(System.DateTime?)row["TuNgay"];
					c.DenNgay = (Convert.IsDBNull(row["DenNgay"]))?DateTime.MinValue:(System.DateTime?)row["DenNgay"];
					c.TenQuanLy = (Convert.IsDBNull(row["TenQuanLy"]))?string.Empty:(System.String)row["TenQuanLy"];
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
		/// Fill an <see cref="VList&lt;ViewNgayChotGio&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewNgayChotGio&gt;"/></returns>
		protected VList<ViewNgayChotGio> Fill(IDataReader reader, VList<ViewNgayChotGio> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewNgayChotGio entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewNgayChotGio>("ViewNgayChotGio",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewNgayChotGio();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaCauHinhChotGio = (System.Int32)reader[((int)ViewNgayChotGioColumn.MaCauHinhChotGio)];
					//entity.MaCauHinhChotGio = (Convert.IsDBNull(reader["MaCauHinhChotGio"]))?(int)0:(System.Int32)reader["MaCauHinhChotGio"];
					entity.TuNgay = (reader.IsDBNull(((int)ViewNgayChotGioColumn.TuNgay)))?null:(System.DateTime?)reader[((int)ViewNgayChotGioColumn.TuNgay)];
					//entity.TuNgay = (Convert.IsDBNull(reader["TuNgay"]))?DateTime.MinValue:(System.DateTime?)reader["TuNgay"];
					entity.DenNgay = (reader.IsDBNull(((int)ViewNgayChotGioColumn.DenNgay)))?null:(System.DateTime?)reader[((int)ViewNgayChotGioColumn.DenNgay)];
					//entity.DenNgay = (Convert.IsDBNull(reader["DenNgay"]))?DateTime.MinValue:(System.DateTime?)reader["DenNgay"];
					entity.TenQuanLy = (reader.IsDBNull(((int)ViewNgayChotGioColumn.TenQuanLy)))?null:(System.String)reader[((int)ViewNgayChotGioColumn.TenQuanLy)];
					//entity.TenQuanLy = (Convert.IsDBNull(reader["TenQuanLy"]))?string.Empty:(System.String)reader["TenQuanLy"];
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
		/// Refreshes the <see cref="ViewNgayChotGio"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewNgayChotGio"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewNgayChotGio entity)
		{
			reader.Read();
			entity.MaCauHinhChotGio = (System.Int32)reader[((int)ViewNgayChotGioColumn.MaCauHinhChotGio)];
			//entity.MaCauHinhChotGio = (Convert.IsDBNull(reader["MaCauHinhChotGio"]))?(int)0:(System.Int32)reader["MaCauHinhChotGio"];
			entity.TuNgay = (reader.IsDBNull(((int)ViewNgayChotGioColumn.TuNgay)))?null:(System.DateTime?)reader[((int)ViewNgayChotGioColumn.TuNgay)];
			//entity.TuNgay = (Convert.IsDBNull(reader["TuNgay"]))?DateTime.MinValue:(System.DateTime?)reader["TuNgay"];
			entity.DenNgay = (reader.IsDBNull(((int)ViewNgayChotGioColumn.DenNgay)))?null:(System.DateTime?)reader[((int)ViewNgayChotGioColumn.DenNgay)];
			//entity.DenNgay = (Convert.IsDBNull(reader["DenNgay"]))?DateTime.MinValue:(System.DateTime?)reader["DenNgay"];
			entity.TenQuanLy = (reader.IsDBNull(((int)ViewNgayChotGioColumn.TenQuanLy)))?null:(System.String)reader[((int)ViewNgayChotGioColumn.TenQuanLy)];
			//entity.TenQuanLy = (Convert.IsDBNull(reader["TenQuanLy"]))?string.Empty:(System.String)reader["TenQuanLy"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewNgayChotGio"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewNgayChotGio"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewNgayChotGio entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaCauHinhChotGio = (Convert.IsDBNull(dataRow["MaCauHinhChotGio"]))?(int)0:(System.Int32)dataRow["MaCauHinhChotGio"];
			entity.TuNgay = (Convert.IsDBNull(dataRow["TuNgay"]))?DateTime.MinValue:(System.DateTime?)dataRow["TuNgay"];
			entity.DenNgay = (Convert.IsDBNull(dataRow["DenNgay"]))?DateTime.MinValue:(System.DateTime?)dataRow["DenNgay"];
			entity.TenQuanLy = (Convert.IsDBNull(dataRow["TenQuanLy"]))?string.Empty:(System.String)dataRow["TenQuanLy"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewNgayChotGioFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewNgayChotGio"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewNgayChotGioFilterBuilder : SqlFilterBuilder<ViewNgayChotGioColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewNgayChotGioFilterBuilder class.
		/// </summary>
		public ViewNgayChotGioFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewNgayChotGioFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewNgayChotGioFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewNgayChotGioFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewNgayChotGioFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewNgayChotGioFilterBuilder

	#region ViewNgayChotGioParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewNgayChotGio"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewNgayChotGioParameterBuilder : ParameterizedSqlFilterBuilder<ViewNgayChotGioColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewNgayChotGioParameterBuilder class.
		/// </summary>
		public ViewNgayChotGioParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewNgayChotGioParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewNgayChotGioParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewNgayChotGioParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewNgayChotGioParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewNgayChotGioParameterBuilder
	
	#region ViewNgayChotGioSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewNgayChotGio"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewNgayChotGioSortBuilder : SqlSortBuilder<ViewNgayChotGioColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewNgayChotGioSqlSortBuilder class.
		/// </summary>
		public ViewNgayChotGioSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewNgayChotGioSortBuilder

} // end namespace
