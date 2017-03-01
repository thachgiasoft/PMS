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
	/// Represents the DataRepository.DonGiaMotTietProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(DonGiaMotTietDataSourceDesigner))]
	public class DonGiaMotTietDataSource : ProviderDataSource<DonGiaMotTiet, DonGiaMotTietKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaMotTietDataSource class.
		/// </summary>
		public DonGiaMotTietDataSource() : base(new DonGiaMotTietService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the DonGiaMotTietDataSourceView used by the DonGiaMotTietDataSource.
		/// </summary>
		protected DonGiaMotTietDataSourceView DonGiaMotTietView
		{
			get { return ( View as DonGiaMotTietDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DonGiaMotTietDataSource control invokes to retrieve data.
		/// </summary>
		public DonGiaMotTietSelectMethod SelectMethod
		{
			get
			{
				DonGiaMotTietSelectMethod selectMethod = DonGiaMotTietSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (DonGiaMotTietSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the DonGiaMotTietDataSourceView class that is to be
		/// used by the DonGiaMotTietDataSource.
		/// </summary>
		/// <returns>An instance of the DonGiaMotTietDataSourceView class.</returns>
		protected override BaseDataSourceView<DonGiaMotTiet, DonGiaMotTietKey> GetNewDataSourceView()
		{
			return new DonGiaMotTietDataSourceView(this, DefaultViewName);
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
	/// Supports the DonGiaMotTietDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class DonGiaMotTietDataSourceView : ProviderDataSourceView<DonGiaMotTiet, DonGiaMotTietKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaMotTietDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the DonGiaMotTietDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public DonGiaMotTietDataSourceView(DonGiaMotTietDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal DonGiaMotTietDataSource DonGiaMotTietOwner
		{
			get { return Owner as DonGiaMotTietDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal DonGiaMotTietSelectMethod SelectMethod
		{
			get { return DonGiaMotTietOwner.SelectMethod; }
			set { DonGiaMotTietOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal DonGiaMotTietService DonGiaMotTietProvider
		{
			get { return Provider as DonGiaMotTietService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<DonGiaMotTiet> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<DonGiaMotTiet> results = null;
			DonGiaMotTiet item;
			count = 0;
			
			System.String _maHocHam;
			System.String _maHocVi;

			switch ( SelectMethod )
			{
				case DonGiaMotTietSelectMethod.Get:
					DonGiaMotTietKey entityKey  = new DonGiaMotTietKey();
					entityKey.Load(values);
					item = DonGiaMotTietProvider.Get(entityKey);
					results = new TList<DonGiaMotTiet>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case DonGiaMotTietSelectMethod.GetAll:
                    results = DonGiaMotTietProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case DonGiaMotTietSelectMethod.GetPaged:
					results = DonGiaMotTietProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case DonGiaMotTietSelectMethod.Find:
					if ( FilterParameters != null )
						results = DonGiaMotTietProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = DonGiaMotTietProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case DonGiaMotTietSelectMethod.GetByMaHocHamMaHocVi:
					_maHocHam = ( values["MaHocHam"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaHocHam"], typeof(System.String)) : string.Empty;
					_maHocVi = ( values["MaHocVi"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaHocVi"], typeof(System.String)) : string.Empty;
					item = DonGiaMotTietProvider.GetByMaHocHamMaHocVi(_maHocHam, _maHocVi);
					results = new TList<DonGiaMotTiet>();
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
			if ( SelectMethod == DonGiaMotTietSelectMethod.Get || SelectMethod == DonGiaMotTietSelectMethod.GetByMaHocHamMaHocVi )
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
				DonGiaMotTiet entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					DonGiaMotTietProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<DonGiaMotTiet> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			DonGiaMotTietProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region DonGiaMotTietDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the DonGiaMotTietDataSource class.
	/// </summary>
	public class DonGiaMotTietDataSourceDesigner : ProviderDataSourceDesigner<DonGiaMotTiet, DonGiaMotTietKey>
	{
		/// <summary>
		/// Initializes a new instance of the DonGiaMotTietDataSourceDesigner class.
		/// </summary>
		public DonGiaMotTietDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DonGiaMotTietSelectMethod SelectMethod
		{
			get { return ((DonGiaMotTietDataSource) DataSource).SelectMethod; }
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
				actions.Add(new DonGiaMotTietDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region DonGiaMotTietDataSourceActionList

	/// <summary>
	/// Supports the DonGiaMotTietDataSourceDesigner class.
	/// </summary>
	internal class DonGiaMotTietDataSourceActionList : DesignerActionList
	{
		private DonGiaMotTietDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the DonGiaMotTietDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public DonGiaMotTietDataSourceActionList(DonGiaMotTietDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DonGiaMotTietSelectMethod SelectMethod
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

	#endregion DonGiaMotTietDataSourceActionList
	
	#endregion DonGiaMotTietDataSourceDesigner
	
	#region DonGiaMotTietSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the DonGiaMotTietDataSource.SelectMethod property.
	/// </summary>
	public enum DonGiaMotTietSelectMethod
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
		/// Represents the GetByMaHocHamMaHocVi method.
		/// </summary>
		GetByMaHocHamMaHocVi
	}
	
	#endregion DonGiaMotTietSelectMethod

	#region DonGiaMotTietFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaMotTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonGiaMotTietFilter : SqlFilter<DonGiaMotTietColumn>
	{
	}
	
	#endregion DonGiaMotTietFilter

	#region DonGiaMotTietExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaMotTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonGiaMotTietExpressionBuilder : SqlExpressionBuilder<DonGiaMotTietColumn>
	{
	}
	
	#endregion DonGiaMotTietExpressionBuilder	

	#region DonGiaMotTietProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;DonGiaMotTietChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaMotTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonGiaMotTietProperty : ChildEntityProperty<DonGiaMotTietChildEntityTypes>
	{
	}
	
	#endregion DonGiaMotTietProperty
}

