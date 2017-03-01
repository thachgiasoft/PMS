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
	/// Represents the DataRepository.ViewChiTietQuyDoiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewChiTietQuyDoiDataSourceDesigner))]
	public class ViewChiTietQuyDoiDataSource : ReadOnlyDataSource<ViewChiTietQuyDoi>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTietQuyDoiDataSource class.
		/// </summary>
		public ViewChiTietQuyDoiDataSource() : base(new ViewChiTietQuyDoiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewChiTietQuyDoiDataSourceView used by the ViewChiTietQuyDoiDataSource.
		/// </summary>
		protected ViewChiTietQuyDoiDataSourceView ViewChiTietQuyDoiView
		{
			get { return ( View as ViewChiTietQuyDoiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewChiTietQuyDoiDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewChiTietQuyDoiSelectMethod SelectMethod
		{
			get
			{
				ViewChiTietQuyDoiSelectMethod selectMethod = ViewChiTietQuyDoiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewChiTietQuyDoiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewChiTietQuyDoiDataSourceView class that is to be
		/// used by the ViewChiTietQuyDoiDataSource.
		/// </summary>
		/// <returns>An instance of the ViewChiTietQuyDoiDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewChiTietQuyDoi, Object> GetNewDataSourceView()
		{
			return new ViewChiTietQuyDoiDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewChiTietQuyDoiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewChiTietQuyDoiDataSourceView : ReadOnlyDataSourceView<ViewChiTietQuyDoi>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTietQuyDoiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewChiTietQuyDoiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewChiTietQuyDoiDataSourceView(ViewChiTietQuyDoiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewChiTietQuyDoiDataSource ViewChiTietQuyDoiOwner
		{
			get { return Owner as ViewChiTietQuyDoiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewChiTietQuyDoiSelectMethod SelectMethod
		{
			get { return ViewChiTietQuyDoiOwner.SelectMethod; }
			set { ViewChiTietQuyDoiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewChiTietQuyDoiService ViewChiTietQuyDoiProvider
		{
			get { return Provider as ViewChiTietQuyDoiService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewChiTietQuyDoi> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewChiTietQuyDoi> results = null;
			// ViewChiTietQuyDoi item;
			count = 0;
			
			System.String sp3039_NamHoc;
			System.String sp3039_HocKy;

			switch ( SelectMethod )
			{
				case ViewChiTietQuyDoiSelectMethod.Get:
					results = ViewChiTietQuyDoiProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewChiTietQuyDoiSelectMethod.GetPaged:
					results = ViewChiTietQuyDoiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewChiTietQuyDoiSelectMethod.GetAll:
					results = ViewChiTietQuyDoiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewChiTietQuyDoiSelectMethod.Find:
					results = ViewChiTietQuyDoiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewChiTietQuyDoiSelectMethod.GetByNamHocHocKy:
					sp3039_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3039_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewChiTietQuyDoiProvider.GetByNamHocHocKy(sp3039_NamHoc, sp3039_HocKy, StartIndex, PageSize);
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

	#region ViewChiTietQuyDoiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewChiTietQuyDoiDataSource.SelectMethod property.
	/// </summary>
	public enum ViewChiTietQuyDoiSelectMethod
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
	
	#endregion ViewChiTietQuyDoiSelectMethod
	
	#region ViewChiTietQuyDoiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewChiTietQuyDoiDataSource class.
	/// </summary>
	public class ViewChiTietQuyDoiDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewChiTietQuyDoi>
	{
		/// <summary>
		/// Initializes a new instance of the ViewChiTietQuyDoiDataSourceDesigner class.
		/// </summary>
		public ViewChiTietQuyDoiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewChiTietQuyDoiSelectMethod SelectMethod
		{
			get { return ((ViewChiTietQuyDoiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewChiTietQuyDoiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewChiTietQuyDoiDataSourceActionList

	/// <summary>
	/// Supports the ViewChiTietQuyDoiDataSourceDesigner class.
	/// </summary>
	internal class ViewChiTietQuyDoiDataSourceActionList : DesignerActionList
	{
		private ViewChiTietQuyDoiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewChiTietQuyDoiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewChiTietQuyDoiDataSourceActionList(ViewChiTietQuyDoiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewChiTietQuyDoiSelectMethod SelectMethod
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

	#endregion ViewChiTietQuyDoiDataSourceActionList

	#endregion ViewChiTietQuyDoiDataSourceDesigner

	#region ViewChiTietQuyDoiFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTietQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewChiTietQuyDoiFilter : SqlFilter<ViewChiTietQuyDoiColumn>
	{
	}

	#endregion ViewChiTietQuyDoiFilter

	#region ViewChiTietQuyDoiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTietQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewChiTietQuyDoiExpressionBuilder : SqlExpressionBuilder<ViewChiTietQuyDoiColumn>
	{
	}
	
	#endregion ViewChiTietQuyDoiExpressionBuilder		
}

