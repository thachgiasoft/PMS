#region Using Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;
using PMS.Services;
#endregion

namespace PMS.Web.Data
{
	/// <summary>
	/// Represents the DataRepository.ViewThamDinhLuanVanThacSyProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewThamDinhLuanVanThacSyDataSourceDesigner))]
	public class ViewThamDinhLuanVanThacSyDataSource : ReadOnlyDataSource<ViewThamDinhLuanVanThacSy>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThamDinhLuanVanThacSyDataSource class.
		/// </summary>
		public ViewThamDinhLuanVanThacSyDataSource() : base(new ViewThamDinhLuanVanThacSyService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewThamDinhLuanVanThacSyDataSourceView used by the ViewThamDinhLuanVanThacSyDataSource.
		/// </summary>
		protected ViewThamDinhLuanVanThacSyDataSourceView ViewThamDinhLuanVanThacSyView
		{
			get { return ( View as ViewThamDinhLuanVanThacSyDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewThamDinhLuanVanThacSyDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewThamDinhLuanVanThacSySelectMethod SelectMethod
		{
			get
			{
				ViewThamDinhLuanVanThacSySelectMethod selectMethod = ViewThamDinhLuanVanThacSySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewThamDinhLuanVanThacSySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewThamDinhLuanVanThacSyDataSourceView class that is to be
		/// used by the ViewThamDinhLuanVanThacSyDataSource.
		/// </summary>
		/// <returns>An instance of the ViewThamDinhLuanVanThacSyDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewThamDinhLuanVanThacSy, Object> GetNewDataSourceView()
		{
			return new ViewThamDinhLuanVanThacSyDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewThamDinhLuanVanThacSyDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewThamDinhLuanVanThacSyDataSourceView : ReadOnlyDataSourceView<ViewThamDinhLuanVanThacSy>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThamDinhLuanVanThacSyDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewThamDinhLuanVanThacSyDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewThamDinhLuanVanThacSyDataSourceView(ViewThamDinhLuanVanThacSyDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewThamDinhLuanVanThacSyDataSource ViewThamDinhLuanVanThacSyOwner
		{
			get { return Owner as ViewThamDinhLuanVanThacSyDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewThamDinhLuanVanThacSySelectMethod SelectMethod
		{
			get { return ViewThamDinhLuanVanThacSyOwner.SelectMethod; }
			set { ViewThamDinhLuanVanThacSyOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewThamDinhLuanVanThacSyService ViewThamDinhLuanVanThacSyProvider
		{
			get { return Provider as ViewThamDinhLuanVanThacSyService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewThamDinhLuanVanThacSy> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewThamDinhLuanVanThacSy> results = null;
			// ViewThamDinhLuanVanThacSy item;
			count = 0;
			
			System.String sp1084_NamHoc;
			System.String sp1084_HocKy;

			switch ( SelectMethod )
			{
				case ViewThamDinhLuanVanThacSySelectMethod.Get:
					results = ViewThamDinhLuanVanThacSyProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewThamDinhLuanVanThacSySelectMethod.GetPaged:
					results = ViewThamDinhLuanVanThacSyProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewThamDinhLuanVanThacSySelectMethod.GetAll:
					results = ViewThamDinhLuanVanThacSyProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewThamDinhLuanVanThacSySelectMethod.Find:
					results = ViewThamDinhLuanVanThacSyProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewThamDinhLuanVanThacSySelectMethod.GetByNamHocHocKy:
					sp1084_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp1084_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewThamDinhLuanVanThacSyProvider.GetByNamHocHocKy(sp1084_NamHoc, sp1084_HocKy, StartIndex, PageSize);
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
		
		#endregion Methods
	}

	#region ViewThamDinhLuanVanThacSySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewThamDinhLuanVanThacSyDataSource.SelectMethod property.
	/// </summary>
	public enum ViewThamDinhLuanVanThacSySelectMethod
	{
		/// <summary>
		/// Represents the Get method.
		/// </summary>
		Get,
		/// <summary>
		/// Represents the GetPaged method.
		/// </summary>
		GetPaged,
		/// <summary>
		/// Represents the GetAll method.
		/// </summary>
		GetAll,
		/// <summary>
		/// Represents the Find method.
		/// </summary>
		Find,
		/// <summary>
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy
	}
	
	#endregion ViewThamDinhLuanVanThacSySelectMethod
	
	#region ViewThamDinhLuanVanThacSyDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewThamDinhLuanVanThacSyDataSource class.
	/// </summary>
	public class ViewThamDinhLuanVanThacSyDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewThamDinhLuanVanThacSy>
	{
		/// <summary>
		/// Initializes a new instance of the ViewThamDinhLuanVanThacSyDataSourceDesigner class.
		/// </summary>
		public ViewThamDinhLuanVanThacSyDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewThamDinhLuanVanThacSySelectMethod SelectMethod
		{
			get { return ((ViewThamDinhLuanVanThacSyDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewThamDinhLuanVanThacSyDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewThamDinhLuanVanThacSyDataSourceActionList

	/// <summary>
	/// Supports the ViewThamDinhLuanVanThacSyDataSourceDesigner class.
	/// </summary>
	internal class ViewThamDinhLuanVanThacSyDataSourceActionList : DesignerActionList
	{
		private ViewThamDinhLuanVanThacSyDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewThamDinhLuanVanThacSyDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewThamDinhLuanVanThacSyDataSourceActionList(ViewThamDinhLuanVanThacSyDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewThamDinhLuanVanThacSySelectMethod SelectMethod
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

	#endregion ViewThamDinhLuanVanThacSyDataSourceActionList

	#endregion ViewThamDinhLuanVanThacSyDataSourceDesigner

	#region ViewThamDinhLuanVanThacSyFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThamDinhLuanVanThacSy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThamDinhLuanVanThacSyFilter : SqlFilter<ViewThamDinhLuanVanThacSyColumn>
	{
	}

	#endregion ViewThamDinhLuanVanThacSyFilter

	#region ViewThamDinhLuanVanThacSyExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThamDinhLuanVanThacSy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThamDinhLuanVanThacSyExpressionBuilder : SqlExpressionBuilder<ViewThamDinhLuanVanThacSyColumn>
	{
	}
	
	#endregion ViewThamDinhLuanVanThacSyExpressionBuilder		
}

