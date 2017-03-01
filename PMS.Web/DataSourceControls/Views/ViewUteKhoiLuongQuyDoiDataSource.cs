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
	/// Represents the DataRepository.ViewUteKhoiLuongQuyDoiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewUteKhoiLuongQuyDoiDataSourceDesigner))]
	public class ViewUteKhoiLuongQuyDoiDataSource : ReadOnlyDataSource<ViewUteKhoiLuongQuyDoi>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewUteKhoiLuongQuyDoiDataSource class.
		/// </summary>
		public ViewUteKhoiLuongQuyDoiDataSource() : base(new ViewUteKhoiLuongQuyDoiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewUteKhoiLuongQuyDoiDataSourceView used by the ViewUteKhoiLuongQuyDoiDataSource.
		/// </summary>
		protected ViewUteKhoiLuongQuyDoiDataSourceView ViewUteKhoiLuongQuyDoiView
		{
			get { return ( View as ViewUteKhoiLuongQuyDoiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewUteKhoiLuongQuyDoiDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewUteKhoiLuongQuyDoiSelectMethod SelectMethod
		{
			get
			{
				ViewUteKhoiLuongQuyDoiSelectMethod selectMethod = ViewUteKhoiLuongQuyDoiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewUteKhoiLuongQuyDoiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewUteKhoiLuongQuyDoiDataSourceView class that is to be
		/// used by the ViewUteKhoiLuongQuyDoiDataSource.
		/// </summary>
		/// <returns>An instance of the ViewUteKhoiLuongQuyDoiDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewUteKhoiLuongQuyDoi, Object> GetNewDataSourceView()
		{
			return new ViewUteKhoiLuongQuyDoiDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewUteKhoiLuongQuyDoiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewUteKhoiLuongQuyDoiDataSourceView : ReadOnlyDataSourceView<ViewUteKhoiLuongQuyDoi>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewUteKhoiLuongQuyDoiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewUteKhoiLuongQuyDoiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewUteKhoiLuongQuyDoiDataSourceView(ViewUteKhoiLuongQuyDoiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewUteKhoiLuongQuyDoiDataSource ViewUteKhoiLuongQuyDoiOwner
		{
			get { return Owner as ViewUteKhoiLuongQuyDoiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewUteKhoiLuongQuyDoiSelectMethod SelectMethod
		{
			get { return ViewUteKhoiLuongQuyDoiOwner.SelectMethod; }
			set { ViewUteKhoiLuongQuyDoiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewUteKhoiLuongQuyDoiService ViewUteKhoiLuongQuyDoiProvider
		{
			get { return Provider as ViewUteKhoiLuongQuyDoiService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewUteKhoiLuongQuyDoi> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewUteKhoiLuongQuyDoi> results = null;
			// ViewUteKhoiLuongQuyDoi item;
			count = 0;
			
			System.String sp1136_NamHoc;
			System.String sp1136_HocKy;

			switch ( SelectMethod )
			{
				case ViewUteKhoiLuongQuyDoiSelectMethod.Get:
					results = ViewUteKhoiLuongQuyDoiProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewUteKhoiLuongQuyDoiSelectMethod.GetPaged:
					results = ViewUteKhoiLuongQuyDoiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewUteKhoiLuongQuyDoiSelectMethod.GetAll:
					results = ViewUteKhoiLuongQuyDoiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewUteKhoiLuongQuyDoiSelectMethod.Find:
					results = ViewUteKhoiLuongQuyDoiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewUteKhoiLuongQuyDoiSelectMethod.GetByNamHocHocKy:
					sp1136_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp1136_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewUteKhoiLuongQuyDoiProvider.GetByNamHocHocKy(sp1136_NamHoc, sp1136_HocKy, StartIndex, PageSize);
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

	#region ViewUteKhoiLuongQuyDoiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewUteKhoiLuongQuyDoiDataSource.SelectMethod property.
	/// </summary>
	public enum ViewUteKhoiLuongQuyDoiSelectMethod
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
	
	#endregion ViewUteKhoiLuongQuyDoiSelectMethod
	
	#region ViewUteKhoiLuongQuyDoiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewUteKhoiLuongQuyDoiDataSource class.
	/// </summary>
	public class ViewUteKhoiLuongQuyDoiDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewUteKhoiLuongQuyDoi>
	{
		/// <summary>
		/// Initializes a new instance of the ViewUteKhoiLuongQuyDoiDataSourceDesigner class.
		/// </summary>
		public ViewUteKhoiLuongQuyDoiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewUteKhoiLuongQuyDoiSelectMethod SelectMethod
		{
			get { return ((ViewUteKhoiLuongQuyDoiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewUteKhoiLuongQuyDoiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewUteKhoiLuongQuyDoiDataSourceActionList

	/// <summary>
	/// Supports the ViewUteKhoiLuongQuyDoiDataSourceDesigner class.
	/// </summary>
	internal class ViewUteKhoiLuongQuyDoiDataSourceActionList : DesignerActionList
	{
		private ViewUteKhoiLuongQuyDoiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewUteKhoiLuongQuyDoiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewUteKhoiLuongQuyDoiDataSourceActionList(ViewUteKhoiLuongQuyDoiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewUteKhoiLuongQuyDoiSelectMethod SelectMethod
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

	#endregion ViewUteKhoiLuongQuyDoiDataSourceActionList

	#endregion ViewUteKhoiLuongQuyDoiDataSourceDesigner

	#region ViewUteKhoiLuongQuyDoiFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewUteKhoiLuongQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewUteKhoiLuongQuyDoiFilter : SqlFilter<ViewUteKhoiLuongQuyDoiColumn>
	{
	}

	#endregion ViewUteKhoiLuongQuyDoiFilter

	#region ViewUteKhoiLuongQuyDoiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewUteKhoiLuongQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewUteKhoiLuongQuyDoiExpressionBuilder : SqlExpressionBuilder<ViewUteKhoiLuongQuyDoiColumn>
	{
	}
	
	#endregion ViewUteKhoiLuongQuyDoiExpressionBuilder		
}

