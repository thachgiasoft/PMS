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
	/// This class is the base class for any <see cref="VTongHopQuyDoiProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class VTongHopQuyDoiProviderBaseCore : EntityViewProviderBase<VTongHopQuyDoi>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;VTongHopQuyDoi&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;VTongHopQuyDoi&gt;"/></returns>
		protected static VList&lt;VTongHopQuyDoi&gt; Fill(DataSet dataSet, VList<VTongHopQuyDoi> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<VTongHopQuyDoi>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;VTongHopQuyDoi&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<VTongHopQuyDoi>"/></returns>
		protected static VList&lt;VTongHopQuyDoi&gt; Fill(DataTable dataTable, VList<VTongHopQuyDoi> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					VTongHopQuyDoi c = new VTongHopQuyDoi();
					c.MaKhoa = (Convert.IsDBNull(row["MaKhoa"]))?string.Empty:(System.String)row["MaKhoa"];
					c.TenKhoa = (Convert.IsDBNull(row["TenKhoa"]))?string.Empty:(System.String)row["TenKhoa"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.SoTiet1 = (Convert.IsDBNull(row["SoTiet1"]))?0.0m:(System.Decimal?)row["SoTiet1"];
					c.TietDoAn1 = (Convert.IsDBNull(row["TietDoAn1"]))?0.0m:(System.Decimal?)row["TietDoAn1"];
					c.SoTiet2 = (Convert.IsDBNull(row["SoTiet2"]))?0.0m:(System.Decimal?)row["SoTiet2"];
					c.TietDoAn2 = (Convert.IsDBNull(row["TietDoAn2"]))?0.0m:(System.Decimal?)row["TietDoAn2"];
					c.TietLyThuyet = (Convert.IsDBNull(row["TietLyThuyet"]))?0.0m:(System.Decimal?)row["TietLyThuyet"];
					c.TietThucHanh = (Convert.IsDBNull(row["TietThucHanh"]))?0.0m:(System.Decimal?)row["TietThucHanh"];
					c.TietThiNghiem = (Convert.IsDBNull(row["TietThiNghiem"]))?0.0m:(System.Decimal?)row["TietThiNghiem"];
					c.TietThucTap = (Convert.IsDBNull(row["TietThucTap"]))?0.0m:(System.Decimal?)row["TietThucTap"];
					c.TietDoAn = (Convert.IsDBNull(row["TietDoAn"]))?0.0m:(System.Decimal?)row["TietDoAn"];
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
		/// Fill an <see cref="VList&lt;VTongHopQuyDoi&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;VTongHopQuyDoi&gt;"/></returns>
		protected VList<VTongHopQuyDoi> Fill(IDataReader reader, VList<VTongHopQuyDoi> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					VTongHopQuyDoi entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<VTongHopQuyDoi>("VTongHopQuyDoi",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new VTongHopQuyDoi();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaKhoa = reader.IsDBNull(reader.GetOrdinal("MaKhoa")) ? null : (System.String)reader["MaKhoa"];
					//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
					entity.TenKhoa = reader.IsDBNull(reader.GetOrdinal("TenKhoa")) ? null : (System.String)reader["TenKhoa"];
					//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
					entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.SoTiet1 = reader.IsDBNull(reader.GetOrdinal("SoTiet1")) ? null : (System.Decimal?)reader["SoTiet1"];
					//entity.SoTiet1 = (Convert.IsDBNull(reader["SoTiet1"]))?0.0m:(System.Decimal?)reader["SoTiet1"];
					entity.TietDoAn1 = reader.IsDBNull(reader.GetOrdinal("TietDoAn1")) ? null : (System.Decimal?)reader["TietDoAn1"];
					//entity.TietDoAn1 = (Convert.IsDBNull(reader["TietDoAn1"]))?0.0m:(System.Decimal?)reader["TietDoAn1"];
					entity.SoTiet2 = reader.IsDBNull(reader.GetOrdinal("SoTiet2")) ? null : (System.Decimal?)reader["SoTiet2"];
					//entity.SoTiet2 = (Convert.IsDBNull(reader["SoTiet2"]))?0.0m:(System.Decimal?)reader["SoTiet2"];
					entity.TietDoAn2 = reader.IsDBNull(reader.GetOrdinal("TietDoAn2")) ? null : (System.Decimal?)reader["TietDoAn2"];
					//entity.TietDoAn2 = (Convert.IsDBNull(reader["TietDoAn2"]))?0.0m:(System.Decimal?)reader["TietDoAn2"];
					entity.TietLyThuyet = reader.IsDBNull(reader.GetOrdinal("TietLyThuyet")) ? null : (System.Decimal?)reader["TietLyThuyet"];
					//entity.TietLyThuyet = (Convert.IsDBNull(reader["TietLyThuyet"]))?0.0m:(System.Decimal?)reader["TietLyThuyet"];
					entity.TietThucHanh = reader.IsDBNull(reader.GetOrdinal("TietThucHanh")) ? null : (System.Decimal?)reader["TietThucHanh"];
					//entity.TietThucHanh = (Convert.IsDBNull(reader["TietThucHanh"]))?0.0m:(System.Decimal?)reader["TietThucHanh"];
					entity.TietThiNghiem = reader.IsDBNull(reader.GetOrdinal("TietThiNghiem")) ? null : (System.Decimal?)reader["TietThiNghiem"];
					//entity.TietThiNghiem = (Convert.IsDBNull(reader["TietThiNghiem"]))?0.0m:(System.Decimal?)reader["TietThiNghiem"];
					entity.TietThucTap = reader.IsDBNull(reader.GetOrdinal("TietThucTap")) ? null : (System.Decimal?)reader["TietThucTap"];
					//entity.TietThucTap = (Convert.IsDBNull(reader["TietThucTap"]))?0.0m:(System.Decimal?)reader["TietThucTap"];
					entity.TietDoAn = reader.IsDBNull(reader.GetOrdinal("TietDoAn")) ? null : (System.Decimal?)reader["TietDoAn"];
					//entity.TietDoAn = (Convert.IsDBNull(reader["TietDoAn"]))?0.0m:(System.Decimal?)reader["TietDoAn"];
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
		/// Refreshes the <see cref="VTongHopQuyDoi"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="VTongHopQuyDoi"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, VTongHopQuyDoi entity)
		{
			reader.Read();
			entity.MaKhoa = reader.IsDBNull(reader.GetOrdinal("MaKhoa")) ? null : (System.String)reader["MaKhoa"];
			//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
			entity.TenKhoa = reader.IsDBNull(reader.GetOrdinal("TenKhoa")) ? null : (System.String)reader["TenKhoa"];
			//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
			entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.SoTiet1 = reader.IsDBNull(reader.GetOrdinal("SoTiet1")) ? null : (System.Decimal?)reader["SoTiet1"];
			//entity.SoTiet1 = (Convert.IsDBNull(reader["SoTiet1"]))?0.0m:(System.Decimal?)reader["SoTiet1"];
			entity.TietDoAn1 = reader.IsDBNull(reader.GetOrdinal("TietDoAn1")) ? null : (System.Decimal?)reader["TietDoAn1"];
			//entity.TietDoAn1 = (Convert.IsDBNull(reader["TietDoAn1"]))?0.0m:(System.Decimal?)reader["TietDoAn1"];
			entity.SoTiet2 = reader.IsDBNull(reader.GetOrdinal("SoTiet2")) ? null : (System.Decimal?)reader["SoTiet2"];
			//entity.SoTiet2 = (Convert.IsDBNull(reader["SoTiet2"]))?0.0m:(System.Decimal?)reader["SoTiet2"];
			entity.TietDoAn2 = reader.IsDBNull(reader.GetOrdinal("TietDoAn2")) ? null : (System.Decimal?)reader["TietDoAn2"];
			//entity.TietDoAn2 = (Convert.IsDBNull(reader["TietDoAn2"]))?0.0m:(System.Decimal?)reader["TietDoAn2"];
			entity.TietLyThuyet = reader.IsDBNull(reader.GetOrdinal("TietLyThuyet")) ? null : (System.Decimal?)reader["TietLyThuyet"];
			//entity.TietLyThuyet = (Convert.IsDBNull(reader["TietLyThuyet"]))?0.0m:(System.Decimal?)reader["TietLyThuyet"];
			entity.TietThucHanh = reader.IsDBNull(reader.GetOrdinal("TietThucHanh")) ? null : (System.Decimal?)reader["TietThucHanh"];
			//entity.TietThucHanh = (Convert.IsDBNull(reader["TietThucHanh"]))?0.0m:(System.Decimal?)reader["TietThucHanh"];
			entity.TietThiNghiem = reader.IsDBNull(reader.GetOrdinal("TietThiNghiem")) ? null : (System.Decimal?)reader["TietThiNghiem"];
			//entity.TietThiNghiem = (Convert.IsDBNull(reader["TietThiNghiem"]))?0.0m:(System.Decimal?)reader["TietThiNghiem"];
			entity.TietThucTap = reader.IsDBNull(reader.GetOrdinal("TietThucTap")) ? null : (System.Decimal?)reader["TietThucTap"];
			//entity.TietThucTap = (Convert.IsDBNull(reader["TietThucTap"]))?0.0m:(System.Decimal?)reader["TietThucTap"];
			entity.TietDoAn = reader.IsDBNull(reader.GetOrdinal("TietDoAn")) ? null : (System.Decimal?)reader["TietDoAn"];
			//entity.TietDoAn = (Convert.IsDBNull(reader["TietDoAn"]))?0.0m:(System.Decimal?)reader["TietDoAn"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="VTongHopQuyDoi"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="VTongHopQuyDoi"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, VTongHopQuyDoi entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaKhoa = (Convert.IsDBNull(dataRow["MaKhoa"]))?string.Empty:(System.String)dataRow["MaKhoa"];
			entity.TenKhoa = (Convert.IsDBNull(dataRow["TenKhoa"]))?string.Empty:(System.String)dataRow["TenKhoa"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.SoTiet1 = (Convert.IsDBNull(dataRow["SoTiet1"]))?0.0m:(System.Decimal?)dataRow["SoTiet1"];
			entity.TietDoAn1 = (Convert.IsDBNull(dataRow["TietDoAn1"]))?0.0m:(System.Decimal?)dataRow["TietDoAn1"];
			entity.SoTiet2 = (Convert.IsDBNull(dataRow["SoTiet2"]))?0.0m:(System.Decimal?)dataRow["SoTiet2"];
			entity.TietDoAn2 = (Convert.IsDBNull(dataRow["TietDoAn2"]))?0.0m:(System.Decimal?)dataRow["TietDoAn2"];
			entity.TietLyThuyet = (Convert.IsDBNull(dataRow["TietLyThuyet"]))?0.0m:(System.Decimal?)dataRow["TietLyThuyet"];
			entity.TietThucHanh = (Convert.IsDBNull(dataRow["TietThucHanh"]))?0.0m:(System.Decimal?)dataRow["TietThucHanh"];
			entity.TietThiNghiem = (Convert.IsDBNull(dataRow["TietThiNghiem"]))?0.0m:(System.Decimal?)dataRow["TietThiNghiem"];
			entity.TietThucTap = (Convert.IsDBNull(dataRow["TietThucTap"]))?0.0m:(System.Decimal?)dataRow["TietThucTap"];
			entity.TietDoAn = (Convert.IsDBNull(dataRow["TietDoAn"]))?0.0m:(System.Decimal?)dataRow["TietDoAn"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region VTongHopQuyDoiFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VTongHopQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VTongHopQuyDoiFilterBuilder : SqlFilterBuilder<VTongHopQuyDoiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VTongHopQuyDoiFilterBuilder class.
		/// </summary>
		public VTongHopQuyDoiFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VTongHopQuyDoiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VTongHopQuyDoiFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VTongHopQuyDoiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VTongHopQuyDoiFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VTongHopQuyDoiFilterBuilder

	#region VTongHopQuyDoiParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VTongHopQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VTongHopQuyDoiParameterBuilder : ParameterizedSqlFilterBuilder<VTongHopQuyDoiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VTongHopQuyDoiParameterBuilder class.
		/// </summary>
		public VTongHopQuyDoiParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VTongHopQuyDoiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VTongHopQuyDoiParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VTongHopQuyDoiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VTongHopQuyDoiParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VTongHopQuyDoiParameterBuilder
	
	#region VTongHopQuyDoiSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VTongHopQuyDoi"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class VTongHopQuyDoiSortBuilder : SqlSortBuilder<VTongHopQuyDoiColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VTongHopQuyDoiSqlSortBuilder class.
		/// </summary>
		public VTongHopQuyDoiSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion VTongHopQuyDoiSortBuilder

} // end namespace
