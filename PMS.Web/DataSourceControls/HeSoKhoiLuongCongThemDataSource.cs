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
	/// Represents the DataRepository.HeSoKhoiLuongCongThemProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(HeSoKhoiLuongCongThemDataSourceDesigner))]
	public class HeSoKhoiLuongCongThemDataSource : ProviderDataSource<HeSoKhoiLuongCongThem, HeSoKhoiLuongCongThemKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoKhoiLuongCongThemDataSource class.
		/// </summary>
		public HeSoKhoiLuongCongThemDataSource() : base(new HeSoKhoiLuongCongThemService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the HeSoKhoiLuongCongThemDataSourceView used by the HeSoKhoiLuongCongThemDataSource.
		/// </summary>
		protected HeSoKhoiLuongCongThemDataSourceView HeSoKhoiLuongCongThemView
		{
			get { return ( View as HeSoKhoiLuongCongThemDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the HeSoKhoiLuongCongThemDataSource control invokes to retrieve data.
		/// </summary>
		public HeSoKhoiLuongCongThemSelectMethod SelectMethod
		{
			get
			{
				HeSoKhoiLuongCongThemSelectMethod selectMethod = HeSoKhoiLuongCongThemSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (HeSoKhoiLuongCongThemSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the HeSoKhoiLuongCongThemDataSourceView class that is to be
		/// used by the HeSoKhoiLuongCongThemDataSource.
		/// </summary>
		/// <returns>An instance of the HeSoKhoiLuongCongThemDataSourceView class.</returns>
		protected override BaseDataSourceView<HeSoKhoiLuongCongThem, HeSoKhoiLuongCongThemKey> GetNewDataSourceView()
		{
			return new HeSoKhoiLuongCongThemDataSourceView(this, DefaultViewName);
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
	/// Supports the HeSoKhoiLuongCongThemDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class HeSoKhoiLuongCongThemDataSourceView : ProviderDataSourceView<HeSoKhoiLuongCongThem, HeSoKhoiLuongCongThemKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoKhoiLuongCongThemDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the HeSoKhoiLuongCongThemDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public HeSoKhoiLuongCongThemDataSourceView(HeSoKhoiLuongCongThemDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal HeSoKhoiLuongCongThemDataSource HeSoKhoiLuongCongThemOwner
		{
			get { return Owner as HeSoKhoiLuongCongThemDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal HeSoKhoiLuongCongThemSelectMethod SelectMethod
		{
			get { return HeSoKhoiLuongCongThemOwner.SelectMethod; }
			set { HeSoKhoiLuongCongThemOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal HeSoKhoiLuongCongThemService HeSoKhoiLuongCongThemProvider
		{
			get { return Provider as HeSoKhoiLuongCongThemService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<HeSoKhoiLuongCongThem> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<HeSoKhoiLuongCongThem> results = null;
			HeSoKhoiLuongCongThem item;
			count = 0;
			
			System.Int32 _id;
			System.String sp275_NamHoc;
			System.String sp275_HocKy;

			switch ( SelectMethod )
			{
				case HeSoKhoiLuongCongThemSelectMethod.Get:
					HeSoKhoiLuongCongThemKey entityKey  = new HeSoKhoiLuongCongThemKey();
					entityKey.Load(values);
					item = HeSoKhoiLuongCongThemProvider.Get(entityKey);
					results = new TList<HeSoKhoiLuongCongThem>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case HeSoKhoiLuongCongThemSelectMethod.GetAll:
                    results = HeSoKhoiLuongCongThemProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case HeSoKhoiLuongCongThemSelectMethod.GetPaged:
					results = HeSoKhoiLuongCongThemProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case HeSoKhoiLuongCongThemSelectMethod.Find:
					if ( FilterParameters != null )
						results = HeSoKhoiLuongCongThemProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = HeSoKhoiLuongCongThemProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case HeSoKhoiLuongCongThemSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = HeSoKhoiLuongCongThemProvider.GetById(_id);
					results = new TList<HeSoKhoiLuongCongThem>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case HeSoKhoiLuongCongThemSelectMethod.GetByNamHocHocKy:
					sp275_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp275_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = HeSoKhoiLuongCongThemProvider.GetByNamHocHocKy(sp275_NamHoc, sp275_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == HeSoKhoiLuongCongThemSelectMethod.Get || SelectMethod == HeSoKhoiLuongCongThemSelectMethod.GetById )
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
				HeSoKhoiLuongCongThem entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					HeSoKhoiLuongCongThemProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<HeSoKhoiLuongCongThem> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			HeSoKhoiLuongCongThemProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region HeSoKhoiLuongCongThemDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the HeSoKhoiLuongCongThemDataSource class.
	/// </summary>
	public class HeSoKhoiLuongCongThemDataSourceDesigner : ProviderDataSourceDesigner<HeSoKhoiLuongCongThem, HeSoKhoiLuongCongThemKey>
	{
		/// <summary>
		/// Initializes a new instance of the HeSoKhoiLuongCongThemDataSourceDesigner class.
		/// </summary>
		public HeSoKhoiLuongCongThemDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoKhoiLuongCongThemSelectMethod SelectMethod
		{
			get { return ((HeSoKhoiLuongCongThemDataSource) DataSource).SelectMethod; }
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
				actions.Add(new HeSoKhoiLuongCongThemDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region HeSoKhoiLuongCongThemDataSourceActionList

	/// <summary>
	/// Supports the HeSoKhoiLuongCongThemDataSourceDesigner class.
	/// </summary>
	internal class HeSoKhoiLuongCongThemDataSourceActionList : DesignerActionList
	{
		private HeSoKhoiLuongCongThemDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the HeSoKhoiLuongCongThemDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public HeSoKhoiLuongCongThemDataSourceActionList(HeSoKhoiLuongCongThemDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoKhoiLuongCongThemSelectMethod SelectMethod
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

	#endregion HeSoKhoiLuongCongThemDataSourceActionList
	
	#endregion HeSoKhoiLuongCongThemDataSourceDesigner
	
	#region HeSoKhoiLuongCongThemSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the HeSoKhoiLuongCongThemDataSource.SelectMethod property.
	/// </summary>
	public enum HeSoKhoiLuongCongThemSelectMethod
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
	
	#endregion HeSoKhoiLuongCongThemSelectMethod

	#region HeSoKhoiLuongCongThemFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoKhoiLuongCongThem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoKhoiLuongCongThemFilter : SqlFilter<HeSoKhoiLuongCongThemColumn>
	{
	}
	
	#endregion HeSoKhoiLuongCongThemFilter

	#region HeSoKhoiLuongCongThemExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoKhoiLuongCongThem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoKhoiLuongCongThemExpressionBuilder : SqlExpressionBuilder<HeSoKhoiLuongCongThemColumn>
	{
	}
	
	#endregion HeSoKhoiLuongCongThemExpressionBuilder	

	#region HeSoKhoiLuongCongThemProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;HeSoKhoiLuongCongThemChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoKhoiLuongCongThem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoKhoiLuongCongThemProperty : ChildEntityProperty<HeSoKhoiLuongCongThemChildEntityTypes>
	{
	}
	
	#endregion HeSoKhoiLuongCongThemProperty
}

