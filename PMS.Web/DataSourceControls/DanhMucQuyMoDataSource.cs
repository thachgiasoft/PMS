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
	/// Represents the DataRepository.DanhMucQuyMoProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(DanhMucQuyMoDataSourceDesigner))]
	public class DanhMucQuyMoDataSource : ProviderDataSource<DanhMucQuyMo, DanhMucQuyMoKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DanhMucQuyMoDataSource class.
		/// </summary>
		public DanhMucQuyMoDataSource() : base(new DanhMucQuyMoService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the DanhMucQuyMoDataSourceView used by the DanhMucQuyMoDataSource.
		/// </summary>
		protected DanhMucQuyMoDataSourceView DanhMucQuyMoView
		{
			get { return ( View as DanhMucQuyMoDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DanhMucQuyMoDataSource control invokes to retrieve data.
		/// </summary>
		public DanhMucQuyMoSelectMethod SelectMethod
		{
			get
			{
				DanhMucQuyMoSelectMethod selectMethod = DanhMucQuyMoSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (DanhMucQuyMoSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the DanhMucQuyMoDataSourceView class that is to be
		/// used by the DanhMucQuyMoDataSource.
		/// </summary>
		/// <returns>An instance of the DanhMucQuyMoDataSourceView class.</returns>
		protected override BaseDataSourceView<DanhMucQuyMo, DanhMucQuyMoKey> GetNewDataSourceView()
		{
			return new DanhMucQuyMoDataSourceView(this, DefaultViewName);
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
	/// Supports the DanhMucQuyMoDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class DanhMucQuyMoDataSourceView : ProviderDataSourceView<DanhMucQuyMo, DanhMucQuyMoKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DanhMucQuyMoDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the DanhMucQuyMoDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public DanhMucQuyMoDataSourceView(DanhMucQuyMoDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal DanhMucQuyMoDataSource DanhMucQuyMoOwner
		{
			get { return Owner as DanhMucQuyMoDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal DanhMucQuyMoSelectMethod SelectMethod
		{
			get { return DanhMucQuyMoOwner.SelectMethod; }
			set { DanhMucQuyMoOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal DanhMucQuyMoService DanhMucQuyMoProvider
		{
			get { return Provider as DanhMucQuyMoService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<DanhMucQuyMo> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<DanhMucQuyMo> results = null;
			DanhMucQuyMo item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case DanhMucQuyMoSelectMethod.Get:
					DanhMucQuyMoKey entityKey  = new DanhMucQuyMoKey();
					entityKey.Load(values);
					item = DanhMucQuyMoProvider.Get(entityKey);
					results = new TList<DanhMucQuyMo>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case DanhMucQuyMoSelectMethod.GetAll:
                    results = DanhMucQuyMoProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case DanhMucQuyMoSelectMethod.GetPaged:
					results = DanhMucQuyMoProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case DanhMucQuyMoSelectMethod.Find:
					if ( FilterParameters != null )
						results = DanhMucQuyMoProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = DanhMucQuyMoProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case DanhMucQuyMoSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = DanhMucQuyMoProvider.GetById(_id);
					results = new TList<DanhMucQuyMo>();
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
			if ( SelectMethod == DanhMucQuyMoSelectMethod.Get || SelectMethod == DanhMucQuyMoSelectMethod.GetById )
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
				DanhMucQuyMo entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					DanhMucQuyMoProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<DanhMucQuyMo> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			DanhMucQuyMoProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region DanhMucQuyMoDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the DanhMucQuyMoDataSource class.
	/// </summary>
	public class DanhMucQuyMoDataSourceDesigner : ProviderDataSourceDesigner<DanhMucQuyMo, DanhMucQuyMoKey>
	{
		/// <summary>
		/// Initializes a new instance of the DanhMucQuyMoDataSourceDesigner class.
		/// </summary>
		public DanhMucQuyMoDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DanhMucQuyMoSelectMethod SelectMethod
		{
			get { return ((DanhMucQuyMoDataSource) DataSource).SelectMethod; }
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
				actions.Add(new DanhMucQuyMoDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region DanhMucQuyMoDataSourceActionList

	/// <summary>
	/// Supports the DanhMucQuyMoDataSourceDesigner class.
	/// </summary>
	internal class DanhMucQuyMoDataSourceActionList : DesignerActionList
	{
		private DanhMucQuyMoDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the DanhMucQuyMoDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public DanhMucQuyMoDataSourceActionList(DanhMucQuyMoDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DanhMucQuyMoSelectMethod SelectMethod
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

	#endregion DanhMucQuyMoDataSourceActionList
	
	#endregion DanhMucQuyMoDataSourceDesigner
	
	#region DanhMucQuyMoSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the DanhMucQuyMoDataSource.SelectMethod property.
	/// </summary>
	public enum DanhMucQuyMoSelectMethod
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
	
	#endregion DanhMucQuyMoSelectMethod

	#region DanhMucQuyMoFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DanhMucQuyMo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DanhMucQuyMoFilter : SqlFilter<DanhMucQuyMoColumn>
	{
	}
	
	#endregion DanhMucQuyMoFilter

	#region DanhMucQuyMoExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DanhMucQuyMo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DanhMucQuyMoExpressionBuilder : SqlExpressionBuilder<DanhMucQuyMoColumn>
	{
	}
	
	#endregion DanhMucQuyMoExpressionBuilder	

	#region DanhMucQuyMoProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;DanhMucQuyMoChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="DanhMucQuyMo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DanhMucQuyMoProperty : ChildEntityProperty<DanhMucQuyMoChildEntityTypes>
	{
	}
	
	#endregion DanhMucQuyMoProperty
}

