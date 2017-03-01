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
	/// Represents the DataRepository.LopChatLuongCaoProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(LopChatLuongCaoDataSourceDesigner))]
	public class LopChatLuongCaoDataSource : ProviderDataSource<LopChatLuongCao, LopChatLuongCaoKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LopChatLuongCaoDataSource class.
		/// </summary>
		public LopChatLuongCaoDataSource() : base(new LopChatLuongCaoService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the LopChatLuongCaoDataSourceView used by the LopChatLuongCaoDataSource.
		/// </summary>
		protected LopChatLuongCaoDataSourceView LopChatLuongCaoView
		{
			get { return ( View as LopChatLuongCaoDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the LopChatLuongCaoDataSource control invokes to retrieve data.
		/// </summary>
		public LopChatLuongCaoSelectMethod SelectMethod
		{
			get
			{
				LopChatLuongCaoSelectMethod selectMethod = LopChatLuongCaoSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (LopChatLuongCaoSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the LopChatLuongCaoDataSourceView class that is to be
		/// used by the LopChatLuongCaoDataSource.
		/// </summary>
		/// <returns>An instance of the LopChatLuongCaoDataSourceView class.</returns>
		protected override BaseDataSourceView<LopChatLuongCao, LopChatLuongCaoKey> GetNewDataSourceView()
		{
			return new LopChatLuongCaoDataSourceView(this, DefaultViewName);
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
	/// Supports the LopChatLuongCaoDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class LopChatLuongCaoDataSourceView : ProviderDataSourceView<LopChatLuongCao, LopChatLuongCaoKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LopChatLuongCaoDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the LopChatLuongCaoDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public LopChatLuongCaoDataSourceView(LopChatLuongCaoDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal LopChatLuongCaoDataSource LopChatLuongCaoOwner
		{
			get { return Owner as LopChatLuongCaoDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal LopChatLuongCaoSelectMethod SelectMethod
		{
			get { return LopChatLuongCaoOwner.SelectMethod; }
			set { LopChatLuongCaoOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal LopChatLuongCaoService LopChatLuongCaoProvider
		{
			get { return Provider as LopChatLuongCaoService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<LopChatLuongCao> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<LopChatLuongCao> results = null;
			LopChatLuongCao item;
			count = 0;
			
			System.String _maLop;

			switch ( SelectMethod )
			{
				case LopChatLuongCaoSelectMethod.Get:
					LopChatLuongCaoKey entityKey  = new LopChatLuongCaoKey();
					entityKey.Load(values);
					item = LopChatLuongCaoProvider.Get(entityKey);
					results = new TList<LopChatLuongCao>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case LopChatLuongCaoSelectMethod.GetAll:
                    results = LopChatLuongCaoProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case LopChatLuongCaoSelectMethod.GetPaged:
					results = LopChatLuongCaoProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case LopChatLuongCaoSelectMethod.Find:
					if ( FilterParameters != null )
						results = LopChatLuongCaoProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = LopChatLuongCaoProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case LopChatLuongCaoSelectMethod.GetByMaLop:
					_maLop = ( values["MaLop"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaLop"], typeof(System.String)) : string.Empty;
					item = LopChatLuongCaoProvider.GetByMaLop(_maLop);
					results = new TList<LopChatLuongCao>();
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
			if ( SelectMethod == LopChatLuongCaoSelectMethod.Get || SelectMethod == LopChatLuongCaoSelectMethod.GetByMaLop )
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
				LopChatLuongCao entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					LopChatLuongCaoProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<LopChatLuongCao> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			LopChatLuongCaoProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region LopChatLuongCaoDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the LopChatLuongCaoDataSource class.
	/// </summary>
	public class LopChatLuongCaoDataSourceDesigner : ProviderDataSourceDesigner<LopChatLuongCao, LopChatLuongCaoKey>
	{
		/// <summary>
		/// Initializes a new instance of the LopChatLuongCaoDataSourceDesigner class.
		/// </summary>
		public LopChatLuongCaoDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public LopChatLuongCaoSelectMethod SelectMethod
		{
			get { return ((LopChatLuongCaoDataSource) DataSource).SelectMethod; }
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
				actions.Add(new LopChatLuongCaoDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region LopChatLuongCaoDataSourceActionList

	/// <summary>
	/// Supports the LopChatLuongCaoDataSourceDesigner class.
	/// </summary>
	internal class LopChatLuongCaoDataSourceActionList : DesignerActionList
	{
		private LopChatLuongCaoDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the LopChatLuongCaoDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public LopChatLuongCaoDataSourceActionList(LopChatLuongCaoDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public LopChatLuongCaoSelectMethod SelectMethod
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

	#endregion LopChatLuongCaoDataSourceActionList
	
	#endregion LopChatLuongCaoDataSourceDesigner
	
	#region LopChatLuongCaoSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the LopChatLuongCaoDataSource.SelectMethod property.
	/// </summary>
	public enum LopChatLuongCaoSelectMethod
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
		/// Represents the GetByMaLop method.
		/// </summary>
		GetByMaLop
	}
	
	#endregion LopChatLuongCaoSelectMethod

	#region LopChatLuongCaoFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LopChatLuongCao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LopChatLuongCaoFilter : SqlFilter<LopChatLuongCaoColumn>
	{
	}
	
	#endregion LopChatLuongCaoFilter

	#region LopChatLuongCaoExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LopChatLuongCao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LopChatLuongCaoExpressionBuilder : SqlExpressionBuilder<LopChatLuongCaoColumn>
	{
	}
	
	#endregion LopChatLuongCaoExpressionBuilder	

	#region LopChatLuongCaoProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;LopChatLuongCaoChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="LopChatLuongCao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LopChatLuongCaoProperty : ChildEntityProperty<LopChatLuongCaoChildEntityTypes>
	{
	}
	
	#endregion LopChatLuongCaoProperty
}

