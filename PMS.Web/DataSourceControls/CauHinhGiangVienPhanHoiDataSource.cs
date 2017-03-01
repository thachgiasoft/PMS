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
	/// Represents the DataRepository.CauHinhGiangVienPhanHoiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(CauHinhGiangVienPhanHoiDataSourceDesigner))]
	public class CauHinhGiangVienPhanHoiDataSource : ProviderDataSource<CauHinhGiangVienPhanHoi, CauHinhGiangVienPhanHoiKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CauHinhGiangVienPhanHoiDataSource class.
		/// </summary>
		public CauHinhGiangVienPhanHoiDataSource() : base(new CauHinhGiangVienPhanHoiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the CauHinhGiangVienPhanHoiDataSourceView used by the CauHinhGiangVienPhanHoiDataSource.
		/// </summary>
		protected CauHinhGiangVienPhanHoiDataSourceView CauHinhGiangVienPhanHoiView
		{
			get { return ( View as CauHinhGiangVienPhanHoiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the CauHinhGiangVienPhanHoiDataSource control invokes to retrieve data.
		/// </summary>
		public CauHinhGiangVienPhanHoiSelectMethod SelectMethod
		{
			get
			{
				CauHinhGiangVienPhanHoiSelectMethod selectMethod = CauHinhGiangVienPhanHoiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (CauHinhGiangVienPhanHoiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the CauHinhGiangVienPhanHoiDataSourceView class that is to be
		/// used by the CauHinhGiangVienPhanHoiDataSource.
		/// </summary>
		/// <returns>An instance of the CauHinhGiangVienPhanHoiDataSourceView class.</returns>
		protected override BaseDataSourceView<CauHinhGiangVienPhanHoi, CauHinhGiangVienPhanHoiKey> GetNewDataSourceView()
		{
			return new CauHinhGiangVienPhanHoiDataSourceView(this, DefaultViewName);
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
	/// Supports the CauHinhGiangVienPhanHoiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class CauHinhGiangVienPhanHoiDataSourceView : ProviderDataSourceView<CauHinhGiangVienPhanHoi, CauHinhGiangVienPhanHoiKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CauHinhGiangVienPhanHoiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the CauHinhGiangVienPhanHoiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public CauHinhGiangVienPhanHoiDataSourceView(CauHinhGiangVienPhanHoiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal CauHinhGiangVienPhanHoiDataSource CauHinhGiangVienPhanHoiOwner
		{
			get { return Owner as CauHinhGiangVienPhanHoiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal CauHinhGiangVienPhanHoiSelectMethod SelectMethod
		{
			get { return CauHinhGiangVienPhanHoiOwner.SelectMethod; }
			set { CauHinhGiangVienPhanHoiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal CauHinhGiangVienPhanHoiService CauHinhGiangVienPhanHoiProvider
		{
			get { return Provider as CauHinhGiangVienPhanHoiService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<CauHinhGiangVienPhanHoi> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<CauHinhGiangVienPhanHoi> results = null;
			CauHinhGiangVienPhanHoi item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case CauHinhGiangVienPhanHoiSelectMethod.Get:
					CauHinhGiangVienPhanHoiKey entityKey  = new CauHinhGiangVienPhanHoiKey();
					entityKey.Load(values);
					item = CauHinhGiangVienPhanHoiProvider.Get(entityKey);
					results = new TList<CauHinhGiangVienPhanHoi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case CauHinhGiangVienPhanHoiSelectMethod.GetAll:
                    results = CauHinhGiangVienPhanHoiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case CauHinhGiangVienPhanHoiSelectMethod.GetPaged:
					results = CauHinhGiangVienPhanHoiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case CauHinhGiangVienPhanHoiSelectMethod.Find:
					if ( FilterParameters != null )
						results = CauHinhGiangVienPhanHoiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = CauHinhGiangVienPhanHoiProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case CauHinhGiangVienPhanHoiSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = CauHinhGiangVienPhanHoiProvider.GetById(_id);
					results = new TList<CauHinhGiangVienPhanHoi>();
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
			if ( SelectMethod == CauHinhGiangVienPhanHoiSelectMethod.Get || SelectMethod == CauHinhGiangVienPhanHoiSelectMethod.GetById )
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
				CauHinhGiangVienPhanHoi entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					CauHinhGiangVienPhanHoiProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<CauHinhGiangVienPhanHoi> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			CauHinhGiangVienPhanHoiProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region CauHinhGiangVienPhanHoiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the CauHinhGiangVienPhanHoiDataSource class.
	/// </summary>
	public class CauHinhGiangVienPhanHoiDataSourceDesigner : ProviderDataSourceDesigner<CauHinhGiangVienPhanHoi, CauHinhGiangVienPhanHoiKey>
	{
		/// <summary>
		/// Initializes a new instance of the CauHinhGiangVienPhanHoiDataSourceDesigner class.
		/// </summary>
		public CauHinhGiangVienPhanHoiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public CauHinhGiangVienPhanHoiSelectMethod SelectMethod
		{
			get { return ((CauHinhGiangVienPhanHoiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new CauHinhGiangVienPhanHoiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region CauHinhGiangVienPhanHoiDataSourceActionList

	/// <summary>
	/// Supports the CauHinhGiangVienPhanHoiDataSourceDesigner class.
	/// </summary>
	internal class CauHinhGiangVienPhanHoiDataSourceActionList : DesignerActionList
	{
		private CauHinhGiangVienPhanHoiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the CauHinhGiangVienPhanHoiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public CauHinhGiangVienPhanHoiDataSourceActionList(CauHinhGiangVienPhanHoiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public CauHinhGiangVienPhanHoiSelectMethod SelectMethod
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

	#endregion CauHinhGiangVienPhanHoiDataSourceActionList
	
	#endregion CauHinhGiangVienPhanHoiDataSourceDesigner
	
	#region CauHinhGiangVienPhanHoiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the CauHinhGiangVienPhanHoiDataSource.SelectMethod property.
	/// </summary>
	public enum CauHinhGiangVienPhanHoiSelectMethod
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
	
	#endregion CauHinhGiangVienPhanHoiSelectMethod

	#region CauHinhGiangVienPhanHoiFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CauHinhGiangVienPhanHoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CauHinhGiangVienPhanHoiFilter : SqlFilter<CauHinhGiangVienPhanHoiColumn>
	{
	}
	
	#endregion CauHinhGiangVienPhanHoiFilter

	#region CauHinhGiangVienPhanHoiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CauHinhGiangVienPhanHoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CauHinhGiangVienPhanHoiExpressionBuilder : SqlExpressionBuilder<CauHinhGiangVienPhanHoiColumn>
	{
	}
	
	#endregion CauHinhGiangVienPhanHoiExpressionBuilder	

	#region CauHinhGiangVienPhanHoiProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;CauHinhGiangVienPhanHoiChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="CauHinhGiangVienPhanHoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CauHinhGiangVienPhanHoiProperty : ChildEntityProperty<CauHinhGiangVienPhanHoiChildEntityTypes>
	{
	}
	
	#endregion CauHinhGiangVienPhanHoiProperty
}

