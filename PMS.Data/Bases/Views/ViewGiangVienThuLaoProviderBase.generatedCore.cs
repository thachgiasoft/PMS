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
	/// This class is the base class for any <see cref="ViewGiangVienThuLaoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewGiangVienThuLaoProviderBaseCore : EntityViewProviderBase<ViewGiangVienThuLao>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewGiangVienThuLao&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewGiangVienThuLao&gt;"/></returns>
		protected static VList&lt;ViewGiangVienThuLao&gt; Fill(DataSet dataSet, VList<ViewGiangVienThuLao> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewGiangVienThuLao>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewGiangVienThuLao&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewGiangVienThuLao>"/></returns>
		protected static VList&lt;ViewGiangVienThuLao&gt; Fill(DataTable dataTable, VList<ViewGiangVienThuLao> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewGiangVienThuLao c = new ViewGiangVienThuLao();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?string.Empty:(System.String)row["MaGiangVien"];
					c.MaBacDaoTao = (Convert.IsDBNull(row["MaBacDaoTao"]))?string.Empty:(System.String)row["MaBacDaoTao"];
					c.MaHeDaoTao = (Convert.IsDBNull(row["MaHeDaoTao"]))?string.Empty:(System.String)row["MaHeDaoTao"];
					c.MaVaiTroGiangDay = (Convert.IsDBNull(row["MaVaiTroGiangDay"]))?string.Empty:(System.String)row["MaVaiTroGiangDay"];
					c.ThuLaoChuan = (Convert.IsDBNull(row["ThuLaoChuan"]))?0:(System.Decimal?)row["ThuLaoChuan"];
					c.ThuLaoChuanCoHeSoChucDanh = (Convert.IsDBNull(row["ThuLaoChuanCoHeSoChucDanh"]))?0:(System.Decimal?)row["ThuLaoChuanCoHeSoChucDanh"];
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
		/// Fill an <see cref="VList&lt;ViewGiangVienThuLao&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewGiangVienThuLao&gt;"/></returns>
		protected VList<ViewGiangVienThuLao> Fill(IDataReader reader, VList<ViewGiangVienThuLao> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewGiangVienThuLao entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewGiangVienThuLao>("ViewGiangVienThuLao",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewGiangVienThuLao();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = (System.String)reader[((int)ViewGiangVienThuLaoColumn.MaGiangVien)];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?string.Empty:(System.String)reader["MaGiangVien"];
					entity.MaBacDaoTao = (System.String)reader[((int)ViewGiangVienThuLaoColumn.MaBacDaoTao)];
					//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
					entity.MaHeDaoTao = (System.String)reader[((int)ViewGiangVienThuLaoColumn.MaHeDaoTao)];
					//entity.MaHeDaoTao = (Convert.IsDBNull(reader["MaHeDaoTao"]))?string.Empty:(System.String)reader["MaHeDaoTao"];
					entity.MaVaiTroGiangDay = (System.String)reader[((int)ViewGiangVienThuLaoColumn.MaVaiTroGiangDay)];
					//entity.MaVaiTroGiangDay = (Convert.IsDBNull(reader["MaVaiTroGiangDay"]))?string.Empty:(System.String)reader["MaVaiTroGiangDay"];
					entity.ThuLaoChuan = (reader.IsDBNull(((int)ViewGiangVienThuLaoColumn.ThuLaoChuan)))?null:(System.Decimal?)reader[((int)ViewGiangVienThuLaoColumn.ThuLaoChuan)];
					//entity.ThuLaoChuan = (Convert.IsDBNull(reader["ThuLaoChuan"]))?0:(System.Decimal?)reader["ThuLaoChuan"];
					entity.ThuLaoChuanCoHeSoChucDanh = (reader.IsDBNull(((int)ViewGiangVienThuLaoColumn.ThuLaoChuanCoHeSoChucDanh)))?null:(System.Decimal?)reader[((int)ViewGiangVienThuLaoColumn.ThuLaoChuanCoHeSoChucDanh)];
					//entity.ThuLaoChuanCoHeSoChucDanh = (Convert.IsDBNull(reader["ThuLaoChuanCoHeSoChucDanh"]))?0:(System.Decimal?)reader["ThuLaoChuanCoHeSoChucDanh"];
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
		/// Refreshes the <see cref="ViewGiangVienThuLao"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewGiangVienThuLao"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewGiangVienThuLao entity)
		{
			reader.Read();
			entity.MaGiangVien = (System.String)reader[((int)ViewGiangVienThuLaoColumn.MaGiangVien)];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?string.Empty:(System.String)reader["MaGiangVien"];
			entity.MaBacDaoTao = (System.String)reader[((int)ViewGiangVienThuLaoColumn.MaBacDaoTao)];
			//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
			entity.MaHeDaoTao = (System.String)reader[((int)ViewGiangVienThuLaoColumn.MaHeDaoTao)];
			//entity.MaHeDaoTao = (Convert.IsDBNull(reader["MaHeDaoTao"]))?string.Empty:(System.String)reader["MaHeDaoTao"];
			entity.MaVaiTroGiangDay = (System.String)reader[((int)ViewGiangVienThuLaoColumn.MaVaiTroGiangDay)];
			//entity.MaVaiTroGiangDay = (Convert.IsDBNull(reader["MaVaiTroGiangDay"]))?string.Empty:(System.String)reader["MaVaiTroGiangDay"];
			entity.ThuLaoChuan = (reader.IsDBNull(((int)ViewGiangVienThuLaoColumn.ThuLaoChuan)))?null:(System.Decimal?)reader[((int)ViewGiangVienThuLaoColumn.ThuLaoChuan)];
			//entity.ThuLaoChuan = (Convert.IsDBNull(reader["ThuLaoChuan"]))?0:(System.Decimal?)reader["ThuLaoChuan"];
			entity.ThuLaoChuanCoHeSoChucDanh = (reader.IsDBNull(((int)ViewGiangVienThuLaoColumn.ThuLaoChuanCoHeSoChucDanh)))?null:(System.Decimal?)reader[((int)ViewGiangVienThuLaoColumn.ThuLaoChuanCoHeSoChucDanh)];
			//entity.ThuLaoChuanCoHeSoChucDanh = (Convert.IsDBNull(reader["ThuLaoChuanCoHeSoChucDanh"]))?0:(System.Decimal?)reader["ThuLaoChuanCoHeSoChucDanh"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewGiangVienThuLao"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewGiangVienThuLao"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewGiangVienThuLao entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?string.Empty:(System.String)dataRow["MaGiangVien"];
			entity.MaBacDaoTao = (Convert.IsDBNull(dataRow["MaBacDaoTao"]))?string.Empty:(System.String)dataRow["MaBacDaoTao"];
			entity.MaHeDaoTao = (Convert.IsDBNull(dataRow["MaHeDaoTao"]))?string.Empty:(System.String)dataRow["MaHeDaoTao"];
			entity.MaVaiTroGiangDay = (Convert.IsDBNull(dataRow["MaVaiTroGiangDay"]))?string.Empty:(System.String)dataRow["MaVaiTroGiangDay"];
			entity.ThuLaoChuan = (Convert.IsDBNull(dataRow["ThuLaoChuan"]))?0:(System.Decimal?)dataRow["ThuLaoChuan"];
			entity.ThuLaoChuanCoHeSoChucDanh = (Convert.IsDBNull(dataRow["ThuLaoChuanCoHeSoChucDanh"]))?0:(System.Decimal?)dataRow["ThuLaoChuanCoHeSoChucDanh"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewGiangVienThuLaoFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVienThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewGiangVienThuLaoFilterBuilder : SqlFilterBuilder<ViewGiangVienThuLaoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienThuLaoFilterBuilder class.
		/// </summary>
		public ViewGiangVienThuLaoFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienThuLaoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewGiangVienThuLaoFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienThuLaoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewGiangVienThuLaoFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewGiangVienThuLaoFilterBuilder

	#region ViewGiangVienThuLaoParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVienThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewGiangVienThuLaoParameterBuilder : ParameterizedSqlFilterBuilder<ViewGiangVienThuLaoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienThuLaoParameterBuilder class.
		/// </summary>
		public ViewGiangVienThuLaoParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienThuLaoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewGiangVienThuLaoParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienThuLaoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewGiangVienThuLaoParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewGiangVienThuLaoParameterBuilder
	
	#region ViewGiangVienThuLaoSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVienThuLao"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewGiangVienThuLaoSortBuilder : SqlSortBuilder<ViewGiangVienThuLaoColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienThuLaoSqlSortBuilder class.
		/// </summary>
		public ViewGiangVienThuLaoSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewGiangVienThuLaoSortBuilder

} // end namespace
