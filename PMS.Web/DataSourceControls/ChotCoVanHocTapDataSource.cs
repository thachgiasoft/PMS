#region Using Directives
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
	/// Represents the DataRepository.ChotCoVanHocTapProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(ChotCoVanHocTapDataSourceDesigner))]
	public class ChotCoVanHocTapDataSource : ProviderDataSource<ChotCoVanHocTap, ChotCoVanHocTapKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChotCoVanHocTapDataSource class.
		/// </summary>
		public ChotCoVanHocTapDataSource() : base(new ChotCoVanHocTapService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ChotCoVanHocTapDataSourceView used by the ChotCoVanHocTapDataSource.
		/// </summary>
		protected ChotCoVanHocTapDataSourceView ChotCoVanHocTapView
		{
			get { return ( View as ChotCoVanHocTapDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ChotCoVanHocTapDataSource control invokes to retrieve data.
		/// </summary>
		public ChotCoVanHocTapSelectMethod SelectMethod
		{
			get
			{
				ChotCoVanHocTapSelectMethod selectMethod = ChotCoVanHocTapSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ChotCoVanHocTapSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ChotCoVanHocTapDataSourceView class that is to be
		/// used by the ChotCoVanHocTapDataSource.
		/// </summary>
		/// <returns>An instance of the ChotCoVanHocTapDataSourceView class.</returns>
		protected override BaseDataSourceView<ChotCoVanHocTap, ChotCoVanHocTapKey> GetNewDataSourceView()
		{
			return new ChotCoVanHocTapDataSourceView(this, DefaultViewName);
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
	/// Supports the ChotCoVanHocTapDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ChotCoVanHocTapDataSourceView : ProviderDataSourceView<ChotCoVanHocTap, ChotCoVanHocTapKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChotCoVanHocTapDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ChotCoVanHocTapDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ChotCoVanHocTapDataSourceView(ChotCoVanHocTapDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ChotCoVanHocTapDataSource ChotCoVanHocTapOwner
		{
			get { return Owner as ChotCoVanHocTapDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal ChotCoVanHocTapSelectMethod SelectMethod
		{
			get { return ChotCoVanHocTapOwner.SelectMethod; }
			set { ChotCoVanHocTapOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ChotCoVanHocTapService ChotCoVanHocTapProvider
		{
			get { return Provider as ChotCoVanHocTapService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ChotCoVanHocTap> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<ChotCoVanHocTap> results = null;
			ChotCoVanHocTap item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case ChotCoVanHocTapSelectMethod.Get:
					ChotCoVanHocTapKey entityKey  = new ChotCoVanHocTapKey();
					entityKey.Load(values);
					item = ChotCoVanHocTapProvider.Get(entityKey);
					results = new TList<ChotCoVanHocTap>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case ChotCoVanHocTapSelectMethod.GetAll:
                    results = ChotCoVanHocTapProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ChotCoVanHocTapSelectMethod.GetPaged:
					results = ChotCoVanHocTapProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ChotCoVanHocTapSelectMethod.Find:
					if ( FilterParameters != null )
						results = ChotCoVanHocTapProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = ChotCoVanHocTapProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case ChotCoVanHocTapSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = ChotCoVanHocTapProvider.GetById(_id);
					results = new TList<ChotCoVanHocTap>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
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
			if ( SelectMethod == ChotCoVanHocTapSelectMethod.Get || SelectMethod == ChotCoVanHocTapSelectMethod.GetById )
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
				ChotCoVanHocTap entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					ChotCoVanHocTapProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<ChotCoVanHocTap> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			ChotCoVanHocTapProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region ChotCoVanHocTapDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ChotCoVanHocTapDataSource class.
	/// </summary>
	public class ChotCoVanHocTapDataSourceDesigner : ProviderDataSourceDesigner<ChotCoVanHocTap, ChotCoVanHocTapKey>
	{
		/// <summary>
		/// Initializes a new instance of the ChotCoVanHocTapDataSourceDesigner class.
		/// </summary>
		public ChotCoVanHocTapDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ChotCoVanHocTapSelectMethod SelectMethod
		{
			get { return ((ChotCoVanHocTapDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ChotCoVanHocTapDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ChotCoVanHocTapDataSourceActionList

	/// <summary>
	/// Supports the ChotCoVanHocTapDataSourceDesigner class.
	/// </summary>
	internal class ChotCoVanHocTapDataSourceActionList : DesignerActionList
	{
		private ChotCoVanHocTapDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ChotCoVanHocTapDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ChotCoVanHocTapDataSourceActionList(ChotCoVanHocTapDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ChotCoVanHocTapSelectMethod SelectMethod
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

	#endregion ChotCoVanHocTapDataSourceActionList
	
	#endregion ChotCoVanHocTapDataSourceDesigner
	
	#region ChotCoVanHocTapSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ChotCoVanHocTapDataSource.SelectMethod property.
	/// </summary>
	public enum ChotCoVanHocTapSelectMethod
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
		GetById
	}
	
	#endregion ChotCoVanHocTapSelectMethod

	#region ChotCoVanHocTapFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChotCoVanHocTap"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChotCoVanHocTapFilter : SqlFilter<ChotCoVanHocTapColumn>
	{
	}
	
	#endregion ChotCoVanHocTapFilter

	#region ChotCoVanHocTapExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChotCoVanHocTap"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChotCoVanHocTapExpressionBuilder : SqlExpressionBuilder<ChotCoVanHocTapColumn>
	{
	}
	
	#endregion ChotCoVanHocTapExpressionBuilder	

	#region ChotCoVanHocTapProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;ChotCoVanHocTapChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="ChotCoVanHocTap"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChotCoVanHocTapProperty : ChildEntityProperty<ChotCoVanHocTapChildEntityTypes>
	{
	}
	
	#endregion ChotCoVanHocTapProperty
}

