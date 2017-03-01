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
	/// Represents the DataRepository.LopHocPhanChuyenNganhProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(LopHocPhanChuyenNganhDataSourceDesigner))]
	public class LopHocPhanChuyenNganhDataSource : ProviderDataSource<LopHocPhanChuyenNganh, LopHocPhanChuyenNganhKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LopHocPhanChuyenNganhDataSource class.
		/// </summary>
		public LopHocPhanChuyenNganhDataSource() : base(new LopHocPhanChuyenNganhService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the LopHocPhanChuyenNganhDataSourceView used by the LopHocPhanChuyenNganhDataSource.
		/// </summary>
		protected LopHocPhanChuyenNganhDataSourceView LopHocPhanChuyenNganhView
		{
			get { return ( View as LopHocPhanChuyenNganhDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the LopHocPhanChuyenNganhDataSource control invokes to retrieve data.
		/// </summary>
		public LopHocPhanChuyenNganhSelectMethod SelectMethod
		{
			get
			{
				LopHocPhanChuyenNganhSelectMethod selectMethod = LopHocPhanChuyenNganhSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (LopHocPhanChuyenNganhSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the LopHocPhanChuyenNganhDataSourceView class that is to be
		/// used by the LopHocPhanChuyenNganhDataSource.
		/// </summary>
		/// <returns>An instance of the LopHocPhanChuyenNganhDataSourceView class.</returns>
		protected override BaseDataSourceView<LopHocPhanChuyenNganh, LopHocPhanChuyenNganhKey> GetNewDataSourceView()
		{
			return new LopHocPhanChuyenNganhDataSourceView(this, DefaultViewName);
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
	/// Supports the LopHocPhanChuyenNganhDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class LopHocPhanChuyenNganhDataSourceView : ProviderDataSourceView<LopHocPhanChuyenNganh, LopHocPhanChuyenNganhKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LopHocPhanChuyenNganhDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the LopHocPhanChuyenNganhDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public LopHocPhanChuyenNganhDataSourceView(LopHocPhanChuyenNganhDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal LopHocPhanChuyenNganhDataSource LopHocPhanChuyenNganhOwner
		{
			get { return Owner as LopHocPhanChuyenNganhDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal LopHocPhanChuyenNganhSelectMethod SelectMethod
		{
			get { return LopHocPhanChuyenNganhOwner.SelectMethod; }
			set { LopHocPhanChuyenNganhOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal LopHocPhanChuyenNganhService LopHocPhanChuyenNganhProvider
		{
			get { return Provider as LopHocPhanChuyenNganhService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<LopHocPhanChuyenNganh> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<LopHocPhanChuyenNganh> results = null;
			LopHocPhanChuyenNganh item;
			count = 0;
			
			System.String _maLopHocPhan;

			switch ( SelectMethod )
			{
				case LopHocPhanChuyenNganhSelectMethod.Get:
					LopHocPhanChuyenNganhKey entityKey  = new LopHocPhanChuyenNganhKey();
					entityKey.Load(values);
					item = LopHocPhanChuyenNganhProvider.Get(entityKey);
					results = new TList<LopHocPhanChuyenNganh>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case LopHocPhanChuyenNganhSelectMethod.GetAll:
                    results = LopHocPhanChuyenNganhProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case LopHocPhanChuyenNganhSelectMethod.GetPaged:
					results = LopHocPhanChuyenNganhProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case LopHocPhanChuyenNganhSelectMethod.Find:
					if ( FilterParameters != null )
						results = LopHocPhanChuyenNganhProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = LopHocPhanChuyenNganhProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case LopHocPhanChuyenNganhSelectMethod.GetByMaLopHocPhan:
					_maLopHocPhan = ( values["MaLopHocPhan"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaLopHocPhan"], typeof(System.String)) : string.Empty;
					item = LopHocPhanChuyenNganhProvider.GetByMaLopHocPhan(_maLopHocPhan);
					results = new TList<LopHocPhanChuyenNganh>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
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
			if ( SelectMethod == LopHocPhanChuyenNganhSelectMethod.Get || SelectMethod == LopHocPhanChuyenNganhSelectMethod.GetByMaLopHocPhan )
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
				LopHocPhanChuyenNganh entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					LopHocPhanChuyenNganhProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<LopHocPhanChuyenNganh> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			LopHocPhanChuyenNganhProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region LopHocPhanChuyenNganhDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the LopHocPhanChuyenNganhDataSource class.
	/// </summary>
	public class LopHocPhanChuyenNganhDataSourceDesigner : ProviderDataSourceDesigner<LopHocPhanChuyenNganh, LopHocPhanChuyenNganhKey>
	{
		/// <summary>
		/// Initializes a new instance of the LopHocPhanChuyenNganhDataSourceDesigner class.
		/// </summary>
		public LopHocPhanChuyenNganhDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public LopHocPhanChuyenNganhSelectMethod SelectMethod
		{
			get { return ((LopHocPhanChuyenNganhDataSource) DataSource).SelectMethod; }
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
				actions.Add(new LopHocPhanChuyenNganhDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region LopHocPhanChuyenNganhDataSourceActionList

	/// <summary>
	/// Supports the LopHocPhanChuyenNganhDataSourceDesigner class.
	/// </summary>
	internal class LopHocPhanChuyenNganhDataSourceActionList : DesignerActionList
	{
		private LopHocPhanChuyenNganhDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the LopHocPhanChuyenNganhDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public LopHocPhanChuyenNganhDataSourceActionList(LopHocPhanChuyenNganhDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public LopHocPhanChuyenNganhSelectMethod SelectMethod
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

	#endregion LopHocPhanChuyenNganhDataSourceActionList
	
	#endregion LopHocPhanChuyenNganhDataSourceDesigner
	
	#region LopHocPhanChuyenNganhSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the LopHocPhanChuyenNganhDataSource.SelectMethod property.
	/// </summary>
	public enum LopHocPhanChuyenNganhSelectMethod
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
		/// Represents the GetByMaLopHocPhan method.
		/// </summary>
		GetByMaLopHocPhan
	}
	
	#endregion LopHocPhanChuyenNganhSelectMethod

	#region LopHocPhanChuyenNganhFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanChuyenNganh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LopHocPhanChuyenNganhFilter : SqlFilter<LopHocPhanChuyenNganhColumn>
	{
	}
	
	#endregion LopHocPhanChuyenNganhFilter

	#region LopHocPhanChuyenNganhExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanChuyenNganh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LopHocPhanChuyenNganhExpressionBuilder : SqlExpressionBuilder<LopHocPhanChuyenNganhColumn>
	{
	}
	
	#endregion LopHocPhanChuyenNganhExpressionBuilder	

	#region LopHocPhanChuyenNganhProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;LopHocPhanChuyenNganhChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanChuyenNganh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LopHocPhanChuyenNganhProperty : ChildEntityProperty<LopHocPhanChuyenNganhChildEntityTypes>
	{
	}
	
	#endregion LopHocPhanChuyenNganhProperty
}

