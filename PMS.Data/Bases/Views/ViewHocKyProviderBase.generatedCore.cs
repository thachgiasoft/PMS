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
	/// This class is the base class for any <see cref="ViewHocKyProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewHocKyProviderBaseCore : EntityViewProviderBase<ViewHocKy>
	{
		#region Custom Methods
		
		
		#region cust_View_HocKy_GetHocKySau
		
		/// <summary>
		///	This method wrap the 'cust_View_HocKy_GetHocKySau' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="namHocSau"> A <c>System.String</c> instance.</param>
			/// <param name="hocKySau"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetHocKySau(System.String namHoc, System.String hocKy, ref System.String namHocSau, ref System.String hocKySau)
		{
			 GetHocKySau(null, 0, int.MaxValue , namHoc, hocKy, ref namHocSau, ref hocKySau);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_HocKy_GetHocKySau' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="namHocSau"> A <c>System.String</c> instance.</param>
			/// <param name="hocKySau"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetHocKySau(int start, int pageLength, System.String namHoc, System.String hocKy, ref System.String namHocSau, ref System.String hocKySau)
		{
			 GetHocKySau(null, start, pageLength , namHoc, hocKy, ref namHocSau, ref hocKySau);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_HocKy_GetHocKySau' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="namHocSau"> A <c>System.String</c> instance.</param>
			/// <param name="hocKySau"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetHocKySau(TransactionManager transactionManager, System.String namHoc, System.String hocKy, ref System.String namHocSau, ref System.String hocKySau)
		{
			 GetHocKySau(transactionManager, 0, int.MaxValue , namHoc, hocKy, ref namHocSau, ref hocKySau);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_HocKy_GetHocKySau' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="namHocSau"> A <c>System.String</c> instance.</param>
			/// <param name="hocKySau"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetHocKySau(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, ref System.String namHocSau, ref System.String hocKySau);
		
		#endregion

		
		#region cust_View_HocKy_GetByNamHoc
		
		/// <summary>
		///	This method wrap the 'cust_View_HocKy_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewHocKy&gt;"/> instance.</returns>
		public VList<ViewHocKy> GetByNamHoc(System.String namHoc)
		{
			return GetByNamHoc(null, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_HocKy_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewHocKy&gt;"/> instance.</returns>
		public VList<ViewHocKy> GetByNamHoc(int start, int pageLength, System.String namHoc)
		{
			return GetByNamHoc(null, start, pageLength , namHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_HocKy_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewHocKy&gt;"/> instance.</returns>
		public VList<ViewHocKy> GetByNamHoc(TransactionManager transactionManager, System.String namHoc)
		{
			return GetByNamHoc(transactionManager, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_HocKy_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewHocKy&gt;"/> instance.</returns>
		public abstract VList<ViewHocKy> GetByNamHoc(TransactionManager transactionManager, int start, int pageLength, System.String namHoc);
		
		#endregion

		
		#region cust_View_HocKy_GetHocKyTruoc
		
		/// <summary>
		///	This method wrap the 'cust_View_HocKy_GetHocKyTruoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="namHocTruoc"> A <c>System.String</c> instance.</param>
			/// <param name="hocKyTruoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetHocKyTruoc(System.String namHoc, System.String hocKy, ref System.String namHocTruoc, ref System.String hocKyTruoc)
		{
			 GetHocKyTruoc(null, 0, int.MaxValue , namHoc, hocKy, ref namHocTruoc, ref hocKyTruoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_HocKy_GetHocKyTruoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="namHocTruoc"> A <c>System.String</c> instance.</param>
			/// <param name="hocKyTruoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetHocKyTruoc(int start, int pageLength, System.String namHoc, System.String hocKy, ref System.String namHocTruoc, ref System.String hocKyTruoc)
		{
			 GetHocKyTruoc(null, start, pageLength , namHoc, hocKy, ref namHocTruoc, ref hocKyTruoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_HocKy_GetHocKyTruoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="namHocTruoc"> A <c>System.String</c> instance.</param>
			/// <param name="hocKyTruoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetHocKyTruoc(TransactionManager transactionManager, System.String namHoc, System.String hocKy, ref System.String namHocTruoc, ref System.String hocKyTruoc)
		{
			 GetHocKyTruoc(transactionManager, 0, int.MaxValue , namHoc, hocKy, ref namHocTruoc, ref hocKyTruoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_HocKy_GetHocKyTruoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="namHocTruoc"> A <c>System.String</c> instance.</param>
			/// <param name="hocKyTruoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetHocKyTruoc(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, ref System.String namHocTruoc, ref System.String hocKyTruoc);
		
		#endregion

		
		#region cust_View_HocKy_GetNgayBatDauKetThuc
		
		/// <summary>
		///	This method wrap the 'cust_View_HocKy_GetNgayBatDauKetThuc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="ngayBatDau"> A <c>System.DateTime</c> instance.</param>
			/// <param name="ngayKetThuc"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetNgayBatDauKetThuc(System.String namHoc, System.String hocKy, ref System.DateTime ngayBatDau, ref System.DateTime ngayKetThuc)
		{
			 GetNgayBatDauKetThuc(null, 0, int.MaxValue , namHoc, hocKy, ref ngayBatDau, ref ngayKetThuc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_HocKy_GetNgayBatDauKetThuc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="ngayBatDau"> A <c>System.DateTime</c> instance.</param>
			/// <param name="ngayKetThuc"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetNgayBatDauKetThuc(int start, int pageLength, System.String namHoc, System.String hocKy, ref System.DateTime ngayBatDau, ref System.DateTime ngayKetThuc)
		{
			 GetNgayBatDauKetThuc(null, start, pageLength , namHoc, hocKy, ref ngayBatDau, ref ngayKetThuc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_HocKy_GetNgayBatDauKetThuc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="ngayBatDau"> A <c>System.DateTime</c> instance.</param>
			/// <param name="ngayKetThuc"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetNgayBatDauKetThuc(TransactionManager transactionManager, System.String namHoc, System.String hocKy, ref System.DateTime ngayBatDau, ref System.DateTime ngayKetThuc)
		{
			 GetNgayBatDauKetThuc(transactionManager, 0, int.MaxValue , namHoc, hocKy, ref ngayBatDau, ref ngayKetThuc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_HocKy_GetNgayBatDauKetThuc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="ngayBatDau"> A <c>System.DateTime</c> instance.</param>
			/// <param name="ngayKetThuc"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetNgayBatDauKetThuc(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, ref System.DateTime ngayBatDau, ref System.DateTime ngayKetThuc);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewHocKy&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewHocKy&gt;"/></returns>
		protected static VList&lt;ViewHocKy&gt; Fill(DataSet dataSet, VList<ViewHocKy> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewHocKy>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewHocKy&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewHocKy>"/></returns>
		protected static VList&lt;ViewHocKy&gt; Fill(DataTable dataTable, VList<ViewHocKy> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewHocKy c = new ViewHocKy();
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.MaHocKy = (Convert.IsDBNull(row["MaHocKy"]))?string.Empty:(System.String)row["MaHocKy"];
					c.TenHocKy = (Convert.IsDBNull(row["TenHocKy"]))?string.Empty:(System.String)row["TenHocKy"];
					c.LoaiHocKy = (Convert.IsDBNull(row["LoaiHocKy"]))?(byte)0:(System.Byte?)row["LoaiHocKy"];
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
		/// Fill an <see cref="VList&lt;ViewHocKy&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewHocKy&gt;"/></returns>
		protected VList<ViewHocKy> Fill(IDataReader reader, VList<ViewHocKy> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewHocKy entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewHocKy>("ViewHocKy",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewHocKy();
					}
					
					entity.SuppressEntityEvents = true;

					entity.NamHoc = (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.MaHocKy = (System.String)reader["MaHocKy"];
					//entity.MaHocKy = (Convert.IsDBNull(reader["MaHocKy"]))?string.Empty:(System.String)reader["MaHocKy"];
					entity.TenHocKy = reader.IsDBNull(reader.GetOrdinal("TenHocKy")) ? null : (System.String)reader["TenHocKy"];
					//entity.TenHocKy = (Convert.IsDBNull(reader["TenHocKy"]))?string.Empty:(System.String)reader["TenHocKy"];
					entity.LoaiHocKy = reader.IsDBNull(reader.GetOrdinal("LoaiHocKy")) ? null : (System.Byte?)reader["LoaiHocKy"];
					//entity.LoaiHocKy = (Convert.IsDBNull(reader["LoaiHocKy"]))?(byte)0:(System.Byte?)reader["LoaiHocKy"];
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
		/// Refreshes the <see cref="ViewHocKy"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewHocKy"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewHocKy entity)
		{
			reader.Read();
			entity.NamHoc = (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.MaHocKy = (System.String)reader["MaHocKy"];
			//entity.MaHocKy = (Convert.IsDBNull(reader["MaHocKy"]))?string.Empty:(System.String)reader["MaHocKy"];
			entity.TenHocKy = reader.IsDBNull(reader.GetOrdinal("TenHocKy")) ? null : (System.String)reader["TenHocKy"];
			//entity.TenHocKy = (Convert.IsDBNull(reader["TenHocKy"]))?string.Empty:(System.String)reader["TenHocKy"];
			entity.LoaiHocKy = reader.IsDBNull(reader.GetOrdinal("LoaiHocKy")) ? null : (System.Byte?)reader["LoaiHocKy"];
			//entity.LoaiHocKy = (Convert.IsDBNull(reader["LoaiHocKy"]))?(byte)0:(System.Byte?)reader["LoaiHocKy"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewHocKy"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewHocKy"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewHocKy entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.MaHocKy = (Convert.IsDBNull(dataRow["MaHocKy"]))?string.Empty:(System.String)dataRow["MaHocKy"];
			entity.TenHocKy = (Convert.IsDBNull(dataRow["TenHocKy"]))?string.Empty:(System.String)dataRow["TenHocKy"];
			entity.LoaiHocKy = (Convert.IsDBNull(dataRow["LoaiHocKy"]))?(byte)0:(System.Byte?)dataRow["LoaiHocKy"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewHocKyFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHocKy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHocKyFilterBuilder : SqlFilterBuilder<ViewHocKyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHocKyFilterBuilder class.
		/// </summary>
		public ViewHocKyFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewHocKyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewHocKyFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewHocKyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewHocKyFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewHocKyFilterBuilder

	#region ViewHocKyParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHocKy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHocKyParameterBuilder : ParameterizedSqlFilterBuilder<ViewHocKyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHocKyParameterBuilder class.
		/// </summary>
		public ViewHocKyParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewHocKyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewHocKyParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewHocKyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewHocKyParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewHocKyParameterBuilder
	
	#region ViewHocKySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHocKy"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewHocKySortBuilder : SqlSortBuilder<ViewHocKyColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHocKySqlSortBuilder class.
		/// </summary>
		public ViewHocKySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewHocKySortBuilder

} // end namespace
