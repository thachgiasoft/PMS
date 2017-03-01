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
	/// This class is the base class for any <see cref="ViewThongKeHoSoChiTietProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewThongKeHoSoChiTietProviderBaseCore : EntityViewProviderBase<ViewThongKeHoSoChiTiet>
	{
		#region Custom Methods
		
		
		#region cust_View_ThongKe_HoSo_ChiTiet_GetByMaGiangVienQuanLy
		
		/// <summary>
		///	This method wrap the 'cust_View_ThongKe_HoSo_ChiTiet_GetByMaGiangVienQuanLy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVienQuanLy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThongKeHoSoChiTiet&gt;"/> instance.</returns>
		public VList<ViewThongKeHoSoChiTiet> GetByMaGiangVienQuanLy(System.String maGiangVienQuanLy)
		{
			return GetByMaGiangVienQuanLy(null, 0, int.MaxValue , maGiangVienQuanLy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThongKe_HoSo_ChiTiet_GetByMaGiangVienQuanLy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVienQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThongKeHoSoChiTiet&gt;"/> instance.</returns>
		public VList<ViewThongKeHoSoChiTiet> GetByMaGiangVienQuanLy(int start, int pageLength, System.String maGiangVienQuanLy)
		{
			return GetByMaGiangVienQuanLy(null, start, pageLength , maGiangVienQuanLy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ThongKe_HoSo_ChiTiet_GetByMaGiangVienQuanLy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVienQuanLy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewThongKeHoSoChiTiet&gt;"/> instance.</returns>
		public VList<ViewThongKeHoSoChiTiet> GetByMaGiangVienQuanLy(TransactionManager transactionManager, System.String maGiangVienQuanLy)
		{
			return GetByMaGiangVienQuanLy(transactionManager, 0, int.MaxValue , maGiangVienQuanLy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThongKe_HoSo_ChiTiet_GetByMaGiangVienQuanLy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVienQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThongKeHoSoChiTiet&gt;"/> instance.</returns>
		public abstract VList<ViewThongKeHoSoChiTiet> GetByMaGiangVienQuanLy(TransactionManager transactionManager, int start, int pageLength, System.String maGiangVienQuanLy);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewThongKeHoSoChiTiet&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewThongKeHoSoChiTiet&gt;"/></returns>
		protected static VList&lt;ViewThongKeHoSoChiTiet&gt; Fill(DataSet dataSet, VList<ViewThongKeHoSoChiTiet> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewThongKeHoSoChiTiet>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewThongKeHoSoChiTiet&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewThongKeHoSoChiTiet>"/></returns>
		protected static VList&lt;ViewThongKeHoSoChiTiet&gt; Fill(DataTable dataTable, VList<ViewThongKeHoSoChiTiet> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewThongKeHoSoChiTiet c = new ViewThongKeHoSoChiTiet();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32)row["MaGiangVien"];
					c.MaGiangVienQuanLy = (Convert.IsDBNull(row["MaGiangVienQuanLy"]))?string.Empty:(System.String)row["MaGiangVienQuanLy"];
					c.Ho = (Convert.IsDBNull(row["Ho"]))?string.Empty:(System.String)row["Ho"];
					c.Ten = (Convert.IsDBNull(row["Ten"]))?string.Empty:(System.String)row["Ten"];
					c.MaHoSoDaNop = (Convert.IsDBNull(row["MaHoSoDaNop"]))?string.Empty:(System.String)row["MaHoSoDaNop"];
					c.MaHoSoDaNopInt = (Convert.IsDBNull(row["MaHoSoDaNopInt"]))?(int)0:(System.Int32?)row["MaHoSoDaNopInt"];
					c.TenHoSo = (Convert.IsDBNull(row["TenHoSo"]))?string.Empty:(System.String)row["TenHoSo"];
					c.MaHoSoChuaNop = (Convert.IsDBNull(row["MaHoSoChuaNop"]))?string.Empty:(System.String)row["MaHoSoChuaNop"];
					c.MaHoSoChuaNopInt = (Convert.IsDBNull(row["MaHoSoChuaNopInt"]))?(int)0:(System.Int32)row["MaHoSoChuaNopInt"];
					c.SoHoSo = (Convert.IsDBNull(row["SoHoSo"]))?string.Empty:(System.String)row["SoHoSo"];
					c.NgayCap = (Convert.IsDBNull(row["NgayCap"]))?string.Empty:(System.String)row["NgayCap"];
					c.DaNop = (Convert.IsDBNull(row["DaNop"]))?false:(System.Boolean?)row["DaNop"];
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
		/// Fill an <see cref="VList&lt;ViewThongKeHoSoChiTiet&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewThongKeHoSoChiTiet&gt;"/></returns>
		protected VList<ViewThongKeHoSoChiTiet> Fill(IDataReader reader, VList<ViewThongKeHoSoChiTiet> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewThongKeHoSoChiTiet entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewThongKeHoSoChiTiet>("ViewThongKeHoSoChiTiet",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewThongKeHoSoChiTiet();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = (System.Int32)reader["MaGiangVien"];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
					entity.MaGiangVienQuanLy = (System.String)reader["MaGiangVienQuanLy"];
					//entity.MaGiangVienQuanLy = (Convert.IsDBNull(reader["MaGiangVienQuanLy"]))?string.Empty:(System.String)reader["MaGiangVienQuanLy"];
					entity.Ho = (System.String)reader["Ho"];
					//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
					entity.Ten = (System.String)reader["Ten"];
					//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
					entity.MaHoSoDaNop = reader.IsDBNull(reader.GetOrdinal("MaHoSoDaNop")) ? null : (System.String)reader["MaHoSoDaNop"];
					//entity.MaHoSoDaNop = (Convert.IsDBNull(reader["MaHoSoDaNop"]))?string.Empty:(System.String)reader["MaHoSoDaNop"];
					entity.MaHoSoDaNopInt = reader.IsDBNull(reader.GetOrdinal("MaHoSoDaNopInt")) ? null : (System.Int32?)reader["MaHoSoDaNopInt"];
					//entity.MaHoSoDaNopInt = (Convert.IsDBNull(reader["MaHoSoDaNopInt"]))?(int)0:(System.Int32?)reader["MaHoSoDaNopInt"];
					entity.TenHoSo = reader.IsDBNull(reader.GetOrdinal("TenHoSo")) ? null : (System.String)reader["TenHoSo"];
					//entity.TenHoSo = (Convert.IsDBNull(reader["TenHoSo"]))?string.Empty:(System.String)reader["TenHoSo"];
					entity.MaHoSoChuaNop = (System.String)reader["MaHoSoChuaNop"];
					//entity.MaHoSoChuaNop = (Convert.IsDBNull(reader["MaHoSoChuaNop"]))?string.Empty:(System.String)reader["MaHoSoChuaNop"];
					entity.MaHoSoChuaNopInt = (System.Int32)reader["MaHoSoChuaNopInt"];
					//entity.MaHoSoChuaNopInt = (Convert.IsDBNull(reader["MaHoSoChuaNopInt"]))?(int)0:(System.Int32)reader["MaHoSoChuaNopInt"];
					entity.SoHoSo = reader.IsDBNull(reader.GetOrdinal("SoHoSo")) ? null : (System.String)reader["SoHoSo"];
					//entity.SoHoSo = (Convert.IsDBNull(reader["SoHoSo"]))?string.Empty:(System.String)reader["SoHoSo"];
					entity.NgayCap = reader.IsDBNull(reader.GetOrdinal("NgayCap")) ? null : (System.String)reader["NgayCap"];
					//entity.NgayCap = (Convert.IsDBNull(reader["NgayCap"]))?string.Empty:(System.String)reader["NgayCap"];
					entity.DaNop = reader.IsDBNull(reader.GetOrdinal("DaNop")) ? null : (System.Boolean?)reader["DaNop"];
					//entity.DaNop = (Convert.IsDBNull(reader["DaNop"]))?false:(System.Boolean?)reader["DaNop"];
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
		/// Refreshes the <see cref="ViewThongKeHoSoChiTiet"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThongKeHoSoChiTiet"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewThongKeHoSoChiTiet entity)
		{
			reader.Read();
			entity.MaGiangVien = (System.Int32)reader["MaGiangVien"];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
			entity.MaGiangVienQuanLy = (System.String)reader["MaGiangVienQuanLy"];
			//entity.MaGiangVienQuanLy = (Convert.IsDBNull(reader["MaGiangVienQuanLy"]))?string.Empty:(System.String)reader["MaGiangVienQuanLy"];
			entity.Ho = (System.String)reader["Ho"];
			//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
			entity.Ten = (System.String)reader["Ten"];
			//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
			entity.MaHoSoDaNop = reader.IsDBNull(reader.GetOrdinal("MaHoSoDaNop")) ? null : (System.String)reader["MaHoSoDaNop"];
			//entity.MaHoSoDaNop = (Convert.IsDBNull(reader["MaHoSoDaNop"]))?string.Empty:(System.String)reader["MaHoSoDaNop"];
			entity.MaHoSoDaNopInt = reader.IsDBNull(reader.GetOrdinal("MaHoSoDaNopInt")) ? null : (System.Int32?)reader["MaHoSoDaNopInt"];
			//entity.MaHoSoDaNopInt = (Convert.IsDBNull(reader["MaHoSoDaNopInt"]))?(int)0:(System.Int32?)reader["MaHoSoDaNopInt"];
			entity.TenHoSo = reader.IsDBNull(reader.GetOrdinal("TenHoSo")) ? null : (System.String)reader["TenHoSo"];
			//entity.TenHoSo = (Convert.IsDBNull(reader["TenHoSo"]))?string.Empty:(System.String)reader["TenHoSo"];
			entity.MaHoSoChuaNop = (System.String)reader["MaHoSoChuaNop"];
			//entity.MaHoSoChuaNop = (Convert.IsDBNull(reader["MaHoSoChuaNop"]))?string.Empty:(System.String)reader["MaHoSoChuaNop"];
			entity.MaHoSoChuaNopInt = (System.Int32)reader["MaHoSoChuaNopInt"];
			//entity.MaHoSoChuaNopInt = (Convert.IsDBNull(reader["MaHoSoChuaNopInt"]))?(int)0:(System.Int32)reader["MaHoSoChuaNopInt"];
			entity.SoHoSo = reader.IsDBNull(reader.GetOrdinal("SoHoSo")) ? null : (System.String)reader["SoHoSo"];
			//entity.SoHoSo = (Convert.IsDBNull(reader["SoHoSo"]))?string.Empty:(System.String)reader["SoHoSo"];
			entity.NgayCap = reader.IsDBNull(reader.GetOrdinal("NgayCap")) ? null : (System.String)reader["NgayCap"];
			//entity.NgayCap = (Convert.IsDBNull(reader["NgayCap"]))?string.Empty:(System.String)reader["NgayCap"];
			entity.DaNop = reader.IsDBNull(reader.GetOrdinal("DaNop")) ? null : (System.Boolean?)reader["DaNop"];
			//entity.DaNop = (Convert.IsDBNull(reader["DaNop"]))?false:(System.Boolean?)reader["DaNop"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewThongKeHoSoChiTiet"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThongKeHoSoChiTiet"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewThongKeHoSoChiTiet entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32)dataRow["MaGiangVien"];
			entity.MaGiangVienQuanLy = (Convert.IsDBNull(dataRow["MaGiangVienQuanLy"]))?string.Empty:(System.String)dataRow["MaGiangVienQuanLy"];
			entity.Ho = (Convert.IsDBNull(dataRow["Ho"]))?string.Empty:(System.String)dataRow["Ho"];
			entity.Ten = (Convert.IsDBNull(dataRow["Ten"]))?string.Empty:(System.String)dataRow["Ten"];
			entity.MaHoSoDaNop = (Convert.IsDBNull(dataRow["MaHoSoDaNop"]))?string.Empty:(System.String)dataRow["MaHoSoDaNop"];
			entity.MaHoSoDaNopInt = (Convert.IsDBNull(dataRow["MaHoSoDaNopInt"]))?(int)0:(System.Int32?)dataRow["MaHoSoDaNopInt"];
			entity.TenHoSo = (Convert.IsDBNull(dataRow["TenHoSo"]))?string.Empty:(System.String)dataRow["TenHoSo"];
			entity.MaHoSoChuaNop = (Convert.IsDBNull(dataRow["MaHoSoChuaNop"]))?string.Empty:(System.String)dataRow["MaHoSoChuaNop"];
			entity.MaHoSoChuaNopInt = (Convert.IsDBNull(dataRow["MaHoSoChuaNopInt"]))?(int)0:(System.Int32)dataRow["MaHoSoChuaNopInt"];
			entity.SoHoSo = (Convert.IsDBNull(dataRow["SoHoSo"]))?string.Empty:(System.String)dataRow["SoHoSo"];
			entity.NgayCap = (Convert.IsDBNull(dataRow["NgayCap"]))?string.Empty:(System.String)dataRow["NgayCap"];
			entity.DaNop = (Convert.IsDBNull(dataRow["DaNop"]))?false:(System.Boolean?)dataRow["DaNop"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewThongKeHoSoChiTietFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongKeHoSoChiTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThongKeHoSoChiTietFilterBuilder : SqlFilterBuilder<ViewThongKeHoSoChiTietColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongKeHoSoChiTietFilterBuilder class.
		/// </summary>
		public ViewThongKeHoSoChiTietFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThongKeHoSoChiTietFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThongKeHoSoChiTietFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThongKeHoSoChiTietFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThongKeHoSoChiTietFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThongKeHoSoChiTietFilterBuilder

	#region ViewThongKeHoSoChiTietParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongKeHoSoChiTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThongKeHoSoChiTietParameterBuilder : ParameterizedSqlFilterBuilder<ViewThongKeHoSoChiTietColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongKeHoSoChiTietParameterBuilder class.
		/// </summary>
		public ViewThongKeHoSoChiTietParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThongKeHoSoChiTietParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThongKeHoSoChiTietParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThongKeHoSoChiTietParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThongKeHoSoChiTietParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThongKeHoSoChiTietParameterBuilder
	
	#region ViewThongKeHoSoChiTietSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongKeHoSoChiTiet"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewThongKeHoSoChiTietSortBuilder : SqlSortBuilder<ViewThongKeHoSoChiTietColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongKeHoSoChiTietSqlSortBuilder class.
		/// </summary>
		public ViewThongKeHoSoChiTietSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewThongKeHoSoChiTietSortBuilder

} // end namespace
