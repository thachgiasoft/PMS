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
	/// This class is the base class for any <see cref="ViewQuyetDinhDoiHocHamHocViProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewQuyetDinhDoiHocHamHocViProviderBaseCore : EntityViewProviderBase<ViewQuyetDinhDoiHocHamHocVi>
	{
		#region Custom Methods
		
		
		#region cust_view_QuyetDinhDoiHocHamHocVi_GetByMaGiangVien
		
		/// <summary>
		///	This method wrap the 'cust_view_QuyetDinhDoiHocHamHocVi_GetByMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewQuyetDinhDoiHocHamHocVi&gt;"/> instance.</returns>
		public VList<ViewQuyetDinhDoiHocHamHocVi> GetByMaGiangVien(System.Int32 maGiangVien)
		{
			return GetByMaGiangVien(null, 0, int.MaxValue , maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_view_QuyetDinhDoiHocHamHocVi_GetByMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewQuyetDinhDoiHocHamHocVi&gt;"/> instance.</returns>
		public VList<ViewQuyetDinhDoiHocHamHocVi> GetByMaGiangVien(int start, int pageLength, System.Int32 maGiangVien)
		{
			return GetByMaGiangVien(null, start, pageLength , maGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_view_QuyetDinhDoiHocHamHocVi_GetByMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewQuyetDinhDoiHocHamHocVi&gt;"/> instance.</returns>
		public VList<ViewQuyetDinhDoiHocHamHocVi> GetByMaGiangVien(TransactionManager transactionManager, System.Int32 maGiangVien)
		{
			return GetByMaGiangVien(transactionManager, 0, int.MaxValue , maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_view_QuyetDinhDoiHocHamHocVi_GetByMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewQuyetDinhDoiHocHamHocVi&gt;"/> instance.</returns>
		public abstract VList<ViewQuyetDinhDoiHocHamHocVi> GetByMaGiangVien(TransactionManager transactionManager, int start, int pageLength, System.Int32 maGiangVien);
		
		#endregion

		
		#region cust_view_QuyetDinhDoiHocHamHocVi_DeleteByMaGiangVienNgayHieuLucLoaiQuyetDinh
		
		/// <summary>
		///	This method wrap the 'cust_view_QuyetDinhDoiHocHamHocVi_DeleteByMaGiangVienNgayHieuLucLoaiQuyetDinh' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayHieuLuc"> A <c>System.DateTime</c> instance.</param>
		/// <param name="loaiQuyetDinh"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteByMaGiangVienNgayHieuLucLoaiQuyetDinh(System.Int32 maGiangVien, System.DateTime ngayHieuLuc, System.String loaiQuyetDinh)
		{
			 DeleteByMaGiangVienNgayHieuLucLoaiQuyetDinh(null, 0, int.MaxValue , maGiangVien, ngayHieuLuc, loaiQuyetDinh);
		}
		
		/// <summary>
		///	This method wrap the 'cust_view_QuyetDinhDoiHocHamHocVi_DeleteByMaGiangVienNgayHieuLucLoaiQuyetDinh' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayHieuLuc"> A <c>System.DateTime</c> instance.</param>
		/// <param name="loaiQuyetDinh"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteByMaGiangVienNgayHieuLucLoaiQuyetDinh(int start, int pageLength, System.Int32 maGiangVien, System.DateTime ngayHieuLuc, System.String loaiQuyetDinh)
		{
			 DeleteByMaGiangVienNgayHieuLucLoaiQuyetDinh(null, start, pageLength , maGiangVien, ngayHieuLuc, loaiQuyetDinh);
		}
				
		/// <summary>
		///	This method wrap the 'cust_view_QuyetDinhDoiHocHamHocVi_DeleteByMaGiangVienNgayHieuLucLoaiQuyetDinh' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayHieuLuc"> A <c>System.DateTime</c> instance.</param>
		/// <param name="loaiQuyetDinh"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteByMaGiangVienNgayHieuLucLoaiQuyetDinh(TransactionManager transactionManager, System.Int32 maGiangVien, System.DateTime ngayHieuLuc, System.String loaiQuyetDinh)
		{
			 DeleteByMaGiangVienNgayHieuLucLoaiQuyetDinh(transactionManager, 0, int.MaxValue , maGiangVien, ngayHieuLuc, loaiQuyetDinh);
		}
		
		/// <summary>
		///	This method wrap the 'cust_view_QuyetDinhDoiHocHamHocVi_DeleteByMaGiangVienNgayHieuLucLoaiQuyetDinh' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayHieuLuc"> A <c>System.DateTime</c> instance.</param>
		/// <param name="loaiQuyetDinh"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DeleteByMaGiangVienNgayHieuLucLoaiQuyetDinh(TransactionManager transactionManager, int start, int pageLength, System.Int32 maGiangVien, System.DateTime ngayHieuLuc, System.String loaiQuyetDinh);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewQuyetDinhDoiHocHamHocVi&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewQuyetDinhDoiHocHamHocVi&gt;"/></returns>
		protected static VList&lt;ViewQuyetDinhDoiHocHamHocVi&gt; Fill(DataSet dataSet, VList<ViewQuyetDinhDoiHocHamHocVi> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewQuyetDinhDoiHocHamHocVi>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewQuyetDinhDoiHocHamHocVi&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewQuyetDinhDoiHocHamHocVi>"/></returns>
		protected static VList&lt;ViewQuyetDinhDoiHocHamHocVi&gt; Fill(DataTable dataTable, VList<ViewQuyetDinhDoiHocHamHocVi> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewQuyetDinhDoiHocHamHocVi c = new ViewQuyetDinhDoiHocHamHocVi();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32?)row["MaGiangVien"];
					c.MaCu = (Convert.IsDBNull(row["MaCu"]))?(int)0:(System.Int32?)row["MaCu"];
					c.MaMoi = (Convert.IsDBNull(row["MaMoi"]))?(int)0:(System.Int32?)row["MaMoi"];
					c.TenCu = (Convert.IsDBNull(row["TenCu"]))?string.Empty:(System.String)row["TenCu"];
					c.TenMoi = (Convert.IsDBNull(row["TenMoi"]))?string.Empty:(System.String)row["TenMoi"];
					c.NgayHieuLuc = (Convert.IsDBNull(row["NgayHieuLuc"]))?DateTime.MinValue:(System.DateTime?)row["NgayHieuLuc"];
					c.LoaiQuyetDinh = (Convert.IsDBNull(row["LoaiQuyetDinh"]))?string.Empty:(System.String)row["LoaiQuyetDinh"];
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
		/// Fill an <see cref="VList&lt;ViewQuyetDinhDoiHocHamHocVi&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewQuyetDinhDoiHocHamHocVi&gt;"/></returns>
		protected VList<ViewQuyetDinhDoiHocHamHocVi> Fill(IDataReader reader, VList<ViewQuyetDinhDoiHocHamHocVi> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewQuyetDinhDoiHocHamHocVi entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewQuyetDinhDoiHocHamHocVi>("ViewQuyetDinhDoiHocHamHocVi",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewQuyetDinhDoiHocHamHocVi();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = reader.IsDBNull(reader.GetOrdinal("MaGiangVien")) ? null : (System.Int32?)reader["MaGiangVien"];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32?)reader["MaGiangVien"];
					entity.MaCu = reader.IsDBNull(reader.GetOrdinal("MaCu")) ? null : (System.Int32?)reader["MaCu"];
					//entity.MaCu = (Convert.IsDBNull(reader["MaCu"]))?(int)0:(System.Int32?)reader["MaCu"];
					entity.MaMoi = reader.IsDBNull(reader.GetOrdinal("MaMoi")) ? null : (System.Int32?)reader["MaMoi"];
					//entity.MaMoi = (Convert.IsDBNull(reader["MaMoi"]))?(int)0:(System.Int32?)reader["MaMoi"];
					entity.TenCu = reader.IsDBNull(reader.GetOrdinal("TenCu")) ? null : (System.String)reader["TenCu"];
					//entity.TenCu = (Convert.IsDBNull(reader["TenCu"]))?string.Empty:(System.String)reader["TenCu"];
					entity.TenMoi = reader.IsDBNull(reader.GetOrdinal("TenMoi")) ? null : (System.String)reader["TenMoi"];
					//entity.TenMoi = (Convert.IsDBNull(reader["TenMoi"]))?string.Empty:(System.String)reader["TenMoi"];
					entity.NgayHieuLuc = reader.IsDBNull(reader.GetOrdinal("NgayHieuLuc")) ? null : (System.DateTime?)reader["NgayHieuLuc"];
					//entity.NgayHieuLuc = (Convert.IsDBNull(reader["NgayHieuLuc"]))?DateTime.MinValue:(System.DateTime?)reader["NgayHieuLuc"];
					entity.LoaiQuyetDinh = (System.String)reader["LoaiQuyetDinh"];
					//entity.LoaiQuyetDinh = (Convert.IsDBNull(reader["LoaiQuyetDinh"]))?string.Empty:(System.String)reader["LoaiQuyetDinh"];
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
		/// Refreshes the <see cref="ViewQuyetDinhDoiHocHamHocVi"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewQuyetDinhDoiHocHamHocVi"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewQuyetDinhDoiHocHamHocVi entity)
		{
			reader.Read();
			entity.MaGiangVien = reader.IsDBNull(reader.GetOrdinal("MaGiangVien")) ? null : (System.Int32?)reader["MaGiangVien"];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32?)reader["MaGiangVien"];
			entity.MaCu = reader.IsDBNull(reader.GetOrdinal("MaCu")) ? null : (System.Int32?)reader["MaCu"];
			//entity.MaCu = (Convert.IsDBNull(reader["MaCu"]))?(int)0:(System.Int32?)reader["MaCu"];
			entity.MaMoi = reader.IsDBNull(reader.GetOrdinal("MaMoi")) ? null : (System.Int32?)reader["MaMoi"];
			//entity.MaMoi = (Convert.IsDBNull(reader["MaMoi"]))?(int)0:(System.Int32?)reader["MaMoi"];
			entity.TenCu = reader.IsDBNull(reader.GetOrdinal("TenCu")) ? null : (System.String)reader["TenCu"];
			//entity.TenCu = (Convert.IsDBNull(reader["TenCu"]))?string.Empty:(System.String)reader["TenCu"];
			entity.TenMoi = reader.IsDBNull(reader.GetOrdinal("TenMoi")) ? null : (System.String)reader["TenMoi"];
			//entity.TenMoi = (Convert.IsDBNull(reader["TenMoi"]))?string.Empty:(System.String)reader["TenMoi"];
			entity.NgayHieuLuc = reader.IsDBNull(reader.GetOrdinal("NgayHieuLuc")) ? null : (System.DateTime?)reader["NgayHieuLuc"];
			//entity.NgayHieuLuc = (Convert.IsDBNull(reader["NgayHieuLuc"]))?DateTime.MinValue:(System.DateTime?)reader["NgayHieuLuc"];
			entity.LoaiQuyetDinh = (System.String)reader["LoaiQuyetDinh"];
			//entity.LoaiQuyetDinh = (Convert.IsDBNull(reader["LoaiQuyetDinh"]))?string.Empty:(System.String)reader["LoaiQuyetDinh"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewQuyetDinhDoiHocHamHocVi"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewQuyetDinhDoiHocHamHocVi"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewQuyetDinhDoiHocHamHocVi entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32?)dataRow["MaGiangVien"];
			entity.MaCu = (Convert.IsDBNull(dataRow["MaCu"]))?(int)0:(System.Int32?)dataRow["MaCu"];
			entity.MaMoi = (Convert.IsDBNull(dataRow["MaMoi"]))?(int)0:(System.Int32?)dataRow["MaMoi"];
			entity.TenCu = (Convert.IsDBNull(dataRow["TenCu"]))?string.Empty:(System.String)dataRow["TenCu"];
			entity.TenMoi = (Convert.IsDBNull(dataRow["TenMoi"]))?string.Empty:(System.String)dataRow["TenMoi"];
			entity.NgayHieuLuc = (Convert.IsDBNull(dataRow["NgayHieuLuc"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayHieuLuc"];
			entity.LoaiQuyetDinh = (Convert.IsDBNull(dataRow["LoaiQuyetDinh"]))?string.Empty:(System.String)dataRow["LoaiQuyetDinh"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewQuyetDinhDoiHocHamHocViFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewQuyetDinhDoiHocHamHocVi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewQuyetDinhDoiHocHamHocViFilterBuilder : SqlFilterBuilder<ViewQuyetDinhDoiHocHamHocViColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewQuyetDinhDoiHocHamHocViFilterBuilder class.
		/// </summary>
		public ViewQuyetDinhDoiHocHamHocViFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewQuyetDinhDoiHocHamHocViFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewQuyetDinhDoiHocHamHocViFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewQuyetDinhDoiHocHamHocViFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewQuyetDinhDoiHocHamHocViFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewQuyetDinhDoiHocHamHocViFilterBuilder

	#region ViewQuyetDinhDoiHocHamHocViParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewQuyetDinhDoiHocHamHocVi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewQuyetDinhDoiHocHamHocViParameterBuilder : ParameterizedSqlFilterBuilder<ViewQuyetDinhDoiHocHamHocViColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewQuyetDinhDoiHocHamHocViParameterBuilder class.
		/// </summary>
		public ViewQuyetDinhDoiHocHamHocViParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewQuyetDinhDoiHocHamHocViParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewQuyetDinhDoiHocHamHocViParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewQuyetDinhDoiHocHamHocViParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewQuyetDinhDoiHocHamHocViParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewQuyetDinhDoiHocHamHocViParameterBuilder
	
	#region ViewQuyetDinhDoiHocHamHocViSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewQuyetDinhDoiHocHamHocVi"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewQuyetDinhDoiHocHamHocViSortBuilder : SqlSortBuilder<ViewQuyetDinhDoiHocHamHocViColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewQuyetDinhDoiHocHamHocViSqlSortBuilder class.
		/// </summary>
		public ViewQuyetDinhDoiHocHamHocViSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewQuyetDinhDoiHocHamHocViSortBuilder

} // end namespace
