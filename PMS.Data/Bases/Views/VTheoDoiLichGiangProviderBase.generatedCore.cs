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
	/// This class is the base class for any <see cref="VTheoDoiLichGiangProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class VTheoDoiLichGiangProviderBaseCore : EntityViewProviderBase<VTheoDoiLichGiang>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;VTheoDoiLichGiang&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;VTheoDoiLichGiang&gt;"/></returns>
		protected static VList&lt;VTheoDoiLichGiang&gt; Fill(DataSet dataSet, VList<VTheoDoiLichGiang> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<VTheoDoiLichGiang>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;VTheoDoiLichGiang&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<VTheoDoiLichGiang>"/></returns>
		protected static VList&lt;VTheoDoiLichGiang&gt; Fill(DataTable dataTable, VList<VTheoDoiLichGiang> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					VTheoDoiLichGiang c = new VTheoDoiLichGiang();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32)row["MaGiangVien"];
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.MaPhong = (Convert.IsDBNull(row["MaPhong"]))?string.Empty:(System.String)row["MaPhong"];
					c.MaToaNha = (Convert.IsDBNull(row["MaToaNha"]))?string.Empty:(System.String)row["MaToaNha"];
					c.MaLopHocPhan = (Convert.IsDBNull(row["MaLopHocPhan"]))?string.Empty:(System.String)row["MaLopHocPhan"];
					c.MaKhoaHoc = (Convert.IsDBNull(row["MaKhoaHoc"]))?string.Empty:(System.String)row["MaKhoaHoc"];
					c.MaMonHoc = (Convert.IsDBNull(row["MaMonHoc"]))?string.Empty:(System.String)row["MaMonHoc"];
					c.TenMonHoc = (Convert.IsDBNull(row["TenMonHoc"]))?string.Empty:(System.String)row["TenMonHoc"];
					c.NgayHoc = (Convert.IsDBNull(row["NgayHoc"]))?DateTime.MinValue:(System.DateTime?)row["NgayHoc"];
					c.NgayBatDau = (Convert.IsDBNull(row["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)row["NgayBatDau"];
					c.NgayKetThuc = (Convert.IsDBNull(row["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)row["NgayKetThuc"];
					c.TietBatDau = (Convert.IsDBNull(row["TietBatDau"]))?(int)0:(System.Int32?)row["TietBatDau"];
					c.TietKetThuc = (Convert.IsDBNull(row["TietKetThuc"]))?(int)0:(System.Int32?)row["TietKetThuc"];
					c.SoTiet = (Convert.IsDBNull(row["SoTiet"]))?(int)0:(System.Int32?)row["SoTiet"];
					c.Ngay = (Convert.IsDBNull(row["Ngay"]))?(int)0:(System.Int32?)row["Ngay"];
					c.Tuan = (Convert.IsDBNull(row["Tuan"]))?(int)0:(System.Int32?)row["Tuan"];
					c.Nam = (Convert.IsDBNull(row["Nam"]))?(int)0:(System.Int32?)row["Nam"];
					c.MaBacLoaiHinh = (Convert.IsDBNull(row["MaBacLoaiHinh"]))?string.Empty:(System.String)row["MaBacLoaiHinh"];
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
		/// Fill an <see cref="VList&lt;VTheoDoiLichGiang&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;VTheoDoiLichGiang&gt;"/></returns>
		protected VList<VTheoDoiLichGiang> Fill(IDataReader reader, VList<VTheoDoiLichGiang> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					VTheoDoiLichGiang entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<VTheoDoiLichGiang>("VTheoDoiLichGiang",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new VTheoDoiLichGiang();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = (System.Int32)reader[((int)VTheoDoiLichGiangColumn.MaGiangVien)];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
					entity.MaQuanLy = (System.String)reader[((int)VTheoDoiLichGiangColumn.MaQuanLy)];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.HoTen = (reader.IsDBNull(((int)VTheoDoiLichGiangColumn.HoTen)))?null:(System.String)reader[((int)VTheoDoiLichGiangColumn.HoTen)];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.MaPhong = (reader.IsDBNull(((int)VTheoDoiLichGiangColumn.MaPhong)))?null:(System.String)reader[((int)VTheoDoiLichGiangColumn.MaPhong)];
					//entity.MaPhong = (Convert.IsDBNull(reader["MaPhong"]))?string.Empty:(System.String)reader["MaPhong"];
					entity.MaToaNha = (reader.IsDBNull(((int)VTheoDoiLichGiangColumn.MaToaNha)))?null:(System.String)reader[((int)VTheoDoiLichGiangColumn.MaToaNha)];
					//entity.MaToaNha = (Convert.IsDBNull(reader["MaToaNha"]))?string.Empty:(System.String)reader["MaToaNha"];
					entity.MaLopHocPhan = (System.String)reader[((int)VTheoDoiLichGiangColumn.MaLopHocPhan)];
					//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
					entity.MaKhoaHoc = (System.String)reader[((int)VTheoDoiLichGiangColumn.MaKhoaHoc)];
					//entity.MaKhoaHoc = (Convert.IsDBNull(reader["MaKhoaHoc"]))?string.Empty:(System.String)reader["MaKhoaHoc"];
					entity.MaMonHoc = (System.String)reader[((int)VTheoDoiLichGiangColumn.MaMonHoc)];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.TenMonHoc = (System.String)reader[((int)VTheoDoiLichGiangColumn.TenMonHoc)];
					//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
					entity.NgayHoc = (reader.IsDBNull(((int)VTheoDoiLichGiangColumn.NgayHoc)))?null:(System.DateTime?)reader[((int)VTheoDoiLichGiangColumn.NgayHoc)];
					//entity.NgayHoc = (Convert.IsDBNull(reader["NgayHoc"]))?DateTime.MinValue:(System.DateTime?)reader["NgayHoc"];
					entity.NgayBatDau = (reader.IsDBNull(((int)VTheoDoiLichGiangColumn.NgayBatDau)))?null:(System.DateTime?)reader[((int)VTheoDoiLichGiangColumn.NgayBatDau)];
					//entity.NgayBatDau = (Convert.IsDBNull(reader["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)reader["NgayBatDau"];
					entity.NgayKetThuc = (reader.IsDBNull(((int)VTheoDoiLichGiangColumn.NgayKetThuc)))?null:(System.DateTime?)reader[((int)VTheoDoiLichGiangColumn.NgayKetThuc)];
					//entity.NgayKetThuc = (Convert.IsDBNull(reader["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKetThuc"];
					entity.TietBatDau = (reader.IsDBNull(((int)VTheoDoiLichGiangColumn.TietBatDau)))?null:(System.Int32?)reader[((int)VTheoDoiLichGiangColumn.TietBatDau)];
					//entity.TietBatDau = (Convert.IsDBNull(reader["TietBatDau"]))?(int)0:(System.Int32?)reader["TietBatDau"];
					entity.TietKetThuc = (reader.IsDBNull(((int)VTheoDoiLichGiangColumn.TietKetThuc)))?null:(System.Int32?)reader[((int)VTheoDoiLichGiangColumn.TietKetThuc)];
					//entity.TietKetThuc = (Convert.IsDBNull(reader["TietKetThuc"]))?(int)0:(System.Int32?)reader["TietKetThuc"];
					entity.SoTiet = (reader.IsDBNull(((int)VTheoDoiLichGiangColumn.SoTiet)))?null:(System.Int32?)reader[((int)VTheoDoiLichGiangColumn.SoTiet)];
					//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32?)reader["SoTiet"];
					entity.Ngay = (reader.IsDBNull(((int)VTheoDoiLichGiangColumn.Ngay)))?null:(System.Int32?)reader[((int)VTheoDoiLichGiangColumn.Ngay)];
					//entity.Ngay = (Convert.IsDBNull(reader["Ngay"]))?(int)0:(System.Int32?)reader["Ngay"];
					entity.Tuan = (reader.IsDBNull(((int)VTheoDoiLichGiangColumn.Tuan)))?null:(System.Int32?)reader[((int)VTheoDoiLichGiangColumn.Tuan)];
					//entity.Tuan = (Convert.IsDBNull(reader["Tuan"]))?(int)0:(System.Int32?)reader["Tuan"];
					entity.Nam = (reader.IsDBNull(((int)VTheoDoiLichGiangColumn.Nam)))?null:(System.Int32?)reader[((int)VTheoDoiLichGiangColumn.Nam)];
					//entity.Nam = (Convert.IsDBNull(reader["Nam"]))?(int)0:(System.Int32?)reader["Nam"];
					entity.MaBacLoaiHinh = (System.String)reader[((int)VTheoDoiLichGiangColumn.MaBacLoaiHinh)];
					//entity.MaBacLoaiHinh = (Convert.IsDBNull(reader["MaBacLoaiHinh"]))?string.Empty:(System.String)reader["MaBacLoaiHinh"];
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
		/// Refreshes the <see cref="VTheoDoiLichGiang"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="VTheoDoiLichGiang"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, VTheoDoiLichGiang entity)
		{
			reader.Read();
			entity.MaGiangVien = (System.Int32)reader[((int)VTheoDoiLichGiangColumn.MaGiangVien)];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
			entity.MaQuanLy = (System.String)reader[((int)VTheoDoiLichGiangColumn.MaQuanLy)];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.HoTen = (reader.IsDBNull(((int)VTheoDoiLichGiangColumn.HoTen)))?null:(System.String)reader[((int)VTheoDoiLichGiangColumn.HoTen)];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.MaPhong = (reader.IsDBNull(((int)VTheoDoiLichGiangColumn.MaPhong)))?null:(System.String)reader[((int)VTheoDoiLichGiangColumn.MaPhong)];
			//entity.MaPhong = (Convert.IsDBNull(reader["MaPhong"]))?string.Empty:(System.String)reader["MaPhong"];
			entity.MaToaNha = (reader.IsDBNull(((int)VTheoDoiLichGiangColumn.MaToaNha)))?null:(System.String)reader[((int)VTheoDoiLichGiangColumn.MaToaNha)];
			//entity.MaToaNha = (Convert.IsDBNull(reader["MaToaNha"]))?string.Empty:(System.String)reader["MaToaNha"];
			entity.MaLopHocPhan = (System.String)reader[((int)VTheoDoiLichGiangColumn.MaLopHocPhan)];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			entity.MaKhoaHoc = (System.String)reader[((int)VTheoDoiLichGiangColumn.MaKhoaHoc)];
			//entity.MaKhoaHoc = (Convert.IsDBNull(reader["MaKhoaHoc"]))?string.Empty:(System.String)reader["MaKhoaHoc"];
			entity.MaMonHoc = (System.String)reader[((int)VTheoDoiLichGiangColumn.MaMonHoc)];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.TenMonHoc = (System.String)reader[((int)VTheoDoiLichGiangColumn.TenMonHoc)];
			//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
			entity.NgayHoc = (reader.IsDBNull(((int)VTheoDoiLichGiangColumn.NgayHoc)))?null:(System.DateTime?)reader[((int)VTheoDoiLichGiangColumn.NgayHoc)];
			//entity.NgayHoc = (Convert.IsDBNull(reader["NgayHoc"]))?DateTime.MinValue:(System.DateTime?)reader["NgayHoc"];
			entity.NgayBatDau = (reader.IsDBNull(((int)VTheoDoiLichGiangColumn.NgayBatDau)))?null:(System.DateTime?)reader[((int)VTheoDoiLichGiangColumn.NgayBatDau)];
			//entity.NgayBatDau = (Convert.IsDBNull(reader["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)reader["NgayBatDau"];
			entity.NgayKetThuc = (reader.IsDBNull(((int)VTheoDoiLichGiangColumn.NgayKetThuc)))?null:(System.DateTime?)reader[((int)VTheoDoiLichGiangColumn.NgayKetThuc)];
			//entity.NgayKetThuc = (Convert.IsDBNull(reader["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKetThuc"];
			entity.TietBatDau = (reader.IsDBNull(((int)VTheoDoiLichGiangColumn.TietBatDau)))?null:(System.Int32?)reader[((int)VTheoDoiLichGiangColumn.TietBatDau)];
			//entity.TietBatDau = (Convert.IsDBNull(reader["TietBatDau"]))?(int)0:(System.Int32?)reader["TietBatDau"];
			entity.TietKetThuc = (reader.IsDBNull(((int)VTheoDoiLichGiangColumn.TietKetThuc)))?null:(System.Int32?)reader[((int)VTheoDoiLichGiangColumn.TietKetThuc)];
			//entity.TietKetThuc = (Convert.IsDBNull(reader["TietKetThuc"]))?(int)0:(System.Int32?)reader["TietKetThuc"];
			entity.SoTiet = (reader.IsDBNull(((int)VTheoDoiLichGiangColumn.SoTiet)))?null:(System.Int32?)reader[((int)VTheoDoiLichGiangColumn.SoTiet)];
			//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32?)reader["SoTiet"];
			entity.Ngay = (reader.IsDBNull(((int)VTheoDoiLichGiangColumn.Ngay)))?null:(System.Int32?)reader[((int)VTheoDoiLichGiangColumn.Ngay)];
			//entity.Ngay = (Convert.IsDBNull(reader["Ngay"]))?(int)0:(System.Int32?)reader["Ngay"];
			entity.Tuan = (reader.IsDBNull(((int)VTheoDoiLichGiangColumn.Tuan)))?null:(System.Int32?)reader[((int)VTheoDoiLichGiangColumn.Tuan)];
			//entity.Tuan = (Convert.IsDBNull(reader["Tuan"]))?(int)0:(System.Int32?)reader["Tuan"];
			entity.Nam = (reader.IsDBNull(((int)VTheoDoiLichGiangColumn.Nam)))?null:(System.Int32?)reader[((int)VTheoDoiLichGiangColumn.Nam)];
			//entity.Nam = (Convert.IsDBNull(reader["Nam"]))?(int)0:(System.Int32?)reader["Nam"];
			entity.MaBacLoaiHinh = (System.String)reader[((int)VTheoDoiLichGiangColumn.MaBacLoaiHinh)];
			//entity.MaBacLoaiHinh = (Convert.IsDBNull(reader["MaBacLoaiHinh"]))?string.Empty:(System.String)reader["MaBacLoaiHinh"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="VTheoDoiLichGiang"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="VTheoDoiLichGiang"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, VTheoDoiLichGiang entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32)dataRow["MaGiangVien"];
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.MaPhong = (Convert.IsDBNull(dataRow["MaPhong"]))?string.Empty:(System.String)dataRow["MaPhong"];
			entity.MaToaNha = (Convert.IsDBNull(dataRow["MaToaNha"]))?string.Empty:(System.String)dataRow["MaToaNha"];
			entity.MaLopHocPhan = (Convert.IsDBNull(dataRow["MaLopHocPhan"]))?string.Empty:(System.String)dataRow["MaLopHocPhan"];
			entity.MaKhoaHoc = (Convert.IsDBNull(dataRow["MaKhoaHoc"]))?string.Empty:(System.String)dataRow["MaKhoaHoc"];
			entity.MaMonHoc = (Convert.IsDBNull(dataRow["MaMonHoc"]))?string.Empty:(System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = (Convert.IsDBNull(dataRow["TenMonHoc"]))?string.Empty:(System.String)dataRow["TenMonHoc"];
			entity.NgayHoc = (Convert.IsDBNull(dataRow["NgayHoc"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayHoc"];
			entity.NgayBatDau = (Convert.IsDBNull(dataRow["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayBatDau"];
			entity.NgayKetThuc = (Convert.IsDBNull(dataRow["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayKetThuc"];
			entity.TietBatDau = (Convert.IsDBNull(dataRow["TietBatDau"]))?(int)0:(System.Int32?)dataRow["TietBatDau"];
			entity.TietKetThuc = (Convert.IsDBNull(dataRow["TietKetThuc"]))?(int)0:(System.Int32?)dataRow["TietKetThuc"];
			entity.SoTiet = (Convert.IsDBNull(dataRow["SoTiet"]))?(int)0:(System.Int32?)dataRow["SoTiet"];
			entity.Ngay = (Convert.IsDBNull(dataRow["Ngay"]))?(int)0:(System.Int32?)dataRow["Ngay"];
			entity.Tuan = (Convert.IsDBNull(dataRow["Tuan"]))?(int)0:(System.Int32?)dataRow["Tuan"];
			entity.Nam = (Convert.IsDBNull(dataRow["Nam"]))?(int)0:(System.Int32?)dataRow["Nam"];
			entity.MaBacLoaiHinh = (Convert.IsDBNull(dataRow["MaBacLoaiHinh"]))?string.Empty:(System.String)dataRow["MaBacLoaiHinh"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region VTheoDoiLichGiangFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VTheoDoiLichGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VTheoDoiLichGiangFilterBuilder : SqlFilterBuilder<VTheoDoiLichGiangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VTheoDoiLichGiangFilterBuilder class.
		/// </summary>
		public VTheoDoiLichGiangFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VTheoDoiLichGiangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VTheoDoiLichGiangFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VTheoDoiLichGiangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VTheoDoiLichGiangFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VTheoDoiLichGiangFilterBuilder

	#region VTheoDoiLichGiangParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VTheoDoiLichGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VTheoDoiLichGiangParameterBuilder : ParameterizedSqlFilterBuilder<VTheoDoiLichGiangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VTheoDoiLichGiangParameterBuilder class.
		/// </summary>
		public VTheoDoiLichGiangParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VTheoDoiLichGiangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VTheoDoiLichGiangParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VTheoDoiLichGiangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VTheoDoiLichGiangParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VTheoDoiLichGiangParameterBuilder
	
	#region VTheoDoiLichGiangSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VTheoDoiLichGiang"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class VTheoDoiLichGiangSortBuilder : SqlSortBuilder<VTheoDoiLichGiangColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VTheoDoiLichGiangSqlSortBuilder class.
		/// </summary>
		public VTheoDoiLichGiangSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion VTheoDoiLichGiangSortBuilder

} // end namespace
