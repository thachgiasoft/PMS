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
	/// Represents the DataRepository.CauHinhProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(CauHinhDataSourceDesigner))]
	public class CauHinhDataSource : ProviderDataSource<CauHinh, CauHinhKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CauHinhDataSource class.
		/// </summary>
		public CauHinhDataSource() : base(new CauHinhService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the CauHinhDataSourceView used by the CauHinhDataSource.
		/// </summary>
		protected CauHinhDataSourceView CauHinhView
		{
			get { return ( View as CauHinhDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the CauHinhDataSource control invokes to retrieve data.
		/// </summary>
		public CauHinhSelectMethod SelectMethod
		{
			get
			{
				CauHinhSelectMethod selectMethod = CauHinhSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (CauHinhSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the CauHinhDataSourceView class that is to be
		/// used by the CauHinhDataSource.
		/// </summary>
		/// <returns>An instance of the CauHinhDataSourceView class.</returns>
		protected override BaseDataSourceView<CauHinh, CauHinhKey> GetNewDataSourceView()
		{
			return new CauHinhDataSourceView(this, DefaultViewName);
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
	/// Supports the CauHinhDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class CauHinhDataSourceView : ProviderDataSourceView<CauHinh, CauHinhKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CauHinhDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the CauHinhDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public CauHinhDataSourceView(CauHinhDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal CauHinhDataSource CauHinhOwner
		{
			get { return Owner as CauHinhDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal CauHinhSelectMethod SelectMethod
		{
			get { return CauHinhOwner.SelectMethod; }
			set { CauHinhOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal CauHinhService CauHinhProvider
		{
			get { return Provider as CauHinhService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<CauHinh> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<CauHinh> results = null;
			CauHinh item;
			count = 0;
			
			System.Int32 _maCauHinh;

			switch ( SelectMethod )
			{
				case CauHinhSelectMethod.Get:
					CauHinhKey entityKey  = new CauHinhKey();
					entityKey.Load(values);
					item = CauHinhProvider.Get(entityKey);
					results = new TList<CauHinh>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case CauHinhSelectMethod.GetAll:
                    results = CauHinhProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case CauHinhSelectMethod.GetPaged:
					results = CauHinhProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case CauHinhSelectMethod.Find:
					if ( FilterParameters != null )
						results = CauHinhProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = CauHinhProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case CauHinhSelectMethod.GetByMaCauHinh:
					_maCauHinh = ( values["MaCauHinh"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaCauHinh"], typeof(System.Int32)) : (int)0;
					item = CauHinhProvider.GetByMaCauHinh(_maCauHinh);
					results = new TList<CauHinh>();
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
			if ( SelectMethod == CauHinhSelectMethod.Get || SelectMethod == CauHinhSelectMethod.GetByMaCauHinh )
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
				CauHinh entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					CauHinhProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<CauHinh> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			CauHinhProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region CauHinhDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the CauHinhDataSource class.
	/// </summary>
	public class CauHinhDataSourceDesigner : ProviderDataSourceDesigner<CauHinh, CauHinhKey>
	{
		/// <summary>
		/// Initializes a new instance of the CauHinhDataSourceDesigner class.
		/// </summary>
		public CauHinhDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public CauHinhSelectMethod SelectMethod
		{
			get { return ((CauHinhDataSource) DataSource).SelectMethod; }
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
				actions.Add(new CauHinhDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region CauHinhDataSourceActionList

	/// <summary>
	/// Supports the CauHinhDataSourceDesigner class.
	/// </summary>
	internal class CauHinhDataSourceActionList : DesignerActionList
	{
		private CauHinhDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the CauHinhDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public CauHinhDataSourceActionList(CauHinhDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public CauHinhSelectMethod SelectMethod
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

	#endregion CauHinhDataSourceActionList
	
	#endregion CauHinhDataSourceDesigner
	
	#region CauHinhSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the CauHinhDataSource.SelectMethod property.
	/// </summary>
	public enum CauHinhSelectMethod
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
		/// Represents the GetByMaCauHinh method.
		/// </summary>
		GetByMaCauHinh
	}
	
	#endregion CauHinhSelectMethod

	#region CauHinhFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CauHinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CauHinhFilter : SqlFilter<CauHinhColumn>
	{
	}
	
	#endregion CauHinhFilter

	#region CauHinhExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CauHinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CauHinhExpressionBuilder : SqlExpressionBuilder<CauHinhColumn>
	{
	}
	
	#endregion CauHinhExpressionBuilder	

	#region CauHinhProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;CauHinhChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="CauHinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CauHinhProperty : ChildEntityProperty<CauHinhChildEntityTypes>
	{
	}
	
	#endregion CauHinhProperty
}

