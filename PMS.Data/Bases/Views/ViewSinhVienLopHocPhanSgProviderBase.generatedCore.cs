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
	/// This class is the base class for any <see cref="ViewSinhVienLopHocPhanSgProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewSinhVienLopHocPhanSgProviderBaseCore : EntityViewProviderBase<ViewSinhVienLopHocPhanSg>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewSinhVienLopHocPhanSg&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewSinhVienLopHocPhanSg&gt;"/></returns>
		protected static VList&lt;ViewSinhVienLopHocPhanSg&gt; Fill(DataSet dataSet, VList<ViewSinhVienLopHocPhanSg> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewSinhVienLopHocPhanSg>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewSinhVienLopHocPhanSg&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewSinhVienLopHocPhanSg>"/></returns>
		protected static VList&lt;ViewSinhVienLopHocPhanSg&gt; Fill(DataTable dataTable, VList<ViewSinhVienLopHocPhanSg> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewSinhVienLopHocPhanSg c = new ViewSinhVienLopHocPhanSg();
					c.MaLop = (Convert.IsDBNull(row["MaLop"]))?string.Empty:(System.String)row["MaLop"];
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
		/// Fill an <see cref="VList&lt;ViewSinhVienLopHocPhanSg&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewSinhVienLopHocPhanSg&gt;"/></returns>
		protected VList<ViewSinhVienLopHocPhanSg> Fill(IDataReader reader, VList<ViewSinhVienLopHocPhanSg> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewSinhVienLopHocPhanSg entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewSinhVienLopHocPhanSg>("ViewSinhVienLopHocPhanSg",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewSinhVienLopHocPhanSg();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaLop = (System.String)reader["MaLop"];
					//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
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
		/// Refreshes the <see cref="ViewSinhVienLopHocPhanSg"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewSinhVienLopHocPhanSg"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewSinhVienLopHocPhanSg entity)
		{
			reader.Read();
			entity.MaLop = (System.String)reader["MaLop"];
			//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
			entity.MaLopHocPhan = (System.String)reader["MaLopHocPhan"];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			entity.SoLuong = reader.IsDBNull(reader.GetOrdinal("SoLuong")) ? null : (System.Int32?)reader["SoLuong"];
			//entity.SoLuong = (Convert.IsDBNull(reader["SoLuong"]))?(int)0:(System.Int32?)reader["SoLuong"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewSinhVienLopHocPhanSg"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewSinhVienLopHocPhanSg"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewSinhVienLopHocPhanSg entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaLop = (Convert.IsDBNull(dataRow["MaLop"]))?string.Empty:(System.String)dataRow["MaLop"];
			entity.MaLopHocPhan = (Convert.IsDBNull(dataRow["MaLopHocPhan"]))?string.Empty:(System.String)dataRow["MaLopHocPhan"];
			entity.SoLuong = (Convert.IsDBNull(dataRow["SoLuong"]))?(int)0:(System.Int32?)dataRow["SoLuong"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewSinhVienLopHocPhanSgFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewSinhVienLopHocPhanSg"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewSinhVienLopHocPhanSgFilterBuilder : SqlFilterBuilder<ViewSinhVienLopHocPhanSgColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewSinhVienLopHocPhanSgFilterBuilder class.
		/// </summary>
		public ViewSinhVienLopHocPhanSgFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewSinhVienLopHocPhanSgFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewSinhVienLopHocPhanSgFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewSinhVienLopHocPhanSgFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewSinhVienLopHocPhanSgFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewSinhVienLopHocPhanSgFilterBuilder

	#region ViewSinhVienLopHocPhanSgParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewSinhVienLopHocPhanSg"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewSinhVienLopHocPhanSgParameterBuilder : ParameterizedSqlFilterBuilder<ViewSinhVienLopHocPhanSgColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewSinhVienLopHocPhanSgParameterBuilder class.
		/// </summary>
		public ViewSinhVienLopHocPhanSgParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewSinhVienLopHocPhanSgParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewSinhVienLopHocPhanSgParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewSinhVienLopHocPhanSgParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewSinhVienLopHocPhanSgParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewSinhVienLopHocPhanSgParameterBuilder
	
	#region ViewSinhVienLopHocPhanSgSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewSinhVienLopHocPhanSg"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewSinhVienLopHocPhanSgSortBuilder : SqlSortBuilder<ViewSinhVienLopHocPhanSgColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewSinhVienLopHocPhanSgSqlSortBuilder class.
		/// </summary>
		public ViewSinhVienLopHocPhanSgSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewSinhVienLopHocPhanSgSortBuilder

} // end namespace
