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
	/// This class is the base class for any <see cref="ViewNamHocProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewNamHocProviderBaseCore : EntityViewProviderBase<ViewNamHoc>
	{
		#region Custom Methods
		
		
		#region cust_View_NamHoc_GetNamHocByNgay
		
		/// <summary>
		///	This method wrap the 'cust_View_NamHoc_GetNamHocByNgay' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetNamHocByNgay(System.DateTime ngay)
		{
			return GetNamHocByNgay(null, 0, int.MaxValue , ngay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_NamHoc_GetNamHocByNgay' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetNamHocByNgay(int start, int pageLength, System.DateTime ngay)
		{
			return GetNamHocByNgay(null, start, pageLength , ngay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_NamHoc_GetNamHocByNgay' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetNamHocByNgay(TransactionManager transactionManager, System.DateTime ngay)
		{
			return GetNamHocByNgay(transactionManager, 0, int.MaxValue , ngay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_NamHoc_GetNamHocByNgay' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetNamHocByNgay(TransactionManager transactionManager, int start, int pageLength, System.DateTime ngay);
		
		#endregion

		
		#region cust_View_NamHoc_GetNamHocTruoc
		
		/// <summary>
		///	This method wrap the 'cust_View_NamHoc_GetNamHocTruoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetNamHocTruoc(System.String namHoc, ref System.String reVal)
		{
			 GetNamHocTruoc(null, 0, int.MaxValue , namHoc, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_NamHoc_GetNamHocTruoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetNamHocTruoc(int start, int pageLength, System.String namHoc, ref System.String reVal)
		{
			 GetNamHocTruoc(null, start, pageLength , namHoc, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_NamHoc_GetNamHocTruoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetNamHocTruoc(TransactionManager transactionManager, System.String namHoc, ref System.String reVal)
		{
			 GetNamHocTruoc(transactionManager, 0, int.MaxValue , namHoc, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_NamHoc_GetNamHocTruoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetNamHocTruoc(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, ref System.String reVal);
		
		#endregion

		
		#region cust_View_NamHoc_GetNamHocKeTiep
		
		/// <summary>
		///	This method wrap the 'cust_View_NamHoc_GetNamHocKeTiep' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetNamHocKeTiep(System.String namHoc, ref System.String reVal)
		{
			 GetNamHocKeTiep(null, 0, int.MaxValue , namHoc, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_NamHoc_GetNamHocKeTiep' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetNamHocKeTiep(int start, int pageLength, System.String namHoc, ref System.String reVal)
		{
			 GetNamHocKeTiep(null, start, pageLength , namHoc, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_NamHoc_GetNamHocKeTiep' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetNamHocKeTiep(TransactionManager transactionManager, System.String namHoc, ref System.String reVal)
		{
			 GetNamHocKeTiep(transactionManager, 0, int.MaxValue , namHoc, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_NamHoc_GetNamHocKeTiep' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetNamHocKeTiep(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, ref System.String reVal);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewNamHoc&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewNamHoc&gt;"/></returns>
		protected static VList&lt;ViewNamHoc&gt; Fill(DataSet dataSet, VList<ViewNamHoc> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewNamHoc>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewNamHoc&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewNamHoc>"/></returns>
		protected static VList&lt;ViewNamHoc&gt; Fill(DataTable dataTable, VList<ViewNamHoc> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewNamHoc c = new ViewNamHoc();
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
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
		/// Fill an <see cref="VList&lt;ViewNamHoc&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewNamHoc&gt;"/></returns>
		protected VList<ViewNamHoc> Fill(IDataReader reader, VList<ViewNamHoc> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewNamHoc entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewNamHoc>("ViewNamHoc",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewNamHoc();
					}
					
					entity.SuppressEntityEvents = true;

					entity.NamHoc = (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
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
		/// Refreshes the <see cref="ViewNamHoc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewNamHoc"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewNamHoc entity)
		{
			reader.Read();
			entity.NamHoc = (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewNamHoc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewNamHoc"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewNamHoc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewNamHocFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewNamHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewNamHocFilterBuilder : SqlFilterBuilder<ViewNamHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewNamHocFilterBuilder class.
		/// </summary>
		public ViewNamHocFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewNamHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewNamHocFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewNamHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewNamHocFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewNamHocFilterBuilder

	#region ViewNamHocParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewNamHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewNamHocParameterBuilder : ParameterizedSqlFilterBuilder<ViewNamHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewNamHocParameterBuilder class.
		/// </summary>
		public ViewNamHocParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewNamHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewNamHocParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewNamHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewNamHocParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewNamHocParameterBuilder
	
	#region ViewNamHocSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewNamHoc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewNamHocSortBuilder : SqlSortBuilder<ViewNamHocColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewNamHocSqlSortBuilder class.
		/// </summary>
		public ViewNamHocSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewNamHocSortBuilder

} // end namespace
