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
	/// This class is the base class for any <see cref="ViewPhuTroiNamHocProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewPhuTroiNamHocProviderBaseCore : EntityViewProviderBase<ViewPhuTroiNamHoc>
	{
		#region Custom Methods
		
		
		#region cust_View_PhuTroi_NamHoc_GetByTuNgayDenNgay
		
		/// <summary>
		///	This method wrap the 'cust_View_PhuTroi_NamHoc_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewPhuTroiNamHoc&gt;"/> instance.</returns>
		public VList<ViewPhuTroiNamHoc> GetByTuNgayDenNgay(System.DateTime tuNgay, System.DateTime denNgay, System.String maDonVi, System.Int32 maLoaiGiangVien)
		{
			return GetByTuNgayDenNgay(null, 0, int.MaxValue , tuNgay, denNgay, maDonVi, maLoaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_PhuTroi_NamHoc_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewPhuTroiNamHoc&gt;"/> instance.</returns>
		public VList<ViewPhuTroiNamHoc> GetByTuNgayDenNgay(int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay, System.String maDonVi, System.Int32 maLoaiGiangVien)
		{
			return GetByTuNgayDenNgay(null, start, pageLength , tuNgay, denNgay, maDonVi, maLoaiGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_PhuTroi_NamHoc_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewPhuTroiNamHoc&gt;"/> instance.</returns>
		public VList<ViewPhuTroiNamHoc> GetByTuNgayDenNgay(TransactionManager transactionManager, System.DateTime tuNgay, System.DateTime denNgay, System.String maDonVi, System.Int32 maLoaiGiangVien)
		{
			return GetByTuNgayDenNgay(transactionManager, 0, int.MaxValue , tuNgay, denNgay, maDonVi, maLoaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_PhuTroi_NamHoc_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewPhuTroiNamHoc&gt;"/> instance.</returns>
		public abstract VList<ViewPhuTroiNamHoc> GetByTuNgayDenNgay(TransactionManager transactionManager, int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay, System.String maDonVi, System.Int32 maLoaiGiangVien);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewPhuTroiNamHoc&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewPhuTroiNamHoc&gt;"/></returns>
		protected static VList&lt;ViewPhuTroiNamHoc&gt; Fill(DataSet dataSet, VList<ViewPhuTroiNamHoc> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewPhuTroiNamHoc>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewPhuTroiNamHoc&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewPhuTroiNamHoc>"/></returns>
		protected static VList&lt;ViewPhuTroiNamHoc&gt; Fill(DataTable dataTable, VList<ViewPhuTroiNamHoc> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewPhuTroiNamHoc c = new ViewPhuTroiNamHoc();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?string.Empty:(System.String)row["MaGiangVien"];
					c.TietThucDay = (Convert.IsDBNull(row["TietThucDay"]))?0.0m:(System.Decimal?)row["TietThucDay"];
					c.TietQuyDoi = (Convert.IsDBNull(row["TietQuyDoi"]))?0.0m:(System.Decimal?)row["TietQuyDoi"];
					c.MaChucVu = (Convert.IsDBNull(row["MaChucVu"]))?(int)0:(System.Int32?)row["MaChucVu"];
					c.TenChucVu = (Convert.IsDBNull(row["TenChucVu"]))?string.Empty:(System.String)row["TenChucVu"];
					c.TietNghiaVu = (Convert.IsDBNull(row["TietNghiaVu"]))?0.0m:(System.Decimal?)row["TietNghiaVu"];
					c.Nckh = (Convert.IsDBNull(row["Nckh"]))?0.0m:(System.Decimal?)row["Nckh"];
					c.NhiemVuKhac = (Convert.IsDBNull(row["NhiemVuKhac"]))?0.0m:(System.Decimal?)row["NhiemVuKhac"];
					c.GioChuan = (Convert.IsDBNull(row["GioChuan"]))?0.0m:(System.Decimal?)row["GioChuan"];
					c.HoLot = (Convert.IsDBNull(row["HoLot"]))?string.Empty:(System.String)row["HoLot"];
					c.Ten = (Convert.IsDBNull(row["Ten"]))?string.Empty:(System.String)row["Ten"];
					c.MaDonVi = (Convert.IsDBNull(row["MaDonVi"]))?string.Empty:(System.String)row["MaDonVi"];
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
		/// Fill an <see cref="VList&lt;ViewPhuTroiNamHoc&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewPhuTroiNamHoc&gt;"/></returns>
		protected VList<ViewPhuTroiNamHoc> Fill(IDataReader reader, VList<ViewPhuTroiNamHoc> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewPhuTroiNamHoc entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewPhuTroiNamHoc>("ViewPhuTroiNamHoc",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewPhuTroiNamHoc();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = (reader.IsDBNull(((int)ViewPhuTroiNamHocColumn.MaGiangVien)))?null:(System.String)reader[((int)ViewPhuTroiNamHocColumn.MaGiangVien)];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?string.Empty:(System.String)reader["MaGiangVien"];
					entity.TietThucDay = (reader.IsDBNull(((int)ViewPhuTroiNamHocColumn.TietThucDay)))?null:(System.Decimal?)reader[((int)ViewPhuTroiNamHocColumn.TietThucDay)];
					//entity.TietThucDay = (Convert.IsDBNull(reader["TietThucDay"]))?0.0m:(System.Decimal?)reader["TietThucDay"];
					entity.TietQuyDoi = (reader.IsDBNull(((int)ViewPhuTroiNamHocColumn.TietQuyDoi)))?null:(System.Decimal?)reader[((int)ViewPhuTroiNamHocColumn.TietQuyDoi)];
					//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal?)reader["TietQuyDoi"];
					entity.MaChucVu = (reader.IsDBNull(((int)ViewPhuTroiNamHocColumn.MaChucVu)))?null:(System.Int32?)reader[((int)ViewPhuTroiNamHocColumn.MaChucVu)];
					//entity.MaChucVu = (Convert.IsDBNull(reader["MaChucVu"]))?(int)0:(System.Int32?)reader["MaChucVu"];
					entity.TenChucVu = (reader.IsDBNull(((int)ViewPhuTroiNamHocColumn.TenChucVu)))?null:(System.String)reader[((int)ViewPhuTroiNamHocColumn.TenChucVu)];
					//entity.TenChucVu = (Convert.IsDBNull(reader["TenChucVu"]))?string.Empty:(System.String)reader["TenChucVu"];
					entity.TietNghiaVu = (reader.IsDBNull(((int)ViewPhuTroiNamHocColumn.TietNghiaVu)))?null:(System.Decimal?)reader[((int)ViewPhuTroiNamHocColumn.TietNghiaVu)];
					//entity.TietNghiaVu = (Convert.IsDBNull(reader["TietNghiaVu"]))?0.0m:(System.Decimal?)reader["TietNghiaVu"];
					entity.Nckh = (reader.IsDBNull(((int)ViewPhuTroiNamHocColumn.Nckh)))?null:(System.Decimal?)reader[((int)ViewPhuTroiNamHocColumn.Nckh)];
					//entity.Nckh = (Convert.IsDBNull(reader["Nckh"]))?0.0m:(System.Decimal?)reader["Nckh"];
					entity.NhiemVuKhac = (reader.IsDBNull(((int)ViewPhuTroiNamHocColumn.NhiemVuKhac)))?null:(System.Decimal?)reader[((int)ViewPhuTroiNamHocColumn.NhiemVuKhac)];
					//entity.NhiemVuKhac = (Convert.IsDBNull(reader["NhiemVuKhac"]))?0.0m:(System.Decimal?)reader["NhiemVuKhac"];
					entity.GioChuan = (reader.IsDBNull(((int)ViewPhuTroiNamHocColumn.GioChuan)))?null:(System.Decimal?)reader[((int)ViewPhuTroiNamHocColumn.GioChuan)];
					//entity.GioChuan = (Convert.IsDBNull(reader["GioChuan"]))?0.0m:(System.Decimal?)reader["GioChuan"];
					entity.HoLot = (reader.IsDBNull(((int)ViewPhuTroiNamHocColumn.HoLot)))?null:(System.String)reader[((int)ViewPhuTroiNamHocColumn.HoLot)];
					//entity.HoLot = (Convert.IsDBNull(reader["HoLot"]))?string.Empty:(System.String)reader["HoLot"];
					entity.Ten = (System.String)reader[((int)ViewPhuTroiNamHocColumn.Ten)];
					//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
					entity.MaDonVi = (reader.IsDBNull(((int)ViewPhuTroiNamHocColumn.MaDonVi)))?null:(System.String)reader[((int)ViewPhuTroiNamHocColumn.MaDonVi)];
					//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
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
		/// Refreshes the <see cref="ViewPhuTroiNamHoc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewPhuTroiNamHoc"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewPhuTroiNamHoc entity)
		{
			reader.Read();
			entity.MaGiangVien = (reader.IsDBNull(((int)ViewPhuTroiNamHocColumn.MaGiangVien)))?null:(System.String)reader[((int)ViewPhuTroiNamHocColumn.MaGiangVien)];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?string.Empty:(System.String)reader["MaGiangVien"];
			entity.TietThucDay = (reader.IsDBNull(((int)ViewPhuTroiNamHocColumn.TietThucDay)))?null:(System.Decimal?)reader[((int)ViewPhuTroiNamHocColumn.TietThucDay)];
			//entity.TietThucDay = (Convert.IsDBNull(reader["TietThucDay"]))?0.0m:(System.Decimal?)reader["TietThucDay"];
			entity.TietQuyDoi = (reader.IsDBNull(((int)ViewPhuTroiNamHocColumn.TietQuyDoi)))?null:(System.Decimal?)reader[((int)ViewPhuTroiNamHocColumn.TietQuyDoi)];
			//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal?)reader["TietQuyDoi"];
			entity.MaChucVu = (reader.IsDBNull(((int)ViewPhuTroiNamHocColumn.MaChucVu)))?null:(System.Int32?)reader[((int)ViewPhuTroiNamHocColumn.MaChucVu)];
			//entity.MaChucVu = (Convert.IsDBNull(reader["MaChucVu"]))?(int)0:(System.Int32?)reader["MaChucVu"];
			entity.TenChucVu = (reader.IsDBNull(((int)ViewPhuTroiNamHocColumn.TenChucVu)))?null:(System.String)reader[((int)ViewPhuTroiNamHocColumn.TenChucVu)];
			//entity.TenChucVu = (Convert.IsDBNull(reader["TenChucVu"]))?string.Empty:(System.String)reader["TenChucVu"];
			entity.TietNghiaVu = (reader.IsDBNull(((int)ViewPhuTroiNamHocColumn.TietNghiaVu)))?null:(System.Decimal?)reader[((int)ViewPhuTroiNamHocColumn.TietNghiaVu)];
			//entity.TietNghiaVu = (Convert.IsDBNull(reader["TietNghiaVu"]))?0.0m:(System.Decimal?)reader["TietNghiaVu"];
			entity.Nckh = (reader.IsDBNull(((int)ViewPhuTroiNamHocColumn.Nckh)))?null:(System.Decimal?)reader[((int)ViewPhuTroiNamHocColumn.Nckh)];
			//entity.Nckh = (Convert.IsDBNull(reader["Nckh"]))?0.0m:(System.Decimal?)reader["Nckh"];
			entity.NhiemVuKhac = (reader.IsDBNull(((int)ViewPhuTroiNamHocColumn.NhiemVuKhac)))?null:(System.Decimal?)reader[((int)ViewPhuTroiNamHocColumn.NhiemVuKhac)];
			//entity.NhiemVuKhac = (Convert.IsDBNull(reader["NhiemVuKhac"]))?0.0m:(System.Decimal?)reader["NhiemVuKhac"];
			entity.GioChuan = (reader.IsDBNull(((int)ViewPhuTroiNamHocColumn.GioChuan)))?null:(System.Decimal?)reader[((int)ViewPhuTroiNamHocColumn.GioChuan)];
			//entity.GioChuan = (Convert.IsDBNull(reader["GioChuan"]))?0.0m:(System.Decimal?)reader["GioChuan"];
			entity.HoLot = (reader.IsDBNull(((int)ViewPhuTroiNamHocColumn.HoLot)))?null:(System.String)reader[((int)ViewPhuTroiNamHocColumn.HoLot)];
			//entity.HoLot = (Convert.IsDBNull(reader["HoLot"]))?string.Empty:(System.String)reader["HoLot"];
			entity.Ten = (System.String)reader[((int)ViewPhuTroiNamHocColumn.Ten)];
			//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
			entity.MaDonVi = (reader.IsDBNull(((int)ViewPhuTroiNamHocColumn.MaDonVi)))?null:(System.String)reader[((int)ViewPhuTroiNamHocColumn.MaDonVi)];
			//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewPhuTroiNamHoc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewPhuTroiNamHoc"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewPhuTroiNamHoc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?string.Empty:(System.String)dataRow["MaGiangVien"];
			entity.TietThucDay = (Convert.IsDBNull(dataRow["TietThucDay"]))?0.0m:(System.Decimal?)dataRow["TietThucDay"];
			entity.TietQuyDoi = (Convert.IsDBNull(dataRow["TietQuyDoi"]))?0.0m:(System.Decimal?)dataRow["TietQuyDoi"];
			entity.MaChucVu = (Convert.IsDBNull(dataRow["MaChucVu"]))?(int)0:(System.Int32?)dataRow["MaChucVu"];
			entity.TenChucVu = (Convert.IsDBNull(dataRow["TenChucVu"]))?string.Empty:(System.String)dataRow["TenChucVu"];
			entity.TietNghiaVu = (Convert.IsDBNull(dataRow["TietNghiaVu"]))?0.0m:(System.Decimal?)dataRow["TietNghiaVu"];
			entity.Nckh = (Convert.IsDBNull(dataRow["Nckh"]))?0.0m:(System.Decimal?)dataRow["Nckh"];
			entity.NhiemVuKhac = (Convert.IsDBNull(dataRow["NhiemVuKhac"]))?0.0m:(System.Decimal?)dataRow["NhiemVuKhac"];
			entity.GioChuan = (Convert.IsDBNull(dataRow["GioChuan"]))?0.0m:(System.Decimal?)dataRow["GioChuan"];
			entity.HoLot = (Convert.IsDBNull(dataRow["HoLot"]))?string.Empty:(System.String)dataRow["HoLot"];
			entity.Ten = (Convert.IsDBNull(dataRow["Ten"]))?string.Empty:(System.String)dataRow["Ten"];
			entity.MaDonVi = (Convert.IsDBNull(dataRow["MaDonVi"]))?string.Empty:(System.String)dataRow["MaDonVi"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewPhuTroiNamHocFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhuTroiNamHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhuTroiNamHocFilterBuilder : SqlFilterBuilder<ViewPhuTroiNamHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhuTroiNamHocFilterBuilder class.
		/// </summary>
		public ViewPhuTroiNamHocFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewPhuTroiNamHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewPhuTroiNamHocFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewPhuTroiNamHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewPhuTroiNamHocFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewPhuTroiNamHocFilterBuilder

	#region ViewPhuTroiNamHocParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhuTroiNamHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhuTroiNamHocParameterBuilder : ParameterizedSqlFilterBuilder<ViewPhuTroiNamHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhuTroiNamHocParameterBuilder class.
		/// </summary>
		public ViewPhuTroiNamHocParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewPhuTroiNamHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewPhuTroiNamHocParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewPhuTroiNamHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewPhuTroiNamHocParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewPhuTroiNamHocParameterBuilder
	
	#region ViewPhuTroiNamHocSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhuTroiNamHoc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewPhuTroiNamHocSortBuilder : SqlSortBuilder<ViewPhuTroiNamHocColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhuTroiNamHocSqlSortBuilder class.
		/// </summary>
		public ViewPhuTroiNamHocSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewPhuTroiNamHocSortBuilder

} // end namespace
