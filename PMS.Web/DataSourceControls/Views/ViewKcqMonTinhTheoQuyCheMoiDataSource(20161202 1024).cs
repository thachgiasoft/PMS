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
	/// Represents the DataRepository.ViewKcqMonTinhTheoQuyCheMoiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewKcqMonTinhTheoQuyCheMoiDataSourceDesigner))]
	public class ViewKcqMonTinhTheoQuyCheMoiDataSource : ReadOnlyDataSource<ViewKcqMonTinhTheoQuyCheMoi>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKcqMonTinhTheoQuyCheMoiDataSource class.
		/// </summary>
		public ViewKcqMonTinhTheoQuyCheMoiDataSource() : base(new ViewKcqMonTinhTheoQuyCheMoiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewKcqMonTinhTheoQuyCheMoiDataSourceView used by the ViewKcqMonTinhTheoQuyCheMoiDataSource.
		/// </summary>
		protected ViewKcqMonTinhTheoQuyCheMoiDataSourceView ViewKcqMonTinhTheoQuyCheMoiView
		{
			get { return ( View as ViewKcqMonTinhTheoQuyCheMoiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewKcqMonTinhTheoQuyCheMoiDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewKcqMonTinhTheoQuyCheMoiSelectMethod SelectMethod
		{
			get
			{
				ViewKcqMonTinhTheoQuyCheMoiSelectMethod selectMethod = ViewKcqMonTinhTheoQuyCheMoiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewKcqMonTinhTheoQuyCheMoiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewKcqMonTinhTheoQuyCheMoiDataSourceView class that is to be
		/// used by the ViewKcqMonTinhTheoQuyCheMoiDataSource.
		/// </summary>
		/// <returns>An instance of the ViewKcqMonTinhTheoQuyCheMoiDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewKcqMonTinhTheoQuyCheMoi, Object> GetNewDataSourceView()
		{
			return new ViewKcqMonTinhTheoQuyCheMoiDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewKcqMonTinhTheoQuyCheMoiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewKcqMonTinhTheoQuyCheMoiDataSourceView : ReadOnlyDataSourceView<ViewKcqMonTinhTheoQuyCheMoi>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKcqMonTinhTheoQuyCheMoiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewKcqMonTinhTheoQuyCheMoiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewKcqMonTinhTheoQuyCheMoiDataSourceView(ViewKcqMonTinhTheoQuyCheMoiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewKcqMonTinhTheoQuyCheMoiDataSource ViewKcqMonTinhTheoQuyCheMoiOwner
		{
			get { return Owner as ViewKcqMonTinhTheoQuyCheMoiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewKcqMonTinhTheoQuyCheMoiSelectMethod SelectMethod
		{
			get { return ViewKcqMonTinhTheoQuyCheMoiOwner.SelectMethod; }
			set { ViewKcqMonTinhTheoQuyCheMoiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewKcqMonTinhTheoQuyCheMoiService ViewKcqMonTinhTheoQuyCheMoiProvider
		{
			get { return Provider as ViewKcqMonTinhTheoQuyCheMoiService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewKcqMonTinhTheoQuyCheMoi> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewKcqMonTinhTheoQuyCheMoi> results = null;
			// ViewKcqMonTinhTheoQuyCheMoi item;
			count = 0;
			
			System.String sp3086_NamHoc;
			System.String sp3086_HocKy;

			switch ( SelectMethod )
			{
				case ViewKcqMonTinhTheoQuyCheMoiSelectMethod.Get:
					results = ViewKcqMonTinhTheoQuyCheMoiProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewKcqMonTinhTheoQuyCheMoiSelectMethod.GetPaged:
					results = ViewKcqMonTinhTheoQuyCheMoiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewKcqMonTinhTheoQuyCheMoiSelectMethod.GetAll:
					results = ViewKcqMonTinhTheoQuyCheMoiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewKcqMonTinhTheoQuyCheMoiSelectMethod.Find:
					results = ViewKcqMonTinhTheoQuyCheMoiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewKcqMonTinhTheoQuyCheMoiSelectMethod.GetByNamHocHocKy:
					sp3086_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3086_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewKcqMonTinhTheoQuyCheMoiProvider.GetByNamHocHocKy(sp3086_NamHoc, sp3086_HocKy, StartIndex, PageSize);
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

	#region ViewKcqMonTinhTheoQuyCheMoiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewKcqMonTinhTheoQuyCheMoiDataSource.SelectMethod property.
	/// </summary>
	public enum ViewKcqMonTinhTheoQuyCheMoiSelectMethod
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
	
	#endregion ViewKcqMonTinhTheoQuyCheMoiSelectMethod
	
	#region ViewKcqMonTinhTheoQuyCheMoiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewKcqMonTinhTheoQuyCheMoiDataSource class.
	/// </summary>
	public class ViewKcqMonTinhTheoQuyCheMoiDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewKcqMonTinhTheoQuyCheMoi>
	{
		/// <summary>
		/// Initializes a new instance of the ViewKcqMonTinhTheoQuyCheMoiDataSourceDesigner class.
		/// </summary>
		public ViewKcqMonTinhTheoQuyCheMoiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewKcqMonTinhTheoQuyCheMoiSelectMethod SelectMethod
		{
			get { return ((ViewKcqMonTinhTheoQuyCheMoiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewKcqMonTinhTheoQuyCheMoiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewKcqMonTinhTheoQuyCheMoiDataSourceActionList

	/// <summary>
	/// Supports the ViewKcqMonTinhTheoQuyCheMoiDataSourceDesigner class.
	/// </summary>
	internal class ViewKcqMonTinhTheoQuyCheMoiDataSourceActionList : DesignerActionList
	{
		private ViewKcqMonTinhTheoQuyCheMoiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewKcqMonTinhTheoQuyCheMoiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewKcqMonTinhTheoQuyCheMoiDataSourceActionList(ViewKcqMonTinhTheoQuyCheMoiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewKcqMonTinhTheoQuyCheMoiSelectMethod SelectMethod
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

	#endregion ViewKcqMonTinhTheoQuyCheMoiDataSourceActionList

	#endregion ViewKcqMonTinhTheoQuyCheMoiDataSourceDesigner

	#region ViewKcqMonTinhTheoQuyCheMoiFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKcqMonTinhTheoQuyCheMoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKcqMonTinhTheoQuyCheMoiFilter : SqlFilter<ViewKcqMonTinhTheoQuyCheMoiColumn>
	{
	}

	#endregion ViewKcqMonTinhTheoQuyCheMoiFilter

	#region ViewKcqMonTinhTheoQuyCheMoiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKcqMonTinhTheoQuyCheMoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKcqMonTinhTheoQuyCheMoiExpressionBuilder : SqlExpressionBuilder<ViewKcqMonTinhTheoQuyCheMoiColumn>
	{
	}
	
	#endregion ViewKcqMonTinhTheoQuyCheMoiExpressionBuilder		
}

