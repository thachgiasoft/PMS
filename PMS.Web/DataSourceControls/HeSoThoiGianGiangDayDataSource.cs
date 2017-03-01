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
	/// Represents the DataRepository.HeSoThoiGianGiangDayProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(HeSoThoiGianGiangDayDataSourceDesigner))]
	public class HeSoThoiGianGiangDayDataSource : ProviderDataSource<HeSoThoiGianGiangDay, HeSoThoiGianGiangDayKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoThoiGianGiangDayDataSource class.
		/// </summary>
		public HeSoThoiGianGiangDayDataSource() : base(new HeSoThoiGianGiangDayService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the HeSoThoiGianGiangDayDataSourceView used by the HeSoThoiGianGiangDayDataSource.
		/// </summary>
		protected HeSoThoiGianGiangDayDataSourceView HeSoThoiGianGiangDayView
		{
			get { return ( View as HeSoThoiGianGiangDayDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the HeSoThoiGianGiangDayDataSource control invokes to retrieve data.
		/// </summary>
		public HeSoThoiGianGiangDaySelectMethod SelectMethod
		{
			get
			{
				HeSoThoiGianGiangDaySelectMethod selectMethod = HeSoThoiGianGiangDaySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (HeSoThoiGianGiangDaySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the HeSoThoiGianGiangDayDataSourceView class that is to be
		/// used by the HeSoThoiGianGiangDayDataSource.
		/// </summary>
		/// <returns>An instance of the HeSoThoiGianGiangDayDataSourceView class.</returns>
		protected override BaseDataSourceView<HeSoThoiGianGiangDay, HeSoThoiGianGiangDayKey> GetNewDataSourceView()
		{
			return new HeSoThoiGianGiangDayDataSourceView(this, DefaultViewName);
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
	/// Supports the HeSoThoiGianGiangDayDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class HeSoThoiGianGiangDayDataSourceView : ProviderDataSourceView<HeSoThoiGianGiangDay, HeSoThoiGianGiangDayKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoThoiGianGiangDayDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the HeSoThoiGianGiangDayDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public HeSoThoiGianGiangDayDataSourceView(HeSoThoiGianGiangDayDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal HeSoThoiGianGiangDayDataSource HeSoThoiGianGiangDayOwner
		{
			get { return Owner as HeSoThoiGianGiangDayDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal HeSoThoiGianGiangDaySelectMethod SelectMethod
		{
			get { return HeSoThoiGianGiangDayOwner.SelectMethod; }
			set { HeSoThoiGianGiangDayOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal HeSoThoiGianGiangDayService HeSoThoiGianGiangDayProvider
		{
			get { return Provider as HeSoThoiGianGiangDayService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<HeSoThoiGianGiangDay> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<HeSoThoiGianGiangDay> results = null;
			HeSoThoiGianGiangDay item;
			count = 0;
			
			System.Int32 _maHeSo;

			switch ( SelectMethod )
			{
				case HeSoThoiGianGiangDaySelectMethod.Get:
					HeSoThoiGianGiangDayKey entityKey  = new HeSoThoiGianGiangDayKey();
					entityKey.Load(values);
					item = HeSoThoiGianGiangDayProvider.Get(entityKey);
					results = new TList<HeSoThoiGianGiangDay>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case HeSoThoiGianGiangDaySelectMethod.GetAll:
                    results = HeSoThoiGianGiangDayProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case HeSoThoiGianGiangDaySelectMethod.GetPaged:
					results = HeSoThoiGianGiangDayProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case HeSoThoiGianGiangDaySelectMethod.Find:
					if ( FilterParameters != null )
						results = HeSoThoiGianGiangDayProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = HeSoThoiGianGiangDayProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case HeSoThoiGianGiangDaySelectMethod.GetByMaHeSo:
					_maHeSo = ( values["MaHeSo"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaHeSo"], typeof(System.Int32)) : (int)0;
					item = HeSoThoiGianGiangDayProvider.GetByMaHeSo(_maHeSo);
					results = new TList<HeSoThoiGianGiangDay>();
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
			if ( SelectMethod == HeSoThoiGianGiangDaySelectMethod.Get || SelectMethod == HeSoThoiGianGiangDaySelectMethod.GetByMaHeSo )
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
				HeSoThoiGianGiangDay entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					HeSoThoiGianGiangDayProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<HeSoThoiGianGiangDay> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			HeSoThoiGianGiangDayProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region HeSoThoiGianGiangDayDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the HeSoThoiGianGiangDayDataSource class.
	/// </summary>
	public class HeSoThoiGianGiangDayDataSourceDesigner : ProviderDataSourceDesigner<HeSoThoiGianGiangDay, HeSoThoiGianGiangDayKey>
	{
		/// <summary>
		/// Initializes a new instance of the HeSoThoiGianGiangDayDataSourceDesigner class.
		/// </summary>
		public HeSoThoiGianGiangDayDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoThoiGianGiangDaySelectMethod SelectMethod
		{
			get { return ((HeSoThoiGianGiangDayDataSource) DataSource).SelectMethod; }
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
				actions.Add(new HeSoThoiGianGiangDayDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region HeSoThoiGianGiangDayDataSourceActionList

	/// <summary>
	/// Supports the HeSoThoiGianGiangDayDataSourceDesigner class.
	/// </summary>
	internal class HeSoThoiGianGiangDayDataSourceActionList : DesignerActionList
	{
		private HeSoThoiGianGiangDayDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the HeSoThoiGianGiangDayDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public HeSoThoiGianGiangDayDataSourceActionList(HeSoThoiGianGiangDayDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoThoiGianGiangDaySelectMethod SelectMethod
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

	#endregion HeSoThoiGianGiangDayDataSourceActionList
	
	#endregion HeSoThoiGianGiangDayDataSourceDesigner
	
	#region HeSoThoiGianGiangDaySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the HeSoThoiGianGiangDayDataSource.SelectMethod property.
	/// </summary>
	public enum HeSoThoiGianGiangDaySelectMethod
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
	
	#endregion HeSoThoiGianGiangDaySelectMethod

	#region HeSoThoiGianGiangDayFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoThoiGianGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoThoiGianGiangDayFilter : SqlFilter<HeSoThoiGianGiangDayColumn>
	{
	}
	
	#endregion HeSoThoiGianGiangDayFilter

	#region HeSoThoiGianGiangDayExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoThoiGianGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoThoiGianGiangDayExpressionBuilder : SqlExpressionBuilder<HeSoThoiGianGiangDayColumn>
	{
	}
	
	#endregion HeSoThoiGianGiangDayExpressionBuilder	

	#region HeSoThoiGianGiangDayProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;HeSoThoiGianGiangDayChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoThoiGianGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoThoiGianGiangDayProperty : ChildEntityProperty<HeSoThoiGianGiangDayChildEntityTypes>
	{
	}
	
	#endregion HeSoThoiGianGiangDayProperty
}

