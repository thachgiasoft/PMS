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
	/// This class is the base class for any <see cref="ViewGiangVienDonGiaProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewGiangVienDonGiaProviderBaseCore : EntityViewProviderBase<ViewGiangVienDonGia>
	{
		#region Custom Methods
		
		
		#region cust_View_GiangVien_DonGia_GetByMaDonVi
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_DonGia_GetByMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaDonVi(System.String maDonVi)
		{
			 GetByMaDonVi(null, 0, int.MaxValue , maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_DonGia_GetByMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaDonVi(int start, int pageLength, System.String maDonVi)
		{
			 GetByMaDonVi(null, start, pageLength , maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_DonGia_GetByMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaDonVi(TransactionManager transactionManager, System.String maDonVi)
		{
			 GetByMaDonVi(transactionManager, 0, int.MaxValue , maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_DonGia_GetByMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetByMaDonVi(TransactionManager transactionManager, int start, int pageLength, System.String maDonVi);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewGiangVienDonGia&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewGiangVienDonGia&gt;"/></returns>
		protected static VList&lt;ViewGiangVienDonGia&gt; Fill(DataSet dataSet, VList<ViewGiangVienDonGia> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewGiangVienDonGia>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewGiangVienDonGia&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewGiangVienDonGia>"/></returns>
		protected static VList&lt;ViewGiangVienDonGia&gt; Fill(DataTable dataTable, VList<ViewGiangVienDonGia> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewGiangVienDonGia c = new ViewGiangVienDonGia();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32)row["MaGiangVien"];
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.MaDonVi = (Convert.IsDBNull(row["MaDonVi"]))?string.Empty:(System.String)row["MaDonVi"];
					c.DonGia = (Convert.IsDBNull(row["DonGia"]))?0.0m:(System.Decimal?)row["DonGia"];
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
		/// Fill an <see cref="VList&lt;ViewGiangVienDonGia&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewGiangVienDonGia&gt;"/></returns>
		protected VList<ViewGiangVienDonGia> Fill(IDataReader reader, VList<ViewGiangVienDonGia> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewGiangVienDonGia entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewGiangVienDonGia>("ViewGiangVienDonGia",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewGiangVienDonGia();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = (System.Int32)reader[((int)ViewGiangVienDonGiaColumn.MaGiangVien)];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
					entity.MaQuanLy = (System.String)reader[((int)ViewGiangVienDonGiaColumn.MaQuanLy)];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.HoTen = (reader.IsDBNull(((int)ViewGiangVienDonGiaColumn.HoTen)))?null:(System.String)reader[((int)ViewGiangVienDonGiaColumn.HoTen)];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.MaDonVi = (reader.IsDBNull(((int)ViewGiangVienDonGiaColumn.MaDonVi)))?null:(System.String)reader[((int)ViewGiangVienDonGiaColumn.MaDonVi)];
					//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
					entity.DonGia = (reader.IsDBNull(((int)ViewGiangVienDonGiaColumn.DonGia)))?null:(System.Decimal?)reader[((int)ViewGiangVienDonGiaColumn.DonGia)];
					//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal?)reader["DonGia"];
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
		/// Refreshes the <see cref="ViewGiangVienDonGia"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewGiangVienDonGia"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewGiangVienDonGia entity)
		{
			reader.Read();
			entity.MaGiangVien = (System.Int32)reader[((int)ViewGiangVienDonGiaColumn.MaGiangVien)];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
			entity.MaQuanLy = (System.String)reader[((int)ViewGiangVienDonGiaColumn.MaQuanLy)];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.HoTen = (reader.IsDBNull(((int)ViewGiangVienDonGiaColumn.HoTen)))?null:(System.String)reader[((int)ViewGiangVienDonGiaColumn.HoTen)];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.MaDonVi = (reader.IsDBNull(((int)ViewGiangVienDonGiaColumn.MaDonVi)))?null:(System.String)reader[((int)ViewGiangVienDonGiaColumn.MaDonVi)];
			//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
			entity.DonGia = (reader.IsDBNull(((int)ViewGiangVienDonGiaColumn.DonGia)))?null:(System.Decimal?)reader[((int)ViewGiangVienDonGiaColumn.DonGia)];
			//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal?)reader["DonGia"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewGiangVienDonGia"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewGiangVienDonGia"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewGiangVienDonGia entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32)dataRow["MaGiangVien"];
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.MaDonVi = (Convert.IsDBNull(dataRow["MaDonVi"]))?string.Empty:(System.String)dataRow["MaDonVi"];
			entity.DonGia = (Convert.IsDBNull(dataRow["DonGia"]))?0.0m:(System.Decimal?)dataRow["DonGia"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewGiangVienDonGiaFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVienDonGia"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewGiangVienDonGiaFilterBuilder : SqlFilterBuilder<ViewGiangVienDonGiaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienDonGiaFilterBuilder class.
		/// </summary>
		public ViewGiangVienDonGiaFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienDonGiaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewGiangVienDonGiaFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienDonGiaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewGiangVienDonGiaFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewGiangVienDonGiaFilterBuilder

	#region ViewGiangVienDonGiaParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVienDonGia"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewGiangVienDonGiaParameterBuilder : ParameterizedSqlFilterBuilder<ViewGiangVienDonGiaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienDonGiaParameterBuilder class.
		/// </summary>
		public ViewGiangVienDonGiaParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienDonGiaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewGiangVienDonGiaParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienDonGiaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewGiangVienDonGiaParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewGiangVienDonGiaParameterBuilder
	
	#region ViewGiangVienDonGiaSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVienDonGia"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewGiangVienDonGiaSortBuilder : SqlSortBuilder<ViewGiangVienDonGiaColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienDonGiaSqlSortBuilder class.
		/// </summary>
		public ViewGiangVienDonGiaSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewGiangVienDonGiaSortBuilder

} // end namespace
