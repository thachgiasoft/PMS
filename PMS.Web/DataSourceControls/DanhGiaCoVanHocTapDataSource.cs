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
	/// Represents the DataRepository.DanhGiaCoVanHocTapProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(DanhGiaCoVanHocTapDataSourceDesigner))]
	public class DanhGiaCoVanHocTapDataSource : ProviderDataSource<DanhGiaCoVanHocTap, DanhGiaCoVanHocTapKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DanhGiaCoVanHocTapDataSource class.
		/// </summary>
		public DanhGiaCoVanHocTapDataSource() : base(new DanhGiaCoVanHocTapService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the DanhGiaCoVanHocTapDataSourceView used by the DanhGiaCoVanHocTapDataSource.
		/// </summary>
		protected DanhGiaCoVanHocTapDataSourceView DanhGiaCoVanHocTapView
		{
			get { return ( View as DanhGiaCoVanHocTapDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DanhGiaCoVanHocTapDataSource control invokes to retrieve data.
		/// </summary>
		public DanhGiaCoVanHocTapSelectMethod SelectMethod
		{
			get
			{
				DanhGiaCoVanHocTapSelectMethod selectMethod = DanhGiaCoVanHocTapSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (DanhGiaCoVanHocTapSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the DanhGiaCoVanHocTapDataSourceView class that is to be
		/// used by the DanhGiaCoVanHocTapDataSource.
		/// </summary>
		/// <returns>An instance of the DanhGiaCoVanHocTapDataSourceView class.</returns>
		protected override BaseDataSourceView<DanhGiaCoVanHocTap, DanhGiaCoVanHocTapKey> GetNewDataSourceView()
		{
			return new DanhGiaCoVanHocTapDataSourceView(this, DefaultViewName);
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
	/// Supports the DanhGiaCoVanHocTapDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class DanhGiaCoVanHocTapDataSourceView : ProviderDataSourceView<DanhGiaCoVanHocTap, DanhGiaCoVanHocTapKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DanhGiaCoVanHocTapDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the DanhGiaCoVanHocTapDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public DanhGiaCoVanHocTapDataSourceView(DanhGiaCoVanHocTapDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal DanhGiaCoVanHocTapDataSource DanhGiaCoVanHocTapOwner
		{
			get { return Owner as DanhGiaCoVanHocTapDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal DanhGiaCoVanHocTapSelectMethod SelectMethod
		{
			get { return DanhGiaCoVanHocTapOwner.SelectMethod; }
			set { DanhGiaCoVanHocTapOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal DanhGiaCoVanHocTapService DanhGiaCoVanHocTapProvider
		{
			get { return Provider as DanhGiaCoVanHocTapService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<DanhGiaCoVanHocTap> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<DanhGiaCoVanHocTap> results = null;
			DanhGiaCoVanHocTap item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case DanhGiaCoVanHocTapSelectMethod.Get:
					DanhGiaCoVanHocTapKey entityKey  = new DanhGiaCoVanHocTapKey();
					entityKey.Load(values);
					item = DanhGiaCoVanHocTapProvider.Get(entityKey);
					results = new TList<DanhGiaCoVanHocTap>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case DanhGiaCoVanHocTapSelectMethod.GetAll:
                    results = DanhGiaCoVanHocTapProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case DanhGiaCoVanHocTapSelectMethod.GetPaged:
					results = DanhGiaCoVanHocTapProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case DanhGiaCoVanHocTapSelectMethod.Find:
					if ( FilterParameters != null )
						results = DanhGiaCoVanHocTapProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = DanhGiaCoVanHocTapProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case DanhGiaCoVanHocTapSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = DanhGiaCoVanHocTapProvider.GetById(_id);
					results = new TList<DanhGiaCoVanHocTap>();
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
			if ( SelectMethod == DanhGiaCoVanHocTapSelectMethod.Get || SelectMethod == DanhGiaCoVanHocTapSelectMethod.GetById )
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
				DanhGiaCoVanHocTap entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					DanhGiaCoVanHocTapProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<DanhGiaCoVanHocTap> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			DanhGiaCoVanHocTapProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region DanhGiaCoVanHocTapDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the DanhGiaCoVanHocTapDataSource class.
	/// </summary>
	public class DanhGiaCoVanHocTapDataSourceDesigner : ProviderDataSourceDesigner<DanhGiaCoVanHocTap, DanhGiaCoVanHocTapKey>
	{
		/// <summary>
		/// Initializes a new instance of the DanhGiaCoVanHocTapDataSourceDesigner class.
		/// </summary>
		public DanhGiaCoVanHocTapDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DanhGiaCoVanHocTapSelectMethod SelectMethod
		{
			get { return ((DanhGiaCoVanHocTapDataSource) DataSource).SelectMethod; }
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
				actions.Add(new DanhGiaCoVanHocTapDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region DanhGiaCoVanHocTapDataSourceActionList

	/// <summary>
	/// Supports the DanhGiaCoVanHocTapDataSourceDesigner class.
	/// </summary>
	internal class DanhGiaCoVanHocTapDataSourceActionList : DesignerActionList
	{
		private DanhGiaCoVanHocTapDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the DanhGiaCoVanHocTapDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public DanhGiaCoVanHocTapDataSourceActionList(DanhGiaCoVanHocTapDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DanhGiaCoVanHocTapSelectMethod SelectMethod
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

	#endregion DanhGiaCoVanHocTapDataSourceActionList
	
	#endregion DanhGiaCoVanHocTapDataSourceDesigner
	
	#region DanhGiaCoVanHocTapSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the DanhGiaCoVanHocTapDataSource.SelectMethod property.
	/// </summary>
	public enum DanhGiaCoVanHocTapSelectMethod
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
	
	#endregion DanhGiaCoVanHocTapSelectMethod

	#region DanhGiaCoVanHocTapFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DanhGiaCoVanHocTap"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DanhGiaCoVanHocTapFilter : SqlFilter<DanhGiaCoVanHocTapColumn>
	{
	}
	
	#endregion DanhGiaCoVanHocTapFilter

	#region DanhGiaCoVanHocTapExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DanhGiaCoVanHocTap"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DanhGiaCoVanHocTapExpressionBuilder : SqlExpressionBuilder<DanhGiaCoVanHocTapColumn>
	{
	}
	
	#endregion DanhGiaCoVanHocTapExpressionBuilder	

	#region DanhGiaCoVanHocTapProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;DanhGiaCoVanHocTapChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="DanhGiaCoVanHocTap"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DanhGiaCoVanHocTapProperty : ChildEntityProperty<DanhGiaCoVanHocTapChildEntityTypes>
	{
	}
	
	#endregion DanhGiaCoVanHocTapProperty
}

