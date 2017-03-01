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
	/// This class is the base class for any <see cref="ViewHeSoTinChiProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewHeSoTinChiProviderBaseCore : EntityViewProviderBase<ViewHeSoTinChi>
	{
		#region Custom Methods
		
		
		#region cust_View_HeSoTinChi_Luu
		
		/// <summary>
		///	This method wrap the 'cust_View_HeSoTinChi_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData)
		{
			 Luu(null, 0, int.MaxValue , xmlData);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_HeSoTinChi_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData)
		{
			 Luu(null, start, pageLength , xmlData);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_HeSoTinChi_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_HeSoTinChi_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength, System.String xmlData);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewHeSoTinChi&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewHeSoTinChi&gt;"/></returns>
		protected static VList&lt;ViewHeSoTinChi&gt; Fill(DataSet dataSet, VList<ViewHeSoTinChi> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewHeSoTinChi>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewHeSoTinChi&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewHeSoTinChi>"/></returns>
		protected static VList&lt;ViewHeSoTinChi&gt; Fill(DataTable dataTable, VList<ViewHeSoTinChi> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewHeSoTinChi c = new ViewHeSoTinChi();
					c.MaHeDaoTao = (Convert.IsDBNull(row["MaHeDaoTao"]))?string.Empty:(System.String)row["MaHeDaoTao"];
					c.TenHeDaoTao = (Convert.IsDBNull(row["TenHeDaoTao"]))?string.Empty:(System.String)row["TenHeDaoTao"];
					c.MaBacDaoTao = (Convert.IsDBNull(row["MaBacDaoTao"]))?string.Empty:(System.String)row["MaBacDaoTao"];
					c.TenBacDaoTao = (Convert.IsDBNull(row["TenBacDaoTao"]))?string.Empty:(System.String)row["TenBacDaoTao"];
					c.MaLoaiGiangVien = (Convert.IsDBNull(row["MaLoaiGiangVien"]))?(int)0:(System.Int32)row["MaLoaiGiangVien"];
					c.TenLoaiGiangVien = (Convert.IsDBNull(row["TenLoaiGiangVien"]))?string.Empty:(System.String)row["TenLoaiGiangVien"];
					c.HeSoTinChi = (Convert.IsDBNull(row["HeSoTinChi"]))?0.0m:(System.Decimal)row["HeSoTinChi"];
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
		/// Fill an <see cref="VList&lt;ViewHeSoTinChi&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewHeSoTinChi&gt;"/></returns>
		protected VList<ViewHeSoTinChi> Fill(IDataReader reader, VList<ViewHeSoTinChi> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewHeSoTinChi entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewHeSoTinChi>("ViewHeSoTinChi",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewHeSoTinChi();
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
					entity.HeSoTinChi = (System.Decimal)reader["HeSoTinChi"];
					//entity.HeSoTinChi = (Convert.IsDBNull(reader["HeSoTinChi"]))?0.0m:(System.Decimal)reader["HeSoTinChi"];
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
		/// Refreshes the <see cref="ViewHeSoTinChi"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewHeSoTinChi"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewHeSoTinChi entity)
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
			entity.HeSoTinChi = (System.Decimal)reader["HeSoTinChi"];
			//entity.HeSoTinChi = (Convert.IsDBNull(reader["HeSoTinChi"]))?0.0m:(System.Decimal)reader["HeSoTinChi"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewHeSoTinChi"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewHeSoTinChi"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewHeSoTinChi entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaHeDaoTao = (Convert.IsDBNull(dataRow["MaHeDaoTao"]))?string.Empty:(System.String)dataRow["MaHeDaoTao"];
			entity.TenHeDaoTao = (Convert.IsDBNull(dataRow["TenHeDaoTao"]))?string.Empty:(System.String)dataRow["TenHeDaoTao"];
			entity.MaBacDaoTao = (Convert.IsDBNull(dataRow["MaBacDaoTao"]))?string.Empty:(System.String)dataRow["MaBacDaoTao"];
			entity.TenBacDaoTao = (Convert.IsDBNull(dataRow["TenBacDaoTao"]))?string.Empty:(System.String)dataRow["TenBacDaoTao"];
			entity.MaLoaiGiangVien = (Convert.IsDBNull(dataRow["MaLoaiGiangVien"]))?(int)0:(System.Int32)dataRow["MaLoaiGiangVien"];
			entity.TenLoaiGiangVien = (Convert.IsDBNull(dataRow["TenLoaiGiangVien"]))?string.Empty:(System.String)dataRow["TenLoaiGiangVien"];
			entity.HeSoTinChi = (Convert.IsDBNull(dataRow["HeSoTinChi"]))?0.0m:(System.Decimal)dataRow["HeSoTinChi"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewHeSoTinChiFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHeSoTinChi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHeSoTinChiFilterBuilder : SqlFilterBuilder<ViewHeSoTinChiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHeSoTinChiFilterBuilder class.
		/// </summary>
		public ViewHeSoTinChiFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewHeSoTinChiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewHeSoTinChiFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewHeSoTinChiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewHeSoTinChiFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewHeSoTinChiFilterBuilder

	#region ViewHeSoTinChiParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHeSoTinChi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHeSoTinChiParameterBuilder : ParameterizedSqlFilterBuilder<ViewHeSoTinChiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHeSoTinChiParameterBuilder class.
		/// </summary>
		public ViewHeSoTinChiParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewHeSoTinChiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewHeSoTinChiParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewHeSoTinChiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewHeSoTinChiParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewHeSoTinChiParameterBuilder
	
	#region ViewHeSoTinChiSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHeSoTinChi"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewHeSoTinChiSortBuilder : SqlSortBuilder<ViewHeSoTinChiColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHeSoTinChiSqlSortBuilder class.
		/// </summary>
		public ViewHeSoTinChiSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewHeSoTinChiSortBuilder

} // end namespace
