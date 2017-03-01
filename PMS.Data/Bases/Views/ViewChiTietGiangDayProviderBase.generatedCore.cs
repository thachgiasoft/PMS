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
	/// This class is the base class for any <see cref="ViewChiTietGiangDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewChiTietGiangDayProviderBaseCore : EntityViewProviderBase<ViewChiTietGiangDay>
	{
		#region Custom Methods
		
		
		#region cust_View_ChiTiet_GiangDay_GetByMaGiangVienMaLopHocPhanMaKhoaHoc
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_GiangDay_GetByMaGiangVienMaLopHocPhanMaKhoaHoc' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewChiTietGiangDay&gt;"/> instance.</returns>
		public VList<ViewChiTietGiangDay> GetByMaGiangVienMaLopHocPhanMaKhoaHoc(System.String maGiangVien, System.String maLopHocPhan, System.String maKhoaHoc)
		{
			return GetByMaGiangVienMaLopHocPhanMaKhoaHoc(null, 0, int.MaxValue , maGiangVien, maLopHocPhan, maKhoaHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_GiangDay_GetByMaGiangVienMaLopHocPhanMaKhoaHoc' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewChiTietGiangDay&gt;"/> instance.</returns>
		public VList<ViewChiTietGiangDay> GetByMaGiangVienMaLopHocPhanMaKhoaHoc(int start, int pageLength, System.String maGiangVien, System.String maLopHocPhan, System.String maKhoaHoc)
		{
			return GetByMaGiangVienMaLopHocPhanMaKhoaHoc(null, start, pageLength , maGiangVien, maLopHocPhan, maKhoaHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_GiangDay_GetByMaGiangVienMaLopHocPhanMaKhoaHoc' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewChiTietGiangDay&gt;"/> instance.</returns>
		public VList<ViewChiTietGiangDay> GetByMaGiangVienMaLopHocPhanMaKhoaHoc(TransactionManager transactionManager, System.String maGiangVien, System.String maLopHocPhan, System.String maKhoaHoc)
		{
			return GetByMaGiangVienMaLopHocPhanMaKhoaHoc(transactionManager, 0, int.MaxValue , maGiangVien, maLopHocPhan, maKhoaHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_GiangDay_GetByMaGiangVienMaLopHocPhanMaKhoaHoc' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewChiTietGiangDay&gt;"/> instance.</returns>
		public abstract VList<ViewChiTietGiangDay> GetByMaGiangVienMaLopHocPhanMaKhoaHoc(TransactionManager transactionManager, int start, int pageLength, System.String maGiangVien, System.String maLopHocPhan, System.String maKhoaHoc);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewChiTietGiangDay&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewChiTietGiangDay&gt;"/></returns>
		protected static VList&lt;ViewChiTietGiangDay&gt; Fill(DataSet dataSet, VList<ViewChiTietGiangDay> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewChiTietGiangDay>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewChiTietGiangDay&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewChiTietGiangDay>"/></returns>
		protected static VList&lt;ViewChiTietGiangDay&gt; Fill(DataTable dataTable, VList<ViewChiTietGiangDay> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewChiTietGiangDay c = new ViewChiTietGiangDay();
					c.MaLichHoc = (Convert.IsDBNull(row["MaLichHoc"]))?(int)0:(System.Int32)row["MaLichHoc"];
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?string.Empty:(System.String)row["MaGiangVien"];
					c.MaLopHocPhan = (Convert.IsDBNull(row["MaLopHocPhan"]))?string.Empty:(System.String)row["MaLopHocPhan"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.Nam = (Convert.IsDBNull(row["Nam"]))?(int)0:(System.Int32?)row["Nam"];
					c.Tuan = (Convert.IsDBNull(row["Tuan"]))?(int)0:(System.Int32?)row["Tuan"];
					c.MaPhong = (Convert.IsDBNull(row["MaPhong"]))?string.Empty:(System.String)row["MaPhong"];
					c.MaToaNha = (Convert.IsDBNull(row["MaToaNha"]))?string.Empty:(System.String)row["MaToaNha"];
					c.MaBuoiHoc = (Convert.IsDBNull(row["MaBuoiHoc"]))?(int)0:(System.Int32?)row["MaBuoiHoc"];
					c.MaKhoaHoc = (Convert.IsDBNull(row["MaKhoaHoc"]))?string.Empty:(System.String)row["MaKhoaHoc"];
					c.TietBatDau = (Convert.IsDBNull(row["TietBatDau"]))?(int)0:(System.Int32?)row["TietBatDau"];
					c.SoTinChi = (Convert.IsDBNull(row["SoTinChi"]))?0.0m:(System.Decimal)row["SoTinChi"];
					c.SoTiet = (Convert.IsDBNull(row["SoTiet"]))?(int)0:(System.Int32?)row["SoTiet"];
					c.TinhTrang = (Convert.IsDBNull(row["TinhTrang"]))?(int)0:(System.Int32)row["TinhTrang"];
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
		/// Fill an <see cref="VList&lt;ViewChiTietGiangDay&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewChiTietGiangDay&gt;"/></returns>
		protected VList<ViewChiTietGiangDay> Fill(IDataReader reader, VList<ViewChiTietGiangDay> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewChiTietGiangDay entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewChiTietGiangDay>("ViewChiTietGiangDay",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewChiTietGiangDay();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaLichHoc = (System.Int32)reader["MaLichHoc"];
					//entity.MaLichHoc = (Convert.IsDBNull(reader["MaLichHoc"]))?(int)0:(System.Int32)reader["MaLichHoc"];
					entity.MaGiangVien = reader.IsDBNull(reader.GetOrdinal("MaGiangVien")) ? null : (System.String)reader["MaGiangVien"];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?string.Empty:(System.String)reader["MaGiangVien"];
					entity.MaLopHocPhan = (System.String)reader["MaLopHocPhan"];
					//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
					entity.NamHoc = (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.Nam = reader.IsDBNull(reader.GetOrdinal("Nam")) ? null : (System.Int32?)reader["Nam"];
					//entity.Nam = (Convert.IsDBNull(reader["Nam"]))?(int)0:(System.Int32?)reader["Nam"];
					entity.Tuan = reader.IsDBNull(reader.GetOrdinal("Tuan")) ? null : (System.Int32?)reader["Tuan"];
					//entity.Tuan = (Convert.IsDBNull(reader["Tuan"]))?(int)0:(System.Int32?)reader["Tuan"];
					entity.MaPhong = reader.IsDBNull(reader.GetOrdinal("MaPhong")) ? null : (System.String)reader["MaPhong"];
					//entity.MaPhong = (Convert.IsDBNull(reader["MaPhong"]))?string.Empty:(System.String)reader["MaPhong"];
					entity.MaToaNha = reader.IsDBNull(reader.GetOrdinal("MaToaNha")) ? null : (System.String)reader["MaToaNha"];
					//entity.MaToaNha = (Convert.IsDBNull(reader["MaToaNha"]))?string.Empty:(System.String)reader["MaToaNha"];
					entity.MaBuoiHoc = reader.IsDBNull(reader.GetOrdinal("MaBuoiHoc")) ? null : (System.Int32?)reader["MaBuoiHoc"];
					//entity.MaBuoiHoc = (Convert.IsDBNull(reader["MaBuoiHoc"]))?(int)0:(System.Int32?)reader["MaBuoiHoc"];
					entity.MaKhoaHoc = reader.IsDBNull(reader.GetOrdinal("MaKhoaHoc")) ? null : (System.String)reader["MaKhoaHoc"];
					//entity.MaKhoaHoc = (Convert.IsDBNull(reader["MaKhoaHoc"]))?string.Empty:(System.String)reader["MaKhoaHoc"];
					entity.TietBatDau = reader.IsDBNull(reader.GetOrdinal("TietBatDau")) ? null : (System.Int32?)reader["TietBatDau"];
					//entity.TietBatDau = (Convert.IsDBNull(reader["TietBatDau"]))?(int)0:(System.Int32?)reader["TietBatDau"];
					entity.SoTinChi = (System.Decimal)reader["SoTinChi"];
					//entity.SoTinChi = (Convert.IsDBNull(reader["SoTinChi"]))?0.0m:(System.Decimal)reader["SoTinChi"];
					entity.SoTiet = reader.IsDBNull(reader.GetOrdinal("SoTiet")) ? null : (System.Int32?)reader["SoTiet"];
					//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32?)reader["SoTiet"];
					entity.TinhTrang = (System.Int32)reader["TinhTrang"];
					//entity.TinhTrang = (Convert.IsDBNull(reader["TinhTrang"]))?(int)0:(System.Int32)reader["TinhTrang"];
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
		/// Refreshes the <see cref="ViewChiTietGiangDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewChiTietGiangDay"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewChiTietGiangDay entity)
		{
			reader.Read();
			entity.MaLichHoc = (System.Int32)reader["MaLichHoc"];
			//entity.MaLichHoc = (Convert.IsDBNull(reader["MaLichHoc"]))?(int)0:(System.Int32)reader["MaLichHoc"];
			entity.MaGiangVien = reader.IsDBNull(reader.GetOrdinal("MaGiangVien")) ? null : (System.String)reader["MaGiangVien"];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?string.Empty:(System.String)reader["MaGiangVien"];
			entity.MaLopHocPhan = (System.String)reader["MaLopHocPhan"];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			entity.NamHoc = (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.Nam = reader.IsDBNull(reader.GetOrdinal("Nam")) ? null : (System.Int32?)reader["Nam"];
			//entity.Nam = (Convert.IsDBNull(reader["Nam"]))?(int)0:(System.Int32?)reader["Nam"];
			entity.Tuan = reader.IsDBNull(reader.GetOrdinal("Tuan")) ? null : (System.Int32?)reader["Tuan"];
			//entity.Tuan = (Convert.IsDBNull(reader["Tuan"]))?(int)0:(System.Int32?)reader["Tuan"];
			entity.MaPhong = reader.IsDBNull(reader.GetOrdinal("MaPhong")) ? null : (System.String)reader["MaPhong"];
			//entity.MaPhong = (Convert.IsDBNull(reader["MaPhong"]))?string.Empty:(System.String)reader["MaPhong"];
			entity.MaToaNha = reader.IsDBNull(reader.GetOrdinal("MaToaNha")) ? null : (System.String)reader["MaToaNha"];
			//entity.MaToaNha = (Convert.IsDBNull(reader["MaToaNha"]))?string.Empty:(System.String)reader["MaToaNha"];
			entity.MaBuoiHoc = reader.IsDBNull(reader.GetOrdinal("MaBuoiHoc")) ? null : (System.Int32?)reader["MaBuoiHoc"];
			//entity.MaBuoiHoc = (Convert.IsDBNull(reader["MaBuoiHoc"]))?(int)0:(System.Int32?)reader["MaBuoiHoc"];
			entity.MaKhoaHoc = reader.IsDBNull(reader.GetOrdinal("MaKhoaHoc")) ? null : (System.String)reader["MaKhoaHoc"];
			//entity.MaKhoaHoc = (Convert.IsDBNull(reader["MaKhoaHoc"]))?string.Empty:(System.String)reader["MaKhoaHoc"];
			entity.TietBatDau = reader.IsDBNull(reader.GetOrdinal("TietBatDau")) ? null : (System.Int32?)reader["TietBatDau"];
			//entity.TietBatDau = (Convert.IsDBNull(reader["TietBatDau"]))?(int)0:(System.Int32?)reader["TietBatDau"];
			entity.SoTinChi = (System.Decimal)reader["SoTinChi"];
			//entity.SoTinChi = (Convert.IsDBNull(reader["SoTinChi"]))?0.0m:(System.Decimal)reader["SoTinChi"];
			entity.SoTiet = reader.IsDBNull(reader.GetOrdinal("SoTiet")) ? null : (System.Int32?)reader["SoTiet"];
			//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32?)reader["SoTiet"];
			entity.TinhTrang = (System.Int32)reader["TinhTrang"];
			//entity.TinhTrang = (Convert.IsDBNull(reader["TinhTrang"]))?(int)0:(System.Int32)reader["TinhTrang"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewChiTietGiangDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewChiTietGiangDay"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewChiTietGiangDay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaLichHoc = (Convert.IsDBNull(dataRow["MaLichHoc"]))?(int)0:(System.Int32)dataRow["MaLichHoc"];
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?string.Empty:(System.String)dataRow["MaGiangVien"];
			entity.MaLopHocPhan = (Convert.IsDBNull(dataRow["MaLopHocPhan"]))?string.Empty:(System.String)dataRow["MaLopHocPhan"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.Nam = (Convert.IsDBNull(dataRow["Nam"]))?(int)0:(System.Int32?)dataRow["Nam"];
			entity.Tuan = (Convert.IsDBNull(dataRow["Tuan"]))?(int)0:(System.Int32?)dataRow["Tuan"];
			entity.MaPhong = (Convert.IsDBNull(dataRow["MaPhong"]))?string.Empty:(System.String)dataRow["MaPhong"];
			entity.MaToaNha = (Convert.IsDBNull(dataRow["MaToaNha"]))?string.Empty:(System.String)dataRow["MaToaNha"];
			entity.MaBuoiHoc = (Convert.IsDBNull(dataRow["MaBuoiHoc"]))?(int)0:(System.Int32?)dataRow["MaBuoiHoc"];
			entity.MaKhoaHoc = (Convert.IsDBNull(dataRow["MaKhoaHoc"]))?string.Empty:(System.String)dataRow["MaKhoaHoc"];
			entity.TietBatDau = (Convert.IsDBNull(dataRow["TietBatDau"]))?(int)0:(System.Int32?)dataRow["TietBatDau"];
			entity.SoTinChi = (Convert.IsDBNull(dataRow["SoTinChi"]))?0.0m:(System.Decimal)dataRow["SoTinChi"];
			entity.SoTiet = (Convert.IsDBNull(dataRow["SoTiet"]))?(int)0:(System.Int32?)dataRow["SoTiet"];
			entity.TinhTrang = (Convert.IsDBNull(dataRow["TinhTrang"]))?(int)0:(System.Int32)dataRow["TinhTrang"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewChiTietGiangDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTietGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewChiTietGiangDayFilterBuilder : SqlFilterBuilder<ViewChiTietGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTietGiangDayFilterBuilder class.
		/// </summary>
		public ViewChiTietGiangDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTietGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewChiTietGiangDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTietGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewChiTietGiangDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewChiTietGiangDayFilterBuilder

	#region ViewChiTietGiangDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTietGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewChiTietGiangDayParameterBuilder : ParameterizedSqlFilterBuilder<ViewChiTietGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTietGiangDayParameterBuilder class.
		/// </summary>
		public ViewChiTietGiangDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTietGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewChiTietGiangDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTietGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewChiTietGiangDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewChiTietGiangDayParameterBuilder
	
	#region ViewChiTietGiangDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTietGiangDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewChiTietGiangDaySortBuilder : SqlSortBuilder<ViewChiTietGiangDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTietGiangDaySqlSortBuilder class.
		/// </summary>
		public ViewChiTietGiangDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewChiTietGiangDaySortBuilder

} // end namespace
