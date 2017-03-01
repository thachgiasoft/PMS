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
	/// Represents the DataRepository.TrinhDoTinHocProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(TrinhDoTinHocDataSourceDesigner))]
	public class TrinhDoTinHocDataSource : ProviderDataSource<TrinhDoTinHoc, TrinhDoTinHocKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrinhDoTinHocDataSource class.
		/// </summary>
		public TrinhDoTinHocDataSource() : base(new TrinhDoTinHocService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the TrinhDoTinHocDataSourceView used by the TrinhDoTinHocDataSource.
		/// </summary>
		protected TrinhDoTinHocDataSourceView TrinhDoTinHocView
		{
			get { return ( View as TrinhDoTinHocDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the TrinhDoTinHocDataSource control invokes to retrieve data.
		/// </summary>
		public TrinhDoTinHocSelectMethod SelectMethod
		{
			get
			{
				TrinhDoTinHocSelectMethod selectMethod = TrinhDoTinHocSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (TrinhDoTinHocSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the TrinhDoTinHocDataSourceView class that is to be
		/// used by the TrinhDoTinHocDataSource.
		/// </summary>
		/// <returns>An instance of the TrinhDoTinHocDataSourceView class.</returns>
		protected override BaseDataSourceView<TrinhDoTinHoc, TrinhDoTinHocKey> GetNewDataSourceView()
		{
			return new TrinhDoTinHocDataSourceView(this, DefaultViewName);
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
	/// Supports the TrinhDoTinHocDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class TrinhDoTinHocDataSourceView : ProviderDataSourceView<TrinhDoTinHoc, TrinhDoTinHocKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrinhDoTinHocDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the TrinhDoTinHocDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public TrinhDoTinHocDataSourceView(TrinhDoTinHocDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal TrinhDoTinHocDataSource TrinhDoTinHocOwner
		{
			get { return Owner as TrinhDoTinHocDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal TrinhDoTinHocSelectMethod SelectMethod
		{
			get { return TrinhDoTinHocOwner.SelectMethod; }
			set { TrinhDoTinHocOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal TrinhDoTinHocService TrinhDoTinHocProvider
		{
			get { return Provider as TrinhDoTinHocService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<TrinhDoTinHoc> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<TrinhDoTinHoc> results = null;
			TrinhDoTinHoc item;
			count = 0;
			
			System.Int32 _maTrinhDoTinHoc;

			switch ( SelectMethod )
			{
				case TrinhDoTinHocSelectMethod.Get:
					TrinhDoTinHocKey entityKey  = new TrinhDoTinHocKey();
					entityKey.Load(values);
					item = TrinhDoTinHocProvider.Get(entityKey);
					results = new TList<TrinhDoTinHoc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case TrinhDoTinHocSelectMethod.GetAll:
                    results = TrinhDoTinHocProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case TrinhDoTinHocSelectMethod.GetPaged:
					results = TrinhDoTinHocProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case TrinhDoTinHocSelectMethod.Find:
					if ( FilterParameters != null )
						results = TrinhDoTinHocProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = TrinhDoTinHocProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case TrinhDoTinHocSelectMethod.GetByMaTrinhDoTinHoc:
					_maTrinhDoTinHoc = ( values["MaTrinhDoTinHoc"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaTrinhDoTinHoc"], typeof(System.Int32)) : (int)0;
					item = TrinhDoTinHocProvider.GetByMaTrinhDoTinHoc(_maTrinhDoTinHoc);
					results = new TList<TrinhDoTinHoc>();
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
			if ( SelectMethod == TrinhDoTinHocSelectMethod.Get || SelectMethod == TrinhDoTinHocSelectMethod.GetByMaTrinhDoTinHoc )
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
				TrinhDoTinHoc entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					TrinhDoTinHocProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<TrinhDoTinHoc> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			TrinhDoTinHocProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region TrinhDoTinHocDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the TrinhDoTinHocDataSource class.
	/// </summary>
	public class TrinhDoTinHocDataSourceDesigner : ProviderDataSourceDesigner<TrinhDoTinHoc, TrinhDoTinHocKey>
	{
		/// <summary>
		/// Initializes a new instance of the TrinhDoTinHocDataSourceDesigner class.
		/// </summary>
		public TrinhDoTinHocDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public TrinhDoTinHocSelectMethod SelectMethod
		{
			get { return ((TrinhDoTinHocDataSource) DataSource).SelectMethod; }
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
				actions.Add(new TrinhDoTinHocDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region TrinhDoTinHocDataSourceActionList

	/// <summary>
	/// Supports the TrinhDoTinHocDataSourceDesigner class.
	/// </summary>
	internal class TrinhDoTinHocDataSourceActionList : DesignerActionList
	{
		private TrinhDoTinHocDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the TrinhDoTinHocDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public TrinhDoTinHocDataSourceActionList(TrinhDoTinHocDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public TrinhDoTinHocSelectMethod SelectMethod
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

	#endregion TrinhDoTinHocDataSourceActionList
	
	#endregion TrinhDoTinHocDataSourceDesigner
	
	#region TrinhDoTinHocSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the TrinhDoTinHocDataSource.SelectMethod property.
	/// </summary>
	public enum TrinhDoTinHocSelectMethod
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
		/// Represents the GetByMaTrinhDoTinHoc method.
		/// </summary>
		GetByMaTrinhDoTinHoc
	}
	
	#endregion TrinhDoTinHocSelectMethod

	#region TrinhDoTinHocFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrinhDoTinHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrinhDoTinHocFilter : SqlFilter<TrinhDoTinHocColumn>
	{
	}
	
	#endregion TrinhDoTinHocFilter

	#region TrinhDoTinHocExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrinhDoTinHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrinhDoTinHocExpressionBuilder : SqlExpressionBuilder<TrinhDoTinHocColumn>
	{
	}
	
	#endregion TrinhDoTinHocExpressionBuilder	

	#region TrinhDoTinHocProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;TrinhDoTinHocChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="TrinhDoTinHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrinhDoTinHocProperty : ChildEntityProperty<TrinhDoTinHocChildEntityTypes>
	{
	}
	
	#endregion TrinhDoTinHocProperty
}

