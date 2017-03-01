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
	/// This class is the base class for any <see cref="VwBangLuongGiangVienProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class VwBangLuongGiangVienProviderBaseCore : EntityViewProviderBase<VwBangLuongGiangVien>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;VwBangLuongGiangVien&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;VwBangLuongGiangVien&gt;"/></returns>
		protected static VList&lt;VwBangLuongGiangVien&gt; Fill(DataSet dataSet, VList<VwBangLuongGiangVien> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<VwBangLuongGiangVien>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;VwBangLuongGiangVien&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<VwBangLuongGiangVien>"/></returns>
		protected static VList&lt;VwBangLuongGiangVien&gt; Fill(DataTable dataTable, VList<VwBangLuongGiangVien> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					VwBangLuongGiangVien c = new VwBangLuongGiangVien();
					c.Ho = (Convert.IsDBNull(row["Ho"]))?string.Empty:(System.String)row["Ho"];
					c.Ten = (Convert.IsDBNull(row["Ten"]))?string.Empty:(System.String)row["Ten"];
					c.SoTaiKhoan = (Convert.IsDBNull(row["SoTaiKhoan"]))?string.Empty:(System.String)row["SoTaiKhoan"];
					c.TenLop = (Convert.IsDBNull(row["TenLop"]))?string.Empty:(System.String)row["TenLop"];
					c.MaLop = (Convert.IsDBNull(row["MaLop"]))?string.Empty:(System.String)row["MaLop"];
					c.MaMonHoc = (Convert.IsDBNull(row["MaMonHoc"]))?string.Empty:(System.String)row["MaMonHoc"];
					c.TenMonHoc = (Convert.IsDBNull(row["TenMonHoc"]))?string.Empty:(System.String)row["TenMonHoc"];
					c.NgayBatDau = (Convert.IsDBNull(row["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)row["NgayBatDau"];
					c.NgayKetThuc = (Convert.IsDBNull(row["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)row["NgayKetThuc"];
					c.SiSoLop = (Convert.IsDBNull(row["SiSoLop"]))?(int)0:(System.Int32?)row["SiSoLop"];
					c.SoTien = (Convert.IsDBNull(row["SoTien"]))?0:(System.Decimal?)row["SoTien"];
					c.MaBacDaoTao = (Convert.IsDBNull(row["MaBacDaoTao"]))?string.Empty:(System.String)row["MaBacDaoTao"];
					c.MaHeDaoTao = (Convert.IsDBNull(row["MaHeDaoTao"]))?string.Empty:(System.String)row["MaHeDaoTao"];
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?string.Empty:(System.String)row["MaGiangVien"];
					c.MaLopHocPhan = (Convert.IsDBNull(row["MaLopHocPhan"]))?string.Empty:(System.String)row["MaLopHocPhan"];
					c.SoTiet = (Convert.IsDBNull(row["SoTiet"]))?(int)0:(System.Int32?)row["SoTiet"];
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
		/// Fill an <see cref="VList&lt;VwBangLuongGiangVien&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;VwBangLuongGiangVien&gt;"/></returns>
		protected VList<VwBangLuongGiangVien> Fill(IDataReader reader, VList<VwBangLuongGiangVien> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					VwBangLuongGiangVien entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<VwBangLuongGiangVien>("VwBangLuongGiangVien",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new VwBangLuongGiangVien();
					}
					
					entity.SuppressEntityEvents = true;

					entity.Ho = (reader.IsDBNull(((int)VwBangLuongGiangVienColumn.Ho)))?null:(System.String)reader[((int)VwBangLuongGiangVienColumn.Ho)];
					//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
					entity.Ten = (reader.IsDBNull(((int)VwBangLuongGiangVienColumn.Ten)))?null:(System.String)reader[((int)VwBangLuongGiangVienColumn.Ten)];
					//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
					entity.SoTaiKhoan = (reader.IsDBNull(((int)VwBangLuongGiangVienColumn.SoTaiKhoan)))?null:(System.String)reader[((int)VwBangLuongGiangVienColumn.SoTaiKhoan)];
					//entity.SoTaiKhoan = (Convert.IsDBNull(reader["SoTaiKhoan"]))?string.Empty:(System.String)reader["SoTaiKhoan"];
					entity.TenLop = (System.String)reader[((int)VwBangLuongGiangVienColumn.TenLop)];
					//entity.TenLop = (Convert.IsDBNull(reader["TenLop"]))?string.Empty:(System.String)reader["TenLop"];
					entity.MaLop = (System.String)reader[((int)VwBangLuongGiangVienColumn.MaLop)];
					//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
					entity.MaMonHoc = (System.String)reader[((int)VwBangLuongGiangVienColumn.MaMonHoc)];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.TenMonHoc = (System.String)reader[((int)VwBangLuongGiangVienColumn.TenMonHoc)];
					//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
					entity.NgayBatDau = (reader.IsDBNull(((int)VwBangLuongGiangVienColumn.NgayBatDau)))?null:(System.DateTime?)reader[((int)VwBangLuongGiangVienColumn.NgayBatDau)];
					//entity.NgayBatDau = (Convert.IsDBNull(reader["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)reader["NgayBatDau"];
					entity.NgayKetThuc = (reader.IsDBNull(((int)VwBangLuongGiangVienColumn.NgayKetThuc)))?null:(System.DateTime?)reader[((int)VwBangLuongGiangVienColumn.NgayKetThuc)];
					//entity.NgayKetThuc = (Convert.IsDBNull(reader["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKetThuc"];
					entity.SiSoLop = (reader.IsDBNull(((int)VwBangLuongGiangVienColumn.SiSoLop)))?null:(System.Int32?)reader[((int)VwBangLuongGiangVienColumn.SiSoLop)];
					//entity.SiSoLop = (Convert.IsDBNull(reader["SiSoLop"]))?(int)0:(System.Int32?)reader["SiSoLop"];
					entity.SoTien = (reader.IsDBNull(((int)VwBangLuongGiangVienColumn.SoTien)))?null:(System.Decimal?)reader[((int)VwBangLuongGiangVienColumn.SoTien)];
					//entity.SoTien = (Convert.IsDBNull(reader["SoTien"]))?0:(System.Decimal?)reader["SoTien"];
					entity.MaBacDaoTao = (reader.IsDBNull(((int)VwBangLuongGiangVienColumn.MaBacDaoTao)))?null:(System.String)reader[((int)VwBangLuongGiangVienColumn.MaBacDaoTao)];
					//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
					entity.MaHeDaoTao = (reader.IsDBNull(((int)VwBangLuongGiangVienColumn.MaHeDaoTao)))?null:(System.String)reader[((int)VwBangLuongGiangVienColumn.MaHeDaoTao)];
					//entity.MaHeDaoTao = (Convert.IsDBNull(reader["MaHeDaoTao"]))?string.Empty:(System.String)reader["MaHeDaoTao"];
					entity.MaGiangVien = (System.String)reader[((int)VwBangLuongGiangVienColumn.MaGiangVien)];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?string.Empty:(System.String)reader["MaGiangVien"];
					entity.MaLopHocPhan = (System.String)reader[((int)VwBangLuongGiangVienColumn.MaLopHocPhan)];
					//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
					entity.SoTiet = (reader.IsDBNull(((int)VwBangLuongGiangVienColumn.SoTiet)))?null:(System.Int32?)reader[((int)VwBangLuongGiangVienColumn.SoTiet)];
					//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32?)reader["SoTiet"];
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
		/// Refreshes the <see cref="VwBangLuongGiangVien"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="VwBangLuongGiangVien"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, VwBangLuongGiangVien entity)
		{
			reader.Read();
			entity.Ho = (reader.IsDBNull(((int)VwBangLuongGiangVienColumn.Ho)))?null:(System.String)reader[((int)VwBangLuongGiangVienColumn.Ho)];
			//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
			entity.Ten = (reader.IsDBNull(((int)VwBangLuongGiangVienColumn.Ten)))?null:(System.String)reader[((int)VwBangLuongGiangVienColumn.Ten)];
			//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
			entity.SoTaiKhoan = (reader.IsDBNull(((int)VwBangLuongGiangVienColumn.SoTaiKhoan)))?null:(System.String)reader[((int)VwBangLuongGiangVienColumn.SoTaiKhoan)];
			//entity.SoTaiKhoan = (Convert.IsDBNull(reader["SoTaiKhoan"]))?string.Empty:(System.String)reader["SoTaiKhoan"];
			entity.TenLop = (System.String)reader[((int)VwBangLuongGiangVienColumn.TenLop)];
			//entity.TenLop = (Convert.IsDBNull(reader["TenLop"]))?string.Empty:(System.String)reader["TenLop"];
			entity.MaLop = (System.String)reader[((int)VwBangLuongGiangVienColumn.MaLop)];
			//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
			entity.MaMonHoc = (System.String)reader[((int)VwBangLuongGiangVienColumn.MaMonHoc)];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.TenMonHoc = (System.String)reader[((int)VwBangLuongGiangVienColumn.TenMonHoc)];
			//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
			entity.NgayBatDau = (reader.IsDBNull(((int)VwBangLuongGiangVienColumn.NgayBatDau)))?null:(System.DateTime?)reader[((int)VwBangLuongGiangVienColumn.NgayBatDau)];
			//entity.NgayBatDau = (Convert.IsDBNull(reader["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)reader["NgayBatDau"];
			entity.NgayKetThuc = (reader.IsDBNull(((int)VwBangLuongGiangVienColumn.NgayKetThuc)))?null:(System.DateTime?)reader[((int)VwBangLuongGiangVienColumn.NgayKetThuc)];
			//entity.NgayKetThuc = (Convert.IsDBNull(reader["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKetThuc"];
			entity.SiSoLop = (reader.IsDBNull(((int)VwBangLuongGiangVienColumn.SiSoLop)))?null:(System.Int32?)reader[((int)VwBangLuongGiangVienColumn.SiSoLop)];
			//entity.SiSoLop = (Convert.IsDBNull(reader["SiSoLop"]))?(int)0:(System.Int32?)reader["SiSoLop"];
			entity.SoTien = (reader.IsDBNull(((int)VwBangLuongGiangVienColumn.SoTien)))?null:(System.Decimal?)reader[((int)VwBangLuongGiangVienColumn.SoTien)];
			//entity.SoTien = (Convert.IsDBNull(reader["SoTien"]))?0:(System.Decimal?)reader["SoTien"];
			entity.MaBacDaoTao = (reader.IsDBNull(((int)VwBangLuongGiangVienColumn.MaBacDaoTao)))?null:(System.String)reader[((int)VwBangLuongGiangVienColumn.MaBacDaoTao)];
			//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
			entity.MaHeDaoTao = (reader.IsDBNull(((int)VwBangLuongGiangVienColumn.MaHeDaoTao)))?null:(System.String)reader[((int)VwBangLuongGiangVienColumn.MaHeDaoTao)];
			//entity.MaHeDaoTao = (Convert.IsDBNull(reader["MaHeDaoTao"]))?string.Empty:(System.String)reader["MaHeDaoTao"];
			entity.MaGiangVien = (System.String)reader[((int)VwBangLuongGiangVienColumn.MaGiangVien)];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?string.Empty:(System.String)reader["MaGiangVien"];
			entity.MaLopHocPhan = (System.String)reader[((int)VwBangLuongGiangVienColumn.MaLopHocPhan)];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			entity.SoTiet = (reader.IsDBNull(((int)VwBangLuongGiangVienColumn.SoTiet)))?null:(System.Int32?)reader[((int)VwBangLuongGiangVienColumn.SoTiet)];
			//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32?)reader["SoTiet"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="VwBangLuongGiangVien"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="VwBangLuongGiangVien"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, VwBangLuongGiangVien entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Ho = (Convert.IsDBNull(dataRow["Ho"]))?string.Empty:(System.String)dataRow["Ho"];
			entity.Ten = (Convert.IsDBNull(dataRow["Ten"]))?string.Empty:(System.String)dataRow["Ten"];
			entity.SoTaiKhoan = (Convert.IsDBNull(dataRow["SoTaiKhoan"]))?string.Empty:(System.String)dataRow["SoTaiKhoan"];
			entity.TenLop = (Convert.IsDBNull(dataRow["TenLop"]))?string.Empty:(System.String)dataRow["TenLop"];
			entity.MaLop = (Convert.IsDBNull(dataRow["MaLop"]))?string.Empty:(System.String)dataRow["MaLop"];
			entity.MaMonHoc = (Convert.IsDBNull(dataRow["MaMonHoc"]))?string.Empty:(System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = (Convert.IsDBNull(dataRow["TenMonHoc"]))?string.Empty:(System.String)dataRow["TenMonHoc"];
			entity.NgayBatDau = (Convert.IsDBNull(dataRow["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayBatDau"];
			entity.NgayKetThuc = (Convert.IsDBNull(dataRow["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayKetThuc"];
			entity.SiSoLop = (Convert.IsDBNull(dataRow["SiSoLop"]))?(int)0:(System.Int32?)dataRow["SiSoLop"];
			entity.SoTien = (Convert.IsDBNull(dataRow["SoTien"]))?0:(System.Decimal?)dataRow["SoTien"];
			entity.MaBacDaoTao = (Convert.IsDBNull(dataRow["MaBacDaoTao"]))?string.Empty:(System.String)dataRow["MaBacDaoTao"];
			entity.MaHeDaoTao = (Convert.IsDBNull(dataRow["MaHeDaoTao"]))?string.Empty:(System.String)dataRow["MaHeDaoTao"];
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?string.Empty:(System.String)dataRow["MaGiangVien"];
			entity.MaLopHocPhan = (Convert.IsDBNull(dataRow["MaLopHocPhan"]))?string.Empty:(System.String)dataRow["MaLopHocPhan"];
			entity.SoTiet = (Convert.IsDBNull(dataRow["SoTiet"]))?(int)0:(System.Int32?)dataRow["SoTiet"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region VwBangLuongGiangVienFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwBangLuongGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VwBangLuongGiangVienFilterBuilder : SqlFilterBuilder<VwBangLuongGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwBangLuongGiangVienFilterBuilder class.
		/// </summary>
		public VwBangLuongGiangVienFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VwBangLuongGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VwBangLuongGiangVienFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VwBangLuongGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VwBangLuongGiangVienFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VwBangLuongGiangVienFilterBuilder

	#region VwBangLuongGiangVienParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwBangLuongGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VwBangLuongGiangVienParameterBuilder : ParameterizedSqlFilterBuilder<VwBangLuongGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwBangLuongGiangVienParameterBuilder class.
		/// </summary>
		public VwBangLuongGiangVienParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VwBangLuongGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VwBangLuongGiangVienParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VwBangLuongGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VwBangLuongGiangVienParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VwBangLuongGiangVienParameterBuilder
	
	#region VwBangLuongGiangVienSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwBangLuongGiangVien"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class VwBangLuongGiangVienSortBuilder : SqlSortBuilder<VwBangLuongGiangVienColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwBangLuongGiangVienSqlSortBuilder class.
		/// </summary>
		public VwBangLuongGiangVienSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion VwBangLuongGiangVienSortBuilder

} // end namespace
