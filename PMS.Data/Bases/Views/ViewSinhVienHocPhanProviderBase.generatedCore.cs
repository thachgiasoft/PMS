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
	/// This class is the base class for any <see cref="ViewSinhVienHocPhanProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewSinhVienHocPhanProviderBaseCore : EntityViewProviderBase<ViewSinhVienHocPhan>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewSinhVienHocPhan&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewSinhVienHocPhan&gt;"/></returns>
		protected static VList&lt;ViewSinhVienHocPhan&gt; Fill(DataSet dataSet, VList<ViewSinhVienHocPhan> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewSinhVienHocPhan>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewSinhVienHocPhan&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewSinhVienHocPhan>"/></returns>
		protected static VList&lt;ViewSinhVienHocPhan&gt; Fill(DataTable dataTable, VList<ViewSinhVienHocPhan> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewSinhVienHocPhan c = new ViewSinhVienHocPhan();
					c.MaLopHocPhan = (Convert.IsDBNull(row["MaLopHocPhan"]))?string.Empty:(System.String)row["MaLopHocPhan"];
					c.SoLuong = (Convert.IsDBNull(row["SoLuong"]))?(int)0:(System.Int32?)row["SoLuong"];
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
		/// Fill an <see cref="VList&lt;ViewSinhVienHocPhan&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewSinhVienHocPhan&gt;"/></returns>
		protected VList<ViewSinhVienHocPhan> Fill(IDataReader reader, VList<ViewSinhVienHocPhan> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewSinhVienHocPhan entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewSinhVienHocPhan>("ViewSinhVienHocPhan",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewSinhVienHocPhan();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaLopHocPhan = (System.String)reader["MaLopHocPhan"];
					//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
					entity.SoLuong = reader.IsDBNull(reader.GetOrdinal("SoLuong")) ? null : (System.Int32?)reader["SoLuong"];
					//entity.SoLuong = (Convert.IsDBNull(reader["SoLuong"]))?(int)0:(System.Int32?)reader["SoLuong"];
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
		/// Refreshes the <see cref="ViewSinhVienHocPhan"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewSinhVienHocPhan"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewSinhVienHocPhan entity)
		{
			reader.Read();
			entity.MaLopHocPhan = (System.String)reader["MaLopHocPhan"];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			entity.SoLuong = reader.IsDBNull(reader.GetOrdinal("SoLuong")) ? null : (System.Int32?)reader["SoLuong"];
			//entity.SoLuong = (Convert.IsDBNull(reader["SoLuong"]))?(int)0:(System.Int32?)reader["SoLuong"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewSinhVienHocPhan"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewSinhVienHocPhan"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewSinhVienHocPhan entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaLopHocPhan = (Convert.IsDBNull(dataRow["MaLopHocPhan"]))?string.Empty:(System.String)dataRow["MaLopHocPhan"];
			entity.SoLuong = (Convert.IsDBNull(dataRow["SoLuong"]))?(int)0:(System.Int32?)dataRow["SoLuong"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewSinhVienHocPhanFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewSinhVienHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewSinhVienHocPhanFilterBuilder : SqlFilterBuilder<ViewSinhVienHocPhanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewSinhVienHocPhanFilterBuilder class.
		/// </summary>
		public ViewSinhVienHocPhanFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewSinhVienHocPhanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewSinhVienHocPhanFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewSinhVienHocPhanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewSinhVienHocPhanFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewSinhVienHocPhanFilterBuilder

	#region ViewSinhVienHocPhanParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewSinhVienHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewSinhVienHocPhanParameterBuilder : ParameterizedSqlFilterBuilder<ViewSinhVienHocPhanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewSinhVienHocPhanParameterBuilder class.
		/// </summary>
		public ViewSinhVienHocPhanParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewSinhVienHocPhanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewSinhVienHocPhanParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewSinhVienHocPhanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewSinhVienHocPhanParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewSinhVienHocPhanParameterBuilder
	
	#region ViewSinhVienHocPhanSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewSinhVienHocPhan"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewSinhVienHocPhanSortBuilder : SqlSortBuilder<ViewSinhVienHocPhanColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewSinhVienHocPhanSqlSortBuilder class.
		/// </summary>
		public ViewSinhVienHocPhanSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewSinhVienHocPhanSortBuilder

} // end namespace
