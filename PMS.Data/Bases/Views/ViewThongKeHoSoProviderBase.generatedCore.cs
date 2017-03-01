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
	/// This class is the base class for any <see cref="ViewThongKeHoSoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewThongKeHoSoProviderBaseCore : EntityViewProviderBase<ViewThongKeHoSo>
	{
		#region Custom Methods
		
		
		#region cust_View_ThongKe_HoSo_GetByNopDu
		
		/// <summary>
		///	This method wrap the 'cust_View_ThongKe_HoSo_GetByNopDu' stored procedure. 
		/// </summary>
		/// <param name="maTuyChon"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThongKeHoSo&gt;"/> instance.</returns>
		public VList<ViewThongKeHoSo> GetByNopDu(System.String maTuyChon)
		{
			return GetByNopDu(null, 0, int.MaxValue , maTuyChon);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThongKe_HoSo_GetByNopDu' stored procedure. 
		/// </summary>
		/// <param name="maTuyChon"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThongKeHoSo&gt;"/> instance.</returns>
		public VList<ViewThongKeHoSo> GetByNopDu(int start, int pageLength, System.String maTuyChon)
		{
			return GetByNopDu(null, start, pageLength , maTuyChon);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ThongKe_HoSo_GetByNopDu' stored procedure. 
		/// </summary>
		/// <param name="maTuyChon"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewThongKeHoSo&gt;"/> instance.</returns>
		public VList<ViewThongKeHoSo> GetByNopDu(TransactionManager transactionManager, System.String maTuyChon)
		{
			return GetByNopDu(transactionManager, 0, int.MaxValue , maTuyChon);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThongKe_HoSo_GetByNopDu' stored procedure. 
		/// </summary>
		/// <param name="maTuyChon"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThongKeHoSo&gt;"/> instance.</returns>
		public abstract VList<ViewThongKeHoSo> GetByNopDu(TransactionManager transactionManager, int start, int pageLength, System.String maTuyChon);
		
		#endregion

		
		#region cust_View_ThongKe_HoSo_ChiTiet_GetByMaGiangVienQuanLy
		
		/// <summary>
		///	This method wrap the 'cust_View_ThongKe_HoSo_ChiTiet_GetByMaGiangVienQuanLy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVienQuanLy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ChiTiet_GetByMaGiangVienQuanLy(System.String maGiangVienQuanLy)
		{
			return ChiTiet_GetByMaGiangVienQuanLy(null, 0, int.MaxValue , maGiangVienQuanLy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThongKe_HoSo_ChiTiet_GetByMaGiangVienQuanLy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVienQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ChiTiet_GetByMaGiangVienQuanLy(int start, int pageLength, System.String maGiangVienQuanLy)
		{
			return ChiTiet_GetByMaGiangVienQuanLy(null, start, pageLength , maGiangVienQuanLy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ThongKe_HoSo_ChiTiet_GetByMaGiangVienQuanLy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVienQuanLy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ChiTiet_GetByMaGiangVienQuanLy(TransactionManager transactionManager, System.String maGiangVienQuanLy)
		{
			return ChiTiet_GetByMaGiangVienQuanLy(transactionManager, 0, int.MaxValue , maGiangVienQuanLy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThongKe_HoSo_ChiTiet_GetByMaGiangVienQuanLy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVienQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ChiTiet_GetByMaGiangVienQuanLy(TransactionManager transactionManager, int start, int pageLength, System.String maGiangVienQuanLy);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewThongKeHoSo&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewThongKeHoSo&gt;"/></returns>
		protected static VList&lt;ViewThongKeHoSo&gt; Fill(DataSet dataSet, VList<ViewThongKeHoSo> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewThongKeHoSo>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewThongKeHoSo&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewThongKeHoSo>"/></returns>
		protected static VList&lt;ViewThongKeHoSo&gt; Fill(DataTable dataTable, VList<ViewThongKeHoSo> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewThongKeHoSo c = new ViewThongKeHoSo();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32)row["MaGiangVien"];
					c.MaGiangVienQuanLy = (Convert.IsDBNull(row["MaGiangVienQuanLy"]))?string.Empty:(System.String)row["MaGiangVienQuanLy"];
					c.Ho = (Convert.IsDBNull(row["Ho"]))?string.Empty:(System.String)row["Ho"];
					c.Ten = (Convert.IsDBNull(row["Ten"]))?string.Empty:(System.String)row["Ten"];
					c.MaHoSoDaNop = (Convert.IsDBNull(row["MaHoSoDaNop"]))?string.Empty:(System.String)row["MaHoSoDaNop"];
					c.MaHoSoChuaNop = (Convert.IsDBNull(row["MaHoSoChuaNop"]))?string.Empty:(System.String)row["MaHoSoChuaNop"];
					c.MaTongHoSo = (Convert.IsDBNull(row["MaTongHoSo"]))?string.Empty:(System.String)row["MaTongHoSo"];
					c.NopDu = (Convert.IsDBNull(row["NopDu"]))?false:(System.Boolean?)row["NopDu"];
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
		/// Fill an <see cref="VList&lt;ViewThongKeHoSo&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewThongKeHoSo&gt;"/></returns>
		protected VList<ViewThongKeHoSo> Fill(IDataReader reader, VList<ViewThongKeHoSo> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewThongKeHoSo entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewThongKeHoSo>("ViewThongKeHoSo",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewThongKeHoSo();
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
					entity.MaHoSoChuaNop = reader.IsDBNull(reader.GetOrdinal("MaHoSoChuaNop")) ? null : (System.String)reader["MaHoSoChuaNop"];
					//entity.MaHoSoChuaNop = (Convert.IsDBNull(reader["MaHoSoChuaNop"]))?string.Empty:(System.String)reader["MaHoSoChuaNop"];
					entity.MaTongHoSo = reader.IsDBNull(reader.GetOrdinal("MaTongHoSo")) ? null : (System.String)reader["MaTongHoSo"];
					//entity.MaTongHoSo = (Convert.IsDBNull(reader["MaTongHoSo"]))?string.Empty:(System.String)reader["MaTongHoSo"];
					entity.NopDu = reader.IsDBNull(reader.GetOrdinal("NopDu")) ? null : (System.Boolean?)reader["NopDu"];
					//entity.NopDu = (Convert.IsDBNull(reader["NopDu"]))?false:(System.Boolean?)reader["NopDu"];
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
		/// Refreshes the <see cref="ViewThongKeHoSo"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThongKeHoSo"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewThongKeHoSo entity)
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
			entity.MaHoSoChuaNop = reader.IsDBNull(reader.GetOrdinal("MaHoSoChuaNop")) ? null : (System.String)reader["MaHoSoChuaNop"];
			//entity.MaHoSoChuaNop = (Convert.IsDBNull(reader["MaHoSoChuaNop"]))?string.Empty:(System.String)reader["MaHoSoChuaNop"];
			entity.MaTongHoSo = reader.IsDBNull(reader.GetOrdinal("MaTongHoSo")) ? null : (System.String)reader["MaTongHoSo"];
			//entity.MaTongHoSo = (Convert.IsDBNull(reader["MaTongHoSo"]))?string.Empty:(System.String)reader["MaTongHoSo"];
			entity.NopDu = reader.IsDBNull(reader.GetOrdinal("NopDu")) ? null : (System.Boolean?)reader["NopDu"];
			//entity.NopDu = (Convert.IsDBNull(reader["NopDu"]))?false:(System.Boolean?)reader["NopDu"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewThongKeHoSo"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThongKeHoSo"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewThongKeHoSo entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32)dataRow["MaGiangVien"];
			entity.MaGiangVienQuanLy = (Convert.IsDBNull(dataRow["MaGiangVienQuanLy"]))?string.Empty:(System.String)dataRow["MaGiangVienQuanLy"];
			entity.Ho = (Convert.IsDBNull(dataRow["Ho"]))?string.Empty:(System.String)dataRow["Ho"];
			entity.Ten = (Convert.IsDBNull(dataRow["Ten"]))?string.Empty:(System.String)dataRow["Ten"];
			entity.MaHoSoDaNop = (Convert.IsDBNull(dataRow["MaHoSoDaNop"]))?string.Empty:(System.String)dataRow["MaHoSoDaNop"];
			entity.MaHoSoChuaNop = (Convert.IsDBNull(dataRow["MaHoSoChuaNop"]))?string.Empty:(System.String)dataRow["MaHoSoChuaNop"];
			entity.MaTongHoSo = (Convert.IsDBNull(dataRow["MaTongHoSo"]))?string.Empty:(System.String)dataRow["MaTongHoSo"];
			entity.NopDu = (Convert.IsDBNull(dataRow["NopDu"]))?false:(System.Boolean?)dataRow["NopDu"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewThongKeHoSoFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongKeHoSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThongKeHoSoFilterBuilder : SqlFilterBuilder<ViewThongKeHoSoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongKeHoSoFilterBuilder class.
		/// </summary>
		public ViewThongKeHoSoFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThongKeHoSoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThongKeHoSoFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThongKeHoSoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThongKeHoSoFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThongKeHoSoFilterBuilder

	#region ViewThongKeHoSoParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongKeHoSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThongKeHoSoParameterBuilder : ParameterizedSqlFilterBuilder<ViewThongKeHoSoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongKeHoSoParameterBuilder class.
		/// </summary>
		public ViewThongKeHoSoParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThongKeHoSoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThongKeHoSoParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThongKeHoSoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThongKeHoSoParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThongKeHoSoParameterBuilder
	
	#region ViewThongKeHoSoSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongKeHoSo"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewThongKeHoSoSortBuilder : SqlSortBuilder<ViewThongKeHoSoColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongKeHoSoSqlSortBuilder class.
		/// </summary>
		public ViewThongKeHoSoSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewThongKeHoSoSortBuilder

} // end namespace
