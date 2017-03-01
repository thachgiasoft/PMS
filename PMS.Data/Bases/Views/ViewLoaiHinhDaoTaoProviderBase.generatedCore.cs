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
	/// This class is the base class for any <see cref="ViewLoaiHinhDaoTaoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewLoaiHinhDaoTaoProviderBaseCore : EntityViewProviderBase<ViewLoaiHinhDaoTao>
	{
		#region Custom Methods
		
		
		#region cust_View_LoaiHinhDaoTao_GetByBacDaoTao
		
		/// <summary>
		///	This method wrap the 'cust_View_LoaiHinhDaoTao_GetByBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByBacDaoTao(System.String bacDaoTao)
		{
			return GetByBacDaoTao(null, 0, int.MaxValue , bacDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_LoaiHinhDaoTao_GetByBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByBacDaoTao(int start, int pageLength, System.String bacDaoTao)
		{
			return GetByBacDaoTao(null, start, pageLength , bacDaoTao);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_LoaiHinhDaoTao_GetByBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByBacDaoTao(TransactionManager transactionManager, System.String bacDaoTao)
		{
			return GetByBacDaoTao(transactionManager, 0, int.MaxValue , bacDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_LoaiHinhDaoTao_GetByBacDaoTao' stored procedure. 
		/// </summary>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByBacDaoTao(TransactionManager transactionManager, int start, int pageLength, System.String bacDaoTao);
		
		#endregion

		
		#region cust_View_LoaiHinhDaoTao_GetMaTen
		
		/// <summary>
		///	This method wrap the 'cust_View_LoaiHinhDaoTao_GetMaTen' stored procedure. 
		/// </summary>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetMaTen(System.String bacDaoTao)
		{
			return GetMaTen(null, 0, int.MaxValue , bacDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_LoaiHinhDaoTao_GetMaTen' stored procedure. 
		/// </summary>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetMaTen(int start, int pageLength, System.String bacDaoTao)
		{
			return GetMaTen(null, start, pageLength , bacDaoTao);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_LoaiHinhDaoTao_GetMaTen' stored procedure. 
		/// </summary>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetMaTen(TransactionManager transactionManager, System.String bacDaoTao)
		{
			return GetMaTen(transactionManager, 0, int.MaxValue , bacDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_LoaiHinhDaoTao_GetMaTen' stored procedure. 
		/// </summary>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetMaTen(TransactionManager transactionManager, int start, int pageLength, System.String bacDaoTao);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewLoaiHinhDaoTao&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewLoaiHinhDaoTao&gt;"/></returns>
		protected static VList&lt;ViewLoaiHinhDaoTao&gt; Fill(DataSet dataSet, VList<ViewLoaiHinhDaoTao> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewLoaiHinhDaoTao>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewLoaiHinhDaoTao&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewLoaiHinhDaoTao>"/></returns>
		protected static VList&lt;ViewLoaiHinhDaoTao&gt; Fill(DataTable dataTable, VList<ViewLoaiHinhDaoTao> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewLoaiHinhDaoTao c = new ViewLoaiHinhDaoTao();
					c.MaLoaiHinh = (Convert.IsDBNull(row["MaLoaiHinh"]))?string.Empty:(System.String)row["MaLoaiHinh"];
					c.TenLoaiHinh = (Convert.IsDBNull(row["TenLoaiHinh"]))?string.Empty:(System.String)row["TenLoaiHinh"];
					c.Level = (Convert.IsDBNull(row["Level"]))?(byte)0:(System.Byte?)row["Level"];
					c.StudyUnitCode = (Convert.IsDBNull(row["StudyUnitCode"]))?string.Empty:(System.String)row["StudyUnitCode"];
					c.Locked = (Convert.IsDBNull(row["Locked"]))?false:(System.Boolean?)row["Locked"];
					c.Abbreviation = (Convert.IsDBNull(row["Abbreviation"]))?string.Empty:(System.String)row["Abbreviation"];
					c.PrintAbbreviation = (Convert.IsDBNull(row["PrintAbbreviation"]))?string.Empty:(System.String)row["PrintAbbreviation"];
					c.StudyTypeEngName = (Convert.IsDBNull(row["StudyTypeEngName"]))?string.Empty:(System.String)row["StudyTypeEngName"];
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
		/// Fill an <see cref="VList&lt;ViewLoaiHinhDaoTao&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewLoaiHinhDaoTao&gt;"/></returns>
		protected VList<ViewLoaiHinhDaoTao> Fill(IDataReader reader, VList<ViewLoaiHinhDaoTao> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewLoaiHinhDaoTao entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewLoaiHinhDaoTao>("ViewLoaiHinhDaoTao",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewLoaiHinhDaoTao();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaLoaiHinh = (System.String)reader["MaLoaiHinh"];
					//entity.MaLoaiHinh = (Convert.IsDBNull(reader["MaLoaiHinh"]))?string.Empty:(System.String)reader["MaLoaiHinh"];
					entity.TenLoaiHinh = (System.String)reader["TenLoaiHinh"];
					//entity.TenLoaiHinh = (Convert.IsDBNull(reader["TenLoaiHinh"]))?string.Empty:(System.String)reader["TenLoaiHinh"];
					entity.Level = reader.IsDBNull(reader.GetOrdinal("Level")) ? null : (System.Byte?)reader["Level"];
					//entity.Level = (Convert.IsDBNull(reader["Level"]))?(byte)0:(System.Byte?)reader["Level"];
					entity.StudyUnitCode = reader.IsDBNull(reader.GetOrdinal("StudyUnitCode")) ? null : (System.String)reader["StudyUnitCode"];
					//entity.StudyUnitCode = (Convert.IsDBNull(reader["StudyUnitCode"]))?string.Empty:(System.String)reader["StudyUnitCode"];
					entity.Locked = reader.IsDBNull(reader.GetOrdinal("Locked")) ? null : (System.Boolean?)reader["Locked"];
					//entity.Locked = (Convert.IsDBNull(reader["Locked"]))?false:(System.Boolean?)reader["Locked"];
					entity.Abbreviation = reader.IsDBNull(reader.GetOrdinal("Abbreviation")) ? null : (System.String)reader["Abbreviation"];
					//entity.Abbreviation = (Convert.IsDBNull(reader["Abbreviation"]))?string.Empty:(System.String)reader["Abbreviation"];
					entity.PrintAbbreviation = reader.IsDBNull(reader.GetOrdinal("PrintAbbreviation")) ? null : (System.String)reader["PrintAbbreviation"];
					//entity.PrintAbbreviation = (Convert.IsDBNull(reader["PrintAbbreviation"]))?string.Empty:(System.String)reader["PrintAbbreviation"];
					entity.StudyTypeEngName = reader.IsDBNull(reader.GetOrdinal("StudyTypeEngName")) ? null : (System.String)reader["StudyTypeEngName"];
					//entity.StudyTypeEngName = (Convert.IsDBNull(reader["StudyTypeEngName"]))?string.Empty:(System.String)reader["StudyTypeEngName"];
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
		/// Refreshes the <see cref="ViewLoaiHinhDaoTao"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewLoaiHinhDaoTao"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewLoaiHinhDaoTao entity)
		{
			reader.Read();
			entity.MaLoaiHinh = (System.String)reader["MaLoaiHinh"];
			//entity.MaLoaiHinh = (Convert.IsDBNull(reader["MaLoaiHinh"]))?string.Empty:(System.String)reader["MaLoaiHinh"];
			entity.TenLoaiHinh = (System.String)reader["TenLoaiHinh"];
			//entity.TenLoaiHinh = (Convert.IsDBNull(reader["TenLoaiHinh"]))?string.Empty:(System.String)reader["TenLoaiHinh"];
			entity.Level = reader.IsDBNull(reader.GetOrdinal("Level")) ? null : (System.Byte?)reader["Level"];
			//entity.Level = (Convert.IsDBNull(reader["Level"]))?(byte)0:(System.Byte?)reader["Level"];
			entity.StudyUnitCode = reader.IsDBNull(reader.GetOrdinal("StudyUnitCode")) ? null : (System.String)reader["StudyUnitCode"];
			//entity.StudyUnitCode = (Convert.IsDBNull(reader["StudyUnitCode"]))?string.Empty:(System.String)reader["StudyUnitCode"];
			entity.Locked = reader.IsDBNull(reader.GetOrdinal("Locked")) ? null : (System.Boolean?)reader["Locked"];
			//entity.Locked = (Convert.IsDBNull(reader["Locked"]))?false:(System.Boolean?)reader["Locked"];
			entity.Abbreviation = reader.IsDBNull(reader.GetOrdinal("Abbreviation")) ? null : (System.String)reader["Abbreviation"];
			//entity.Abbreviation = (Convert.IsDBNull(reader["Abbreviation"]))?string.Empty:(System.String)reader["Abbreviation"];
			entity.PrintAbbreviation = reader.IsDBNull(reader.GetOrdinal("PrintAbbreviation")) ? null : (System.String)reader["PrintAbbreviation"];
			//entity.PrintAbbreviation = (Convert.IsDBNull(reader["PrintAbbreviation"]))?string.Empty:(System.String)reader["PrintAbbreviation"];
			entity.StudyTypeEngName = reader.IsDBNull(reader.GetOrdinal("StudyTypeEngName")) ? null : (System.String)reader["StudyTypeEngName"];
			//entity.StudyTypeEngName = (Convert.IsDBNull(reader["StudyTypeEngName"]))?string.Empty:(System.String)reader["StudyTypeEngName"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewLoaiHinhDaoTao"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewLoaiHinhDaoTao"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewLoaiHinhDaoTao entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaLoaiHinh = (Convert.IsDBNull(dataRow["MaLoaiHinh"]))?string.Empty:(System.String)dataRow["MaLoaiHinh"];
			entity.TenLoaiHinh = (Convert.IsDBNull(dataRow["TenLoaiHinh"]))?string.Empty:(System.String)dataRow["TenLoaiHinh"];
			entity.Level = (Convert.IsDBNull(dataRow["Level"]))?(byte)0:(System.Byte?)dataRow["Level"];
			entity.StudyUnitCode = (Convert.IsDBNull(dataRow["StudyUnitCode"]))?string.Empty:(System.String)dataRow["StudyUnitCode"];
			entity.Locked = (Convert.IsDBNull(dataRow["Locked"]))?false:(System.Boolean?)dataRow["Locked"];
			entity.Abbreviation = (Convert.IsDBNull(dataRow["Abbreviation"]))?string.Empty:(System.String)dataRow["Abbreviation"];
			entity.PrintAbbreviation = (Convert.IsDBNull(dataRow["PrintAbbreviation"]))?string.Empty:(System.String)dataRow["PrintAbbreviation"];
			entity.StudyTypeEngName = (Convert.IsDBNull(dataRow["StudyTypeEngName"]))?string.Empty:(System.String)dataRow["StudyTypeEngName"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewLoaiHinhDaoTaoFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLoaiHinhDaoTao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLoaiHinhDaoTaoFilterBuilder : SqlFilterBuilder<ViewLoaiHinhDaoTaoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLoaiHinhDaoTaoFilterBuilder class.
		/// </summary>
		public ViewLoaiHinhDaoTaoFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewLoaiHinhDaoTaoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewLoaiHinhDaoTaoFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewLoaiHinhDaoTaoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewLoaiHinhDaoTaoFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewLoaiHinhDaoTaoFilterBuilder

	#region ViewLoaiHinhDaoTaoParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLoaiHinhDaoTao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLoaiHinhDaoTaoParameterBuilder : ParameterizedSqlFilterBuilder<ViewLoaiHinhDaoTaoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLoaiHinhDaoTaoParameterBuilder class.
		/// </summary>
		public ViewLoaiHinhDaoTaoParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewLoaiHinhDaoTaoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewLoaiHinhDaoTaoParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewLoaiHinhDaoTaoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewLoaiHinhDaoTaoParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewLoaiHinhDaoTaoParameterBuilder
	
	#region ViewLoaiHinhDaoTaoSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLoaiHinhDaoTao"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewLoaiHinhDaoTaoSortBuilder : SqlSortBuilder<ViewLoaiHinhDaoTaoColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLoaiHinhDaoTaoSqlSortBuilder class.
		/// </summary>
		public ViewLoaiHinhDaoTaoSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewLoaiHinhDaoTaoSortBuilder

} // end namespace
