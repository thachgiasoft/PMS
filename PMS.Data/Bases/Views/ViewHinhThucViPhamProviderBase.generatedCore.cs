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
	/// This class is the base class for any <see cref="ViewHinhThucViPhamProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewHinhThucViPhamProviderBaseCore : EntityViewProviderBase<ViewHinhThucViPham>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewHinhThucViPham&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewHinhThucViPham&gt;"/></returns>
		protected static VList&lt;ViewHinhThucViPham&gt; Fill(DataSet dataSet, VList<ViewHinhThucViPham> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewHinhThucViPham>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewHinhThucViPham&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewHinhThucViPham>"/></returns>
		protected static VList&lt;ViewHinhThucViPham&gt; Fill(DataTable dataTable, VList<ViewHinhThucViPham> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewHinhThucViPham c = new ViewHinhThucViPham();
					c.Oid = (Convert.IsDBNull(row["Oid"]))?Guid.Empty:(System.Guid)row["Oid"];
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.TenHinhThucViPham = (Convert.IsDBNull(row["TenHinhThucViPham"]))?string.Empty:(System.String)row["TenHinhThucViPham"];
					c.OptimisticLockField = (Convert.IsDBNull(row["OptimisticLockField"]))?(int)0:(System.Int32?)row["OptimisticLockField"];
					c.GcRecord = (Convert.IsDBNull(row["GCRecord"]))?(int)0:(System.Int32?)row["GCRecord"];
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
		/// Fill an <see cref="VList&lt;ViewHinhThucViPham&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewHinhThucViPham&gt;"/></returns>
		protected VList<ViewHinhThucViPham> Fill(IDataReader reader, VList<ViewHinhThucViPham> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewHinhThucViPham entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewHinhThucViPham>("ViewHinhThucViPham",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewHinhThucViPham();
					}
					
					entity.SuppressEntityEvents = true;

					entity.Oid = (System.Guid)reader["Oid"];
					//entity.Oid = (Convert.IsDBNull(reader["Oid"]))?Guid.Empty:(System.Guid)reader["Oid"];
					entity.MaQuanLy = reader.IsDBNull(reader.GetOrdinal("MaQuanLy")) ? null : (System.String)reader["MaQuanLy"];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.TenHinhThucViPham = reader.IsDBNull(reader.GetOrdinal("TenHinhThucViPham")) ? null : (System.String)reader["TenHinhThucViPham"];
					//entity.TenHinhThucViPham = (Convert.IsDBNull(reader["TenHinhThucViPham"]))?string.Empty:(System.String)reader["TenHinhThucViPham"];
					entity.OptimisticLockField = reader.IsDBNull(reader.GetOrdinal("OptimisticLockField")) ? null : (System.Int32?)reader["OptimisticLockField"];
					//entity.OptimisticLockField = (Convert.IsDBNull(reader["OptimisticLockField"]))?(int)0:(System.Int32?)reader["OptimisticLockField"];
					entity.GcRecord = reader.IsDBNull(reader.GetOrdinal("GcRecord")) ? null : (System.Int32?)reader["GcRecord"];
					//entity.GcRecord = (Convert.IsDBNull(reader["GCRecord"]))?(int)0:(System.Int32?)reader["GCRecord"];
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
		/// Refreshes the <see cref="ViewHinhThucViPham"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewHinhThucViPham"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewHinhThucViPham entity)
		{
			reader.Read();
			entity.Oid = (System.Guid)reader["Oid"];
			//entity.Oid = (Convert.IsDBNull(reader["Oid"]))?Guid.Empty:(System.Guid)reader["Oid"];
			entity.MaQuanLy = reader.IsDBNull(reader.GetOrdinal("MaQuanLy")) ? null : (System.String)reader["MaQuanLy"];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.TenHinhThucViPham = reader.IsDBNull(reader.GetOrdinal("TenHinhThucViPham")) ? null : (System.String)reader["TenHinhThucViPham"];
			//entity.TenHinhThucViPham = (Convert.IsDBNull(reader["TenHinhThucViPham"]))?string.Empty:(System.String)reader["TenHinhThucViPham"];
			entity.OptimisticLockField = reader.IsDBNull(reader.GetOrdinal("OptimisticLockField")) ? null : (System.Int32?)reader["OptimisticLockField"];
			//entity.OptimisticLockField = (Convert.IsDBNull(reader["OptimisticLockField"]))?(int)0:(System.Int32?)reader["OptimisticLockField"];
			entity.GcRecord = reader.IsDBNull(reader.GetOrdinal("GcRecord")) ? null : (System.Int32?)reader["GcRecord"];
			//entity.GcRecord = (Convert.IsDBNull(reader["GCRecord"]))?(int)0:(System.Int32?)reader["GCRecord"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewHinhThucViPham"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewHinhThucViPham"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewHinhThucViPham entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Oid = (Convert.IsDBNull(dataRow["Oid"]))?Guid.Empty:(System.Guid)dataRow["Oid"];
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.TenHinhThucViPham = (Convert.IsDBNull(dataRow["TenHinhThucViPham"]))?string.Empty:(System.String)dataRow["TenHinhThucViPham"];
			entity.OptimisticLockField = (Convert.IsDBNull(dataRow["OptimisticLockField"]))?(int)0:(System.Int32?)dataRow["OptimisticLockField"];
			entity.GcRecord = (Convert.IsDBNull(dataRow["GCRecord"]))?(int)0:(System.Int32?)dataRow["GCRecord"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewHinhThucViPhamFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHinhThucViPham"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHinhThucViPhamFilterBuilder : SqlFilterBuilder<ViewHinhThucViPhamColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHinhThucViPhamFilterBuilder class.
		/// </summary>
		public ViewHinhThucViPhamFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewHinhThucViPhamFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewHinhThucViPhamFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewHinhThucViPhamFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewHinhThucViPhamFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewHinhThucViPhamFilterBuilder

	#region ViewHinhThucViPhamParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHinhThucViPham"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHinhThucViPhamParameterBuilder : ParameterizedSqlFilterBuilder<ViewHinhThucViPhamColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHinhThucViPhamParameterBuilder class.
		/// </summary>
		public ViewHinhThucViPhamParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewHinhThucViPhamParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewHinhThucViPhamParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewHinhThucViPhamParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewHinhThucViPhamParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewHinhThucViPhamParameterBuilder
	
	#region ViewHinhThucViPhamSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHinhThucViPham"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewHinhThucViPhamSortBuilder : SqlSortBuilder<ViewHinhThucViPhamColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHinhThucViPhamSqlSortBuilder class.
		/// </summary>
		public ViewHinhThucViPhamSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewHinhThucViPhamSortBuilder

} // end namespace
