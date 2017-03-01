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
	/// This class is the base class for any <see cref="ViewDoiTuongDonGiaProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewDoiTuongDonGiaProviderBaseCore : EntityViewProviderBase<ViewDoiTuongDonGia>
	{
		#region Custom Methods
		
		
		#region cust_View_DoiTuongDonGia_GetTenGoiByMaQuanLy
		
		/// <summary>
		///	This method wrap the 'cust_View_DoiTuongDonGia_GetTenGoiByMaQuanLy' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewDoiTuongDonGia&gt;"/> instance.</returns>
		public VList<ViewDoiTuongDonGia> GetTenGoiByMaQuanLy(System.String maQuanLy)
		{
			return GetTenGoiByMaQuanLy(null, 0, int.MaxValue , maQuanLy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_DoiTuongDonGia_GetTenGoiByMaQuanLy' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewDoiTuongDonGia&gt;"/> instance.</returns>
		public VList<ViewDoiTuongDonGia> GetTenGoiByMaQuanLy(int start, int pageLength, System.String maQuanLy)
		{
			return GetTenGoiByMaQuanLy(null, start, pageLength , maQuanLy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_DoiTuongDonGia_GetTenGoiByMaQuanLy' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewDoiTuongDonGia&gt;"/> instance.</returns>
		public VList<ViewDoiTuongDonGia> GetTenGoiByMaQuanLy(TransactionManager transactionManager, System.String maQuanLy)
		{
			return GetTenGoiByMaQuanLy(transactionManager, 0, int.MaxValue , maQuanLy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_DoiTuongDonGia_GetTenGoiByMaQuanLy' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewDoiTuongDonGia&gt;"/> instance.</returns>
		public abstract VList<ViewDoiTuongDonGia> GetTenGoiByMaQuanLy(TransactionManager transactionManager, int start, int pageLength, System.String maQuanLy);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewDoiTuongDonGia&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewDoiTuongDonGia&gt;"/></returns>
		protected static VList&lt;ViewDoiTuongDonGia&gt; Fill(DataSet dataSet, VList<ViewDoiTuongDonGia> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewDoiTuongDonGia>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewDoiTuongDonGia&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewDoiTuongDonGia>"/></returns>
		protected static VList&lt;ViewDoiTuongDonGia&gt; Fill(DataTable dataTable, VList<ViewDoiTuongDonGia> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewDoiTuongDonGia c = new ViewDoiTuongDonGia();
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.TenGoi = (Convert.IsDBNull(row["TenGoi"]))?string.Empty:(System.String)row["TenGoi"];
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
		/// Fill an <see cref="VList&lt;ViewDoiTuongDonGia&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewDoiTuongDonGia&gt;"/></returns>
		protected VList<ViewDoiTuongDonGia> Fill(IDataReader reader, VList<ViewDoiTuongDonGia> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewDoiTuongDonGia entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewDoiTuongDonGia>("ViewDoiTuongDonGia",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewDoiTuongDonGia();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaQuanLy = reader.IsDBNull(reader.GetOrdinal("MaQuanLy")) ? null : (System.String)reader["MaQuanLy"];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.TenGoi = reader.IsDBNull(reader.GetOrdinal("TenGoi")) ? null : (System.String)reader["TenGoi"];
					//entity.TenGoi = (Convert.IsDBNull(reader["TenGoi"]))?string.Empty:(System.String)reader["TenGoi"];
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
		/// Refreshes the <see cref="ViewDoiTuongDonGia"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewDoiTuongDonGia"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewDoiTuongDonGia entity)
		{
			reader.Read();
			entity.MaQuanLy = reader.IsDBNull(reader.GetOrdinal("MaQuanLy")) ? null : (System.String)reader["MaQuanLy"];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.TenGoi = reader.IsDBNull(reader.GetOrdinal("TenGoi")) ? null : (System.String)reader["TenGoi"];
			//entity.TenGoi = (Convert.IsDBNull(reader["TenGoi"]))?string.Empty:(System.String)reader["TenGoi"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewDoiTuongDonGia"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewDoiTuongDonGia"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewDoiTuongDonGia entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.TenGoi = (Convert.IsDBNull(dataRow["TenGoi"]))?string.Empty:(System.String)dataRow["TenGoi"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewDoiTuongDonGiaFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewDoiTuongDonGia"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewDoiTuongDonGiaFilterBuilder : SqlFilterBuilder<ViewDoiTuongDonGiaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewDoiTuongDonGiaFilterBuilder class.
		/// </summary>
		public ViewDoiTuongDonGiaFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewDoiTuongDonGiaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewDoiTuongDonGiaFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewDoiTuongDonGiaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewDoiTuongDonGiaFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewDoiTuongDonGiaFilterBuilder

	#region ViewDoiTuongDonGiaParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewDoiTuongDonGia"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewDoiTuongDonGiaParameterBuilder : ParameterizedSqlFilterBuilder<ViewDoiTuongDonGiaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewDoiTuongDonGiaParameterBuilder class.
		/// </summary>
		public ViewDoiTuongDonGiaParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewDoiTuongDonGiaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewDoiTuongDonGiaParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewDoiTuongDonGiaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewDoiTuongDonGiaParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewDoiTuongDonGiaParameterBuilder
	
	#region ViewDoiTuongDonGiaSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewDoiTuongDonGia"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewDoiTuongDonGiaSortBuilder : SqlSortBuilder<ViewDoiTuongDonGiaColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewDoiTuongDonGiaSqlSortBuilder class.
		/// </summary>
		public ViewDoiTuongDonGiaSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewDoiTuongDonGiaSortBuilder

} // end namespace
