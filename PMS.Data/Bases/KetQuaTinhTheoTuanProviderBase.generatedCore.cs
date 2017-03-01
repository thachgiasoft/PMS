#region Using directives

using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;

using PMS.Entities;
using PMS.Data;

#endregion

namespace PMS.Data.Bases
{	
	///<summary>
	/// This class is the base class for any <see cref="KetQuaTinhTheoTuanProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KetQuaTinhTheoTuanProviderBaseCore : EntityProviderBase<PMS.Entities.KetQuaTinhTheoTuan, PMS.Entities.KetQuaTinhTheoTuanKey>
	{		
		#region Get from Many To Many Relationship Functions
		#endregion	
		
		#region Delete Methods

		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
		/// <param name="key">The unique identifier of the row to delete.</param>
		/// <returns>Returns true if operation suceeded.</returns>
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KetQuaTinhTheoTuanKey key)
		{
			return Delete(transactionManager, key.MaKetQua);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maKetQua">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maKetQua)
		{
			return Delete(null, _maKetQua);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKetQua">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maKetQua);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
		#endregion

		#region Get By Index Functions
		
		/// <summary>
		/// 	Gets a row from the DataSource based on its primary key.
		/// </summary>
		/// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
		/// <param name="key">The unique identifier of the row to retrieve.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <returns>Returns an instance of the Entity class.</returns>
		public override PMS.Entities.KetQuaTinhTheoTuan Get(TransactionManager transactionManager, PMS.Entities.KetQuaTinhTheoTuanKey key, int start, int pageLength)
		{
			return GetByMaKetQua(transactionManager, key.MaKetQua, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KetQuaTinhTheoTuan index.
		/// </summary>
		/// <param name="_maKetQua"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaTinhTheoTuan"/> class.</returns>
		public PMS.Entities.KetQuaTinhTheoTuan GetByMaKetQua(System.Int32 _maKetQua)
		{
			int count = -1;
			return GetByMaKetQua(null,_maKetQua, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KetQuaTinhTheoTuan index.
		/// </summary>
		/// <param name="_maKetQua"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaTinhTheoTuan"/> class.</returns>
		public PMS.Entities.KetQuaTinhTheoTuan GetByMaKetQua(System.Int32 _maKetQua, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKetQua(null, _maKetQua, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KetQuaTinhTheoTuan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKetQua"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaTinhTheoTuan"/> class.</returns>
		public PMS.Entities.KetQuaTinhTheoTuan GetByMaKetQua(TransactionManager transactionManager, System.Int32 _maKetQua)
		{
			int count = -1;
			return GetByMaKetQua(transactionManager, _maKetQua, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KetQuaTinhTheoTuan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKetQua"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaTinhTheoTuan"/> class.</returns>
		public PMS.Entities.KetQuaTinhTheoTuan GetByMaKetQua(TransactionManager transactionManager, System.Int32 _maKetQua, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKetQua(transactionManager, _maKetQua, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KetQuaTinhTheoTuan index.
		/// </summary>
		/// <param name="_maKetQua"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaTinhTheoTuan"/> class.</returns>
		public PMS.Entities.KetQuaTinhTheoTuan GetByMaKetQua(System.Int32 _maKetQua, int start, int pageLength, out int count)
		{
			return GetByMaKetQua(null, _maKetQua, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KetQuaTinhTheoTuan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKetQua"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KetQuaTinhTheoTuan"/> class.</returns>
		public abstract PMS.Entities.KetQuaTinhTheoTuan GetByMaKetQua(TransactionManager transactionManager, System.Int32 _maKetQua, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KetQuaTinhTheoTuan&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KetQuaTinhTheoTuan&gt;"/></returns>
		public static TList<KetQuaTinhTheoTuan> Fill(IDataReader reader, TList<KetQuaTinhTheoTuan> rows, int start, int pageLength)
		{
			NetTiersProvider currentProvider = DataRepository.Provider;
            bool useEntityFactory = currentProvider.UseEntityFactory;
            bool enableEntityTracking = currentProvider.EnableEntityTracking;
            LoadPolicy currentLoadPolicy = currentProvider.CurrentLoadPolicy;
			Type entityCreationFactoryType = currentProvider.EntityCreationalFactoryType;
			
			// advance to the starting row
			for (int i = 0; i < start; i++)
			{
				if (!reader.Read())
				return rows; // not enough rows, just return
			}
			for (int i = 0; i < pageLength; i++)
			{
				if (!reader.Read())
					break; // we are done
					
				string key = null;
				
				PMS.Entities.KetQuaTinhTheoTuan c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KetQuaTinhTheoTuan")
					.Append("|").Append((System.Int32)reader[((int)KetQuaTinhTheoTuanColumn.MaKetQua - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KetQuaTinhTheoTuan>(
					key.ToString(), // EntityTrackingKey
					"KetQuaTinhTheoTuan",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KetQuaTinhTheoTuan();
				}
				
				if (!enableEntityTracking ||
					c.EntityState == EntityState.Added ||
					(enableEntityTracking &&
					
						(
							(currentLoadPolicy == LoadPolicy.PreserveChanges && c.EntityState == EntityState.Unchanged) ||
							(currentLoadPolicy == LoadPolicy.DiscardChanges && c.EntityState != EntityState.Unchanged)
						)
					))
				{
					c.SuppressEntityEvents = true;
					c.MaKetQua = (System.Int32)reader[(KetQuaTinhTheoTuanColumn.MaKetQua.ToString())];
					c.MaGiangVien = (reader[KetQuaTinhTheoTuanColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KetQuaTinhTheoTuanColumn.MaGiangVien.ToString())];
					c.TietNghiaVu = (reader[KetQuaTinhTheoTuanColumn.TietNghiaVu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KetQuaTinhTheoTuanColumn.TietNghiaVu.ToString())];
					c.TietGioiHan = (reader[KetQuaTinhTheoTuanColumn.TietGioiHan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KetQuaTinhTheoTuanColumn.TietGioiHan.ToString())];
					c.NgayTao = (reader[KetQuaTinhTheoTuanColumn.NgayTao.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KetQuaTinhTheoTuanColumn.NgayTao.ToString())];
					c.Tuan = (reader[KetQuaTinhTheoTuanColumn.Tuan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KetQuaTinhTheoTuanColumn.Tuan.ToString())];
					c.Nam = (reader[KetQuaTinhTheoTuanColumn.Nam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KetQuaTinhTheoTuanColumn.Nam.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KetQuaTinhTheoTuan"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KetQuaTinhTheoTuan"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KetQuaTinhTheoTuan entity)
		{
			if (!reader.Read()) return;
			
			entity.MaKetQua = (System.Int32)reader[(KetQuaTinhTheoTuanColumn.MaKetQua.ToString())];
			entity.MaGiangVien = (reader[KetQuaTinhTheoTuanColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KetQuaTinhTheoTuanColumn.MaGiangVien.ToString())];
			entity.TietNghiaVu = (reader[KetQuaTinhTheoTuanColumn.TietNghiaVu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KetQuaTinhTheoTuanColumn.TietNghiaVu.ToString())];
			entity.TietGioiHan = (reader[KetQuaTinhTheoTuanColumn.TietGioiHan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KetQuaTinhTheoTuanColumn.TietGioiHan.ToString())];
			entity.NgayTao = (reader[KetQuaTinhTheoTuanColumn.NgayTao.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KetQuaTinhTheoTuanColumn.NgayTao.ToString())];
			entity.Tuan = (reader[KetQuaTinhTheoTuanColumn.Tuan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KetQuaTinhTheoTuanColumn.Tuan.ToString())];
			entity.Nam = (reader[KetQuaTinhTheoTuanColumn.Nam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KetQuaTinhTheoTuanColumn.Nam.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KetQuaTinhTheoTuan"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KetQuaTinhTheoTuan"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KetQuaTinhTheoTuan entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaKetQua = (System.Int32)dataRow["MaKetQua"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.Int32?)dataRow["MaGiangVien"];
			entity.TietNghiaVu = Convert.IsDBNull(dataRow["TietNghiaVu"]) ? null : (System.Int32?)dataRow["TietNghiaVu"];
			entity.TietGioiHan = Convert.IsDBNull(dataRow["TietGioiHan"]) ? null : (System.Int32?)dataRow["TietGioiHan"];
			entity.NgayTao = Convert.IsDBNull(dataRow["NgayTao"]) ? null : (System.DateTime?)dataRow["NgayTao"];
			entity.Tuan = Convert.IsDBNull(dataRow["Tuan"]) ? null : (System.Int32?)dataRow["Tuan"];
			entity.Nam = Convert.IsDBNull(dataRow["Nam"]) ? null : (System.Int32?)dataRow["Nam"];
			entity.AcceptChanges();
		}
		#endregion 
		
		#region DeepLoad Methods
		/// <summary>
		/// Deep Loads the <see cref="IEntity"/> object with criteria based of the child 
		/// property collections only N Levels Deep based on the <see cref="DeepLoadType"/>.
		/// </summary>
		/// <remarks>
		/// Use this method with caution as it is possible to DeepLoad with Recursion and traverse an entire object graph.
		/// </remarks>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="entity">The <see cref="PMS.Entities.KetQuaTinhTheoTuan"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KetQuaTinhTheoTuan Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KetQuaTinhTheoTuan entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			
			//Fire all DeepLoad Items
			foreach(KeyValuePair<Delegate, object> pair in deepHandles.Values)
		    {
                pair.Key.DynamicInvoke((object[])pair.Value);
		    }
			deepHandles = null;
		}
		
		#endregion 
		
		#region DeepSave Methods

		/// <summary>
		/// Deep Save the entire object graph of the PMS.Entities.KetQuaTinhTheoTuan object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KetQuaTinhTheoTuan instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KetQuaTinhTheoTuan Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KetQuaTinhTheoTuan entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			//Fire all DeepSave Items
			foreach(KeyValuePair<Delegate, object> pair in deepHandles.Values)
		    {
                pair.Key.DynamicInvoke((object[])pair.Value);
		    }
			
			// Save Root Entity through Provider, if not already saved in delete mode
			if (entity.IsDeleted)
				this.Save(transactionManager, entity);
				

			deepHandles = null;
						
			return true;
		}
		#endregion
	} // end class
	
	#region KetQuaTinhTheoTuanChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KetQuaTinhTheoTuan</c>
	///</summary>
	public enum KetQuaTinhTheoTuanChildEntityTypes
	{
	}
	
	#endregion KetQuaTinhTheoTuanChildEntityTypes
	
	#region KetQuaTinhTheoTuanFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KetQuaTinhTheoTuanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KetQuaTinhTheoTuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KetQuaTinhTheoTuanFilterBuilder : SqlFilterBuilder<KetQuaTinhTheoTuanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KetQuaTinhTheoTuanFilterBuilder class.
		/// </summary>
		public KetQuaTinhTheoTuanFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KetQuaTinhTheoTuanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KetQuaTinhTheoTuanFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KetQuaTinhTheoTuanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KetQuaTinhTheoTuanFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KetQuaTinhTheoTuanFilterBuilder
	
	#region KetQuaTinhTheoTuanParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KetQuaTinhTheoTuanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KetQuaTinhTheoTuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KetQuaTinhTheoTuanParameterBuilder : ParameterizedSqlFilterBuilder<KetQuaTinhTheoTuanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KetQuaTinhTheoTuanParameterBuilder class.
		/// </summary>
		public KetQuaTinhTheoTuanParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KetQuaTinhTheoTuanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KetQuaTinhTheoTuanParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KetQuaTinhTheoTuanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KetQuaTinhTheoTuanParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KetQuaTinhTheoTuanParameterBuilder
	
	#region KetQuaTinhTheoTuanSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KetQuaTinhTheoTuanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KetQuaTinhTheoTuan"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KetQuaTinhTheoTuanSortBuilder : SqlSortBuilder<KetQuaTinhTheoTuanColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KetQuaTinhTheoTuanSqlSortBuilder class.
		/// </summary>
		public KetQuaTinhTheoTuanSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KetQuaTinhTheoTuanSortBuilder
	
} // end namespace
