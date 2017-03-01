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
	/// Represents the DataRepository.ThuLaoChamThiVhuexProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(ThuLaoChamThiVhuexDataSourceDesigner))]
	public class ThuLaoChamThiVhuexDataSource : ProviderDataSource<ThuLaoChamThiVhuex, ThuLaoChamThiVhuexKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoChamThiVhuexDataSource class.
		/// </summary>
		public ThuLaoChamThiVhuexDataSource() : base(new ThuLaoChamThiVhuexService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ThuLaoChamThiVhuexDataSourceView used by the ThuLaoChamThiVhuexDataSource.
		/// </summary>
		protected ThuLaoChamThiVhuexDataSourceView ThuLaoChamThiVhuexView
		{
			get { return ( View as ThuLaoChamThiVhuexDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ThuLaoChamThiVhuexDataSource control invokes to retrieve data.
		/// </summary>
		public ThuLaoChamThiVhuexSelectMethod SelectMethod
		{
			get
			{
				ThuLaoChamThiVhuexSelectMethod selectMethod = ThuLaoChamThiVhuexSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ThuLaoChamThiVhuexSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ThuLaoChamThiVhuexDataSourceView class that is to be
		/// used by the ThuLaoChamThiVhuexDataSource.
		/// </summary>
		/// <returns>An instance of the ThuLaoChamThiVhuexDataSourceView class.</returns>
		protected override BaseDataSourceView<ThuLaoChamThiVhuex, ThuLaoChamThiVhuexKey> GetNewDataSourceView()
		{
			return new ThuLaoChamThiVhuexDataSourceView(this, DefaultViewName);
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
	/// Supports the ThuLaoChamThiVhuexDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ThuLaoChamThiVhuexDataSourceView : ProviderDataSourceView<ThuLaoChamThiVhuex, ThuLaoChamThiVhuexKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoChamThiVhuexDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ThuLaoChamThiVhuexDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ThuLaoChamThiVhuexDataSourceView(ThuLaoChamThiVhuexDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ThuLaoChamThiVhuexDataSource ThuLaoChamThiVhuexOwner
		{
			get { return Owner as ThuLaoChamThiVhuexDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal ThuLaoChamThiVhuexSelectMethod SelectMethod
		{
			get { return ThuLaoChamThiVhuexOwner.SelectMethod; }
			set { ThuLaoChamThiVhuexOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ThuLaoChamThiVhuexService ThuLaoChamThiVhuexProvider
		{
			get { return Provider as ThuLaoChamThiVhuexService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ThuLaoChamThiVhuex> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<ThuLaoChamThiVhuex> results = null;
			ThuLaoChamThiVhuex item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case ThuLaoChamThiVhuexSelectMethod.Get:
					ThuLaoChamThiVhuexKey entityKey  = new ThuLaoChamThiVhuexKey();
					entityKey.Load(values);
					item = ThuLaoChamThiVhuexProvider.Get(entityKey);
					results = new TList<ThuLaoChamThiVhuex>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case ThuLaoChamThiVhuexSelectMethod.GetAll:
                    results = ThuLaoChamThiVhuexProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ThuLaoChamThiVhuexSelectMethod.GetPaged:
					results = ThuLaoChamThiVhuexProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ThuLaoChamThiVhuexSelectMethod.Find:
					if ( FilterParameters != null )
						results = ThuLaoChamThiVhuexProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = ThuLaoChamThiVhuexProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case ThuLaoChamThiVhuexSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = ThuLaoChamThiVhuexProvider.GetById(_id);
					results = new TList<ThuLaoChamThiVhuex>();
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
			if ( SelectMethod == ThuLaoChamThiVhuexSelectMethod.Get || SelectMethod == ThuLaoChamThiVhuexSelectMethod.GetById )
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
				ThuLaoChamThiVhuex entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					ThuLaoChamThiVhuexProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<ThuLaoChamThiVhuex> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			ThuLaoChamThiVhuexProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region ThuLaoChamThiVhuexDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ThuLaoChamThiVhuexDataSource class.
	/// </summary>
	public class ThuLaoChamThiVhuexDataSourceDesigner : ProviderDataSourceDesigner<ThuLaoChamThiVhuex, ThuLaoChamThiVhuexKey>
	{
		/// <summary>
		/// Initializes a new instance of the ThuLaoChamThiVhuexDataSourceDesigner class.
		/// </summary>
		public ThuLaoChamThiVhuexDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThuLaoChamThiVhuexSelectMethod SelectMethod
		{
			get { return ((ThuLaoChamThiVhuexDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ThuLaoChamThiVhuexDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ThuLaoChamThiVhuexDataSourceActionList

	/// <summary>
	/// Supports the ThuLaoChamThiVhuexDataSourceDesigner class.
	/// </summary>
	internal class ThuLaoChamThiVhuexDataSourceActionList : DesignerActionList
	{
		private ThuLaoChamThiVhuexDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ThuLaoChamThiVhuexDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ThuLaoChamThiVhuexDataSourceActionList(ThuLaoChamThiVhuexDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThuLaoChamThiVhuexSelectMethod SelectMethod
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

	#endregion ThuLaoChamThiVhuexDataSourceActionList
	
	#endregion ThuLaoChamThiVhuexDataSourceDesigner
	
	#region ThuLaoChamThiVhuexSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ThuLaoChamThiVhuexDataSource.SelectMethod property.
	/// </summary>
	public enum ThuLaoChamThiVhuexSelectMethod
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
	
	#endregion ThuLaoChamThiVhuexSelectMethod

	#region ThuLaoChamThiVhuexFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoChamThiVhuex"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoChamThiVhuexFilter : SqlFilter<ThuLaoChamThiVhuexColumn>
	{
	}
	
	#endregion ThuLaoChamThiVhuexFilter

	#region ThuLaoChamThiVhuexExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoChamThiVhuex"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoChamThiVhuexExpressionBuilder : SqlExpressionBuilder<ThuLaoChamThiVhuexColumn>
	{
	}
	
	#endregion ThuLaoChamThiVhuexExpressionBuilder	

	#region ThuLaoChamThiVhuexProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;ThuLaoChamThiVhuexChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoChamThiVhuex"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoChamThiVhuexProperty : ChildEntityProperty<ThuLaoChamThiVhuexChildEntityTypes>
	{
	}
	
	#endregion ThuLaoChamThiVhuexProperty
}

