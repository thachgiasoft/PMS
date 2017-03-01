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
	/// This class is the base class for any <see cref="ViewBacDaoTaoLoaiHinhProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewBacDaoTaoLoaiHinhProviderBaseCore : EntityViewProviderBase<ViewBacDaoTaoLoaiHinh>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewBacDaoTaoLoaiHinh&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewBacDaoTaoLoaiHinh&gt;"/></returns>
		protected static VList&lt;ViewBacDaoTaoLoaiHinh&gt; Fill(DataSet dataSet, VList<ViewBacDaoTaoLoaiHinh> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewBacDaoTaoLoaiHinh>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewBacDaoTaoLoaiHinh&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewBacDaoTaoLoaiHinh>"/></returns>
		protected static VList&lt;ViewBacDaoTaoLoaiHinh&gt; Fill(DataTable dataTable, VList<ViewBacDaoTaoLoaiHinh> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewBacDaoTaoLoaiHinh c = new ViewBacDaoTaoLoaiHinh();
					c.MaBacDaoTao = (Convert.IsDBNull(row["MaBacDaoTao"]))?string.Empty:(System.String)row["MaBacDaoTao"];
					c.MaLoaiHinh = (Convert.IsDBNull(row["MaLoaiHinh"]))?string.Empty:(System.String)row["MaLoaiHinh"];
					c.MaBacLoaiHinh = (Convert.IsDBNull(row["MaBacLoaiHinh"]))?string.Empty:(System.String)row["MaBacLoaiHinh"];
					c.TenBacLoaiHinh = (Convert.IsDBNull(row["TenBacLoaiHinh"]))?string.Empty:(System.String)row["TenBacLoaiHinh"];
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
		/// Fill an <see cref="VList&lt;ViewBacDaoTaoLoaiHinh&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewBacDaoTaoLoaiHinh&gt;"/></returns>
		protected VList<ViewBacDaoTaoLoaiHinh> Fill(IDataReader reader, VList<ViewBacDaoTaoLoaiHinh> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewBacDaoTaoLoaiHinh entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewBacDaoTaoLoaiHinh>("ViewBacDaoTaoLoaiHinh",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewBacDaoTaoLoaiHinh();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaBacDaoTao = (System.String)reader["MaBacDaoTao"];
					//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
					entity.MaLoaiHinh = (System.String)reader["MaLoaiHinh"];
					//entity.MaLoaiHinh = (Convert.IsDBNull(reader["MaLoaiHinh"]))?string.Empty:(System.String)reader["MaLoaiHinh"];
					entity.MaBacLoaiHinh = (System.String)reader["MaBacLoaiHinh"];
					//entity.MaBacLoaiHinh = (Convert.IsDBNull(reader["MaBacLoaiHinh"]))?string.Empty:(System.String)reader["MaBacLoaiHinh"];
					entity.TenBacLoaiHinh = (System.String)reader["TenBacLoaiHinh"];
					//entity.TenBacLoaiHinh = (Convert.IsDBNull(reader["TenBacLoaiHinh"]))?string.Empty:(System.String)reader["TenBacLoaiHinh"];
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
		/// Refreshes the <see cref="ViewBacDaoTaoLoaiHinh"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewBacDaoTaoLoaiHinh"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewBacDaoTaoLoaiHinh entity)
		{
			reader.Read();
			entity.MaBacDaoTao = (System.String)reader["MaBacDaoTao"];
			//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
			entity.MaLoaiHinh = (System.String)reader["MaLoaiHinh"];
			//entity.MaLoaiHinh = (Convert.IsDBNull(reader["MaLoaiHinh"]))?string.Empty:(System.String)reader["MaLoaiHinh"];
			entity.MaBacLoaiHinh = (System.String)reader["MaBacLoaiHinh"];
			//entity.MaBacLoaiHinh = (Convert.IsDBNull(reader["MaBacLoaiHinh"]))?string.Empty:(System.String)reader["MaBacLoaiHinh"];
			entity.TenBacLoaiHinh = (System.String)reader["TenBacLoaiHinh"];
			//entity.TenBacLoaiHinh = (Convert.IsDBNull(reader["TenBacLoaiHinh"]))?string.Empty:(System.String)reader["TenBacLoaiHinh"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewBacDaoTaoLoaiHinh"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewBacDaoTaoLoaiHinh"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewBacDaoTaoLoaiHinh entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaBacDaoTao = (Convert.IsDBNull(dataRow["MaBacDaoTao"]))?string.Empty:(System.String)dataRow["MaBacDaoTao"];
			entity.MaLoaiHinh = (Convert.IsDBNull(dataRow["MaLoaiHinh"]))?string.Empty:(System.String)dataRow["MaLoaiHinh"];
			entity.MaBacLoaiHinh = (Convert.IsDBNull(dataRow["MaBacLoaiHinh"]))?string.Empty:(System.String)dataRow["MaBacLoaiHinh"];
			entity.TenBacLoaiHinh = (Convert.IsDBNull(dataRow["TenBacLoaiHinh"]))?string.Empty:(System.String)dataRow["TenBacLoaiHinh"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewBacDaoTaoLoaiHinhFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewBacDaoTaoLoaiHinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewBacDaoTaoLoaiHinhFilterBuilder : SqlFilterBuilder<ViewBacDaoTaoLoaiHinhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewBacDaoTaoLoaiHinhFilterBuilder class.
		/// </summary>
		public ViewBacDaoTaoLoaiHinhFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewBacDaoTaoLoaiHinhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewBacDaoTaoLoaiHinhFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewBacDaoTaoLoaiHinhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewBacDaoTaoLoaiHinhFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewBacDaoTaoLoaiHinhFilterBuilder

	#region ViewBacDaoTaoLoaiHinhParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewBacDaoTaoLoaiHinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewBacDaoTaoLoaiHinhParameterBuilder : ParameterizedSqlFilterBuilder<ViewBacDaoTaoLoaiHinhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewBacDaoTaoLoaiHinhParameterBuilder class.
		/// </summary>
		public ViewBacDaoTaoLoaiHinhParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewBacDaoTaoLoaiHinhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewBacDaoTaoLoaiHinhParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewBacDaoTaoLoaiHinhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewBacDaoTaoLoaiHinhParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewBacDaoTaoLoaiHinhParameterBuilder
	
	#region ViewBacDaoTaoLoaiHinhSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewBacDaoTaoLoaiHinh"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewBacDaoTaoLoaiHinhSortBuilder : SqlSortBuilder<ViewBacDaoTaoLoaiHinhColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewBacDaoTaoLoaiHinhSqlSortBuilder class.
		/// </summary>
		public ViewBacDaoTaoLoaiHinhSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewBacDaoTaoLoaiHinhSortBuilder

} // end namespace
