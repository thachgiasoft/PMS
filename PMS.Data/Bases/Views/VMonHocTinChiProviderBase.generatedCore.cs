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
	/// This class is the base class for any <see cref="VMonHocTinChiProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class VMonHocTinChiProviderBaseCore : EntityViewProviderBase<VMonHocTinChi>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;VMonHocTinChi&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;VMonHocTinChi&gt;"/></returns>
		protected static VList&lt;VMonHocTinChi&gt; Fill(DataSet dataSet, VList<VMonHocTinChi> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<VMonHocTinChi>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;VMonHocTinChi&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<VMonHocTinChi>"/></returns>
		protected static VList&lt;VMonHocTinChi&gt; Fill(DataTable dataTable, VList<VMonHocTinChi> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					VMonHocTinChi c = new VMonHocTinChi();
					c.MaMonHoc = (Convert.IsDBNull(row["MaMonHoc"]))?string.Empty:(System.String)row["MaMonHoc"];
					c.TenMonHoc = (Convert.IsDBNull(row["TenMonHoc"]))?string.Empty:(System.String)row["TenMonHoc"];
					c.SoTinChi = (Convert.IsDBNull(row["SoTinChi"]))?0.0m:(System.Decimal)row["SoTinChi"];
					c.LyThuyet = (Convert.IsDBNull(row["LyThuyet"]))?0.0m:(System.Decimal)row["LyThuyet"];
					c.ThucHanh = (Convert.IsDBNull(row["ThucHanh"]))?0.0m:(System.Decimal)row["ThucHanh"];
					c.BaiTap = (Convert.IsDBNull(row["BaiTap"]))?0.0m:(System.Decimal)row["BaiTap"];
					c.BaiTapLon = (Convert.IsDBNull(row["BaiTapLon"]))?0.0m:(System.Decimal)row["BaiTapLon"];
					c.DoAn = (Convert.IsDBNull(row["DoAn"]))?0.0m:(System.Decimal)row["DoAn"];
					c.LuanAn = (Convert.IsDBNull(row["LuanAn"]))?0.0m:(System.Decimal)row["LuanAn"];
					c.TieuLuan = (Convert.IsDBNull(row["TieuLuan"]))?0.0m:(System.Decimal)row["TieuLuan"];
					c.ThucTap = (Convert.IsDBNull(row["ThucTap"]))?0.0m:(System.Decimal)row["ThucTap"];
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
		/// Fill an <see cref="VList&lt;VMonHocTinChi&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;VMonHocTinChi&gt;"/></returns>
		protected VList<VMonHocTinChi> Fill(IDataReader reader, VList<VMonHocTinChi> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					VMonHocTinChi entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<VMonHocTinChi>("VMonHocTinChi",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new VMonHocTinChi();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaMonHoc = (System.String)reader["MaMonHoc"];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.TenMonHoc = (System.String)reader["TenMonHoc"];
					//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
					entity.SoTinChi = (System.Decimal)reader["SoTinChi"];
					//entity.SoTinChi = (Convert.IsDBNull(reader["SoTinChi"]))?0.0m:(System.Decimal)reader["SoTinChi"];
					entity.LyThuyet = (System.Decimal)reader["LyThuyet"];
					//entity.LyThuyet = (Convert.IsDBNull(reader["LyThuyet"]))?0.0m:(System.Decimal)reader["LyThuyet"];
					entity.ThucHanh = (System.Decimal)reader["ThucHanh"];
					//entity.ThucHanh = (Convert.IsDBNull(reader["ThucHanh"]))?0.0m:(System.Decimal)reader["ThucHanh"];
					entity.BaiTap = (System.Decimal)reader["BaiTap"];
					//entity.BaiTap = (Convert.IsDBNull(reader["BaiTap"]))?0.0m:(System.Decimal)reader["BaiTap"];
					entity.BaiTapLon = (System.Decimal)reader["BaiTapLon"];
					//entity.BaiTapLon = (Convert.IsDBNull(reader["BaiTapLon"]))?0.0m:(System.Decimal)reader["BaiTapLon"];
					entity.DoAn = (System.Decimal)reader["DoAn"];
					//entity.DoAn = (Convert.IsDBNull(reader["DoAn"]))?0.0m:(System.Decimal)reader["DoAn"];
					entity.LuanAn = (System.Decimal)reader["LuanAn"];
					//entity.LuanAn = (Convert.IsDBNull(reader["LuanAn"]))?0.0m:(System.Decimal)reader["LuanAn"];
					entity.TieuLuan = (System.Decimal)reader["TieuLuan"];
					//entity.TieuLuan = (Convert.IsDBNull(reader["TieuLuan"]))?0.0m:(System.Decimal)reader["TieuLuan"];
					entity.ThucTap = (System.Decimal)reader["ThucTap"];
					//entity.ThucTap = (Convert.IsDBNull(reader["ThucTap"]))?0.0m:(System.Decimal)reader["ThucTap"];
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
		/// Refreshes the <see cref="VMonHocTinChi"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="VMonHocTinChi"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, VMonHocTinChi entity)
		{
			reader.Read();
			entity.MaMonHoc = (System.String)reader["MaMonHoc"];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.TenMonHoc = (System.String)reader["TenMonHoc"];
			//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
			entity.SoTinChi = (System.Decimal)reader["SoTinChi"];
			//entity.SoTinChi = (Convert.IsDBNull(reader["SoTinChi"]))?0.0m:(System.Decimal)reader["SoTinChi"];
			entity.LyThuyet = (System.Decimal)reader["LyThuyet"];
			//entity.LyThuyet = (Convert.IsDBNull(reader["LyThuyet"]))?0.0m:(System.Decimal)reader["LyThuyet"];
			entity.ThucHanh = (System.Decimal)reader["ThucHanh"];
			//entity.ThucHanh = (Convert.IsDBNull(reader["ThucHanh"]))?0.0m:(System.Decimal)reader["ThucHanh"];
			entity.BaiTap = (System.Decimal)reader["BaiTap"];
			//entity.BaiTap = (Convert.IsDBNull(reader["BaiTap"]))?0.0m:(System.Decimal)reader["BaiTap"];
			entity.BaiTapLon = (System.Decimal)reader["BaiTapLon"];
			//entity.BaiTapLon = (Convert.IsDBNull(reader["BaiTapLon"]))?0.0m:(System.Decimal)reader["BaiTapLon"];
			entity.DoAn = (System.Decimal)reader["DoAn"];
			//entity.DoAn = (Convert.IsDBNull(reader["DoAn"]))?0.0m:(System.Decimal)reader["DoAn"];
			entity.LuanAn = (System.Decimal)reader["LuanAn"];
			//entity.LuanAn = (Convert.IsDBNull(reader["LuanAn"]))?0.0m:(System.Decimal)reader["LuanAn"];
			entity.TieuLuan = (System.Decimal)reader["TieuLuan"];
			//entity.TieuLuan = (Convert.IsDBNull(reader["TieuLuan"]))?0.0m:(System.Decimal)reader["TieuLuan"];
			entity.ThucTap = (System.Decimal)reader["ThucTap"];
			//entity.ThucTap = (Convert.IsDBNull(reader["ThucTap"]))?0.0m:(System.Decimal)reader["ThucTap"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="VMonHocTinChi"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="VMonHocTinChi"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, VMonHocTinChi entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaMonHoc = (Convert.IsDBNull(dataRow["MaMonHoc"]))?string.Empty:(System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = (Convert.IsDBNull(dataRow["TenMonHoc"]))?string.Empty:(System.String)dataRow["TenMonHoc"];
			entity.SoTinChi = (Convert.IsDBNull(dataRow["SoTinChi"]))?0.0m:(System.Decimal)dataRow["SoTinChi"];
			entity.LyThuyet = (Convert.IsDBNull(dataRow["LyThuyet"]))?0.0m:(System.Decimal)dataRow["LyThuyet"];
			entity.ThucHanh = (Convert.IsDBNull(dataRow["ThucHanh"]))?0.0m:(System.Decimal)dataRow["ThucHanh"];
			entity.BaiTap = (Convert.IsDBNull(dataRow["BaiTap"]))?0.0m:(System.Decimal)dataRow["BaiTap"];
			entity.BaiTapLon = (Convert.IsDBNull(dataRow["BaiTapLon"]))?0.0m:(System.Decimal)dataRow["BaiTapLon"];
			entity.DoAn = (Convert.IsDBNull(dataRow["DoAn"]))?0.0m:(System.Decimal)dataRow["DoAn"];
			entity.LuanAn = (Convert.IsDBNull(dataRow["LuanAn"]))?0.0m:(System.Decimal)dataRow["LuanAn"];
			entity.TieuLuan = (Convert.IsDBNull(dataRow["TieuLuan"]))?0.0m:(System.Decimal)dataRow["TieuLuan"];
			entity.ThucTap = (Convert.IsDBNull(dataRow["ThucTap"]))?0.0m:(System.Decimal)dataRow["ThucTap"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region VMonHocTinChiFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VMonHocTinChi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VMonHocTinChiFilterBuilder : SqlFilterBuilder<VMonHocTinChiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VMonHocTinChiFilterBuilder class.
		/// </summary>
		public VMonHocTinChiFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VMonHocTinChiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VMonHocTinChiFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VMonHocTinChiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VMonHocTinChiFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VMonHocTinChiFilterBuilder

	#region VMonHocTinChiParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VMonHocTinChi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VMonHocTinChiParameterBuilder : ParameterizedSqlFilterBuilder<VMonHocTinChiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VMonHocTinChiParameterBuilder class.
		/// </summary>
		public VMonHocTinChiParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VMonHocTinChiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VMonHocTinChiParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VMonHocTinChiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VMonHocTinChiParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VMonHocTinChiParameterBuilder
	
	#region VMonHocTinChiSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VMonHocTinChi"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class VMonHocTinChiSortBuilder : SqlSortBuilder<VMonHocTinChiColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VMonHocTinChiSqlSortBuilder class.
		/// </summary>
		public VMonHocTinChiSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion VMonHocTinChiSortBuilder

} // end namespace
