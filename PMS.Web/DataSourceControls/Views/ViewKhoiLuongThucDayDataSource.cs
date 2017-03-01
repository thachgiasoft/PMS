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
	/// Represents the DataRepository.ViewKhoiLuongThucDayProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewKhoiLuongThucDayDataSourceDesigner))]
	public class ViewKhoiLuongThucDayDataSource : ReadOnlyDataSource<ViewKhoiLuongThucDay>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongThucDayDataSource class.
		/// </summary>
		public ViewKhoiLuongThucDayDataSource() : base(new ViewKhoiLuongThucDayService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewKhoiLuongThucDayDataSourceView used by the ViewKhoiLuongThucDayDataSource.
		/// </summary>
		protected ViewKhoiLuongThucDayDataSourceView ViewKhoiLuongThucDayView
		{
			get { return ( View as ViewKhoiLuongThucDayDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewKhoiLuongThucDayDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewKhoiLuongThucDaySelectMethod SelectMethod
		{
			get
			{
				ViewKhoiLuongThucDaySelectMethod selectMethod = ViewKhoiLuongThucDaySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewKhoiLuongThucDaySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewKhoiLuongThucDayDataSourceView class that is to be
		/// used by the ViewKhoiLuongThucDayDataSource.
		/// </summary>
		/// <returns>An instance of the ViewKhoiLuongThucDayDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewKhoiLuongThucDay, Object> GetNewDataSourceView()
		{
			return new ViewKhoiLuongThucDayDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewKhoiLuongThucDayDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewKhoiLuongThucDayDataSourceView : ReadOnlyDataSourceView<ViewKhoiLuongThucDay>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongThucDayDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewKhoiLuongThucDayDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewKhoiLuongThucDayDataSourceView(ViewKhoiLuongThucDayDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewKhoiLuongThucDayDataSource ViewKhoiLuongThucDayOwner
		{
			get { return Owner as ViewKhoiLuongThucDayDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewKhoiLuongThucDaySelectMethod SelectMethod
		{
			get { return ViewKhoiLuongThucDayOwner.SelectMethod; }
			set { ViewKhoiLuongThucDayOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewKhoiLuongThucDayService ViewKhoiLuongThucDayProvider
		{
			get { return Provider as ViewKhoiLuongThucDayService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewKhoiLuongThucDay> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewKhoiLuongThucDay> results = null;
			// ViewKhoiLuongThucDay item;
			count = 0;
			
			System.String sp1025_NamHoc;
			System.String sp1025_HocKy;

			switch ( SelectMethod )
			{
				case ViewKhoiLuongThucDaySelectMethod.Get:
					results = ViewKhoiLuongThucDayProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewKhoiLuongThucDaySelectMethod.GetPaged:
					results = ViewKhoiLuongThucDayProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewKhoiLuongThucDaySelectMethod.GetAll:
					results = ViewKhoiLuongThucDayProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewKhoiLuongThucDaySelectMethod.Find:
					results = ViewKhoiLuongThucDayProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewKhoiLuongThucDaySelectMethod.GetByNamHocHocKy:
					sp1025_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp1025_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewKhoiLuongThucDayProvider.GetByNamHocHocKy(sp1025_NamHoc, sp1025_HocKy, StartIndex, PageSize);
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

	#region ViewKhoiLuongThucDaySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewKhoiLuongThucDayDataSource.SelectMethod property.
	/// </summary>
	public enum ViewKhoiLuongThucDaySelectMethod
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
	
	#endregion ViewKhoiLuongThucDaySelectMethod
	
	#region ViewKhoiLuongThucDayDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewKhoiLuongThucDayDataSource class.
	/// </summary>
	public class ViewKhoiLuongThucDayDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewKhoiLuongThucDay>
	{
		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongThucDayDataSourceDesigner class.
		/// </summary>
		public ViewKhoiLuongThucDayDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewKhoiLuongThucDaySelectMethod SelectMethod
		{
			get { return ((ViewKhoiLuongThucDayDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewKhoiLuongThucDayDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewKhoiLuongThucDayDataSourceActionList

	/// <summary>
	/// Supports the ViewKhoiLuongThucDayDataSourceDesigner class.
	/// </summary>
	internal class ViewKhoiLuongThucDayDataSourceActionList : DesignerActionList
	{
		private ViewKhoiLuongThucDayDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongThucDayDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewKhoiLuongThucDayDataSourceActionList(ViewKhoiLuongThucDayDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewKhoiLuongThucDaySelectMethod SelectMethod
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

	#endregion ViewKhoiLuongThucDayDataSourceActionList

	#endregion ViewKhoiLuongThucDayDataSourceDesigner

	#region ViewKhoiLuongThucDayFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoiLuongThucDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKhoiLuongThucDayFilter : SqlFilter<ViewKhoiLuongThucDayColumn>
	{
	}

	#endregion ViewKhoiLuongThucDayFilter

	#region ViewKhoiLuongThucDayExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoiLuongThucDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKhoiLuongThucDayExpressionBuilder : SqlExpressionBuilder<ViewKhoiLuongThucDayColumn>
	{
	}
	
	#endregion ViewKhoiLuongThucDayExpressionBuilder		
}

