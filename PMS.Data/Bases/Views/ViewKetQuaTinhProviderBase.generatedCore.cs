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
	/// This class is the base class for any <see cref="ViewKetQuaTinhProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewKetQuaTinhProviderBaseCore : EntityViewProviderBase<ViewKetQuaTinh>
	{
		#region Custom Methods
		
		
		#region cust_View_KetQuaTinh_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaTinh_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKetQuaTinh&gt;"/> instance.</returns>
		public VList<ViewKetQuaTinh> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaTinh_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKetQuaTinh&gt;"/> instance.</returns>
		public VList<ViewKetQuaTinh> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaTinh_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewKetQuaTinh&gt;"/> instance.</returns>
		public VList<ViewKetQuaTinh> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaTinh_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKetQuaTinh&gt;"/> instance.</returns>
		public abstract VList<ViewKetQuaTinh> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#region cust_View_KetQuaTinh_GetByNamHocHocKyMaGiangVien
		
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaTinh_GetByNamHocHocKyMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKetQuaTinh&gt;"/> instance.</returns>
		public VList<ViewKetQuaTinh> GetByNamHocHocKyMaGiangVien(System.String namHoc, System.String hocKy, System.Int32 maGiangVien)
		{
			return GetByNamHocHocKyMaGiangVien(null, 0, int.MaxValue , namHoc, hocKy, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaTinh_GetByNamHocHocKyMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKetQuaTinh&gt;"/> instance.</returns>
		public VList<ViewKetQuaTinh> GetByNamHocHocKyMaGiangVien(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 maGiangVien)
		{
			return GetByNamHocHocKyMaGiangVien(null, start, pageLength , namHoc, hocKy, maGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaTinh_GetByNamHocHocKyMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewKetQuaTinh&gt;"/> instance.</returns>
		public VList<ViewKetQuaTinh> GetByNamHocHocKyMaGiangVien(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 maGiangVien)
		{
			return GetByNamHocHocKyMaGiangVien(transactionManager, 0, int.MaxValue , namHoc, hocKy, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaTinh_GetByNamHocHocKyMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKetQuaTinh&gt;"/> instance.</returns>
		public abstract VList<ViewKetQuaTinh> GetByNamHocHocKyMaGiangVien(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 maGiangVien);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewKetQuaTinh&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewKetQuaTinh&gt;"/></returns>
		protected static VList&lt;ViewKetQuaTinh&gt; Fill(DataSet dataSet, VList<ViewKetQuaTinh> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewKetQuaTinh>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewKetQuaTinh&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewKetQuaTinh>"/></returns>
		protected static VList&lt;ViewKetQuaTinh&gt; Fill(DataTable dataTable, VList<ViewKetQuaTinh> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewKetQuaTinh c = new ViewKetQuaTinh();
					c.MaKetQua = (Convert.IsDBNull(row["MaKetQua"]))?(int)0:(System.Int32)row["MaKetQua"];
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32?)row["MaGiangVien"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.DonGia = (Convert.IsDBNull(row["DonGia"]))?0.0m:(System.Decimal?)row["DonGia"];
					c.TietNghiaVu = (Convert.IsDBNull(row["TietNghiaVu"]))?(int)0:(System.Int32?)row["TietNghiaVu"];
					c.TietGioiHan = (Convert.IsDBNull(row["TietGioiHan"]))?(int)0:(System.Int32?)row["TietGioiHan"];
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
		/// Fill an <see cref="VList&lt;ViewKetQuaTinh&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewKetQuaTinh&gt;"/></returns>
		protected VList<ViewKetQuaTinh> Fill(IDataReader reader, VList<ViewKetQuaTinh> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewKetQuaTinh entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewKetQuaTinh>("ViewKetQuaTinh",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewKetQuaTinh();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaKetQua = (System.Int32)reader["MaKetQua"];
					//entity.MaKetQua = (Convert.IsDBNull(reader["MaKetQua"]))?(int)0:(System.Int32)reader["MaKetQua"];
					entity.MaGiangVien = reader.IsDBNull(reader.GetOrdinal("MaGiangVien")) ? null : (System.Int32?)reader["MaGiangVien"];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32?)reader["MaGiangVien"];
					entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.DonGia = reader.IsDBNull(reader.GetOrdinal("DonGia")) ? null : (System.Decimal?)reader["DonGia"];
					//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal?)reader["DonGia"];
					entity.TietNghiaVu = reader.IsDBNull(reader.GetOrdinal("TietNghiaVu")) ? null : (System.Int32?)reader["TietNghiaVu"];
					//entity.TietNghiaVu = (Convert.IsDBNull(reader["TietNghiaVu"]))?(int)0:(System.Int32?)reader["TietNghiaVu"];
					entity.TietGioiHan = reader.IsDBNull(reader.GetOrdinal("TietGioiHan")) ? null : (System.Int32?)reader["TietGioiHan"];
					//entity.TietGioiHan = (Convert.IsDBNull(reader["TietGioiHan"]))?(int)0:(System.Int32?)reader["TietGioiHan"];
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
		/// Refreshes the <see cref="ViewKetQuaTinh"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewKetQuaTinh"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewKetQuaTinh entity)
		{
			reader.Read();
			entity.MaKetQua = (System.Int32)reader["MaKetQua"];
			//entity.MaKetQua = (Convert.IsDBNull(reader["MaKetQua"]))?(int)0:(System.Int32)reader["MaKetQua"];
			entity.MaGiangVien = reader.IsDBNull(reader.GetOrdinal("MaGiangVien")) ? null : (System.Int32?)reader["MaGiangVien"];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32?)reader["MaGiangVien"];
			entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.DonGia = reader.IsDBNull(reader.GetOrdinal("DonGia")) ? null : (System.Decimal?)reader["DonGia"];
			//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal?)reader["DonGia"];
			entity.TietNghiaVu = reader.IsDBNull(reader.GetOrdinal("TietNghiaVu")) ? null : (System.Int32?)reader["TietNghiaVu"];
			//entity.TietNghiaVu = (Convert.IsDBNull(reader["TietNghiaVu"]))?(int)0:(System.Int32?)reader["TietNghiaVu"];
			entity.TietGioiHan = reader.IsDBNull(reader.GetOrdinal("TietGioiHan")) ? null : (System.Int32?)reader["TietGioiHan"];
			//entity.TietGioiHan = (Convert.IsDBNull(reader["TietGioiHan"]))?(int)0:(System.Int32?)reader["TietGioiHan"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewKetQuaTinh"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewKetQuaTinh"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewKetQuaTinh entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaKetQua = (Convert.IsDBNull(dataRow["MaKetQua"]))?(int)0:(System.Int32)dataRow["MaKetQua"];
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32?)dataRow["MaGiangVien"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.DonGia = (Convert.IsDBNull(dataRow["DonGia"]))?0.0m:(System.Decimal?)dataRow["DonGia"];
			entity.TietNghiaVu = (Convert.IsDBNull(dataRow["TietNghiaVu"]))?(int)0:(System.Int32?)dataRow["TietNghiaVu"];
			entity.TietGioiHan = (Convert.IsDBNull(dataRow["TietGioiHan"]))?(int)0:(System.Int32?)dataRow["TietGioiHan"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewKetQuaTinhFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKetQuaTinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKetQuaTinhFilterBuilder : SqlFilterBuilder<ViewKetQuaTinhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKetQuaTinhFilterBuilder class.
		/// </summary>
		public ViewKetQuaTinhFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewKetQuaTinhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewKetQuaTinhFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewKetQuaTinhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewKetQuaTinhFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewKetQuaTinhFilterBuilder

	#region ViewKetQuaTinhParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKetQuaTinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKetQuaTinhParameterBuilder : ParameterizedSqlFilterBuilder<ViewKetQuaTinhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKetQuaTinhParameterBuilder class.
		/// </summary>
		public ViewKetQuaTinhParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewKetQuaTinhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewKetQuaTinhParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewKetQuaTinhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewKetQuaTinhParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewKetQuaTinhParameterBuilder
	
	#region ViewKetQuaTinhSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKetQuaTinh"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewKetQuaTinhSortBuilder : SqlSortBuilder<ViewKetQuaTinhColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKetQuaTinhSqlSortBuilder class.
		/// </summary>
		public ViewKetQuaTinhSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewKetQuaTinhSortBuilder

} // end namespace
