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
	/// Represents the DataRepository.HeSoQuyDoiTinChiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(HeSoQuyDoiTinChiDataSourceDesigner))]
	public class HeSoQuyDoiTinChiDataSource : ProviderDataSource<HeSoQuyDoiTinChi, HeSoQuyDoiTinChiKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoQuyDoiTinChiDataSource class.
		/// </summary>
		public HeSoQuyDoiTinChiDataSource() : base(new HeSoQuyDoiTinChiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the HeSoQuyDoiTinChiDataSourceView used by the HeSoQuyDoiTinChiDataSource.
		/// </summary>
		protected HeSoQuyDoiTinChiDataSourceView HeSoQuyDoiTinChiView
		{
			get { return ( View as HeSoQuyDoiTinChiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the HeSoQuyDoiTinChiDataSource control invokes to retrieve data.
		/// </summary>
		public HeSoQuyDoiTinChiSelectMethod SelectMethod
		{
			get
			{
				HeSoQuyDoiTinChiSelectMethod selectMethod = HeSoQuyDoiTinChiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (HeSoQuyDoiTinChiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the HeSoQuyDoiTinChiDataSourceView class that is to be
		/// used by the HeSoQuyDoiTinChiDataSource.
		/// </summary>
		/// <returns>An instance of the HeSoQuyDoiTinChiDataSourceView class.</returns>
		protected override BaseDataSourceView<HeSoQuyDoiTinChi, HeSoQuyDoiTinChiKey> GetNewDataSourceView()
		{
			return new HeSoQuyDoiTinChiDataSourceView(this, DefaultViewName);
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
	/// Supports the HeSoQuyDoiTinChiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class HeSoQuyDoiTinChiDataSourceView : ProviderDataSourceView<HeSoQuyDoiTinChi, HeSoQuyDoiTinChiKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoQuyDoiTinChiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the HeSoQuyDoiTinChiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public HeSoQuyDoiTinChiDataSourceView(HeSoQuyDoiTinChiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal HeSoQuyDoiTinChiDataSource HeSoQuyDoiTinChiOwner
		{
			get { return Owner as HeSoQuyDoiTinChiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal HeSoQuyDoiTinChiSelectMethod SelectMethod
		{
			get { return HeSoQuyDoiTinChiOwner.SelectMethod; }
			set { HeSoQuyDoiTinChiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal HeSoQuyDoiTinChiService HeSoQuyDoiTinChiProvider
		{
			get { return Provider as HeSoQuyDoiTinChiService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<HeSoQuyDoiTinChi> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<HeSoQuyDoiTinChi> results = null;
			HeSoQuyDoiTinChi item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case HeSoQuyDoiTinChiSelectMethod.Get:
					HeSoQuyDoiTinChiKey entityKey  = new HeSoQuyDoiTinChiKey();
					entityKey.Load(values);
					item = HeSoQuyDoiTinChiProvider.Get(entityKey);
					results = new TList<HeSoQuyDoiTinChi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case HeSoQuyDoiTinChiSelectMethod.GetAll:
                    results = HeSoQuyDoiTinChiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case HeSoQuyDoiTinChiSelectMethod.GetPaged:
					results = HeSoQuyDoiTinChiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case HeSoQuyDoiTinChiSelectMethod.Find:
					if ( FilterParameters != null )
						results = HeSoQuyDoiTinChiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = HeSoQuyDoiTinChiProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case HeSoQuyDoiTinChiSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = HeSoQuyDoiTinChiProvider.GetById(_id);
					results = new TList<HeSoQuyDoiTinChi>();
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
			if ( SelectMethod == HeSoQuyDoiTinChiSelectMethod.Get || SelectMethod == HeSoQuyDoiTinChiSelectMethod.GetById )
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
				HeSoQuyDoiTinChi entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					HeSoQuyDoiTinChiProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<HeSoQuyDoiTinChi> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			HeSoQuyDoiTinChiProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region HeSoQuyDoiTinChiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the HeSoQuyDoiTinChiDataSource class.
	/// </summary>
	public class HeSoQuyDoiTinChiDataSourceDesigner : ProviderDataSourceDesigner<HeSoQuyDoiTinChi, HeSoQuyDoiTinChiKey>
	{
		/// <summary>
		/// Initializes a new instance of the HeSoQuyDoiTinChiDataSourceDesigner class.
		/// </summary>
		public HeSoQuyDoiTinChiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoQuyDoiTinChiSelectMethod SelectMethod
		{
			get { return ((HeSoQuyDoiTinChiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new HeSoQuyDoiTinChiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region HeSoQuyDoiTinChiDataSourceActionList

	/// <summary>
	/// Supports the HeSoQuyDoiTinChiDataSourceDesigner class.
	/// </summary>
	internal class HeSoQuyDoiTinChiDataSourceActionList : DesignerActionList
	{
		private HeSoQuyDoiTinChiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the HeSoQuyDoiTinChiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public HeSoQuyDoiTinChiDataSourceActionList(HeSoQuyDoiTinChiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoQuyDoiTinChiSelectMethod SelectMethod
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

	#endregion HeSoQuyDoiTinChiDataSourceActionList
	
	#endregion HeSoQuyDoiTinChiDataSourceDesigner
	
	#region HeSoQuyDoiTinChiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the HeSoQuyDoiTinChiDataSource.SelectMethod property.
	/// </summary>
	public enum HeSoQuyDoiTinChiSelectMethod
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
	
	#endregion HeSoQuyDoiTinChiSelectMethod

	#region HeSoQuyDoiTinChiFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoQuyDoiTinChi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoQuyDoiTinChiFilter : SqlFilter<HeSoQuyDoiTinChiColumn>
	{
	}
	
	#endregion HeSoQuyDoiTinChiFilter

	#region HeSoQuyDoiTinChiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoQuyDoiTinChi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoQuyDoiTinChiExpressionBuilder : SqlExpressionBuilder<HeSoQuyDoiTinChiColumn>
	{
	}
	
	#endregion HeSoQuyDoiTinChiExpressionBuilder	

	#region HeSoQuyDoiTinChiProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;HeSoQuyDoiTinChiChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoQuyDoiTinChi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoQuyDoiTinChiProperty : ChildEntityProperty<HeSoQuyDoiTinChiChildEntityTypes>
	{
	}
	
	#endregion HeSoQuyDoiTinChiProperty
}

