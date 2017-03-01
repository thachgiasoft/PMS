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
	/// This class is the base class for any <see cref="VwThongKeChucVuGiangVienProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class VwThongKeChucVuGiangVienProviderBaseCore : EntityViewProviderBase<VwThongKeChucVuGiangVien>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;VwThongKeChucVuGiangVien&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;VwThongKeChucVuGiangVien&gt;"/></returns>
		protected static VList&lt;VwThongKeChucVuGiangVien&gt; Fill(DataSet dataSet, VList<VwThongKeChucVuGiangVien> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<VwThongKeChucVuGiangVien>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;VwThongKeChucVuGiangVien&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<VwThongKeChucVuGiangVien>"/></returns>
		protected static VList&lt;VwThongKeChucVuGiangVien&gt; Fill(DataTable dataTable, VList<VwThongKeChucVuGiangVien> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					VwThongKeChucVuGiangVien c = new VwThongKeChucVuGiangVien();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32)row["MaGiangVien"];
					c.MaGiangVienQuanLy = (Convert.IsDBNull(row["MaGiangVienQuanLy"]))?string.Empty:(System.String)row["MaGiangVienQuanLy"];
					c.MaChucVuHienTai = (Convert.IsDBNull(row["MaChucVuHienTai"]))?string.Empty:(System.String)row["MaChucVuHienTai"];
					c.TenChucVu = (Convert.IsDBNull(row["TenChucVu"]))?string.Empty:(System.String)row["TenChucVu"];
					c.MaChucVuQuanLy = (Convert.IsDBNull(row["MaChucVuQuanLy"]))?string.Empty:(System.String)row["MaChucVuQuanLy"];
					c.NgayHieuLuc = (Convert.IsDBNull(row["NgayHieuLuc"]))?string.Empty:(System.String)row["NgayHieuLuc"];
					c.NgayHetHieuLuc = (Convert.IsDBNull(row["NgayHetHieuLuc"]))?string.Empty:(System.String)row["NgayHetHieuLuc"];
					c.TrangThai = (Convert.IsDBNull(row["TrangThai"]))?false:(System.Boolean?)row["TrangThai"];
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
		/// Fill an <see cref="VList&lt;VwThongKeChucVuGiangVien&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;VwThongKeChucVuGiangVien&gt;"/></returns>
		protected VList<VwThongKeChucVuGiangVien> Fill(IDataReader reader, VList<VwThongKeChucVuGiangVien> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					VwThongKeChucVuGiangVien entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<VwThongKeChucVuGiangVien>("VwThongKeChucVuGiangVien",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new VwThongKeChucVuGiangVien();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = (System.Int32)reader[((int)VwThongKeChucVuGiangVienColumn.MaGiangVien)];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
					entity.MaGiangVienQuanLy = (System.String)reader[((int)VwThongKeChucVuGiangVienColumn.MaGiangVienQuanLy)];
					//entity.MaGiangVienQuanLy = (Convert.IsDBNull(reader["MaGiangVienQuanLy"]))?string.Empty:(System.String)reader["MaGiangVienQuanLy"];
					entity.MaChucVuHienTai = (reader.IsDBNull(((int)VwThongKeChucVuGiangVienColumn.MaChucVuHienTai)))?null:(System.String)reader[((int)VwThongKeChucVuGiangVienColumn.MaChucVuHienTai)];
					//entity.MaChucVuHienTai = (Convert.IsDBNull(reader["MaChucVuHienTai"]))?string.Empty:(System.String)reader["MaChucVuHienTai"];
					entity.TenChucVu = (reader.IsDBNull(((int)VwThongKeChucVuGiangVienColumn.TenChucVu)))?null:(System.String)reader[((int)VwThongKeChucVuGiangVienColumn.TenChucVu)];
					//entity.TenChucVu = (Convert.IsDBNull(reader["TenChucVu"]))?string.Empty:(System.String)reader["TenChucVu"];
					entity.MaChucVuQuanLy = (System.String)reader[((int)VwThongKeChucVuGiangVienColumn.MaChucVuQuanLy)];
					//entity.MaChucVuQuanLy = (Convert.IsDBNull(reader["MaChucVuQuanLy"]))?string.Empty:(System.String)reader["MaChucVuQuanLy"];
					entity.NgayHieuLuc = (reader.IsDBNull(((int)VwThongKeChucVuGiangVienColumn.NgayHieuLuc)))?null:(System.String)reader[((int)VwThongKeChucVuGiangVienColumn.NgayHieuLuc)];
					//entity.NgayHieuLuc = (Convert.IsDBNull(reader["NgayHieuLuc"]))?string.Empty:(System.String)reader["NgayHieuLuc"];
					entity.NgayHetHieuLuc = (reader.IsDBNull(((int)VwThongKeChucVuGiangVienColumn.NgayHetHieuLuc)))?null:(System.String)reader[((int)VwThongKeChucVuGiangVienColumn.NgayHetHieuLuc)];
					//entity.NgayHetHieuLuc = (Convert.IsDBNull(reader["NgayHetHieuLuc"]))?string.Empty:(System.String)reader["NgayHetHieuLuc"];
					entity.TrangThai = (reader.IsDBNull(((int)VwThongKeChucVuGiangVienColumn.TrangThai)))?null:(System.Boolean?)reader[((int)VwThongKeChucVuGiangVienColumn.TrangThai)];
					//entity.TrangThai = (Convert.IsDBNull(reader["TrangThai"]))?false:(System.Boolean?)reader["TrangThai"];
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
		/// Refreshes the <see cref="VwThongKeChucVuGiangVien"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="VwThongKeChucVuGiangVien"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, VwThongKeChucVuGiangVien entity)
		{
			reader.Read();
			entity.MaGiangVien = (System.Int32)reader[((int)VwThongKeChucVuGiangVienColumn.MaGiangVien)];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
			entity.MaGiangVienQuanLy = (System.String)reader[((int)VwThongKeChucVuGiangVienColumn.MaGiangVienQuanLy)];
			//entity.MaGiangVienQuanLy = (Convert.IsDBNull(reader["MaGiangVienQuanLy"]))?string.Empty:(System.String)reader["MaGiangVienQuanLy"];
			entity.MaChucVuHienTai = (reader.IsDBNull(((int)VwThongKeChucVuGiangVienColumn.MaChucVuHienTai)))?null:(System.String)reader[((int)VwThongKeChucVuGiangVienColumn.MaChucVuHienTai)];
			//entity.MaChucVuHienTai = (Convert.IsDBNull(reader["MaChucVuHienTai"]))?string.Empty:(System.String)reader["MaChucVuHienTai"];
			entity.TenChucVu = (reader.IsDBNull(((int)VwThongKeChucVuGiangVienColumn.TenChucVu)))?null:(System.String)reader[((int)VwThongKeChucVuGiangVienColumn.TenChucVu)];
			//entity.TenChucVu = (Convert.IsDBNull(reader["TenChucVu"]))?string.Empty:(System.String)reader["TenChucVu"];
			entity.MaChucVuQuanLy = (System.String)reader[((int)VwThongKeChucVuGiangVienColumn.MaChucVuQuanLy)];
			//entity.MaChucVuQuanLy = (Convert.IsDBNull(reader["MaChucVuQuanLy"]))?string.Empty:(System.String)reader["MaChucVuQuanLy"];
			entity.NgayHieuLuc = (reader.IsDBNull(((int)VwThongKeChucVuGiangVienColumn.NgayHieuLuc)))?null:(System.String)reader[((int)VwThongKeChucVuGiangVienColumn.NgayHieuLuc)];
			//entity.NgayHieuLuc = (Convert.IsDBNull(reader["NgayHieuLuc"]))?string.Empty:(System.String)reader["NgayHieuLuc"];
			entity.NgayHetHieuLuc = (reader.IsDBNull(((int)VwThongKeChucVuGiangVienColumn.NgayHetHieuLuc)))?null:(System.String)reader[((int)VwThongKeChucVuGiangVienColumn.NgayHetHieuLuc)];
			//entity.NgayHetHieuLuc = (Convert.IsDBNull(reader["NgayHetHieuLuc"]))?string.Empty:(System.String)reader["NgayHetHieuLuc"];
			entity.TrangThai = (reader.IsDBNull(((int)VwThongKeChucVuGiangVienColumn.TrangThai)))?null:(System.Boolean?)reader[((int)VwThongKeChucVuGiangVienColumn.TrangThai)];
			//entity.TrangThai = (Convert.IsDBNull(reader["TrangThai"]))?false:(System.Boolean?)reader["TrangThai"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="VwThongKeChucVuGiangVien"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="VwThongKeChucVuGiangVien"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, VwThongKeChucVuGiangVien entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32)dataRow["MaGiangVien"];
			entity.MaGiangVienQuanLy = (Convert.IsDBNull(dataRow["MaGiangVienQuanLy"]))?string.Empty:(System.String)dataRow["MaGiangVienQuanLy"];
			entity.MaChucVuHienTai = (Convert.IsDBNull(dataRow["MaChucVuHienTai"]))?string.Empty:(System.String)dataRow["MaChucVuHienTai"];
			entity.TenChucVu = (Convert.IsDBNull(dataRow["TenChucVu"]))?string.Empty:(System.String)dataRow["TenChucVu"];
			entity.MaChucVuQuanLy = (Convert.IsDBNull(dataRow["MaChucVuQuanLy"]))?string.Empty:(System.String)dataRow["MaChucVuQuanLy"];
			entity.NgayHieuLuc = (Convert.IsDBNull(dataRow["NgayHieuLuc"]))?string.Empty:(System.String)dataRow["NgayHieuLuc"];
			entity.NgayHetHieuLuc = (Convert.IsDBNull(dataRow["NgayHetHieuLuc"]))?string.Empty:(System.String)dataRow["NgayHetHieuLuc"];
			entity.TrangThai = (Convert.IsDBNull(dataRow["TrangThai"]))?false:(System.Boolean?)dataRow["TrangThai"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region VwThongKeChucVuGiangVienFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwThongKeChucVuGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VwThongKeChucVuGiangVienFilterBuilder : SqlFilterBuilder<VwThongKeChucVuGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwThongKeChucVuGiangVienFilterBuilder class.
		/// </summary>
		public VwThongKeChucVuGiangVienFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VwThongKeChucVuGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VwThongKeChucVuGiangVienFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VwThongKeChucVuGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VwThongKeChucVuGiangVienFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VwThongKeChucVuGiangVienFilterBuilder

	#region VwThongKeChucVuGiangVienParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwThongKeChucVuGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VwThongKeChucVuGiangVienParameterBuilder : ParameterizedSqlFilterBuilder<VwThongKeChucVuGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwThongKeChucVuGiangVienParameterBuilder class.
		/// </summary>
		public VwThongKeChucVuGiangVienParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VwThongKeChucVuGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VwThongKeChucVuGiangVienParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VwThongKeChucVuGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VwThongKeChucVuGiangVienParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VwThongKeChucVuGiangVienParameterBuilder
	
	#region VwThongKeChucVuGiangVienSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwThongKeChucVuGiangVien"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class VwThongKeChucVuGiangVienSortBuilder : SqlSortBuilder<VwThongKeChucVuGiangVienColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwThongKeChucVuGiangVienSqlSortBuilder class.
		/// </summary>
		public VwThongKeChucVuGiangVienSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion VwThongKeChucVuGiangVienSortBuilder

} // end namespace
