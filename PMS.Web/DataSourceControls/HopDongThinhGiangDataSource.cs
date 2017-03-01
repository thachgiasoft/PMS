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
	/// Represents the DataRepository.HopDongThinhGiangProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(HopDongThinhGiangDataSourceDesigner))]
	public class HopDongThinhGiangDataSource : ProviderDataSource<HopDongThinhGiang, HopDongThinhGiangKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HopDongThinhGiangDataSource class.
		/// </summary>
		public HopDongThinhGiangDataSource() : base(new HopDongThinhGiangService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the HopDongThinhGiangDataSourceView used by the HopDongThinhGiangDataSource.
		/// </summary>
		protected HopDongThinhGiangDataSourceView HopDongThinhGiangView
		{
			get { return ( View as HopDongThinhGiangDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the HopDongThinhGiangDataSource control invokes to retrieve data.
		/// </summary>
		public HopDongThinhGiangSelectMethod SelectMethod
		{
			get
			{
				HopDongThinhGiangSelectMethod selectMethod = HopDongThinhGiangSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (HopDongThinhGiangSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the HopDongThinhGiangDataSourceView class that is to be
		/// used by the HopDongThinhGiangDataSource.
		/// </summary>
		/// <returns>An instance of the HopDongThinhGiangDataSourceView class.</returns>
		protected override BaseDataSourceView<HopDongThinhGiang, HopDongThinhGiangKey> GetNewDataSourceView()
		{
			return new HopDongThinhGiangDataSourceView(this, DefaultViewName);
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
	/// Supports the HopDongThinhGiangDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class HopDongThinhGiangDataSourceView : ProviderDataSourceView<HopDongThinhGiang, HopDongThinhGiangKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HopDongThinhGiangDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the HopDongThinhGiangDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public HopDongThinhGiangDataSourceView(HopDongThinhGiangDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal HopDongThinhGiangDataSource HopDongThinhGiangOwner
		{
			get { return Owner as HopDongThinhGiangDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal HopDongThinhGiangSelectMethod SelectMethod
		{
			get { return HopDongThinhGiangOwner.SelectMethod; }
			set { HopDongThinhGiangOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal HopDongThinhGiangService HopDongThinhGiangProvider
		{
			get { return Provider as HopDongThinhGiangService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<HopDongThinhGiang> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<HopDongThinhGiang> results = null;
			HopDongThinhGiang item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case HopDongThinhGiangSelectMethod.Get:
					HopDongThinhGiangKey entityKey  = new HopDongThinhGiangKey();
					entityKey.Load(values);
					item = HopDongThinhGiangProvider.Get(entityKey);
					results = new TList<HopDongThinhGiang>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case HopDongThinhGiangSelectMethod.GetAll:
                    results = HopDongThinhGiangProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case HopDongThinhGiangSelectMethod.GetPaged:
					results = HopDongThinhGiangProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case HopDongThinhGiangSelectMethod.Find:
					if ( FilterParameters != null )
						results = HopDongThinhGiangProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = HopDongThinhGiangProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case HopDongThinhGiangSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = HopDongThinhGiangProvider.GetById(_id);
					results = new TList<HopDongThinhGiang>();
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
			if ( SelectMethod == HopDongThinhGiangSelectMethod.Get || SelectMethod == HopDongThinhGiangSelectMethod.GetById )
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
				HopDongThinhGiang entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					HopDongThinhGiangProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<HopDongThinhGiang> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			HopDongThinhGiangProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region HopDongThinhGiangDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the HopDongThinhGiangDataSource class.
	/// </summary>
	public class HopDongThinhGiangDataSourceDesigner : ProviderDataSourceDesigner<HopDongThinhGiang, HopDongThinhGiangKey>
	{
		/// <summary>
		/// Initializes a new instance of the HopDongThinhGiangDataSourceDesigner class.
		/// </summary>
		public HopDongThinhGiangDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HopDongThinhGiangSelectMethod SelectMethod
		{
			get { return ((HopDongThinhGiangDataSource) DataSource).SelectMethod; }
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
				actions.Add(new HopDongThinhGiangDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region HopDongThinhGiangDataSourceActionList

	/// <summary>
	/// Supports the HopDongThinhGiangDataSourceDesigner class.
	/// </summary>
	internal class HopDongThinhGiangDataSourceActionList : DesignerActionList
	{
		private HopDongThinhGiangDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the HopDongThinhGiangDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public HopDongThinhGiangDataSourceActionList(HopDongThinhGiangDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HopDongThinhGiangSelectMethod SelectMethod
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

	#endregion HopDongThinhGiangDataSourceActionList
	
	#endregion HopDongThinhGiangDataSourceDesigner
	
	#region HopDongThinhGiangSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the HopDongThinhGiangDataSource.SelectMethod property.
	/// </summary>
	public enum HopDongThinhGiangSelectMethod
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
	
	#endregion HopDongThinhGiangSelectMethod

	#region HopDongThinhGiangFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HopDongThinhGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HopDongThinhGiangFilter : SqlFilter<HopDongThinhGiangColumn>
	{
	}
	
	#endregion HopDongThinhGiangFilter

	#region HopDongThinhGiangExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HopDongThinhGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HopDongThinhGiangExpressionBuilder : SqlExpressionBuilder<HopDongThinhGiangColumn>
	{
	}
	
	#endregion HopDongThinhGiangExpressionBuilder	

	#region HopDongThinhGiangProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;HopDongThinhGiangChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="HopDongThinhGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HopDongThinhGiangProperty : ChildEntityProperty<HopDongThinhGiangChildEntityTypes>
	{
	}
	
	#endregion HopDongThinhGiangProperty
}

