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
	/// Represents the DataRepository.LopHocPhanKhongTinhGioGiangProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(LopHocPhanKhongTinhGioGiangDataSourceDesigner))]
	public class LopHocPhanKhongTinhGioGiangDataSource : ProviderDataSource<LopHocPhanKhongTinhGioGiang, LopHocPhanKhongTinhGioGiangKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LopHocPhanKhongTinhGioGiangDataSource class.
		/// </summary>
		public LopHocPhanKhongTinhGioGiangDataSource() : base(new LopHocPhanKhongTinhGioGiangService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the LopHocPhanKhongTinhGioGiangDataSourceView used by the LopHocPhanKhongTinhGioGiangDataSource.
		/// </summary>
		protected LopHocPhanKhongTinhGioGiangDataSourceView LopHocPhanKhongTinhGioGiangView
		{
			get { return ( View as LopHocPhanKhongTinhGioGiangDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the LopHocPhanKhongTinhGioGiangDataSource control invokes to retrieve data.
		/// </summary>
		public LopHocPhanKhongTinhGioGiangSelectMethod SelectMethod
		{
			get
			{
				LopHocPhanKhongTinhGioGiangSelectMethod selectMethod = LopHocPhanKhongTinhGioGiangSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (LopHocPhanKhongTinhGioGiangSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the LopHocPhanKhongTinhGioGiangDataSourceView class that is to be
		/// used by the LopHocPhanKhongTinhGioGiangDataSource.
		/// </summary>
		/// <returns>An instance of the LopHocPhanKhongTinhGioGiangDataSourceView class.</returns>
		protected override BaseDataSourceView<LopHocPhanKhongTinhGioGiang, LopHocPhanKhongTinhGioGiangKey> GetNewDataSourceView()
		{
			return new LopHocPhanKhongTinhGioGiangDataSourceView(this, DefaultViewName);
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
	/// Supports the LopHocPhanKhongTinhGioGiangDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class LopHocPhanKhongTinhGioGiangDataSourceView : ProviderDataSourceView<LopHocPhanKhongTinhGioGiang, LopHocPhanKhongTinhGioGiangKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LopHocPhanKhongTinhGioGiangDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the LopHocPhanKhongTinhGioGiangDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public LopHocPhanKhongTinhGioGiangDataSourceView(LopHocPhanKhongTinhGioGiangDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal LopHocPhanKhongTinhGioGiangDataSource LopHocPhanKhongTinhGioGiangOwner
		{
			get { return Owner as LopHocPhanKhongTinhGioGiangDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal LopHocPhanKhongTinhGioGiangSelectMethod SelectMethod
		{
			get { return LopHocPhanKhongTinhGioGiangOwner.SelectMethod; }
			set { LopHocPhanKhongTinhGioGiangOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal LopHocPhanKhongTinhGioGiangService LopHocPhanKhongTinhGioGiangProvider
		{
			get { return Provider as LopHocPhanKhongTinhGioGiangService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<LopHocPhanKhongTinhGioGiang> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<LopHocPhanKhongTinhGioGiang> results = null;
			LopHocPhanKhongTinhGioGiang item;
			count = 0;
			
			System.String _maLopHocPhan;

			switch ( SelectMethod )
			{
				case LopHocPhanKhongTinhGioGiangSelectMethod.Get:
					LopHocPhanKhongTinhGioGiangKey entityKey  = new LopHocPhanKhongTinhGioGiangKey();
					entityKey.Load(values);
					item = LopHocPhanKhongTinhGioGiangProvider.Get(entityKey);
					results = new TList<LopHocPhanKhongTinhGioGiang>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case LopHocPhanKhongTinhGioGiangSelectMethod.GetAll:
                    results = LopHocPhanKhongTinhGioGiangProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case LopHocPhanKhongTinhGioGiangSelectMethod.GetPaged:
					results = LopHocPhanKhongTinhGioGiangProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case LopHocPhanKhongTinhGioGiangSelectMethod.Find:
					if ( FilterParameters != null )
						results = LopHocPhanKhongTinhGioGiangProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = LopHocPhanKhongTinhGioGiangProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case LopHocPhanKhongTinhGioGiangSelectMethod.GetByMaLopHocPhan:
					_maLopHocPhan = ( values["MaLopHocPhan"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaLopHocPhan"], typeof(System.String)) : string.Empty;
					item = LopHocPhanKhongTinhGioGiangProvider.GetByMaLopHocPhan(_maLopHocPhan);
					results = new TList<LopHocPhanKhongTinhGioGiang>();
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
			if ( SelectMethod == LopHocPhanKhongTinhGioGiangSelectMethod.Get || SelectMethod == LopHocPhanKhongTinhGioGiangSelectMethod.GetByMaLopHocPhan )
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
				LopHocPhanKhongTinhGioGiang entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					LopHocPhanKhongTinhGioGiangProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<LopHocPhanKhongTinhGioGiang> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			LopHocPhanKhongTinhGioGiangProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region LopHocPhanKhongTinhGioGiangDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the LopHocPhanKhongTinhGioGiangDataSource class.
	/// </summary>
	public class LopHocPhanKhongTinhGioGiangDataSourceDesigner : ProviderDataSourceDesigner<LopHocPhanKhongTinhGioGiang, LopHocPhanKhongTinhGioGiangKey>
	{
		/// <summary>
		/// Initializes a new instance of the LopHocPhanKhongTinhGioGiangDataSourceDesigner class.
		/// </summary>
		public LopHocPhanKhongTinhGioGiangDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public LopHocPhanKhongTinhGioGiangSelectMethod SelectMethod
		{
			get { return ((LopHocPhanKhongTinhGioGiangDataSource) DataSource).SelectMethod; }
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
				actions.Add(new LopHocPhanKhongTinhGioGiangDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region LopHocPhanKhongTinhGioGiangDataSourceActionList

	/// <summary>
	/// Supports the LopHocPhanKhongTinhGioGiangDataSourceDesigner class.
	/// </summary>
	internal class LopHocPhanKhongTinhGioGiangDataSourceActionList : DesignerActionList
	{
		private LopHocPhanKhongTinhGioGiangDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the LopHocPhanKhongTinhGioGiangDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public LopHocPhanKhongTinhGioGiangDataSourceActionList(LopHocPhanKhongTinhGioGiangDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public LopHocPhanKhongTinhGioGiangSelectMethod SelectMethod
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

	#endregion LopHocPhanKhongTinhGioGiangDataSourceActionList
	
	#endregion LopHocPhanKhongTinhGioGiangDataSourceDesigner
	
	#region LopHocPhanKhongTinhGioGiangSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the LopHocPhanKhongTinhGioGiangDataSource.SelectMethod property.
	/// </summary>
	public enum LopHocPhanKhongTinhGioGiangSelectMethod
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
		/// Represents the GetByMaLopHocPhan method.
		/// </summary>
		GetByMaLopHocPhan
	}
	
	#endregion LopHocPhanKhongTinhGioGiangSelectMethod

	#region LopHocPhanKhongTinhGioGiangFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanKhongTinhGioGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LopHocPhanKhongTinhGioGiangFilter : SqlFilter<LopHocPhanKhongTinhGioGiangColumn>
	{
	}
	
	#endregion LopHocPhanKhongTinhGioGiangFilter

	#region LopHocPhanKhongTinhGioGiangExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanKhongTinhGioGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LopHocPhanKhongTinhGioGiangExpressionBuilder : SqlExpressionBuilder<LopHocPhanKhongTinhGioGiangColumn>
	{
	}
	
	#endregion LopHocPhanKhongTinhGioGiangExpressionBuilder	

	#region LopHocPhanKhongTinhGioGiangProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;LopHocPhanKhongTinhGioGiangChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanKhongTinhGioGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LopHocPhanKhongTinhGioGiangProperty : ChildEntityProperty<LopHocPhanKhongTinhGioGiangChildEntityTypes>
	{
	}
	
	#endregion LopHocPhanKhongTinhGioGiangProperty
}

