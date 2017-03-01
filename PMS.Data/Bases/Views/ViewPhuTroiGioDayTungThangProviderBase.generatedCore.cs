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
	/// This class is the base class for any <see cref="ViewPhuTroiGioDayTungThangProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewPhuTroiGioDayTungThangProviderBaseCore : EntityViewProviderBase<ViewPhuTroiGioDayTungThang>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewPhuTroiGioDayTungThang&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewPhuTroiGioDayTungThang&gt;"/></returns>
		protected static VList&lt;ViewPhuTroiGioDayTungThang&gt; Fill(DataSet dataSet, VList<ViewPhuTroiGioDayTungThang> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewPhuTroiGioDayTungThang>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewPhuTroiGioDayTungThang&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewPhuTroiGioDayTungThang>"/></returns>
		protected static VList&lt;ViewPhuTroiGioDayTungThang&gt; Fill(DataTable dataTable, VList<ViewPhuTroiGioDayTungThang> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewPhuTroiGioDayTungThang c = new ViewPhuTroiGioDayTungThang();
					c.MaCauHinhChotGio = (Convert.IsDBNull(row["MaCauHinhChotGio"]))?(int)0:(System.Int32)row["MaCauHinhChotGio"];
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.TenQuanLy = (Convert.IsDBNull(row["TenQuanLy"]))?string.Empty:(System.String)row["TenQuanLy"];
					c.TuNgay = (Convert.IsDBNull(row["TuNgay"]))?DateTime.MinValue:(System.DateTime?)row["TuNgay"];
					c.DenNgay = (Convert.IsDBNull(row["DenNgay"]))?DateTime.MinValue:(System.DateTime?)row["DenNgay"];
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
		/// Fill an <see cref="VList&lt;ViewPhuTroiGioDayTungThang&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewPhuTroiGioDayTungThang&gt;"/></returns>
		protected VList<ViewPhuTroiGioDayTungThang> Fill(IDataReader reader, VList<ViewPhuTroiGioDayTungThang> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewPhuTroiGioDayTungThang entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewPhuTroiGioDayTungThang>("ViewPhuTroiGioDayTungThang",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewPhuTroiGioDayTungThang();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaCauHinhChotGio = (System.Int32)reader[((int)ViewPhuTroiGioDayTungThangColumn.MaCauHinhChotGio)];
					//entity.MaCauHinhChotGio = (Convert.IsDBNull(reader["MaCauHinhChotGio"]))?(int)0:(System.Int32)reader["MaCauHinhChotGio"];
					entity.MaQuanLy = (reader.IsDBNull(((int)ViewPhuTroiGioDayTungThangColumn.MaQuanLy)))?null:(System.String)reader[((int)ViewPhuTroiGioDayTungThangColumn.MaQuanLy)];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.TenQuanLy = (reader.IsDBNull(((int)ViewPhuTroiGioDayTungThangColumn.TenQuanLy)))?null:(System.String)reader[((int)ViewPhuTroiGioDayTungThangColumn.TenQuanLy)];
					//entity.TenQuanLy = (Convert.IsDBNull(reader["TenQuanLy"]))?string.Empty:(System.String)reader["TenQuanLy"];
					entity.TuNgay = (reader.IsDBNull(((int)ViewPhuTroiGioDayTungThangColumn.TuNgay)))?null:(System.DateTime?)reader[((int)ViewPhuTroiGioDayTungThangColumn.TuNgay)];
					//entity.TuNgay = (Convert.IsDBNull(reader["TuNgay"]))?DateTime.MinValue:(System.DateTime?)reader["TuNgay"];
					entity.DenNgay = (reader.IsDBNull(((int)ViewPhuTroiGioDayTungThangColumn.DenNgay)))?null:(System.DateTime?)reader[((int)ViewPhuTroiGioDayTungThangColumn.DenNgay)];
					//entity.DenNgay = (Convert.IsDBNull(reader["DenNgay"]))?DateTime.MinValue:(System.DateTime?)reader["DenNgay"];
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
		/// Refreshes the <see cref="ViewPhuTroiGioDayTungThang"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewPhuTroiGioDayTungThang"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewPhuTroiGioDayTungThang entity)
		{
			reader.Read();
			entity.MaCauHinhChotGio = (System.Int32)reader[((int)ViewPhuTroiGioDayTungThangColumn.MaCauHinhChotGio)];
			//entity.MaCauHinhChotGio = (Convert.IsDBNull(reader["MaCauHinhChotGio"]))?(int)0:(System.Int32)reader["MaCauHinhChotGio"];
			entity.MaQuanLy = (reader.IsDBNull(((int)ViewPhuTroiGioDayTungThangColumn.MaQuanLy)))?null:(System.String)reader[((int)ViewPhuTroiGioDayTungThangColumn.MaQuanLy)];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.TenQuanLy = (reader.IsDBNull(((int)ViewPhuTroiGioDayTungThangColumn.TenQuanLy)))?null:(System.String)reader[((int)ViewPhuTroiGioDayTungThangColumn.TenQuanLy)];
			//entity.TenQuanLy = (Convert.IsDBNull(reader["TenQuanLy"]))?string.Empty:(System.String)reader["TenQuanLy"];
			entity.TuNgay = (reader.IsDBNull(((int)ViewPhuTroiGioDayTungThangColumn.TuNgay)))?null:(System.DateTime?)reader[((int)ViewPhuTroiGioDayTungThangColumn.TuNgay)];
			//entity.TuNgay = (Convert.IsDBNull(reader["TuNgay"]))?DateTime.MinValue:(System.DateTime?)reader["TuNgay"];
			entity.DenNgay = (reader.IsDBNull(((int)ViewPhuTroiGioDayTungThangColumn.DenNgay)))?null:(System.DateTime?)reader[((int)ViewPhuTroiGioDayTungThangColumn.DenNgay)];
			//entity.DenNgay = (Convert.IsDBNull(reader["DenNgay"]))?DateTime.MinValue:(System.DateTime?)reader["DenNgay"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewPhuTroiGioDayTungThang"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewPhuTroiGioDayTungThang"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewPhuTroiGioDayTungThang entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaCauHinhChotGio = (Convert.IsDBNull(dataRow["MaCauHinhChotGio"]))?(int)0:(System.Int32)dataRow["MaCauHinhChotGio"];
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.TenQuanLy = (Convert.IsDBNull(dataRow["TenQuanLy"]))?string.Empty:(System.String)dataRow["TenQuanLy"];
			entity.TuNgay = (Convert.IsDBNull(dataRow["TuNgay"]))?DateTime.MinValue:(System.DateTime?)dataRow["TuNgay"];
			entity.DenNgay = (Convert.IsDBNull(dataRow["DenNgay"]))?DateTime.MinValue:(System.DateTime?)dataRow["DenNgay"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewPhuTroiGioDayTungThangFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhuTroiGioDayTungThang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhuTroiGioDayTungThangFilterBuilder : SqlFilterBuilder<ViewPhuTroiGioDayTungThangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhuTroiGioDayTungThangFilterBuilder class.
		/// </summary>
		public ViewPhuTroiGioDayTungThangFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewPhuTroiGioDayTungThangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewPhuTroiGioDayTungThangFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewPhuTroiGioDayTungThangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewPhuTroiGioDayTungThangFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewPhuTroiGioDayTungThangFilterBuilder

	#region ViewPhuTroiGioDayTungThangParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhuTroiGioDayTungThang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhuTroiGioDayTungThangParameterBuilder : ParameterizedSqlFilterBuilder<ViewPhuTroiGioDayTungThangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhuTroiGioDayTungThangParameterBuilder class.
		/// </summary>
		public ViewPhuTroiGioDayTungThangParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewPhuTroiGioDayTungThangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewPhuTroiGioDayTungThangParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewPhuTroiGioDayTungThangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewPhuTroiGioDayTungThangParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewPhuTroiGioDayTungThangParameterBuilder
	
	#region ViewPhuTroiGioDayTungThangSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhuTroiGioDayTungThang"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewPhuTroiGioDayTungThangSortBuilder : SqlSortBuilder<ViewPhuTroiGioDayTungThangColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhuTroiGioDayTungThangSqlSortBuilder class.
		/// </summary>
		public ViewPhuTroiGioDayTungThangSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewPhuTroiGioDayTungThangSortBuilder

} // end namespace
