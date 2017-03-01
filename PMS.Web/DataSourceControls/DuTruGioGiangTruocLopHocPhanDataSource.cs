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
	/// Represents the DataRepository.DuTruGioGiangTruocLopHocPhanProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(DuTruGioGiangTruocLopHocPhanDataSourceDesigner))]
	public class DuTruGioGiangTruocLopHocPhanDataSource : ProviderDataSource<DuTruGioGiangTruocLopHocPhan, DuTruGioGiangTruocLopHocPhanKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DuTruGioGiangTruocLopHocPhanDataSource class.
		/// </summary>
		public DuTruGioGiangTruocLopHocPhanDataSource() : base(new DuTruGioGiangTruocLopHocPhanService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the DuTruGioGiangTruocLopHocPhanDataSourceView used by the DuTruGioGiangTruocLopHocPhanDataSource.
		/// </summary>
		protected DuTruGioGiangTruocLopHocPhanDataSourceView DuTruGioGiangTruocLopHocPhanView
		{
			get { return ( View as DuTruGioGiangTruocLopHocPhanDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DuTruGioGiangTruocLopHocPhanDataSource control invokes to retrieve data.
		/// </summary>
		public DuTruGioGiangTruocLopHocPhanSelectMethod SelectMethod
		{
			get
			{
				DuTruGioGiangTruocLopHocPhanSelectMethod selectMethod = DuTruGioGiangTruocLopHocPhanSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (DuTruGioGiangTruocLopHocPhanSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the DuTruGioGiangTruocLopHocPhanDataSourceView class that is to be
		/// used by the DuTruGioGiangTruocLopHocPhanDataSource.
		/// </summary>
		/// <returns>An instance of the DuTruGioGiangTruocLopHocPhanDataSourceView class.</returns>
		protected override BaseDataSourceView<DuTruGioGiangTruocLopHocPhan, DuTruGioGiangTruocLopHocPhanKey> GetNewDataSourceView()
		{
			return new DuTruGioGiangTruocLopHocPhanDataSourceView(this, DefaultViewName);
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
	/// Supports the DuTruGioGiangTruocLopHocPhanDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class DuTruGioGiangTruocLopHocPhanDataSourceView : ProviderDataSourceView<DuTruGioGiangTruocLopHocPhan, DuTruGioGiangTruocLopHocPhanKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DuTruGioGiangTruocLopHocPhanDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the DuTruGioGiangTruocLopHocPhanDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public DuTruGioGiangTruocLopHocPhanDataSourceView(DuTruGioGiangTruocLopHocPhanDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal DuTruGioGiangTruocLopHocPhanDataSource DuTruGioGiangTruocLopHocPhanOwner
		{
			get { return Owner as DuTruGioGiangTruocLopHocPhanDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal DuTruGioGiangTruocLopHocPhanSelectMethod SelectMethod
		{
			get { return DuTruGioGiangTruocLopHocPhanOwner.SelectMethod; }
			set { DuTruGioGiangTruocLopHocPhanOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal DuTruGioGiangTruocLopHocPhanService DuTruGioGiangTruocLopHocPhanProvider
		{
			get { return Provider as DuTruGioGiangTruocLopHocPhanService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<DuTruGioGiangTruocLopHocPhan> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<DuTruGioGiangTruocLopHocPhan> results = null;
			DuTruGioGiangTruocLopHocPhan item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case DuTruGioGiangTruocLopHocPhanSelectMethod.Get:
					DuTruGioGiangTruocLopHocPhanKey entityKey  = new DuTruGioGiangTruocLopHocPhanKey();
					entityKey.Load(values);
					item = DuTruGioGiangTruocLopHocPhanProvider.Get(entityKey);
					results = new TList<DuTruGioGiangTruocLopHocPhan>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case DuTruGioGiangTruocLopHocPhanSelectMethod.GetAll:
                    results = DuTruGioGiangTruocLopHocPhanProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case DuTruGioGiangTruocLopHocPhanSelectMethod.GetPaged:
					results = DuTruGioGiangTruocLopHocPhanProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case DuTruGioGiangTruocLopHocPhanSelectMethod.Find:
					if ( FilterParameters != null )
						results = DuTruGioGiangTruocLopHocPhanProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = DuTruGioGiangTruocLopHocPhanProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case DuTruGioGiangTruocLopHocPhanSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = DuTruGioGiangTruocLopHocPhanProvider.GetById(_id);
					results = new TList<DuTruGioGiangTruocLopHocPhan>();
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
			if ( SelectMethod == DuTruGioGiangTruocLopHocPhanSelectMethod.Get || SelectMethod == DuTruGioGiangTruocLopHocPhanSelectMethod.GetById )
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
				DuTruGioGiangTruocLopHocPhan entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					DuTruGioGiangTruocLopHocPhanProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<DuTruGioGiangTruocLopHocPhan> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			DuTruGioGiangTruocLopHocPhanProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region DuTruGioGiangTruocLopHocPhanDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the DuTruGioGiangTruocLopHocPhanDataSource class.
	/// </summary>
	public class DuTruGioGiangTruocLopHocPhanDataSourceDesigner : ProviderDataSourceDesigner<DuTruGioGiangTruocLopHocPhan, DuTruGioGiangTruocLopHocPhanKey>
	{
		/// <summary>
		/// Initializes a new instance of the DuTruGioGiangTruocLopHocPhanDataSourceDesigner class.
		/// </summary>
		public DuTruGioGiangTruocLopHocPhanDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DuTruGioGiangTruocLopHocPhanSelectMethod SelectMethod
		{
			get { return ((DuTruGioGiangTruocLopHocPhanDataSource) DataSource).SelectMethod; }
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
				actions.Add(new DuTruGioGiangTruocLopHocPhanDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region DuTruGioGiangTruocLopHocPhanDataSourceActionList

	/// <summary>
	/// Supports the DuTruGioGiangTruocLopHocPhanDataSourceDesigner class.
	/// </summary>
	internal class DuTruGioGiangTruocLopHocPhanDataSourceActionList : DesignerActionList
	{
		private DuTruGioGiangTruocLopHocPhanDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the DuTruGioGiangTruocLopHocPhanDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public DuTruGioGiangTruocLopHocPhanDataSourceActionList(DuTruGioGiangTruocLopHocPhanDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DuTruGioGiangTruocLopHocPhanSelectMethod SelectMethod
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

	#endregion DuTruGioGiangTruocLopHocPhanDataSourceActionList
	
	#endregion DuTruGioGiangTruocLopHocPhanDataSourceDesigner
	
	#region DuTruGioGiangTruocLopHocPhanSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the DuTruGioGiangTruocLopHocPhanDataSource.SelectMethod property.
	/// </summary>
	public enum DuTruGioGiangTruocLopHocPhanSelectMethod
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
	
	#endregion DuTruGioGiangTruocLopHocPhanSelectMethod

	#region DuTruGioGiangTruocLopHocPhanFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DuTruGioGiangTruocLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DuTruGioGiangTruocLopHocPhanFilter : SqlFilter<DuTruGioGiangTruocLopHocPhanColumn>
	{
	}
	
	#endregion DuTruGioGiangTruocLopHocPhanFilter

	#region DuTruGioGiangTruocLopHocPhanExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DuTruGioGiangTruocLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DuTruGioGiangTruocLopHocPhanExpressionBuilder : SqlExpressionBuilder<DuTruGioGiangTruocLopHocPhanColumn>
	{
	}
	
	#endregion DuTruGioGiangTruocLopHocPhanExpressionBuilder	

	#region DuTruGioGiangTruocLopHocPhanProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;DuTruGioGiangTruocLopHocPhanChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="DuTruGioGiangTruocLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DuTruGioGiangTruocLopHocPhanProperty : ChildEntityProperty<DuTruGioGiangTruocLopHocPhanChildEntityTypes>
	{
	}
	
	#endregion DuTruGioGiangTruocLopHocPhanProperty
}

