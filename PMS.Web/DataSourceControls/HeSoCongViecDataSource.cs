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
	/// Represents the DataRepository.HeSoCongViecProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(HeSoCongViecDataSourceDesigner))]
	public class HeSoCongViecDataSource : ProviderDataSource<HeSoCongViec, HeSoCongViecKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoCongViecDataSource class.
		/// </summary>
		public HeSoCongViecDataSource() : base(new HeSoCongViecService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the HeSoCongViecDataSourceView used by the HeSoCongViecDataSource.
		/// </summary>
		protected HeSoCongViecDataSourceView HeSoCongViecView
		{
			get { return ( View as HeSoCongViecDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the HeSoCongViecDataSource control invokes to retrieve data.
		/// </summary>
		public HeSoCongViecSelectMethod SelectMethod
		{
			get
			{
				HeSoCongViecSelectMethod selectMethod = HeSoCongViecSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (HeSoCongViecSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the HeSoCongViecDataSourceView class that is to be
		/// used by the HeSoCongViecDataSource.
		/// </summary>
		/// <returns>An instance of the HeSoCongViecDataSourceView class.</returns>
		protected override BaseDataSourceView<HeSoCongViec, HeSoCongViecKey> GetNewDataSourceView()
		{
			return new HeSoCongViecDataSourceView(this, DefaultViewName);
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
	/// Supports the HeSoCongViecDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class HeSoCongViecDataSourceView : ProviderDataSourceView<HeSoCongViec, HeSoCongViecKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoCongViecDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the HeSoCongViecDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public HeSoCongViecDataSourceView(HeSoCongViecDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal HeSoCongViecDataSource HeSoCongViecOwner
		{
			get { return Owner as HeSoCongViecDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal HeSoCongViecSelectMethod SelectMethod
		{
			get { return HeSoCongViecOwner.SelectMethod; }
			set { HeSoCongViecOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal HeSoCongViecService HeSoCongViecProvider
		{
			get { return Provider as HeSoCongViecService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<HeSoCongViec> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<HeSoCongViec> results = null;
			HeSoCongViec item;
			count = 0;
			
			System.Int32 _maHeSo;
			System.String sp256_NamHoc;
			System.String sp256_HocKy;
			System.String sp255_LoaiHocPhan;
			System.DateTime sp255_NgayDay;

			switch ( SelectMethod )
			{
				case HeSoCongViecSelectMethod.Get:
					HeSoCongViecKey entityKey  = new HeSoCongViecKey();
					entityKey.Load(values);
					item = HeSoCongViecProvider.Get(entityKey);
					results = new TList<HeSoCongViec>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case HeSoCongViecSelectMethod.GetAll:
                    results = HeSoCongViecProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case HeSoCongViecSelectMethod.GetPaged:
					results = HeSoCongViecProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case HeSoCongViecSelectMethod.Find:
					if ( FilterParameters != null )
						results = HeSoCongViecProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = HeSoCongViecProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case HeSoCongViecSelectMethod.GetByMaHeSo:
					_maHeSo = ( values["MaHeSo"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaHeSo"], typeof(System.Int32)) : (int)0;
					item = HeSoCongViecProvider.GetByMaHeSo(_maHeSo);
					results = new TList<HeSoCongViec>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case HeSoCongViecSelectMethod.GetByNamHocHocKy:
					sp256_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp256_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = HeSoCongViecProvider.GetByNamHocHocKy(sp256_NamHoc, sp256_HocKy, StartIndex, PageSize);
					break;
				case HeSoCongViecSelectMethod.GetByLoaiHocPhanNgayDay:
					sp255_LoaiHocPhan = (System.String) EntityUtil.ChangeType(values["LoaiHocPhan"], typeof(System.String));
					sp255_NgayDay = (System.DateTime) EntityUtil.ChangeType(values["NgayDay"], typeof(System.DateTime));
					results = HeSoCongViecProvider.GetByLoaiHocPhanNgayDay(sp255_LoaiHocPhan, sp255_NgayDay, StartIndex, PageSize);
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
			if ( SelectMethod == HeSoCongViecSelectMethod.Get || SelectMethod == HeSoCongViecSelectMethod.GetByMaHeSo )
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
				HeSoCongViec entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					HeSoCongViecProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<HeSoCongViec> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			HeSoCongViecProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region HeSoCongViecDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the HeSoCongViecDataSource class.
	/// </summary>
	public class HeSoCongViecDataSourceDesigner : ProviderDataSourceDesigner<HeSoCongViec, HeSoCongViecKey>
	{
		/// <summary>
		/// Initializes a new instance of the HeSoCongViecDataSourceDesigner class.
		/// </summary>
		public HeSoCongViecDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoCongViecSelectMethod SelectMethod
		{
			get { return ((HeSoCongViecDataSource) DataSource).SelectMethod; }
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
				actions.Add(new HeSoCongViecDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region HeSoCongViecDataSourceActionList

	/// <summary>
	/// Supports the HeSoCongViecDataSourceDesigner class.
	/// </summary>
	internal class HeSoCongViecDataSourceActionList : DesignerActionList
	{
		private HeSoCongViecDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the HeSoCongViecDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public HeSoCongViecDataSourceActionList(HeSoCongViecDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoCongViecSelectMethod SelectMethod
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

	#endregion HeSoCongViecDataSourceActionList
	
	#endregion HeSoCongViecDataSourceDesigner
	
	#region HeSoCongViecSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the HeSoCongViecDataSource.SelectMethod property.
	/// </summary>
	public enum HeSoCongViecSelectMethod
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
		GetByMaHeSo,
		/// <summary>
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy,
		/// <summary>
		/// Represents the GetByLoaiHocPhanNgayDay method.
		/// </summary>
		GetByLoaiHocPhanNgayDay
	}
	
	#endregion HeSoCongViecSelectMethod

	#region HeSoCongViecFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoCongViec"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoCongViecFilter : SqlFilter<HeSoCongViecColumn>
	{
	}
	
	#endregion HeSoCongViecFilter

	#region HeSoCongViecExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoCongViec"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoCongViecExpressionBuilder : SqlExpressionBuilder<HeSoCongViecColumn>
	{
	}
	
	#endregion HeSoCongViecExpressionBuilder	

	#region HeSoCongViecProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;HeSoCongViecChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoCongViec"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoCongViecProperty : ChildEntityProperty<HeSoCongViecChildEntityTypes>
	{
	}
	
	#endregion HeSoCongViecProperty
}

