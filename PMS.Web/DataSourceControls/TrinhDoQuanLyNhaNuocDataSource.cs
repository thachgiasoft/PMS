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
	/// Represents the DataRepository.TrinhDoQuanLyNhaNuocProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(TrinhDoQuanLyNhaNuocDataSourceDesigner))]
	public class TrinhDoQuanLyNhaNuocDataSource : ProviderDataSource<TrinhDoQuanLyNhaNuoc, TrinhDoQuanLyNhaNuocKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrinhDoQuanLyNhaNuocDataSource class.
		/// </summary>
		public TrinhDoQuanLyNhaNuocDataSource() : base(new TrinhDoQuanLyNhaNuocService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the TrinhDoQuanLyNhaNuocDataSourceView used by the TrinhDoQuanLyNhaNuocDataSource.
		/// </summary>
		protected TrinhDoQuanLyNhaNuocDataSourceView TrinhDoQuanLyNhaNuocView
		{
			get { return ( View as TrinhDoQuanLyNhaNuocDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the TrinhDoQuanLyNhaNuocDataSource control invokes to retrieve data.
		/// </summary>
		public TrinhDoQuanLyNhaNuocSelectMethod SelectMethod
		{
			get
			{
				TrinhDoQuanLyNhaNuocSelectMethod selectMethod = TrinhDoQuanLyNhaNuocSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (TrinhDoQuanLyNhaNuocSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the TrinhDoQuanLyNhaNuocDataSourceView class that is to be
		/// used by the TrinhDoQuanLyNhaNuocDataSource.
		/// </summary>
		/// <returns>An instance of the TrinhDoQuanLyNhaNuocDataSourceView class.</returns>
		protected override BaseDataSourceView<TrinhDoQuanLyNhaNuoc, TrinhDoQuanLyNhaNuocKey> GetNewDataSourceView()
		{
			return new TrinhDoQuanLyNhaNuocDataSourceView(this, DefaultViewName);
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
	/// Supports the TrinhDoQuanLyNhaNuocDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class TrinhDoQuanLyNhaNuocDataSourceView : ProviderDataSourceView<TrinhDoQuanLyNhaNuoc, TrinhDoQuanLyNhaNuocKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrinhDoQuanLyNhaNuocDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the TrinhDoQuanLyNhaNuocDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public TrinhDoQuanLyNhaNuocDataSourceView(TrinhDoQuanLyNhaNuocDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal TrinhDoQuanLyNhaNuocDataSource TrinhDoQuanLyNhaNuocOwner
		{
			get { return Owner as TrinhDoQuanLyNhaNuocDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal TrinhDoQuanLyNhaNuocSelectMethod SelectMethod
		{
			get { return TrinhDoQuanLyNhaNuocOwner.SelectMethod; }
			set { TrinhDoQuanLyNhaNuocOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal TrinhDoQuanLyNhaNuocService TrinhDoQuanLyNhaNuocProvider
		{
			get { return Provider as TrinhDoQuanLyNhaNuocService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<TrinhDoQuanLyNhaNuoc> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<TrinhDoQuanLyNhaNuoc> results = null;
			TrinhDoQuanLyNhaNuoc item;
			count = 0;
			
			System.Int32 _maTrinhDoQuanLyNhaNuoc;

			switch ( SelectMethod )
			{
				case TrinhDoQuanLyNhaNuocSelectMethod.Get:
					TrinhDoQuanLyNhaNuocKey entityKey  = new TrinhDoQuanLyNhaNuocKey();
					entityKey.Load(values);
					item = TrinhDoQuanLyNhaNuocProvider.Get(entityKey);
					results = new TList<TrinhDoQuanLyNhaNuoc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case TrinhDoQuanLyNhaNuocSelectMethod.GetAll:
                    results = TrinhDoQuanLyNhaNuocProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case TrinhDoQuanLyNhaNuocSelectMethod.GetPaged:
					results = TrinhDoQuanLyNhaNuocProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case TrinhDoQuanLyNhaNuocSelectMethod.Find:
					if ( FilterParameters != null )
						results = TrinhDoQuanLyNhaNuocProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = TrinhDoQuanLyNhaNuocProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case TrinhDoQuanLyNhaNuocSelectMethod.GetByMaTrinhDoQuanLyNhaNuoc:
					_maTrinhDoQuanLyNhaNuoc = ( values["MaTrinhDoQuanLyNhaNuoc"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaTrinhDoQuanLyNhaNuoc"], typeof(System.Int32)) : (int)0;
					item = TrinhDoQuanLyNhaNuocProvider.GetByMaTrinhDoQuanLyNhaNuoc(_maTrinhDoQuanLyNhaNuoc);
					results = new TList<TrinhDoQuanLyNhaNuoc>();
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
			if ( SelectMethod == TrinhDoQuanLyNhaNuocSelectMethod.Get || SelectMethod == TrinhDoQuanLyNhaNuocSelectMethod.GetByMaTrinhDoQuanLyNhaNuoc )
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
				TrinhDoQuanLyNhaNuoc entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					TrinhDoQuanLyNhaNuocProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<TrinhDoQuanLyNhaNuoc> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			TrinhDoQuanLyNhaNuocProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region TrinhDoQuanLyNhaNuocDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the TrinhDoQuanLyNhaNuocDataSource class.
	/// </summary>
	public class TrinhDoQuanLyNhaNuocDataSourceDesigner : ProviderDataSourceDesigner<TrinhDoQuanLyNhaNuoc, TrinhDoQuanLyNhaNuocKey>
	{
		/// <summary>
		/// Initializes a new instance of the TrinhDoQuanLyNhaNuocDataSourceDesigner class.
		/// </summary>
		public TrinhDoQuanLyNhaNuocDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public TrinhDoQuanLyNhaNuocSelectMethod SelectMethod
		{
			get { return ((TrinhDoQuanLyNhaNuocDataSource) DataSource).SelectMethod; }
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
				actions.Add(new TrinhDoQuanLyNhaNuocDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region TrinhDoQuanLyNhaNuocDataSourceActionList

	/// <summary>
	/// Supports the TrinhDoQuanLyNhaNuocDataSourceDesigner class.
	/// </summary>
	internal class TrinhDoQuanLyNhaNuocDataSourceActionList : DesignerActionList
	{
		private TrinhDoQuanLyNhaNuocDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the TrinhDoQuanLyNhaNuocDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public TrinhDoQuanLyNhaNuocDataSourceActionList(TrinhDoQuanLyNhaNuocDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public TrinhDoQuanLyNhaNuocSelectMethod SelectMethod
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

	#endregion TrinhDoQuanLyNhaNuocDataSourceActionList
	
	#endregion TrinhDoQuanLyNhaNuocDataSourceDesigner
	
	#region TrinhDoQuanLyNhaNuocSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the TrinhDoQuanLyNhaNuocDataSource.SelectMethod property.
	/// </summary>
	public enum TrinhDoQuanLyNhaNuocSelectMethod
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
		/// Represents the GetByMaTrinhDoQuanLyNhaNuoc method.
		/// </summary>
		GetByMaTrinhDoQuanLyNhaNuoc
	}
	
	#endregion TrinhDoQuanLyNhaNuocSelectMethod

	#region TrinhDoQuanLyNhaNuocFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrinhDoQuanLyNhaNuoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrinhDoQuanLyNhaNuocFilter : SqlFilter<TrinhDoQuanLyNhaNuocColumn>
	{
	}
	
	#endregion TrinhDoQuanLyNhaNuocFilter

	#region TrinhDoQuanLyNhaNuocExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrinhDoQuanLyNhaNuoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrinhDoQuanLyNhaNuocExpressionBuilder : SqlExpressionBuilder<TrinhDoQuanLyNhaNuocColumn>
	{
	}
	
	#endregion TrinhDoQuanLyNhaNuocExpressionBuilder	

	#region TrinhDoQuanLyNhaNuocProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;TrinhDoQuanLyNhaNuocChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="TrinhDoQuanLyNhaNuoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrinhDoQuanLyNhaNuocProperty : ChildEntityProperty<TrinhDoQuanLyNhaNuocChildEntityTypes>
	{
	}
	
	#endregion TrinhDoQuanLyNhaNuocProperty
}

