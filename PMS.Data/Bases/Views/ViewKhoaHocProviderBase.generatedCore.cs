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
	/// This class is the base class for any <see cref="ViewKhoaHocProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewKhoaHocProviderBaseCore : EntityViewProviderBase<ViewKhoaHoc>
	{
		#region Custom Methods
		
		
		#region cust_View_KhoaHoc_GetNganhByMaKhoaHoc
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoaHoc_GetNganhByMaKhoaHoc' stored procedure. 
		/// </summary>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetNganhByMaKhoaHoc(System.String maKhoaHoc, System.String maBacDaoTao)
		{
			return GetNganhByMaKhoaHoc(null, 0, int.MaxValue , maKhoaHoc, maBacDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoaHoc_GetNganhByMaKhoaHoc' stored procedure. 
		/// </summary>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetNganhByMaKhoaHoc(int start, int pageLength, System.String maKhoaHoc, System.String maBacDaoTao)
		{
			return GetNganhByMaKhoaHoc(null, start, pageLength , maKhoaHoc, maBacDaoTao);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_KhoaHoc_GetNganhByMaKhoaHoc' stored procedure. 
		/// </summary>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetNganhByMaKhoaHoc(TransactionManager transactionManager, System.String maKhoaHoc, System.String maBacDaoTao)
		{
			return GetNganhByMaKhoaHoc(transactionManager, 0, int.MaxValue , maKhoaHoc, maBacDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoaHoc_GetNganhByMaKhoaHoc' stored procedure. 
		/// </summary>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetNganhByMaKhoaHoc(TransactionManager transactionManager, int start, int pageLength, System.String maKhoaHoc, System.String maBacDaoTao);
		
		#endregion

		
		#region cust_View_KhoaHoc_Bac_He_GetByMaBacDaoTao
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoaHoc_Bac_He_GetByMaBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader Bac_He_GetByMaBacDaoTao(System.String maBacDaoTao)
		{
			return Bac_He_GetByMaBacDaoTao(null, 0, int.MaxValue , maBacDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoaHoc_Bac_He_GetByMaBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader Bac_He_GetByMaBacDaoTao(int start, int pageLength, System.String maBacDaoTao)
		{
			return Bac_He_GetByMaBacDaoTao(null, start, pageLength , maBacDaoTao);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_KhoaHoc_Bac_He_GetByMaBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader Bac_He_GetByMaBacDaoTao(TransactionManager transactionManager, System.String maBacDaoTao)
		{
			return Bac_He_GetByMaBacDaoTao(transactionManager, 0, int.MaxValue , maBacDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoaHoc_Bac_He_GetByMaBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader Bac_He_GetByMaBacDaoTao(TransactionManager transactionManager, int start, int pageLength, System.String maBacDaoTao);
		
		#endregion

		
		#region cust_View_KhoaHoc_Bac_He_GetByMaHeMaBac
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoaHoc_Bac_He_GetByMaHeMaBac' stored procedure. 
		/// </summary>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader Bac_He_GetByMaHeMaBac(System.String maHeDaoTao, System.String maBacDaoTao)
		{
			return Bac_He_GetByMaHeMaBac(null, 0, int.MaxValue , maHeDaoTao, maBacDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoaHoc_Bac_He_GetByMaHeMaBac' stored procedure. 
		/// </summary>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader Bac_He_GetByMaHeMaBac(int start, int pageLength, System.String maHeDaoTao, System.String maBacDaoTao)
		{
			return Bac_He_GetByMaHeMaBac(null, start, pageLength , maHeDaoTao, maBacDaoTao);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_KhoaHoc_Bac_He_GetByMaHeMaBac' stored procedure. 
		/// </summary>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader Bac_He_GetByMaHeMaBac(TransactionManager transactionManager, System.String maHeDaoTao, System.String maBacDaoTao)
		{
			return Bac_He_GetByMaHeMaBac(transactionManager, 0, int.MaxValue , maHeDaoTao, maBacDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoaHoc_Bac_He_GetByMaHeMaBac' stored procedure. 
		/// </summary>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader Bac_He_GetByMaHeMaBac(TransactionManager transactionManager, int start, int pageLength, System.String maHeDaoTao, System.String maBacDaoTao);
		
		#endregion

		
		#region cust_View_KhoaHoc_GetByMaBacDaoTao
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoaHoc_GetByMaBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoaHoc&gt;"/> instance.</returns>
		public VList<ViewKhoaHoc> GetByMaBacDaoTao(System.String maBacDaoTao)
		{
			return GetByMaBacDaoTao(null, 0, int.MaxValue , maBacDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoaHoc_GetByMaBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoaHoc&gt;"/> instance.</returns>
		public VList<ViewKhoaHoc> GetByMaBacDaoTao(int start, int pageLength, System.String maBacDaoTao)
		{
			return GetByMaBacDaoTao(null, start, pageLength , maBacDaoTao);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_KhoaHoc_GetByMaBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewKhoaHoc&gt;"/> instance.</returns>
		public VList<ViewKhoaHoc> GetByMaBacDaoTao(TransactionManager transactionManager, System.String maBacDaoTao)
		{
			return GetByMaBacDaoTao(transactionManager, 0, int.MaxValue , maBacDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoaHoc_GetByMaBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoaHoc&gt;"/> instance.</returns>
		public abstract VList<ViewKhoaHoc> GetByMaBacDaoTao(TransactionManager transactionManager, int start, int pageLength, System.String maBacDaoTao);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewKhoaHoc&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewKhoaHoc&gt;"/></returns>
		protected static VList&lt;ViewKhoaHoc&gt; Fill(DataSet dataSet, VList<ViewKhoaHoc> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewKhoaHoc>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewKhoaHoc&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewKhoaHoc>"/></returns>
		protected static VList&lt;ViewKhoaHoc&gt; Fill(DataTable dataTable, VList<ViewKhoaHoc> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewKhoaHoc c = new ViewKhoaHoc();
					c.MaKhoaHoc = (Convert.IsDBNull(row["MaKhoaHoc"]))?string.Empty:(System.String)row["MaKhoaHoc"];
					c.TenKhoaHoc = (Convert.IsDBNull(row["TenKhoaHoc"]))?string.Empty:(System.String)row["TenKhoaHoc"];
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
		/// Fill an <see cref="VList&lt;ViewKhoaHoc&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewKhoaHoc&gt;"/></returns>
		protected VList<ViewKhoaHoc> Fill(IDataReader reader, VList<ViewKhoaHoc> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewKhoaHoc entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewKhoaHoc>("ViewKhoaHoc",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewKhoaHoc();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaKhoaHoc = (System.String)reader["MaKhoaHoc"];
					//entity.MaKhoaHoc = (Convert.IsDBNull(reader["MaKhoaHoc"]))?string.Empty:(System.String)reader["MaKhoaHoc"];
					entity.TenKhoaHoc = (System.String)reader["TenKhoaHoc"];
					//entity.TenKhoaHoc = (Convert.IsDBNull(reader["TenKhoaHoc"]))?string.Empty:(System.String)reader["TenKhoaHoc"];
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
		/// Refreshes the <see cref="ViewKhoaHoc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewKhoaHoc"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewKhoaHoc entity)
		{
			reader.Read();
			entity.MaKhoaHoc = (System.String)reader["MaKhoaHoc"];
			//entity.MaKhoaHoc = (Convert.IsDBNull(reader["MaKhoaHoc"]))?string.Empty:(System.String)reader["MaKhoaHoc"];
			entity.TenKhoaHoc = (System.String)reader["TenKhoaHoc"];
			//entity.TenKhoaHoc = (Convert.IsDBNull(reader["TenKhoaHoc"]))?string.Empty:(System.String)reader["TenKhoaHoc"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewKhoaHoc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewKhoaHoc"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewKhoaHoc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaKhoaHoc = (Convert.IsDBNull(dataRow["MaKhoaHoc"]))?string.Empty:(System.String)dataRow["MaKhoaHoc"];
			entity.TenKhoaHoc = (Convert.IsDBNull(dataRow["TenKhoaHoc"]))?string.Empty:(System.String)dataRow["TenKhoaHoc"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewKhoaHocFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoaHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKhoaHocFilterBuilder : SqlFilterBuilder<ViewKhoaHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoaHocFilterBuilder class.
		/// </summary>
		public ViewKhoaHocFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewKhoaHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewKhoaHocFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewKhoaHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewKhoaHocFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewKhoaHocFilterBuilder

	#region ViewKhoaHocParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoaHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKhoaHocParameterBuilder : ParameterizedSqlFilterBuilder<ViewKhoaHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoaHocParameterBuilder class.
		/// </summary>
		public ViewKhoaHocParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewKhoaHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewKhoaHocParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewKhoaHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewKhoaHocParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewKhoaHocParameterBuilder
	
	#region ViewKhoaHocSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoaHoc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewKhoaHocSortBuilder : SqlSortBuilder<ViewKhoaHocColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoaHocSqlSortBuilder class.
		/// </summary>
		public ViewKhoaHocSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewKhoaHocSortBuilder

} // end namespace
