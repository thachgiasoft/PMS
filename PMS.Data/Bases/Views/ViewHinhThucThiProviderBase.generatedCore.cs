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
	/// This class is the base class for any <see cref="ViewHinhThucThiProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewHinhThucThiProviderBaseCore : EntityViewProviderBase<ViewHinhThucThi>
	{
		#region Custom Methods
		
		
		#region cust_View_HinhThucThi_GetThoiGianThi
		
		/// <summary>
		///	This method wrap the 'cust_View_HinhThucThi_GetThoiGianThi' stored procedure. 
		/// </summary>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThoiGianThi()
		{
			return GetThoiGianThi(null, 0, int.MaxValue );
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_HinhThucThi_GetThoiGianThi' stored procedure. 
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThoiGianThi(int start, int pageLength)
		{
			return GetThoiGianThi(null, start, pageLength );
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_HinhThucThi_GetThoiGianThi' stored procedure. 
		/// </summary>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThoiGianThi(TransactionManager transactionManager)
		{
			return GetThoiGianThi(transactionManager, 0, int.MaxValue );
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_HinhThucThi_GetThoiGianThi' stored procedure. 
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetThoiGianThi(TransactionManager transactionManager, int start, int pageLength);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewHinhThucThi&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewHinhThucThi&gt;"/></returns>
		protected static VList&lt;ViewHinhThucThi&gt; Fill(DataSet dataSet, VList<ViewHinhThucThi> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewHinhThucThi>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewHinhThucThi&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewHinhThucThi>"/></returns>
		protected static VList&lt;ViewHinhThucThi&gt; Fill(DataTable dataTable, VList<ViewHinhThucThi> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewHinhThucThi c = new ViewHinhThucThi();
					c.MaHinhThucThi = (Convert.IsDBNull(row["MaHinhThucThi"]))?string.Empty:(System.String)row["MaHinhThucThi"];
					c.TenHinhThucThi = (Convert.IsDBNull(row["TenHinhThucThi"]))?string.Empty:(System.String)row["TenHinhThucThi"];
					c.ThoiGianThi = (Convert.IsDBNull(row["ThoiGianThi"]))?string.Empty:(System.String)row["ThoiGianThi"];
					c.GhiChu = (Convert.IsDBNull(row["GhiChu"]))?string.Empty:(System.String)row["GhiChu"];
					c.Coefficient = (Convert.IsDBNull(row["Coefficient"]))?0.0m:(System.Decimal?)row["Coefficient"];
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
		/// Fill an <see cref="VList&lt;ViewHinhThucThi&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewHinhThucThi&gt;"/></returns>
		protected VList<ViewHinhThucThi> Fill(IDataReader reader, VList<ViewHinhThucThi> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewHinhThucThi entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewHinhThucThi>("ViewHinhThucThi",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewHinhThucThi();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaHinhThucThi = (System.String)reader["MaHinhThucThi"];
					//entity.MaHinhThucThi = (Convert.IsDBNull(reader["MaHinhThucThi"]))?string.Empty:(System.String)reader["MaHinhThucThi"];
					entity.TenHinhThucThi = reader.IsDBNull(reader.GetOrdinal("TenHinhThucThi")) ? null : (System.String)reader["TenHinhThucThi"];
					//entity.TenHinhThucThi = (Convert.IsDBNull(reader["TenHinhThucThi"]))?string.Empty:(System.String)reader["TenHinhThucThi"];
					entity.ThoiGianThi = reader.IsDBNull(reader.GetOrdinal("ThoiGianThi")) ? null : (System.String)reader["ThoiGianThi"];
					//entity.ThoiGianThi = (Convert.IsDBNull(reader["ThoiGianThi"]))?string.Empty:(System.String)reader["ThoiGianThi"];
					entity.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : (System.String)reader["GhiChu"];
					//entity.GhiChu = (Convert.IsDBNull(reader["GhiChu"]))?string.Empty:(System.String)reader["GhiChu"];
					entity.Coefficient = reader.IsDBNull(reader.GetOrdinal("Coefficient")) ? null : (System.Decimal?)reader["Coefficient"];
					//entity.Coefficient = (Convert.IsDBNull(reader["Coefficient"]))?0.0m:(System.Decimal?)reader["Coefficient"];
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
		/// Refreshes the <see cref="ViewHinhThucThi"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewHinhThucThi"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewHinhThucThi entity)
		{
			reader.Read();
			entity.MaHinhThucThi = (System.String)reader["MaHinhThucThi"];
			//entity.MaHinhThucThi = (Convert.IsDBNull(reader["MaHinhThucThi"]))?string.Empty:(System.String)reader["MaHinhThucThi"];
			entity.TenHinhThucThi = reader.IsDBNull(reader.GetOrdinal("TenHinhThucThi")) ? null : (System.String)reader["TenHinhThucThi"];
			//entity.TenHinhThucThi = (Convert.IsDBNull(reader["TenHinhThucThi"]))?string.Empty:(System.String)reader["TenHinhThucThi"];
			entity.ThoiGianThi = reader.IsDBNull(reader.GetOrdinal("ThoiGianThi")) ? null : (System.String)reader["ThoiGianThi"];
			//entity.ThoiGianThi = (Convert.IsDBNull(reader["ThoiGianThi"]))?string.Empty:(System.String)reader["ThoiGianThi"];
			entity.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : (System.String)reader["GhiChu"];
			//entity.GhiChu = (Convert.IsDBNull(reader["GhiChu"]))?string.Empty:(System.String)reader["GhiChu"];
			entity.Coefficient = reader.IsDBNull(reader.GetOrdinal("Coefficient")) ? null : (System.Decimal?)reader["Coefficient"];
			//entity.Coefficient = (Convert.IsDBNull(reader["Coefficient"]))?0.0m:(System.Decimal?)reader["Coefficient"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewHinhThucThi"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewHinhThucThi"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewHinhThucThi entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaHinhThucThi = (Convert.IsDBNull(dataRow["MaHinhThucThi"]))?string.Empty:(System.String)dataRow["MaHinhThucThi"];
			entity.TenHinhThucThi = (Convert.IsDBNull(dataRow["TenHinhThucThi"]))?string.Empty:(System.String)dataRow["TenHinhThucThi"];
			entity.ThoiGianThi = (Convert.IsDBNull(dataRow["ThoiGianThi"]))?string.Empty:(System.String)dataRow["ThoiGianThi"];
			entity.GhiChu = (Convert.IsDBNull(dataRow["GhiChu"]))?string.Empty:(System.String)dataRow["GhiChu"];
			entity.Coefficient = (Convert.IsDBNull(dataRow["Coefficient"]))?0.0m:(System.Decimal?)dataRow["Coefficient"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewHinhThucThiFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHinhThucThi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHinhThucThiFilterBuilder : SqlFilterBuilder<ViewHinhThucThiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHinhThucThiFilterBuilder class.
		/// </summary>
		public ViewHinhThucThiFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewHinhThucThiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewHinhThucThiFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewHinhThucThiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewHinhThucThiFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewHinhThucThiFilterBuilder

	#region ViewHinhThucThiParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHinhThucThi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHinhThucThiParameterBuilder : ParameterizedSqlFilterBuilder<ViewHinhThucThiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHinhThucThiParameterBuilder class.
		/// </summary>
		public ViewHinhThucThiParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewHinhThucThiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewHinhThucThiParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewHinhThucThiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewHinhThucThiParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewHinhThucThiParameterBuilder
	
	#region ViewHinhThucThiSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHinhThucThi"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewHinhThucThiSortBuilder : SqlSortBuilder<ViewHinhThucThiColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHinhThucThiSqlSortBuilder class.
		/// </summary>
		public ViewHinhThucThiSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewHinhThucThiSortBuilder

} // end namespace
