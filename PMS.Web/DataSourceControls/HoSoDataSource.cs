﻿#region Using Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Web.UI;
using System.Web.UI.Design;

using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;
using PMS.Services;
#endregion

namespace PMS.Web.Data
{
	/// <summary>
	/// Represents the DataRepository.HoSoProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(HoSoDataSourceDesigner))]
	public class HoSoDataSource : ProviderDataSource<HoSo, HoSoKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HoSoDataSource class.
		/// </summary>
		public HoSoDataSource() : base(new HoSoService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the HoSoDataSourceView used by the HoSoDataSource.
		/// </summary>
		protected HoSoDataSourceView HoSoView
		{
			get { return ( View as HoSoDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the HoSoDataSource control invokes to retrieve data.
		/// </summary>
		public HoSoSelectMethod SelectMethod
		{
			get
			{
				HoSoSelectMethod selectMethod = HoSoSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (HoSoSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the HoSoDataSourceView class that is to be
		/// used by the HoSoDataSource.
		/// </summary>
		/// <returns>An instance of the HoSoDataSourceView class.</returns>
		protected override BaseDataSourceView<HoSo, HoSoKey> GetNewDataSourceView()
		{
			return new HoSoDataSourceView(this, DefaultViewName);
		}
		
		/// <summary>
        /// Creates a cache hashing key based on the startIndex, pageSize and the SelectMethod being used.
        /// </summary>
        /// <param name="startIndex">The current start row index.</param>
        /// <param name="pageSize">The current page size.</param>
        /// <returns>A string that can be used as a key for caching purposes.</returns>
		protected override string CacheHashKey(int startIndex, int pageSize)
        {
			return String.Format("{0}:{1}:{2}", SelectMethod, startIndex, pageSize);
        }
		
		#endregion Methods
	}
	
	/// <summary>
	/// Supports the HoSoDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class HoSoDataSourceView : ProviderDataSourceView<HoSo, HoSoKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HoSoDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the HoSoDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public HoSoDataSourceView(HoSoDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal HoSoDataSource HoSoOwner
		{
			get { return Owner as HoSoDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal HoSoSelectMethod SelectMethod
		{
			get { return HoSoOwner.SelectMethod; }
			set { HoSoOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal HoSoService HoSoProvider
		{
			get { return Provider as HoSoService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<HoSo> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<HoSo> results = null;
			HoSo item;
			count = 0;
			
			System.String _maQuanLy;
			System.Int32 _maHoSo;
			System.Int32 _maGiangVien;

			switch ( SelectMethod )
			{
				case HoSoSelectMethod.Get:
					HoSoKey entityKey  = new HoSoKey();
					entityKey.Load(values);
					item = HoSoProvider.Get(entityKey);
					results = new TList<HoSo>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case HoSoSelectMethod.GetAll:
                    results = HoSoProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case HoSoSelectMethod.GetPaged:
					results = HoSoProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case HoSoSelectMethod.Find:
					if ( FilterParameters != null )
						results = HoSoProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = HoSoProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case HoSoSelectMethod.GetByMaHoSo:
					_maHoSo = ( values["MaHoSo"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaHoSo"], typeof(System.Int32)) : (int)0;
					item = HoSoProvider.GetByMaHoSo(_maHoSo);
					results = new TList<HoSo>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				case HoSoSelectMethod.GetByMaQuanLy:
					_maQuanLy = ( values["MaQuanLy"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaQuanLy"], typeof(System.String)) : string.Empty;
					item = HoSoProvider.GetByMaQuanLy(_maQuanLy);
					results = new TList<HoSo>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// FK
				// M:M
				case HoSoSelectMethod.GetByMaGiangVienFromGiangVienHoSo:
					_maGiangVien = ( values["MaGiangVien"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32)) : (int)0;
					results = HoSoProvider.GetByMaGiangVienFromGiangVienHoSo(_maGiangVien, this.StartIndex, this.PageSize, out count);
					break;
				// Custom
				default:
					break;
			}

			if ( results != null && count < 1 )
			{
				count = results.Count;

				if ( !String.IsNullOrEmpty(CustomMethodRecordCountParamName) )
				{
					object objCustomCount = EntityUtil.ChangeType(customOutput[CustomMethodRecordCountParamName], typeof(Int32));
					
					if ( objCustomCount != null )
					{
						count = (int) objCustomCount;
					}
				}
			}
			
			return results;
		}
		
		/// <summary>
		/// Gets the values of any supplied parameters for internal caching.
		/// </summary>
		/// <param name="values">An IDictionary object of name/value pairs.</param>
		protected override void GetSelectParameters(IDictionary values)
		{
			if ( SelectMethod == HoSoSelectMethod.Get || SelectMethod == HoSoSelectMethod.GetByMaHoSo )
			{
				EntityId = GetEntityKey(values);
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation for the current entity if it has
		/// not already been performed.
		/// </summary>
		internal override void DeepLoad()
		{
			if ( !IsDeepLoaded )
			{
				HoSo entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					HoSoProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
					// set loaded flag
					IsDeepLoaded = true;
				}
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation on the specified entity collection.
		/// </summary>
		/// <param name="entityList"></param>
		/// <param name="properties"></param>
		internal override void DeepLoad(TList<HoSo> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			HoSoProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region HoSoDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the HoSoDataSource class.
	/// </summary>
	public class HoSoDataSourceDesigner : ProviderDataSourceDesigner<HoSo, HoSoKey>
	{
		/// <summary>
		/// Initializes a new instance of the HoSoDataSourceDesigner class.
		/// </summary>
		public HoSoDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HoSoSelectMethod SelectMethod
		{
			get { return ((HoSoDataSource) DataSource).SelectMethod; }
			set { SetPropertyValue("SelectMethod", value); }
		}

		/// <summary>Gets the designer action list collection for this designer.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.Design.DesignerActionListCollection"/>
		/// associated with this designer.</returns>
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				DesignerActionListCollection actions = new DesignerActionListCollection();
				actions.Add(new HoSoDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region HoSoDataSourceActionList

	/// <summary>
	/// Supports the HoSoDataSourceDesigner class.
	/// </summary>
	internal class HoSoDataSourceActionList : DesignerActionList
	{
		private HoSoDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the HoSoDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public HoSoDataSourceActionList(HoSoDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HoSoSelectMethod SelectMethod
		{
			get { return _designer.SelectMethod; }
			set { _designer.SelectMethod = value; }
		}

		/// <summary>
		/// Returns the collection of <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// objects contained in the list.
		/// </summary>
		/// <returns>A <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// array that contains the items in this list.</returns>
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			DesignerActionItemCollection items = new DesignerActionItemCollection();
			items.Add(new DesignerActionPropertyItem("SelectMethod", "Select Method", "Methods"));
			return items;
		}
	}

	#endregion HoSoDataSourceActionList
	
	#endregion HoSoDataSourceDesigner
	
	#region HoSoSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the HoSoDataSource.SelectMethod property.
	/// </summary>
	public enum HoSoSelectMethod
	{
		/// <summary>
		/// Represents the Get method.
		/// </summary>
		Get,
		/// <summary>
		/// Represents the GetAll method.
		/// </summary>
		GetAll,
		/// <summary>
		/// Represents the GetPaged method.
		/// </summary>
		GetPaged,
		/// <summary>
		/// Represents the Find method.
		/// </summary>
		Find,
		/// <summary>
		/// Represents the GetByMaQuanLy method.
		/// </summary>
		GetByMaQuanLy,
		/// <summary>
		/// Represents the GetByMaHoSo method.
		/// </summary>
		GetByMaHoSo,
		/// <summary>
		/// Represents the GetByMaGiangVienFromGiangVienHoSo method.
		/// </summary>
		GetByMaGiangVienFromGiangVienHoSo
	}
	
	#endregion HoSoSelectMethod

	#region HoSoFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HoSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HoSoFilter : SqlFilter<HoSoColumn>
	{
	}
	
	#endregion HoSoFilter

	#region HoSoExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HoSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HoSoExpressionBuilder : SqlExpressionBuilder<HoSoColumn>
	{
	}
	
	#endregion HoSoExpressionBuilder	

	#region HoSoProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;HoSoChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="HoSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HoSoProperty : ChildEntityProperty<HoSoChildEntityTypes>
	{
	}
	
	#endregion HoSoProperty
}
