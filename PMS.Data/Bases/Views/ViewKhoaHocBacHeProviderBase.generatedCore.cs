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
	/// This class is the base class for any <see cref="ViewKhoaHocBacHeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewKhoaHocBacHeProviderBaseCore : EntityViewProviderBase<ViewKhoaHocBacHe>
	{
		#region Custom Methods
		
		
		#region cust_View_KhoaHoc_Bac_He_GetByMaBacDaoTao
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoaHoc_Bac_He_GetByMaBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoaHocBacHe&gt;"/> instance.</returns>
		public VList<ViewKhoaHocBacHe> GetByMaBacDaoTao(System.String maBacDaoTao)
		{
			return GetByMaBacDaoTao(null, 0, int.MaxValue , maBacDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoaHoc_Bac_He_GetByMaBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoaHocBacHe&gt;"/> instance.</returns>
		public VList<ViewKhoaHocBacHe> GetByMaBacDaoTao(int start, int pageLength, System.String maBacDaoTao)
		{
			return GetByMaBacDaoTao(null, start, pageLength , maBacDaoTao);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_KhoaHoc_Bac_He_GetByMaBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewKhoaHocBacHe&gt;"/> instance.</returns>
		public VList<ViewKhoaHocBacHe> GetByMaBacDaoTao(TransactionManager transactionManager, System.String maBacDaoTao)
		{
			return GetByMaBacDaoTao(transactionManager, 0, int.MaxValue , maBacDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoaHoc_Bac_He_GetByMaBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoaHocBacHe&gt;"/> instance.</returns>
		public abstract VList<ViewKhoaHocBacHe> GetByMaBacDaoTao(TransactionManager transactionManager, int start, int pageLength, System.String maBacDaoTao);
		
		#endregion

		
		#region cust_View_KhoaHoc_Bac_He_GetByMaHeMaBac
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoaHoc_Bac_He_GetByMaHeMaBac' stored procedure. 
		/// </summary>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoaHocBacHe&gt;"/> instance.</returns>
		public VList<ViewKhoaHocBacHe> GetByMaHeMaBac(System.String maHeDaoTao, System.String maBacDaoTao)
		{
			return GetByMaHeMaBac(null, 0, int.MaxValue , maHeDaoTao, maBacDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoaHoc_Bac_He_GetByMaHeMaBac' stored procedure. 
		/// </summary>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoaHocBacHe&gt;"/> instance.</returns>
		public VList<ViewKhoaHocBacHe> GetByMaHeMaBac(int start, int pageLength, System.String maHeDaoTao, System.String maBacDaoTao)
		{
			return GetByMaHeMaBac(null, start, pageLength , maHeDaoTao, maBacDaoTao);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_KhoaHoc_Bac_He_GetByMaHeMaBac' stored procedure. 
		/// </summary>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewKhoaHocBacHe&gt;"/> instance.</returns>
		public VList<ViewKhoaHocBacHe> GetByMaHeMaBac(TransactionManager transactionManager, System.String maHeDaoTao, System.String maBacDaoTao)
		{
			return GetByMaHeMaBac(transactionManager, 0, int.MaxValue , maHeDaoTao, maBacDaoTao);
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
		/// <returns>A <see cref="VList&lt;ViewKhoaHocBacHe&gt;"/> instance.</returns>
		public abstract VList<ViewKhoaHocBacHe> GetByMaHeMaBac(TransactionManager transactionManager, int start, int pageLength, System.String maHeDaoTao, System.String maBacDaoTao);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewKhoaHocBacHe&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewKhoaHocBacHe&gt;"/></returns>
		protected static VList&lt;ViewKhoaHocBacHe&gt; Fill(DataSet dataSet, VList<ViewKhoaHocBacHe> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewKhoaHocBacHe>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewKhoaHocBacHe&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewKhoaHocBacHe>"/></returns>
		protected static VList&lt;ViewKhoaHocBacHe&gt; Fill(DataTable dataTable, VList<ViewKhoaHocBacHe> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewKhoaHocBacHe c = new ViewKhoaHocBacHe();
					c.MaKhoaHoc = (Convert.IsDBNull(row["MaKhoaHoc"]))?string.Empty:(System.String)row["MaKhoaHoc"];
					c.TenKhoaHoc = (Convert.IsDBNull(row["TenKhoaHoc"]))?string.Empty:(System.String)row["TenKhoaHoc"];
					c.MaHeDaoTao = (Convert.IsDBNull(row["MaHeDaoTao"]))?string.Empty:(System.String)row["MaHeDaoTao"];
					c.MaBacDaoTao = (Convert.IsDBNull(row["MaBacDaoTao"]))?string.Empty:(System.String)row["MaBacDaoTao"];
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
		/// Fill an <see cref="VList&lt;ViewKhoaHocBacHe&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewKhoaHocBacHe&gt;"/></returns>
		protected VList<ViewKhoaHocBacHe> Fill(IDataReader reader, VList<ViewKhoaHocBacHe> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewKhoaHocBacHe entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewKhoaHocBacHe>("ViewKhoaHocBacHe",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewKhoaHocBacHe();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaKhoaHoc = (System.String)reader["MaKhoaHoc"];
					//entity.MaKhoaHoc = (Convert.IsDBNull(reader["MaKhoaHoc"]))?string.Empty:(System.String)reader["MaKhoaHoc"];
					entity.TenKhoaHoc = (System.String)reader["TenKhoaHoc"];
					//entity.TenKhoaHoc = (Convert.IsDBNull(reader["TenKhoaHoc"]))?string.Empty:(System.String)reader["TenKhoaHoc"];
					entity.MaHeDaoTao = (System.String)reader["MaHeDaoTao"];
					//entity.MaHeDaoTao = (Convert.IsDBNull(reader["MaHeDaoTao"]))?string.Empty:(System.String)reader["MaHeDaoTao"];
					entity.MaBacDaoTao = (System.String)reader["MaBacDaoTao"];
					//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
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
		/// Refreshes the <see cref="ViewKhoaHocBacHe"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewKhoaHocBacHe"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewKhoaHocBacHe entity)
		{
			reader.Read();
			entity.MaKhoaHoc = (System.String)reader["MaKhoaHoc"];
			//entity.MaKhoaHoc = (Convert.IsDBNull(reader["MaKhoaHoc"]))?string.Empty:(System.String)reader["MaKhoaHoc"];
			entity.TenKhoaHoc = (System.String)reader["TenKhoaHoc"];
			//entity.TenKhoaHoc = (Convert.IsDBNull(reader["TenKhoaHoc"]))?string.Empty:(System.String)reader["TenKhoaHoc"];
			entity.MaHeDaoTao = (System.String)reader["MaHeDaoTao"];
			//entity.MaHeDaoTao = (Convert.IsDBNull(reader["MaHeDaoTao"]))?string.Empty:(System.String)reader["MaHeDaoTao"];
			entity.MaBacDaoTao = (System.String)reader["MaBacDaoTao"];
			//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewKhoaHocBacHe"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewKhoaHocBacHe"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewKhoaHocBacHe entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaKhoaHoc = (Convert.IsDBNull(dataRow["MaKhoaHoc"]))?string.Empty:(System.String)dataRow["MaKhoaHoc"];
			entity.TenKhoaHoc = (Convert.IsDBNull(dataRow["TenKhoaHoc"]))?string.Empty:(System.String)dataRow["TenKhoaHoc"];
			entity.MaHeDaoTao = (Convert.IsDBNull(dataRow["MaHeDaoTao"]))?string.Empty:(System.String)dataRow["MaHeDaoTao"];
			entity.MaBacDaoTao = (Convert.IsDBNull(dataRow["MaBacDaoTao"]))?string.Empty:(System.String)dataRow["MaBacDaoTao"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewKhoaHocBacHeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoaHocBacHe"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKhoaHocBacHeFilterBuilder : SqlFilterBuilder<ViewKhoaHocBacHeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoaHocBacHeFilterBuilder class.
		/// </summary>
		public ViewKhoaHocBacHeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewKhoaHocBacHeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewKhoaHocBacHeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewKhoaHocBacHeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewKhoaHocBacHeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewKhoaHocBacHeFilterBuilder

	#region ViewKhoaHocBacHeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoaHocBacHe"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKhoaHocBacHeParameterBuilder : ParameterizedSqlFilterBuilder<ViewKhoaHocBacHeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoaHocBacHeParameterBuilder class.
		/// </summary>
		public ViewKhoaHocBacHeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewKhoaHocBacHeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewKhoaHocBacHeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewKhoaHocBacHeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewKhoaHocBacHeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewKhoaHocBacHeParameterBuilder
	
	#region ViewKhoaHocBacHeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoaHocBacHe"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewKhoaHocBacHeSortBuilder : SqlSortBuilder<ViewKhoaHocBacHeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoaHocBacHeSqlSortBuilder class.
		/// </summary>
		public ViewKhoaHocBacHeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewKhoaHocBacHeSortBuilder

} // end namespace
