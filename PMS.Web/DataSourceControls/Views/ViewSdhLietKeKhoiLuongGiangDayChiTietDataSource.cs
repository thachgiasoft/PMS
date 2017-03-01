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
	/// Represents the DataRepository.ViewSdhLietKeKhoiLuongGiangDayChiTietProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewSdhLietKeKhoiLuongGiangDayChiTietDataSourceDesigner))]
	public class ViewSdhLietKeKhoiLuongGiangDayChiTietDataSource : ReadOnlyDataSource<ViewSdhLietKeKhoiLuongGiangDayChiTiet>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewSdhLietKeKhoiLuongGiangDayChiTietDataSource class.
		/// </summary>
		public ViewSdhLietKeKhoiLuongGiangDayChiTietDataSource() : base(new ViewSdhLietKeKhoiLuongGiangDayChiTietService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewSdhLietKeKhoiLuongGiangDayChiTietDataSourceView used by the ViewSdhLietKeKhoiLuongGiangDayChiTietDataSource.
		/// </summary>
		protected ViewSdhLietKeKhoiLuongGiangDayChiTietDataSourceView ViewSdhLietKeKhoiLuongGiangDayChiTietView
		{
			get { return ( View as ViewSdhLietKeKhoiLuongGiangDayChiTietDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewSdhLietKeKhoiLuongGiangDayChiTietDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewSdhLietKeKhoiLuongGiangDayChiTietSelectMethod SelectMethod
		{
			get
			{
				ViewSdhLietKeKhoiLuongGiangDayChiTietSelectMethod selectMethod = ViewSdhLietKeKhoiLuongGiangDayChiTietSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewSdhLietKeKhoiLuongGiangDayChiTietSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewSdhLietKeKhoiLuongGiangDayChiTietDataSourceView class that is to be
		/// used by the ViewSdhLietKeKhoiLuongGiangDayChiTietDataSource.
		/// </summary>
		/// <returns>An instance of the ViewSdhLietKeKhoiLuongGiangDayChiTietDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewSdhLietKeKhoiLuongGiangDayChiTiet, Object> GetNewDataSourceView()
		{
			return new ViewSdhLietKeKhoiLuongGiangDayChiTietDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewSdhLietKeKhoiLuongGiangDayChiTietDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewSdhLietKeKhoiLuongGiangDayChiTietDataSourceView : ReadOnlyDataSourceView<ViewSdhLietKeKhoiLuongGiangDayChiTiet>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewSdhLietKeKhoiLuongGiangDayChiTietDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewSdhLietKeKhoiLuongGiangDayChiTietDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewSdhLietKeKhoiLuongGiangDayChiTietDataSourceView(ViewSdhLietKeKhoiLuongGiangDayChiTietDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewSdhLietKeKhoiLuongGiangDayChiTietDataSource ViewSdhLietKeKhoiLuongGiangDayChiTietOwner
		{
			get { return Owner as ViewSdhLietKeKhoiLuongGiangDayChiTietDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewSdhLietKeKhoiLuongGiangDayChiTietSelectMethod SelectMethod
		{
			get { return ViewSdhLietKeKhoiLuongGiangDayChiTietOwner.SelectMethod; }
			set { ViewSdhLietKeKhoiLuongGiangDayChiTietOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewSdhLietKeKhoiLuongGiangDayChiTietService ViewSdhLietKeKhoiLuongGiangDayChiTietProvider
		{
			get { return Provider as ViewSdhLietKeKhoiLuongGiangDayChiTietService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewSdhLietKeKhoiLuongGiangDayChiTiet> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewSdhLietKeKhoiLuongGiangDayChiTiet> results = null;
			// ViewSdhLietKeKhoiLuongGiangDayChiTiet item;
			count = 0;
			
			System.String sp1078_NamHoc;
			System.String sp1078_HocKy;

			switch ( SelectMethod )
			{
				case ViewSdhLietKeKhoiLuongGiangDayChiTietSelectMethod.Get:
					results = ViewSdhLietKeKhoiLuongGiangDayChiTietProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewSdhLietKeKhoiLuongGiangDayChiTietSelectMethod.GetPaged:
					results = ViewSdhLietKeKhoiLuongGiangDayChiTietProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewSdhLietKeKhoiLuongGiangDayChiTietSelectMethod.GetAll:
					results = ViewSdhLietKeKhoiLuongGiangDayChiTietProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewSdhLietKeKhoiLuongGiangDayChiTietSelectMethod.Find:
					results = ViewSdhLietKeKhoiLuongGiangDayChiTietProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewSdhLietKeKhoiLuongGiangDayChiTietSelectMethod.GetByNamHocHocKy:
					sp1078_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp1078_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewSdhLietKeKhoiLuongGiangDayChiTietProvider.GetByNamHocHocKy(sp1078_NamHoc, sp1078_HocKy, StartIndex, PageSize);
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

	#region ViewSdhLietKeKhoiLuongGiangDayChiTietSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewSdhLietKeKhoiLuongGiangDayChiTietDataSource.SelectMethod property.
	/// </summary>
	public enum ViewSdhLietKeKhoiLuongGiangDayChiTietSelectMethod
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
	
	#endregion ViewSdhLietKeKhoiLuongGiangDayChiTietSelectMethod
	
	#region ViewSdhLietKeKhoiLuongGiangDayChiTietDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewSdhLietKeKhoiLuongGiangDayChiTietDataSource class.
	/// </summary>
	public class ViewSdhLietKeKhoiLuongGiangDayChiTietDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewSdhLietKeKhoiLuongGiangDayChiTiet>
	{
		/// <summary>
		/// Initializes a new instance of the ViewSdhLietKeKhoiLuongGiangDayChiTietDataSourceDesigner class.
		/// </summary>
		public ViewSdhLietKeKhoiLuongGiangDayChiTietDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewSdhLietKeKhoiLuongGiangDayChiTietSelectMethod SelectMethod
		{
			get { return ((ViewSdhLietKeKhoiLuongGiangDayChiTietDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewSdhLietKeKhoiLuongGiangDayChiTietDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewSdhLietKeKhoiLuongGiangDayChiTietDataSourceActionList

	/// <summary>
	/// Supports the ViewSdhLietKeKhoiLuongGiangDayChiTietDataSourceDesigner class.
	/// </summary>
	internal class ViewSdhLietKeKhoiLuongGiangDayChiTietDataSourceActionList : DesignerActionList
	{
		private ViewSdhLietKeKhoiLuongGiangDayChiTietDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewSdhLietKeKhoiLuongGiangDayChiTietDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewSdhLietKeKhoiLuongGiangDayChiTietDataSourceActionList(ViewSdhLietKeKhoiLuongGiangDayChiTietDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewSdhLietKeKhoiLuongGiangDayChiTietSelectMethod SelectMethod
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

	#endregion ViewSdhLietKeKhoiLuongGiangDayChiTietDataSourceActionList

	#endregion ViewSdhLietKeKhoiLuongGiangDayChiTietDataSourceDesigner

	#region ViewSdhLietKeKhoiLuongGiangDayChiTietFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewSdhLietKeKhoiLuongGiangDayChiTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewSdhLietKeKhoiLuongGiangDayChiTietFilter : SqlFilter<ViewSdhLietKeKhoiLuongGiangDayChiTietColumn>
	{
	}

	#endregion ViewSdhLietKeKhoiLuongGiangDayChiTietFilter

	#region ViewSdhLietKeKhoiLuongGiangDayChiTietExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewSdhLietKeKhoiLuongGiangDayChiTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewSdhLietKeKhoiLuongGiangDayChiTietExpressionBuilder : SqlExpressionBuilder<ViewSdhLietKeKhoiLuongGiangDayChiTietColumn>
	{
	}
	
	#endregion ViewSdhLietKeKhoiLuongGiangDayChiTietExpressionBuilder		
}

