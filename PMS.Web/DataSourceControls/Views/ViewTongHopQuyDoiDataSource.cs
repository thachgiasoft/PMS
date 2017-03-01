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
	/// Represents the DataRepository.ViewTongHopQuyDoiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewTongHopQuyDoiDataSourceDesigner))]
	public class ViewTongHopQuyDoiDataSource : ReadOnlyDataSource<ViewTongHopQuyDoi>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTongHopQuyDoiDataSource class.
		/// </summary>
		public ViewTongHopQuyDoiDataSource() : base(new ViewTongHopQuyDoiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewTongHopQuyDoiDataSourceView used by the ViewTongHopQuyDoiDataSource.
		/// </summary>
		protected ViewTongHopQuyDoiDataSourceView ViewTongHopQuyDoiView
		{
			get { return ( View as ViewTongHopQuyDoiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewTongHopQuyDoiDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewTongHopQuyDoiSelectMethod SelectMethod
		{
			get
			{
				ViewTongHopQuyDoiSelectMethod selectMethod = ViewTongHopQuyDoiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewTongHopQuyDoiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewTongHopQuyDoiDataSourceView class that is to be
		/// used by the ViewTongHopQuyDoiDataSource.
		/// </summary>
		/// <returns>An instance of the ViewTongHopQuyDoiDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewTongHopQuyDoi, Object> GetNewDataSourceView()
		{
			return new ViewTongHopQuyDoiDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewTongHopQuyDoiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewTongHopQuyDoiDataSourceView : ReadOnlyDataSourceView<ViewTongHopQuyDoi>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTongHopQuyDoiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewTongHopQuyDoiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewTongHopQuyDoiDataSourceView(ViewTongHopQuyDoiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewTongHopQuyDoiDataSource ViewTongHopQuyDoiOwner
		{
			get { return Owner as ViewTongHopQuyDoiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewTongHopQuyDoiSelectMethod SelectMethod
		{
			get { return ViewTongHopQuyDoiOwner.SelectMethod; }
			set { ViewTongHopQuyDoiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewTongHopQuyDoiService ViewTongHopQuyDoiProvider
		{
			get { return Provider as ViewTongHopQuyDoiService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewTongHopQuyDoi> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewTongHopQuyDoi> results = null;
			// ViewTongHopQuyDoi item;
			count = 0;
			
			System.String sp1133_NamHoc;
			System.String sp1133_HocKy;

			switch ( SelectMethod )
			{
				case ViewTongHopQuyDoiSelectMethod.Get:
					results = ViewTongHopQuyDoiProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewTongHopQuyDoiSelectMethod.GetPaged:
					results = ViewTongHopQuyDoiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewTongHopQuyDoiSelectMethod.GetAll:
					results = ViewTongHopQuyDoiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewTongHopQuyDoiSelectMethod.Find:
					results = ViewTongHopQuyDoiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewTongHopQuyDoiSelectMethod.GetByNamHocHocKy:
					sp1133_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp1133_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewTongHopQuyDoiProvider.GetByNamHocHocKy(sp1133_NamHoc, sp1133_HocKy, StartIndex, PageSize);
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

	#region ViewTongHopQuyDoiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewTongHopQuyDoiDataSource.SelectMethod property.
	/// </summary>
	public enum ViewTongHopQuyDoiSelectMethod
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
	
	#endregion ViewTongHopQuyDoiSelectMethod
	
	#region ViewTongHopQuyDoiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewTongHopQuyDoiDataSource class.
	/// </summary>
	public class ViewTongHopQuyDoiDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewTongHopQuyDoi>
	{
		/// <summary>
		/// Initializes a new instance of the ViewTongHopQuyDoiDataSourceDesigner class.
		/// </summary>
		public ViewTongHopQuyDoiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewTongHopQuyDoiSelectMethod SelectMethod
		{
			get { return ((ViewTongHopQuyDoiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewTongHopQuyDoiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewTongHopQuyDoiDataSourceActionList

	/// <summary>
	/// Supports the ViewTongHopQuyDoiDataSourceDesigner class.
	/// </summary>
	internal class ViewTongHopQuyDoiDataSourceActionList : DesignerActionList
	{
		private ViewTongHopQuyDoiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewTongHopQuyDoiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewTongHopQuyDoiDataSourceActionList(ViewTongHopQuyDoiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewTongHopQuyDoiSelectMethod SelectMethod
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

	#endregion ViewTongHopQuyDoiDataSourceActionList

	#endregion ViewTongHopQuyDoiDataSourceDesigner

	#region ViewTongHopQuyDoiFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTongHopQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTongHopQuyDoiFilter : SqlFilter<ViewTongHopQuyDoiColumn>
	{
	}

	#endregion ViewTongHopQuyDoiFilter

	#region ViewTongHopQuyDoiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTongHopQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTongHopQuyDoiExpressionBuilder : SqlExpressionBuilder<ViewTongHopQuyDoiColumn>
	{
	}
	
	#endregion ViewTongHopQuyDoiExpressionBuilder		
}

