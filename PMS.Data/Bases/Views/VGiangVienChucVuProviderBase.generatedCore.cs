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
	/// This class is the base class for any <see cref="VGiangVienChucVuProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class VGiangVienChucVuProviderBaseCore : EntityViewProviderBase<VGiangVienChucVu>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;VGiangVienChucVu&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;VGiangVienChucVu&gt;"/></returns>
		protected static VList&lt;VGiangVienChucVu&gt; Fill(DataSet dataSet, VList<VGiangVienChucVu> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<VGiangVienChucVu>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;VGiangVienChucVu&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<VGiangVienChucVu>"/></returns>
		protected static VList&lt;VGiangVienChucVu&gt; Fill(DataTable dataTable, VList<VGiangVienChucVu> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					VGiangVienChucVu c = new VGiangVienChucVu();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32)row["MaGiangVien"];
					c.NguongTiet = (Convert.IsDBNull(row["NguongTiet"]))?(int)0:(System.Int32?)row["NguongTiet"];
					c.TietNghiaVu = (Convert.IsDBNull(row["TietNghiaVu"]))?0.0m:(System.Decimal?)row["TietNghiaVu"];
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
		/// Fill an <see cref="VList&lt;VGiangVienChucVu&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;VGiangVienChucVu&gt;"/></returns>
		protected VList<VGiangVienChucVu> Fill(IDataReader reader, VList<VGiangVienChucVu> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					VGiangVienChucVu entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<VGiangVienChucVu>("VGiangVienChucVu",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new VGiangVienChucVu();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = (System.Int32)reader["MaGiangVien"];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
					entity.NguongTiet = reader.IsDBNull(reader.GetOrdinal("NguongTiet")) ? null : (System.Int32?)reader["NguongTiet"];
					//entity.NguongTiet = (Convert.IsDBNull(reader["NguongTiet"]))?(int)0:(System.Int32?)reader["NguongTiet"];
					entity.TietNghiaVu = reader.IsDBNull(reader.GetOrdinal("TietNghiaVu")) ? null : (System.Decimal?)reader["TietNghiaVu"];
					//entity.TietNghiaVu = (Convert.IsDBNull(reader["TietNghiaVu"]))?0.0m:(System.Decimal?)reader["TietNghiaVu"];
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
		/// Refreshes the <see cref="VGiangVienChucVu"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="VGiangVienChucVu"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, VGiangVienChucVu entity)
		{
			reader.Read();
			entity.MaGiangVien = (System.Int32)reader["MaGiangVien"];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
			entity.NguongTiet = reader.IsDBNull(reader.GetOrdinal("NguongTiet")) ? null : (System.Int32?)reader["NguongTiet"];
			//entity.NguongTiet = (Convert.IsDBNull(reader["NguongTiet"]))?(int)0:(System.Int32?)reader["NguongTiet"];
			entity.TietNghiaVu = reader.IsDBNull(reader.GetOrdinal("TietNghiaVu")) ? null : (System.Decimal?)reader["TietNghiaVu"];
			//entity.TietNghiaVu = (Convert.IsDBNull(reader["TietNghiaVu"]))?0.0m:(System.Decimal?)reader["TietNghiaVu"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="VGiangVienChucVu"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="VGiangVienChucVu"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, VGiangVienChucVu entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32)dataRow["MaGiangVien"];
			entity.NguongTiet = (Convert.IsDBNull(dataRow["NguongTiet"]))?(int)0:(System.Int32?)dataRow["NguongTiet"];
			entity.TietNghiaVu = (Convert.IsDBNull(dataRow["TietNghiaVu"]))?0.0m:(System.Decimal?)dataRow["TietNghiaVu"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region VGiangVienChucVuFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VGiangVienChucVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VGiangVienChucVuFilterBuilder : SqlFilterBuilder<VGiangVienChucVuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VGiangVienChucVuFilterBuilder class.
		/// </summary>
		public VGiangVienChucVuFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VGiangVienChucVuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VGiangVienChucVuFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VGiangVienChucVuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VGiangVienChucVuFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VGiangVienChucVuFilterBuilder

	#region VGiangVienChucVuParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VGiangVienChucVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VGiangVienChucVuParameterBuilder : ParameterizedSqlFilterBuilder<VGiangVienChucVuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VGiangVienChucVuParameterBuilder class.
		/// </summary>
		public VGiangVienChucVuParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VGiangVienChucVuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VGiangVienChucVuParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VGiangVienChucVuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VGiangVienChucVuParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VGiangVienChucVuParameterBuilder
	
	#region VGiangVienChucVuSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VGiangVienChucVu"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class VGiangVienChucVuSortBuilder : SqlSortBuilder<VGiangVienChucVuColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VGiangVienChucVuSqlSortBuilder class.
		/// </summary>
		public VGiangVienChucVuSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion VGiangVienChucVuSortBuilder

} // end namespace
