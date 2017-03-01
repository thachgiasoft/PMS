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
	/// Represents the DataRepository.HeSoQuyDoiGioTroiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(HeSoQuyDoiGioTroiDataSourceDesigner))]
	public class HeSoQuyDoiGioTroiDataSource : ProviderDataSource<HeSoQuyDoiGioTroi, HeSoQuyDoiGioTroiKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoQuyDoiGioTroiDataSource class.
		/// </summary>
		public HeSoQuyDoiGioTroiDataSource() : base(new HeSoQuyDoiGioTroiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the HeSoQuyDoiGioTroiDataSourceView used by the HeSoQuyDoiGioTroiDataSource.
		/// </summary>
		protected HeSoQuyDoiGioTroiDataSourceView HeSoQuyDoiGioTroiView
		{
			get { return ( View as HeSoQuyDoiGioTroiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the HeSoQuyDoiGioTroiDataSource control invokes to retrieve data.
		/// </summary>
		public HeSoQuyDoiGioTroiSelectMethod SelectMethod
		{
			get
			{
				HeSoQuyDoiGioTroiSelectMethod selectMethod = HeSoQuyDoiGioTroiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (HeSoQuyDoiGioTroiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the HeSoQuyDoiGioTroiDataSourceView class that is to be
		/// used by the HeSoQuyDoiGioTroiDataSource.
		/// </summary>
		/// <returns>An instance of the HeSoQuyDoiGioTroiDataSourceView class.</returns>
		protected override BaseDataSourceView<HeSoQuyDoiGioTroi, HeSoQuyDoiGioTroiKey> GetNewDataSourceView()
		{
			return new HeSoQuyDoiGioTroiDataSourceView(this, DefaultViewName);
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
	/// Supports the HeSoQuyDoiGioTroiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class HeSoQuyDoiGioTroiDataSourceView : ProviderDataSourceView<HeSoQuyDoiGioTroi, HeSoQuyDoiGioTroiKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoQuyDoiGioTroiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the HeSoQuyDoiGioTroiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public HeSoQuyDoiGioTroiDataSourceView(HeSoQuyDoiGioTroiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal HeSoQuyDoiGioTroiDataSource HeSoQuyDoiGioTroiOwner
		{
			get { return Owner as HeSoQuyDoiGioTroiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal HeSoQuyDoiGioTroiSelectMethod SelectMethod
		{
			get { return HeSoQuyDoiGioTroiOwner.SelectMethod; }
			set { HeSoQuyDoiGioTroiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal HeSoQuyDoiGioTroiService HeSoQuyDoiGioTroiProvider
		{
			get { return Provider as HeSoQuyDoiGioTroiService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<HeSoQuyDoiGioTroi> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<HeSoQuyDoiGioTroi> results = null;
			HeSoQuyDoiGioTroi item;
			count = 0;
			
			System.Int32 _id;
			System.String sp2415_NamHoc;
			System.String sp2415_HocKy;

			switch ( SelectMethod )
			{
				case HeSoQuyDoiGioTroiSelectMethod.Get:
					HeSoQuyDoiGioTroiKey entityKey  = new HeSoQuyDoiGioTroiKey();
					entityKey.Load(values);
					item = HeSoQuyDoiGioTroiProvider.Get(entityKey);
					results = new TList<HeSoQuyDoiGioTroi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case HeSoQuyDoiGioTroiSelectMethod.GetAll:
                    results = HeSoQuyDoiGioTroiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case HeSoQuyDoiGioTroiSelectMethod.GetPaged:
					results = HeSoQuyDoiGioTroiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case HeSoQuyDoiGioTroiSelectMethod.Find:
					if ( FilterParameters != null )
						results = HeSoQuyDoiGioTroiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = HeSoQuyDoiGioTroiProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case HeSoQuyDoiGioTroiSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = HeSoQuyDoiGioTroiProvider.GetById(_id);
					results = new TList<HeSoQuyDoiGioTroi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case HeSoQuyDoiGioTroiSelectMethod.GetByNamHocHocKy:
					sp2415_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2415_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = HeSoQuyDoiGioTroiProvider.GetByNamHocHocKy(sp2415_NamHoc, sp2415_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == HeSoQuyDoiGioTroiSelectMethod.Get || SelectMethod == HeSoQuyDoiGioTroiSelectMethod.GetById )
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
				HeSoQuyDoiGioTroi entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					HeSoQuyDoiGioTroiProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<HeSoQuyDoiGioTroi> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			HeSoQuyDoiGioTroiProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region HeSoQuyDoiGioTroiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the HeSoQuyDoiGioTroiDataSource class.
	/// </summary>
	public class HeSoQuyDoiGioTroiDataSourceDesigner : ProviderDataSourceDesigner<HeSoQuyDoiGioTroi, HeSoQuyDoiGioTroiKey>
	{
		/// <summary>
		/// Initializes a new instance of the HeSoQuyDoiGioTroiDataSourceDesigner class.
		/// </summary>
		public HeSoQuyDoiGioTroiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoQuyDoiGioTroiSelectMethod SelectMethod
		{
			get { return ((HeSoQuyDoiGioTroiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new HeSoQuyDoiGioTroiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region HeSoQuyDoiGioTroiDataSourceActionList

	/// <summary>
	/// Supports the HeSoQuyDoiGioTroiDataSourceDesigner class.
	/// </summary>
	internal class HeSoQuyDoiGioTroiDataSourceActionList : DesignerActionList
	{
		private HeSoQuyDoiGioTroiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the HeSoQuyDoiGioTroiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public HeSoQuyDoiGioTroiDataSourceActionList(HeSoQuyDoiGioTroiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoQuyDoiGioTroiSelectMethod SelectMethod
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

	#endregion HeSoQuyDoiGioTroiDataSourceActionList
	
	#endregion HeSoQuyDoiGioTroiDataSourceDesigner
	
	#region HeSoQuyDoiGioTroiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the HeSoQuyDoiGioTroiDataSource.SelectMethod property.
	/// </summary>
	public enum HeSoQuyDoiGioTroiSelectMethod
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
	
	#endregion HeSoQuyDoiGioTroiSelectMethod

	#region HeSoQuyDoiGioTroiFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoQuyDoiGioTroi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoQuyDoiGioTroiFilter : SqlFilter<HeSoQuyDoiGioTroiColumn>
	{
	}
	
	#endregion HeSoQuyDoiGioTroiFilter

	#region HeSoQuyDoiGioTroiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoQuyDoiGioTroi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoQuyDoiGioTroiExpressionBuilder : SqlExpressionBuilder<HeSoQuyDoiGioTroiColumn>
	{
	}
	
	#endregion HeSoQuyDoiGioTroiExpressionBuilder	

	#region HeSoQuyDoiGioTroiProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;HeSoQuyDoiGioTroiChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoQuyDoiGioTroi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoQuyDoiGioTroiProperty : ChildEntityProperty<HeSoQuyDoiGioTroiChildEntityTypes>
	{
	}
	
	#endregion HeSoQuyDoiGioTroiProperty
}

