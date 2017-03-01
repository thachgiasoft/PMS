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
	/// This class is the base class for any <see cref="ViewChiTietKhoiLuongThucDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewChiTietKhoiLuongThucDayProviderBaseCore : EntityViewProviderBase<ViewChiTietKhoiLuongThucDay>
	{
		#region Custom Methods
		
		
		#region cust_View_ChiTiet_KhoiLuong_ThucDay_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_KhoiLuong_ThucDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewChiTietKhoiLuongThucDay&gt;"/> instance.</returns>
		public VList<ViewChiTietKhoiLuongThucDay> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_KhoiLuong_ThucDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewChiTietKhoiLuongThucDay&gt;"/> instance.</returns>
		public VList<ViewChiTietKhoiLuongThucDay> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_KhoiLuong_ThucDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewChiTietKhoiLuongThucDay&gt;"/> instance.</returns>
		public VList<ViewChiTietKhoiLuongThucDay> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_KhoiLuong_ThucDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewChiTietKhoiLuongThucDay&gt;"/> instance.</returns>
		public abstract VList<ViewChiTietKhoiLuongThucDay> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewChiTietKhoiLuongThucDay&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewChiTietKhoiLuongThucDay&gt;"/></returns>
		protected static VList&lt;ViewChiTietKhoiLuongThucDay&gt; Fill(DataSet dataSet, VList<ViewChiTietKhoiLuongThucDay> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewChiTietKhoiLuongThucDay>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewChiTietKhoiLuongThucDay&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewChiTietKhoiLuongThucDay>"/></returns>
		protected static VList&lt;ViewChiTietKhoiLuongThucDay&gt; Fill(DataTable dataTable, VList<ViewChiTietKhoiLuongThucDay> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewChiTietKhoiLuongThucDay c = new ViewChiTietKhoiLuongThucDay();
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.MaKhoa = (Convert.IsDBNull(row["MaKhoa"]))?string.Empty:(System.String)row["MaKhoa"];
					c.TenKhoa = (Convert.IsDBNull(row["TenKhoa"]))?string.Empty:(System.String)row["TenKhoa"];
					c.MaBoMon = (Convert.IsDBNull(row["MaBoMon"]))?string.Empty:(System.String)row["MaBoMon"];
					c.TenBoMon = (Convert.IsDBNull(row["TenBoMon"]))?string.Empty:(System.String)row["TenBoMon"];
					c.LyThuyet1 = (Convert.IsDBNull(row["LyThuyet1"]))?0.0m:(System.Decimal?)row["LyThuyet1"];
					c.ThucHanh1 = (Convert.IsDBNull(row["ThucHanh1"]))?0.0m:(System.Decimal?)row["ThucHanh1"];
					c.ThiNghiem1 = (Convert.IsDBNull(row["ThiNghiem1"]))?0.0m:(System.Decimal?)row["ThiNghiem1"];
					c.DoAn1 = (Convert.IsDBNull(row["DoAn1"]))?0.0m:(System.Decimal?)row["DoAn1"];
					c.LyThuyet2 = (Convert.IsDBNull(row["LyThuyet2"]))?0.0m:(System.Decimal?)row["LyThuyet2"];
					c.ThucHanh2 = (Convert.IsDBNull(row["ThucHanh2"]))?0.0m:(System.Decimal?)row["ThucHanh2"];
					c.ThiNghiem2 = (Convert.IsDBNull(row["ThiNghiem2"]))?0.0m:(System.Decimal?)row["ThiNghiem2"];
					c.DoAn2 = (Convert.IsDBNull(row["DoAn2"]))?0.0m:(System.Decimal?)row["DoAn2"];
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
		/// Fill an <see cref="VList&lt;ViewChiTietKhoiLuongThucDay&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewChiTietKhoiLuongThucDay&gt;"/></returns>
		protected VList<ViewChiTietKhoiLuongThucDay> Fill(IDataReader reader, VList<ViewChiTietKhoiLuongThucDay> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewChiTietKhoiLuongThucDay entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewChiTietKhoiLuongThucDay>("ViewChiTietKhoiLuongThucDay",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewChiTietKhoiLuongThucDay();
					}
					
					entity.SuppressEntityEvents = true;

					entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.MaKhoa = reader.IsDBNull(reader.GetOrdinal("MaKhoa")) ? null : (System.String)reader["MaKhoa"];
					//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
					entity.TenKhoa = reader.IsDBNull(reader.GetOrdinal("TenKhoa")) ? null : (System.String)reader["TenKhoa"];
					//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
					entity.MaBoMon = reader.IsDBNull(reader.GetOrdinal("MaBoMon")) ? null : (System.String)reader["MaBoMon"];
					//entity.MaBoMon = (Convert.IsDBNull(reader["MaBoMon"]))?string.Empty:(System.String)reader["MaBoMon"];
					entity.TenBoMon = reader.IsDBNull(reader.GetOrdinal("TenBoMon")) ? null : (System.String)reader["TenBoMon"];
					//entity.TenBoMon = (Convert.IsDBNull(reader["TenBoMon"]))?string.Empty:(System.String)reader["TenBoMon"];
					entity.LyThuyet1 = reader.IsDBNull(reader.GetOrdinal("LyThuyet1")) ? null : (System.Decimal?)reader["LyThuyet1"];
					//entity.LyThuyet1 = (Convert.IsDBNull(reader["LyThuyet1"]))?0.0m:(System.Decimal?)reader["LyThuyet1"];
					entity.ThucHanh1 = reader.IsDBNull(reader.GetOrdinal("ThucHanh1")) ? null : (System.Decimal?)reader["ThucHanh1"];
					//entity.ThucHanh1 = (Convert.IsDBNull(reader["ThucHanh1"]))?0.0m:(System.Decimal?)reader["ThucHanh1"];
					entity.ThiNghiem1 = reader.IsDBNull(reader.GetOrdinal("ThiNghiem1")) ? null : (System.Decimal?)reader["ThiNghiem1"];
					//entity.ThiNghiem1 = (Convert.IsDBNull(reader["ThiNghiem1"]))?0.0m:(System.Decimal?)reader["ThiNghiem1"];
					entity.DoAn1 = reader.IsDBNull(reader.GetOrdinal("DoAn1")) ? null : (System.Decimal?)reader["DoAn1"];
					//entity.DoAn1 = (Convert.IsDBNull(reader["DoAn1"]))?0.0m:(System.Decimal?)reader["DoAn1"];
					entity.LyThuyet2 = reader.IsDBNull(reader.GetOrdinal("LyThuyet2")) ? null : (System.Decimal?)reader["LyThuyet2"];
					//entity.LyThuyet2 = (Convert.IsDBNull(reader["LyThuyet2"]))?0.0m:(System.Decimal?)reader["LyThuyet2"];
					entity.ThucHanh2 = reader.IsDBNull(reader.GetOrdinal("ThucHanh2")) ? null : (System.Decimal?)reader["ThucHanh2"];
					//entity.ThucHanh2 = (Convert.IsDBNull(reader["ThucHanh2"]))?0.0m:(System.Decimal?)reader["ThucHanh2"];
					entity.ThiNghiem2 = reader.IsDBNull(reader.GetOrdinal("ThiNghiem2")) ? null : (System.Decimal?)reader["ThiNghiem2"];
					//entity.ThiNghiem2 = (Convert.IsDBNull(reader["ThiNghiem2"]))?0.0m:(System.Decimal?)reader["ThiNghiem2"];
					entity.DoAn2 = reader.IsDBNull(reader.GetOrdinal("DoAn2")) ? null : (System.Decimal?)reader["DoAn2"];
					//entity.DoAn2 = (Convert.IsDBNull(reader["DoAn2"]))?0.0m:(System.Decimal?)reader["DoAn2"];
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
		/// Refreshes the <see cref="ViewChiTietKhoiLuongThucDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewChiTietKhoiLuongThucDay"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewChiTietKhoiLuongThucDay entity)
		{
			reader.Read();
			entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.MaKhoa = reader.IsDBNull(reader.GetOrdinal("MaKhoa")) ? null : (System.String)reader["MaKhoa"];
			//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
			entity.TenKhoa = reader.IsDBNull(reader.GetOrdinal("TenKhoa")) ? null : (System.String)reader["TenKhoa"];
			//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
			entity.MaBoMon = reader.IsDBNull(reader.GetOrdinal("MaBoMon")) ? null : (System.String)reader["MaBoMon"];
			//entity.MaBoMon = (Convert.IsDBNull(reader["MaBoMon"]))?string.Empty:(System.String)reader["MaBoMon"];
			entity.TenBoMon = reader.IsDBNull(reader.GetOrdinal("TenBoMon")) ? null : (System.String)reader["TenBoMon"];
			//entity.TenBoMon = (Convert.IsDBNull(reader["TenBoMon"]))?string.Empty:(System.String)reader["TenBoMon"];
			entity.LyThuyet1 = reader.IsDBNull(reader.GetOrdinal("LyThuyet1")) ? null : (System.Decimal?)reader["LyThuyet1"];
			//entity.LyThuyet1 = (Convert.IsDBNull(reader["LyThuyet1"]))?0.0m:(System.Decimal?)reader["LyThuyet1"];
			entity.ThucHanh1 = reader.IsDBNull(reader.GetOrdinal("ThucHanh1")) ? null : (System.Decimal?)reader["ThucHanh1"];
			//entity.ThucHanh1 = (Convert.IsDBNull(reader["ThucHanh1"]))?0.0m:(System.Decimal?)reader["ThucHanh1"];
			entity.ThiNghiem1 = reader.IsDBNull(reader.GetOrdinal("ThiNghiem1")) ? null : (System.Decimal?)reader["ThiNghiem1"];
			//entity.ThiNghiem1 = (Convert.IsDBNull(reader["ThiNghiem1"]))?0.0m:(System.Decimal?)reader["ThiNghiem1"];
			entity.DoAn1 = reader.IsDBNull(reader.GetOrdinal("DoAn1")) ? null : (System.Decimal?)reader["DoAn1"];
			//entity.DoAn1 = (Convert.IsDBNull(reader["DoAn1"]))?0.0m:(System.Decimal?)reader["DoAn1"];
			entity.LyThuyet2 = reader.IsDBNull(reader.GetOrdinal("LyThuyet2")) ? null : (System.Decimal?)reader["LyThuyet2"];
			//entity.LyThuyet2 = (Convert.IsDBNull(reader["LyThuyet2"]))?0.0m:(System.Decimal?)reader["LyThuyet2"];
			entity.ThucHanh2 = reader.IsDBNull(reader.GetOrdinal("ThucHanh2")) ? null : (System.Decimal?)reader["ThucHanh2"];
			//entity.ThucHanh2 = (Convert.IsDBNull(reader["ThucHanh2"]))?0.0m:(System.Decimal?)reader["ThucHanh2"];
			entity.ThiNghiem2 = reader.IsDBNull(reader.GetOrdinal("ThiNghiem2")) ? null : (System.Decimal?)reader["ThiNghiem2"];
			//entity.ThiNghiem2 = (Convert.IsDBNull(reader["ThiNghiem2"]))?0.0m:(System.Decimal?)reader["ThiNghiem2"];
			entity.DoAn2 = reader.IsDBNull(reader.GetOrdinal("DoAn2")) ? null : (System.Decimal?)reader["DoAn2"];
			//entity.DoAn2 = (Convert.IsDBNull(reader["DoAn2"]))?0.0m:(System.Decimal?)reader["DoAn2"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewChiTietKhoiLuongThucDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewChiTietKhoiLuongThucDay"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewChiTietKhoiLuongThucDay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.MaKhoa = (Convert.IsDBNull(dataRow["MaKhoa"]))?string.Empty:(System.String)dataRow["MaKhoa"];
			entity.TenKhoa = (Convert.IsDBNull(dataRow["TenKhoa"]))?string.Empty:(System.String)dataRow["TenKhoa"];
			entity.MaBoMon = (Convert.IsDBNull(dataRow["MaBoMon"]))?string.Empty:(System.String)dataRow["MaBoMon"];
			entity.TenBoMon = (Convert.IsDBNull(dataRow["TenBoMon"]))?string.Empty:(System.String)dataRow["TenBoMon"];
			entity.LyThuyet1 = (Convert.IsDBNull(dataRow["LyThuyet1"]))?0.0m:(System.Decimal?)dataRow["LyThuyet1"];
			entity.ThucHanh1 = (Convert.IsDBNull(dataRow["ThucHanh1"]))?0.0m:(System.Decimal?)dataRow["ThucHanh1"];
			entity.ThiNghiem1 = (Convert.IsDBNull(dataRow["ThiNghiem1"]))?0.0m:(System.Decimal?)dataRow["ThiNghiem1"];
			entity.DoAn1 = (Convert.IsDBNull(dataRow["DoAn1"]))?0.0m:(System.Decimal?)dataRow["DoAn1"];
			entity.LyThuyet2 = (Convert.IsDBNull(dataRow["LyThuyet2"]))?0.0m:(System.Decimal?)dataRow["LyThuyet2"];
			entity.ThucHanh2 = (Convert.IsDBNull(dataRow["ThucHanh2"]))?0.0m:(System.Decimal?)dataRow["ThucHanh2"];
			entity.ThiNghiem2 = (Convert.IsDBNull(dataRow["ThiNghiem2"]))?0.0m:(System.Decimal?)dataRow["ThiNghiem2"];
			entity.DoAn2 = (Convert.IsDBNull(dataRow["DoAn2"]))?0.0m:(System.Decimal?)dataRow["DoAn2"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewChiTietKhoiLuongThucDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTietKhoiLuongThucDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewChiTietKhoiLuongThucDayFilterBuilder : SqlFilterBuilder<ViewChiTietKhoiLuongThucDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongThucDayFilterBuilder class.
		/// </summary>
		public ViewChiTietKhoiLuongThucDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongThucDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewChiTietKhoiLuongThucDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongThucDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewChiTietKhoiLuongThucDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewChiTietKhoiLuongThucDayFilterBuilder

	#region ViewChiTietKhoiLuongThucDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTietKhoiLuongThucDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewChiTietKhoiLuongThucDayParameterBuilder : ParameterizedSqlFilterBuilder<ViewChiTietKhoiLuongThucDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongThucDayParameterBuilder class.
		/// </summary>
		public ViewChiTietKhoiLuongThucDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongThucDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewChiTietKhoiLuongThucDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongThucDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewChiTietKhoiLuongThucDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewChiTietKhoiLuongThucDayParameterBuilder
	
	#region ViewChiTietKhoiLuongThucDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTietKhoiLuongThucDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewChiTietKhoiLuongThucDaySortBuilder : SqlSortBuilder<ViewChiTietKhoiLuongThucDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongThucDaySqlSortBuilder class.
		/// </summary>
		public ViewChiTietKhoiLuongThucDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewChiTietKhoiLuongThucDaySortBuilder

} // end namespace
