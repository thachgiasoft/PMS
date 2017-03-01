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
	/// Represents the DataRepository.ViewTietNoKyTruocProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewTietNoKyTruocDataSourceDesigner))]
	public class ViewTietNoKyTruocDataSource : ReadOnlyDataSource<ViewTietNoKyTruoc>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTietNoKyTruocDataSource class.
		/// </summary>
		public ViewTietNoKyTruocDataSource() : base(new ViewTietNoKyTruocService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewTietNoKyTruocDataSourceView used by the ViewTietNoKyTruocDataSource.
		/// </summary>
		protected ViewTietNoKyTruocDataSourceView ViewTietNoKyTruocView
		{
			get { return ( View as ViewTietNoKyTruocDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewTietNoKyTruocDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewTietNoKyTruocSelectMethod SelectMethod
		{
			get
			{
				ViewTietNoKyTruocSelectMethod selectMethod = ViewTietNoKyTruocSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewTietNoKyTruocSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewTietNoKyTruocDataSourceView class that is to be
		/// used by the ViewTietNoKyTruocDataSource.
		/// </summary>
		/// <returns>An instance of the ViewTietNoKyTruocDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewTietNoKyTruoc, Object> GetNewDataSourceView()
		{
			return new ViewTietNoKyTruocDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewTietNoKyTruocDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewTietNoKyTruocDataSourceView : ReadOnlyDataSourceView<ViewTietNoKyTruoc>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTietNoKyTruocDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewTietNoKyTruocDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewTietNoKyTruocDataSourceView(ViewTietNoKyTruocDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewTietNoKyTruocDataSource ViewTietNoKyTruocOwner
		{
			get { return Owner as ViewTietNoKyTruocDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewTietNoKyTruocSelectMethod SelectMethod
		{
			get { return ViewTietNoKyTruocOwner.SelectMethod; }
			set { ViewTietNoKyTruocOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewTietNoKyTruocService ViewTietNoKyTruocProvider
		{
			get { return Provider as ViewTietNoKyTruocService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewTietNoKyTruoc> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewTietNoKyTruoc> results = null;
			// ViewTietNoKyTruoc item;
			count = 0;
			
			System.String sp1125_NamHoc;
			System.String sp1125_HocKy;

			switch ( SelectMethod )
			{
				case ViewTietNoKyTruocSelectMethod.Get:
					results = ViewTietNoKyTruocProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewTietNoKyTruocSelectMethod.GetPaged:
					results = ViewTietNoKyTruocProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewTietNoKyTruocSelectMethod.GetAll:
					results = ViewTietNoKyTruocProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewTietNoKyTruocSelectMethod.Find:
					results = ViewTietNoKyTruocProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewTietNoKyTruocSelectMethod.GetByNamHocHocKy:
					sp1125_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp1125_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewTietNoKyTruocProvider.GetByNamHocHocKy(sp1125_NamHoc, sp1125_HocKy, StartIndex, PageSize);
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

	#region ViewTietNoKyTruocSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewTietNoKyTruocDataSource.SelectMethod property.
	/// </summary>
	public enum ViewTietNoKyTruocSelectMethod
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
	
	#endregion ViewTietNoKyTruocSelectMethod
	
	#region ViewTietNoKyTruocDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewTietNoKyTruocDataSource class.
	/// </summary>
	public class ViewTietNoKyTruocDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewTietNoKyTruoc>
	{
		/// <summary>
		/// Initializes a new instance of the ViewTietNoKyTruocDataSourceDesigner class.
		/// </summary>
		public ViewTietNoKyTruocDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewTietNoKyTruocSelectMethod SelectMethod
		{
			get { return ((ViewTietNoKyTruocDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewTietNoKyTruocDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewTietNoKyTruocDataSourceActionList

	/// <summary>
	/// Supports the ViewTietNoKyTruocDataSourceDesigner class.
	/// </summary>
	internal class ViewTietNoKyTruocDataSourceActionList : DesignerActionList
	{
		private ViewTietNoKyTruocDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewTietNoKyTruocDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewTietNoKyTruocDataSourceActionList(ViewTietNoKyTruocDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewTietNoKyTruocSelectMethod SelectMethod
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

	#endregion ViewTietNoKyTruocDataSourceActionList

	#endregion ViewTietNoKyTruocDataSourceDesigner

	#region ViewTietNoKyTruocFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTietNoKyTruoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTietNoKyTruocFilter : SqlFilter<ViewTietNoKyTruocColumn>
	{
	}

	#endregion ViewTietNoKyTruocFilter

	#region ViewTietNoKyTruocExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTietNoKyTruoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTietNoKyTruocExpressionBuilder : SqlExpressionBuilder<ViewTietNoKyTruocColumn>
	{
	}
	
	#endregion ViewTietNoKyTruocExpressionBuilder		
}

