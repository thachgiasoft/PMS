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
	/// This class is the base class for any <see cref="ViewCauHinhProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewCauHinhProviderBaseCore : EntityViewProviderBase<ViewCauHinh>
	{
		#region Custom Methods
		
		
		#region cust_View_CauHinh_Update
		
		/// <summary>
		///	This method wrap the 'cust_View_CauHinh_Update' stored procedure. 
		/// </summary>
		/// <param name="settingName"> A <c>System.String</c> instance.</param>
		/// <param name="value"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Update(System.String settingName, System.String value)
		{
			 Update(null, 0, int.MaxValue , settingName, value);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_CauHinh_Update' stored procedure. 
		/// </summary>
		/// <param name="settingName"> A <c>System.String</c> instance.</param>
		/// <param name="value"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Update(int start, int pageLength, System.String settingName, System.String value)
		{
			 Update(null, start, pageLength , settingName, value);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_CauHinh_Update' stored procedure. 
		/// </summary>
		/// <param name="settingName"> A <c>System.String</c> instance.</param>
		/// <param name="value"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Update(TransactionManager transactionManager, System.String settingName, System.String value)
		{
			 Update(transactionManager, 0, int.MaxValue , settingName, value);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_CauHinh_Update' stored procedure. 
		/// </summary>
		/// <param name="settingName"> A <c>System.String</c> instance.</param>
		/// <param name="value"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Update(TransactionManager transactionManager, int start, int pageLength, System.String settingName, System.String value);
		
		#endregion

		
		#region cust_View_CauHinh_GetBySettingName
		
		/// <summary>
		///	This method wrap the 'cust_View_CauHinh_GetBySettingName' stored procedure. 
		/// </summary>
		/// <param name="settingName"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewCauHinh&gt;"/> instance.</returns>
		public VList<ViewCauHinh> GetBySettingName(System.String settingName)
		{
			return GetBySettingName(null, 0, int.MaxValue , settingName);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_CauHinh_GetBySettingName' stored procedure. 
		/// </summary>
		/// <param name="settingName"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewCauHinh&gt;"/> instance.</returns>
		public VList<ViewCauHinh> GetBySettingName(int start, int pageLength, System.String settingName)
		{
			return GetBySettingName(null, start, pageLength , settingName);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_CauHinh_GetBySettingName' stored procedure. 
		/// </summary>
		/// <param name="settingName"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewCauHinh&gt;"/> instance.</returns>
		public VList<ViewCauHinh> GetBySettingName(TransactionManager transactionManager, System.String settingName)
		{
			return GetBySettingName(transactionManager, 0, int.MaxValue , settingName);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_CauHinh_GetBySettingName' stored procedure. 
		/// </summary>
		/// <param name="settingName"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewCauHinh&gt;"/> instance.</returns>
		public abstract VList<ViewCauHinh> GetBySettingName(TransactionManager transactionManager, int start, int pageLength, System.String settingName);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewCauHinh&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewCauHinh&gt;"/></returns>
		protected static VList&lt;ViewCauHinh&gt; Fill(DataSet dataSet, VList<ViewCauHinh> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewCauHinh>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewCauHinh&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewCauHinh>"/></returns>
		protected static VList&lt;ViewCauHinh&gt; Fill(DataTable dataTable, VList<ViewCauHinh> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewCauHinh c = new ViewCauHinh();
					c.SettingName = (Convert.IsDBNull(row["SettingName"]))?string.Empty:(System.String)row["SettingName"];
					c.SettingStringData = (Convert.IsDBNull(row["SettingStringData"]))?string.Empty:(System.String)row["SettingStringData"];
					c.SettingBinaryData = (Convert.IsDBNull(row["SettingBinaryData"]))?new byte[] {}:(System.Byte[])row["SettingBinaryData"];
					c.Descriptions = (Convert.IsDBNull(row["Descriptions"]))?string.Empty:(System.String)row["Descriptions"];
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
		/// Fill an <see cref="VList&lt;ViewCauHinh&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewCauHinh&gt;"/></returns>
		protected VList<ViewCauHinh> Fill(IDataReader reader, VList<ViewCauHinh> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewCauHinh entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewCauHinh>("ViewCauHinh",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewCauHinh();
					}
					
					entity.SuppressEntityEvents = true;

					entity.SettingName = (System.String)reader["SettingName"];
					//entity.SettingName = (Convert.IsDBNull(reader["SettingName"]))?string.Empty:(System.String)reader["SettingName"];
					entity.SettingStringData = reader.IsDBNull(reader.GetOrdinal("SettingStringData")) ? null : (System.String)reader["SettingStringData"];
					//entity.SettingStringData = (Convert.IsDBNull(reader["SettingStringData"]))?string.Empty:(System.String)reader["SettingStringData"];
					entity.SettingBinaryData = reader.IsDBNull(reader.GetOrdinal("SettingBinaryData")) ? null : (System.Byte[])reader["SettingBinaryData"];
					//entity.SettingBinaryData = (Convert.IsDBNull(reader["SettingBinaryData"]))?new byte[] {}:(System.Byte[])reader["SettingBinaryData"];
					entity.Descriptions = reader.IsDBNull(reader.GetOrdinal("Descriptions")) ? null : (System.String)reader["Descriptions"];
					//entity.Descriptions = (Convert.IsDBNull(reader["Descriptions"]))?string.Empty:(System.String)reader["Descriptions"];
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
		/// Refreshes the <see cref="ViewCauHinh"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewCauHinh"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewCauHinh entity)
		{
			reader.Read();
			entity.SettingName = (System.String)reader["SettingName"];
			//entity.SettingName = (Convert.IsDBNull(reader["SettingName"]))?string.Empty:(System.String)reader["SettingName"];
			entity.SettingStringData = reader.IsDBNull(reader.GetOrdinal("SettingStringData")) ? null : (System.String)reader["SettingStringData"];
			//entity.SettingStringData = (Convert.IsDBNull(reader["SettingStringData"]))?string.Empty:(System.String)reader["SettingStringData"];
			entity.SettingBinaryData = reader.IsDBNull(reader.GetOrdinal("SettingBinaryData")) ? null : (System.Byte[])reader["SettingBinaryData"];
			//entity.SettingBinaryData = (Convert.IsDBNull(reader["SettingBinaryData"]))?new byte[] {}:(System.Byte[])reader["SettingBinaryData"];
			entity.Descriptions = reader.IsDBNull(reader.GetOrdinal("Descriptions")) ? null : (System.String)reader["Descriptions"];
			//entity.Descriptions = (Convert.IsDBNull(reader["Descriptions"]))?string.Empty:(System.String)reader["Descriptions"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewCauHinh"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewCauHinh"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewCauHinh entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SettingName = (Convert.IsDBNull(dataRow["SettingName"]))?string.Empty:(System.String)dataRow["SettingName"];
			entity.SettingStringData = (Convert.IsDBNull(dataRow["SettingStringData"]))?string.Empty:(System.String)dataRow["SettingStringData"];
			entity.SettingBinaryData = (Convert.IsDBNull(dataRow["SettingBinaryData"]))?new byte[] {}:(System.Byte[])dataRow["SettingBinaryData"];
			entity.Descriptions = (Convert.IsDBNull(dataRow["Descriptions"]))?string.Empty:(System.String)dataRow["Descriptions"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewCauHinhFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewCauHinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewCauHinhFilterBuilder : SqlFilterBuilder<ViewCauHinhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewCauHinhFilterBuilder class.
		/// </summary>
		public ViewCauHinhFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewCauHinhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewCauHinhFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewCauHinhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewCauHinhFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewCauHinhFilterBuilder

	#region ViewCauHinhParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewCauHinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewCauHinhParameterBuilder : ParameterizedSqlFilterBuilder<ViewCauHinhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewCauHinhParameterBuilder class.
		/// </summary>
		public ViewCauHinhParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewCauHinhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewCauHinhParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewCauHinhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewCauHinhParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewCauHinhParameterBuilder
	
	#region ViewCauHinhSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewCauHinh"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewCauHinhSortBuilder : SqlSortBuilder<ViewCauHinhColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewCauHinhSqlSortBuilder class.
		/// </summary>
		public ViewCauHinhSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewCauHinhSortBuilder

} // end namespace
