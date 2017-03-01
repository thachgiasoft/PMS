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
	/// Represents the DataRepository.HeSoChucDanhChuyenMonProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(HeSoChucDanhChuyenMonDataSourceDesigner))]
	public class HeSoChucDanhChuyenMonDataSource : ProviderDataSource<HeSoChucDanhChuyenMon, HeSoChucDanhChuyenMonKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoChucDanhChuyenMonDataSource class.
		/// </summary>
		public HeSoChucDanhChuyenMonDataSource() : base(new HeSoChucDanhChuyenMonService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the HeSoChucDanhChuyenMonDataSourceView used by the HeSoChucDanhChuyenMonDataSource.
		/// </summary>
		protected HeSoChucDanhChuyenMonDataSourceView HeSoChucDanhChuyenMonView
		{
			get { return ( View as HeSoChucDanhChuyenMonDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the HeSoChucDanhChuyenMonDataSource control invokes to retrieve data.
		/// </summary>
		public HeSoChucDanhChuyenMonSelectMethod SelectMethod
		{
			get
			{
				HeSoChucDanhChuyenMonSelectMethod selectMethod = HeSoChucDanhChuyenMonSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (HeSoChucDanhChuyenMonSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the HeSoChucDanhChuyenMonDataSourceView class that is to be
		/// used by the HeSoChucDanhChuyenMonDataSource.
		/// </summary>
		/// <returns>An instance of the HeSoChucDanhChuyenMonDataSourceView class.</returns>
		protected override BaseDataSourceView<HeSoChucDanhChuyenMon, HeSoChucDanhChuyenMonKey> GetNewDataSourceView()
		{
			return new HeSoChucDanhChuyenMonDataSourceView(this, DefaultViewName);
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
	/// Supports the HeSoChucDanhChuyenMonDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class HeSoChucDanhChuyenMonDataSourceView : ProviderDataSourceView<HeSoChucDanhChuyenMon, HeSoChucDanhChuyenMonKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoChucDanhChuyenMonDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the HeSoChucDanhChuyenMonDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public HeSoChucDanhChuyenMonDataSourceView(HeSoChucDanhChuyenMonDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal HeSoChucDanhChuyenMonDataSource HeSoChucDanhChuyenMonOwner
		{
			get { return Owner as HeSoChucDanhChuyenMonDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal HeSoChucDanhChuyenMonSelectMethod SelectMethod
		{
			get { return HeSoChucDanhChuyenMonOwner.SelectMethod; }
			set { HeSoChucDanhChuyenMonOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal HeSoChucDanhChuyenMonService HeSoChucDanhChuyenMonProvider
		{
			get { return Provider as HeSoChucDanhChuyenMonService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<HeSoChucDanhChuyenMon> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<HeSoChucDanhChuyenMon> results = null;
			HeSoChucDanhChuyenMon item;
			count = 0;
			
			System.Int32 _maHeSo;
			System.String sp2350_NamHoc;
			System.String sp2350_HocKy;

			switch ( SelectMethod )
			{
				case HeSoChucDanhChuyenMonSelectMethod.Get:
					HeSoChucDanhChuyenMonKey entityKey  = new HeSoChucDanhChuyenMonKey();
					entityKey.Load(values);
					item = HeSoChucDanhChuyenMonProvider.Get(entityKey);
					results = new TList<HeSoChucDanhChuyenMon>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case HeSoChucDanhChuyenMonSelectMethod.GetAll:
                    results = HeSoChucDanhChuyenMonProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case HeSoChucDanhChuyenMonSelectMethod.GetPaged:
					results = HeSoChucDanhChuyenMonProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case HeSoChucDanhChuyenMonSelectMethod.Find:
					if ( FilterParameters != null )
						results = HeSoChucDanhChuyenMonProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = HeSoChucDanhChuyenMonProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case HeSoChucDanhChuyenMonSelectMethod.GetByMaHeSo:
					_maHeSo = ( values["MaHeSo"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaHeSo"], typeof(System.Int32)) : (int)0;
					item = HeSoChucDanhChuyenMonProvider.GetByMaHeSo(_maHeSo);
					results = new TList<HeSoChucDanhChuyenMon>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case HeSoChucDanhChuyenMonSelectMethod.GetByNamHocHocKy:
					sp2350_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2350_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = HeSoChucDanhChuyenMonProvider.GetByNamHocHocKy(sp2350_NamHoc, sp2350_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == HeSoChucDanhChuyenMonSelectMethod.Get || SelectMethod == HeSoChucDanhChuyenMonSelectMethod.GetByMaHeSo )
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
				HeSoChucDanhChuyenMon entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					HeSoChucDanhChuyenMonProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<HeSoChucDanhChuyenMon> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			HeSoChucDanhChuyenMonProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region HeSoChucDanhChuyenMonDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the HeSoChucDanhChuyenMonDataSource class.
	/// </summary>
	public class HeSoChucDanhChuyenMonDataSourceDesigner : ProviderDataSourceDesigner<HeSoChucDanhChuyenMon, HeSoChucDanhChuyenMonKey>
	{
		/// <summary>
		/// Initializes a new instance of the HeSoChucDanhChuyenMonDataSourceDesigner class.
		/// </summary>
		public HeSoChucDanhChuyenMonDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoChucDanhChuyenMonSelectMethod SelectMethod
		{
			get { return ((HeSoChucDanhChuyenMonDataSource) DataSource).SelectMethod; }
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
				actions.Add(new HeSoChucDanhChuyenMonDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region HeSoChucDanhChuyenMonDataSourceActionList

	/// <summary>
	/// Supports the HeSoChucDanhChuyenMonDataSourceDesigner class.
	/// </summary>
	internal class HeSoChucDanhChuyenMonDataSourceActionList : DesignerActionList
	{
		private HeSoChucDanhChuyenMonDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the HeSoChucDanhChuyenMonDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public HeSoChucDanhChuyenMonDataSourceActionList(HeSoChucDanhChuyenMonDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoChucDanhChuyenMonSelectMethod SelectMethod
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

	#endregion HeSoChucDanhChuyenMonDataSourceActionList
	
	#endregion HeSoChucDanhChuyenMonDataSourceDesigner
	
	#region HeSoChucDanhChuyenMonSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the HeSoChucDanhChuyenMonDataSource.SelectMethod property.
	/// </summary>
	public enum HeSoChucDanhChuyenMonSelectMethod
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
		GetByNamHocHocKy
	}
	
	#endregion HeSoChucDanhChuyenMonSelectMethod

	#region HeSoChucDanhChuyenMonFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoChucDanhChuyenMon"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoChucDanhChuyenMonFilter : SqlFilter<HeSoChucDanhChuyenMonColumn>
	{
	}
	
	#endregion HeSoChucDanhChuyenMonFilter

	#region HeSoChucDanhChuyenMonExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoChucDanhChuyenMon"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoChucDanhChuyenMonExpressionBuilder : SqlExpressionBuilder<HeSoChucDanhChuyenMonColumn>
	{
	}
	
	#endregion HeSoChucDanhChuyenMonExpressionBuilder	

	#region HeSoChucDanhChuyenMonProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;HeSoChucDanhChuyenMonChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoChucDanhChuyenMon"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoChucDanhChuyenMonProperty : ChildEntityProperty<HeSoChucDanhChuyenMonChildEntityTypes>
	{
	}
	
	#endregion HeSoChucDanhChuyenMonProperty
}

