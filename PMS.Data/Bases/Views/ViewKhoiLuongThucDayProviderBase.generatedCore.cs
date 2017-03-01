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
	/// This class is the base class for any <see cref="ViewKhoiLuongThucDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewKhoiLuongThucDayProviderBaseCore : EntityViewProviderBase<ViewKhoiLuongThucDay>
	{
		#region Custom Methods
		
		
		#region cust_View_KhoiLuong_ThucDay_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_ThucDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoiLuongThucDay&gt;"/> instance.</returns>
		public VList<ViewKhoiLuongThucDay> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_ThucDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoiLuongThucDay&gt;"/> instance.</returns>
		public VList<ViewKhoiLuongThucDay> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_ThucDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewKhoiLuongThucDay&gt;"/> instance.</returns>
		public VList<ViewKhoiLuongThucDay> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_ThucDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoiLuongThucDay&gt;"/> instance.</returns>
		public abstract VList<ViewKhoiLuongThucDay> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewKhoiLuongThucDay&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewKhoiLuongThucDay&gt;"/></returns>
		protected static VList&lt;ViewKhoiLuongThucDay&gt; Fill(DataSet dataSet, VList<ViewKhoiLuongThucDay> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewKhoiLuongThucDay>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewKhoiLuongThucDay&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewKhoiLuongThucDay>"/></returns>
		protected static VList&lt;ViewKhoiLuongThucDay&gt; Fill(DataTable dataTable, VList<ViewKhoiLuongThucDay> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewKhoiLuongThucDay c = new ViewKhoiLuongThucDay();
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.MaKhoa = (Convert.IsDBNull(row["MaKhoa"]))?string.Empty:(System.String)row["MaKhoa"];
					c.TenKhoa = (Convert.IsDBNull(row["TenKhoa"]))?string.Empty:(System.String)row["TenKhoa"];
					c.LyThuyet1 = (Convert.IsDBNull(row["LyThuyet1"]))?0.0m:(System.Decimal?)row["LyThuyet1"];
					c.ThucHanh1 = (Convert.IsDBNull(row["ThucHanh1"]))?0.0m:(System.Decimal?)row["ThucHanh1"];
					c.ThiNghiem1 = (Convert.IsDBNull(row["ThiNghiem1"]))?0.0m:(System.Decimal?)row["ThiNghiem1"];
					c.DoAn1 = (Convert.IsDBNull(row["DoAn1"]))?0.0m:(System.Decimal?)row["DoAn1"];
					c.LyThuyet2 = (Convert.IsDBNull(row["LyThuyet2"]))?0.0m:(System.Decimal?)row["LyThuyet2"];
					c.ThucHanh2 = (Convert.IsDBNull(row["ThucHanh2"]))?0.0m:(System.Decimal?)row["ThucHanh2"];
					c.ThiNghiem2 = (Convert.IsDBNull(row["ThiNghiem2"]))?0.0m:(System.Decimal?)row["ThiNghiem2"];
					c.DoAn2 = (Convert.IsDBNull(row["DoAn2"]))?0.0m:(System.Decimal?)row["DoAn2"];
					c.TietLyThuyet = (Convert.IsDBNull(row["TietLyThuyet"]))?0.0m:(System.Decimal?)row["TietLyThuyet"];
					c.TietThucHanh = (Convert.IsDBNull(row["TietThucHanh"]))?0.0m:(System.Decimal?)row["TietThucHanh"];
					c.TietThiNghiem = (Convert.IsDBNull(row["TietThiNghiem"]))?0.0m:(System.Decimal?)row["TietThiNghiem"];
					c.TietDoAn = (Convert.IsDBNull(row["TietDoAn"]))?0.0m:(System.Decimal?)row["TietDoAn"];
					c.TongCong = (Convert.IsDBNull(row["TongCong"]))?0.0m:(System.Decimal?)row["TongCong"];
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
		/// Fill an <see cref="VList&lt;ViewKhoiLuongThucDay&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewKhoiLuongThucDay&gt;"/></returns>
		protected VList<ViewKhoiLuongThucDay> Fill(IDataReader reader, VList<ViewKhoiLuongThucDay> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewKhoiLuongThucDay entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewKhoiLuongThucDay>("ViewKhoiLuongThucDay",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewKhoiLuongThucDay();
					}
					
					entity.SuppressEntityEvents = true;

					entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.MaKhoa = reader.IsDBNull(reader.GetOrdinal("MaKhoa")) ? null : (System.String)reader["MaKhoa"];
					//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
					entity.TenKhoa = reader.IsDBNull(reader.GetOrdinal("TenKhoa")) ? null : (System.String)reader["TenKhoa"];
					//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
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
					entity.TietLyThuyet = reader.IsDBNull(reader.GetOrdinal("TietLyThuyet")) ? null : (System.Decimal?)reader["TietLyThuyet"];
					//entity.TietLyThuyet = (Convert.IsDBNull(reader["TietLyThuyet"]))?0.0m:(System.Decimal?)reader["TietLyThuyet"];
					entity.TietThucHanh = reader.IsDBNull(reader.GetOrdinal("TietThucHanh")) ? null : (System.Decimal?)reader["TietThucHanh"];
					//entity.TietThucHanh = (Convert.IsDBNull(reader["TietThucHanh"]))?0.0m:(System.Decimal?)reader["TietThucHanh"];
					entity.TietThiNghiem = reader.IsDBNull(reader.GetOrdinal("TietThiNghiem")) ? null : (System.Decimal?)reader["TietThiNghiem"];
					//entity.TietThiNghiem = (Convert.IsDBNull(reader["TietThiNghiem"]))?0.0m:(System.Decimal?)reader["TietThiNghiem"];
					entity.TietDoAn = reader.IsDBNull(reader.GetOrdinal("TietDoAn")) ? null : (System.Decimal?)reader["TietDoAn"];
					//entity.TietDoAn = (Convert.IsDBNull(reader["TietDoAn"]))?0.0m:(System.Decimal?)reader["TietDoAn"];
					entity.TongCong = reader.IsDBNull(reader.GetOrdinal("TongCong")) ? null : (System.Decimal?)reader["TongCong"];
					//entity.TongCong = (Convert.IsDBNull(reader["TongCong"]))?0.0m:(System.Decimal?)reader["TongCong"];
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
		/// Refreshes the <see cref="ViewKhoiLuongThucDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewKhoiLuongThucDay"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewKhoiLuongThucDay entity)
		{
			reader.Read();
			entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.MaKhoa = reader.IsDBNull(reader.GetOrdinal("MaKhoa")) ? null : (System.String)reader["MaKhoa"];
			//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
			entity.TenKhoa = reader.IsDBNull(reader.GetOrdinal("TenKhoa")) ? null : (System.String)reader["TenKhoa"];
			//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
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
			entity.TietLyThuyet = reader.IsDBNull(reader.GetOrdinal("TietLyThuyet")) ? null : (System.Decimal?)reader["TietLyThuyet"];
			//entity.TietLyThuyet = (Convert.IsDBNull(reader["TietLyThuyet"]))?0.0m:(System.Decimal?)reader["TietLyThuyet"];
			entity.TietThucHanh = reader.IsDBNull(reader.GetOrdinal("TietThucHanh")) ? null : (System.Decimal?)reader["TietThucHanh"];
			//entity.TietThucHanh = (Convert.IsDBNull(reader["TietThucHanh"]))?0.0m:(System.Decimal?)reader["TietThucHanh"];
			entity.TietThiNghiem = reader.IsDBNull(reader.GetOrdinal("TietThiNghiem")) ? null : (System.Decimal?)reader["TietThiNghiem"];
			//entity.TietThiNghiem = (Convert.IsDBNull(reader["TietThiNghiem"]))?0.0m:(System.Decimal?)reader["TietThiNghiem"];
			entity.TietDoAn = reader.IsDBNull(reader.GetOrdinal("TietDoAn")) ? null : (System.Decimal?)reader["TietDoAn"];
			//entity.TietDoAn = (Convert.IsDBNull(reader["TietDoAn"]))?0.0m:(System.Decimal?)reader["TietDoAn"];
			entity.TongCong = reader.IsDBNull(reader.GetOrdinal("TongCong")) ? null : (System.Decimal?)reader["TongCong"];
			//entity.TongCong = (Convert.IsDBNull(reader["TongCong"]))?0.0m:(System.Decimal?)reader["TongCong"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewKhoiLuongThucDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewKhoiLuongThucDay"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewKhoiLuongThucDay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.MaKhoa = (Convert.IsDBNull(dataRow["MaKhoa"]))?string.Empty:(System.String)dataRow["MaKhoa"];
			entity.TenKhoa = (Convert.IsDBNull(dataRow["TenKhoa"]))?string.Empty:(System.String)dataRow["TenKhoa"];
			entity.LyThuyet1 = (Convert.IsDBNull(dataRow["LyThuyet1"]))?0.0m:(System.Decimal?)dataRow["LyThuyet1"];
			entity.ThucHanh1 = (Convert.IsDBNull(dataRow["ThucHanh1"]))?0.0m:(System.Decimal?)dataRow["ThucHanh1"];
			entity.ThiNghiem1 = (Convert.IsDBNull(dataRow["ThiNghiem1"]))?0.0m:(System.Decimal?)dataRow["ThiNghiem1"];
			entity.DoAn1 = (Convert.IsDBNull(dataRow["DoAn1"]))?0.0m:(System.Decimal?)dataRow["DoAn1"];
			entity.LyThuyet2 = (Convert.IsDBNull(dataRow["LyThuyet2"]))?0.0m:(System.Decimal?)dataRow["LyThuyet2"];
			entity.ThucHanh2 = (Convert.IsDBNull(dataRow["ThucHanh2"]))?0.0m:(System.Decimal?)dataRow["ThucHanh2"];
			entity.ThiNghiem2 = (Convert.IsDBNull(dataRow["ThiNghiem2"]))?0.0m:(System.Decimal?)dataRow["ThiNghiem2"];
			entity.DoAn2 = (Convert.IsDBNull(dataRow["DoAn2"]))?0.0m:(System.Decimal?)dataRow["DoAn2"];
			entity.TietLyThuyet = (Convert.IsDBNull(dataRow["TietLyThuyet"]))?0.0m:(System.Decimal?)dataRow["TietLyThuyet"];
			entity.TietThucHanh = (Convert.IsDBNull(dataRow["TietThucHanh"]))?0.0m:(System.Decimal?)dataRow["TietThucHanh"];
			entity.TietThiNghiem = (Convert.IsDBNull(dataRow["TietThiNghiem"]))?0.0m:(System.Decimal?)dataRow["TietThiNghiem"];
			entity.TietDoAn = (Convert.IsDBNull(dataRow["TietDoAn"]))?0.0m:(System.Decimal?)dataRow["TietDoAn"];
			entity.TongCong = (Convert.IsDBNull(dataRow["TongCong"]))?0.0m:(System.Decimal?)dataRow["TongCong"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewKhoiLuongThucDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoiLuongThucDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKhoiLuongThucDayFilterBuilder : SqlFilterBuilder<ViewKhoiLuongThucDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongThucDayFilterBuilder class.
		/// </summary>
		public ViewKhoiLuongThucDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongThucDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewKhoiLuongThucDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongThucDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewKhoiLuongThucDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewKhoiLuongThucDayFilterBuilder

	#region ViewKhoiLuongThucDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoiLuongThucDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKhoiLuongThucDayParameterBuilder : ParameterizedSqlFilterBuilder<ViewKhoiLuongThucDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongThucDayParameterBuilder class.
		/// </summary>
		public ViewKhoiLuongThucDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongThucDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewKhoiLuongThucDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongThucDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewKhoiLuongThucDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewKhoiLuongThucDayParameterBuilder
	
	#region ViewKhoiLuongThucDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoiLuongThucDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewKhoiLuongThucDaySortBuilder : SqlSortBuilder<ViewKhoiLuongThucDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongThucDaySqlSortBuilder class.
		/// </summary>
		public ViewKhoiLuongThucDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewKhoiLuongThucDaySortBuilder

} // end namespace
