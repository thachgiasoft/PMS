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
	/// Represents the DataRepository.ThuLaoChamBaiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(ThuLaoChamBaiDataSourceDesigner))]
	public class ThuLaoChamBaiDataSource : ProviderDataSource<ThuLaoChamBai, ThuLaoChamBaiKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoChamBaiDataSource class.
		/// </summary>
		public ThuLaoChamBaiDataSource() : base(new ThuLaoChamBaiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ThuLaoChamBaiDataSourceView used by the ThuLaoChamBaiDataSource.
		/// </summary>
		protected ThuLaoChamBaiDataSourceView ThuLaoChamBaiView
		{
			get { return ( View as ThuLaoChamBaiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ThuLaoChamBaiDataSource control invokes to retrieve data.
		/// </summary>
		public ThuLaoChamBaiSelectMethod SelectMethod
		{
			get
			{
				ThuLaoChamBaiSelectMethod selectMethod = ThuLaoChamBaiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ThuLaoChamBaiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ThuLaoChamBaiDataSourceView class that is to be
		/// used by the ThuLaoChamBaiDataSource.
		/// </summary>
		/// <returns>An instance of the ThuLaoChamBaiDataSourceView class.</returns>
		protected override BaseDataSourceView<ThuLaoChamBai, ThuLaoChamBaiKey> GetNewDataSourceView()
		{
			return new ThuLaoChamBaiDataSourceView(this, DefaultViewName);
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
	/// Supports the ThuLaoChamBaiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ThuLaoChamBaiDataSourceView : ProviderDataSourceView<ThuLaoChamBai, ThuLaoChamBaiKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoChamBaiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ThuLaoChamBaiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ThuLaoChamBaiDataSourceView(ThuLaoChamBaiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ThuLaoChamBaiDataSource ThuLaoChamBaiOwner
		{
			get { return Owner as ThuLaoChamBaiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal ThuLaoChamBaiSelectMethod SelectMethod
		{
			get { return ThuLaoChamBaiOwner.SelectMethod; }
			set { ThuLaoChamBaiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ThuLaoChamBaiService ThuLaoChamBaiProvider
		{
			get { return Provider as ThuLaoChamBaiService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ThuLaoChamBai> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<ThuLaoChamBai> results = null;
			ThuLaoChamBai item;
			count = 0;
			
			System.Int32 _id;
			System.String sp798_NamHoc;
			System.String sp798_HocKy;

			switch ( SelectMethod )
			{
				case ThuLaoChamBaiSelectMethod.Get:
					ThuLaoChamBaiKey entityKey  = new ThuLaoChamBaiKey();
					entityKey.Load(values);
					item = ThuLaoChamBaiProvider.Get(entityKey);
					results = new TList<ThuLaoChamBai>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case ThuLaoChamBaiSelectMethod.GetAll:
                    results = ThuLaoChamBaiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ThuLaoChamBaiSelectMethod.GetPaged:
					results = ThuLaoChamBaiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ThuLaoChamBaiSelectMethod.Find:
					if ( FilterParameters != null )
						results = ThuLaoChamBaiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = ThuLaoChamBaiProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case ThuLaoChamBaiSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = ThuLaoChamBaiProvider.GetById(_id);
					results = new TList<ThuLaoChamBai>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case ThuLaoChamBaiSelectMethod.GetByNamHocHocKy:
					sp798_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp798_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ThuLaoChamBaiProvider.GetByNamHocHocKy(sp798_NamHoc, sp798_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == ThuLaoChamBaiSelectMethod.Get || SelectMethod == ThuLaoChamBaiSelectMethod.GetById )
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
				ThuLaoChamBai entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					ThuLaoChamBaiProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<ThuLaoChamBai> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			ThuLaoChamBaiProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region ThuLaoChamBaiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ThuLaoChamBaiDataSource class.
	/// </summary>
	public class ThuLaoChamBaiDataSourceDesigner : ProviderDataSourceDesigner<ThuLaoChamBai, ThuLaoChamBaiKey>
	{
		/// <summary>
		/// Initializes a new instance of the ThuLaoChamBaiDataSourceDesigner class.
		/// </summary>
		public ThuLaoChamBaiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThuLaoChamBaiSelectMethod SelectMethod
		{
			get { return ((ThuLaoChamBaiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ThuLaoChamBaiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ThuLaoChamBaiDataSourceActionList

	/// <summary>
	/// Supports the ThuLaoChamBaiDataSourceDesigner class.
	/// </summary>
	internal class ThuLaoChamBaiDataSourceActionList : DesignerActionList
	{
		private ThuLaoChamBaiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ThuLaoChamBaiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ThuLaoChamBaiDataSourceActionList(ThuLaoChamBaiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThuLaoChamBaiSelectMethod SelectMethod
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

	#endregion ThuLaoChamBaiDataSourceActionList
	
	#endregion ThuLaoChamBaiDataSourceDesigner
	
	#region ThuLaoChamBaiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ThuLaoChamBaiDataSource.SelectMethod property.
	/// </summary>
	public enum ThuLaoChamBaiSelectMethod
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
		GetById,
		/// <summary>
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy
	}
	
	#endregion ThuLaoChamBaiSelectMethod

	#region ThuLaoChamBaiFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoChamBai"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoChamBaiFilter : SqlFilter<ThuLaoChamBaiColumn>
	{
	}
	
	#endregion ThuLaoChamBaiFilter

	#region ThuLaoChamBaiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoChamBai"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoChamBaiExpressionBuilder : SqlExpressionBuilder<ThuLaoChamBaiColumn>
	{
	}
	
	#endregion ThuLaoChamBaiExpressionBuilder	

	#region ThuLaoChamBaiProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;ThuLaoChamBaiChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoChamBai"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoChamBaiProperty : ChildEntityProperty<ThuLaoChamBaiChildEntityTypes>
	{
	}
	
	#endregion ThuLaoChamBaiProperty
}

