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
	/// Represents the DataRepository.GiangVienGiamTruDinhMucProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(GiangVienGiamTruDinhMucDataSourceDesigner))]
	public class GiangVienGiamTruDinhMucDataSource : ProviderDataSource<GiangVienGiamTruDinhMuc, GiangVienGiamTruDinhMucKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienGiamTruDinhMucDataSource class.
		/// </summary>
		public GiangVienGiamTruDinhMucDataSource() : base(new GiangVienGiamTruDinhMucService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the GiangVienGiamTruDinhMucDataSourceView used by the GiangVienGiamTruDinhMucDataSource.
		/// </summary>
		protected GiangVienGiamTruDinhMucDataSourceView GiangVienGiamTruDinhMucView
		{
			get { return ( View as GiangVienGiamTruDinhMucDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the GiangVienGiamTruDinhMucDataSource control invokes to retrieve data.
		/// </summary>
		public GiangVienGiamTruDinhMucSelectMethod SelectMethod
		{
			get
			{
				GiangVienGiamTruDinhMucSelectMethod selectMethod = GiangVienGiamTruDinhMucSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (GiangVienGiamTruDinhMucSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the GiangVienGiamTruDinhMucDataSourceView class that is to be
		/// used by the GiangVienGiamTruDinhMucDataSource.
		/// </summary>
		/// <returns>An instance of the GiangVienGiamTruDinhMucDataSourceView class.</returns>
		protected override BaseDataSourceView<GiangVienGiamTruDinhMuc, GiangVienGiamTruDinhMucKey> GetNewDataSourceView()
		{
			return new GiangVienGiamTruDinhMucDataSourceView(this, DefaultViewName);
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
	/// Supports the GiangVienGiamTruDinhMucDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class GiangVienGiamTruDinhMucDataSourceView : ProviderDataSourceView<GiangVienGiamTruDinhMuc, GiangVienGiamTruDinhMucKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienGiamTruDinhMucDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the GiangVienGiamTruDinhMucDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public GiangVienGiamTruDinhMucDataSourceView(GiangVienGiamTruDinhMucDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal GiangVienGiamTruDinhMucDataSource GiangVienGiamTruDinhMucOwner
		{
			get { return Owner as GiangVienGiamTruDinhMucDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal GiangVienGiamTruDinhMucSelectMethod SelectMethod
		{
			get { return GiangVienGiamTruDinhMucOwner.SelectMethod; }
			set { GiangVienGiamTruDinhMucOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal GiangVienGiamTruDinhMucService GiangVienGiamTruDinhMucProvider
		{
			get { return Provider as GiangVienGiamTruDinhMucService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<GiangVienGiamTruDinhMuc> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<GiangVienGiamTruDinhMuc> results = null;
			GiangVienGiamTruDinhMuc item;
			count = 0;
			
			System.Int32 _maQuanLy;
			System.Int32? _maGiamTru_nullable;
			System.Int32? _maGiangVien_nullable;
			System.String sp2251_NamHoc;

			switch ( SelectMethod )
			{
				case GiangVienGiamTruDinhMucSelectMethod.Get:
					GiangVienGiamTruDinhMucKey entityKey  = new GiangVienGiamTruDinhMucKey();
					entityKey.Load(values);
					item = GiangVienGiamTruDinhMucProvider.Get(entityKey);
					results = new TList<GiangVienGiamTruDinhMuc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case GiangVienGiamTruDinhMucSelectMethod.GetAll:
                    results = GiangVienGiamTruDinhMucProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case GiangVienGiamTruDinhMucSelectMethod.GetPaged:
					results = GiangVienGiamTruDinhMucProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case GiangVienGiamTruDinhMucSelectMethod.Find:
					if ( FilterParameters != null )
						results = GiangVienGiamTruDinhMucProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = GiangVienGiamTruDinhMucProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case GiangVienGiamTruDinhMucSelectMethod.GetByMaQuanLy:
					_maQuanLy = ( values["MaQuanLy"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaQuanLy"], typeof(System.Int32)) : (int)0;
					item = GiangVienGiamTruDinhMucProvider.GetByMaQuanLy(_maQuanLy);
					results = new TList<GiangVienGiamTruDinhMuc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case GiangVienGiamTruDinhMucSelectMethod.GetByMaGiamTru:
					_maGiamTru_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaGiamTru"], typeof(System.Int32?));
					results = GiangVienGiamTruDinhMucProvider.GetByMaGiamTru(_maGiamTru_nullable, this.StartIndex, this.PageSize, out count);
					break;
				case GiangVienGiamTruDinhMucSelectMethod.GetByMaGiangVien:
					_maGiangVien_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32?));
					results = GiangVienGiamTruDinhMucProvider.GetByMaGiangVien(_maGiangVien_nullable, this.StartIndex, this.PageSize, out count);
					break;
				// M:M
				// Custom
				case GiangVienGiamTruDinhMucSelectMethod.GetByNamHoc:
					sp2251_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					results = GiangVienGiamTruDinhMucProvider.GetByNamHoc(sp2251_NamHoc, StartIndex, PageSize);
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
			if ( SelectMethod == GiangVienGiamTruDinhMucSelectMethod.Get || SelectMethod == GiangVienGiamTruDinhMucSelectMethod.GetByMaQuanLy )
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
				GiangVienGiamTruDinhMuc entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					GiangVienGiamTruDinhMucProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<GiangVienGiamTruDinhMuc> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			GiangVienGiamTruDinhMucProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region GiangVienGiamTruDinhMucDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the GiangVienGiamTruDinhMucDataSource class.
	/// </summary>
	public class GiangVienGiamTruDinhMucDataSourceDesigner : ProviderDataSourceDesigner<GiangVienGiamTruDinhMuc, GiangVienGiamTruDinhMucKey>
	{
		/// <summary>
		/// Initializes a new instance of the GiangVienGiamTruDinhMucDataSourceDesigner class.
		/// </summary>
		public GiangVienGiamTruDinhMucDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienGiamTruDinhMucSelectMethod SelectMethod
		{
			get { return ((GiangVienGiamTruDinhMucDataSource) DataSource).SelectMethod; }
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
				actions.Add(new GiangVienGiamTruDinhMucDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region GiangVienGiamTruDinhMucDataSourceActionList

	/// <summary>
	/// Supports the GiangVienGiamTruDinhMucDataSourceDesigner class.
	/// </summary>
	internal class GiangVienGiamTruDinhMucDataSourceActionList : DesignerActionList
	{
		private GiangVienGiamTruDinhMucDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the GiangVienGiamTruDinhMucDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public GiangVienGiamTruDinhMucDataSourceActionList(GiangVienGiamTruDinhMucDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienGiamTruDinhMucSelectMethod SelectMethod
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

	#endregion GiangVienGiamTruDinhMucDataSourceActionList
	
	#endregion GiangVienGiamTruDinhMucDataSourceDesigner
	
	#region GiangVienGiamTruDinhMucSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the GiangVienGiamTruDinhMucDataSource.SelectMethod property.
	/// </summary>
	public enum GiangVienGiamTruDinhMucSelectMethod
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
		/// Represents the GetByMaGiamTru method.
		/// </summary>
		GetByMaGiamTru,
		/// <summary>
		/// Represents the GetByMaGiangVien method.
		/// </summary>
		GetByMaGiangVien,
		/// <summary>
		/// Represents the GetByNamHoc method.
		/// </summary>
		GetByNamHoc
	}
	
	#endregion GiangVienGiamTruDinhMucSelectMethod

	#region GiangVienGiamTruDinhMucFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienGiamTruDinhMuc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienGiamTruDinhMucFilter : SqlFilter<GiangVienGiamTruDinhMucColumn>
	{
	}
	
	#endregion GiangVienGiamTruDinhMucFilter

	#region GiangVienGiamTruDinhMucExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienGiamTruDinhMuc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienGiamTruDinhMucExpressionBuilder : SqlExpressionBuilder<GiangVienGiamTruDinhMucColumn>
	{
	}
	
	#endregion GiangVienGiamTruDinhMucExpressionBuilder	

	#region GiangVienGiamTruDinhMucProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;GiangVienGiamTruDinhMucChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienGiamTruDinhMuc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienGiamTruDinhMucProperty : ChildEntityProperty<GiangVienGiamTruDinhMucChildEntityTypes>
	{
	}
	
	#endregion GiangVienGiamTruDinhMucProperty
}

