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
	/// This class is the base class for any <see cref="VwThongKeHoSoDaNopChuaNopProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class VwThongKeHoSoDaNopChuaNopProviderBaseCore : EntityViewProviderBase<VwThongKeHoSoDaNopChuaNop>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;VwThongKeHoSoDaNopChuaNop&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;VwThongKeHoSoDaNopChuaNop&gt;"/></returns>
		protected static VList&lt;VwThongKeHoSoDaNopChuaNop&gt; Fill(DataSet dataSet, VList<VwThongKeHoSoDaNopChuaNop> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<VwThongKeHoSoDaNopChuaNop>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;VwThongKeHoSoDaNopChuaNop&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<VwThongKeHoSoDaNopChuaNop>"/></returns>
		protected static VList&lt;VwThongKeHoSoDaNopChuaNop&gt; Fill(DataTable dataTable, VList<VwThongKeHoSoDaNopChuaNop> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					VwThongKeHoSoDaNopChuaNop c = new VwThongKeHoSoDaNopChuaNop();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32)row["MaGiangVien"];
					c.MaGiangVienQuanLy = (Convert.IsDBNull(row["MaGiangVienQuanLy"]))?string.Empty:(System.String)row["MaGiangVienQuanLy"];
					c.MaHoSoDaNop = (Convert.IsDBNull(row["MaHoSoDaNop"]))?string.Empty:(System.String)row["MaHoSoDaNop"];
					c.TenHoSo = (Convert.IsDBNull(row["TenHoSo"]))?string.Empty:(System.String)row["TenHoSo"];
					c.MaHoSoChuaNop = (Convert.IsDBNull(row["MaHoSoChuaNop"]))?string.Empty:(System.String)row["MaHoSoChuaNop"];
					c.SoHoSo = (Convert.IsDBNull(row["SoHoSo"]))?string.Empty:(System.String)row["SoHoSo"];
					c.NgayCap = (Convert.IsDBNull(row["NgayCap"]))?string.Empty:(System.String)row["NgayCap"];
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
		/// Fill an <see cref="VList&lt;VwThongKeHoSoDaNopChuaNop&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;VwThongKeHoSoDaNopChuaNop&gt;"/></returns>
		protected VList<VwThongKeHoSoDaNopChuaNop> Fill(IDataReader reader, VList<VwThongKeHoSoDaNopChuaNop> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					VwThongKeHoSoDaNopChuaNop entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<VwThongKeHoSoDaNopChuaNop>("VwThongKeHoSoDaNopChuaNop",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new VwThongKeHoSoDaNopChuaNop();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = (System.Int32)reader[((int)VwThongKeHoSoDaNopChuaNopColumn.MaGiangVien)];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
					entity.MaGiangVienQuanLy = (System.String)reader[((int)VwThongKeHoSoDaNopChuaNopColumn.MaGiangVienQuanLy)];
					//entity.MaGiangVienQuanLy = (Convert.IsDBNull(reader["MaGiangVienQuanLy"]))?string.Empty:(System.String)reader["MaGiangVienQuanLy"];
					entity.MaHoSoDaNop = (reader.IsDBNull(((int)VwThongKeHoSoDaNopChuaNopColumn.MaHoSoDaNop)))?null:(System.String)reader[((int)VwThongKeHoSoDaNopChuaNopColumn.MaHoSoDaNop)];
					//entity.MaHoSoDaNop = (Convert.IsDBNull(reader["MaHoSoDaNop"]))?string.Empty:(System.String)reader["MaHoSoDaNop"];
					entity.TenHoSo = (reader.IsDBNull(((int)VwThongKeHoSoDaNopChuaNopColumn.TenHoSo)))?null:(System.String)reader[((int)VwThongKeHoSoDaNopChuaNopColumn.TenHoSo)];
					//entity.TenHoSo = (Convert.IsDBNull(reader["TenHoSo"]))?string.Empty:(System.String)reader["TenHoSo"];
					entity.MaHoSoChuaNop = (System.String)reader[((int)VwThongKeHoSoDaNopChuaNopColumn.MaHoSoChuaNop)];
					//entity.MaHoSoChuaNop = (Convert.IsDBNull(reader["MaHoSoChuaNop"]))?string.Empty:(System.String)reader["MaHoSoChuaNop"];
					entity.SoHoSo = (reader.IsDBNull(((int)VwThongKeHoSoDaNopChuaNopColumn.SoHoSo)))?null:(System.String)reader[((int)VwThongKeHoSoDaNopChuaNopColumn.SoHoSo)];
					//entity.SoHoSo = (Convert.IsDBNull(reader["SoHoSo"]))?string.Empty:(System.String)reader["SoHoSo"];
					entity.NgayCap = (reader.IsDBNull(((int)VwThongKeHoSoDaNopChuaNopColumn.NgayCap)))?null:(System.String)reader[((int)VwThongKeHoSoDaNopChuaNopColumn.NgayCap)];
					//entity.NgayCap = (Convert.IsDBNull(reader["NgayCap"]))?string.Empty:(System.String)reader["NgayCap"];
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
		/// Refreshes the <see cref="VwThongKeHoSoDaNopChuaNop"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="VwThongKeHoSoDaNopChuaNop"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, VwThongKeHoSoDaNopChuaNop entity)
		{
			reader.Read();
			entity.MaGiangVien = (System.Int32)reader[((int)VwThongKeHoSoDaNopChuaNopColumn.MaGiangVien)];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
			entity.MaGiangVienQuanLy = (System.String)reader[((int)VwThongKeHoSoDaNopChuaNopColumn.MaGiangVienQuanLy)];
			//entity.MaGiangVienQuanLy = (Convert.IsDBNull(reader["MaGiangVienQuanLy"]))?string.Empty:(System.String)reader["MaGiangVienQuanLy"];
			entity.MaHoSoDaNop = (reader.IsDBNull(((int)VwThongKeHoSoDaNopChuaNopColumn.MaHoSoDaNop)))?null:(System.String)reader[((int)VwThongKeHoSoDaNopChuaNopColumn.MaHoSoDaNop)];
			//entity.MaHoSoDaNop = (Convert.IsDBNull(reader["MaHoSoDaNop"]))?string.Empty:(System.String)reader["MaHoSoDaNop"];
			entity.TenHoSo = (reader.IsDBNull(((int)VwThongKeHoSoDaNopChuaNopColumn.TenHoSo)))?null:(System.String)reader[((int)VwThongKeHoSoDaNopChuaNopColumn.TenHoSo)];
			//entity.TenHoSo = (Convert.IsDBNull(reader["TenHoSo"]))?string.Empty:(System.String)reader["TenHoSo"];
			entity.MaHoSoChuaNop = (System.String)reader[((int)VwThongKeHoSoDaNopChuaNopColumn.MaHoSoChuaNop)];
			//entity.MaHoSoChuaNop = (Convert.IsDBNull(reader["MaHoSoChuaNop"]))?string.Empty:(System.String)reader["MaHoSoChuaNop"];
			entity.SoHoSo = (reader.IsDBNull(((int)VwThongKeHoSoDaNopChuaNopColumn.SoHoSo)))?null:(System.String)reader[((int)VwThongKeHoSoDaNopChuaNopColumn.SoHoSo)];
			//entity.SoHoSo = (Convert.IsDBNull(reader["SoHoSo"]))?string.Empty:(System.String)reader["SoHoSo"];
			entity.NgayCap = (reader.IsDBNull(((int)VwThongKeHoSoDaNopChuaNopColumn.NgayCap)))?null:(System.String)reader[((int)VwThongKeHoSoDaNopChuaNopColumn.NgayCap)];
			//entity.NgayCap = (Convert.IsDBNull(reader["NgayCap"]))?string.Empty:(System.String)reader["NgayCap"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="VwThongKeHoSoDaNopChuaNop"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="VwThongKeHoSoDaNopChuaNop"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, VwThongKeHoSoDaNopChuaNop entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32)dataRow["MaGiangVien"];
			entity.MaGiangVienQuanLy = (Convert.IsDBNull(dataRow["MaGiangVienQuanLy"]))?string.Empty:(System.String)dataRow["MaGiangVienQuanLy"];
			entity.MaHoSoDaNop = (Convert.IsDBNull(dataRow["MaHoSoDaNop"]))?string.Empty:(System.String)dataRow["MaHoSoDaNop"];
			entity.TenHoSo = (Convert.IsDBNull(dataRow["TenHoSo"]))?string.Empty:(System.String)dataRow["TenHoSo"];
			entity.MaHoSoChuaNop = (Convert.IsDBNull(dataRow["MaHoSoChuaNop"]))?string.Empty:(System.String)dataRow["MaHoSoChuaNop"];
			entity.SoHoSo = (Convert.IsDBNull(dataRow["SoHoSo"]))?string.Empty:(System.String)dataRow["SoHoSo"];
			entity.NgayCap = (Convert.IsDBNull(dataRow["NgayCap"]))?string.Empty:(System.String)dataRow["NgayCap"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region VwThongKeHoSoDaNopChuaNopFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwThongKeHoSoDaNopChuaNop"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VwThongKeHoSoDaNopChuaNopFilterBuilder : SqlFilterBuilder<VwThongKeHoSoDaNopChuaNopColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwThongKeHoSoDaNopChuaNopFilterBuilder class.
		/// </summary>
		public VwThongKeHoSoDaNopChuaNopFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VwThongKeHoSoDaNopChuaNopFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VwThongKeHoSoDaNopChuaNopFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VwThongKeHoSoDaNopChuaNopFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VwThongKeHoSoDaNopChuaNopFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VwThongKeHoSoDaNopChuaNopFilterBuilder

	#region VwThongKeHoSoDaNopChuaNopParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwThongKeHoSoDaNopChuaNop"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VwThongKeHoSoDaNopChuaNopParameterBuilder : ParameterizedSqlFilterBuilder<VwThongKeHoSoDaNopChuaNopColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwThongKeHoSoDaNopChuaNopParameterBuilder class.
		/// </summary>
		public VwThongKeHoSoDaNopChuaNopParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VwThongKeHoSoDaNopChuaNopParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VwThongKeHoSoDaNopChuaNopParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VwThongKeHoSoDaNopChuaNopParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VwThongKeHoSoDaNopChuaNopParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VwThongKeHoSoDaNopChuaNopParameterBuilder
	
	#region VwThongKeHoSoDaNopChuaNopSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwThongKeHoSoDaNopChuaNop"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class VwThongKeHoSoDaNopChuaNopSortBuilder : SqlSortBuilder<VwThongKeHoSoDaNopChuaNopColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwThongKeHoSoDaNopChuaNopSqlSortBuilder class.
		/// </summary>
		public VwThongKeHoSoDaNopChuaNopSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion VwThongKeHoSoDaNopChuaNopSortBuilder

} // end namespace
