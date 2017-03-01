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
	/// Represents the DataRepository.HistoryProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(HistoryDataSourceDesigner))]
	public class HistoryDataSource : ProviderDataSource<History, HistoryKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HistoryDataSource class.
		/// </summary>
		public HistoryDataSource() : base(new HistoryService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the HistoryDataSourceView used by the HistoryDataSource.
		/// </summary>
		protected HistoryDataSourceView HistoryView
		{
			get { return ( View as HistoryDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the HistoryDataSource control invokes to retrieve data.
		/// </summary>
		public HistorySelectMethod SelectMethod
		{
			get
			{
				HistorySelectMethod selectMethod = HistorySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (HistorySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the HistoryDataSourceView class that is to be
		/// used by the HistoryDataSource.
		/// </summary>
		/// <returns>An instance of the HistoryDataSourceView class.</returns>
		protected override BaseDataSourceView<History, HistoryKey> GetNewDataSourceView()
		{
			return new HistoryDataSourceView(this, DefaultViewName);
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
	/// Supports the HistoryDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class HistoryDataSourceView : ProviderDataSourceView<History, HistoryKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HistoryDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the HistoryDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public HistoryDataSourceView(HistoryDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal HistoryDataSource HistoryOwner
		{
			get { return Owner as HistoryDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal HistorySelectMethod SelectMethod
		{
			get { return HistoryOwner.SelectMethod; }
			set { HistoryOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal HistoryService HistoryProvider
		{
			get { return Provider as HistoryService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<History> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<History> results = null;
			History item;
			count = 0;
			
			System.Int64 _historyId;

			switch ( SelectMethod )
			{
				case HistorySelectMethod.Get:
					HistoryKey entityKey  = new HistoryKey();
					entityKey.Load(values);
					item = HistoryProvider.Get(entityKey);
					results = new TList<History>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case HistorySelectMethod.GetAll:
                    results = HistoryProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case HistorySelectMethod.GetPaged:
					results = HistoryProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case HistorySelectMethod.Find:
					if ( FilterParameters != null )
						results = HistoryProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = HistoryProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case HistorySelectMethod.GetByHistoryId:
					_historyId = ( values["HistoryId"] != null ) ? (System.Int64) EntityUtil.ChangeType(values["HistoryId"], typeof(System.Int64)) : (long)0;
					item = HistoryProvider.GetByHistoryId(_historyId);
					results = new TList<History>();
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
			if ( SelectMethod == HistorySelectMethod.Get || SelectMethod == HistorySelectMethod.GetByHistoryId )
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
				History entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					HistoryProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<History> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			HistoryProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region HistoryDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the HistoryDataSource class.
	/// </summary>
	public class HistoryDataSourceDesigner : ProviderDataSourceDesigner<History, HistoryKey>
	{
		/// <summary>
		/// Initializes a new instance of the HistoryDataSourceDesigner class.
		/// </summary>
		public HistoryDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HistorySelectMethod SelectMethod
		{
			get { return ((HistoryDataSource) DataSource).SelectMethod; }
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
				actions.Add(new HistoryDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region HistoryDataSourceActionList

	/// <summary>
	/// Supports the HistoryDataSourceDesigner class.
	/// </summary>
	internal class HistoryDataSourceActionList : DesignerActionList
	{
		private HistoryDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the HistoryDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public HistoryDataSourceActionList(HistoryDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HistorySelectMethod SelectMethod
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

	#endregion HistoryDataSourceActionList
	
	#endregion HistoryDataSourceDesigner
	
	#region HistorySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the HistoryDataSource.SelectMethod property.
	/// </summary>
	public enum HistorySelectMethod
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
		/// Represents the GetByHistoryId method.
		/// </summary>
		GetByHistoryId
	}
	
	#endregion HistorySelectMethod

	#region HistoryFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="History"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HistoryFilter : SqlFilter<HistoryColumn>
	{
	}
	
	#endregion HistoryFilter

	#region HistoryExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="History"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HistoryExpressionBuilder : SqlExpressionBuilder<HistoryColumn>
	{
	}
	
	#endregion HistoryExpressionBuilder	

	#region HistoryProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;HistoryChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="History"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HistoryProperty : ChildEntityProperty<HistoryChildEntityTypes>
	{
	}
	
	#endregion HistoryProperty
}

