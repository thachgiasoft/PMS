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
	/// Represents the DataRepository.NamHocHienThiThuLaoLenWebProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(NamHocHienThiThuLaoLenWebDataSourceDesigner))]
	public class NamHocHienThiThuLaoLenWebDataSource : ProviderDataSource<NamHocHienThiThuLaoLenWeb, NamHocHienThiThuLaoLenWebKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NamHocHienThiThuLaoLenWebDataSource class.
		/// </summary>
		public NamHocHienThiThuLaoLenWebDataSource() : base(new NamHocHienThiThuLaoLenWebService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the NamHocHienThiThuLaoLenWebDataSourceView used by the NamHocHienThiThuLaoLenWebDataSource.
		/// </summary>
		protected NamHocHienThiThuLaoLenWebDataSourceView NamHocHienThiThuLaoLenWebView
		{
			get { return ( View as NamHocHienThiThuLaoLenWebDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the NamHocHienThiThuLaoLenWebDataSource control invokes to retrieve data.
		/// </summary>
		public NamHocHienThiThuLaoLenWebSelectMethod SelectMethod
		{
			get
			{
				NamHocHienThiThuLaoLenWebSelectMethod selectMethod = NamHocHienThiThuLaoLenWebSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (NamHocHienThiThuLaoLenWebSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the NamHocHienThiThuLaoLenWebDataSourceView class that is to be
		/// used by the NamHocHienThiThuLaoLenWebDataSource.
		/// </summary>
		/// <returns>An instance of the NamHocHienThiThuLaoLenWebDataSourceView class.</returns>
		protected override BaseDataSourceView<NamHocHienThiThuLaoLenWeb, NamHocHienThiThuLaoLenWebKey> GetNewDataSourceView()
		{
			return new NamHocHienThiThuLaoLenWebDataSourceView(this, DefaultViewName);
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
	/// Supports the NamHocHienThiThuLaoLenWebDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class NamHocHienThiThuLaoLenWebDataSourceView : ProviderDataSourceView<NamHocHienThiThuLaoLenWeb, NamHocHienThiThuLaoLenWebKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NamHocHienThiThuLaoLenWebDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the NamHocHienThiThuLaoLenWebDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public NamHocHienThiThuLaoLenWebDataSourceView(NamHocHienThiThuLaoLenWebDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal NamHocHienThiThuLaoLenWebDataSource NamHocHienThiThuLaoLenWebOwner
		{
			get { return Owner as NamHocHienThiThuLaoLenWebDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal NamHocHienThiThuLaoLenWebSelectMethod SelectMethod
		{
			get { return NamHocHienThiThuLaoLenWebOwner.SelectMethod; }
			set { NamHocHienThiThuLaoLenWebOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal NamHocHienThiThuLaoLenWebService NamHocHienThiThuLaoLenWebProvider
		{
			get { return Provider as NamHocHienThiThuLaoLenWebService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<NamHocHienThiThuLaoLenWeb> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<NamHocHienThiThuLaoLenWeb> results = null;
			NamHocHienThiThuLaoLenWeb item;
			count = 0;
			
			System.String _namHoc;
			System.String _hocKy;

			switch ( SelectMethod )
			{
				case NamHocHienThiThuLaoLenWebSelectMethod.Get:
					NamHocHienThiThuLaoLenWebKey entityKey  = new NamHocHienThiThuLaoLenWebKey();
					entityKey.Load(values);
					item = NamHocHienThiThuLaoLenWebProvider.Get(entityKey);
					results = new TList<NamHocHienThiThuLaoLenWeb>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case NamHocHienThiThuLaoLenWebSelectMethod.GetAll:
                    results = NamHocHienThiThuLaoLenWebProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case NamHocHienThiThuLaoLenWebSelectMethod.GetPaged:
					results = NamHocHienThiThuLaoLenWebProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case NamHocHienThiThuLaoLenWebSelectMethod.Find:
					if ( FilterParameters != null )
						results = NamHocHienThiThuLaoLenWebProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = NamHocHienThiThuLaoLenWebProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case NamHocHienThiThuLaoLenWebSelectMethod.GetByNamHocHocKy:
					_namHoc = ( values["NamHoc"] != null ) ? (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String)) : string.Empty;
					_hocKy = ( values["HocKy"] != null ) ? (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String)) : string.Empty;
					item = NamHocHienThiThuLaoLenWebProvider.GetByNamHocHocKy(_namHoc, _hocKy);
					results = new TList<NamHocHienThiThuLaoLenWeb>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case NamHocHienThiThuLaoLenWebSelectMethod.Sel:
					results = NamHocHienThiThuLaoLenWebProvider.Sel(StartIndex, PageSize);
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
			if ( SelectMethod == NamHocHienThiThuLaoLenWebSelectMethod.Get || SelectMethod == NamHocHienThiThuLaoLenWebSelectMethod.GetByNamHocHocKy )
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
				NamHocHienThiThuLaoLenWeb entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					NamHocHienThiThuLaoLenWebProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<NamHocHienThiThuLaoLenWeb> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			NamHocHienThiThuLaoLenWebProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region NamHocHienThiThuLaoLenWebDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the NamHocHienThiThuLaoLenWebDataSource class.
	/// </summary>
	public class NamHocHienThiThuLaoLenWebDataSourceDesigner : ProviderDataSourceDesigner<NamHocHienThiThuLaoLenWeb, NamHocHienThiThuLaoLenWebKey>
	{
		/// <summary>
		/// Initializes a new instance of the NamHocHienThiThuLaoLenWebDataSourceDesigner class.
		/// </summary>
		public NamHocHienThiThuLaoLenWebDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public NamHocHienThiThuLaoLenWebSelectMethod SelectMethod
		{
			get { return ((NamHocHienThiThuLaoLenWebDataSource) DataSource).SelectMethod; }
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
				actions.Add(new NamHocHienThiThuLaoLenWebDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region NamHocHienThiThuLaoLenWebDataSourceActionList

	/// <summary>
	/// Supports the NamHocHienThiThuLaoLenWebDataSourceDesigner class.
	/// </summary>
	internal class NamHocHienThiThuLaoLenWebDataSourceActionList : DesignerActionList
	{
		private NamHocHienThiThuLaoLenWebDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the NamHocHienThiThuLaoLenWebDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public NamHocHienThiThuLaoLenWebDataSourceActionList(NamHocHienThiThuLaoLenWebDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public NamHocHienThiThuLaoLenWebSelectMethod SelectMethod
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

	#endregion NamHocHienThiThuLaoLenWebDataSourceActionList
	
	#endregion NamHocHienThiThuLaoLenWebDataSourceDesigner
	
	#region NamHocHienThiThuLaoLenWebSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the NamHocHienThiThuLaoLenWebDataSource.SelectMethod property.
	/// </summary>
	public enum NamHocHienThiThuLaoLenWebSelectMethod
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
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy,
		/// <summary>
		/// Represents the Sel method.
		/// </summary>
		Sel
	}
	
	#endregion NamHocHienThiThuLaoLenWebSelectMethod

	#region NamHocHienThiThuLaoLenWebFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NamHocHienThiThuLaoLenWeb"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NamHocHienThiThuLaoLenWebFilter : SqlFilter<NamHocHienThiThuLaoLenWebColumn>
	{
	}
	
	#endregion NamHocHienThiThuLaoLenWebFilter

	#region NamHocHienThiThuLaoLenWebExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NamHocHienThiThuLaoLenWeb"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NamHocHienThiThuLaoLenWebExpressionBuilder : SqlExpressionBuilder<NamHocHienThiThuLaoLenWebColumn>
	{
	}
	
	#endregion NamHocHienThiThuLaoLenWebExpressionBuilder	

	#region NamHocHienThiThuLaoLenWebProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;NamHocHienThiThuLaoLenWebChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="NamHocHienThiThuLaoLenWeb"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NamHocHienThiThuLaoLenWebProperty : ChildEntityProperty<NamHocHienThiThuLaoLenWebChildEntityTypes>
	{
	}
	
	#endregion NamHocHienThiThuLaoLenWebProperty
}

