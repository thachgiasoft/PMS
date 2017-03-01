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
	/// Represents the DataRepository.HeSoCoVanHocTapProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(HeSoCoVanHocTapDataSourceDesigner))]
	public class HeSoCoVanHocTapDataSource : ProviderDataSource<HeSoCoVanHocTap, HeSoCoVanHocTapKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoCoVanHocTapDataSource class.
		/// </summary>
		public HeSoCoVanHocTapDataSource() : base(new HeSoCoVanHocTapService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the HeSoCoVanHocTapDataSourceView used by the HeSoCoVanHocTapDataSource.
		/// </summary>
		protected HeSoCoVanHocTapDataSourceView HeSoCoVanHocTapView
		{
			get { return ( View as HeSoCoVanHocTapDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the HeSoCoVanHocTapDataSource control invokes to retrieve data.
		/// </summary>
		public HeSoCoVanHocTapSelectMethod SelectMethod
		{
			get
			{
				HeSoCoVanHocTapSelectMethod selectMethod = HeSoCoVanHocTapSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (HeSoCoVanHocTapSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the HeSoCoVanHocTapDataSourceView class that is to be
		/// used by the HeSoCoVanHocTapDataSource.
		/// </summary>
		/// <returns>An instance of the HeSoCoVanHocTapDataSourceView class.</returns>
		protected override BaseDataSourceView<HeSoCoVanHocTap, HeSoCoVanHocTapKey> GetNewDataSourceView()
		{
			return new HeSoCoVanHocTapDataSourceView(this, DefaultViewName);
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
	/// Supports the HeSoCoVanHocTapDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class HeSoCoVanHocTapDataSourceView : ProviderDataSourceView<HeSoCoVanHocTap, HeSoCoVanHocTapKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoCoVanHocTapDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the HeSoCoVanHocTapDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public HeSoCoVanHocTapDataSourceView(HeSoCoVanHocTapDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal HeSoCoVanHocTapDataSource HeSoCoVanHocTapOwner
		{
			get { return Owner as HeSoCoVanHocTapDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal HeSoCoVanHocTapSelectMethod SelectMethod
		{
			get { return HeSoCoVanHocTapOwner.SelectMethod; }
			set { HeSoCoVanHocTapOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal HeSoCoVanHocTapService HeSoCoVanHocTapProvider
		{
			get { return Provider as HeSoCoVanHocTapService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<HeSoCoVanHocTap> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<HeSoCoVanHocTap> results = null;
			HeSoCoVanHocTap item;
			count = 0;
			
			System.Int32 _id;
			System.String sp2367_NamHoc;
			System.String sp2367_HocKy;

			switch ( SelectMethod )
			{
				case HeSoCoVanHocTapSelectMethod.Get:
					HeSoCoVanHocTapKey entityKey  = new HeSoCoVanHocTapKey();
					entityKey.Load(values);
					item = HeSoCoVanHocTapProvider.Get(entityKey);
					results = new TList<HeSoCoVanHocTap>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case HeSoCoVanHocTapSelectMethod.GetAll:
                    results = HeSoCoVanHocTapProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case HeSoCoVanHocTapSelectMethod.GetPaged:
					results = HeSoCoVanHocTapProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case HeSoCoVanHocTapSelectMethod.Find:
					if ( FilterParameters != null )
						results = HeSoCoVanHocTapProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = HeSoCoVanHocTapProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case HeSoCoVanHocTapSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = HeSoCoVanHocTapProvider.GetById(_id);
					results = new TList<HeSoCoVanHocTap>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case HeSoCoVanHocTapSelectMethod.GetByNamHocHocKy:
					sp2367_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2367_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = HeSoCoVanHocTapProvider.GetByNamHocHocKy(sp2367_NamHoc, sp2367_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == HeSoCoVanHocTapSelectMethod.Get || SelectMethod == HeSoCoVanHocTapSelectMethod.GetById )
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
				HeSoCoVanHocTap entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					HeSoCoVanHocTapProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<HeSoCoVanHocTap> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			HeSoCoVanHocTapProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region HeSoCoVanHocTapDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the HeSoCoVanHocTapDataSource class.
	/// </summary>
	public class HeSoCoVanHocTapDataSourceDesigner : ProviderDataSourceDesigner<HeSoCoVanHocTap, HeSoCoVanHocTapKey>
	{
		/// <summary>
		/// Initializes a new instance of the HeSoCoVanHocTapDataSourceDesigner class.
		/// </summary>
		public HeSoCoVanHocTapDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoCoVanHocTapSelectMethod SelectMethod
		{
			get { return ((HeSoCoVanHocTapDataSource) DataSource).SelectMethod; }
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
				actions.Add(new HeSoCoVanHocTapDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region HeSoCoVanHocTapDataSourceActionList

	/// <summary>
	/// Supports the HeSoCoVanHocTapDataSourceDesigner class.
	/// </summary>
	internal class HeSoCoVanHocTapDataSourceActionList : DesignerActionList
	{
		private HeSoCoVanHocTapDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the HeSoCoVanHocTapDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public HeSoCoVanHocTapDataSourceActionList(HeSoCoVanHocTapDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoCoVanHocTapSelectMethod SelectMethod
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

	#endregion HeSoCoVanHocTapDataSourceActionList
	
	#endregion HeSoCoVanHocTapDataSourceDesigner
	
	#region HeSoCoVanHocTapSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the HeSoCoVanHocTapDataSource.SelectMethod property.
	/// </summary>
	public enum HeSoCoVanHocTapSelectMethod
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
	
	#endregion HeSoCoVanHocTapSelectMethod

	#region HeSoCoVanHocTapFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoCoVanHocTap"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoCoVanHocTapFilter : SqlFilter<HeSoCoVanHocTapColumn>
	{
	}
	
	#endregion HeSoCoVanHocTapFilter

	#region HeSoCoVanHocTapExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoCoVanHocTap"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoCoVanHocTapExpressionBuilder : SqlExpressionBuilder<HeSoCoVanHocTapColumn>
	{
	}
	
	#endregion HeSoCoVanHocTapExpressionBuilder	

	#region HeSoCoVanHocTapProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;HeSoCoVanHocTapChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoCoVanHocTap"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoCoVanHocTapProperty : ChildEntityProperty<HeSoCoVanHocTapChildEntityTypes>
	{
	}
	
	#endregion HeSoCoVanHocTapProperty
}

