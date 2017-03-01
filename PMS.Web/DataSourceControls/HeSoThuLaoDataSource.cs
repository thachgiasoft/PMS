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
	/// Represents the DataRepository.HeSoThuLaoProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(HeSoThuLaoDataSourceDesigner))]
	public class HeSoThuLaoDataSource : ProviderDataSource<HeSoThuLao, HeSoThuLaoKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoThuLaoDataSource class.
		/// </summary>
		public HeSoThuLaoDataSource() : base(new HeSoThuLaoService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the HeSoThuLaoDataSourceView used by the HeSoThuLaoDataSource.
		/// </summary>
		protected HeSoThuLaoDataSourceView HeSoThuLaoView
		{
			get { return ( View as HeSoThuLaoDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the HeSoThuLaoDataSource control invokes to retrieve data.
		/// </summary>
		public HeSoThuLaoSelectMethod SelectMethod
		{
			get
			{
				HeSoThuLaoSelectMethod selectMethod = HeSoThuLaoSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (HeSoThuLaoSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the HeSoThuLaoDataSourceView class that is to be
		/// used by the HeSoThuLaoDataSource.
		/// </summary>
		/// <returns>An instance of the HeSoThuLaoDataSourceView class.</returns>
		protected override BaseDataSourceView<HeSoThuLao, HeSoThuLaoKey> GetNewDataSourceView()
		{
			return new HeSoThuLaoDataSourceView(this, DefaultViewName);
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
	/// Supports the HeSoThuLaoDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class HeSoThuLaoDataSourceView : ProviderDataSourceView<HeSoThuLao, HeSoThuLaoKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoThuLaoDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the HeSoThuLaoDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public HeSoThuLaoDataSourceView(HeSoThuLaoDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal HeSoThuLaoDataSource HeSoThuLaoOwner
		{
			get { return Owner as HeSoThuLaoDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal HeSoThuLaoSelectMethod SelectMethod
		{
			get { return HeSoThuLaoOwner.SelectMethod; }
			set { HeSoThuLaoOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal HeSoThuLaoService HeSoThuLaoProvider
		{
			get { return Provider as HeSoThuLaoService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<HeSoThuLao> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<HeSoThuLao> results = null;
			HeSoThuLao item;
			count = 0;
			
			System.String _maThuLao;

			switch ( SelectMethod )
			{
				case HeSoThuLaoSelectMethod.Get:
					HeSoThuLaoKey entityKey  = new HeSoThuLaoKey();
					entityKey.Load(values);
					item = HeSoThuLaoProvider.Get(entityKey);
					results = new TList<HeSoThuLao>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case HeSoThuLaoSelectMethod.GetAll:
                    results = HeSoThuLaoProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case HeSoThuLaoSelectMethod.GetPaged:
					results = HeSoThuLaoProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case HeSoThuLaoSelectMethod.Find:
					if ( FilterParameters != null )
						results = HeSoThuLaoProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = HeSoThuLaoProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case HeSoThuLaoSelectMethod.GetByMaThuLao:
					_maThuLao = ( values["MaThuLao"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaThuLao"], typeof(System.String)) : string.Empty;
					item = HeSoThuLaoProvider.GetByMaThuLao(_maThuLao);
					results = new TList<HeSoThuLao>();
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
			if ( SelectMethod == HeSoThuLaoSelectMethod.Get || SelectMethod == HeSoThuLaoSelectMethod.GetByMaThuLao )
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
				HeSoThuLao entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					HeSoThuLaoProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<HeSoThuLao> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			HeSoThuLaoProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region HeSoThuLaoDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the HeSoThuLaoDataSource class.
	/// </summary>
	public class HeSoThuLaoDataSourceDesigner : ProviderDataSourceDesigner<HeSoThuLao, HeSoThuLaoKey>
	{
		/// <summary>
		/// Initializes a new instance of the HeSoThuLaoDataSourceDesigner class.
		/// </summary>
		public HeSoThuLaoDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoThuLaoSelectMethod SelectMethod
		{
			get { return ((HeSoThuLaoDataSource) DataSource).SelectMethod; }
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
				actions.Add(new HeSoThuLaoDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region HeSoThuLaoDataSourceActionList

	/// <summary>
	/// Supports the HeSoThuLaoDataSourceDesigner class.
	/// </summary>
	internal class HeSoThuLaoDataSourceActionList : DesignerActionList
	{
		private HeSoThuLaoDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the HeSoThuLaoDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public HeSoThuLaoDataSourceActionList(HeSoThuLaoDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoThuLaoSelectMethod SelectMethod
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

	#endregion HeSoThuLaoDataSourceActionList
	
	#endregion HeSoThuLaoDataSourceDesigner
	
	#region HeSoThuLaoSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the HeSoThuLaoDataSource.SelectMethod property.
	/// </summary>
	public enum HeSoThuLaoSelectMethod
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
		/// Represents the GetByMaThuLao method.
		/// </summary>
		GetByMaThuLao
	}
	
	#endregion HeSoThuLaoSelectMethod

	#region HeSoThuLaoFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoThuLaoFilter : SqlFilter<HeSoThuLaoColumn>
	{
	}
	
	#endregion HeSoThuLaoFilter

	#region HeSoThuLaoExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoThuLaoExpressionBuilder : SqlExpressionBuilder<HeSoThuLaoColumn>
	{
	}
	
	#endregion HeSoThuLaoExpressionBuilder	

	#region HeSoThuLaoProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;HeSoThuLaoChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoThuLaoProperty : ChildEntityProperty<HeSoThuLaoChildEntityTypes>
	{
	}
	
	#endregion HeSoThuLaoProperty
}

