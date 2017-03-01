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
	/// Represents the DataRepository.HeSoLuongProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(HeSoLuongDataSourceDesigner))]
	public class HeSoLuongDataSource : ProviderDataSource<HeSoLuong, HeSoLuongKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoLuongDataSource class.
		/// </summary>
		public HeSoLuongDataSource() : base(new HeSoLuongService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the HeSoLuongDataSourceView used by the HeSoLuongDataSource.
		/// </summary>
		protected HeSoLuongDataSourceView HeSoLuongView
		{
			get { return ( View as HeSoLuongDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the HeSoLuongDataSource control invokes to retrieve data.
		/// </summary>
		public HeSoLuongSelectMethod SelectMethod
		{
			get
			{
				HeSoLuongSelectMethod selectMethod = HeSoLuongSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (HeSoLuongSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the HeSoLuongDataSourceView class that is to be
		/// used by the HeSoLuongDataSource.
		/// </summary>
		/// <returns>An instance of the HeSoLuongDataSourceView class.</returns>
		protected override BaseDataSourceView<HeSoLuong, HeSoLuongKey> GetNewDataSourceView()
		{
			return new HeSoLuongDataSourceView(this, DefaultViewName);
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
	/// Supports the HeSoLuongDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class HeSoLuongDataSourceView : ProviderDataSourceView<HeSoLuong, HeSoLuongKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoLuongDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the HeSoLuongDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public HeSoLuongDataSourceView(HeSoLuongDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal HeSoLuongDataSource HeSoLuongOwner
		{
			get { return Owner as HeSoLuongDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal HeSoLuongSelectMethod SelectMethod
		{
			get { return HeSoLuongOwner.SelectMethod; }
			set { HeSoLuongOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal HeSoLuongService HeSoLuongProvider
		{
			get { return Provider as HeSoLuongService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<HeSoLuong> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<HeSoLuong> results = null;
			HeSoLuong item;
			count = 0;
			
			System.Int32 _maHeSo;

			switch ( SelectMethod )
			{
				case HeSoLuongSelectMethod.Get:
					HeSoLuongKey entityKey  = new HeSoLuongKey();
					entityKey.Load(values);
					item = HeSoLuongProvider.Get(entityKey);
					results = new TList<HeSoLuong>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case HeSoLuongSelectMethod.GetAll:
                    results = HeSoLuongProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case HeSoLuongSelectMethod.GetPaged:
					results = HeSoLuongProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case HeSoLuongSelectMethod.Find:
					if ( FilterParameters != null )
						results = HeSoLuongProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = HeSoLuongProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case HeSoLuongSelectMethod.GetByMaHeSo:
					_maHeSo = ( values["MaHeSo"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaHeSo"], typeof(System.Int32)) : (int)0;
					item = HeSoLuongProvider.GetByMaHeSo(_maHeSo);
					results = new TList<HeSoLuong>();
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
			if ( SelectMethod == HeSoLuongSelectMethod.Get || SelectMethod == HeSoLuongSelectMethod.GetByMaHeSo )
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
				HeSoLuong entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					HeSoLuongProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<HeSoLuong> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			HeSoLuongProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region HeSoLuongDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the HeSoLuongDataSource class.
	/// </summary>
	public class HeSoLuongDataSourceDesigner : ProviderDataSourceDesigner<HeSoLuong, HeSoLuongKey>
	{
		/// <summary>
		/// Initializes a new instance of the HeSoLuongDataSourceDesigner class.
		/// </summary>
		public HeSoLuongDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoLuongSelectMethod SelectMethod
		{
			get { return ((HeSoLuongDataSource) DataSource).SelectMethod; }
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
				actions.Add(new HeSoLuongDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region HeSoLuongDataSourceActionList

	/// <summary>
	/// Supports the HeSoLuongDataSourceDesigner class.
	/// </summary>
	internal class HeSoLuongDataSourceActionList : DesignerActionList
	{
		private HeSoLuongDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the HeSoLuongDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public HeSoLuongDataSourceActionList(HeSoLuongDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoLuongSelectMethod SelectMethod
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

	#endregion HeSoLuongDataSourceActionList
	
	#endregion HeSoLuongDataSourceDesigner
	
	#region HeSoLuongSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the HeSoLuongDataSource.SelectMethod property.
	/// </summary>
	public enum HeSoLuongSelectMethod
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
		/// Represents the GetByMaHeSo method.
		/// </summary>
		GetByMaHeSo
	}
	
	#endregion HeSoLuongSelectMethod

	#region HeSoLuongFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoLuongFilter : SqlFilter<HeSoLuongColumn>
	{
	}
	
	#endregion HeSoLuongFilter

	#region HeSoLuongExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoLuongExpressionBuilder : SqlExpressionBuilder<HeSoLuongColumn>
	{
	}
	
	#endregion HeSoLuongExpressionBuilder	

	#region HeSoLuongProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;HeSoLuongChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoLuongProperty : ChildEntityProperty<HeSoLuongChildEntityTypes>
	{
	}
	
	#endregion HeSoLuongProperty
}

