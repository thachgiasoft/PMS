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
	/// This class is the base class for any <see cref="VwKhoanQuyDoiHeSoLopDongThProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class VwKhoanQuyDoiHeSoLopDongThProviderBaseCore : EntityViewProviderBase<VwKhoanQuyDoiHeSoLopDongTh>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;VwKhoanQuyDoiHeSoLopDongTh&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;VwKhoanQuyDoiHeSoLopDongTh&gt;"/></returns>
		protected static VList&lt;VwKhoanQuyDoiHeSoLopDongTh&gt; Fill(DataSet dataSet, VList<VwKhoanQuyDoiHeSoLopDongTh> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<VwKhoanQuyDoiHeSoLopDongTh>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;VwKhoanQuyDoiHeSoLopDongTh&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<VwKhoanQuyDoiHeSoLopDongTh>"/></returns>
		protected static VList&lt;VwKhoanQuyDoiHeSoLopDongTh&gt; Fill(DataTable dataTable, VList<VwKhoanQuyDoiHeSoLopDongTh> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					VwKhoanQuyDoiHeSoLopDongTh c = new VwKhoanQuyDoiHeSoLopDongTh();
					c.TuKhoan = (Convert.IsDBNull(row["TuKhoan"]))?(int)0:(System.Int32?)row["TuKhoan"];
					c.DenKhoan = (Convert.IsDBNull(row["DenKhoan"]))?(int)0:(System.Int32?)row["DenKhoan"];
					c.HeSo = (Convert.IsDBNull(row["HeSo"]))?0.0m:(System.Decimal?)row["HeSo"];
					c.ThuTu = (Convert.IsDBNull(row["ThuTu"]))?(int)0:(System.Int32?)row["ThuTu"];
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
		/// Fill an <see cref="VList&lt;VwKhoanQuyDoiHeSoLopDongTh&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;VwKhoanQuyDoiHeSoLopDongTh&gt;"/></returns>
		protected VList<VwKhoanQuyDoiHeSoLopDongTh> Fill(IDataReader reader, VList<VwKhoanQuyDoiHeSoLopDongTh> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					VwKhoanQuyDoiHeSoLopDongTh entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<VwKhoanQuyDoiHeSoLopDongTh>("VwKhoanQuyDoiHeSoLopDongTh",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new VwKhoanQuyDoiHeSoLopDongTh();
					}
					
					entity.SuppressEntityEvents = true;

					entity.TuKhoan = (reader.IsDBNull(((int)VwKhoanQuyDoiHeSoLopDongThColumn.TuKhoan)))?null:(System.Int32?)reader[((int)VwKhoanQuyDoiHeSoLopDongThColumn.TuKhoan)];
					//entity.TuKhoan = (Convert.IsDBNull(reader["TuKhoan"]))?(int)0:(System.Int32?)reader["TuKhoan"];
					entity.DenKhoan = (reader.IsDBNull(((int)VwKhoanQuyDoiHeSoLopDongThColumn.DenKhoan)))?null:(System.Int32?)reader[((int)VwKhoanQuyDoiHeSoLopDongThColumn.DenKhoan)];
					//entity.DenKhoan = (Convert.IsDBNull(reader["DenKhoan"]))?(int)0:(System.Int32?)reader["DenKhoan"];
					entity.HeSo = (reader.IsDBNull(((int)VwKhoanQuyDoiHeSoLopDongThColumn.HeSo)))?null:(System.Decimal?)reader[((int)VwKhoanQuyDoiHeSoLopDongThColumn.HeSo)];
					//entity.HeSo = (Convert.IsDBNull(reader["HeSo"]))?0.0m:(System.Decimal?)reader["HeSo"];
					entity.ThuTu = (reader.IsDBNull(((int)VwKhoanQuyDoiHeSoLopDongThColumn.ThuTu)))?null:(System.Int32?)reader[((int)VwKhoanQuyDoiHeSoLopDongThColumn.ThuTu)];
					//entity.ThuTu = (Convert.IsDBNull(reader["ThuTu"]))?(int)0:(System.Int32?)reader["ThuTu"];
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
		/// Refreshes the <see cref="VwKhoanQuyDoiHeSoLopDongTh"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="VwKhoanQuyDoiHeSoLopDongTh"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, VwKhoanQuyDoiHeSoLopDongTh entity)
		{
			reader.Read();
			entity.TuKhoan = (reader.IsDBNull(((int)VwKhoanQuyDoiHeSoLopDongThColumn.TuKhoan)))?null:(System.Int32?)reader[((int)VwKhoanQuyDoiHeSoLopDongThColumn.TuKhoan)];
			//entity.TuKhoan = (Convert.IsDBNull(reader["TuKhoan"]))?(int)0:(System.Int32?)reader["TuKhoan"];
			entity.DenKhoan = (reader.IsDBNull(((int)VwKhoanQuyDoiHeSoLopDongThColumn.DenKhoan)))?null:(System.Int32?)reader[((int)VwKhoanQuyDoiHeSoLopDongThColumn.DenKhoan)];
			//entity.DenKhoan = (Convert.IsDBNull(reader["DenKhoan"]))?(int)0:(System.Int32?)reader["DenKhoan"];
			entity.HeSo = (reader.IsDBNull(((int)VwKhoanQuyDoiHeSoLopDongThColumn.HeSo)))?null:(System.Decimal?)reader[((int)VwKhoanQuyDoiHeSoLopDongThColumn.HeSo)];
			//entity.HeSo = (Convert.IsDBNull(reader["HeSo"]))?0.0m:(System.Decimal?)reader["HeSo"];
			entity.ThuTu = (reader.IsDBNull(((int)VwKhoanQuyDoiHeSoLopDongThColumn.ThuTu)))?null:(System.Int32?)reader[((int)VwKhoanQuyDoiHeSoLopDongThColumn.ThuTu)];
			//entity.ThuTu = (Convert.IsDBNull(reader["ThuTu"]))?(int)0:(System.Int32?)reader["ThuTu"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="VwKhoanQuyDoiHeSoLopDongTh"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="VwKhoanQuyDoiHeSoLopDongTh"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, VwKhoanQuyDoiHeSoLopDongTh entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.TuKhoan = (Convert.IsDBNull(dataRow["TuKhoan"]))?(int)0:(System.Int32?)dataRow["TuKhoan"];
			entity.DenKhoan = (Convert.IsDBNull(dataRow["DenKhoan"]))?(int)0:(System.Int32?)dataRow["DenKhoan"];
			entity.HeSo = (Convert.IsDBNull(dataRow["HeSo"]))?0.0m:(System.Decimal?)dataRow["HeSo"];
			entity.ThuTu = (Convert.IsDBNull(dataRow["ThuTu"]))?(int)0:(System.Int32?)dataRow["ThuTu"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region VwKhoanQuyDoiHeSoLopDongThFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwKhoanQuyDoiHeSoLopDongTh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VwKhoanQuyDoiHeSoLopDongThFilterBuilder : SqlFilterBuilder<VwKhoanQuyDoiHeSoLopDongThColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwKhoanQuyDoiHeSoLopDongThFilterBuilder class.
		/// </summary>
		public VwKhoanQuyDoiHeSoLopDongThFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VwKhoanQuyDoiHeSoLopDongThFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VwKhoanQuyDoiHeSoLopDongThFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VwKhoanQuyDoiHeSoLopDongThFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VwKhoanQuyDoiHeSoLopDongThFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VwKhoanQuyDoiHeSoLopDongThFilterBuilder

	#region VwKhoanQuyDoiHeSoLopDongThParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwKhoanQuyDoiHeSoLopDongTh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VwKhoanQuyDoiHeSoLopDongThParameterBuilder : ParameterizedSqlFilterBuilder<VwKhoanQuyDoiHeSoLopDongThColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwKhoanQuyDoiHeSoLopDongThParameterBuilder class.
		/// </summary>
		public VwKhoanQuyDoiHeSoLopDongThParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VwKhoanQuyDoiHeSoLopDongThParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VwKhoanQuyDoiHeSoLopDongThParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VwKhoanQuyDoiHeSoLopDongThParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VwKhoanQuyDoiHeSoLopDongThParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VwKhoanQuyDoiHeSoLopDongThParameterBuilder
	
	#region VwKhoanQuyDoiHeSoLopDongThSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwKhoanQuyDoiHeSoLopDongTh"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class VwKhoanQuyDoiHeSoLopDongThSortBuilder : SqlSortBuilder<VwKhoanQuyDoiHeSoLopDongThColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwKhoanQuyDoiHeSoLopDongThSqlSortBuilder class.
		/// </summary>
		public VwKhoanQuyDoiHeSoLopDongThSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion VwKhoanQuyDoiHeSoLopDongThSortBuilder

} // end namespace
