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
	/// Represents the DataRepository.HocViProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(HocViDataSourceDesigner))]
	public class HocViDataSource : ProviderDataSource<HocVi, HocViKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HocViDataSource class.
		/// </summary>
		public HocViDataSource() : base(new HocViService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the HocViDataSourceView used by the HocViDataSource.
		/// </summary>
		protected HocViDataSourceView HocViView
		{
			get { return ( View as HocViDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the HocViDataSource control invokes to retrieve data.
		/// </summary>
		public HocViSelectMethod SelectMethod
		{
			get
			{
				HocViSelectMethod selectMethod = HocViSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (HocViSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the HocViDataSourceView class that is to be
		/// used by the HocViDataSource.
		/// </summary>
		/// <returns>An instance of the HocViDataSourceView class.</returns>
		protected override BaseDataSourceView<HocVi, HocViKey> GetNewDataSourceView()
		{
			return new HocViDataSourceView(this, DefaultViewName);
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
	/// Supports the HocViDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class HocViDataSourceView : ProviderDataSourceView<HocVi, HocViKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HocViDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the HocViDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public HocViDataSourceView(HocViDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal HocViDataSource HocViOwner
		{
			get { return Owner as HocViDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal HocViSelectMethod SelectMethod
		{
			get { return HocViOwner.SelectMethod; }
			set { HocViOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal HocViService HocViProvider
		{
			get { return Provider as HocViService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<HocVi> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<HocVi> results = null;
			HocVi item;
			count = 0;
			
			System.String _maQuanLy_nullable;
			System.Int32 _maHocVi;

			switch ( SelectMethod )
			{
				case HocViSelectMethod.Get:
					HocViKey entityKey  = new HocViKey();
					entityKey.Load(values);
					item = HocViProvider.Get(entityKey);
					results = new TList<HocVi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case HocViSelectMethod.GetAll:
                    results = HocViProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case HocViSelectMethod.GetPaged:
					results = HocViProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case HocViSelectMethod.Find:
					if ( FilterParameters != null )
						results = HocViProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = HocViProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case HocViSelectMethod.GetByMaHocVi:
					_maHocVi = ( values["MaHocVi"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaHocVi"], typeof(System.Int32)) : (int)0;
					item = HocViProvider.GetByMaHocVi(_maHocVi);
					results = new TList<HocVi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				case HocViSelectMethod.GetByMaQuanLy:
					_maQuanLy_nullable = (System.String) EntityUtil.ChangeType(values["MaQuanLy"], typeof(System.String));
					item = HocViProvider.GetByMaQuanLy(_maQuanLy_nullable);
					results = new TList<HocVi>();
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
			if ( SelectMethod == HocViSelectMethod.Get || SelectMethod == HocViSelectMethod.GetByMaHocVi )
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
				HocVi entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					HocViProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<HocVi> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			HocViProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region HocViDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the HocViDataSource class.
	/// </summary>
	public class HocViDataSourceDesigner : ProviderDataSourceDesigner<HocVi, HocViKey>
	{
		/// <summary>
		/// Initializes a new instance of the HocViDataSourceDesigner class.
		/// </summary>
		public HocViDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HocViSelectMethod SelectMethod
		{
			get { return ((HocViDataSource) DataSource).SelectMethod; }
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
				actions.Add(new HocViDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region HocViDataSourceActionList

	/// <summary>
	/// Supports the HocViDataSourceDesigner class.
	/// </summary>
	internal class HocViDataSourceActionList : DesignerActionList
	{
		private HocViDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the HocViDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public HocViDataSourceActionList(HocViDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HocViSelectMethod SelectMethod
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

	#endregion HocViDataSourceActionList
	
	#endregion HocViDataSourceDesigner
	
	#region HocViSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the HocViDataSource.SelectMethod property.
	/// </summary>
	public enum HocViSelectMethod
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
		/// Represents the GetByMaHocVi method.
		/// </summary>
		GetByMaHocVi
	}
	
	#endregion HocViSelectMethod

	#region HocViFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HocVi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HocViFilter : SqlFilter<HocViColumn>
	{
	}
	
	#endregion HocViFilter

	#region HocViExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HocVi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HocViExpressionBuilder : SqlExpressionBuilder<HocViColumn>
	{
	}
	
	#endregion HocViExpressionBuilder	

	#region HocViProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;HocViChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="HocVi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HocViProperty : ChildEntityProperty<HocViChildEntityTypes>
	{
	}
	
	#endregion HocViProperty
}

