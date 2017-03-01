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
	/// Represents the DataRepository.DuTruGioGiangTruocThoiKhoaBieuProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(DuTruGioGiangTruocThoiKhoaBieuDataSourceDesigner))]
	public class DuTruGioGiangTruocThoiKhoaBieuDataSource : ProviderDataSource<DuTruGioGiangTruocThoiKhoaBieu, DuTruGioGiangTruocThoiKhoaBieuKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DuTruGioGiangTruocThoiKhoaBieuDataSource class.
		/// </summary>
		public DuTruGioGiangTruocThoiKhoaBieuDataSource() : base(new DuTruGioGiangTruocThoiKhoaBieuService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the DuTruGioGiangTruocThoiKhoaBieuDataSourceView used by the DuTruGioGiangTruocThoiKhoaBieuDataSource.
		/// </summary>
		protected DuTruGioGiangTruocThoiKhoaBieuDataSourceView DuTruGioGiangTruocThoiKhoaBieuView
		{
			get { return ( View as DuTruGioGiangTruocThoiKhoaBieuDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DuTruGioGiangTruocThoiKhoaBieuDataSource control invokes to retrieve data.
		/// </summary>
		public DuTruGioGiangTruocThoiKhoaBieuSelectMethod SelectMethod
		{
			get
			{
				DuTruGioGiangTruocThoiKhoaBieuSelectMethod selectMethod = DuTruGioGiangTruocThoiKhoaBieuSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (DuTruGioGiangTruocThoiKhoaBieuSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the DuTruGioGiangTruocThoiKhoaBieuDataSourceView class that is to be
		/// used by the DuTruGioGiangTruocThoiKhoaBieuDataSource.
		/// </summary>
		/// <returns>An instance of the DuTruGioGiangTruocThoiKhoaBieuDataSourceView class.</returns>
		protected override BaseDataSourceView<DuTruGioGiangTruocThoiKhoaBieu, DuTruGioGiangTruocThoiKhoaBieuKey> GetNewDataSourceView()
		{
			return new DuTruGioGiangTruocThoiKhoaBieuDataSourceView(this, DefaultViewName);
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
	/// Supports the DuTruGioGiangTruocThoiKhoaBieuDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class DuTruGioGiangTruocThoiKhoaBieuDataSourceView : ProviderDataSourceView<DuTruGioGiangTruocThoiKhoaBieu, DuTruGioGiangTruocThoiKhoaBieuKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DuTruGioGiangTruocThoiKhoaBieuDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the DuTruGioGiangTruocThoiKhoaBieuDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public DuTruGioGiangTruocThoiKhoaBieuDataSourceView(DuTruGioGiangTruocThoiKhoaBieuDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal DuTruGioGiangTruocThoiKhoaBieuDataSource DuTruGioGiangTruocThoiKhoaBieuOwner
		{
			get { return Owner as DuTruGioGiangTruocThoiKhoaBieuDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal DuTruGioGiangTruocThoiKhoaBieuSelectMethod SelectMethod
		{
			get { return DuTruGioGiangTruocThoiKhoaBieuOwner.SelectMethod; }
			set { DuTruGioGiangTruocThoiKhoaBieuOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal DuTruGioGiangTruocThoiKhoaBieuService DuTruGioGiangTruocThoiKhoaBieuProvider
		{
			get { return Provider as DuTruGioGiangTruocThoiKhoaBieuService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<DuTruGioGiangTruocThoiKhoaBieu> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<DuTruGioGiangTruocThoiKhoaBieu> results = null;
			DuTruGioGiangTruocThoiKhoaBieu item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case DuTruGioGiangTruocThoiKhoaBieuSelectMethod.Get:
					DuTruGioGiangTruocThoiKhoaBieuKey entityKey  = new DuTruGioGiangTruocThoiKhoaBieuKey();
					entityKey.Load(values);
					item = DuTruGioGiangTruocThoiKhoaBieuProvider.Get(entityKey);
					results = new TList<DuTruGioGiangTruocThoiKhoaBieu>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case DuTruGioGiangTruocThoiKhoaBieuSelectMethod.GetAll:
                    results = DuTruGioGiangTruocThoiKhoaBieuProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case DuTruGioGiangTruocThoiKhoaBieuSelectMethod.GetPaged:
					results = DuTruGioGiangTruocThoiKhoaBieuProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case DuTruGioGiangTruocThoiKhoaBieuSelectMethod.Find:
					if ( FilterParameters != null )
						results = DuTruGioGiangTruocThoiKhoaBieuProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = DuTruGioGiangTruocThoiKhoaBieuProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case DuTruGioGiangTruocThoiKhoaBieuSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = DuTruGioGiangTruocThoiKhoaBieuProvider.GetById(_id);
					results = new TList<DuTruGioGiangTruocThoiKhoaBieu>();
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
			if ( SelectMethod == DuTruGioGiangTruocThoiKhoaBieuSelectMethod.Get || SelectMethod == DuTruGioGiangTruocThoiKhoaBieuSelectMethod.GetById )
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
				DuTruGioGiangTruocThoiKhoaBieu entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					DuTruGioGiangTruocThoiKhoaBieuProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<DuTruGioGiangTruocThoiKhoaBieu> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			DuTruGioGiangTruocThoiKhoaBieuProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region DuTruGioGiangTruocThoiKhoaBieuDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the DuTruGioGiangTruocThoiKhoaBieuDataSource class.
	/// </summary>
	public class DuTruGioGiangTruocThoiKhoaBieuDataSourceDesigner : ProviderDataSourceDesigner<DuTruGioGiangTruocThoiKhoaBieu, DuTruGioGiangTruocThoiKhoaBieuKey>
	{
		/// <summary>
		/// Initializes a new instance of the DuTruGioGiangTruocThoiKhoaBieuDataSourceDesigner class.
		/// </summary>
		public DuTruGioGiangTruocThoiKhoaBieuDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DuTruGioGiangTruocThoiKhoaBieuSelectMethod SelectMethod
		{
			get { return ((DuTruGioGiangTruocThoiKhoaBieuDataSource) DataSource).SelectMethod; }
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
				actions.Add(new DuTruGioGiangTruocThoiKhoaBieuDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region DuTruGioGiangTruocThoiKhoaBieuDataSourceActionList

	/// <summary>
	/// Supports the DuTruGioGiangTruocThoiKhoaBieuDataSourceDesigner class.
	/// </summary>
	internal class DuTruGioGiangTruocThoiKhoaBieuDataSourceActionList : DesignerActionList
	{
		private DuTruGioGiangTruocThoiKhoaBieuDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the DuTruGioGiangTruocThoiKhoaBieuDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public DuTruGioGiangTruocThoiKhoaBieuDataSourceActionList(DuTruGioGiangTruocThoiKhoaBieuDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DuTruGioGiangTruocThoiKhoaBieuSelectMethod SelectMethod
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

	#endregion DuTruGioGiangTruocThoiKhoaBieuDataSourceActionList
	
	#endregion DuTruGioGiangTruocThoiKhoaBieuDataSourceDesigner
	
	#region DuTruGioGiangTruocThoiKhoaBieuSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the DuTruGioGiangTruocThoiKhoaBieuDataSource.SelectMethod property.
	/// </summary>
	public enum DuTruGioGiangTruocThoiKhoaBieuSelectMethod
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
	
	#endregion DuTruGioGiangTruocThoiKhoaBieuSelectMethod

	#region DuTruGioGiangTruocThoiKhoaBieuFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DuTruGioGiangTruocThoiKhoaBieu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DuTruGioGiangTruocThoiKhoaBieuFilter : SqlFilter<DuTruGioGiangTruocThoiKhoaBieuColumn>
	{
	}
	
	#endregion DuTruGioGiangTruocThoiKhoaBieuFilter

	#region DuTruGioGiangTruocThoiKhoaBieuExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DuTruGioGiangTruocThoiKhoaBieu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DuTruGioGiangTruocThoiKhoaBieuExpressionBuilder : SqlExpressionBuilder<DuTruGioGiangTruocThoiKhoaBieuColumn>
	{
	}
	
	#endregion DuTruGioGiangTruocThoiKhoaBieuExpressionBuilder	

	#region DuTruGioGiangTruocThoiKhoaBieuProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;DuTruGioGiangTruocThoiKhoaBieuChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="DuTruGioGiangTruocThoiKhoaBieu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DuTruGioGiangTruocThoiKhoaBieuProperty : ChildEntityProperty<DuTruGioGiangTruocThoiKhoaBieuChildEntityTypes>
	{
	}
	
	#endregion DuTruGioGiangTruocThoiKhoaBieuProperty
}

