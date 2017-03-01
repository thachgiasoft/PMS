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
	/// Represents the DataRepository.ViewXetDuyetDeCuongLuanVanCaoHocProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewXetDuyetDeCuongLuanVanCaoHocDataSourceDesigner))]
	public class ViewXetDuyetDeCuongLuanVanCaoHocDataSource : ReadOnlyDataSource<ViewXetDuyetDeCuongLuanVanCaoHoc>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewXetDuyetDeCuongLuanVanCaoHocDataSource class.
		/// </summary>
		public ViewXetDuyetDeCuongLuanVanCaoHocDataSource() : base(new ViewXetDuyetDeCuongLuanVanCaoHocService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewXetDuyetDeCuongLuanVanCaoHocDataSourceView used by the ViewXetDuyetDeCuongLuanVanCaoHocDataSource.
		/// </summary>
		protected ViewXetDuyetDeCuongLuanVanCaoHocDataSourceView ViewXetDuyetDeCuongLuanVanCaoHocView
		{
			get { return ( View as ViewXetDuyetDeCuongLuanVanCaoHocDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewXetDuyetDeCuongLuanVanCaoHocDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewXetDuyetDeCuongLuanVanCaoHocSelectMethod SelectMethod
		{
			get
			{
				ViewXetDuyetDeCuongLuanVanCaoHocSelectMethod selectMethod = ViewXetDuyetDeCuongLuanVanCaoHocSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewXetDuyetDeCuongLuanVanCaoHocSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewXetDuyetDeCuongLuanVanCaoHocDataSourceView class that is to be
		/// used by the ViewXetDuyetDeCuongLuanVanCaoHocDataSource.
		/// </summary>
		/// <returns>An instance of the ViewXetDuyetDeCuongLuanVanCaoHocDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewXetDuyetDeCuongLuanVanCaoHoc, Object> GetNewDataSourceView()
		{
			return new ViewXetDuyetDeCuongLuanVanCaoHocDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewXetDuyetDeCuongLuanVanCaoHocDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewXetDuyetDeCuongLuanVanCaoHocDataSourceView : ReadOnlyDataSourceView<ViewXetDuyetDeCuongLuanVanCaoHoc>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewXetDuyetDeCuongLuanVanCaoHocDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewXetDuyetDeCuongLuanVanCaoHocDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewXetDuyetDeCuongLuanVanCaoHocDataSourceView(ViewXetDuyetDeCuongLuanVanCaoHocDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewXetDuyetDeCuongLuanVanCaoHocDataSource ViewXetDuyetDeCuongLuanVanCaoHocOwner
		{
			get { return Owner as ViewXetDuyetDeCuongLuanVanCaoHocDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewXetDuyetDeCuongLuanVanCaoHocSelectMethod SelectMethod
		{
			get { return ViewXetDuyetDeCuongLuanVanCaoHocOwner.SelectMethod; }
			set { ViewXetDuyetDeCuongLuanVanCaoHocOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewXetDuyetDeCuongLuanVanCaoHocService ViewXetDuyetDeCuongLuanVanCaoHocProvider
		{
			get { return Provider as ViewXetDuyetDeCuongLuanVanCaoHocService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewXetDuyetDeCuongLuanVanCaoHoc> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewXetDuyetDeCuongLuanVanCaoHoc> results = null;
			// ViewXetDuyetDeCuongLuanVanCaoHoc item;
			count = 0;
			
			System.String sp3235_NamHoc;
			System.String sp3235_HocKy;

			switch ( SelectMethod )
			{
				case ViewXetDuyetDeCuongLuanVanCaoHocSelectMethod.Get:
					results = ViewXetDuyetDeCuongLuanVanCaoHocProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewXetDuyetDeCuongLuanVanCaoHocSelectMethod.GetPaged:
					results = ViewXetDuyetDeCuongLuanVanCaoHocProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewXetDuyetDeCuongLuanVanCaoHocSelectMethod.GetAll:
					results = ViewXetDuyetDeCuongLuanVanCaoHocProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewXetDuyetDeCuongLuanVanCaoHocSelectMethod.Find:
					results = ViewXetDuyetDeCuongLuanVanCaoHocProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewXetDuyetDeCuongLuanVanCaoHocSelectMethod.GetBYNamHocHocKy:
					sp3235_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3235_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewXetDuyetDeCuongLuanVanCaoHocProvider.GetBYNamHocHocKy(sp3235_NamHoc, sp3235_HocKy, StartIndex, PageSize);
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

	#region ViewXetDuyetDeCuongLuanVanCaoHocSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewXetDuyetDeCuongLuanVanCaoHocDataSource.SelectMethod property.
	/// </summary>
	public enum ViewXetDuyetDeCuongLuanVanCaoHocSelectMethod
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
		/// Represents the GetBYNamHocHocKy method.
		/// </summary>
		GetBYNamHocHocKy
	}
	
	#endregion ViewXetDuyetDeCuongLuanVanCaoHocSelectMethod
	
	#region ViewXetDuyetDeCuongLuanVanCaoHocDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewXetDuyetDeCuongLuanVanCaoHocDataSource class.
	/// </summary>
	public class ViewXetDuyetDeCuongLuanVanCaoHocDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewXetDuyetDeCuongLuanVanCaoHoc>
	{
		/// <summary>
		/// Initializes a new instance of the ViewXetDuyetDeCuongLuanVanCaoHocDataSourceDesigner class.
		/// </summary>
		public ViewXetDuyetDeCuongLuanVanCaoHocDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewXetDuyetDeCuongLuanVanCaoHocSelectMethod SelectMethod
		{
			get { return ((ViewXetDuyetDeCuongLuanVanCaoHocDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewXetDuyetDeCuongLuanVanCaoHocDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewXetDuyetDeCuongLuanVanCaoHocDataSourceActionList

	/// <summary>
	/// Supports the ViewXetDuyetDeCuongLuanVanCaoHocDataSourceDesigner class.
	/// </summary>
	internal class ViewXetDuyetDeCuongLuanVanCaoHocDataSourceActionList : DesignerActionList
	{
		private ViewXetDuyetDeCuongLuanVanCaoHocDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewXetDuyetDeCuongLuanVanCaoHocDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewXetDuyetDeCuongLuanVanCaoHocDataSourceActionList(ViewXetDuyetDeCuongLuanVanCaoHocDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewXetDuyetDeCuongLuanVanCaoHocSelectMethod SelectMethod
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

	#endregion ViewXetDuyetDeCuongLuanVanCaoHocDataSourceActionList

	#endregion ViewXetDuyetDeCuongLuanVanCaoHocDataSourceDesigner

	#region ViewXetDuyetDeCuongLuanVanCaoHocFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewXetDuyetDeCuongLuanVanCaoHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewXetDuyetDeCuongLuanVanCaoHocFilter : SqlFilter<ViewXetDuyetDeCuongLuanVanCaoHocColumn>
	{
	}

	#endregion ViewXetDuyetDeCuongLuanVanCaoHocFilter

	#region ViewXetDuyetDeCuongLuanVanCaoHocExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewXetDuyetDeCuongLuanVanCaoHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewXetDuyetDeCuongLuanVanCaoHocExpressionBuilder : SqlExpressionBuilder<ViewXetDuyetDeCuongLuanVanCaoHocColumn>
	{
	}
	
	#endregion ViewXetDuyetDeCuongLuanVanCaoHocExpressionBuilder		
}

