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
	/// Represents the DataRepository.ViewPhuCapHanhChinhProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewPhuCapHanhChinhDataSourceDesigner))]
	public class ViewPhuCapHanhChinhDataSource : ReadOnlyDataSource<ViewPhuCapHanhChinh>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhuCapHanhChinhDataSource class.
		/// </summary>
		public ViewPhuCapHanhChinhDataSource() : base(new ViewPhuCapHanhChinhService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewPhuCapHanhChinhDataSourceView used by the ViewPhuCapHanhChinhDataSource.
		/// </summary>
		protected ViewPhuCapHanhChinhDataSourceView ViewPhuCapHanhChinhView
		{
			get { return ( View as ViewPhuCapHanhChinhDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewPhuCapHanhChinhDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewPhuCapHanhChinhSelectMethod SelectMethod
		{
			get
			{
				ViewPhuCapHanhChinhSelectMethod selectMethod = ViewPhuCapHanhChinhSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewPhuCapHanhChinhSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewPhuCapHanhChinhDataSourceView class that is to be
		/// used by the ViewPhuCapHanhChinhDataSource.
		/// </summary>
		/// <returns>An instance of the ViewPhuCapHanhChinhDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewPhuCapHanhChinh, Object> GetNewDataSourceView()
		{
			return new ViewPhuCapHanhChinhDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewPhuCapHanhChinhDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewPhuCapHanhChinhDataSourceView : ReadOnlyDataSourceView<ViewPhuCapHanhChinh>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhuCapHanhChinhDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewPhuCapHanhChinhDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewPhuCapHanhChinhDataSourceView(ViewPhuCapHanhChinhDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewPhuCapHanhChinhDataSource ViewPhuCapHanhChinhOwner
		{
			get { return Owner as ViewPhuCapHanhChinhDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewPhuCapHanhChinhSelectMethod SelectMethod
		{
			get { return ViewPhuCapHanhChinhOwner.SelectMethod; }
			set { ViewPhuCapHanhChinhOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewPhuCapHanhChinhService ViewPhuCapHanhChinhProvider
		{
			get { return Provider as ViewPhuCapHanhChinhService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewPhuCapHanhChinh> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewPhuCapHanhChinh> results = null;
			// ViewPhuCapHanhChinh item;
			count = 0;
			
			System.String sp1073_NamHoc;
			System.String sp1073_HocKy;

			switch ( SelectMethod )
			{
				case ViewPhuCapHanhChinhSelectMethod.Get:
					results = ViewPhuCapHanhChinhProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewPhuCapHanhChinhSelectMethod.GetPaged:
					results = ViewPhuCapHanhChinhProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewPhuCapHanhChinhSelectMethod.GetAll:
					results = ViewPhuCapHanhChinhProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewPhuCapHanhChinhSelectMethod.Find:
					results = ViewPhuCapHanhChinhProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewPhuCapHanhChinhSelectMethod.GetByNamHocHocKy:
					sp1073_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp1073_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewPhuCapHanhChinhProvider.GetByNamHocHocKy(sp1073_NamHoc, sp1073_HocKy, StartIndex, PageSize);
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

	#region ViewPhuCapHanhChinhSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewPhuCapHanhChinhDataSource.SelectMethod property.
	/// </summary>
	public enum ViewPhuCapHanhChinhSelectMethod
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
	
	#endregion ViewPhuCapHanhChinhSelectMethod
	
	#region ViewPhuCapHanhChinhDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewPhuCapHanhChinhDataSource class.
	/// </summary>
	public class ViewPhuCapHanhChinhDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewPhuCapHanhChinh>
	{
		/// <summary>
		/// Initializes a new instance of the ViewPhuCapHanhChinhDataSourceDesigner class.
		/// </summary>
		public ViewPhuCapHanhChinhDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewPhuCapHanhChinhSelectMethod SelectMethod
		{
			get { return ((ViewPhuCapHanhChinhDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewPhuCapHanhChinhDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewPhuCapHanhChinhDataSourceActionList

	/// <summary>
	/// Supports the ViewPhuCapHanhChinhDataSourceDesigner class.
	/// </summary>
	internal class ViewPhuCapHanhChinhDataSourceActionList : DesignerActionList
	{
		private ViewPhuCapHanhChinhDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewPhuCapHanhChinhDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewPhuCapHanhChinhDataSourceActionList(ViewPhuCapHanhChinhDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewPhuCapHanhChinhSelectMethod SelectMethod
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

	#endregion ViewPhuCapHanhChinhDataSourceActionList

	#endregion ViewPhuCapHanhChinhDataSourceDesigner

	#region ViewPhuCapHanhChinhFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhuCapHanhChinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhuCapHanhChinhFilter : SqlFilter<ViewPhuCapHanhChinhColumn>
	{
	}

	#endregion ViewPhuCapHanhChinhFilter

	#region ViewPhuCapHanhChinhExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhuCapHanhChinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhuCapHanhChinhExpressionBuilder : SqlExpressionBuilder<ViewPhuCapHanhChinhColumn>
	{
	}
	
	#endregion ViewPhuCapHanhChinhExpressionBuilder		
}

