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
	/// This class is the base class for any <see cref="ViewGiangVienHocPhanProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewGiangVienHocPhanProviderBaseCore : EntityViewProviderBase<ViewGiangVienHocPhan>
	{
		#region Custom Methods
		
		
		#region cust_View_GiangVien_HocPhan_GetByTuNgayDenNgay
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_HocPhan_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="value"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVienHocPhan&gt;"/> instance.</returns>
		public VList<ViewGiangVienHocPhan> GetByTuNgayDenNgay(System.DateTime tuNgay, System.DateTime denNgay, System.String value)
		{
			return GetByTuNgayDenNgay(null, 0, int.MaxValue , tuNgay, denNgay, value);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_HocPhan_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="value"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVienHocPhan&gt;"/> instance.</returns>
		public VList<ViewGiangVienHocPhan> GetByTuNgayDenNgay(int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay, System.String value)
		{
			return GetByTuNgayDenNgay(null, start, pageLength , tuNgay, denNgay, value);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_HocPhan_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="value"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewGiangVienHocPhan&gt;"/> instance.</returns>
		public VList<ViewGiangVienHocPhan> GetByTuNgayDenNgay(TransactionManager transactionManager, System.DateTime tuNgay, System.DateTime denNgay, System.String value)
		{
			return GetByTuNgayDenNgay(transactionManager, 0, int.MaxValue , tuNgay, denNgay, value);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_HocPhan_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="value"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVienHocPhan&gt;"/> instance.</returns>
		public abstract VList<ViewGiangVienHocPhan> GetByTuNgayDenNgay(TransactionManager transactionManager, int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay, System.String value);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewGiangVienHocPhan&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewGiangVienHocPhan&gt;"/></returns>
		protected static VList&lt;ViewGiangVienHocPhan&gt; Fill(DataSet dataSet, VList<ViewGiangVienHocPhan> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewGiangVienHocPhan>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewGiangVienHocPhan&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewGiangVienHocPhan>"/></returns>
		protected static VList&lt;ViewGiangVienHocPhan&gt; Fill(DataTable dataTable, VList<ViewGiangVienHocPhan> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewGiangVienHocPhan c = new ViewGiangVienHocPhan();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32)row["MaGiangVien"];
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.MaLopHocPhan = (Convert.IsDBNull(row["MaLopHocPhan"]))?string.Empty:(System.String)row["MaLopHocPhan"];
					c.MaBacDaoTao = (Convert.IsDBNull(row["MaBacDaoTao"]))?string.Empty:(System.String)row["MaBacDaoTao"];
					c.MaLoaiHinh = (Convert.IsDBNull(row["MaLoaiHinh"]))?string.Empty:(System.String)row["MaLoaiHinh"];
					c.MaBacLoaiHinh = (Convert.IsDBNull(row["MaBacLoaiHinh"]))?string.Empty:(System.String)row["MaBacLoaiHinh"];
					c.DonGia = (Convert.IsDBNull(row["DonGia"]))?0.0m:(System.Decimal)row["DonGia"];
					c.TienThem = (Convert.IsDBNull(row["TienThem"]))?0.0m:(System.Decimal)row["TienThem"];
					c.TongCong = (Convert.IsDBNull(row["TongCong"]))?0.0m:(System.Decimal?)row["TongCong"];
					c.NgayBatDau = (Convert.IsDBNull(row["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)row["NgayBatDau"];
					c.NgayKetThuc = (Convert.IsDBNull(row["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)row["NgayKetThuc"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
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
		/// Fill an <see cref="VList&lt;ViewGiangVienHocPhan&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewGiangVienHocPhan&gt;"/></returns>
		protected VList<ViewGiangVienHocPhan> Fill(IDataReader reader, VList<ViewGiangVienHocPhan> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewGiangVienHocPhan entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewGiangVienHocPhan>("ViewGiangVienHocPhan",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewGiangVienHocPhan();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = (System.Int32)reader[((int)ViewGiangVienHocPhanColumn.MaGiangVien)];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
					entity.MaQuanLy = (System.String)reader[((int)ViewGiangVienHocPhanColumn.MaQuanLy)];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.MaLopHocPhan = (System.String)reader[((int)ViewGiangVienHocPhanColumn.MaLopHocPhan)];
					//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
					entity.MaBacDaoTao = (System.String)reader[((int)ViewGiangVienHocPhanColumn.MaBacDaoTao)];
					//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
					entity.MaLoaiHinh = (System.String)reader[((int)ViewGiangVienHocPhanColumn.MaLoaiHinh)];
					//entity.MaLoaiHinh = (Convert.IsDBNull(reader["MaLoaiHinh"]))?string.Empty:(System.String)reader["MaLoaiHinh"];
					entity.MaBacLoaiHinh = (System.String)reader[((int)ViewGiangVienHocPhanColumn.MaBacLoaiHinh)];
					//entity.MaBacLoaiHinh = (Convert.IsDBNull(reader["MaBacLoaiHinh"]))?string.Empty:(System.String)reader["MaBacLoaiHinh"];
					entity.DonGia = (System.Decimal)reader[((int)ViewGiangVienHocPhanColumn.DonGia)];
					//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal)reader["DonGia"];
					entity.TienThem = (System.Decimal)reader[((int)ViewGiangVienHocPhanColumn.TienThem)];
					//entity.TienThem = (Convert.IsDBNull(reader["TienThem"]))?0.0m:(System.Decimal)reader["TienThem"];
					entity.TongCong = (reader.IsDBNull(((int)ViewGiangVienHocPhanColumn.TongCong)))?null:(System.Decimal?)reader[((int)ViewGiangVienHocPhanColumn.TongCong)];
					//entity.TongCong = (Convert.IsDBNull(reader["TongCong"]))?0.0m:(System.Decimal?)reader["TongCong"];
					entity.NgayBatDau = (reader.IsDBNull(((int)ViewGiangVienHocPhanColumn.NgayBatDau)))?null:(System.DateTime?)reader[((int)ViewGiangVienHocPhanColumn.NgayBatDau)];
					//entity.NgayBatDau = (Convert.IsDBNull(reader["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)reader["NgayBatDau"];
					entity.NgayKetThuc = (reader.IsDBNull(((int)ViewGiangVienHocPhanColumn.NgayKetThuc)))?null:(System.DateTime?)reader[((int)ViewGiangVienHocPhanColumn.NgayKetThuc)];
					//entity.NgayKetThuc = (Convert.IsDBNull(reader["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKetThuc"];
					entity.NamHoc = (System.String)reader[((int)ViewGiangVienHocPhanColumn.NamHoc)];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = (System.String)reader[((int)ViewGiangVienHocPhanColumn.HocKy)];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
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
		/// Refreshes the <see cref="ViewGiangVienHocPhan"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewGiangVienHocPhan"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewGiangVienHocPhan entity)
		{
			reader.Read();
			entity.MaGiangVien = (System.Int32)reader[((int)ViewGiangVienHocPhanColumn.MaGiangVien)];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
			entity.MaQuanLy = (System.String)reader[((int)ViewGiangVienHocPhanColumn.MaQuanLy)];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.MaLopHocPhan = (System.String)reader[((int)ViewGiangVienHocPhanColumn.MaLopHocPhan)];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			entity.MaBacDaoTao = (System.String)reader[((int)ViewGiangVienHocPhanColumn.MaBacDaoTao)];
			//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
			entity.MaLoaiHinh = (System.String)reader[((int)ViewGiangVienHocPhanColumn.MaLoaiHinh)];
			//entity.MaLoaiHinh = (Convert.IsDBNull(reader["MaLoaiHinh"]))?string.Empty:(System.String)reader["MaLoaiHinh"];
			entity.MaBacLoaiHinh = (System.String)reader[((int)ViewGiangVienHocPhanColumn.MaBacLoaiHinh)];
			//entity.MaBacLoaiHinh = (Convert.IsDBNull(reader["MaBacLoaiHinh"]))?string.Empty:(System.String)reader["MaBacLoaiHinh"];
			entity.DonGia = (System.Decimal)reader[((int)ViewGiangVienHocPhanColumn.DonGia)];
			//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal)reader["DonGia"];
			entity.TienThem = (System.Decimal)reader[((int)ViewGiangVienHocPhanColumn.TienThem)];
			//entity.TienThem = (Convert.IsDBNull(reader["TienThem"]))?0.0m:(System.Decimal)reader["TienThem"];
			entity.TongCong = (reader.IsDBNull(((int)ViewGiangVienHocPhanColumn.TongCong)))?null:(System.Decimal?)reader[((int)ViewGiangVienHocPhanColumn.TongCong)];
			//entity.TongCong = (Convert.IsDBNull(reader["TongCong"]))?0.0m:(System.Decimal?)reader["TongCong"];
			entity.NgayBatDau = (reader.IsDBNull(((int)ViewGiangVienHocPhanColumn.NgayBatDau)))?null:(System.DateTime?)reader[((int)ViewGiangVienHocPhanColumn.NgayBatDau)];
			//entity.NgayBatDau = (Convert.IsDBNull(reader["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)reader["NgayBatDau"];
			entity.NgayKetThuc = (reader.IsDBNull(((int)ViewGiangVienHocPhanColumn.NgayKetThuc)))?null:(System.DateTime?)reader[((int)ViewGiangVienHocPhanColumn.NgayKetThuc)];
			//entity.NgayKetThuc = (Convert.IsDBNull(reader["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKetThuc"];
			entity.NamHoc = (System.String)reader[((int)ViewGiangVienHocPhanColumn.NamHoc)];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = (System.String)reader[((int)ViewGiangVienHocPhanColumn.HocKy)];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewGiangVienHocPhan"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewGiangVienHocPhan"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewGiangVienHocPhan entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32)dataRow["MaGiangVien"];
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.MaLopHocPhan = (Convert.IsDBNull(dataRow["MaLopHocPhan"]))?string.Empty:(System.String)dataRow["MaLopHocPhan"];
			entity.MaBacDaoTao = (Convert.IsDBNull(dataRow["MaBacDaoTao"]))?string.Empty:(System.String)dataRow["MaBacDaoTao"];
			entity.MaLoaiHinh = (Convert.IsDBNull(dataRow["MaLoaiHinh"]))?string.Empty:(System.String)dataRow["MaLoaiHinh"];
			entity.MaBacLoaiHinh = (Convert.IsDBNull(dataRow["MaBacLoaiHinh"]))?string.Empty:(System.String)dataRow["MaBacLoaiHinh"];
			entity.DonGia = (Convert.IsDBNull(dataRow["DonGia"]))?0.0m:(System.Decimal)dataRow["DonGia"];
			entity.TienThem = (Convert.IsDBNull(dataRow["TienThem"]))?0.0m:(System.Decimal)dataRow["TienThem"];
			entity.TongCong = (Convert.IsDBNull(dataRow["TongCong"]))?0.0m:(System.Decimal?)dataRow["TongCong"];
			entity.NgayBatDau = (Convert.IsDBNull(dataRow["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayBatDau"];
			entity.NgayKetThuc = (Convert.IsDBNull(dataRow["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayKetThuc"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewGiangVienHocPhanFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVienHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewGiangVienHocPhanFilterBuilder : SqlFilterBuilder<ViewGiangVienHocPhanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienHocPhanFilterBuilder class.
		/// </summary>
		public ViewGiangVienHocPhanFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienHocPhanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewGiangVienHocPhanFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienHocPhanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewGiangVienHocPhanFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewGiangVienHocPhanFilterBuilder

	#region ViewGiangVienHocPhanParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVienHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewGiangVienHocPhanParameterBuilder : ParameterizedSqlFilterBuilder<ViewGiangVienHocPhanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienHocPhanParameterBuilder class.
		/// </summary>
		public ViewGiangVienHocPhanParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienHocPhanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewGiangVienHocPhanParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienHocPhanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewGiangVienHocPhanParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewGiangVienHocPhanParameterBuilder
	
	#region ViewGiangVienHocPhanSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVienHocPhan"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewGiangVienHocPhanSortBuilder : SqlSortBuilder<ViewGiangVienHocPhanColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienHocPhanSqlSortBuilder class.
		/// </summary>
		public ViewGiangVienHocPhanSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewGiangVienHocPhanSortBuilder

} // end namespace
