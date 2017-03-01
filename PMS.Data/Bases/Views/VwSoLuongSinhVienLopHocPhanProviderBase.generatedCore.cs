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
	/// This class is the base class for any <see cref="VwSoLuongSinhVienLopHocPhanProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class VwSoLuongSinhVienLopHocPhanProviderBaseCore : EntityViewProviderBase<VwSoLuongSinhVienLopHocPhan>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;VwSoLuongSinhVienLopHocPhan&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;VwSoLuongSinhVienLopHocPhan&gt;"/></returns>
		protected static VList&lt;VwSoLuongSinhVienLopHocPhan&gt; Fill(DataSet dataSet, VList<VwSoLuongSinhVienLopHocPhan> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<VwSoLuongSinhVienLopHocPhan>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;VwSoLuongSinhVienLopHocPhan&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<VwSoLuongSinhVienLopHocPhan>"/></returns>
		protected static VList&lt;VwSoLuongSinhVienLopHocPhan&gt; Fill(DataTable dataTable, VList<VwSoLuongSinhVienLopHocPhan> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					VwSoLuongSinhVienLopHocPhan c = new VwSoLuongSinhVienLopHocPhan();
					c.MaLop = (Convert.IsDBNull(row["MaLop"]))?string.Empty:(System.String)row["MaLop"];
					c.SoLuong = (Convert.IsDBNull(row["SoLuong"]))?(int)0:(System.Int32?)row["SoLuong"];
					c.MaLopHocPhan = (Convert.IsDBNull(row["MaLopHocPhan"]))?string.Empty:(System.String)row["MaLopHocPhan"];
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
		/// Fill an <see cref="VList&lt;VwSoLuongSinhVienLopHocPhan&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;VwSoLuongSinhVienLopHocPhan&gt;"/></returns>
		protected VList<VwSoLuongSinhVienLopHocPhan> Fill(IDataReader reader, VList<VwSoLuongSinhVienLopHocPhan> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					VwSoLuongSinhVienLopHocPhan entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<VwSoLuongSinhVienLopHocPhan>("VwSoLuongSinhVienLopHocPhan",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new VwSoLuongSinhVienLopHocPhan();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaLop = (System.String)reader[((int)VwSoLuongSinhVienLopHocPhanColumn.MaLop)];
					//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
					entity.SoLuong = (reader.IsDBNull(((int)VwSoLuongSinhVienLopHocPhanColumn.SoLuong)))?null:(System.Int32?)reader[((int)VwSoLuongSinhVienLopHocPhanColumn.SoLuong)];
					//entity.SoLuong = (Convert.IsDBNull(reader["SoLuong"]))?(int)0:(System.Int32?)reader["SoLuong"];
					entity.MaLopHocPhan = (System.String)reader[((int)VwSoLuongSinhVienLopHocPhanColumn.MaLopHocPhan)];
					//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
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
		/// Refreshes the <see cref="VwSoLuongSinhVienLopHocPhan"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="VwSoLuongSinhVienLopHocPhan"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, VwSoLuongSinhVienLopHocPhan entity)
		{
			reader.Read();
			entity.MaLop = (System.String)reader[((int)VwSoLuongSinhVienLopHocPhanColumn.MaLop)];
			//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
			entity.SoLuong = (reader.IsDBNull(((int)VwSoLuongSinhVienLopHocPhanColumn.SoLuong)))?null:(System.Int32?)reader[((int)VwSoLuongSinhVienLopHocPhanColumn.SoLuong)];
			//entity.SoLuong = (Convert.IsDBNull(reader["SoLuong"]))?(int)0:(System.Int32?)reader["SoLuong"];
			entity.MaLopHocPhan = (System.String)reader[((int)VwSoLuongSinhVienLopHocPhanColumn.MaLopHocPhan)];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="VwSoLuongSinhVienLopHocPhan"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="VwSoLuongSinhVienLopHocPhan"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, VwSoLuongSinhVienLopHocPhan entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaLop = (Convert.IsDBNull(dataRow["MaLop"]))?string.Empty:(System.String)dataRow["MaLop"];
			entity.SoLuong = (Convert.IsDBNull(dataRow["SoLuong"]))?(int)0:(System.Int32?)dataRow["SoLuong"];
			entity.MaLopHocPhan = (Convert.IsDBNull(dataRow["MaLopHocPhan"]))?string.Empty:(System.String)dataRow["MaLopHocPhan"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region VwSoLuongSinhVienLopHocPhanFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwSoLuongSinhVienLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VwSoLuongSinhVienLopHocPhanFilterBuilder : SqlFilterBuilder<VwSoLuongSinhVienLopHocPhanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwSoLuongSinhVienLopHocPhanFilterBuilder class.
		/// </summary>
		public VwSoLuongSinhVienLopHocPhanFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VwSoLuongSinhVienLopHocPhanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VwSoLuongSinhVienLopHocPhanFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VwSoLuongSinhVienLopHocPhanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VwSoLuongSinhVienLopHocPhanFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VwSoLuongSinhVienLopHocPhanFilterBuilder

	#region VwSoLuongSinhVienLopHocPhanParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwSoLuongSinhVienLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VwSoLuongSinhVienLopHocPhanParameterBuilder : ParameterizedSqlFilterBuilder<VwSoLuongSinhVienLopHocPhanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwSoLuongSinhVienLopHocPhanParameterBuilder class.
		/// </summary>
		public VwSoLuongSinhVienLopHocPhanParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VwSoLuongSinhVienLopHocPhanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VwSoLuongSinhVienLopHocPhanParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VwSoLuongSinhVienLopHocPhanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VwSoLuongSinhVienLopHocPhanParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VwSoLuongSinhVienLopHocPhanParameterBuilder
	
	#region VwSoLuongSinhVienLopHocPhanSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwSoLuongSinhVienLopHocPhan"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class VwSoLuongSinhVienLopHocPhanSortBuilder : SqlSortBuilder<VwSoLuongSinhVienLopHocPhanColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwSoLuongSinhVienLopHocPhanSqlSortBuilder class.
		/// </summary>
		public VwSoLuongSinhVienLopHocPhanSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion VwSoLuongSinhVienLopHocPhanSortBuilder

} // end namespace
