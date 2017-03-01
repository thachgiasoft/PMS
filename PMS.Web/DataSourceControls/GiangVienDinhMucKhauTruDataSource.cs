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
	/// Represents the DataRepository.GiangVienDinhMucKhauTruProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(GiangVienDinhMucKhauTruDataSourceDesigner))]
	public class GiangVienDinhMucKhauTruDataSource : ProviderDataSource<GiangVienDinhMucKhauTru, GiangVienDinhMucKhauTruKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienDinhMucKhauTruDataSource class.
		/// </summary>
		public GiangVienDinhMucKhauTruDataSource() : base(new GiangVienDinhMucKhauTruService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the GiangVienDinhMucKhauTruDataSourceView used by the GiangVienDinhMucKhauTruDataSource.
		/// </summary>
		protected GiangVienDinhMucKhauTruDataSourceView GiangVienDinhMucKhauTruView
		{
			get { return ( View as GiangVienDinhMucKhauTruDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the GiangVienDinhMucKhauTruDataSource control invokes to retrieve data.
		/// </summary>
		public GiangVienDinhMucKhauTruSelectMethod SelectMethod
		{
			get
			{
				GiangVienDinhMucKhauTruSelectMethod selectMethod = GiangVienDinhMucKhauTruSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (GiangVienDinhMucKhauTruSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the GiangVienDinhMucKhauTruDataSourceView class that is to be
		/// used by the GiangVienDinhMucKhauTruDataSource.
		/// </summary>
		/// <returns>An instance of the GiangVienDinhMucKhauTruDataSourceView class.</returns>
		protected override BaseDataSourceView<GiangVienDinhMucKhauTru, GiangVienDinhMucKhauTruKey> GetNewDataSourceView()
		{
			return new GiangVienDinhMucKhauTruDataSourceView(this, DefaultViewName);
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
	/// Supports the GiangVienDinhMucKhauTruDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class GiangVienDinhMucKhauTruDataSourceView : ProviderDataSourceView<GiangVienDinhMucKhauTru, GiangVienDinhMucKhauTruKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienDinhMucKhauTruDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the GiangVienDinhMucKhauTruDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public GiangVienDinhMucKhauTruDataSourceView(GiangVienDinhMucKhauTruDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal GiangVienDinhMucKhauTruDataSource GiangVienDinhMucKhauTruOwner
		{
			get { return Owner as GiangVienDinhMucKhauTruDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal GiangVienDinhMucKhauTruSelectMethod SelectMethod
		{
			get { return GiangVienDinhMucKhauTruOwner.SelectMethod; }
			set { GiangVienDinhMucKhauTruOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal GiangVienDinhMucKhauTruService GiangVienDinhMucKhauTruProvider
		{
			get { return Provider as GiangVienDinhMucKhauTruService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<GiangVienDinhMucKhauTru> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<GiangVienDinhMucKhauTru> results = null;
			GiangVienDinhMucKhauTru item;
			count = 0;
			
			System.Int32 _maQuanLy;

			switch ( SelectMethod )
			{
				case GiangVienDinhMucKhauTruSelectMethod.Get:
					GiangVienDinhMucKhauTruKey entityKey  = new GiangVienDinhMucKhauTruKey();
					entityKey.Load(values);
					item = GiangVienDinhMucKhauTruProvider.Get(entityKey);
					results = new TList<GiangVienDinhMucKhauTru>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case GiangVienDinhMucKhauTruSelectMethod.GetAll:
                    results = GiangVienDinhMucKhauTruProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case GiangVienDinhMucKhauTruSelectMethod.GetPaged:
					results = GiangVienDinhMucKhauTruProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case GiangVienDinhMucKhauTruSelectMethod.Find:
					if ( FilterParameters != null )
						results = GiangVienDinhMucKhauTruProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = GiangVienDinhMucKhauTruProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case GiangVienDinhMucKhauTruSelectMethod.GetByMaQuanLy:
					_maQuanLy = ( values["MaQuanLy"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaQuanLy"], typeof(System.Int32)) : (int)0;
					item = GiangVienDinhMucKhauTruProvider.GetByMaQuanLy(_maQuanLy);
					results = new TList<GiangVienDinhMucKhauTru>();
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
			if ( SelectMethod == GiangVienDinhMucKhauTruSelectMethod.Get || SelectMethod == GiangVienDinhMucKhauTruSelectMethod.GetByMaQuanLy )
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
				GiangVienDinhMucKhauTru entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					GiangVienDinhMucKhauTruProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<GiangVienDinhMucKhauTru> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			GiangVienDinhMucKhauTruProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region GiangVienDinhMucKhauTruDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the GiangVienDinhMucKhauTruDataSource class.
	/// </summary>
	public class GiangVienDinhMucKhauTruDataSourceDesigner : ProviderDataSourceDesigner<GiangVienDinhMucKhauTru, GiangVienDinhMucKhauTruKey>
	{
		/// <summary>
		/// Initializes a new instance of the GiangVienDinhMucKhauTruDataSourceDesigner class.
		/// </summary>
		public GiangVienDinhMucKhauTruDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienDinhMucKhauTruSelectMethod SelectMethod
		{
			get { return ((GiangVienDinhMucKhauTruDataSource) DataSource).SelectMethod; }
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
				actions.Add(new GiangVienDinhMucKhauTruDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region GiangVienDinhMucKhauTruDataSourceActionList

	/// <summary>
	/// Supports the GiangVienDinhMucKhauTruDataSourceDesigner class.
	/// </summary>
	internal class GiangVienDinhMucKhauTruDataSourceActionList : DesignerActionList
	{
		private GiangVienDinhMucKhauTruDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the GiangVienDinhMucKhauTruDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public GiangVienDinhMucKhauTruDataSourceActionList(GiangVienDinhMucKhauTruDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienDinhMucKhauTruSelectMethod SelectMethod
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

	#endregion GiangVienDinhMucKhauTruDataSourceActionList
	
	#endregion GiangVienDinhMucKhauTruDataSourceDesigner
	
	#region GiangVienDinhMucKhauTruSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the GiangVienDinhMucKhauTruDataSource.SelectMethod property.
	/// </summary>
	public enum GiangVienDinhMucKhauTruSelectMethod
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
		GetByMaQuanLy
	}
	
	#endregion GiangVienDinhMucKhauTruSelectMethod

	#region GiangVienDinhMucKhauTruFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienDinhMucKhauTru"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienDinhMucKhauTruFilter : SqlFilter<GiangVienDinhMucKhauTruColumn>
	{
	}
	
	#endregion GiangVienDinhMucKhauTruFilter

	#region GiangVienDinhMucKhauTruExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienDinhMucKhauTru"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienDinhMucKhauTruExpressionBuilder : SqlExpressionBuilder<GiangVienDinhMucKhauTruColumn>
	{
	}
	
	#endregion GiangVienDinhMucKhauTruExpressionBuilder	

	#region GiangVienDinhMucKhauTruProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;GiangVienDinhMucKhauTruChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienDinhMucKhauTru"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienDinhMucKhauTruProperty : ChildEntityProperty<GiangVienDinhMucKhauTruChildEntityTypes>
	{
	}
	
	#endregion GiangVienDinhMucKhauTruProperty
}

