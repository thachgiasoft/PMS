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
	/// Represents the DataRepository.TrinhDoNgoaiNguProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(TrinhDoNgoaiNguDataSourceDesigner))]
	public class TrinhDoNgoaiNguDataSource : ProviderDataSource<TrinhDoNgoaiNgu, TrinhDoNgoaiNguKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrinhDoNgoaiNguDataSource class.
		/// </summary>
		public TrinhDoNgoaiNguDataSource() : base(new TrinhDoNgoaiNguService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the TrinhDoNgoaiNguDataSourceView used by the TrinhDoNgoaiNguDataSource.
		/// </summary>
		protected TrinhDoNgoaiNguDataSourceView TrinhDoNgoaiNguView
		{
			get { return ( View as TrinhDoNgoaiNguDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the TrinhDoNgoaiNguDataSource control invokes to retrieve data.
		/// </summary>
		public TrinhDoNgoaiNguSelectMethod SelectMethod
		{
			get
			{
				TrinhDoNgoaiNguSelectMethod selectMethod = TrinhDoNgoaiNguSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (TrinhDoNgoaiNguSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the TrinhDoNgoaiNguDataSourceView class that is to be
		/// used by the TrinhDoNgoaiNguDataSource.
		/// </summary>
		/// <returns>An instance of the TrinhDoNgoaiNguDataSourceView class.</returns>
		protected override BaseDataSourceView<TrinhDoNgoaiNgu, TrinhDoNgoaiNguKey> GetNewDataSourceView()
		{
			return new TrinhDoNgoaiNguDataSourceView(this, DefaultViewName);
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
	/// Supports the TrinhDoNgoaiNguDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class TrinhDoNgoaiNguDataSourceView : ProviderDataSourceView<TrinhDoNgoaiNgu, TrinhDoNgoaiNguKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrinhDoNgoaiNguDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the TrinhDoNgoaiNguDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public TrinhDoNgoaiNguDataSourceView(TrinhDoNgoaiNguDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal TrinhDoNgoaiNguDataSource TrinhDoNgoaiNguOwner
		{
			get { return Owner as TrinhDoNgoaiNguDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal TrinhDoNgoaiNguSelectMethod SelectMethod
		{
			get { return TrinhDoNgoaiNguOwner.SelectMethod; }
			set { TrinhDoNgoaiNguOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal TrinhDoNgoaiNguService TrinhDoNgoaiNguProvider
		{
			get { return Provider as TrinhDoNgoaiNguService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<TrinhDoNgoaiNgu> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<TrinhDoNgoaiNgu> results = null;
			TrinhDoNgoaiNgu item;
			count = 0;
			
			System.Int32 _maTrinhDoNgoaiNgu;

			switch ( SelectMethod )
			{
				case TrinhDoNgoaiNguSelectMethod.Get:
					TrinhDoNgoaiNguKey entityKey  = new TrinhDoNgoaiNguKey();
					entityKey.Load(values);
					item = TrinhDoNgoaiNguProvider.Get(entityKey);
					results = new TList<TrinhDoNgoaiNgu>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case TrinhDoNgoaiNguSelectMethod.GetAll:
                    results = TrinhDoNgoaiNguProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case TrinhDoNgoaiNguSelectMethod.GetPaged:
					results = TrinhDoNgoaiNguProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case TrinhDoNgoaiNguSelectMethod.Find:
					if ( FilterParameters != null )
						results = TrinhDoNgoaiNguProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = TrinhDoNgoaiNguProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case TrinhDoNgoaiNguSelectMethod.GetByMaTrinhDoNgoaiNgu:
					_maTrinhDoNgoaiNgu = ( values["MaTrinhDoNgoaiNgu"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaTrinhDoNgoaiNgu"], typeof(System.Int32)) : (int)0;
					item = TrinhDoNgoaiNguProvider.GetByMaTrinhDoNgoaiNgu(_maTrinhDoNgoaiNgu);
					results = new TList<TrinhDoNgoaiNgu>();
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
			if ( SelectMethod == TrinhDoNgoaiNguSelectMethod.Get || SelectMethod == TrinhDoNgoaiNguSelectMethod.GetByMaTrinhDoNgoaiNgu )
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
				TrinhDoNgoaiNgu entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					TrinhDoNgoaiNguProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<TrinhDoNgoaiNgu> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			TrinhDoNgoaiNguProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region TrinhDoNgoaiNguDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the TrinhDoNgoaiNguDataSource class.
	/// </summary>
	public class TrinhDoNgoaiNguDataSourceDesigner : ProviderDataSourceDesigner<TrinhDoNgoaiNgu, TrinhDoNgoaiNguKey>
	{
		/// <summary>
		/// Initializes a new instance of the TrinhDoNgoaiNguDataSourceDesigner class.
		/// </summary>
		public TrinhDoNgoaiNguDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public TrinhDoNgoaiNguSelectMethod SelectMethod
		{
			get { return ((TrinhDoNgoaiNguDataSource) DataSource).SelectMethod; }
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
				actions.Add(new TrinhDoNgoaiNguDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region TrinhDoNgoaiNguDataSourceActionList

	/// <summary>
	/// Supports the TrinhDoNgoaiNguDataSourceDesigner class.
	/// </summary>
	internal class TrinhDoNgoaiNguDataSourceActionList : DesignerActionList
	{
		private TrinhDoNgoaiNguDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the TrinhDoNgoaiNguDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public TrinhDoNgoaiNguDataSourceActionList(TrinhDoNgoaiNguDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public TrinhDoNgoaiNguSelectMethod SelectMethod
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

	#endregion TrinhDoNgoaiNguDataSourceActionList
	
	#endregion TrinhDoNgoaiNguDataSourceDesigner
	
	#region TrinhDoNgoaiNguSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the TrinhDoNgoaiNguDataSource.SelectMethod property.
	/// </summary>
	public enum TrinhDoNgoaiNguSelectMethod
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
		/// Represents the GetByMaTrinhDoNgoaiNgu method.
		/// </summary>
		GetByMaTrinhDoNgoaiNgu
	}
	
	#endregion TrinhDoNgoaiNguSelectMethod

	#region TrinhDoNgoaiNguFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrinhDoNgoaiNgu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrinhDoNgoaiNguFilter : SqlFilter<TrinhDoNgoaiNguColumn>
	{
	}
	
	#endregion TrinhDoNgoaiNguFilter

	#region TrinhDoNgoaiNguExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrinhDoNgoaiNgu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrinhDoNgoaiNguExpressionBuilder : SqlExpressionBuilder<TrinhDoNgoaiNguColumn>
	{
	}
	
	#endregion TrinhDoNgoaiNguExpressionBuilder	

	#region TrinhDoNgoaiNguProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;TrinhDoNgoaiNguChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="TrinhDoNgoaiNgu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrinhDoNgoaiNguProperty : ChildEntityProperty<TrinhDoNgoaiNguChildEntityTypes>
	{
	}
	
	#endregion TrinhDoNgoaiNguProperty
}

