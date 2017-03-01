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
	/// This class is the base class for any <see cref="ViewGiangVienChamThiLan2ProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewGiangVienChamThiLan2ProviderBaseCore : EntityViewProviderBase<ViewGiangVienChamThiLan2>
	{
		#region Custom Methods
		
		
		#region cust_View_GiangVien_ChamThi_Lan2_GetByMaGiangVienMaLopHocPhanNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_ChamThi_Lan2_GetByMaGiangVienMaLopHocPhanNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaGiangVienMaLopHocPhanNamHocHocKy(System.String maQuanLy, System.String namHoc, System.String hocKy)
		{
			 GetByMaGiangVienMaLopHocPhanNamHocHocKy(null, 0, int.MaxValue , maQuanLy, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_ChamThi_Lan2_GetByMaGiangVienMaLopHocPhanNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaGiangVienMaLopHocPhanNamHocHocKy(int start, int pageLength, System.String maQuanLy, System.String namHoc, System.String hocKy)
		{
			 GetByMaGiangVienMaLopHocPhanNamHocHocKy(null, start, pageLength , maQuanLy, namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_ChamThi_Lan2_GetByMaGiangVienMaLopHocPhanNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaGiangVienMaLopHocPhanNamHocHocKy(TransactionManager transactionManager, System.String maQuanLy, System.String namHoc, System.String hocKy)
		{
			 GetByMaGiangVienMaLopHocPhanNamHocHocKy(transactionManager, 0, int.MaxValue , maQuanLy, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_ChamThi_Lan2_GetByMaGiangVienMaLopHocPhanNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetByMaGiangVienMaLopHocPhanNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String maQuanLy, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewGiangVienChamThiLan2&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewGiangVienChamThiLan2&gt;"/></returns>
		protected static VList&lt;ViewGiangVienChamThiLan2&gt; Fill(DataSet dataSet, VList<ViewGiangVienChamThiLan2> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewGiangVienChamThiLan2>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewGiangVienChamThiLan2&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewGiangVienChamThiLan2>"/></returns>
		protected static VList&lt;ViewGiangVienChamThiLan2&gt; Fill(DataTable dataTable, VList<ViewGiangVienChamThiLan2> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewGiangVienChamThiLan2 c = new ViewGiangVienChamThiLan2();
					c.MaChiTietChamThi = (Convert.IsDBNull(row["MaChiTietChamThi"]))?(int)0:(System.Int32)row["MaChiTietChamThi"];
					c.MaKyThi = (Convert.IsDBNull(row["MaKyThi"]))?(int)0:(System.Int32?)row["MaKyThi"];
					c.MaLopHocPhan = (Convert.IsDBNull(row["MaLopHocPhan"]))?string.Empty:(System.String)row["MaLopHocPhan"];
					c.MaGiangVienChamThi = (Convert.IsDBNull(row["MaGiangVienChamThi"]))?string.Empty:(System.String)row["MaGiangVienChamThi"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.SoBaiThiDaCham = (Convert.IsDBNull(row["SoBaiThiDaCham"]))?(int)0:(System.Int32?)row["SoBaiThiDaCham"];
					c.SiSoLop = (Convert.IsDBNull(row["SiSoLop"]))?(int)0:(System.Int32?)row["SiSoLop"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.NoiLamViec = (Convert.IsDBNull(row["NoiLamViec"]))?string.Empty:(System.String)row["NoiLamViec"];
					c.MaMonHoc = (Convert.IsDBNull(row["MaMonHoc"]))?string.Empty:(System.String)row["MaMonHoc"];
					c.TenMonHoc = (Convert.IsDBNull(row["TenMonHoc"]))?string.Empty:(System.String)row["TenMonHoc"];
					c.ThanhTienTruocThue = (Convert.IsDBNull(row["ThanhTienTruocThue"]))?0.0m:(System.Decimal?)row["ThanhTienTruocThue"];
					c.Thue10 = (Convert.IsDBNull(row["Thue10"]))?0.0m:(System.Decimal?)row["Thue10"];
					c.ThanhTienSauThue = (Convert.IsDBNull(row["ThanhTienSauThue"]))?0.0m:(System.Decimal?)row["ThanhTienSauThue"];
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
		/// Fill an <see cref="VList&lt;ViewGiangVienChamThiLan2&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewGiangVienChamThiLan2&gt;"/></returns>
		protected VList<ViewGiangVienChamThiLan2> Fill(IDataReader reader, VList<ViewGiangVienChamThiLan2> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewGiangVienChamThiLan2 entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewGiangVienChamThiLan2>("ViewGiangVienChamThiLan2",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewGiangVienChamThiLan2();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaChiTietChamThi = (System.Int32)reader[((int)ViewGiangVienChamThiLan2Column.MaChiTietChamThi)];
					//entity.MaChiTietChamThi = (Convert.IsDBNull(reader["MaChiTietChamThi"]))?(int)0:(System.Int32)reader["MaChiTietChamThi"];
					entity.MaKyThi = (reader.IsDBNull(((int)ViewGiangVienChamThiLan2Column.MaKyThi)))?null:(System.Int32?)reader[((int)ViewGiangVienChamThiLan2Column.MaKyThi)];
					//entity.MaKyThi = (Convert.IsDBNull(reader["MaKyThi"]))?(int)0:(System.Int32?)reader["MaKyThi"];
					entity.MaLopHocPhan = (reader.IsDBNull(((int)ViewGiangVienChamThiLan2Column.MaLopHocPhan)))?null:(System.String)reader[((int)ViewGiangVienChamThiLan2Column.MaLopHocPhan)];
					//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
					entity.MaGiangVienChamThi = (reader.IsDBNull(((int)ViewGiangVienChamThiLan2Column.MaGiangVienChamThi)))?null:(System.String)reader[((int)ViewGiangVienChamThiLan2Column.MaGiangVienChamThi)];
					//entity.MaGiangVienChamThi = (Convert.IsDBNull(reader["MaGiangVienChamThi"]))?string.Empty:(System.String)reader["MaGiangVienChamThi"];
					entity.HoTen = (reader.IsDBNull(((int)ViewGiangVienChamThiLan2Column.HoTen)))?null:(System.String)reader[((int)ViewGiangVienChamThiLan2Column.HoTen)];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.SoBaiThiDaCham = (reader.IsDBNull(((int)ViewGiangVienChamThiLan2Column.SoBaiThiDaCham)))?null:(System.Int32?)reader[((int)ViewGiangVienChamThiLan2Column.SoBaiThiDaCham)];
					//entity.SoBaiThiDaCham = (Convert.IsDBNull(reader["SoBaiThiDaCham"]))?(int)0:(System.Int32?)reader["SoBaiThiDaCham"];
					entity.SiSoLop = (reader.IsDBNull(((int)ViewGiangVienChamThiLan2Column.SiSoLop)))?null:(System.Int32?)reader[((int)ViewGiangVienChamThiLan2Column.SiSoLop)];
					//entity.SiSoLop = (Convert.IsDBNull(reader["SiSoLop"]))?(int)0:(System.Int32?)reader["SiSoLop"];
					entity.HocKy = (reader.IsDBNull(((int)ViewGiangVienChamThiLan2Column.HocKy)))?null:(System.String)reader[((int)ViewGiangVienChamThiLan2Column.HocKy)];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.NamHoc = (reader.IsDBNull(((int)ViewGiangVienChamThiLan2Column.NamHoc)))?null:(System.String)reader[((int)ViewGiangVienChamThiLan2Column.NamHoc)];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.NoiLamViec = (reader.IsDBNull(((int)ViewGiangVienChamThiLan2Column.NoiLamViec)))?null:(System.String)reader[((int)ViewGiangVienChamThiLan2Column.NoiLamViec)];
					//entity.NoiLamViec = (Convert.IsDBNull(reader["NoiLamViec"]))?string.Empty:(System.String)reader["NoiLamViec"];
					entity.MaMonHoc = (reader.IsDBNull(((int)ViewGiangVienChamThiLan2Column.MaMonHoc)))?null:(System.String)reader[((int)ViewGiangVienChamThiLan2Column.MaMonHoc)];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.TenMonHoc = (System.String)reader[((int)ViewGiangVienChamThiLan2Column.TenMonHoc)];
					//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
					entity.ThanhTienTruocThue = (reader.IsDBNull(((int)ViewGiangVienChamThiLan2Column.ThanhTienTruocThue)))?null:(System.Decimal?)reader[((int)ViewGiangVienChamThiLan2Column.ThanhTienTruocThue)];
					//entity.ThanhTienTruocThue = (Convert.IsDBNull(reader["ThanhTienTruocThue"]))?0.0m:(System.Decimal?)reader["ThanhTienTruocThue"];
					entity.Thue10 = (reader.IsDBNull(((int)ViewGiangVienChamThiLan2Column.Thue10)))?null:(System.Decimal?)reader[((int)ViewGiangVienChamThiLan2Column.Thue10)];
					//entity.Thue10 = (Convert.IsDBNull(reader["Thue10"]))?0.0m:(System.Decimal?)reader["Thue10"];
					entity.ThanhTienSauThue = (reader.IsDBNull(((int)ViewGiangVienChamThiLan2Column.ThanhTienSauThue)))?null:(System.Decimal?)reader[((int)ViewGiangVienChamThiLan2Column.ThanhTienSauThue)];
					//entity.ThanhTienSauThue = (Convert.IsDBNull(reader["ThanhTienSauThue"]))?0.0m:(System.Decimal?)reader["ThanhTienSauThue"];
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
		/// Refreshes the <see cref="ViewGiangVienChamThiLan2"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewGiangVienChamThiLan2"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewGiangVienChamThiLan2 entity)
		{
			reader.Read();
			entity.MaChiTietChamThi = (System.Int32)reader[((int)ViewGiangVienChamThiLan2Column.MaChiTietChamThi)];
			//entity.MaChiTietChamThi = (Convert.IsDBNull(reader["MaChiTietChamThi"]))?(int)0:(System.Int32)reader["MaChiTietChamThi"];
			entity.MaKyThi = (reader.IsDBNull(((int)ViewGiangVienChamThiLan2Column.MaKyThi)))?null:(System.Int32?)reader[((int)ViewGiangVienChamThiLan2Column.MaKyThi)];
			//entity.MaKyThi = (Convert.IsDBNull(reader["MaKyThi"]))?(int)0:(System.Int32?)reader["MaKyThi"];
			entity.MaLopHocPhan = (reader.IsDBNull(((int)ViewGiangVienChamThiLan2Column.MaLopHocPhan)))?null:(System.String)reader[((int)ViewGiangVienChamThiLan2Column.MaLopHocPhan)];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			entity.MaGiangVienChamThi = (reader.IsDBNull(((int)ViewGiangVienChamThiLan2Column.MaGiangVienChamThi)))?null:(System.String)reader[((int)ViewGiangVienChamThiLan2Column.MaGiangVienChamThi)];
			//entity.MaGiangVienChamThi = (Convert.IsDBNull(reader["MaGiangVienChamThi"]))?string.Empty:(System.String)reader["MaGiangVienChamThi"];
			entity.HoTen = (reader.IsDBNull(((int)ViewGiangVienChamThiLan2Column.HoTen)))?null:(System.String)reader[((int)ViewGiangVienChamThiLan2Column.HoTen)];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.SoBaiThiDaCham = (reader.IsDBNull(((int)ViewGiangVienChamThiLan2Column.SoBaiThiDaCham)))?null:(System.Int32?)reader[((int)ViewGiangVienChamThiLan2Column.SoBaiThiDaCham)];
			//entity.SoBaiThiDaCham = (Convert.IsDBNull(reader["SoBaiThiDaCham"]))?(int)0:(System.Int32?)reader["SoBaiThiDaCham"];
			entity.SiSoLop = (reader.IsDBNull(((int)ViewGiangVienChamThiLan2Column.SiSoLop)))?null:(System.Int32?)reader[((int)ViewGiangVienChamThiLan2Column.SiSoLop)];
			//entity.SiSoLop = (Convert.IsDBNull(reader["SiSoLop"]))?(int)0:(System.Int32?)reader["SiSoLop"];
			entity.HocKy = (reader.IsDBNull(((int)ViewGiangVienChamThiLan2Column.HocKy)))?null:(System.String)reader[((int)ViewGiangVienChamThiLan2Column.HocKy)];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.NamHoc = (reader.IsDBNull(((int)ViewGiangVienChamThiLan2Column.NamHoc)))?null:(System.String)reader[((int)ViewGiangVienChamThiLan2Column.NamHoc)];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.NoiLamViec = (reader.IsDBNull(((int)ViewGiangVienChamThiLan2Column.NoiLamViec)))?null:(System.String)reader[((int)ViewGiangVienChamThiLan2Column.NoiLamViec)];
			//entity.NoiLamViec = (Convert.IsDBNull(reader["NoiLamViec"]))?string.Empty:(System.String)reader["NoiLamViec"];
			entity.MaMonHoc = (reader.IsDBNull(((int)ViewGiangVienChamThiLan2Column.MaMonHoc)))?null:(System.String)reader[((int)ViewGiangVienChamThiLan2Column.MaMonHoc)];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.TenMonHoc = (System.String)reader[((int)ViewGiangVienChamThiLan2Column.TenMonHoc)];
			//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
			entity.ThanhTienTruocThue = (reader.IsDBNull(((int)ViewGiangVienChamThiLan2Column.ThanhTienTruocThue)))?null:(System.Decimal?)reader[((int)ViewGiangVienChamThiLan2Column.ThanhTienTruocThue)];
			//entity.ThanhTienTruocThue = (Convert.IsDBNull(reader["ThanhTienTruocThue"]))?0.0m:(System.Decimal?)reader["ThanhTienTruocThue"];
			entity.Thue10 = (reader.IsDBNull(((int)ViewGiangVienChamThiLan2Column.Thue10)))?null:(System.Decimal?)reader[((int)ViewGiangVienChamThiLan2Column.Thue10)];
			//entity.Thue10 = (Convert.IsDBNull(reader["Thue10"]))?0.0m:(System.Decimal?)reader["Thue10"];
			entity.ThanhTienSauThue = (reader.IsDBNull(((int)ViewGiangVienChamThiLan2Column.ThanhTienSauThue)))?null:(System.Decimal?)reader[((int)ViewGiangVienChamThiLan2Column.ThanhTienSauThue)];
			//entity.ThanhTienSauThue = (Convert.IsDBNull(reader["ThanhTienSauThue"]))?0.0m:(System.Decimal?)reader["ThanhTienSauThue"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewGiangVienChamThiLan2"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewGiangVienChamThiLan2"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewGiangVienChamThiLan2 entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaChiTietChamThi = (Convert.IsDBNull(dataRow["MaChiTietChamThi"]))?(int)0:(System.Int32)dataRow["MaChiTietChamThi"];
			entity.MaKyThi = (Convert.IsDBNull(dataRow["MaKyThi"]))?(int)0:(System.Int32?)dataRow["MaKyThi"];
			entity.MaLopHocPhan = (Convert.IsDBNull(dataRow["MaLopHocPhan"]))?string.Empty:(System.String)dataRow["MaLopHocPhan"];
			entity.MaGiangVienChamThi = (Convert.IsDBNull(dataRow["MaGiangVienChamThi"]))?string.Empty:(System.String)dataRow["MaGiangVienChamThi"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.SoBaiThiDaCham = (Convert.IsDBNull(dataRow["SoBaiThiDaCham"]))?(int)0:(System.Int32?)dataRow["SoBaiThiDaCham"];
			entity.SiSoLop = (Convert.IsDBNull(dataRow["SiSoLop"]))?(int)0:(System.Int32?)dataRow["SiSoLop"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.NoiLamViec = (Convert.IsDBNull(dataRow["NoiLamViec"]))?string.Empty:(System.String)dataRow["NoiLamViec"];
			entity.MaMonHoc = (Convert.IsDBNull(dataRow["MaMonHoc"]))?string.Empty:(System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = (Convert.IsDBNull(dataRow["TenMonHoc"]))?string.Empty:(System.String)dataRow["TenMonHoc"];
			entity.ThanhTienTruocThue = (Convert.IsDBNull(dataRow["ThanhTienTruocThue"]))?0.0m:(System.Decimal?)dataRow["ThanhTienTruocThue"];
			entity.Thue10 = (Convert.IsDBNull(dataRow["Thue10"]))?0.0m:(System.Decimal?)dataRow["Thue10"];
			entity.ThanhTienSauThue = (Convert.IsDBNull(dataRow["ThanhTienSauThue"]))?0.0m:(System.Decimal?)dataRow["ThanhTienSauThue"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewGiangVienChamThiLan2FilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVienChamThiLan2"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewGiangVienChamThiLan2FilterBuilder : SqlFilterBuilder<ViewGiangVienChamThiLan2Column>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienChamThiLan2FilterBuilder class.
		/// </summary>
		public ViewGiangVienChamThiLan2FilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienChamThiLan2FilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewGiangVienChamThiLan2FilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienChamThiLan2FilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewGiangVienChamThiLan2FilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewGiangVienChamThiLan2FilterBuilder

	#region ViewGiangVienChamThiLan2ParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVienChamThiLan2"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewGiangVienChamThiLan2ParameterBuilder : ParameterizedSqlFilterBuilder<ViewGiangVienChamThiLan2Column>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienChamThiLan2ParameterBuilder class.
		/// </summary>
		public ViewGiangVienChamThiLan2ParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienChamThiLan2ParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewGiangVienChamThiLan2ParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienChamThiLan2ParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewGiangVienChamThiLan2ParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewGiangVienChamThiLan2ParameterBuilder
	
	#region ViewGiangVienChamThiLan2SortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVienChamThiLan2"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewGiangVienChamThiLan2SortBuilder : SqlSortBuilder<ViewGiangVienChamThiLan2Column>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienChamThiLan2SqlSortBuilder class.
		/// </summary>
		public ViewGiangVienChamThiLan2SortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewGiangVienChamThiLan2SortBuilder

} // end namespace
