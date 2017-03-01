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
	/// Represents the DataRepository.LopHocPhanGiangBangTiengNuocNgoaiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(LopHocPhanGiangBangTiengNuocNgoaiDataSourceDesigner))]
	public class LopHocPhanGiangBangTiengNuocNgoaiDataSource : ProviderDataSource<LopHocPhanGiangBangTiengNuocNgoai, LopHocPhanGiangBangTiengNuocNgoaiKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LopHocPhanGiangBangTiengNuocNgoaiDataSource class.
		/// </summary>
		public LopHocPhanGiangBangTiengNuocNgoaiDataSource() : base(new LopHocPhanGiangBangTiengNuocNgoaiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the LopHocPhanGiangBangTiengNuocNgoaiDataSourceView used by the LopHocPhanGiangBangTiengNuocNgoaiDataSource.
		/// </summary>
		protected LopHocPhanGiangBangTiengNuocNgoaiDataSourceView LopHocPhanGiangBangTiengNuocNgoaiView
		{
			get { return ( View as LopHocPhanGiangBangTiengNuocNgoaiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the LopHocPhanGiangBangTiengNuocNgoaiDataSource control invokes to retrieve data.
		/// </summary>
		public LopHocPhanGiangBangTiengNuocNgoaiSelectMethod SelectMethod
		{
			get
			{
				LopHocPhanGiangBangTiengNuocNgoaiSelectMethod selectMethod = LopHocPhanGiangBangTiengNuocNgoaiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (LopHocPhanGiangBangTiengNuocNgoaiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the LopHocPhanGiangBangTiengNuocNgoaiDataSourceView class that is to be
		/// used by the LopHocPhanGiangBangTiengNuocNgoaiDataSource.
		/// </summary>
		/// <returns>An instance of the LopHocPhanGiangBangTiengNuocNgoaiDataSourceView class.</returns>
		protected override BaseDataSourceView<LopHocPhanGiangBangTiengNuocNgoai, LopHocPhanGiangBangTiengNuocNgoaiKey> GetNewDataSourceView()
		{
			return new LopHocPhanGiangBangTiengNuocNgoaiDataSourceView(this, DefaultViewName);
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
	/// Supports the LopHocPhanGiangBangTiengNuocNgoaiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class LopHocPhanGiangBangTiengNuocNgoaiDataSourceView : ProviderDataSourceView<LopHocPhanGiangBangTiengNuocNgoai, LopHocPhanGiangBangTiengNuocNgoaiKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LopHocPhanGiangBangTiengNuocNgoaiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the LopHocPhanGiangBangTiengNuocNgoaiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public LopHocPhanGiangBangTiengNuocNgoaiDataSourceView(LopHocPhanGiangBangTiengNuocNgoaiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal LopHocPhanGiangBangTiengNuocNgoaiDataSource LopHocPhanGiangBangTiengNuocNgoaiOwner
		{
			get { return Owner as LopHocPhanGiangBangTiengNuocNgoaiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal LopHocPhanGiangBangTiengNuocNgoaiSelectMethod SelectMethod
		{
			get { return LopHocPhanGiangBangTiengNuocNgoaiOwner.SelectMethod; }
			set { LopHocPhanGiangBangTiengNuocNgoaiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal LopHocPhanGiangBangTiengNuocNgoaiService LopHocPhanGiangBangTiengNuocNgoaiProvider
		{
			get { return Provider as LopHocPhanGiangBangTiengNuocNgoaiService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<LopHocPhanGiangBangTiengNuocNgoai> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<LopHocPhanGiangBangTiengNuocNgoai> results = null;
			LopHocPhanGiangBangTiengNuocNgoai item;
			count = 0;
			
			System.String _maLopHocPhan;

			switch ( SelectMethod )
			{
				case LopHocPhanGiangBangTiengNuocNgoaiSelectMethod.Get:
					LopHocPhanGiangBangTiengNuocNgoaiKey entityKey  = new LopHocPhanGiangBangTiengNuocNgoaiKey();
					entityKey.Load(values);
					item = LopHocPhanGiangBangTiengNuocNgoaiProvider.Get(entityKey);
					results = new TList<LopHocPhanGiangBangTiengNuocNgoai>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case LopHocPhanGiangBangTiengNuocNgoaiSelectMethod.GetAll:
                    results = LopHocPhanGiangBangTiengNuocNgoaiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case LopHocPhanGiangBangTiengNuocNgoaiSelectMethod.GetPaged:
					results = LopHocPhanGiangBangTiengNuocNgoaiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case LopHocPhanGiangBangTiengNuocNgoaiSelectMethod.Find:
					if ( FilterParameters != null )
						results = LopHocPhanGiangBangTiengNuocNgoaiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = LopHocPhanGiangBangTiengNuocNgoaiProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case LopHocPhanGiangBangTiengNuocNgoaiSelectMethod.GetByMaLopHocPhan:
					_maLopHocPhan = ( values["MaLopHocPhan"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaLopHocPhan"], typeof(System.String)) : string.Empty;
					item = LopHocPhanGiangBangTiengNuocNgoaiProvider.GetByMaLopHocPhan(_maLopHocPhan);
					results = new TList<LopHocPhanGiangBangTiengNuocNgoai>();
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
			if ( SelectMethod == LopHocPhanGiangBangTiengNuocNgoaiSelectMethod.Get || SelectMethod == LopHocPhanGiangBangTiengNuocNgoaiSelectMethod.GetByMaLopHocPhan )
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
				LopHocPhanGiangBangTiengNuocNgoai entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					LopHocPhanGiangBangTiengNuocNgoaiProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<LopHocPhanGiangBangTiengNuocNgoai> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			LopHocPhanGiangBangTiengNuocNgoaiProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region LopHocPhanGiangBangTiengNuocNgoaiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the LopHocPhanGiangBangTiengNuocNgoaiDataSource class.
	/// </summary>
	public class LopHocPhanGiangBangTiengNuocNgoaiDataSourceDesigner : ProviderDataSourceDesigner<LopHocPhanGiangBangTiengNuocNgoai, LopHocPhanGiangBangTiengNuocNgoaiKey>
	{
		/// <summary>
		/// Initializes a new instance of the LopHocPhanGiangBangTiengNuocNgoaiDataSourceDesigner class.
		/// </summary>
		public LopHocPhanGiangBangTiengNuocNgoaiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public LopHocPhanGiangBangTiengNuocNgoaiSelectMethod SelectMethod
		{
			get { return ((LopHocPhanGiangBangTiengNuocNgoaiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new LopHocPhanGiangBangTiengNuocNgoaiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region LopHocPhanGiangBangTiengNuocNgoaiDataSourceActionList

	/// <summary>
	/// Supports the LopHocPhanGiangBangTiengNuocNgoaiDataSourceDesigner class.
	/// </summary>
	internal class LopHocPhanGiangBangTiengNuocNgoaiDataSourceActionList : DesignerActionList
	{
		private LopHocPhanGiangBangTiengNuocNgoaiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the LopHocPhanGiangBangTiengNuocNgoaiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public LopHocPhanGiangBangTiengNuocNgoaiDataSourceActionList(LopHocPhanGiangBangTiengNuocNgoaiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public LopHocPhanGiangBangTiengNuocNgoaiSelectMethod SelectMethod
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

	#endregion LopHocPhanGiangBangTiengNuocNgoaiDataSourceActionList
	
	#endregion LopHocPhanGiangBangTiengNuocNgoaiDataSourceDesigner
	
	#region LopHocPhanGiangBangTiengNuocNgoaiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the LopHocPhanGiangBangTiengNuocNgoaiDataSource.SelectMethod property.
	/// </summary>
	public enum LopHocPhanGiangBangTiengNuocNgoaiSelectMethod
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
	
	#endregion LopHocPhanGiangBangTiengNuocNgoaiSelectMethod

	#region LopHocPhanGiangBangTiengNuocNgoaiFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanGiangBangTiengNuocNgoai"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LopHocPhanGiangBangTiengNuocNgoaiFilter : SqlFilter<LopHocPhanGiangBangTiengNuocNgoaiColumn>
	{
	}
	
	#endregion LopHocPhanGiangBangTiengNuocNgoaiFilter

	#region LopHocPhanGiangBangTiengNuocNgoaiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanGiangBangTiengNuocNgoai"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LopHocPhanGiangBangTiengNuocNgoaiExpressionBuilder : SqlExpressionBuilder<LopHocPhanGiangBangTiengNuocNgoaiColumn>
	{
	}
	
	#endregion LopHocPhanGiangBangTiengNuocNgoaiExpressionBuilder	

	#region LopHocPhanGiangBangTiengNuocNgoaiProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;LopHocPhanGiangBangTiengNuocNgoaiChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanGiangBangTiengNuocNgoai"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LopHocPhanGiangBangTiengNuocNgoaiProperty : ChildEntityProperty<LopHocPhanGiangBangTiengNuocNgoaiChildEntityTypes>
	{
	}
	
	#endregion LopHocPhanGiangBangTiengNuocNgoaiProperty
}

