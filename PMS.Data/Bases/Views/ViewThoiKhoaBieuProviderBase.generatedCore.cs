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
	/// This class is the base class for any <see cref="ViewThoiKhoaBieuProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewThoiKhoaBieuProviderBaseCore : EntityViewProviderBase<ViewThoiKhoaBieu>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewThoiKhoaBieu&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewThoiKhoaBieu&gt;"/></returns>
		protected static VList&lt;ViewThoiKhoaBieu&gt; Fill(DataSet dataSet, VList<ViewThoiKhoaBieu> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewThoiKhoaBieu>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewThoiKhoaBieu&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewThoiKhoaBieu>"/></returns>
		protected static VList&lt;ViewThoiKhoaBieu&gt; Fill(DataTable dataTable, VList<ViewThoiKhoaBieu> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewThoiKhoaBieu c = new ViewThoiKhoaBieu();
					c.MaLichHoc = (Convert.IsDBNull(row["MaLichHoc"]))?(int)0:(System.Int32)row["MaLichHoc"];
					c.MaGocLopHocPhan = (Convert.IsDBNull(row["MaGocLopHocPhan"]))?string.Empty:(System.String)row["MaGocLopHocPhan"];
					c.MaLopHocPhan = (Convert.IsDBNull(row["MaLopHocPhan"]))?string.Empty:(System.String)row["MaLopHocPhan"];
					c.MaHocPhan = (Convert.IsDBNull(row["MaHocPhan"]))?string.Empty:(System.String)row["MaHocPhan"];
					c.TenHocPhan = (Convert.IsDBNull(row["TenHocPhan"]))?string.Empty:(System.String)row["TenHocPhan"];
					c.LoaiHocPhan = (Convert.IsDBNull(row["LoaiHocPhan"]))?string.Empty:(System.String)row["LoaiHocPhan"];
					c.MaLop = (Convert.IsDBNull(row["MaLop"]))?string.Empty:(System.String)row["MaLop"];
					c.Ngay = (Convert.IsDBNull(row["Ngay"]))?string.Empty:(System.String)row["Ngay"];
					c.Thu = (Convert.IsDBNull(row["Thu"]))?string.Empty:(System.String)row["Thu"];
					c.TietBatDau = (Convert.IsDBNull(row["TietBatDau"]))?(int)0:(System.Int32?)row["TietBatDau"];
					c.SoTiet = (Convert.IsDBNull(row["SoTiet"]))?(int)0:(System.Int32?)row["SoTiet"];
					c.Phong = (Convert.IsDBNull(row["Phong"]))?string.Empty:(System.String)row["Phong"];
					c.Khoa = (Convert.IsDBNull(row["Khoa"]))?string.Empty:(System.String)row["Khoa"];
					c.MaCanBoGiangDay = (Convert.IsDBNull(row["MaCanBoGiangDay"]))?string.Empty:(System.String)row["MaCanBoGiangDay"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.TienDo = (Convert.IsDBNull(row["TienDo"]))?string.Empty:(System.String)row["TienDo"];
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
		/// Fill an <see cref="VList&lt;ViewThoiKhoaBieu&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewThoiKhoaBieu&gt;"/></returns>
		protected VList<ViewThoiKhoaBieu> Fill(IDataReader reader, VList<ViewThoiKhoaBieu> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewThoiKhoaBieu entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewThoiKhoaBieu>("ViewThoiKhoaBieu",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewThoiKhoaBieu();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaLichHoc = (System.Int32)reader["MaLichHoc"];
					//entity.MaLichHoc = (Convert.IsDBNull(reader["MaLichHoc"]))?(int)0:(System.Int32)reader["MaLichHoc"];
					entity.MaGocLopHocPhan = (System.String)reader["MaGocLopHocPhan"];
					//entity.MaGocLopHocPhan = (Convert.IsDBNull(reader["MaGocLopHocPhan"]))?string.Empty:(System.String)reader["MaGocLopHocPhan"];
					entity.MaLopHocPhan = reader.IsDBNull(reader.GetOrdinal("MaLopHocPhan")) ? null : (System.String)reader["MaLopHocPhan"];
					//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
					entity.MaHocPhan = (System.String)reader["MaHocPhan"];
					//entity.MaHocPhan = (Convert.IsDBNull(reader["MaHocPhan"]))?string.Empty:(System.String)reader["MaHocPhan"];
					entity.TenHocPhan = (System.String)reader["TenHocPhan"];
					//entity.TenHocPhan = (Convert.IsDBNull(reader["TenHocPhan"]))?string.Empty:(System.String)reader["TenHocPhan"];
					entity.LoaiHocPhan = reader.IsDBNull(reader.GetOrdinal("LoaiHocPhan")) ? null : (System.String)reader["LoaiHocPhan"];
					//entity.LoaiHocPhan = (Convert.IsDBNull(reader["LoaiHocPhan"]))?string.Empty:(System.String)reader["LoaiHocPhan"];
					entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
					//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
					entity.Ngay = reader.IsDBNull(reader.GetOrdinal("Ngay")) ? null : (System.String)reader["Ngay"];
					//entity.Ngay = (Convert.IsDBNull(reader["Ngay"]))?string.Empty:(System.String)reader["Ngay"];
					entity.Thu = reader.IsDBNull(reader.GetOrdinal("Thu")) ? null : (System.String)reader["Thu"];
					//entity.Thu = (Convert.IsDBNull(reader["Thu"]))?string.Empty:(System.String)reader["Thu"];
					entity.TietBatDau = reader.IsDBNull(reader.GetOrdinal("TietBatDau")) ? null : (System.Int32?)reader["TietBatDau"];
					//entity.TietBatDau = (Convert.IsDBNull(reader["TietBatDau"]))?(int)0:(System.Int32?)reader["TietBatDau"];
					entity.SoTiet = reader.IsDBNull(reader.GetOrdinal("SoTiet")) ? null : (System.Int32?)reader["SoTiet"];
					//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32?)reader["SoTiet"];
					entity.Phong = reader.IsDBNull(reader.GetOrdinal("Phong")) ? null : (System.String)reader["Phong"];
					//entity.Phong = (Convert.IsDBNull(reader["Phong"]))?string.Empty:(System.String)reader["Phong"];
					entity.Khoa = reader.IsDBNull(reader.GetOrdinal("Khoa")) ? null : (System.String)reader["Khoa"];
					//entity.Khoa = (Convert.IsDBNull(reader["Khoa"]))?string.Empty:(System.String)reader["Khoa"];
					entity.MaCanBoGiangDay = (System.String)reader["MaCanBoGiangDay"];
					//entity.MaCanBoGiangDay = (Convert.IsDBNull(reader["MaCanBoGiangDay"]))?string.Empty:(System.String)reader["MaCanBoGiangDay"];
					entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.TienDo = (System.String)reader["TienDo"];
					//entity.TienDo = (Convert.IsDBNull(reader["TienDo"]))?string.Empty:(System.String)reader["TienDo"];
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
		/// Refreshes the <see cref="ViewThoiKhoaBieu"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThoiKhoaBieu"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewThoiKhoaBieu entity)
		{
			reader.Read();
			entity.MaLichHoc = (System.Int32)reader["MaLichHoc"];
			//entity.MaLichHoc = (Convert.IsDBNull(reader["MaLichHoc"]))?(int)0:(System.Int32)reader["MaLichHoc"];
			entity.MaGocLopHocPhan = (System.String)reader["MaGocLopHocPhan"];
			//entity.MaGocLopHocPhan = (Convert.IsDBNull(reader["MaGocLopHocPhan"]))?string.Empty:(System.String)reader["MaGocLopHocPhan"];
			entity.MaLopHocPhan = reader.IsDBNull(reader.GetOrdinal("MaLopHocPhan")) ? null : (System.String)reader["MaLopHocPhan"];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			entity.MaHocPhan = (System.String)reader["MaHocPhan"];
			//entity.MaHocPhan = (Convert.IsDBNull(reader["MaHocPhan"]))?string.Empty:(System.String)reader["MaHocPhan"];
			entity.TenHocPhan = (System.String)reader["TenHocPhan"];
			//entity.TenHocPhan = (Convert.IsDBNull(reader["TenHocPhan"]))?string.Empty:(System.String)reader["TenHocPhan"];
			entity.LoaiHocPhan = reader.IsDBNull(reader.GetOrdinal("LoaiHocPhan")) ? null : (System.String)reader["LoaiHocPhan"];
			//entity.LoaiHocPhan = (Convert.IsDBNull(reader["LoaiHocPhan"]))?string.Empty:(System.String)reader["LoaiHocPhan"];
			entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
			//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
			entity.Ngay = reader.IsDBNull(reader.GetOrdinal("Ngay")) ? null : (System.String)reader["Ngay"];
			//entity.Ngay = (Convert.IsDBNull(reader["Ngay"]))?string.Empty:(System.String)reader["Ngay"];
			entity.Thu = reader.IsDBNull(reader.GetOrdinal("Thu")) ? null : (System.String)reader["Thu"];
			//entity.Thu = (Convert.IsDBNull(reader["Thu"]))?string.Empty:(System.String)reader["Thu"];
			entity.TietBatDau = reader.IsDBNull(reader.GetOrdinal("TietBatDau")) ? null : (System.Int32?)reader["TietBatDau"];
			//entity.TietBatDau = (Convert.IsDBNull(reader["TietBatDau"]))?(int)0:(System.Int32?)reader["TietBatDau"];
			entity.SoTiet = reader.IsDBNull(reader.GetOrdinal("SoTiet")) ? null : (System.Int32?)reader["SoTiet"];
			//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32?)reader["SoTiet"];
			entity.Phong = reader.IsDBNull(reader.GetOrdinal("Phong")) ? null : (System.String)reader["Phong"];
			//entity.Phong = (Convert.IsDBNull(reader["Phong"]))?string.Empty:(System.String)reader["Phong"];
			entity.Khoa = reader.IsDBNull(reader.GetOrdinal("Khoa")) ? null : (System.String)reader["Khoa"];
			//entity.Khoa = (Convert.IsDBNull(reader["Khoa"]))?string.Empty:(System.String)reader["Khoa"];
			entity.MaCanBoGiangDay = (System.String)reader["MaCanBoGiangDay"];
			//entity.MaCanBoGiangDay = (Convert.IsDBNull(reader["MaCanBoGiangDay"]))?string.Empty:(System.String)reader["MaCanBoGiangDay"];
			entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.TienDo = (System.String)reader["TienDo"];
			//entity.TienDo = (Convert.IsDBNull(reader["TienDo"]))?string.Empty:(System.String)reader["TienDo"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewThoiKhoaBieu"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThoiKhoaBieu"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewThoiKhoaBieu entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaLichHoc = (Convert.IsDBNull(dataRow["MaLichHoc"]))?(int)0:(System.Int32)dataRow["MaLichHoc"];
			entity.MaGocLopHocPhan = (Convert.IsDBNull(dataRow["MaGocLopHocPhan"]))?string.Empty:(System.String)dataRow["MaGocLopHocPhan"];
			entity.MaLopHocPhan = (Convert.IsDBNull(dataRow["MaLopHocPhan"]))?string.Empty:(System.String)dataRow["MaLopHocPhan"];
			entity.MaHocPhan = (Convert.IsDBNull(dataRow["MaHocPhan"]))?string.Empty:(System.String)dataRow["MaHocPhan"];
			entity.TenHocPhan = (Convert.IsDBNull(dataRow["TenHocPhan"]))?string.Empty:(System.String)dataRow["TenHocPhan"];
			entity.LoaiHocPhan = (Convert.IsDBNull(dataRow["LoaiHocPhan"]))?string.Empty:(System.String)dataRow["LoaiHocPhan"];
			entity.MaLop = (Convert.IsDBNull(dataRow["MaLop"]))?string.Empty:(System.String)dataRow["MaLop"];
			entity.Ngay = (Convert.IsDBNull(dataRow["Ngay"]))?string.Empty:(System.String)dataRow["Ngay"];
			entity.Thu = (Convert.IsDBNull(dataRow["Thu"]))?string.Empty:(System.String)dataRow["Thu"];
			entity.TietBatDau = (Convert.IsDBNull(dataRow["TietBatDau"]))?(int)0:(System.Int32?)dataRow["TietBatDau"];
			entity.SoTiet = (Convert.IsDBNull(dataRow["SoTiet"]))?(int)0:(System.Int32?)dataRow["SoTiet"];
			entity.Phong = (Convert.IsDBNull(dataRow["Phong"]))?string.Empty:(System.String)dataRow["Phong"];
			entity.Khoa = (Convert.IsDBNull(dataRow["Khoa"]))?string.Empty:(System.String)dataRow["Khoa"];
			entity.MaCanBoGiangDay = (Convert.IsDBNull(dataRow["MaCanBoGiangDay"]))?string.Empty:(System.String)dataRow["MaCanBoGiangDay"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.TienDo = (Convert.IsDBNull(dataRow["TienDo"]))?string.Empty:(System.String)dataRow["TienDo"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewThoiKhoaBieuFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThoiKhoaBieu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThoiKhoaBieuFilterBuilder : SqlFilterBuilder<ViewThoiKhoaBieuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThoiKhoaBieuFilterBuilder class.
		/// </summary>
		public ViewThoiKhoaBieuFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThoiKhoaBieuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThoiKhoaBieuFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThoiKhoaBieuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThoiKhoaBieuFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThoiKhoaBieuFilterBuilder

	#region ViewThoiKhoaBieuParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThoiKhoaBieu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThoiKhoaBieuParameterBuilder : ParameterizedSqlFilterBuilder<ViewThoiKhoaBieuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThoiKhoaBieuParameterBuilder class.
		/// </summary>
		public ViewThoiKhoaBieuParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThoiKhoaBieuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThoiKhoaBieuParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThoiKhoaBieuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThoiKhoaBieuParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThoiKhoaBieuParameterBuilder
	
	#region ViewThoiKhoaBieuSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThoiKhoaBieu"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewThoiKhoaBieuSortBuilder : SqlSortBuilder<ViewThoiKhoaBieuColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThoiKhoaBieuSqlSortBuilder class.
		/// </summary>
		public ViewThoiKhoaBieuSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewThoiKhoaBieuSortBuilder

} // end namespace
