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
	/// Represents the DataRepository.DuTruGioGiangKhiCoLopHocPhanProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(DuTruGioGiangKhiCoLopHocPhanDataSourceDesigner))]
	public class DuTruGioGiangKhiCoLopHocPhanDataSource : ProviderDataSource<DuTruGioGiangKhiCoLopHocPhan, DuTruGioGiangKhiCoLopHocPhanKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DuTruGioGiangKhiCoLopHocPhanDataSource class.
		/// </summary>
		public DuTruGioGiangKhiCoLopHocPhanDataSource() : base(new DuTruGioGiangKhiCoLopHocPhanService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the DuTruGioGiangKhiCoLopHocPhanDataSourceView used by the DuTruGioGiangKhiCoLopHocPhanDataSource.
		/// </summary>
		protected DuTruGioGiangKhiCoLopHocPhanDataSourceView DuTruGioGiangKhiCoLopHocPhanView
		{
			get { return ( View as DuTruGioGiangKhiCoLopHocPhanDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DuTruGioGiangKhiCoLopHocPhanDataSource control invokes to retrieve data.
		/// </summary>
		public DuTruGioGiangKhiCoLopHocPhanSelectMethod SelectMethod
		{
			get
			{
				DuTruGioGiangKhiCoLopHocPhanSelectMethod selectMethod = DuTruGioGiangKhiCoLopHocPhanSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (DuTruGioGiangKhiCoLopHocPhanSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the DuTruGioGiangKhiCoLopHocPhanDataSourceView class that is to be
		/// used by the DuTruGioGiangKhiCoLopHocPhanDataSource.
		/// </summary>
		/// <returns>An instance of the DuTruGioGiangKhiCoLopHocPhanDataSourceView class.</returns>
		protected override BaseDataSourceView<DuTruGioGiangKhiCoLopHocPhan, DuTruGioGiangKhiCoLopHocPhanKey> GetNewDataSourceView()
		{
			return new DuTruGioGiangKhiCoLopHocPhanDataSourceView(this, DefaultViewName);
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
	/// Supports the DuTruGioGiangKhiCoLopHocPhanDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class DuTruGioGiangKhiCoLopHocPhanDataSourceView : ProviderDataSourceView<DuTruGioGiangKhiCoLopHocPhan, DuTruGioGiangKhiCoLopHocPhanKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DuTruGioGiangKhiCoLopHocPhanDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the DuTruGioGiangKhiCoLopHocPhanDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public DuTruGioGiangKhiCoLopHocPhanDataSourceView(DuTruGioGiangKhiCoLopHocPhanDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal DuTruGioGiangKhiCoLopHocPhanDataSource DuTruGioGiangKhiCoLopHocPhanOwner
		{
			get { return Owner as DuTruGioGiangKhiCoLopHocPhanDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal DuTruGioGiangKhiCoLopHocPhanSelectMethod SelectMethod
		{
			get { return DuTruGioGiangKhiCoLopHocPhanOwner.SelectMethod; }
			set { DuTruGioGiangKhiCoLopHocPhanOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal DuTruGioGiangKhiCoLopHocPhanService DuTruGioGiangKhiCoLopHocPhanProvider
		{
			get { return Provider as DuTruGioGiangKhiCoLopHocPhanService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<DuTruGioGiangKhiCoLopHocPhan> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<DuTruGioGiangKhiCoLopHocPhan> results = null;
			DuTruGioGiangKhiCoLopHocPhan item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case DuTruGioGiangKhiCoLopHocPhanSelectMethod.Get:
					DuTruGioGiangKhiCoLopHocPhanKey entityKey  = new DuTruGioGiangKhiCoLopHocPhanKey();
					entityKey.Load(values);
					item = DuTruGioGiangKhiCoLopHocPhanProvider.Get(entityKey);
					results = new TList<DuTruGioGiangKhiCoLopHocPhan>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case DuTruGioGiangKhiCoLopHocPhanSelectMethod.GetAll:
                    results = DuTruGioGiangKhiCoLopHocPhanProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case DuTruGioGiangKhiCoLopHocPhanSelectMethod.GetPaged:
					results = DuTruGioGiangKhiCoLopHocPhanProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case DuTruGioGiangKhiCoLopHocPhanSelectMethod.Find:
					if ( FilterParameters != null )
						results = DuTruGioGiangKhiCoLopHocPhanProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = DuTruGioGiangKhiCoLopHocPhanProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case DuTruGioGiangKhiCoLopHocPhanSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = DuTruGioGiangKhiCoLopHocPhanProvider.GetById(_id);
					results = new TList<DuTruGioGiangKhiCoLopHocPhan>();
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
			if ( SelectMethod == DuTruGioGiangKhiCoLopHocPhanSelectMethod.Get || SelectMethod == DuTruGioGiangKhiCoLopHocPhanSelectMethod.GetById )
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
				DuTruGioGiangKhiCoLopHocPhan entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					DuTruGioGiangKhiCoLopHocPhanProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<DuTruGioGiangKhiCoLopHocPhan> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			DuTruGioGiangKhiCoLopHocPhanProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region DuTruGioGiangKhiCoLopHocPhanDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the DuTruGioGiangKhiCoLopHocPhanDataSource class.
	/// </summary>
	public class DuTruGioGiangKhiCoLopHocPhanDataSourceDesigner : ProviderDataSourceDesigner<DuTruGioGiangKhiCoLopHocPhan, DuTruGioGiangKhiCoLopHocPhanKey>
	{
		/// <summary>
		/// Initializes a new instance of the DuTruGioGiangKhiCoLopHocPhanDataSourceDesigner class.
		/// </summary>
		public DuTruGioGiangKhiCoLopHocPhanDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DuTruGioGiangKhiCoLopHocPhanSelectMethod SelectMethod
		{
			get { return ((DuTruGioGiangKhiCoLopHocPhanDataSource) DataSource).SelectMethod; }
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
				actions.Add(new DuTruGioGiangKhiCoLopHocPhanDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region DuTruGioGiangKhiCoLopHocPhanDataSourceActionList

	/// <summary>
	/// Supports the DuTruGioGiangKhiCoLopHocPhanDataSourceDesigner class.
	/// </summary>
	internal class DuTruGioGiangKhiCoLopHocPhanDataSourceActionList : DesignerActionList
	{
		private DuTruGioGiangKhiCoLopHocPhanDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the DuTruGioGiangKhiCoLopHocPhanDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public DuTruGioGiangKhiCoLopHocPhanDataSourceActionList(DuTruGioGiangKhiCoLopHocPhanDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DuTruGioGiangKhiCoLopHocPhanSelectMethod SelectMethod
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

	#endregion DuTruGioGiangKhiCoLopHocPhanDataSourceActionList
	
	#endregion DuTruGioGiangKhiCoLopHocPhanDataSourceDesigner
	
	#region DuTruGioGiangKhiCoLopHocPhanSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the DuTruGioGiangKhiCoLopHocPhanDataSource.SelectMethod property.
	/// </summary>
	public enum DuTruGioGiangKhiCoLopHocPhanSelectMethod
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
	
	#endregion DuTruGioGiangKhiCoLopHocPhanSelectMethod

	#region DuTruGioGiangKhiCoLopHocPhanFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DuTruGioGiangKhiCoLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DuTruGioGiangKhiCoLopHocPhanFilter : SqlFilter<DuTruGioGiangKhiCoLopHocPhanColumn>
	{
	}
	
	#endregion DuTruGioGiangKhiCoLopHocPhanFilter

	#region DuTruGioGiangKhiCoLopHocPhanExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DuTruGioGiangKhiCoLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DuTruGioGiangKhiCoLopHocPhanExpressionBuilder : SqlExpressionBuilder<DuTruGioGiangKhiCoLopHocPhanColumn>
	{
	}
	
	#endregion DuTruGioGiangKhiCoLopHocPhanExpressionBuilder	

	#region DuTruGioGiangKhiCoLopHocPhanProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;DuTruGioGiangKhiCoLopHocPhanChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="DuTruGioGiangKhiCoLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DuTruGioGiangKhiCoLopHocPhanProperty : ChildEntityProperty<DuTruGioGiangKhiCoLopHocPhanChildEntityTypes>
	{
	}
	
	#endregion DuTruGioGiangKhiCoLopHocPhanProperty
}

