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
	/// This class is the base class for any <see cref="ViewXyLyQuyDoiProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewXyLyQuyDoiProviderBaseCore : EntityViewProviderBase<ViewXyLyQuyDoi>
	{
		#region Custom Methods
		
		
		#region cust_View_XyLy_QuyDoi_GetByMaKetQua
		
		/// <summary>
		///	This method wrap the 'cust_View_XyLy_QuyDoi_GetByMaKetQua' stored procedure. 
		/// </summary>
		/// <param name="maKetQua"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewXyLyQuyDoi&gt;"/> instance.</returns>
		public VList<ViewXyLyQuyDoi> GetByMaKetQua(System.Int32 maKetQua)
		{
			return GetByMaKetQua(null, 0, int.MaxValue , maKetQua);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_XyLy_QuyDoi_GetByMaKetQua' stored procedure. 
		/// </summary>
		/// <param name="maKetQua"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewXyLyQuyDoi&gt;"/> instance.</returns>
		public VList<ViewXyLyQuyDoi> GetByMaKetQua(int start, int pageLength, System.Int32 maKetQua)
		{
			return GetByMaKetQua(null, start, pageLength , maKetQua);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_XyLy_QuyDoi_GetByMaKetQua' stored procedure. 
		/// </summary>
		/// <param name="maKetQua"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewXyLyQuyDoi&gt;"/> instance.</returns>
		public VList<ViewXyLyQuyDoi> GetByMaKetQua(TransactionManager transactionManager, System.Int32 maKetQua)
		{
			return GetByMaKetQua(transactionManager, 0, int.MaxValue , maKetQua);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_XyLy_QuyDoi_GetByMaKetQua' stored procedure. 
		/// </summary>
		/// <param name="maKetQua"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewXyLyQuyDoi&gt;"/> instance.</returns>
		public abstract VList<ViewXyLyQuyDoi> GetByMaKetQua(TransactionManager transactionManager, int start, int pageLength, System.Int32 maKetQua);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewXyLyQuyDoi&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewXyLyQuyDoi&gt;"/></returns>
		protected static VList&lt;ViewXyLyQuyDoi&gt; Fill(DataSet dataSet, VList<ViewXyLyQuyDoi> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewXyLyQuyDoi>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewXyLyQuyDoi&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewXyLyQuyDoi>"/></returns>
		protected static VList&lt;ViewXyLyQuyDoi&gt; Fill(DataTable dataTable, VList<ViewXyLyQuyDoi> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewXyLyQuyDoi c = new ViewXyLyQuyDoi();
					c.MaKhoiLuong = (Convert.IsDBNull(row["MaKhoiLuong"]))?(int)0:(System.Int32)row["MaKhoiLuong"];
					c.MaKetQua = (Convert.IsDBNull(row["MaKetQua"]))?(int)0:(System.Int32?)row["MaKetQua"];
					c.MaLopHocPhan = (Convert.IsDBNull(row["MaLopHocPhan"]))?string.Empty:(System.String)row["MaLopHocPhan"];
					c.LoaiHocPhan = (Convert.IsDBNull(row["LoaiHocPhan"]))?string.Empty:(System.String)row["LoaiHocPhan"];
					c.SoTiet = (Convert.IsDBNull(row["SoTiet"]))?0.0m:(System.Decimal?)row["SoTiet"];
					c.SoTinChi = (Convert.IsDBNull(row["SoTinChi"]))?0.0m:(System.Decimal?)row["SoTinChi"];
					c.SiSoLop = (Convert.IsDBNull(row["SiSoLop"]))?(int)0:(System.Int32?)row["SiSoLop"];
					c.ChatLuongCao = (Convert.IsDBNull(row["ChatLuongCao"]))?0.0m:(System.Decimal)row["ChatLuongCao"];
					c.NgoaiGio = (Convert.IsDBNull(row["NgoaiGio"]))?0.0m:(System.Decimal?)row["NgoaiGio"];
					c.TrongGio = (Convert.IsDBNull(row["TrongGio"]))?0.0m:(System.Decimal?)row["TrongGio"];
					c.HeSoLopDong = (Convert.IsDBNull(row["HeSoLopDong"]))?0.0m:(System.Decimal)row["HeSoLopDong"];
					c.HeSoCoSo = (Convert.IsDBNull(row["HeSoCoSo"]))?0.0m:(System.Decimal)row["HeSoCoSo"];
					c.HeSoHocKy = (Convert.IsDBNull(row["HeSoHocKy"]))?0.0m:(System.Decimal)row["HeSoHocKy"];
					c.HeSoThanhPhan = (Convert.IsDBNull(row["HeSoThanhPhan"]))?0.0m:(System.Decimal)row["HeSoThanhPhan"];
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
		/// Fill an <see cref="VList&lt;ViewXyLyQuyDoi&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewXyLyQuyDoi&gt;"/></returns>
		protected VList<ViewXyLyQuyDoi> Fill(IDataReader reader, VList<ViewXyLyQuyDoi> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewXyLyQuyDoi entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewXyLyQuyDoi>("ViewXyLyQuyDoi",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewXyLyQuyDoi();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaKhoiLuong = (System.Int32)reader[((int)ViewXyLyQuyDoiColumn.MaKhoiLuong)];
					//entity.MaKhoiLuong = (Convert.IsDBNull(reader["MaKhoiLuong"]))?(int)0:(System.Int32)reader["MaKhoiLuong"];
					entity.MaKetQua = (reader.IsDBNull(((int)ViewXyLyQuyDoiColumn.MaKetQua)))?null:(System.Int32?)reader[((int)ViewXyLyQuyDoiColumn.MaKetQua)];
					//entity.MaKetQua = (Convert.IsDBNull(reader["MaKetQua"]))?(int)0:(System.Int32?)reader["MaKetQua"];
					entity.MaLopHocPhan = (reader.IsDBNull(((int)ViewXyLyQuyDoiColumn.MaLopHocPhan)))?null:(System.String)reader[((int)ViewXyLyQuyDoiColumn.MaLopHocPhan)];
					//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
					entity.LoaiHocPhan = (reader.IsDBNull(((int)ViewXyLyQuyDoiColumn.LoaiHocPhan)))?null:(System.String)reader[((int)ViewXyLyQuyDoiColumn.LoaiHocPhan)];
					//entity.LoaiHocPhan = (Convert.IsDBNull(reader["LoaiHocPhan"]))?string.Empty:(System.String)reader["LoaiHocPhan"];
					entity.SoTiet = (reader.IsDBNull(((int)ViewXyLyQuyDoiColumn.SoTiet)))?null:(System.Decimal?)reader[((int)ViewXyLyQuyDoiColumn.SoTiet)];
					//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?0.0m:(System.Decimal?)reader["SoTiet"];
					entity.SoTinChi = (reader.IsDBNull(((int)ViewXyLyQuyDoiColumn.SoTinChi)))?null:(System.Decimal?)reader[((int)ViewXyLyQuyDoiColumn.SoTinChi)];
					//entity.SoTinChi = (Convert.IsDBNull(reader["SoTinChi"]))?0.0m:(System.Decimal?)reader["SoTinChi"];
					entity.SiSoLop = (reader.IsDBNull(((int)ViewXyLyQuyDoiColumn.SiSoLop)))?null:(System.Int32?)reader[((int)ViewXyLyQuyDoiColumn.SiSoLop)];
					//entity.SiSoLop = (Convert.IsDBNull(reader["SiSoLop"]))?(int)0:(System.Int32?)reader["SiSoLop"];
					entity.ChatLuongCao = (System.Decimal)reader[((int)ViewXyLyQuyDoiColumn.ChatLuongCao)];
					//entity.ChatLuongCao = (Convert.IsDBNull(reader["ChatLuongCao"]))?0.0m:(System.Decimal)reader["ChatLuongCao"];
					entity.NgoaiGio = (reader.IsDBNull(((int)ViewXyLyQuyDoiColumn.NgoaiGio)))?null:(System.Decimal?)reader[((int)ViewXyLyQuyDoiColumn.NgoaiGio)];
					//entity.NgoaiGio = (Convert.IsDBNull(reader["NgoaiGio"]))?0.0m:(System.Decimal?)reader["NgoaiGio"];
					entity.TrongGio = (reader.IsDBNull(((int)ViewXyLyQuyDoiColumn.TrongGio)))?null:(System.Decimal?)reader[((int)ViewXyLyQuyDoiColumn.TrongGio)];
					//entity.TrongGio = (Convert.IsDBNull(reader["TrongGio"]))?0.0m:(System.Decimal?)reader["TrongGio"];
					entity.HeSoLopDong = (System.Decimal)reader[((int)ViewXyLyQuyDoiColumn.HeSoLopDong)];
					//entity.HeSoLopDong = (Convert.IsDBNull(reader["HeSoLopDong"]))?0.0m:(System.Decimal)reader["HeSoLopDong"];
					entity.HeSoCoSo = (System.Decimal)reader[((int)ViewXyLyQuyDoiColumn.HeSoCoSo)];
					//entity.HeSoCoSo = (Convert.IsDBNull(reader["HeSoCoSo"]))?0.0m:(System.Decimal)reader["HeSoCoSo"];
					entity.HeSoHocKy = (System.Decimal)reader[((int)ViewXyLyQuyDoiColumn.HeSoHocKy)];
					//entity.HeSoHocKy = (Convert.IsDBNull(reader["HeSoHocKy"]))?0.0m:(System.Decimal)reader["HeSoHocKy"];
					entity.HeSoThanhPhan = (System.Decimal)reader[((int)ViewXyLyQuyDoiColumn.HeSoThanhPhan)];
					//entity.HeSoThanhPhan = (Convert.IsDBNull(reader["HeSoThanhPhan"]))?0.0m:(System.Decimal)reader["HeSoThanhPhan"];
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
		/// Refreshes the <see cref="ViewXyLyQuyDoi"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewXyLyQuyDoi"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewXyLyQuyDoi entity)
		{
			reader.Read();
			entity.MaKhoiLuong = (System.Int32)reader[((int)ViewXyLyQuyDoiColumn.MaKhoiLuong)];
			//entity.MaKhoiLuong = (Convert.IsDBNull(reader["MaKhoiLuong"]))?(int)0:(System.Int32)reader["MaKhoiLuong"];
			entity.MaKetQua = (reader.IsDBNull(((int)ViewXyLyQuyDoiColumn.MaKetQua)))?null:(System.Int32?)reader[((int)ViewXyLyQuyDoiColumn.MaKetQua)];
			//entity.MaKetQua = (Convert.IsDBNull(reader["MaKetQua"]))?(int)0:(System.Int32?)reader["MaKetQua"];
			entity.MaLopHocPhan = (reader.IsDBNull(((int)ViewXyLyQuyDoiColumn.MaLopHocPhan)))?null:(System.String)reader[((int)ViewXyLyQuyDoiColumn.MaLopHocPhan)];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			entity.LoaiHocPhan = (reader.IsDBNull(((int)ViewXyLyQuyDoiColumn.LoaiHocPhan)))?null:(System.String)reader[((int)ViewXyLyQuyDoiColumn.LoaiHocPhan)];
			//entity.LoaiHocPhan = (Convert.IsDBNull(reader["LoaiHocPhan"]))?string.Empty:(System.String)reader["LoaiHocPhan"];
			entity.SoTiet = (reader.IsDBNull(((int)ViewXyLyQuyDoiColumn.SoTiet)))?null:(System.Decimal?)reader[((int)ViewXyLyQuyDoiColumn.SoTiet)];
			//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?0.0m:(System.Decimal?)reader["SoTiet"];
			entity.SoTinChi = (reader.IsDBNull(((int)ViewXyLyQuyDoiColumn.SoTinChi)))?null:(System.Decimal?)reader[((int)ViewXyLyQuyDoiColumn.SoTinChi)];
			//entity.SoTinChi = (Convert.IsDBNull(reader["SoTinChi"]))?0.0m:(System.Decimal?)reader["SoTinChi"];
			entity.SiSoLop = (reader.IsDBNull(((int)ViewXyLyQuyDoiColumn.SiSoLop)))?null:(System.Int32?)reader[((int)ViewXyLyQuyDoiColumn.SiSoLop)];
			//entity.SiSoLop = (Convert.IsDBNull(reader["SiSoLop"]))?(int)0:(System.Int32?)reader["SiSoLop"];
			entity.ChatLuongCao = (System.Decimal)reader[((int)ViewXyLyQuyDoiColumn.ChatLuongCao)];
			//entity.ChatLuongCao = (Convert.IsDBNull(reader["ChatLuongCao"]))?0.0m:(System.Decimal)reader["ChatLuongCao"];
			entity.NgoaiGio = (reader.IsDBNull(((int)ViewXyLyQuyDoiColumn.NgoaiGio)))?null:(System.Decimal?)reader[((int)ViewXyLyQuyDoiColumn.NgoaiGio)];
			//entity.NgoaiGio = (Convert.IsDBNull(reader["NgoaiGio"]))?0.0m:(System.Decimal?)reader["NgoaiGio"];
			entity.TrongGio = (reader.IsDBNull(((int)ViewXyLyQuyDoiColumn.TrongGio)))?null:(System.Decimal?)reader[((int)ViewXyLyQuyDoiColumn.TrongGio)];
			//entity.TrongGio = (Convert.IsDBNull(reader["TrongGio"]))?0.0m:(System.Decimal?)reader["TrongGio"];
			entity.HeSoLopDong = (System.Decimal)reader[((int)ViewXyLyQuyDoiColumn.HeSoLopDong)];
			//entity.HeSoLopDong = (Convert.IsDBNull(reader["HeSoLopDong"]))?0.0m:(System.Decimal)reader["HeSoLopDong"];
			entity.HeSoCoSo = (System.Decimal)reader[((int)ViewXyLyQuyDoiColumn.HeSoCoSo)];
			//entity.HeSoCoSo = (Convert.IsDBNull(reader["HeSoCoSo"]))?0.0m:(System.Decimal)reader["HeSoCoSo"];
			entity.HeSoHocKy = (System.Decimal)reader[((int)ViewXyLyQuyDoiColumn.HeSoHocKy)];
			//entity.HeSoHocKy = (Convert.IsDBNull(reader["HeSoHocKy"]))?0.0m:(System.Decimal)reader["HeSoHocKy"];
			entity.HeSoThanhPhan = (System.Decimal)reader[((int)ViewXyLyQuyDoiColumn.HeSoThanhPhan)];
			//entity.HeSoThanhPhan = (Convert.IsDBNull(reader["HeSoThanhPhan"]))?0.0m:(System.Decimal)reader["HeSoThanhPhan"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewXyLyQuyDoi"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewXyLyQuyDoi"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewXyLyQuyDoi entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaKhoiLuong = (Convert.IsDBNull(dataRow["MaKhoiLuong"]))?(int)0:(System.Int32)dataRow["MaKhoiLuong"];
			entity.MaKetQua = (Convert.IsDBNull(dataRow["MaKetQua"]))?(int)0:(System.Int32?)dataRow["MaKetQua"];
			entity.MaLopHocPhan = (Convert.IsDBNull(dataRow["MaLopHocPhan"]))?string.Empty:(System.String)dataRow["MaLopHocPhan"];
			entity.LoaiHocPhan = (Convert.IsDBNull(dataRow["LoaiHocPhan"]))?string.Empty:(System.String)dataRow["LoaiHocPhan"];
			entity.SoTiet = (Convert.IsDBNull(dataRow["SoTiet"]))?0.0m:(System.Decimal?)dataRow["SoTiet"];
			entity.SoTinChi = (Convert.IsDBNull(dataRow["SoTinChi"]))?0.0m:(System.Decimal?)dataRow["SoTinChi"];
			entity.SiSoLop = (Convert.IsDBNull(dataRow["SiSoLop"]))?(int)0:(System.Int32?)dataRow["SiSoLop"];
			entity.ChatLuongCao = (Convert.IsDBNull(dataRow["ChatLuongCao"]))?0.0m:(System.Decimal)dataRow["ChatLuongCao"];
			entity.NgoaiGio = (Convert.IsDBNull(dataRow["NgoaiGio"]))?0.0m:(System.Decimal?)dataRow["NgoaiGio"];
			entity.TrongGio = (Convert.IsDBNull(dataRow["TrongGio"]))?0.0m:(System.Decimal?)dataRow["TrongGio"];
			entity.HeSoLopDong = (Convert.IsDBNull(dataRow["HeSoLopDong"]))?0.0m:(System.Decimal)dataRow["HeSoLopDong"];
			entity.HeSoCoSo = (Convert.IsDBNull(dataRow["HeSoCoSo"]))?0.0m:(System.Decimal)dataRow["HeSoCoSo"];
			entity.HeSoHocKy = (Convert.IsDBNull(dataRow["HeSoHocKy"]))?0.0m:(System.Decimal)dataRow["HeSoHocKy"];
			entity.HeSoThanhPhan = (Convert.IsDBNull(dataRow["HeSoThanhPhan"]))?0.0m:(System.Decimal)dataRow["HeSoThanhPhan"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewXyLyQuyDoiFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewXyLyQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewXyLyQuyDoiFilterBuilder : SqlFilterBuilder<ViewXyLyQuyDoiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewXyLyQuyDoiFilterBuilder class.
		/// </summary>
		public ViewXyLyQuyDoiFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewXyLyQuyDoiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewXyLyQuyDoiFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewXyLyQuyDoiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewXyLyQuyDoiFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewXyLyQuyDoiFilterBuilder

	#region ViewXyLyQuyDoiParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewXyLyQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewXyLyQuyDoiParameterBuilder : ParameterizedSqlFilterBuilder<ViewXyLyQuyDoiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewXyLyQuyDoiParameterBuilder class.
		/// </summary>
		public ViewXyLyQuyDoiParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewXyLyQuyDoiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewXyLyQuyDoiParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewXyLyQuyDoiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewXyLyQuyDoiParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewXyLyQuyDoiParameterBuilder
	
	#region ViewXyLyQuyDoiSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewXyLyQuyDoi"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewXyLyQuyDoiSortBuilder : SqlSortBuilder<ViewXyLyQuyDoiColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewXyLyQuyDoiSqlSortBuilder class.
		/// </summary>
		public ViewXyLyQuyDoiSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewXyLyQuyDoiSortBuilder

} // end namespace
