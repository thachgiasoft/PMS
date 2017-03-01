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
	/// This class is the base class for any <see cref="ViewMonHocKhoaProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewMonHocKhoaProviderBaseCore : EntityViewProviderBase<ViewMonHocKhoa>
	{
		#region Custom Methods
		
		
		#region cust_View_MonHoc_Khoa_GetByMaDonVi
		
		/// <summary>
		///	This method wrap the 'cust_View_MonHoc_Khoa_GetByMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewMonHocKhoa&gt;"/> instance.</returns>
		public VList<ViewMonHocKhoa> GetByMaDonVi(System.String maDonVi)
		{
			return GetByMaDonVi(null, 0, int.MaxValue , maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_MonHoc_Khoa_GetByMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewMonHocKhoa&gt;"/> instance.</returns>
		public VList<ViewMonHocKhoa> GetByMaDonVi(int start, int pageLength, System.String maDonVi)
		{
			return GetByMaDonVi(null, start, pageLength , maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_MonHoc_Khoa_GetByMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewMonHocKhoa&gt;"/> instance.</returns>
		public VList<ViewMonHocKhoa> GetByMaDonVi(TransactionManager transactionManager, System.String maDonVi)
		{
			return GetByMaDonVi(transactionManager, 0, int.MaxValue , maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_MonHoc_Khoa_GetByMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewMonHocKhoa&gt;"/> instance.</returns>
		public abstract VList<ViewMonHocKhoa> GetByMaDonVi(TransactionManager transactionManager, int start, int pageLength, System.String maDonVi);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewMonHocKhoa&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewMonHocKhoa&gt;"/></returns>
		protected static VList&lt;ViewMonHocKhoa&gt; Fill(DataSet dataSet, VList<ViewMonHocKhoa> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewMonHocKhoa>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewMonHocKhoa&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewMonHocKhoa>"/></returns>
		protected static VList&lt;ViewMonHocKhoa&gt; Fill(DataTable dataTable, VList<ViewMonHocKhoa> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewMonHocKhoa c = new ViewMonHocKhoa();
					c.MaMonHoc = (Convert.IsDBNull(row["MaMonHoc"]))?string.Empty:(System.String)row["MaMonHoc"];
					c.TenMonHoc = (Convert.IsDBNull(row["TenMonHoc"]))?string.Empty:(System.String)row["TenMonHoc"];
					c.TenHienThi = (Convert.IsDBNull(row["TenHienThi"]))?string.Empty:(System.String)row["TenHienThi"];
					c.SoTinChi = (Convert.IsDBNull(row["SoTinChi"]))?0.0m:(System.Decimal)row["SoTinChi"];
					c.MaKhoa = (Convert.IsDBNull(row["MaKhoa"]))?string.Empty:(System.String)row["MaKhoa"];
					c.TenKhoa = (Convert.IsDBNull(row["TenKhoa"]))?string.Empty:(System.String)row["TenKhoa"];
					c.MaBoMon = (Convert.IsDBNull(row["MaBoMon"]))?string.Empty:(System.String)row["MaBoMon"];
					c.TenBoMon = (Convert.IsDBNull(row["TenBoMon"]))?string.Empty:(System.String)row["TenBoMon"];
					c.NhomMonHoc = (Convert.IsDBNull(row["NhomMonHoc"]))?string.Empty:(System.String)row["NhomMonHoc"];
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
		/// Fill an <see cref="VList&lt;ViewMonHocKhoa&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewMonHocKhoa&gt;"/></returns>
		protected VList<ViewMonHocKhoa> Fill(IDataReader reader, VList<ViewMonHocKhoa> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewMonHocKhoa entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewMonHocKhoa>("ViewMonHocKhoa",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewMonHocKhoa();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaMonHoc = (System.String)reader["MaMonHoc"];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.TenMonHoc = (System.String)reader["TenMonHoc"];
					//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
					entity.TenHienThi = (System.String)reader["TenHienThi"];
					//entity.TenHienThi = (Convert.IsDBNull(reader["TenHienThi"]))?string.Empty:(System.String)reader["TenHienThi"];
					entity.SoTinChi = (System.Decimal)reader["SoTinChi"];
					//entity.SoTinChi = (Convert.IsDBNull(reader["SoTinChi"]))?0.0m:(System.Decimal)reader["SoTinChi"];
					entity.MaKhoa = reader.IsDBNull(reader.GetOrdinal("MaKhoa")) ? null : (System.String)reader["MaKhoa"];
					//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
					entity.TenKhoa = reader.IsDBNull(reader.GetOrdinal("TenKhoa")) ? null : (System.String)reader["TenKhoa"];
					//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
					entity.MaBoMon = reader.IsDBNull(reader.GetOrdinal("MaBoMon")) ? null : (System.String)reader["MaBoMon"];
					//entity.MaBoMon = (Convert.IsDBNull(reader["MaBoMon"]))?string.Empty:(System.String)reader["MaBoMon"];
					entity.TenBoMon = reader.IsDBNull(reader.GetOrdinal("TenBoMon")) ? null : (System.String)reader["TenBoMon"];
					//entity.TenBoMon = (Convert.IsDBNull(reader["TenBoMon"]))?string.Empty:(System.String)reader["TenBoMon"];
					entity.NhomMonHoc = reader.IsDBNull(reader.GetOrdinal("NhomMonHoc")) ? null : (System.String)reader["NhomMonHoc"];
					//entity.NhomMonHoc = (Convert.IsDBNull(reader["NhomMonHoc"]))?string.Empty:(System.String)reader["NhomMonHoc"];
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
		/// Refreshes the <see cref="ViewMonHocKhoa"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewMonHocKhoa"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewMonHocKhoa entity)
		{
			reader.Read();
			entity.MaMonHoc = (System.String)reader["MaMonHoc"];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.TenMonHoc = (System.String)reader["TenMonHoc"];
			//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
			entity.TenHienThi = (System.String)reader["TenHienThi"];
			//entity.TenHienThi = (Convert.IsDBNull(reader["TenHienThi"]))?string.Empty:(System.String)reader["TenHienThi"];
			entity.SoTinChi = (System.Decimal)reader["SoTinChi"];
			//entity.SoTinChi = (Convert.IsDBNull(reader["SoTinChi"]))?0.0m:(System.Decimal)reader["SoTinChi"];
			entity.MaKhoa = reader.IsDBNull(reader.GetOrdinal("MaKhoa")) ? null : (System.String)reader["MaKhoa"];
			//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
			entity.TenKhoa = reader.IsDBNull(reader.GetOrdinal("TenKhoa")) ? null : (System.String)reader["TenKhoa"];
			//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
			entity.MaBoMon = reader.IsDBNull(reader.GetOrdinal("MaBoMon")) ? null : (System.String)reader["MaBoMon"];
			//entity.MaBoMon = (Convert.IsDBNull(reader["MaBoMon"]))?string.Empty:(System.String)reader["MaBoMon"];
			entity.TenBoMon = reader.IsDBNull(reader.GetOrdinal("TenBoMon")) ? null : (System.String)reader["TenBoMon"];
			//entity.TenBoMon = (Convert.IsDBNull(reader["TenBoMon"]))?string.Empty:(System.String)reader["TenBoMon"];
			entity.NhomMonHoc = reader.IsDBNull(reader.GetOrdinal("NhomMonHoc")) ? null : (System.String)reader["NhomMonHoc"];
			//entity.NhomMonHoc = (Convert.IsDBNull(reader["NhomMonHoc"]))?string.Empty:(System.String)reader["NhomMonHoc"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewMonHocKhoa"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewMonHocKhoa"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewMonHocKhoa entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaMonHoc = (Convert.IsDBNull(dataRow["MaMonHoc"]))?string.Empty:(System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = (Convert.IsDBNull(dataRow["TenMonHoc"]))?string.Empty:(System.String)dataRow["TenMonHoc"];
			entity.TenHienThi = (Convert.IsDBNull(dataRow["TenHienThi"]))?string.Empty:(System.String)dataRow["TenHienThi"];
			entity.SoTinChi = (Convert.IsDBNull(dataRow["SoTinChi"]))?0.0m:(System.Decimal)dataRow["SoTinChi"];
			entity.MaKhoa = (Convert.IsDBNull(dataRow["MaKhoa"]))?string.Empty:(System.String)dataRow["MaKhoa"];
			entity.TenKhoa = (Convert.IsDBNull(dataRow["TenKhoa"]))?string.Empty:(System.String)dataRow["TenKhoa"];
			entity.MaBoMon = (Convert.IsDBNull(dataRow["MaBoMon"]))?string.Empty:(System.String)dataRow["MaBoMon"];
			entity.TenBoMon = (Convert.IsDBNull(dataRow["TenBoMon"]))?string.Empty:(System.String)dataRow["TenBoMon"];
			entity.NhomMonHoc = (Convert.IsDBNull(dataRow["NhomMonHoc"]))?string.Empty:(System.String)dataRow["NhomMonHoc"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewMonHocKhoaFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewMonHocKhoa"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewMonHocKhoaFilterBuilder : SqlFilterBuilder<ViewMonHocKhoaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewMonHocKhoaFilterBuilder class.
		/// </summary>
		public ViewMonHocKhoaFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewMonHocKhoaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewMonHocKhoaFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewMonHocKhoaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewMonHocKhoaFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewMonHocKhoaFilterBuilder

	#region ViewMonHocKhoaParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewMonHocKhoa"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewMonHocKhoaParameterBuilder : ParameterizedSqlFilterBuilder<ViewMonHocKhoaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewMonHocKhoaParameterBuilder class.
		/// </summary>
		public ViewMonHocKhoaParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewMonHocKhoaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewMonHocKhoaParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewMonHocKhoaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewMonHocKhoaParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewMonHocKhoaParameterBuilder
	
	#region ViewMonHocKhoaSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewMonHocKhoa"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewMonHocKhoaSortBuilder : SqlSortBuilder<ViewMonHocKhoaColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewMonHocKhoaSqlSortBuilder class.
		/// </summary>
		public ViewMonHocKhoaSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewMonHocKhoaSortBuilder

} // end namespace
