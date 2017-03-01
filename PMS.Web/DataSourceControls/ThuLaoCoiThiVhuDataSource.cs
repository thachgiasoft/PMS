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
	/// Represents the DataRepository.ThuLaoCoiThiVhuProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(ThuLaoCoiThiVhuDataSourceDesigner))]
	public class ThuLaoCoiThiVhuDataSource : ProviderDataSource<ThuLaoCoiThiVhu, ThuLaoCoiThiVhuKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiVhuDataSource class.
		/// </summary>
		public ThuLaoCoiThiVhuDataSource() : base(new ThuLaoCoiThiVhuService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ThuLaoCoiThiVhuDataSourceView used by the ThuLaoCoiThiVhuDataSource.
		/// </summary>
		protected ThuLaoCoiThiVhuDataSourceView ThuLaoCoiThiVhuView
		{
			get { return ( View as ThuLaoCoiThiVhuDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ThuLaoCoiThiVhuDataSource control invokes to retrieve data.
		/// </summary>
		public ThuLaoCoiThiVhuSelectMethod SelectMethod
		{
			get
			{
				ThuLaoCoiThiVhuSelectMethod selectMethod = ThuLaoCoiThiVhuSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ThuLaoCoiThiVhuSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ThuLaoCoiThiVhuDataSourceView class that is to be
		/// used by the ThuLaoCoiThiVhuDataSource.
		/// </summary>
		/// <returns>An instance of the ThuLaoCoiThiVhuDataSourceView class.</returns>
		protected override BaseDataSourceView<ThuLaoCoiThiVhu, ThuLaoCoiThiVhuKey> GetNewDataSourceView()
		{
			return new ThuLaoCoiThiVhuDataSourceView(this, DefaultViewName);
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
	/// Supports the ThuLaoCoiThiVhuDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ThuLaoCoiThiVhuDataSourceView : ProviderDataSourceView<ThuLaoCoiThiVhu, ThuLaoCoiThiVhuKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiVhuDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ThuLaoCoiThiVhuDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ThuLaoCoiThiVhuDataSourceView(ThuLaoCoiThiVhuDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ThuLaoCoiThiVhuDataSource ThuLaoCoiThiVhuOwner
		{
			get { return Owner as ThuLaoCoiThiVhuDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal ThuLaoCoiThiVhuSelectMethod SelectMethod
		{
			get { return ThuLaoCoiThiVhuOwner.SelectMethod; }
			set { ThuLaoCoiThiVhuOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ThuLaoCoiThiVhuService ThuLaoCoiThiVhuProvider
		{
			get { return Provider as ThuLaoCoiThiVhuService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ThuLaoCoiThiVhu> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<ThuLaoCoiThiVhu> results = null;
			ThuLaoCoiThiVhu item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case ThuLaoCoiThiVhuSelectMethod.Get:
					ThuLaoCoiThiVhuKey entityKey  = new ThuLaoCoiThiVhuKey();
					entityKey.Load(values);
					item = ThuLaoCoiThiVhuProvider.Get(entityKey);
					results = new TList<ThuLaoCoiThiVhu>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case ThuLaoCoiThiVhuSelectMethod.GetAll:
                    results = ThuLaoCoiThiVhuProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ThuLaoCoiThiVhuSelectMethod.GetPaged:
					results = ThuLaoCoiThiVhuProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ThuLaoCoiThiVhuSelectMethod.Find:
					if ( FilterParameters != null )
						results = ThuLaoCoiThiVhuProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = ThuLaoCoiThiVhuProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case ThuLaoCoiThiVhuSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = ThuLaoCoiThiVhuProvider.GetById(_id);
					results = new TList<ThuLaoCoiThiVhu>();
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
			if ( SelectMethod == ThuLaoCoiThiVhuSelectMethod.Get || SelectMethod == ThuLaoCoiThiVhuSelectMethod.GetById )
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
				ThuLaoCoiThiVhu entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					ThuLaoCoiThiVhuProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<ThuLaoCoiThiVhu> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			ThuLaoCoiThiVhuProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region ThuLaoCoiThiVhuDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ThuLaoCoiThiVhuDataSource class.
	/// </summary>
	public class ThuLaoCoiThiVhuDataSourceDesigner : ProviderDataSourceDesigner<ThuLaoCoiThiVhu, ThuLaoCoiThiVhuKey>
	{
		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiVhuDataSourceDesigner class.
		/// </summary>
		public ThuLaoCoiThiVhuDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThuLaoCoiThiVhuSelectMethod SelectMethod
		{
			get { return ((ThuLaoCoiThiVhuDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ThuLaoCoiThiVhuDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ThuLaoCoiThiVhuDataSourceActionList

	/// <summary>
	/// Supports the ThuLaoCoiThiVhuDataSourceDesigner class.
	/// </summary>
	internal class ThuLaoCoiThiVhuDataSourceActionList : DesignerActionList
	{
		private ThuLaoCoiThiVhuDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiVhuDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ThuLaoCoiThiVhuDataSourceActionList(ThuLaoCoiThiVhuDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThuLaoCoiThiVhuSelectMethod SelectMethod
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

	#endregion ThuLaoCoiThiVhuDataSourceActionList
	
	#endregion ThuLaoCoiThiVhuDataSourceDesigner
	
	#region ThuLaoCoiThiVhuSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ThuLaoCoiThiVhuDataSource.SelectMethod property.
	/// </summary>
	public enum ThuLaoCoiThiVhuSelectMethod
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
	
	#endregion ThuLaoCoiThiVhuSelectMethod

	#region ThuLaoCoiThiVhuFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoCoiThiVhu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoCoiThiVhuFilter : SqlFilter<ThuLaoCoiThiVhuColumn>
	{
	}
	
	#endregion ThuLaoCoiThiVhuFilter

	#region ThuLaoCoiThiVhuExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoCoiThiVhu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoCoiThiVhuExpressionBuilder : SqlExpressionBuilder<ThuLaoCoiThiVhuColumn>
	{
	}
	
	#endregion ThuLaoCoiThiVhuExpressionBuilder	

	#region ThuLaoCoiThiVhuProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;ThuLaoCoiThiVhuChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoCoiThiVhu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoCoiThiVhuProperty : ChildEntityProperty<ThuLaoCoiThiVhuChildEntityTypes>
	{
	}
	
	#endregion ThuLaoCoiThiVhuProperty
}

