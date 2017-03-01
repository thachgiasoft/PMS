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
	/// This class is the base class for any <see cref="VwThongKeChucVuHienTaiGiangVienProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class VwThongKeChucVuHienTaiGiangVienProviderBaseCore : EntityViewProviderBase<VwThongKeChucVuHienTaiGiangVien>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;VwThongKeChucVuHienTaiGiangVien&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;VwThongKeChucVuHienTaiGiangVien&gt;"/></returns>
		protected static VList&lt;VwThongKeChucVuHienTaiGiangVien&gt; Fill(DataSet dataSet, VList<VwThongKeChucVuHienTaiGiangVien> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<VwThongKeChucVuHienTaiGiangVien>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;VwThongKeChucVuHienTaiGiangVien&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<VwThongKeChucVuHienTaiGiangVien>"/></returns>
		protected static VList&lt;VwThongKeChucVuHienTaiGiangVien&gt; Fill(DataTable dataTable, VList<VwThongKeChucVuHienTaiGiangVien> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					VwThongKeChucVuHienTaiGiangVien c = new VwThongKeChucVuHienTaiGiangVien();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32)row["MaGiangVien"];
					c.MaGiangVienQuanLy = (Convert.IsDBNull(row["MaGiangVienQuanLy"]))?string.Empty:(System.String)row["MaGiangVienQuanLy"];
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
		/// Fill an <see cref="VList&lt;VwThongKeChucVuHienTaiGiangVien&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;VwThongKeChucVuHienTaiGiangVien&gt;"/></returns>
		protected VList<VwThongKeChucVuHienTaiGiangVien> Fill(IDataReader reader, VList<VwThongKeChucVuHienTaiGiangVien> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					VwThongKeChucVuHienTaiGiangVien entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<VwThongKeChucVuHienTaiGiangVien>("VwThongKeChucVuHienTaiGiangVien",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new VwThongKeChucVuHienTaiGiangVien();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = (System.Int32)reader[((int)VwThongKeChucVuHienTaiGiangVienColumn.MaGiangVien)];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
					entity.MaGiangVienQuanLy = (System.String)reader[((int)VwThongKeChucVuHienTaiGiangVienColumn.MaGiangVienQuanLy)];
					//entity.MaGiangVienQuanLy = (Convert.IsDBNull(reader["MaGiangVienQuanLy"]))?string.Empty:(System.String)reader["MaGiangVienQuanLy"];
					entity.MaChucVuHienTai = (reader.IsDBNull(((int)VwThongKeChucVuHienTaiGiangVienColumn.MaChucVuHienTai)))?null:(System.String)reader[((int)VwThongKeChucVuHienTaiGiangVienColumn.MaChucVuHienTai)];
					//entity.MaChucVuHienTai = (Convert.IsDBNull(reader["MaChucVuHienTai"]))?string.Empty:(System.String)reader["MaChucVuHienTai"];
					entity.TenChucVuHienTai = (reader.IsDBNull(((int)VwThongKeChucVuHienTaiGiangVienColumn.TenChucVuHienTai)))?null:(System.String)reader[((int)VwThongKeChucVuHienTaiGiangVienColumn.TenChucVuHienTai)];
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
		/// Refreshes the <see cref="VwThongKeChucVuHienTaiGiangVien"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="VwThongKeChucVuHienTaiGiangVien"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, VwThongKeChucVuHienTaiGiangVien entity)
		{
			reader.Read();
			entity.MaGiangVien = (System.Int32)reader[((int)VwThongKeChucVuHienTaiGiangVienColumn.MaGiangVien)];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
			entity.MaGiangVienQuanLy = (System.String)reader[((int)VwThongKeChucVuHienTaiGiangVienColumn.MaGiangVienQuanLy)];
			//entity.MaGiangVienQuanLy = (Convert.IsDBNull(reader["MaGiangVienQuanLy"]))?string.Empty:(System.String)reader["MaGiangVienQuanLy"];
			entity.MaChucVuHienTai = (reader.IsDBNull(((int)VwThongKeChucVuHienTaiGiangVienColumn.MaChucVuHienTai)))?null:(System.String)reader[((int)VwThongKeChucVuHienTaiGiangVienColumn.MaChucVuHienTai)];
			//entity.MaChucVuHienTai = (Convert.IsDBNull(reader["MaChucVuHienTai"]))?string.Empty:(System.String)reader["MaChucVuHienTai"];
			entity.TenChucVuHienTai = (reader.IsDBNull(((int)VwThongKeChucVuHienTaiGiangVienColumn.TenChucVuHienTai)))?null:(System.String)reader[((int)VwThongKeChucVuHienTaiGiangVienColumn.TenChucVuHienTai)];
			//entity.TenChucVuHienTai = (Convert.IsDBNull(reader["TenChucVuHienTai"]))?string.Empty:(System.String)reader["TenChucVuHienTai"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="VwThongKeChucVuHienTaiGiangVien"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="VwThongKeChucVuHienTaiGiangVien"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, VwThongKeChucVuHienTaiGiangVien entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32)dataRow["MaGiangVien"];
			entity.MaGiangVienQuanLy = (Convert.IsDBNull(dataRow["MaGiangVienQuanLy"]))?string.Empty:(System.String)dataRow["MaGiangVienQuanLy"];
			entity.MaChucVuHienTai = (Convert.IsDBNull(dataRow["MaChucVuHienTai"]))?string.Empty:(System.String)dataRow["MaChucVuHienTai"];
			entity.TenChucVuHienTai = (Convert.IsDBNull(dataRow["TenChucVuHienTai"]))?string.Empty:(System.String)dataRow["TenChucVuHienTai"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region VwThongKeChucVuHienTaiGiangVienFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwThongKeChucVuHienTaiGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VwThongKeChucVuHienTaiGiangVienFilterBuilder : SqlFilterBuilder<VwThongKeChucVuHienTaiGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwThongKeChucVuHienTaiGiangVienFilterBuilder class.
		/// </summary>
		public VwThongKeChucVuHienTaiGiangVienFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VwThongKeChucVuHienTaiGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VwThongKeChucVuHienTaiGiangVienFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VwThongKeChucVuHienTaiGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VwThongKeChucVuHienTaiGiangVienFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VwThongKeChucVuHienTaiGiangVienFilterBuilder

	#region VwThongKeChucVuHienTaiGiangVienParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwThongKeChucVuHienTaiGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VwThongKeChucVuHienTaiGiangVienParameterBuilder : ParameterizedSqlFilterBuilder<VwThongKeChucVuHienTaiGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwThongKeChucVuHienTaiGiangVienParameterBuilder class.
		/// </summary>
		public VwThongKeChucVuHienTaiGiangVienParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VwThongKeChucVuHienTaiGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VwThongKeChucVuHienTaiGiangVienParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VwThongKeChucVuHienTaiGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VwThongKeChucVuHienTaiGiangVienParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VwThongKeChucVuHienTaiGiangVienParameterBuilder
	
	#region VwThongKeChucVuHienTaiGiangVienSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwThongKeChucVuHienTaiGiangVien"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class VwThongKeChucVuHienTaiGiangVienSortBuilder : SqlSortBuilder<VwThongKeChucVuHienTaiGiangVienColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwThongKeChucVuHienTaiGiangVienSqlSortBuilder class.
		/// </summary>
		public VwThongKeChucVuHienTaiGiangVienSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion VwThongKeChucVuHienTaiGiangVienSortBuilder

} // end namespace
