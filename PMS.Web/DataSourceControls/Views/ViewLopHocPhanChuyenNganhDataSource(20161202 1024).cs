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
	/// Represents the DataRepository.ViewLopHocPhanChuyenNganhProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewLopHocPhanChuyenNganhDataSourceDesigner))]
	public class ViewLopHocPhanChuyenNganhDataSource : ReadOnlyDataSource<ViewLopHocPhanChuyenNganh>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLopHocPhanChuyenNganhDataSource class.
		/// </summary>
		public ViewLopHocPhanChuyenNganhDataSource() : base(new ViewLopHocPhanChuyenNganhService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewLopHocPhanChuyenNganhDataSourceView used by the ViewLopHocPhanChuyenNganhDataSource.
		/// </summary>
		protected ViewLopHocPhanChuyenNganhDataSourceView ViewLopHocPhanChuyenNganhView
		{
			get { return ( View as ViewLopHocPhanChuyenNganhDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewLopHocPhanChuyenNganhDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewLopHocPhanChuyenNganhSelectMethod SelectMethod
		{
			get
			{
				ViewLopHocPhanChuyenNganhSelectMethod selectMethod = ViewLopHocPhanChuyenNganhSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewLopHocPhanChuyenNganhSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewLopHocPhanChuyenNganhDataSourceView class that is to be
		/// used by the ViewLopHocPhanChuyenNganhDataSource.
		/// </summary>
		/// <returns>An instance of the ViewLopHocPhanChuyenNganhDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewLopHocPhanChuyenNganh, Object> GetNewDataSourceView()
		{
			return new ViewLopHocPhanChuyenNganhDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewLopHocPhanChuyenNganhDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewLopHocPhanChuyenNganhDataSourceView : ReadOnlyDataSourceView<ViewLopHocPhanChuyenNganh>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLopHocPhanChuyenNganhDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewLopHocPhanChuyenNganhDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewLopHocPhanChuyenNganhDataSourceView(ViewLopHocPhanChuyenNganhDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewLopHocPhanChuyenNganhDataSource ViewLopHocPhanChuyenNganhOwner
		{
			get { return Owner as ViewLopHocPhanChuyenNganhDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewLopHocPhanChuyenNganhSelectMethod SelectMethod
		{
			get { return ViewLopHocPhanChuyenNganhOwner.SelectMethod; }
			set { ViewLopHocPhanChuyenNganhOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewLopHocPhanChuyenNganhService ViewLopHocPhanChuyenNganhProvider
		{
			get { return Provider as ViewLopHocPhanChuyenNganhService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewLopHocPhanChuyenNganh> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewLopHocPhanChuyenNganh> results = null;
			// ViewLopHocPhanChuyenNganh item;
			count = 0;
			
			System.String sp3145_NamHoc;
			System.String sp3145_HocKy;

			switch ( SelectMethod )
			{
				case ViewLopHocPhanChuyenNganhSelectMethod.Get:
					results = ViewLopHocPhanChuyenNganhProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewLopHocPhanChuyenNganhSelectMethod.GetPaged:
					results = ViewLopHocPhanChuyenNganhProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewLopHocPhanChuyenNganhSelectMethod.GetAll:
					results = ViewLopHocPhanChuyenNganhProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewLopHocPhanChuyenNganhSelectMethod.Find:
					results = ViewLopHocPhanChuyenNganhProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewLopHocPhanChuyenNganhSelectMethod.GetByNamHocHocKy:
					sp3145_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3145_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewLopHocPhanChuyenNganhProvider.GetByNamHocHocKy(sp3145_NamHoc, sp3145_HocKy, StartIndex, PageSize);
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

	#region ViewLopHocPhanChuyenNganhSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewLopHocPhanChuyenNganhDataSource.SelectMethod property.
	/// </summary>
	public enum ViewLopHocPhanChuyenNganhSelectMethod
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
	
	#endregion ViewLopHocPhanChuyenNganhSelectMethod
	
	#region ViewLopHocPhanChuyenNganhDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewLopHocPhanChuyenNganhDataSource class.
	/// </summary>
	public class ViewLopHocPhanChuyenNganhDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewLopHocPhanChuyenNganh>
	{
		/// <summary>
		/// Initializes a new instance of the ViewLopHocPhanChuyenNganhDataSourceDesigner class.
		/// </summary>
		public ViewLopHocPhanChuyenNganhDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewLopHocPhanChuyenNganhSelectMethod SelectMethod
		{
			get { return ((ViewLopHocPhanChuyenNganhDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewLopHocPhanChuyenNganhDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewLopHocPhanChuyenNganhDataSourceActionList

	/// <summary>
	/// Supports the ViewLopHocPhanChuyenNganhDataSourceDesigner class.
	/// </summary>
	internal class ViewLopHocPhanChuyenNganhDataSourceActionList : DesignerActionList
	{
		private ViewLopHocPhanChuyenNganhDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewLopHocPhanChuyenNganhDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewLopHocPhanChuyenNganhDataSourceActionList(ViewLopHocPhanChuyenNganhDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewLopHocPhanChuyenNganhSelectMethod SelectMethod
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

	#endregion ViewLopHocPhanChuyenNganhDataSourceActionList

	#endregion ViewLopHocPhanChuyenNganhDataSourceDesigner

	#region ViewLopHocPhanChuyenNganhFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLopHocPhanChuyenNganh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLopHocPhanChuyenNganhFilter : SqlFilter<ViewLopHocPhanChuyenNganhColumn>
	{
	}

	#endregion ViewLopHocPhanChuyenNganhFilter

	#region ViewLopHocPhanChuyenNganhExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLopHocPhanChuyenNganh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLopHocPhanChuyenNganhExpressionBuilder : SqlExpressionBuilder<ViewLopHocPhanChuyenNganhColumn>
	{
	}
	
	#endregion ViewLopHocPhanChuyenNganhExpressionBuilder		
}

