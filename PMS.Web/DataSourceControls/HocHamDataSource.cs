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
	/// Represents the DataRepository.HocHamProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(HocHamDataSourceDesigner))]
	public class HocHamDataSource : ProviderDataSource<HocHam, HocHamKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HocHamDataSource class.
		/// </summary>
		public HocHamDataSource() : base(new HocHamService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the HocHamDataSourceView used by the HocHamDataSource.
		/// </summary>
		protected HocHamDataSourceView HocHamView
		{
			get { return ( View as HocHamDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the HocHamDataSource control invokes to retrieve data.
		/// </summary>
		public HocHamSelectMethod SelectMethod
		{
			get
			{
				HocHamSelectMethod selectMethod = HocHamSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (HocHamSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the HocHamDataSourceView class that is to be
		/// used by the HocHamDataSource.
		/// </summary>
		/// <returns>An instance of the HocHamDataSourceView class.</returns>
		protected override BaseDataSourceView<HocHam, HocHamKey> GetNewDataSourceView()
		{
			return new HocHamDataSourceView(this, DefaultViewName);
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
	/// Supports the HocHamDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class HocHamDataSourceView : ProviderDataSourceView<HocHam, HocHamKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HocHamDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the HocHamDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public HocHamDataSourceView(HocHamDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal HocHamDataSource HocHamOwner
		{
			get { return Owner as HocHamDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal HocHamSelectMethod SelectMethod
		{
			get { return HocHamOwner.SelectMethod; }
			set { HocHamOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal HocHamService HocHamProvider
		{
			get { return Provider as HocHamService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<HocHam> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<HocHam> results = null;
			HocHam item;
			count = 0;
			
			System.String _maQuanLy;
			System.Int32 _maHocHam;

			switch ( SelectMethod )
			{
				case HocHamSelectMethod.Get:
					HocHamKey entityKey  = new HocHamKey();
					entityKey.Load(values);
					item = HocHamProvider.Get(entityKey);
					results = new TList<HocHam>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case HocHamSelectMethod.GetAll:
                    results = HocHamProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case HocHamSelectMethod.GetPaged:
					results = HocHamProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case HocHamSelectMethod.Find:
					if ( FilterParameters != null )
						results = HocHamProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = HocHamProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case HocHamSelectMethod.GetByMaHocHam:
					_maHocHam = ( values["MaHocHam"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaHocHam"], typeof(System.Int32)) : (int)0;
					item = HocHamProvider.GetByMaHocHam(_maHocHam);
					results = new TList<HocHam>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				case HocHamSelectMethod.GetByMaQuanLy:
					_maQuanLy = ( values["MaQuanLy"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaQuanLy"], typeof(System.String)) : string.Empty;
					item = HocHamProvider.GetByMaQuanLy(_maQuanLy);
					results = new TList<HocHam>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// FK
				// M:M
				// Custom
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
			if ( SelectMethod == HocHamSelectMethod.Get || SelectMethod == HocHamSelectMethod.GetByMaHocHam )
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
				HocHam entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					HocHamProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<HocHam> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			HocHamProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region HocHamDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the HocHamDataSource class.
	/// </summary>
	public class HocHamDataSourceDesigner : ProviderDataSourceDesigner<HocHam, HocHamKey>
	{
		/// <summary>
		/// Initializes a new instance of the HocHamDataSourceDesigner class.
		/// </summary>
		public HocHamDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HocHamSelectMethod SelectMethod
		{
			get { return ((HocHamDataSource) DataSource).SelectMethod; }
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
				actions.Add(new HocHamDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region HocHamDataSourceActionList

	/// <summary>
	/// Supports the HocHamDataSourceDesigner class.
	/// </summary>
	internal class HocHamDataSourceActionList : DesignerActionList
	{
		private HocHamDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the HocHamDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public HocHamDataSourceActionList(HocHamDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HocHamSelectMethod SelectMethod
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

	#endregion HocHamDataSourceActionList
	
	#endregion HocHamDataSourceDesigner
	
	#region HocHamSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the HocHamDataSource.SelectMethod property.
	/// </summary>
	public enum HocHamSelectMethod
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
		/// Represents the GetByMaQuanLy method.
		/// </summary>
		GetByMaQuanLy,
		/// <summary>
		/// Represents the GetByMaHocHam method.
		/// </summary>
		GetByMaHocHam
	}
	
	#endregion HocHamSelectMethod

	#region HocHamFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HocHam"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HocHamFilter : SqlFilter<HocHamColumn>
	{
	}
	
	#endregion HocHamFilter

	#region HocHamExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HocHam"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HocHamExpressionBuilder : SqlExpressionBuilder<HocHamColumn>
	{
	}
	
	#endregion HocHamExpressionBuilder	

	#region HocHamProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;HocHamChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="HocHam"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HocHamProperty : ChildEntityProperty<HocHamChildEntityTypes>
	{
	}
	
	#endregion HocHamProperty
}

