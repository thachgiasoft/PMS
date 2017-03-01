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
	/// This class is the base class for any <see cref="ViewHeSoLopDongHbuProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewHeSoLopDongHbuProviderBaseCore : EntityViewProviderBase<ViewHeSoLopDongHbu>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewHeSoLopDongHbu&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewHeSoLopDongHbu&gt;"/></returns>
		protected static VList&lt;ViewHeSoLopDongHbu&gt; Fill(DataSet dataSet, VList<ViewHeSoLopDongHbu> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewHeSoLopDongHbu>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewHeSoLopDongHbu&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewHeSoLopDongHbu>"/></returns>
		protected static VList&lt;ViewHeSoLopDongHbu&gt; Fill(DataTable dataTable, VList<ViewHeSoLopDongHbu> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewHeSoLopDongHbu c = new ViewHeSoLopDongHbu();
					c.MaNhomMonHoc = (Convert.IsDBNull(row["MaNhomMonHoc"]))?string.Empty:(System.String)row["MaNhomMonHoc"];
					c.TenNhomMon = (Convert.IsDBNull(row["TenNhomMon"]))?string.Empty:(System.String)row["TenNhomMon"];
					c.TuKhoan = (Convert.IsDBNull(row["TuKhoan"]))?(int)0:(System.Int32?)row["TuKhoan"];
					c.DenKhoan = (Convert.IsDBNull(row["DenKhoan"]))?(int)0:(System.Int32?)row["DenKhoan"];
					c.HeSo = (Convert.IsDBNull(row["HeSo"]))?0.0m:(System.Decimal?)row["HeSo"];
					c.NgayCapNhat = (Convert.IsDBNull(row["NgayCapNhat"]))?string.Empty:(System.String)row["NgayCapNhat"];
					c.NguoiCapNhat = (Convert.IsDBNull(row["NguoiCapNhat"]))?string.Empty:(System.String)row["NguoiCapNhat"];
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
		/// Fill an <see cref="VList&lt;ViewHeSoLopDongHbu&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewHeSoLopDongHbu&gt;"/></returns>
		protected VList<ViewHeSoLopDongHbu> Fill(IDataReader reader, VList<ViewHeSoLopDongHbu> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewHeSoLopDongHbu entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewHeSoLopDongHbu>("ViewHeSoLopDongHbu",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewHeSoLopDongHbu();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaNhomMonHoc = reader.IsDBNull(reader.GetOrdinal("MaNhomMonHoc")) ? null : (System.String)reader["MaNhomMonHoc"];
					//entity.MaNhomMonHoc = (Convert.IsDBNull(reader["MaNhomMonHoc"]))?string.Empty:(System.String)reader["MaNhomMonHoc"];
					entity.TenNhomMon = reader.IsDBNull(reader.GetOrdinal("TenNhomMon")) ? null : (System.String)reader["TenNhomMon"];
					//entity.TenNhomMon = (Convert.IsDBNull(reader["TenNhomMon"]))?string.Empty:(System.String)reader["TenNhomMon"];
					entity.TuKhoan = reader.IsDBNull(reader.GetOrdinal("TuKhoan")) ? null : (System.Int32?)reader["TuKhoan"];
					//entity.TuKhoan = (Convert.IsDBNull(reader["TuKhoan"]))?(int)0:(System.Int32?)reader["TuKhoan"];
					entity.DenKhoan = reader.IsDBNull(reader.GetOrdinal("DenKhoan")) ? null : (System.Int32?)reader["DenKhoan"];
					//entity.DenKhoan = (Convert.IsDBNull(reader["DenKhoan"]))?(int)0:(System.Int32?)reader["DenKhoan"];
					entity.HeSo = reader.IsDBNull(reader.GetOrdinal("HeSo")) ? null : (System.Decimal?)reader["HeSo"];
					//entity.HeSo = (Convert.IsDBNull(reader["HeSo"]))?0.0m:(System.Decimal?)reader["HeSo"];
					entity.NgayCapNhat = reader.IsDBNull(reader.GetOrdinal("NgayCapNhat")) ? null : (System.String)reader["NgayCapNhat"];
					//entity.NgayCapNhat = (Convert.IsDBNull(reader["NgayCapNhat"]))?string.Empty:(System.String)reader["NgayCapNhat"];
					entity.NguoiCapNhat = reader.IsDBNull(reader.GetOrdinal("NguoiCapNhat")) ? null : (System.String)reader["NguoiCapNhat"];
					//entity.NguoiCapNhat = (Convert.IsDBNull(reader["NguoiCapNhat"]))?string.Empty:(System.String)reader["NguoiCapNhat"];
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
		/// Refreshes the <see cref="ViewHeSoLopDongHbu"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewHeSoLopDongHbu"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewHeSoLopDongHbu entity)
		{
			reader.Read();
			entity.MaNhomMonHoc = reader.IsDBNull(reader.GetOrdinal("MaNhomMonHoc")) ? null : (System.String)reader["MaNhomMonHoc"];
			//entity.MaNhomMonHoc = (Convert.IsDBNull(reader["MaNhomMonHoc"]))?string.Empty:(System.String)reader["MaNhomMonHoc"];
			entity.TenNhomMon = reader.IsDBNull(reader.GetOrdinal("TenNhomMon")) ? null : (System.String)reader["TenNhomMon"];
			//entity.TenNhomMon = (Convert.IsDBNull(reader["TenNhomMon"]))?string.Empty:(System.String)reader["TenNhomMon"];
			entity.TuKhoan = reader.IsDBNull(reader.GetOrdinal("TuKhoan")) ? null : (System.Int32?)reader["TuKhoan"];
			//entity.TuKhoan = (Convert.IsDBNull(reader["TuKhoan"]))?(int)0:(System.Int32?)reader["TuKhoan"];
			entity.DenKhoan = reader.IsDBNull(reader.GetOrdinal("DenKhoan")) ? null : (System.Int32?)reader["DenKhoan"];
			//entity.DenKhoan = (Convert.IsDBNull(reader["DenKhoan"]))?(int)0:(System.Int32?)reader["DenKhoan"];
			entity.HeSo = reader.IsDBNull(reader.GetOrdinal("HeSo")) ? null : (System.Decimal?)reader["HeSo"];
			//entity.HeSo = (Convert.IsDBNull(reader["HeSo"]))?0.0m:(System.Decimal?)reader["HeSo"];
			entity.NgayCapNhat = reader.IsDBNull(reader.GetOrdinal("NgayCapNhat")) ? null : (System.String)reader["NgayCapNhat"];
			//entity.NgayCapNhat = (Convert.IsDBNull(reader["NgayCapNhat"]))?string.Empty:(System.String)reader["NgayCapNhat"];
			entity.NguoiCapNhat = reader.IsDBNull(reader.GetOrdinal("NguoiCapNhat")) ? null : (System.String)reader["NguoiCapNhat"];
			//entity.NguoiCapNhat = (Convert.IsDBNull(reader["NguoiCapNhat"]))?string.Empty:(System.String)reader["NguoiCapNhat"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewHeSoLopDongHbu"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewHeSoLopDongHbu"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewHeSoLopDongHbu entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaNhomMonHoc = (Convert.IsDBNull(dataRow["MaNhomMonHoc"]))?string.Empty:(System.String)dataRow["MaNhomMonHoc"];
			entity.TenNhomMon = (Convert.IsDBNull(dataRow["TenNhomMon"]))?string.Empty:(System.String)dataRow["TenNhomMon"];
			entity.TuKhoan = (Convert.IsDBNull(dataRow["TuKhoan"]))?(int)0:(System.Int32?)dataRow["TuKhoan"];
			entity.DenKhoan = (Convert.IsDBNull(dataRow["DenKhoan"]))?(int)0:(System.Int32?)dataRow["DenKhoan"];
			entity.HeSo = (Convert.IsDBNull(dataRow["HeSo"]))?0.0m:(System.Decimal?)dataRow["HeSo"];
			entity.NgayCapNhat = (Convert.IsDBNull(dataRow["NgayCapNhat"]))?string.Empty:(System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = (Convert.IsDBNull(dataRow["NguoiCapNhat"]))?string.Empty:(System.String)dataRow["NguoiCapNhat"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewHeSoLopDongHbuFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHeSoLopDongHbu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHeSoLopDongHbuFilterBuilder : SqlFilterBuilder<ViewHeSoLopDongHbuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHeSoLopDongHbuFilterBuilder class.
		/// </summary>
		public ViewHeSoLopDongHbuFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewHeSoLopDongHbuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewHeSoLopDongHbuFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewHeSoLopDongHbuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewHeSoLopDongHbuFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewHeSoLopDongHbuFilterBuilder

	#region ViewHeSoLopDongHbuParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHeSoLopDongHbu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHeSoLopDongHbuParameterBuilder : ParameterizedSqlFilterBuilder<ViewHeSoLopDongHbuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHeSoLopDongHbuParameterBuilder class.
		/// </summary>
		public ViewHeSoLopDongHbuParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewHeSoLopDongHbuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewHeSoLopDongHbuParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewHeSoLopDongHbuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewHeSoLopDongHbuParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewHeSoLopDongHbuParameterBuilder
	
	#region ViewHeSoLopDongHbuSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHeSoLopDongHbu"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewHeSoLopDongHbuSortBuilder : SqlSortBuilder<ViewHeSoLopDongHbuColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHeSoLopDongHbuSqlSortBuilder class.
		/// </summary>
		public ViewHeSoLopDongHbuSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewHeSoLopDongHbuSortBuilder

} // end namespace
