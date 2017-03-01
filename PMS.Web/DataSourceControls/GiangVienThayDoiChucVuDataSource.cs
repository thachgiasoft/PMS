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
	/// Represents the DataRepository.GiangVienThayDoiChucVuProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(GiangVienThayDoiChucVuDataSourceDesigner))]
	public class GiangVienThayDoiChucVuDataSource : ProviderDataSource<GiangVienThayDoiChucVu, GiangVienThayDoiChucVuKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienThayDoiChucVuDataSource class.
		/// </summary>
		public GiangVienThayDoiChucVuDataSource() : base(new GiangVienThayDoiChucVuService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the GiangVienThayDoiChucVuDataSourceView used by the GiangVienThayDoiChucVuDataSource.
		/// </summary>
		protected GiangVienThayDoiChucVuDataSourceView GiangVienThayDoiChucVuView
		{
			get { return ( View as GiangVienThayDoiChucVuDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the GiangVienThayDoiChucVuDataSource control invokes to retrieve data.
		/// </summary>
		public GiangVienThayDoiChucVuSelectMethod SelectMethod
		{
			get
			{
				GiangVienThayDoiChucVuSelectMethod selectMethod = GiangVienThayDoiChucVuSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (GiangVienThayDoiChucVuSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the GiangVienThayDoiChucVuDataSourceView class that is to be
		/// used by the GiangVienThayDoiChucVuDataSource.
		/// </summary>
		/// <returns>An instance of the GiangVienThayDoiChucVuDataSourceView class.</returns>
		protected override BaseDataSourceView<GiangVienThayDoiChucVu, GiangVienThayDoiChucVuKey> GetNewDataSourceView()
		{
			return new GiangVienThayDoiChucVuDataSourceView(this, DefaultViewName);
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
	/// Supports the GiangVienThayDoiChucVuDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class GiangVienThayDoiChucVuDataSourceView : ProviderDataSourceView<GiangVienThayDoiChucVu, GiangVienThayDoiChucVuKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienThayDoiChucVuDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the GiangVienThayDoiChucVuDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public GiangVienThayDoiChucVuDataSourceView(GiangVienThayDoiChucVuDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal GiangVienThayDoiChucVuDataSource GiangVienThayDoiChucVuOwner
		{
			get { return Owner as GiangVienThayDoiChucVuDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal GiangVienThayDoiChucVuSelectMethod SelectMethod
		{
			get { return GiangVienThayDoiChucVuOwner.SelectMethod; }
			set { GiangVienThayDoiChucVuOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal GiangVienThayDoiChucVuService GiangVienThayDoiChucVuProvider
		{
			get { return Provider as GiangVienThayDoiChucVuService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<GiangVienThayDoiChucVu> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<GiangVienThayDoiChucVu> results = null;
			GiangVienThayDoiChucVu item;
			count = 0;
			
			System.Int32 _maQuanLy;

			switch ( SelectMethod )
			{
				case GiangVienThayDoiChucVuSelectMethod.Get:
					GiangVienThayDoiChucVuKey entityKey  = new GiangVienThayDoiChucVuKey();
					entityKey.Load(values);
					item = GiangVienThayDoiChucVuProvider.Get(entityKey);
					results = new TList<GiangVienThayDoiChucVu>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case GiangVienThayDoiChucVuSelectMethod.GetAll:
                    results = GiangVienThayDoiChucVuProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case GiangVienThayDoiChucVuSelectMethod.GetPaged:
					results = GiangVienThayDoiChucVuProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case GiangVienThayDoiChucVuSelectMethod.Find:
					if ( FilterParameters != null )
						results = GiangVienThayDoiChucVuProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = GiangVienThayDoiChucVuProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case GiangVienThayDoiChucVuSelectMethod.GetByMaQuanLy:
					_maQuanLy = ( values["MaQuanLy"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaQuanLy"], typeof(System.Int32)) : (int)0;
					item = GiangVienThayDoiChucVuProvider.GetByMaQuanLy(_maQuanLy);
					results = new TList<GiangVienThayDoiChucVu>();
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
			if ( SelectMethod == GiangVienThayDoiChucVuSelectMethod.Get || SelectMethod == GiangVienThayDoiChucVuSelectMethod.GetByMaQuanLy )
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
				GiangVienThayDoiChucVu entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					GiangVienThayDoiChucVuProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<GiangVienThayDoiChucVu> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			GiangVienThayDoiChucVuProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region GiangVienThayDoiChucVuDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the GiangVienThayDoiChucVuDataSource class.
	/// </summary>
	public class GiangVienThayDoiChucVuDataSourceDesigner : ProviderDataSourceDesigner<GiangVienThayDoiChucVu, GiangVienThayDoiChucVuKey>
	{
		/// <summary>
		/// Initializes a new instance of the GiangVienThayDoiChucVuDataSourceDesigner class.
		/// </summary>
		public GiangVienThayDoiChucVuDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienThayDoiChucVuSelectMethod SelectMethod
		{
			get { return ((GiangVienThayDoiChucVuDataSource) DataSource).SelectMethod; }
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
				actions.Add(new GiangVienThayDoiChucVuDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region GiangVienThayDoiChucVuDataSourceActionList

	/// <summary>
	/// Supports the GiangVienThayDoiChucVuDataSourceDesigner class.
	/// </summary>
	internal class GiangVienThayDoiChucVuDataSourceActionList : DesignerActionList
	{
		private GiangVienThayDoiChucVuDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the GiangVienThayDoiChucVuDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public GiangVienThayDoiChucVuDataSourceActionList(GiangVienThayDoiChucVuDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienThayDoiChucVuSelectMethod SelectMethod
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

	#endregion GiangVienThayDoiChucVuDataSourceActionList
	
	#endregion GiangVienThayDoiChucVuDataSourceDesigner
	
	#region GiangVienThayDoiChucVuSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the GiangVienThayDoiChucVuDataSource.SelectMethod property.
	/// </summary>
	public enum GiangVienThayDoiChucVuSelectMethod
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
	
	#endregion GiangVienThayDoiChucVuSelectMethod

	#region GiangVienThayDoiChucVuFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienThayDoiChucVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienThayDoiChucVuFilter : SqlFilter<GiangVienThayDoiChucVuColumn>
	{
	}
	
	#endregion GiangVienThayDoiChucVuFilter

	#region GiangVienThayDoiChucVuExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienThayDoiChucVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienThayDoiChucVuExpressionBuilder : SqlExpressionBuilder<GiangVienThayDoiChucVuColumn>
	{
	}
	
	#endregion GiangVienThayDoiChucVuExpressionBuilder	

	#region GiangVienThayDoiChucVuProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;GiangVienThayDoiChucVuChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienThayDoiChucVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienThayDoiChucVuProperty : ChildEntityProperty<GiangVienThayDoiChucVuChildEntityTypes>
	{
	}
	
	#endregion GiangVienThayDoiChucVuProperty
}

