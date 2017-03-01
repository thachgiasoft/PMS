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
	/// Represents the DataRepository.LopHocPhanGhepThoiKhoaBieuProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(LopHocPhanGhepThoiKhoaBieuDataSourceDesigner))]
	public class LopHocPhanGhepThoiKhoaBieuDataSource : ProviderDataSource<LopHocPhanGhepThoiKhoaBieu, LopHocPhanGhepThoiKhoaBieuKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LopHocPhanGhepThoiKhoaBieuDataSource class.
		/// </summary>
		public LopHocPhanGhepThoiKhoaBieuDataSource() : base(new LopHocPhanGhepThoiKhoaBieuService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the LopHocPhanGhepThoiKhoaBieuDataSourceView used by the LopHocPhanGhepThoiKhoaBieuDataSource.
		/// </summary>
		protected LopHocPhanGhepThoiKhoaBieuDataSourceView LopHocPhanGhepThoiKhoaBieuView
		{
			get { return ( View as LopHocPhanGhepThoiKhoaBieuDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the LopHocPhanGhepThoiKhoaBieuDataSource control invokes to retrieve data.
		/// </summary>
		public LopHocPhanGhepThoiKhoaBieuSelectMethod SelectMethod
		{
			get
			{
				LopHocPhanGhepThoiKhoaBieuSelectMethod selectMethod = LopHocPhanGhepThoiKhoaBieuSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (LopHocPhanGhepThoiKhoaBieuSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the LopHocPhanGhepThoiKhoaBieuDataSourceView class that is to be
		/// used by the LopHocPhanGhepThoiKhoaBieuDataSource.
		/// </summary>
		/// <returns>An instance of the LopHocPhanGhepThoiKhoaBieuDataSourceView class.</returns>
		protected override BaseDataSourceView<LopHocPhanGhepThoiKhoaBieu, LopHocPhanGhepThoiKhoaBieuKey> GetNewDataSourceView()
		{
			return new LopHocPhanGhepThoiKhoaBieuDataSourceView(this, DefaultViewName);
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
	/// Supports the LopHocPhanGhepThoiKhoaBieuDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class LopHocPhanGhepThoiKhoaBieuDataSourceView : ProviderDataSourceView<LopHocPhanGhepThoiKhoaBieu, LopHocPhanGhepThoiKhoaBieuKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LopHocPhanGhepThoiKhoaBieuDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the LopHocPhanGhepThoiKhoaBieuDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public LopHocPhanGhepThoiKhoaBieuDataSourceView(LopHocPhanGhepThoiKhoaBieuDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal LopHocPhanGhepThoiKhoaBieuDataSource LopHocPhanGhepThoiKhoaBieuOwner
		{
			get { return Owner as LopHocPhanGhepThoiKhoaBieuDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal LopHocPhanGhepThoiKhoaBieuSelectMethod SelectMethod
		{
			get { return LopHocPhanGhepThoiKhoaBieuOwner.SelectMethod; }
			set { LopHocPhanGhepThoiKhoaBieuOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal LopHocPhanGhepThoiKhoaBieuService LopHocPhanGhepThoiKhoaBieuProvider
		{
			get { return Provider as LopHocPhanGhepThoiKhoaBieuService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<LopHocPhanGhepThoiKhoaBieu> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<LopHocPhanGhepThoiKhoaBieu> results = null;
			LopHocPhanGhepThoiKhoaBieu item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case LopHocPhanGhepThoiKhoaBieuSelectMethod.Get:
					LopHocPhanGhepThoiKhoaBieuKey entityKey  = new LopHocPhanGhepThoiKhoaBieuKey();
					entityKey.Load(values);
					item = LopHocPhanGhepThoiKhoaBieuProvider.Get(entityKey);
					results = new TList<LopHocPhanGhepThoiKhoaBieu>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case LopHocPhanGhepThoiKhoaBieuSelectMethod.GetAll:
                    results = LopHocPhanGhepThoiKhoaBieuProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case LopHocPhanGhepThoiKhoaBieuSelectMethod.GetPaged:
					results = LopHocPhanGhepThoiKhoaBieuProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case LopHocPhanGhepThoiKhoaBieuSelectMethod.Find:
					if ( FilterParameters != null )
						results = LopHocPhanGhepThoiKhoaBieuProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = LopHocPhanGhepThoiKhoaBieuProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case LopHocPhanGhepThoiKhoaBieuSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = LopHocPhanGhepThoiKhoaBieuProvider.GetById(_id);
					results = new TList<LopHocPhanGhepThoiKhoaBieu>();
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
			if ( SelectMethod == LopHocPhanGhepThoiKhoaBieuSelectMethod.Get || SelectMethod == LopHocPhanGhepThoiKhoaBieuSelectMethod.GetById )
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
				LopHocPhanGhepThoiKhoaBieu entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					LopHocPhanGhepThoiKhoaBieuProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<LopHocPhanGhepThoiKhoaBieu> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			LopHocPhanGhepThoiKhoaBieuProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region LopHocPhanGhepThoiKhoaBieuDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the LopHocPhanGhepThoiKhoaBieuDataSource class.
	/// </summary>
	public class LopHocPhanGhepThoiKhoaBieuDataSourceDesigner : ProviderDataSourceDesigner<LopHocPhanGhepThoiKhoaBieu, LopHocPhanGhepThoiKhoaBieuKey>
	{
		/// <summary>
		/// Initializes a new instance of the LopHocPhanGhepThoiKhoaBieuDataSourceDesigner class.
		/// </summary>
		public LopHocPhanGhepThoiKhoaBieuDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public LopHocPhanGhepThoiKhoaBieuSelectMethod SelectMethod
		{
			get { return ((LopHocPhanGhepThoiKhoaBieuDataSource) DataSource).SelectMethod; }
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
				actions.Add(new LopHocPhanGhepThoiKhoaBieuDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region LopHocPhanGhepThoiKhoaBieuDataSourceActionList

	/// <summary>
	/// Supports the LopHocPhanGhepThoiKhoaBieuDataSourceDesigner class.
	/// </summary>
	internal class LopHocPhanGhepThoiKhoaBieuDataSourceActionList : DesignerActionList
	{
		private LopHocPhanGhepThoiKhoaBieuDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the LopHocPhanGhepThoiKhoaBieuDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public LopHocPhanGhepThoiKhoaBieuDataSourceActionList(LopHocPhanGhepThoiKhoaBieuDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public LopHocPhanGhepThoiKhoaBieuSelectMethod SelectMethod
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

	#endregion LopHocPhanGhepThoiKhoaBieuDataSourceActionList
	
	#endregion LopHocPhanGhepThoiKhoaBieuDataSourceDesigner
	
	#region LopHocPhanGhepThoiKhoaBieuSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the LopHocPhanGhepThoiKhoaBieuDataSource.SelectMethod property.
	/// </summary>
	public enum LopHocPhanGhepThoiKhoaBieuSelectMethod
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
	
	#endregion LopHocPhanGhepThoiKhoaBieuSelectMethod

	#region LopHocPhanGhepThoiKhoaBieuFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanGhepThoiKhoaBieu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LopHocPhanGhepThoiKhoaBieuFilter : SqlFilter<LopHocPhanGhepThoiKhoaBieuColumn>
	{
	}
	
	#endregion LopHocPhanGhepThoiKhoaBieuFilter

	#region LopHocPhanGhepThoiKhoaBieuExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanGhepThoiKhoaBieu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LopHocPhanGhepThoiKhoaBieuExpressionBuilder : SqlExpressionBuilder<LopHocPhanGhepThoiKhoaBieuColumn>
	{
	}
	
	#endregion LopHocPhanGhepThoiKhoaBieuExpressionBuilder	

	#region LopHocPhanGhepThoiKhoaBieuProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;LopHocPhanGhepThoiKhoaBieuChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanGhepThoiKhoaBieu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LopHocPhanGhepThoiKhoaBieuProperty : ChildEntityProperty<LopHocPhanGhepThoiKhoaBieuChildEntityTypes>
	{
	}
	
	#endregion LopHocPhanGhepThoiKhoaBieuProperty
}

