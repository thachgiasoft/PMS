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
	/// This class is the base class for any <see cref="ViewThanhTraChamGiangTheoKhoaHocProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewThanhTraChamGiangTheoKhoaHocProviderBaseCore : EntityViewProviderBase<ViewThanhTraChamGiangTheoKhoaHoc>
	{
		#region Custom Methods
		
		
		#region cust_View_ThanhTraChamGiangTheoKhoaHoc_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraChamGiangTheoKhoaHoc_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThanhTraChamGiangTheoKhoaHoc&gt;"/> instance.</returns>
		public VList<ViewThanhTraChamGiangTheoKhoaHoc> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraChamGiangTheoKhoaHoc_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThanhTraChamGiangTheoKhoaHoc&gt;"/> instance.</returns>
		public VList<ViewThanhTraChamGiangTheoKhoaHoc> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraChamGiangTheoKhoaHoc_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewThanhTraChamGiangTheoKhoaHoc&gt;"/> instance.</returns>
		public VList<ViewThanhTraChamGiangTheoKhoaHoc> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraChamGiangTheoKhoaHoc_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThanhTraChamGiangTheoKhoaHoc&gt;"/> instance.</returns>
		public abstract VList<ViewThanhTraChamGiangTheoKhoaHoc> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewThanhTraChamGiangTheoKhoaHoc&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewThanhTraChamGiangTheoKhoaHoc&gt;"/></returns>
		protected static VList&lt;ViewThanhTraChamGiangTheoKhoaHoc&gt; Fill(DataSet dataSet, VList<ViewThanhTraChamGiangTheoKhoaHoc> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewThanhTraChamGiangTheoKhoaHoc>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewThanhTraChamGiangTheoKhoaHoc&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewThanhTraChamGiangTheoKhoaHoc>"/></returns>
		protected static VList&lt;ViewThanhTraChamGiangTheoKhoaHoc&gt; Fill(DataTable dataTable, VList<ViewThanhTraChamGiangTheoKhoaHoc> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewThanhTraChamGiangTheoKhoaHoc c = new ViewThanhTraChamGiangTheoKhoaHoc();
					c.MaBacDaoTao = (Convert.IsDBNull(row["MaBacDaoTao"]))?string.Empty:(System.String)row["MaBacDaoTao"];
					c.TenBacDaoTao = (Convert.IsDBNull(row["TenBacDaoTao"]))?string.Empty:(System.String)row["TenBacDaoTao"];
					c.MaLoaiHinhDaoTao = (Convert.IsDBNull(row["MaLoaiHinhDaoTao"]))?string.Empty:(System.String)row["MaLoaiHinhDaoTao"];
					c.TenLoaiHinhDaoTao = (Convert.IsDBNull(row["TenLoaiHinhDaoTao"]))?string.Empty:(System.String)row["TenLoaiHinhDaoTao"];
					c.MaKhoaHoc = (Convert.IsDBNull(row["MaKhoaHoc"]))?string.Empty:(System.String)row["MaKhoaHoc"];
					c.TenKhoaHoc = (Convert.IsDBNull(row["TenKhoaHoc"]))?string.Empty:(System.String)row["TenKhoaHoc"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.Chon = (Convert.IsDBNull(row["Chon"]))?false:(System.Boolean?)row["Chon"];
					c.NgayCapNhat = (Convert.IsDBNull(row["NgayCapNhat"]))?string.Empty:(System.String)row["NgayCapNhat"];
					c.NguoiCapNhat = (Convert.IsDBNull(row["NguoiCapNhat"]))?string.Empty:(System.String)row["NguoiCapNhat"];
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
		/// Fill an <see cref="VList&lt;ViewThanhTraChamGiangTheoKhoaHoc&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewThanhTraChamGiangTheoKhoaHoc&gt;"/></returns>
		protected VList<ViewThanhTraChamGiangTheoKhoaHoc> Fill(IDataReader reader, VList<ViewThanhTraChamGiangTheoKhoaHoc> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewThanhTraChamGiangTheoKhoaHoc entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewThanhTraChamGiangTheoKhoaHoc>("ViewThanhTraChamGiangTheoKhoaHoc",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewThanhTraChamGiangTheoKhoaHoc();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaBacDaoTao = (System.String)reader["MaBacDaoTao"];
					//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
					entity.TenBacDaoTao = (System.String)reader["TenBacDaoTao"];
					//entity.TenBacDaoTao = (Convert.IsDBNull(reader["TenBacDaoTao"]))?string.Empty:(System.String)reader["TenBacDaoTao"];
					entity.MaLoaiHinhDaoTao = (System.String)reader["MaLoaiHinhDaoTao"];
					//entity.MaLoaiHinhDaoTao = (Convert.IsDBNull(reader["MaLoaiHinhDaoTao"]))?string.Empty:(System.String)reader["MaLoaiHinhDaoTao"];
					entity.TenLoaiHinhDaoTao = (System.String)reader["TenLoaiHinhDaoTao"];
					//entity.TenLoaiHinhDaoTao = (Convert.IsDBNull(reader["TenLoaiHinhDaoTao"]))?string.Empty:(System.String)reader["TenLoaiHinhDaoTao"];
					entity.MaKhoaHoc = (System.String)reader["MaKhoaHoc"];
					//entity.MaKhoaHoc = (Convert.IsDBNull(reader["MaKhoaHoc"]))?string.Empty:(System.String)reader["MaKhoaHoc"];
					entity.TenKhoaHoc = (System.String)reader["TenKhoaHoc"];
					//entity.TenKhoaHoc = (Convert.IsDBNull(reader["TenKhoaHoc"]))?string.Empty:(System.String)reader["TenKhoaHoc"];
					entity.NamHoc = (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.Chon = reader.IsDBNull(reader.GetOrdinal("Chon")) ? null : (System.Boolean?)reader["Chon"];
					//entity.Chon = (Convert.IsDBNull(reader["Chon"]))?false:(System.Boolean?)reader["Chon"];
					entity.NgayCapNhat = (System.String)reader["NgayCapNhat"];
					//entity.NgayCapNhat = (Convert.IsDBNull(reader["NgayCapNhat"]))?string.Empty:(System.String)reader["NgayCapNhat"];
					entity.NguoiCapNhat = (System.String)reader["NguoiCapNhat"];
					//entity.NguoiCapNhat = (Convert.IsDBNull(reader["NguoiCapNhat"]))?string.Empty:(System.String)reader["NguoiCapNhat"];
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
		/// Refreshes the <see cref="ViewThanhTraChamGiangTheoKhoaHoc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThanhTraChamGiangTheoKhoaHoc"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewThanhTraChamGiangTheoKhoaHoc entity)
		{
			reader.Read();
			entity.MaBacDaoTao = (System.String)reader["MaBacDaoTao"];
			//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
			entity.TenBacDaoTao = (System.String)reader["TenBacDaoTao"];
			//entity.TenBacDaoTao = (Convert.IsDBNull(reader["TenBacDaoTao"]))?string.Empty:(System.String)reader["TenBacDaoTao"];
			entity.MaLoaiHinhDaoTao = (System.String)reader["MaLoaiHinhDaoTao"];
			//entity.MaLoaiHinhDaoTao = (Convert.IsDBNull(reader["MaLoaiHinhDaoTao"]))?string.Empty:(System.String)reader["MaLoaiHinhDaoTao"];
			entity.TenLoaiHinhDaoTao = (System.String)reader["TenLoaiHinhDaoTao"];
			//entity.TenLoaiHinhDaoTao = (Convert.IsDBNull(reader["TenLoaiHinhDaoTao"]))?string.Empty:(System.String)reader["TenLoaiHinhDaoTao"];
			entity.MaKhoaHoc = (System.String)reader["MaKhoaHoc"];
			//entity.MaKhoaHoc = (Convert.IsDBNull(reader["MaKhoaHoc"]))?string.Empty:(System.String)reader["MaKhoaHoc"];
			entity.TenKhoaHoc = (System.String)reader["TenKhoaHoc"];
			//entity.TenKhoaHoc = (Convert.IsDBNull(reader["TenKhoaHoc"]))?string.Empty:(System.String)reader["TenKhoaHoc"];
			entity.NamHoc = (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.Chon = reader.IsDBNull(reader.GetOrdinal("Chon")) ? null : (System.Boolean?)reader["Chon"];
			//entity.Chon = (Convert.IsDBNull(reader["Chon"]))?false:(System.Boolean?)reader["Chon"];
			entity.NgayCapNhat = (System.String)reader["NgayCapNhat"];
			//entity.NgayCapNhat = (Convert.IsDBNull(reader["NgayCapNhat"]))?string.Empty:(System.String)reader["NgayCapNhat"];
			entity.NguoiCapNhat = (System.String)reader["NguoiCapNhat"];
			//entity.NguoiCapNhat = (Convert.IsDBNull(reader["NguoiCapNhat"]))?string.Empty:(System.String)reader["NguoiCapNhat"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewThanhTraChamGiangTheoKhoaHoc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThanhTraChamGiangTheoKhoaHoc"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewThanhTraChamGiangTheoKhoaHoc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaBacDaoTao = (Convert.IsDBNull(dataRow["MaBacDaoTao"]))?string.Empty:(System.String)dataRow["MaBacDaoTao"];
			entity.TenBacDaoTao = (Convert.IsDBNull(dataRow["TenBacDaoTao"]))?string.Empty:(System.String)dataRow["TenBacDaoTao"];
			entity.MaLoaiHinhDaoTao = (Convert.IsDBNull(dataRow["MaLoaiHinhDaoTao"]))?string.Empty:(System.String)dataRow["MaLoaiHinhDaoTao"];
			entity.TenLoaiHinhDaoTao = (Convert.IsDBNull(dataRow["TenLoaiHinhDaoTao"]))?string.Empty:(System.String)dataRow["TenLoaiHinhDaoTao"];
			entity.MaKhoaHoc = (Convert.IsDBNull(dataRow["MaKhoaHoc"]))?string.Empty:(System.String)dataRow["MaKhoaHoc"];
			entity.TenKhoaHoc = (Convert.IsDBNull(dataRow["TenKhoaHoc"]))?string.Empty:(System.String)dataRow["TenKhoaHoc"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.Chon = (Convert.IsDBNull(dataRow["Chon"]))?false:(System.Boolean?)dataRow["Chon"];
			entity.NgayCapNhat = (Convert.IsDBNull(dataRow["NgayCapNhat"]))?string.Empty:(System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = (Convert.IsDBNull(dataRow["NguoiCapNhat"]))?string.Empty:(System.String)dataRow["NguoiCapNhat"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewThanhTraChamGiangTheoKhoaHocFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThanhTraChamGiangTheoKhoaHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThanhTraChamGiangTheoKhoaHocFilterBuilder : SqlFilterBuilder<ViewThanhTraChamGiangTheoKhoaHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraChamGiangTheoKhoaHocFilterBuilder class.
		/// </summary>
		public ViewThanhTraChamGiangTheoKhoaHocFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraChamGiangTheoKhoaHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThanhTraChamGiangTheoKhoaHocFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraChamGiangTheoKhoaHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThanhTraChamGiangTheoKhoaHocFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThanhTraChamGiangTheoKhoaHocFilterBuilder

	#region ViewThanhTraChamGiangTheoKhoaHocParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThanhTraChamGiangTheoKhoaHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThanhTraChamGiangTheoKhoaHocParameterBuilder : ParameterizedSqlFilterBuilder<ViewThanhTraChamGiangTheoKhoaHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraChamGiangTheoKhoaHocParameterBuilder class.
		/// </summary>
		public ViewThanhTraChamGiangTheoKhoaHocParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraChamGiangTheoKhoaHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThanhTraChamGiangTheoKhoaHocParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraChamGiangTheoKhoaHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThanhTraChamGiangTheoKhoaHocParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThanhTraChamGiangTheoKhoaHocParameterBuilder
	
	#region ViewThanhTraChamGiangTheoKhoaHocSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThanhTraChamGiangTheoKhoaHoc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewThanhTraChamGiangTheoKhoaHocSortBuilder : SqlSortBuilder<ViewThanhTraChamGiangTheoKhoaHocColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraChamGiangTheoKhoaHocSqlSortBuilder class.
		/// </summary>
		public ViewThanhTraChamGiangTheoKhoaHocSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewThanhTraChamGiangTheoKhoaHocSortBuilder

} // end namespace
