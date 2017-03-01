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
	/// Represents the DataRepository.HeSoChucDanhKhoiLuongKhacProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(HeSoChucDanhKhoiLuongKhacDataSourceDesigner))]
	public class HeSoChucDanhKhoiLuongKhacDataSource : ProviderDataSource<HeSoChucDanhKhoiLuongKhac, HeSoChucDanhKhoiLuongKhacKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoChucDanhKhoiLuongKhacDataSource class.
		/// </summary>
		public HeSoChucDanhKhoiLuongKhacDataSource() : base(new HeSoChucDanhKhoiLuongKhacService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the HeSoChucDanhKhoiLuongKhacDataSourceView used by the HeSoChucDanhKhoiLuongKhacDataSource.
		/// </summary>
		protected HeSoChucDanhKhoiLuongKhacDataSourceView HeSoChucDanhKhoiLuongKhacView
		{
			get { return ( View as HeSoChucDanhKhoiLuongKhacDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the HeSoChucDanhKhoiLuongKhacDataSource control invokes to retrieve data.
		/// </summary>
		public HeSoChucDanhKhoiLuongKhacSelectMethod SelectMethod
		{
			get
			{
				HeSoChucDanhKhoiLuongKhacSelectMethod selectMethod = HeSoChucDanhKhoiLuongKhacSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (HeSoChucDanhKhoiLuongKhacSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the HeSoChucDanhKhoiLuongKhacDataSourceView class that is to be
		/// used by the HeSoChucDanhKhoiLuongKhacDataSource.
		/// </summary>
		/// <returns>An instance of the HeSoChucDanhKhoiLuongKhacDataSourceView class.</returns>
		protected override BaseDataSourceView<HeSoChucDanhKhoiLuongKhac, HeSoChucDanhKhoiLuongKhacKey> GetNewDataSourceView()
		{
			return new HeSoChucDanhKhoiLuongKhacDataSourceView(this, DefaultViewName);
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
	/// Supports the HeSoChucDanhKhoiLuongKhacDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class HeSoChucDanhKhoiLuongKhacDataSourceView : ProviderDataSourceView<HeSoChucDanhKhoiLuongKhac, HeSoChucDanhKhoiLuongKhacKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoChucDanhKhoiLuongKhacDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the HeSoChucDanhKhoiLuongKhacDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public HeSoChucDanhKhoiLuongKhacDataSourceView(HeSoChucDanhKhoiLuongKhacDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal HeSoChucDanhKhoiLuongKhacDataSource HeSoChucDanhKhoiLuongKhacOwner
		{
			get { return Owner as HeSoChucDanhKhoiLuongKhacDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal HeSoChucDanhKhoiLuongKhacSelectMethod SelectMethod
		{
			get { return HeSoChucDanhKhoiLuongKhacOwner.SelectMethod; }
			set { HeSoChucDanhKhoiLuongKhacOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal HeSoChucDanhKhoiLuongKhacService HeSoChucDanhKhoiLuongKhacProvider
		{
			get { return Provider as HeSoChucDanhKhoiLuongKhacService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<HeSoChucDanhKhoiLuongKhac> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<HeSoChucDanhKhoiLuongKhac> results = null;
			HeSoChucDanhKhoiLuongKhac item;
			count = 0;
			
			System.Int32 _id;
			System.Int32 sp2352_MaKhoiLuong;

			switch ( SelectMethod )
			{
				case HeSoChucDanhKhoiLuongKhacSelectMethod.Get:
					HeSoChucDanhKhoiLuongKhacKey entityKey  = new HeSoChucDanhKhoiLuongKhacKey();
					entityKey.Load(values);
					item = HeSoChucDanhKhoiLuongKhacProvider.Get(entityKey);
					results = new TList<HeSoChucDanhKhoiLuongKhac>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case HeSoChucDanhKhoiLuongKhacSelectMethod.GetAll:
                    results = HeSoChucDanhKhoiLuongKhacProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case HeSoChucDanhKhoiLuongKhacSelectMethod.GetPaged:
					results = HeSoChucDanhKhoiLuongKhacProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case HeSoChucDanhKhoiLuongKhacSelectMethod.Find:
					if ( FilterParameters != null )
						results = HeSoChucDanhKhoiLuongKhacProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = HeSoChucDanhKhoiLuongKhacProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case HeSoChucDanhKhoiLuongKhacSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = HeSoChucDanhKhoiLuongKhacProvider.GetById(_id);
					results = new TList<HeSoChucDanhKhoiLuongKhac>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case HeSoChucDanhKhoiLuongKhacSelectMethod.GetByMaKhoiLuong:
					sp2352_MaKhoiLuong = (System.Int32) EntityUtil.ChangeType(values["MaKhoiLuong"], typeof(System.Int32));
					results = HeSoChucDanhKhoiLuongKhacProvider.GetByMaKhoiLuong(sp2352_MaKhoiLuong, StartIndex, PageSize);
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
			if ( SelectMethod == HeSoChucDanhKhoiLuongKhacSelectMethod.Get || SelectMethod == HeSoChucDanhKhoiLuongKhacSelectMethod.GetById )
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
				HeSoChucDanhKhoiLuongKhac entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					HeSoChucDanhKhoiLuongKhacProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<HeSoChucDanhKhoiLuongKhac> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			HeSoChucDanhKhoiLuongKhacProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region HeSoChucDanhKhoiLuongKhacDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the HeSoChucDanhKhoiLuongKhacDataSource class.
	/// </summary>
	public class HeSoChucDanhKhoiLuongKhacDataSourceDesigner : ProviderDataSourceDesigner<HeSoChucDanhKhoiLuongKhac, HeSoChucDanhKhoiLuongKhacKey>
	{
		/// <summary>
		/// Initializes a new instance of the HeSoChucDanhKhoiLuongKhacDataSourceDesigner class.
		/// </summary>
		public HeSoChucDanhKhoiLuongKhacDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoChucDanhKhoiLuongKhacSelectMethod SelectMethod
		{
			get { return ((HeSoChucDanhKhoiLuongKhacDataSource) DataSource).SelectMethod; }
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
				actions.Add(new HeSoChucDanhKhoiLuongKhacDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region HeSoChucDanhKhoiLuongKhacDataSourceActionList

	/// <summary>
	/// Supports the HeSoChucDanhKhoiLuongKhacDataSourceDesigner class.
	/// </summary>
	internal class HeSoChucDanhKhoiLuongKhacDataSourceActionList : DesignerActionList
	{
		private HeSoChucDanhKhoiLuongKhacDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the HeSoChucDanhKhoiLuongKhacDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public HeSoChucDanhKhoiLuongKhacDataSourceActionList(HeSoChucDanhKhoiLuongKhacDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoChucDanhKhoiLuongKhacSelectMethod SelectMethod
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

	#endregion HeSoChucDanhKhoiLuongKhacDataSourceActionList
	
	#endregion HeSoChucDanhKhoiLuongKhacDataSourceDesigner
	
	#region HeSoChucDanhKhoiLuongKhacSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the HeSoChucDanhKhoiLuongKhacDataSource.SelectMethod property.
	/// </summary>
	public enum HeSoChucDanhKhoiLuongKhacSelectMethod
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
		/// Represents the GetByMaKhoiLuong method.
		/// </summary>
		GetByMaKhoiLuong
	}
	
	#endregion HeSoChucDanhKhoiLuongKhacSelectMethod

	#region HeSoChucDanhKhoiLuongKhacFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoChucDanhKhoiLuongKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoChucDanhKhoiLuongKhacFilter : SqlFilter<HeSoChucDanhKhoiLuongKhacColumn>
	{
	}
	
	#endregion HeSoChucDanhKhoiLuongKhacFilter

	#region HeSoChucDanhKhoiLuongKhacExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoChucDanhKhoiLuongKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoChucDanhKhoiLuongKhacExpressionBuilder : SqlExpressionBuilder<HeSoChucDanhKhoiLuongKhacColumn>
	{
	}
	
	#endregion HeSoChucDanhKhoiLuongKhacExpressionBuilder	

	#region HeSoChucDanhKhoiLuongKhacProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;HeSoChucDanhKhoiLuongKhacChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoChucDanhKhoiLuongKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoChucDanhKhoiLuongKhacProperty : ChildEntityProperty<HeSoChucDanhKhoiLuongKhacChildEntityTypes>
	{
	}
	
	#endregion HeSoChucDanhKhoiLuongKhacProperty
}

