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
	/// This class is the base class for any <see cref="ViewCauHinhThuLaoChuanProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewCauHinhThuLaoChuanProviderBaseCore : EntityViewProviderBase<ViewCauHinhThuLaoChuan>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewCauHinhThuLaoChuan&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewCauHinhThuLaoChuan&gt;"/></returns>
		protected static VList&lt;ViewCauHinhThuLaoChuan&gt; Fill(DataSet dataSet, VList<ViewCauHinhThuLaoChuan> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewCauHinhThuLaoChuan>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewCauHinhThuLaoChuan&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewCauHinhThuLaoChuan>"/></returns>
		protected static VList&lt;ViewCauHinhThuLaoChuan&gt; Fill(DataTable dataTable, VList<ViewCauHinhThuLaoChuan> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewCauHinhThuLaoChuan c = new ViewCauHinhThuLaoChuan();
					c.MaHeDaoTao = (Convert.IsDBNull(row["MaHeDaoTao"]))?string.Empty:(System.String)row["MaHeDaoTao"];
					c.TenHeDaoTao = (Convert.IsDBNull(row["TenHeDaoTao"]))?string.Empty:(System.String)row["TenHeDaoTao"];
					c.MaBacDaoTao = (Convert.IsDBNull(row["MaBacDaoTao"]))?string.Empty:(System.String)row["MaBacDaoTao"];
					c.TenBacDaoTao = (Convert.IsDBNull(row["TenBacDaoTao"]))?string.Empty:(System.String)row["TenBacDaoTao"];
					c.MaLoaiGiangVien = (Convert.IsDBNull(row["MaLoaiGiangVien"]))?(int)0:(System.Int32)row["MaLoaiGiangVien"];
					c.TenLoaiGiangVien = (Convert.IsDBNull(row["TenLoaiGiangVien"]))?string.Empty:(System.String)row["TenLoaiGiangVien"];
					c.MaVaiTroGiangDay = (Convert.IsDBNull(row["MaVaiTroGiangDay"]))?string.Empty:(System.String)row["MaVaiTroGiangDay"];
					c.TenVaiTroGiangDay = (Convert.IsDBNull(row["TenVaiTroGiangDay"]))?string.Empty:(System.String)row["TenVaiTroGiangDay"];
					c.ThuLaoChuan = (Convert.IsDBNull(row["ThuLaoChuan"]))?(long)0:(System.Int64?)row["ThuLaoChuan"];
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
		/// Fill an <see cref="VList&lt;ViewCauHinhThuLaoChuan&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewCauHinhThuLaoChuan&gt;"/></returns>
		protected VList<ViewCauHinhThuLaoChuan> Fill(IDataReader reader, VList<ViewCauHinhThuLaoChuan> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewCauHinhThuLaoChuan entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewCauHinhThuLaoChuan>("ViewCauHinhThuLaoChuan",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewCauHinhThuLaoChuan();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaHeDaoTao = (System.String)reader["MaHeDaoTao"];
					//entity.MaHeDaoTao = (Convert.IsDBNull(reader["MaHeDaoTao"]))?string.Empty:(System.String)reader["MaHeDaoTao"];
					entity.TenHeDaoTao = (System.String)reader["TenHeDaoTao"];
					//entity.TenHeDaoTao = (Convert.IsDBNull(reader["TenHeDaoTao"]))?string.Empty:(System.String)reader["TenHeDaoTao"];
					entity.MaBacDaoTao = (System.String)reader["MaBacDaoTao"];
					//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
					entity.TenBacDaoTao = (System.String)reader["TenBacDaoTao"];
					//entity.TenBacDaoTao = (Convert.IsDBNull(reader["TenBacDaoTao"]))?string.Empty:(System.String)reader["TenBacDaoTao"];
					entity.MaLoaiGiangVien = (System.Int32)reader["MaLoaiGiangVien"];
					//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32)reader["MaLoaiGiangVien"];
					entity.TenLoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("TenLoaiGiangVien")) ? null : (System.String)reader["TenLoaiGiangVien"];
					//entity.TenLoaiGiangVien = (Convert.IsDBNull(reader["TenLoaiGiangVien"]))?string.Empty:(System.String)reader["TenLoaiGiangVien"];
					entity.MaVaiTroGiangDay = (System.String)reader["MaVaiTroGiangDay"];
					//entity.MaVaiTroGiangDay = (Convert.IsDBNull(reader["MaVaiTroGiangDay"]))?string.Empty:(System.String)reader["MaVaiTroGiangDay"];
					entity.TenVaiTroGiangDay = (System.String)reader["TenVaiTroGiangDay"];
					//entity.TenVaiTroGiangDay = (Convert.IsDBNull(reader["TenVaiTroGiangDay"]))?string.Empty:(System.String)reader["TenVaiTroGiangDay"];
					entity.ThuLaoChuan = reader.IsDBNull(reader.GetOrdinal("ThuLaoChuan")) ? null : (System.Int64?)reader["ThuLaoChuan"];
					//entity.ThuLaoChuan = (Convert.IsDBNull(reader["ThuLaoChuan"]))?(long)0:(System.Int64?)reader["ThuLaoChuan"];
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
		/// Refreshes the <see cref="ViewCauHinhThuLaoChuan"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewCauHinhThuLaoChuan"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewCauHinhThuLaoChuan entity)
		{
			reader.Read();
			entity.MaHeDaoTao = (System.String)reader["MaHeDaoTao"];
			//entity.MaHeDaoTao = (Convert.IsDBNull(reader["MaHeDaoTao"]))?string.Empty:(System.String)reader["MaHeDaoTao"];
			entity.TenHeDaoTao = (System.String)reader["TenHeDaoTao"];
			//entity.TenHeDaoTao = (Convert.IsDBNull(reader["TenHeDaoTao"]))?string.Empty:(System.String)reader["TenHeDaoTao"];
			entity.MaBacDaoTao = (System.String)reader["MaBacDaoTao"];
			//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
			entity.TenBacDaoTao = (System.String)reader["TenBacDaoTao"];
			//entity.TenBacDaoTao = (Convert.IsDBNull(reader["TenBacDaoTao"]))?string.Empty:(System.String)reader["TenBacDaoTao"];
			entity.MaLoaiGiangVien = (System.Int32)reader["MaLoaiGiangVien"];
			//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32)reader["MaLoaiGiangVien"];
			entity.TenLoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("TenLoaiGiangVien")) ? null : (System.String)reader["TenLoaiGiangVien"];
			//entity.TenLoaiGiangVien = (Convert.IsDBNull(reader["TenLoaiGiangVien"]))?string.Empty:(System.String)reader["TenLoaiGiangVien"];
			entity.MaVaiTroGiangDay = (System.String)reader["MaVaiTroGiangDay"];
			//entity.MaVaiTroGiangDay = (Convert.IsDBNull(reader["MaVaiTroGiangDay"]))?string.Empty:(System.String)reader["MaVaiTroGiangDay"];
			entity.TenVaiTroGiangDay = (System.String)reader["TenVaiTroGiangDay"];
			//entity.TenVaiTroGiangDay = (Convert.IsDBNull(reader["TenVaiTroGiangDay"]))?string.Empty:(System.String)reader["TenVaiTroGiangDay"];
			entity.ThuLaoChuan = reader.IsDBNull(reader.GetOrdinal("ThuLaoChuan")) ? null : (System.Int64?)reader["ThuLaoChuan"];
			//entity.ThuLaoChuan = (Convert.IsDBNull(reader["ThuLaoChuan"]))?(long)0:(System.Int64?)reader["ThuLaoChuan"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewCauHinhThuLaoChuan"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewCauHinhThuLaoChuan"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewCauHinhThuLaoChuan entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaHeDaoTao = (Convert.IsDBNull(dataRow["MaHeDaoTao"]))?string.Empty:(System.String)dataRow["MaHeDaoTao"];
			entity.TenHeDaoTao = (Convert.IsDBNull(dataRow["TenHeDaoTao"]))?string.Empty:(System.String)dataRow["TenHeDaoTao"];
			entity.MaBacDaoTao = (Convert.IsDBNull(dataRow["MaBacDaoTao"]))?string.Empty:(System.String)dataRow["MaBacDaoTao"];
			entity.TenBacDaoTao = (Convert.IsDBNull(dataRow["TenBacDaoTao"]))?string.Empty:(System.String)dataRow["TenBacDaoTao"];
			entity.MaLoaiGiangVien = (Convert.IsDBNull(dataRow["MaLoaiGiangVien"]))?(int)0:(System.Int32)dataRow["MaLoaiGiangVien"];
			entity.TenLoaiGiangVien = (Convert.IsDBNull(dataRow["TenLoaiGiangVien"]))?string.Empty:(System.String)dataRow["TenLoaiGiangVien"];
			entity.MaVaiTroGiangDay = (Convert.IsDBNull(dataRow["MaVaiTroGiangDay"]))?string.Empty:(System.String)dataRow["MaVaiTroGiangDay"];
			entity.TenVaiTroGiangDay = (Convert.IsDBNull(dataRow["TenVaiTroGiangDay"]))?string.Empty:(System.String)dataRow["TenVaiTroGiangDay"];
			entity.ThuLaoChuan = (Convert.IsDBNull(dataRow["ThuLaoChuan"]))?(long)0:(System.Int64?)dataRow["ThuLaoChuan"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewCauHinhThuLaoChuanFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewCauHinhThuLaoChuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewCauHinhThuLaoChuanFilterBuilder : SqlFilterBuilder<ViewCauHinhThuLaoChuanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewCauHinhThuLaoChuanFilterBuilder class.
		/// </summary>
		public ViewCauHinhThuLaoChuanFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewCauHinhThuLaoChuanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewCauHinhThuLaoChuanFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewCauHinhThuLaoChuanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewCauHinhThuLaoChuanFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewCauHinhThuLaoChuanFilterBuilder

	#region ViewCauHinhThuLaoChuanParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewCauHinhThuLaoChuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewCauHinhThuLaoChuanParameterBuilder : ParameterizedSqlFilterBuilder<ViewCauHinhThuLaoChuanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewCauHinhThuLaoChuanParameterBuilder class.
		/// </summary>
		public ViewCauHinhThuLaoChuanParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewCauHinhThuLaoChuanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewCauHinhThuLaoChuanParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewCauHinhThuLaoChuanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewCauHinhThuLaoChuanParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewCauHinhThuLaoChuanParameterBuilder
	
	#region ViewCauHinhThuLaoChuanSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewCauHinhThuLaoChuan"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewCauHinhThuLaoChuanSortBuilder : SqlSortBuilder<ViewCauHinhThuLaoChuanColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewCauHinhThuLaoChuanSqlSortBuilder class.
		/// </summary>
		public ViewCauHinhThuLaoChuanSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewCauHinhThuLaoChuanSortBuilder

} // end namespace
