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
	/// Represents the DataRepository.HeSoKhoiNganhProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(HeSoKhoiNganhDataSourceDesigner))]
	public class HeSoKhoiNganhDataSource : ProviderDataSource<HeSoKhoiNganh, HeSoKhoiNganhKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoKhoiNganhDataSource class.
		/// </summary>
		public HeSoKhoiNganhDataSource() : base(new HeSoKhoiNganhService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the HeSoKhoiNganhDataSourceView used by the HeSoKhoiNganhDataSource.
		/// </summary>
		protected HeSoKhoiNganhDataSourceView HeSoKhoiNganhView
		{
			get { return ( View as HeSoKhoiNganhDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the HeSoKhoiNganhDataSource control invokes to retrieve data.
		/// </summary>
		public HeSoKhoiNganhSelectMethod SelectMethod
		{
			get
			{
				HeSoKhoiNganhSelectMethod selectMethod = HeSoKhoiNganhSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (HeSoKhoiNganhSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the HeSoKhoiNganhDataSourceView class that is to be
		/// used by the HeSoKhoiNganhDataSource.
		/// </summary>
		/// <returns>An instance of the HeSoKhoiNganhDataSourceView class.</returns>
		protected override BaseDataSourceView<HeSoKhoiNganh, HeSoKhoiNganhKey> GetNewDataSourceView()
		{
			return new HeSoKhoiNganhDataSourceView(this, DefaultViewName);
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
	/// Supports the HeSoKhoiNganhDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class HeSoKhoiNganhDataSourceView : ProviderDataSourceView<HeSoKhoiNganh, HeSoKhoiNganhKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoKhoiNganhDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the HeSoKhoiNganhDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public HeSoKhoiNganhDataSourceView(HeSoKhoiNganhDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal HeSoKhoiNganhDataSource HeSoKhoiNganhOwner
		{
			get { return Owner as HeSoKhoiNganhDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal HeSoKhoiNganhSelectMethod SelectMethod
		{
			get { return HeSoKhoiNganhOwner.SelectMethod; }
			set { HeSoKhoiNganhOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal HeSoKhoiNganhService HeSoKhoiNganhProvider
		{
			get { return Provider as HeSoKhoiNganhService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<HeSoKhoiNganh> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<HeSoKhoiNganh> results = null;
			HeSoKhoiNganh item;
			count = 0;
			
			System.Int32 _id;
			System.String sp2376_NamHoc;
			System.String sp2376_HocKy;

			switch ( SelectMethod )
			{
				case HeSoKhoiNganhSelectMethod.Get:
					HeSoKhoiNganhKey entityKey  = new HeSoKhoiNganhKey();
					entityKey.Load(values);
					item = HeSoKhoiNganhProvider.Get(entityKey);
					results = new TList<HeSoKhoiNganh>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case HeSoKhoiNganhSelectMethod.GetAll:
                    results = HeSoKhoiNganhProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case HeSoKhoiNganhSelectMethod.GetPaged:
					results = HeSoKhoiNganhProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case HeSoKhoiNganhSelectMethod.Find:
					if ( FilterParameters != null )
						results = HeSoKhoiNganhProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = HeSoKhoiNganhProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case HeSoKhoiNganhSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = HeSoKhoiNganhProvider.GetById(_id);
					results = new TList<HeSoKhoiNganh>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case HeSoKhoiNganhSelectMethod.GetByNamHocHocKy:
					sp2376_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2376_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = HeSoKhoiNganhProvider.GetByNamHocHocKy(sp2376_NamHoc, sp2376_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == HeSoKhoiNganhSelectMethod.Get || SelectMethod == HeSoKhoiNganhSelectMethod.GetById )
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
				HeSoKhoiNganh entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					HeSoKhoiNganhProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<HeSoKhoiNganh> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			HeSoKhoiNganhProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region HeSoKhoiNganhDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the HeSoKhoiNganhDataSource class.
	/// </summary>
	public class HeSoKhoiNganhDataSourceDesigner : ProviderDataSourceDesigner<HeSoKhoiNganh, HeSoKhoiNganhKey>
	{
		/// <summary>
		/// Initializes a new instance of the HeSoKhoiNganhDataSourceDesigner class.
		/// </summary>
		public HeSoKhoiNganhDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoKhoiNganhSelectMethod SelectMethod
		{
			get { return ((HeSoKhoiNganhDataSource) DataSource).SelectMethod; }
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
				actions.Add(new HeSoKhoiNganhDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region HeSoKhoiNganhDataSourceActionList

	/// <summary>
	/// Supports the HeSoKhoiNganhDataSourceDesigner class.
	/// </summary>
	internal class HeSoKhoiNganhDataSourceActionList : DesignerActionList
	{
		private HeSoKhoiNganhDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the HeSoKhoiNganhDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public HeSoKhoiNganhDataSourceActionList(HeSoKhoiNganhDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoKhoiNganhSelectMethod SelectMethod
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

	#endregion HeSoKhoiNganhDataSourceActionList
	
	#endregion HeSoKhoiNganhDataSourceDesigner
	
	#region HeSoKhoiNganhSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the HeSoKhoiNganhDataSource.SelectMethod property.
	/// </summary>
	public enum HeSoKhoiNganhSelectMethod
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
	
	#endregion HeSoKhoiNganhSelectMethod

	#region HeSoKhoiNganhFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoKhoiNganh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoKhoiNganhFilter : SqlFilter<HeSoKhoiNganhColumn>
	{
	}
	
	#endregion HeSoKhoiNganhFilter

	#region HeSoKhoiNganhExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoKhoiNganh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoKhoiNganhExpressionBuilder : SqlExpressionBuilder<HeSoKhoiNganhColumn>
	{
	}
	
	#endregion HeSoKhoiNganhExpressionBuilder	

	#region HeSoKhoiNganhProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;HeSoKhoiNganhChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoKhoiNganh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoKhoiNganhProperty : ChildEntityProperty<HeSoKhoiNganhChildEntityTypes>
	{
	}
	
	#endregion HeSoKhoiNganhProperty
}

