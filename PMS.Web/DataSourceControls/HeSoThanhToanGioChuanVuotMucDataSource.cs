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
	/// Represents the DataRepository.HeSoThanhToanGioChuanVuotMucProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(HeSoThanhToanGioChuanVuotMucDataSourceDesigner))]
	public class HeSoThanhToanGioChuanVuotMucDataSource : ProviderDataSource<HeSoThanhToanGioChuanVuotMuc, HeSoThanhToanGioChuanVuotMucKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoThanhToanGioChuanVuotMucDataSource class.
		/// </summary>
		public HeSoThanhToanGioChuanVuotMucDataSource() : base(new HeSoThanhToanGioChuanVuotMucService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the HeSoThanhToanGioChuanVuotMucDataSourceView used by the HeSoThanhToanGioChuanVuotMucDataSource.
		/// </summary>
		protected HeSoThanhToanGioChuanVuotMucDataSourceView HeSoThanhToanGioChuanVuotMucView
		{
			get { return ( View as HeSoThanhToanGioChuanVuotMucDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the HeSoThanhToanGioChuanVuotMucDataSource control invokes to retrieve data.
		/// </summary>
		public HeSoThanhToanGioChuanVuotMucSelectMethod SelectMethod
		{
			get
			{
				HeSoThanhToanGioChuanVuotMucSelectMethod selectMethod = HeSoThanhToanGioChuanVuotMucSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (HeSoThanhToanGioChuanVuotMucSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the HeSoThanhToanGioChuanVuotMucDataSourceView class that is to be
		/// used by the HeSoThanhToanGioChuanVuotMucDataSource.
		/// </summary>
		/// <returns>An instance of the HeSoThanhToanGioChuanVuotMucDataSourceView class.</returns>
		protected override BaseDataSourceView<HeSoThanhToanGioChuanVuotMuc, HeSoThanhToanGioChuanVuotMucKey> GetNewDataSourceView()
		{
			return new HeSoThanhToanGioChuanVuotMucDataSourceView(this, DefaultViewName);
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
	/// Supports the HeSoThanhToanGioChuanVuotMucDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class HeSoThanhToanGioChuanVuotMucDataSourceView : ProviderDataSourceView<HeSoThanhToanGioChuanVuotMuc, HeSoThanhToanGioChuanVuotMucKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoThanhToanGioChuanVuotMucDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the HeSoThanhToanGioChuanVuotMucDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public HeSoThanhToanGioChuanVuotMucDataSourceView(HeSoThanhToanGioChuanVuotMucDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal HeSoThanhToanGioChuanVuotMucDataSource HeSoThanhToanGioChuanVuotMucOwner
		{
			get { return Owner as HeSoThanhToanGioChuanVuotMucDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal HeSoThanhToanGioChuanVuotMucSelectMethod SelectMethod
		{
			get { return HeSoThanhToanGioChuanVuotMucOwner.SelectMethod; }
			set { HeSoThanhToanGioChuanVuotMucOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal HeSoThanhToanGioChuanVuotMucService HeSoThanhToanGioChuanVuotMucProvider
		{
			get { return Provider as HeSoThanhToanGioChuanVuotMucService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<HeSoThanhToanGioChuanVuotMuc> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<HeSoThanhToanGioChuanVuotMuc> results = null;
			HeSoThanhToanGioChuanVuotMuc item;
			count = 0;
			
			System.Int32 _id;
			System.String sp319_NamHoc;
			System.String sp319_HocKy;

			switch ( SelectMethod )
			{
				case HeSoThanhToanGioChuanVuotMucSelectMethod.Get:
					HeSoThanhToanGioChuanVuotMucKey entityKey  = new HeSoThanhToanGioChuanVuotMucKey();
					entityKey.Load(values);
					item = HeSoThanhToanGioChuanVuotMucProvider.Get(entityKey);
					results = new TList<HeSoThanhToanGioChuanVuotMuc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case HeSoThanhToanGioChuanVuotMucSelectMethod.GetAll:
                    results = HeSoThanhToanGioChuanVuotMucProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case HeSoThanhToanGioChuanVuotMucSelectMethod.GetPaged:
					results = HeSoThanhToanGioChuanVuotMucProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case HeSoThanhToanGioChuanVuotMucSelectMethod.Find:
					if ( FilterParameters != null )
						results = HeSoThanhToanGioChuanVuotMucProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = HeSoThanhToanGioChuanVuotMucProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case HeSoThanhToanGioChuanVuotMucSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = HeSoThanhToanGioChuanVuotMucProvider.GetById(_id);
					results = new TList<HeSoThanhToanGioChuanVuotMuc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case HeSoThanhToanGioChuanVuotMucSelectMethod.GetByNamHocHocKy:
					sp319_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp319_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = HeSoThanhToanGioChuanVuotMucProvider.GetByNamHocHocKy(sp319_NamHoc, sp319_HocKy, StartIndex, PageSize);
					break;
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
			if ( SelectMethod == HeSoThanhToanGioChuanVuotMucSelectMethod.Get || SelectMethod == HeSoThanhToanGioChuanVuotMucSelectMethod.GetById )
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
				HeSoThanhToanGioChuanVuotMuc entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					HeSoThanhToanGioChuanVuotMucProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<HeSoThanhToanGioChuanVuotMuc> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			HeSoThanhToanGioChuanVuotMucProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region HeSoThanhToanGioChuanVuotMucDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the HeSoThanhToanGioChuanVuotMucDataSource class.
	/// </summary>
	public class HeSoThanhToanGioChuanVuotMucDataSourceDesigner : ProviderDataSourceDesigner<HeSoThanhToanGioChuanVuotMuc, HeSoThanhToanGioChuanVuotMucKey>
	{
		/// <summary>
		/// Initializes a new instance of the HeSoThanhToanGioChuanVuotMucDataSourceDesigner class.
		/// </summary>
		public HeSoThanhToanGioChuanVuotMucDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoThanhToanGioChuanVuotMucSelectMethod SelectMethod
		{
			get { return ((HeSoThanhToanGioChuanVuotMucDataSource) DataSource).SelectMethod; }
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
				actions.Add(new HeSoThanhToanGioChuanVuotMucDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region HeSoThanhToanGioChuanVuotMucDataSourceActionList

	/// <summary>
	/// Supports the HeSoThanhToanGioChuanVuotMucDataSourceDesigner class.
	/// </summary>
	internal class HeSoThanhToanGioChuanVuotMucDataSourceActionList : DesignerActionList
	{
		private HeSoThanhToanGioChuanVuotMucDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the HeSoThanhToanGioChuanVuotMucDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public HeSoThanhToanGioChuanVuotMucDataSourceActionList(HeSoThanhToanGioChuanVuotMucDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoThanhToanGioChuanVuotMucSelectMethod SelectMethod
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

	#endregion HeSoThanhToanGioChuanVuotMucDataSourceActionList
	
	#endregion HeSoThanhToanGioChuanVuotMucDataSourceDesigner
	
	#region HeSoThanhToanGioChuanVuotMucSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the HeSoThanhToanGioChuanVuotMucDataSource.SelectMethod property.
	/// </summary>
	public enum HeSoThanhToanGioChuanVuotMucSelectMethod
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
		/// Represents the GetById method.
		/// </summary>
		GetById,
		/// <summary>
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy
	}
	
	#endregion HeSoThanhToanGioChuanVuotMucSelectMethod

	#region HeSoThanhToanGioChuanVuotMucFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoThanhToanGioChuanVuotMuc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoThanhToanGioChuanVuotMucFilter : SqlFilter<HeSoThanhToanGioChuanVuotMucColumn>
	{
	}
	
	#endregion HeSoThanhToanGioChuanVuotMucFilter

	#region HeSoThanhToanGioChuanVuotMucExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoThanhToanGioChuanVuotMuc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoThanhToanGioChuanVuotMucExpressionBuilder : SqlExpressionBuilder<HeSoThanhToanGioChuanVuotMucColumn>
	{
	}
	
	#endregion HeSoThanhToanGioChuanVuotMucExpressionBuilder	

	#region HeSoThanhToanGioChuanVuotMucProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;HeSoThanhToanGioChuanVuotMucChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoThanhToanGioChuanVuotMuc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoThanhToanGioChuanVuotMucProperty : ChildEntityProperty<HeSoThanhToanGioChuanVuotMucChildEntityTypes>
	{
	}
	
	#endregion HeSoThanhToanGioChuanVuotMucProperty
}
