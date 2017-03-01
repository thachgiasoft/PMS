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
	/// Represents the DataRepository.TrinhDoChinhTriProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(TrinhDoChinhTriDataSourceDesigner))]
	public class TrinhDoChinhTriDataSource : ProviderDataSource<TrinhDoChinhTri, TrinhDoChinhTriKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrinhDoChinhTriDataSource class.
		/// </summary>
		public TrinhDoChinhTriDataSource() : base(new TrinhDoChinhTriService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the TrinhDoChinhTriDataSourceView used by the TrinhDoChinhTriDataSource.
		/// </summary>
		protected TrinhDoChinhTriDataSourceView TrinhDoChinhTriView
		{
			get { return ( View as TrinhDoChinhTriDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the TrinhDoChinhTriDataSource control invokes to retrieve data.
		/// </summary>
		public TrinhDoChinhTriSelectMethod SelectMethod
		{
			get
			{
				TrinhDoChinhTriSelectMethod selectMethod = TrinhDoChinhTriSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (TrinhDoChinhTriSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the TrinhDoChinhTriDataSourceView class that is to be
		/// used by the TrinhDoChinhTriDataSource.
		/// </summary>
		/// <returns>An instance of the TrinhDoChinhTriDataSourceView class.</returns>
		protected override BaseDataSourceView<TrinhDoChinhTri, TrinhDoChinhTriKey> GetNewDataSourceView()
		{
			return new TrinhDoChinhTriDataSourceView(this, DefaultViewName);
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
	/// Supports the TrinhDoChinhTriDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class TrinhDoChinhTriDataSourceView : ProviderDataSourceView<TrinhDoChinhTri, TrinhDoChinhTriKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrinhDoChinhTriDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the TrinhDoChinhTriDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public TrinhDoChinhTriDataSourceView(TrinhDoChinhTriDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal TrinhDoChinhTriDataSource TrinhDoChinhTriOwner
		{
			get { return Owner as TrinhDoChinhTriDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal TrinhDoChinhTriSelectMethod SelectMethod
		{
			get { return TrinhDoChinhTriOwner.SelectMethod; }
			set { TrinhDoChinhTriOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal TrinhDoChinhTriService TrinhDoChinhTriProvider
		{
			get { return Provider as TrinhDoChinhTriService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<TrinhDoChinhTri> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<TrinhDoChinhTri> results = null;
			TrinhDoChinhTri item;
			count = 0;
			
			System.Int32 _maTrinhDoChinhTri;

			switch ( SelectMethod )
			{
				case TrinhDoChinhTriSelectMethod.Get:
					TrinhDoChinhTriKey entityKey  = new TrinhDoChinhTriKey();
					entityKey.Load(values);
					item = TrinhDoChinhTriProvider.Get(entityKey);
					results = new TList<TrinhDoChinhTri>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case TrinhDoChinhTriSelectMethod.GetAll:
                    results = TrinhDoChinhTriProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case TrinhDoChinhTriSelectMethod.GetPaged:
					results = TrinhDoChinhTriProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case TrinhDoChinhTriSelectMethod.Find:
					if ( FilterParameters != null )
						results = TrinhDoChinhTriProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = TrinhDoChinhTriProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case TrinhDoChinhTriSelectMethod.GetByMaTrinhDoChinhTri:
					_maTrinhDoChinhTri = ( values["MaTrinhDoChinhTri"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaTrinhDoChinhTri"], typeof(System.Int32)) : (int)0;
					item = TrinhDoChinhTriProvider.GetByMaTrinhDoChinhTri(_maTrinhDoChinhTri);
					results = new TList<TrinhDoChinhTri>();
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
			if ( SelectMethod == TrinhDoChinhTriSelectMethod.Get || SelectMethod == TrinhDoChinhTriSelectMethod.GetByMaTrinhDoChinhTri )
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
				TrinhDoChinhTri entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					TrinhDoChinhTriProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<TrinhDoChinhTri> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			TrinhDoChinhTriProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region TrinhDoChinhTriDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the TrinhDoChinhTriDataSource class.
	/// </summary>
	public class TrinhDoChinhTriDataSourceDesigner : ProviderDataSourceDesigner<TrinhDoChinhTri, TrinhDoChinhTriKey>
	{
		/// <summary>
		/// Initializes a new instance of the TrinhDoChinhTriDataSourceDesigner class.
		/// </summary>
		public TrinhDoChinhTriDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public TrinhDoChinhTriSelectMethod SelectMethod
		{
			get { return ((TrinhDoChinhTriDataSource) DataSource).SelectMethod; }
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
				actions.Add(new TrinhDoChinhTriDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region TrinhDoChinhTriDataSourceActionList

	/// <summary>
	/// Supports the TrinhDoChinhTriDataSourceDesigner class.
	/// </summary>
	internal class TrinhDoChinhTriDataSourceActionList : DesignerActionList
	{
		private TrinhDoChinhTriDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the TrinhDoChinhTriDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public TrinhDoChinhTriDataSourceActionList(TrinhDoChinhTriDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public TrinhDoChinhTriSelectMethod SelectMethod
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

	#endregion TrinhDoChinhTriDataSourceActionList
	
	#endregion TrinhDoChinhTriDataSourceDesigner
	
	#region TrinhDoChinhTriSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the TrinhDoChinhTriDataSource.SelectMethod property.
	/// </summary>
	public enum TrinhDoChinhTriSelectMethod
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
		/// Represents the GetByMaTrinhDoChinhTri method.
		/// </summary>
		GetByMaTrinhDoChinhTri
	}
	
	#endregion TrinhDoChinhTriSelectMethod

	#region TrinhDoChinhTriFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrinhDoChinhTri"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrinhDoChinhTriFilter : SqlFilter<TrinhDoChinhTriColumn>
	{
	}
	
	#endregion TrinhDoChinhTriFilter

	#region TrinhDoChinhTriExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrinhDoChinhTri"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrinhDoChinhTriExpressionBuilder : SqlExpressionBuilder<TrinhDoChinhTriColumn>
	{
	}
	
	#endregion TrinhDoChinhTriExpressionBuilder	

	#region TrinhDoChinhTriProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;TrinhDoChinhTriChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="TrinhDoChinhTri"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrinhDoChinhTriProperty : ChildEntityProperty<TrinhDoChinhTriChildEntityTypes>
	{
	}
	
	#endregion TrinhDoChinhTriProperty
}

