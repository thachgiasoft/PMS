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
	/// This class is the base class for any <see cref="ViewDanhSachLopPhanCongGiangDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewDanhSachLopPhanCongGiangDayProviderBaseCore : EntityViewProviderBase<ViewDanhSachLopPhanCongGiangDay>
	{
		#region Custom Methods
		
		
		#region cust_View_DanhSachLopPhanCongGiangDay_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_DanhSachLopPhanCongGiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewDanhSachLopPhanCongGiangDay&gt;"/> instance.</returns>
		public VList<ViewDanhSachLopPhanCongGiangDay> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_DanhSachLopPhanCongGiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewDanhSachLopPhanCongGiangDay&gt;"/> instance.</returns>
		public VList<ViewDanhSachLopPhanCongGiangDay> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_DanhSachLopPhanCongGiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewDanhSachLopPhanCongGiangDay&gt;"/> instance.</returns>
		public VList<ViewDanhSachLopPhanCongGiangDay> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_DanhSachLopPhanCongGiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewDanhSachLopPhanCongGiangDay&gt;"/> instance.</returns>
		public abstract VList<ViewDanhSachLopPhanCongGiangDay> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#region cust_View_DanhSachLopPhanCongGiangDay_GetByNamHocHocKyMaGiangVien
		
		/// <summary>
		///	This method wrap the 'cust_View_DanhSachLopPhanCongGiangDay_GetByNamHocHocKyMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewDanhSachLopPhanCongGiangDay&gt;"/> instance.</returns>
		public VList<ViewDanhSachLopPhanCongGiangDay> GetByNamHocHocKyMaGiangVien(System.String namHoc, System.String hocKy, System.String maGiangVien)
		{
			return GetByNamHocHocKyMaGiangVien(null, 0, int.MaxValue , namHoc, hocKy, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_DanhSachLopPhanCongGiangDay_GetByNamHocHocKyMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewDanhSachLopPhanCongGiangDay&gt;"/> instance.</returns>
		public VList<ViewDanhSachLopPhanCongGiangDay> GetByNamHocHocKyMaGiangVien(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maGiangVien)
		{
			return GetByNamHocHocKyMaGiangVien(null, start, pageLength , namHoc, hocKy, maGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_DanhSachLopPhanCongGiangDay_GetByNamHocHocKyMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewDanhSachLopPhanCongGiangDay&gt;"/> instance.</returns>
		public VList<ViewDanhSachLopPhanCongGiangDay> GetByNamHocHocKyMaGiangVien(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maGiangVien)
		{
			return GetByNamHocHocKyMaGiangVien(transactionManager, 0, int.MaxValue , namHoc, hocKy, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_DanhSachLopPhanCongGiangDay_GetByNamHocHocKyMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewDanhSachLopPhanCongGiangDay&gt;"/> instance.</returns>
		public abstract VList<ViewDanhSachLopPhanCongGiangDay> GetByNamHocHocKyMaGiangVien(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, System.String maGiangVien);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewDanhSachLopPhanCongGiangDay&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewDanhSachLopPhanCongGiangDay&gt;"/></returns>
		protected static VList&lt;ViewDanhSachLopPhanCongGiangDay&gt; Fill(DataSet dataSet, VList<ViewDanhSachLopPhanCongGiangDay> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewDanhSachLopPhanCongGiangDay>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewDanhSachLopPhanCongGiangDay&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewDanhSachLopPhanCongGiangDay>"/></returns>
		protected static VList&lt;ViewDanhSachLopPhanCongGiangDay&gt; Fill(DataTable dataTable, VList<ViewDanhSachLopPhanCongGiangDay> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewDanhSachLopPhanCongGiangDay c = new ViewDanhSachLopPhanCongGiangDay();
					c.MaGocLhp = (Convert.IsDBNull(row["MaGocLHP"]))?string.Empty:(System.String)row["MaGocLHP"];
					c.MaLhp = (Convert.IsDBNull(row["MaLHP"]))?string.Empty:(System.String)row["MaLHP"];
					c.TenHp = (Convert.IsDBNull(row["TenHP"]))?string.Empty:(System.String)row["TenHP"];
					c.LoaiHp = (Convert.IsDBNull(row["LoaiHP"]))?string.Empty:(System.String)row["LoaiHP"];
					c.SoTc = (Convert.IsDBNull(row["SoTC"]))?string.Empty:(System.String)row["SoTC"];
					c.SiSoLop = (Convert.IsDBNull(row["SiSoLop"]))?0.0m:(System.Decimal?)row["SiSoLop"];
					c.SiSoDk = (Convert.IsDBNull(row["SiSoDK"]))?(int)0:(System.Int32?)row["SiSoDK"];
					c.MaLop = (Convert.IsDBNull(row["MaLop"]))?string.Empty:(System.String)row["MaLop"];
					c.MaCbgd = (Convert.IsDBNull(row["MaCBGD"]))?string.Empty:(System.String)row["MaCBGD"];
					c.TenCbgd = (Convert.IsDBNull(row["TenCBGD"]))?string.Empty:(System.String)row["TenCBGD"];
					c.Tkb = (Convert.IsDBNull(row["TKB"]))?string.Empty:(System.String)row["TKB"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?string.Empty:(System.String)row["MaGiangVien"];
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
		/// Fill an <see cref="VList&lt;ViewDanhSachLopPhanCongGiangDay&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewDanhSachLopPhanCongGiangDay&gt;"/></returns>
		protected VList<ViewDanhSachLopPhanCongGiangDay> Fill(IDataReader reader, VList<ViewDanhSachLopPhanCongGiangDay> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewDanhSachLopPhanCongGiangDay entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewDanhSachLopPhanCongGiangDay>("ViewDanhSachLopPhanCongGiangDay",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewDanhSachLopPhanCongGiangDay();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGocLhp = (System.String)reader["MaGocLhp"];
					//entity.MaGocLhp = (Convert.IsDBNull(reader["MaGocLHP"]))?string.Empty:(System.String)reader["MaGocLHP"];
					entity.MaLhp = reader.IsDBNull(reader.GetOrdinal("MaLhp")) ? null : (System.String)reader["MaLhp"];
					//entity.MaLhp = (Convert.IsDBNull(reader["MaLHP"]))?string.Empty:(System.String)reader["MaLHP"];
					entity.TenHp = (System.String)reader["TenHp"];
					//entity.TenHp = (Convert.IsDBNull(reader["TenHP"]))?string.Empty:(System.String)reader["TenHP"];
					entity.LoaiHp = (System.String)reader["LoaiHp"];
					//entity.LoaiHp = (Convert.IsDBNull(reader["LoaiHP"]))?string.Empty:(System.String)reader["LoaiHP"];
					entity.SoTc = reader.IsDBNull(reader.GetOrdinal("SoTc")) ? null : (System.String)reader["SoTc"];
					//entity.SoTc = (Convert.IsDBNull(reader["SoTC"]))?string.Empty:(System.String)reader["SoTC"];
					entity.SiSoLop = reader.IsDBNull(reader.GetOrdinal("SiSoLop")) ? null : (System.Decimal?)reader["SiSoLop"];
					//entity.SiSoLop = (Convert.IsDBNull(reader["SiSoLop"]))?0.0m:(System.Decimal?)reader["SiSoLop"];
					entity.SiSoDk = reader.IsDBNull(reader.GetOrdinal("SiSoDk")) ? null : (System.Int32?)reader["SiSoDk"];
					//entity.SiSoDk = (Convert.IsDBNull(reader["SiSoDK"]))?(int)0:(System.Int32?)reader["SiSoDK"];
					entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
					//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
					entity.MaCbgd = reader.IsDBNull(reader.GetOrdinal("MaCbgd")) ? null : (System.String)reader["MaCbgd"];
					//entity.MaCbgd = (Convert.IsDBNull(reader["MaCBGD"]))?string.Empty:(System.String)reader["MaCBGD"];
					entity.TenCbgd = reader.IsDBNull(reader.GetOrdinal("TenCbgd")) ? null : (System.String)reader["TenCbgd"];
					//entity.TenCbgd = (Convert.IsDBNull(reader["TenCBGD"]))?string.Empty:(System.String)reader["TenCBGD"];
					entity.Tkb = reader.IsDBNull(reader.GetOrdinal("Tkb")) ? null : (System.String)reader["Tkb"];
					//entity.Tkb = (Convert.IsDBNull(reader["TKB"]))?string.Empty:(System.String)reader["TKB"];
					entity.HocKy = (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.NamHoc = (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.MaGiangVien = (System.String)reader["MaGiangVien"];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?string.Empty:(System.String)reader["MaGiangVien"];
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
		/// Refreshes the <see cref="ViewDanhSachLopPhanCongGiangDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewDanhSachLopPhanCongGiangDay"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewDanhSachLopPhanCongGiangDay entity)
		{
			reader.Read();
			entity.MaGocLhp = (System.String)reader["MaGocLhp"];
			//entity.MaGocLhp = (Convert.IsDBNull(reader["MaGocLHP"]))?string.Empty:(System.String)reader["MaGocLHP"];
			entity.MaLhp = reader.IsDBNull(reader.GetOrdinal("MaLhp")) ? null : (System.String)reader["MaLhp"];
			//entity.MaLhp = (Convert.IsDBNull(reader["MaLHP"]))?string.Empty:(System.String)reader["MaLHP"];
			entity.TenHp = (System.String)reader["TenHp"];
			//entity.TenHp = (Convert.IsDBNull(reader["TenHP"]))?string.Empty:(System.String)reader["TenHP"];
			entity.LoaiHp = (System.String)reader["LoaiHp"];
			//entity.LoaiHp = (Convert.IsDBNull(reader["LoaiHP"]))?string.Empty:(System.String)reader["LoaiHP"];
			entity.SoTc = reader.IsDBNull(reader.GetOrdinal("SoTc")) ? null : (System.String)reader["SoTc"];
			//entity.SoTc = (Convert.IsDBNull(reader["SoTC"]))?string.Empty:(System.String)reader["SoTC"];
			entity.SiSoLop = reader.IsDBNull(reader.GetOrdinal("SiSoLop")) ? null : (System.Decimal?)reader["SiSoLop"];
			//entity.SiSoLop = (Convert.IsDBNull(reader["SiSoLop"]))?0.0m:(System.Decimal?)reader["SiSoLop"];
			entity.SiSoDk = reader.IsDBNull(reader.GetOrdinal("SiSoDk")) ? null : (System.Int32?)reader["SiSoDk"];
			//entity.SiSoDk = (Convert.IsDBNull(reader["SiSoDK"]))?(int)0:(System.Int32?)reader["SiSoDK"];
			entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
			//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
			entity.MaCbgd = reader.IsDBNull(reader.GetOrdinal("MaCbgd")) ? null : (System.String)reader["MaCbgd"];
			//entity.MaCbgd = (Convert.IsDBNull(reader["MaCBGD"]))?string.Empty:(System.String)reader["MaCBGD"];
			entity.TenCbgd = reader.IsDBNull(reader.GetOrdinal("TenCbgd")) ? null : (System.String)reader["TenCbgd"];
			//entity.TenCbgd = (Convert.IsDBNull(reader["TenCBGD"]))?string.Empty:(System.String)reader["TenCBGD"];
			entity.Tkb = reader.IsDBNull(reader.GetOrdinal("Tkb")) ? null : (System.String)reader["Tkb"];
			//entity.Tkb = (Convert.IsDBNull(reader["TKB"]))?string.Empty:(System.String)reader["TKB"];
			entity.HocKy = (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.NamHoc = (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.MaGiangVien = (System.String)reader["MaGiangVien"];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?string.Empty:(System.String)reader["MaGiangVien"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewDanhSachLopPhanCongGiangDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewDanhSachLopPhanCongGiangDay"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewDanhSachLopPhanCongGiangDay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGocLhp = (Convert.IsDBNull(dataRow["MaGocLHP"]))?string.Empty:(System.String)dataRow["MaGocLHP"];
			entity.MaLhp = (Convert.IsDBNull(dataRow["MaLHP"]))?string.Empty:(System.String)dataRow["MaLHP"];
			entity.TenHp = (Convert.IsDBNull(dataRow["TenHP"]))?string.Empty:(System.String)dataRow["TenHP"];
			entity.LoaiHp = (Convert.IsDBNull(dataRow["LoaiHP"]))?string.Empty:(System.String)dataRow["LoaiHP"];
			entity.SoTc = (Convert.IsDBNull(dataRow["SoTC"]))?string.Empty:(System.String)dataRow["SoTC"];
			entity.SiSoLop = (Convert.IsDBNull(dataRow["SiSoLop"]))?0.0m:(System.Decimal?)dataRow["SiSoLop"];
			entity.SiSoDk = (Convert.IsDBNull(dataRow["SiSoDK"]))?(int)0:(System.Int32?)dataRow["SiSoDK"];
			entity.MaLop = (Convert.IsDBNull(dataRow["MaLop"]))?string.Empty:(System.String)dataRow["MaLop"];
			entity.MaCbgd = (Convert.IsDBNull(dataRow["MaCBGD"]))?string.Empty:(System.String)dataRow["MaCBGD"];
			entity.TenCbgd = (Convert.IsDBNull(dataRow["TenCBGD"]))?string.Empty:(System.String)dataRow["TenCBGD"];
			entity.Tkb = (Convert.IsDBNull(dataRow["TKB"]))?string.Empty:(System.String)dataRow["TKB"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?string.Empty:(System.String)dataRow["MaGiangVien"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewDanhSachLopPhanCongGiangDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewDanhSachLopPhanCongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewDanhSachLopPhanCongGiangDayFilterBuilder : SqlFilterBuilder<ViewDanhSachLopPhanCongGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewDanhSachLopPhanCongGiangDayFilterBuilder class.
		/// </summary>
		public ViewDanhSachLopPhanCongGiangDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewDanhSachLopPhanCongGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewDanhSachLopPhanCongGiangDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewDanhSachLopPhanCongGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewDanhSachLopPhanCongGiangDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewDanhSachLopPhanCongGiangDayFilterBuilder

	#region ViewDanhSachLopPhanCongGiangDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewDanhSachLopPhanCongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewDanhSachLopPhanCongGiangDayParameterBuilder : ParameterizedSqlFilterBuilder<ViewDanhSachLopPhanCongGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewDanhSachLopPhanCongGiangDayParameterBuilder class.
		/// </summary>
		public ViewDanhSachLopPhanCongGiangDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewDanhSachLopPhanCongGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewDanhSachLopPhanCongGiangDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewDanhSachLopPhanCongGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewDanhSachLopPhanCongGiangDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewDanhSachLopPhanCongGiangDayParameterBuilder
	
	#region ViewDanhSachLopPhanCongGiangDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewDanhSachLopPhanCongGiangDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewDanhSachLopPhanCongGiangDaySortBuilder : SqlSortBuilder<ViewDanhSachLopPhanCongGiangDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewDanhSachLopPhanCongGiangDaySqlSortBuilder class.
		/// </summary>
		public ViewDanhSachLopPhanCongGiangDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewDanhSachLopPhanCongGiangDaySortBuilder

} // end namespace
