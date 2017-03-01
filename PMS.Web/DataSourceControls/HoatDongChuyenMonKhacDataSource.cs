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
	/// Represents the DataRepository.HoatDongChuyenMonKhacProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(HoatDongChuyenMonKhacDataSourceDesigner))]
	public class HoatDongChuyenMonKhacDataSource : ProviderDataSource<HoatDongChuyenMonKhac, HoatDongChuyenMonKhacKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HoatDongChuyenMonKhacDataSource class.
		/// </summary>
		public HoatDongChuyenMonKhacDataSource() : base(new HoatDongChuyenMonKhacService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the HoatDongChuyenMonKhacDataSourceView used by the HoatDongChuyenMonKhacDataSource.
		/// </summary>
		protected HoatDongChuyenMonKhacDataSourceView HoatDongChuyenMonKhacView
		{
			get { return ( View as HoatDongChuyenMonKhacDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the HoatDongChuyenMonKhacDataSource control invokes to retrieve data.
		/// </summary>
		public HoatDongChuyenMonKhacSelectMethod SelectMethod
		{
			get
			{
				HoatDongChuyenMonKhacSelectMethod selectMethod = HoatDongChuyenMonKhacSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (HoatDongChuyenMonKhacSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the HoatDongChuyenMonKhacDataSourceView class that is to be
		/// used by the HoatDongChuyenMonKhacDataSource.
		/// </summary>
		/// <returns>An instance of the HoatDongChuyenMonKhacDataSourceView class.</returns>
		protected override BaseDataSourceView<HoatDongChuyenMonKhac, HoatDongChuyenMonKhacKey> GetNewDataSourceView()
		{
			return new HoatDongChuyenMonKhacDataSourceView(this, DefaultViewName);
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
	/// Supports the HoatDongChuyenMonKhacDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class HoatDongChuyenMonKhacDataSourceView : ProviderDataSourceView<HoatDongChuyenMonKhac, HoatDongChuyenMonKhacKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HoatDongChuyenMonKhacDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the HoatDongChuyenMonKhacDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public HoatDongChuyenMonKhacDataSourceView(HoatDongChuyenMonKhacDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal HoatDongChuyenMonKhacDataSource HoatDongChuyenMonKhacOwner
		{
			get { return Owner as HoatDongChuyenMonKhacDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal HoatDongChuyenMonKhacSelectMethod SelectMethod
		{
			get { return HoatDongChuyenMonKhacOwner.SelectMethod; }
			set { HoatDongChuyenMonKhacOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal HoatDongChuyenMonKhacService HoatDongChuyenMonKhacProvider
		{
			get { return Provider as HoatDongChuyenMonKhacService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<HoatDongChuyenMonKhac> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<HoatDongChuyenMonKhac> results = null;
			HoatDongChuyenMonKhac item;
			count = 0;
			
			System.Int32 _id;
			System.String sp325_NamHoc;
			System.String sp325_HocKy;

			switch ( SelectMethod )
			{
				case HoatDongChuyenMonKhacSelectMethod.Get:
					HoatDongChuyenMonKhacKey entityKey  = new HoatDongChuyenMonKhacKey();
					entityKey.Load(values);
					item = HoatDongChuyenMonKhacProvider.Get(entityKey);
					results = new TList<HoatDongChuyenMonKhac>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case HoatDongChuyenMonKhacSelectMethod.GetAll:
                    results = HoatDongChuyenMonKhacProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case HoatDongChuyenMonKhacSelectMethod.GetPaged:
					results = HoatDongChuyenMonKhacProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case HoatDongChuyenMonKhacSelectMethod.Find:
					if ( FilterParameters != null )
						results = HoatDongChuyenMonKhacProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = HoatDongChuyenMonKhacProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case HoatDongChuyenMonKhacSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = HoatDongChuyenMonKhacProvider.GetById(_id);
					results = new TList<HoatDongChuyenMonKhac>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case HoatDongChuyenMonKhacSelectMethod.GetByNamHocHocKy:
					sp325_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp325_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = HoatDongChuyenMonKhacProvider.GetByNamHocHocKy(sp325_NamHoc, sp325_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == HoatDongChuyenMonKhacSelectMethod.Get || SelectMethod == HoatDongChuyenMonKhacSelectMethod.GetById )
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
				HoatDongChuyenMonKhac entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					HoatDongChuyenMonKhacProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<HoatDongChuyenMonKhac> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			HoatDongChuyenMonKhacProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region HoatDongChuyenMonKhacDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the HoatDongChuyenMonKhacDataSource class.
	/// </summary>
	public class HoatDongChuyenMonKhacDataSourceDesigner : ProviderDataSourceDesigner<HoatDongChuyenMonKhac, HoatDongChuyenMonKhacKey>
	{
		/// <summary>
		/// Initializes a new instance of the HoatDongChuyenMonKhacDataSourceDesigner class.
		/// </summary>
		public HoatDongChuyenMonKhacDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HoatDongChuyenMonKhacSelectMethod SelectMethod
		{
			get { return ((HoatDongChuyenMonKhacDataSource) DataSource).SelectMethod; }
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
				actions.Add(new HoatDongChuyenMonKhacDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region HoatDongChuyenMonKhacDataSourceActionList

	/// <summary>
	/// Supports the HoatDongChuyenMonKhacDataSourceDesigner class.
	/// </summary>
	internal class HoatDongChuyenMonKhacDataSourceActionList : DesignerActionList
	{
		private HoatDongChuyenMonKhacDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the HoatDongChuyenMonKhacDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public HoatDongChuyenMonKhacDataSourceActionList(HoatDongChuyenMonKhacDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HoatDongChuyenMonKhacSelectMethod SelectMethod
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

	#endregion HoatDongChuyenMonKhacDataSourceActionList
	
	#endregion HoatDongChuyenMonKhacDataSourceDesigner
	
	#region HoatDongChuyenMonKhacSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the HoatDongChuyenMonKhacDataSource.SelectMethod property.
	/// </summary>
	public enum HoatDongChuyenMonKhacSelectMethod
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
	
	#endregion HoatDongChuyenMonKhacSelectMethod

	#region HoatDongChuyenMonKhacFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HoatDongChuyenMonKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HoatDongChuyenMonKhacFilter : SqlFilter<HoatDongChuyenMonKhacColumn>
	{
	}
	
	#endregion HoatDongChuyenMonKhacFilter

	#region HoatDongChuyenMonKhacExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HoatDongChuyenMonKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HoatDongChuyenMonKhacExpressionBuilder : SqlExpressionBuilder<HoatDongChuyenMonKhacColumn>
	{
	}
	
	#endregion HoatDongChuyenMonKhacExpressionBuilder	

	#region HoatDongChuyenMonKhacProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;HoatDongChuyenMonKhacChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="HoatDongChuyenMonKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HoatDongChuyenMonKhacProperty : ChildEntityProperty<HoatDongChuyenMonKhacChildEntityTypes>
	{
	}
	
	#endregion HoatDongChuyenMonKhacProperty
}

