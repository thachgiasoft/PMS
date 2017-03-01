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
	/// This class is the base class for any <see cref="VwKhoanQuyDoiHeSoLopDongProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class VwKhoanQuyDoiHeSoLopDongProviderBaseCore : EntityViewProviderBase<VwKhoanQuyDoiHeSoLopDong>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;VwKhoanQuyDoiHeSoLopDong&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;VwKhoanQuyDoiHeSoLopDong&gt;"/></returns>
		protected static VList&lt;VwKhoanQuyDoiHeSoLopDong&gt; Fill(DataSet dataSet, VList<VwKhoanQuyDoiHeSoLopDong> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<VwKhoanQuyDoiHeSoLopDong>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;VwKhoanQuyDoiHeSoLopDong&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<VwKhoanQuyDoiHeSoLopDong>"/></returns>
		protected static VList&lt;VwKhoanQuyDoiHeSoLopDong&gt; Fill(DataTable dataTable, VList<VwKhoanQuyDoiHeSoLopDong> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					VwKhoanQuyDoiHeSoLopDong c = new VwKhoanQuyDoiHeSoLopDong();
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
		/// Fill an <see cref="VList&lt;VwKhoanQuyDoiHeSoLopDong&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;VwKhoanQuyDoiHeSoLopDong&gt;"/></returns>
		protected VList<VwKhoanQuyDoiHeSoLopDong> Fill(IDataReader reader, VList<VwKhoanQuyDoiHeSoLopDong> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					VwKhoanQuyDoiHeSoLopDong entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<VwKhoanQuyDoiHeSoLopDong>("VwKhoanQuyDoiHeSoLopDong",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new VwKhoanQuyDoiHeSoLopDong();
					}
					
					entity.SuppressEntityEvents = true;

					entity.TuKhoan = (reader.IsDBNull(((int)VwKhoanQuyDoiHeSoLopDongColumn.TuKhoan)))?null:(System.Int32?)reader[((int)VwKhoanQuyDoiHeSoLopDongColumn.TuKhoan)];
					//entity.TuKhoan = (Convert.IsDBNull(reader["TuKhoan"]))?(int)0:(System.Int32?)reader["TuKhoan"];
					entity.DenKhoan = (reader.IsDBNull(((int)VwKhoanQuyDoiHeSoLopDongColumn.DenKhoan)))?null:(System.Int32?)reader[((int)VwKhoanQuyDoiHeSoLopDongColumn.DenKhoan)];
					//entity.DenKhoan = (Convert.IsDBNull(reader["DenKhoan"]))?(int)0:(System.Int32?)reader["DenKhoan"];
					entity.HeSo = (reader.IsDBNull(((int)VwKhoanQuyDoiHeSoLopDongColumn.HeSo)))?null:(System.Decimal?)reader[((int)VwKhoanQuyDoiHeSoLopDongColumn.HeSo)];
					//entity.HeSo = (Convert.IsDBNull(reader["HeSo"]))?0.0m:(System.Decimal?)reader["HeSo"];
					entity.ThuTu = (reader.IsDBNull(((int)VwKhoanQuyDoiHeSoLopDongColumn.ThuTu)))?null:(System.Int32?)reader[((int)VwKhoanQuyDoiHeSoLopDongColumn.ThuTu)];
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
		/// Refreshes the <see cref="VwKhoanQuyDoiHeSoLopDong"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="VwKhoanQuyDoiHeSoLopDong"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, VwKhoanQuyDoiHeSoLopDong entity)
		{
			reader.Read();
			entity.TuKhoan = (reader.IsDBNull(((int)VwKhoanQuyDoiHeSoLopDongColumn.TuKhoan)))?null:(System.Int32?)reader[((int)VwKhoanQuyDoiHeSoLopDongColumn.TuKhoan)];
			//entity.TuKhoan = (Convert.IsDBNull(reader["TuKhoan"]))?(int)0:(System.Int32?)reader["TuKhoan"];
			entity.DenKhoan = (reader.IsDBNull(((int)VwKhoanQuyDoiHeSoLopDongColumn.DenKhoan)))?null:(System.Int32?)reader[((int)VwKhoanQuyDoiHeSoLopDongColumn.DenKhoan)];
			//entity.DenKhoan = (Convert.IsDBNull(reader["DenKhoan"]))?(int)0:(System.Int32?)reader["DenKhoan"];
			entity.HeSo = (reader.IsDBNull(((int)VwKhoanQuyDoiHeSoLopDongColumn.HeSo)))?null:(System.Decimal?)reader[((int)VwKhoanQuyDoiHeSoLopDongColumn.HeSo)];
			//entity.HeSo = (Convert.IsDBNull(reader["HeSo"]))?0.0m:(System.Decimal?)reader["HeSo"];
			entity.ThuTu = (reader.IsDBNull(((int)VwKhoanQuyDoiHeSoLopDongColumn.ThuTu)))?null:(System.Int32?)reader[((int)VwKhoanQuyDoiHeSoLopDongColumn.ThuTu)];
			//entity.ThuTu = (Convert.IsDBNull(reader["ThuTu"]))?(int)0:(System.Int32?)reader["ThuTu"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="VwKhoanQuyDoiHeSoLopDong"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="VwKhoanQuyDoiHeSoLopDong"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, VwKhoanQuyDoiHeSoLopDong entity)
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

	#region VwKhoanQuyDoiHeSoLopDongFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwKhoanQuyDoiHeSoLopDong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VwKhoanQuyDoiHeSoLopDongFilterBuilder : SqlFilterBuilder<VwKhoanQuyDoiHeSoLopDongColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwKhoanQuyDoiHeSoLopDongFilterBuilder class.
		/// </summary>
		public VwKhoanQuyDoiHeSoLopDongFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VwKhoanQuyDoiHeSoLopDongFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VwKhoanQuyDoiHeSoLopDongFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VwKhoanQuyDoiHeSoLopDongFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VwKhoanQuyDoiHeSoLopDongFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VwKhoanQuyDoiHeSoLopDongFilterBuilder

	#region VwKhoanQuyDoiHeSoLopDongParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwKhoanQuyDoiHeSoLopDong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VwKhoanQuyDoiHeSoLopDongParameterBuilder : ParameterizedSqlFilterBuilder<VwKhoanQuyDoiHeSoLopDongColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwKhoanQuyDoiHeSoLopDongParameterBuilder class.
		/// </summary>
		public VwKhoanQuyDoiHeSoLopDongParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VwKhoanQuyDoiHeSoLopDongParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VwKhoanQuyDoiHeSoLopDongParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VwKhoanQuyDoiHeSoLopDongParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VwKhoanQuyDoiHeSoLopDongParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VwKhoanQuyDoiHeSoLopDongParameterBuilder
	
	#region VwKhoanQuyDoiHeSoLopDongSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwKhoanQuyDoiHeSoLopDong"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class VwKhoanQuyDoiHeSoLopDongSortBuilder : SqlSortBuilder<VwKhoanQuyDoiHeSoLopDongColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwKhoanQuyDoiHeSoLopDongSqlSortBuilder class.
		/// </summary>
		public VwKhoanQuyDoiHeSoLopDongSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion VwKhoanQuyDoiHeSoLopDongSortBuilder

} // end namespace
