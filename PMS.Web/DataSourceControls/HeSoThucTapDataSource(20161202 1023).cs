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
	/// Represents the DataRepository.HeSoThucTapProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(HeSoThucTapDataSourceDesigner))]
	public class HeSoThucTapDataSource : ProviderDataSource<HeSoThucTap, HeSoThucTapKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoThucTapDataSource class.
		/// </summary>
		public HeSoThucTapDataSource() : base(new HeSoThucTapService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the HeSoThucTapDataSourceView used by the HeSoThucTapDataSource.
		/// </summary>
		protected HeSoThucTapDataSourceView HeSoThucTapView
		{
			get { return ( View as HeSoThucTapDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the HeSoThucTapDataSource control invokes to retrieve data.
		/// </summary>
		public HeSoThucTapSelectMethod SelectMethod
		{
			get
			{
				HeSoThucTapSelectMethod selectMethod = HeSoThucTapSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (HeSoThucTapSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the HeSoThucTapDataSourceView class that is to be
		/// used by the HeSoThucTapDataSource.
		/// </summary>
		/// <returns>An instance of the HeSoThucTapDataSourceView class.</returns>
		protected override BaseDataSourceView<HeSoThucTap, HeSoThucTapKey> GetNewDataSourceView()
		{
			return new HeSoThucTapDataSourceView(this, DefaultViewName);
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
	/// Supports the HeSoThucTapDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class HeSoThucTapDataSourceView : ProviderDataSourceView<HeSoThucTap, HeSoThucTapKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoThucTapDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the HeSoThucTapDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public HeSoThucTapDataSourceView(HeSoThucTapDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal HeSoThucTapDataSource HeSoThucTapOwner
		{
			get { return Owner as HeSoThucTapDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal HeSoThucTapSelectMethod SelectMethod
		{
			get { return HeSoThucTapOwner.SelectMethod; }
			set { HeSoThucTapOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal HeSoThucTapService HeSoThucTapProvider
		{
			get { return Provider as HeSoThucTapService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<HeSoThucTap> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<HeSoThucTap> results = null;
			HeSoThucTap item;
			count = 0;
			
			System.Int32 _id;
			System.String sp2420_NamHoc;
			System.String sp2420_HocKy;

			switch ( SelectMethod )
			{
				case HeSoThucTapSelectMethod.Get:
					HeSoThucTapKey entityKey  = new HeSoThucTapKey();
					entityKey.Load(values);
					item = HeSoThucTapProvider.Get(entityKey);
					results = new TList<HeSoThucTap>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case HeSoThucTapSelectMethod.GetAll:
                    results = HeSoThucTapProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case HeSoThucTapSelectMethod.GetPaged:
					results = HeSoThucTapProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case HeSoThucTapSelectMethod.Find:
					if ( FilterParameters != null )
						results = HeSoThucTapProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = HeSoThucTapProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case HeSoThucTapSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = HeSoThucTapProvider.GetById(_id);
					results = new TList<HeSoThucTap>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case HeSoThucTapSelectMethod.GetByNamHocHocKy:
					sp2420_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2420_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = HeSoThucTapProvider.GetByNamHocHocKy(sp2420_NamHoc, sp2420_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == HeSoThucTapSelectMethod.Get || SelectMethod == HeSoThucTapSelectMethod.GetById )
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
				HeSoThucTap entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					HeSoThucTapProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<HeSoThucTap> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			HeSoThucTapProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region HeSoThucTapDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the HeSoThucTapDataSource class.
	/// </summary>
	public class HeSoThucTapDataSourceDesigner : ProviderDataSourceDesigner<HeSoThucTap, HeSoThucTapKey>
	{
		/// <summary>
		/// Initializes a new instance of the HeSoThucTapDataSourceDesigner class.
		/// </summary>
		public HeSoThucTapDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoThucTapSelectMethod SelectMethod
		{
			get { return ((HeSoThucTapDataSource) DataSource).SelectMethod; }
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
				actions.Add(new HeSoThucTapDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region HeSoThucTapDataSourceActionList

	/// <summary>
	/// Supports the HeSoThucTapDataSourceDesigner class.
	/// </summary>
	internal class HeSoThucTapDataSourceActionList : DesignerActionList
	{
		private HeSoThucTapDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the HeSoThucTapDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public HeSoThucTapDataSourceActionList(HeSoThucTapDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoThucTapSelectMethod SelectMethod
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

	#endregion HeSoThucTapDataSourceActionList
	
	#endregion HeSoThucTapDataSourceDesigner
	
	#region HeSoThucTapSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the HeSoThucTapDataSource.SelectMethod property.
	/// </summary>
	public enum HeSoThucTapSelectMethod
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
	
	#endregion HeSoThucTapSelectMethod

	#region HeSoThucTapFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoThucTap"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoThucTapFilter : SqlFilter<HeSoThucTapColumn>
	{
	}
	
	#endregion HeSoThucTapFilter

	#region HeSoThucTapExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoThucTap"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoThucTapExpressionBuilder : SqlExpressionBuilder<HeSoThucTapColumn>
	{
	}
	
	#endregion HeSoThucTapExpressionBuilder	

	#region HeSoThucTapProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;HeSoThucTapChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoThucTap"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoThucTapProperty : ChildEntityProperty<HeSoThucTapChildEntityTypes>
	{
	}
	
	#endregion HeSoThucTapProperty
}

