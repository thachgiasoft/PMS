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
	/// Represents the DataRepository.ViewPhanNhomMonHocProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewPhanNhomMonHocDataSourceDesigner))]
	public class ViewPhanNhomMonHocDataSource : ReadOnlyDataSource<ViewPhanNhomMonHoc>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhanNhomMonHocDataSource class.
		/// </summary>
		public ViewPhanNhomMonHocDataSource() : base(new ViewPhanNhomMonHocService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewPhanNhomMonHocDataSourceView used by the ViewPhanNhomMonHocDataSource.
		/// </summary>
		protected ViewPhanNhomMonHocDataSourceView ViewPhanNhomMonHocView
		{
			get { return ( View as ViewPhanNhomMonHocDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewPhanNhomMonHocDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewPhanNhomMonHocSelectMethod SelectMethod
		{
			get
			{
				ViewPhanNhomMonHocSelectMethod selectMethod = ViewPhanNhomMonHocSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewPhanNhomMonHocSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewPhanNhomMonHocDataSourceView class that is to be
		/// used by the ViewPhanNhomMonHocDataSource.
		/// </summary>
		/// <returns>An instance of the ViewPhanNhomMonHocDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewPhanNhomMonHoc, Object> GetNewDataSourceView()
		{
			return new ViewPhanNhomMonHocDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewPhanNhomMonHocDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewPhanNhomMonHocDataSourceView : ReadOnlyDataSourceView<ViewPhanNhomMonHoc>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhanNhomMonHocDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewPhanNhomMonHocDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewPhanNhomMonHocDataSourceView(ViewPhanNhomMonHocDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewPhanNhomMonHocDataSource ViewPhanNhomMonHocOwner
		{
			get { return Owner as ViewPhanNhomMonHocDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewPhanNhomMonHocSelectMethod SelectMethod
		{
			get { return ViewPhanNhomMonHocOwner.SelectMethod; }
			set { ViewPhanNhomMonHocOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewPhanNhomMonHocService ViewPhanNhomMonHocProvider
		{
			get { return Provider as ViewPhanNhomMonHocService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewPhanNhomMonHoc> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewPhanNhomMonHoc> results = null;
			// ViewPhanNhomMonHoc item;
			count = 0;
			
			System.String sp1072_NamHoc;
			System.String sp1072_HocKy;

			switch ( SelectMethod )
			{
				case ViewPhanNhomMonHocSelectMethod.Get:
					results = ViewPhanNhomMonHocProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewPhanNhomMonHocSelectMethod.GetPaged:
					results = ViewPhanNhomMonHocProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewPhanNhomMonHocSelectMethod.GetAll:
					results = ViewPhanNhomMonHocProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewPhanNhomMonHocSelectMethod.Find:
					results = ViewPhanNhomMonHocProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewPhanNhomMonHocSelectMethod.GetByNamHocHocKy:
					sp1072_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp1072_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewPhanNhomMonHocProvider.GetByNamHocHocKy(sp1072_NamHoc, sp1072_HocKy, StartIndex, PageSize);
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

	#region ViewPhanNhomMonHocSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewPhanNhomMonHocDataSource.SelectMethod property.
	/// </summary>
	public enum ViewPhanNhomMonHocSelectMethod
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
	
	#endregion ViewPhanNhomMonHocSelectMethod
	
	#region ViewPhanNhomMonHocDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewPhanNhomMonHocDataSource class.
	/// </summary>
	public class ViewPhanNhomMonHocDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewPhanNhomMonHoc>
	{
		/// <summary>
		/// Initializes a new instance of the ViewPhanNhomMonHocDataSourceDesigner class.
		/// </summary>
		public ViewPhanNhomMonHocDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewPhanNhomMonHocSelectMethod SelectMethod
		{
			get { return ((ViewPhanNhomMonHocDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewPhanNhomMonHocDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewPhanNhomMonHocDataSourceActionList

	/// <summary>
	/// Supports the ViewPhanNhomMonHocDataSourceDesigner class.
	/// </summary>
	internal class ViewPhanNhomMonHocDataSourceActionList : DesignerActionList
	{
		private ViewPhanNhomMonHocDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewPhanNhomMonHocDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewPhanNhomMonHocDataSourceActionList(ViewPhanNhomMonHocDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewPhanNhomMonHocSelectMethod SelectMethod
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

	#endregion ViewPhanNhomMonHocDataSourceActionList

	#endregion ViewPhanNhomMonHocDataSourceDesigner

	#region ViewPhanNhomMonHocFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhanNhomMonHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhanNhomMonHocFilter : SqlFilter<ViewPhanNhomMonHocColumn>
	{
	}

	#endregion ViewPhanNhomMonHocFilter

	#region ViewPhanNhomMonHocExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhanNhomMonHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhanNhomMonHocExpressionBuilder : SqlExpressionBuilder<ViewPhanNhomMonHocColumn>
	{
	}
	
	#endregion ViewPhanNhomMonHocExpressionBuilder		
}

