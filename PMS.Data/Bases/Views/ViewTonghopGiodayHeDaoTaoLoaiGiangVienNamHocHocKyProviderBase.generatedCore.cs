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
	/// This class is the base class for any <see cref="ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyProviderBaseCore : EntityViewProviderBase<ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy>
	{
		#region Custom Methods
		
		
		#region cust_View_Tonghop_Gioday_HeDaoTao_LoaiGiangVien_NamHoc_HocKy_GetByMaDonViMaHeDaoTaoNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_Tonghop_Gioday_HeDaoTao_LoaiGiangVien_NamHoc_HocKy_GetByMaDonViMaHeDaoTaoNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.Int32</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy&gt;"/> instance.</returns>
		public VList<ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy> GetByMaDonViMaHeDaoTaoNamHocHocKy(System.String namHoc, System.String hocKy, System.Int32 maHeDaoTao, System.String maDonVi)
		{
			return GetByMaDonViMaHeDaoTaoNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy, maHeDaoTao, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Tonghop_Gioday_HeDaoTao_LoaiGiangVien_NamHoc_HocKy_GetByMaDonViMaHeDaoTaoNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.Int32</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy&gt;"/> instance.</returns>
		public VList<ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy> GetByMaDonViMaHeDaoTaoNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 maHeDaoTao, System.String maDonVi)
		{
			return GetByMaDonViMaHeDaoTaoNamHocHocKy(null, start, pageLength , namHoc, hocKy, maHeDaoTao, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_Tonghop_Gioday_HeDaoTao_LoaiGiangVien_NamHoc_HocKy_GetByMaDonViMaHeDaoTaoNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.Int32</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy&gt;"/> instance.</returns>
		public VList<ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy> GetByMaDonViMaHeDaoTaoNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 maHeDaoTao, System.String maDonVi)
		{
			return GetByMaDonViMaHeDaoTaoNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy, maHeDaoTao, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Tonghop_Gioday_HeDaoTao_LoaiGiangVien_NamHoc_HocKy_GetByMaDonViMaHeDaoTaoNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.Int32</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy&gt;"/> instance.</returns>
		public abstract VList<ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy> GetByMaDonViMaHeDaoTaoNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 maHeDaoTao, System.String maDonVi);
		
		#endregion

		
		#region cust_View_Tonghop_Gioday_HeDaoTao_LoaiGiangVien_NamHoc_HocKy_GetByLoaiGiangVienHeNHHK
		
		/// <summary>
		///	This method wrap the 'cust_View_Tonghop_Gioday_HeDaoTao_LoaiGiangVien_NamHoc_HocKy_GetByLoaiGiangVienHeNHHK' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy&gt;"/> instance.</returns>
		public VList<ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy> GetByLoaiGiangVienHeNHHK(System.String namHoc, System.String hocKy, System.Int32 maLoaiGiangVien, System.String maHeDaoTao)
		{
			return GetByLoaiGiangVienHeNHHK(null, 0, int.MaxValue , namHoc, hocKy, maLoaiGiangVien, maHeDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Tonghop_Gioday_HeDaoTao_LoaiGiangVien_NamHoc_HocKy_GetByLoaiGiangVienHeNHHK' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy&gt;"/> instance.</returns>
		public VList<ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy> GetByLoaiGiangVienHeNHHK(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 maLoaiGiangVien, System.String maHeDaoTao)
		{
			return GetByLoaiGiangVienHeNHHK(null, start, pageLength , namHoc, hocKy, maLoaiGiangVien, maHeDaoTao);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_Tonghop_Gioday_HeDaoTao_LoaiGiangVien_NamHoc_HocKy_GetByLoaiGiangVienHeNHHK' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy&gt;"/> instance.</returns>
		public VList<ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy> GetByLoaiGiangVienHeNHHK(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 maLoaiGiangVien, System.String maHeDaoTao)
		{
			return GetByLoaiGiangVienHeNHHK(transactionManager, 0, int.MaxValue , namHoc, hocKy, maLoaiGiangVien, maHeDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Tonghop_Gioday_HeDaoTao_LoaiGiangVien_NamHoc_HocKy_GetByLoaiGiangVienHeNHHK' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy&gt;"/> instance.</returns>
		public abstract VList<ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy> GetByLoaiGiangVienHeNHHK(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 maLoaiGiangVien, System.String maHeDaoTao);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy&gt;"/></returns>
		protected static VList&lt;ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy&gt; Fill(DataSet dataSet, VList<ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy>"/></returns>
		protected static VList&lt;ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy&gt; Fill(DataTable dataTable, VList<ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy c = new ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy();
					c.MaDonVi = (Convert.IsDBNull(row["MaDonVi"]))?string.Empty:(System.String)row["MaDonVi"];
					c.TenDonVi = (Convert.IsDBNull(row["TenDonVi"]))?string.Empty:(System.String)row["TenDonVi"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.MaLoaiGiangVien = (Convert.IsDBNull(row["MaLoaiGiangVien"]))?(int)0:(System.Int32?)row["MaLoaiGiangVien"];
					c.MaHeDaoTao = (Convert.IsDBNull(row["MaHeDaoTao"]))?string.Empty:(System.String)row["MaHeDaoTao"];
					c.TietThucDay = (Convert.IsDBNull(row["TietThucDay"]))?0.0m:(System.Decimal?)row["TietThucDay"];
					c.TietQuyDoi = (Convert.IsDBNull(row["TietQuyDoi"]))?0.0m:(System.Decimal?)row["TietQuyDoi"];
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
		/// Fill an <see cref="VList&lt;ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy&gt;"/></returns>
		protected VList<ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy> Fill(IDataReader reader, VList<ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy>("ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaDonVi = reader.IsDBNull(reader.GetOrdinal("MaDonVi")) ? null : (System.String)reader["MaDonVi"];
					//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
					entity.TenDonVi = reader.IsDBNull(reader.GetOrdinal("TenDonVi")) ? null : (System.String)reader["TenDonVi"];
					//entity.TenDonVi = (Convert.IsDBNull(reader["TenDonVi"]))?string.Empty:(System.String)reader["TenDonVi"];
					entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.MaLoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("MaLoaiGiangVien")) ? null : (System.Int32?)reader["MaLoaiGiangVien"];
					//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32?)reader["MaLoaiGiangVien"];
					entity.MaHeDaoTao = (System.String)reader["MaHeDaoTao"];
					//entity.MaHeDaoTao = (Convert.IsDBNull(reader["MaHeDaoTao"]))?string.Empty:(System.String)reader["MaHeDaoTao"];
					entity.TietThucDay = reader.IsDBNull(reader.GetOrdinal("TietThucDay")) ? null : (System.Decimal?)reader["TietThucDay"];
					//entity.TietThucDay = (Convert.IsDBNull(reader["TietThucDay"]))?0.0m:(System.Decimal?)reader["TietThucDay"];
					entity.TietQuyDoi = reader.IsDBNull(reader.GetOrdinal("TietQuyDoi")) ? null : (System.Decimal?)reader["TietQuyDoi"];
					//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal?)reader["TietQuyDoi"];
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
		/// Refreshes the <see cref="ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy entity)
		{
			reader.Read();
			entity.MaDonVi = reader.IsDBNull(reader.GetOrdinal("MaDonVi")) ? null : (System.String)reader["MaDonVi"];
			//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
			entity.TenDonVi = reader.IsDBNull(reader.GetOrdinal("TenDonVi")) ? null : (System.String)reader["TenDonVi"];
			//entity.TenDonVi = (Convert.IsDBNull(reader["TenDonVi"]))?string.Empty:(System.String)reader["TenDonVi"];
			entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.MaLoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("MaLoaiGiangVien")) ? null : (System.Int32?)reader["MaLoaiGiangVien"];
			//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32?)reader["MaLoaiGiangVien"];
			entity.MaHeDaoTao = (System.String)reader["MaHeDaoTao"];
			//entity.MaHeDaoTao = (Convert.IsDBNull(reader["MaHeDaoTao"]))?string.Empty:(System.String)reader["MaHeDaoTao"];
			entity.TietThucDay = reader.IsDBNull(reader.GetOrdinal("TietThucDay")) ? null : (System.Decimal?)reader["TietThucDay"];
			//entity.TietThucDay = (Convert.IsDBNull(reader["TietThucDay"]))?0.0m:(System.Decimal?)reader["TietThucDay"];
			entity.TietQuyDoi = reader.IsDBNull(reader.GetOrdinal("TietQuyDoi")) ? null : (System.Decimal?)reader["TietQuyDoi"];
			//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal?)reader["TietQuyDoi"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaDonVi = (Convert.IsDBNull(dataRow["MaDonVi"]))?string.Empty:(System.String)dataRow["MaDonVi"];
			entity.TenDonVi = (Convert.IsDBNull(dataRow["TenDonVi"]))?string.Empty:(System.String)dataRow["TenDonVi"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.MaLoaiGiangVien = (Convert.IsDBNull(dataRow["MaLoaiGiangVien"]))?(int)0:(System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.MaHeDaoTao = (Convert.IsDBNull(dataRow["MaHeDaoTao"]))?string.Empty:(System.String)dataRow["MaHeDaoTao"];
			entity.TietThucDay = (Convert.IsDBNull(dataRow["TietThucDay"]))?0.0m:(System.Decimal?)dataRow["TietThucDay"];
			entity.TietQuyDoi = (Convert.IsDBNull(dataRow["TietQuyDoi"]))?0.0m:(System.Decimal?)dataRow["TietQuyDoi"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyFilterBuilder : SqlFilterBuilder<ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyFilterBuilder class.
		/// </summary>
		public ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyFilterBuilder

	#region ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyParameterBuilder : ParameterizedSqlFilterBuilder<ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyParameterBuilder class.
		/// </summary>
		public ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyParameterBuilder
	
	#region ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKySortBuilder : SqlSortBuilder<ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKySqlSortBuilder class.
		/// </summary>
		public ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKySortBuilder

} // end namespace
