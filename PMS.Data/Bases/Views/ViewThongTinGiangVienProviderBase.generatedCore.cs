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
	/// This class is the base class for any <see cref="ViewThongTinGiangVienProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewThongTinGiangVienProviderBaseCore : EntityViewProviderBase<ViewThongTinGiangVien>
	{
		#region Custom Methods
		
		
		#region cust_View_ThongTin_GiangVien_GetByMaGiangVien
		
		/// <summary>
		///	This method wrap the 'cust_View_ThongTin_GiangVien_GetByMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThongTinGiangVien&gt;"/> instance.</returns>
		public VList<ViewThongTinGiangVien> GetByMaGiangVien(System.String maQuanLy)
		{
			return GetByMaGiangVien(null, 0, int.MaxValue , maQuanLy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThongTin_GiangVien_GetByMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThongTinGiangVien&gt;"/> instance.</returns>
		public VList<ViewThongTinGiangVien> GetByMaGiangVien(int start, int pageLength, System.String maQuanLy)
		{
			return GetByMaGiangVien(null, start, pageLength , maQuanLy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ThongTin_GiangVien_GetByMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewThongTinGiangVien&gt;"/> instance.</returns>
		public VList<ViewThongTinGiangVien> GetByMaGiangVien(TransactionManager transactionManager, System.String maQuanLy)
		{
			return GetByMaGiangVien(transactionManager, 0, int.MaxValue , maQuanLy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThongTin_GiangVien_GetByMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThongTinGiangVien&gt;"/> instance.</returns>
		public abstract VList<ViewThongTinGiangVien> GetByMaGiangVien(TransactionManager transactionManager, int start, int pageLength, System.String maQuanLy);
		
		#endregion

		
		#region cust_View_ThongTin_GiangVien_GetByMaQuanLy
		
		/// <summary>
		///	This method wrap the 'cust_View_ThongTin_GiangVien_GetByMaQuanLy' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThongTinGiangVien&gt;"/> instance.</returns>
		public VList<ViewThongTinGiangVien> GetByMaQuanLy(System.String maQuanLy)
		{
			return GetByMaQuanLy(null, 0, int.MaxValue , maQuanLy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThongTin_GiangVien_GetByMaQuanLy' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThongTinGiangVien&gt;"/> instance.</returns>
		public VList<ViewThongTinGiangVien> GetByMaQuanLy(int start, int pageLength, System.String maQuanLy)
		{
			return GetByMaQuanLy(null, start, pageLength , maQuanLy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ThongTin_GiangVien_GetByMaQuanLy' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewThongTinGiangVien&gt;"/> instance.</returns>
		public VList<ViewThongTinGiangVien> GetByMaQuanLy(TransactionManager transactionManager, System.String maQuanLy)
		{
			return GetByMaQuanLy(transactionManager, 0, int.MaxValue , maQuanLy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThongTin_GiangVien_GetByMaQuanLy' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThongTinGiangVien&gt;"/> instance.</returns>
		public abstract VList<ViewThongTinGiangVien> GetByMaQuanLy(TransactionManager transactionManager, int start, int pageLength, System.String maQuanLy);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewThongTinGiangVien&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewThongTinGiangVien&gt;"/></returns>
		protected static VList&lt;ViewThongTinGiangVien&gt; Fill(DataSet dataSet, VList<ViewThongTinGiangVien> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewThongTinGiangVien>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewThongTinGiangVien&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewThongTinGiangVien>"/></returns>
		protected static VList&lt;ViewThongTinGiangVien&gt; Fill(DataTable dataTable, VList<ViewThongTinGiangVien> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewThongTinGiangVien c = new ViewThongTinGiangVien();
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.MaKhoa = (Convert.IsDBNull(row["MaKhoa"]))?string.Empty:(System.String)row["MaKhoa"];
					c.TenKhoa = (Convert.IsDBNull(row["TenKhoa"]))?string.Empty:(System.String)row["TenKhoa"];
					c.MaBoMon = (Convert.IsDBNull(row["MaBoMon"]))?string.Empty:(System.String)row["MaBoMon"];
					c.TenBoMon = (Convert.IsDBNull(row["TenBoMon"]))?string.Empty:(System.String)row["TenBoMon"];
					c.NgaySinh = (Convert.IsDBNull(row["NgaySinh"]))?string.Empty:(System.String)row["NgaySinh"];
					c.GioiTinh = (Convert.IsDBNull(row["GioiTinh"]))?string.Empty:(System.String)row["GioiTinh"];
					c.DienThoai = (Convert.IsDBNull(row["DienThoai"]))?string.Empty:(System.String)row["DienThoai"];
					c.Email = (Convert.IsDBNull(row["Email"]))?string.Empty:(System.String)row["Email"];
					c.NoiSinh = (Convert.IsDBNull(row["NoiSinh"]))?string.Empty:(System.String)row["NoiSinh"];
					c.MatKhau = (Convert.IsDBNull(row["MatKhau"]))?string.Empty:(System.String)row["MatKhau"];
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
		/// Fill an <see cref="VList&lt;ViewThongTinGiangVien&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewThongTinGiangVien&gt;"/></returns>
		protected VList<ViewThongTinGiangVien> Fill(IDataReader reader, VList<ViewThongTinGiangVien> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewThongTinGiangVien entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewThongTinGiangVien>("ViewThongTinGiangVien",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewThongTinGiangVien();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaQuanLy = (System.String)reader["MaQuanLy"];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.MaKhoa = reader.IsDBNull(reader.GetOrdinal("MaKhoa")) ? null : (System.String)reader["MaKhoa"];
					//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
					entity.TenKhoa = reader.IsDBNull(reader.GetOrdinal("TenKhoa")) ? null : (System.String)reader["TenKhoa"];
					//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
					entity.MaBoMon = (System.String)reader["MaBoMon"];
					//entity.MaBoMon = (Convert.IsDBNull(reader["MaBoMon"]))?string.Empty:(System.String)reader["MaBoMon"];
					entity.TenBoMon = (System.String)reader["TenBoMon"];
					//entity.TenBoMon = (Convert.IsDBNull(reader["TenBoMon"]))?string.Empty:(System.String)reader["TenBoMon"];
					entity.NgaySinh = reader.IsDBNull(reader.GetOrdinal("NgaySinh")) ? null : (System.String)reader["NgaySinh"];
					//entity.NgaySinh = (Convert.IsDBNull(reader["NgaySinh"]))?string.Empty:(System.String)reader["NgaySinh"];
					entity.GioiTinh = (System.String)reader["GioiTinh"];
					//entity.GioiTinh = (Convert.IsDBNull(reader["GioiTinh"]))?string.Empty:(System.String)reader["GioiTinh"];
					entity.DienThoai = reader.IsDBNull(reader.GetOrdinal("DienThoai")) ? null : (System.String)reader["DienThoai"];
					//entity.DienThoai = (Convert.IsDBNull(reader["DienThoai"]))?string.Empty:(System.String)reader["DienThoai"];
					entity.Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? null : (System.String)reader["Email"];
					//entity.Email = (Convert.IsDBNull(reader["Email"]))?string.Empty:(System.String)reader["Email"];
					entity.NoiSinh = reader.IsDBNull(reader.GetOrdinal("NoiSinh")) ? null : (System.String)reader["NoiSinh"];
					//entity.NoiSinh = (Convert.IsDBNull(reader["NoiSinh"]))?string.Empty:(System.String)reader["NoiSinh"];
					entity.MatKhau = reader.IsDBNull(reader.GetOrdinal("MatKhau")) ? null : (System.String)reader["MatKhau"];
					//entity.MatKhau = (Convert.IsDBNull(reader["MatKhau"]))?string.Empty:(System.String)reader["MatKhau"];
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
		/// Refreshes the <see cref="ViewThongTinGiangVien"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThongTinGiangVien"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewThongTinGiangVien entity)
		{
			reader.Read();
			entity.MaQuanLy = (System.String)reader["MaQuanLy"];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.MaKhoa = reader.IsDBNull(reader.GetOrdinal("MaKhoa")) ? null : (System.String)reader["MaKhoa"];
			//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
			entity.TenKhoa = reader.IsDBNull(reader.GetOrdinal("TenKhoa")) ? null : (System.String)reader["TenKhoa"];
			//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
			entity.MaBoMon = (System.String)reader["MaBoMon"];
			//entity.MaBoMon = (Convert.IsDBNull(reader["MaBoMon"]))?string.Empty:(System.String)reader["MaBoMon"];
			entity.TenBoMon = (System.String)reader["TenBoMon"];
			//entity.TenBoMon = (Convert.IsDBNull(reader["TenBoMon"]))?string.Empty:(System.String)reader["TenBoMon"];
			entity.NgaySinh = reader.IsDBNull(reader.GetOrdinal("NgaySinh")) ? null : (System.String)reader["NgaySinh"];
			//entity.NgaySinh = (Convert.IsDBNull(reader["NgaySinh"]))?string.Empty:(System.String)reader["NgaySinh"];
			entity.GioiTinh = (System.String)reader["GioiTinh"];
			//entity.GioiTinh = (Convert.IsDBNull(reader["GioiTinh"]))?string.Empty:(System.String)reader["GioiTinh"];
			entity.DienThoai = reader.IsDBNull(reader.GetOrdinal("DienThoai")) ? null : (System.String)reader["DienThoai"];
			//entity.DienThoai = (Convert.IsDBNull(reader["DienThoai"]))?string.Empty:(System.String)reader["DienThoai"];
			entity.Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? null : (System.String)reader["Email"];
			//entity.Email = (Convert.IsDBNull(reader["Email"]))?string.Empty:(System.String)reader["Email"];
			entity.NoiSinh = reader.IsDBNull(reader.GetOrdinal("NoiSinh")) ? null : (System.String)reader["NoiSinh"];
			//entity.NoiSinh = (Convert.IsDBNull(reader["NoiSinh"]))?string.Empty:(System.String)reader["NoiSinh"];
			entity.MatKhau = reader.IsDBNull(reader.GetOrdinal("MatKhau")) ? null : (System.String)reader["MatKhau"];
			//entity.MatKhau = (Convert.IsDBNull(reader["MatKhau"]))?string.Empty:(System.String)reader["MatKhau"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewThongTinGiangVien"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThongTinGiangVien"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewThongTinGiangVien entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.MaKhoa = (Convert.IsDBNull(dataRow["MaKhoa"]))?string.Empty:(System.String)dataRow["MaKhoa"];
			entity.TenKhoa = (Convert.IsDBNull(dataRow["TenKhoa"]))?string.Empty:(System.String)dataRow["TenKhoa"];
			entity.MaBoMon = (Convert.IsDBNull(dataRow["MaBoMon"]))?string.Empty:(System.String)dataRow["MaBoMon"];
			entity.TenBoMon = (Convert.IsDBNull(dataRow["TenBoMon"]))?string.Empty:(System.String)dataRow["TenBoMon"];
			entity.NgaySinh = (Convert.IsDBNull(dataRow["NgaySinh"]))?string.Empty:(System.String)dataRow["NgaySinh"];
			entity.GioiTinh = (Convert.IsDBNull(dataRow["GioiTinh"]))?string.Empty:(System.String)dataRow["GioiTinh"];
			entity.DienThoai = (Convert.IsDBNull(dataRow["DienThoai"]))?string.Empty:(System.String)dataRow["DienThoai"];
			entity.Email = (Convert.IsDBNull(dataRow["Email"]))?string.Empty:(System.String)dataRow["Email"];
			entity.NoiSinh = (Convert.IsDBNull(dataRow["NoiSinh"]))?string.Empty:(System.String)dataRow["NoiSinh"];
			entity.MatKhau = (Convert.IsDBNull(dataRow["MatKhau"]))?string.Empty:(System.String)dataRow["MatKhau"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewThongTinGiangVienFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongTinGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThongTinGiangVienFilterBuilder : SqlFilterBuilder<ViewThongTinGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongTinGiangVienFilterBuilder class.
		/// </summary>
		public ViewThongTinGiangVienFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThongTinGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThongTinGiangVienFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThongTinGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThongTinGiangVienFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThongTinGiangVienFilterBuilder

	#region ViewThongTinGiangVienParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongTinGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThongTinGiangVienParameterBuilder : ParameterizedSqlFilterBuilder<ViewThongTinGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongTinGiangVienParameterBuilder class.
		/// </summary>
		public ViewThongTinGiangVienParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThongTinGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThongTinGiangVienParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThongTinGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThongTinGiangVienParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThongTinGiangVienParameterBuilder
	
	#region ViewThongTinGiangVienSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongTinGiangVien"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewThongTinGiangVienSortBuilder : SqlSortBuilder<ViewThongTinGiangVienColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongTinGiangVienSqlSortBuilder class.
		/// </summary>
		public ViewThongTinGiangVienSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewThongTinGiangVienSortBuilder

} // end namespace
