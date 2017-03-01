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
	/// This class is the base class for any <see cref="CongThucProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CongThucProviderBaseCore : EntityProviderBase<PMS.Entities.CongThuc, PMS.Entities.CongThucKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.CongThucKey key)
		{
			return Delete(transactionManager, key.Id);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_id">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _id)
		{
			return Delete(null, _id);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _id);		
		
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
		public override PMS.Entities.CongThuc Get(TransactionManager transactionManager, PMS.Entities.CongThucKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CongThuc index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CongThuc"/> class.</returns>
		public PMS.Entities.CongThuc GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CongThuc index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CongThuc"/> class.</returns>
		public PMS.Entities.CongThuc GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CongThuc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CongThuc"/> class.</returns>
		public PMS.Entities.CongThuc GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CongThuc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CongThuc"/> class.</returns>
		public PMS.Entities.CongThuc GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CongThuc index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CongThuc"/> class.</returns>
		public PMS.Entities.CongThuc GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CongThuc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CongThuc"/> class.</returns>
		public abstract PMS.Entities.CongThuc GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_CongThuc_GetbyNamHoc 
		
		/// <summary>
		///	This method wrap the 'cust_CongThuc_GetbyNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CongThuc&gt;"/> instance.</returns>
		public TList<CongThuc> GetbyNamHoc(System.String namHoc)
		{
			return GetbyNamHoc(null, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CongThuc_GetbyNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CongThuc&gt;"/> instance.</returns>
		public TList<CongThuc> GetbyNamHoc(int start, int pageLength, System.String namHoc)
		{
			return GetbyNamHoc(null, start, pageLength , namHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_CongThuc_GetbyNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CongThuc&gt;"/> instance.</returns>
		public TList<CongThuc> GetbyNamHoc(TransactionManager transactionManager, System.String namHoc)
		{
			return GetbyNamHoc(transactionManager, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CongThuc_GetbyNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CongThuc&gt;"/> instance.</returns>
		public abstract TList<CongThuc> GetbyNamHoc(TransactionManager transactionManager, int start, int pageLength , System.String namHoc);
		
		#endregion
		
		#region cust_CongThuc_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_CongThuc_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, System.String namHoc, ref System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , xmlData, namHoc, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CongThuc_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, System.String namHoc, ref System.Int32 reVal)
		{
			 Luu(null, start, pageLength , xmlData, namHoc, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_CongThuc_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, System.String namHoc, ref System.Int32 reVal)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, namHoc, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CongThuc_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CongThuc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CongThuc&gt;"/></returns>
		public static TList<CongThuc> Fill(IDataReader reader, TList<CongThuc> rows, int start, int pageLength)
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
				
				PMS.Entities.CongThuc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CongThuc")
					.Append("|").Append((System.Int32)reader[((int)CongThucColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<CongThuc>(
					key.ToString(), // EntityTrackingKey
					"CongThuc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.CongThuc();
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
					c.Id = (System.Int32)reader[(CongThucColumn.Id.ToString())];
					c.YearStudy = (reader[CongThucColumn.YearStudy.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucColumn.YearStudy.ToString())];
					c.Name = (reader[CongThucColumn.Name.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucColumn.Name.ToString())];
					c.Col01 = (reader[CongThucColumn.Col01.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(CongThucColumn.Col01.ToString())];
					c.Col02 = (reader[CongThucColumn.Col02.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(CongThucColumn.Col02.ToString())];
					c.Col03 = (reader[CongThucColumn.Col03.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(CongThucColumn.Col03.ToString())];
					c.Col04 = (reader[CongThucColumn.Col04.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(CongThucColumn.Col04.ToString())];
					c.Col05 = (reader[CongThucColumn.Col05.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(CongThucColumn.Col05.ToString())];
					c.Col06 = (reader[CongThucColumn.Col06.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(CongThucColumn.Col06.ToString())];
					c.Col07 = (reader[CongThucColumn.Col07.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(CongThucColumn.Col07.ToString())];
					c.Col08 = (reader[CongThucColumn.Col08.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(CongThucColumn.Col08.ToString())];
					c.UpdateDate = (reader[CongThucColumn.UpdateDate.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucColumn.UpdateDate.ToString())];
					c.UpdateStaff = (reader[CongThucColumn.UpdateStaff.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucColumn.UpdateStaff.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.CongThuc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.CongThuc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.CongThuc entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(CongThucColumn.Id.ToString())];
			entity.YearStudy = (reader[CongThucColumn.YearStudy.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucColumn.YearStudy.ToString())];
			entity.Name = (reader[CongThucColumn.Name.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucColumn.Name.ToString())];
			entity.Col01 = (reader[CongThucColumn.Col01.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(CongThucColumn.Col01.ToString())];
			entity.Col02 = (reader[CongThucColumn.Col02.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(CongThucColumn.Col02.ToString())];
			entity.Col03 = (reader[CongThucColumn.Col03.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(CongThucColumn.Col03.ToString())];
			entity.Col04 = (reader[CongThucColumn.Col04.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(CongThucColumn.Col04.ToString())];
			entity.Col05 = (reader[CongThucColumn.Col05.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(CongThucColumn.Col05.ToString())];
			entity.Col06 = (reader[CongThucColumn.Col06.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(CongThucColumn.Col06.ToString())];
			entity.Col07 = (reader[CongThucColumn.Col07.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(CongThucColumn.Col07.ToString())];
			entity.Col08 = (reader[CongThucColumn.Col08.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(CongThucColumn.Col08.ToString())];
			entity.UpdateDate = (reader[CongThucColumn.UpdateDate.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucColumn.UpdateDate.ToString())];
			entity.UpdateStaff = (reader[CongThucColumn.UpdateStaff.ToString()] == DBNull.Value) ? null : (System.String)reader[(CongThucColumn.UpdateStaff.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.CongThuc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.CongThuc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.CongThuc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.YearStudy = Convert.IsDBNull(dataRow["YearStudy"]) ? null : (System.String)dataRow["YearStudy"];
			entity.Name = Convert.IsDBNull(dataRow["Name"]) ? null : (System.String)dataRow["Name"];
			entity.Col01 = Convert.IsDBNull(dataRow["Col01"]) ? null : (System.Decimal?)dataRow["Col01"];
			entity.Col02 = Convert.IsDBNull(dataRow["Col02"]) ? null : (System.Decimal?)dataRow["Col02"];
			entity.Col03 = Convert.IsDBNull(dataRow["Col03"]) ? null : (System.Decimal?)dataRow["Col03"];
			entity.Col04 = Convert.IsDBNull(dataRow["Col04"]) ? null : (System.Decimal?)dataRow["Col04"];
			entity.Col05 = Convert.IsDBNull(dataRow["Col05"]) ? null : (System.Decimal?)dataRow["Col05"];
			entity.Col06 = Convert.IsDBNull(dataRow["Col06"]) ? null : (System.Decimal?)dataRow["Col06"];
			entity.Col07 = Convert.IsDBNull(dataRow["Col07"]) ? null : (System.Decimal?)dataRow["Col07"];
			entity.Col08 = Convert.IsDBNull(dataRow["Col08"]) ? null : (System.Decimal?)dataRow["Col08"];
			entity.UpdateDate = Convert.IsDBNull(dataRow["UpdateDate"]) ? null : (System.String)dataRow["UpdateDate"];
			entity.UpdateStaff = Convert.IsDBNull(dataRow["UpdateStaff"]) ? null : (System.String)dataRow["UpdateStaff"];
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
		/// <param name="entity">The <see cref="PMS.Entities.CongThuc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.CongThuc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.CongThuc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.CongThuc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.CongThuc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.CongThuc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.CongThuc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region CongThucChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.CongThuc</c>
	///</summary>
	public enum CongThucChildEntityTypes
	{
	}
	
	#endregion CongThucChildEntityTypes
	
	#region CongThucFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CongThucColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CongThuc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CongThucFilterBuilder : SqlFilterBuilder<CongThucColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CongThucFilterBuilder class.
		/// </summary>
		public CongThucFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CongThucFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CongThucFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CongThucFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CongThucFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CongThucFilterBuilder
	
	#region CongThucParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CongThucColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CongThuc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CongThucParameterBuilder : ParameterizedSqlFilterBuilder<CongThucColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CongThucParameterBuilder class.
		/// </summary>
		public CongThucParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CongThucParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CongThucParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CongThucParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CongThucParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CongThucParameterBuilder
	
	#region CongThucSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CongThucColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CongThuc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CongThucSortBuilder : SqlSortBuilder<CongThucColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CongThucSqlSortBuilder class.
		/// </summary>
		public CongThucSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CongThucSortBuilder
	
} // end namespace
