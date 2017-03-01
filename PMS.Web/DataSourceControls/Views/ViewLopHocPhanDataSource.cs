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
	/// Represents the DataRepository.ViewLopHocPhanProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewLopHocPhanDataSourceDesigner))]
	public class ViewLopHocPhanDataSource : ReadOnlyDataSource<ViewLopHocPhan>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLopHocPhanDataSource class.
		/// </summary>
		public ViewLopHocPhanDataSource() : base(new ViewLopHocPhanService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewLopHocPhanDataSourceView used by the ViewLopHocPhanDataSource.
		/// </summary>
		protected ViewLopHocPhanDataSourceView ViewLopHocPhanView
		{
			get { return ( View as ViewLopHocPhanDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewLopHocPhanDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewLopHocPhanSelectMethod SelectMethod
		{
			get
			{
				ViewLopHocPhanSelectMethod selectMethod = ViewLopHocPhanSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewLopHocPhanSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewLopHocPhanDataSourceView class that is to be
		/// used by the ViewLopHocPhanDataSource.
		/// </summary>
		/// <returns>An instance of the ViewLopHocPhanDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewLopHocPhan, Object> GetNewDataSourceView()
		{
			return new ViewLopHocPhanDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewLopHocPhanDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewLopHocPhanDataSourceView : ReadOnlyDataSourceView<ViewLopHocPhan>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLopHocPhanDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewLopHocPhanDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewLopHocPhanDataSourceView(ViewLopHocPhanDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewLopHocPhanDataSource ViewLopHocPhanOwner
		{
			get { return Owner as ViewLopHocPhanDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewLopHocPhanSelectMethod SelectMethod
		{
			get { return ViewLopHocPhanOwner.SelectMethod; }
			set { ViewLopHocPhanOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewLopHocPhanService ViewLopHocPhanProvider
		{
			get { return Provider as ViewLopHocPhanService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewLopHocPhan> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewLopHocPhan> results = null;
			// ViewLopHocPhan item;
			count = 0;
			
			System.String sp1044_NamHoc;
			System.String sp1044_HocKy;
			System.String sp1045_NamHoc;
			System.String sp1045_HocKy;
			System.String sp1045_MaDonVi;

			switch ( SelectMethod )
			{
				case ViewLopHocPhanSelectMethod.Get:
					results = ViewLopHocPhanProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewLopHocPhanSelectMethod.GetPaged:
					results = ViewLopHocPhanProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewLopHocPhanSelectMethod.GetAll:
					results = ViewLopHocPhanProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewLopHocPhanSelectMethod.Find:
					results = ViewLopHocPhanProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewLopHocPhanSelectMethod.GetByNamHocHocKy:
					sp1044_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp1044_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewLopHocPhanProvider.GetByNamHocHocKy(sp1044_NamHoc, sp1044_HocKy, StartIndex, PageSize);
					break;
				case ViewLopHocPhanSelectMethod.GetByNamHocHocKyKhoaDonVi:
					sp1045_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp1045_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp1045_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					results = ViewLopHocPhanProvider.GetByNamHocHocKyKhoaDonVi(sp1045_NamHoc, sp1045_HocKy, sp1045_MaDonVi, StartIndex, PageSize);
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

	#region ViewLopHocPhanSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewLopHocPhanDataSource.SelectMethod property.
	/// </summary>
	public enum ViewLopHocPhanSelectMethod
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
		GetByNamHocHocKy,
		/// <summary>
		/// Represents the GetByNamHocHocKyKhoaDonVi method.
		/// </summary>
		GetByNamHocHocKyKhoaDonVi
	}
	
	#endregion ViewLopHocPhanSelectMethod
	
	#region ViewLopHocPhanDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewLopHocPhanDataSource class.
	/// </summary>
	public class ViewLopHocPhanDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewLopHocPhan>
	{
		/// <summary>
		/// Initializes a new instance of the ViewLopHocPhanDataSourceDesigner class.
		/// </summary>
		public ViewLopHocPhanDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewLopHocPhanSelectMethod SelectMethod
		{
			get { return ((ViewLopHocPhanDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewLopHocPhanDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewLopHocPhanDataSourceActionList

	/// <summary>
	/// Supports the ViewLopHocPhanDataSourceDesigner class.
	/// </summary>
	internal class ViewLopHocPhanDataSourceActionList : DesignerActionList
	{
		private ViewLopHocPhanDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewLopHocPhanDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewLopHocPhanDataSourceActionList(ViewLopHocPhanDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewLopHocPhanSelectMethod SelectMethod
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

	#endregion ViewLopHocPhanDataSourceActionList

	#endregion ViewLopHocPhanDataSourceDesigner

	#region ViewLopHocPhanFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLopHocPhanFilter : SqlFilter<ViewLopHocPhanColumn>
	{
	}

	#endregion ViewLopHocPhanFilter

	#region ViewLopHocPhanExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLopHocPhanExpressionBuilder : SqlExpressionBuilder<ViewLopHocPhanColumn>
	{
	}
	
	#endregion ViewLopHocPhanExpressionBuilder		
}

