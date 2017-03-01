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
	/// Represents the DataRepository.ViewMonGiangMoiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewMonGiangMoiDataSourceDesigner))]
	public class ViewMonGiangMoiDataSource : ReadOnlyDataSource<ViewMonGiangMoi>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewMonGiangMoiDataSource class.
		/// </summary>
		public ViewMonGiangMoiDataSource() : base(new ViewMonGiangMoiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewMonGiangMoiDataSourceView used by the ViewMonGiangMoiDataSource.
		/// </summary>
		protected ViewMonGiangMoiDataSourceView ViewMonGiangMoiView
		{
			get { return ( View as ViewMonGiangMoiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewMonGiangMoiDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewMonGiangMoiSelectMethod SelectMethod
		{
			get
			{
				ViewMonGiangMoiSelectMethod selectMethod = ViewMonGiangMoiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewMonGiangMoiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewMonGiangMoiDataSourceView class that is to be
		/// used by the ViewMonGiangMoiDataSource.
		/// </summary>
		/// <returns>An instance of the ViewMonGiangMoiDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewMonGiangMoi, Object> GetNewDataSourceView()
		{
			return new ViewMonGiangMoiDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewMonGiangMoiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewMonGiangMoiDataSourceView : ReadOnlyDataSourceView<ViewMonGiangMoi>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewMonGiangMoiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewMonGiangMoiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewMonGiangMoiDataSourceView(ViewMonGiangMoiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewMonGiangMoiDataSource ViewMonGiangMoiOwner
		{
			get { return Owner as ViewMonGiangMoiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewMonGiangMoiSelectMethod SelectMethod
		{
			get { return ViewMonGiangMoiOwner.SelectMethod; }
			set { ViewMonGiangMoiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewMonGiangMoiService ViewMonGiangMoiProvider
		{
			get { return Provider as ViewMonGiangMoiService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewMonGiangMoi> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewMonGiangMoi> results = null;
			// ViewMonGiangMoi item;
			count = 0;
			
			System.String sp1052_NamHoc;
			System.String sp1052_HocKy;

			switch ( SelectMethod )
			{
				case ViewMonGiangMoiSelectMethod.Get:
					results = ViewMonGiangMoiProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewMonGiangMoiSelectMethod.GetPaged:
					results = ViewMonGiangMoiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewMonGiangMoiSelectMethod.GetAll:
					results = ViewMonGiangMoiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewMonGiangMoiSelectMethod.Find:
					results = ViewMonGiangMoiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewMonGiangMoiSelectMethod.GetByNamHocHocKy:
					sp1052_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp1052_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewMonGiangMoiProvider.GetByNamHocHocKy(sp1052_NamHoc, sp1052_HocKy, StartIndex, PageSize);
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

	#region ViewMonGiangMoiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewMonGiangMoiDataSource.SelectMethod property.
	/// </summary>
	public enum ViewMonGiangMoiSelectMethod
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
	
	#endregion ViewMonGiangMoiSelectMethod
	
	#region ViewMonGiangMoiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewMonGiangMoiDataSource class.
	/// </summary>
	public class ViewMonGiangMoiDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewMonGiangMoi>
	{
		/// <summary>
		/// Initializes a new instance of the ViewMonGiangMoiDataSourceDesigner class.
		/// </summary>
		public ViewMonGiangMoiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewMonGiangMoiSelectMethod SelectMethod
		{
			get { return ((ViewMonGiangMoiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewMonGiangMoiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewMonGiangMoiDataSourceActionList

	/// <summary>
	/// Supports the ViewMonGiangMoiDataSourceDesigner class.
	/// </summary>
	internal class ViewMonGiangMoiDataSourceActionList : DesignerActionList
	{
		private ViewMonGiangMoiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewMonGiangMoiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewMonGiangMoiDataSourceActionList(ViewMonGiangMoiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewMonGiangMoiSelectMethod SelectMethod
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

	#endregion ViewMonGiangMoiDataSourceActionList

	#endregion ViewMonGiangMoiDataSourceDesigner

	#region ViewMonGiangMoiFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewMonGiangMoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewMonGiangMoiFilter : SqlFilter<ViewMonGiangMoiColumn>
	{
	}

	#endregion ViewMonGiangMoiFilter

	#region ViewMonGiangMoiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewMonGiangMoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewMonGiangMoiExpressionBuilder : SqlExpressionBuilder<ViewMonGiangMoiColumn>
	{
	}
	
	#endregion ViewMonGiangMoiExpressionBuilder		
}

