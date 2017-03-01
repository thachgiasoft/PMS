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
	/// This class is the base class for any <see cref="VwThongKeHoSoDaNopChuaNopTongHoSoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class VwThongKeHoSoDaNopChuaNopTongHoSoProviderBaseCore : EntityViewProviderBase<VwThongKeHoSoDaNopChuaNopTongHoSo>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;VwThongKeHoSoDaNopChuaNopTongHoSo&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;VwThongKeHoSoDaNopChuaNopTongHoSo&gt;"/></returns>
		protected static VList&lt;VwThongKeHoSoDaNopChuaNopTongHoSo&gt; Fill(DataSet dataSet, VList<VwThongKeHoSoDaNopChuaNopTongHoSo> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<VwThongKeHoSoDaNopChuaNopTongHoSo>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;VwThongKeHoSoDaNopChuaNopTongHoSo&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<VwThongKeHoSoDaNopChuaNopTongHoSo>"/></returns>
		protected static VList&lt;VwThongKeHoSoDaNopChuaNopTongHoSo&gt; Fill(DataTable dataTable, VList<VwThongKeHoSoDaNopChuaNopTongHoSo> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					VwThongKeHoSoDaNopChuaNopTongHoSo c = new VwThongKeHoSoDaNopChuaNopTongHoSo();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32)row["MaGiangVien"];
					c.MaGiangVienQuanLy = (Convert.IsDBNull(row["MaGiangVienQuanLy"]))?string.Empty:(System.String)row["MaGiangVienQuanLy"];
					c.MaHoSoDaNop = (Convert.IsDBNull(row["MaHoSoDaNop"]))?string.Empty:(System.String)row["MaHoSoDaNop"];
					c.MaHoSoChuaNop = (Convert.IsDBNull(row["MaHoSoChuaNop"]))?string.Empty:(System.String)row["MaHoSoChuaNop"];
					c.MaTongHoSo = (Convert.IsDBNull(row["MaTongHoSo"]))?string.Empty:(System.String)row["MaTongHoSo"];
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
		/// Fill an <see cref="VList&lt;VwThongKeHoSoDaNopChuaNopTongHoSo&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;VwThongKeHoSoDaNopChuaNopTongHoSo&gt;"/></returns>
		protected VList<VwThongKeHoSoDaNopChuaNopTongHoSo> Fill(IDataReader reader, VList<VwThongKeHoSoDaNopChuaNopTongHoSo> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					VwThongKeHoSoDaNopChuaNopTongHoSo entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<VwThongKeHoSoDaNopChuaNopTongHoSo>("VwThongKeHoSoDaNopChuaNopTongHoSo",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new VwThongKeHoSoDaNopChuaNopTongHoSo();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = (System.Int32)reader[((int)VwThongKeHoSoDaNopChuaNopTongHoSoColumn.MaGiangVien)];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
					entity.MaGiangVienQuanLy = (System.String)reader[((int)VwThongKeHoSoDaNopChuaNopTongHoSoColumn.MaGiangVienQuanLy)];
					//entity.MaGiangVienQuanLy = (Convert.IsDBNull(reader["MaGiangVienQuanLy"]))?string.Empty:(System.String)reader["MaGiangVienQuanLy"];
					entity.MaHoSoDaNop = (reader.IsDBNull(((int)VwThongKeHoSoDaNopChuaNopTongHoSoColumn.MaHoSoDaNop)))?null:(System.String)reader[((int)VwThongKeHoSoDaNopChuaNopTongHoSoColumn.MaHoSoDaNop)];
					//entity.MaHoSoDaNop = (Convert.IsDBNull(reader["MaHoSoDaNop"]))?string.Empty:(System.String)reader["MaHoSoDaNop"];
					entity.MaHoSoChuaNop = (reader.IsDBNull(((int)VwThongKeHoSoDaNopChuaNopTongHoSoColumn.MaHoSoChuaNop)))?null:(System.String)reader[((int)VwThongKeHoSoDaNopChuaNopTongHoSoColumn.MaHoSoChuaNop)];
					//entity.MaHoSoChuaNop = (Convert.IsDBNull(reader["MaHoSoChuaNop"]))?string.Empty:(System.String)reader["MaHoSoChuaNop"];
					entity.MaTongHoSo = (reader.IsDBNull(((int)VwThongKeHoSoDaNopChuaNopTongHoSoColumn.MaTongHoSo)))?null:(System.String)reader[((int)VwThongKeHoSoDaNopChuaNopTongHoSoColumn.MaTongHoSo)];
					//entity.MaTongHoSo = (Convert.IsDBNull(reader["MaTongHoSo"]))?string.Empty:(System.String)reader["MaTongHoSo"];
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
		/// Refreshes the <see cref="VwThongKeHoSoDaNopChuaNopTongHoSo"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="VwThongKeHoSoDaNopChuaNopTongHoSo"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, VwThongKeHoSoDaNopChuaNopTongHoSo entity)
		{
			reader.Read();
			entity.MaGiangVien = (System.Int32)reader[((int)VwThongKeHoSoDaNopChuaNopTongHoSoColumn.MaGiangVien)];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
			entity.MaGiangVienQuanLy = (System.String)reader[((int)VwThongKeHoSoDaNopChuaNopTongHoSoColumn.MaGiangVienQuanLy)];
			//entity.MaGiangVienQuanLy = (Convert.IsDBNull(reader["MaGiangVienQuanLy"]))?string.Empty:(System.String)reader["MaGiangVienQuanLy"];
			entity.MaHoSoDaNop = (reader.IsDBNull(((int)VwThongKeHoSoDaNopChuaNopTongHoSoColumn.MaHoSoDaNop)))?null:(System.String)reader[((int)VwThongKeHoSoDaNopChuaNopTongHoSoColumn.MaHoSoDaNop)];
			//entity.MaHoSoDaNop = (Convert.IsDBNull(reader["MaHoSoDaNop"]))?string.Empty:(System.String)reader["MaHoSoDaNop"];
			entity.MaHoSoChuaNop = (reader.IsDBNull(((int)VwThongKeHoSoDaNopChuaNopTongHoSoColumn.MaHoSoChuaNop)))?null:(System.String)reader[((int)VwThongKeHoSoDaNopChuaNopTongHoSoColumn.MaHoSoChuaNop)];
			//entity.MaHoSoChuaNop = (Convert.IsDBNull(reader["MaHoSoChuaNop"]))?string.Empty:(System.String)reader["MaHoSoChuaNop"];
			entity.MaTongHoSo = (reader.IsDBNull(((int)VwThongKeHoSoDaNopChuaNopTongHoSoColumn.MaTongHoSo)))?null:(System.String)reader[((int)VwThongKeHoSoDaNopChuaNopTongHoSoColumn.MaTongHoSo)];
			//entity.MaTongHoSo = (Convert.IsDBNull(reader["MaTongHoSo"]))?string.Empty:(System.String)reader["MaTongHoSo"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="VwThongKeHoSoDaNopChuaNopTongHoSo"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="VwThongKeHoSoDaNopChuaNopTongHoSo"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, VwThongKeHoSoDaNopChuaNopTongHoSo entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32)dataRow["MaGiangVien"];
			entity.MaGiangVienQuanLy = (Convert.IsDBNull(dataRow["MaGiangVienQuanLy"]))?string.Empty:(System.String)dataRow["MaGiangVienQuanLy"];
			entity.MaHoSoDaNop = (Convert.IsDBNull(dataRow["MaHoSoDaNop"]))?string.Empty:(System.String)dataRow["MaHoSoDaNop"];
			entity.MaHoSoChuaNop = (Convert.IsDBNull(dataRow["MaHoSoChuaNop"]))?string.Empty:(System.String)dataRow["MaHoSoChuaNop"];
			entity.MaTongHoSo = (Convert.IsDBNull(dataRow["MaTongHoSo"]))?string.Empty:(System.String)dataRow["MaTongHoSo"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region VwThongKeHoSoDaNopChuaNopTongHoSoFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwThongKeHoSoDaNopChuaNopTongHoSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VwThongKeHoSoDaNopChuaNopTongHoSoFilterBuilder : SqlFilterBuilder<VwThongKeHoSoDaNopChuaNopTongHoSoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwThongKeHoSoDaNopChuaNopTongHoSoFilterBuilder class.
		/// </summary>
		public VwThongKeHoSoDaNopChuaNopTongHoSoFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VwThongKeHoSoDaNopChuaNopTongHoSoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VwThongKeHoSoDaNopChuaNopTongHoSoFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VwThongKeHoSoDaNopChuaNopTongHoSoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VwThongKeHoSoDaNopChuaNopTongHoSoFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VwThongKeHoSoDaNopChuaNopTongHoSoFilterBuilder

	#region VwThongKeHoSoDaNopChuaNopTongHoSoParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwThongKeHoSoDaNopChuaNopTongHoSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VwThongKeHoSoDaNopChuaNopTongHoSoParameterBuilder : ParameterizedSqlFilterBuilder<VwThongKeHoSoDaNopChuaNopTongHoSoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwThongKeHoSoDaNopChuaNopTongHoSoParameterBuilder class.
		/// </summary>
		public VwThongKeHoSoDaNopChuaNopTongHoSoParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VwThongKeHoSoDaNopChuaNopTongHoSoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VwThongKeHoSoDaNopChuaNopTongHoSoParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VwThongKeHoSoDaNopChuaNopTongHoSoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VwThongKeHoSoDaNopChuaNopTongHoSoParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VwThongKeHoSoDaNopChuaNopTongHoSoParameterBuilder
	
	#region VwThongKeHoSoDaNopChuaNopTongHoSoSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwThongKeHoSoDaNopChuaNopTongHoSo"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class VwThongKeHoSoDaNopChuaNopTongHoSoSortBuilder : SqlSortBuilder<VwThongKeHoSoDaNopChuaNopTongHoSoColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwThongKeHoSoDaNopChuaNopTongHoSoSqlSortBuilder class.
		/// </summary>
		public VwThongKeHoSoDaNopChuaNopTongHoSoSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion VwThongKeHoSoDaNopChuaNopTongHoSoSortBuilder

} // end namespace
