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
	/// This class is the base class for any <see cref="VThongTinMonHocProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class VThongTinMonHocProviderBaseCore : EntityViewProviderBase<VThongTinMonHoc>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;VThongTinMonHoc&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;VThongTinMonHoc&gt;"/></returns>
		protected static VList&lt;VThongTinMonHoc&gt; Fill(DataSet dataSet, VList<VThongTinMonHoc> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<VThongTinMonHoc>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;VThongTinMonHoc&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<VThongTinMonHoc>"/></returns>
		protected static VList&lt;VThongTinMonHoc&gt; Fill(DataTable dataTable, VList<VThongTinMonHoc> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					VThongTinMonHoc c = new VThongTinMonHoc();
					c.MaMonHoc = (Convert.IsDBNull(row["MaMonHoc"]))?string.Empty:(System.String)row["MaMonHoc"];
					c.TenMonHoc = (Convert.IsDBNull(row["TenMonHoc"]))?string.Empty:(System.String)row["TenMonHoc"];
					c.Credits = (Convert.IsDBNull(row["Credits"]))?(int)0:(System.Int32?)row["Credits"];
					c.TheoryCredits = (Convert.IsDBNull(row["TheoryCredits"]))?0.0m:(System.Decimal?)row["TheoryCredits"];
					c.PracticeCredits = (Convert.IsDBNull(row["PracticeCredits"]))?0.0m:(System.Decimal?)row["PracticeCredits"];
					c.SelfCredits = (Convert.IsDBNull(row["SelfCredits"]))?0.0m:(System.Decimal?)row["SelfCredits"];
					c.Note = (Convert.IsDBNull(row["Note"]))?string.Empty:(System.String)row["Note"];
					c.CreditInfos = (Convert.IsDBNull(row["CreditInfos"]))?string.Empty:(System.String)row["CreditInfos"];
					c.LyThuyet = (Convert.IsDBNull(row["LyThuyet"]))?0.0m:(System.Decimal)row["LyThuyet"];
					c.ThucHanh = (Convert.IsDBNull(row["ThucHanh"]))?0.0m:(System.Decimal)row["ThucHanh"];
					c.ThucTap = (Convert.IsDBNull(row["ThucTap"]))?0.0m:(System.Decimal)row["ThucTap"];
					c.TieuLuan = (Convert.IsDBNull(row["TieuLuan"]))?0.0m:(System.Decimal)row["TieuLuan"];
					c.DoAn = (Convert.IsDBNull(row["DoAn"]))?0.0m:(System.Decimal)row["DoAn"];
					c.LuanAn = (Convert.IsDBNull(row["LuanAn"]))?0.0m:(System.Decimal)row["LuanAn"];
					c.BaiTap = (Convert.IsDBNull(row["BaiTap"]))?(int)0:(System.Int32)row["BaiTap"];
					c.BaiTapLon = (Convert.IsDBNull(row["BaiTapLon"]))?(int)0:(System.Int32)row["BaiTapLon"];
					c.MaLoaiPhong = (Convert.IsDBNull(row["MaLoaiPhong"]))?string.Empty:(System.String)row["MaLoaiPhong"];
					c.MaBacDaoTao = (Convert.IsDBNull(row["MaBacDaoTao"]))?string.Empty:(System.String)row["MaBacDaoTao"];
					c.TenBacDaoTao = (Convert.IsDBNull(row["TenBacDaoTao"]))?string.Empty:(System.String)row["TenBacDaoTao"];
					c.MaNhomMonHoc = (Convert.IsDBNull(row["MaNhomMonHoc"]))?string.Empty:(System.String)row["MaNhomMonHoc"];
					c.TenNhomMonHoc = (Convert.IsDBNull(row["TenNhomMonHoc"]))?string.Empty:(System.String)row["TenNhomMonHoc"];
					c.MaDonVi = (Convert.IsDBNull(row["MaDonVi"]))?string.Empty:(System.String)row["MaDonVi"];
					c.TenDonVi = (Convert.IsDBNull(row["TenDonVi"]))?string.Empty:(System.String)row["TenDonVi"];
					c.MaKhoaBoMon = (Convert.IsDBNull(row["MaKhoaBoMon"]))?string.Empty:(System.String)row["MaKhoaBoMon"];
					c.TenKhoaBoMon = (Convert.IsDBNull(row["TenKhoaBoMon"]))?string.Empty:(System.String)row["TenKhoaBoMon"];
					c.ThongTinDonVi = (Convert.IsDBNull(row["ThongTinDonVi"]))?string.Empty:(System.String)row["ThongTinDonVi"];
					c.UpdateStaff = (Convert.IsDBNull(row["UpdateStaff"]))?string.Empty:(System.String)row["UpdateStaff"];
					c.UpdateDate = (Convert.IsDBNull(row["UpdateDate"]))?DateTime.MinValue:(System.DateTime?)row["UpdateDate"];
					c.CreditInfo = (Convert.IsDBNull(row["CreditInfo"]))?string.Empty:(System.String)row["CreditInfo"];
					c.LoaiMonHoc = (Convert.IsDBNull(row["LoaiMonHoc"]))?string.Empty:(System.String)row["LoaiMonHoc"];
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
		/// Fill an <see cref="VList&lt;VThongTinMonHoc&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;VThongTinMonHoc&gt;"/></returns>
		protected VList<VThongTinMonHoc> Fill(IDataReader reader, VList<VThongTinMonHoc> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					VThongTinMonHoc entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<VThongTinMonHoc>("VThongTinMonHoc",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new VThongTinMonHoc();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaMonHoc = (System.String)reader[((int)VThongTinMonHocColumn.MaMonHoc)];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.TenMonHoc = (System.String)reader[((int)VThongTinMonHocColumn.TenMonHoc)];
					//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
					entity.Credits = (reader.IsDBNull(((int)VThongTinMonHocColumn.Credits)))?null:(System.Int32?)reader[((int)VThongTinMonHocColumn.Credits)];
					//entity.Credits = (Convert.IsDBNull(reader["Credits"]))?(int)0:(System.Int32?)reader["Credits"];
					entity.TheoryCredits = (reader.IsDBNull(((int)VThongTinMonHocColumn.TheoryCredits)))?null:(System.Decimal?)reader[((int)VThongTinMonHocColumn.TheoryCredits)];
					//entity.TheoryCredits = (Convert.IsDBNull(reader["TheoryCredits"]))?0.0m:(System.Decimal?)reader["TheoryCredits"];
					entity.PracticeCredits = (reader.IsDBNull(((int)VThongTinMonHocColumn.PracticeCredits)))?null:(System.Decimal?)reader[((int)VThongTinMonHocColumn.PracticeCredits)];
					//entity.PracticeCredits = (Convert.IsDBNull(reader["PracticeCredits"]))?0.0m:(System.Decimal?)reader["PracticeCredits"];
					entity.SelfCredits = (reader.IsDBNull(((int)VThongTinMonHocColumn.SelfCredits)))?null:(System.Decimal?)reader[((int)VThongTinMonHocColumn.SelfCredits)];
					//entity.SelfCredits = (Convert.IsDBNull(reader["SelfCredits"]))?0.0m:(System.Decimal?)reader["SelfCredits"];
					entity.Note = (reader.IsDBNull(((int)VThongTinMonHocColumn.Note)))?null:(System.String)reader[((int)VThongTinMonHocColumn.Note)];
					//entity.Note = (Convert.IsDBNull(reader["Note"]))?string.Empty:(System.String)reader["Note"];
					entity.CreditInfos = (reader.IsDBNull(((int)VThongTinMonHocColumn.CreditInfos)))?null:(System.String)reader[((int)VThongTinMonHocColumn.CreditInfos)];
					//entity.CreditInfos = (Convert.IsDBNull(reader["CreditInfos"]))?string.Empty:(System.String)reader["CreditInfos"];
					entity.LyThuyet = (System.Decimal)reader[((int)VThongTinMonHocColumn.LyThuyet)];
					//entity.LyThuyet = (Convert.IsDBNull(reader["LyThuyet"]))?0.0m:(System.Decimal)reader["LyThuyet"];
					entity.ThucHanh = (System.Decimal)reader[((int)VThongTinMonHocColumn.ThucHanh)];
					//entity.ThucHanh = (Convert.IsDBNull(reader["ThucHanh"]))?0.0m:(System.Decimal)reader["ThucHanh"];
					entity.ThucTap = (System.Decimal)reader[((int)VThongTinMonHocColumn.ThucTap)];
					//entity.ThucTap = (Convert.IsDBNull(reader["ThucTap"]))?0.0m:(System.Decimal)reader["ThucTap"];
					entity.TieuLuan = (System.Decimal)reader[((int)VThongTinMonHocColumn.TieuLuan)];
					//entity.TieuLuan = (Convert.IsDBNull(reader["TieuLuan"]))?0.0m:(System.Decimal)reader["TieuLuan"];
					entity.DoAn = (System.Decimal)reader[((int)VThongTinMonHocColumn.DoAn)];
					//entity.DoAn = (Convert.IsDBNull(reader["DoAn"]))?0.0m:(System.Decimal)reader["DoAn"];
					entity.LuanAn = (System.Decimal)reader[((int)VThongTinMonHocColumn.LuanAn)];
					//entity.LuanAn = (Convert.IsDBNull(reader["LuanAn"]))?0.0m:(System.Decimal)reader["LuanAn"];
					entity.BaiTap = (System.Int32)reader[((int)VThongTinMonHocColumn.BaiTap)];
					//entity.BaiTap = (Convert.IsDBNull(reader["BaiTap"]))?(int)0:(System.Int32)reader["BaiTap"];
					entity.BaiTapLon = (System.Int32)reader[((int)VThongTinMonHocColumn.BaiTapLon)];
					//entity.BaiTapLon = (Convert.IsDBNull(reader["BaiTapLon"]))?(int)0:(System.Int32)reader["BaiTapLon"];
					entity.MaLoaiPhong = (System.String)reader[((int)VThongTinMonHocColumn.MaLoaiPhong)];
					//entity.MaLoaiPhong = (Convert.IsDBNull(reader["MaLoaiPhong"]))?string.Empty:(System.String)reader["MaLoaiPhong"];
					entity.MaBacDaoTao = (System.String)reader[((int)VThongTinMonHocColumn.MaBacDaoTao)];
					//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
					entity.TenBacDaoTao = (reader.IsDBNull(((int)VThongTinMonHocColumn.TenBacDaoTao)))?null:(System.String)reader[((int)VThongTinMonHocColumn.TenBacDaoTao)];
					//entity.TenBacDaoTao = (Convert.IsDBNull(reader["TenBacDaoTao"]))?string.Empty:(System.String)reader["TenBacDaoTao"];
					entity.MaNhomMonHoc = (reader.IsDBNull(((int)VThongTinMonHocColumn.MaNhomMonHoc)))?null:(System.String)reader[((int)VThongTinMonHocColumn.MaNhomMonHoc)];
					//entity.MaNhomMonHoc = (Convert.IsDBNull(reader["MaNhomMonHoc"]))?string.Empty:(System.String)reader["MaNhomMonHoc"];
					entity.TenNhomMonHoc = (reader.IsDBNull(((int)VThongTinMonHocColumn.TenNhomMonHoc)))?null:(System.String)reader[((int)VThongTinMonHocColumn.TenNhomMonHoc)];
					//entity.TenNhomMonHoc = (Convert.IsDBNull(reader["TenNhomMonHoc"]))?string.Empty:(System.String)reader["TenNhomMonHoc"];
					entity.MaDonVi = (reader.IsDBNull(((int)VThongTinMonHocColumn.MaDonVi)))?null:(System.String)reader[((int)VThongTinMonHocColumn.MaDonVi)];
					//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
					entity.TenDonVi = (reader.IsDBNull(((int)VThongTinMonHocColumn.TenDonVi)))?null:(System.String)reader[((int)VThongTinMonHocColumn.TenDonVi)];
					//entity.TenDonVi = (Convert.IsDBNull(reader["TenDonVi"]))?string.Empty:(System.String)reader["TenDonVi"];
					entity.MaKhoaBoMon = (reader.IsDBNull(((int)VThongTinMonHocColumn.MaKhoaBoMon)))?null:(System.String)reader[((int)VThongTinMonHocColumn.MaKhoaBoMon)];
					//entity.MaKhoaBoMon = (Convert.IsDBNull(reader["MaKhoaBoMon"]))?string.Empty:(System.String)reader["MaKhoaBoMon"];
					entity.TenKhoaBoMon = (reader.IsDBNull(((int)VThongTinMonHocColumn.TenKhoaBoMon)))?null:(System.String)reader[((int)VThongTinMonHocColumn.TenKhoaBoMon)];
					//entity.TenKhoaBoMon = (Convert.IsDBNull(reader["TenKhoaBoMon"]))?string.Empty:(System.String)reader["TenKhoaBoMon"];
					entity.ThongTinDonVi = (reader.IsDBNull(((int)VThongTinMonHocColumn.ThongTinDonVi)))?null:(System.String)reader[((int)VThongTinMonHocColumn.ThongTinDonVi)];
					//entity.ThongTinDonVi = (Convert.IsDBNull(reader["ThongTinDonVi"]))?string.Empty:(System.String)reader["ThongTinDonVi"];
					entity.UpdateStaff = (reader.IsDBNull(((int)VThongTinMonHocColumn.UpdateStaff)))?null:(System.String)reader[((int)VThongTinMonHocColumn.UpdateStaff)];
					//entity.UpdateStaff = (Convert.IsDBNull(reader["UpdateStaff"]))?string.Empty:(System.String)reader["UpdateStaff"];
					entity.UpdateDate = (reader.IsDBNull(((int)VThongTinMonHocColumn.UpdateDate)))?null:(System.DateTime?)reader[((int)VThongTinMonHocColumn.UpdateDate)];
					//entity.UpdateDate = (Convert.IsDBNull(reader["UpdateDate"]))?DateTime.MinValue:(System.DateTime?)reader["UpdateDate"];
					entity.CreditInfo = (reader.IsDBNull(((int)VThongTinMonHocColumn.CreditInfo)))?null:(System.String)reader[((int)VThongTinMonHocColumn.CreditInfo)];
					//entity.CreditInfo = (Convert.IsDBNull(reader["CreditInfo"]))?string.Empty:(System.String)reader["CreditInfo"];
					entity.LoaiMonHoc = (System.String)reader[((int)VThongTinMonHocColumn.LoaiMonHoc)];
					//entity.LoaiMonHoc = (Convert.IsDBNull(reader["LoaiMonHoc"]))?string.Empty:(System.String)reader["LoaiMonHoc"];
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
		/// Refreshes the <see cref="VThongTinMonHoc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="VThongTinMonHoc"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, VThongTinMonHoc entity)
		{
			reader.Read();
			entity.MaMonHoc = (System.String)reader[((int)VThongTinMonHocColumn.MaMonHoc)];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.TenMonHoc = (System.String)reader[((int)VThongTinMonHocColumn.TenMonHoc)];
			//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
			entity.Credits = (reader.IsDBNull(((int)VThongTinMonHocColumn.Credits)))?null:(System.Int32?)reader[((int)VThongTinMonHocColumn.Credits)];
			//entity.Credits = (Convert.IsDBNull(reader["Credits"]))?(int)0:(System.Int32?)reader["Credits"];
			entity.TheoryCredits = (reader.IsDBNull(((int)VThongTinMonHocColumn.TheoryCredits)))?null:(System.Decimal?)reader[((int)VThongTinMonHocColumn.TheoryCredits)];
			//entity.TheoryCredits = (Convert.IsDBNull(reader["TheoryCredits"]))?0.0m:(System.Decimal?)reader["TheoryCredits"];
			entity.PracticeCredits = (reader.IsDBNull(((int)VThongTinMonHocColumn.PracticeCredits)))?null:(System.Decimal?)reader[((int)VThongTinMonHocColumn.PracticeCredits)];
			//entity.PracticeCredits = (Convert.IsDBNull(reader["PracticeCredits"]))?0.0m:(System.Decimal?)reader["PracticeCredits"];
			entity.SelfCredits = (reader.IsDBNull(((int)VThongTinMonHocColumn.SelfCredits)))?null:(System.Decimal?)reader[((int)VThongTinMonHocColumn.SelfCredits)];
			//entity.SelfCredits = (Convert.IsDBNull(reader["SelfCredits"]))?0.0m:(System.Decimal?)reader["SelfCredits"];
			entity.Note = (reader.IsDBNull(((int)VThongTinMonHocColumn.Note)))?null:(System.String)reader[((int)VThongTinMonHocColumn.Note)];
			//entity.Note = (Convert.IsDBNull(reader["Note"]))?string.Empty:(System.String)reader["Note"];
			entity.CreditInfos = (reader.IsDBNull(((int)VThongTinMonHocColumn.CreditInfos)))?null:(System.String)reader[((int)VThongTinMonHocColumn.CreditInfos)];
			//entity.CreditInfos = (Convert.IsDBNull(reader["CreditInfos"]))?string.Empty:(System.String)reader["CreditInfos"];
			entity.LyThuyet = (System.Decimal)reader[((int)VThongTinMonHocColumn.LyThuyet)];
			//entity.LyThuyet = (Convert.IsDBNull(reader["LyThuyet"]))?0.0m:(System.Decimal)reader["LyThuyet"];
			entity.ThucHanh = (System.Decimal)reader[((int)VThongTinMonHocColumn.ThucHanh)];
			//entity.ThucHanh = (Convert.IsDBNull(reader["ThucHanh"]))?0.0m:(System.Decimal)reader["ThucHanh"];
			entity.ThucTap = (System.Decimal)reader[((int)VThongTinMonHocColumn.ThucTap)];
			//entity.ThucTap = (Convert.IsDBNull(reader["ThucTap"]))?0.0m:(System.Decimal)reader["ThucTap"];
			entity.TieuLuan = (System.Decimal)reader[((int)VThongTinMonHocColumn.TieuLuan)];
			//entity.TieuLuan = (Convert.IsDBNull(reader["TieuLuan"]))?0.0m:(System.Decimal)reader["TieuLuan"];
			entity.DoAn = (System.Decimal)reader[((int)VThongTinMonHocColumn.DoAn)];
			//entity.DoAn = (Convert.IsDBNull(reader["DoAn"]))?0.0m:(System.Decimal)reader["DoAn"];
			entity.LuanAn = (System.Decimal)reader[((int)VThongTinMonHocColumn.LuanAn)];
			//entity.LuanAn = (Convert.IsDBNull(reader["LuanAn"]))?0.0m:(System.Decimal)reader["LuanAn"];
			entity.BaiTap = (System.Int32)reader[((int)VThongTinMonHocColumn.BaiTap)];
			//entity.BaiTap = (Convert.IsDBNull(reader["BaiTap"]))?(int)0:(System.Int32)reader["BaiTap"];
			entity.BaiTapLon = (System.Int32)reader[((int)VThongTinMonHocColumn.BaiTapLon)];
			//entity.BaiTapLon = (Convert.IsDBNull(reader["BaiTapLon"]))?(int)0:(System.Int32)reader["BaiTapLon"];
			entity.MaLoaiPhong = (System.String)reader[((int)VThongTinMonHocColumn.MaLoaiPhong)];
			//entity.MaLoaiPhong = (Convert.IsDBNull(reader["MaLoaiPhong"]))?string.Empty:(System.String)reader["MaLoaiPhong"];
			entity.MaBacDaoTao = (System.String)reader[((int)VThongTinMonHocColumn.MaBacDaoTao)];
			//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
			entity.TenBacDaoTao = (reader.IsDBNull(((int)VThongTinMonHocColumn.TenBacDaoTao)))?null:(System.String)reader[((int)VThongTinMonHocColumn.TenBacDaoTao)];
			//entity.TenBacDaoTao = (Convert.IsDBNull(reader["TenBacDaoTao"]))?string.Empty:(System.String)reader["TenBacDaoTao"];
			entity.MaNhomMonHoc = (reader.IsDBNull(((int)VThongTinMonHocColumn.MaNhomMonHoc)))?null:(System.String)reader[((int)VThongTinMonHocColumn.MaNhomMonHoc)];
			//entity.MaNhomMonHoc = (Convert.IsDBNull(reader["MaNhomMonHoc"]))?string.Empty:(System.String)reader["MaNhomMonHoc"];
			entity.TenNhomMonHoc = (reader.IsDBNull(((int)VThongTinMonHocColumn.TenNhomMonHoc)))?null:(System.String)reader[((int)VThongTinMonHocColumn.TenNhomMonHoc)];
			//entity.TenNhomMonHoc = (Convert.IsDBNull(reader["TenNhomMonHoc"]))?string.Empty:(System.String)reader["TenNhomMonHoc"];
			entity.MaDonVi = (reader.IsDBNull(((int)VThongTinMonHocColumn.MaDonVi)))?null:(System.String)reader[((int)VThongTinMonHocColumn.MaDonVi)];
			//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
			entity.TenDonVi = (reader.IsDBNull(((int)VThongTinMonHocColumn.TenDonVi)))?null:(System.String)reader[((int)VThongTinMonHocColumn.TenDonVi)];
			//entity.TenDonVi = (Convert.IsDBNull(reader["TenDonVi"]))?string.Empty:(System.String)reader["TenDonVi"];
			entity.MaKhoaBoMon = (reader.IsDBNull(((int)VThongTinMonHocColumn.MaKhoaBoMon)))?null:(System.String)reader[((int)VThongTinMonHocColumn.MaKhoaBoMon)];
			//entity.MaKhoaBoMon = (Convert.IsDBNull(reader["MaKhoaBoMon"]))?string.Empty:(System.String)reader["MaKhoaBoMon"];
			entity.TenKhoaBoMon = (reader.IsDBNull(((int)VThongTinMonHocColumn.TenKhoaBoMon)))?null:(System.String)reader[((int)VThongTinMonHocColumn.TenKhoaBoMon)];
			//entity.TenKhoaBoMon = (Convert.IsDBNull(reader["TenKhoaBoMon"]))?string.Empty:(System.String)reader["TenKhoaBoMon"];
			entity.ThongTinDonVi = (reader.IsDBNull(((int)VThongTinMonHocColumn.ThongTinDonVi)))?null:(System.String)reader[((int)VThongTinMonHocColumn.ThongTinDonVi)];
			//entity.ThongTinDonVi = (Convert.IsDBNull(reader["ThongTinDonVi"]))?string.Empty:(System.String)reader["ThongTinDonVi"];
			entity.UpdateStaff = (reader.IsDBNull(((int)VThongTinMonHocColumn.UpdateStaff)))?null:(System.String)reader[((int)VThongTinMonHocColumn.UpdateStaff)];
			//entity.UpdateStaff = (Convert.IsDBNull(reader["UpdateStaff"]))?string.Empty:(System.String)reader["UpdateStaff"];
			entity.UpdateDate = (reader.IsDBNull(((int)VThongTinMonHocColumn.UpdateDate)))?null:(System.DateTime?)reader[((int)VThongTinMonHocColumn.UpdateDate)];
			//entity.UpdateDate = (Convert.IsDBNull(reader["UpdateDate"]))?DateTime.MinValue:(System.DateTime?)reader["UpdateDate"];
			entity.CreditInfo = (reader.IsDBNull(((int)VThongTinMonHocColumn.CreditInfo)))?null:(System.String)reader[((int)VThongTinMonHocColumn.CreditInfo)];
			//entity.CreditInfo = (Convert.IsDBNull(reader["CreditInfo"]))?string.Empty:(System.String)reader["CreditInfo"];
			entity.LoaiMonHoc = (System.String)reader[((int)VThongTinMonHocColumn.LoaiMonHoc)];
			//entity.LoaiMonHoc = (Convert.IsDBNull(reader["LoaiMonHoc"]))?string.Empty:(System.String)reader["LoaiMonHoc"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="VThongTinMonHoc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="VThongTinMonHoc"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, VThongTinMonHoc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaMonHoc = (Convert.IsDBNull(dataRow["MaMonHoc"]))?string.Empty:(System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = (Convert.IsDBNull(dataRow["TenMonHoc"]))?string.Empty:(System.String)dataRow["TenMonHoc"];
			entity.Credits = (Convert.IsDBNull(dataRow["Credits"]))?(int)0:(System.Int32?)dataRow["Credits"];
			entity.TheoryCredits = (Convert.IsDBNull(dataRow["TheoryCredits"]))?0.0m:(System.Decimal?)dataRow["TheoryCredits"];
			entity.PracticeCredits = (Convert.IsDBNull(dataRow["PracticeCredits"]))?0.0m:(System.Decimal?)dataRow["PracticeCredits"];
			entity.SelfCredits = (Convert.IsDBNull(dataRow["SelfCredits"]))?0.0m:(System.Decimal?)dataRow["SelfCredits"];
			entity.Note = (Convert.IsDBNull(dataRow["Note"]))?string.Empty:(System.String)dataRow["Note"];
			entity.CreditInfos = (Convert.IsDBNull(dataRow["CreditInfos"]))?string.Empty:(System.String)dataRow["CreditInfos"];
			entity.LyThuyet = (Convert.IsDBNull(dataRow["LyThuyet"]))?0.0m:(System.Decimal)dataRow["LyThuyet"];
			entity.ThucHanh = (Convert.IsDBNull(dataRow["ThucHanh"]))?0.0m:(System.Decimal)dataRow["ThucHanh"];
			entity.ThucTap = (Convert.IsDBNull(dataRow["ThucTap"]))?0.0m:(System.Decimal)dataRow["ThucTap"];
			entity.TieuLuan = (Convert.IsDBNull(dataRow["TieuLuan"]))?0.0m:(System.Decimal)dataRow["TieuLuan"];
			entity.DoAn = (Convert.IsDBNull(dataRow["DoAn"]))?0.0m:(System.Decimal)dataRow["DoAn"];
			entity.LuanAn = (Convert.IsDBNull(dataRow["LuanAn"]))?0.0m:(System.Decimal)dataRow["LuanAn"];
			entity.BaiTap = (Convert.IsDBNull(dataRow["BaiTap"]))?(int)0:(System.Int32)dataRow["BaiTap"];
			entity.BaiTapLon = (Convert.IsDBNull(dataRow["BaiTapLon"]))?(int)0:(System.Int32)dataRow["BaiTapLon"];
			entity.MaLoaiPhong = (Convert.IsDBNull(dataRow["MaLoaiPhong"]))?string.Empty:(System.String)dataRow["MaLoaiPhong"];
			entity.MaBacDaoTao = (Convert.IsDBNull(dataRow["MaBacDaoTao"]))?string.Empty:(System.String)dataRow["MaBacDaoTao"];
			entity.TenBacDaoTao = (Convert.IsDBNull(dataRow["TenBacDaoTao"]))?string.Empty:(System.String)dataRow["TenBacDaoTao"];
			entity.MaNhomMonHoc = (Convert.IsDBNull(dataRow["MaNhomMonHoc"]))?string.Empty:(System.String)dataRow["MaNhomMonHoc"];
			entity.TenNhomMonHoc = (Convert.IsDBNull(dataRow["TenNhomMonHoc"]))?string.Empty:(System.String)dataRow["TenNhomMonHoc"];
			entity.MaDonVi = (Convert.IsDBNull(dataRow["MaDonVi"]))?string.Empty:(System.String)dataRow["MaDonVi"];
			entity.TenDonVi = (Convert.IsDBNull(dataRow["TenDonVi"]))?string.Empty:(System.String)dataRow["TenDonVi"];
			entity.MaKhoaBoMon = (Convert.IsDBNull(dataRow["MaKhoaBoMon"]))?string.Empty:(System.String)dataRow["MaKhoaBoMon"];
			entity.TenKhoaBoMon = (Convert.IsDBNull(dataRow["TenKhoaBoMon"]))?string.Empty:(System.String)dataRow["TenKhoaBoMon"];
			entity.ThongTinDonVi = (Convert.IsDBNull(dataRow["ThongTinDonVi"]))?string.Empty:(System.String)dataRow["ThongTinDonVi"];
			entity.UpdateStaff = (Convert.IsDBNull(dataRow["UpdateStaff"]))?string.Empty:(System.String)dataRow["UpdateStaff"];
			entity.UpdateDate = (Convert.IsDBNull(dataRow["UpdateDate"]))?DateTime.MinValue:(System.DateTime?)dataRow["UpdateDate"];
			entity.CreditInfo = (Convert.IsDBNull(dataRow["CreditInfo"]))?string.Empty:(System.String)dataRow["CreditInfo"];
			entity.LoaiMonHoc = (Convert.IsDBNull(dataRow["LoaiMonHoc"]))?string.Empty:(System.String)dataRow["LoaiMonHoc"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region VThongTinMonHocFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VThongTinMonHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VThongTinMonHocFilterBuilder : SqlFilterBuilder<VThongTinMonHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VThongTinMonHocFilterBuilder class.
		/// </summary>
		public VThongTinMonHocFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VThongTinMonHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VThongTinMonHocFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VThongTinMonHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VThongTinMonHocFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VThongTinMonHocFilterBuilder

	#region VThongTinMonHocParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VThongTinMonHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VThongTinMonHocParameterBuilder : ParameterizedSqlFilterBuilder<VThongTinMonHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VThongTinMonHocParameterBuilder class.
		/// </summary>
		public VThongTinMonHocParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VThongTinMonHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VThongTinMonHocParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VThongTinMonHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VThongTinMonHocParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VThongTinMonHocParameterBuilder
	
	#region VThongTinMonHocSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VThongTinMonHoc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class VThongTinMonHocSortBuilder : SqlSortBuilder<VThongTinMonHocColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VThongTinMonHocSqlSortBuilder class.
		/// </summary>
		public VThongTinMonHocSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion VThongTinMonHocSortBuilder

} // end namespace
