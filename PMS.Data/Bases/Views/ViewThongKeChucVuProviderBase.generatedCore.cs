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
	/// This class is the base class for any <see cref="ViewThongKeChucVuProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewThongKeChucVuProviderBaseCore : EntityViewProviderBase<ViewThongKeChucVu>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewThongKeChucVu&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewThongKeChucVu&gt;"/></returns>
		protected static VList&lt;ViewThongKeChucVu&gt; Fill(DataSet dataSet, VList<ViewThongKeChucVu> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewThongKeChucVu>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewThongKeChucVu&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewThongKeChucVu>"/></returns>
		protected static VList&lt;ViewThongKeChucVu&gt; Fill(DataTable dataTable, VList<ViewThongKeChucVu> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewThongKeChucVu c = new ViewThongKeChucVu();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32)row["MaGiangVien"];
					c.MaGiangVienQuanLy = (Convert.IsDBNull(row["MaGiangVienQuanLy"]))?string.Empty:(System.String)row["MaGiangVienQuanLy"];
					c.Ho = (Convert.IsDBNull(row["Ho"]))?string.Empty:(System.String)row["Ho"];
					c.Ten = (Convert.IsDBNull(row["Ten"]))?string.Empty:(System.String)row["Ten"];
					c.MaChucVuHienTai = (Convert.IsDBNull(row["MaChucVuHienTai"]))?string.Empty:(System.String)row["MaChucVuHienTai"];
					c.TenChucVuHienTai = (Convert.IsDBNull(row["TenChucVuHienTai"]))?string.Empty:(System.String)row["TenChucVuHienTai"];
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
		/// Fill an <see cref="VList&lt;ViewThongKeChucVu&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewThongKeChucVu&gt;"/></returns>
		protected VList<ViewThongKeChucVu> Fill(IDataReader reader, VList<ViewThongKeChucVu> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewThongKeChucVu entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewThongKeChucVu>("ViewThongKeChucVu",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewThongKeChucVu();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = (System.Int32)reader["MaGiangVien"];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
					entity.MaGiangVienQuanLy = (System.String)reader["MaGiangVienQuanLy"];
					//entity.MaGiangVienQuanLy = (Convert.IsDBNull(reader["MaGiangVienQuanLy"]))?string.Empty:(System.String)reader["MaGiangVienQuanLy"];
					entity.Ho = (System.String)reader["Ho"];
					//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
					entity.Ten = (System.String)reader["Ten"];
					//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
					entity.MaChucVuHienTai = reader.IsDBNull(reader.GetOrdinal("MaChucVuHienTai")) ? null : (System.String)reader["MaChucVuHienTai"];
					//entity.MaChucVuHienTai = (Convert.IsDBNull(reader["MaChucVuHienTai"]))?string.Empty:(System.String)reader["MaChucVuHienTai"];
					entity.TenChucVuHienTai = reader.IsDBNull(reader.GetOrdinal("TenChucVuHienTai")) ? null : (System.String)reader["TenChucVuHienTai"];
					//entity.TenChucVuHienTai = (Convert.IsDBNull(reader["TenChucVuHienTai"]))?string.Empty:(System.String)reader["TenChucVuHienTai"];
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
		/// Refreshes the <see cref="ViewThongKeChucVu"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThongKeChucVu"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewThongKeChucVu entity)
		{
			reader.Read();
			entity.MaGiangVien = (System.Int32)reader["MaGiangVien"];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
			entity.MaGiangVienQuanLy = (System.String)reader["MaGiangVienQuanLy"];
			//entity.MaGiangVienQuanLy = (Convert.IsDBNull(reader["MaGiangVienQuanLy"]))?string.Empty:(System.String)reader["MaGiangVienQuanLy"];
			entity.Ho = (System.String)reader["Ho"];
			//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
			entity.Ten = (System.String)reader["Ten"];
			//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
			entity.MaChucVuHienTai = reader.IsDBNull(reader.GetOrdinal("MaChucVuHienTai")) ? null : (System.String)reader["MaChucVuHienTai"];
			//entity.MaChucVuHienTai = (Convert.IsDBNull(reader["MaChucVuHienTai"]))?string.Empty:(System.String)reader["MaChucVuHienTai"];
			entity.TenChucVuHienTai = reader.IsDBNull(reader.GetOrdinal("TenChucVuHienTai")) ? null : (System.String)reader["TenChucVuHienTai"];
			//entity.TenChucVuHienTai = (Convert.IsDBNull(reader["TenChucVuHienTai"]))?string.Empty:(System.String)reader["TenChucVuHienTai"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewThongKeChucVu"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThongKeChucVu"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewThongKeChucVu entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32)dataRow["MaGiangVien"];
			entity.MaGiangVienQuanLy = (Convert.IsDBNull(dataRow["MaGiangVienQuanLy"]))?string.Empty:(System.String)dataRow["MaGiangVienQuanLy"];
			entity.Ho = (Convert.IsDBNull(dataRow["Ho"]))?string.Empty:(System.String)dataRow["Ho"];
			entity.Ten = (Convert.IsDBNull(dataRow["Ten"]))?string.Empty:(System.String)dataRow["Ten"];
			entity.MaChucVuHienTai = (Convert.IsDBNull(dataRow["MaChucVuHienTai"]))?string.Empty:(System.String)dataRow["MaChucVuHienTai"];
			entity.TenChucVuHienTai = (Convert.IsDBNull(dataRow["TenChucVuHienTai"]))?string.Empty:(System.String)dataRow["TenChucVuHienTai"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewThongKeChucVuFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongKeChucVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThongKeChucVuFilterBuilder : SqlFilterBuilder<ViewThongKeChucVuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongKeChucVuFilterBuilder class.
		/// </summary>
		public ViewThongKeChucVuFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThongKeChucVuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThongKeChucVuFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThongKeChucVuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThongKeChucVuFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThongKeChucVuFilterBuilder

	#region ViewThongKeChucVuParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongKeChucVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThongKeChucVuParameterBuilder : ParameterizedSqlFilterBuilder<ViewThongKeChucVuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongKeChucVuParameterBuilder class.
		/// </summary>
		public ViewThongKeChucVuParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThongKeChucVuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThongKeChucVuParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThongKeChucVuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThongKeChucVuParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThongKeChucVuParameterBuilder
	
	#region ViewThongKeChucVuSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongKeChucVu"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewThongKeChucVuSortBuilder : SqlSortBuilder<ViewThongKeChucVuColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongKeChucVuSqlSortBuilder class.
		/// </summary>
		public ViewThongKeChucVuSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewThongKeChucVuSortBuilder

} // end namespace
