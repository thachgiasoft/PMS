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
	/// Represents the DataRepository.HeSoHocKyProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(HeSoHocKyDataSourceDesigner))]
	public class HeSoHocKyDataSource : ProviderDataSource<HeSoHocKy, HeSoHocKyKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoHocKyDataSource class.
		/// </summary>
		public HeSoHocKyDataSource() : base(new HeSoHocKyService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the HeSoHocKyDataSourceView used by the HeSoHocKyDataSource.
		/// </summary>
		protected HeSoHocKyDataSourceView HeSoHocKyView
		{
			get { return ( View as HeSoHocKyDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the HeSoHocKyDataSource control invokes to retrieve data.
		/// </summary>
		public HeSoHocKySelectMethod SelectMethod
		{
			get
			{
				HeSoHocKySelectMethod selectMethod = HeSoHocKySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (HeSoHocKySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the HeSoHocKyDataSourceView class that is to be
		/// used by the HeSoHocKyDataSource.
		/// </summary>
		/// <returns>An instance of the HeSoHocKyDataSourceView class.</returns>
		protected override BaseDataSourceView<HeSoHocKy, HeSoHocKyKey> GetNewDataSourceView()
		{
			return new HeSoHocKyDataSourceView(this, DefaultViewName);
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
	/// Supports the HeSoHocKyDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class HeSoHocKyDataSourceView : ProviderDataSourceView<HeSoHocKy, HeSoHocKyKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoHocKyDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the HeSoHocKyDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public HeSoHocKyDataSourceView(HeSoHocKyDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal HeSoHocKyDataSource HeSoHocKyOwner
		{
			get { return Owner as HeSoHocKyDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal HeSoHocKySelectMethod SelectMethod
		{
			get { return HeSoHocKyOwner.SelectMethod; }
			set { HeSoHocKyOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal HeSoHocKyService HeSoHocKyProvider
		{
			get { return Provider as HeSoHocKyService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<HeSoHocKy> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<HeSoHocKy> results = null;
			HeSoHocKy item;
			count = 0;
			
			System.String _maQuanLy_nullable;
			System.Int32 _maHocKy;
			System.String sp2371_MaHocKy;
			System.String sp2372_MaHocKy;

			switch ( SelectMethod )
			{
				case HeSoHocKySelectMethod.Get:
					HeSoHocKyKey entityKey  = new HeSoHocKyKey();
					entityKey.Load(values);
					item = HeSoHocKyProvider.Get(entityKey);
					results = new TList<HeSoHocKy>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case HeSoHocKySelectMethod.GetAll:
                    results = HeSoHocKyProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case HeSoHocKySelectMethod.GetPaged:
					results = HeSoHocKyProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case HeSoHocKySelectMethod.Find:
					if ( FilterParameters != null )
						results = HeSoHocKyProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = HeSoHocKyProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case HeSoHocKySelectMethod.GetByMaHocKy:
					_maHocKy = ( values["MaHocKy"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaHocKy"], typeof(System.Int32)) : (int)0;
					item = HeSoHocKyProvider.GetByMaHocKy(_maHocKy);
					results = new TList<HeSoHocKy>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				case HeSoHocKySelectMethod.GetByMaQuanLy:
					_maQuanLy_nullable = (System.String) EntityUtil.ChangeType(values["MaQuanLy"], typeof(System.String));
					item = HeSoHocKyProvider.GetByMaQuanLy(_maQuanLy_nullable);
					results = new TList<HeSoHocKy>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// FK
				// M:M
				// Custom
				case HeSoHocKySelectMethod.GetByHocKy:
					sp2371_MaHocKy = (System.String) EntityUtil.ChangeType(values["MaHocKy"], typeof(System.String));
					results = HeSoHocKyProvider.GetByHocKy(sp2371_MaHocKy, StartIndex, PageSize);
					break;
				case HeSoHocKySelectMethod.GetByMaHocKy:
					sp2372_MaHocKy = (System.String) EntityUtil.ChangeType(values["MaHocKy"], typeof(System.String));
					results = HeSoHocKyProvider.GetByMaHocKy(sp2372_MaHocKy, StartIndex, PageSize);
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
			if ( SelectMethod == HeSoHocKySelectMethod.Get || SelectMethod == HeSoHocKySelectMethod.GetByMaHocKy )
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
				HeSoHocKy entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					HeSoHocKyProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<HeSoHocKy> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			HeSoHocKyProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region HeSoHocKyDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the HeSoHocKyDataSource class.
	/// </summary>
	public class HeSoHocKyDataSourceDesigner : ProviderDataSourceDesigner<HeSoHocKy, HeSoHocKyKey>
	{
		/// <summary>
		/// Initializes a new instance of the HeSoHocKyDataSourceDesigner class.
		/// </summary>
		public HeSoHocKyDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoHocKySelectMethod SelectMethod
		{
			get { return ((HeSoHocKyDataSource) DataSource).SelectMethod; }
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
				actions.Add(new HeSoHocKyDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region HeSoHocKyDataSourceActionList

	/// <summary>
	/// Supports the HeSoHocKyDataSourceDesigner class.
	/// </summary>
	internal class HeSoHocKyDataSourceActionList : DesignerActionList
	{
		private HeSoHocKyDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the HeSoHocKyDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public HeSoHocKyDataSourceActionList(HeSoHocKyDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoHocKySelectMethod SelectMethod
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

	#endregion HeSoHocKyDataSourceActionList
	
	#endregion HeSoHocKyDataSourceDesigner
	
	#region HeSoHocKySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the HeSoHocKyDataSource.SelectMethod property.
	/// </summary>
	public enum HeSoHocKySelectMethod
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
		/// Represents the GetByMaHocKy method.
		/// </summary>
		GetByMaHocKy,
		/// <summary>
		/// Represents the GetByHocKy method.
		/// </summary>
		GetByHocKy
	}
	
	#endregion HeSoHocKySelectMethod

	#region HeSoHocKyFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoHocKy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoHocKyFilter : SqlFilter<HeSoHocKyColumn>
	{
	}
	
	#endregion HeSoHocKyFilter

	#region HeSoHocKyExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoHocKy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoHocKyExpressionBuilder : SqlExpressionBuilder<HeSoHocKyColumn>
	{
	}
	
	#endregion HeSoHocKyExpressionBuilder	

	#region HeSoHocKyProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;HeSoHocKyChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoHocKy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoHocKyProperty : ChildEntityProperty<HeSoHocKyChildEntityTypes>
	{
	}
	
	#endregion HeSoHocKyProperty
}

