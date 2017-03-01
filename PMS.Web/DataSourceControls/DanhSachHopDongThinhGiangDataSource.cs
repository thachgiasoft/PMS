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
	/// Represents the DataRepository.DanhSachHopDongThinhGiangProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(DanhSachHopDongThinhGiangDataSourceDesigner))]
	public class DanhSachHopDongThinhGiangDataSource : ProviderDataSource<DanhSachHopDongThinhGiang, DanhSachHopDongThinhGiangKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DanhSachHopDongThinhGiangDataSource class.
		/// </summary>
		public DanhSachHopDongThinhGiangDataSource() : base(new DanhSachHopDongThinhGiangService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the DanhSachHopDongThinhGiangDataSourceView used by the DanhSachHopDongThinhGiangDataSource.
		/// </summary>
		protected DanhSachHopDongThinhGiangDataSourceView DanhSachHopDongThinhGiangView
		{
			get { return ( View as DanhSachHopDongThinhGiangDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DanhSachHopDongThinhGiangDataSource control invokes to retrieve data.
		/// </summary>
		public DanhSachHopDongThinhGiangSelectMethod SelectMethod
		{
			get
			{
				DanhSachHopDongThinhGiangSelectMethod selectMethod = DanhSachHopDongThinhGiangSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (DanhSachHopDongThinhGiangSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the DanhSachHopDongThinhGiangDataSourceView class that is to be
		/// used by the DanhSachHopDongThinhGiangDataSource.
		/// </summary>
		/// <returns>An instance of the DanhSachHopDongThinhGiangDataSourceView class.</returns>
		protected override BaseDataSourceView<DanhSachHopDongThinhGiang, DanhSachHopDongThinhGiangKey> GetNewDataSourceView()
		{
			return new DanhSachHopDongThinhGiangDataSourceView(this, DefaultViewName);
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
	/// Supports the DanhSachHopDongThinhGiangDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class DanhSachHopDongThinhGiangDataSourceView : ProviderDataSourceView<DanhSachHopDongThinhGiang, DanhSachHopDongThinhGiangKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DanhSachHopDongThinhGiangDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the DanhSachHopDongThinhGiangDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public DanhSachHopDongThinhGiangDataSourceView(DanhSachHopDongThinhGiangDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal DanhSachHopDongThinhGiangDataSource DanhSachHopDongThinhGiangOwner
		{
			get { return Owner as DanhSachHopDongThinhGiangDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal DanhSachHopDongThinhGiangSelectMethod SelectMethod
		{
			get { return DanhSachHopDongThinhGiangOwner.SelectMethod; }
			set { DanhSachHopDongThinhGiangOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal DanhSachHopDongThinhGiangService DanhSachHopDongThinhGiangProvider
		{
			get { return Provider as DanhSachHopDongThinhGiangService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<DanhSachHopDongThinhGiang> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<DanhSachHopDongThinhGiang> results = null;
			DanhSachHopDongThinhGiang item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case DanhSachHopDongThinhGiangSelectMethod.Get:
					DanhSachHopDongThinhGiangKey entityKey  = new DanhSachHopDongThinhGiangKey();
					entityKey.Load(values);
					item = DanhSachHopDongThinhGiangProvider.Get(entityKey);
					results = new TList<DanhSachHopDongThinhGiang>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case DanhSachHopDongThinhGiangSelectMethod.GetAll:
                    results = DanhSachHopDongThinhGiangProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case DanhSachHopDongThinhGiangSelectMethod.GetPaged:
					results = DanhSachHopDongThinhGiangProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case DanhSachHopDongThinhGiangSelectMethod.Find:
					if ( FilterParameters != null )
						results = DanhSachHopDongThinhGiangProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = DanhSachHopDongThinhGiangProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case DanhSachHopDongThinhGiangSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = DanhSachHopDongThinhGiangProvider.GetById(_id);
					results = new TList<DanhSachHopDongThinhGiang>();
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
			if ( SelectMethod == DanhSachHopDongThinhGiangSelectMethod.Get || SelectMethod == DanhSachHopDongThinhGiangSelectMethod.GetById )
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
				DanhSachHopDongThinhGiang entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					DanhSachHopDongThinhGiangProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<DanhSachHopDongThinhGiang> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			DanhSachHopDongThinhGiangProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region DanhSachHopDongThinhGiangDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the DanhSachHopDongThinhGiangDataSource class.
	/// </summary>
	public class DanhSachHopDongThinhGiangDataSourceDesigner : ProviderDataSourceDesigner<DanhSachHopDongThinhGiang, DanhSachHopDongThinhGiangKey>
	{
		/// <summary>
		/// Initializes a new instance of the DanhSachHopDongThinhGiangDataSourceDesigner class.
		/// </summary>
		public DanhSachHopDongThinhGiangDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DanhSachHopDongThinhGiangSelectMethod SelectMethod
		{
			get { return ((DanhSachHopDongThinhGiangDataSource) DataSource).SelectMethod; }
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
				actions.Add(new DanhSachHopDongThinhGiangDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region DanhSachHopDongThinhGiangDataSourceActionList

	/// <summary>
	/// Supports the DanhSachHopDongThinhGiangDataSourceDesigner class.
	/// </summary>
	internal class DanhSachHopDongThinhGiangDataSourceActionList : DesignerActionList
	{
		private DanhSachHopDongThinhGiangDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the DanhSachHopDongThinhGiangDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public DanhSachHopDongThinhGiangDataSourceActionList(DanhSachHopDongThinhGiangDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DanhSachHopDongThinhGiangSelectMethod SelectMethod
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

	#endregion DanhSachHopDongThinhGiangDataSourceActionList
	
	#endregion DanhSachHopDongThinhGiangDataSourceDesigner
	
	#region DanhSachHopDongThinhGiangSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the DanhSachHopDongThinhGiangDataSource.SelectMethod property.
	/// </summary>
	public enum DanhSachHopDongThinhGiangSelectMethod
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
		/// Represents the GetById method.
		/// </summary>
		GetById
	}
	
	#endregion DanhSachHopDongThinhGiangSelectMethod

	#region DanhSachHopDongThinhGiangFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DanhSachHopDongThinhGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DanhSachHopDongThinhGiangFilter : SqlFilter<DanhSachHopDongThinhGiangColumn>
	{
	}
	
	#endregion DanhSachHopDongThinhGiangFilter

	#region DanhSachHopDongThinhGiangExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DanhSachHopDongThinhGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DanhSachHopDongThinhGiangExpressionBuilder : SqlExpressionBuilder<DanhSachHopDongThinhGiangColumn>
	{
	}
	
	#endregion DanhSachHopDongThinhGiangExpressionBuilder	

	#region DanhSachHopDongThinhGiangProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;DanhSachHopDongThinhGiangChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="DanhSachHopDongThinhGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DanhSachHopDongThinhGiangProperty : ChildEntityProperty<DanhSachHopDongThinhGiangChildEntityTypes>
	{
	}
	
	#endregion DanhSachHopDongThinhGiangProperty
}

