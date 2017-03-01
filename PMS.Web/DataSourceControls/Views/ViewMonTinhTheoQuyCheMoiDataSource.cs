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
	/// Represents the DataRepository.ViewMonTinhTheoQuyCheMoiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewMonTinhTheoQuyCheMoiDataSourceDesigner))]
	public class ViewMonTinhTheoQuyCheMoiDataSource : ReadOnlyDataSource<ViewMonTinhTheoQuyCheMoi>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewMonTinhTheoQuyCheMoiDataSource class.
		/// </summary>
		public ViewMonTinhTheoQuyCheMoiDataSource() : base(new ViewMonTinhTheoQuyCheMoiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewMonTinhTheoQuyCheMoiDataSourceView used by the ViewMonTinhTheoQuyCheMoiDataSource.
		/// </summary>
		protected ViewMonTinhTheoQuyCheMoiDataSourceView ViewMonTinhTheoQuyCheMoiView
		{
			get { return ( View as ViewMonTinhTheoQuyCheMoiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewMonTinhTheoQuyCheMoiDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewMonTinhTheoQuyCheMoiSelectMethod SelectMethod
		{
			get
			{
				ViewMonTinhTheoQuyCheMoiSelectMethod selectMethod = ViewMonTinhTheoQuyCheMoiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewMonTinhTheoQuyCheMoiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewMonTinhTheoQuyCheMoiDataSourceView class that is to be
		/// used by the ViewMonTinhTheoQuyCheMoiDataSource.
		/// </summary>
		/// <returns>An instance of the ViewMonTinhTheoQuyCheMoiDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewMonTinhTheoQuyCheMoi, Object> GetNewDataSourceView()
		{
			return new ViewMonTinhTheoQuyCheMoiDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewMonTinhTheoQuyCheMoiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewMonTinhTheoQuyCheMoiDataSourceView : ReadOnlyDataSourceView<ViewMonTinhTheoQuyCheMoi>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewMonTinhTheoQuyCheMoiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewMonTinhTheoQuyCheMoiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewMonTinhTheoQuyCheMoiDataSourceView(ViewMonTinhTheoQuyCheMoiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewMonTinhTheoQuyCheMoiDataSource ViewMonTinhTheoQuyCheMoiOwner
		{
			get { return Owner as ViewMonTinhTheoQuyCheMoiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewMonTinhTheoQuyCheMoiSelectMethod SelectMethod
		{
			get { return ViewMonTinhTheoQuyCheMoiOwner.SelectMethod; }
			set { ViewMonTinhTheoQuyCheMoiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewMonTinhTheoQuyCheMoiService ViewMonTinhTheoQuyCheMoiProvider
		{
			get { return Provider as ViewMonTinhTheoQuyCheMoiService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewMonTinhTheoQuyCheMoi> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewMonTinhTheoQuyCheMoi> results = null;
			// ViewMonTinhTheoQuyCheMoi item;
			count = 0;
			
			System.String sp1060_NamHoc;
			System.String sp1060_HocKy;

			switch ( SelectMethod )
			{
				case ViewMonTinhTheoQuyCheMoiSelectMethod.Get:
					results = ViewMonTinhTheoQuyCheMoiProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewMonTinhTheoQuyCheMoiSelectMethod.GetPaged:
					results = ViewMonTinhTheoQuyCheMoiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewMonTinhTheoQuyCheMoiSelectMethod.GetAll:
					results = ViewMonTinhTheoQuyCheMoiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewMonTinhTheoQuyCheMoiSelectMethod.Find:
					results = ViewMonTinhTheoQuyCheMoiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewMonTinhTheoQuyCheMoiSelectMethod.GetByNamHocHocKy:
					sp1060_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp1060_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewMonTinhTheoQuyCheMoiProvider.GetByNamHocHocKy(sp1060_NamHoc, sp1060_HocKy, StartIndex, PageSize);
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

	#region ViewMonTinhTheoQuyCheMoiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewMonTinhTheoQuyCheMoiDataSource.SelectMethod property.
	/// </summary>
	public enum ViewMonTinhTheoQuyCheMoiSelectMethod
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
	
	#endregion ViewMonTinhTheoQuyCheMoiSelectMethod
	
	#region ViewMonTinhTheoQuyCheMoiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewMonTinhTheoQuyCheMoiDataSource class.
	/// </summary>
	public class ViewMonTinhTheoQuyCheMoiDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewMonTinhTheoQuyCheMoi>
	{
		/// <summary>
		/// Initializes a new instance of the ViewMonTinhTheoQuyCheMoiDataSourceDesigner class.
		/// </summary>
		public ViewMonTinhTheoQuyCheMoiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewMonTinhTheoQuyCheMoiSelectMethod SelectMethod
		{
			get { return ((ViewMonTinhTheoQuyCheMoiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewMonTinhTheoQuyCheMoiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewMonTinhTheoQuyCheMoiDataSourceActionList

	/// <summary>
	/// Supports the ViewMonTinhTheoQuyCheMoiDataSourceDesigner class.
	/// </summary>
	internal class ViewMonTinhTheoQuyCheMoiDataSourceActionList : DesignerActionList
	{
		private ViewMonTinhTheoQuyCheMoiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewMonTinhTheoQuyCheMoiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewMonTinhTheoQuyCheMoiDataSourceActionList(ViewMonTinhTheoQuyCheMoiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewMonTinhTheoQuyCheMoiSelectMethod SelectMethod
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

	#endregion ViewMonTinhTheoQuyCheMoiDataSourceActionList

	#endregion ViewMonTinhTheoQuyCheMoiDataSourceDesigner

	#region ViewMonTinhTheoQuyCheMoiFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewMonTinhTheoQuyCheMoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewMonTinhTheoQuyCheMoiFilter : SqlFilter<ViewMonTinhTheoQuyCheMoiColumn>
	{
	}

	#endregion ViewMonTinhTheoQuyCheMoiFilter

	#region ViewMonTinhTheoQuyCheMoiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewMonTinhTheoQuyCheMoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewMonTinhTheoQuyCheMoiExpressionBuilder : SqlExpressionBuilder<ViewMonTinhTheoQuyCheMoiColumn>
	{
	}
	
	#endregion ViewMonTinhTheoQuyCheMoiExpressionBuilder		
}

