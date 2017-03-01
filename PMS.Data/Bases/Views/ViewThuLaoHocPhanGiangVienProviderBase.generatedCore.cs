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
	/// This class is the base class for any <see cref="ViewThuLaoHocPhanGiangVienProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewThuLaoHocPhanGiangVienProviderBaseCore : EntityViewProviderBase<ViewThuLaoHocPhanGiangVien>
	{
		#region Custom Methods
		
		
		#region cust_View_ThuLaoHocPhan_GiangVien_GetByMaGiangVien
		
		/// <summary>
		///	This method wrap the 'cust_View_ThuLaoHocPhan_GiangVien_GetByMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaGiangVien(System.String xmlData, ref System.Int32 reVal)
		{
			return GetByMaGiangVien(null, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThuLaoHocPhan_GiangVien_GetByMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaGiangVien(int start, int pageLength, System.String xmlData, ref System.Int32 reVal)
		{
			return GetByMaGiangVien(null, start, pageLength , xmlData, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ThuLaoHocPhan_GiangVien_GetByMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaGiangVien(TransactionManager transactionManager, System.String xmlData, ref System.Int32 reVal)
		{
			return GetByMaGiangVien(transactionManager, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThuLaoHocPhan_GiangVien_GetByMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByMaGiangVien(TransactionManager transactionManager, int start, int pageLength, System.String xmlData, ref System.Int32 reVal);
		
		#endregion

		
		#region cust_View_ThuLaoHocPhan_GiangVien_GetDinhMucHocPhan
		
		/// <summary>
		///	This method wrap the 'cust_View_ThuLaoHocPhan_GiangVien_GetDinhMucHocPhan' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThuLaoHocPhanGiangVien&gt;"/> instance.</returns>
		public VList<ViewThuLaoHocPhanGiangVien> GetDinhMucHocPhan(System.Int32 maGiangVien)
		{
			return GetDinhMucHocPhan(null, 0, int.MaxValue , maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThuLaoHocPhan_GiangVien_GetDinhMucHocPhan' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThuLaoHocPhanGiangVien&gt;"/> instance.</returns>
		public VList<ViewThuLaoHocPhanGiangVien> GetDinhMucHocPhan(int start, int pageLength, System.Int32 maGiangVien)
		{
			return GetDinhMucHocPhan(null, start, pageLength , maGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ThuLaoHocPhan_GiangVien_GetDinhMucHocPhan' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewThuLaoHocPhanGiangVien&gt;"/> instance.</returns>
		public VList<ViewThuLaoHocPhanGiangVien> GetDinhMucHocPhan(TransactionManager transactionManager, System.Int32 maGiangVien)
		{
			return GetDinhMucHocPhan(transactionManager, 0, int.MaxValue , maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThuLaoHocPhan_GiangVien_GetDinhMucHocPhan' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThuLaoHocPhanGiangVien&gt;"/> instance.</returns>
		public abstract VList<ViewThuLaoHocPhanGiangVien> GetDinhMucHocPhan(TransactionManager transactionManager, int start, int pageLength, System.Int32 maGiangVien);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewThuLaoHocPhanGiangVien&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewThuLaoHocPhanGiangVien&gt;"/></returns>
		protected static VList&lt;ViewThuLaoHocPhanGiangVien&gt; Fill(DataSet dataSet, VList<ViewThuLaoHocPhanGiangVien> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewThuLaoHocPhanGiangVien>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewThuLaoHocPhanGiangVien&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewThuLaoHocPhanGiangVien>"/></returns>
		protected static VList&lt;ViewThuLaoHocPhanGiangVien&gt; Fill(DataTable dataTable, VList<ViewThuLaoHocPhanGiangVien> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewThuLaoHocPhanGiangVien c = new ViewThuLaoHocPhanGiangVien();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32?)row["MaGiangVien"];
					c.MaHeDaoTao = (Convert.IsDBNull(row["MaHeDaoTao"]))?string.Empty:(System.String)row["MaHeDaoTao"];
					c.TenHeDaoTao = (Convert.IsDBNull(row["TenHeDaoTao"]))?string.Empty:(System.String)row["TenHeDaoTao"];
					c.MaBacDaoTao = (Convert.IsDBNull(row["MaBacDaoTao"]))?string.Empty:(System.String)row["MaBacDaoTao"];
					c.TenBacDaoTao = (Convert.IsDBNull(row["TenBacDaoTao"]))?string.Empty:(System.String)row["TenBacDaoTao"];
					c.MaLoaiGiangVien = (Convert.IsDBNull(row["MaLoaiGiangVien"]))?string.Empty:(System.String)row["MaLoaiGiangVien"];
					c.TenLoaiGiangVien = (Convert.IsDBNull(row["TenLoaiGiangVien"]))?string.Empty:(System.String)row["TenLoaiGiangVien"];
					c.MaVaiTroGiangDay = (Convert.IsDBNull(row["MaVaiTroGiangDay"]))?string.Empty:(System.String)row["MaVaiTroGiangDay"];
					c.TenVaiTroGiangDay = (Convert.IsDBNull(row["TenVaiTroGiangDay"]))?string.Empty:(System.String)row["TenVaiTroGiangDay"];
					c.ThuLaoChuan = (Convert.IsDBNull(row["ThuLaoChuan"]))?(long)0:(System.Int64)row["ThuLaoChuan"];
					c.ThuLaoCoHeSoChucDanh = (Convert.IsDBNull(row["ThuLaoCoHeSoChucDanh"]))?(long)0:(System.Int64)row["ThuLaoCoHeSoChucDanh"];
					c.ThuLaoThoaThuan = (Convert.IsDBNull(row["ThuLaoThoaThuan"]))?(long)0:(System.Int64?)row["ThuLaoThoaThuan"];
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
		/// Fill an <see cref="VList&lt;ViewThuLaoHocPhanGiangVien&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewThuLaoHocPhanGiangVien&gt;"/></returns>
		protected VList<ViewThuLaoHocPhanGiangVien> Fill(IDataReader reader, VList<ViewThuLaoHocPhanGiangVien> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewThuLaoHocPhanGiangVien entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewThuLaoHocPhanGiangVien>("ViewThuLaoHocPhanGiangVien",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewThuLaoHocPhanGiangVien();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = (reader.IsDBNull(((int)ViewThuLaoHocPhanGiangVienColumn.MaGiangVien)))?null:(System.Int32?)reader[((int)ViewThuLaoHocPhanGiangVienColumn.MaGiangVien)];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32?)reader["MaGiangVien"];
					entity.MaHeDaoTao = (System.String)reader[((int)ViewThuLaoHocPhanGiangVienColumn.MaHeDaoTao)];
					//entity.MaHeDaoTao = (Convert.IsDBNull(reader["MaHeDaoTao"]))?string.Empty:(System.String)reader["MaHeDaoTao"];
					entity.TenHeDaoTao = (System.String)reader[((int)ViewThuLaoHocPhanGiangVienColumn.TenHeDaoTao)];
					//entity.TenHeDaoTao = (Convert.IsDBNull(reader["TenHeDaoTao"]))?string.Empty:(System.String)reader["TenHeDaoTao"];
					entity.MaBacDaoTao = (System.String)reader[((int)ViewThuLaoHocPhanGiangVienColumn.MaBacDaoTao)];
					//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
					entity.TenBacDaoTao = (System.String)reader[((int)ViewThuLaoHocPhanGiangVienColumn.TenBacDaoTao)];
					//entity.TenBacDaoTao = (Convert.IsDBNull(reader["TenBacDaoTao"]))?string.Empty:(System.String)reader["TenBacDaoTao"];
					entity.MaLoaiGiangVien = (System.String)reader[((int)ViewThuLaoHocPhanGiangVienColumn.MaLoaiGiangVien)];
					//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?string.Empty:(System.String)reader["MaLoaiGiangVien"];
					entity.TenLoaiGiangVien = (reader.IsDBNull(((int)ViewThuLaoHocPhanGiangVienColumn.TenLoaiGiangVien)))?null:(System.String)reader[((int)ViewThuLaoHocPhanGiangVienColumn.TenLoaiGiangVien)];
					//entity.TenLoaiGiangVien = (Convert.IsDBNull(reader["TenLoaiGiangVien"]))?string.Empty:(System.String)reader["TenLoaiGiangVien"];
					entity.MaVaiTroGiangDay = (System.String)reader[((int)ViewThuLaoHocPhanGiangVienColumn.MaVaiTroGiangDay)];
					//entity.MaVaiTroGiangDay = (Convert.IsDBNull(reader["MaVaiTroGiangDay"]))?string.Empty:(System.String)reader["MaVaiTroGiangDay"];
					entity.TenVaiTroGiangDay = (reader.IsDBNull(((int)ViewThuLaoHocPhanGiangVienColumn.TenVaiTroGiangDay)))?null:(System.String)reader[((int)ViewThuLaoHocPhanGiangVienColumn.TenVaiTroGiangDay)];
					//entity.TenVaiTroGiangDay = (Convert.IsDBNull(reader["TenVaiTroGiangDay"]))?string.Empty:(System.String)reader["TenVaiTroGiangDay"];
					entity.ThuLaoChuan = (System.Int64)reader[((int)ViewThuLaoHocPhanGiangVienColumn.ThuLaoChuan)];
					//entity.ThuLaoChuan = (Convert.IsDBNull(reader["ThuLaoChuan"]))?(long)0:(System.Int64)reader["ThuLaoChuan"];
					entity.ThuLaoCoHeSoChucDanh = (System.Int64)reader[((int)ViewThuLaoHocPhanGiangVienColumn.ThuLaoCoHeSoChucDanh)];
					//entity.ThuLaoCoHeSoChucDanh = (Convert.IsDBNull(reader["ThuLaoCoHeSoChucDanh"]))?(long)0:(System.Int64)reader["ThuLaoCoHeSoChucDanh"];
					entity.ThuLaoThoaThuan = (reader.IsDBNull(((int)ViewThuLaoHocPhanGiangVienColumn.ThuLaoThoaThuan)))?null:(System.Int64?)reader[((int)ViewThuLaoHocPhanGiangVienColumn.ThuLaoThoaThuan)];
					//entity.ThuLaoThoaThuan = (Convert.IsDBNull(reader["ThuLaoThoaThuan"]))?(long)0:(System.Int64?)reader["ThuLaoThoaThuan"];
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
		/// Refreshes the <see cref="ViewThuLaoHocPhanGiangVien"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThuLaoHocPhanGiangVien"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewThuLaoHocPhanGiangVien entity)
		{
			reader.Read();
			entity.MaGiangVien = (reader.IsDBNull(((int)ViewThuLaoHocPhanGiangVienColumn.MaGiangVien)))?null:(System.Int32?)reader[((int)ViewThuLaoHocPhanGiangVienColumn.MaGiangVien)];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32?)reader["MaGiangVien"];
			entity.MaHeDaoTao = (System.String)reader[((int)ViewThuLaoHocPhanGiangVienColumn.MaHeDaoTao)];
			//entity.MaHeDaoTao = (Convert.IsDBNull(reader["MaHeDaoTao"]))?string.Empty:(System.String)reader["MaHeDaoTao"];
			entity.TenHeDaoTao = (System.String)reader[((int)ViewThuLaoHocPhanGiangVienColumn.TenHeDaoTao)];
			//entity.TenHeDaoTao = (Convert.IsDBNull(reader["TenHeDaoTao"]))?string.Empty:(System.String)reader["TenHeDaoTao"];
			entity.MaBacDaoTao = (System.String)reader[((int)ViewThuLaoHocPhanGiangVienColumn.MaBacDaoTao)];
			//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
			entity.TenBacDaoTao = (System.String)reader[((int)ViewThuLaoHocPhanGiangVienColumn.TenBacDaoTao)];
			//entity.TenBacDaoTao = (Convert.IsDBNull(reader["TenBacDaoTao"]))?string.Empty:(System.String)reader["TenBacDaoTao"];
			entity.MaLoaiGiangVien = (System.String)reader[((int)ViewThuLaoHocPhanGiangVienColumn.MaLoaiGiangVien)];
			//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?string.Empty:(System.String)reader["MaLoaiGiangVien"];
			entity.TenLoaiGiangVien = (reader.IsDBNull(((int)ViewThuLaoHocPhanGiangVienColumn.TenLoaiGiangVien)))?null:(System.String)reader[((int)ViewThuLaoHocPhanGiangVienColumn.TenLoaiGiangVien)];
			//entity.TenLoaiGiangVien = (Convert.IsDBNull(reader["TenLoaiGiangVien"]))?string.Empty:(System.String)reader["TenLoaiGiangVien"];
			entity.MaVaiTroGiangDay = (System.String)reader[((int)ViewThuLaoHocPhanGiangVienColumn.MaVaiTroGiangDay)];
			//entity.MaVaiTroGiangDay = (Convert.IsDBNull(reader["MaVaiTroGiangDay"]))?string.Empty:(System.String)reader["MaVaiTroGiangDay"];
			entity.TenVaiTroGiangDay = (reader.IsDBNull(((int)ViewThuLaoHocPhanGiangVienColumn.TenVaiTroGiangDay)))?null:(System.String)reader[((int)ViewThuLaoHocPhanGiangVienColumn.TenVaiTroGiangDay)];
			//entity.TenVaiTroGiangDay = (Convert.IsDBNull(reader["TenVaiTroGiangDay"]))?string.Empty:(System.String)reader["TenVaiTroGiangDay"];
			entity.ThuLaoChuan = (System.Int64)reader[((int)ViewThuLaoHocPhanGiangVienColumn.ThuLaoChuan)];
			//entity.ThuLaoChuan = (Convert.IsDBNull(reader["ThuLaoChuan"]))?(long)0:(System.Int64)reader["ThuLaoChuan"];
			entity.ThuLaoCoHeSoChucDanh = (System.Int64)reader[((int)ViewThuLaoHocPhanGiangVienColumn.ThuLaoCoHeSoChucDanh)];
			//entity.ThuLaoCoHeSoChucDanh = (Convert.IsDBNull(reader["ThuLaoCoHeSoChucDanh"]))?(long)0:(System.Int64)reader["ThuLaoCoHeSoChucDanh"];
			entity.ThuLaoThoaThuan = (reader.IsDBNull(((int)ViewThuLaoHocPhanGiangVienColumn.ThuLaoThoaThuan)))?null:(System.Int64?)reader[((int)ViewThuLaoHocPhanGiangVienColumn.ThuLaoThoaThuan)];
			//entity.ThuLaoThoaThuan = (Convert.IsDBNull(reader["ThuLaoThoaThuan"]))?(long)0:(System.Int64?)reader["ThuLaoThoaThuan"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewThuLaoHocPhanGiangVien"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThuLaoHocPhanGiangVien"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewThuLaoHocPhanGiangVien entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32?)dataRow["MaGiangVien"];
			entity.MaHeDaoTao = (Convert.IsDBNull(dataRow["MaHeDaoTao"]))?string.Empty:(System.String)dataRow["MaHeDaoTao"];
			entity.TenHeDaoTao = (Convert.IsDBNull(dataRow["TenHeDaoTao"]))?string.Empty:(System.String)dataRow["TenHeDaoTao"];
			entity.MaBacDaoTao = (Convert.IsDBNull(dataRow["MaBacDaoTao"]))?string.Empty:(System.String)dataRow["MaBacDaoTao"];
			entity.TenBacDaoTao = (Convert.IsDBNull(dataRow["TenBacDaoTao"]))?string.Empty:(System.String)dataRow["TenBacDaoTao"];
			entity.MaLoaiGiangVien = (Convert.IsDBNull(dataRow["MaLoaiGiangVien"]))?string.Empty:(System.String)dataRow["MaLoaiGiangVien"];
			entity.TenLoaiGiangVien = (Convert.IsDBNull(dataRow["TenLoaiGiangVien"]))?string.Empty:(System.String)dataRow["TenLoaiGiangVien"];
			entity.MaVaiTroGiangDay = (Convert.IsDBNull(dataRow["MaVaiTroGiangDay"]))?string.Empty:(System.String)dataRow["MaVaiTroGiangDay"];
			entity.TenVaiTroGiangDay = (Convert.IsDBNull(dataRow["TenVaiTroGiangDay"]))?string.Empty:(System.String)dataRow["TenVaiTroGiangDay"];
			entity.ThuLaoChuan = (Convert.IsDBNull(dataRow["ThuLaoChuan"]))?(long)0:(System.Int64)dataRow["ThuLaoChuan"];
			entity.ThuLaoCoHeSoChucDanh = (Convert.IsDBNull(dataRow["ThuLaoCoHeSoChucDanh"]))?(long)0:(System.Int64)dataRow["ThuLaoCoHeSoChucDanh"];
			entity.ThuLaoThoaThuan = (Convert.IsDBNull(dataRow["ThuLaoThoaThuan"]))?(long)0:(System.Int64?)dataRow["ThuLaoThoaThuan"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewThuLaoHocPhanGiangVienFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThuLaoHocPhanGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThuLaoHocPhanGiangVienFilterBuilder : SqlFilterBuilder<ViewThuLaoHocPhanGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThuLaoHocPhanGiangVienFilterBuilder class.
		/// </summary>
		public ViewThuLaoHocPhanGiangVienFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThuLaoHocPhanGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThuLaoHocPhanGiangVienFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThuLaoHocPhanGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThuLaoHocPhanGiangVienFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThuLaoHocPhanGiangVienFilterBuilder

	#region ViewThuLaoHocPhanGiangVienParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThuLaoHocPhanGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThuLaoHocPhanGiangVienParameterBuilder : ParameterizedSqlFilterBuilder<ViewThuLaoHocPhanGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThuLaoHocPhanGiangVienParameterBuilder class.
		/// </summary>
		public ViewThuLaoHocPhanGiangVienParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThuLaoHocPhanGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThuLaoHocPhanGiangVienParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThuLaoHocPhanGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThuLaoHocPhanGiangVienParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThuLaoHocPhanGiangVienParameterBuilder
	
	#region ViewThuLaoHocPhanGiangVienSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThuLaoHocPhanGiangVien"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewThuLaoHocPhanGiangVienSortBuilder : SqlSortBuilder<ViewThuLaoHocPhanGiangVienColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThuLaoHocPhanGiangVienSqlSortBuilder class.
		/// </summary>
		public ViewThuLaoHocPhanGiangVienSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewThuLaoHocPhanGiangVienSortBuilder

} // end namespace
