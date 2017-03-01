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
	/// Represents the DataRepository.HeSoNhomThucHanhProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(HeSoNhomThucHanhDataSourceDesigner))]
	public class HeSoNhomThucHanhDataSource : ProviderDataSource<HeSoNhomThucHanh, HeSoNhomThucHanhKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoNhomThucHanhDataSource class.
		/// </summary>
		public HeSoNhomThucHanhDataSource() : base(new HeSoNhomThucHanhService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the HeSoNhomThucHanhDataSourceView used by the HeSoNhomThucHanhDataSource.
		/// </summary>
		protected HeSoNhomThucHanhDataSourceView HeSoNhomThucHanhView
		{
			get { return ( View as HeSoNhomThucHanhDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the HeSoNhomThucHanhDataSource control invokes to retrieve data.
		/// </summary>
		public HeSoNhomThucHanhSelectMethod SelectMethod
		{
			get
			{
				HeSoNhomThucHanhSelectMethod selectMethod = HeSoNhomThucHanhSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (HeSoNhomThucHanhSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the HeSoNhomThucHanhDataSourceView class that is to be
		/// used by the HeSoNhomThucHanhDataSource.
		/// </summary>
		/// <returns>An instance of the HeSoNhomThucHanhDataSourceView class.</returns>
		protected override BaseDataSourceView<HeSoNhomThucHanh, HeSoNhomThucHanhKey> GetNewDataSourceView()
		{
			return new HeSoNhomThucHanhDataSourceView(this, DefaultViewName);
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
	/// Supports the HeSoNhomThucHanhDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class HeSoNhomThucHanhDataSourceView : ProviderDataSourceView<HeSoNhomThucHanh, HeSoNhomThucHanhKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoNhomThucHanhDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the HeSoNhomThucHanhDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public HeSoNhomThucHanhDataSourceView(HeSoNhomThucHanhDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal HeSoNhomThucHanhDataSource HeSoNhomThucHanhOwner
		{
			get { return Owner as HeSoNhomThucHanhDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal HeSoNhomThucHanhSelectMethod SelectMethod
		{
			get { return HeSoNhomThucHanhOwner.SelectMethod; }
			set { HeSoNhomThucHanhOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal HeSoNhomThucHanhService HeSoNhomThucHanhProvider
		{
			get { return Provider as HeSoNhomThucHanhService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<HeSoNhomThucHanh> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<HeSoNhomThucHanh> results = null;
			HeSoNhomThucHanh item;
			count = 0;
			
			System.Int32 _id;
			System.String sp2405_NamHoc;
			System.String sp2405_HocKy;

			switch ( SelectMethod )
			{
				case HeSoNhomThucHanhSelectMethod.Get:
					HeSoNhomThucHanhKey entityKey  = new HeSoNhomThucHanhKey();
					entityKey.Load(values);
					item = HeSoNhomThucHanhProvider.Get(entityKey);
					results = new TList<HeSoNhomThucHanh>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case HeSoNhomThucHanhSelectMethod.GetAll:
                    results = HeSoNhomThucHanhProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case HeSoNhomThucHanhSelectMethod.GetPaged:
					results = HeSoNhomThucHanhProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case HeSoNhomThucHanhSelectMethod.Find:
					if ( FilterParameters != null )
						results = HeSoNhomThucHanhProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = HeSoNhomThucHanhProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case HeSoNhomThucHanhSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = HeSoNhomThucHanhProvider.GetById(_id);
					results = new TList<HeSoNhomThucHanh>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case HeSoNhomThucHanhSelectMethod.GetByNamHocHocKy:
					sp2405_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2405_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = HeSoNhomThucHanhProvider.GetByNamHocHocKy(sp2405_NamHoc, sp2405_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == HeSoNhomThucHanhSelectMethod.Get || SelectMethod == HeSoNhomThucHanhSelectMethod.GetById )
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
				HeSoNhomThucHanh entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					HeSoNhomThucHanhProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<HeSoNhomThucHanh> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			HeSoNhomThucHanhProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region HeSoNhomThucHanhDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the HeSoNhomThucHanhDataSource class.
	/// </summary>
	public class HeSoNhomThucHanhDataSourceDesigner : ProviderDataSourceDesigner<HeSoNhomThucHanh, HeSoNhomThucHanhKey>
	{
		/// <summary>
		/// Initializes a new instance of the HeSoNhomThucHanhDataSourceDesigner class.
		/// </summary>
		public HeSoNhomThucHanhDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoNhomThucHanhSelectMethod SelectMethod
		{
			get { return ((HeSoNhomThucHanhDataSource) DataSource).SelectMethod; }
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
				actions.Add(new HeSoNhomThucHanhDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region HeSoNhomThucHanhDataSourceActionList

	/// <summary>
	/// Supports the HeSoNhomThucHanhDataSourceDesigner class.
	/// </summary>
	internal class HeSoNhomThucHanhDataSourceActionList : DesignerActionList
	{
		private HeSoNhomThucHanhDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the HeSoNhomThucHanhDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public HeSoNhomThucHanhDataSourceActionList(HeSoNhomThucHanhDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoNhomThucHanhSelectMethod SelectMethod
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

	#endregion HeSoNhomThucHanhDataSourceActionList
	
	#endregion HeSoNhomThucHanhDataSourceDesigner
	
	#region HeSoNhomThucHanhSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the HeSoNhomThucHanhDataSource.SelectMethod property.
	/// </summary>
	public enum HeSoNhomThucHanhSelectMethod
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
	
	#endregion HeSoNhomThucHanhSelectMethod

	#region HeSoNhomThucHanhFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoNhomThucHanh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoNhomThucHanhFilter : SqlFilter<HeSoNhomThucHanhColumn>
	{
	}
	
	#endregion HeSoNhomThucHanhFilter

	#region HeSoNhomThucHanhExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoNhomThucHanh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoNhomThucHanhExpressionBuilder : SqlExpressionBuilder<HeSoNhomThucHanhColumn>
	{
	}
	
	#endregion HeSoNhomThucHanhExpressionBuilder	

	#region HeSoNhomThucHanhProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;HeSoNhomThucHanhChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoNhomThucHanh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoNhomThucHanhProperty : ChildEntityProperty<HeSoNhomThucHanhChildEntityTypes>
	{
	}
	
	#endregion HeSoNhomThucHanhProperty
}

