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
	/// This class is the base class for any <see cref="ViewThongKeChucVuChiTietProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewThongKeChucVuChiTietProviderBaseCore : EntityViewProviderBase<ViewThongKeChucVuChiTiet>
	{
		#region Custom Methods
		
		
		#region cust_View_ThongKe_ChucVu_ChiTiet_GetByMaGiangVienQuanLy
		
		/// <summary>
		///	This method wrap the 'cust_View_ThongKe_ChucVu_ChiTiet_GetByMaGiangVienQuanLy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVienQuanLy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaGiangVienQuanLy(System.String maGiangVienQuanLy)
		{
			 GetByMaGiangVienQuanLy(null, 0, int.MaxValue , maGiangVienQuanLy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThongKe_ChucVu_ChiTiet_GetByMaGiangVienQuanLy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVienQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaGiangVienQuanLy(int start, int pageLength, System.String maGiangVienQuanLy)
		{
			 GetByMaGiangVienQuanLy(null, start, pageLength , maGiangVienQuanLy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ThongKe_ChucVu_ChiTiet_GetByMaGiangVienQuanLy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVienQuanLy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaGiangVienQuanLy(TransactionManager transactionManager, System.String maGiangVienQuanLy)
		{
			 GetByMaGiangVienQuanLy(transactionManager, 0, int.MaxValue , maGiangVienQuanLy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThongKe_ChucVu_ChiTiet_GetByMaGiangVienQuanLy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVienQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetByMaGiangVienQuanLy(TransactionManager transactionManager, int start, int pageLength, System.String maGiangVienQuanLy);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewThongKeChucVuChiTiet&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewThongKeChucVuChiTiet&gt;"/></returns>
		protected static VList&lt;ViewThongKeChucVuChiTiet&gt; Fill(DataSet dataSet, VList<ViewThongKeChucVuChiTiet> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewThongKeChucVuChiTiet>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewThongKeChucVuChiTiet&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewThongKeChucVuChiTiet>"/></returns>
		protected static VList&lt;ViewThongKeChucVuChiTiet&gt; Fill(DataTable dataTable, VList<ViewThongKeChucVuChiTiet> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewThongKeChucVuChiTiet c = new ViewThongKeChucVuChiTiet();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32)row["MaGiangVien"];
					c.MaGiangVienQuanLy = (Convert.IsDBNull(row["MaGiangVienQuanLy"]))?string.Empty:(System.String)row["MaGiangVienQuanLy"];
					c.Ho = (Convert.IsDBNull(row["Ho"]))?string.Empty:(System.String)row["Ho"];
					c.Ten = (Convert.IsDBNull(row["Ten"]))?string.Empty:(System.String)row["Ten"];
					c.MaChucVuHienTai = (Convert.IsDBNull(row["MaChucVuHienTai"]))?(int)0:(System.Int32?)row["MaChucVuHienTai"];
					c.MaChucVu = (Convert.IsDBNull(row["MaChucVu"]))?(int)0:(System.Int32)row["MaChucVu"];
					c.MaChucVuHienTaiQuanLy = (Convert.IsDBNull(row["MaChucVuHienTaiQuanLy"]))?string.Empty:(System.String)row["MaChucVuHienTaiQuanLy"];
					c.MaChucVuQuanLy = (Convert.IsDBNull(row["MaChucVuQuanLy"]))?string.Empty:(System.String)row["MaChucVuQuanLy"];
					c.TenChucVu = (Convert.IsDBNull(row["TenChucVu"]))?string.Empty:(System.String)row["TenChucVu"];
					c.KyHieu = (Convert.IsDBNull(row["KyHieu"]))?string.Empty:(System.String)row["KyHieu"];
					c.SoTiet = (Convert.IsDBNull(row["SoTiet"]))?(int)0:(System.Int32?)row["SoTiet"];
					c.PhanTramGio = (Convert.IsDBNull(row["PhanTramGio"]))?0.0m:(System.Decimal?)row["PhanTramGio"];
					c.NguongTiet = (Convert.IsDBNull(row["NguongTiet"]))?(int)0:(System.Int32?)row["NguongTiet"];
					c.NgayHieuLuc = (Convert.IsDBNull(row["NgayHieuLuc"]))?string.Empty:(System.String)row["NgayHieuLuc"];
					c.NgayHetHieuLuc = (Convert.IsDBNull(row["NgayHetHieuLuc"]))?string.Empty:(System.String)row["NgayHetHieuLuc"];
					c.TrangThai = (Convert.IsDBNull(row["TrangThai"]))?false:(System.Boolean?)row["TrangThai"];
					c.DamNhiem = (Convert.IsDBNull(row["DamNhiem"]))?false:(System.Boolean?)row["DamNhiem"];
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
		/// Fill an <see cref="VList&lt;ViewThongKeChucVuChiTiet&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewThongKeChucVuChiTiet&gt;"/></returns>
		protected VList<ViewThongKeChucVuChiTiet> Fill(IDataReader reader, VList<ViewThongKeChucVuChiTiet> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewThongKeChucVuChiTiet entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewThongKeChucVuChiTiet>("ViewThongKeChucVuChiTiet",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewThongKeChucVuChiTiet();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = (System.Int32)reader[((int)ViewThongKeChucVuChiTietColumn.MaGiangVien)];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
					entity.MaGiangVienQuanLy = (System.String)reader[((int)ViewThongKeChucVuChiTietColumn.MaGiangVienQuanLy)];
					//entity.MaGiangVienQuanLy = (Convert.IsDBNull(reader["MaGiangVienQuanLy"]))?string.Empty:(System.String)reader["MaGiangVienQuanLy"];
					entity.Ho = (System.String)reader[((int)ViewThongKeChucVuChiTietColumn.Ho)];
					//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
					entity.Ten = (System.String)reader[((int)ViewThongKeChucVuChiTietColumn.Ten)];
					//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
					entity.MaChucVuHienTai = (reader.IsDBNull(((int)ViewThongKeChucVuChiTietColumn.MaChucVuHienTai)))?null:(System.Int32?)reader[((int)ViewThongKeChucVuChiTietColumn.MaChucVuHienTai)];
					//entity.MaChucVuHienTai = (Convert.IsDBNull(reader["MaChucVuHienTai"]))?(int)0:(System.Int32?)reader["MaChucVuHienTai"];
					entity.MaChucVu = (System.Int32)reader[((int)ViewThongKeChucVuChiTietColumn.MaChucVu)];
					//entity.MaChucVu = (Convert.IsDBNull(reader["MaChucVu"]))?(int)0:(System.Int32)reader["MaChucVu"];
					entity.MaChucVuHienTaiQuanLy = (reader.IsDBNull(((int)ViewThongKeChucVuChiTietColumn.MaChucVuHienTaiQuanLy)))?null:(System.String)reader[((int)ViewThongKeChucVuChiTietColumn.MaChucVuHienTaiQuanLy)];
					//entity.MaChucVuHienTaiQuanLy = (Convert.IsDBNull(reader["MaChucVuHienTaiQuanLy"]))?string.Empty:(System.String)reader["MaChucVuHienTaiQuanLy"];
					entity.MaChucVuQuanLy = (System.String)reader[((int)ViewThongKeChucVuChiTietColumn.MaChucVuQuanLy)];
					//entity.MaChucVuQuanLy = (Convert.IsDBNull(reader["MaChucVuQuanLy"]))?string.Empty:(System.String)reader["MaChucVuQuanLy"];
					entity.TenChucVu = (reader.IsDBNull(((int)ViewThongKeChucVuChiTietColumn.TenChucVu)))?null:(System.String)reader[((int)ViewThongKeChucVuChiTietColumn.TenChucVu)];
					//entity.TenChucVu = (Convert.IsDBNull(reader["TenChucVu"]))?string.Empty:(System.String)reader["TenChucVu"];
					entity.KyHieu = (reader.IsDBNull(((int)ViewThongKeChucVuChiTietColumn.KyHieu)))?null:(System.String)reader[((int)ViewThongKeChucVuChiTietColumn.KyHieu)];
					//entity.KyHieu = (Convert.IsDBNull(reader["KyHieu"]))?string.Empty:(System.String)reader["KyHieu"];
					entity.SoTiet = (reader.IsDBNull(((int)ViewThongKeChucVuChiTietColumn.SoTiet)))?null:(System.Int32?)reader[((int)ViewThongKeChucVuChiTietColumn.SoTiet)];
					//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32?)reader["SoTiet"];
					entity.PhanTramGio = (reader.IsDBNull(((int)ViewThongKeChucVuChiTietColumn.PhanTramGio)))?null:(System.Decimal?)reader[((int)ViewThongKeChucVuChiTietColumn.PhanTramGio)];
					//entity.PhanTramGio = (Convert.IsDBNull(reader["PhanTramGio"]))?0.0m:(System.Decimal?)reader["PhanTramGio"];
					entity.NguongTiet = (reader.IsDBNull(((int)ViewThongKeChucVuChiTietColumn.NguongTiet)))?null:(System.Int32?)reader[((int)ViewThongKeChucVuChiTietColumn.NguongTiet)];
					//entity.NguongTiet = (Convert.IsDBNull(reader["NguongTiet"]))?(int)0:(System.Int32?)reader["NguongTiet"];
					entity.NgayHieuLuc = (reader.IsDBNull(((int)ViewThongKeChucVuChiTietColumn.NgayHieuLuc)))?null:(System.String)reader[((int)ViewThongKeChucVuChiTietColumn.NgayHieuLuc)];
					//entity.NgayHieuLuc = (Convert.IsDBNull(reader["NgayHieuLuc"]))?string.Empty:(System.String)reader["NgayHieuLuc"];
					entity.NgayHetHieuLuc = (reader.IsDBNull(((int)ViewThongKeChucVuChiTietColumn.NgayHetHieuLuc)))?null:(System.String)reader[((int)ViewThongKeChucVuChiTietColumn.NgayHetHieuLuc)];
					//entity.NgayHetHieuLuc = (Convert.IsDBNull(reader["NgayHetHieuLuc"]))?string.Empty:(System.String)reader["NgayHetHieuLuc"];
					entity.TrangThai = (reader.IsDBNull(((int)ViewThongKeChucVuChiTietColumn.TrangThai)))?null:(System.Boolean?)reader[((int)ViewThongKeChucVuChiTietColumn.TrangThai)];
					//entity.TrangThai = (Convert.IsDBNull(reader["TrangThai"]))?false:(System.Boolean?)reader["TrangThai"];
					entity.DamNhiem = (reader.IsDBNull(((int)ViewThongKeChucVuChiTietColumn.DamNhiem)))?null:(System.Boolean?)reader[((int)ViewThongKeChucVuChiTietColumn.DamNhiem)];
					//entity.DamNhiem = (Convert.IsDBNull(reader["DamNhiem"]))?false:(System.Boolean?)reader["DamNhiem"];
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
		/// Refreshes the <see cref="ViewThongKeChucVuChiTiet"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThongKeChucVuChiTiet"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewThongKeChucVuChiTiet entity)
		{
			reader.Read();
			entity.MaGiangVien = (System.Int32)reader[((int)ViewThongKeChucVuChiTietColumn.MaGiangVien)];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
			entity.MaGiangVienQuanLy = (System.String)reader[((int)ViewThongKeChucVuChiTietColumn.MaGiangVienQuanLy)];
			//entity.MaGiangVienQuanLy = (Convert.IsDBNull(reader["MaGiangVienQuanLy"]))?string.Empty:(System.String)reader["MaGiangVienQuanLy"];
			entity.Ho = (System.String)reader[((int)ViewThongKeChucVuChiTietColumn.Ho)];
			//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
			entity.Ten = (System.String)reader[((int)ViewThongKeChucVuChiTietColumn.Ten)];
			//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
			entity.MaChucVuHienTai = (reader.IsDBNull(((int)ViewThongKeChucVuChiTietColumn.MaChucVuHienTai)))?null:(System.Int32?)reader[((int)ViewThongKeChucVuChiTietColumn.MaChucVuHienTai)];
			//entity.MaChucVuHienTai = (Convert.IsDBNull(reader["MaChucVuHienTai"]))?(int)0:(System.Int32?)reader["MaChucVuHienTai"];
			entity.MaChucVu = (System.Int32)reader[((int)ViewThongKeChucVuChiTietColumn.MaChucVu)];
			//entity.MaChucVu = (Convert.IsDBNull(reader["MaChucVu"]))?(int)0:(System.Int32)reader["MaChucVu"];
			entity.MaChucVuHienTaiQuanLy = (reader.IsDBNull(((int)ViewThongKeChucVuChiTietColumn.MaChucVuHienTaiQuanLy)))?null:(System.String)reader[((int)ViewThongKeChucVuChiTietColumn.MaChucVuHienTaiQuanLy)];
			//entity.MaChucVuHienTaiQuanLy = (Convert.IsDBNull(reader["MaChucVuHienTaiQuanLy"]))?string.Empty:(System.String)reader["MaChucVuHienTaiQuanLy"];
			entity.MaChucVuQuanLy = (System.String)reader[((int)ViewThongKeChucVuChiTietColumn.MaChucVuQuanLy)];
			//entity.MaChucVuQuanLy = (Convert.IsDBNull(reader["MaChucVuQuanLy"]))?string.Empty:(System.String)reader["MaChucVuQuanLy"];
			entity.TenChucVu = (reader.IsDBNull(((int)ViewThongKeChucVuChiTietColumn.TenChucVu)))?null:(System.String)reader[((int)ViewThongKeChucVuChiTietColumn.TenChucVu)];
			//entity.TenChucVu = (Convert.IsDBNull(reader["TenChucVu"]))?string.Empty:(System.String)reader["TenChucVu"];
			entity.KyHieu = (reader.IsDBNull(((int)ViewThongKeChucVuChiTietColumn.KyHieu)))?null:(System.String)reader[((int)ViewThongKeChucVuChiTietColumn.KyHieu)];
			//entity.KyHieu = (Convert.IsDBNull(reader["KyHieu"]))?string.Empty:(System.String)reader["KyHieu"];
			entity.SoTiet = (reader.IsDBNull(((int)ViewThongKeChucVuChiTietColumn.SoTiet)))?null:(System.Int32?)reader[((int)ViewThongKeChucVuChiTietColumn.SoTiet)];
			//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32?)reader["SoTiet"];
			entity.PhanTramGio = (reader.IsDBNull(((int)ViewThongKeChucVuChiTietColumn.PhanTramGio)))?null:(System.Decimal?)reader[((int)ViewThongKeChucVuChiTietColumn.PhanTramGio)];
			//entity.PhanTramGio = (Convert.IsDBNull(reader["PhanTramGio"]))?0.0m:(System.Decimal?)reader["PhanTramGio"];
			entity.NguongTiet = (reader.IsDBNull(((int)ViewThongKeChucVuChiTietColumn.NguongTiet)))?null:(System.Int32?)reader[((int)ViewThongKeChucVuChiTietColumn.NguongTiet)];
			//entity.NguongTiet = (Convert.IsDBNull(reader["NguongTiet"]))?(int)0:(System.Int32?)reader["NguongTiet"];
			entity.NgayHieuLuc = (reader.IsDBNull(((int)ViewThongKeChucVuChiTietColumn.NgayHieuLuc)))?null:(System.String)reader[((int)ViewThongKeChucVuChiTietColumn.NgayHieuLuc)];
			//entity.NgayHieuLuc = (Convert.IsDBNull(reader["NgayHieuLuc"]))?string.Empty:(System.String)reader["NgayHieuLuc"];
			entity.NgayHetHieuLuc = (reader.IsDBNull(((int)ViewThongKeChucVuChiTietColumn.NgayHetHieuLuc)))?null:(System.String)reader[((int)ViewThongKeChucVuChiTietColumn.NgayHetHieuLuc)];
			//entity.NgayHetHieuLuc = (Convert.IsDBNull(reader["NgayHetHieuLuc"]))?string.Empty:(System.String)reader["NgayHetHieuLuc"];
			entity.TrangThai = (reader.IsDBNull(((int)ViewThongKeChucVuChiTietColumn.TrangThai)))?null:(System.Boolean?)reader[((int)ViewThongKeChucVuChiTietColumn.TrangThai)];
			//entity.TrangThai = (Convert.IsDBNull(reader["TrangThai"]))?false:(System.Boolean?)reader["TrangThai"];
			entity.DamNhiem = (reader.IsDBNull(((int)ViewThongKeChucVuChiTietColumn.DamNhiem)))?null:(System.Boolean?)reader[((int)ViewThongKeChucVuChiTietColumn.DamNhiem)];
			//entity.DamNhiem = (Convert.IsDBNull(reader["DamNhiem"]))?false:(System.Boolean?)reader["DamNhiem"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewThongKeChucVuChiTiet"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThongKeChucVuChiTiet"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewThongKeChucVuChiTiet entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32)dataRow["MaGiangVien"];
			entity.MaGiangVienQuanLy = (Convert.IsDBNull(dataRow["MaGiangVienQuanLy"]))?string.Empty:(System.String)dataRow["MaGiangVienQuanLy"];
			entity.Ho = (Convert.IsDBNull(dataRow["Ho"]))?string.Empty:(System.String)dataRow["Ho"];
			entity.Ten = (Convert.IsDBNull(dataRow["Ten"]))?string.Empty:(System.String)dataRow["Ten"];
			entity.MaChucVuHienTai = (Convert.IsDBNull(dataRow["MaChucVuHienTai"]))?(int)0:(System.Int32?)dataRow["MaChucVuHienTai"];
			entity.MaChucVu = (Convert.IsDBNull(dataRow["MaChucVu"]))?(int)0:(System.Int32)dataRow["MaChucVu"];
			entity.MaChucVuHienTaiQuanLy = (Convert.IsDBNull(dataRow["MaChucVuHienTaiQuanLy"]))?string.Empty:(System.String)dataRow["MaChucVuHienTaiQuanLy"];
			entity.MaChucVuQuanLy = (Convert.IsDBNull(dataRow["MaChucVuQuanLy"]))?string.Empty:(System.String)dataRow["MaChucVuQuanLy"];
			entity.TenChucVu = (Convert.IsDBNull(dataRow["TenChucVu"]))?string.Empty:(System.String)dataRow["TenChucVu"];
			entity.KyHieu = (Convert.IsDBNull(dataRow["KyHieu"]))?string.Empty:(System.String)dataRow["KyHieu"];
			entity.SoTiet = (Convert.IsDBNull(dataRow["SoTiet"]))?(int)0:(System.Int32?)dataRow["SoTiet"];
			entity.PhanTramGio = (Convert.IsDBNull(dataRow["PhanTramGio"]))?0.0m:(System.Decimal?)dataRow["PhanTramGio"];
			entity.NguongTiet = (Convert.IsDBNull(dataRow["NguongTiet"]))?(int)0:(System.Int32?)dataRow["NguongTiet"];
			entity.NgayHieuLuc = (Convert.IsDBNull(dataRow["NgayHieuLuc"]))?string.Empty:(System.String)dataRow["NgayHieuLuc"];
			entity.NgayHetHieuLuc = (Convert.IsDBNull(dataRow["NgayHetHieuLuc"]))?string.Empty:(System.String)dataRow["NgayHetHieuLuc"];
			entity.TrangThai = (Convert.IsDBNull(dataRow["TrangThai"]))?false:(System.Boolean?)dataRow["TrangThai"];
			entity.DamNhiem = (Convert.IsDBNull(dataRow["DamNhiem"]))?false:(System.Boolean?)dataRow["DamNhiem"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewThongKeChucVuChiTietFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongKeChucVuChiTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThongKeChucVuChiTietFilterBuilder : SqlFilterBuilder<ViewThongKeChucVuChiTietColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongKeChucVuChiTietFilterBuilder class.
		/// </summary>
		public ViewThongKeChucVuChiTietFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThongKeChucVuChiTietFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThongKeChucVuChiTietFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThongKeChucVuChiTietFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThongKeChucVuChiTietFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThongKeChucVuChiTietFilterBuilder

	#region ViewThongKeChucVuChiTietParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongKeChucVuChiTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThongKeChucVuChiTietParameterBuilder : ParameterizedSqlFilterBuilder<ViewThongKeChucVuChiTietColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongKeChucVuChiTietParameterBuilder class.
		/// </summary>
		public ViewThongKeChucVuChiTietParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThongKeChucVuChiTietParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThongKeChucVuChiTietParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThongKeChucVuChiTietParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThongKeChucVuChiTietParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThongKeChucVuChiTietParameterBuilder
	
	#region ViewThongKeChucVuChiTietSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongKeChucVuChiTiet"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewThongKeChucVuChiTietSortBuilder : SqlSortBuilder<ViewThongKeChucVuChiTietColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongKeChucVuChiTietSqlSortBuilder class.
		/// </summary>
		public ViewThongKeChucVuChiTietSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewThongKeChucVuChiTietSortBuilder

} // end namespace
