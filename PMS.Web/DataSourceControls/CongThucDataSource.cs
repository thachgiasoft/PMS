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
	/// Represents the DataRepository.CongThucProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(CongThucDataSourceDesigner))]
	public class CongThucDataSource : ProviderDataSource<CongThuc, CongThucKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CongThucDataSource class.
		/// </summary>
		public CongThucDataSource() : base(new CongThucService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the CongThucDataSourceView used by the CongThucDataSource.
		/// </summary>
		protected CongThucDataSourceView CongThucView
		{
			get { return ( View as CongThucDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the CongThucDataSource control invokes to retrieve data.
		/// </summary>
		public CongThucSelectMethod SelectMethod
		{
			get
			{
				CongThucSelectMethod selectMethod = CongThucSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (CongThucSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the CongThucDataSourceView class that is to be
		/// used by the CongThucDataSource.
		/// </summary>
		/// <returns>An instance of the CongThucDataSourceView class.</returns>
		protected override BaseDataSourceView<CongThuc, CongThucKey> GetNewDataSourceView()
		{
			return new CongThucDataSourceView(this, DefaultViewName);
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
	/// Supports the CongThucDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class CongThucDataSourceView : ProviderDataSourceView<CongThuc, CongThucKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CongThucDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the CongThucDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public CongThucDataSourceView(CongThucDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal CongThucDataSource CongThucOwner
		{
			get { return Owner as CongThucDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal CongThucSelectMethod SelectMethod
		{
			get { return CongThucOwner.SelectMethod; }
			set { CongThucOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal CongThucService CongThucProvider
		{
			get { return Provider as CongThucService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<CongThuc> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<CongThuc> results = null;
			CongThuc item;
			count = 0;
			
			System.Int32 _id;
			System.String sp37_NamHoc;

			switch ( SelectMethod )
			{
				case CongThucSelectMethod.Get:
					CongThucKey entityKey  = new CongThucKey();
					entityKey.Load(values);
					item = CongThucProvider.Get(entityKey);
					results = new TList<CongThuc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case CongThucSelectMethod.GetAll:
                    results = CongThucProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case CongThucSelectMethod.GetPaged:
					results = CongThucProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case CongThucSelectMethod.Find:
					if ( FilterParameters != null )
						results = CongThucProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = CongThucProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case CongThucSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = CongThucProvider.GetById(_id);
					results = new TList<CongThuc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case CongThucSelectMethod.GetbyNamHoc:
					sp37_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					results = CongThucProvider.GetbyNamHoc(sp37_NamHoc, StartIndex, PageSize);
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
			if ( SelectMethod == CongThucSelectMethod.Get || SelectMethod == CongThucSelectMethod.GetById )
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
				CongThuc entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					CongThucProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<CongThuc> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			CongThucProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region CongThucDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the CongThucDataSource class.
	/// </summary>
	public class CongThucDataSourceDesigner : ProviderDataSourceDesigner<CongThuc, CongThucKey>
	{
		/// <summary>
		/// Initializes a new instance of the CongThucDataSourceDesigner class.
		/// </summary>
		public CongThucDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public CongThucSelectMethod SelectMethod
		{
			get { return ((CongThucDataSource) DataSource).SelectMethod; }
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
				actions.Add(new CongThucDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region CongThucDataSourceActionList

	/// <summary>
	/// Supports the CongThucDataSourceDesigner class.
	/// </summary>
	internal class CongThucDataSourceActionList : DesignerActionList
	{
		private CongThucDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the CongThucDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public CongThucDataSourceActionList(CongThucDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public CongThucSelectMethod SelectMethod
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

	#endregion CongThucDataSourceActionList
	
	#endregion CongThucDataSourceDesigner
	
	#region CongThucSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the CongThucDataSource.SelectMethod property.
	/// </summary>
	public enum CongThucSelectMethod
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
		/// Represents the GetbyNamHoc method.
		/// </summary>
		GetbyNamHoc
	}
	
	#endregion CongThucSelectMethod

	#region CongThucFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CongThuc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CongThucFilter : SqlFilter<CongThucColumn>
	{
	}
	
	#endregion CongThucFilter

	#region CongThucExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CongThuc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CongThucExpressionBuilder : SqlExpressionBuilder<CongThucColumn>
	{
	}
	
	#endregion CongThucExpressionBuilder	

	#region CongThucProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;CongThucChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="CongThuc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CongThucProperty : ChildEntityProperty<CongThucChildEntityTypes>
	{
	}
	
	#endregion CongThucProperty
}

