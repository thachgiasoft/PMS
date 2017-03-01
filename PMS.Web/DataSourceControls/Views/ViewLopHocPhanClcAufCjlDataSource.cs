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
	/// Represents the DataRepository.ViewLopHocPhanClcAufCjlProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewLopHocPhanClcAufCjlDataSourceDesigner))]
	public class ViewLopHocPhanClcAufCjlDataSource : ReadOnlyDataSource<ViewLopHocPhanClcAufCjl>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLopHocPhanClcAufCjlDataSource class.
		/// </summary>
		public ViewLopHocPhanClcAufCjlDataSource() : base(new ViewLopHocPhanClcAufCjlService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewLopHocPhanClcAufCjlDataSourceView used by the ViewLopHocPhanClcAufCjlDataSource.
		/// </summary>
		protected ViewLopHocPhanClcAufCjlDataSourceView ViewLopHocPhanClcAufCjlView
		{
			get { return ( View as ViewLopHocPhanClcAufCjlDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewLopHocPhanClcAufCjlDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewLopHocPhanClcAufCjlSelectMethod SelectMethod
		{
			get
			{
				ViewLopHocPhanClcAufCjlSelectMethod selectMethod = ViewLopHocPhanClcAufCjlSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewLopHocPhanClcAufCjlSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewLopHocPhanClcAufCjlDataSourceView class that is to be
		/// used by the ViewLopHocPhanClcAufCjlDataSource.
		/// </summary>
		/// <returns>An instance of the ViewLopHocPhanClcAufCjlDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewLopHocPhanClcAufCjl, Object> GetNewDataSourceView()
		{
			return new ViewLopHocPhanClcAufCjlDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewLopHocPhanClcAufCjlDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewLopHocPhanClcAufCjlDataSourceView : ReadOnlyDataSourceView<ViewLopHocPhanClcAufCjl>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLopHocPhanClcAufCjlDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewLopHocPhanClcAufCjlDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewLopHocPhanClcAufCjlDataSourceView(ViewLopHocPhanClcAufCjlDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewLopHocPhanClcAufCjlDataSource ViewLopHocPhanClcAufCjlOwner
		{
			get { return Owner as ViewLopHocPhanClcAufCjlDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewLopHocPhanClcAufCjlSelectMethod SelectMethod
		{
			get { return ViewLopHocPhanClcAufCjlOwner.SelectMethod; }
			set { ViewLopHocPhanClcAufCjlOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewLopHocPhanClcAufCjlService ViewLopHocPhanClcAufCjlProvider
		{
			get { return Provider as ViewLopHocPhanClcAufCjlService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewLopHocPhanClcAufCjl> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewLopHocPhanClcAufCjl> results = null;
			// ViewLopHocPhanClcAufCjl item;
			count = 0;
			
			System.String sp1043_NamHoc;
			System.String sp1043_HocKy;

			switch ( SelectMethod )
			{
				case ViewLopHocPhanClcAufCjlSelectMethod.Get:
					results = ViewLopHocPhanClcAufCjlProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewLopHocPhanClcAufCjlSelectMethod.GetPaged:
					results = ViewLopHocPhanClcAufCjlProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewLopHocPhanClcAufCjlSelectMethod.GetAll:
					results = ViewLopHocPhanClcAufCjlProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewLopHocPhanClcAufCjlSelectMethod.Find:
					results = ViewLopHocPhanClcAufCjlProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewLopHocPhanClcAufCjlSelectMethod.GetByNamHocHocKy:
					sp1043_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp1043_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewLopHocPhanClcAufCjlProvider.GetByNamHocHocKy(sp1043_NamHoc, sp1043_HocKy, StartIndex, PageSize);
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

	#region ViewLopHocPhanClcAufCjlSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewLopHocPhanClcAufCjlDataSource.SelectMethod property.
	/// </summary>
	public enum ViewLopHocPhanClcAufCjlSelectMethod
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
	
	#endregion ViewLopHocPhanClcAufCjlSelectMethod
	
	#region ViewLopHocPhanClcAufCjlDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewLopHocPhanClcAufCjlDataSource class.
	/// </summary>
	public class ViewLopHocPhanClcAufCjlDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewLopHocPhanClcAufCjl>
	{
		/// <summary>
		/// Initializes a new instance of the ViewLopHocPhanClcAufCjlDataSourceDesigner class.
		/// </summary>
		public ViewLopHocPhanClcAufCjlDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewLopHocPhanClcAufCjlSelectMethod SelectMethod
		{
			get { return ((ViewLopHocPhanClcAufCjlDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewLopHocPhanClcAufCjlDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewLopHocPhanClcAufCjlDataSourceActionList

	/// <summary>
	/// Supports the ViewLopHocPhanClcAufCjlDataSourceDesigner class.
	/// </summary>
	internal class ViewLopHocPhanClcAufCjlDataSourceActionList : DesignerActionList
	{
		private ViewLopHocPhanClcAufCjlDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewLopHocPhanClcAufCjlDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewLopHocPhanClcAufCjlDataSourceActionList(ViewLopHocPhanClcAufCjlDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewLopHocPhanClcAufCjlSelectMethod SelectMethod
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

	#endregion ViewLopHocPhanClcAufCjlDataSourceActionList

	#endregion ViewLopHocPhanClcAufCjlDataSourceDesigner

	#region ViewLopHocPhanClcAufCjlFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLopHocPhanClcAufCjl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLopHocPhanClcAufCjlFilter : SqlFilter<ViewLopHocPhanClcAufCjlColumn>
	{
	}

	#endregion ViewLopHocPhanClcAufCjlFilter

	#region ViewLopHocPhanClcAufCjlExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLopHocPhanClcAufCjl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLopHocPhanClcAufCjlExpressionBuilder : SqlExpressionBuilder<ViewLopHocPhanClcAufCjlColumn>
	{
	}
	
	#endregion ViewLopHocPhanClcAufCjlExpressionBuilder		
}

