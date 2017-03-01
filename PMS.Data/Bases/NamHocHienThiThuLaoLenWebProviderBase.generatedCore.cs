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
	/// This class is the base class for any <see cref="NamHocHienThiThuLaoLenWebProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class NamHocHienThiThuLaoLenWebProviderBaseCore : EntityProviderBase<PMS.Entities.NamHocHienThiThuLaoLenWeb, PMS.Entities.NamHocHienThiThuLaoLenWebKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.NamHocHienThiThuLaoLenWebKey key)
		{
			return Delete(transactionManager, key.NamHoc, key.HocKy);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_namHoc">. Primary Key.</param>
		/// <param name="_hocKy">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _namHoc, System.String _hocKy)
		{
			return Delete(null, _namHoc, _hocKy);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_namHoc">. Primary Key.</param>
		/// <param name="_hocKy">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _namHoc, System.String _hocKy);		
		
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
		public override PMS.Entities.NamHocHienThiThuLaoLenWeb Get(TransactionManager transactionManager, PMS.Entities.NamHocHienThiThuLaoLenWebKey key, int start, int pageLength)
		{
			return GetByNamHocHocKy(transactionManager, key.NamHoc, key.HocKy, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_NamHocHienThiThuLaoLenWeb index.
		/// </summary>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NamHocHienThiThuLaoLenWeb"/> class.</returns>
		public PMS.Entities.NamHocHienThiThuLaoLenWeb GetByNamHocHocKy(System.String _namHoc, System.String _hocKy)
		{
			int count = -1;
			return GetByNamHocHocKy(null,_namHoc, _hocKy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NamHocHienThiThuLaoLenWeb index.
		/// </summary>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NamHocHienThiThuLaoLenWeb"/> class.</returns>
		public PMS.Entities.NamHocHienThiThuLaoLenWeb GetByNamHocHocKy(System.String _namHoc, System.String _hocKy, int start, int pageLength)
		{
			int count = -1;
			return GetByNamHocHocKy(null, _namHoc, _hocKy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NamHocHienThiThuLaoLenWeb index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NamHocHienThiThuLaoLenWeb"/> class.</returns>
		public PMS.Entities.NamHocHienThiThuLaoLenWeb GetByNamHocHocKy(TransactionManager transactionManager, System.String _namHoc, System.String _hocKy)
		{
			int count = -1;
			return GetByNamHocHocKy(transactionManager, _namHoc, _hocKy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NamHocHienThiThuLaoLenWeb index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NamHocHienThiThuLaoLenWeb"/> class.</returns>
		public PMS.Entities.NamHocHienThiThuLaoLenWeb GetByNamHocHocKy(TransactionManager transactionManager, System.String _namHoc, System.String _hocKy, int start, int pageLength)
		{
			int count = -1;
			return GetByNamHocHocKy(transactionManager, _namHoc, _hocKy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NamHocHienThiThuLaoLenWeb index.
		/// </summary>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NamHocHienThiThuLaoLenWeb"/> class.</returns>
		public PMS.Entities.NamHocHienThiThuLaoLenWeb GetByNamHocHocKy(System.String _namHoc, System.String _hocKy, int start, int pageLength, out int count)
		{
			return GetByNamHocHocKy(null, _namHoc, _hocKy, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NamHocHienThiThuLaoLenWeb index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_namHoc"></param>
		/// <param name="_hocKy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NamHocHienThiThuLaoLenWeb"/> class.</returns>
		public abstract PMS.Entities.NamHocHienThiThuLaoLenWeb GetByNamHocHocKy(TransactionManager transactionManager, System.String _namHoc, System.String _hocKy, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_NamHocHienThiThuLaoLenWeb_Sel 
		
		/// <summary>
		///	This method wrap the 'cust_NamHocHienThiThuLaoLenWeb_Sel' stored procedure. 
		/// </summary>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;NamHocHienThiThuLaoLenWeb&gt;"/> instance.</returns>
		public TList<NamHocHienThiThuLaoLenWeb> Sel()
		{
			return Sel(null, 0, int.MaxValue );
		}
		
		/// <summary>
		///	This method wrap the 'cust_NamHocHienThiThuLaoLenWeb_Sel' stored procedure. 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;NamHocHienThiThuLaoLenWeb&gt;"/> instance.</returns>
		public TList<NamHocHienThiThuLaoLenWeb> Sel(int start, int pageLength)
		{
			return Sel(null, start, pageLength );
		}
				
		/// <summary>
		///	This method wrap the 'cust_NamHocHienThiThuLaoLenWeb_Sel' stored procedure. 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;NamHocHienThiThuLaoLenWeb&gt;"/> instance.</returns>
		public TList<NamHocHienThiThuLaoLenWeb> Sel(TransactionManager transactionManager)
		{
			return Sel(transactionManager, 0, int.MaxValue );
		}
		
		/// <summary>
		///	This method wrap the 'cust_NamHocHienThiThuLaoLenWeb_Sel' stored procedure. 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;NamHocHienThiThuLaoLenWeb&gt;"/> instance.</returns>
		public abstract TList<NamHocHienThiThuLaoLenWeb> Sel(TransactionManager transactionManager, int start, int pageLength );
		
		#endregion
		
		#region cust_NamHocHienThiThuLaoLenWeb_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_NamHocHienThiThuLaoLenWeb_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, ref System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_NamHocHienThiThuLaoLenWeb_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, ref System.Int32 reVal)
		{
			 Luu(null, start, pageLength , xmlData, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_NamHocHienThiThuLaoLenWeb_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, ref System.Int32 reVal)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_NamHocHienThiThuLaoLenWeb_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;NamHocHienThiThuLaoLenWeb&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;NamHocHienThiThuLaoLenWeb&gt;"/></returns>
		public static TList<NamHocHienThiThuLaoLenWeb> Fill(IDataReader reader, TList<NamHocHienThiThuLaoLenWeb> rows, int start, int pageLength)
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
				
				PMS.Entities.NamHocHienThiThuLaoLenWeb c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("NamHocHienThiThuLaoLenWeb")
					.Append("|").Append((System.String)reader[((int)NamHocHienThiThuLaoLenWebColumn.NamHoc - 1)])
					.Append("|").Append((System.String)reader[((int)NamHocHienThiThuLaoLenWebColumn.HocKy - 1)]).ToString();
					c = EntityManager.LocateOrCreate<NamHocHienThiThuLaoLenWeb>(
					key.ToString(), // EntityTrackingKey
					"NamHocHienThiThuLaoLenWeb",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.NamHocHienThiThuLaoLenWeb();
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
					c.NamHoc = (System.String)reader[(NamHocHienThiThuLaoLenWebColumn.NamHoc.ToString())];
					c.OriginalNamHoc = c.NamHoc;
					c.HocKy = (System.String)reader[(NamHocHienThiThuLaoLenWebColumn.HocKy.ToString())];
					c.OriginalHocKy = c.HocKy;
					c.Chon = (reader[NamHocHienThiThuLaoLenWebColumn.Chon.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(NamHocHienThiThuLaoLenWebColumn.Chon.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.NamHocHienThiThuLaoLenWeb"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.NamHocHienThiThuLaoLenWeb"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.NamHocHienThiThuLaoLenWeb entity)
		{
			if (!reader.Read()) return;
			
			entity.NamHoc = (System.String)reader[(NamHocHienThiThuLaoLenWebColumn.NamHoc.ToString())];
			entity.OriginalNamHoc = (System.String)reader["NamHoc"];
			entity.HocKy = (System.String)reader[(NamHocHienThiThuLaoLenWebColumn.HocKy.ToString())];
			entity.OriginalHocKy = (System.String)reader["HocKy"];
			entity.Chon = (reader[NamHocHienThiThuLaoLenWebColumn.Chon.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(NamHocHienThiThuLaoLenWebColumn.Chon.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.NamHocHienThiThuLaoLenWeb"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.NamHocHienThiThuLaoLenWeb"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.NamHocHienThiThuLaoLenWeb entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.NamHoc = (System.String)dataRow["NamHoc"];
			entity.OriginalNamHoc = (System.String)dataRow["NamHoc"];
			entity.HocKy = (System.String)dataRow["HocKy"];
			entity.OriginalHocKy = (System.String)dataRow["HocKy"];
			entity.Chon = Convert.IsDBNull(dataRow["Chon"]) ? null : (System.Boolean?)dataRow["Chon"];
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
		/// <param name="entity">The <see cref="PMS.Entities.NamHocHienThiThuLaoLenWeb"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.NamHocHienThiThuLaoLenWeb Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.NamHocHienThiThuLaoLenWeb entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.NamHocHienThiThuLaoLenWeb object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.NamHocHienThiThuLaoLenWeb instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.NamHocHienThiThuLaoLenWeb Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.NamHocHienThiThuLaoLenWeb entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region NamHocHienThiThuLaoLenWebChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.NamHocHienThiThuLaoLenWeb</c>
	///</summary>
	public enum NamHocHienThiThuLaoLenWebChildEntityTypes
	{
	}
	
	#endregion NamHocHienThiThuLaoLenWebChildEntityTypes
	
	#region NamHocHienThiThuLaoLenWebFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;NamHocHienThiThuLaoLenWebColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NamHocHienThiThuLaoLenWeb"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NamHocHienThiThuLaoLenWebFilterBuilder : SqlFilterBuilder<NamHocHienThiThuLaoLenWebColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NamHocHienThiThuLaoLenWebFilterBuilder class.
		/// </summary>
		public NamHocHienThiThuLaoLenWebFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the NamHocHienThiThuLaoLenWebFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public NamHocHienThiThuLaoLenWebFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the NamHocHienThiThuLaoLenWebFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public NamHocHienThiThuLaoLenWebFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion NamHocHienThiThuLaoLenWebFilterBuilder
	
	#region NamHocHienThiThuLaoLenWebParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;NamHocHienThiThuLaoLenWebColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NamHocHienThiThuLaoLenWeb"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NamHocHienThiThuLaoLenWebParameterBuilder : ParameterizedSqlFilterBuilder<NamHocHienThiThuLaoLenWebColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NamHocHienThiThuLaoLenWebParameterBuilder class.
		/// </summary>
		public NamHocHienThiThuLaoLenWebParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the NamHocHienThiThuLaoLenWebParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public NamHocHienThiThuLaoLenWebParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the NamHocHienThiThuLaoLenWebParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public NamHocHienThiThuLaoLenWebParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion NamHocHienThiThuLaoLenWebParameterBuilder
	
	#region NamHocHienThiThuLaoLenWebSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;NamHocHienThiThuLaoLenWebColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NamHocHienThiThuLaoLenWeb"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class NamHocHienThiThuLaoLenWebSortBuilder : SqlSortBuilder<NamHocHienThiThuLaoLenWebColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NamHocHienThiThuLaoLenWebSqlSortBuilder class.
		/// </summary>
		public NamHocHienThiThuLaoLenWebSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion NamHocHienThiThuLaoLenWebSortBuilder
	
} // end namespace
