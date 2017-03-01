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
	/// Represents the DataRepository.ViewSdhUteKhoiLuongQuyDoiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewSdhUteKhoiLuongQuyDoiDataSourceDesigner))]
	public class ViewSdhUteKhoiLuongQuyDoiDataSource : ReadOnlyDataSource<ViewSdhUteKhoiLuongQuyDoi>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewSdhUteKhoiLuongQuyDoiDataSource class.
		/// </summary>
		public ViewSdhUteKhoiLuongQuyDoiDataSource() : base(new ViewSdhUteKhoiLuongQuyDoiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewSdhUteKhoiLuongQuyDoiDataSourceView used by the ViewSdhUteKhoiLuongQuyDoiDataSource.
		/// </summary>
		protected ViewSdhUteKhoiLuongQuyDoiDataSourceView ViewSdhUteKhoiLuongQuyDoiView
		{
			get { return ( View as ViewSdhUteKhoiLuongQuyDoiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewSdhUteKhoiLuongQuyDoiDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewSdhUteKhoiLuongQuyDoiSelectMethod SelectMethod
		{
			get
			{
				ViewSdhUteKhoiLuongQuyDoiSelectMethod selectMethod = ViewSdhUteKhoiLuongQuyDoiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewSdhUteKhoiLuongQuyDoiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewSdhUteKhoiLuongQuyDoiDataSourceView class that is to be
		/// used by the ViewSdhUteKhoiLuongQuyDoiDataSource.
		/// </summary>
		/// <returns>An instance of the ViewSdhUteKhoiLuongQuyDoiDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewSdhUteKhoiLuongQuyDoi, Object> GetNewDataSourceView()
		{
			return new ViewSdhUteKhoiLuongQuyDoiDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewSdhUteKhoiLuongQuyDoiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewSdhUteKhoiLuongQuyDoiDataSourceView : ReadOnlyDataSourceView<ViewSdhUteKhoiLuongQuyDoi>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewSdhUteKhoiLuongQuyDoiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewSdhUteKhoiLuongQuyDoiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewSdhUteKhoiLuongQuyDoiDataSourceView(ViewSdhUteKhoiLuongQuyDoiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewSdhUteKhoiLuongQuyDoiDataSource ViewSdhUteKhoiLuongQuyDoiOwner
		{
			get { return Owner as ViewSdhUteKhoiLuongQuyDoiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewSdhUteKhoiLuongQuyDoiSelectMethod SelectMethod
		{
			get { return ViewSdhUteKhoiLuongQuyDoiOwner.SelectMethod; }
			set { ViewSdhUteKhoiLuongQuyDoiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewSdhUteKhoiLuongQuyDoiService ViewSdhUteKhoiLuongQuyDoiProvider
		{
			get { return Provider as ViewSdhUteKhoiLuongQuyDoiService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewSdhUteKhoiLuongQuyDoi> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewSdhUteKhoiLuongQuyDoi> results = null;
			// ViewSdhUteKhoiLuongQuyDoi item;
			count = 0;
			
			System.String sp3176_NamHoc;
			System.String sp3176_HocKy;

			switch ( SelectMethod )
			{
				case ViewSdhUteKhoiLuongQuyDoiSelectMethod.Get:
					results = ViewSdhUteKhoiLuongQuyDoiProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewSdhUteKhoiLuongQuyDoiSelectMethod.GetPaged:
					results = ViewSdhUteKhoiLuongQuyDoiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewSdhUteKhoiLuongQuyDoiSelectMethod.GetAll:
					results = ViewSdhUteKhoiLuongQuyDoiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewSdhUteKhoiLuongQuyDoiSelectMethod.Find:
					results = ViewSdhUteKhoiLuongQuyDoiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewSdhUteKhoiLuongQuyDoiSelectMethod.GetByNamHocHocKy:
					sp3176_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3176_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewSdhUteKhoiLuongQuyDoiProvider.GetByNamHocHocKy(sp3176_NamHoc, sp3176_HocKy, StartIndex, PageSize);
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

	#region ViewSdhUteKhoiLuongQuyDoiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewSdhUteKhoiLuongQuyDoiDataSource.SelectMethod property.
	/// </summary>
	public enum ViewSdhUteKhoiLuongQuyDoiSelectMethod
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
	
	#endregion ViewSdhUteKhoiLuongQuyDoiSelectMethod
	
	#region ViewSdhUteKhoiLuongQuyDoiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewSdhUteKhoiLuongQuyDoiDataSource class.
	/// </summary>
	public class ViewSdhUteKhoiLuongQuyDoiDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewSdhUteKhoiLuongQuyDoi>
	{
		/// <summary>
		/// Initializes a new instance of the ViewSdhUteKhoiLuongQuyDoiDataSourceDesigner class.
		/// </summary>
		public ViewSdhUteKhoiLuongQuyDoiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewSdhUteKhoiLuongQuyDoiSelectMethod SelectMethod
		{
			get { return ((ViewSdhUteKhoiLuongQuyDoiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewSdhUteKhoiLuongQuyDoiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewSdhUteKhoiLuongQuyDoiDataSourceActionList

	/// <summary>
	/// Supports the ViewSdhUteKhoiLuongQuyDoiDataSourceDesigner class.
	/// </summary>
	internal class ViewSdhUteKhoiLuongQuyDoiDataSourceActionList : DesignerActionList
	{
		private ViewSdhUteKhoiLuongQuyDoiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewSdhUteKhoiLuongQuyDoiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewSdhUteKhoiLuongQuyDoiDataSourceActionList(ViewSdhUteKhoiLuongQuyDoiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewSdhUteKhoiLuongQuyDoiSelectMethod SelectMethod
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

	#endregion ViewSdhUteKhoiLuongQuyDoiDataSourceActionList

	#endregion ViewSdhUteKhoiLuongQuyDoiDataSourceDesigner

	#region ViewSdhUteKhoiLuongQuyDoiFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewSdhUteKhoiLuongQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewSdhUteKhoiLuongQuyDoiFilter : SqlFilter<ViewSdhUteKhoiLuongQuyDoiColumn>
	{
	}

	#endregion ViewSdhUteKhoiLuongQuyDoiFilter

	#region ViewSdhUteKhoiLuongQuyDoiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewSdhUteKhoiLuongQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewSdhUteKhoiLuongQuyDoiExpressionBuilder : SqlExpressionBuilder<ViewSdhUteKhoiLuongQuyDoiColumn>
	{
	}
	
	#endregion ViewSdhUteKhoiLuongQuyDoiExpressionBuilder		
}

