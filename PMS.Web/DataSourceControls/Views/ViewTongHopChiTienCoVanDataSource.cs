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
	/// Represents the DataRepository.ViewTongHopChiTienCoVanProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewTongHopChiTienCoVanDataSourceDesigner))]
	public class ViewTongHopChiTienCoVanDataSource : ReadOnlyDataSource<ViewTongHopChiTienCoVan>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTongHopChiTienCoVanDataSource class.
		/// </summary>
		public ViewTongHopChiTienCoVanDataSource() : base(new ViewTongHopChiTienCoVanService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewTongHopChiTienCoVanDataSourceView used by the ViewTongHopChiTienCoVanDataSource.
		/// </summary>
		protected ViewTongHopChiTienCoVanDataSourceView ViewTongHopChiTienCoVanView
		{
			get { return ( View as ViewTongHopChiTienCoVanDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewTongHopChiTienCoVanDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewTongHopChiTienCoVanSelectMethod SelectMethod
		{
			get
			{
				ViewTongHopChiTienCoVanSelectMethod selectMethod = ViewTongHopChiTienCoVanSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewTongHopChiTienCoVanSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewTongHopChiTienCoVanDataSourceView class that is to be
		/// used by the ViewTongHopChiTienCoVanDataSource.
		/// </summary>
		/// <returns>An instance of the ViewTongHopChiTienCoVanDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewTongHopChiTienCoVan, Object> GetNewDataSourceView()
		{
			return new ViewTongHopChiTienCoVanDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewTongHopChiTienCoVanDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewTongHopChiTienCoVanDataSourceView : ReadOnlyDataSourceView<ViewTongHopChiTienCoVan>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTongHopChiTienCoVanDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewTongHopChiTienCoVanDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewTongHopChiTienCoVanDataSourceView(ViewTongHopChiTienCoVanDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewTongHopChiTienCoVanDataSource ViewTongHopChiTienCoVanOwner
		{
			get { return Owner as ViewTongHopChiTienCoVanDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewTongHopChiTienCoVanSelectMethod SelectMethod
		{
			get { return ViewTongHopChiTienCoVanOwner.SelectMethod; }
			set { ViewTongHopChiTienCoVanOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewTongHopChiTienCoVanService ViewTongHopChiTienCoVanProvider
		{
			get { return Provider as ViewTongHopChiTienCoVanService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewTongHopChiTienCoVan> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewTongHopChiTienCoVan> results = null;
			// ViewTongHopChiTienCoVan item;
			count = 0;
			
			System.String sp1129_NamHoc;
			System.String sp1129_HocKy;

			switch ( SelectMethod )
			{
				case ViewTongHopChiTienCoVanSelectMethod.Get:
					results = ViewTongHopChiTienCoVanProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewTongHopChiTienCoVanSelectMethod.GetPaged:
					results = ViewTongHopChiTienCoVanProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewTongHopChiTienCoVanSelectMethod.GetAll:
					results = ViewTongHopChiTienCoVanProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewTongHopChiTienCoVanSelectMethod.Find:
					results = ViewTongHopChiTienCoVanProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewTongHopChiTienCoVanSelectMethod.GetByNamHocHocKy:
					sp1129_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp1129_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewTongHopChiTienCoVanProvider.GetByNamHocHocKy(sp1129_NamHoc, sp1129_HocKy, StartIndex, PageSize);
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

	#region ViewTongHopChiTienCoVanSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewTongHopChiTienCoVanDataSource.SelectMethod property.
	/// </summary>
	public enum ViewTongHopChiTienCoVanSelectMethod
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
	
	#endregion ViewTongHopChiTienCoVanSelectMethod
	
	#region ViewTongHopChiTienCoVanDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewTongHopChiTienCoVanDataSource class.
	/// </summary>
	public class ViewTongHopChiTienCoVanDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewTongHopChiTienCoVan>
	{
		/// <summary>
		/// Initializes a new instance of the ViewTongHopChiTienCoVanDataSourceDesigner class.
		/// </summary>
		public ViewTongHopChiTienCoVanDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewTongHopChiTienCoVanSelectMethod SelectMethod
		{
			get { return ((ViewTongHopChiTienCoVanDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewTongHopChiTienCoVanDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewTongHopChiTienCoVanDataSourceActionList

	/// <summary>
	/// Supports the ViewTongHopChiTienCoVanDataSourceDesigner class.
	/// </summary>
	internal class ViewTongHopChiTienCoVanDataSourceActionList : DesignerActionList
	{
		private ViewTongHopChiTienCoVanDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewTongHopChiTienCoVanDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewTongHopChiTienCoVanDataSourceActionList(ViewTongHopChiTienCoVanDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewTongHopChiTienCoVanSelectMethod SelectMethod
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

	#endregion ViewTongHopChiTienCoVanDataSourceActionList

	#endregion ViewTongHopChiTienCoVanDataSourceDesigner

	#region ViewTongHopChiTienCoVanFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTongHopChiTienCoVan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTongHopChiTienCoVanFilter : SqlFilter<ViewTongHopChiTienCoVanColumn>
	{
	}

	#endregion ViewTongHopChiTienCoVanFilter

	#region ViewTongHopChiTienCoVanExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTongHopChiTienCoVan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTongHopChiTienCoVanExpressionBuilder : SqlExpressionBuilder<ViewTongHopChiTienCoVanColumn>
	{
	}
	
	#endregion ViewTongHopChiTienCoVanExpressionBuilder		
}

