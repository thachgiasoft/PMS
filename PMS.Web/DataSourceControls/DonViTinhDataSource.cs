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
	/// Represents the DataRepository.DonViTinhProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(DonViTinhDataSourceDesigner))]
	public class DonViTinhDataSource : ProviderDataSource<DonViTinh, DonViTinhKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonViTinhDataSource class.
		/// </summary>
		public DonViTinhDataSource() : base(new DonViTinhService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the DonViTinhDataSourceView used by the DonViTinhDataSource.
		/// </summary>
		protected DonViTinhDataSourceView DonViTinhView
		{
			get { return ( View as DonViTinhDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DonViTinhDataSource control invokes to retrieve data.
		/// </summary>
		public DonViTinhSelectMethod SelectMethod
		{
			get
			{
				DonViTinhSelectMethod selectMethod = DonViTinhSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (DonViTinhSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the DonViTinhDataSourceView class that is to be
		/// used by the DonViTinhDataSource.
		/// </summary>
		/// <returns>An instance of the DonViTinhDataSourceView class.</returns>
		protected override BaseDataSourceView<DonViTinh, DonViTinhKey> GetNewDataSourceView()
		{
			return new DonViTinhDataSourceView(this, DefaultViewName);
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
	/// Supports the DonViTinhDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class DonViTinhDataSourceView : ProviderDataSourceView<DonViTinh, DonViTinhKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonViTinhDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the DonViTinhDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public DonViTinhDataSourceView(DonViTinhDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal DonViTinhDataSource DonViTinhOwner
		{
			get { return Owner as DonViTinhDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal DonViTinhSelectMethod SelectMethod
		{
			get { return DonViTinhOwner.SelectMethod; }
			set { DonViTinhOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal DonViTinhService DonViTinhProvider
		{
			get { return Provider as DonViTinhService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<DonViTinh> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<DonViTinh> results = null;
			DonViTinh item;
			count = 0;
			
			System.String _maQuanLy;
			System.Int32 _maDonVi;

			switch ( SelectMethod )
			{
				case DonViTinhSelectMethod.Get:
					DonViTinhKey entityKey  = new DonViTinhKey();
					entityKey.Load(values);
					item = DonViTinhProvider.Get(entityKey);
					results = new TList<DonViTinh>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case DonViTinhSelectMethod.GetAll:
                    results = DonViTinhProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case DonViTinhSelectMethod.GetPaged:
					results = DonViTinhProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case DonViTinhSelectMethod.Find:
					if ( FilterParameters != null )
						results = DonViTinhProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = DonViTinhProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case DonViTinhSelectMethod.GetByMaDonVi:
					_maDonVi = ( values["MaDonVi"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.Int32)) : (int)0;
					item = DonViTinhProvider.GetByMaDonVi(_maDonVi);
					results = new TList<DonViTinh>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				case DonViTinhSelectMethod.GetByMaQuanLy:
					_maQuanLy = ( values["MaQuanLy"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaQuanLy"], typeof(System.String)) : string.Empty;
					item = DonViTinhProvider.GetByMaQuanLy(_maQuanLy);
					results = new TList<DonViTinh>();
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
			if ( SelectMethod == DonViTinhSelectMethod.Get || SelectMethod == DonViTinhSelectMethod.GetByMaDonVi )
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
				DonViTinh entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					DonViTinhProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<DonViTinh> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			DonViTinhProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region DonViTinhDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the DonViTinhDataSource class.
	/// </summary>
	public class DonViTinhDataSourceDesigner : ProviderDataSourceDesigner<DonViTinh, DonViTinhKey>
	{
		/// <summary>
		/// Initializes a new instance of the DonViTinhDataSourceDesigner class.
		/// </summary>
		public DonViTinhDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DonViTinhSelectMethod SelectMethod
		{
			get { return ((DonViTinhDataSource) DataSource).SelectMethod; }
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
				actions.Add(new DonViTinhDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region DonViTinhDataSourceActionList

	/// <summary>
	/// Supports the DonViTinhDataSourceDesigner class.
	/// </summary>
	internal class DonViTinhDataSourceActionList : DesignerActionList
	{
		private DonViTinhDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the DonViTinhDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public DonViTinhDataSourceActionList(DonViTinhDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DonViTinhSelectMethod SelectMethod
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

	#endregion DonViTinhDataSourceActionList
	
	#endregion DonViTinhDataSourceDesigner
	
	#region DonViTinhSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the DonViTinhDataSource.SelectMethod property.
	/// </summary>
	public enum DonViTinhSelectMethod
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
		/// Represents the GetByMaDonVi method.
		/// </summary>
		GetByMaDonVi
	}
	
	#endregion DonViTinhSelectMethod

	#region DonViTinhFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonViTinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonViTinhFilter : SqlFilter<DonViTinhColumn>
	{
	}
	
	#endregion DonViTinhFilter

	#region DonViTinhExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonViTinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonViTinhExpressionBuilder : SqlExpressionBuilder<DonViTinhColumn>
	{
	}
	
	#endregion DonViTinhExpressionBuilder	

	#region DonViTinhProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;DonViTinhChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="DonViTinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonViTinhProperty : ChildEntityProperty<DonViTinhChildEntityTypes>
	{
	}
	
	#endregion DonViTinhProperty
}

