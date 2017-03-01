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
	/// Represents the DataRepository.QuocTichProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(QuocTichDataSourceDesigner))]
	public class QuocTichDataSource : ProviderDataSource<QuocTich, QuocTichKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the QuocTichDataSource class.
		/// </summary>
		public QuocTichDataSource() : base(new QuocTichService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the QuocTichDataSourceView used by the QuocTichDataSource.
		/// </summary>
		protected QuocTichDataSourceView QuocTichView
		{
			get { return ( View as QuocTichDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the QuocTichDataSource control invokes to retrieve data.
		/// </summary>
		public QuocTichSelectMethod SelectMethod
		{
			get
			{
				QuocTichSelectMethod selectMethod = QuocTichSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (QuocTichSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the QuocTichDataSourceView class that is to be
		/// used by the QuocTichDataSource.
		/// </summary>
		/// <returns>An instance of the QuocTichDataSourceView class.</returns>
		protected override BaseDataSourceView<QuocTich, QuocTichKey> GetNewDataSourceView()
		{
			return new QuocTichDataSourceView(this, DefaultViewName);
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
	/// Supports the QuocTichDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class QuocTichDataSourceView : ProviderDataSourceView<QuocTich, QuocTichKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the QuocTichDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the QuocTichDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public QuocTichDataSourceView(QuocTichDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal QuocTichDataSource QuocTichOwner
		{
			get { return Owner as QuocTichDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal QuocTichSelectMethod SelectMethod
		{
			get { return QuocTichOwner.SelectMethod; }
			set { QuocTichOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal QuocTichService QuocTichProvider
		{
			get { return Provider as QuocTichService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<QuocTich> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<QuocTich> results = null;
			QuocTich item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case QuocTichSelectMethod.Get:
					QuocTichKey entityKey  = new QuocTichKey();
					entityKey.Load(values);
					item = QuocTichProvider.Get(entityKey);
					results = new TList<QuocTich>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case QuocTichSelectMethod.GetAll:
                    results = QuocTichProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case QuocTichSelectMethod.GetPaged:
					results = QuocTichProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case QuocTichSelectMethod.Find:
					if ( FilterParameters != null )
						results = QuocTichProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = QuocTichProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case QuocTichSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = QuocTichProvider.GetById(_id);
					results = new TList<QuocTich>();
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
			if ( SelectMethod == QuocTichSelectMethod.Get || SelectMethod == QuocTichSelectMethod.GetById )
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
				QuocTich entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					QuocTichProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<QuocTich> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			QuocTichProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region QuocTichDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the QuocTichDataSource class.
	/// </summary>
	public class QuocTichDataSourceDesigner : ProviderDataSourceDesigner<QuocTich, QuocTichKey>
	{
		/// <summary>
		/// Initializes a new instance of the QuocTichDataSourceDesigner class.
		/// </summary>
		public QuocTichDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public QuocTichSelectMethod SelectMethod
		{
			get { return ((QuocTichDataSource) DataSource).SelectMethod; }
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
				actions.Add(new QuocTichDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region QuocTichDataSourceActionList

	/// <summary>
	/// Supports the QuocTichDataSourceDesigner class.
	/// </summary>
	internal class QuocTichDataSourceActionList : DesignerActionList
	{
		private QuocTichDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the QuocTichDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public QuocTichDataSourceActionList(QuocTichDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public QuocTichSelectMethod SelectMethod
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

	#endregion QuocTichDataSourceActionList
	
	#endregion QuocTichDataSourceDesigner
	
	#region QuocTichSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the QuocTichDataSource.SelectMethod property.
	/// </summary>
	public enum QuocTichSelectMethod
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
	
	#endregion QuocTichSelectMethod

	#region QuocTichFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="QuocTich"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class QuocTichFilter : SqlFilter<QuocTichColumn>
	{
	}
	
	#endregion QuocTichFilter

	#region QuocTichExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="QuocTich"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class QuocTichExpressionBuilder : SqlExpressionBuilder<QuocTichColumn>
	{
	}
	
	#endregion QuocTichExpressionBuilder	

	#region QuocTichProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;QuocTichChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="QuocTich"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class QuocTichProperty : ChildEntityProperty<QuocTichChildEntityTypes>
	{
	}
	
	#endregion QuocTichProperty
}

