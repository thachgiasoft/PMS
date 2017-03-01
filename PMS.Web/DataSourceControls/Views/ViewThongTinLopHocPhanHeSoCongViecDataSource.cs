﻿#region Using Directives
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
	/// Represents the DataRepository.ViewThongTinLopHocPhanHeSoCongViecProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewThongTinLopHocPhanHeSoCongViecDataSourceDesigner))]
	public class ViewThongTinLopHocPhanHeSoCongViecDataSource : ReadOnlyDataSource<ViewThongTinLopHocPhanHeSoCongViec>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongTinLopHocPhanHeSoCongViecDataSource class.
		/// </summary>
		public ViewThongTinLopHocPhanHeSoCongViecDataSource() : base(new ViewThongTinLopHocPhanHeSoCongViecService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewThongTinLopHocPhanHeSoCongViecDataSourceView used by the ViewThongTinLopHocPhanHeSoCongViecDataSource.
		/// </summary>
		protected ViewThongTinLopHocPhanHeSoCongViecDataSourceView ViewThongTinLopHocPhanHeSoCongViecView
		{
			get { return ( View as ViewThongTinLopHocPhanHeSoCongViecDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewThongTinLopHocPhanHeSoCongViecDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewThongTinLopHocPhanHeSoCongViecSelectMethod SelectMethod
		{
			get
			{
				ViewThongTinLopHocPhanHeSoCongViecSelectMethod selectMethod = ViewThongTinLopHocPhanHeSoCongViecSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewThongTinLopHocPhanHeSoCongViecSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewThongTinLopHocPhanHeSoCongViecDataSourceView class that is to be
		/// used by the ViewThongTinLopHocPhanHeSoCongViecDataSource.
		/// </summary>
		/// <returns>An instance of the ViewThongTinLopHocPhanHeSoCongViecDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewThongTinLopHocPhanHeSoCongViec, Object> GetNewDataSourceView()
		{
			return new ViewThongTinLopHocPhanHeSoCongViecDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewThongTinLopHocPhanHeSoCongViecDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewThongTinLopHocPhanHeSoCongViecDataSourceView : ReadOnlyDataSourceView<ViewThongTinLopHocPhanHeSoCongViec>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongTinLopHocPhanHeSoCongViecDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewThongTinLopHocPhanHeSoCongViecDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewThongTinLopHocPhanHeSoCongViecDataSourceView(ViewThongTinLopHocPhanHeSoCongViecDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewThongTinLopHocPhanHeSoCongViecDataSource ViewThongTinLopHocPhanHeSoCongViecOwner
		{
			get { return Owner as ViewThongTinLopHocPhanHeSoCongViecDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewThongTinLopHocPhanHeSoCongViecSelectMethod SelectMethod
		{
			get { return ViewThongTinLopHocPhanHeSoCongViecOwner.SelectMethod; }
			set { ViewThongTinLopHocPhanHeSoCongViecOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewThongTinLopHocPhanHeSoCongViecService ViewThongTinLopHocPhanHeSoCongViecProvider
		{
			get { return Provider as ViewThongTinLopHocPhanHeSoCongViecService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewThongTinLopHocPhanHeSoCongViec> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewThongTinLopHocPhanHeSoCongViec> results = null;
			// ViewThongTinLopHocPhanHeSoCongViec item;
			count = 0;
			
			System.String sp1117_NamHoc;
			System.String sp1117_HocKy;

			switch ( SelectMethod )
			{
				case ViewThongTinLopHocPhanHeSoCongViecSelectMethod.Get:
					results = ViewThongTinLopHocPhanHeSoCongViecProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewThongTinLopHocPhanHeSoCongViecSelectMethod.GetPaged:
					results = ViewThongTinLopHocPhanHeSoCongViecProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewThongTinLopHocPhanHeSoCongViecSelectMethod.GetAll:
					results = ViewThongTinLopHocPhanHeSoCongViecProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewThongTinLopHocPhanHeSoCongViecSelectMethod.Find:
					results = ViewThongTinLopHocPhanHeSoCongViecProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewThongTinLopHocPhanHeSoCongViecSelectMethod.GetByNamHocHocKy:
					sp1117_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp1117_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewThongTinLopHocPhanHeSoCongViecProvider.GetByNamHocHocKy(sp1117_NamHoc, sp1117_HocKy, StartIndex, PageSize);
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

	#region ViewThongTinLopHocPhanHeSoCongViecSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewThongTinLopHocPhanHeSoCongViecDataSource.SelectMethod property.
	/// </summary>
	public enum ViewThongTinLopHocPhanHeSoCongViecSelectMethod
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
	
	#endregion ViewThongTinLopHocPhanHeSoCongViecSelectMethod
	
	#region ViewThongTinLopHocPhanHeSoCongViecDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewThongTinLopHocPhanHeSoCongViecDataSource class.
	/// </summary>
	public class ViewThongTinLopHocPhanHeSoCongViecDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewThongTinLopHocPhanHeSoCongViec>
	{
		/// <summary>
		/// Initializes a new instance of the ViewThongTinLopHocPhanHeSoCongViecDataSourceDesigner class.
		/// </summary>
		public ViewThongTinLopHocPhanHeSoCongViecDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewThongTinLopHocPhanHeSoCongViecSelectMethod SelectMethod
		{
			get { return ((ViewThongTinLopHocPhanHeSoCongViecDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewThongTinLopHocPhanHeSoCongViecDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewThongTinLopHocPhanHeSoCongViecDataSourceActionList

	/// <summary>
	/// Supports the ViewThongTinLopHocPhanHeSoCongViecDataSourceDesigner class.
	/// </summary>
	internal class ViewThongTinLopHocPhanHeSoCongViecDataSourceActionList : DesignerActionList
	{
		private ViewThongTinLopHocPhanHeSoCongViecDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewThongTinLopHocPhanHeSoCongViecDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewThongTinLopHocPhanHeSoCongViecDataSourceActionList(ViewThongTinLopHocPhanHeSoCongViecDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewThongTinLopHocPhanHeSoCongViecSelectMethod SelectMethod
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

	#endregion ViewThongTinLopHocPhanHeSoCongViecDataSourceActionList

	#endregion ViewThongTinLopHocPhanHeSoCongViecDataSourceDesigner

	#region ViewThongTinLopHocPhanHeSoCongViecFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongTinLopHocPhanHeSoCongViec"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThongTinLopHocPhanHeSoCongViecFilter : SqlFilter<ViewThongTinLopHocPhanHeSoCongViecColumn>
	{
	}

	#endregion ViewThongTinLopHocPhanHeSoCongViecFilter

	#region ViewThongTinLopHocPhanHeSoCongViecExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongTinLopHocPhanHeSoCongViec"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThongTinLopHocPhanHeSoCongViecExpressionBuilder : SqlExpressionBuilder<ViewThongTinLopHocPhanHeSoCongViecColumn>
	{
	}
	
	#endregion ViewThongTinLopHocPhanHeSoCongViecExpressionBuilder		
}
