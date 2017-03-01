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
	/// This class is the base class for any <see cref="ViewTongHopKhoiLuongQuyDoiProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewTongHopKhoiLuongQuyDoiProviderBaseCore : EntityViewProviderBase<ViewTongHopKhoiLuongQuyDoi>
	{
		#region Custom Methods
		
		
		#region cust_View_TongHop_KhoiLuong_QuyDoi_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_TongHop_KhoiLuong_QuyDoi_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			 GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_TongHop_KhoiLuong_QuyDoi_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			 GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_TongHop_KhoiLuong_QuyDoi_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			 GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_TongHop_KhoiLuong_QuyDoi_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewTongHopKhoiLuongQuyDoi&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewTongHopKhoiLuongQuyDoi&gt;"/></returns>
		protected static VList&lt;ViewTongHopKhoiLuongQuyDoi&gt; Fill(DataSet dataSet, VList<ViewTongHopKhoiLuongQuyDoi> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewTongHopKhoiLuongQuyDoi>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewTongHopKhoiLuongQuyDoi&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewTongHopKhoiLuongQuyDoi>"/></returns>
		protected static VList&lt;ViewTongHopKhoiLuongQuyDoi&gt; Fill(DataTable dataTable, VList<ViewTongHopKhoiLuongQuyDoi> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewTongHopKhoiLuongQuyDoi c = new ViewTongHopKhoiLuongQuyDoi();
					c.MaDonVi = (Convert.IsDBNull(row["MaDonVi"]))?string.Empty:(System.String)row["MaDonVi"];
					c.TenDonVi = (Convert.IsDBNull(row["TenDonVi"]))?string.Empty:(System.String)row["TenDonVi"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.TietQuyDoi1 = (Convert.IsDBNull(row["TietQuyDoi1"]))?0.0m:(System.Decimal?)row["TietQuyDoi1"];
					c.TietDoAn1 = (Convert.IsDBNull(row["TietDoAn1"]))?0.0m:(System.Decimal?)row["TietDoAn1"];
					c.TietQuyDoi2 = (Convert.IsDBNull(row["TietQuyDoi2"]))?0.0m:(System.Decimal?)row["TietQuyDoi2"];
					c.TietDoAn2 = (Convert.IsDBNull(row["TietDoAn2"]))?0.0m:(System.Decimal?)row["TietDoAn2"];
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
		/// Fill an <see cref="VList&lt;ViewTongHopKhoiLuongQuyDoi&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewTongHopKhoiLuongQuyDoi&gt;"/></returns>
		protected VList<ViewTongHopKhoiLuongQuyDoi> Fill(IDataReader reader, VList<ViewTongHopKhoiLuongQuyDoi> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewTongHopKhoiLuongQuyDoi entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewTongHopKhoiLuongQuyDoi>("ViewTongHopKhoiLuongQuyDoi",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewTongHopKhoiLuongQuyDoi();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaDonVi = (System.String)reader[((int)ViewTongHopKhoiLuongQuyDoiColumn.MaDonVi)];
					//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
					entity.TenDonVi = (System.String)reader[((int)ViewTongHopKhoiLuongQuyDoiColumn.TenDonVi)];
					//entity.TenDonVi = (Convert.IsDBNull(reader["TenDonVi"]))?string.Empty:(System.String)reader["TenDonVi"];
					entity.NamHoc = (reader.IsDBNull(((int)ViewTongHopKhoiLuongQuyDoiColumn.NamHoc)))?null:(System.String)reader[((int)ViewTongHopKhoiLuongQuyDoiColumn.NamHoc)];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = (reader.IsDBNull(((int)ViewTongHopKhoiLuongQuyDoiColumn.HocKy)))?null:(System.String)reader[((int)ViewTongHopKhoiLuongQuyDoiColumn.HocKy)];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.TietQuyDoi1 = (reader.IsDBNull(((int)ViewTongHopKhoiLuongQuyDoiColumn.TietQuyDoi1)))?null:(System.Decimal?)reader[((int)ViewTongHopKhoiLuongQuyDoiColumn.TietQuyDoi1)];
					//entity.TietQuyDoi1 = (Convert.IsDBNull(reader["TietQuyDoi1"]))?0.0m:(System.Decimal?)reader["TietQuyDoi1"];
					entity.TietDoAn1 = (reader.IsDBNull(((int)ViewTongHopKhoiLuongQuyDoiColumn.TietDoAn1)))?null:(System.Decimal?)reader[((int)ViewTongHopKhoiLuongQuyDoiColumn.TietDoAn1)];
					//entity.TietDoAn1 = (Convert.IsDBNull(reader["TietDoAn1"]))?0.0m:(System.Decimal?)reader["TietDoAn1"];
					entity.TietQuyDoi2 = (reader.IsDBNull(((int)ViewTongHopKhoiLuongQuyDoiColumn.TietQuyDoi2)))?null:(System.Decimal?)reader[((int)ViewTongHopKhoiLuongQuyDoiColumn.TietQuyDoi2)];
					//entity.TietQuyDoi2 = (Convert.IsDBNull(reader["TietQuyDoi2"]))?0.0m:(System.Decimal?)reader["TietQuyDoi2"];
					entity.TietDoAn2 = (reader.IsDBNull(((int)ViewTongHopKhoiLuongQuyDoiColumn.TietDoAn2)))?null:(System.Decimal?)reader[((int)ViewTongHopKhoiLuongQuyDoiColumn.TietDoAn2)];
					//entity.TietDoAn2 = (Convert.IsDBNull(reader["TietDoAn2"]))?0.0m:(System.Decimal?)reader["TietDoAn2"];
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
		/// Refreshes the <see cref="ViewTongHopKhoiLuongQuyDoi"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewTongHopKhoiLuongQuyDoi"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewTongHopKhoiLuongQuyDoi entity)
		{
			reader.Read();
			entity.MaDonVi = (System.String)reader[((int)ViewTongHopKhoiLuongQuyDoiColumn.MaDonVi)];
			//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
			entity.TenDonVi = (System.String)reader[((int)ViewTongHopKhoiLuongQuyDoiColumn.TenDonVi)];
			//entity.TenDonVi = (Convert.IsDBNull(reader["TenDonVi"]))?string.Empty:(System.String)reader["TenDonVi"];
			entity.NamHoc = (reader.IsDBNull(((int)ViewTongHopKhoiLuongQuyDoiColumn.NamHoc)))?null:(System.String)reader[((int)ViewTongHopKhoiLuongQuyDoiColumn.NamHoc)];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = (reader.IsDBNull(((int)ViewTongHopKhoiLuongQuyDoiColumn.HocKy)))?null:(System.String)reader[((int)ViewTongHopKhoiLuongQuyDoiColumn.HocKy)];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.TietQuyDoi1 = (reader.IsDBNull(((int)ViewTongHopKhoiLuongQuyDoiColumn.TietQuyDoi1)))?null:(System.Decimal?)reader[((int)ViewTongHopKhoiLuongQuyDoiColumn.TietQuyDoi1)];
			//entity.TietQuyDoi1 = (Convert.IsDBNull(reader["TietQuyDoi1"]))?0.0m:(System.Decimal?)reader["TietQuyDoi1"];
			entity.TietDoAn1 = (reader.IsDBNull(((int)ViewTongHopKhoiLuongQuyDoiColumn.TietDoAn1)))?null:(System.Decimal?)reader[((int)ViewTongHopKhoiLuongQuyDoiColumn.TietDoAn1)];
			//entity.TietDoAn1 = (Convert.IsDBNull(reader["TietDoAn1"]))?0.0m:(System.Decimal?)reader["TietDoAn1"];
			entity.TietQuyDoi2 = (reader.IsDBNull(((int)ViewTongHopKhoiLuongQuyDoiColumn.TietQuyDoi2)))?null:(System.Decimal?)reader[((int)ViewTongHopKhoiLuongQuyDoiColumn.TietQuyDoi2)];
			//entity.TietQuyDoi2 = (Convert.IsDBNull(reader["TietQuyDoi2"]))?0.0m:(System.Decimal?)reader["TietQuyDoi2"];
			entity.TietDoAn2 = (reader.IsDBNull(((int)ViewTongHopKhoiLuongQuyDoiColumn.TietDoAn2)))?null:(System.Decimal?)reader[((int)ViewTongHopKhoiLuongQuyDoiColumn.TietDoAn2)];
			//entity.TietDoAn2 = (Convert.IsDBNull(reader["TietDoAn2"]))?0.0m:(System.Decimal?)reader["TietDoAn2"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewTongHopKhoiLuongQuyDoi"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewTongHopKhoiLuongQuyDoi"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewTongHopKhoiLuongQuyDoi entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaDonVi = (Convert.IsDBNull(dataRow["MaDonVi"]))?string.Empty:(System.String)dataRow["MaDonVi"];
			entity.TenDonVi = (Convert.IsDBNull(dataRow["TenDonVi"]))?string.Empty:(System.String)dataRow["TenDonVi"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.TietQuyDoi1 = (Convert.IsDBNull(dataRow["TietQuyDoi1"]))?0.0m:(System.Decimal?)dataRow["TietQuyDoi1"];
			entity.TietDoAn1 = (Convert.IsDBNull(dataRow["TietDoAn1"]))?0.0m:(System.Decimal?)dataRow["TietDoAn1"];
			entity.TietQuyDoi2 = (Convert.IsDBNull(dataRow["TietQuyDoi2"]))?0.0m:(System.Decimal?)dataRow["TietQuyDoi2"];
			entity.TietDoAn2 = (Convert.IsDBNull(dataRow["TietDoAn2"]))?0.0m:(System.Decimal?)dataRow["TietDoAn2"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewTongHopKhoiLuongQuyDoiFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTongHopKhoiLuongQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTongHopKhoiLuongQuyDoiFilterBuilder : SqlFilterBuilder<ViewTongHopKhoiLuongQuyDoiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTongHopKhoiLuongQuyDoiFilterBuilder class.
		/// </summary>
		public ViewTongHopKhoiLuongQuyDoiFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewTongHopKhoiLuongQuyDoiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewTongHopKhoiLuongQuyDoiFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewTongHopKhoiLuongQuyDoiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewTongHopKhoiLuongQuyDoiFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewTongHopKhoiLuongQuyDoiFilterBuilder

	#region ViewTongHopKhoiLuongQuyDoiParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTongHopKhoiLuongQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTongHopKhoiLuongQuyDoiParameterBuilder : ParameterizedSqlFilterBuilder<ViewTongHopKhoiLuongQuyDoiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTongHopKhoiLuongQuyDoiParameterBuilder class.
		/// </summary>
		public ViewTongHopKhoiLuongQuyDoiParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewTongHopKhoiLuongQuyDoiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewTongHopKhoiLuongQuyDoiParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewTongHopKhoiLuongQuyDoiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewTongHopKhoiLuongQuyDoiParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewTongHopKhoiLuongQuyDoiParameterBuilder
	
	#region ViewTongHopKhoiLuongQuyDoiSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTongHopKhoiLuongQuyDoi"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewTongHopKhoiLuongQuyDoiSortBuilder : SqlSortBuilder<ViewTongHopKhoiLuongQuyDoiColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTongHopKhoiLuongQuyDoiSqlSortBuilder class.
		/// </summary>
		public ViewTongHopKhoiLuongQuyDoiSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewTongHopKhoiLuongQuyDoiSortBuilder

} // end namespace
