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
	/// Represents the DataRepository.HeSoQuyDoiGioChuanProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(HeSoQuyDoiGioChuanDataSourceDesigner))]
	public class HeSoQuyDoiGioChuanDataSource : ProviderDataSource<HeSoQuyDoiGioChuan, HeSoQuyDoiGioChuanKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoQuyDoiGioChuanDataSource class.
		/// </summary>
		public HeSoQuyDoiGioChuanDataSource() : base(new HeSoQuyDoiGioChuanService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the HeSoQuyDoiGioChuanDataSourceView used by the HeSoQuyDoiGioChuanDataSource.
		/// </summary>
		protected HeSoQuyDoiGioChuanDataSourceView HeSoQuyDoiGioChuanView
		{
			get { return ( View as HeSoQuyDoiGioChuanDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the HeSoQuyDoiGioChuanDataSource control invokes to retrieve data.
		/// </summary>
		public HeSoQuyDoiGioChuanSelectMethod SelectMethod
		{
			get
			{
				HeSoQuyDoiGioChuanSelectMethod selectMethod = HeSoQuyDoiGioChuanSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (HeSoQuyDoiGioChuanSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the HeSoQuyDoiGioChuanDataSourceView class that is to be
		/// used by the HeSoQuyDoiGioChuanDataSource.
		/// </summary>
		/// <returns>An instance of the HeSoQuyDoiGioChuanDataSourceView class.</returns>
		protected override BaseDataSourceView<HeSoQuyDoiGioChuan, HeSoQuyDoiGioChuanKey> GetNewDataSourceView()
		{
			return new HeSoQuyDoiGioChuanDataSourceView(this, DefaultViewName);
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
	/// Supports the HeSoQuyDoiGioChuanDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class HeSoQuyDoiGioChuanDataSourceView : ProviderDataSourceView<HeSoQuyDoiGioChuan, HeSoQuyDoiGioChuanKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoQuyDoiGioChuanDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the HeSoQuyDoiGioChuanDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public HeSoQuyDoiGioChuanDataSourceView(HeSoQuyDoiGioChuanDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal HeSoQuyDoiGioChuanDataSource HeSoQuyDoiGioChuanOwner
		{
			get { return Owner as HeSoQuyDoiGioChuanDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal HeSoQuyDoiGioChuanSelectMethod SelectMethod
		{
			get { return HeSoQuyDoiGioChuanOwner.SelectMethod; }
			set { HeSoQuyDoiGioChuanOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal HeSoQuyDoiGioChuanService HeSoQuyDoiGioChuanProvider
		{
			get { return Provider as HeSoQuyDoiGioChuanService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<HeSoQuyDoiGioChuan> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<HeSoQuyDoiGioChuan> results = null;
			HeSoQuyDoiGioChuan item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case HeSoQuyDoiGioChuanSelectMethod.Get:
					HeSoQuyDoiGioChuanKey entityKey  = new HeSoQuyDoiGioChuanKey();
					entityKey.Load(values);
					item = HeSoQuyDoiGioChuanProvider.Get(entityKey);
					results = new TList<HeSoQuyDoiGioChuan>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case HeSoQuyDoiGioChuanSelectMethod.GetAll:
                    results = HeSoQuyDoiGioChuanProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case HeSoQuyDoiGioChuanSelectMethod.GetPaged:
					results = HeSoQuyDoiGioChuanProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case HeSoQuyDoiGioChuanSelectMethod.Find:
					if ( FilterParameters != null )
						results = HeSoQuyDoiGioChuanProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = HeSoQuyDoiGioChuanProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case HeSoQuyDoiGioChuanSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = HeSoQuyDoiGioChuanProvider.GetById(_id);
					results = new TList<HeSoQuyDoiGioChuan>();
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
			if ( SelectMethod == HeSoQuyDoiGioChuanSelectMethod.Get || SelectMethod == HeSoQuyDoiGioChuanSelectMethod.GetById )
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
				HeSoQuyDoiGioChuan entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					HeSoQuyDoiGioChuanProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<HeSoQuyDoiGioChuan> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			HeSoQuyDoiGioChuanProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region HeSoQuyDoiGioChuanDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the HeSoQuyDoiGioChuanDataSource class.
	/// </summary>
	public class HeSoQuyDoiGioChuanDataSourceDesigner : ProviderDataSourceDesigner<HeSoQuyDoiGioChuan, HeSoQuyDoiGioChuanKey>
	{
		/// <summary>
		/// Initializes a new instance of the HeSoQuyDoiGioChuanDataSourceDesigner class.
		/// </summary>
		public HeSoQuyDoiGioChuanDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoQuyDoiGioChuanSelectMethod SelectMethod
		{
			get { return ((HeSoQuyDoiGioChuanDataSource) DataSource).SelectMethod; }
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
				actions.Add(new HeSoQuyDoiGioChuanDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region HeSoQuyDoiGioChuanDataSourceActionList

	/// <summary>
	/// Supports the HeSoQuyDoiGioChuanDataSourceDesigner class.
	/// </summary>
	internal class HeSoQuyDoiGioChuanDataSourceActionList : DesignerActionList
	{
		private HeSoQuyDoiGioChuanDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the HeSoQuyDoiGioChuanDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public HeSoQuyDoiGioChuanDataSourceActionList(HeSoQuyDoiGioChuanDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoQuyDoiGioChuanSelectMethod SelectMethod
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

	#endregion HeSoQuyDoiGioChuanDataSourceActionList
	
	#endregion HeSoQuyDoiGioChuanDataSourceDesigner
	
	#region HeSoQuyDoiGioChuanSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the HeSoQuyDoiGioChuanDataSource.SelectMethod property.
	/// </summary>
	public enum HeSoQuyDoiGioChuanSelectMethod
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
	
	#endregion HeSoQuyDoiGioChuanSelectMethod

	#region HeSoQuyDoiGioChuanFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoQuyDoiGioChuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoQuyDoiGioChuanFilter : SqlFilter<HeSoQuyDoiGioChuanColumn>
	{
	}
	
	#endregion HeSoQuyDoiGioChuanFilter

	#region HeSoQuyDoiGioChuanExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoQuyDoiGioChuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoQuyDoiGioChuanExpressionBuilder : SqlExpressionBuilder<HeSoQuyDoiGioChuanColumn>
	{
	}
	
	#endregion HeSoQuyDoiGioChuanExpressionBuilder	

	#region HeSoQuyDoiGioChuanProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;HeSoQuyDoiGioChuanChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoQuyDoiGioChuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoQuyDoiGioChuanProperty : ChildEntityProperty<HeSoQuyDoiGioChuanChildEntityTypes>
	{
	}
	
	#endregion HeSoQuyDoiGioChuanProperty
}

