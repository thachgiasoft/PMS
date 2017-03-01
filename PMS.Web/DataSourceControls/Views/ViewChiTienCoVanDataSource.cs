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
	/// Represents the DataRepository.ViewChiTienCoVanProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewChiTienCoVanDataSourceDesigner))]
	public class ViewChiTienCoVanDataSource : ReadOnlyDataSource<ViewChiTienCoVan>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTienCoVanDataSource class.
		/// </summary>
		public ViewChiTienCoVanDataSource() : base(new ViewChiTienCoVanService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewChiTienCoVanDataSourceView used by the ViewChiTienCoVanDataSource.
		/// </summary>
		protected ViewChiTienCoVanDataSourceView ViewChiTienCoVanView
		{
			get { return ( View as ViewChiTienCoVanDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewChiTienCoVanDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewChiTienCoVanSelectMethod SelectMethod
		{
			get
			{
				ViewChiTienCoVanSelectMethod selectMethod = ViewChiTienCoVanSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewChiTienCoVanSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewChiTienCoVanDataSourceView class that is to be
		/// used by the ViewChiTienCoVanDataSource.
		/// </summary>
		/// <returns>An instance of the ViewChiTienCoVanDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewChiTienCoVan, Object> GetNewDataSourceView()
		{
			return new ViewChiTienCoVanDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewChiTienCoVanDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewChiTienCoVanDataSourceView : ReadOnlyDataSourceView<ViewChiTienCoVan>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTienCoVanDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewChiTienCoVanDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewChiTienCoVanDataSourceView(ViewChiTienCoVanDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewChiTienCoVanDataSource ViewChiTienCoVanOwner
		{
			get { return Owner as ViewChiTienCoVanDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewChiTienCoVanSelectMethod SelectMethod
		{
			get { return ViewChiTienCoVanOwner.SelectMethod; }
			set { ViewChiTienCoVanOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewChiTienCoVanService ViewChiTienCoVanProvider
		{
			get { return Provider as ViewChiTienCoVanService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewChiTienCoVan> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewChiTienCoVan> results = null;
			// ViewChiTienCoVan item;
			count = 0;
			
			System.String sp933_NamHoc;
			System.String sp933_HocKy;

			switch ( SelectMethod )
			{
				case ViewChiTienCoVanSelectMethod.Get:
					results = ViewChiTienCoVanProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewChiTienCoVanSelectMethod.GetPaged:
					results = ViewChiTienCoVanProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewChiTienCoVanSelectMethod.GetAll:
					results = ViewChiTienCoVanProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewChiTienCoVanSelectMethod.Find:
					results = ViewChiTienCoVanProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewChiTienCoVanSelectMethod.GetByNamHocHocKy:
					sp933_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp933_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewChiTienCoVanProvider.GetByNamHocHocKy(sp933_NamHoc, sp933_HocKy, StartIndex, PageSize);
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

	#region ViewChiTienCoVanSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewChiTienCoVanDataSource.SelectMethod property.
	/// </summary>
	public enum ViewChiTienCoVanSelectMethod
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
	
	#endregion ViewChiTienCoVanSelectMethod
	
	#region ViewChiTienCoVanDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewChiTienCoVanDataSource class.
	/// </summary>
	public class ViewChiTienCoVanDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewChiTienCoVan>
	{
		/// <summary>
		/// Initializes a new instance of the ViewChiTienCoVanDataSourceDesigner class.
		/// </summary>
		public ViewChiTienCoVanDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewChiTienCoVanSelectMethod SelectMethod
		{
			get { return ((ViewChiTienCoVanDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewChiTienCoVanDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewChiTienCoVanDataSourceActionList

	/// <summary>
	/// Supports the ViewChiTienCoVanDataSourceDesigner class.
	/// </summary>
	internal class ViewChiTienCoVanDataSourceActionList : DesignerActionList
	{
		private ViewChiTienCoVanDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewChiTienCoVanDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewChiTienCoVanDataSourceActionList(ViewChiTienCoVanDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewChiTienCoVanSelectMethod SelectMethod
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

	#endregion ViewChiTienCoVanDataSourceActionList

	#endregion ViewChiTienCoVanDataSourceDesigner

	#region ViewChiTienCoVanFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTienCoVan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewChiTienCoVanFilter : SqlFilter<ViewChiTienCoVanColumn>
	{
	}

	#endregion ViewChiTienCoVanFilter

	#region ViewChiTienCoVanExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTienCoVan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewChiTienCoVanExpressionBuilder : SqlExpressionBuilder<ViewChiTienCoVanColumn>
	{
	}
	
	#endregion ViewChiTienCoVanExpressionBuilder		
}

