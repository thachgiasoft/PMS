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
	/// This class is the base class for any <see cref="ViewLopDaiDienProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewLopDaiDienProviderBaseCore : EntityViewProviderBase<ViewLopDaiDien>
	{
		#region Custom Methods
		
		
		#region cust_View_Lop_DaiDien_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_Lop_DaiDien_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			 GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Lop_DaiDien_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_View_Lop_DaiDien_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			 GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Lop_DaiDien_GetByNamHocHocKy' stored procedure. 
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
		/// Fill an VList&lt;ViewLopDaiDien&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewLopDaiDien&gt;"/></returns>
		protected static VList&lt;ViewLopDaiDien&gt; Fill(DataSet dataSet, VList<ViewLopDaiDien> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewLopDaiDien>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewLopDaiDien&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewLopDaiDien>"/></returns>
		protected static VList&lt;ViewLopDaiDien&gt; Fill(DataTable dataTable, VList<ViewLopDaiDien> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewLopDaiDien c = new ViewLopDaiDien();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32?)row["MaGiangVien"];
					c.DonGia = (Convert.IsDBNull(row["DonGia"]))?0.0m:(System.Decimal?)row["DonGia"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.MaLoaiHocPhan = (Convert.IsDBNull(row["MaLoaiHocPhan"]))?(byte)0:(System.Byte)row["MaLoaiHocPhan"];
					c.LoaiHocPhan = (Convert.IsDBNull(row["LoaiHocPhan"]))?string.Empty:(System.String)row["LoaiHocPhan"];
					c.PhanLoai = (Convert.IsDBNull(row["PhanLoai"]))?string.Empty:(System.String)row["PhanLoai"];
					c.MaMonHoc = (Convert.IsDBNull(row["MaMonHoc"]))?string.Empty:(System.String)row["MaMonHoc"];
					c.TenMonHoc = (Convert.IsDBNull(row["TenMonHoc"]))?string.Empty:(System.String)row["TenMonHoc"];
					c.MaNhom = (Convert.IsDBNull(row["MaNhom"]))?string.Empty:(System.String)row["MaNhom"];
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
		/// Fill an <see cref="VList&lt;ViewLopDaiDien&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewLopDaiDien&gt;"/></returns>
		protected VList<ViewLopDaiDien> Fill(IDataReader reader, VList<ViewLopDaiDien> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewLopDaiDien entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewLopDaiDien>("ViewLopDaiDien",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewLopDaiDien();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = (reader.IsDBNull(((int)ViewLopDaiDienColumn.MaGiangVien)))?null:(System.Int32?)reader[((int)ViewLopDaiDienColumn.MaGiangVien)];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32?)reader["MaGiangVien"];
					entity.DonGia = (reader.IsDBNull(((int)ViewLopDaiDienColumn.DonGia)))?null:(System.Decimal?)reader[((int)ViewLopDaiDienColumn.DonGia)];
					//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal?)reader["DonGia"];
					entity.NamHoc = (System.String)reader[((int)ViewLopDaiDienColumn.NamHoc)];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = (System.String)reader[((int)ViewLopDaiDienColumn.HocKy)];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.MaLoaiHocPhan = (System.Byte)reader[((int)ViewLopDaiDienColumn.MaLoaiHocPhan)];
					//entity.MaLoaiHocPhan = (Convert.IsDBNull(reader["MaLoaiHocPhan"]))?(byte)0:(System.Byte)reader["MaLoaiHocPhan"];
					entity.LoaiHocPhan = (reader.IsDBNull(((int)ViewLopDaiDienColumn.LoaiHocPhan)))?null:(System.String)reader[((int)ViewLopDaiDienColumn.LoaiHocPhan)];
					//entity.LoaiHocPhan = (Convert.IsDBNull(reader["LoaiHocPhan"]))?string.Empty:(System.String)reader["LoaiHocPhan"];
					entity.PhanLoai = (reader.IsDBNull(((int)ViewLopDaiDienColumn.PhanLoai)))?null:(System.String)reader[((int)ViewLopDaiDienColumn.PhanLoai)];
					//entity.PhanLoai = (Convert.IsDBNull(reader["PhanLoai"]))?string.Empty:(System.String)reader["PhanLoai"];
					entity.MaMonHoc = (System.String)reader[((int)ViewLopDaiDienColumn.MaMonHoc)];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.TenMonHoc = (System.String)reader[((int)ViewLopDaiDienColumn.TenMonHoc)];
					//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
					entity.MaNhom = (reader.IsDBNull(((int)ViewLopDaiDienColumn.MaNhom)))?null:(System.String)reader[((int)ViewLopDaiDienColumn.MaNhom)];
					//entity.MaNhom = (Convert.IsDBNull(reader["MaNhom"]))?string.Empty:(System.String)reader["MaNhom"];
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
		/// Refreshes the <see cref="ViewLopDaiDien"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewLopDaiDien"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewLopDaiDien entity)
		{
			reader.Read();
			entity.MaGiangVien = (reader.IsDBNull(((int)ViewLopDaiDienColumn.MaGiangVien)))?null:(System.Int32?)reader[((int)ViewLopDaiDienColumn.MaGiangVien)];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32?)reader["MaGiangVien"];
			entity.DonGia = (reader.IsDBNull(((int)ViewLopDaiDienColumn.DonGia)))?null:(System.Decimal?)reader[((int)ViewLopDaiDienColumn.DonGia)];
			//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal?)reader["DonGia"];
			entity.NamHoc = (System.String)reader[((int)ViewLopDaiDienColumn.NamHoc)];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = (System.String)reader[((int)ViewLopDaiDienColumn.HocKy)];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.MaLoaiHocPhan = (System.Byte)reader[((int)ViewLopDaiDienColumn.MaLoaiHocPhan)];
			//entity.MaLoaiHocPhan = (Convert.IsDBNull(reader["MaLoaiHocPhan"]))?(byte)0:(System.Byte)reader["MaLoaiHocPhan"];
			entity.LoaiHocPhan = (reader.IsDBNull(((int)ViewLopDaiDienColumn.LoaiHocPhan)))?null:(System.String)reader[((int)ViewLopDaiDienColumn.LoaiHocPhan)];
			//entity.LoaiHocPhan = (Convert.IsDBNull(reader["LoaiHocPhan"]))?string.Empty:(System.String)reader["LoaiHocPhan"];
			entity.PhanLoai = (reader.IsDBNull(((int)ViewLopDaiDienColumn.PhanLoai)))?null:(System.String)reader[((int)ViewLopDaiDienColumn.PhanLoai)];
			//entity.PhanLoai = (Convert.IsDBNull(reader["PhanLoai"]))?string.Empty:(System.String)reader["PhanLoai"];
			entity.MaMonHoc = (System.String)reader[((int)ViewLopDaiDienColumn.MaMonHoc)];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.TenMonHoc = (System.String)reader[((int)ViewLopDaiDienColumn.TenMonHoc)];
			//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
			entity.MaNhom = (reader.IsDBNull(((int)ViewLopDaiDienColumn.MaNhom)))?null:(System.String)reader[((int)ViewLopDaiDienColumn.MaNhom)];
			//entity.MaNhom = (Convert.IsDBNull(reader["MaNhom"]))?string.Empty:(System.String)reader["MaNhom"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewLopDaiDien"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewLopDaiDien"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewLopDaiDien entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32?)dataRow["MaGiangVien"];
			entity.DonGia = (Convert.IsDBNull(dataRow["DonGia"]))?0.0m:(System.Decimal?)dataRow["DonGia"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.MaLoaiHocPhan = (Convert.IsDBNull(dataRow["MaLoaiHocPhan"]))?(byte)0:(System.Byte)dataRow["MaLoaiHocPhan"];
			entity.LoaiHocPhan = (Convert.IsDBNull(dataRow["LoaiHocPhan"]))?string.Empty:(System.String)dataRow["LoaiHocPhan"];
			entity.PhanLoai = (Convert.IsDBNull(dataRow["PhanLoai"]))?string.Empty:(System.String)dataRow["PhanLoai"];
			entity.MaMonHoc = (Convert.IsDBNull(dataRow["MaMonHoc"]))?string.Empty:(System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = (Convert.IsDBNull(dataRow["TenMonHoc"]))?string.Empty:(System.String)dataRow["TenMonHoc"];
			entity.MaNhom = (Convert.IsDBNull(dataRow["MaNhom"]))?string.Empty:(System.String)dataRow["MaNhom"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewLopDaiDienFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLopDaiDien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLopDaiDienFilterBuilder : SqlFilterBuilder<ViewLopDaiDienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLopDaiDienFilterBuilder class.
		/// </summary>
		public ViewLopDaiDienFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewLopDaiDienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewLopDaiDienFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewLopDaiDienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewLopDaiDienFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewLopDaiDienFilterBuilder

	#region ViewLopDaiDienParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLopDaiDien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLopDaiDienParameterBuilder : ParameterizedSqlFilterBuilder<ViewLopDaiDienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLopDaiDienParameterBuilder class.
		/// </summary>
		public ViewLopDaiDienParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewLopDaiDienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewLopDaiDienParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewLopDaiDienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewLopDaiDienParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewLopDaiDienParameterBuilder
	
	#region ViewLopDaiDienSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLopDaiDien"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewLopDaiDienSortBuilder : SqlSortBuilder<ViewLopDaiDienColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLopDaiDienSqlSortBuilder class.
		/// </summary>
		public ViewLopDaiDienSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewLopDaiDienSortBuilder

} // end namespace
